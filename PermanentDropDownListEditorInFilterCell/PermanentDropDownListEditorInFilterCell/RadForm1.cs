using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PermanentDropDownListEditorInFilterCell
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("IssueTitle", typeof(string));
            dt.Columns.Add("Priority", typeof(string));
            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    dt.Rows.Add(i, "Issue#" + i, "Low");
                }
                else
                {
                    dt.Rows.Add(i, "Issue#" + i, "High");
                }
            }

            this.radGridView1.AutoGenerateColumns = false;

            GridViewDecimalColumn idColumn = new GridViewDecimalColumn("Id");
            this.radGridView1.Columns.Add(idColumn);
            GridViewTextBoxColumn titleColumn = new GridViewTextBoxColumn("IssueTitle");
            this.radGridView1.Columns.Add(titleColumn);
            CustomColumn myColumn = new CustomColumn();
            myColumn.FieldName = myColumn.Name = myColumn.HeaderText = "Priority";
            this.radGridView1.Columns.Add(myColumn);

            this.radGridView1.DataSource = dt;
            this.radGridView1.BestFitColumns(BestFitColumnMode.AllCells);
            this.radGridView1.EnableFiltering = true;

            this.radGridView1.CellBeginEdit += radGridView1_CellBeginEdit;
        }

        private void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (e.Row is GridViewFilteringRowInfo && e.Column.Name == "Priority")
            {
                e.Cancel = true;
            }
        }
    }
}