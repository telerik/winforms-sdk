using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace _547099
{
    public class CustomColumn : GridViewComboBoxColumn
    {
        public CustomColumn(string name)
            : base(name)
        {

        }

        public override Type DataType
        {
            get
            {
                if (UseGetLookupValue)
                {
                    return typeof(int);
                }
                return typeof(int[]);
            }
            set { }
        }

        public bool UseGetLookupValue = false;

        public override Type GetDefaultEditorType()
        {
            return typeof(CustomDropDownListEditor);
        }

        public override Type GetCellType(GridViewRowInfo row)
        {
            if (row is GridViewDataRowInfo || row is GridViewNewRowInfo)
            {
                return typeof(CustomCellElement);
            }
            return base.GetCellType(row);
        }
    }
}
