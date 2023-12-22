using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using ERP.Client.Properties;

namespace ERP.Client.CustomControls
{
    public partial class TitleBarControl : UserControl
    {
        public TitleBarControl()
        {
            InitializeComponent();
            radPanel1.ElementTree.EnableApplicationThemeName = false;
            radTitleBar1.ElementTree.EnableApplicationThemeName = false;
            radTitleBar1.TitleBarElement.BorderPrimitive.Visibility = ElementVisibility.Collapsed;
            radTitleBar1.ThemeName = "VisualStudio2012Dark";
            radPanel1.BackgroundImage = Resources.logo;
            radPanel1.BackgroundImageLayout = ImageLayout.Center;
            radPanel1.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            radPanel1.Text = "";
            radPanel1.BackColor = Color.FromArgb(52, 53, 54);
            radTitleBar1.BackColor = Color.FromArgb(52, 53, 54);
            this.BackColor = Color.FromArgb(52, 53, 54); 

        }
    }
}
