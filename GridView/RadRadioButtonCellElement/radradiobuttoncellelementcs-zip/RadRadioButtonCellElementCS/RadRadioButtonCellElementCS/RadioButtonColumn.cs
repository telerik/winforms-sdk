using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace RadRadioButtonCellElementCS
{
    public class RadioButtonColumn: GridViewDataColumn
    {
        public RadioButtonColumn(string fieldName)
            : base(fieldName)
        {
        }

        public override Type GetCellType(GridViewRowInfo row)
        {
            if (row is GridViewDataRowInfo)
            {
                return typeof(RadioButtonCellElement);
            }        
            return base.GetCellType(row);
        }
    }
}
