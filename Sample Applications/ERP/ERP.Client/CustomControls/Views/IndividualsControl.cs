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
    class IndividualsControl : BaseGridControl
    {
        RelatedOrdersControl relatedOrdersControl;

        List<Customer> data = new List<Customer>();
        public Action<List<Customer>> Callback { get; private set; }

        protected override void Initialize()
        {
            this.dataFormText = "Edit Individual";
            relatedOrdersControl = new RelatedOrdersControl();
            relatedOrdersControl.Parent = this;
            relatedOrdersControl.Dock = DockStyle.Bottom;
            relatedOrdersControl.Height = 300;

            this.gridControl.SelectionChanged += GridControl_SelectionChanged;
            this.gridControl.ColumnCount = 9;
            columnTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(DateTime) };
            this.columnNames.Add("Account Number");
            this.columnNames.Add("First Name");
            this.columnNames.Add("Last Name");
            this.columnNames.Add("Email Address");
            this.columnNames.Add("Phone");
            this.columnNames.Add("Address Line 1");
            this.columnNames.Add("City");
            this.columnNames.Add("State");
            this.columnNames.Add("Modified Date");

            this.gridControl.RowCount = MainRepository.GetIndividualCustomers().Count();

            this.Callback = new Action<List<Customer>>(query =>
            {
                this.data = query;
                this.gridControl.MasterViewInfo.IsWaiting = false;
                this.gridControl.TableElement.SynchronizeRows();
            });

            this.RefreshData(0);
            this.gridControl.MasterViewInfo.SetColumnDataType(columnTypes);
            this.gridControl.CellFormatting += GridControl_CellFormatting;
        }

        private void GridControl_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement is VirtualGridFilterCellElement)
            {
                if (e.CellElement.ColumnIndex == 1 || e.CellElement.ColumnIndex == 2 || e.CellElement.ColumnIndex == 3 ||
                    e.CellElement.ColumnIndex == 4 || e.CellElement.ColumnIndex == 5 || e.CellElement.ColumnIndex == 6 ||
                    e.CellElement.ColumnIndex == 7)
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
                if (e.CellElement.ColumnIndex == 1 || e.CellElement.ColumnIndex == 2 || e.CellElement.ColumnIndex == 3 ||
                    e.CellElement.ColumnIndex == 4 || e.CellElement.ColumnIndex == 5 || e.CellElement.ColumnIndex == 6 ||
                    e.CellElement.ColumnIndex == 7)
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
                relatedOrdersControl.OrdersGrid.DataSource = item.SalesOrderHeaders;
                currentItem = data[this.gridControl.CurrentCell.RowIndex % this.gridControl.PageSize];
            }
    
        }

        protected override void RadGridView1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {
            base.RadGridView1_CellValueNeeded(sender, e);
            if (e.ColumnIndex < 0)
                return;
            if (e.RowIndex < 0)
            {
                e.FieldName = FieldsHelper.IndividualsFields[e.ColumnIndex];

            }
            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = columnNames[e.ColumnIndex];
            }
            if (e.RowIndex >= 0 && data.Count > 0)
            {
                var rowData = data[e.RowIndex % gridControl.PageSize] as Customer;

                switch (e.ColumnIndex)
                {
                    case 0:
                        e.Value = rowData.AccountNumber;
                        break;
                    case 1:
                        e.Value = rowData.FirstName;
                        break;
                    case 2:
                        e.Value = rowData.LastName;
                        break;
                    case 3:
                        e.Value = rowData.EmailAddress;
                        break;
                    case 4:
                        e.Value = rowData.Phone;
                        break;
                    case 5:
                        e.Value = rowData.AddressLine1;
                        break;
                    case 6:
                        e.Value = rowData.City;
                        break;
                    case 7:
                        e.Value = rowData.State;
                        break;
                    case 8:
                        e.Value = rowData.ModifiedDate;
                        e.FormatString = "{0:MM/dd/yyyy}";
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
            if (propertyName == "FirstName" || propertyName == "LastName" || propertyName == "EmailAddress" || propertyName == "Phone" || propertyName == "AddressLine1"
               || propertyName == "City" || propertyName == "State")
            {
                return;
            }
            var prop = typeof(Customer).GetProperty(propertyName).PropertyType;
            if (prop.IsValueType || prop == typeof(string))
            {
                base.RadGridView1_SortChanged(sender, e);
            }

        }
        protected override void RefreshData(int skip)
        {
            data.Clear();
            
            var query = SortHelper.Sort(MainRepository.GetIndividualCustomers(), this.gridControl.SortDescriptors);
            query = FilterHelper.Filter(query, this.gridControl.FilterDescriptors);
            gridControl.RowCount = query.Count();

            this.gridControl.MasterViewInfo.IsWaiting = true;
            ExecuteQueryAsync<List<Customer>>(Task.Run(() => query.Skip(skip).Take(this.gridControl.PageSize).ToList()), this.Callback);

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
                selection.SetValue(data[i].AccountNumber);

                selection = worksheet.Cells[rowIndex, 1];
                selection.SetValue(data[i].FirstName);

                selection = worksheet.Cells[rowIndex, 2];
                selection.SetValue(data[i].LastName);

                selection = worksheet.Cells[rowIndex, 3];
                selection.SetValue(data[i].EmailAddress);

                selection = worksheet.Cells[rowIndex, 4];
                selection.SetValue(data[i].Phone);

                selection = worksheet.Cells[rowIndex, 5];
                selection.SetValue(data[i].AddressLine1);

                selection = worksheet.Cells[rowIndex, 6];
                selection.SetValue(data[i].City);

                selection = worksheet.Cells[rowIndex, 7];
                selection.SetValue(data[i].State);

                selection = worksheet.Cells[rowIndex, 8];
                selection.SetValue(data[i].ModifiedDate);

            }
            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
            worksheet.Name = "Individuals";
            return workbook;
        }
    }
}
