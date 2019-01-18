using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace GridViewEditDialog
{
    public partial class EditForm : Telerik.WinControls.UI.RadForm
    {
        private MainForms.Student student;

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(MainForms.Student student) : this()
        {
            this.student = student;

            this.radDropDownList1.Items.AddRange(new List<string>() { "A", "A+", "A-", "B", "B+", "B-", "C", "C+", "C-", "D", "D+", "D-", "E", "E+", "E-", "F", "F+", "F-" });
            this.radDropDownList1.DropDownStyle = RadDropDownStyle.DropDownList;
            this.radDropDownList1.DropDownListElement.SyncSelectionWithText = true;

            this.radSpinEditor1.Value = this.student.Id;
            this.radTextBox1.Text = this.student.Name;
            this.radDropDownList1.SelectedValue = this.student.Grade;
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.student.Id = (int)this.radSpinEditor1.Value;
                this.student.Name = this.radTextBox1.Text;
                this.student.Grade = this.radDropDownList1.SelectedItem.Text;
                this.Close();
            }
        }

        private bool IsValidData()
        {
            this.errorProvider1.Clear();

            if (this.radTextBox1.Text == string.Empty)
            {
                this.errorProvider1.SetError(this.radTextBox1, "Invalid name!");
                return false;
            }

            return true;
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}