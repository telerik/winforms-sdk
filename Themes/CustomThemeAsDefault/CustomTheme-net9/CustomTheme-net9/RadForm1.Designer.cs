namespace CustomTheme_net9
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
            windows11LightBlue1 = new Windows11LightBlueClassLibrary.Windows11LightBlue();
            radaiPrompt1 = new Telerik.WinControls.UI.RadAIPrompt();
            ((System.ComponentModel.ISupportInitialize)radaiPrompt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radaiPrompt1
            // 
            radaiPrompt1.Location = new System.Drawing.Point(13, 13);
            radaiPrompt1.Margin = new System.Windows.Forms.Padding(4);
            radaiPrompt1.Name = "radaiPrompt1";
            radaiPrompt1.Size = new System.Drawing.Size(501, 363);
            radaiPrompt1.TabIndex = 0;
            // 
            // RadForm1
            // 
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(527, 417);
            Controls.Add(radaiPrompt1);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "RadForm1";
            Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)radaiPrompt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Windows11LightBlueClassLibrary.Windows11LightBlue windows11LightBlue1;
        private Telerik.WinControls.UI.RadAIPrompt radaiPrompt1;
    }
}