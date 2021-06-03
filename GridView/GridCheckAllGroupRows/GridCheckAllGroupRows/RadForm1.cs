using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GridCheckAllGroupRows
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            ThemeResolutionService.ApplicationThemeName = "TelerikMetro";

            this.radGridView1.CreateCell += radGridView1_CreateCell;
            this.radGridView1.CellValueChanged += radGridView1_CellValueChanged;
        }

        private void radGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name == "Discontinued")
            {
                GridViewGroupRowInfo parentGroup = e.Row.Parent as GridViewGroupRowInfo;
                if (parentGroup != null)
                {
                    bool atLeastOneOff = false;
                    foreach (GridViewRowInfo row in parentGroup.ChildRows)
                    {
                        if ((bool)row.Cells["Discontinued"].Value == false)
                        {
                            atLeastOneOff = true;
                            break;
                        }
                    }
                    parentGroup.Tag = !atLeastOneOff;
                }
            }
        }

        private void radGridView1_CreateCell(object sender, Telerik.WinControls.UI.GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridGroupContentCellElement))
            {
                e.CellElement = new CustomGridGroupContentCellElement(e.Column, e.Row);
            }
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
        }
    }
}