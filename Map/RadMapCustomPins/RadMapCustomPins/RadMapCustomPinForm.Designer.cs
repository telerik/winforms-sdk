namespace RadMapCustomPins
{
    partial class RadMapCustomPinForm
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
            this.radMap1 = new Telerik.WinControls.UI.RadMap();
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // radMap1
            // 
            this.radMap1.Location = new System.Drawing.Point(13, 13);
            this.radMap1.Name = "radMap1";
            this.radMap1.Size = new System.Drawing.Size(1231, 832);
            this.radMap1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 857);
            this.Controls.Add(this.radMap1);
            this.Name = "RadMapCustomPinForm";
            this.Text = "RadMapCustomPinForm";
            ((System.ComponentModel.ISupportInitialize)(this.radMap1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMap radMap1;
    }
}