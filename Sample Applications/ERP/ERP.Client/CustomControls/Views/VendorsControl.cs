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
using System.Drawing;

namespace ERP.Client
{
    class VendorsControl : BaseGridControl
    {
        List<Vendor> data = new List<Vendor>();
        public Action<List<Vendor>> Callback { get; private set; }

        protected override void Initialize()
        {
            this.dataFormText = "Edit Supplier";
            columnTypes = new Type[] { typeof(string), typeof(string), typeof(byte), typeof(string), typeof(string), typeof(string), typeof(DateTime) };
            this.gridControl.ColumnCount = 7;
            this.gridControl.CreateCellElement += GridControl_CreateCellElement;

            this.columnNames.Add("Account Number");
            this.columnNames.Add("Name");
            this.columnNames.Add("Credit Rating");
            this.columnNames.Add("Preference");
            this.columnNames.Add("ActiveStaus");
            this.columnNames.Add("URL");
            this.columnNames.Add("Modified Date");


            this.gridControl.RowCount = MainRepository.Context.Vendors.Count();

            this.Callback = new Action<List<Vendor>>(query =>
            {
                this.data = query;
                this.gridControl.MasterViewInfo.IsWaiting = false;
                this.gridControl.TableElement.SynchronizeRows();
            });


            this.RefreshData(0);
            this.gridControl.CellFormatting += GridControl_CellFormatting;
            this.gridControl.SelectionChanged += GridControl_SelectionChanged;
            this.gridControl.MasterViewInfo.SetColumnDataType(columnTypes);
        }

        private void GridControl_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gridControl.CurrentCell != null && this.gridControl.CurrentCell.RowIndex >= 0)
            {
                currentItem = data[this.gridControl.CurrentCell.RowIndex % this.gridControl.PageSize];
            }
        }

        private void GridControl_CreateCellElement(object sender, VirtualGridCreateCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                e.CellElement = new RatingCellElement();
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
                return;
            if (e.RowIndex < 0)
            {
                e.FieldName = FieldsHelper.VendorFields[e.ColumnIndex];
            }
            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = columnNames[e.ColumnIndex];
                e.FieldName = FieldsHelper.VendorFields[e.ColumnIndex];
            }
            if (e.RowIndex >= 0 && data.Count > 0)
            {
                if ((e.RowIndex % gridControl.PageSize) >= data.Count)
                {
                    return;
                }
                var rowData = data[e.RowIndex % gridControl.PageSize] as Vendor;

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

        protected override void RefreshData(int skip)
        {
            data.Clear();
            var query = SortHelper.Sort(MainRepository.Context.Vendors, this.gridControl.SortDescriptors);
            query = FilterHelper.Filter(query, this.gridControl.FilterDescriptors);
            gridControl.RowCount = query.Count();

            this.gridControl.MasterViewInfo.IsWaiting = true;
            ExecuteQueryAsync<List<Vendor>>(Task.Run(() => query.Skip(skip).Take(this.gridControl.PageSize).ToList()), this.Callback);
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
                selection.SetValue(data[i].Name);

                selection = worksheet.Cells[rowIndex, 2];
                selection.SetValue(data[i].CreditRating);

                selection = worksheet.Cells[rowIndex, 3];
                selection.SetValue(data[i].PreferredVendorStatus);

                selection = worksheet.Cells[rowIndex, 4];
                selection.SetValue(data[i].ActiveFlag);

                selection = worksheet.Cells[rowIndex, 5];
                selection.SetValue(data[i].PurchasingWebServiceURL);

                selection = worksheet.Cells[rowIndex, 6];
                selection.SetValue(data[i].ModifiedDate);
            }
            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
            worksheet.Name = "Suppliers";
            return workbook;
        }
    }
}

