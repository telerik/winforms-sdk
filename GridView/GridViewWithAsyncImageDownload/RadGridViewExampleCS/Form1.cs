using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.IO;

namespace RadGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable table = new DataTable();
            table.Columns.Add("Images");

            table.Rows.Add(@"http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Ferrari%20Enzo.png");
            table.Rows.Add(@"http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Jaguar%20XJ220.png");
            table.Rows.Add(@"http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Koenigsegg%20CCX.png");
            table.Rows.Add(@"http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Lamborghini%20Murcielago%20LP640.png");
            table.Rows.Add(@"http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/McLaren%20F1.png");
            table.Rows.Add(@"http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Pagani%20Zonda F.png");
            table.Rows.Add(@"http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Porsche%20Carrera GT.png");
            table.Rows.Add(@"http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Saleen%20S7%20Twin-Turbo.png");
            table.Rows.Add(@"http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/SSC%20Ultimate Aero.png");

            this.radGridView1.CreateCell += new GridViewCreateCellEventHandler(radGridView1_CreateCell);
            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.DataSource = table;
            this.radGridView1.Columns[0].Width = 160;
            this.radGridView1.TableElement.RowHeight = 100;
        }

        private void radGridView1_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridDataCellElement))
            {
                e.CellElement = new CustomCellElement(e.Column, e.Row);
            }
        }
    }

    public class CustomCellElement : GridDataCellElement
    {
        public CustomCellElement(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {
            this.ImageLayout = ImageLayout.Stretch;
        }

        public override void SetContent()
        {
            base.SetContent();

            this.Image = null;
            this.Text = "Loading image...";

            ImageInfo cache = this.RowInfo.Tag as ImageInfo;

            if (cache != null && cache.Url == this.Value.ToString())
            {
                 if (cache.Image != null)
                {
                    this.Image = cache.Image;
                    this.Text = cache.Url;
                }
            }
            else
            {
                this.RowInfo.Tag = new ImageInfo(this.RowInfo.Cells[this.ColumnInfo.Name].Value.ToString(), null);
                ThreadPool.QueueUserWorkItem(new WaitCallback(LoadImage), this.RowInfo);
            }
        }

        private void LoadImage(object state)
        {
            GridViewRowInfo rowInfo = (GridViewRowInfo)state;
            ImageInfo info = (ImageInfo)rowInfo.Tag;

            string url = info.Url;
            HttpWebRequest request = (HttpWebRequest)System.Net.HttpWebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Image image = Image.FromStream(response.GetResponseStream());
            response.Close();

            info.Image = image;
            rowInfo.InvalidateRow();

        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataCellElement);
            }
        }
    }

    public class ImageInfo
    {
        private string url;
        private Image image;

        public ImageInfo(string url, Image image)
        {
            this.url = url;
            this.image = image;
        }

        public string Url
        {
            get { return this.url; }
            set { this.url = value; }
        }

        public Image Image
        {
            get { return this.image; }
            set { this.image = value; }
        }
    }
}
