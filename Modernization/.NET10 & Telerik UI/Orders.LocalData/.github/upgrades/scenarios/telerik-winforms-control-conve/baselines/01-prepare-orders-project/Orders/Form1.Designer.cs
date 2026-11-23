using System.Drawing;
using System.Windows.Forms;

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
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.menuStrip = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.exitToolStripMenuItem = new ToolStripMenuItem();
            this.helpToolStripMenuItem = new ToolStripMenuItem();
            this.aboutToolStripMenuItem = new ToolStripMenuItem();
            this.splitContainer = new SplitContainer();
            this.treeViewCategories = new TreeView();
            this.tabControl = new TabControl();
            this.tabProducts = new TabPage();
            this.btnAddToOrder = new Button();
            this.cmbCategoryFilter = new ComboBox();
            this.lblFilterBy = new Label();
            this.dataGridViewProducts = new DataGridView();
            this.tabOrders = new TabPage();
            this.lblTotalPrice = new Label();
            this.btnClearOrder = new Button();
            this.btnRemoveSelected = new Button();
            this.listBoxOrder = new ListBox();
            
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
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
            this.menuStrip.Items.AddRange(new ToolStripItem[] { this.fileToolStripMenuItem, this.helpToolStripMenuItem });
            this.menuStrip.Location = new Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new Size(1000, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.exitToolStripMenuItem });
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
            this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.aboutToolStripMenuItem });
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
            this.splitContainer.SplitterDistance = 250;
            this.splitContainer.TabIndex = 1;
            
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeViewCategories);
            
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            
            // 
            // treeViewCategories
            // 
            this.treeViewCategories.Dock = DockStyle.Fill;
            this.treeViewCategories.Font = new Font("Segoe UI", 10F);
            this.treeViewCategories.Location = new Point(0, 0);
            this.treeViewCategories.Name = "treeViewCategories";
            this.treeViewCategories.Size = new Size(250, 576);
            this.treeViewCategories.TabIndex = 0;
            this.treeViewCategories.AfterSelect += new TreeViewEventHandler(this.TreeViewCategories_AfterSelect);
            
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabProducts);
            this.tabControl.Controls.Add(this.tabOrders);
            this.tabControl.Dock = DockStyle.Fill;
            this.tabControl.Font = new Font("Segoe UI", 10F);
            this.tabControl.Location = new Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
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
            this.tabProducts.UseVisualStyleBackColor = true;
            
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
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.BtnAddToOrder_Click);
            
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.cmbCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Font = new Font("Segoe UI", 10F);
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new Point(80, 510);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new Size(200, 25);
            this.cmbCategoryFilter.TabIndex = 2;
            this.cmbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.CmbCategoryFilter_SelectedIndexChanged);
            
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
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new Point(6, 6);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            this.tabOrders.UseVisualStyleBackColor = true;
            
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
            this.lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            
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
            this.btnClearOrder.UseVisualStyleBackColor = true;
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
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
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
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Order Management System";
            
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
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

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private SplitContainer splitContainer;
        private TreeView treeViewCategories;
        private TabControl tabControl;
        private TabPage tabProducts;
        private TabPage tabOrders;
        private DataGridView dataGridViewProducts;
        private Label lblFilterBy;
        private ComboBox cmbCategoryFilter;
        private Button btnAddToOrder;
        private ListBox listBoxOrder;
        private Button btnRemoveSelected;
        private Button btnClearOrder;
        private Label lblTotalPrice;
    }
}
