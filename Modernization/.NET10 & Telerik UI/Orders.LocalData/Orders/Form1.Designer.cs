using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Orders
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name = "disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

#region Windows Form Designer generated code
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new RadMenu();
            this.fileToolStripMenuItem = new RadMenuItem();
            this.exitToolStripMenuItem = new RadMenuItem();
            this.helpToolStripMenuItem = new RadMenuItem();
            this.aboutToolStripMenuItem = new RadMenuItem();
            this.splitContainer = new RadSplitContainer();
            // Telerik insertCode for splitContainer:
            Telerik.WinControls.UI.SplitPanel splitContainerPanel1= new Telerik.WinControls.UI.SplitPanel();
            Telerik.WinControls.UI.SplitPanel splitContainerPanel2= new Telerik.WinControls.UI.SplitPanel();
            splitContainer.Controls.AddRange(new System.Windows.Forms.Control[] {               splitContainerPanel1, splitContainerPanel2});
            this.treeViewCategories = new RadTreeView();
            this.tabControl = new RadPageView();
            this.tabProducts = new RadPageViewPage();
            this.btnAddToOrder = new RadButton();
            this.cmbCategoryFilter = new RadDropDownList();
            this.lblFilterBy = new RadLabel();
            this.dataGridViewProducts = new RadGridView();
            this.tabOrders = new RadPageViewPage();
            this.lblTotalPrice = new RadLabel();
            this.btnClearOrder = new RadButton();
            this.btnRemoveSelected = new RadButton();
            this.listBoxOrder = new RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            splitContainerPanel1.SuspendLayout();
            splitContainerPanel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.tabOrders.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new RadItem[] { this.fileToolStripMenuItem, this.helpToolStripMenuItem });
            this.menuStrip.Location = new Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new Size(1000, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Items.AddRange(new RadItem[] { this.exitToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Items.AddRange(new RadItem[] { this.aboutToolStripMenuItem });
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = DockStyle.Fill;
            this.splitContainer.Location = new Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Size = new Size(1000, 576);
            this.splitContainer.SplitPanels[0].SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Absolute;
            this.splitContainer.SplitPanels[0].SizeInfo.AbsoluteSize = new System.Drawing.Size(250, 250);
            this.splitContainer.TabIndex = 1;
            // 
            // splitContainer.Panel1
            // 
            splitContainerPanel1.Controls.Add(this.treeViewCategories);
            // 
            // splitContainer.Panel2
            // 
            splitContainerPanel2.Controls.Add(this.tabControl);
            // 
            // treeViewCategories
            // 
            this.treeViewCategories.Dock = DockStyle.Fill;
            this.treeViewCategories.Font = new Font("Segoe UI", 10F);
            this.treeViewCategories.Location = new Point(0, 0);
            this.treeViewCategories.Name = "treeViewCategories";
            this.treeViewCategories.Size = new Size(250, 576);
            this.treeViewCategories.TabIndex = 0;
            this.treeViewCategories.SelectedNodeChanged += new RadTreeView.RadTreeViewEventHandler(this.TreeViewCategories_AfterSelect);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabProducts);
            this.tabControl.Controls.Add(this.tabOrders);
            this.tabControl.Dock = DockStyle.Fill;
            this.tabControl.Font = new Font("Segoe UI", 10F);
            this.tabControl.Location = new Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedPage = this.tabProducts;
            this.tabControl.Size = new Size(746, 576);
            this.tabControl.TabIndex = 0;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.btnAddToOrder);
            this.tabProducts.Controls.Add(this.cmbCategoryFilter);
            this.tabProducts.Controls.Add(this.lblFilterBy);
            this.tabProducts.Controls.Add(this.dataGridViewProducts);
            this.tabProducts.Location = new Point(4, 26);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new Padding(3);
            this.tabProducts.Size = new Size(738, 546);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "Products";
            // Removed (no Telerik equivalent): this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnAddToOrder.Font = new Font("Segoe UI", 10F);
            this.btnAddToOrder.Location = new Point(607, 508);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new Size(120, 30);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = "Add to Order";
            // Removed (no Telerik equivalent): this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.BtnAddToOrder_Click);
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.cmbCategoryFilter.DropDownStyle = RadDropDownStyle.DropDownList;
            this.cmbCategoryFilter.Font = new Font("Segoe UI", 10F);
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new Point(80, 510);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new Size(200, 25);
            this.cmbCategoryFilter.TabIndex = 2;
            this.cmbCategoryFilter.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.CmbCategoryFilter_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new Font("Segoe UI", 10F);
            this.lblFilterBy.Location = new Point(10, 513);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new Size(64, 19);
            this.lblFilterBy.TabIndex = 1;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowAddNewRow = false;
            this.dataGridViewProducts.AllowDeleteRow = false;
            this.dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridViewProducts.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            // Removed (no Telerik equivalent): this.dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new Point(6, 6);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new Size(726, 490);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.lblTotalPrice);
            this.tabOrders.Controls.Add(this.btnClearOrder);
            this.tabOrders.Controls.Add(this.btnRemoveSelected);
            this.tabOrders.Controls.Add(this.listBoxOrder);
            this.tabOrders.Location = new Point(4, 26);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new Padding(3);
            this.tabOrders.Size = new Size(738, 546);
            this.tabOrders.TabIndex = 1;
            this.tabOrders.Text = "Orders";
            // Removed (no Telerik equivalent): this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.lblTotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTotalPrice.Location = new Point(6, 510);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new Size(726, 28);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total Price: $0.00";
            this.lblTotalPrice.TextAlignment = ContentAlignment.MiddleRight;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnClearOrder.Font = new Font("Segoe UI", 10F);
            this.btnClearOrder.Location = new Point(607, 50);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new Size(120, 30);
            this.btnClearOrder.TabIndex = 2;
            this.btnClearOrder.Text = "Clear Order";
            // Removed (no Telerik equivalent): this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.BtnClearOrder_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnRemoveSelected.Font = new Font("Segoe UI", 10F);
            this.btnRemoveSelected.Location = new Point(607, 10);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new Size(120, 30);
            this.btnRemoveSelected.TabIndex = 1;
            this.btnRemoveSelected.Text = "Remove Selected";
            // Removed (no Telerik equivalent): this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.BtnRemoveSelected_Click);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.listBoxOrder.Font = new Font("Segoe UI", 10F);
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 17;
            this.listBoxOrder.Location = new Point(6, 6);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new Size(585, 497);
            this.listBoxOrder.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 600);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Order Management System";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            splitContainerPanel1.ResumeLayout(false);
            splitContainerPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.tabOrders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
        private RadMenu menuStrip;
        private RadMenuItem fileToolStripMenuItem;
        private RadMenuItem exitToolStripMenuItem;
        private RadMenuItem helpToolStripMenuItem;
        private RadMenuItem aboutToolStripMenuItem;
        private RadSplitContainer splitContainer;
        private RadTreeView treeViewCategories;
        private RadPageView tabControl;
        private RadPageViewPage tabProducts;
        private RadPageViewPage tabOrders;
        private RadGridView dataGridViewProducts;
        private RadLabel lblFilterBy;
        private RadDropDownList cmbCategoryFilter;
        private RadButton btnAddToOrder;
        private RadListControl listBoxOrder;
        private RadButton btnRemoveSelected;
        private RadButton btnClearOrder;
        private RadLabel lblTotalPrice;
    }
}
