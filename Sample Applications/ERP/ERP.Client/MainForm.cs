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
        private InfoControl infoControl;
        private BaseGridControl storesControl;
        private BaseGridControl vendorsControl;
        private BaseGridControl purchasesControl;
        private BaseGridControl inventoriesControl;
        private BaseGridControl billOfMaterialsControl;
        private BaseGridControl workOrdersControl;
        private BaseGridControl individualsControl;
        private BaseGridControl ordersControl;

        public MainForm()
        {
            this.InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.radCollapsiblePanel1.CollapsiblePanelElement.HeaderElement.ShowHeaderLine = false;
            this.topControl1.ViewLabel.TextChanged += this.ViewLabel_TextChanged;
            ThemeResolutionService.ApplicationThemeChanged += this.ThemeResolutionService_ApplicationThemeChanged;
            this.radTreeView1.SelectedNodeChanged += this.RadTreeView1_SelectedNodeChanged;
            this.radBreadCrumb1.DefaultTreeView = this.radTreeView1;

            this.Icon = Resources.ERP;
            this.Text = "ERP Demo";

            foreach (RadTreeNode item in this.radTreeView1.TreeViewElement.GetNodes())
            {
                if (item.Nodes.Count > 0)
                {
                    item.Image = Resources.folder;
                }
            }

            this.topControl1.ViewLabel.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            this.topControl1.ViewLabel.Text = "";
            this.radCollapsiblePanel1.EnableAnimation = false;
            this.radCollapsiblePanel1.Collapsed += this.RadCollapsiblePanel1_Collapsed;
            this.radCollapsiblePanel1.Expanded += this.RadCollapsiblePanel1_Expanded;
        }

        private void ViewLabel_TextChanged(object sender, EventArgs e)
        {
            this.radCollapsiblePanel1.HeaderText = this.topControl1.ViewLabel.Text;
        }

        private void RadCollapsiblePanel1_Expanded(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.ColumnStyles[0].Width = 267;
        }

        private void RadCollapsiblePanel1_Collapsed(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.ColumnStyles[0].Width = 40;
        }

        private void ThemeResolutionService_ApplicationThemeChanged(object sender, ThemeChangedEventArgs args)
        {
            this.OnThemeChanged();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.OnThemeChanged();
            this.radTreeView1.Nodes[2].Nodes[1].Selected = true;
        }

        private void RadTreeView1_SelectedNodeChanged(object sender, Telerik.WinControls.UI.RadTreeViewEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "instructionsNode":
                    this.topControl1.ViewLabel.Text = "Instructions";
                    this.AttachInfoControl("Instructions.pdf");
                    break;
                case "documentationNode":
                    this.topControl1.ViewLabel.Text = "Documentation";
                    this.AttachInfoControl("Documentation.pdf");
                    break;
                case "storesNode":
                    this.topControl1.ViewLabel.Text = "Stores";
                    this.AttachGridControl<StoresControl>(ref this.storesControl);
                    break;
                case "suppliersNode":
                    this.topControl1.ViewLabel.Text = "Vendors";
                    this.AttachGridControl<VendorsControl>(ref this.vendorsControl);
                    break;
                case "purchasesNode":
                    this.topControl1.ViewLabel.Text = "Purchase Orders";
                    this.AttachGridControl<PurchasesControl>(ref this.purchasesControl);
                    break;
                case "productInventoryNode":
                    this.topControl1.ViewLabel.Text = "Product Inventory";
                    this.AttachGridControl<InventoriesControl>(ref this.inventoriesControl);
                    break;
                case "billOfMaterialsNode":
                    this.topControl1.ViewLabel.Text = "Bill Of Materials";
                    this.AttachGridControl<BillOfMaterialsControl>(ref this.billOfMaterialsControl);
                    break;
                case "workOrdersNode":
                    this.topControl1.ViewLabel.Text = "Work Orders";
                    this.AttachGridControl<WorkOrdersControl>(ref this.workOrdersControl);
                    break;
                case "individualsNode":
                    this.topControl1.ViewLabel.Text = "Individuals";
                    this.AttachGridControl<IndividualsControl>(ref this.individualsControl);
                    break;
                case "ordersNode":
                    this.topControl1.ViewLabel.Text = "Sales Orders";
                    this.AttachGridControl<OrdersControl>(ref this.ordersControl);
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

            this.tableLayoutPanel1.Controls.Remove(this.tableLayoutPanel1.GetControlFromPosition(1, 2));
            this.tableLayoutPanel1.Controls.Add(ctrl, 1, 2);

        }
        public void AttachInfoControl(string document)
        {
            if (this.infoControl == null)
            {
                this.infoControl = new InfoControl();
                this.infoControl.Dock = DockStyle.Fill;
                this.infoControl.Margin = new Padding(0, 0, 7, 7);
            }

            this.infoControl.InfoPdfViewer.LoadDocument(@"..\..\ERP.Client\Documents\" + document);
            this.infoControl.DocumentName = document;

            this.tableLayoutPanel1.Controls.Remove(this.tableLayoutPanel1.GetControlFromPosition(1, 2));
            this.tableLayoutPanel1.Controls.Add(this.infoControl, 1, 2);
        }

        protected void OnThemeChanged()
        {
            // The UserControls need to be repainted in order to update their BackColor on theme change.
            this.Refresh();
        }
        }
}