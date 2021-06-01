using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GridViewComboxColumnCustomValue
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        List<Food> data = new List<Food>();

        public RadForm1()
        {
            InitializeComponent();
            radGridView1.AutoGenerateColumns = false;
            radGridView1.EditorRequired += radGridView1_EditorRequired;
            radGridView1.CreateCell += radGridView1_CreateCell;
            data.Add(new Food(0, "Onion"));
            data.Add(new Food(1, "Cucumber"));
            data.Add(new Food(2, "Tomato"));
            data.Add(new Food(3, "Peach"));
            data.Add(new Food(4, "Banana"));
            data.Add(new Food(5, "Grape"));

            GridViewComboBoxColumn comboBoxColumn = new GridViewComboBoxColumn();
            comboBoxColumn.DataSource = data;
            comboBoxColumn.DisplayMember = "FoodName";
            comboBoxColumn.ValueMember = "FoodName";
            comboBoxColumn.Width = 200;
            comboBoxColumn.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown;
            radGridView1.Columns.Add(comboBoxColumn);

            radGridView1.Rows.Add("Onion");
            
            radGridView1.CellValueChanged += radGridView1_CellValueChanged;
        }

        void radGridView1_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridComboBoxCellElement))
            {
                e.CellElement = new MyCombBoxCellElement(e.Column as GridViewDataColumn, e.Row);
            }
        }

        void radGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
        }
        
        void radGridView1_EditorRequired(object sender, EditorRequiredEventArgs e)
        {
            if (e.EditorType == typeof(RadDropDownListEditor))
            {
                e.EditorType = typeof(MyRadDropDownListEditor);
            }
        }
    }

    public class MyRadDropDownListEditor : RadDropDownListEditor
    {
        public override object Value
        {
            get
            {
                RadDropDownListElement editor = this.EditorElement as RadDropDownListElement;
                if (editor.SelectedItem != null)
                {
                    if (!string.IsNullOrEmpty(editor.ValueMember))
                    {
                        return editor.SelectedItem.Value;
                    }

                    return editor.SelectedItem.Text;
                }

                return editor.Text;
            }
            set
            {
                base.Value = value;
            }
        }
    }

    public class MyCombBoxCellElement : GridComboBoxCellElement
    {
        public MyCombBoxCellElement(GridViewColumn col, GridRowElement row) : base(col, row)
        {
        }

        public override void SetContent()
        {
            
            SetContentCore(this.Value);
        }
    }

    public class Food
    {
        private int foodID;
        private string foodName;

        public Food(int foodID, string foodName)
        {
            this.foodID = foodID;
            this.foodName = foodName;
        }

        public int FoodID
        {
            get
            {
                return foodID;
            }
            set
            {
                foodID = value;
            }
        }

        public string FoodName
        {
            get
            {
                return foodName;
            }
            set
            {
                foodName = value;
            }
        }
    }
}