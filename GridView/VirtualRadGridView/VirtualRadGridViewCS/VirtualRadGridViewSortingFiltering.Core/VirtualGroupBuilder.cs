using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using System.Threading.Tasks;

namespace VirtualRadGridViewSortingFiltering.Core
{
    public class VirtualGroupBuilder : GroupBuilder<GridViewRowInfo>
    {
        private VirtualGridDataView dataView;

        public VirtualGroupBuilder(Telerik.Collections.Generic.Index<GridViewRowInfo> index, VirtualGridDataView dataView)
            : base(index)
        {
            this.dataView = dataView;
        }

        protected override object GetItemKey(GridViewRowInfo item, SortDescriptor descriptor)
        {
            return this.dataView.ItemsSource.GetValue(item.DataBoundItem, descriptor.PropertyIndex);
        }
    }
}
