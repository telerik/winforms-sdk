namespace CustomTheme_net48
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
            this.radAIPrompt1 = new Telerik.WinControls.UI.RadAIPrompt();
            this.windows11LightBlue1 = new Windows11LightBlueClassLibrary.Windows11LightBlue();
            ((System.ComponentModel.ISupportInitialize)(this.radAIPrompt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radAIPrompt1
            // 
            this.radAIPrompt1.Location = new System.Drawing.Point(40, 16);
            this.radAIPrompt1.Margin = new System.Windows.Forms.Padding(5);
            this.radAIPrompt1.Name = "radAIPrompt1";
            this.radAIPrompt1.Size = new System.Drawing.Size(275, 305);
            this.radAIPrompt1.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 354);
            this.Controls.Add(this.radAIPrompt1);
            this.Name = "RadForm1";
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radAIPrompt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadAIPrompt radAIPrompt1;
        private Windows11LightBlueClassLibrary.Windows11LightBlue windows11LightBlue1;
    }
}