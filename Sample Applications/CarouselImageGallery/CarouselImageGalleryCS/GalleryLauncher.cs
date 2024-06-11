using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CarouselImageGallery
{
    public partial class GalleryLauncher : Form
    {
        public GalleryLauncher()
        {
            InitializeComponent();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(this.radDropDownList1.Text))
            {
                fbd.SelectedPath = this.radDropDownList1.Text;
            }

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.radDropDownList1.Text = fbd.SelectedPath;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string path = this.radDropDownList1.Text.Trim();
            if (this.radDropDownList1.FindItemExact(path, false) == null)
            {
                this.radDropDownList1.Items.Add(new RadListDataItem(path));
            }

            GalleryView galleryView = new GalleryView();

            galleryView.ShowGallery(path);
        }

        private void GalleryLauncher_Load(object sender, EventArgs e)
        {
            this.radDropDownList1.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }
    }
}