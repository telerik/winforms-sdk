using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ResizingPanelsDoubleBuffer
{
    public class CustomPanel : Panel
    {
        public CustomPanel()
        {
            this.DoubleBuffered = true;
        }
    }
}
