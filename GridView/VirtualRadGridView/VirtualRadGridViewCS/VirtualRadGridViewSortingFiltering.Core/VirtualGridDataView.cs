using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace VirtualRadGridViewSortingFiltering.Core
{
    public class VirtualGridDataView : RadDataView<GridViewRowInfo>
    {
        private GridViewListSource listSource;
        private ItemSource itemsSource;
        private string filterExpression;

        public ItemSource ItemsSource
        {
            get
            {
                if (this.itemsSource == null)
                {
                    this.itemsSource = new ItemSource(this.ListSource.Template as VirtualMasterGridViewTemplate);
                }

                return this.itemsSource;
            }
        }

        public override string FilterExpression
        {
            get
            {
                return this.filterExpression;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && this.filterExpression != value)
                {
                    this.filterExpression = value;
                }
            }
        }

        

        public VirtualGridDataView(GridViewListSource listSource)
            : base(listSource)
        {
            this.listSource = listSource;
        }

        public GridViewListSource ListSource
        {
            get { return this.listSource; }
        }

        protected override Telerik.Collections.Generic.Index<GridViewRowInfo> CreateIndex()
        {
            return new VirtualIndex(this);
        }

        protected override GroupBuilder<GridViewRowInfo> CreateGroupBuilder()
        {
            return new VirtualGroupBuilder(this.Indexer, this);
        }
    }
}
