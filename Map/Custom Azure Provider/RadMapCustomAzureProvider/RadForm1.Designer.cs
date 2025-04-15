namespace RadMapCustomAzureProvider
{
    partial class RadForm1
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
            radMap1 = new Telerik.WinControls.UI.RadMap();
            ((System.ComponentModel.ISupportInitialize)radMap1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radMap1
            // 
            radMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            radMap1.Location = new System.Drawing.Point(0, 0);
            radMap1.Name = "radMap1";
            radMap1.Size = new System.Drawing.Size(1347, 794);
            radMap1.TabIndex = 0;
            // 
            // RadForm1
            // 
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1347, 794);
            Controls.Add(radMap1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "RadForm1";
            Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)radMap1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadMap radMap1;
    }
}