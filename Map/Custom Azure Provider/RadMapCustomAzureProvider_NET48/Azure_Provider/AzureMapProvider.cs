using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map.Bing;

namespace RadMapCustomAzureProvider_NET48.Azure_Provider
{
    public class AzureMapProvider : IMapTileProvider, IMapProvider, IMapSearchProvider
    {

        private const string ImageryMetadataServiceUri = "https://atlas.microsoft.com/map/tile?subscription-key={AzureKey}&api-version=2024-04-01&tilesetId={tilesetId}&zoom={zoomLevel}&x={tileMatrixX}&y={tileMatrixY}&tileSize=256";
        private const string SearchServiceUri = "https://atlas.microsoft.com/search/address/json?api-version=1.0&query={query}&subscription-key={subscriptionKey}";

        private IMapCacheProvider cacheProvider;
        private IMapTileDownloader tileDownloader;

        private int server = 0;

        private string id;
        private Size tileSize = new Size(256, 256);
        private int minZoomLevel = 0;
        private int maxZoomLevel = 19;
        private string azureAPIKey;

        protected Dictionary<string, TileInfo> tileMatrix = new Dictionary<string, TileInfo>();
        protected Dictionary<string, List<TileInfo>> cacheLoadReference = new Dictionary<string, List<TileInfo>>();
        protected object lockObj = new object();

        private AzureTileSet tileSetId;

        public AzureMapProvider()
        {
            var downloader = new MapTileDownloader();
            downloader.WebHeaders["Subscription-Key"] = AzureAPIKey;
            this.TileDownloader = downloader;
        }
        public string AzureAPIKey
        {
            get { return azureAPIKey; }
            set { azureAPIKey = value; }
        }

        public bool Initialized { get; protected set; }

        public Uri GetTile(int tileMatrixX, int tileMatrixY, int zoomLevel)
        {
            string uriString = ImageryMetadataServiceUri;

            uriString = uriString.Replace("{AzureKey}", AzureAPIKey);
            uriString = uriString.Replace("{tilesetId}", AzureTileSetIdProvider.TileSetIdMap[this.TileSetID.ToString()]);
            uriString = uriString.Replace("{zoomLevel}", zoomLevel.ToString());
            uriString = uriString.Replace("{tileMatrixX}", tileMatrixX.ToString());
            uriString = uriString.Replace("{tileMatrixY}", tileMatrixY.ToString());

            return new Uri(uriString);
        }

        protected virtual string GetCacheKey(int tileX, int tileY, int zoomLevel)
        {
            return "Tile_" + tileX + "_" + tileY + "_" + zoomLevel + "_" + AzureTileSetIdProvider.TileSetIdMap[this.TileSetID.ToString()] + ".png";
        }

        protected virtual void GetTileInfoImage(TileInfo tileInfo)
        {
            if (this.EnableCaching && this.CacheProvider != null)
            {
                lock (this.lockObj)
                {
                    string key = this.GetCacheKey(tileInfo.TileX, tileInfo.TileY, tileInfo.ZoomLevel);

                    if (!this.cacheLoadReference.ContainsKey(key))
                    {
                        this.cacheLoadReference.Add(key, new List<TileInfo>() { tileInfo });
                        this.CacheProvider.LoadAsync(key, new Action<string, byte[]>(this.OnFileLoadAsyncComplete));
                    }
                    else
                    {
                        this.cacheLoadReference[key].Add(tileInfo);
                        this.CacheProvider.LoadAsync(key, new Action<string, byte[]>(this.OnFileLoadAsyncComplete));
                    }
                }

                return;
            }

            Uri tileUri = this.GetTile(tileInfo.TileX, tileInfo.TileY, tileInfo.ZoomLevel);
            this.TileDownloader.BeginDownloadTile(tileUri, tileInfo);
        }

        protected virtual void OnFileLoadAsyncComplete(string fileName, byte[] content)
        {
            lock (this.lockObj)
            {
                List<TileInfo> tileInfos = this.cacheLoadReference[fileName];
                TileInfo tileInfo = tileInfos[0];

                if (tileInfos.Count > 0)
                {
                    tileInfos.Remove(tileInfo);

                    if (tileInfos.Count == 0)
                    {
                        this.cacheLoadReference.Remove(fileName);
                    }
                }

                if (content != null)
                {
                    tileInfo.Content = content;
                    this.OnProviderUpdated(new TileInfoEventArgs(tileInfo));
                }
                else
                {
                    Uri tileUri = this.GetTile(tileInfo.TileX, tileInfo.TileY, tileInfo.ZoomLevel);
                    this.TileDownloader.BeginDownloadTile(tileUri, tileInfo);
                }
            }
        }

        protected virtual void OnTileDownloadComplete(object sender, TileInfoEventArgs e)
        {
            if (this.EnableCaching && this.CacheProvider != null && e.TileInfo.Content != null)
            {
                this.CacheProvider.Save(this.GetCacheKey(e.TileInfo.TileX, e.TileInfo.TileY, e.TileInfo.ZoomLevel), DateTime.MaxValue, e.TileInfo.Content);
            }

            int index = -1;

            foreach (KeyValuePair<string, TileInfo> tile in this.tileMatrix)
            {
                index = tile.Key.IndexOf("wraparound");

                if (index > 0)
                {
                    string quadKey = tile.Key.Substring(0, index);

                    if (quadKey == e.TileInfo.Quadkey)
                    {
                        tile.Value.Content = e.TileInfo.Content;
                        tile.Value.Image = e.TileInfo.Image;
                    }
                }
            }

            this.OnProviderUpdated(e);
        }

        #region IMapTileProvider
        ///// <summary>
        ///// Gets or sets the imagery set.
        ///// </summary>
        ///// <value>The imagery set.</value>
        public AzureTileSet TileSetID
        {
            get { return tileSetId; }
            set
            {
                this.tileSetId = value;

                if (this.Initialized)
                {
                    this.Initialize();
                }
            }
        }

        public Image GetTileImage(int tileMatrixX, int tileMatrixY, int zoomLevel)
        {
            Uri tileUri = this.GetTile(tileMatrixX, tileMatrixY, zoomLevel);
            string key = this.GetCacheKey(tileMatrixX, tileMatrixY, zoomLevel);

            MemoryStream file = this.CacheProvider.Load(key) as MemoryStream;

            if (file == null)
            {
                WebClient client = new WebClient();
                byte[] content = client.DownloadData(tileUri);

                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(content, 0, content.Length);
                    Image img = Image.FromStream(ms);

                    return img;
                }
            }

            return Image.FromStream(file);
        }

        public Size TileSize
        {
            get { return this.tileSize; }
        }

        public bool EnableCaching { get; set; }

        public IMapCacheProvider CacheProvider
        {
            get { return cacheProvider; }
            set { this.cacheProvider = value; }
        }

        public IMapTileDownloader TileDownloader
        {
            get { return tileDownloader; }
            set
            {
                if (this.tileDownloader != null)
                {
                    this.tileDownloader.TileDownloadComplete -= this.OnTileDownloadComplete;
                }

                this.tileDownloader = value;

                if (this.tileDownloader != null)
                {
                    this.tileDownloader.TileDownloadComplete += this.OnTileDownloadComplete;
                }
            }
        }

        #endregion

        #region IMapProvider

        public IEnumerable<MapVisualElement> GetContent(IMapViewport viewport)
        {
            if (!this.Initialized)
            {
                this.Initialize();

                yield break;
            }

            Dictionary<string, TileInfo>.Enumerator enumerator = this.tileMatrix.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.Value.Image != null)
                {
                    yield return RadMapElement.VisualElementFactory.CreateTile(enumerator.Current.Value.Image, enumerator.Current.Value.DrawRect);
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        if (enumerator.Current.Value.Content != null)
                        {
                            ms.Write(enumerator.Current.Value.Content, 0, enumerator.Current.Value.Content.Length);
                            Bitmap bmp = new Bitmap(ms);
                            enumerator.Current.Value.Image = new Bitmap(bmp);

                            yield return RadMapElement.VisualElementFactory.CreateTile(enumerator.Current.Value.Image, enumerator.Current.Value.DrawRect);
                        }
                    }
                }
            }
        }

        public virtual List<MapViewInfo> GetSupportedViews()
        {
            List<MapViewInfo> result = new List<MapViewInfo>();

            foreach (AzureTileSet tileSet in Enum.GetValues(typeof(AzureTileSet)))
            {
                MapViewInfo view = new MapViewInfo(tileSet.ToString(), false, false, this.TileSetID == tileSet);
                result.Add(view);
            }

            return result;
        }

        public string Id
        {
            get { return this.id; }
        }

        public int MaxZoomLevel
        {
            get { return this.maxZoomLevel; }
            set { this.maxZoomLevel = value; }
        }

        public int MinZoomLevel
        {
            get { return this.minZoomLevel; }
            set { this.minZoomLevel = value; }
        }

        public event EventHandler InitializationComplete;

        protected virtual void OnInitializationComplete(EventArgs e)
        {
            if (this.InitializationComplete != null)
            {
                this.InitializationComplete(this, e);
            }
        }

        public event InitializationErrorEventHandler InitializationError;

        public void Initialize()
        {
            this.tileMatrix.Clear();

            this.Initialized = true;
            this.OnInitializationComplete(EventArgs.Empty);
        }

        public event EventHandler ProviderUpdated;

        protected virtual void OnProviderUpdated(EventArgs e)
        {
            if (this.ProviderUpdated != null)
            {
                this.ProviderUpdated(this, e);
            }
        }

        public void SetView(MapViewInfo view)
        {
            if (Enum.TryParse(view.Name, out AzureTileSet tileSet))
            {
                this.TileSetID = tileSet;
            }
            else
            {
                throw new ArgumentException($"Unsupported view name: {view.Name}");
            }
        }

        public void ViewportChanged(IMapViewport viewport, ViewportChangeAction action)
        {
            if (!this.Initialized)
            {
                this.Initialize();

                return;
            }

            int numberOfTilesForCurrentLevel = 2 << (viewport.ZoomLevel - 1);
            int numOfVisibleTilesX = (int)Math.Ceiling((double)(viewport.ViewportInPixels.Width) / this.TileSize.Width) + 2;
            int numOfVisibleTilesY = (int)Math.Ceiling((double)(viewport.ViewportInPixels.Height) / this.TileSize.Height) + 2;
            numOfVisibleTilesY = Math.Min(numOfVisibleTilesY, numberOfTilesForCurrentLevel);

            Point topLeftTile = MapTileSystemHelper.PixelXYToTileXY(viewport.PanOffset.Width > 0 ? 0 : -viewport.PanOffset.Width, viewport.PanOffset.Height > 0 ? 0 : -viewport.PanOffset.Height);

            Dictionary<TileInfo, bool> newTileMatrix = new Dictionary<TileInfo, bool>();
            int startX = (int)viewport.PanOffset.Width % this.TileSize.Width;
            int startY = (int)viewport.PanOffset.Height % this.TileSize.Height;

            if (startX > 0)
            {
                startX -= this.TileSize.Width;
            }

            for (int i = 0; i < numOfVisibleTilesY; i++)
            {
                for (int j = 0; j < numOfVisibleTilesX; j++)
                {
                    int x = startX + j * this.TileSize.Width;
                    int y = startY + i * this.TileSize.Height;

                    if (viewport.ViewportInPixels.Height > numberOfTilesForCurrentLevel * this.TileSize.Height)
                    {
                        y = (int)((viewport.ViewportInPixels.Height - numberOfTilesForCurrentLevel * this.TileSize.Height) / 2);
                        y += i * this.TileSize.Height;
                    }

                    if (x > viewport.ViewportInPixels.Width || y > viewport.ViewportInPixels.Height)
                    {
                        continue;
                    }

                    int tileX = (topLeftTile.X + j) % numberOfTilesForCurrentLevel;
                    int tileY = (topLeftTile.Y + i) % numberOfTilesForCurrentLevel;

                    if (tileX < 0)
                    {
                        tileX += numberOfTilesForCurrentLevel;
                    }

                    TileInfo tileInfo;

                    string key = MapTileSystemHelper.TileXYToQuadKey(tileX, tileY, viewport.ZoomLevel);

                    if (this.tileMatrix.ContainsKey(key))
                    {
                        tileInfo = this.tileMatrix[key];
                        tileInfo.DrawRect = new Rectangle(new Point(x, y), this.TileSize);
                        tileMatrix.Remove(key);
                    }
                    else
                    {
                        tileInfo = new TileInfo(tileX, tileY, viewport.ZoomLevel, null, new Rectangle(new Point(x, y), this.TileSize));
                    }

                    if (tileInfo.Content == null)
                    {
                        this.GetTileInfoImage(tileInfo);
                    }

                    newTileMatrix.Add(tileInfo, false);
                }
            }

            Dictionary<string, TileInfo>.Enumerator enumerator = this.tileMatrix.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.Value.Content == null)
                {
                    this.TileDownloader.CancelTileDownload(enumerator.Current.Value);
                }
            }

            this.tileMatrix.Clear();

            foreach (TileInfo tileInfo in newTileMatrix.Keys)
            {
                string key = tileInfo.Quadkey;
                string keyAddition = "";
                int wraparoundCount = 0;

                while (this.tileMatrix.ContainsKey(key + keyAddition))
                {
                    wraparoundCount++;
                    keyAddition = "wraparound" + wraparoundCount;
                }

                this.tileMatrix.Add(key + keyAddition, tileInfo);
            }
        }

        public object Clone()
        {
            AzureMapProvider clone = new AzureMapProvider();
            clone.id = this.id;
            clone.tileSetId = this.tileSetId;
            clone.EnableCaching = this.EnableCaching;
            clone.cacheProvider = this.cacheProvider;
            clone.tileDownloader = this.tileDownloader;
            clone.tileSize = this.tileSize;
            clone.minZoomLevel = this.minZoomLevel;
            clone.maxZoomLevel = this.maxZoomLevel;
            clone.Initialized = this.Initialized;

            return clone;
        }

        #endregion

        #region IMapSearchProvider members

        public void SearchAsync(SearchRequest request)
        {
            Uri uri = this.BuildSearchRequestUri(request);

            try
            {
                WebClient client = new WebClient();
                client.DownloadStringCompleted += this.OnSearchRequestCompleted;
                client.DownloadStringAsync(uri, request.UserData);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Search Service Exception: {0}", ex.Message), ex);
            }
        }

        protected virtual void OnSearchRequestCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            WebClient client = sender as WebClient;
            client.DownloadStringCompleted -= this.OnSearchRequestCompleted;

            if (e.Error == null)
            {
                try
                {
                    //Response response;
                    AzureResponse azureResponse;
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Response));
                    // The Bing rest service appears to handle the culture if it is passed in the request.
                    // The response, however, misses information about the encoding of the result string.
                    // We will assume that it is iso-8859-1 or windows-1252, they will properly display
                    // most of the European languages - letters like ä, ö, ü, š, ç, é will be readable,
                    // the latter also handles Chinese. If we fail to deserialize the response, we will
                    // fallback to UTF-8.
                    DataContractJsonSerializer azureSerializer = new DataContractJsonSerializer(typeof(AzureResponse));
                    try
                    {

                        using (MemoryStream stream = new MemoryStream(Encoding.GetEncoding("iso-8859-1").GetBytes(e.Result)))
                        {

                            azureResponse = azureSerializer.ReadObject(stream) as AzureResponse;
                        }
                    }
                    catch (Exception)
                    {

                        try
                        {
                            using (MemoryStream stream = new MemoryStream(Encoding.GetEncoding("windows-1252").GetBytes(e.Result)))
                            {
                                azureResponse = azureSerializer.ReadObject(stream) as AzureResponse;
                            }
                        }
                        catch
                        {
                            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(e.Result)))
                            {
                                azureResponse = azureSerializer.ReadObject(stream) as AzureResponse;
                            }
                        }
                    }

                    if (azureResponse != null)
                    {
                        Location[] locations = new Location[azureResponse.Results.Length];

                        for (int i = 0; i < locations.Length; i++)
                        {
                            double lat = double.Parse(azureResponse.Results[i].Position.Latitude, System.Globalization.CultureInfo.InvariantCulture);
                            double lon = double.Parse(azureResponse.Results[i].Position.Longitude, System.Globalization.CultureInfo.InvariantCulture);
                            var bingPoint = new BingPointG() { Coordinates = new double[2] { lat, lon } };
                            locations[i] = new Location() { Point = bingPoint, Address = new Telerik.WinControls.UI.Map.Bing.Address() { FormattedAddress = azureResponse.Results[i].Address.FreeformAddress } };
                        }

                        this.OnSearchCompleted(new SearchCompletedEventArgs(locations, e.UserState));
                    }
                    else
                    {
                        this.OnSearchError(new SearchErrorEventArgs(new WebException("The remote server returned an error: (404) Not Found.")));
                    }
                }
                catch (SerializationException) { }
            }
            else
            {
                this.OnSearchError(new SearchErrorEventArgs(e.Error));
            }
        }

        protected virtual Uri BuildSearchRequestUri(SearchRequest request)
        {
            string searchURI = SearchServiceUri;

            searchURI = searchURI.Replace("{query}", request.Query);
            searchURI = searchURI.Replace("{subscriptionKey}", AzureAPIKey);
            return new Uri(searchURI);
        }

        public event EventHandler<SearchCompletedEventArgs> SearchCompleted;

        protected virtual void OnSearchCompleted(SearchCompletedEventArgs e)
        {
            if (this.SearchCompleted != null)
            {
                this.SearchCompleted(this, e);
            }
        }

        public event EventHandler<SearchErrorEventArgs> SearchError;

        protected virtual void OnSearchError(SearchErrorEventArgs e)
        {
            if (this.SearchError != null)
            {
                this.SearchError(this, e);
            }
        }

        #endregion
    }
}
