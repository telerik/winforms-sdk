using System;
using System.Collections.Generic;
using System.ComponentModel;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace GridSortExtend
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        Random rnd = new Random();
        BindingList<GridItem> data;

        public RadForm1()
        {
            InitializeComponent();
            data = new BindingList<GridItem>();
            for (int i = 0; i < 100000; i++)
            {
                data.Add(new GridItem("Text " + rnd.Next(100), i));
            }

            radGridView1.DataSource = data;
            radGridView1.MasterTemplate.SortComparer = new CustomComparer(this.radGridView1.SortDescriptors);
        }
    }
    
    public class GridItem
    {
        public string TextValue { get; set; }

        public int IntValue { get; set; }

        public GridItem(string textValue, int intValue)
        {
            this.TextValue = textValue;
            this.IntValue = intValue;
        }
    }

    public class CustomComparer : IComparer<GridViewRowInfo>
    {
        private SortDescriptorCollection sortDescriptors;

        public CustomComparer(SortDescriptorCollection sortDescriptors)
        {
            this.sortDescriptors = sortDescriptors;
        }

        public int Compare(GridViewRowInfo x, GridViewRowInfo y)
        {
            GridItem item1 = (GridItem)x.DataBoundItem;
            GridItem item2 = (GridItem)y.DataBoundItem;

            int result = 0;

            for (int i = 0; i < this.sortDescriptors.Count; i++)
            {
                result = this.CompareDataItems(item1, item2, this.sortDescriptors[i].PropertyName, this.sortDescriptors[i].Direction == ListSortDirection.Ascending);

                if (result != 0)
                {
                    return result;
                }
            }

            return result;
        }

        private int CompareDataItems(GridItem x, GridItem y, string propertyName, bool ascending)
        {
            int asc = (ascending) ? 1 : -1;

            switch (propertyName)
            {
                case "TextValue":
                    return x.TextValue.CompareTo(y.TextValue) * asc;
                case "IntValue":
                    return x.IntValue.CompareTo(y.IntValue) * asc;
            }

            return 0;
        }
    }
}