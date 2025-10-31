﻿using ERP.Repository;
using ERP.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ERP.Client
{
    internal class PurchasesControl : BaseGridControl
    {
        private List<PurchaseOrderHeader> data = new List<PurchaseOrderHeader>();
        private List<PurchaseOrderDetail> detailsData = new List<PurchaseOrderDetail>();
        private List<string> detailsViewColumnNames = new List<string>();

        protected override void Initialize()
        {
            this.dataFormText = "Edit Purchase";
            this.gridControl.ColumnCount = 10;
            this.columnTypes = new Type[] { typeof(string), typeof(DateTime), typeof(DateTime), typeof(decimal), typeof(decimal), typeof(decimal), typeof(decimal), typeof(DateTime), typeof(string), typeof(string) };

            this.columnNames.Add("Order Status");
            this.columnNames.Add("Order Date");
            this.columnNames.Add("Ship Date");
            this.columnNames.Add("Sub Total");
            this.columnNames.Add("Tax Amount");
            this.columnNames.Add("Freight");
            this.columnNames.Add("Total Due");
            this.columnNames.Add("Modified Date");
            this.columnNames.Add("Ship Method");
            this.columnNames.Add("Vendor");

            this.gridControl.RowCount = MainRepository.PurchaseOrdersCache.Count();
            this.data = MainRepository.PurchaseOrdersCache;
            this.gridControl.MasterViewInfo.IsWaiting = false;
            this.gridControl.TableElement.SynchronizeRows();
            // this.RefreshData(0);

            this.detailsViewColumnNames.Add("Product");
            this.detailsViewColumnNames.Add("Quantity");
            this.detailsViewColumnNames.Add("Received Quantity");
            this.detailsViewColumnNames.Add("Rejected Quantity");
            this.detailsViewColumnNames.Add("Stocked Quantity");
            this.detailsViewColumnNames.Add("Price per Unit");
            this.detailsViewColumnNames.Add("Total Price");
            this.detailsViewColumnNames.Add("Due Date");
            this.detailsViewColumnNames.Add("Modified Date");

            this.gridControl.RowExpanding += this.GridControl_RowExpanding;
            this.gridControl.QueryHasChildRows += this.GridControl_QueryHasChildRows;
            this.gridControl.SelectionChanged += this.GridControl_SelectionChanged;

            this.gridControl.CellFormatting += this.GridControl_CellFormatting;
            this.gridControl.MasterViewInfo.SetColumnDataType(this.columnTypes);
            this.gridControl.RowFormatting += this.GridControl_RowFormatting;
            this.ClearSelection();
        }

        private void GridControl_RowFormatting(object sender, VirtualGridRowElementEventArgs e)
        {
            if (e.ViewInfo != this.gridControl.MasterViewInfo && e.RowElement is VirtualGridFilterRowElement)
            {
                e.RowElement.Visibility = ElementVisibility.Collapsed;
            }
            else
            {
                e.RowElement.ResetValue(RadItem.VisibilityProperty, ValueResetFlags.Local);
            }
        }

        private void GridControl_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement is VirtualGridFilterCellElement)
            {
                if (e.CellElement.ColumnIndex == 0 || e.CellElement.ColumnIndex == 9 || e.CellElement.ColumnIndex == 8)
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
                if (e.CellElement.ColumnIndex == 0 || e.CellElement.ColumnIndex == 9 || e.CellElement.ColumnIndex == 8)
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
                this.currentItem = this.data[this.gridControl.CurrentCell.RowIndex % this.gridControl.PageSize] as PurchaseOrderHeader;
            }
        }

        private void GridControl_QueryHasChildRows(object sender, VirtualGridQueryHasChildRowsEventArgs e)
        {
            e.HasChildRows = e.ViewInfo == this.gridControl.MasterViewInfo;
        }

        private void GridControl_RowExpanding(object sender, VirtualGridRowExpandingEventArgs e)
        {
            this.detailsData = this.data[e.RowIndex % this.gridControl.PageSize].PurchaseOrderDetails.ToList();
            e.ChildViewInfo.RowCount = this.detailsData.Count;
            e.ChildViewInfo.ColumnCount = this.detailsViewColumnNames.Count;
        }

        protected override void RadGridView1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {
            base.RadGridView1_CellValueNeeded(sender, e);
            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.ViewInfo == this.gridControl.MasterViewInfo)
            {
                if (e.RowIndex < 0)
                {
                    e.FieldName = FieldsHelper.PurchaseOrderHeaderFields[e.ColumnIndex];
                }

                if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
                {
                    e.Value = this.columnNames[e.ColumnIndex];
                    e.FieldName = FieldsHelper.PurchaseOrderHeaderFields[e.ColumnIndex];
                }

                if (e.RowIndex >= 0 && this.data.Count > 0)
                {
                    var rowData = this.data[e.RowIndex % this.gridControl.PageSize] as PurchaseOrderHeader;

                    switch (e.ColumnIndex)
                    {
                        case 0:
                            e.Value = rowData.OrderStatus;
                            break;
                        case 1:
                            e.Value = rowData.OrderDate;
                            break;
                        case 2:
                            e.Value = rowData.ShipDate;
                            break;
                        case 3:
                            e.Value = rowData.SubTotal;
                            break;
                        case 4:
                            e.Value = rowData.TaxAmt;
                            break;
                        case 5:
                            e.Value = rowData.Freight;
                            break;
                        case 6:
                            e.Value = rowData.TotalDue;
                            break;
                        case 7:
                            e.Value = rowData.ModifiedDate;
                            e.FormatString = "{0:MM/dd/yyyy}";
                            break;
                        case 8:
                            e.Value = rowData.ShipMethod;
                            break;
                        case 9:
                            e.Value = rowData.Vendor.Name;
                            break;
                    }
                }
            }
            else
            {
                if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
                {
                    e.Value = this.detailsViewColumnNames[e.ColumnIndex];
                }

                if (e.RowIndex >= 0 && this.detailsData.Count > 0)
                {
                    var rowData = this.detailsData[e.RowIndex] as PurchaseOrderDetail;

                    switch (e.ColumnIndex)
                    {
                        case 0:
                            e.Value = rowData.Product;
                            break;
                        case 1:
                            e.Value = rowData.OrderQty;
                            break;
                        case 2:
                            e.Value = rowData.ReceivedQty;
                            break;
                        case 3:
                            e.Value = rowData.RejectedQty;
                            break;
                        case 4:
                            e.Value = rowData.StockedQty;
                            break;
                        case 5:
                            e.Value = rowData.UnitPrice;
                            break;
                        case 6:
                            e.Value = rowData.LineTotal;
                            break;
                        case 7:
                            e.Value = rowData.DueDate;
                            e.FormatString = "{0:MM/dd/yyyy}";
                            break;
                        case 8:
                            e.Value = rowData.ModifiedDate;
                            e.FormatString = "{0:MM/dd/yyyy}";
                            break;
                    }
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
            if (propertyName == "OrderStatus")
            {
                return;
            }

            var prop = typeof(PurchaseOrderHeader).GetProperty(propertyName).PropertyType;
            if (prop.IsValueType || prop == typeof(string))
            {
                base.RadGridView1_SortChanged(sender, e);
            }
        }

        protected override void DeleteCurrentRow()
        {
            MainRepository.PurchaseOrdersCache.Remove(this.currentItem as PurchaseOrderHeader);
            this.ClearSelection();
        }

        protected override void RefreshData(int skip)
        {
            this.gridControl.RowCount = 0;

            var sortedData = SortHelper.Sort(MainRepository.PurchaseOrdersCache, this.gridControl.SortDescriptors);
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
                selection.SetValue(this.data[i].OrderStatus);

                selection = worksheet.Cells[rowIndex, 1];
                selection.SetValue(this.data[i].OrderDate);

                selection = worksheet.Cells[rowIndex, 2];
                selection.SetValue(this.data[i].ShipDate.Value);

                selection = worksheet.Cells[rowIndex, 3];
                selection.SetValue(Convert.ToDouble(this.data[i].SubTotal));

                selection = worksheet.Cells[rowIndex, 4];
                selection.SetValue(Convert.ToDouble(this.data[i].TaxAmt));

                selection = worksheet.Cells[rowIndex, 5];
                selection.SetValue(Convert.ToDouble(this.data[i].Freight));

                selection = worksheet.Cells[rowIndex, 6];
                selection.SetValue(Convert.ToDouble(this.data[i].TotalDue));

                selection = worksheet.Cells[rowIndex, 7];
                selection.SetValue(this.data[i].ModifiedDate);

                selection = worksheet.Cells[rowIndex, 8];
                selection.SetValue(this.data[i].ShipMethod.Name);

                selection = worksheet.Cells[rowIndex, 9];
                selection.SetValue(this.data[i].Vendor.Name);

            }

            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
            worksheet.Name = "Purchases";
            return workbook;
        }
    }
}