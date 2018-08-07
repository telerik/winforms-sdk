using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace _1171173
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            
            radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            radGridView1.DataSource = GetTable();
            radGridView1.EnableFiltering = true;
            

        }

        

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var col = new CustomColumn("Bool");
            radGridView1.Columns.RemoveAt(0);
            radGridView1.Columns.Insert(0, col);

        }
        static DataTable GetTable()
        {

            DataTable table = new DataTable();
            table.Columns.Add("Bool", typeof(bool));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            for (int i = 0; i < 10; i++)
            {
                table.Rows.Add(false, "Indocin", "David", DateTime.Now);
                table.Rows.Add(false, "Enebrel", "Sam", DateTime.Now);
                table.Rows.Add(false, "Hydralazine", "Christoff", DateTime.Now);
                table.Rows.Add(false, "Combivent", "Janet", DateTime.Now);
                table.Rows.Add(false, "Dilantin", "Melanie", DateTime.Now);
            }
            return table;
        }
    }
}
