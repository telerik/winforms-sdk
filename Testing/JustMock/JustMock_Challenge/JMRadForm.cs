using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace JustMock_Challenge
{
    public partial class JMRadForm : Telerik.WinControls.UI.RadForm
    {
        public RadGridView Grid { get { return this.radGridView1; } }

        public JMRadForm()
        {
            InitializeComponent();
            this.radGridView1.DataSource = GetData();
            this.radGridView1.MultiSelect = true;
            SelectOrdersByProduct("Apple");
             
        }  

        public void SelectOrdersByProduct(string productName)
        {
            foreach (GridViewRowInfo row in this.radGridView1.Rows)
            {
                Order order = row.DataBoundItem as Order;
                if (order.ContainsProduct(productName))
                {
                    row.IsSelected = true;
                }
            }
        }

        public List<Order> GetData()
        { 
            List<string> productNames = new List<string>() { "Apple", "Banana", "Avocado", "Cucumber", "Tomato", "Orange" };
            List<float> productPrices = new List<float>() { 1.45f, 3.15f, 2.30f, 2.80f, 1.20f, 4.30f };
            List<Order> orders = new List<Order>();
            Random rand = new Random();

            int ordersCount = rand.Next(1, 10);
            int productsCount = 0;
            int productIndex = -1;
            for (int i = 0; i < ordersCount; i++)
            {
                List<Product> orderProducts = new List<Product>();
                productsCount = rand.Next(1, 5);
                for (int j = 0; j < productsCount; j++)
                {
                    productIndex = rand.Next(0, productsCount + 1);
                    orderProducts.Add(new Product(productNames[productIndex], productPrices[productIndex], rand.Next(1, 5)));
                }
                orders.Add(new Order(i, DateTime.Now, orderProducts));
            }
            return orders;
        }
         
        public class Order
        {
            public int Id { get; set; }

            public DateTime CreatedOn { get; set; }

            [TypeConverter(typeof(MyConverter))]
            public List<Product> Products { get; set; }

            public Order(int id, DateTime createdOn, List<Product> products)
            {
                this.Id = id;
                this.CreatedOn = createdOn;
                this.Products = products;
            }

            private float GetTotalAmount()
            {
                float sum = 0;
                foreach (Product p in this.Products)
                {
                    sum += (p.Price * p.Quantity);
                }
                return sum;
            }

            public bool ContainsProduct(string name)
            {
                foreach (Product p in this.Products)
                {
                    if (p.Name==name)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public class MyConverter : TypeConverter
        {
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(string))
                {
                    return true;
                }
                return base.CanConvertTo(context, destinationType);
            }

            public override object ConvertTo(ITypeDescriptorContext context, 
                System.Globalization.CultureInfo culture, object value, Type destinationType)
            {
                List<Product> products = value as List<Product>;
                if (destinationType == typeof(string) && products != null)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (Product p in products)
                    {
                        sb.Append(p.Quantity + " x " + p.Name + "; ");
                    }
                    return sb.ToString();
                }
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

        public class Product
        { 
            public string Name { get; set; }

            public float Price { get; set; }

            public int Quantity { get; set; }
             
            public Product( string name, float price, int quantity)
            { 
                this.Name = name;
                this.Price = price;
                this.Quantity = quantity;
            }
        } 
    }
}