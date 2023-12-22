using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP.Repository.Service;
using ERP.Repository;
using Telerik.WinControls;
using System.Data.Services.Client;
using Telerik.WinControls.UI;

namespace ERP.Client
{
    public partial class OrderDetailsControl : UserControl
    {
        SalesOrderHeader data;
        MapLocationHelper shippingHelper;
        MapLocationHelper customerHelper;

        Address shipingAddressBackup = new Address();
        Address customerAddressBackup = new Address();
        public OrderDetailsControl()
        {
            InitializeComponent();
           
            this.orderDetailsPageView.SelectedPage = this.shipingDetailsPage;
            radGridView1.EnableFiltering = true;
            radGridView1.ShowFilteringRow = false;
            radGridView1.ShowHeaderCellButtons = true;
            radGridView1.ReadOnly = true;
            radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            radGridView1.Columns[0].FieldName = "Product";
            radGridView1.Columns[1].FieldName = "CarrierTrackingNumber";
            radGridView1.Columns[2].FieldName = "OrderQty";
            radGridView1.Columns[3].FieldName = "UnitPrice";
            radGridView1.Columns[4].FieldName = "UnitPriceDiscount";
            radGridView1.Columns[5].FieldName = "LineTotal";
            radGridView1.Columns[6].FieldName = "ModifiedDate";

            this.orderDetailsPageView.SelectedPageChanged += OrderDetailsPageView_SelectedPageChanged;

            shippingHelper = new MapLocationHelper(shipingDetailsMapControl.MapControl);
            customerHelper = new MapLocationHelper(customerDetailsMapControl.MapControl);

            this.shipingDetailsMapControl.DataControl.CommandExecuted += DataControl_CommandExecuted;
            this.customerDetailsMapControl.DataControl.CommandExecuted += DataControl_CommandExecuted;
        }

        private void DataControl_CommandExecuted(object sender, DataDialogCommandEventArgs e)
        {
            if (e.SavaChanges)
            {
                (this.Data as ISavableObject).Save(false);
            }
            else
            {
                (this.Data as ISavableObject).Cancel();
                CloneAddress(data.Address, this.shipingAddressBackup);
                CloneAddress(data.Customer.Address, this.customerAddressBackup);
                UpdateData();
            }


        }

        private void OrderDetailsPageView_SelectedPageChanged(object sender, EventArgs e)
        {
            if (this.data == null)
            {
                RadMessageBox.Show("Please select entry in the above grid");
                return;
            }
            if (orderDetailsPageView.SelectedPage == shipingDetailsPage)
            {
                if (this.data.Address == null)
                {
                    return;
                }
                shippingHelper.UpdateMap(this.data.Address);
            }
            else if (orderDetailsPageView.SelectedPage == customerDetailsPage)
            {
                if (this.data.Customer.Address == null)
                {
                    return;
                }
                customerHelper.UpdateMap(this.data.Customer.Address);
            }
        }

        public SalesOrderHeader Data
        {
            get
            {
                return this.data;
            }
            set
            {
                data = value;
                CloneAddress(shipingAddressBackup, data.Address);
                CloneAddress(customerAddressBackup, data.Customer.Address);
                UpdateData();

            }
        }

        private void UpdateData()
        {


            //grid update
            this.radGridView1.DataSource = data.SalesOrderDetails;

            //map update
            if (this.data.Address != null)
            {
                shippingHelper.UpdateMap(this.data.Address);
            }
            if (this.data.Customer.Address != null)
            {
                customerHelper.UpdateMap(this.data.Customer.Address);
            }


            //data layout update
            this.shipingDetailsMapControl.DataControl.DataEntry.DataSource = data.Address;
            this.customerDetailsMapControl.DataControl.DataEntry.DataSource = data.Customer.Address;

        }
        public void CloneAddress(Address adr1, Address adr2)
        {

            adr1.AddressLine1 = adr2.AddressLine1;
            adr1.AddressLine2 = adr2.AddressLine2;
            adr1.City = adr2.City;
            adr1.StateProvince = adr2.StateProvince;
            adr1.PostalCode = adr2.PostalCode;
            adr1.ModifiedDate = adr2.ModifiedDate;


        }

    }
}
