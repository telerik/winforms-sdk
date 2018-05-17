using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ServerSidePaging
{
    #region PageIndexChangingEvent
    public partial class ServerSidePagingVirtualGrid : Telerik.WinControls.UI.RadForm
    {
        private VirtualGridRepository repository;
        private IList<OrderDataModel> data;

        public ServerSidePagingVirtualGrid()
        {
            InitializeComponent();

            this.repository = new VirtualGridRepository();
            this.radVirtualGrid1.RowCount = this.repository.Orders.Count();
            this.radVirtualGrid1.ColumnCount = this.repository.ColumnNames.Length;

            this.radVirtualGrid1.EnablePaging = true;
            this.radVirtualGrid1.AutoSizeColumnsMode = Telerik.WinControls.UI.VirtualGridAutoSizeColumnsMode.Fill;
            this.SelectData(this.radVirtualGrid1.PageIndex);

            this.radVirtualGrid1.CellValueNeeded += RadVirtualGrid1_CellValueNeeded;
            this.radVirtualGrid1.PageChanging += RadVirtualGrid1_PageChanging;
        }

        private void RadVirtualGrid1_PageChanging(object sender, VirtualGridPageChangingEventArgs e)
        {
            this.SelectData(e.NewIndex);
        }

        private void RadVirtualGrid1_CellValueNeeded(object sender, Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = this.repository.ColumnNames[e.ColumnIndex];
            }

            if (e.RowIndex >= 0 && e.RowIndex < this.data.Count * (this.radVirtualGrid1.PageIndex + 1))
            {
                int index = e.RowIndex - this.radVirtualGrid1.PageSize * this.radVirtualGrid1.PageIndex;
                e.Value = this.data[index][e.ColumnIndex];
            }
        }

        private void SelectData(int pageIndex)
        {
            this.data = this.repository.Orders.Skip(pageIndex * this.radVirtualGrid1.PageSize).Take(this.radVirtualGrid1.PageSize).ToList();
        }
    }
    #endregion
}
