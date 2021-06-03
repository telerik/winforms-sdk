using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace VirtualRadGridViewSortingFiltering.Core
{
    public class VirtualRadGridViewElement : RadGridViewElement
    {
        public ItemSource ItemsSource
        {
            get { return (this.Template.ListSource as VirtualGridViewListSource).DataView.ItemsSource; }
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadGridViewElement);
            }
        }

        protected override MasterGridViewTemplate CreateTemplate()
        {
            return new VirtualMasterGridViewTemplate();
        }
    }
}
