using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Primitives;
using System.Drawing.Drawing2D;

namespace ResizingPanelsDoubleBuffer
{
    public partial class ControlsWithoutDoubleBuffer : Form
    {
        public ControlsWithoutDoubleBuffer()
        {
            InitializeComponent();

            this.radPanel1.Scroll += new ScrollEventHandler(radPanel1_Scroll);
            this.panel1.Scroll += new ScrollEventHandler(panel1_Scroll);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush linearGradientBrush = new LinearGradientBrush(
               new Rectangle(408, 34, this.panel1.Width, this.panel1.Height), Color.White, Color.Blue, 90);
            g.FillRectangle(linearGradientBrush, new Rectangle(408, 34, this.panel1.Width, this.panel1.Height));

            linearGradientBrush.Dispose();
        }

        void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            this.panel1.Invalidate();
        }

        void radPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            this.radPanel1.Invalidate();
        }
    }
}