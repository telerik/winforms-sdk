using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace RowDetailsInGridView
{
    public class RowDetailsLayout : TableViewRowLayout
    {
        int systemWidth;
        SizeF availableSize;

        public override void InvalidateRenderColumns()
        {
            base.InvalidateRenderColumns();
            systemWidth = 0;
            foreach (GridViewColumn column in this.RenderColumns)
            {
                if (!(column is GridViewDataColumn))
                {
                    systemWidth += column.Width + Owner.CellSpacing;
                }
            }
            if (systemWidth > 0)
            {
                systemWidth -= Owner.CellSpacing;
            }
        }

        public override SizeF MeasureRow(SizeF availableSize)
        {
            SizeF desiredSize = base.MeasureRow(availableSize);
            this.availableSize = availableSize;
            return desiredSize;
        }

        public override RectangleF ArrangeCell(RectangleF clientRect, GridCellElement cell)
        {
            RowDetailsGrid grid = (RowDetailsGrid)Owner.GridViewElement.GridControl;

            if (grid.DetailsColumn == null)
            {
                return base.ArrangeCell(clientRect, cell);
            }

            int width = GetColumnWidth(grid.DetailsColumn) + grid.TableElement.CellSpacing;

            if (cell.RowInfo.IsCurrent)
            {
                if (cell.ColumnInfo == grid.DetailsColumn)
                {
                    float visibleColumnsWidth = 0;

                    foreach (GridViewColumn col in this.RenderColumns)
                    {
                        if (col is GridViewDataColumn)
                        {
                            visibleColumnsWidth += col.Width + grid.TableElement.CellSpacing;
                        }
                    }

                    return new RectangleF(clientRect.X, Owner.RowHeight, visibleColumnsWidth - 1, grid.DetailsRowHeight - Owner.RowHeight);
                }
                else
                {
                    RectangleF rect = base.ArrangeCell(clientRect, cell);
                    rect.Height = Owner.RowHeight;
                    rect.X -= width;

                    if (this.LastDataColumn == cell.ColumnInfo)
                    {
                        rect.Width += width;
                    }

                    return rect;
                }
            }
            else if (cell.ColumnInfo == grid.DetailsColumn)
            {
                return RectangleF.Empty;
            }

            if (cell.ColumnInfo is GridViewDataColumn)
            {
                RectangleF cellRect = base.ArrangeCell(clientRect, cell);
                cellRect.Height = Owner.RowHeight;
                cellRect.X -= width;

                if (this.LastDataColumn == cell.ColumnInfo)
                {
                    cellRect.Width += width;
                }

                return cellRect;
            }

            return base.ArrangeCell(clientRect, cell);
        }
    }
}

