using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

using Telerik.WinControls.UI;

using RadGridViewEFCodeFirst.Data;
using RadGridViewEFCodeFirst.Models;
using RadGridViewEFCodeFirst.Data.Contracts;
using RadGridViewEFCodeFirst.Data.Common;
using System.ComponentModel;
using System.Collections.Generic;

namespace RadGridViewEFCodeFirst.WinFormsClient
{
    public partial class Form1 : Form
    {
        private IRadGridViewEFCodeFirstData data;

        public Form1()
        {
            InitializeComponent();

            this.data = new RadGridViewEFCodeFirstData();
            if (!data.OrderTypes.All().Any() || !data.Orders.All().Any() || !data.Shippers.All().Any())
            {
                DataGenerator.PopulateData(this.data);
            }

            this.SetUpGrid();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.data.SaveChanges();
        }

        private void SetUpGrid()
        {
            ((IDbSet<OrderType>)this.data.OrderTypes.All()).Load();
            this.radGridView1.DataSource = ((IDbSet<OrderType>)this.data.OrderTypes.All()).Local.ToBindingList();
            this.radGridView1.Columns["Orders"].IsVisible = false;
            this.radGridView1.Columns["Shippers"].IsVisible = false;
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            GridViewTemplate ordersTemplate = new GridViewTemplate();
            ordersTemplate.Caption = "Orders";
            radGridView1.MasterTemplate.Templates.Add(ordersTemplate);
            ((IDbSet<Order>)this.data.Orders.All()).Load();
            ordersTemplate.DataSource = ((IDbSet<Order>)this.data.Orders.All()).Local.ToBindingList();
            ordersTemplate.Columns["OrderType"].IsVisible = false;
            ordersTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            GridViewRelation relation = new GridViewRelation(radGridView1.MasterTemplate);
            relation.ChildTemplate = ordersTemplate;
            relation.RelationName = "OrderTypesOrders";
            relation.ParentColumnNames.Add("OrderTypeId");
            relation.ChildColumnNames.Add("OrderTypeId");
            radGridView1.Relations.Add(relation);

            GridViewTemplate shippersTemplate = new GridViewTemplate();
            shippersTemplate.Caption = "Shippers";
            radGridView1.MasterTemplate.Templates.Add(shippersTemplate);
            ((IDbSet<Shipper>)this.data.Shippers.All()).Load();
            shippersTemplate.DataSource = ((IDbSet<Shipper>)this.data.Shippers.All()).Local.ToBindingList();
            shippersTemplate.Columns["OrderType"].IsVisible = false;
            shippersTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            GridViewRelation relation2 = new GridViewRelation(radGridView1.MasterTemplate);
            relation2.ChildTemplate = shippersTemplate;
            relation2.RelationName = "OrderTypesShippers";
            relation2.ParentColumnNames.Add("OrderTypeId");
            relation2.ChildColumnNames.Add("OrderTypeId");
            radGridView1.Relations.Add(relation2);
        }
    }
}
