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
    public class BillOfMaterialsControl : BaseGridControl
    {
        private List<BillOfMaterial> data = new List<BillOfMaterial>();

        protected override void Initialize()
        {
            this.dataFormText = "Edit Bill of Material";
            this.gridControl.ColumnCount = 8;
            this.columnTypes = new Type[] { typeof(string), typeof(string), typeof(DateTime), typeof(DateTime), typeof(short), typeof(string), typeof(decimal), typeof(DateTime) };
            this.columnNames.Add("Parent Product");
            this.columnNames.Add("Child Product");
            this.columnNames.Add("Start Date");
            this.columnNames.Add("End Date");
            this.columnNames.Add("BOM Level");
            this.columnNames.Add("Unit Measure");
            this.columnNames.Add("Per Assembly Qty");
            this.columnNames.Add("Modified Date");

            this.gridControl.RowCount = MainRepository.BillsCache.Count();
            this.data = MainRepository.BillsCache;
            this.gridControl.SelectionChanged += this.GridControl_SelectionChanged;
            this.gridControl.MasterViewInfo.SetColumnDataType(this.columnTypes);
            this.gridControl.CellFormatting += this.GridControl_CellFormatting;
            this.ClearSelection();
        }

        private void GridControl_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement is VirtualGridFilterCellElement)
            {
                if (e.CellElement.ColumnIndex == 0 || e.CellElement.ColumnIndex == 1 || e.CellElement.ColumnIndex == 5)
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
                if (e.CellElement.ColumnIndex == 0 || e.CellElement.ColumnIndex == 1 || e.CellElement.ColumnIndex == 5)
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

        protected override void RadGridView1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {
            base.RadGridView1_CellValueNeeded(sender, e);

            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.RowIndex < 0)
            {
                e.FieldName = FieldsHelper.BillOfMaterialsFields[e.ColumnIndex];
            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = this.columnNames[e.ColumnIndex];
            }

            if (e.RowIndex >= 0 && this.data.Count > 0)
            {
                var rowData = this.data[e.RowIndex % this.gridControl.PageSize] as BillOfMaterial;

                switch (e.ColumnIndex)
                {
                    case 0:
                        if (rowData.Product == null)
                        {
                            break;
                        }

                        e.Value = rowData.Product.Name;
                        break;
                    case 1:
                        if (rowData.Product1 != null)
                        {
                            e.Value = rowData.Product1.Name;
                        } 
                        
                        break;
                    case 2:
                        e.Value = rowData.StartDate;
                        e.FormatString = "{0:MM/dd/yyyy}";
                        break;
                    case 3:
                        e.Value = rowData.EndDate;
                        e.FormatString = "{0:MM/dd/yyyy}";
                        break;
                    case 4:
                        e.Value = rowData.BOMLevel;
                        break;
                    case 5:
                        if (rowData.UnitMeasure == null)
                        {
                            break;
                        }

                        e.Value = rowData.UnitMeasure.Name;
                        break;
                    case 6:
                        e.Value = rowData.PerAssemblyQty;
                        break;
                    case 7:
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
            var prop = typeof(BillOfMaterial).GetProperty(propertyName).PropertyType;
            if (prop.IsValueType || prop == typeof(string))
            {
                base.RadGridView1_SortChanged(sender, e);
            }
        }

        protected override void DeleteCurrentRow()
        {
            MainRepository.BillsCache.Remove(this.currentItem as BillOfMaterial);
            this.ClearSelection();
        }

        protected override void RefreshData(int skip)
        {
            this.gridControl.RowCount = 0;

            var sortedData = SortHelper.Sort(MainRepository.BillsCache, this.gridControl.SortDescriptors);
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
                selection.SetValue(this.data[i].Product.Name);

                selection = worksheet.Cells[rowIndex, 1];
                selection.SetValue(this.data[i].Product1.Name);

                selection = worksheet.Cells[rowIndex, 2];
                selection.SetValue(this.data[i].StartDate);

                selection = worksheet.Cells[rowIndex, 3];
                if (this.data[i].EndDate.HasValue)
                {
                    selection.SetValue(this.data[i].EndDate.Value);
                }

                selection = worksheet.Cells[rowIndex, 4];
                selection.SetValue(this.data[i].BOMLevel);

                selection = worksheet.Cells[rowIndex, 5];
                selection.SetValue(this.data[i].UnitMeasure.Name);

                selection = worksheet.Cells[rowIndex, 6];
                selection.SetValue(Convert.ToDouble(this.data[i].PerAssemblyQty));

                selection = worksheet.Cells[rowIndex, 7];
                selection.SetValue(this.data[i].ModifiedDate);
            }

            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
            worksheet.Name = "Bill Of Materials";
            return workbook;
        }
    }
}