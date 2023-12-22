namespace ERP.Client
{
    partial class ERPDataForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.erpDataDialog = new ERP.Client.ERPDataDialog();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // erpDataDialog1
            // 
            this.erpDataDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.erpDataDialog.Location = new System.Drawing.Point(0, 0);
            this.erpDataDialog.Name = "erpDataDialog1";
            this.erpDataDialog.Size = new System.Drawing.Size(477, 461);
            this.erpDataDialog.TabIndex = 0;
            // 
            // ERPDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 520);
            this.Controls.Add(this.erpDataDialog);
            this.Name = "ERPDataForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ERPDataForm";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ERPDataDialog erpDataDialog;
    }
}