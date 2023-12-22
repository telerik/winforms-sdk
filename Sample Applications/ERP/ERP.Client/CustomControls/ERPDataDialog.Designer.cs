namespace ERP.Client
{
    partial class ERPDataDialog
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radDataEntry = new Telerik.WinControls.UI.RadDataEntry();//new Telerik.WinControls.UI.RadDataLayout();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new Telerik.WinControls.UI.RadButton();
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radDataEntry)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.radDataLayout1.LayoutControl)).BeginInit();
            this.radDataEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.okButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            this.SuspendLayout();
            // 
            // radDataLayout1
            // 
            this.radDataEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // radDataLayout1.LayoutControl
            // 
            //this.radDataLayout1.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.radDataLayout1.LayoutControl.DrawBorder = false;
            //this.radDataLayout1.LayoutControl.Location = new System.Drawing.Point(0, 0);
            //this.radDataLayout1.LayoutControl.Name = "LayoutControl";
            //this.radDataLayout1.LayoutControl.Size = new System.Drawing.Size(513, 379);
            //this.radDataLayout1.LayoutControl.TabIndex = 0;
            this.radDataEntry.Location = new System.Drawing.Point(0, 0);
            this.radDataEntry.Name = "radDataLayout1";
            this.radDataEntry.Size = new System.Drawing.Size(515, 381);
            this.radDataEntry.TabIndex = 0;
            this.radDataEntry.Text = "radDataLayout1";
            // 
            // radSeparator1
            // 
            this.radSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radSeparator1.Location = new System.Drawing.Point(0, 381);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(515, 4);
            this.radSeparator1.TabIndex = 1;
            this.radSeparator1.Text = "radSeparator1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.87558F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.90669F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.06221F));
            this.tableLayoutPanel1.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 385);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 41);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(311, 14);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 24);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(413, 14);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(99, 24);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ERPDataDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radDataEntry);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ERPDataDialog";
            this.Size = new System.Drawing.Size(515, 426);
            //((System.ComponentModel.ISupportInitialize)(this.radDataLayout1.LayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDataEntry)).EndInit();
            this.radDataEntry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.okButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Telerik.WinControls.UI.RadDataLayout radDataLayout1;
        private Telerik.WinControls.UI.RadDataEntry radDataEntry;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton okButton;
        private Telerik.WinControls.UI.RadButton cancelButton;
    }
}
