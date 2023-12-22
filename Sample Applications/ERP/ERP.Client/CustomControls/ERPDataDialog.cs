using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using ERP.Repository.Service;
using ERP.Repository;

namespace ERP.Client
{
    public partial class ERPDataDialog : UserControl
    {
        public event EventHandler<DataDialogCommandEventArgs> CommandExecuted;
        public ERPDataDialog()
        {
            InitializeComponent();
            this.radDataEntry.ItemDefaultSize = new Size(300, 25);
            this.radDataEntry.FlowDirection = FlowDirection.TopDown;
            this.radDataEntry.DataEntryElement.ItemSpace = 10;
            this.radDataEntry.FitToParentWidth = true;

            this.radDataEntry.ItemInitializing += radDataEntry_ItemInitializing;
            this.radDataEntry.BindingCreating += radDataEntry_BindingCreating;
            this.radDataEntry.BindingCreated += radDataEntry_BindingCreated;
            this.radDataEntry.EditorInitializing += radDataEntry_EditorInitializing;
            this.radDataEntry.VerticalScrollbar.ValueChanged += VerticalScrollbar_ValueChanged;
        }

        private void VerticalScrollbar_ValueChanged(object sender, EventArgs e)
        {
            this.radDataEntry.PanelContainer.Invalidate();
        }

        protected virtual void OnCommandExecuted(DataDialogCommandEventArgs e)
        {
            if (CommandExecuted != null)
            {
                CommandExecuted(this, e);
            }
        }

        private void radDataEntry_ItemInitializing(object sender, ItemInitializingEventArgs e)
        {
          
            if (radDataEntry.DataSource is Address)
            {
                if (!FieldsHelper.AddressFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;

                }
            }
            else if (radDataEntry.DataSource is PurchaseOrderHeader)
            {
                if (!FieldsHelper.PurchaseOrderHeaderFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;
                }
            }
            else if (radDataEntry.DataSource is Vendor)
            {
                if (!FieldsHelper.VendorFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;
                }
            }
            else if (radDataEntry.DataSource is ProductInventory)
            {
                if (!FieldsHelper.InventoriesFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;
                }
            }
            else if (radDataEntry.DataSource is WorkOrder)
            {
                if (!FieldsHelper.WorkOrdersFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;
                }
            }
            else if (radDataEntry.DataSource is BillOfMaterial)
            {
                if (!FieldsHelper.BillOfMaterialsFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;
                }
            }
            else if (radDataEntry.DataSource is SalesOrderHeader)
            {
                if (!FieldsHelper.OrdersFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;
                }
            }
            else if (radDataEntry.DataSource is Customer)
            {
                var customer = radDataEntry.DataSource as Customer;
                if (customer.IsPerson)
                {
                    if (!FieldsHelper.IndividualsFields.Contains(e.Panel.Controls[1].Text))
                    {
                        e.Cancel = true;
                        e.Panel.Visible = false;
                    }
                }
                else
                {
                    if (!FieldsHelper.StoresFields.Contains(e.Panel.Controls[1].Text))
                    {
                        e.Cancel = true;
                        e.Panel.Visible = false;
                    }
                }

            }

        }

        

        private void radDataEntry_EditorInitializing(object sender, EditorInitializingEventArgs e)
        {
            if (radDataEntry.DataSource is Address)
            {
                if (e.Property.Name == "StateProvince")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DataSource = MainRepository.StatesCache;
                    radDropDownList1.ValueMember = "StateProvinceID";
                    radDropDownList1.DisplayMember = "FullName";
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    e.Editor = radDropDownList1;
                }

            }
            else if (radDataEntry.DataSource is PurchaseOrderHeader)
            {
                var purchaseOrder = this.radDataEntry.DataSource as PurchaseOrderHeader;

                if (e.Property.Name == "OrderStatus")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DataSource = purchaseOrder.OrderStatuses;
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    e.Editor = radDropDownList1;
                }
                else if (e.Property.Name == "ShipMethod")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = MainRepository.ShipMethodsCache;
                    radDropDownList1.ValueMember = "ShipMethodID";
                    radDropDownList1.DisplayMember = "Name";
                    e.Editor = radDropDownList1;
                }
                else if (e.Property.Name == "Vendor")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = MainRepository.VendorsCache;
                    radDropDownList1.ValueMember = "BusinessEntityID";
                    radDropDownList1.DisplayMember = "Name";
                    e.Editor = radDropDownList1;
                }

            }
            else if (radDataEntry.DataSource is Customer)
            {

                if (e.Property.Name == "State")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = MainRepository.StatesCache;
                    radDropDownList1.ValueMember = "StateProvinceID";
                    radDropDownList1.DisplayMember = "FullName";
                    e.Editor = radDropDownList1;
                }
            }
            else if (radDataEntry.DataSource is BillOfMaterial)
            {

                if (e.Property.Name == "UnitMeasure")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = MainRepository.UnitMeasuresCache;
                    radDropDownList1.ValueMember = "UnitMeasureCode";
                    radDropDownList1.DisplayMember = "Name";
                    e.Editor = radDropDownList1;
                }
                else if (e.Property.Name == "Product1")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = MainRepository.ProductsCache.ToList();
                    radDropDownList1.ValueMember = "ProductID";
                    radDropDownList1.DisplayMember = "Name";
                    e.Editor = radDropDownList1;
                }
                else if (e.Property.Name == "Product")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = MainRepository.ProductsCache.ToList();
                    radDropDownList1.ValueMember = "ProductID";
                    radDropDownList1.DisplayMember = "Name";

                    e.Editor = radDropDownList1;
                }
            }
            else if (radDataEntry.DataSource is ProductInventory)
            {
                if (e.Property.Name == "Product")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = MainRepository.ProductsCache;
                    radDropDownList1.ValueMember = "ProductID";
                    radDropDownList1.DisplayMember = "Name";
                    e.Editor = radDropDownList1;
                }
                else if (e.Property.Name == "Color")
                {
                    e.Editor = new RadColorBox();
                }
                else if (e.Property.Name == "Location")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = MainRepository.LocationsCache;
                    radDropDownList1.ValueMember = "LocationID";
                    radDropDownList1.DisplayMember = "Name";
                    e.Editor = radDropDownList1;
                }
            }
            else if (radDataEntry.DataSource is SalesOrderHeader)
            {
                var order = radDataEntry.DataSource as SalesOrderHeader;

                if (e.Property.Name == "Customer")
                {
                    var customers = MainRepository.TopCustomersCache;
                    var orderCustomer = order.Customer;
                    if (orderCustomer != null && !customers.Contains(orderCustomer))
                    {
                        customers.Insert(0, orderCustomer);
                    }

                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = customers;
                    radDropDownList1.ValueMember = "CustomerID";
                    radDropDownList1.DisplayMember = "Name";
                    e.Editor = radDropDownList1;
                }
                else if (e.Property.Name == "ShipMethod")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DataSource = MainRepository.ShipMethodsCache;
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.ValueMember = "ShipMethodID";
                    radDropDownList1.DisplayMember = "Name";
                    e.Editor = radDropDownList1;
                }
            }
            else if (radDataEntry.DataSource is Vendor)
            {
                if (e.Property.Name == "CreditRating")
                {
                    var editor = new RadSpinEditor();
                    editor.Maximum = 5;
                    editor.Minimum = 0;
                    e.Editor = editor;
                }
            }
            else if (radDataEntry.DataSource is WorkOrder)
            {
                if (e.Property.Name == "Product")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = MainRepository.ProductsCache;
                    radDropDownList1.ValueMember = "ProductID";
                    radDropDownList1.DisplayMember = "Name";
                    e.Editor = radDropDownList1;
                }
            }
        }

        private void radDataEntry_BindingCreating(object sender, BindingCreatingEventArgs e)
        {
            if (radDataEntry.DataSource is Address)
            {
                if (e.DataMember == "StateProvince")
                {
                    e.DataMember = "StateProvince.StateProvinceID";
                    e.PropertyName = "SelectedValue";
                }
            }
            else if (radDataEntry.DataSource is PurchaseOrderHeader)
            {
                if (e.DataMember == "ShipMethod" || e.DataMember == "OrderStatus" || e.DataMember == "Vendor")
                {
                    e.PropertyName = "SelectedValue";
                }
            }
            else if (radDataEntry.DataSource is Customer)
            {
                if (e.DataMember == "State")
                {
                    e.DataMember = "Address.StateProvinceID";
                    e.PropertyName = "SelectedValue";
                }
            }
            else if (radDataEntry.DataSource is BillOfMaterial)
            {
                var entry = radDataEntry.DataSource as BillOfMaterial;

                if (e.DataMember == "Product")
                {
                    e.DataMember = "ComponentID";
                    e.PropertyName = "SelectedValue";
                }
                if (e.DataMember == "Product1")
                {
                    e.DataMember = "ProductAssemblyID";
                    e.PropertyName = "SelectedValue";
                }
                else if (e.DataMember == "UnitMeasure")
                {
                    e.DataMember = "UnitMeasure.UnitMeasureCode";
                    e.PropertyName = "SelectedValue";
                }

            }

        }

        private void radDataEntry_BindingCreated(object sender, BindingCreatedEventArgs e)
        {
            if (radDataEntry.DataSource is ProductInventory)
            {
                if (e.DataMember == "Color")
                {
                    e.Binding.FormattingEnabled = true;
                    e.Binding.Format += Binding_Format;
                }
            }
        }

        private void Binding_Format(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType == typeof(Color) && e.Value != null)
            {
                var color = Color.Transparent;
                if (e.Value.ToString().StartsWith("#"))
                {
                    color = System.Drawing.ColorTranslator.FromHtml(e.Value.ToString());
                }
                else if (!e.Value.ToString().Contains('/'))
                {
                    color = Color.FromName(e.Value.ToString());
                }
                e.Value = color;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.OnCommandExecuted(new DataDialogCommandEventArgs(true));

            var form = this.Parent as ERPDataForm;
            if (form != null)
            {
                form.DialogResult = DialogResult.OK;
                form.Close();
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.OnCommandExecuted(new DataDialogCommandEventArgs(false));

            var form = this.Parent as ERPDataForm;
            if (form != null)
            {
                form.DialogResult = DialogResult.Cancel;
                form.Close();
            }

        }
        public RadDataEntry DataEntry
        {
            get
            {
                return this.radDataEntry;
            }
        }
    }
}
