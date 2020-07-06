namespace CustomMergeField
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
            this.radRichTextEditor1 = new Telerik.WinControls.UI.RadRichTextEditor();
            this.richTextEditorRibbonBar1 = new Telerik.WinControls.UI.RichTextEditorRibbonBar();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richTextEditorRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRichTextEditor1
            // 
            this.radRichTextEditor1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            this.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRichTextEditor1.Location = new System.Drawing.Point(0, 174);
            this.radRichTextEditor1.Name = "radRichTextEditor1";
            this.radRichTextEditor1.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.radRichTextEditor1.Size = new System.Drawing.Size(1271, 659);
            this.radRichTextEditor1.TabIndex = 0;
            // 
            // richTextEditorRibbonBar1
            // 
            this.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView;
            this.richTextEditorRibbonBar1.AssociatedRichTextEditor = this.radRichTextEditor1;
            this.richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013;
            this.richTextEditorRibbonBar1.EnableKeyMap = false;
            // 
            // 
            // 
            this.richTextEditorRibbonBar1.ExitButton.Text = "Exit";
            this.richTextEditorRibbonBar1.LocalizationSettings.LayoutModeText = "Simplified Layout";
            this.richTextEditorRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1";
            // 
            // 
            // 
            this.richTextEditorRibbonBar1.OptionsButton.Text = "Options";
            this.richTextEditorRibbonBar1.ShowLayoutModeButton = true;
            this.richTextEditorRibbonBar1.Size = new System.Drawing.Size(1271, 174);
            this.richTextEditorRibbonBar1.TabIndex = 1;
            this.richTextEditorRibbonBar1.TabStop = false;
            this.richTextEditorRibbonBar1.Text = "RadForm1";
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // radButton1
            // 
            this.radButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radButton1.Location = new System.Drawing.Point(0, 833);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(1271, 24);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "Merge";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 857);
            this.Controls.Add(this.radRichTextEditor1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.richTextEditorRibbonBar1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richTextEditorRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;
        private Telerik.WinControls.UI.RichTextEditorRibbonBar richTextEditorRibbonBar1;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}