using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace _547099
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable t = new DataTable();
            t.Columns.Add("ID", typeof(int));
            t.Columns.Add("Name", typeof(string));
            t.Rows.Add(1, "one");
            t.Rows.Add(2, "two");
            t.Rows.Add(3, "three");
            t.Rows.Add(4, "four");
            t.Rows.Add(5, "five");
            t.Rows.Add(6, "six");
            t.Rows.Add(7, "seven");
            t.Rows.Add(8, "eight");
            t.Rows.Add(9, "nine");
            t.Rows.Add(10, "ten");

            CustomColumn col = new CustomColumn("MutiSelect column");
            col.DataSource = t;
            col.DisplayMember = "Name";
            col.ValueMember = "ID";
            radGridView1.Columns.Add(col);

            radGridView1.Rows.Add( new int[] { 9, 6, 10 });
            radGridView1.Rows.Add( new int[] { 5, 1, 3 });
            radGridView1.Rows.Add( new int[] { 8,7 });
            radGridView1.Rows.Add( new int[] { 4, 2, 1 });
        }
    }
}
