namespace ERP.Client
{
    partial class DetailsMapControl
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
            this.radMap1 = new Telerik.WinControls.UI.RadMap();
            this.erpDataDialog1 = new ERP.Client.ERPDataDialog();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // radMap1
            // 
            this.radMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radMap1.Location = new System.Drawing.Point(449, 0);
            this.radMap1.Name = "radMap1";
            this.radMap1.Size = new System.Drawing.Size(764, 606);
            this.radMap1.TabIndex = 0;
            // 
            // erpDataDialog1
            // 
            this.erpDataDialog1.Dock = System.Windows.Forms.DockStyle.Left;
            this.erpDataDialog1.Location = new System.Drawing.Point(0, 0);
            this.erpDataDialog1.Name = "erpDataDialog1";
            this.erpDataDialog1.Size = new System.Drawing.Size(449, 606);
            this.erpDataDialog1.TabIndex = 1;
            // 
            // DetailsMapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radMap1);
            this.Controls.Add(this.erpDataDialog1);
            this.Name = "DetailsMapControl";
            this.Size = new System.Drawing.Size(1213, 606);
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMap radMap1;
        private ERPDataDialog erpDataDialog1;
    }
}
