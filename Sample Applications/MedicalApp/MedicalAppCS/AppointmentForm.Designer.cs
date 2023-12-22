namespace MedicalAppCS
{
    partial class AppointmentForm
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
            this.patientsDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.startDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.endDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.locationTextBoxControl = new Telerik.WinControls.UI.RadTextBoxControl();
            this.descriptionTextBoxControl = new Telerik.WinControls.UI.RadTextBoxControl();
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            this.saveButton = new Telerik.WinControls.UI.RadButton();
            this.personsTableAdapter1 = new MedicalAppCS.PatientsDataSetTableAdapters.PersonsTableAdapter();
            this.appointmentsTableAdapter1 = new MedicalAppCS.PatientsDataSetTableAdapters.AppointmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationTextBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // patientsDropDownList
            // 
            this.patientsDropDownList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patientsDropDownList.Location = new System.Drawing.Point(17, 33);
            this.patientsDropDownList.Name = "patientsDropDownList";
            this.patientsDropDownList.Size = new System.Drawing.Size(225, 20);
            this.patientsDropDownList.TabIndex = 0;
            this.patientsDropDownList.ThemeName = "MedicalAppTheme";
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Location = new System.Drawing.Point(14, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(41, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Patient";
            this.radLabel1.ThemeName = "MedicalAppTheme";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(15, 62);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(30, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Start";
            this.radLabel2.ThemeName = "MedicalAppTheme";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(14, 112);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(25, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "End";
            this.radLabel3.ThemeName = "MedicalAppTheme";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(307, 12);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(49, 18);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Location";
            this.radLabel4.ThemeName = "MedicalAppTheme";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(307, 62);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(63, 18);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "Description";
            this.radLabel5.ThemeName = "MedicalAppTheme";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "dd-MMMM-yyyy HH:mm";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(17, 83);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.startDateTimePicker.TabIndex = 3;
            this.startDateTimePicker.TabStop = false;
            this.startDateTimePicker.Text = "17-June-2015 12:00";
            this.startDateTimePicker.Value = new System.DateTime(2015, 6, 17, 12, 0, 0, 0);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "dd-MMMM-yyyy HH:mm";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(17, 133);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(225, 20);
            this.endDateTimePicker.TabIndex = 4;
            this.endDateTimePicker.TabStop = false;
            this.endDateTimePicker.Text = "17-June-2015 12:30";
            this.endDateTimePicker.Value = new System.DateTime(2015, 6, 17, 12, 30, 0, 0);
            // 
            // locationTextBoxControl
            // 
            this.locationTextBoxControl.Location = new System.Drawing.Point(310, 33);
            this.locationTextBoxControl.Name = "locationTextBoxControl";
            this.locationTextBoxControl.Size = new System.Drawing.Size(225, 20);
            this.locationTextBoxControl.TabIndex = 5;
            this.locationTextBoxControl.ThemeName = "MedicalAppTheme";
            // 
            // descriptionTextBoxControl
            // 
            this.descriptionTextBoxControl.Location = new System.Drawing.Point(310, 83);
            this.descriptionTextBoxControl.Multiline = true;
            this.descriptionTextBoxControl.Name = "descriptionTextBoxControl";
            this.descriptionTextBoxControl.Size = new System.Drawing.Size(225, 70);
            this.descriptionTextBoxControl.TabIndex = 6;
            this.descriptionTextBoxControl.ThemeName = "MedicalAppTheme";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cancelButton.Location = new System.Drawing.Point(97, 195);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 21);
            this.cancelButton.TabIndex = 40;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.ThemeName = "MedicalAppTheme";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.saveButton.Location = new System.Drawing.Point(17, 195);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 21);
            this.saveButton.TabIndex = 39;
            this.saveButton.Text = "Save";
            this.saveButton.ThemeName = "MedicalAppTheme";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // personsTableAdapter1
            // 
            this.personsTableAdapter1.ClearBeforeFill = true;
            // 
            // appointmentsTableAdapter1
            // 
            this.appointmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 228);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBoxControl);
            this.Controls.Add(this.locationTextBoxControl);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.patientsDropDownList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppointmentForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "New Appointment";
            this.ThemeName = "MedicalAppTheme";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationTextBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList patientsDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDateTimePicker startDateTimePicker;
        private Telerik.WinControls.UI.RadDateTimePicker endDateTimePicker;
        private Telerik.WinControls.UI.RadTextBoxControl locationTextBoxControl;
        private Telerik.WinControls.UI.RadTextBoxControl descriptionTextBoxControl;
        private Telerik.WinControls.UI.RadButton cancelButton;
        private Telerik.WinControls.UI.RadButton saveButton;
        private PatientsDataSetTableAdapters.PersonsTableAdapter personsTableAdapter1;
        private PatientsDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter1;
    }
}