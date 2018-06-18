using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaugeValueMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point click = Point.Empty;
        Point center = new Point(150, 150);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           // center = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            click = e.Location;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawLine(Pens.Red, center, click);

            float xDiff = click.X - center.X;
            float yDiff = click.Y - center.Y;
            var angle = Math.Atan2(yDiff, xDiff) * 180.0 / Math.PI;
            if (angle < 0) angle += 360;
            this.Text = angle + "";
        }
    }
}
