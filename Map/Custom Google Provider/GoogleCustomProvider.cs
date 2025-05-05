using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using Telerik.WinControls.UI;

namespace RadMapCustomGoogleProvider
{
    public class GoogleCustomProvider : IMapTileProvider, IMapProvider
    {
        private const string UrlFormat = @"http://mt{0}.google.com/vt/lyrs={1}&z={2}&x={3}&y={4}";

        private IMapCacheProvider cacheProvider;
        private IMapTileDownloader tileDownloader;

        private int server = 0;

        private string id;
        private Size tileSize = new Size(256, 256);
        private int minZoomLevel = 0;
        private int maxZoomLevel = 19;

        protected Dictionary<string, TileInfo> tileMatrix = new Dictionary<string, TileInfo>();
        protected Dictionary<string, List<TileInfo>> cacheLoadReference = new Dictionary<string, List<TileInfo>>();
        protected object lockObj = new object();

        private GoogleCustomMapMode mode;

        public GoogleCustomProvider()
        {
            var downloader = new MapTileDownloader();
            downloader.WebHeaders[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
            this.TileDownloader = downloader;
            this.CacheProvider = new MemoryCacheProvider();
            this.EnableCaching = false;
        }

        public bool Initialized { get; protected set; }

        #region IMapTileProvider

        public GoogleCustomMapMode Mode
        {
            get { return this.mode; }
            set
            {
                this.mode = value;

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

            MapViewInfo view = new MapViewInfo(GoogleCustomMapMode.Physical.ToString(), false, false, this.Mode == GoogleCustomMapMode.Physical);
            result.Add(view);

            view = new MapViewInfo(GoogleCustomMapMode.PhysicalHybrid.ToString(), false, false, this.Mode == GoogleCustomMapMode.PhysicalHybrid);
            result.Add(view);

            view = new MapViewInfo(GoogleCustomMapMode.Satellite.ToString(), false, false, this.Mode == GoogleCustomMapMode.Satellite);
            result.Add(view);

            view = new MapViewInfo(GoogleCustomMapMode.SatelliteHybrid.ToString(), false, false, this.Mode == GoogleCustomMapMode.SatelliteHybrid);
            result.Add(view);

            view = new MapViewInfo(GoogleCustomMapMode.Street.ToString(), false, false, this.Mode == GoogleCustomMapMode.Street);
            result.Add(view);

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
            if (view.Name == GoogleCustomMapMode.Physical.ToString())
            {
                this.Mode = GoogleCustomMapMode.Physical;
            }
            else if (view.Name == GoogleCustomMapMode.PhysicalHybrid.ToString())
            {
                this.Mode = GoogleCustomMapMode.PhysicalHybrid;
            }
            else if (view.Name == GoogleCustomMapMode.Satellite.ToString())
            {
                this.Mode = GoogleCustomMapMode.Satellite;
            }
            else if (view.Name == GoogleCustomMapMode.SatelliteHybrid.ToString())
            {
                this.Mode = GoogleCustomMapMode.SatelliteHybrid;
            }
            else if (view.Name == GoogleCustomMapMode.Street.ToString())
            {
                this.Mode = GoogleCustomMapMode.Street;
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
            GoogleCustomProvider clone = new GoogleCustomProvider();

            clone.id = this.id;
            clone.mode = this.mode;
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

        public Uri GetTile(int tileMatrixX, int tileMatrixY, int zoomLevel)
        {
            string url = string.Empty;
            //string prefix = string.Empty;

            this.server = (this.server + 1) % 4;

            url = string.Format(UrlFormat, server, this.GetModeString(this.Mode), zoomLevel, tileMatrixX, tileMatrixY);
            //url = ProtocolHelper.SetScheme(url);

            return new Uri(url);
        }

        protected virtual string GetCacheKey(int tileX, int tileY, int zoomLevel)
        {
            return "Tile_" + tileX + "_" + tileY + "_" + zoomLevel + "_" + this.GetModeString(this.Mode) + ".png";
        }

        public string GetModeString(GoogleCustomMapMode mode)
        {
            switch (mode)
            {
                case GoogleCustomMapMode.Street:
                    return "m";
                case GoogleCustomMapMode.Satellite:
                    return "s";
                case GoogleCustomMapMode.SatelliteHybrid:
                    return "y";
                case GoogleCustomMapMode.Physical:
                    return "t";
                case GoogleCustomMapMode.PhysicalHybrid:
                    return "p";
                default:
                    return "m";
            }
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
            if (this.EnableCaching && this.CacheProvider != null)
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
    }
}
