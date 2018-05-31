namespace CustomDisplayText
{
    partial class CustomDisplayTextForm
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.myRadSpinEditor1 = new CustomDisplayText.MyRadSpinEditor();
            this.radSpinEditor2 = new CustomDisplayText.MyRadSpinEditor();
            this.radSpinEditor1 = new CustomDisplayText.MyRadSpinEditor();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRadSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 31);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(97, 16);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Scientific Notation";
            this.radLabel1.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(214, 27);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(73, 16);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Leading Zero";
            this.radLabel2.ThemeName = "TelerikMetro";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(416, 27);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(26, 16);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "Hex";
            this.radLabel3.ThemeName = "TelerikMetro";
            // 
            // myRadSpinEditor1
            // 
            this.myRadSpinEditor1.Hexadecimal = true;
            this.myRadSpinEditor1.LeadingZero = true;
            this.myRadSpinEditor1.Location = new System.Drawing.Point(416, 51);
            this.myRadSpinEditor1.Name = "myRadSpinEditor1";
            this.myRadSpinEditor1.NullableValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.myRadSpinEditor1.ScientificNatation = false;
            this.myRadSpinEditor1.Size = new System.Drawing.Size(196, 24);
            this.myRadSpinEditor1.TabIndex = 4;
            this.myRadSpinEditor1.TabStop = false;
            this.myRadSpinEditor1.ThemeName = "TelerikMetro";
            this.myRadSpinEditor1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radSpinEditor2
            // 
            this.radSpinEditor2.LeadingZero = true;
            this.radSpinEditor2.Location = new System.Drawing.Point(214, 51);
            this.radSpinEditor2.Name = "radSpinEditor2";
            this.radSpinEditor2.NullableValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinEditor2.ScientificNatation = false;
            this.radSpinEditor2.Size = new System.Drawing.Size(196, 24);
            this.radSpinEditor2.TabIndex = 1;
            this.radSpinEditor2.TabStop = false;
            this.radSpinEditor2.ThemeName = "TelerikMetro";
            this.radSpinEditor2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.LeadingZero = false;
            this.radSpinEditor1.Location = new System.Drawing.Point(12, 51);
            this.radSpinEditor1.Name = "radSpinEditor1";
            this.radSpinEditor1.NullableValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinEditor1.ScientificNatation = true;
            this.radSpinEditor1.Size = new System.Drawing.Size(196, 24);
            this.radSpinEditor1.TabIndex = 0;
            this.radSpinEditor1.TabStop = false;
            this.radSpinEditor1.ThemeName = "TelerikMetro";
            this.radSpinEditor1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CustomDisplayTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 118);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.myRadSpinEditor1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radSpinEditor2);
            this.Controls.Add(this.radSpinEditor1);
            this.Name = "CustomDisplayTextForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "CustomDisplayTextForm";
            this.ThemeName = "TelerikMetro";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRadSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyRadSpinEditor radSpinEditor1;
        private MyRadSpinEditor radSpinEditor2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private MyRadSpinEditor myRadSpinEditor1;
    }
}