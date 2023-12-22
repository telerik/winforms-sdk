using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map.Bing;

namespace ERP.Client
{
    public class MapLocationHelper
    {
        private const string VEKey = "AqaPuZWytKRUA8Nm5nqvXHWGL8BDCXvK8onCl2PkC581Zp3T_fYAQBiwIphJbRAK";
        private RadMap map;
        private BingRestMapProvider provider;
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
            this.provider = new BingRestMapProvider();
            this.provider.BingKey = VEKey;
            this.provider.UseSession = true;
            this.provider.ImagerySet = ImagerySet.CanvasGray;
            this.map.Providers.Add(provider);

            this.provider.SearchCompleted += Provider_SearchCompleted;
            this.provider.SearchError += Provider_SearchError;
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
            var  zoomPoint = new Telerik.WinControls.UI.Map.PointG(e.Locations[0].Point.Coordinates[0], e.Locations[0].Point.Coordinates[1]);
         
            if (this.map.Visible)
            {
                this.map.Zoom(9, true);
                this.map.BringIntoView(zoomPoint);
            }
           
        }

        private void LoadMap()
        {
            this.visualizationLayer = this.map.Layers[0] as MapLayer;

            this.CreateRequestAndSearchAsync(address);
            this.address.PropertyChanged -= this.OnAddressPropertyChanged;
            this.address.PropertyChanged += this.OnAddressPropertyChanged;
        }

        private void OnMapUnloaded(object sender, RoutedEventArgs e)
        {
            this.address.PropertyChanged -= this.OnAddressPropertyChanged;
        }

        private void OnAddressPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            this.CreateRequestAndSearchAsync(this.address);
        }

        private void CreateRequestAndSearchAsync(Repository.Service.Address address)
        {
            var restRequest = new SearchRequest();

            restRequest.Culture = new System.Globalization.CultureInfo("en-US");
            restRequest.Query = this.GenerateSearchQueryFromAddress(address);
            this.provider.SearchAsync(restRequest);
        }

        private string GenerateSearchQueryFromAddress(Repository.Service.Address address)
        {
            string searchQuery = string.Format("{0} {1} {2}",
                // If the first search doesn't succeed - search on for City and Country.
                !this.isAddtionalSearch ? address.AddressLine1 : string.Empty,
                address.City,
                address.StateProvince.CountryRegion != null ? address.StateProvince.CountryRegion.Name : address.StateProvince.Name).Trim();

            return searchQuery;
        }
    }
}