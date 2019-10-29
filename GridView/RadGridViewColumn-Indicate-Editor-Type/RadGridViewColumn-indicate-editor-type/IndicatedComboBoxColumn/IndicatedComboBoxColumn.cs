using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace RadGridViewColumn_indicate_editor_type
{
    public class IndicatedComboBoxColumn : GridViewComboBoxColumn
    {
        private bool enableIndicator;

        public IndicatedComboBoxColumn()
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
                return typeof(IndicatedComboBoxCellElement);
            }
            return base.GetCellType(row);
        }
    }
}
