using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace PermanentDropDownListEditorInFilterCell
{
    class CustomColumn : GridViewTextBoxColumn
    {
        public override Type GetCellType(GridViewRowInfo row)
        {
            if (row is GridViewFilteringRowInfo)
            {
                return typeof(DropDownGridFilterCellElement);
            }
            return base.GetCellType(row);
        }
    }
}