using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace _1165384
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        BindingList<OrderItem> orderedItems = new BindingList<OrderItem>();

        public RadForm1()
        {
            InitializeComponent();
            radListView1.VisualItemCreating += RadListView1_VisualItemCreating;

            var view = radListView1.ListViewElement.ViewElement as SimpleListViewElement;
            view.ItemSize = new Size(20, 60);
            radListView1.AllowEdit = false;
            radListView2.ItemMouseDoubleClick += RadListView2_ItemMouseDoubleClick;
            radListView1.DataSource = orderedItems;

            orderedItems.ListChanged += OrderedItems_ListChanged;
        }

        private void OrderedItems_ListChanged(object sender, ListChangedEventArgs e)
        {
            decimal total = 0;
            foreach (var item in orderedItems)
            {
                total += item.Price * item.Amount;
            }
            radLabel4.Text = total.ToString("C");
        }

        private void RadListView2_ItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
        {
            e.Item.Enabled = false;
            var product = ((DataRowView)e.Item.DataBoundItem).Row;
            var newItem = new OrderItem();
            newItem.Amount = 1;
            newItem.Name = product["ProductName"].ToString();
            newItem.Price = ((decimal)product["UnitPrice"]);
            newItem.QuantityPerUnit = product["QuantityPerUnit"].ToString();
            orderedItems.Add(newItem);
        }

        private void RadListView1_VisualItemCreating(object sender, Telerik.WinControls.UI.ListViewVisualItemCreatingEventArgs e)
        {
            if (this.radListView1.ViewType == ListViewType.ListView)
            {
                e.VisualItem = new CartVisualItem();
            }
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);

        }
    }
  
    
}
