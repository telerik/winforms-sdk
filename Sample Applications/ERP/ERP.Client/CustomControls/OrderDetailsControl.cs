using ERP.Repository.Service;
using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ERP.Client
{
    public partial class OrderDetailsControl : UserControl
    {
        private SalesOrderHeader data;
        private MapLocationHelper shippingHelper;
        private MapLocationHelper customerHelper;

        private Address shipingAddressBackup = new Address();
        private Address customerAddressBackup = new Address();
        public OrderDetailsControl()
        {
            this.InitializeComponent();
           
            this.orderDetailsPageView.SelectedPage = this.shipingDetailsPage;
            this.radGridView1.EnableFiltering = true;
            this.radGridView1.ShowFilteringRow = false;
            this.radGridView1.ShowHeaderCellButtons = true;
            this.radGridView1.ReadOnly = true;
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.Columns[0].FieldName = "Product";
            this.radGridView1.Columns[1].FieldName = "CarrierTrackingNumber";
            this.radGridView1.Columns[2].FieldName = "OrderQty";
            this.radGridView1.Columns[3].FieldName = "UnitPrice";
            this.radGridView1.Columns[4].FieldName = "UnitPriceDiscount";
            this.radGridView1.Columns[5].FieldName = "LineTotal";
            this.radGridView1.Columns[6].FieldName = "ModifiedDate";

            this.orderDetailsPageView.SelectedPageChanged += this.OrderDetailsPageView_SelectedPageChanged;

            this.shippingHelper = new MapLocationHelper(this.shipingDetailsMapControl.MapControl);
            this.customerHelper = new MapLocationHelper(this.customerDetailsMapControl.MapControl);

            this.shipingDetailsMapControl.DataControl.CommandExecuted += this.DataControl_CommandExecuted;
            this.customerDetailsMapControl.DataControl.CommandExecuted += this.DataControl_CommandExecuted;
        }

        private void DataControl_CommandExecuted(object sender, DataDialogCommandEventArgs e)
        {
            if (e.SavaChanges)
            {
               // (this.Data as ISavableObject).Save(false);
            }
            else
            {
                //(this.Data as ISavableObject).Cancel();
                this.CloneAddress(this.data.Address, this.shipingAddressBackup);
                this.CloneAddress(this.data.Customer.Address, this.customerAddressBackup);
                this.UpdateData();
            }


        }

        private void OrderDetailsPageView_SelectedPageChanged(object sender, EventArgs e)
        {
            if (this.data == null)
            {
                RadMessageBox.Show("Please select entry in the above grid");
                return;
            }

            if (this.orderDetailsPageView.SelectedPage == this.shipingDetailsPage)
            {
                if (this.data.Address == null)
                {
                    return;
                }

                this.shippingHelper.UpdateMap(this.data.Address);
            }
            else if (this.orderDetailsPageView.SelectedPage == this.customerDetailsPage)
            {
                if (this.data.Customer.Address == null)
                {
                    return;
                }

                this.customerHelper.UpdateMap(this.data.Customer.Address);
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
                this.data = value;
                this.CloneAddress(this.shipingAddressBackup, this.data.Address);
                this.CloneAddress(this.customerAddressBackup, this.data.Customer.Address);
                this.UpdateData();

            }
        }

        private void UpdateData()
        {


            //grid update
            this.radGridView1.DataSource = this.data.SalesOrderDetails;

            //map update
            if (this.data.Address != null)
            {
                this.shippingHelper.UpdateMap(this.data.Address);
            }

            if (this.data.Customer.Address != null)
            {
                this.customerHelper.UpdateMap(this.data.Customer.Address);
            }


            //data layout update
            this.shipingDetailsMapControl.DataControl.DataEntry.DataSource = this.data.Address;
            this.customerDetailsMapControl.DataControl.DataEntry.DataSource = this.data.Customer.Address;

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
