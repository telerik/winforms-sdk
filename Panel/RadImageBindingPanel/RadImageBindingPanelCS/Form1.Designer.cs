namespace RadImageBindingPanelTest
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
            this.radImageBindingPanel1 = new RadImageBindingPanelTest.RadImageBindingPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radImageBindingPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radImageBindingPanel1
            // 
            this.radImageBindingPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radImageBindingPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radImageBindingPanel1.ButtonSize = new System.Drawing.Size(20, 20);
            this.radImageBindingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radImageBindingPanel1.Image = null;
            this.radImageBindingPanel1.Location = new System.Drawing.Point(0, 0);
            this.radImageBindingPanel1.Name = "radImageBindingPanel1";
            this.radImageBindingPanel1.OpenDialogTitle = "Open Image";
            this.radImageBindingPanel1.ReadOnly = false;
            this.radImageBindingPanel1.Size = new System.Drawing.Size(422, 246);
            this.radImageBindingPanel1.TabIndex = 0;
            this.radImageBindingPanel1.Text = "radImageBindingPanel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 246);
            this.Controls.Add(this.radImageBindingPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radImageBindingPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadImageBindingPanel radImageBindingPanel1;

    }
}

