//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SampleApp
{
    public partial class Form1
    {
        internal Form1()
        {
            InitializeComponent();
        }

        private LoadOnDemandCellEditor _loadOnDemandCellEditor;

        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeLinesGrid();

            LoadGrid();
        }

        //Load the grid columns, set grid properties, etc.
        private void InitializeLinesGrid()
        {
            GridViewMultiComboBoxColumn gridMultiColumnComboColumn = null;

            rgData.MasterTemplate.Columns.Clear();
            rgData.MasterTemplate.AutoGenerateColumns = false;

            gridMultiColumnComboColumn = CreateGridMultiComboBoxColumn("COUNTRY", "COUNTRY", "Country", null, "COUNTRY", "COUNTRY", 400);
            rgData.MasterTemplate.Columns.Add(gridMultiColumnComboColumn);

            //Set MasterGridViewTemplate properties
            rgData.MasterTemplate.AllowEditRow = true;
            rgData.MasterTemplate.AllowAddNewRow = false;
            rgData.MasterTemplate.EnableGrouping = false;
            rgData.MasterTemplate.AllowColumnChooser = false;
            rgData.MasterTemplate.AllowColumnHeaderContextMenu = false;

            rgData.MultiSelect = true;
            rgData.SelectionMode = GridViewSelectionMode.FullRowSelect;
            rgData.ShowGroupPanel = false;
        }

        //Create GridViewMultiComboBoxColumn with values passed in
        private GridViewMultiComboBoxColumn CreateGridMultiComboBoxColumn(string Name, string fieldName, string headerText, BindingSource dataSource, string valueMember, string displayMember, int width)
        {
            GridViewMultiComboBoxColumn multiComboBoxColumn = new GridViewMultiComboBoxColumn();

            multiComboBoxColumn.Name = Name;
            multiComboBoxColumn.FieldName = fieldName;
            multiComboBoxColumn.HeaderText = headerText;
            multiComboBoxColumn.DataSource = dataSource;
            multiComboBoxColumn.ValueMember = valueMember;
            multiComboBoxColumn.DisplayMember = displayMember;
            multiComboBoxColumn.Width = width;

            //Set default values
            multiComboBoxColumn.HeaderTextAlignment = ContentAlignment.BottomLeft;
            multiComboBoxColumn.DropDownStyle = RadDropDownStyle.DropDown;

            return multiComboBoxColumn;
        }

        //Load the grid
        private void LoadGrid()
        {
            GridViewRowInfo rowInfo = null;

            rowInfo = rgData.Rows.AddNew();
            rowInfo.Cells["COUNTRY"].Value = "United States of America";

            rowInfo = rgData.Rows.AddNew();
            rowInfo.Cells["COUNTRY"].Value = "Malta";

            rowInfo = rgData.Rows.AddNew();
            rowInfo.Cells["COUNTRY"].Value = "Canada";

            rowInfo = rgData.Rows.AddNew();
            rowInfo.Cells["COUNTRY"].Value = "Spain";

            rowInfo = rgData.Rows.AddNew();
            rowInfo.Cells["COUNTRY"].Value = "Italy";
        }

        //This event fires when a field is put into edit mode.
        private void rgData_EditorRequired(object sender, Telerik.WinControls.UI.EditorRequiredEventArgs e)
        {
            int currentColumnIndex = 0;
            int currentRowIndex = 0;
            object country = null;
            int columnWidth = 0;

            currentColumnIndex = rgData.Columns.IndexOf(rgData.CurrentColumn.Name);

            //INSTANT C# NOTE: The following VB 'Select Case' included either a non-ordinal switch expression or non-ordinal,
            //range-type, or non-constant 'Case' expressions and was converted to C# 'if-else' logic:
            //			Select Case currentColumnIndex

            //ORIGINAL LINE: Case rgData.Columns("COUNTRY").Index
            if (currentColumnIndex == rgData.Columns["COUNTRY"].Index)
            {
                currentRowIndex = rgData.Rows.IndexOf(rgData.CurrentRow);
                country = rgData.Rows[currentRowIndex].Cells[currentColumnIndex].Value;
                columnWidth = rgData.Columns[currentColumnIndex].Width;

                _loadOnDemandCellEditor = new LoadOnDemandCellEditor(country, columnWidth, rgData);
                e.Editor = _loadOnDemandCellEditor;
            }
        }

        //Fires when a cell is taken out of edit mode
        private void rgData_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.ColumnIndex == rgData.Columns["COUNTRY"].Index)
            {
                //Set the editor text from editor element and update the cell value (sometimes the grid did not hold
                //the updated value)
                rgData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _loadOnDemandCellEditor.EditorElement.Text;

                _loadOnDemandCellEditor.Dispose();
            }
        }

        private static Form1 _DefaultInstance;

        public static Form1 DefaultInstance
        {
            get
            {
                if (_DefaultInstance == null)
                    _DefaultInstance = new Form1();

                return _DefaultInstance;
            }
        }
    }
}