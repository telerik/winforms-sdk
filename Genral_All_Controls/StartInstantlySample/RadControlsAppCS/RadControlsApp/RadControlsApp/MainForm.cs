using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace RadControlsApp
{
    public partial class MainForm : RadForm
    {
        public MainForm()
        {
            InitializeComponent();
            
            this.Text = "SingleInstanceDemo";
            this.Opacity = 0;
        }

        private bool firstShow = true;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (firstShow)
            {
                this.Visible = false;
                this.firstShow = false;
                this.Opacity = 1;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

            base.OnClosing(e);
        }
    }
}
