using System;
using System.Drawing;
using System.Drawing.Imaging;
using Telerik.WinControls.Paint;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;

namespace RadMapToAnImage
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        #region InitialSetup
        public MainForm()
        {
            InitializeComponent();

            MapLayer pinLayer = new MapLayer("PinsLayer");
            this.radMap1.Layers.Add(pinLayer);

            OpenStreetMapProvider osmProvider = new OpenStreetMapProvider();
            osmProvider.InitializationComplete += OsmProvider_InitializationComplete;
            this.radMap1.MapElement.Providers.Add(osmProvider);
        }

        private void OsmProvider_InitializationComplete(object sender, EventArgs e)
        {
            MapPin element = new MapPin(new PointG(34.0140562, -118.2880489));
            element.Text = "Los Angeles";
            element.BackColor = Color.Red;

            this.radMap1.Layers["PinsLayer"].Add(element);
            this.radMap1.BringIntoView(element.Location, 10);
        }
        #endregion

        #region ExportToImage
        private void radButton1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap((int)this.radMap1.MapElement.ViewportInPixels.Size.Width, (int)this.radMap1.MapElement.ViewportInPixels.Height);
            Graphics g = Graphics.FromImage(bitmap);
            RadGdiGraphics gg = new RadGdiGraphics(g);

            foreach (MapVisualElement element in this.radMap1.MapElement.Providers[0].GetContent(this.radMap1.MapElement))
            {
                element.Paint(gg, this.radMap1.MapElement);
            }

            object state = gg.SaveState();
            gg.TranslateTransform(-this.radMap1.MapElement.ViewportInPixels.X, -this.radMap1.MapElement.ViewportInPixels.Y);
            this.radMap1.MapElement.Layers["PinsLayer"].Paint(gg, this.radMap1.MapElement);

            gg.RestoreState(state);
            bitmap.Save(@"..\..\test.png", ImageFormat.Png);
        }
    }
    #endregion
}
