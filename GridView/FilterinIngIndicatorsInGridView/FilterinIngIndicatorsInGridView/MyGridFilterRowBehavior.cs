using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace FilterinIngIndicatorsInGridView
{
    #region CustomGridFilterRowBehavior
    public class MyGridFilterRowBehavior : GridFilterRowBehavior
    {
        protected override bool OnMouseDownLeft(MouseEventArgs e)
        {
            MyGridFilterCellElement filterCell = this.GetCellAtPoint(e.Location) as MyGridFilterCellElement;
            if (filterCell != null && filterCell.ClearButtonElement.ControlBoundingRectangle.Contains(e.Location))
            {
                return false;
            }

            return base.OnMouseDownLeft(e);
        }
    }
    #endregion
}
