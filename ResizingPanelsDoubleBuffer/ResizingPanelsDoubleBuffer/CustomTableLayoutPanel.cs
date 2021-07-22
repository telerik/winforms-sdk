using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ResizingPanelsDoubleBuffer
{
    public class CustomTableLayoutPanel : TableLayoutPanel
    {
        public CustomTableLayoutPanel()
        {
            this.DoubleBuffered = true;
        }
    }
}
