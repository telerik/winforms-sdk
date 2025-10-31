using ERP.Repository;
using ERP.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ERP.Client
{
    internal class InventoriesControl : BaseGridControl
    {
        private List<ProductInventory> data = new List<ProductInventory>();

        protected override void Initialize()
        {
            this.dataFormText = "Edit Product Inventory";
            this.columnTypes = new Type[] { typeof(string), typeof(string), typeof(short), typeof(string), typeof(short), typeof(string), typeof(decimal), typeof(decimal), typeof(string), typeof(byte), typeof(string) };
            this.gridControl.CreateCellElement += this.GridControl_CreateCellElement;
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
            this.gridControl.ColumnCount = this.columnNames.Count;
            this.gridControl.RowCount = MainRepository.ProductInventoryCache.Count();
            this.data = MainRepository.ProductInventoryCache;
            this.gridControl.SelectionChanged += this.GridControl_SelectionChanged;
            this.gridControl.MasterViewInfo.SetColumnDataType(this.columnTypes);
            this.gridControl.CellFormatting += this.GridControl_CellFormatting;
            this.ClearSelection();
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
                this.currentItem = this.data[this.gridControl.CurrentCell.RowIndex % this.gridControl.PageSize];
            }
        }

        private void GridControl_CreateCellElement(object sender, VirtualGridCreateCellEventArgs e)
        {
            if (e.CellType == typeof(VirtualGridCellElement))
            {
                if (e.ColumnIndex == 3 && e.RowIndex >= 0)
                {
                    e.CellElement = new ColorCellElement();
                }
                else
                {
                    e.CellElement = new DefaultVirtualGridCellElement() { ExcludeColumnIndex = 3 };
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
                e.FieldName = FieldsHelper.InventoriesFields[e.ColumnIndex];

            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = this.columnNames[e.ColumnIndex];
            }

            if (e.RowIndex >= 0 && this.data.Count > 0)
            {
                var rowData = this.data[e.RowIndex % this.gridControl.PageSize] as ProductInventory;

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

        protected override void DeleteCurrentRow()
        {
            MainRepository.ProductInventoryCache.Remove(this.currentItem as ProductInventory);
            this.ClearSelection();
        }

        protected override void RefreshData(int skip)
        {
            this.gridControl.RowCount = 0;

            var sortedData = SortHelper.Sort(MainRepository.ProductInventoryCache, this.gridControl.SortDescriptors);
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
                selection.SetValue(this.data[i].ProductNumber);

                selection = worksheet.Cells[rowIndex, 1];
                selection.SetValue(this.data[i].Product.Name);

                selection = worksheet.Cells[rowIndex, 2];
                selection.SetValue(this.data[i].Quantity);

                selection = worksheet.Cells[rowIndex, 3];
                selection.SetValue(this.data[i].Color);

                selection = worksheet.Cells[rowIndex, 4];
                selection.SetValue(this.data[i].StockLevel);

                selection = worksheet.Cells[rowIndex, 5];
                selection.SetValue(this.data[i].Size);

                selection = worksheet.Cells[rowIndex, 6];
                selection.SetValue(Convert.ToDouble(this.data[i].Price));

                selection = worksheet.Cells[rowIndex, 7];
                selection.SetValue(Convert.ToDouble(this.data[i].Cost));

                selection = worksheet.Cells[rowIndex, 8];
                selection.SetValue(this.data[i].Shelf);

                selection = worksheet.Cells[rowIndex, 9];
                selection.SetValue(this.data[i].Bin);

                selection = worksheet.Cells[rowIndex, 10];
                selection.SetValue(this.data[i].Location.Name);


            }

            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
            worksheet.Name = "Inventories";
            return workbook;
        }
    }
}
