using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace MCCB_CustomFilteringCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);

            this.radMultiColumnComboBox1.AutoFilter = true;
            this.radMultiColumnComboBox1.DisplayMember = "ContactName";
            radMultiColumnComboBox1.Text = "";

            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.radMultiColumnComboBox1.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.radMultiColumnComboBox1.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            radMultiColumnComboBox1.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = true;

            radMultiColumnComboBox1.MultiColumnComboBoxElement.EditorControl.CustomFiltering += EditorControl_CustomFiltering;
            radMultiColumnComboBox1.KeyDown += radMultiColumnComboBox1_KeyDown;

        }

        void radMultiColumnComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (this.radMultiColumnComboBox1.ValueMember != "")
                {
                    radMultiColumnComboBox1.SelectedValue = radMultiColumnComboBox1.EditorControl.CurrentRow.Cells[radMultiColumnComboBox1.ValueMember].Value;
                }
                else
                {
                    radMultiColumnComboBox1.SelectedValue = radMultiColumnComboBox1.EditorControl.CurrentRow.Cells[radMultiColumnComboBox1.DisplayMember].Value;
                }

                radMultiColumnComboBox1.Text = radMultiColumnComboBox1.EditorControl.CurrentRow.Cells[radMultiColumnComboBox1.DisplayMember].Value.ToString();
                radMultiColumnComboBox1.MultiColumnComboBoxElement.ClosePopup();
                radMultiColumnComboBox1.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll();
            }

        }
        void EditorControl_CustomFiltering(object sender, Telerik.WinControls.UI.GridViewCustomFilteringEventArgs e)
        {
            RadMultiColumnComboBoxElement element = radMultiColumnComboBox1.MultiColumnComboBoxElement;

            string textToSearch = radMultiColumnComboBox1.Text;
            if (AutoCompleteMode.Append == (element.AutoCompleteMode & AutoCompleteMode.Append))
            {
                if (element.SelectionLength > 0 && element.SelectionStart > 0)
                {
                    textToSearch = radMultiColumnComboBox1.Text.Substring(0, element.SelectionStart);
                }
            }
            if (string.IsNullOrEmpty(textToSearch))
            {
                e.Visible = true;

                for (int i = 0; i < element.EditorControl.ColumnCount; i++)
                {
                    e.Row.Cells[i].Style.Reset();
                  
                }
                e.Row.InvalidateRow();
                return;
            }

            e.Visible = false;
            for (int i = 0; i < element.EditorControl.ColumnCount; i++)
            {
                string text = e.Row.Cells[i].Value.ToString();
                if (text.IndexOf(textToSearch, 0, StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    e.Visible = true;
                    e.Row.Cells[i].Style.CustomizeFill = true;
                    e.Row.Cells[i].Style.DrawFill = true;
                    e.Row.Cells[i].Style.BackColor = Color.FromArgb(201, 252, 254);
                }
                else
                {
                    e.Row.Cells[i].Style.Reset();
                    
                }
            }
            e.Row.InvalidateRow();

        }
    }
}
