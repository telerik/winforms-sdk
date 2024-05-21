using System.Drawing;


namespace GermanRadControlsLocalization
{
    partial class SchedulerCustomEditAppointmentDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulerCustomEditAppointmentDialog));
            this.timeEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dateEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.timeStart = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dateStart = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblEndTime = new Telerik.WinControls.UI.RadLabel();
            this.lblStartTime = new Telerik.WinControls.UI.RadLabel();
            this.chkAllDay = new Telerik.WinControls.UI.RadCheckBox();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.txtLocation = new Telerik.WinControls.UI.RadTextBox();
            this.txtSubject = new Telerik.WinControls.UI.RadTextBox();
            this.lblLocation = new Telerik.WinControls.UI.RadLabel();
            this.lblSubject = new Telerik.WinControls.UI.RadLabel();
            this.cmbShowTimeAs = new Telerik.WinControls.UI.RadDropDownList();
            this.lblStatus = new Telerik.WinControls.UI.RadLabel();
            this.ribbonBarAppointment = new Telerik.WinControls.UI.RadRibbonBar();
            this.tabAppointment = new Telerik.WinControls.UI.RibbonTab();
            this.grActions = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnSave = new Telerik.WinControls.UI.RadButtonElement();
            this.btnDelete = new Telerik.WinControls.UI.RadButtonElement();
            this.grOptions = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnRecurrence = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.lblEmail = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbShowTimeAs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonBarAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // timeEnd
            // 
            this.timeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeEnd.Checked = true;
            this.timeEnd.Culture = new System.Globalization.CultureInfo("de-DE");
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(211, 242);
            this.timeEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeEnd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.NullableValue = new System.DateTime(2008, 9, 12, 16, 55, 40, 944);
            this.timeEnd.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(88, 20);
            this.timeEnd.TabIndex = 5;
            this.timeEnd.TabStop = false;
            this.timeEnd.Value = new System.DateTime(2008, 9, 12, 16, 55, 40, 944);
            // 
            // dateEnd
            // 
            this.dateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEnd.Checked = true;
            this.dateEnd.Culture = new System.Globalization.CultureInfo("de-DE");
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(89, 242);
            this.dateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateEnd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.NullableValue = new System.DateTime(2008, 9, 12, 16, 55, 37, 429);
            this.dateEnd.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateEnd.Size = new System.Drawing.Size(116, 20);
            this.dateEnd.TabIndex = 4;
            this.dateEnd.TabStop = false;
            this.dateEnd.Value = new System.DateTime(2008, 9, 12, 16, 55, 37, 429);
            // 
            // timeStart
            // 
            this.timeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeStart.Checked = true;
            this.timeStart.Culture = new System.Globalization.CultureInfo("de-DE");
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(211, 214);
            this.timeStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeStart.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.timeStart.Name = "timeStart";
            this.timeStart.NullableValue = new System.DateTime(2008, 9, 12, 16, 55, 34, 944);
            this.timeStart.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(88, 20);
            this.timeStart.TabIndex = 3;
            this.timeStart.TabStop = false;
            this.timeStart.Value = new System.DateTime(2008, 9, 12, 16, 55, 34, 944);
            // 
            // dateStart
            // 
            this.dateStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateStart.Checked = true;
            this.dateStart.Culture = new System.Globalization.CultureInfo("de-DE");
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(89, 214);
            this.dateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateStart.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.NullableValue = new System.DateTime(2008, 9, 12, 16, 51, 38, 596);
            this.dateStart.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateStart.Size = new System.Drawing.Size(116, 20);
            this.dateStart.TabIndex = 2;
            this.dateStart.TabStop = false;
            this.dateStart.ThemeName = "ControlDefault";
            this.dateStart.Value = new System.DateTime(2008, 9, 12, 16, 51, 38, 596);
            // 
            // lblEndTime
            // 
            this.lblEndTime.BackColor = System.Drawing.Color.Transparent;
            this.lblEndTime.Location = new System.Drawing.Point(7, 243);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(53, 18);
            this.lblEndTime.TabIndex = 14;
            this.lblEndTime.Text = "End time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStartTime.Location = new System.Drawing.Point(7, 220);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(57, 18);
            this.lblStartTime.TabIndex = 13;
            this.lblStartTime.Text = "Start time:";
            // 
            // chkAllDay
            // 
            this.chkAllDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAllDay.BackColor = System.Drawing.Color.Transparent;
            this.chkAllDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.chkAllDay.Location = new System.Drawing.Point(305, 219);
            this.chkAllDay.Name = "chkAllDay";
            // 
            // 
            // 
            this.chkAllDay.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.chkAllDay.Size = new System.Drawing.Size(85, 18);
            this.chkAllDay.TabIndex = 6;
            this.chkAllDay.Text = "All day event";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(7, 340);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            // 
            // 
            // 
            this.txtDescription.RootElement.StretchVertically = true;
            this.txtDescription.Size = new System.Drawing.Size(573, 205);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.TabStop = false;
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Location = new System.Drawing.Point(89, 185);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(491, 20);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.TabStop = false;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(89, 159);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(491, 20);
            this.txtSubject.TabIndex = 0;
            this.txtSubject.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Location = new System.Drawing.Point(7, 189);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 18);
            this.lblLocation.TabIndex = 12;
            this.lblLocation.Text = "Location:";
            // 
            // lblSubject
            // 
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Location = new System.Drawing.Point(7, 162);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(45, 18);
            this.lblSubject.TabIndex = 11;
            this.lblSubject.Text = "Subject:";
            // 
            // cmbShowTimeAs
            // 
            this.cmbShowTimeAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbShowTimeAs.DropDownAnimationEnabled = true;
            this.cmbShowTimeAs.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbShowTimeAs.Location = new System.Drawing.Point(89, 275);
            this.cmbShowTimeAs.Name = "cmbShowTimeAs";
            // 
            // 
            // 
            this.cmbShowTimeAs.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.cmbShowTimeAs.ShowImageInEditorArea = true;
            this.cmbShowTimeAs.Size = new System.Drawing.Size(210, 20);
            this.cmbShowTimeAs.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(7, 275);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 18);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Show time as:";
            // 
            // ribbonBarAppointment
            // 
            this.ribbonBarAppointment.AutoSize = true;
            this.ribbonBarAppointment.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.tabAppointment});
            this.ribbonBarAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            this.ribbonBarAppointment.ExitButton.AccessibleDescription = "Exit";
            this.ribbonBarAppointment.ExitButton.AccessibleName = "Exit";
            // 
            // 
            // 
            this.ribbonBarAppointment.ExitButton.ButtonElement.AccessibleDescription = "Exit";
            this.ribbonBarAppointment.ExitButton.ButtonElement.AccessibleName = "Exit";
            this.ribbonBarAppointment.ExitButton.Text = "Exit";
            this.ribbonBarAppointment.Location = new System.Drawing.Point(0, 0);
            this.ribbonBarAppointment.Name = "ribbonBarAppointment";
            // 
            // 
            // 
            this.ribbonBarAppointment.OptionsButton.AccessibleDescription = "Options";
            this.ribbonBarAppointment.OptionsButton.AccessibleName = "Options";
            // 
            // 
            // 
            this.ribbonBarAppointment.OptionsButton.ButtonElement.AccessibleDescription = "Options";
            this.ribbonBarAppointment.OptionsButton.ButtonElement.AccessibleName = "Options";
            this.ribbonBarAppointment.OptionsButton.Text = "Options";
            this.ribbonBarAppointment.Size = new System.Drawing.Size(624, 154);
            this.ribbonBarAppointment.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("ribbonBarAppointment.StartButtonImage")));
            this.ribbonBarAppointment.TabIndex = 10;
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.ribbonBarAppointment.GetChildAt(0))).Text = "";
            //((Telerik.WinControls.UI.RadQuickAccessToolBar)(this.ribbonBarAppointment.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
			this.ribbonBarAppointment.RibbonBarElement.QuickAccessToolBar.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // tabAppointment
            // 
            this.tabAppointment.AccessibleDescription = "Appointment";
            this.tabAppointment.AccessibleName = "Appointment";
            this.tabAppointment.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.tabAppointment.Class = "RibbonTab";
            this.tabAppointment.IsSelected = true;
            this.tabAppointment.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.grActions,
            this.grOptions});
            this.tabAppointment.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.tabAppointment.Name = "tabAppointment";
            this.tabAppointment.StretchHorizontally = false;
            this.tabAppointment.Text = "Appointment";
            this.tabAppointment.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // grActions
            // 
            this.grActions.AccessibleDescription = "Actions";
            this.grActions.AccessibleName = "Actions";
            this.grActions.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnSave,
            this.btnDelete});
            this.grActions.Name = "grActions";
            this.grActions.Text = "Actions";
            this.grActions.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = "Save &&\nClose";
            this.btnSave.AccessibleName = "Save &&\nClose";
            this.btnSave.Class = "RibbonBarButtonElement";
            this.btnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.ImageIndex = 0;
            this.btnSave.MeasureTrailingSpaces = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save &&\nClose";
            this.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "Delete";
            this.btnDelete.AccessibleName = "Delete";
            this.btnDelete.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Class = "RibbonBarButtonElement";
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.StretchVertically = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grOptions
            // 
            this.grOptions.AccessibleDescription = "Options";
            this.grOptions.AccessibleName = "Options";
            this.grOptions.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnRecurrence});
            this.grOptions.Name = "grOptions";
            this.grOptions.Text = "Options";
            this.grOptions.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.AccessibleDescription = "Recurrence";
            this.btnRecurrence.AccessibleName = "Recurrence";
            this.btnRecurrence.Class = "RibbonBarButtonElement";
            this.btnRecurrence.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecurrence.ImageIndex = 2;
            this.btnRecurrence.Name = "btnRecurrence";
            this.btnRecurrence.Text = "Recurrence";
            this.btnRecurrence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecurrence.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnRecurrence.Click += new System.EventHandler(this.btnRecurrence_Click);
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(89, 301);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(7, 301);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 18);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // SchedulerCustomEditAppointmentDialog
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(624, 623);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cmbShowTimeAs);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.chkAllDay);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.ribbonBarAppointment);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.MinimumSize = new System.Drawing.Size(600, 365);
            this.Name = "SchedulerCustomEditAppointmentDialog";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MinSize = new System.Drawing.Size(600, 365);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbShowTimeAs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonBarAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar ribbonBarAppointment;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.UI.RibbonTab tabAppointment;
        private Telerik.WinControls.UI.RadRibbonBarGroup grActions;
        private Telerik.WinControls.UI.RadButtonElement btnSave;
        protected Telerik.WinControls.UI.RadDateTimePicker timeEnd;
        protected Telerik.WinControls.UI.RadDateTimePicker dateEnd;
        protected Telerik.WinControls.UI.RadDateTimePicker timeStart;
        protected Telerik.WinControls.UI.RadDateTimePicker dateStart;
        private Telerik.WinControls.UI.RadLabel lblEndTime;
        private Telerik.WinControls.UI.RadLabel lblStartTime;
        protected Telerik.WinControls.UI.RadCheckBox chkAllDay;
        protected Telerik.WinControls.UI.RadTextBox txtLocation;
        protected Telerik.WinControls.UI.RadTextBox txtSubject;
        private Telerik.WinControls.UI.RadLabel lblLocation;
        private Telerik.WinControls.UI.RadLabel lblSubject;
        protected Telerik.WinControls.UI.RadTextBox txtDescription;
        private Telerik.WinControls.UI.RadButtonElement btnDelete;
        private Telerik.WinControls.UI.RadRibbonBarGroup grOptions;
        private Telerik.WinControls.UI.RadButtonElement btnRecurrence;
        protected Telerik.WinControls.UI.RadDropDownList cmbShowTimeAs;
        private Telerik.WinControls.UI.RadLabel lblStatus;
        protected Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadLabel lblEmail;
    }
}