using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RadMapCustomGoogleProvider
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            this.radMap1.ShowSearchBar = false;
            IMapProvider provider = new GoogleCustomProvider();
            this.radMap1.Providers.Add(provider);
        }
    }
}
