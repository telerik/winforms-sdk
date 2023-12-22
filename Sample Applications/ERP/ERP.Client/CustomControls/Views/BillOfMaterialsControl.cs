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
    class BillOfMaterialsControl : BaseGridControl
    {
        List<BillOfMaterial> data = new List<BillOfMaterial>();
        public Action<List<BillOfMaterial>> Callback { get; private set; }

        protected override void Initialize()
        {
            this.dataFormText = "Edit Bill of Material";
            this.gridControl.ColumnCount = 8;
            columnTypes = new Type[] { typeof(string), typeof(string), typeof(DateTime), typeof(DateTime), typeof(short), typeof(string), typeof(decimal), typeof(DateTime) };
            this.columnNames.Add("Parent Product");
            this.columnNames.Add("Child Product");
            this.columnNames.Add("Start Date");
            this.columnNames.Add("End Date");
            this.columnNames.Add("BOM Level");
            this.columnNames.Add("Unit Measure");
            this.columnNames.Add("Per Assembly Qty");
            this.columnNames.Add("Modified Date");

            this.gridControl.RowCount = MainRepository.Context.BillOfMaterials.Count();

            this.Callback = new Action<List<BillOfMaterial>>(query =>
            {
                this.data = query;
                this.gridControl.MasterViewInfo.IsWaiting = false;
                this.gridControl.TableElement.SynchronizeRows();
                MainRepository.Context.MergeOption = MergeOption.PreserveChanges;
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
                e.FieldName = FieldsHelper.BillOfMaterialsFields[e.ColumnIndex];

            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = columnNames[e.ColumnIndex];
            }
            if (e.RowIndex >= 0 && data.Count > 0)
            {
                var rowData = data[e.RowIndex % gridControl.PageSize] as BillOfMaterial;

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

        protected override void RefreshData(int skip)
        {
            data.Clear();
            MainRepository.Context.MergeOption = MergeOption.NoTracking;

            var query = SortHelper.Sort(MainRepository.GetBills(), this.gridControl.SortDescriptors);
            query = FilterHelper.Filter(query, this.gridControl.FilterDescriptors);
            gridControl.RowCount = query.Count();

            this.gridControl.MasterViewInfo.IsWaiting = true;

            ExecuteQueryAsync<List<BillOfMaterial>>(Task.Run(() => query.Skip(skip).Take(this.gridControl.PageSize).ToList()), this.Callback);
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
                selection.SetValue(data[i].Product.Name);

                selection = worksheet.Cells[rowIndex, 1];
                selection.SetValue(data[i].Product1.Name);

                selection = worksheet.Cells[rowIndex, 2];
                selection.SetValue(data[i].StartDate);

                selection = worksheet.Cells[rowIndex, 3];
                if (data[i].EndDate.HasValue)
                {
                    selection.SetValue(data[i].EndDate.Value);
                }

                selection = worksheet.Cells[rowIndex, 4];
                selection.SetValue(data[i].BOMLevel);

                selection = worksheet.Cells[rowIndex, 5];
                selection.SetValue(data[i].UnitMeasure.Name);

                selection = worksheet.Cells[rowIndex, 6];
                selection.SetValue(Convert.ToDouble(data[i].PerAssemblyQty));

                selection = worksheet.Cells[rowIndex, 7];
                selection.SetValue(data[i].ModifiedDate);
            }
            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
            worksheet.Name = "Bill Of Materials";
            return workbook;
        }
    }
}