namespace ERP.Client
{
    partial class InfoControl
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
            this.printButton = new Telerik.WinControls.UI.RadButton();
            this.saveButton = new Telerik.WinControls.UI.RadButton();
            this.infoPdfViewer = new Telerik.WinControls.UI.RadPdfViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPdfViewer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.printButton.Location = new System.Drawing.Point(862, 12);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(110, 24);
            this.printButton.TabIndex = 0;
            this.printButton.Text = "Print";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveButton.Location = new System.Drawing.Point(1035, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 24);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // infoPdfViewer
            // 
            this.infoPdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPdfViewer.Location = new System.Drawing.Point(0, 48);
            this.infoPdfViewer.Name = "infoPdfViewer";
            this.infoPdfViewer.Size = new System.Drawing.Size(1148, 779);
            this.infoPdfViewer.TabIndex = 1;
            this.infoPdfViewer.Text = "radPdfViewer1";
            this.infoPdfViewer.ThumbnailsScaleFactor = 0.15F;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.printButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1148, 48);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // InfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoPdfViewer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InfoControl";
            this.Size = new System.Drawing.Size(1148, 827);
            ((System.ComponentModel.ISupportInitialize)(this.printButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPdfViewer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton printButton;
        private Telerik.WinControls.UI.RadButton saveButton;
        private Telerik.WinControls.UI.RadPdfViewer infoPdfViewer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
