using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace CustomCellEditor
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Value", typeof(int));
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                table.Rows.Add(i, "Row " + i, r.Next(3));
            }
            this.radGridView1.DataSource = table;

            List<Item> items = new List<Item>();
            items.Add(new Item(0, "Zero"));
            items.Add(new Item(1, "One"));
            items.Add(new Item(2, "Two"));
            items.Add(new Item(3, "Three"));

            GridViewComboBoxColumn combo = new GridViewComboBoxColumn();
            combo.Name = "CustomColumn";
            combo.FieldName = "Value";
            combo.DataSource = items;
            combo.DisplayMember = "Name";
            combo.ValueMember = "Id";
            this.radGridView1.Columns.Add(combo);

            this.radGridView1.CreateCell += new GridViewCreateCellEventHandler(radGridView1_CreateCell);
            this.radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(radGridView1_CellBeginEdit);
            this.radGridView1.CellEndEdit += new GridViewCellEventHandler(radGridView1_CellEndEdit);
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private void radGridView1_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.Row is GridDataRowElement)
            {
                if (e.Column.Name == "CustomColumn")
                {
                    e.CellType = typeof(CustomInfoCell);
                }
            }
        }

        private Font font = new Font("Arial", 9F, FontStyle.Bold);
        private void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (e.Column.Name == "CustomColumn")
            {
                RadButtonElement radButtonElement = new RadButtonElement();
                radButtonElement.Font = font;
                radButtonElement.Text = "...";
                radButtonElement.Click += new EventHandler(radButtonElement_Click);
                this.radGridView1.CurrentCell.Children.Add(radButtonElement);
            }
        }

        private void radButtonElement_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.radGridView1.CurrentRow.Cells[1].Value.ToString());
        }

        private void radGridView1_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name == "CustomColumn")
            {
                if (this.radGridView1.CurrentCell.Children.Count == 1)
                {
                    this.radGridView1.CurrentCell.Children.RemoveAt(0);
                }
            }
        }

        public class Item
        {
            private int id;
            private string name;

            public Item()
            {
            }

            public Item(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public int Id 
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }

            public string Name 
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
        }
    }
}