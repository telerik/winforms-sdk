using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace HotelApp
{
    public class CustomGridDataRowBehavior : GridDataRowBehavior
    {
        protected override bool OnMouseDownLeft(MouseEventArgs e)
        {
            GridDataRowElement row = this.GetRowAtPoint(e.Location) as GridDataRowElement;
            if (row != null)
            {
                RadGridViewDragDropService svc = this.GridViewElement.GetService<RadGridViewDragDropService>();
                svc.AllowAutoScrollColumnsWhileDragging = false;
                svc.AllowAutoScrollRowsWhileDragging = false;
                svc.Start(row);
            }
            return base.OnMouseDownLeft(e);
        }
    }
}