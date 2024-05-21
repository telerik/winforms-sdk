using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace _920856
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            radGridView1.TableElement.RowHeight = 120;

            // Add Columns
            ListViewColumn Col1 = new ListViewColumn("Devices");
            Col1.Width = 200;
            radGridView1.Columns.Add(Col1);

            ListViewColumn Col2 = new ListViewColumn("Bins");
            Col2.Width = 200;
            radGridView1.Columns.Add(Col2);

            ListViewColumn Col3 = new ListViewColumn("Printer");
            Col3.Width = 200;
            radGridView1.Columns.Add(Col3);

            // Add Rows
            Telerik.WinControls.UI.GridViewDataRowInfo row1 = new Telerik.WinControls.UI.GridViewDataRowInfo(this.radGridView1.MasterView);
            row1.Height = 65;
			row1.AllowResize = false;
            row1.Cells["Devices"].Value = CreateDeviceList(20, 30, Properties.Resources.working, Properties.Resources.canceled, Color.Black);
            row1.Cells["Bins"].Value = CreateBinsList(300, 210, 182, Properties.Resources.working, Properties.Resources.working, Properties.Resources.working, Color.Black);
            row1.Cells["Printer"].Value = CreatePrintList(44, 340, Properties.Resources.canceled, Properties.Resources.working, Color.Black);
            radGridView1.Rows.Add(row1);

            Telerik.WinControls.UI.GridViewDataRowInfo row2 = new Telerik.WinControls.UI.GridViewDataRowInfo(this.radGridView1.MasterView);
            row2.Height = 65;
			row2.AllowResize = false;
			row2.Cells["Devices"].Value = CreateDeviceList(15, 30, Properties.Resources.canceled, Properties.Resources.canceled, Color.Black);
            row2.Cells["Bins"].Value = CreateBinsList(234, 232, 223, Properties.Resources.working, Properties.Resources.working, Properties.Resources.working, Color.Black);
            row2.Cells["Printer"].Value = CreatePrintList(33, 20, Properties.Resources.canceled, Properties.Resources.working, Color.Black);
            radGridView1.Rows.Add(row2);

            Telerik.WinControls.UI.GridViewDataRowInfo row3 = new Telerik.WinControls.UI.GridViewDataRowInfo(this.radGridView1.MasterView);
            row3.Height = 65;
			row3.AllowResize = false;
			row3.Cells["Devices"].Value = CreateDeviceList(25, 12, Properties.Resources.working, Properties.Resources.canceled, Color.Black);
            row3.Cells["Bins"].Value = CreateBinsList(124, 32, 232, Properties.Resources.working, Properties.Resources.working, Properties.Resources.canceled, Color.Black);
            row3.Cells["Printer"].Value = CreatePrintList(99, 222, Properties.Resources.canceled, Properties.Resources.working, Color.Black);
            radGridView1.Rows.Add(row3);

            radGridView1.Rows[0].IsCurrent = true;
        }

        private ListViewCellInfo CreateDeviceList(int _value1, int _value2, Image _image1, Image _image2, Color _color)
        {
            ListViewCellInfo info = new ListViewCellInfo();
            ListViewRowDataItem item1 = new ListViewRowDataItem();
            item1.ForeColor = _color;
            item1.Image = _image1;
            item1.Text = String.Format("Device1 ({0})", _value1);
            info.Items.Add(item1);

            ListViewRowDataItem item2 = new ListViewRowDataItem();
            item2.Image = _image2;
            item2.ForeColor = _color;
            item2.Text = String.Format("Device2 ({0})", _value2);
            info.Items.Add(item1);
            return info;
        }

        private ListViewCellInfo CreateBinsList(int _value1, int _value2, int _value3, Image _image1, Image _Image2, Image _Image3, Color _color)
        {
            ListViewCellInfo info = new ListViewCellInfo();
            ListViewRowDataItem item1 = new ListViewRowDataItem();
            item1.ForeColor = _color;
            item1.Image = _image1;
            item1.Text = String.Format("Bin1 ({0})", _value1);
            info.Items.Add(item1);

            ListViewRowDataItem item2 = new ListViewRowDataItem();
            item2.Image = _Image2;
            item2.ForeColor = _color;
            item2.Text = String.Format("Bin2 ({0})", _value2);
            info.Items.Add(item2);

            ListViewRowDataItem item3 = new ListViewRowDataItem();
            item3.Image = _Image3;
            item3.ForeColor = _color;
            item3.Text = String.Format("Bin3 ({0})", _value3);
            info.Items.Add(item3);
            return info;
        }

        private ListViewCellInfo CreatePrintList(int _value1, int _value2, Image _image1, Image _Image2, Color _color)
        {
            ListViewCellInfo info = new ListViewCellInfo();
            ListViewRowDataItem item1 = new ListViewRowDataItem();
            item1.Image = _image1;
            item1.Text = String.Format("Printer ({0})", _value1);
            item1.ForeColor = _color;
            info.Items.Add(item1);

            ListViewRowDataItem item2 = new ListViewRowDataItem();
            item2.Image = _Image2;
            item2.Text = String.Format("Ink ({0})", _value2);
            item2.ForeColor = _color;
            info.Items.Add(item2);
            return info;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            radGridView1.Rows[radGridView1.CurrentRow.Index].Cells["Devices"].Value = CreateDeviceList(10, 40, Properties.Resources.canceled, Properties.Resources.working, Color.Red);
            radGridView1.Rows[radGridView1.CurrentRow.Index].Cells["Bins"].Value = CreateBinsList(220, 153, 232, Properties.Resources.canceled, Properties.Resources.working, Properties.Resources.canceled, Color.Red);
            radGridView1.Rows[radGridView1.CurrentRow.Index].Cells["Printer"].Value = CreatePrintList(33, 44, Properties.Resources.canceled, Properties.Resources.working, Color.Red);
		}

        private void radButton2_Click(object sender, EventArgs e)
        {
            radGridView1.Rows[radGridView1.CurrentRow.Index].Cells["Devices"].Value = CreateDeviceList(20, 30, Properties.Resources.working, Properties.Resources.canceled, Color.Black);
            radGridView1.Rows[radGridView1.CurrentRow.Index].Cells["Bins"].Value = CreateBinsList(300, 210, 180, Properties.Resources.working, Properties.Resources.canceled, Properties.Resources.working, Color.Black);
            radGridView1.Rows[radGridView1.CurrentRow.Index].Cells["Printer"].Value = CreatePrintList(120, 330, Properties.Resources.working, Properties.Resources.canceled, Color.Black);
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; ++i)
            {
                radButton1_Click(null, null);
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
                radButton2_Click(null, null);
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }

        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
			ListViewCell cell = (ListViewCell)e.CellElement;
            e.CellElement.DrawBorder = false; // Don't want border on selected cell
            e.CellElement.DrawFill = false; // Don't want selected cell to change color
		}
    }
}