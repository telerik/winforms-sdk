using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ERP.Client
{
    public partial class DetailsMapControl : UserControl
    {
        public DetailsMapControl()
        {
            this.InitializeComponent();
            this.radMap1.ShowLegend = false;
            this.radMap1.ShowSearchBar = false;
            this.radMap1.ShowNavigationBar = false;
            this.radMap1.ShowMiniMap = false;
            this.radMap1.ShowScaleIndicator = false;
            Telerik.WinControls.UI.MapLayer pinsLayer = new MapLayer("Pins");
            this.radMap1.Layers.Add(pinsLayer);

        }
        public ERPDataDialog DataControl
        {
            get
            {
                return this.erpDataDialog1;
            }
        }
        public RadMap MapControl
        {
            get
            {
                return this.radMap1;
            }
        }
    }
}
