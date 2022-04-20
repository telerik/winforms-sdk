using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RadImageEditorMultiPageTiff
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        Image tiffImage;
        Bitmap editedImage;
        int currentPage = 0;
        List<Image> images;
        string path = @"..\..\multipage_tif_example.tif";

        public RadForm1()
        {
            InitializeComponent();
            this.tiffImage = Image.FromFile(@"..\..\multipage_tif_example.tif");
            this.images = this.GetAllPages(tiffImage);

            this.tiffImage.SelectActiveFrame(FrameDimension.Page, this.currentPage);
            this.editedImage = new Bitmap(this.tiffImage);
            this.radImageEditor1.OpenImage(this.editedImage);
            this.radLabel1.Text = Convert.ToString(this.currentPage + 1);
        }

        private List<Image> GetAllPages(Image multiPageImage)
        {
            List<Image> images = new List<Image>();
            int count = multiPageImage.GetFrameCount(FrameDimension.Page);
            for (int i = 0; i < count; i++)
            {
                multiPageImage.SelectActiveFrame(FrameDimension.Page, i);
                MemoryStream byteStream = new MemoryStream();
                multiPageImage.Save(byteStream, ImageFormat.Tiff);
                images.Add(Image.FromStream(byteStream));
                byteStream.Dispose();
            }
            return images;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (this.currentPage > 0)
            {
                MemoryStream byteStream = new MemoryStream();
                this.radImageEditor1.SaveImage(byteStream, ImageFormat.Tiff);
                this.images[this.currentPage] = Image.FromStream(byteStream);
                byteStream.Dispose();

                this.currentPage--;
                this.UpdateImage(this.currentPage);
            }
        }

        private void UpdateImage(int page)
        {
            this.editedImage = new Bitmap(this.images[page]);
            this.radImageEditor1.OpenImage(this.editedImage);
            this.radLabel1.Text = Convert.ToString(page + 1);

            this.radImageEditor1.Invalidate();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (this.currentPage < this.images.Count - 1)
            {
                MemoryStream byteStream = new MemoryStream();
                this.radImageEditor1.SaveImage(byteStream, ImageFormat.Tiff);
                this.images[this.currentPage] = Image.FromStream(byteStream);
                byteStream.Dispose();

                this.currentPage++;
                this.UpdateImage(this.currentPage);
            }
        }
    }
}