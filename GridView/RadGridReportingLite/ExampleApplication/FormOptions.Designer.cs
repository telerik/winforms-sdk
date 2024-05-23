namespace ExampleApplication
{
    partial class FormOptions
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
            this.radButtonOK = new Telerik.WinControls.UI.RadButton();
            this.radButtonCancel = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radCheckBoxHeaderRow = new Telerik.WinControls.UI.RadCheckBox();
            this.radRadioButtonPortrait = new Telerik.WinControls.UI.RadRadioButton();
            this.radSpinEditorMargins = new Telerik.WinControls.UI.RadSpinEditor();
            this.radComboBoxPaperSize = new Telerik.WinControls.UI.RadDropDownList();
            this.radRadioButtonLandscape = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabelMargins = new Telerik.WinControls.UI.RadLabel();
            this.radCheckBoxColors = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxFit = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxHeaderRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonPortrait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorMargins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxPaperSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonLandscape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMargins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxFit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButtonOK
            // 
            this.radButtonOK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radButtonOK.Location = new System.Drawing.Point(31, 14);
            this.radButtonOK.Name = "radButtonOK";
            this.radButtonOK.Size = new System.Drawing.Size(75, 23);
            this.radButtonOK.TabIndex = 0;
            this.radButtonOK.Text = "OK";
            this.radButtonOK.Click += new System.EventHandler(this.radButtonOK_Click);
            // 
            // radButtonCancel
            // 
            this.radButtonCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radButtonCancel.Location = new System.Drawing.Point(112, 14);
            this.radButtonCancel.Name = "radButtonCancel";
            this.radButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.radButtonCancel.TabIndex = 1;
            this.radButtonCancel.Text = "Cancel";
            this.radButtonCancel.Click += new System.EventHandler(this.radButtonCancel_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Controls.Add(this.radButtonCancel);
            this.radPanel1.Controls.Add(this.radButtonOK);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 216);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(215, 49);
            this.radPanel1.TabIndex = 2;
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.Color.White;
            this.radPanel2.Controls.Add(this.radCheckBoxHeaderRow);
            this.radPanel2.Controls.Add(this.radRadioButtonPortrait);
            this.radPanel2.Controls.Add(this.radSpinEditorMargins);
            this.radPanel2.Controls.Add(this.radComboBoxPaperSize);
            this.radPanel2.Controls.Add(this.radRadioButtonLandscape);
            this.radPanel2.Controls.Add(this.radLabel2);
            this.radPanel2.Controls.Add(this.radLabelMargins);
            this.radPanel2.Controls.Add(this.radCheckBoxColors);
            this.radPanel2.Controls.Add(this.radCheckBoxFit);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(215, 216);
            this.radPanel2.TabIndex = 3;
            // 
            // radCheckBoxHeaderRow
            // 
            this.radCheckBoxHeaderRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxHeaderRow.IsChecked = false;
            this.radCheckBoxHeaderRow.Location = new System.Drawing.Point(12, 58);
            this.radCheckBoxHeaderRow.Name = "radCheckBoxHeaderRow";
            this.radCheckBoxHeaderRow.Size = new System.Drawing.Size(17, 17);
            this.radCheckBoxHeaderRow.TabIndex = 8;
            this.radCheckBoxHeaderRow.Text = "Repeat header row";
            this.radCheckBoxHeaderRow.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            // 
            // radRadioButtonPortrait
            // 
            this.radRadioButtonPortrait.IsChecked = true;
            this.radRadioButtonPortrait.Location = new System.Drawing.Point(12, 154);
            this.radRadioButtonPortrait.Name = "radRadioButtonPortrait";
            this.radRadioButtonPortrait.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioButtonPortrait.Size = new System.Drawing.Size(15, 15);
            this.radRadioButtonPortrait.TabIndex = 5;
            this.radRadioButtonPortrait.Text = "Portrait";
            this.radRadioButtonPortrait.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radSpinEditorMargins
            // 
            this.radSpinEditorMargins.BackColor = System.Drawing.Color.White;
            this.radSpinEditorMargins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radSpinEditorMargins.Location = new System.Drawing.Point(99, 81);
            this.radSpinEditorMargins.Name = "radSpinEditorMargins";
            // 
            // 
            // 
            this.radSpinEditorMargins.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorMargins.ShowBorder = true;
            this.radSpinEditorMargins.Size = new System.Drawing.Size(46, 18);
            this.radSpinEditorMargins.TabIndex = 7;
            this.radSpinEditorMargins.Text = "radSpinEditor1";
            // 
            // radComboBoxPaperSize
            // 
            this.radComboBoxPaperSize.AutoSize = false;
            this.radComboBoxPaperSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radComboBoxPaperSize.Location = new System.Drawing.Point(90, 113);
            this.radComboBoxPaperSize.Name = "radComboBoxPaperSize";
            // 
            // 
            // 
            this.radComboBoxPaperSize.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBoxPaperSize.Size = new System.Drawing.Size(117, 27);
            this.radComboBoxPaperSize.TabIndex = 6;
            this.radComboBoxPaperSize.Text = "radComboBox1";
            // 
            // radRadioButtonLandscape
            // 
            this.radRadioButtonLandscape.IsChecked = false;
            this.radRadioButtonLandscape.Location = new System.Drawing.Point(12, 182);
            this.radRadioButtonLandscape.Name = "radRadioButtonLandscape";
            this.radRadioButtonLandscape.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radRadioButtonLandscape.Size = new System.Drawing.Size(15, 15);
            this.radRadioButtonLandscape.TabIndex = 4;
            this.radRadioButtonLandscape.Text = "Landscape";
            this.radRadioButtonLandscape.ThemeName = "Aqua";
            this.radRadioButtonLandscape.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(12, 118);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(72, 22);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Paper size:";
            // 
            // radLabelMargins
            // 
            this.radLabelMargins.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabelMargins.Location = new System.Drawing.Point(12, 81);
            this.radLabelMargins.Name = "radLabelMargins";
            this.radLabelMargins.Size = new System.Drawing.Size(81, 22);
            this.radLabelMargins.TabIndex = 2;
            this.radLabelMargins.Text = "Set margins:";
            // 
            // radCheckBoxColors
            // 
            this.radCheckBoxColors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxColors.IsChecked = false;
            this.radCheckBoxColors.Location = new System.Drawing.Point(12, 35);
            this.radCheckBoxColors.Name = "radCheckBoxColors";
            this.radCheckBoxColors.Size = new System.Drawing.Size(17, 17);
            this.radCheckBoxColors.TabIndex = 1;
            this.radCheckBoxColors.Text = "Use grid header colors";
            this.radCheckBoxColors.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            // 
            // radCheckBoxFit
            // 
            this.radCheckBoxFit.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.radCheckBoxFit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxFit.IsChecked = false;
            this.radCheckBoxFit.Location = new System.Drawing.Point(12, 12);
            this.radCheckBoxFit.Name = "radCheckBoxFit";
            // 
            // 
            // 
            this.radCheckBoxFit.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckBoxFit.Size = new System.Drawing.Size(17, 17);
            this.radCheckBoxFit.TabIndex = 0;
            this.radCheckBoxFit.Text = "Fit to page size";
            this.radCheckBoxFit.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 265);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report options";
            ((System.ComponentModel.ISupportInitialize)(this.radButtonOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxHeaderRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonPortrait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorMargins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxPaperSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonLandscape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMargins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxFit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButtonOK;
        private Telerik.WinControls.UI.RadButton radButtonCancel;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxColors;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxFit;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditorMargins;
        private Telerik.WinControls.UI.RadDropDownList radComboBoxPaperSize;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonPortrait;
        private Telerik.WinControls.UI.RadRadioButton radRadioButtonLandscape;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabelMargins;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxHeaderRow;
    }
}