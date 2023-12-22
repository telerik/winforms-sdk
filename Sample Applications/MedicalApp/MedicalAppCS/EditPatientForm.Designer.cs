namespace MedicalAppCS
{
    partial class EditPatientForm
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
            this.postalCodeTextBoxControl = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            this.saveButton = new Telerik.WinControls.UI.RadButton();
            this.phoneMaskedEditBox = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.addressTextBoxControl = new Telerik.WinControls.UI.RadTextBoxControl();
            this.stateTextBoxControl = new Telerik.WinControls.UI.RadTextBoxControl();
            this.cityTextBoxControl = new Telerik.WinControls.UI.RadTextBoxControl();
            this.photoBrowseEditor = new Telerik.WinControls.UI.RadBrowseEditor();
            this.birthDateDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.genderFemaleRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.genderMaleRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.lastNameTextBoxControl = new Telerik.WinControls.UI.RadTextBoxControl();
            this.middleNameTextBoxControl = new Telerik.WinControls.UI.RadTextBoxControl();
            this.firstNameTextBoxControl = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.personsTableAdapter1 = new MedicalAppCS.PatientsDataSetTableAdapters.PersonsTableAdapter();
            this.personImagesTableAdapter1 = new MedicalAppCS.PatientsDataSetTableAdapters.PersonImagesTableAdapter();
            this.patientsTableAdapter1 = new MedicalAppCS.PatientsDataSetTableAdapters.PatientsTableAdapter();
            this.personImagesTableAdapter2 = new MedicalAppCS.PatientsDataSetTableAdapters.PersonImagesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.postalCodeTextBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneMaskedEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTextBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBrowseEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderFemaleRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderMaleRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // postalCodeTextBoxControl
            // 
            this.postalCodeTextBoxControl.Location = new System.Drawing.Point(310, 213);
            this.postalCodeTextBoxControl.Name = "postalCodeTextBoxControl";
            this.postalCodeTextBoxControl.Size = new System.Drawing.Size(225, 20);
            this.postalCodeTextBoxControl.TabIndex = 58;
            this.postalCodeTextBoxControl.ThemeName = "MedicalAppTheme";
            // 
            // radLabel10
            // 
            this.radLabel10.Location = new System.Drawing.Point(307, 193);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(64, 18);
            this.radLabel10.TabIndex = 62;
            this.radLabel10.Text = "Postal code";
            this.radLabel10.ThemeName = "MedicalAppTheme";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cancelButton.Location = new System.Drawing.Point(97, 307);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 21);
            this.cancelButton.TabIndex = 61;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.ThemeName = "MedicalAppTheme";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.saveButton.Location = new System.Drawing.Point(17, 307);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 21);
            this.saveButton.TabIndex = 60;
            this.saveButton.Text = "Save";
            this.saveButton.ThemeName = "MedicalAppTheme";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // phoneMaskedEditBox
            // 
            this.phoneMaskedEditBox.Location = new System.Drawing.Point(310, 260);
            this.phoneMaskedEditBox.Mask = "(999) 000-0000";
            this.phoneMaskedEditBox.Name = "phoneMaskedEditBox";
            this.phoneMaskedEditBox.Size = new System.Drawing.Size(225, 20);
            this.phoneMaskedEditBox.TabIndex = 59;
            this.phoneMaskedEditBox.TabStop = false;
            this.phoneMaskedEditBox.ThemeName = "MedicalAppTheme";
            // 
            // addressTextBoxControl
            // 
            this.addressTextBoxControl.Location = new System.Drawing.Point(310, 133);
            this.addressTextBoxControl.Multiline = true;
            this.addressTextBoxControl.Name = "addressTextBoxControl";
            this.addressTextBoxControl.Size = new System.Drawing.Size(225, 54);
            this.addressTextBoxControl.TabIndex = 57;
            this.addressTextBoxControl.ThemeName = "MedicalAppTheme";
            // 
            // stateTextBoxControl
            // 
            this.stateTextBoxControl.Location = new System.Drawing.Point(310, 83);
            this.stateTextBoxControl.Name = "stateTextBoxControl";
            this.stateTextBoxControl.Size = new System.Drawing.Size(225, 20);
            this.stateTextBoxControl.TabIndex = 56;
            this.stateTextBoxControl.ThemeName = "MedicalAppTheme";
            // 
            // cityTextBoxControl
            // 
            this.cityTextBoxControl.Location = new System.Drawing.Point(310, 33);
            this.cityTextBoxControl.Name = "cityTextBoxControl";
            this.cityTextBoxControl.Size = new System.Drawing.Size(225, 20);
            this.cityTextBoxControl.TabIndex = 55;
            this.cityTextBoxControl.ThemeName = "MedicalAppTheme";
            // 
            // photoBrowseEditor
            // 
            this.photoBrowseEditor.Location = new System.Drawing.Point(17, 260);
            this.photoBrowseEditor.Name = "photoBrowseEditor";
            this.photoBrowseEditor.Size = new System.Drawing.Size(225, 20);
            this.photoBrowseEditor.TabIndex = 54;
            this.photoBrowseEditor.Text = "radBrowseEditor1";
            this.photoBrowseEditor.ThemeName = "MedicalAppTheme";
            this.photoBrowseEditor.ValueChanged += new System.EventHandler(this.photoBrowseEditor_ValueChanged);
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(17, 213);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.birthDateDateTimePicker.TabIndex = 53;
            this.birthDateDateTimePicker.TabStop = false;
            this.birthDateDateTimePicker.ThemeName = "MedicalAppTheme";
            this.birthDateDateTimePicker.Value = new System.DateTime(((long)(0)));
            // 
            // genderFemaleRadioButton
            // 
            this.genderFemaleRadioButton.Location = new System.Drawing.Point(111, 167);
            this.genderFemaleRadioButton.Name = "genderFemaleRadioButton";
            this.genderFemaleRadioButton.Size = new System.Drawing.Size(56, 18);
            this.genderFemaleRadioButton.TabIndex = 52;
            this.genderFemaleRadioButton.TabStop = false;
            this.genderFemaleRadioButton.Text = "Female";
            this.genderFemaleRadioButton.ThemeName = "MedicalAppTheme";
            // 
            // genderMaleRadioButton
            // 
            this.genderMaleRadioButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.genderMaleRadioButton.Location = new System.Drawing.Point(17, 167);
            this.genderMaleRadioButton.Name = "genderMaleRadioButton";
            this.genderMaleRadioButton.Size = new System.Drawing.Size(45, 18);
            this.genderMaleRadioButton.TabIndex = 51;
            this.genderMaleRadioButton.Text = "Male";
            this.genderMaleRadioButton.ThemeName = "MedicalAppTheme";
            this.genderMaleRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // lastNameTextBoxControl
            // 
            this.lastNameTextBoxControl.Location = new System.Drawing.Point(17, 133);
            this.lastNameTextBoxControl.Name = "lastNameTextBoxControl";
            this.lastNameTextBoxControl.Size = new System.Drawing.Size(225, 20);
            this.lastNameTextBoxControl.TabIndex = 50;
            this.lastNameTextBoxControl.ThemeName = "MedicalAppTheme";
            // 
            // middleNameTextBoxControl
            // 
            this.middleNameTextBoxControl.Location = new System.Drawing.Point(17, 83);
            this.middleNameTextBoxControl.Name = "middleNameTextBoxControl";
            this.middleNameTextBoxControl.Size = new System.Drawing.Size(225, 20);
            this.middleNameTextBoxControl.TabIndex = 49;
            this.middleNameTextBoxControl.ThemeName = "MedicalAppTheme";
            // 
            // firstNameTextBoxControl
            // 
            this.firstNameTextBoxControl.Location = new System.Drawing.Point(17, 33);
            this.firstNameTextBoxControl.Name = "firstNameTextBoxControl";
            this.firstNameTextBoxControl.Size = new System.Drawing.Size(225, 20);
            this.firstNameTextBoxControl.TabIndex = 48;
            this.firstNameTextBoxControl.ThemeName = "MedicalAppTheme";
            // 
            // radLabel9
            // 
            this.radLabel9.Location = new System.Drawing.Point(307, 239);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(38, 18);
            this.radLabel9.TabIndex = 47;
            this.radLabel9.Text = "Phone";
            this.radLabel9.ThemeName = "MedicalAppTheme";
            // 
            // radLabel8
            // 
            this.radLabel8.Location = new System.Drawing.Point(308, 112);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(46, 18);
            this.radLabel8.TabIndex = 46;
            this.radLabel8.Text = "Address";
            this.radLabel8.ThemeName = "MedicalAppTheme";
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(308, 62);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(32, 18);
            this.radLabel7.TabIndex = 45;
            this.radLabel7.Text = "State";
            this.radLabel7.ThemeName = "MedicalAppTheme";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(308, 12);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(25, 18);
            this.radLabel6.TabIndex = 44;
            this.radLabel6.Text = "City";
            this.radLabel6.ThemeName = "MedicalAppTheme";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(14, 239);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(36, 18);
            this.radLabel5.TabIndex = 43;
            this.radLabel5.Text = "Photo";
            this.radLabel5.ThemeName = "MedicalAppTheme";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(14, 193);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(70, 18);
            this.radLabel4.TabIndex = 42;
            this.radLabel4.Text = "Date of birth";
            this.radLabel4.ThemeName = "MedicalAppTheme";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(14, 112);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(57, 18);
            this.radLabel3.TabIndex = 41;
            this.radLabel3.Text = "Last name";
            this.radLabel3.ThemeName = "MedicalAppTheme";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(14, 62);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(72, 18);
            this.radLabel2.TabIndex = 40;
            this.radLabel2.Text = "Middle name";
            this.radLabel2.ThemeName = "MedicalAppTheme";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(14, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(58, 18);
            this.radLabel1.TabIndex = 39;
            this.radLabel1.Text = "First name";
            this.radLabel1.ThemeName = "MedicalAppTheme";
            // 
            // personsTableAdapter1
            // 
            this.personsTableAdapter1.ClearBeforeFill = true;
            // 
            // personImagesTableAdapter1
            // 
            this.personImagesTableAdapter1.ClearBeforeFill = true;
            // 
            // patientsTableAdapter1
            // 
            this.patientsTableAdapter1.ClearBeforeFill = true;
            // 
            // personImagesTableAdapter2
            // 
            this.personImagesTableAdapter2.ClearBeforeFill = true;
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 340);
            this.Controls.Add(this.postalCodeTextBoxControl);
            this.Controls.Add(this.radLabel10);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.phoneMaskedEditBox);
            this.Controls.Add(this.addressTextBoxControl);
            this.Controls.Add(this.stateTextBoxControl);
            this.Controls.Add(this.cityTextBoxControl);
            this.Controls.Add(this.photoBrowseEditor);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(this.genderFemaleRadioButton);
            this.Controls.Add(this.genderMaleRadioButton);
            this.Controls.Add(this.lastNameTextBoxControl);
            this.Controls.Add(this.middleNameTextBoxControl);
            this.Controls.Add(this.firstNameTextBoxControl);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPatientForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Edit patient";
            this.ThemeName = "MedicalAppTheme";
            this.Load += new System.EventHandler(this.EditPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postalCodeTextBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneMaskedEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressTextBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTextBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityTextBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBrowseEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderFemaleRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderMaleRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameTextBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBoxControl postalCodeTextBoxControl;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private Telerik.WinControls.UI.RadButton cancelButton;
        private Telerik.WinControls.UI.RadButton saveButton;
        private Telerik.WinControls.UI.RadMaskedEditBox phoneMaskedEditBox;
        private Telerik.WinControls.UI.RadTextBoxControl addressTextBoxControl;
        private Telerik.WinControls.UI.RadTextBoxControl stateTextBoxControl;
        private Telerik.WinControls.UI.RadTextBoxControl cityTextBoxControl;
        private Telerik.WinControls.UI.RadBrowseEditor photoBrowseEditor;
        private Telerik.WinControls.UI.RadDateTimePicker birthDateDateTimePicker;
        private Telerik.WinControls.UI.RadRadioButton genderFemaleRadioButton;
        private Telerik.WinControls.UI.RadRadioButton genderMaleRadioButton;
        private Telerik.WinControls.UI.RadTextBoxControl lastNameTextBoxControl;
        private Telerik.WinControls.UI.RadTextBoxControl middleNameTextBoxControl;
        private Telerik.WinControls.UI.RadTextBoxControl firstNameTextBoxControl;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private PatientsDataSetTableAdapters.PersonsTableAdapter personsTableAdapter1;
        private PatientsDataSetTableAdapters.PersonImagesTableAdapter personImagesTableAdapter1;
        private PatientsDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter1;
        private PatientsDataSetTableAdapters.PersonImagesTableAdapter personImagesTableAdapter2;
    }
}