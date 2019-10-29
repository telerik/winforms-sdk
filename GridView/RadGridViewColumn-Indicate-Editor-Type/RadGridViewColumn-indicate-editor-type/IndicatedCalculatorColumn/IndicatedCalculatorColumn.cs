using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace RadGridViewColumn_indicate_editor_type
{
    public class IndicatedCalculatorColumn : GridViewCalculatorColumn
    {
        private bool enableIndicator;

        public IndicatedCalculatorColumn()
        {
            enableIndicator = true;
        }

        public bool EnableIndicator
        {
            get
            {
                return this.enableIndicator;
            }
            set
            {
                this.enableIndicator = value;
                this.OwnerTemplate.Refresh();
            }
        }

        public override Type GetCellType(GridViewRowInfo row)
        {
            if (row is GridViewDataRowInfo)
            {
                return typeof(IndicatedCalculatorCellElement);
            }
            return base.GetCellType(row);
        }
    }
}
