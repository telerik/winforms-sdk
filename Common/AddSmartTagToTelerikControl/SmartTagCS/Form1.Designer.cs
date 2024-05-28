namespace SmartTagCS
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
            this.radGridViewSmartTags1 = new RadGridViewSmartTags();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewSmartTags1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewSmartTags1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridViewSmartTags1
            // 
            this.radGridViewSmartTags1.Location = new System.Drawing.Point(12, 12);
            this.radGridViewSmartTags1.MyContextMenuEnabled = false;
            this.radGridViewSmartTags1.MyContextMenuVisible = true;
            this.radGridViewSmartTags1.Name = "radGridViewSmartTags1";
            this.radGridViewSmartTags1.Size = new System.Drawing.Size(260, 238);
            this.radGridViewSmartTags1.TabIndex = 0;
            this.radGridViewSmartTags1.Text = "radGridViewSmartTags1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.radGridViewSmartTags1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewSmartTags1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewSmartTags1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadGridViewSmartTags radGridViewSmartTags1;
    }
}

