using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Orders
{
    public partial class Form1 : RadForm
    {
        private List<Product> allProducts = new List<Product>();
        private List<OrderItem> currentOrder = new List<OrderItem>();
        private BindingSource productsBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            InitializeData();
            SetupDataGridView();
            LoadTreeView();
            LoadCategoryFilter();
        }

        private void InitializeData()
        {
            // Preload sample products - 2-3 products per category
            allProducts = new List<Product>
            {
                // Electronics
                new Product
                {
                    ProductID = 1,
                    Name = "Laptop",
                    Price = 1299.99m,
                    Stock = 15,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductID = 2,
                    Name = "Smartphone",
                    Price = 899.99m,
                    Stock = 25,
                    Category = "Electronics"
                },
                new Product
                {
                    ProductID = 3,
                    Name = "Wireless Headphones",
                    Price = 199.99m,
                    Stock = 40,
                    Category = "Electronics"
                },
                // Furniture
                new Product
                {
                    ProductID = 4,
                    Name = "Office Desk",
                    Price = 349.99m,
                    Stock = 10,
                    Category = "Furniture"
                },
                new Product
                {
                    ProductID = 5,
                    Name = "Ergonomic Chair",
                    Price = 299.99m,
                    Stock = 20,
                    Category = "Furniture"
                },
                new Product
                {
                    ProductID = 6,
                    Name = "Bookshelf",
                    Price = 149.99m,
                    Stock = 12,
                    Category = "Furniture"
                },
                // Clothing
                new Product
                {
                    ProductID = 7,
                    Name = "Winter Jacket",
                    Price = 89.99m,
                    Stock = 30,
                    Category = "Clothing"
                },
                new Product
                {
                    ProductID = 8,
                    Name = "Running Shoes",
                    Price = 119.99m,
                    Stock = 35,
                    Category = "Clothing"
                },
                new Product
                {
                    ProductID = 9,
                    Name = "Casual T-Shirt",
                    Price = 24.99m,
                    Stock = 50,
                    Category = "Clothing"
                }
            };
        }

        private void SetupDataGridView()
        {
            // Set up DataGridView columns and styling
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.Columns.Add(new GridViewTextBoxColumn { FieldName = "ProductID", HeaderText = "ProductID", Name = "ProductID" });
            dataGridViewProducts.Columns.Add(new GridViewTextBoxColumn { FieldName = "Name", HeaderText = "Name", Name = "Name" });
            dataGridViewProducts.Columns.Add(new GridViewTextBoxColumn { FieldName = "Price", HeaderText = "Price", Name = "Price", FormatString = "{0:C2}" });
            dataGridViewProducts.Columns.Add(new GridViewTextBoxColumn { FieldName = "Stock", HeaderText = "Stock", Name = "Stock" });
            // Set alternating row colors
            dataGridViewProducts.EnableAlternatingRowColor = true;
            dataGridViewProducts.TableElement.AlternatingRowColor = Color.LightGray;
            // Bind data
            productsBindingSource.DataSource = allProducts;
            dataGridViewProducts.DataSource = productsBindingSource;
        }

        private void LoadTreeView()
        {
            treeViewCategories.Nodes.Clear();
            var rootNode = treeViewCategories.Nodes.Add("Categories");
            rootNode.Nodes.Add("Electronics");
            rootNode.Nodes.Add("Furniture");
            rootNode.Nodes.Add("Clothing");
            rootNode.Expand();
        }

        private void LoadCategoryFilter()
        {
            cmbCategoryFilter.Items.Add("All Categories");
            cmbCategoryFilter.Items.Add("Electronics");
            cmbCategoryFilter.Items.Add("Furniture");
            cmbCategoryFilter.Items.Add("Clothing");
            cmbCategoryFilter.SelectedIndex = 0;
        }

        private void TreeViewCategories_AfterSelect(object sender, RadTreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Parent != null) // Not root node
            {
                string category = e.Node.Text;
                FilterProductsByCategory(category);
            }
            else if (e.Node != null && e.Node.Parent == null) // Root node
            {
                ShowAllProducts();
            }
        }

        private void CmbCategoryFilter_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cmbCategoryFilter.SelectedItem != null)
            {
                string selected = cmbCategoryFilter.SelectedItem.ToString();
                if (selected == null)
                    selected = "All Categories";
                if (selected == "All Categories")
                {
                    ShowAllProducts();
                }
                else
                {
                    FilterProductsByCategory(selected);
                }
            }
        }

        private void FilterProductsByCategory(string category)
        {
            var filteredProducts = allProducts.Where(p => p.Category == category).ToList();
            productsBindingSource.DataSource = filteredProducts;
            productsBindingSource.ResetBindings(false);
        }

        private void ShowAllProducts()
        {
            productsBindingSource.DataSource = allProducts;
            productsBindingSource.ResetBindings(false);
        }

        private void BtnAddToOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                RadMessageBox.Show("Please select a product to add to the order.", "No Selection", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }

            var selectedProduct = dataGridViewProducts.SelectedRows[0].DataBoundItem as Product;
            if (selectedProduct != null)
            {
                // Check if product already in order
                var existingItem = currentOrder.FirstOrDefault(oi => oi.Product.ProductID == selectedProduct.ProductID);
                if (existingItem != null)
                {
                    existingItem.Quantity++;
                }
                else
                {
                    currentOrder.Add(new OrderItem { Product = selectedProduct, Quantity = 1 });
                }

                UpdateOrderDisplay();
            }
        }

        private void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (listBoxOrder.SelectedItem != null)
            {
                var selectedItem = listBoxOrder.SelectedItem?.DataBoundItem as OrderItem;
                if (selectedItem != null)
                {
                    currentOrder.Remove(selectedItem);
                    UpdateOrderDisplay();
                }
            }
        }

        private void BtnClearOrder_Click(object sender, EventArgs e)
        {
            currentOrder.Clear();
            UpdateOrderDisplay();
        }

        private void UpdateOrderDisplay()
        {
            listBoxOrder.DataSource = null;
            listBoxOrder.DataSource = currentOrder;
            decimal total = currentOrder.Sum(oi => oi.TotalPrice);
            lblTotalPrice.Text = $"Total Price: {total:C2}";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = RadMessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("Order Management System\n\n" + "Version 1.0\n\n" + "A demo application for managing products and orders.\n\n" + "Built with Windows Forms and .NET Framework 4.8", "About", MessageBoxButtons.OK, RadMessageIcon.Info);
        }
    }
}
