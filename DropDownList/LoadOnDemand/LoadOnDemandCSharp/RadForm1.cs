
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace LoadOnDemand
{

    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {

        private List<ExampleData> _dropDownDataSource = ExampleData.CreateList();

        public RadForm1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize the load on demand controls..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadForm1_Load(object sender, System.EventArgs e)
        {
            SetRadDropDownList1();
            SetRadGridView1();

        }

        /// <summary>
        /// Three things are required to create a Load on Demand dropdownlist:<br/>
        /// 1 - Set autocompletemode to suggest<br/>
        /// 2 - Set the display- and valuemember of the dropdownlist<br/>
        /// 3 - Add custom handlers to the KeyUp and Leave event of the dropdownlist<br/>
        /// </summary>
        /// <remarks>The properties and handlers could also be set in the visual studio designer</remarks>

        private void SetRadDropDownList1()
        {
            {
                RadDropDownList1.AutoCompleteMode = AutoCompleteMode.Suggest;
                RadDropDownList1.DisplayMember = "ExampleDisplayMember";
                RadDropDownList1.ValueMember = "ExampleValueMember";
                RadDropDownList1.KeyUp += RadDropDownList1_KeyUp;
                RadDropDownList1.Leave += RadDropDownList1_leave;
            }

            //show current values of the dropdownlist in thui UI.
            lblSelectedIndex.DataBindings.Add(new Binding("Text", RadDropDownList1, "SelectedIndex", true));
            lblSelectedValue.DataBindings.Add(new Binding("Text", RadDropDownList1, "SelectedValue", true));
            lblSelectedItem.DataBindings.Add(new Binding("Text", RadDropDownList1, "SelectedItem", true));

        }

        /// <summary>
        /// Three things need to be done to create a Load on Demand dropdownlist:<br/>
        /// 1 - Set dropdownstyle to dropdown and autocompletemode to suggest<br/>
        /// 2 - Set the display- and valuemember of the dropdownlist<br/>
        /// 3 - Add custom handlers to the EditorRequired and CelEndEdit event of the radgridview<br/>
        /// </summary>
        /// <remarks>The columns, properties and handlers could also be set in the visual studio designer</remarks>

        private void SetRadGridView1()
        {
            //create the columns, first the dropdown column
            GridViewComboBoxColumn ddlCol = new GridViewComboBoxColumn
            {
                HeaderText = "Example ddl",
                Name = "ddlExample",
                DropDownStyle = RadDropDownStyle.DropDown,
                AutoCompleteMode = AutoCompleteMode.Suggest,
                FieldName = "ExampleValueMember",
                ValueMember = "ExampleValueMember",
                DisplayMember = "ExampleDisplayMember"
            };
            GridViewTextBoxColumn txtCol1 = new GridViewTextBoxColumn
            {
                Name = "ExampleDisplayMember",
                HeaderText = "Display"
            };
            GridViewTextBoxColumn txtCol2 = new GridViewTextBoxColumn
            {
                Name = "Guid",
                HeaderText = "Value"
            };
            GridViewTextBoxColumn txtCol3 = new GridViewTextBoxColumn
            {
                Name = "WhateverOtherProps",
                HeaderText = "Other"
            };

            //Initialize the grid (add columns and handlers and a few other properties)
            RadGridView1.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            RadGridView1.MasterTemplate.AllowCellContextMenu = false;
            RadGridView1.MasterTemplate.AutoGenerateColumns = false;
            RadGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            RadGridView1.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] {
				ddlCol,
				txtCol1,
				txtCol2,
				txtCol3
			});
            RadGridView1.EditorRequired += RadGridView1_EditorRequired;
            RadGridView1.CellEndEdit += RadGridView1_CellEndEdit;
        }

        #region "Load on Demand RadDropDownList1"

        /// <summary>
        /// Handle the KeyUp event of RadDropDownList1.
        /// Loads the dropdown datasource when atleast 2 characters are entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>

        private void RadDropDownList1_KeyUp(object sender, KeyEventArgs e)
        {
            //Change datasource only when a char or number was entered
            if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyValue >= 48 && e.KeyValue <= 58))
            {
                //we need also atleast 2 input chars to get the data
                if (RadDropDownList1.Text.Length > 1)
                {
                    //catch any keypresses while processing
                    RadDropDownList1.KeyDown += SuspendKeyboard;

                    //input state
                    string txt = RadDropDownList1.Text;
                    int cursorPos = RadDropDownList1.SelectionStart;

                    //change the RadDropDownList1 datasource, only get records starting with the inputed text..
                    //notice the Guid's of the items change(!) since the list is generated each 'load on emand'-request!
                    //just to demonstrate the datasource is really changed!
                    RadDropDownList1.DataSource = _dropDownDataSource.Where<ExampleData>(c => c.ExampleDisplayMember.StartsWith(txt));

                    //reset the user input
                    RadDropDownList1.Text = txt;
                    RadDropDownList1.SelectionStart = cursorPos;

                    //release the keypress 'lock'
                    RadDropDownList1.KeyDown -= SuspendKeyboard;

                }

                //Cancel any processing of the handled keypress
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// Whenever an item is not selected but partly entered, the dropdown needs to be cleared since the user
        /// dit not make an actual selection from the available values...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void RadDropDownList1_leave(object sender, System.EventArgs e)
        {
            RadDropDownList ddl = (RadDropDownList)sender;
            bool clear = true;

            //check if the selected item display member equals the dropdownlist textproperty.
            if (ddl.SelectedItem != null)
            {
                ExampleData data = (ExampleData)ddl.SelectedItem.DataBoundItem;
                if (data != null)
                {
                    if (ddl.Text.Trim() == data.ExampleDisplayMember.Trim())
                        clear = false;
                }
            }

            //if it is not, the user did not make a selection.
            if (clear)
            {
                ddl.SelectedIndex = -1;
                ddl.Text = string.Empty;
                ddl.SelectedItem = null;
                ddl.Update();
            }

        }

        /// <summary>
        /// Catch any keyboard input and ignor it!
        /// Helper functie for the load on demand dropdownlists to ignore keypresses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void SuspendKeyboard(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        #endregion

        /// <summary>
        /// Replace the default RadDropDownListEditor with a load on demand editor when the column is "ddlExample"!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void RadGridView1_EditorRequired(object sender, Telerik.WinControls.UI.EditorRequiredEventArgs e)
        {
            if (RadGridView1.CurrentColumn.Name == "ddlExample")
            {
                LoadOnDemandRadDropDownListEditor ddl = new LoadOnDemandRadDropDownListEditor();
                ddl.DisplayMember = "ExampleDisplayMember";
                ddl.Valuemember = "ExampleValueMember";
                ddl.KeyUp += RadGridView1_ddlExample_KeyUp;
                ddl.SelectedIndexChanged += RadGridView1_ddlExample_SelectedIndexChanged;
                e.Editor = ddl;
            }
        }

        /// <summary>
        /// For column "ddlExample" check if the user input (stored in the cell.Tag of the dropdownlist cell) equals the
        /// full displaymember text. If so, the user selected the item. If not the user did not select an item!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>

        private void RadGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Column.Name == "ddlExample")
            {
                bool clear = true;

                if (e.Value != null)
                {
                    //get the user input, stored in the cell.Tag
                    GridViewEditManager mngr = (GridViewEditManager)sender;
                    string input = mngr.GridViewElement.CurrentCell.Tag.ToString();

                    //In the example, the valuemember is a typeof Guid. But the e.Value is an object. We nee to cast it..
                    Guid id = new Guid(e.Value.ToString());
                    //and find the databound item
                    ExampleData selected = _dropDownDataSource.FirstOrDefault<ExampleData>(c => c.ExampleValueMember.Equals(id));
                    if (selected != null)
                    {
                        // if the user input equals the dataitem displaymember, we have a winner
                        if (input.Equals(selected.ExampleDisplayMember))
                        {
                            e.Row.Cells["ddlExample"].Value = selected.ExampleDisplayMember;
                            e.Row.Cells["ExampleDisplayMember"].Value = selected.ExampleDisplayMember;
                            e.Row.Cells["Guid"].Value = selected.ExampleValueMember;
                            e.Row.Cells["WhateverOtherProps"].Value = selected.WhateverOtherProps;
                            e.Row.InvalidateRow();
                            clear = false;
                        }
                    }
                }

                //if the input does not equal the selected items displaymember, the user did not make a selection.
                if (clear)
                {
                    e.Row.Cells["ddlExample"].Value = null;
                    e.Row.Cells["ExampleDisplayMember"].Value = string.Empty;
                    e.Row.Cells["Guid"].Value = string.Empty;
                    e.Row.Cells["WhateverOtherProps"].Value = string.Empty;
                }

                e.Row.InvalidateRow();
            }

        }

        /// <summary>
        /// De event handler of the load on demand dropdown editor from column  "ddlExample"  
        /// Handles KeyUp event  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>

        private void RadGridView1_ddlExample_KeyUp(object sender, LoadOnDemandRadDropDownListEditorEventargs e)
        {
            RadDropDownListEditorElement ddl = e.RadDropDownListEditorElement;

            //input state
            string txt = ddl.TextBox.Text;
            GridComboBoxCellElement cell = (GridComboBoxCellElement)ddl.Parent;

            //change the RadDropDownList1 datasource, only get records starting with the inputed text..
            ddl.DataSource = _dropDownDataSource.Where<ExampleData>(c => c.ExampleDisplayMember.StartsWith(txt));

            //reset the user input
            ddl.TextBox.Text = txt;
            ddl.SelectionStart = ddl.TextBox.Text.Length;
            ddl.Text = txt;
            // the text input is stored in the cell Tag property for alter evaluation
            cell.Tag = txt;

        }

        /// <summary>
        /// The event handler of the load on demand dropdown editor from column  "ddlExample"  
        /// Handles the RadDropDownListEditorElement.SelectedIndexChanged event 
        /// The user input is stored in the cell.Tag property, when the user selects an item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void RadGridView1_ddlExample_SelectedIndexChanged(object sender, LoadOnDemandRadDropDownListEditorEventargs e)
        {
            RadDropDownListEditorElement ddl = e.RadDropDownListEditorElement;
            GridComboBoxCellElement cell = (GridComboBoxCellElement)ddl.Parent;

            if (ddl.SelectedItem != null && ddl.SelectedItem.DataBoundItem != null)
            {
                ExampleData data = (ExampleData)ddl.SelectedItem.DataBoundItem;
                //when the user makes a selection, the cell.Tag property should contain the displaymember property of the
                //databound item.
                cell.Tag = data.ExampleDisplayMember;
            }
        }








    }
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik, @toddanglin
//Facebook: facebook.com/telerik
//=======================================================
