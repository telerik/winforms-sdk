using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSSoftKeyboard
{
    public class MyBufferedTableLayoutPanel : TableLayoutPanel
    {
        public MyBufferedTableLayoutPanel() : base()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}
