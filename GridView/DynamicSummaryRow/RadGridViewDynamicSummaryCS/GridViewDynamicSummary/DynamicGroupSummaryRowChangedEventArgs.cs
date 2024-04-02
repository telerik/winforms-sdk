using System;
using Telerik.WinControls.UI;

namespace GridView
{

    public class DynamicGroupSummaryRowChangedEventArgs : System.EventArgs
    {

        public DynamicGroupSummaryRowChangedEventArgs(GridViewDataColumn column, GridView.SummaryRowPosition summaryRowPosition, AggregateFunction aggregateFunction, bool isEnabled)
            : base()
        {
            this.Column = column;
            this.SummaryRowPosition = summaryRowPosition;
            this.AggregateFunction = aggregateFunction;
            this.IsEnabled = isEnabled;
        }

        public GridViewDataColumn Column;
        public SummaryRowPosition SummaryRowPosition;
        public AggregateFunction AggregateFunction;
        public bool IsEnabled;
    }

}
