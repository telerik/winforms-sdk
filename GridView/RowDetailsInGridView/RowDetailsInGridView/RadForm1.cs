using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RowDetailsInGridView
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            this.radGridView1.CellFormatting += radGridView1_CellFormatting;
           
        }

        private void radGridView1_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement.RowInfo.IsCurrent &&
                e.CellElement.ColumnInfo == this.radGridView1.DetailsColumn)
            {
                e.CellElement.TextImageRelation = TextImageRelation.ImageBeforeText;
                e.CellElement.TextAlignment = ContentAlignment.TopLeft;
                e.CellElement.ImageAlignment = ContentAlignment.MiddleLeft;
                e.CellElement.Padding = new Padding(10);
                e.CellElement.ImageLayout = ImageLayout.Zoom;

                byte[] bytes = (byte[])e.CellElement.RowInfo.Cells["Photo"].Value;
                e.CellElement.Image = GetImageFromBytes(bytes);
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.ImageProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.PaddingProperty, ValueResetFlags.Local);
            }
        }

        private const int OleHeaderSize = 78;

        private Image GetImageFromBytes(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return null;
            }

            Image result = null;
            MemoryStream stream = null;

            try
            {
                int count;
                int start;

                if (IsOleContainer(bytes))
                {
                    count = bytes.Length - OleHeaderSize;
                    start = OleHeaderSize;
                }
                else
                {
                    count = bytes.Length;
                    start = 0;
                }

                stream = new MemoryStream(bytes, start, count);
                result = Image.FromStream(stream);
            }
            catch
            {
                result = null;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
            return result;
        }

        private bool IsOleContainer(byte[] imageData)
        {
            return (imageData != null
                && imageData[0] == 0x15
                && imageData[1] == 0x1C);
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.nwindDataSet.Employees);

            this.radGridView1.ReadOnly = true;
            this.radGridView1.AllowColumnReorder = false;
            this.radGridView1.AllowColumnResize = false;
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.AutoExpandGroups = true;
            this.radGridView1.TableElement.RowHeight = 40;

            this.radGridView1.GroupDescriptors.Add(new GridGroupByExpression("City GroupBy City"));
            this.radGridView1.Groups[1][0].IsCurrent = true;

            this.radGridView1.Columns["Photo"].VisibleInColumnChooser = false;
            this.radGridView1.Columns["Photo"].IsVisible = false;
            this.radGridView1.Columns["Notes"].WrapText = true;
            this.radGridView1.Columns["LastName"].SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;

            this.radGridView1.DetailsColumn = this.radGridView1.Columns["Notes"];

        }
    }
}
