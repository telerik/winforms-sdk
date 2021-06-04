using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.Drawing;

namespace DisabledEditors
{
    public class MyTextBox : HostedTextBoxBase
    {
        public MyTextBox()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            e.Graphics.DrawString(Text, Font, drawBrush, -1f, -1f);
        }
    }
}
