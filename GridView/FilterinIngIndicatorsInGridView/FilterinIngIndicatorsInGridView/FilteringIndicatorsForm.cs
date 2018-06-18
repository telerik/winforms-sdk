using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace FilterinIngIndicatorsInGridView
{
    #region InitialSetupAndEvents
    public partial class FilteringIndicatorsForm : Telerik.WinControls.UI.RadForm
    {
        public FilteringIndicatorsForm()
        {
            InitializeComponent();

            this.radGridView1.CreateCell += RadGridView1_CreateCell;

            BaseGridBehavior gridBehavior = radGridView1.GridBehavior as BaseGridBehavior;
            gridBehavior.UnregisterBehavior(typeof(GridViewFilteringRowInfo));
            gridBehavior.RegisterBehavior(typeof(GridViewFilteringRowInfo), new MyGridFilterRowBehavior());

            this.radGridView1.DataSource = this.GetData();
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.EnableFiltering = true;
        }

        private void RadGridView1_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridFilterCellElement))
            {
                e.CellElement = new MyGridFilterCellElement((GridViewDataColumn)e.Column, e.Row);
            }
            else if (e.CellType == typeof(GridRowHeaderCellElement))
            {
                e.CellElement = new MyGridRowHeaderCellElement(e.Column, e.Row);
            }
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Bool", typeof(bool));
            for (int i = 0; i < 20; i++)
            {
                dt.Rows.Add(i, "Name " + i, DateTime.Now.AddDays(i), i % 2 == 0);
            }

            return dt;
        }
    }
    #endregion
}
