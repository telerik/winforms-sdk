using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms.VisualStyles;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GridViewCustomCells
{
   

    public class IndicatedDecimalColumn : GridViewDecimalColumn
    {
        private bool enableIndicator;

        public IndicatedDecimalColumn()
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
                return typeof(IndicatedDecimalCellElement);
            }
            return base.GetCellType(row);
        }
    }
}