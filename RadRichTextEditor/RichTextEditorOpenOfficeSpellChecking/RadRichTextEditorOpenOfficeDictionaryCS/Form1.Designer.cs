namespace _1074335_RadRichTextEditorDictionary
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
            this.richTextEditorRibbonBar1 = new Telerik.WinControls.UI.RichTextEditorRibbonBar();
            this.radRichTextEditorRuler1 = new Telerik.WinControls.UI.RadRichTextEditorRuler();
            this.radRichTextEditor1 = new Telerik.WinControls.UI.RadRichTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.richTextEditorRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditorRuler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextEditorRibbonBar1
            // 
            this.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView;
            this.richTextEditorRibbonBar1.AssociatedRichTextEditor = null;
            this.richTextEditorRibbonBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013;
            // 
            // 
            // 
            this.richTextEditorRibbonBar1.ExitButton.Text = "Exit";
            this.richTextEditorRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1";
            // 
            // 
            // 
            this.richTextEditorRibbonBar1.OptionsButton.Text = "Options";
            // 
            // 
            // 
            this.richTextEditorRibbonBar1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 400, 108);
            this.richTextEditorRibbonBar1.RootElement.StretchVertically = true;
            this.richTextEditorRibbonBar1.Size = new System.Drawing.Size(1193, 173);
            this.richTextEditorRibbonBar1.TabIndex = 0;
            this.richTextEditorRibbonBar1.TabStop = false;
            this.richTextEditorRibbonBar1.Text = "Form1";
            // 
            // radRichTextEditorRuler1
            // 
            this.radRichTextEditorRuler1.AssociatedRichTextBox = this.radRichTextEditor1;
            this.radRichTextEditorRuler1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radRichTextEditorRuler1.Controls.Add(this.radRichTextEditor1);
            this.radRichTextEditorRuler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRichTextEditorRuler1.Location = new System.Drawing.Point(0, 173);
            this.radRichTextEditorRuler1.Name = "radRichTextEditorRuler1";
            // 
            // 
            // 
            this.radRichTextEditorRuler1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 200);
            this.radRichTextEditorRuler1.Size = new System.Drawing.Size(1193, 589);
            this.radRichTextEditorRuler1.TabIndex = 1;
            this.radRichTextEditorRuler1.Text = "radRichTextEditorRuler1";
            // 
            // radRichTextEditor1
            // 
            this.radRichTextEditor1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radRichTextEditor1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            this.radRichTextEditor1.CaretWidth = float.NaN;
            this.radRichTextEditor1.Location = new System.Drawing.Point(29, 29);
            this.radRichTextEditor1.Name = "radRichTextEditor1";
            // 
            // 
            // 
            this.radRichTextEditor1.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 200, 200);
            this.radRichTextEditor1.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.radRichTextEditor1.Size = new System.Drawing.Size(1163, 559);
            this.radRichTextEditor1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 762);
            this.Controls.Add(this.radRichTextEditorRuler1);
            this.Controls.Add(this.richTextEditorRibbonBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.richTextEditorRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditorRuler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RichTextEditorRibbonBar richTextEditorRibbonBar1;
        private Telerik.WinControls.UI.RadRichTextEditorRuler radRichTextEditorRuler1;
        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;

    }
}

