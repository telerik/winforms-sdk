namespace DataEntryPropertiesOrder
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
            this.radDataEntry1 = new Telerik.WinControls.UI.RadDataEntry();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radDataEntry1)).BeginInit();
            this.radDataEntry1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radDataEntry1
            // 
            this.radDataEntry1.Location = new System.Drawing.Point(13, 13);
            this.radDataEntry1.Name = "radDataEntry1";
            // 
            // radDataEntry1.PanelContainer
            // 
            this.radDataEntry1.PanelContainer.Size = new System.Drawing.Size(298, 148);
            this.radDataEntry1.Size = new System.Drawing.Size(300, 150);
            this.radDataEntry1.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 199);
            this.Controls.Add(this.radDataEntry1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radDataEntry1)).EndInit();
            this.radDataEntry1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadDataEntry radDataEntry1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
    }
}