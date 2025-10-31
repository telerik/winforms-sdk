using ERP.Repository;
using ERP.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ERP.Client
{
    internal class OrdersControl : BaseGridControl
    {
        private OrderDetailsControl orderDetailsControl;

        private List<SalesOrderHeader> data = new List<SalesOrderHeader>();

        protected override void Initialize()
        {
            this.dataFormText = "Edit Order";
            this.orderDetailsControl = new OrderDetailsControl();
            this.orderDetailsControl.Parent = this;
            this.orderDetailsControl.Dock = DockStyle.Bottom;
            this.orderDetailsControl.Height = 330;
            this.orderDetailsControl.Margin = new Padding(3);

            this.gridControl.SelectionChanged += this.GridControl_SelectionChanged;
            this.columnTypes = new Type[] { typeof(string), typeof(string), typeof(DateTime), typeof(bool), typeof(string), typeof(decimal), typeof(decimal), typeof(decimal), typeof(DateTime) };
            this.gridControl.ColumnCount = 10;

            this.columnNames.Add("Order Number");
            this.columnNames.Add("Customer");
            this.columnNames.Add("Due Date");
            this.columnNames.Add("Is Online Order");
            this.columnNames.Add("Account Number");
            this.columnNames.Add("Sub Total");
            this.columnNames.Add("Tax Amount");
            this.columnNames.Add("Freight");
            this.columnNames.Add("Total Due");
            this.columnNames.Add("Ship Method");
            this.gridControl.RowCount = MainRepository.OrdersCache.Count;
            this.data = MainRepository.OrdersCache;
          
            this.gridControl.MasterViewInfo.SetColumnDataType(this.columnTypes);
            this.gridControl.CellFormatting += this.GridControl_CellFormatting;
            this.ClearSelection();
        }

        private void GridControl_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement is VirtualGridFilterCellElement)
            {
                if (e.CellElement.ColumnIndex == 1  || e.CellElement.ColumnIndex == 9)
                {
                    e.CellElement.Enabled = false;
                }
                else
                {
                    e.CellElement.ResetValue(RadItem.EnabledProperty, ValueResetFlags.Local);
                }
            }

            if (e.CellElement is VirtualGridHeaderCellElement)
            {
                var cell = e.CellElement as VirtualGridHeaderCellElement;
                if (e.CellElement.ColumnIndex == 1 || e.CellElement.ColumnIndex == 9)
                {
                    cell.Arrow.ShouldPaint = false;
                }
                else
                {
                    cell.Arrow.ResetValue(LightVisualElement.ShouldPaintProperty, ValueResetFlags.Local);
                }
            }
        }

        private void GridControl_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridControl.CurrentCell != null && this.gridControl.CurrentCell.RowIndex >= 0)
            {
                var item = this.data[this.gridControl.CurrentCell.RowIndex % this.gridControl.PageSize];
                this.orderDetailsControl.Data = item;
                this.currentItem = item;
            }           
        }

        protected override void RadGridView1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {
            base.RadGridView1_CellValueNeeded(sender, e);
            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.RowIndex < 0)
            {
                e.FieldName = FieldsHelper.OrdersFields[e.ColumnIndex];

            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = this.columnNames[e.ColumnIndex];
            }

            if (e.RowIndex >= 0 && this.data.Count > 0)
            {
                var rowData = this.data[e.RowIndex % this.gridControl.PageSize] as SalesOrderHeader;

                switch (e.ColumnIndex)
                {
                    case 0:
                        e.Value = rowData.SalesOrderNumber;
                        break;
                    case 1:
                        e.Value = rowData.Customer.FirstName + " " + rowData.Customer.LastName;
                        break;
                    case 2:
                        e.Value = rowData.DueDate;
                        e.FormatString = "{0:MM/dd/yyyy}";
                        break;
                    case 3:
                        e.Value = rowData.OnlineOrderFlag;
                        break;
                    case 4:
                        e.Value = rowData.AccountNumber;
                        break;
                    case 5:
                        e.Value = rowData.SubTotal;
                        break;
                    case 6:
                        e.Value = rowData.TaxAmt;
                        break;
                    case 7:
                        e.Value = rowData.Freight;
                        break;
                    case 8:
                        e.Value = rowData.TotalDue;
                        break;
                    case 9:
                        e.Value = rowData.ShipMethod.Name;
                        break;
                }
            }
        }

        protected override void RadGridView1_SortChanged(object sender, VirtualGridEventArgs e)
        {
            if (e.ViewInfo.SortDescriptors.Count == 0)
            {
                return;
            }

            var propertyName = e.ViewInfo.SortDescriptors[0].PropertyName;
            var prop = typeof(SalesOrderHeader).GetProperty(propertyName).PropertyType;
            if (prop.IsValueType || prop == typeof(string))
            {
                base.RadGridView1_SortChanged(sender, e);
            }
        }

        protected override void DeleteCurrentRow()
        {
            MainRepository.OrdersCache.Remove(this.currentItem as SalesOrderHeader);
            this.ClearSelection();
        }

        protected override void RefreshData(int skip)
        {
            this.gridControl.RowCount = 0;

            var sortedData = SortHelper.Sort(MainRepository.OrdersCache, this.gridControl.SortDescriptors);
            var filteredData = FilterHelper.Filter(sortedData, this.gridControl.FilterDescriptors);

            this.data = filteredData.Skip(skip).Take(this.gridControl.PageSize).ToList();
            this.gridControl.RowCount = filteredData.Count();
        }

        protected override Workbook CreateWorkbook()
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            // set header
            for (int i = 0; i < this.columnNames.Count; i++)
            {
                CellSelection selection = worksheet.Cells[0, i];
                selection.SetValue(this.columnNames[i]);
            }

            for (int i = 0; i < this.data.Count; i++)
            {
                int rowIndex = i + 1;
                CellSelection selection = worksheet.Cells[rowIndex, 0];
                selection.SetValue(this.data[i].PurchaseOrderNumber);

                selection = worksheet.Cells[rowIndex, 1];
                selection.SetValue(this.data[i].Customer.FirstName + " " + this.data[i].Customer.LastName);

                selection = worksheet.Cells[rowIndex, 2];
                selection.SetValue(this.data[i].DueDate);

                selection = worksheet.Cells[rowIndex, 3];
                selection.SetValue(this.data[i].OnlineOrderFlag);

                selection = worksheet.Cells[rowIndex, 4];
                selection.SetValue(this.data[i].AccountNumber);

                selection = worksheet.Cells[rowIndex, 5];
                selection.SetValue(Convert.ToDouble(this.data[i].SubTotal));

                selection = worksheet.Cells[rowIndex, 6];
                selection.SetValue(Convert.ToDouble(this.data[i].TaxAmt));

                selection = worksheet.Cells[rowIndex, 7];
                selection.SetValue(Convert.ToDouble(this.data[i].Freight));

                selection = worksheet.Cells[rowIndex, 8];
                selection.SetValue(Convert.ToDouble(this.data[i].TotalDue));

                selection = worksheet.Cells[rowIndex, 8];
                selection.SetValue(this.data[i].ShipMethod.Name);
            }

            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
            worksheet.Name = "Orders";
            return workbook;
        }
    }
}
