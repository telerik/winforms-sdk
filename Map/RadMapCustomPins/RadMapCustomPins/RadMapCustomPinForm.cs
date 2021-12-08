using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Paint;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;
using Telerik.WinControls.UI.Map.Bing;

namespace RadMapCustomPins
{
    public partial class RadMapCustomPinForm : RadForm
    {
        #region InitialSetup
        public RadMapCustomPinForm()
        {
            InitializeComponent();

            this.SetupProviders();

            MapLayer pointLayer = new MapLayer("PointG");
            this.radMap1.Layers.Add(pointLayer);
            MapPin element = new CustomMapPin(new PointG(34.04302, -118.26725))
            {
                Image = Properties.Resources.NBALakers
            };

            element.Text = "Los Angeles";
            element.BackColor = Color.Red;
            this.radMap1.Layers["PointG"].Add(element);
        }

        private void SetupProviders()
        {
            OpenStreetMapProvider osmProvider = new OpenStreetMapProvider();
            MapTileDownloader tileDownloader = osmProvider.TileDownloader as MapTileDownloader;
            tileDownloader.WebHeaders.Add(System.Net.HttpRequestHeader.UserAgent, "your application name");
            this.radMap1.MapElement.Providers.Add(osmProvider);
        }

        #endregion
    }

    #region CustomMapPin
    public class CustomMapPin : MapPin
    {
        private Image image;
        private PointL pixelLocation;
        private RectangleL drawRect;
        private bool isImageInViewPort;
        public CustomMapPin(PointG location)
            : base(location)
        {
        }
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                this.image = value;
            }
        }
        public override bool IsInViewport
        {
            get { return this.Image != null ? this.isImageInViewPort : base.IsInViewport; }
        }
        public override void Paint(IGraphics graphics, IMapViewport viewport)
        {
            object state = graphics.SaveState();
            graphics.ChangeSmoothingMode(SmoothingMode.AntiAlias);
            MapVisualElementInfo info = this.GetVisualElementInfo(viewport);
            GraphicsPath path = info.Path.Clone() as GraphicsPath;
            GraphicsPath dotPath = new GraphicsPath();
            long mapSize = MapTileSystemHelper.MapSize(viewport.ZoomLevel);
            Matrix matrixOffset = new Matrix();
            matrixOffset.Translate(viewport.PanOffset.Width + info.Offset.X, viewport.PanOffset.Height + info.Offset.Y);
            path.Transform(matrixOffset);
            Matrix matrixWraparound = new Matrix();
            matrixWraparound.Translate(mapSize, 0);
            for (int i = 0; i < viewport.NumberOfWraparounds; i++)
            {
                RectangleF bounds = path.GetBounds();
                float diameter = bounds.Width / 3F;
                dotPath.AddEllipse(bounds.X + diameter, bounds.Y + diameter, diameter, diameter);
                graphics.FillPath(this.BorderColor, dotPath);
                //draw the image
                Point imageLocation = new Point((int)bounds.Location.X + (int)bounds.Width / 2 - this.image.Width / 2, (int)bounds.Location.Y);
                graphics.DrawImage(imageLocation, this.Image, true);
                path.Transform(matrixWraparound);
            }
            graphics.RestoreState(state);
        }
        public override void ViewportChanged(IMapViewport viewport, ViewportChangeAction action)
        {
            if (this.Image == null)
            {
                base.ViewportChanged(viewport, action);
                return;
            }
            long mapSize = MapTileSystemHelper.MapSize(viewport.ZoomLevel);
            if ((action & ViewportChangeAction.Zoom) != 0)
            {
                this.pixelLocation = MapTileSystemHelper.LatLongToPixelXY(this.Location, viewport.ZoomLevel);
            }
            if ((action & ViewportChangeAction.Pan) != 0)
            {
                this.drawRect = new RectangleL(pixelLocation.X - this.Image.Size.Width / 2, pixelLocation.Y - this.Image.Size.Height, this.Image.Size.Width, this.Image.Size.Height);
            }
            RectangleL wraparoundDrawRect = this.drawRect;
            for (int i = 0; i <= viewport.NumberOfWraparounds; i++)
            {
                if (wraparoundDrawRect.IntersectsWith(viewport.ViewportInPixels))
                {
                    this.isImageInViewPort = true;
                    break;
                }
                wraparoundDrawRect.Offset(mapSize, 0L);
            }
            if (!this.IsInViewport)
            {
                return;
            }
        }
        public override bool HitTest(PointG pointG, PointL pointL, IMapViewport viewport)
        {
            if (this.Image == null)
            {
                return base.HitTest(pointG, pointL, viewport);
            }
            return this.drawRect.Contains(pointL);
        }
    }
    #endregion
}
