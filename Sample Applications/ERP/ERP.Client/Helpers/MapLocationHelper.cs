using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map.Azure;

namespace ERP.Client
{
    public class MapLocationHelper
    {
        private const string AzureAPIKey = "8uR6rCv3uY6Tttpu2O-Fxe2IF3D_pHtiS1YRkTVtq2Y";
        private RadMap map;
        private AzureMapProvider azureProvider;
        private MapLayer visualizationLayer;
        private ERP.Repository.Service.Address address;
        private bool isAddtionalSearch;

        public MapLocationHelper(RadMap map)
        {
            this.map = map;
            this.InitializeMapProvider();
        }

        public void UpdateMap(ERP.Repository.Service.Address address)
        {
            this.address = address;
            this.LoadMap();
        }

        private void InitializeMapProvider()
        {
            string cacheFolder = @"..\..\cache";
            this.azureProvider = new AzureMapProvider();
            this.azureProvider.TileSetID = AzureTileSet.Road;
            this.azureProvider.AzureAPIKey = AzureAPIKey;
            this.azureProvider.AzureAPIVersion = "2024-04-01";
            LocalFileCacheProvider cache = new LocalFileCacheProvider(cacheFolder);
            this.azureProvider.CacheProvider = cache;
            this.map.Providers.Add(this.azureProvider);
            this.azureProvider.SearchCompleted += this.AzureProvider_SearchCompleted; ;
            this.azureProvider.TileDownloader = new AzureTileDownloader();
            this.azureProvider.SearchError += this.Provider_SearchError;
        }

        private void AzureProvider_SearchCompleted(object sender, AzureSearchCompletedEventArgs e)
        {
            this.visualizationLayer.Clear();

            Telerik.WinControls.UI.Map.RectangleG allPoints = new Telerik.WinControls.UI.Map.RectangleG(double.MinValue, double.MaxValue, double.MaxValue, double.MinValue);
            this.map.Layers["Pins"].Clear();

            foreach (Result result in e.AzureResponse.Results)
            {
                var latitude = result.Position.Latitude;
                var longitude = result.Position.Longitude;
                Telerik.WinControls.UI.Map.PointG point = new Telerik.WinControls.UI.Map.PointG(latitude, longitude);
                MapPin pin = new MapPin(point);
                pin.Size = new System.Drawing.Size(20, 40);
                pin.BackColor = Color.Red;
                pin.ToolTipText = result.Address.FreeformAddress;

                this.map.MapElement.Layers["Pins"].Add(pin);
                allPoints.North = Math.Max(allPoints.North, point.Latitude);
                allPoints.South = Math.Min(allPoints.South, point.Latitude);
                allPoints.West = Math.Min(allPoints.West, point.Longitude);
                allPoints.East = Math.Max(allPoints.East, point.Longitude);
            }

            if (e.AzureResponse.Results.Length > 0)
            {
                var latitude = e.AzureResponse.Results[0].Position.Latitude;
                var longitude = e.AzureResponse.Results[0].Position.Longitude;
                this.map.Zoom(15, true);
                this.map.BringIntoView(new Telerik.WinControls.UI.Map.PointG(latitude, longitude));
            }
            else
            {
                RadMessageBox.Show("No result found for the provided search query!");
            }
        }

        private void Provider_SearchError(object sender, SearchErrorEventArgs e)
        {
            if (!this.isAddtionalSearch)
            {
                this.isAddtionalSearch = true;
                this.CreateRequestAndSearchAsync(this.address);
            }
            else
            {
                MessageBox.Show("Address cannot be found!");
            }
        }

        private void Provider_SearchCompleted(object sender, SearchCompletedEventArgs e)
        {
            this.visualizationLayer.Clear();

            double[] bbox = e.Locations[0].BBox;

            var location = e.Locations[0];
            Telerik.WinControls.UI.Map.PointG point = new Telerik.WinControls.UI.Map.PointG(location.Point.Coordinates[0], location.Point.Coordinates[1]);
            MapPin pin = new MapPin(point);
            pin.Size = new System.Drawing.Size(20, 40);
            pin.BackColor = System.Drawing.Color.Red;
            pin.ToolTipText = location.Address.FormattedAddress;
            this.map.MapElement.Layers[0].Add(pin);
            var zoomPoint = new Telerik.WinControls.UI.Map.PointG(e.Locations[0].Point.Coordinates[0], e.Locations[0].Point.Coordinates[1]);

            if (this.map.Visible)
            {
                this.map.Zoom(9, true);
                this.map.BringIntoView(zoomPoint);
            }

        }

        private void LoadMap()
        {
            this.visualizationLayer = this.map.Layers[0] as MapLayer;

            this.CreateRequestAndSearchAsync(this.address);
            this.address.PropertyChanged -= this.OnAddressPropertyChanged;
            this.address.PropertyChanged += this.OnAddressPropertyChanged;
        }

        private void OnAddressPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {            
            this.CreateRequestAndSearchAsync(this.address);
        }

        private void CreateRequestAndSearchAsync(Repository.Service.Address address)
        {
            AzureSearchRequest azureRequest = new AzureSearchRequest();
            azureRequest.Query = this.GenerateSearchQueryFromAddress(address);
            azureRequest.SearchOptions.Count = 1;
            this.azureProvider.SearchAsync(azureRequest);
        }

        private string GenerateSearchQueryFromAddress(Repository.Service.Address address)
        {
            string searchQuery = string.Format("{0} {1} {2} {3}",
                // If the first search doesn't succeed - search on for City and Country.
                !this.isAddtionalSearch ? address.AddressLine1 : string.Empty,
                address.City,
                address.StateProvince.CountryRegion != null ? address.StateProvince.Name : address.StateProvince.CountryRegion.Name,
                address.StateProvince.CountryRegion != null ? address.StateProvince.CountryRegion.Name : "").Trim();

            return searchQuery;
        }
    }
}