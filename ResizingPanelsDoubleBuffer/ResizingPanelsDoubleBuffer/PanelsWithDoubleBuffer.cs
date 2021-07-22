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
    public partial class PanelsWithDoubleBuffer : Form
    {
        public PanelsWithDoubleBuffer()
        {
            InitializeComponent();

            this.customTableLayoutPanel1.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush linearGradientBrush = new LinearGradientBrush(
               new Rectangle(0, 0, this.customTableLayoutPanel1.Width, this.customTableLayoutPanel1.Height), Color.White, Color.Blue, 90);
            g.FillRectangle(linearGradientBrush, new Rectangle(0, 0, this.customTableLayoutPanel1.Width, this.customTableLayoutPanel1.Height));

            linearGradientBrush.Dispose();
        }
    }
}