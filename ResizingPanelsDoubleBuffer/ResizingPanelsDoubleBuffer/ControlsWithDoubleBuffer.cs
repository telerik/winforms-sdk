using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ResizingPanelsDoubleBuffer
{
    public partial class ControlsWithDoubleBuffer : Form
    {
        public ControlsWithDoubleBuffer()
        {
            InitializeComponent();

            this.radPanel1.Scroll += new ScrollEventHandler(radPanel1_Scroll);
            this.customPanel1.Scroll += new ScrollEventHandler(customPanel1_Scroll);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush linearGradientBrush = new LinearGradientBrush(
               new Rectangle(408, 34, this.customPanel1.Width, this.customPanel1.Height), Color.White, Color.Blue, 90);
            g.FillRectangle(linearGradientBrush, new Rectangle(408, 34, this.customPanel1.Width, this.customPanel1.Height));

            linearGradientBrush.Dispose();
        }

        void customPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            this.customPanel1.Invalidate();
        }

        void radPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            this.radPanel1.Invalidate();
        }
    }
}