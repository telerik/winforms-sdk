using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace MergeCellGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingList<DataElement> list = new BindingList<DataElement>()
            {
                new DataElement(1,"Mike","Toshiba portage","Sony"),
                new DataElement(2,"Mike","Asus","Asus"),
                new DataElement(3,"Nancy","Toshiba portage","Asus"),
                new DataElement(4,"Nancy","Sony", "Toshiba portage"),
                new DataElement(5,"Rosa","Asus","Sony"),
                new DataElement(6,"Rosa","Hp","Sony"),
                new DataElement(7,"Robert","Lenovo", "Lenovo"),
                new DataElement(8,"Robin","Sony", "Sony"),
                new DataElement(9,"Jason","IBM" , "Sony"),
                new DataElement(10,"Jason","Asus", "Lenovo"),
            };
            this.radGridView1.DataSource = list;

            MergeVertically(this.radGridView1, new int[] { 1, 2 });
            MergeHorizontally(this.radGridView1, 2, 3);
      
            this.radGridView1.ShowRowHeaderColumn = false;
            this.radGridView1.EnableGrouping = false;
            radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            radGridView1.Size = new Size(400, 310);
            radGridView1.EnableFiltering = true;

            radGridView1.SortChanged += radGridView1_SortChanged;
            radGridView1.FilterChanged += radGridView1_FilterChanged;
            radGridView1.PrintCellPaint += radGridView1_PrintCellPaint;
            radGridView1.CellValueChanged += radGridView1_CellValueChanged;
        }
        
        void radGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            MergeVertically(this.radGridView1, new int[] { 1, 2 });
            MergeHorizontally(this.radGridView1, 2, 3);
        }

        void radGridView1_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            MergeVertically(this.radGridView1, new int[] { 1, 2 });
            MergeHorizontally(this.radGridView1, 2, 3);
        }

        void radGridView1_SortChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            MergeVertically(this.radGridView1, new int[] { 1, 2 });
            MergeHorizontally(this.radGridView1, 2, 3);
        }

        private void MergeHorizontally(RadGridView radGridView, int startColumnIndex, int endColumnIndex)
        {
            foreach (GridViewRowInfo item in radGridView.Rows)
            {
                for (int i = startColumnIndex; i < endColumnIndex; i++)
                {
                    GridViewCellInfo firstCell = item.Cells[i];
                    GridViewCellInfo secondCell = item.Cells[i + 1];
                    
                    string firstCellText = (firstCell != null && firstCell.Value != null ? firstCell.Value.ToString() : string.Empty);
                    string secondCellText = (secondCell != null && secondCell.Value != null ? secondCell.Value.ToString() : string.Empty);                    

                    setCellBorders(firstCell, Color.FromArgb(209, 225, 245));
                    setCellBorders(secondCell, Color.FromArgb(209, 225, 245));
                    
                    if (firstCellText == secondCellText)
                    {
                        firstCell.Style.BorderRightColor = Color.Transparent;
                        secondCell.Style.BorderLeftColor = Color.Transparent;
                        secondCell.Style.ForeColor = Color.Transparent;
                    }
                    else
                    {
                        secondCell.Style.ForeColor = Color.Black;
                    }
                }
            }
        }
        
        private void MergeVertically(RadGridView radGridView, int[] columnIndexes)
        {
            GridViewRowInfo Prev = null;
            foreach (GridViewRowInfo item in radGridView.Rows)
            {
                if (Prev != null)
                {
                    string firstCellText = string.Empty;
                    string secondCellText = string.Empty;

                    foreach (int i in columnIndexes)
                    {
                        GridViewCellInfo firstCell = Prev.Cells[i];
                        GridViewCellInfo secondCell = item.Cells[i];

                        firstCellText = (firstCell != null && firstCell.Value != null ? firstCell.Value.ToString() : string.Empty);
                        secondCellText = (secondCell != null && secondCell.Value != null ? secondCell.Value.ToString() : string.Empty);

                        setCellBorders(firstCell, Color.FromArgb(209, 225, 245));
                        setCellBorders(secondCell, Color.FromArgb(209, 225, 245));

                        if (firstCellText == secondCellText)
                        {
                            firstCell.Style.BorderBottomColor = Color.Transparent;
                            secondCell.Style.BorderTopColor = Color.Transparent;
                            secondCell.Style.ForeColor = Color.Transparent;
                        }
                        else
                        {
                            secondCell.Style.ForeColor = Color.Black;
                            Prev = item;
                            break;
                        }
                    }
                }
                else
                {
                    Prev = item;
                }
            }
        }

        private void setCellBorders(GridViewCellInfo cell, Color color)
        {
            cell.Style.CustomizeBorder = true;
            cell.Style.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders;
            cell.Style.BorderLeftColor = color;
            cell.Style.BorderRightColor = color;
            cell.Style.BorderBottomColor = color;
            if (cell.Style.BorderTopColor != Color.Transparent)
            {
                cell.Style.BorderTopColor = color;
            }
        }

        void radGridView1_PrintCellPaint(object sender, PrintCellPaintEventArgs e)
        {
            if (e.Row.Index >= 0)
            {
                GridViewCellInfo cell = this.radGridView1.Rows[e.Row.Index].Cells[e.Column.Index];

                if (cell.Style.BorderTopColor == Color.Transparent)
                {
                    e.Graphics.DrawLine(
                        Pens.White, new Point(e.CellRect.Left + 1, e.CellRect.Top),
                        new Point(e.CellRect.Right - 1, e.CellRect.Top));
                }
                if (cell.Style.BorderLeftColor == Color.Transparent)
                {
                    e.Graphics.DrawLine(
                        Pens.White, new Point(e.CellRect.Left, e.CellRect.Top),
                        new Point(e.CellRect.Left - 1, e.CellRect.Bottom));
                }
                if (cell.Style.ForeColor == Color.Transparent)
                {
                    Rectangle r = new Rectangle(e.CellRect.X + 1,e.CellRect.Y + 1,e.CellRect.Width - 2,e.CellRect.Height - 2);
                    e.Graphics.FillRectangle(Brushes.White, r);
                }
            }
        }
    }

    public class DataElement
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FirstOwnedItem { get; set; }

        public string SecondOwnedItem { get; set; }

        public DataElement(int id, string name, string firstOwnedItem, string secondOwnedItem)
        {
            this.Id = id;
            this.Name = name;
            this.FirstOwnedItem = firstOwnedItem;
            this.SecondOwnedItem = secondOwnedItem;
        }
    }
}