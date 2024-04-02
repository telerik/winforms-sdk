using System;
using Telerik.WinControls.UI;

namespace RadGridViewDynamicSummary_CS
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.radGridViewDynamicSummary1.AllowAddNewRow = false;
            this.radGridViewDynamicSummary1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            this.radGridViewDynamicSummary1.Columns.Add(new GridViewTextBoxColumn("Month"));
            this.radGridViewDynamicSummary1.Columns.Add(new GridViewDecimalColumn("Income"));
            this.radGridViewDynamicSummary1.Columns.Add(new GridViewDateTimeColumn("Date Paid"));


            GridViewRowInfo rowInfo = this.radGridViewDynamicSummary1.Rows.AddNew();
            rowInfo.Cells[0].Value = "January";
            rowInfo.Cells[1].Value = 22.5;
            rowInfo.Cells[2].Value = System.DateTime.Now.AddDays(-14);
            rowInfo = this.radGridViewDynamicSummary1.Rows.AddNew();
            rowInfo.Cells[0].Value = "February";
            rowInfo.Cells[1].Value = 30.65;
            rowInfo.Cells[2].Value = System.DateTime.Now.AddDays(-9);
            rowInfo = this.radGridViewDynamicSummary1.Rows.AddNew();
            rowInfo.Cells[0].Value = "March";
            rowInfo.Cells[1].Value = 4.65;
            rowInfo.Cells[2].Value = System.DateTime.Now.AddDays(-6);
            rowInfo = this.radGridViewDynamicSummary1.Rows.AddNew();
            rowInfo.Cells[0].Value = "April";
            rowInfo.Cells[1].Value = 21.57;
            rowInfo.Cells[2].Value = System.DateTime.Now.AddDays(-2);
            rowInfo = this.radGridViewDynamicSummary1.Rows.AddNew();
            rowInfo.Cells[0].Value = "May";
            rowInfo.Cells[1].Value = 24.65;
            rowInfo.Cells[2].Value = System.DateTime.Now.AddDays(-1);


            this.RadDropDownListSummaryPosition.Enabled = false;
            this.RadDropDownListSummaryColumn.Enabled = false;


            //// --------------------------------------------------------------------------------
            //// Demo implementation
            //// --------------------------------------------------------------------------------
            //Me.RadGridViewDynamicSummary1.EnableDynamicRowSummary(GridView.AggregateFunction.Max, _
            //                                                      CType(Me.RadGridViewDynamicSummary1.Columns(1), GridViewDecimalColumn), _
            //                                                      GridView.SummaryRowPosition.Bottom)
            //
            //And to Remove
            //Me.RadGridViewDynamicSummary1.DisableDynamicRowSummary()
            //// --------------------------------------------------------------------------------
            //// this is all you need to use this functionality
            //// --------------------------------------------------------------------------------

        }

        private void RadCheckBoxEnabled_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (RadCheckBoxEnabled.Checked)
            {
                this.RadDropDownListSummaryPosition.Enabled = true;
                this.RadDropDownListSummaryColumn.Enabled = true;

                SetUp();
            }
            else
            {
                this.RadDropDownListSummaryPosition.Enabled = false;
                this.RadDropDownListSummaryColumn.Enabled = false;

                this.radGridViewDynamicSummary1.DisableDynamicRowSummary();
            }

        }

        private void RadDropDownListSummaryPosition_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.RadCheckBoxEnabled.Checked)
            {
                SetUp();
            }

        }

        private void RadDropDownListSummaryColumn_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.RadCheckBoxEnabled.Checked)
            {
                SetUp();
            }

        }

        private void SetUp()
        {
            GridView.SummaryRowPosition summaryRowPosition = default(GridView.SummaryRowPosition);
            if (this.RadDropDownListSummaryPosition.SelectedIndex == 0)
            {
                summaryRowPosition = GridView.SummaryRowPosition.Top;
            }
            else
            {
                summaryRowPosition = GridView.SummaryRowPosition.Bottom;
            }

            GridViewDateTimeColumn summaryDateTimeColumn = (GridViewDateTimeColumn)this.radGridViewDynamicSummary1.Columns["Date Paid"];
            GridViewDecimalColumn summaryDecimalColumn = (GridViewDecimalColumn)this.radGridViewDynamicSummary1.Columns["Income"];

            if (this.RadDropDownListSummaryColumn.SelectedIndex == 0)
            {
                this.radGridViewDynamicSummary1.EnableDynamicRowSummary(GridView.AggregateFunction.Count, summaryDecimalColumn, summaryRowPosition);
            }
            else
            {
                this.radGridViewDynamicSummary1.EnableDynamicRowSummary(GridView.AggregateFunction.Count, summaryDateTimeColumn, summaryRowPosition);
            }
        }

        private void radGridViewDynamicSummary1_DynamicGroupSummaryChanged(object sender, GridView.DynamicGroupSummaryRowChangedEventArgs e)
        {

        }

        private void radGridViewDynamicSummary1_DynamicGroupSummaryChanged_1(object sender, GridView.DynamicGroupSummaryRowChangedEventArgs e)
        {
            if (e.IsEnabled)
            {
                this.RadListControlEvents.Items.Add("column: " + e.Column.ToString());
                this.RadListControlEvents.Items.Add("enabled: " + e.IsEnabled.ToString());
                this.RadListControlEvents.Items.Add("position: " + e.SummaryRowPosition.ToString());
                this.RadListControlEvents.Items.Add("function: " + e.AggregateFunction.ToString());
            }
            else
            {
                this.RadListControlEvents.Items.Add("enabled: " + e.IsEnabled.ToString());
            }
            this.RadListControlEvents.SelectedIndex = this.RadListControlEvents.Items.Count - 1;
        }

    }
}
