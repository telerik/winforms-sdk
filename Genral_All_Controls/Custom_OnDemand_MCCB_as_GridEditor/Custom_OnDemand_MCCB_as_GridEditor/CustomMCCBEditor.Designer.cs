namespace _1408634
{
    partial class CustomMCCBEditor
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPopupEditor1 = new Telerik.WinControls.UI.RadPopupEditor();
            this.radPopupContainer1 = new Telerik.WinControls.UI.RadPopupContainer();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPopupEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPopupContainer1)).BeginInit();
            this.radPopupContainer1.PanelContainer.SuspendLayout();
            this.radPopupContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radPopupEditor1
            // 
            this.radPopupEditor1.AssociatedControl = this.radPopupContainer1;
            this.radPopupEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPopupEditor1.Location = new System.Drawing.Point(0, 0);
            this.radPopupEditor1.Name = "radPopupEditor1";
            this.radPopupEditor1.ShowTextBox = false;
            this.radPopupEditor1.Size = new System.Drawing.Size(501, 20);
            this.radPopupEditor1.TabIndex = 0;
            this.radPopupEditor1.Text = "radPopupEditor1";
            // 
            // radPopupContainer1
            // 
            this.radPopupContainer1.Location = new System.Drawing.Point(48, 127);
            this.radPopupContainer1.Name = "radPopupContainer1";
            // 
            // radPopupContainer1.PanelContainer
            // 
            this.radPopupContainer1.PanelContainer.Controls.Add(this.radGridView1);
            this.radPopupContainer1.PanelContainer.Size = new System.Drawing.Size(362, 185);
            this.radPopupContainer1.Size = new System.Drawing.Size(364, 187);
            this.radPopupContainer1.TabIndex = 1;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(362, 185);
            this.radGridView1.TabIndex = 0;
            // 
            // CustomMCCBEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPopupContainer1);
            this.Controls.Add(this.radPopupEditor1);
            this.Name = "CustomMCCBEditor";
            this.Size = new System.Drawing.Size(501, 413);
            ((System.ComponentModel.ISupportInitialize)(this.radPopupEditor1)).EndInit();
            this.radPopupContainer1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPopupContainer1)).EndInit();
            this.radPopupContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPopupEditor radPopupEditor1;
        private Telerik.WinControls.UI.RadPopupContainer radPopupContainer1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}
