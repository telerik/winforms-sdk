namespace PanAndZoomExample
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
            this.panImageControl1 = new PanAndZoomExample.PanImageControl();
            ((System.ComponentModel.ISupportInitialize)(this.panImageControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panImageControl1
            // 
            this.panImageControl1.Location = new System.Drawing.Point(72, 45);
            this.panImageControl1.Name = "panImageControl1";
            this.panImageControl1.Size = new System.Drawing.Size(424, 327);
            this.panImageControl1.TabIndex = 0;
            this.panImageControl1.Text = "panImageControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 405);
            this.Controls.Add(this.panImageControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panImageControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanImageControl panImageControl1;
    }
}

