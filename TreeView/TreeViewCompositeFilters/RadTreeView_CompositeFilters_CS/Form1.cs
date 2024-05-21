using System;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using System.Drawing;

namespace RadControlsWinFormsApp1
{
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void TreeView_SelectedNodeChanged(object sender, Telerik.WinControls.UI.RadTreeViewEventArgs e)
        {
            this.CommandBarTextBoxFilter.Text = e.Node.Text;
        }

        private void CommandBarButtonAdd_Click(object sender, EventArgs e)
        {

            foreach (RadListDataItem item in this.ListControlFilters.Items)
            {
                if (item.Text.ToUpperInvariant() == this.CommandBarTextBoxFilter.Text.ToUpperInvariant())
                { return; }
            }
            this.ListControlFilters.Items.Add(this.CommandBarTextBoxFilter.Text);
            Filter();
            this.CommandBarTextBoxFilter.Text = "";
        }

        private void CommandBarButtonRemoveFilter_Click(object sender, EventArgs e)
        {
            this.ListControlFilters.Items.Remove(this.ListControlFilters.SelectedItem);
            Filter();
        }

        private void ListControlFilters_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.CommandBarButtonRemoveFilter.Enabled = (this.ListControlFilters.SelectedItems.Count > 0);
        }

        private void Filter()
        {
            this.TreeView.FilterDescriptors.Clear();
            if (this.ListControlFilters.Items.Count > 0)
            { 
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                foreach (RadListDataItem item in this.ListControlFilters.Items)
                {
                    compositeFilter.FilterDescriptors.Add(new FilterDescriptor("Text", FilterOperator.Contains, item.Text));
                }
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                this.TreeView.FilterDescriptors.Add(compositeFilter);           
            }

        }

        private void CommandBarTextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            this.CommandBarButtonAddFilter.Enabled = (this.CommandBarTextBoxFilter.Text.Length > 0);
        }

        private void TreeView_NodeFormatting(object sender, TreeNodeFormattingEventArgs e)
        {
            if (this.ListControlFilters.FindStringExact(e.Node.Text) > -1)
            {
                e.NodeElement.BackColor = Color.LightGray;
                e.NodeElement.NumberOfColors = 1;
                e.NodeElement.DrawFill = true;
            }
        }
    }
}
