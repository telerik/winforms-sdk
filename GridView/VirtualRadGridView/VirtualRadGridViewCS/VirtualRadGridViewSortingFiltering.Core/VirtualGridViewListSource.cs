using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace VirtualRadGridViewSortingFiltering.Core
{
    public class VirtualGridViewListSource : GridViewListSource
    {
        public VirtualGridDataView DataView { get; private set; }

        public VirtualGridViewListSource(GridViewTemplate template)
            : base(template)
        {
        }

        protected override void InsertItem(int index, GridViewRowInfo item)
        {
            base.InsertItem(index, item);
            this.InitializeBoundRow(item, this.DataView.ItemsSource[index]);
        }

        protected override Telerik.WinControls.Data.RadCollectionView<GridViewRowInfo> CreateDefaultCollectionView()
        {
            this.DataView = new VirtualGridDataView(this);
            return this.DataView;
        }
    }
}
