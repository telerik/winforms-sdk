using System.Collections.Generic;
using System.Linq;
using Telerik.WinControls.UI;

namespace ServerSideDropDownList.Core
{
    public class ServerAutoCompleteSuggestHelper<T> : AutoCompleteSuggestHelper
    {
        public IQueryable<T> Data { get; private set; }
        public int MaxItems { get; set; }

        public ServerAutoCompleteSuggestHelper(RadDropDownListElement owner, IEnumerable<T> data, 
            int maxItems = 1000)
            : base(owner)
        {
            this.Data = data.AsQueryable();
            this.MaxItems = maxItems;
            ExpressionBuilder.Instance.Optimize(this.Data);
        }

        public override void ApplyFilterToDropDown(string filter)
        {
            this.DropDownList.BeginUpdate();

            this.DropDownList.ListElement.Items.Clear();

            var dataItemsExp = ExpressionBuilder.Instance.BuildContainsExpression<T>(this.Owner.AutoCompleteValueMember, filter);
            var dataItemsQuery = this.Data.Where(dataItemsExp).Take(this.MaxItems);
            var dataItems = dataItemsQuery.ToList();

            var selectExp = ExpressionBuilder.Instance.BuildSelectExpression<T>(this.Owner.AutoCompleteValueMember);
            var displayItemsQuery = dataItemsQuery.Select(selectExp);
            var displayItems = displayItemsQuery.ToList();

            for (int i = 0; i < dataItems.Count; i++)
            {
                var dataItem = dataItems[i];
                var displayMember = displayItems[i];
                this.DropDownList.ListElement.Items.Add(new RadListDataItem(displayMember, dataItem));
            }

            this.DropDownList.EndUpdate();
            this.Owner.SelectionLength = this.Owner.Text.Length;
        }
    }
}
