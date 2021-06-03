using System;
using System.Collections.Generic;
using System.Text;
using Telerik.Collections.Generic;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace VirtualRadGridViewSortingFiltering.Core
{
    public class VirtualIndex : Index<GridViewRowInfo>
    {
        public VirtualIndex(RadCollectionView<GridViewRowInfo> collectionView)
            : base(collectionView)
        {
        }

        public override IList<GridViewRowInfo> Items
        {
            get
            {
                return (this.CollectionView as VirtualGridDataView).ListSource;
            }
        }

        protected override void Perform()
        {
        }
    }
}
