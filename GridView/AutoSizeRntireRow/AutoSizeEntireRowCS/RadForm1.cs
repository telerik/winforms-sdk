using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace _1151916
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            radGridView1.CreateRow += radGridView1_CreateRow;
            radGridView1.DataSource = GetTable();
            radGridView1.AutoSizeRows = true;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (var item in radGridView1.Columns)
            {
                item.WrapText = true;
            }

            radGridView1.CachedHeight.Clear();
            radGridView1.TableElement.ScrollToRow(500);
        }
        void radGridView1_CreateRow(object sender, GridViewCreateRowEventArgs e)
        {
            if (e.RowType == typeof(GridDataRowElement))
            {
                e.RowType = typeof(CustomRowElement);
            }
        }
        static Random rnd = new Random();
        static DataTable GetTable()
        {
            DataTable table = new DataTable();
            string[] values = new string[30];

            for (int i = 0; i < 30; i++)
            {
                table.Columns.Add("Column " + i);
                values[i] = new string('*', rnd.Next(20));
            }


            for (int i = 0; i < 100; i++)
            {
                values[0] = "Row " + i;
                values[1] = new string('*', rnd.Next(50));
                table.Rows.Add(values);

            }

            return table;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);


        }
    }
    class MyGrid : RadGridView
    {
        Dictionary<GridViewRowInfo, int> cachedHeight = new Dictionary<GridViewRowInfo, int>();

        public Dictionary<GridViewRowInfo, int> CachedHeight { get => cachedHeight; }
    }
    public class CustomRowElement : GridDataRowElement
    {

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataRowElement);
            }
        }
        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            var cachedHeight = ((MyGrid)this.GridControl).CachedHeight;

            SizeF baseSize = base.MeasureOverride(availableSize);
            Padding borderThickness = GetBorderThickness(false);

            if (cachedHeight.ContainsKey(this.RowInfo))
            {
                return new SizeF(baseSize.Width, cachedHeight[this.RowInfo]);
            }


            CellElementProvider provider = new CellElementProvider(this.TableElement);
            SizeF desiredSize = SizeF.Empty;

            foreach (GridViewColumn column in this.ViewTemplate.Columns)
            {
                if (!this.IsColumnVisible(column))
                {
                    continue;
                }
                GridDataCellElement cellElement = provider.GetElement(column, this) as GridDataCellElement;
                this.Children.Add(cellElement);
                if (cellElement != null)
                {
                    cellElement.Measure(new SizeF(column.Width, float.PositiveInfinity));
                    if (desiredSize.Height < cellElement.DesiredSize.Height)
                    {
                        desiredSize.Height = cellElement.DesiredSize.Height;
                    }
                }
                cellElement.Detach();
                this.Children.Remove(cellElement);
            }
            SizeF elementSize = this.TableElement.RowScroller.ElementProvider.GetElementSize(this.RowInfo);
            int oldHeight = RowInfo.Height == -1 ? (int)elementSize.Height : RowInfo.Height;
            this.RowInfo.SuspendPropertyNotifications();

            var newHeight = Math.Min(this.RowInfo.Height, (int)desiredSize.Height);
            this.RowInfo.Height = Math.Max((int)desiredSize.Height, Math.Max(newHeight, Math.Max(this.RowInfo.MinHeight, 24)));
            this.RowInfo.Height = (int)desiredSize.Height;

            if (!cachedHeight.ContainsKey(this.RowInfo))
            {
                cachedHeight.Add(this.RowInfo, this.RowInfo.Height);
            }

            this.RowInfo.ResumePropertyNotifications();

            if (!this.RowInfo.IsPinned)
            {
                int delta = RowInfo.Height - oldHeight;
                TableElement.RowScroller.UpdateScrollRange(TableElement.RowScroller.Scrollbar.Maximum + delta, false);
            }
            baseSize.Height = this.RowInfo.Height;
            return baseSize;
        }
        private bool IsColumnVisible(GridViewColumn column)
        {
            return column.IsVisible;
        }
    }
}
