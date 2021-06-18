using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace _547099
{
    public class CustomCellElement: GridDataCellElement
    {
        public CustomCellElement(GridViewColumn column, GridRowElement row)
            : base(column, row)
        { }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataCellElement);
            }
        }

        public override void SetContent()
        {
            int[] values = this.Value as int[];
            if (values == null)
            {
                this.Text = "";
            }
            else
            {
                string text = "";

                CustomColumn col = this.ColumnInfo as CustomColumn;
                if (col != null)
                {
                    foreach (int i in values)
                    {
                        col.UseGetLookupValue = true;
                        object val = col.GetLookupValue(i);
                        col.UseGetLookupValue = false;
                        if (val != null)
                        {
                            text += val.ToString() + "; ";
                        }
                    }
                }
                this.Text = text;
            }
        }
    }
}
