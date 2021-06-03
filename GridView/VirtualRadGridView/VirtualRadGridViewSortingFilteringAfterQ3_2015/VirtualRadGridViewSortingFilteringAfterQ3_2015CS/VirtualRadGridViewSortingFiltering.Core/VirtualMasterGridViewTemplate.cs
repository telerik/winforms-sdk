using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace VirtualRadGridViewSortingFiltering.Core
{
    public class VirtualMasterGridViewTemplate : MasterGridViewTemplate
    {
        public VirtualMasterGridViewTemplate()
        {
            this.ThrowExceptionOnDataOperationInVirtualMode = false;
        }

        protected override GridViewListSource CreateListSource()
        {
            return new VirtualGridViewListSource(this);
        }
    }
}