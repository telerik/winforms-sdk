using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace NotificationButtonCSharp
{
    public partial class Form1 : RadRibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radButton1.NotificationCount = 3;
            this.radButton2.NotificationCount = 0;
            this.radButton3.NotificationCount = 55;

            this.radButtonElement1.NotificationCount = 24;
            this.radButtonElement2.NotificationCount = 0;
            this.radButtonElement3.NotificationCount = 17;
        }
    }
}