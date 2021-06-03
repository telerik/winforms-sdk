using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace RadGridViewCascadingCombos
{
    public partial class Form1 : Form
    {
        BindingList<Food> fullList;
        BindingList<Food> fruitsList;
        BindingList<Food> vegetablesList;

        public Form1()
        {
            InitializeComponent();

            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            fullList = new BindingList<Food>();
            fullList.Add(new Food(0, "Onion"));
            fullList.Add(new Food(1, "Cucumber"));
            fullList.Add(new Food(2, "Tomato"));
            fullList.Add(new Food(3, "Peach"));
            fullList.Add(new Food(4, "Banana"));
            fullList.Add(new Food(5, "Grape"));

            fruitsList = new BindingList<Food>();
            fruitsList.Add(fullList[3]);
            fruitsList.Add(fullList[4]);
            fruitsList.Add(fullList[5]);

            vegetablesList = new BindingList<Food>();
            vegetablesList.Add(fullList[0]);
            vegetablesList.Add(fullList[1]);
            vegetablesList.Add(fullList[2]);

            BindingList<FoodType> typesList = new BindingList<FoodType>();
            typesList.Add(new FoodType(0, "Vegetables"));
            typesList.Add(new FoodType(1, "Fruits"));

            GridViewComboBoxColumn foodType = new GridViewComboBoxColumn();
            foodType.FieldName = "FoodType";
            this.radGridView1.Columns.Add(foodType);
            foodType.DataSource = typesList;
            foodType.Width = 100;
            foodType.DisplayMember = "FoodTypeName";
            foodType.ValueMember = "FoodTypeID";

            GridViewComboBoxColumn food = new GridViewComboBoxColumn();
            food.FieldName = "Food";
            this.radGridView1.Columns.Add(food);
            food.DataSource = fullList;
            food.Width = 100;
            food.DisplayMember = "FoodName";
            food.ValueMember = "FoodID";

            this.radGridView1.Rows.Add(new object[] { 0, 1 });
            this.radGridView1.Rows.Add(new object[] { 1, 4 });
            this.radGridView1.Rows.Add(new object[] { 1, 3 });
            this.radGridView1.Rows.Add(new object[] { 0, 0 });
            this.radGridView1.Rows.Add(new object[] { 0, 2 });
            this.radGridView1.Rows.Add(new object[] { 0, 1 });
            this.radGridView1.Rows.Add(new object[] { 1, 4 });
            this.radGridView1.Rows.Add(new object[] { 1, 3 });
            this.radGridView1.Rows.Add(new object[] { 0, 0 });
            this.radGridView1.Rows.Add(new object[] { 0, 2 });
            this.radGridView1.Rows.Add(new object[] { 0, 1 });
            this.radGridView1.Rows.Add(new object[] { 1, 4 });
            this.radGridView1.Rows.Add(new object[] { 1, 3 });
            this.radGridView1.Rows.Add(new object[] { 0, 0 });
            this.radGridView1.Rows.Add(new object[] { 0, 2 });

            this.radGridView1.CellEditorInitialized += new Telerik.WinControls.UI.GridViewCellEventHandler(radGridView1_CellEditorInitialized);
            this.radGridView1.CellValueChanged += new GridViewCellEventHandler(radGridView1_CellValueChanged);
        }

        void radGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.HeaderText == "FoodType")
            {
                e.Row.Cells["Food"].Value = null;
            }
        }

        void radGridView1_CellEditorInitialized(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Column.HeaderText == "Food")
            {
                if (this.radGridView1.CurrentRow.Cells["FoodType"].Value != DBNull.Value
                    && this.radGridView1.CurrentRow.Cells["FoodType"].Value != null)
                {
                    RadDropDownListEditor editor = (RadDropDownListEditor)this.radGridView1.ActiveEditor;
                    RadDropDownListEditorElement editorElement = (RadDropDownListEditorElement)editor.EditorElement;
                    if (int.Parse(this.radGridView1.CurrentRow.Cells["FoodType"].Value.ToString()) == 0)
                    {
                        editorElement.DataSource = vegetablesList;
                    }
                    else
                    {
                        editorElement.DataSource = fruitsList;
                    }
                    editorElement.SelectedValue = null;
                    editorElement.SelectedValue = this.radGridView1.CurrentCell.Value;
                }
            }
        }
    }

    public class FoodType
    {
        private int foodTypeID;
        private string foodType;

        public FoodType(int foodTypeID, string foodType)
        {
            this.foodTypeID = foodTypeID;
            this.foodType = foodType;
        }

        public int FoodTypeID
        {
            get { return foodTypeID; }
            set { foodTypeID = value; }
        }

        public string FoodTypeName
        {
            get { return foodType; }
            set { foodType = value; }
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
            get { return foodID; }
            set { foodID = value; }
        }

        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }
    }
}