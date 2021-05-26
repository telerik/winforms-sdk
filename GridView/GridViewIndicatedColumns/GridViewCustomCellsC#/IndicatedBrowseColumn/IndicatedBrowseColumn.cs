using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GridViewCustomCells
{
    class IndicatedBrowseColumn : GridViewBrowseColumn
    {
        private bool enableIndicator;

        public IndicatedBrowseColumn()
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
                return typeof(IndicatedBrowseCellElement);
            }
            return base.GetCellType(row);
        }
    }
}