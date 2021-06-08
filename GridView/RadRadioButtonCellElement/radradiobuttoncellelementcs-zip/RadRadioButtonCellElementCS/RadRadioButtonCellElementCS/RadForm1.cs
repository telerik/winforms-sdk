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
            dt.Columns.Add(new DataColumn("FavouriteColor", typeof(int)));

            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = i;
                dr[1] = "John" + i.ToString();
                dr[2] = rand.Next(3);
                dt.Rows.Add(dr);
            }

            this.radGridView1.DataSource = dt;

            this.radGridView1.MasterTemplate.BeginUpdate();

            this.radGridView1.Columns.RemoveAt(2);

            RadioButtonColumn column = new RadioButtonColumn("FavouriteColor");
            column.HeaderText = "Favourite Color";
            column.Width = 170;
            column.ReadOnly = true;
            this.radGridView1.Columns.Add(column);

            this.radGridView1.MasterTemplate.EndUpdate();
        }
    }
}