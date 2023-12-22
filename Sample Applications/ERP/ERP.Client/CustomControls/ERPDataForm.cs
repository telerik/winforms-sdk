using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ERP.Client
{
    public partial class ERPDataForm : RadForm
    {
        public ERPDataForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;         
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ShowIcon = false;
          
            if (Telerik.WinControls.TelerikHelper.IsMaterialTheme(this.ThemeName))
            {
                erpDataDialog.DataEntry.ItemDefaultSize =  new Size(100, 25);
                this.Height += 100;
                this.Width += 50;
            }
           
        }
        public RadDataEntry DataEntry
        {
            get
            {
                return this.erpDataDialog.DataEntry;
            }
        }       
    }
}
