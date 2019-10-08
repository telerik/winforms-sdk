using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Paint;
using Telerik.WinControls.UI;

namespace PanAndZoomExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Size defaultImageSize = this.panImageControl1.Size;
            //Bitmap image = new Bitmap(defaultImageSize.Width, defaultImageSize.Height);
            //Graphics graphics = Graphics.FromImage(image);

            //Rectangle rect = new Rectangle(Point.Empty, defaultImageSize);
            //rect.Inflate(-1, -1);
            //using (GraphicsPath path = (new RoundRectShape(1)).CreatePath(rect))
            //{
            //    using (LinearGradientBrush gradientBrush = new LinearGradientBrush(rect,
            //        Color.Red,
            //        Color.Blue,
            //        70))
            //    {
            //        graphics.FillPath(gradientBrush, path);
            //    }

            //    using (Pen pen = new Pen(Color.Black))
            //    {
            //        graphics.DrawPath(pen, path);
            //    }
            //}

            this.panImageControl1.PanImageElement.ImageElement.Image = Properties.Resources.World_physical_map_1970;
        }
    }
}