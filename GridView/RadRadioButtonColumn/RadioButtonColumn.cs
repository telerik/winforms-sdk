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

        public event EventHandler<RadioButtonEventArgs> RadioButtonToggleStateChanged;

        internal virtual void OnRadioButtonToggleStateChanged(RadioButtonEventArgs e)
        {
            if (RadioButtonToggleStateChanged != null)
            {
                RadioButtonToggleStateChanged(this, e);
            }
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

    public class RadioButtonEventArgs : EventArgs
    {
        private int rowIndex;

        public RadioButtonEventArgs(int rowIndex)
        {
            this.rowIndex = rowIndex;
        }

        public int RowIndex
        {
            get { return this.rowIndex; }
        }

    }
}
