using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace RowDetailsInGridView
{
    public class RowDetailsRowElement : GridDataRowElement
    {
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataRowElement);
            }
        }

        public override void UpdateInfo()
        {
            if (!this.RowInfo.IsCurrent)
            {
                this.RowInfo.Height = TableElement.RowHeight;
            }
            else
            {
                this.RowInfo.Height = ((RowDetailsGrid)this.GridControl).DetailsRowHeight;
            }
            base.UpdateInfo();
        }
    }
}
