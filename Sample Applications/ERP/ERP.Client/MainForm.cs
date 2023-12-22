using ERP.Client.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ERP.Client
{
    public partial class MainForm : ShapedForm
    {
        InfoControl infoControl;
        BaseGridControl storesControl;
        BaseGridControl vendorsControl;
        BaseGridControl purchasesControl;
        BaseGridControl inventoriesControl;
        BaseGridControl billOfMaterialsControl;
        BaseGridControl workOrdersControl;
        BaseGridControl individualsControl;
        BaseGridControl ordersControl;

        public MainForm()
        {            
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.radCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.ShowHeaderLine = false;
            topControl1.ViewLabel.TextChanged += ViewLabel_TextChanged;
            ThemeResolutionService.ApplicationThemeChanged += ThemeResolutionService_ApplicationThemeChanged;
            radTreeView1.SelectedNodeChanged += RadTreeView1_SelectedNodeChanged;
            radBreadCrumb1.DefaultTreeView = radTreeView1;

            this.Icon = Resources.ERP;
            this.Text = "ERP Demo";

            foreach (RadTreeNode item in radTreeView1.TreeViewElement.GetNodes())
            {
                if (item.Nodes.Count > 0)
                {
                    item.Image = Resources.folder;
                }
            }
            topControl1.ViewLabel.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            topControl1.ViewLabel.Text = "";
            radCollapsiblePanel1.EnableAnimation = false;
            radCollapsiblePanel1.Collapsed += RadCollapsiblePanel1_Collapsed;
            radCollapsiblePanel1.Expanded += RadCollapsiblePanel1_Expanded;
        }

        private void ViewLabel_TextChanged(object sender, EventArgs e)
        {
            radCollapsiblePanel1.HeaderText = topControl1.ViewLabel.Text;
        }

        private void RadCollapsiblePanel1_Expanded(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles[0].Width = 267;
        }

        private void RadCollapsiblePanel1_Collapsed(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles[0].Width = 40;
        }

        private void ThemeResolutionService_ApplicationThemeChanged(object sender, ThemeChangedEventArgs args)
        {
            OnThemeChanged();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            OnThemeChanged();
            radTreeView1.Nodes[2].Nodes[1].Selected = true;
        }

        private void RadTreeView1_SelectedNodeChanged(object sender, Telerik.WinControls.UI.RadTreeViewEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "instructionsNode":
                    topControl1.ViewLabel.Text = "Instructions";
                    AttachInfoControl("Instructions.pdf");
                    break;
                case "documentationNode":
                    topControl1.ViewLabel.Text = "Documentation";
                    AttachInfoControl("Documentation.pdf");
                    break;
                case "storesNode":
                    topControl1.ViewLabel.Text = "Stores";
                    AttachGridControl<StoresControl>(ref storesControl);
                    break;
                case "suppliersNode":
                    topControl1.ViewLabel.Text = "Vendors";
                    AttachGridControl<VendorsControl>(ref vendorsControl);
                    break;
                case "purchasesNode":
                    topControl1.ViewLabel.Text = "Purchase Orders";
                    AttachGridControl<PurchasesControl>(ref purchasesControl);
                    break;
                case "productInventoryNode":
                    topControl1.ViewLabel.Text = "Product Inventory";
                    AttachGridControl<InventoriesControl>(ref inventoriesControl);
                    break;
                case "billOfMaterialsNode":
                    topControl1.ViewLabel.Text = "Bill Of Materials";
                    AttachGridControl<BillOfMaterialsControl>(ref billOfMaterialsControl);
                    break;
                case "workOrdersNode":
                    topControl1.ViewLabel.Text = "Work Orders";
                    AttachGridControl<WorkOrdersControl>(ref workOrdersControl);
                    break;
                case "individualsNode":
                    topControl1.ViewLabel.Text = "Individuals";
                    AttachGridControl<IndividualsControl>(ref individualsControl);
                    break;
                case "ordersNode":
                    topControl1.ViewLabel.Text = "Sales Orders";
                    AttachGridControl<OrdersControl>(ref ordersControl);
                    break;
            }
        }

        public void AttachGridControl<T>(ref BaseGridControl ctrl) where T : BaseGridControl, new()
        {
            if (ctrl == null)
            {
                ctrl = new T();
                ctrl.Dock = DockStyle.Fill;
                ctrl.Margin = new Padding(0, 0, 7, 7);
            }

            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 2));
            tableLayoutPanel1.Controls.Add(ctrl, 1, 2);

        }
        public void AttachInfoControl(string document)
        {
            if (infoControl == null)
            {
                infoControl = new InfoControl();
                infoControl.Dock = DockStyle.Fill;
                infoControl.Margin = new Padding(0, 0, 7, 7);
            }

            infoControl.InfoPdfViewer.LoadDocument(@"..\..\ERP.Client\Documents\" + document);
            infoControl.DocumentName = document;
           
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 2));
            tableLayoutPanel1.Controls.Add(infoControl, 1, 2);
        }

        protected void OnThemeChanged()
        {
            Theme theme = ThemeResolutionService.GetTheme(ThemeResolutionService.ApplicationThemeName);
       
            foreach (StyleGroup styleGroup in theme.StyleGroups)
            {
                foreach (PropertySettingGroup propertySettingGroup in styleGroup.PropertySettingGroups)
                {
                    if (propertySettingGroup.Selector.Value == "RadFormElement")
                    {
                        foreach (PropertySetting propertySetting in propertySettingGroup.PropertySettings)
                        {
                            if (propertySetting.Name == "BackColor")
                            {
                                this.BackColor = (Color)propertySetting.Value;
                                return;
                            }
                        }
                    }
                    if (styleGroup.Registrations[0].ControlType == "Telerik.WinControls.UI.RadForm" && propertySettingGroup.Selector.Value == "Telerik.WinControls.RootRadElement")
                    {
                        foreach (PropertySetting propertySetting in propertySettingGroup.PropertySettings)
                        {
                            if (propertySetting.Name == "BackColor")
                            {
                                this.BackColor = (Color)propertySetting.Value;
                                return;
                            }
                        }
                    }

                }

            }
        }
        
    }
}
