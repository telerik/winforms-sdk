using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace GroupRowsWithSummaryValues
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            this.radGridView1.CreateCell += radGridView1_CreateCell;
            this.radGridView1.GroupByChanged+=radGridView1_GroupByChanged;
        }

        private void radGridView1_GroupByChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            this.radGridView1.MasterTemplate.Refresh();
        }

        private void radGridView1_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridGroupContentCellElement))
            {
                e.CellElement = new MyGridGroupContentCellElement(e.Column, e.Row);
            }
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            this.radGridView1.DataSource = this.productsBindingSource;
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.AllowAddNewRow = false;

            this.radGridView1.EnableGrouping = true;
            this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
             this.radGridView1.TableElement.GroupHeaderHeight = 60;

            // group by CategoryID
            GroupDescriptor descriptor = new GroupDescriptor();
            descriptor.GroupNames.Add("CategoryID", ListSortDirection.Ascending);
            this.radGridView1.GroupDescriptors.Add(descriptor);

            // add summary items
            GridViewSummaryItem item1 = new GridViewSummaryItem("UnitPrice", "Avg = {0:N2}", GridAggregateFunction.Avg);
            GridViewSummaryItem item2 = new GridViewSummaryItem("ProductID", "Count = {0}", GridAggregateFunction.Count);
            GridViewSummaryItem item4 = new GridViewSummaryItem("UnitsOnOrder", "Max = {0}", GridAggregateFunction.Max);
            GridViewSummaryItem item5 = new GridViewSummaryItem("UnitsInStock", "Sum = {0}", GridAggregateFunction.Sum);
            GridViewSummaryRowItem row = new GridViewSummaryRowItem(new GridViewSummaryItem[] { item1, item2, item4, item5 });
            this.radGridView1.SummaryRowsTop.Add(row);
        }

        public class MyGridGroupContentCellElement : GridGroupContentCellElement
        {
            private StackLayoutElement stack;
            private bool showSummaryCells_Renamed = true;

            public MyGridGroupContentCellElement(GridViewColumn column, GridRowElement row) : base(column, row)
            {
                // creating the elements here in order to have a valid insance of a row
                if (this.stack == null)
                    this.CreateStackElement(row);

                this.ClipDrawing = true;
                row.GridControl.TableElement.HScrollBar.Scroll += HScrollBar_Scroll;
                row.GridControl.ColumnWidthChanged += GridControl_ColumnWidthChanged;
                row.GridControl.GroupDescriptors.CollectionChanged += GroupDescriptors_CollectionChanged;
            }

            private void GroupDescriptors_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                if (this.RowInfo.Parent is GridViewGroupRowInfo && ((GridViewGroupRowInfo)this.RowInfo.Parent).IsExpanded)
                    this.InvalidateArrange();
            }

            private void HScrollBar_Scroll(object sender, ScrollEventArgs e)
            {
                if (e.NewValue != e.OldValue)
                    this.stack.PositionOffset = new SizeF(0 - e.NewValue, 0);
            }

            private void CreateStackElement(GridRowElement row)
            {
                this.stack = new StackLayoutElement();
                this.stack.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
                this.stack.AutoSize = true;
                this.stack.StretchHorizontally = true;
                this.stack.Alignment = ContentAlignment.BottomCenter;
                this.stack.DrawFill = true;
                this.stack.BackColor = Color.White;
                int i = 0;
                while (i < row.RowInfo.Cells.Count)
                {
                    SummaryCellElement element = new SummaryCellElement();
                    element.ColumnName = row.RowInfo.Cells[i].ColumnInfo.Name;
                    element.StretchHorizontally = false;
                    element.StretchVertically = true;
                    element.DrawBorder = true;
                    element.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
                    element.BorderColor = Color.LightBlue;
                    element.ForeColor = Color.Black;
                    element.GradientStyle = GradientStyles.Solid;
                    this.stack.Children.Add(element);
                    i += 1;
                }

                this.Children.Add(this.stack);
            }

            public override void Initialize(GridViewColumn column, GridRowElement row)
            {
                base.Initialize(column, row);
                this.ShowSummaryCells = (!row.Data.IsExpanded) || row.Data.Group.Groups.Count > 0;
            }

            protected override void DisposeManagedResources()
            {
                if (this.GridControl != null)
                {
                    this.GridControl.ColumnWidthChanged -= GridControl_ColumnWidthChanged;
                    this.GridControl.GroupDescriptors.CollectionChanged -= GroupDescriptors_CollectionChanged;
                }

                base.DisposeManagedResources();
            }

            public bool ShowSummaryCells
            {
                get
                {
                    return this.showSummaryCells_Renamed;
                }
                set
                {
                    if (this.showSummaryCells_Renamed != value)
                    {
                        this.showSummaryCells_Renamed = value;

                        if (this.stack == null)
                            this.CreateStackElement(this.RowElement);

                        if (this.showSummaryCells_Renamed)
                            this.stack.Visibility = ElementVisibility.Visible;
                        else
                            this.stack.Visibility = ElementVisibility.Hidden;
                    }
                }
            }

            private void GridControl_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
            {
                this.InvalidateArrange();
            }

            protected override SizeF ArrangeOverride(SizeF finalSize)
            {
                SizeF size = base.ArrangeOverride(finalSize);

                float x = this.GridControl.TableElement.GroupIndent * (this.GridControl.GroupDescriptors.Count - this.RowInfo.Group.Level - 1);
                float y = size.Height - this.stack.DesiredSize.Height - 2.0F;
                float width = size.Width - x;
                float height = this.stack.DesiredSize.Height;

                this.stack.Arrange(new RectangleF(x, y, width, height));

                foreach (SummaryCellElement element in this.stack.Children)
                {
                    Size elementSize = new Size(this.RowInfo.Cells[element.ColumnName].ColumnInfo.Width + this.GridControl.TableElement.CellSpacing, 30);
                    Console.WriteLine(this.RowInfo.Cells[element.ColumnName].ColumnInfo.Width + " " + this.RowInfo.Cells[element.ColumnName].ColumnInfo.Name);
                    element.MinSize = elementSize;
                    element.MaxSize = elementSize;
                }

                return size;
            }

            public override void SetContent()
            {
                base.SetContent();
                this.TextAlignment = ContentAlignment.TopLeft;
                this.ShowSummaryCells = (!this.RowInfo.Group.IsExpanded) || this.RowInfo.Group.Groups.Count > 0;

                GridViewGroupRowInfo rowInfo = (GridViewGroupRowInfo)this.RowInfo;

                if (rowInfo.Parent is GridViewGroupRowInfo && !((GridViewGroupRowInfo)rowInfo.Parent).IsExpanded)
                    return;

                Dictionary<string, string> values = this.GetSummaryValues();
                int index = 0;

                foreach (KeyValuePair<string, string> column in values)
                {
                    SummaryCellElement element = ((SummaryCellElement)this.stack.Children[index]);
                    index += 1;

                    if (this.ViewTemplate.Columns[column.Key].IsGrouped && this.ViewTemplate.ShowGroupedColumns == false)
                        element.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
                    else
                    {
                        element.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                        element.Text = column.Value;
                    }
                }
            }

            public virtual Dictionary<string, string> GetSummaryValues()
            {
                if (this.ElementTree == null)
                    return new Dictionary<string, string>();

                Dictionary<string, string> result = new Dictionary<string, string>();
                if (this.GridControl.SummaryRowsTop.Count > 0)
                {
                    foreach (SummaryCellElement cell in this.stack.Children)
                    {
                        if (this.GridControl.SummaryRowsTop[0][cell.ColumnName] == null)
                            result.Add(cell.ColumnName, string.Empty);
                        else
                        {
                            GridViewSummaryItem summaryItem = this.GridControl.SummaryRowsTop[0][cell.ColumnName][0];
                            object value = this.ViewTemplate.DataView.Evaluate(summaryItem.GetSummaryExpression(), this.GetDataRows());
                            string text = string.Format(summaryItem.FormatString, value);
                            result.Add(summaryItem.Name, text);
                        }
                    }
                }
                return result;
            }

            private IEnumerable<GridViewRowInfo> GetDataRows()
            {
                Queue<GridViewRowInfo> queue = new Queue<GridViewRowInfo>();
                queue.Enqueue(this.RowInfo);

                List<GridViewRowInfo> list = new List<GridViewRowInfo>();

                while (queue.Count != 0)
                {
                    GridViewRowInfo currentRow = queue.Dequeue();

                    if (currentRow is GridViewDataRowInfo)
                        list.Add(currentRow);

                    foreach (GridViewRowInfo row in currentRow.ChildRows)
                        queue.Enqueue(row);
                }

                return list;
            }

            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(GridGroupContentCellElement);
                }
            }
        }

        public class SummaryCellElement : LightVisualElement
        {
            private string columnName_Renamed;

            public string ColumnName
            {
                get
                {
                    return this.columnName_Renamed;
                }
                set
                {
                    this.columnName_Renamed = value;
                }
            }
        }
    }
}