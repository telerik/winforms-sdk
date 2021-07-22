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
    public partial class PanelsWithoutDoubleBuffer : Form
    {
        public PanelsWithoutDoubleBuffer()
        {
            InitializeComponent();

            this.tableLayoutPanel1.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush linearGradientBrush = new LinearGradientBrush(
               new Rectangle(0, 0, this.tableLayoutPanel1.Width, this.tableLayoutPanel1.Height), Color.White, Color.Blue, 90);
            g.FillRectangle(linearGradientBrush, new Rectangle(0, 0, this.tableLayoutPanel1.Width, this.tableLayoutPanel1.Height));

            linearGradientBrush.Dispose();
        }
    }
}