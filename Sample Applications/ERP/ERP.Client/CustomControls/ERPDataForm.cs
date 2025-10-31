using System;
using System.Drawing;
using System.Windows.Forms;
using ERP.Repository;
using ERP.Repository.Service;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ERP.Client
{
    public partial class ERPDataForm : RadForm
    {
        public ERPDataForm()
        {
            this.InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ShowIcon = false;

            if (Telerik.WinControls.TelerikHelper.IsMaterialTheme(this.ThemeName))
            {
                this.erpDataDialog.DataEntry.ItemDefaultSize = new Size(100, 25);
                this.Height += 100;
                this.Width += 50;
            }

            //this.DataEntry.ItemInitializing += this.DataEntry_ItemInitializing;
            //this.DataEntry.EditorInitializing += this.DataEntry_EditorInitializing;
           // this.DataEntry.BindingCreating += this.DataEntry_BindingCreating;
           // this.DataEntry.BindingCreated += this.radDataEntry1_BindingCreated;
        }

        private RadDropDownList radDropDownList1 = new RadDropDownList();
        private void DataEntry_EditorInitializing(object sender, EditorInitializingEventArgs e)
        {
            var purchaseOrder = this.DataEntry.DataSource as PurchaseOrderHeader;
            if (purchaseOrder != null)
            {
                if (e.Property.Name == "ShipDate")
                {
                    RadDateTimePicker radDateTimePicker = new RadDateTimePicker();
                    e.Editor = radDateTimePicker;
                }
                else if (e.Property.Name == "ShipMethod")
                {
                    RadDropDownList radDropDownList = new RadDropDownList();
                    radDropDownList.DropDownStyle = RadDropDownStyle.DropDownList;
                    radDropDownList.DisplayMember = "Name";
                    radDropDownList.DataSource = MainRepository.ShipMethodsCache;
                    e.Editor = radDropDownList;
                }
                else if (e.Property.Name == "Vendor")
                {
                    RadDropDownList radDropDownList = new RadDropDownList();
                    radDropDownList.DropDownStyle = RadDropDownStyle.DropDownList;
                    radDropDownList.DataSource = MainRepository.VendorsCache;
                    radDropDownList.DisplayMember = "Name";
                    e.Editor = radDropDownList;
                }
            }

            var productInventory = this.DataEntry.DataSource as ProductInventory;
            if (productInventory != null)
            {
                if (e.Property.Name == "Location")
                {
                    RadDropDownList radDropDownList = new RadDropDownList();
                    radDropDownList.DropDownStyle = RadDropDownStyle.DropDownList;
                    radDropDownList.DataSource = MainRepository.LocationsCache;
                    radDropDownList.DisplayMember = "Name";
                    e.Editor = radDropDownList;
                }
                else if (e.Property.Name == "Product")
                {
                    RadDropDownList radDropDownList = new RadDropDownList();
                    radDropDownList.DropDownStyle = RadDropDownStyle.DropDownList;
                    radDropDownList.DataSource = MainRepository.ProductsCache;
                    radDropDownList.DisplayMember = "Name";
                    e.Editor = radDropDownList;
                }
            }
 // TO DO
            var billOfMaterial = this.DataEntry.DataSource as BillOfMaterial;
            if (billOfMaterial != null)
            {
                if (e.Property.Name == "EndDate")
                {
                    RadDateTimePicker radDateTimePicker = new RadDateTimePicker();
                    e.Editor = radDateTimePicker;
                }                
            }

            var workOrder = this.DataEntry.DataSource as WorkOrder;
            if (workOrder != null)
            {
                if (e.Property.Name == "EndDate")
                {
                    RadDateTimePicker radDateTimePicker = new RadDateTimePicker();
                    e.Editor = radDateTimePicker;
                }
                else if (e.Property.Name == "Product")
                {
                    RadDropDownList radDropDownList = new RadDropDownList();
                    radDropDownList.DropDownStyle = RadDropDownStyle.DropDownList;
                    radDropDownList.DataSource = MainRepository.ProductsCache;
                    radDropDownList.DisplayMember = "Name";
                    e.Editor = radDropDownList;
                }
            }

            var order = this.DataEntry.DataSource as SalesOrderHeader;
            if (order != null)
            {
                if (e.Property.Name == "ShipDate")
                {
                    RadDateTimePicker radDateTimePicker = new RadDateTimePicker();
                    e.Editor = radDateTimePicker;
                }
                else if (e.Property.Name == "Customer")
                {
                    RadDropDownList radDropDownList = new RadDropDownList();
                    radDropDownList.DropDownStyle = RadDropDownStyle.DropDownList;
                    radDropDownList.DataSource = MainRepository.CustomersCache;
                    radDropDownList.DisplayMember = "FirstName";
                    e.Editor = radDropDownList;
                }
                else if (e.Property.Name == "ShipMethod")
                {
                    RadDropDownList radDropDownList = new RadDropDownList();
                    radDropDownList.DropDownStyle = RadDropDownStyle.DropDownList;
                    radDropDownList.DataSource = MainRepository.ShipMethodsCache;
                    radDropDownList.DisplayMember = "FirstName";
                    e.Editor = radDropDownList;
                }
            }
        }

        private void RadDropDownList1_SelectedIndexChanged(object sender, 
                                                           Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            var obj = this.DataEntry.CurrentObject;
        }

        private void DataEntry_BindingCreating(object sender, BindingCreatingEventArgs e)
        {           
            if (e.DataMember == "ShipDate" || e.DataMember == "Color" || e.DataMember == "EndDate")
            {
                e.PropertyName = "Value";
            }
           
             if (e.DataMember == "UnitMeasure.UnitMeasureCode")
            {
                //e.DataMember = "UnitMeasure";
                //e.PropertyName = "SelectedValue";
            }

            if (e.DataMember == "Location" || e.DataMember == "Product"  || e.DataMember == "Customer" || e.DataMember == "ShipMethod")
            {
                e.PropertyName = "SelectedValue";
            }
        }
        private void radDataEntry1_BindingCreated(object sender, BindingCreatedEventArgs e)
        {
            if (e.DataMember == "ShipDate" || e.DataMember == "EndDate")
            {
                e.Binding.FormattingEnabled = true;           
            }
            else if (e.DataMember == "Color")
            {
                e.Binding.FormattingEnabled = true;
                e.Binding.Parse += this.Binding_Parse;
            }
        }

        private void Binding_Parse(object sender, ConvertEventArgs e)        
        {
            // Convert RGB values to hexadecimal with transparency
            if (e.Value is Color color)
            {
                // Include alpha channel for transparency: #AARRGGBB format
                e.Value = string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}", color.A, color.R, color.G, color.B);
            }
        }

        public RadDataEntry DataEntry
        {
            get
            {
                return this.erpDataDialog.DataEntry;
            }
        }
    }
}
