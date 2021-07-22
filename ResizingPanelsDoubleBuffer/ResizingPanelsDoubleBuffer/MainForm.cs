using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResizingPanelsDoubleBuffer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            PanelsWithDoubleBuffer panelsDoubleBuff = new PanelsWithDoubleBuffer();
            panelsDoubleBuff.Show();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            PanelsWithoutDoubleBuffer panelsNotDoubleBuff = new PanelsWithoutDoubleBuffer();
            panelsNotDoubleBuff.Show();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            ControlsWithDoubleBuffer controlsDoubleBuff = new ControlsWithDoubleBuffer();
            controlsDoubleBuff.Show();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            ControlsWithoutDoubleBuffer controlsNotDoubleBuff = new ControlsWithoutDoubleBuffer();
            controlsNotDoubleBuff.Show();
        }
    }
}