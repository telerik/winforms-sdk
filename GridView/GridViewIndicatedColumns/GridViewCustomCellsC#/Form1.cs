using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GridViewCustomCells
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            IndicatedComboBoxColumn comboColumn = new IndicatedComboBoxColumn();
            comboColumn.HeaderText = "Combo Box";
            comboColumn.DataSource = GetTable();
            comboColumn.ValueMember = "Name";
            comboColumn.DisplayMember = "Name";
            comboColumn.Width = 100;
            radGridView1.Columns.Add(comboColumn);

            IndicatedDateTimeColumn DateTimeColumn = new IndicatedDateTimeColumn();
            DateTimeColumn.HeaderText = "DateTime";
            radGridView1.Columns.Add(DateTimeColumn);

            IndicatedBrowseColumn browseColumn = new IndicatedBrowseColumn();
            browseColumn.HeaderText = "Browse";
            radGridView1.Columns.Add(browseColumn);

            IndicatedCalculatorColumn calculatorColumn = new IndicatedCalculatorColumn();
            calculatorColumn.HeaderText = "Calcualtor";
            radGridView1.Columns.Add(calculatorColumn);

            IndicatedColorColumn colorColumn = new IndicatedColorColumn();
            colorColumn.HeaderText = "Color";
            radGridView1.Columns.Add(colorColumn);

            IndicatedMultiComboBoxColumn MCCBColumn = new IndicatedMultiComboBoxColumn();
            MCCBColumn.HeaderText = "MCCB";
            MCCBColumn.DataSource = GetTable();
            MCCBColumn.DisplayMember = "Name";
            MCCBColumn.ValueMember = "Name";
            radGridView1.Columns.Add(MCCBColumn);

            IndicatedDecimalColumn deciamlColumn = new IndicatedDecimalColumn();
            deciamlColumn.HeaderText = "Decimal";
            radGridView1.Columns.Add(deciamlColumn);

            for (int i = 0; i < 5; i++)
            {
                radGridView1.Rows.Add("David", new DateTime(2014,8,4), @"C:\", 123456, Color.Black, "Sam", 123456);
            }
        }

        static DataTable GetTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);

            return table;
        }
    }
}