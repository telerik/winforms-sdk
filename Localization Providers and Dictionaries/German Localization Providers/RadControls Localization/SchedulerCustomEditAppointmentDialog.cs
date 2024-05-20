using System;
using System.Windows.Forms;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.UI.Scheduler.Dialogs;


namespace GermanRadControlsLocalization
{
    public partial class SchedulerCustomEditAppointmentDialog : RadSchedulerDialog , IEditAppointmentDialog
    {
        #region fields

        private static readonly TimeSpan EndOfDayTimeSpan = new TimeSpan(23, 59, 59);
        private static readonly TimeSpan StartOfDayTimeSpan = new TimeSpan(0, 0, 0);

        private IEvent _appointment = null;
        private ISchedulerData _schedulerData = null;
        protected IOpenRecurringAppointmentDialog OpenRecurringAppointmentDialog = null;

        private IEvent _recurringAppointment = null;
        private bool _saveRecurringAppointment = false;

        #endregion

        #region constructors

        public SchedulerCustomEditAppointmentDialog( )
        {
            InitializeComponent();
            
            this.ribbonBarAppointment.StartButtonImage = null; // ( ( System.Drawing.Image ) ( resources.GetObject( "ribbonBarAppointment.StartButtonImage" ) ) );
            this.btnSave.Image = null; // ( ( Image ) ( resources.GetObject( "SaveAppointment" ) ) );
            this.btnDelete.Image = null; // ( ( System.Drawing.Image ) ( resources.GetObject( "DeleteAppointment" ) ) );
            this.btnRecurrence.Image = null; // ( ( System.Drawing.Image ) ( resources.GetObject( "RecurrenceAppointment" ) ) );

            this.tabAppointment.Text = "Termin";

            // Move Controls
            this.chkAllDay.Location = new System.Drawing.Point( 340 , 216);
        }

        public SchedulerCustomEditAppointmentDialog( IEvent appointment , ISchedulerData schedulerData )
        {
            InitializeComponent( );

            this.ribbonBarAppointment.StartButtonImage = null; // ( ( System.Drawing.Image ) ( resources.GetObject( "ribbonBarAppointment.StartButtonImage" ) ) );
            this.btnSave.Image = null; // ( ( Image ) ( resources.GetObject( "SaveAppointment" ) ) );
            this.btnDelete.Image = null; // ( ( System.Drawing.Image ) ( resources.GetObject( "DeleteAppointment" ) ) );
            this.btnRecurrence.Image = null; // ( ( System.Drawing.Image ) ( resources.GetObject( "RecurrenceAppointment" ) ) );

            this.tabAppointment.Text = "Termin";

            // Move Controls
            this.chkAllDay.Location = new System.Drawing.Point( 340 , 216 );

            this.EditAppointment( appointment , schedulerData );
        }

        #endregion

        #region IEditAppointmentDialog Members

        public bool EditAppointment(IEvent appointment, ISchedulerData schedulerData)
        {
            this._appointment = appointment;
            this._schedulerData = schedulerData;

            // show OpenRecurringAppointmentDialog
            if (this._appointment != null && this._appointment.MasterEvent != null )
            {
                if (this.OpenRecurringAppointmentDialog == null)
                {
                    this.OpenRecurringAppointmentDialog = new OpenRecurringAppointmentDialog();
                }

                this.OpenRecurringAppointmentDialog.ThemeName = this.ThemeName;
                this.OpenRecurringAppointmentDialog.EventName = appointment.Summary;

                DialogResult result = this.OpenRecurringAppointmentDialog.ShowDialog();

                if (result != DialogResult.OK)
                {
                    return false;
                }

                bool editOccurrence = this.OpenRecurringAppointmentDialog.EditOccurrence;
                
                if (!editOccurrence)
                {
                    this._appointment = this._appointment.MasterEvent as SchedulerOutlookLikeAppointment;
                }
            }

			return true;
        }

        public void ShowRecurrenceDialog()
        {
            // initialize the recurringAppointment as BITSchedulerOutlookLikeAppointment
            if (this._recurringAppointment == null)
            {
                this._recurringAppointment = new SchedulerOutlookLikeAppointment();
            }

            // set settings
            this._recurringAppointment.Start = this.GetAppointmentStart();
            this._recurringAppointment.End = this.GetAppointmentEnd();

            if ( !this.RecurrenceSettingsShouldBeSaved() && this._appointment.RecurrenceRule != null )
            {
                this._recurringAppointment.RecurrenceRule = this._appointment.RecurrenceRule.Clone();
            }

            // show EditRecurrenceDialog
            IEditRecurrenceDialog editRecurrenceDialog = new SchedulerCustomEditRecurrenceDialog( this._recurringAppointment , this._schedulerData );
            editRecurrenceDialog.ThemeName = this.ThemeName;
            DialogResult result = editRecurrenceDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this._saveRecurringAppointment = true;

                this.SetStartDateAndTime(this._recurringAppointment.Start);
                this.SetEndDateAndTime(this._recurringAppointment.End);

                ApplyRecurrenceBehavior(this._recurringAppointment);
            }
        }

        #endregion

        #region events

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this._saveRecurringAppointment = false;
            this._recurringAppointment = null;

            // load appointment settings and controls data
            this.LoadStatuses();
            this.LoadSettingsFromEvent(this._appointment);
            this.ApplyRecurrenceBehavior(this._appointment);

            this.btnRecurrence.Enabled = (this._appointment.MasterEvent == null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ApplySettingsToEvent(this._appointment);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this._schedulerData != null)
            {
                this._schedulerData.GetEventStorage().Remove(this._appointment);
            }

            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnRecurrence_Click(object sender, EventArgs e)
        {
            this.ShowRecurrenceDialog();
        }

        #endregion

        #region private methods

        private void LoadStatuses()
        {
            if (this._schedulerData == null)
            {
                return;
            }

            ISchedulerStorage<IAppointmentStatusInfo> statusStorage = this._schedulerData.GetStatusStorage();
            this.cmbShowTimeAs.BeginUpdate();
            this.cmbShowTimeAs.Items.Clear();
            foreach (IAppointmentStatusInfo status in statusStorage)
            {
                this.cmbShowTimeAs.Items.Add( new RadListDataItem( status.DisplayName , status.Id ) );
            }

            if (this.cmbShowTimeAs.Items.Count > 0)
            {
                this.cmbShowTimeAs.SelectedIndex = 0;
            }

            this.cmbShowTimeAs.EndUpdate();
        }


        private void ApplySettingsToEvent(IEvent targetEvent)
        {
            // appointment settings
            targetEvent.Summary = this.txtSubject.Text;
            targetEvent.Location = this.txtLocation.Text;
            targetEvent.Description = this.txtDescription.Text;

            object selectedStatus = this.cmbShowTimeAs.SelectedValue;
            targetEvent.StatusId = (selectedStatus != null) ? (int)selectedStatus : 1;

            targetEvent.Start = this.GetAppointmentStart();
            targetEvent.End = this.GetAppointmentEnd();

            if (this.RecurrenceSettingsShouldBeSaved())
            {
                targetEvent.RecurrenceRule = this._recurringAppointment.RecurrenceRule;
            }

            // OutlookLike settings
            SchedulerOutlookLikeAppointment outlookAppointment = targetEvent as SchedulerOutlookLikeAppointment;

            if ( outlookAppointment != null )
            {
                outlookAppointment.Email = this.txtEmail.Text;
            }
        }

        private void LoadSettingsFromEvent(IEvent sourceEvent)
        {
            // appointment settings
            this.txtSubject.Text = sourceEvent.Summary;
            this.txtLocation.Text = sourceEvent.Location;
            this.txtDescription.Text = sourceEvent.Description;

            this.cmbShowTimeAs.SelectedValue = sourceEvent.StatusId;

            this.SetStartDateAndTime(sourceEvent.Start);
            this.SetEndDateAndTime(sourceEvent.End);

            double totalHours = sourceEvent.Duration.TotalHours;
            bool isAllDay = totalHours >= 23.99 && Math.Round(totalHours) % 24 == 0;
            this.chkAllDay.ToggleState = isAllDay ? ToggleState.On : ToggleState.Off;

            if (this._appointment != null && this._schedulerData != null)
            {
                this.btnDelete.Enabled = this._schedulerData.GetEventStorage().Contains(this._appointment) && sourceEvent.AllowDelete;
            }

            this.SetTimePickersEnabledState(isAllDay);

            // OutlookLike settings
            SchedulerOutlookLikeAppointment outlookAppointment = sourceEvent as SchedulerOutlookLikeAppointment;

            this.txtEmail.Text = outlookAppointment == null ? String.Empty : outlookAppointment.Email;
        }


        private void ApplyRecurrenceBehavior(IEvent appointment)
        {
            bool isOutlookBehavior = false;
            RadScheduler scheduler = this._schedulerData as RadScheduler;

            if (scheduler != null)
            {
                if (appointment != null && appointment.RecurrenceRule != null)
                {
                    isOutlookBehavior = true;
                }
            }

            this.dateStart.Enabled = !isOutlookBehavior;
            this.dateEnd.Enabled = !isOutlookBehavior;
            this.timeStart.Enabled = !isOutlookBehavior && !this.chkAllDay.Checked;
            this.timeEnd.Enabled = !isOutlookBehavior && !this.chkAllDay.Checked;
            this.chkAllDay.Visible = !isOutlookBehavior;
        }

        private bool RecurrenceSettingsShouldBeSaved()
        {
            return this._saveRecurringAppointment && this._recurringAppointment != null;
        }

        private void SetTimePickersEnabledState(bool allDay)
        {
            bool enabled = !allDay;

            this.timeStart.Enabled = enabled;
            this.timeEnd.Enabled = enabled;
        }


        private DateTime GetAppointmentStart()
        {
            DateTime startDate = this.dateStart.Value.Date;

            if (this.chkAllDay.ToggleState != ToggleState.On)
            {
                TimeSpan startTime = this.timeStart.Value.TimeOfDay;
                startDate = startDate.Add(startTime);
            }

            return startDate;
        }

        private DateTime GetAppointmentEnd()
        {
            DateTime endDate = this.dateEnd.Value.Date;
            TimeSpan endTime = this.timeEnd.Value.TimeOfDay;

            bool isAllDay = this.chkAllDay.ToggleState == ToggleState.On;

            endDate = endDate.Add( !isAllDay ? endTime : EndOfDayTimeSpan );

            return endDate;
        }

        private void SetStartDateAndTime(DateTime start)
        {
            this.dateStart.Value = start;
            this.timeStart.Value = start;
        }

        private void SetEndDateAndTime(DateTime end)
        {
            this.dateEnd.Value = end;
            this.timeEnd.Value = end;
        }

        #endregion

        #region Localization

        protected override void LocalizeDialog( RadSchedulerLocalizationProvider localizationProvider )
        {
            this.Text = localizationProvider.GetLocalizedString( RadSchedulerStringId.AppointmentDialogTitle );
            this.lblSubject.Text = localizationProvider.GetLocalizedString( RadSchedulerStringId.AppointmentDialogSubject );
            this.lblLocation.Text = localizationProvider.GetLocalizedString( RadSchedulerStringId.AppointmentDialogLocation );
            //this.lblBackground.Text = localizationProvider.GetLocalizedString( RadSchedulerStringId.AppointmentDialogBackground );
            this.lblStartTime.Text = localizationProvider.GetLocalizedString( RadSchedulerStringId.AppointmentDialogStartTime );
            this.lblEndTime.Text = localizationProvider.GetLocalizedString( RadSchedulerStringId.AppointmentDialogEndTime );
            this.chkAllDay.Text = localizationProvider.GetLocalizedString( RadSchedulerStringId.AppointmentDialogAllDay );
            //this.lblResource.Text = localizationProvider.GetLocalizedString( RadSchedulerStringId.AppointmentDialogResource );
            this.lblStatus.Text = localizationProvider.GetLocalizedString( RadSchedulerStringId.AppointmentDialogStatus );
            this.btnDelete.Text = localizationProvider.GetLocalizedString( RadSchedulerStringId.AppointmentDialogDelete );
            this.btnRecurrence.Text = localizationProvider.GetLocalizedString( RadSchedulerStringId.AppointmentDialogRecurrence );

            this.grActions.Text = "Aktionen";
            this.grOptions.Text = "Optionen";
            this.btnSave.Text = "Speichern &&\nSchließen";
            
        }

        #endregion

        #region RecurrenceDialog

        /// <summary>
        /// Creates a recurrence dialog.
        /// </summary>
        /// <param name="recurringAppointment"></param>
        /// <returns></returns>
        protected virtual IEditRecurrenceDialog CreateRecurrenceDialog( IEvent recurringAppointment )
        {
            SchedulerCustomEditRecurrenceDialog editRecurrenceDialog = new SchedulerCustomEditRecurrenceDialog( recurringAppointment , this._schedulerData );

            return editRecurrenceDialog;
        }

        #endregion
    }
}