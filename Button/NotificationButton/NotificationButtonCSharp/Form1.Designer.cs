namespace NotificationButtonCSharp
{
    partial class Form1
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
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement1 = new NotificationButtonElement();
            this.radButtonElement2 = new NotificationButtonElement();
            this.radButtonElement3 = new NotificationButtonElement();
            this.radButton3 = new NotificationButtonCSharp.NotificationButton();
            this.radButton2 = new NotificationButtonCSharp.NotificationButton();
            this.radButton1 = new NotificationButtonCSharp.NotificationButton();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.Size = new System.Drawing.Size(538, 162);
            this.radRibbonBar1.TabIndex = 4;
            this.radRibbonBar1.Text = "Form1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Notification Tab";
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radButtonElement2,
            this.radButtonElement3});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "Notification Group";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Text = "radButtonElement1";
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.Text = "radButtonElement2";
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.Text = "radButtonElement3";
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(355, 191);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(150, 50);
            this.radButton3.TabIndex = 5;
            this.radButton3.Text = "radButton3";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(184, 191);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(150, 50);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "radButton2";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(12, 191);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(150, 50);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "radButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 313);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radRibbonBar1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotificationButton radButton1;
        private NotificationButton radButton2;
        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private NotificationButtonElement radButtonElement1;
        private NotificationButtonElement radButtonElement2;
        private NotificationButtonElement radButtonElement3;
        private NotificationButton radButton3;
    }
}

