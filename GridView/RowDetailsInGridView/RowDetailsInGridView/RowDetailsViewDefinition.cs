using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace RowDetailsInGridView
{
    public class RowDetailsViewDefinition : TableViewDefinition
    {
        public override IRowView CreateViewUIElement(GridViewInfo viewInfo)
        {
            GridTableElement tableElement = (GridTableElement)base.CreateViewUIElement(viewInfo);
            tableElement.ViewElement.RowLayout = CreateRowLayout();
            return tableElement;
        }

        public override IGridRowLayout CreateRowLayout()
        {
            return new RowDetailsLayout();
        }
    }
}
