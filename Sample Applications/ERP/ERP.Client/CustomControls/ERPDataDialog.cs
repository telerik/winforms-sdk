using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ERP.Repository;
using ERP.Repository.Service;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ERP.Client
{
    public partial class ERPDataDialog : UserControl
    {
        public event EventHandler<DataDialogCommandEventArgs> CommandExecuted;
        public ERPDataDialog()
        {
            this.InitializeComponent();
            this.radDataEntry.ItemDefaultSize = new Size(300, 25);
            this.radDataEntry.FlowDirection = FlowDirection.TopDown;
            this.radDataEntry.DataEntryElement.ItemSpace = 10;
            this.radDataEntry.FitToParentWidth = true;

            this.radDataEntry.ItemInitializing += this.radDataEntry_ItemInitializing;
            this.radDataEntry.BindingCreating += this.radDataEntry_BindingCreating;
            this.radDataEntry.BindingCreated += this.radDataEntry_BindingCreated;
            this.radDataEntry.EditorInitializing += this.radDataEntry_EditorInitializing;
            this.radDataEntry.VerticalScrollbar.ValueChanged += this.VerticalScrollbar_ValueChanged;
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

            if (this.radDataEntry.DataSource is Address)
            {
                if (!FieldsHelper.AddressFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;

                }
            }
            else if (this.radDataEntry.DataSource is PurchaseOrderHeader)
            {
                if (!FieldsHelper.PurchaseOrderHeaderFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;
                }
            }
            else if (this.radDataEntry.DataSource is Vendor)
            {
                if (!FieldsHelper.VendorFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;
                }
            }
            else if (this.radDataEntry.DataSource is ProductInventory)
            {
                if (!FieldsHelper.InventoriesFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;
                }
            }
            else if (this.radDataEntry.DataSource is WorkOrder)
            {
                if (!FieldsHelper.WorkOrdersFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;
                }
            }
            else if (this.radDataEntry.DataSource is BillOfMaterial)
            {
                if (!FieldsHelper.BillOfMaterialsFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;
                }
            }
            else if (this.radDataEntry.DataSource is SalesOrderHeader)
            {
                if (!FieldsHelper.OrdersFields.Contains(e.Panel.Controls[1].Text))
                {
                    e.Cancel = true;
                    e.Panel.Visible = false;
                }
            }
            else if (this.radDataEntry.DataSource is Customer)
            {
                var customer = this.radDataEntry.DataSource as Customer;
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
            if (this.radDataEntry.DataSource is Address)
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
            else if (this.radDataEntry.DataSource is PurchaseOrderHeader)
            {
                var purchaseOrder = this.radDataEntry.DataSource as PurchaseOrderHeader;

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

                if (e.Property.Name == "OrderStatus")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DataSource = purchaseOrder.OrderStatuses;
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    e.Editor = radDropDownList1;
                }
            }
            else if (this.radDataEntry.DataSource is Customer)
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
            else if (this.radDataEntry.DataSource is BillOfMaterial)
            {
                if (e.Property.Name == "EndDate")
                {
                    RadDateTimePicker radDateTimePicker = new RadDateTimePicker();
                    e.Editor = radDateTimePicker;
                }
                else if (e.Property.Name == "UnitMeasure")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = MainRepository.UnitMeasuresCache;
                    radDropDownList1.ValueMember = "UnitMeasureCode";
                    radDropDownList1.DisplayMember = "Name";
                    e.Editor = radDropDownList1;
                }
                else if (e.Property.Name == "Product")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = MainRepository.ProductsCache;

                    e.Editor = radDropDownList1;
                }
                else if (e.Property.Name == "Product1")
                {
                    var radDropDownList1 = new RadDropDownList();
                    radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
                    radDropDownList1.DataSource = MainRepository.ProductsCache.ToList();
                    radDropDownList1.DataMember = "ProductAssemblyID";
                    radDropDownList1.DisplayMember = "Name";
                    e.Editor = radDropDownList1;
                }

            }
            else if (this.radDataEntry.DataSource is ProductInventory)
            {
                if (e.Property.Name == "Color")
                {
                    e.Editor = new RadColorBox();
                }
                else if (e.Property.Name == "Location")
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
            else if (this.radDataEntry.DataSource is SalesOrderHeader)
            {
                if (e.Property.Name == "Customer")
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
                else if(e.Property.Name == "ShipDate")
                {
                    RadDateTimePicker radDateTimePicker = new RadDateTimePicker();
                    e.Editor = radDateTimePicker;
                }
            }
            else if (this.radDataEntry.DataSource is Vendor)
            {
                if (e.Property.Name == "CreditRating")
                {
                    var editor = new RadSpinEditor();
                    editor.Maximum = 5;
                    editor.Minimum = 0;
                    e.Editor = editor;
                }
            }
            else if (this.radDataEntry.DataSource is WorkOrder)
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
        }

        private void radDataEntry_BindingCreating(object sender, BindingCreatingEventArgs e)
        {

            if (this.radDataEntry.DataSource is Address)
            {
                if (e.DataMember == "StateProvince")
                {
                    e.DataMember = "StateProvince.StateProvinceID";
                    e.PropertyName = "SelectedValue";
                }
            }
            else if (this.radDataEntry.DataSource is PurchaseOrderHeader)
            {
                if (e.DataMember == "ShipMethod" || e.DataMember == "OrderStatus" || e.DataMember == "Vendor")
                {
                    e.PropertyName = "SelectedValue";
                }
            }
            else if (this.radDataEntry.DataSource is Customer)
            {
                if (e.DataMember == "State")
                {
                    e.DataMember = "Address.StateProvinceID";
                    e.PropertyName = "SelectedValue";
                }
            }
            else if (this.radDataEntry.DataSource is BillOfMaterial)
            {
                if (e.DataMember == "Product1")
                {
                    e.DataMember = "ProductAssemblyID";
                    e.PropertyName = "SelectedValue";
                }
                else if (e.DataMember == "UnitMeasure")
                {
                    e.DataMember = "UnitMeasureCode";
                    e.PropertyName = "Text";
                }
            }

            if (e.DataMember == "ShipDate" || e.DataMember == "Color" || e.DataMember == "EndDate")
            {
                e.PropertyName = "Value";
            }

            if (e.DataMember == "Location" || e.DataMember == "Product" || e.DataMember == "Customer" || e.DataMember == "ShipMethod")
            {
                e.PropertyName = "SelectedValue";
            }
        }

        private void radDataEntry_BindingCreated(object sender, BindingCreatedEventArgs e)
        {
            if (this.radDataEntry.DataSource is BillOfMaterial)
            {
                if (e.DataMember == "Color")
                {
                    e.Binding.FormattingEnabled = true;
                    e.Binding.Format += this.Binding_Format;
                }
            }

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
