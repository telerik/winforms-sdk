using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace RadGridViewLinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable dt = new DataTable();

            DataColumn id = new DataColumn();
            id.Caption = "Id";
            id.AutoIncrement = true;
            dt.Columns.Add(id);

            DataColumn name = new DataColumn();
            name.Caption = "Name";
            dt.Columns.Add(name);

            DataColumn linkLabelCol = new DataColumn();
            linkLabelCol.Caption = "Web site";
            dt.Columns.Add(linkLabelCol);

            DataColumn webAddressCol = new DataColumn();
            webAddressCol.Caption = "HiddenWebAddressCol";
            dt.Columns.Add(webAddressCol);

            for (int i = 0; i < 1000; i++)
            {
                DataRow row = dt.NewRow();
                row[1] = "John" + i.ToString();
                if (i % 2 == 0)
                {
                    row[2] = "Telerik";
                    row[3] = "http://www.telerik.com";
                }
                else if (i % 5 == 0)
                {
                    row[2] = "Google";
                    row[3] = "http://www.google.com";
                }
                else
                {
                    row[2] = "Yahoo";
                    row[3] = "http://www.yahoo.com";
                }
                dt.Rows.Add(row);
            }

            this.radGridView1.CellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);
            this.radGridView1.CellClick += new GridViewCellEventHandler(radGridView1_CellClick);
            this.radGridView1.MouseMove += new MouseEventHandler(radGridView1_MouseMove);

            this.radGridView1.DataSource = dt;

            this.radGridView1.MasterTemplate.BestFitColumns();
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.Columns[3].IsVisible = false;
            this.radGridView1.Columns[2].ReadOnly = true;
        }

        // If the mouse cursor is on the cell of the linklabel column,
        // the cursor becomes a hand
        private void radGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            LightVisualElement cellElement = this.radGridView1.ElementTree.GetElementAtPoint(e.Location) as LightVisualElement;
            if (cellElement == null) return;
            if (cellElement is GridDataCellElement)
            {
                if (((GridDataCellElement)cellElement).ColumnIndex == 2)
                {
                    Telerik.WinControls.UI.LayoutManagerPart mgr = ((LightVisualElement)cellElement).Layout as LayoutManagerPart;
                    SizeF size = TextRenderer.MeasureText(cellElement.Text, cellElement.Font);
                    RectangleF textRectangle = LayoutUtils.Align(size, mgr.RightPart.Bounds, cellElement.TextAlignment);

                    if ((textRectangle.Contains(cellElement.PointFromControl(e.Location))))
                    {
                        this.radGridView1.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        this.radGridView1.Cursor = Cursors.Default;
                    }
                }
            }
            else
            {
                this.radGridView1.Cursor = Cursors.Arrow;
            }
        }

        // If you click on a cell which belongs to the linklabel column
        // this opens the corresponding web site. The URL is taken from the invisible column
        private void radGridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                Process.Start(this.radGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());
            }
        }

        Font font = new Font("Tahoma", 9f, FontStyle.Underline);

        // Here I am formatting the text
        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.RowIndex >= 0)
            {
                if (e.CellElement.ColumnIndex == 2)
                {
                    if (e.CellElement.ForeColor != Color.Blue)
                    {
                        e.CellElement.Font = font;
                        e.CellElement.ForeColor = Color.Blue;
                    }
                }
            }
        }
    }
}