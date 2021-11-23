using AllowEndUsersAddItemsComboBoxEditor.NwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace AllowEndUsersAddItemsComboBoxEditor
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            this.radGridView1.Dock = DockStyle.Fill;
            GridViewComboBoxColumn categoriesColumn = new GridViewComboBoxColumn();
            categoriesColumn.DisplayMember = "CategoryName";
            categoriesColumn.ValueMember = "CategoryID";
            categoriesColumn.FieldName = "CategoryID";
            categoriesColumn.HeaderText = "Category";
            categoriesColumn.DataSource = this.categoriesBindingSource;
            categoriesColumn.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown;
            categoriesColumn.Width = 150;
            this.radGridView1.Columns.Insert(4, categoriesColumn);
            this.radGridView1.CellEndEdit += RadGridView1_CellEndEdit;
            this.radGridView1.EditorRequired += RadGridView1_EditorRequired;
        }
        private void RadGridView1_EditorRequired(object sender, EditorRequiredEventArgs e)
        {
            if (e.EditorType == typeof(RadDropDownListEditor))
            {
                e.Editor = new CustomDropDownEditor();
            }
        }

        private void RadGridView1_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            if (this.radGridView1.CurrentCell.Tag != null)
            {
                this.radGridView1.CurrentCell.Value = this.radGridView1.CurrentCell.Tag;
                this.radGridView1.CurrentCell.Tag = null;
            }
        }

        public NwindDataSet DataSet
        {
            get
            {
                return this.nwindDataSet;
            }
        }
        public CategoriesTableAdapter CategoriesTA
        {
            get
            {
                return this.categoriesTableAdapter;
            }
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
        }
    }
}
