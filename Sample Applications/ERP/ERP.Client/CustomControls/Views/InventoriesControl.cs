using ERP.Repository;
using ERP.Repository.Service;
using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ERP.Client
{
    class InventoriesControl : BaseGridControl
    {
        List<ProductInventory> data = new List<ProductInventory>();
        public Action<List<ProductInventory>> Callback { get; private set; }

        protected override void Initialize()
        {
            this.dataFormText = "Edit Product Inventory";
            columnTypes = new Type[] { typeof(string), typeof(string), typeof(short), typeof(string), typeof(short), typeof(string), typeof(decimal), typeof(decimal), typeof(string), typeof(byte), typeof(string) };
            this.gridControl.CreateCellElement += GridControl_CreateCellElement;
            this.columnNames.Add("Product Number");
            this.columnNames.Add("Product");
            this.columnNames.Add("Quantity");
            this.columnNames.Add("Color");
            this.columnNames.Add("Stock Level");
            this.columnNames.Add("Size");
            this.columnNames.Add("Price");
            this.columnNames.Add("Cost");
            this.columnNames.Add("Shelf");
            this.columnNames.Add("Bin");
            this.columnNames.Add("Location");
            this.gridControl.ColumnCount = columnNames.Count;

            this.gridControl.RowCount = MainRepository.Context.ProductInventories.Count();

            this.Callback = new Action<List<ProductInventory>>(query =>
            {
                this.data = query;
                this.gridControl.MasterViewInfo.IsWaiting = false;
                this.gridControl.TableElement.SynchronizeRows();
            });

            this.RefreshData(0);
            this.gridControl.SelectionChanged += GridControl_SelectionChanged;
            this.gridControl.MasterViewInfo.SetColumnDataType(columnTypes);
            this.gridControl.CellFormatting += GridControl_CellFormatting;
        }

        private void GridControl_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement is VirtualGridFilterCellElement)
            {
                if (e.CellElement.ColumnIndex == 0 || e.CellElement.ColumnIndex == 1 || e.CellElement.ColumnIndex == 3 ||
                    e.CellElement.ColumnIndex == 4 || e.CellElement.ColumnIndex == 5 || e.CellElement.ColumnIndex == 6 ||
                    e.CellElement.ColumnIndex == 7 || e.CellElement.ColumnIndex == 10 )
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
                if (e.CellElement.ColumnIndex == 0 || e.CellElement.ColumnIndex == 1 || e.CellElement.ColumnIndex == 3 ||
                    e.CellElement.ColumnIndex == 4 || e.CellElement.ColumnIndex == 5 || e.CellElement.ColumnIndex == 6 ||
                    e.CellElement.ColumnIndex == 7 || e.CellElement.ColumnIndex == 10)              
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
                currentItem = data[this.gridControl.CurrentCell.RowIndex % this.gridControl.PageSize];
            }
        }

        private void GridControl_CreateCellElement(object sender, VirtualGridCreateCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                e.CellElement = new ColorCellElement();
            }
        }

        protected override void RadGridView1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {
            base.RadGridView1_CellValueNeeded(sender, e);
            if (e.ColumnIndex < 0)
                return;
            if (e.RowIndex < 0)
            {
                e.FieldName = FieldsHelper.InventoriesFields[e.ColumnIndex];

            }
            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = columnNames[e.ColumnIndex];
            }
            if (e.RowIndex >= 0 && data.Count > 0)
            {
                var rowData = data[e.RowIndex % gridControl.PageSize] as ProductInventory;

                switch (e.ColumnIndex)
                {
                    case 0:
                        e.Value = rowData.ProductNumber;
                        break;
                    case 1:
                        e.Value = rowData.Product.Name;
                        break;
                    case 2:
                        e.Value = rowData.Quantity;
                        break;
                    case 3:
                        e.Value = rowData.Color;
                        break;
                    case 4:
                        e.Value = rowData.StockLevel;
                        break;
                    case 5:
                        e.Value = rowData.Size;
                        break;
                    case 6:
                        e.Value = rowData.Price;
                        break;
                    case 7:
                        e.Value = rowData.Cost;
                        break;
                    case 8:
                        e.Value = rowData.Shelf;
                        break;
                    case 9:
                        e.Value = rowData.Bin;
                        break;
                    case 10:
                        e.Value = rowData.Location.Name;
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
            if (propertyName == "Color" || propertyName == "ProductNumber" ||propertyName == "StockLevel" 
                || propertyName == "Size" || propertyName == "Cost" || propertyName == "Price" || propertyName == "Location")
            {
                return;
            }
            var prop = typeof(ProductInventory).GetProperty(propertyName).PropertyType;
            if (prop.IsValueType || prop == typeof(string))
            {
                base.RadGridView1_SortChanged(sender, e);
            }


        }
        protected override void RefreshData(int skip)
        {
            data.Clear();
            var query = SortHelper.Sort(MainRepository.Context.ProductInventories.Expand(p => p.Product).Expand(p => p.Location), this.gridControl.SortDescriptors);
            query = FilterHelper.Filter(query, this.gridControl.FilterDescriptors);
            gridControl.RowCount = query.Count();

            this.gridControl.MasterViewInfo.IsWaiting = true;
            ExecuteQueryAsync<List<ProductInventory>>(Task.Run(() => query.Skip(skip).Take(this.gridControl.PageSize).ToList()), this.Callback);
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
                selection.SetValue(data[i].ProductNumber);

                selection = worksheet.Cells[rowIndex, 1];
                selection.SetValue(data[i].Product.Name);

                selection = worksheet.Cells[rowIndex, 2];
                selection.SetValue(data[i].Quantity);

                selection = worksheet.Cells[rowIndex, 3];
                selection.SetValue(data[i].Color);

                selection = worksheet.Cells[rowIndex, 4];
                selection.SetValue(data[i].StockLevel);

                selection = worksheet.Cells[rowIndex, 5];
                selection.SetValue(data[i].Size);

                selection = worksheet.Cells[rowIndex, 6];
                selection.SetValue(Convert.ToDouble(data[i].Price));

                selection = worksheet.Cells[rowIndex, 7];
                selection.SetValue(Convert.ToDouble(data[i].Cost));

                selection = worksheet.Cells[rowIndex, 8];
                selection.SetValue(data[i].Shelf);

                selection = worksheet.Cells[rowIndex, 9];
                selection.SetValue(data[i].Bin);

                selection = worksheet.Cells[rowIndex, 10];
                selection.SetValue(data[i].Location.Name);


            }
            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
            worksheet.Name = "Inventories";
            return workbook;
        }
    }
}
