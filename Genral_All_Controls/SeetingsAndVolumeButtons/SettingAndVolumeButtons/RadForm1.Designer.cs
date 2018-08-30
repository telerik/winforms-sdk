namespace SettingAndVolumeButtons
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
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.radDropDownButton1 = new Telerik.WinControls.UI.RadDropDownButton();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radPopupEditor1 = new Telerik.WinControls.UI.RadPopupEditor();
            this.radPopupContainer1 = new Telerik.WinControls.UI.RadPopupContainer();
            this.radTrackBar1 = new Telerik.WinControls.UI.RadTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPopupEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPopupContainer1)).BeginInit();
            this.radPopupContainer1.PanelContainer.SuspendLayout();
            this.radPopupContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radDropDownButton1
            // 
            this.radDropDownButton1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4,
            this.radMenuItem5});
            this.radDropDownButton1.Location = new System.Drawing.Point(631, 12);
            this.radDropDownButton1.Name = "radDropDownButton1";
            this.radDropDownButton1.Size = new System.Drawing.Size(44, 24);
            this.radDropDownButton1.TabIndex = 0;
            this.radDropDownButton1.Text = "radDropDownButton1";
            this.radDropDownButton1.ThemeName = "Fluent";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "radMenuItem1";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "radMenuItem2";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "radMenuItem3";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "radMenuItem4";
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "radMenuItem5";
            // 
            // radPopupEditor1
            // 
            this.radPopupEditor1.AssociatedControl = this.radPopupContainer1;
            this.radPopupEditor1.Location = new System.Drawing.Point(631, 346);
            this.radPopupEditor1.Name = "radPopupEditor1";
            this.radPopupEditor1.ShowTextBox = false;
            this.radPopupEditor1.Size = new System.Drawing.Size(44, 24);
            this.radPopupEditor1.TabIndex = 1;
            this.radPopupEditor1.Text = "radPopupEditor1";
            this.radPopupEditor1.ThemeName = "Fluent";
            // 
            // radPopupContainer1
            // 
            this.radPopupContainer1.Location = new System.Drawing.Point(13, 13);
            this.radPopupContainer1.Name = "radPopupContainer1";
            // 
            // radPopupContainer1.PanelContainer
            // 
            this.radPopupContainer1.PanelContainer.Controls.Add(this.radTrackBar1);
            this.radPopupContainer1.PanelContainer.Size = new System.Drawing.Size(38, 170);
            this.radPopupContainer1.Size = new System.Drawing.Size(40, 172);
            this.radPopupContainer1.TabIndex = 2;
            this.radPopupContainer1.ThemeName = "Fluent";
            // 
            // radTrackBar1
            // 
            this.radTrackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTrackBar1.Location = new System.Drawing.Point(0, 0);
            this.radTrackBar1.Name = "radTrackBar1";
            this.radTrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // 
            // 
            this.radTrackBar1.RootElement.StretchHorizontally = false;
            this.radTrackBar1.RootElement.StretchVertically = true;
            this.radTrackBar1.Size = new System.Drawing.Size(34, 170);
            this.radTrackBar1.TabIndex = 0;
            this.radTrackBar1.ThemeName = "Fluent";
            this.radTrackBar1.ThumbSize = new System.Drawing.Size(8, 20);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 392);
            this.Controls.Add(this.radPopupContainer1);
            this.Controls.Add(this.radPopupEditor1);
            this.Controls.Add(this.radDropDownButton1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            this.ThemeName = "Fluent";
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPopupEditor1)).EndInit();
            this.radPopupContainer1.PanelContainer.ResumeLayout(false);
            this.radPopupContainer1.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPopupContainer1)).EndInit();
            this.radPopupContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.UI.RadDropDownButton radDropDownButton1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadPopupEditor radPopupEditor1;
        private Telerik.WinControls.UI.RadPopupContainer radPopupContainer1;
        private Telerik.WinControls.UI.RadTrackBar radTrackBar1;
    }
}