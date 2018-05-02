using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace _1164656
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            new Telerik.WinControls.RadControlSpy.RadControlSpyForm().Show();

            radGridView1.DataSource = GetTable();

            var comboColumn = new MyDDLColumn();
            comboColumn.Name = "Name1";
            comboColumn.HeaderText = "Name1";
            comboColumn.DataSource = GetTable();
            comboColumn.ValueMember = "Name";
            comboColumn.DisplayMember = "Name";
            comboColumn.FieldName = "Name";
            comboColumn.Width = 200;
            this.radGridView1.Columns.Add(comboColumn);

            radGridView1.DataSource = GetTable();

             
            radGridView1.EditorRequired += RadGridView1_EditorRequired;
            radGridView1.CellValueChanged += RadGridView1_CellValueChanged;
        }

        private void RadGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
        {

        }

        private void RadGridView1_EditorRequired(object sender, EditorRequiredEventArgs e)
        {
            if (e.EditorType == typeof(RadDropDownListEditor))
            {
                e.EditorType = typeof(MyRadDropDownListEditor);
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
    class MyRadDropDownListEditor : RadDropDownListEditor
    {
        public override object Value
        {
            get
            {
                var result = base.Value;
                if (result == null || string.IsNullOrEmpty(result.ToString()))
                {
                    var editor = this.EditorElement as RadDropDownListElement;
                    return editor.Text;
                }
                return result;
            }

            set
            {
                base.Value = value;
                var editor = this.EditorElement as RadDropDownListElement;
                if (editor.SelectedValue == null)
                {
                    editor.TextBox.TextBoxItem.Text = value.ToString();
                }
            }
        }
        public override void BeginEdit()
        {
            base.BeginEdit();
            var editor = this.EditorElement as RadDropDownListElement;
            editor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown;
        }
    }
    class MyDDLColumn : GridViewComboBoxColumn
    {
        public override object GetLookupValue(object cellValue)
        {
            var result = base.GetLookupValue(cellValue);
            if (result == null)
            {
                return cellValue;
            }
            return result;

        }

    }
}