using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace VirtualRadGridViewSortingFiltering.Core
{
    public class VirtualMasterGridViewTemplate : MasterGridViewTemplate
    {
        protected override GridViewListSource CreateListSource()
        {
            return new VirtualGridViewListSource(this);
        }
    }
}