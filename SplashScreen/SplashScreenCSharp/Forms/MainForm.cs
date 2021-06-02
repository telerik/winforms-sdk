using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace RadSplashScreen
{
    public partial class MainForm : RadForm
    {
        public MainForm()
        {
            InitializeComponent();

            Thread.Sleep(2000);
            this.StartPosition = FormStartPosition.CenterScreen;

        }
    }
}
