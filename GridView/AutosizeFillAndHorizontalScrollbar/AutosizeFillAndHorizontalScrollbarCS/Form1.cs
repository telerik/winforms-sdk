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

namespace MixedSelfGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            DataTable people = new DataTable("people");
            people.Columns.Add("ID", typeof(int));
            people.Columns.Add("Title", typeof(string));
            people.Columns.Add("FirstName", typeof(string));
            people.Columns.Add("LastName", typeof(string));
            people.Columns.Add("Address", typeof(string));
            people.Columns.Add("City", typeof(string));
            people.Columns.Add("State", typeof(string));
            people.Columns.Add("ZIP", typeof(string));


            people.Rows.Add(0, "CEO - Chief executive officer", "John", "Doe", "1 Red Street", "Boston", "Massachusetts", "01234");
            people.Rows.Add(0, "CFO - Chief financial officer", "Mario", "Rossi", "1 Black Street", "Boston", "Massachusetts", "01234");
            people.Rows.Add(0, "VP - Vice president", "Carlo", "Bianchi", "1 Green Street", "Miami", "Florida", "54321");
            
            this.radGridView1.DataSource = people;

            this.radGridView1.Columns["ID"].MinWidth = 70;
            this.radGridView1.Columns["ID"].MaxWidth = 70;
            this.radGridView1.Columns["ID"].Width = 70;

            this.radGridView1.Columns["Title"].MinWidth = 100;
            // Set the column that has to fill the rest of the space to the full grid Width
            this.radGridView1.Columns["Title"].Width = this.radGridView1.Width;

            this.radGridView1.Columns["FirstName"].MinWidth = 200;
            this.radGridView1.Columns["FirstName"].MaxWidth = 200;
            this.radGridView1.Columns["FirstName"].Width = 200;

            this.radGridView1.Columns["LastName"].MinWidth = 200;
            this.radGridView1.Columns["LastName"].MaxWidth = 200;
            this.radGridView1.Columns["LastName"].Width = 200;

            this.radGridView1.Columns["Address"].MinWidth = 200;
            this.radGridView1.Columns["Address"].MaxWidth = 200;
            this.radGridView1.Columns["Address"].Width = 200;

            this.radGridView1.Columns["City"].MinWidth = 200;
            this.radGridView1.Columns["City"].MaxWidth = 200;
            this.radGridView1.Columns["City"].Width = 200;

            this.radGridView1.Columns["State"].MinWidth = 70;
            this.radGridView1.Columns["State"].MaxWidth = 70;
            this.radGridView1.Columns["State"].Width = 70;

            this.radGridView1.Columns["ZIP"].MinWidth = 50;
            this.radGridView1.Columns["ZIP"].MaxWidth = 50;
            this.radGridView1.Columns["ZIP"].Width = 50;
            
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;            
        }

        void radGridView1_SizeChanged(object sender, System.EventArgs e)
        {
            if (((RadGridView)sender).MasterTemplate.Columns.Count > 0)
            {
                int columnsWidth = 0;
                for (int index = 0; index < ((RadGridView)sender).MasterTemplate.Columns.Count; index++)
                {
                    if (((RadGridView)sender).Columns[index].IsVisible)
                    {
                        columnsWidth += ((RadGridView)sender).Columns[index].Width;
                    }
                }
                int gridWidth = ((RadGridView)sender).Width;
                if (columnsWidth > gridWidth)
                {
                    ((RadGridView)sender).MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None;
                }
                else
                {
                    ((RadGridView)sender).MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                }
            }

        }

    }
}
