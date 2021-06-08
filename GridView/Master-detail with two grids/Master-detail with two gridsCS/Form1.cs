using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Master_detail_with_two_grids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radGridView1.Columns["Picture"].IsVisible = false;
            radGridView1.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(radGridView1_CurrentRowChanged);

        }

        void radGridView1_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow != null && e.CurrentRow is GridViewDataRowInfo)
            {
                this.radGridView2.DataSource = ((NwindDataSet.CategoriesRow)((DataRowView)e.CurrentRow.DataBoundItem).Row).GetProductsRows();

                radGridView2.Columns["CategoriesRow"].IsVisible = false;
                radGridView2.Columns["RowError"].IsVisible = false;
                radGridView2.Columns["RowState"].IsVisible = false;
                radGridView2.Columns["Table"].IsVisible = false;
                radGridView2.Columns["ItemArray"].IsVisible = false;
                radGridView2.Columns["HasErrors"].IsVisible = false;

                radGridView1.BestFitColumns();
                radGridView2.BestFitColumns();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
        }
    }
}
