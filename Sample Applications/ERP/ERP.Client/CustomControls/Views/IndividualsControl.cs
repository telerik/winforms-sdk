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
    public class IndividualsControl : BaseGridControl 
    {
        private RelatedOrdersControl relatedOrdersControl;

        private List<Customer> data = new List<Customer>();

        protected override void Initialize()
        {
            this.dataFormText = "Edit Individual";
            this.relatedOrdersControl = new RelatedOrdersControl();
            this.relatedOrdersControl.Parent = this;
            this.relatedOrdersControl.Dock = DockStyle.Bottom;
            this.relatedOrdersControl.Height = 300;

            this.gridControl.SelectionChanged += this.GridControl_SelectionChanged;
            this.gridControl.ColumnCount = 9;
            this.columnTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(DateTime) };
            this.columnNames.Add("Account Number");
            this.columnNames.Add("First Name");
            this.columnNames.Add("Last Name");
            this.columnNames.Add("Email Address");
            this.columnNames.Add("Phone");
            this.columnNames.Add("Address Line 1");
            this.columnNames.Add("City");
            this.columnNames.Add("State");
            this.columnNames.Add("Modified Date");
            this.gridControl.RowCount = MainRepository.IndividualCustomersCache.Count();
            this.data = MainRepository.IndividualCustomersCache;   
            this.gridControl.MasterViewInfo.SetColumnDataType(this.columnTypes);
            this.gridControl.CellFormatting += this.GridControl_CellFormatting;
            this.ClearSelection();
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
                var item = this.data[this.gridControl.CurrentCell.RowIndex % this.gridControl.PageSize];
                this.relatedOrdersControl.OrdersGrid.DataSource = item.SalesOrderHeaders;
                this.currentItem = this.data[this.gridControl.CurrentCell.RowIndex % this.gridControl.PageSize];
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
                e.FieldName = FieldsHelper.IndividualsFields[e.ColumnIndex];

            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = this.columnNames[e.ColumnIndex];
            }

            if (e.RowIndex >= 0 && this.data.Count > 0)
            {
                var rowData = this.data[e.RowIndex % this.gridControl.PageSize] as Customer;

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

        protected override void DeleteCurrentRow()
        {
            MainRepository.IndividualCustomersCache.Remove(this.currentItem as Customer);
            this.ClearSelection();
        }

        protected override void RefreshData(int skip)
        {
            this.gridControl.RowCount = 0;

            var sortedData = SortHelper.Sort(MainRepository.IndividualCustomersCache, this.gridControl.SortDescriptors);
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
                selection.SetValue(this.data[i].AccountNumber);

                selection = worksheet.Cells[rowIndex, 1];
                selection.SetValue(this.data[i].FirstName);

                selection = worksheet.Cells[rowIndex, 2];
                selection.SetValue(this.data[i].LastName);

                selection = worksheet.Cells[rowIndex, 3];
                selection.SetValue(this.data[i].EmailAddress);

                selection = worksheet.Cells[rowIndex, 4];
                selection.SetValue(this.data[i].Phone);

                selection = worksheet.Cells[rowIndex, 5];
                selection.SetValue(this.data[i].AddressLine1);

                selection = worksheet.Cells[rowIndex, 6];
                selection.SetValue(this.data[i].City);

                selection = worksheet.Cells[rowIndex, 7];
                selection.SetValue(this.data[i].State);

                selection = worksheet.Cells[rowIndex, 8];
                selection.SetValue(this.data[i].ModifiedDate);

            }

            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
            worksheet.Name = "Individuals";
            return workbook;
        }
    }
}
