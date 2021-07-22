using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ResizingPanelsDoubleBuffer
{
    public class CustomGroupBox : GroupBox
    {
        public CustomGroupBox()
        {
            this.DoubleBuffered = true;
        }
    }
}
