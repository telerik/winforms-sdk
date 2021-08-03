using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MultiCombobox_buttons_pop_up
{
    public partial class DataEntryForm : Telerik.WinControls.UI.RadForm
    {
        DataTable dt;
        RadMultiColumnComboBoxElement mccb;
        public DataEntryForm(RadMultiColumnComboBoxElement mccb)
        {
            InitializeComponent();
            this.mccb = mccb;

            this.bindingSource1 = new BindingSource();
            this.bindingSource1.DataSource = mccb.EditorControl.DataSource;
            this.radDataEntry1.DataSource = this.bindingSource1;
            this.radBindingNavigator1.BindingSource = this.bindingSource1;

            this.radBindingNavigator1.AutoHandleAddNew = false;
            dt = (DataTable)mccb.EditorControl.DataSource;
        }

        private void RadBindingNavigator1AddNewItem_Click(object sender, System.EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr[0] = "";
            dr[1] = "";
            dr[2] = "";
            dr[3] = new DateTime(2020, 1, 1);
            dr[4] = false;
            dr[5] = "";

            dt.Rows.Add(dr);
            dt.AcceptChanges();
            this.bindingSource1.Position = this.bindingSource1.Count - 1;
        }
        private void RadBindingNavigator1DeleteItem_Click(object sender, System.EventArgs e)
        {

            this.bindingSource1.RemoveCurrent();
        }

    }
}
