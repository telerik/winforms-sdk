using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace RadRadioButtonCellElementCS
{
    public partial class RadForm1 : RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(int)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Radio Button", typeof(int)));

            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i;
                dr[1] = "John" + i.ToString();
                dr[2] = 0;
                dt.Rows.Add(dr);
            }
            this.radGridView1.DataSource = dt;

            this.radGridView1.MasterTemplate.BeginUpdate();
            this.radGridView1.Columns.RemoveAt(2);

            RadioButtonColumn column = new RadioButtonColumn("Radio Button");
            column.RadioButtonToggleStateChanged += column_RadioButtonToggleStateChanged;
            column.HeaderText = "Radio Button";
            column.ReadOnly = true;
            this.radGridView1.Columns.Add(column);

            this.radGridView1.MasterTemplate.EndUpdate();
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        int oldIndex = -1;
        private void column_RadioButtonToggleStateChanged(object sender, RadioButtonEventArgs e)
        {
            if (oldIndex != e.RowIndex && oldIndex > - 1)
            {
                this.radGridView1.Rows[oldIndex].Cells[2].Value = 0;
            }

            oldIndex = e.RowIndex;
        }
    }
}