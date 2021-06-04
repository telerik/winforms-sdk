using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace CheckBoxInHeader_csharp
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            AddCheckColumn();

            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.EnableFiltering = true;

            this.radGridView1.ViewCellFormatting += radGridView1_ViewCellFormatting;
        }
        private void radGridView1_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is Telerik.WinControls.UI.GridFilterCellElement && e.CellElement.ColumnIndex == 0)
                e.CellElement.Children.Clear();
        }


        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
        }

        private void AddCheckColumn()
        {
            CustomCheckBoxColumn checkColumn = new CustomCheckBoxColumn();
            checkColumn.Name = "Select";
            checkColumn.HeaderText = "All";
            this.radGridView1.Columns.Insert(0, checkColumn);
        }
    }

    public class CustomCheckBoxColumn : GridViewCheckBoxColumn
    {
        public override Type GetCellType(GridViewRowInfo row)
        {
            if (row is GridViewTableHeaderRowInfo)
                return typeof(CheckBoxHeaderCell);
            return base.GetCellType(row);
        }
    }
}
}
