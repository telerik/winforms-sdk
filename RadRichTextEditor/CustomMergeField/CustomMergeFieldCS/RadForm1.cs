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
using Telerik.WinForms.Documents.Layout;
using Telerik.WinForms.Documents.Model;

namespace CustomMergeField
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            this.radRichTextEditor1.Document.MailMergeDataSource.ItemsSource = new List<Customer>()
            {
                new Customer()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Orders = new List<Order>()
                    {
                        new Order() { ProductName = "Product 1" },
                        new Order() { ProductName = "Product 2" },
                    }
                },
                new Customer()
                {
                    FirstName = "Sara",
                    LastName = "Doe",
                    Orders = new List<Order>()
                    {
                        new Order() { ProductName = "Product 3" },
                        new Order() { ProductName = "Product 4" },
                    }
                }
            };

            this.radRichTextEditor1.InsertField(new MergeField() { PropertyPath = "FirstName" });
            this.radRichTextEditor1.Insert(FormattingSymbolLayoutBox.ENTER);
            this.radRichTextEditor1.InsertField(new OrdersMergeField() { PropertyPath = "Orders" });

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            var docuemnt = radRichTextEditor1.MailMerge();
            radRichTextEditor1.Document = docuemnt;
        }
    }
}
