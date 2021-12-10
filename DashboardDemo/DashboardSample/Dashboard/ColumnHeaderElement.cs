using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using System.Windows.Forms;

namespace TicketTest
{
    public class ColumnHeaderElement: LightVisualElement
    {        
        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.DrawFill = true;
            this.DrawBorder = true;
            this.Padding = new Padding(5);
            this.StretchHorizontally = true;
            this.StretchVertically = false;
            this.Margin = new Padding(1);
        }
    }
}
