using ERP.Repository;
using ERP.Repository.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Services.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using System.Data.Entity;
using Telerik.WinControls.Export;
using System.Windows.Forms;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using System.IO;
using Telerik.WinControls;

namespace ERP.Client
{
    class OrdersControl : BaseGridControl
    {
        OrderDetailsControl orderDetailsControl;

        List<SalesOrderHeader> data = new List<SalesOrderHeader>();
        public Action<List<SalesOrderHeader>> Callback { get; private set; }

        protected override void Initialize()
        {
            this.dataFormText = "Edit Order";
            orderDetailsControl = new OrderDetailsControl();
            orderDetailsControl.Parent = this;
            orderDetailsControl.Dock = DockStyle.Bottom;
            orderDetailsControl.Height = 330;
            orderDetailsControl.Margin = new Padding(3);

            this.gridControl.SelectionChanged += GridControl_SelectionChanged;
            columnTypes = new Type[] { typeof(string), typeof(string), typeof(DateTime), typeof(bool), typeof(string), typeof(decimal), typeof(decimal), typeof(decimal), typeof(DateTime) };
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

            this.gridControl.RowCount = MainRepository.GetPurchaseOrders().Count();

            this.Callback = new Action<List<SalesOrderHeader>>(query =>
            {
                this.data = query;              
                this.gridControl.MasterViewInfo.IsWaiting = false;
                this.gridControl.TableElement.SynchronizeRows();

            });
            this.gridControl.MasterViewInfo.IsWaiting = true;

            ExecuteQueryAsync<List<Product>>(Task.Run(() => MainRepository.ProductsCache.ToList()), new Action<List<Product>>(query => { this.RefreshData(0); }));
          
            this.gridControl.MasterViewInfo.SetColumnDataType(columnTypes);
            this.gridControl.CellFormatting += GridControl_CellFormatting;
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
                var item = data[this.gridControl.CurrentCell.RowIndex % gridControl.PageSize];
                orderDetailsControl.Data = item;
                currentItem = item;
            }
           
        }

        protected override void RadGridView1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {
            base.RadGridView1_CellValueNeeded(sender, e);
            if (e.ColumnIndex < 0)
                return;
            if (e.RowIndex < 0)
            {
                e.FieldName = FieldsHelper.OrdersFields[e.ColumnIndex];

            }
            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = columnNames[e.ColumnIndex];
            }
            if (e.RowIndex >= 0 && data.Count > 0)
            {
                var rowData = data[e.RowIndex % gridControl.PageSize] as SalesOrderHeader;

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
        protected override void RefreshData(int skip)
        {
            data.Clear();
 
            var query = SortHelper.Sort(MainRepository.GetSalesOrders(), this.gridControl.SortDescriptors);
            query = FilterHelper.Filter(query, this.gridControl.FilterDescriptors);
            gridControl.RowCount = query.Count();

            this.gridControl.MasterViewInfo.IsWaiting = true;
            ExecuteQueryAsync<List<SalesOrderHeader>>(Task.Run(() => query.Skip(skip).Take(this.gridControl.PageSize).ToList()), this.Callback);
        }

        protected override Workbook CreateWorkbook()
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            // set header
            for (int i = 0; i < columnNames.Count; i++)
            {
                CellSelection selection = worksheet.Cells[0, i];
                selection.SetValue(columnNames[i]);
            }

            for (int i = 0; i < data.Count; i++)
            {
                int rowIndex = i + 1;
                CellSelection selection = worksheet.Cells[rowIndex, 0];
                selection.SetValue(data[i].PurchaseOrderNumber);

                selection = worksheet.Cells[rowIndex, 1];
                selection.SetValue(data[i].Customer.FirstName + " " + data[i].Customer.LastName);

                selection = worksheet.Cells[rowIndex, 2];
                selection.SetValue(data[i].DueDate);

                selection = worksheet.Cells[rowIndex, 3];
                selection.SetValue(data[i].OnlineOrderFlag);

                selection = worksheet.Cells[rowIndex, 4];
                selection.SetValue(data[i].AccountNumber);

                selection = worksheet.Cells[rowIndex, 5];
                selection.SetValue(Convert.ToDouble(data[i].SubTotal));

                selection = worksheet.Cells[rowIndex, 6];
                selection.SetValue(Convert.ToDouble(data[i].TaxAmt));

                selection = worksheet.Cells[rowIndex, 7];
                selection.SetValue(Convert.ToDouble(data[i].Freight));

                selection = worksheet.Cells[rowIndex, 8];
                selection.SetValue(Convert.ToDouble(data[i].TotalDue));

                selection = worksheet.Cells[rowIndex, 8];
                selection.SetValue(data[i].ShipMethod.Name);
            }
            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
            worksheet.Name = "Orders";
            return workbook;


        }
    }
}
