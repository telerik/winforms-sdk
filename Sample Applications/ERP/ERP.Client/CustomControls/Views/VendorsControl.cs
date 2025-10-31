using ERP.Repository;
using ERP.Repository.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ERP.Client
{
   public class VendorsControl : BaseGridControl
    {
        private List<Vendor> data = new List<Vendor>();

        public Action<List<Vendor>> Callback { get; private set; }

        protected override void Initialize()
        {
            this.dataFormText = "Edit Supplier";
            this.columnTypes = new Type[] { typeof(string), typeof(string), typeof(byte), typeof(string), typeof(string), typeof(string), typeof(DateTime) };
            this.gridControl.ColumnCount = 7;
            this.gridControl.CreateCellElement += this.GridControl_CreateCellElement;

            this.columnNames.Add("Account Number");
            this.columnNames.Add("Name");
            this.columnNames.Add("Credit Rating");
            this.columnNames.Add("Preference");
            this.columnNames.Add("ActiveStaus");
            this.columnNames.Add("URL");
            this.columnNames.Add("Modified Date");

            this.gridControl.RowCount = MainRepository.VendorsCache.Count();
            this.data = MainRepository.VendorsCache;     
            this.gridControl.CellFormatting += this.GridControl_CellFormatting;
            this.gridControl.SelectionChanged += this.GridControl_SelectionChanged;
            this.gridControl.MasterViewInfo.SetColumnDataType(this.columnTypes);
            this.ClearSelection();
        }

        private void GridControl_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridControl.CurrentCell != null && this.gridControl.CurrentCell.RowIndex >= 0)
            {
                this.currentItem = this.data[this.gridControl.CurrentCell.RowIndex % this.gridControl.PageSize];
            }
        }

        private void GridControl_CreateCellElement(object sender, VirtualGridCreateCellEventArgs e)
        {
            if (e.CellType == typeof(VirtualGridCellElement))
            {
                if (e.ColumnIndex == 2 && e.RowIndex >= 0)
                {
                    e.CellElement = new RatingCellElement();
                }
                else
                {
                    e.CellElement = new DefaultVirtualGridCellElement() { ExcludeColumnIndex = 2 };
                }
            }
        }

        private void GridControl_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement.RowIndex < 0)
            {
                return;
            }

            if (e.CellElement.ColumnIndex == 4 && e.CellElement.Value != null)
            {
                var value = (bool)e.CellElement.Value;
                if (value)
                {
                    e.CellElement.ForeColor = Color.Green;
                    e.CellElement.Text = "Active";
                }
                else
                {
                    e.CellElement.ForeColor = Color.Red;
                    e.CellElement.Text = "Inactive";
                }
            }

            else if (e.CellElement.ColumnIndex == 3 && e.CellElement.Value != null)
            {
                var value = (bool)e.CellElement.Value;
                if (value)
                {
                    e.CellElement.ForeColor = Color.Green;
                    e.CellElement.Text = "Preferred";
                }
                else
                {
                    e.CellElement.ForeColor = Color.Gold;
                    e.CellElement.Text = "Not Preferred";
                }
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
                e.FieldName = FieldsHelper.VendorFields[e.ColumnIndex];
            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = this.columnNames[e.ColumnIndex];
                e.FieldName = FieldsHelper.VendorFields[e.ColumnIndex];
            }

            if (e.RowIndex >= 0 && this.data.Count > 0)
            {
                if ((e.RowIndex % this.gridControl.PageSize) >= this.data.Count)
                {
                    return;
                }

                var rowData = this.data[e.RowIndex % this.gridControl.PageSize] as Vendor;

                switch (e.ColumnIndex)
                {
                    case 0:
                        e.Value = rowData.AccountNumber;
                        break;
                    case 1:
                        e.Value = rowData.Name;
                        break;
                    case 2:
                        e.Value = rowData.CreditRating;
                        break;
                    case 3:
                        e.Value = rowData.PreferredVendorStatus;
                        break;
                    case 4:
                        e.Value = rowData.ActiveFlag;
                        break;
                    case 5:
                        e.Value = rowData.PurchasingWebServiceURL;
                        break;
                    case 6:
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
            var prop = typeof(Vendor).GetProperty(propertyName).PropertyType;
            
            if (prop.IsValueType || prop == typeof(string))
            {
                base.RadGridView1_SortChanged(sender, e);
            }           
        }

        protected override void DeleteCurrentRow()
        {
            MainRepository.VendorsCache.Remove(this.currentItem as Vendor);
            this.ClearSelection();
        }

        protected override void RefreshData(int skip)
        {
            this.gridControl.RowCount = 0;

            var sortedData = SortHelper.Sort(MainRepository.VendorsCache, this.gridControl.SortDescriptors);
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
                selection.SetValue(this.data[i].Name);

                selection = worksheet.Cells[rowIndex, 2];
                selection.SetValue(this.data[i].CreditRating);

                selection = worksheet.Cells[rowIndex, 3];
                selection.SetValue(this.data[i].PreferredVendorStatus);

                selection = worksheet.Cells[rowIndex, 4];
                selection.SetValue(this.data[i].ActiveFlag);

                selection = worksheet.Cells[rowIndex, 5];
                selection.SetValue(this.data[i].PurchasingWebServiceURL);

                selection = worksheet.Cells[rowIndex, 6];
                selection.SetValue(this.data[i].ModifiedDate);
            }

            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
            worksheet.Name = "Suppliers";
            return workbook;
        }
    }
}

