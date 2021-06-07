using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CustomRowBehaviorCSharp
{
    public partial class Form1 : Form
    {
        List<Item> items = new List<Item>();

        public Form1()
        {
            InitializeComponent();

            this.radGridView1.TableElement.CurrentRowHeaderImage = null;

            this.radGridView1.RowValidating += radGridView1_RowValidating;
            this.radGridView1.RowValidated += radGridView1_RowValidated;
            this.radGridView1.CurrentRowChanged += radGridView1_CurrentRowChanged;
            this.radGridView1.CellValidating += radGridView1_CellValidating;
            this.radGridView1.PreviewKeyDown += radGridView1_PreviewKeyDown;

            for (int i = 0; i < 10; i++)
            {
                items.Add(new Item(i, "Item" + i, i % 2 == 0, DateTime.Now.AddDays(i)));
            }

            this.radGridView1.DataSource = items;
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private void radGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (this.radGridView1.CurrentRow is GridViewDataRowInfo && e.KeyData == Keys.Escape)
            {
                //revert the previous cell value which is stored in advance.
                if (this.radGridView1.ActiveEditor == null && this.radGridView1.Tag == "RowNotValidated")
                {
                    foreach (KeyValuePair<int, object> cell in initialValues)
                    {
                        this.radGridView1.CurrentRow.Cells[cell.Key].Value = cell.Value;
                    }
                    this.radGridView1.CurrentRow.ErrorText = string.Empty;
                }
            }
        }
        
        private void radGridView1_RowValidated(object sender, RowValidatedEventArgs e)
        {
            this.radGridView1.Tag = null;
        }
        
        private void radGridView1_CellValidating(object sender, CellValidatingEventArgs e)
        {
            if (this.radGridView1.CurrentCell != null)
            {
                int cellIndex = e.ColumnIndex;
                object initialCellValue = e.Row.Cells[cellIndex].Value;
                if (!initialValues.ContainsKey(cellIndex))
                {
                    initialValues.Add(cellIndex, initialCellValue);
                }
            }
        }

        private void radGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow != null)
            {
                initialValues = new Dictionary<int, object>();
            }
        }

        private void radGridView1_RowValidating(object sender, RowValidatingEventArgs e)
        {
            e.Row.ErrorText = string.Empty;
            if (e.Row is GridViewDataRowInfo)
            {
                if (e.Row.Cells[1].Value == null || String.IsNullOrEmpty(e.Row.Cells[1].Value.ToString()))
                {
                    e.Row.ErrorText = "Empty value is not allowed";
                    e.Cancel = true;
                    this.radGridView1.Tag = "RowNotValidated";
                }
            }
        }

        //Cell index as a Key, cell value as Value
         Dictionary<int, object> initialValues;

        public class Item
        {
            public int Id { get; set; }

            public string Title { get; set; }

            public bool IsActive { get; set; }

            public DateTime CreatedOn { get; set; }

            public Item(int id, string title, bool isActive, DateTime createdOn)
            {
                this.Id = id;
                this.Title = title;
                this.IsActive = isActive;
                this.CreatedOn = createdOn;
            }
        }
    }
}