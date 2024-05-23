using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ExampleApplication
{
    public partial class FormMessage : RadForm
    {
        
        public FormMessage(string title, string text)
        {
            InitializeComponent();

            this.Text = title;
            this.radLabel1.Text = text;
        }

        private void radButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}