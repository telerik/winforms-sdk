using System;
using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using RadMapCustomAzureProvider_NET48.Azure_Provider;

namespace RadMapCustomAzureProvider_NET48
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        private string AzureAPIKey = "";

        public RadForm1()
        {
            InitializeComponent();
            this.radMap1.ShowSearchBar = true;
            AzureMapProvider provider = new AzureMapProvider();
            provider.TileSetID = AzureTileSet.Road;

            if (AzureAPIKey == "")
            {
                if (string.IsNullOrWhiteSpace(AzureAPIKey))
                {
                    throw new InvalidOperationException("An Azure API key must be provided to use the Azure Map Provider.");
                }            
            }

            provider.AzureAPIKey = AzureAPIKey;
            string cacheFolder = @"..\..\cache";
            LocalFileCacheProvider cache = new LocalFileCacheProvider(cacheFolder);
            provider.CacheProvider = cache;
            provider.EnableCaching = true;
            this.radMap1.Providers.Add(provider);

            MapLayer pinsLayer = new MapLayer("Pins");
            this.radMap1.Layers.Add(pinsLayer);
            this.radMap1.MapElement.SearchBarElement.SearchProvider = provider;
            this.radMap1.MapElement.SearchBarElement.SearchProvider.SearchCompleted += BingProvider_SearchCompleted;
        }
        private void BingProvider_SearchCompleted(object sender, SearchCompletedEventArgs e)
        {
            Telerik.WinControls.UI.Map.RectangleG allPoints = new Telerik.WinControls.UI.Map.RectangleG(double.MinValue, double.MaxValue, double.MaxValue, double.MinValue);
            this.radMap1.Layers["Pins"].Clear();

            foreach (Telerik.WinControls.UI.Map.Bing.Location location in e.Locations)
            {
                Telerik.WinControls.UI.Map.PointG point = new Telerik.WinControls.UI.Map.PointG(location.Point.Coordinates[0], location.Point.Coordinates[1]);
                MapPin pin = new MapPin(point);
                pin.Size = new System.Drawing.Size(20, 40);
                pin.BackColor = Color.Red;
                pin.ToolTipText = location.Address.FormattedAddress;

                this.radMap1.MapElement.Layers["Pins"].Add(pin);
                allPoints.North = Math.Max(allPoints.North, point.Latitude);
                allPoints.South = Math.Min(allPoints.South, point.Latitude);
                allPoints.West = Math.Min(allPoints.West, point.Longitude);
                allPoints.East = Math.Max(allPoints.East, point.Longitude);
            }
            if (e.Locations.Length > 0)
            {
                if (e.Locations.Length == 1)
                {
                    this.radMap1.BringIntoView(new Telerik.WinControls.UI.Map.PointG(e.Locations[0].Point.Coordinates[0], e.Locations[0].Point.Coordinates[1]));
                }
                else
                {
                    this.radMap1.MapElement.BringIntoView(allPoints);
                    this.radMap1.Zoom(this.radMap1.MapElement.ZoomLevel - 1);
                }
            }
            else
            {
                RadMessageBox.Show("No result found for the provided search query!");
            }
        }
    }
}
