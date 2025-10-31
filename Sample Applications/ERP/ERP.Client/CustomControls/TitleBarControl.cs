using ERP.Client.Properties;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ERP.Client.CustomControls
{
    public partial class TitleBarControl : UserControl
    {
        public TitleBarControl()
        {
            this.InitializeComponent();
            this.radPanel1.ElementTree.EnableApplicationThemeName = false;
            this.radTitleBar1.ElementTree.EnableApplicationThemeName = false;
            this.radTitleBar1.TitleBarElement.BorderPrimitive.Visibility = ElementVisibility.Collapsed;
            this.radTitleBar1.ThemeName = "VisualStudio2012Dark";
            this.radPanel1.BackgroundImage = Resources.logo;
            this.radPanel1.BackgroundImageLayout = ImageLayout.Center;
            this.radPanel1.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.radPanel1.Text = "";
            this.radPanel1.BackColor = Color.FromArgb(52, 53, 54);
            this.radTitleBar1.BackColor = Color.FromArgb(52, 53, 54);
            this.BackColor = Color.FromArgb(52, 53, 54); 

        }
    }
}
