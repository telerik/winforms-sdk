using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace EditRowInACustomFormCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindGrid();
             
            radGridView1.CreateCell += new GridViewCreateCellEventHandler(radGridView1_CreateCell);
        }

        public class CustomCell : GridDataCellElement
        {
            private RadDropDownButtonElement button;
            private UserControl1 userControl;

            public CustomCell(GridViewColumn column, GridRowElement row) : base(column, row)
            {
            }

            protected override void CreateChildElements()
            {
                base.CreateChildElements();
                this.button = new RadDropDownButtonElement();
                this.button.Text = "Click For Edit";
                this.Children.Add(button);
                this.button.Items.Add(CreateDropDownButton());
                
                //subscribe for RadDropDownButtonClick event
                this.button.Click += new EventHandler(button_Click);

                //subscribe for UserControl's saveButton click event
                RadButton saveButton = (RadButton)userControl.Controls["saveButton"];
                saveButton.Click += new EventHandler(saveButton_Click);
            }

            private RadMenuHostItem CreateDropDownButton()
            {
                this.userControl = new UserControl1();
                RadMenuHostItem host = new RadMenuHostItem(userControl);
                host.MaxSize = new Size(userControl.Size.Width, 0);

                return host;
            }

            void button_Click(object sender, EventArgs e)
            {
                RadTextBox textBox = (RadTextBox)userControl.Controls["textBox"];

                if (this.RowInfo.Cells["TextBoxColumn"].Value != null)
                {
                    textBox.Text = this.RowInfo.Cells["TextBoxColumn"].Value.ToString();
                }
                else
                {
                    textBox.Text = String.Empty;
                }

                RadDateTimePicker dateTimePicker = (RadDateTimePicker)userControl.Controls["dateTimePicker"];

                if (this.RowInfo.Cells["DateTimeColumn"].Value != null)
                {
                    dateTimePicker.Value = (DateTime)this.RowInfo.Cells["DateTimeColumn"].Value;
                }
                else
                {
                    dateTimePicker.SetToNullValue();
                }
            }

            void saveButton_Click(object sender, EventArgs e)
            {
                RadTextBox textBox = (RadTextBox)this.userControl.Controls["textBox"];
                this.RowInfo.Cells["TextBoxColumn"].Value = textBox.Text;

                RadDateTimePicker dateTimePicker = (RadDateTimePicker)this.userControl.Controls["dateTimePicker"];
                if (dateTimePicker.Value != dateTimePicker.NullDate)
                {
                    this.RowInfo.Cells["DateTimeColumn"].Value = dateTimePicker.Value;
                }
                
                //add new row
                GridViewNewRowInfo newRow = this.RowInfo as GridViewNewRowInfo;
                if (newRow != null)
                {
                    newRow.EndAddNewRow(); 
                }
               
                this.button.DropDownMenu.ClosePopup(RadPopupCloseReason.AppFocusChange);
            }
        }

        void radGridView1_CreateCell(object sender, GridViewCreateCellEventArgs e)
        { 
            if (e.Column.Name == "Edit" && (e.Row is GridDataRowElement || e.Row is GridNewRowElement))
            {
                e.CellType = typeof(CustomCell);
                e.CellElement = new CustomCell(e.Column, e.Row);
            }
        }

        private void BindGrid()
        { 
            //in this column we are going to store our RadDropDownButton 
            //which comes from our CustomCell
            GridViewTextBoxColumn editButtonColumn = new GridViewTextBoxColumn("Edit");
            editButtonColumn.FieldName = "Edit";
            editButtonColumn.ReadOnly = true;
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Width = 200;
            radGridView1.MasterTemplate.Columns.Add(editButtonColumn);
            
            GridViewTextBoxColumn textBoxColumn = new GridViewTextBoxColumn("TextBoxColumn");
            textBoxColumn.FieldName = "TextBoxColumn";
            textBoxColumn.HeaderText = "TextBoxColumn";
            textBoxColumn.Width = 200;
            radGridView1.MasterTemplate.Columns.Add(textBoxColumn);

            GridViewDateTimeColumn dateTimeColumn = new GridViewDateTimeColumn("DateTimeColumn");
            dateTimeColumn.FieldName = "DateTimeColumn";
            dateTimeColumn.HeaderText = "DateTimeColumn";
            dateTimeColumn.Width = 200;
            radGridView1.MasterTemplate.Columns.Add(dateTimeColumn);

            for (int i = 0; i < 10; i++)
            {
                radGridView1.Rows.Add(null, "Some Text " + i, DateTime.Now.AddHours(i));
            }
        }
    }
}