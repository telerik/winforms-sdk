using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ThemeApply
{
    public partial class Form1 : Form
    {
        private Bitmap icon;

        public Form1()
        {
            InitializeComponent();
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            this.icon = (Bitmap)Bitmap.FromFile("info.png");

            RadMessageBox.SetThemeName("CustomMessageBox");
            RadMessageBox.Show(this, "Are you sure?", "Example Message", MessageBoxButtons.OKCancel, icon);
        }
    }
}