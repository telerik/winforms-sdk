using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using System.Collections.Generic;

namespace RadGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //This project demonstrates how to show the summary cells when the groups are collpased
            #region Populate with data
            for (int i = 0; i < 5; i++)
            {
                GridViewDecimalColumn col = new GridViewDecimalColumn("Col " + (i + 1));
                this.radGridView1.Columns.Add(col);
            }

            for (int i = 0; i < 20; i++)
            {
                this.radGridView1.Rows.Add(i % 5, i % 3, i % 2, i, i);
            }
            #endregion

            #region Add summary items
            GridViewSummaryItem item1 = new GridViewSummaryItem("Col 1", "Sum = {0}", GridAggregateFunction.Sum);
            GridViewSummaryItem item2 = new GridViewSummaryItem("Col 2", "Avg = {0}", GridAggregateFunction.Avg);
            GridViewSummaryItem item4 = new GridViewSummaryItem("Col 4", "Max = {0}", GridAggregateFunction.Max);
            GridViewSummaryItem item5 = new GridViewSummaryItem("Col 5", "First = {0}", GridAggregateFunction.First);
            GridViewSummaryRowItem row = new GridViewSummaryRowItem(new GridViewSummaryItem[] { item1, item2, item4, item5 });
            this.radGridView1.SummaryRowsTop.Add(row);
            #endregion

            this.radGridView1.TableElement.GroupHeaderHeight = 50;
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.CreateCell += new GridViewCreateCellEventHandler(radGridView1_CreateCell);
            this.radGridView1.Columns.CollectionChanged += new NotifyCollectionChangedEventHandler(Columns_CollectionChanged);
        }

        private void Columns_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //invalidate when columns are re-arranged
            this.radGridView1.MasterTemplate.Refresh();
        }

        private void radGridView1_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridGroupContentCellElement))
            {
                e.CellElement = new MyGridGroupContentCellElement(e.Column, e.Row);
            }
        }
    }

    public class MyGridGroupContentCellElement : GridGroupContentCellElement
    {
        private StackLayoutElement stack;
        private bool showSummaryCells = true;

        public MyGridGroupContentCellElement(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {
            //creating the elements here in order to have a valid insance of a row
            if (this.stack == null)
            {
                this.CreateStackElement(row);
            }

            this.ClipDrawing = true;
            row.GridControl.TableElement.HScrollBar.Scroll += new ScrollEventHandler(HScrollBar_Scroll);
            row.GridControl.ColumnWidthChanged += new ColumnWidthChangedEventHandler(GridControl_ColumnWidthChanged);
            row.GridControl.GroupDescriptors.CollectionChanged += new NotifyCollectionChangedEventHandler(GroupDescriptors_CollectionChanged);
        }

        private void HScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                this.stack.PositionOffset = new SizeF(0 - e.NewValue, 0);
            }
        }

        private void GroupDescriptors_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (this.RowInfo.Parent is GridViewGroupRowInfo && ((GridViewGroupRowInfo)this.RowInfo.Parent).IsExpanded)
            {
                this.InvalidateArrange();
            }
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

            for (int i = 0; i < row.RowInfo.Cells.Count; i++)
            {
                SummaryCellElement element = new SummaryCellElement();
                element.ColumnName = row.RowInfo.Cells[i].ColumnInfo.Name;
                element.StretchHorizontally = false;
                element.StretchVertically = true;
                element.DrawBorder = true;
                element.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
                element.BorderColor = Color.LightBlue;
                this.stack.Children.Add(element);
            }

            this.Children.Add(this.stack);
        }

        public override void Initialize(GridViewColumn column, GridRowElement row)
        {
            base.Initialize(column, row);
            this.ShowSummaryCells = !row.Data.IsExpanded || row.Data.Group.Groups.Count > 0;
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
            get { return this.showSummaryCells; }
            set
            {
                if (this.showSummaryCells != value)
                {
                    this.showSummaryCells = value;

                    if (this.stack == null)
                    {
                        this.CreateStackElement(this.RowElement);
                    }

                    if (this.showSummaryCells)
                    {
                        this.stack.Visibility = ElementVisibility.Visible;
                    }
                    else
                    {
                        this.stack.Visibility = ElementVisibility.Hidden;
                    }
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
            float y = size.Height - this.stack.DesiredSize.Height - 2f;
            float width = size.Width - x;
            float height = this.stack.DesiredSize.Height;

            this.stack.Arrange(new RectangleF(x, y, width, height));

            foreach (SummaryCellElement element in this.stack.Children)
            {
                Size elementSize = new Size(this.RowInfo.Cells[element.ColumnName].ColumnInfo.Width + this.GridControl.TableElement.CellSpacing, 0);
                element.MinSize = elementSize;
                element.MaxSize = elementSize;
            }

            return size;
        }

        public override void SetContent()
        {
            base.SetContent();

            this.ShowSummaryCells = !this.RowInfo.Group.IsExpanded || this.RowInfo.Group.Groups.Count > 0;

            GridViewGroupRowInfo rowInfo = (GridViewGroupRowInfo)this.RowInfo;

            if (rowInfo.Parent is GridViewGroupRowInfo && !((GridViewGroupRowInfo)rowInfo.Parent).IsExpanded)
            {
                return;
            }

            Dictionary<string, string> values = this.GetSummaryValues();
            int index = 0;

            foreach (KeyValuePair<string, string> column in values)
            {
                SummaryCellElement element = ((SummaryCellElement)this.stack.Children[index++]);

                if (this.ViewTemplate.Columns[column.Key].IsGrouped)
                {
                    element.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
                }
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
            {
                return new Dictionary<string, string>();
            }

            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (SummaryCellElement cell in this.stack.Children)
            {
                if (this.GridControl.SummaryRowsTop[0][cell.ColumnName] == null)
                {
                    result.Add(cell.ColumnName, String.Empty);
                }
                else
                {
                    GridViewSummaryItem summaryItem = this.GridControl.SummaryRowsTop[0][cell.ColumnName][0];
                    object value = this.ViewTemplate.DataView.Evaluate(summaryItem.GetSummaryExpression(), this.GetDataRows());
                    string text = string.Format(summaryItem.FormatString, value);
                    result.Add(summaryItem.Name, text);
                }
            }

            return result;
        }

        private IEnumerable<GridViewRowInfo> GetDataRows()
        {
            Queue<GridViewRowInfo> queue = new Queue<GridViewRowInfo>();
            queue.Enqueue(this.RowInfo);

            while (queue.Count != 0)
            {
                GridViewRowInfo currentRow = queue.Dequeue();

                if (currentRow is GridViewDataRowInfo)
                {
                    yield return currentRow;
                }

                foreach (GridViewRowInfo row in currentRow.ChildRows)
                {
                    queue.Enqueue(row);
                }
            }
        }

        protected override Type ThemeEffectiveType
        {
            get { return typeof(GridGroupContentCellElement); }
        }
    }

    public class SummaryCellElement : LightVisualElement
    {
        private string columnName;

        public string ColumnName
        {
            get { return this.columnName; }
            set { this.columnName = value; }
        }
    }
}
