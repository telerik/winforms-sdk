namespace HostBlazorInWinFormsSample
{
    partial class RadTabbedForm1
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
            this.radTabbedFormControl1 = new Telerik.WinControls.UI.RadTabbedFormControl();
            this.radTabbedFormControlTab1 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            this.radTabbedFormControlTab2 = new Telerik.WinControls.UI.RadTabbedFormControlTab();
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).BeginInit();
            this.radTabbedFormControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTabbedFormControl1
            // 
            this.radTabbedFormControl1.CaptionHeight = 36;
            this.radTabbedFormControl1.Controls.Add(this.radTabbedFormControlTab1);
            this.radTabbedFormControl1.Controls.Add(this.radTabbedFormControlTab2);
            this.radTabbedFormControl1.Location = new System.Drawing.Point(0, 0);
            this.radTabbedFormControl1.Name = "radTabbedFormControl1";
            this.radTabbedFormControl1.SelectedTab = this.radTabbedFormControlTab1;
            this.radTabbedFormControl1.Size = new System.Drawing.Size(507, 451);
            this.radTabbedFormControl1.TabHeight = 36;
            this.radTabbedFormControl1.TabIndex = 0;
            this.radTabbedFormControl1.TabSpacing = -1;
            this.radTabbedFormControl1.Text = "RadTabbedForm1";
            // 
            // radTabbedFormControlTab1
            // 
            this.radTabbedFormControlTab1.Location = new System.Drawing.Point(1, 37);
            this.radTabbedFormControlTab1.Name = "radTabbedFormControlTab1";
            this.radTabbedFormControlTab1.Size = new System.Drawing.Size(505, 413);
            this.radTabbedFormControlTab1.Text = "Tab 1";
            // 
            // radTabbedFormControlTab2
            // 
            this.radTabbedFormControlTab2.Location = new System.Drawing.Point(1, 37);
            this.radTabbedFormControlTab2.Name = "radTabbedFormControlTab2";
            this.radTabbedFormControlTab2.Size = new System.Drawing.Size(505, 413);
            this.radTabbedFormControlTab2.Text = "Tab 2";
            // 
            // RadTabbedForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 451);
            this.Controls.Add(this.radTabbedFormControl1);
            this.Name = "RadTabbedForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "RadTabbedForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radTabbedFormControl1)).EndInit();
            this.radTabbedFormControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTabbedFormControl radTabbedFormControl1;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab1;
        private Telerik.WinControls.UI.RadTabbedFormControlTab radTabbedFormControlTab2;
    }
}
