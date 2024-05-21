using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Scheduler.Dialogs;

namespace GermanRadControlsLocalization
{
    public partial class SchedulerCustomEditRecurrenceDialog : EditRecurrenceDialog
    {
        public SchedulerCustomEditRecurrenceDialog( IEvent recurringAppointment , ISchedulerData schedulerData )
            : base( recurringAppointment , schedulerData )
        {
            InitializeComponent( );

            // Rearrange the Controls on the EditRecurrenceDialog
            RearrangeControlsInDialog( );
        }

        private void RearrangeControlsInDialog( )
        {
            // --------------- grpAppointmentTime -------------------------------------------------
            RearrangeControlsInGroupBoxAppointmentTime( );

            // --------------- grpRange -----------------------------------------------------------
            RearrangeControlsInGroupBoxRange( );

            // --------------- recurrenceGroupBox -------------------------------------------------
            RadGroupBox recurrenceGroupBox = ( RadGroupBox ) this.Controls[ "recurrenceGroupBox" ];

            RadRadioButton radioYearly = ( RadRadioButton ) recurrenceGroupBox.Controls[ "radioYearly" ];
            RadRadioButton radioMonthly = ( RadRadioButton ) recurrenceGroupBox.Controls[ "radioMonthly" ];
            RadRadioButton radioWeekly = ( RadRadioButton ) recurrenceGroupBox.Controls[ "radioWeekly" ];
            RadRadioButton radioDaily = ( RadRadioButton ) recurrenceGroupBox.Controls[ "radioDaily" ];
            RadSeparator radSeparator1 = ( RadSeparator ) recurrenceGroupBox.Controls [ "radSeparator1" ];

            RearrangeControlsInGroupBoxRecurrence( ref radioYearly , ref radioMonthly , ref radioWeekly , ref radioDaily , ref radSeparator1);

            // --------------- DailyRecurrenceSettings --------------------------------------------
            RearrangeControlsInDailySettings( ref radioDaily );

            // --------------- MonthlyRecurrenceSettings ------------------------------------------
            RearrangeControlsInMonthlySettings( ref radioMonthly );

            // --------------- YearlyRecurrenceSettings -------------------------------------------
            RearrangeControlsInYearlySettings( ref radioYearly );

            // --------------- WeeklyRecurrenceSettings -------------------------------------------
            RearrangeControlsInWeeklySettings( ref radioWeekly );
        }

        private void RearrangeControlsInWeeklySettings( ref RadRadioButton radioWeekly )
        {
            WeeklyRecurrenceSettings weekly = ( WeeklyRecurrenceSettings ) this.radioToSettingsDictionary[ radioWeekly ];
            weekly.Location = new Point( 85 , 40 );

            RadLabel lblRecurEvery = ( RadLabel ) weekly.Controls[ "lblRecurEvery" ];

            lblRecurEvery.Location = new Point( 10 , 4 );

            RadCheckBox chkSunday = ( RadCheckBox ) weekly.Controls[ "chkSunday" ];

            chkSunday.Location = new Point( 147 , 61 );

            RadCheckBox chkMonday = ( RadCheckBox ) weekly.Controls[ "chkMonday" ];

            chkMonday.Location = new Point( 9 , 37 );

            RadCheckBox chkTuesday = ( RadCheckBox ) weekly.Controls[ "chkTuesday" ];

            chkTuesday.Location = new Point( 79 , 37 );

            RadCheckBox chkWednesday = ( RadCheckBox ) weekly.Controls[ "chkWednesday" ];

            chkWednesday.Location = new Point( 147 , 37 );

            RadCheckBox chkThursday = ( RadCheckBox ) weekly.Controls[ "chkThursday" ];

            chkThursday.Location = new Point( 219 , 37 );
            chkThursday.Size = new Size( 80 , 17 );

            RadCheckBox chkFriday = ( RadCheckBox ) weekly.Controls[ "chkFriday" ];

            chkFriday.Location = new Point( 9 , 61 );

            RadCheckBox chkSaturday = ( RadCheckBox ) weekly.Controls[ "chkSaturday" ];

            chkSaturday.Location = new Point( 79 , 61 );
        }

        private void RearrangeControlsInYearlySettings( ref RadRadioButton radioYearly )
        {
            YearlyRecurrenceSettings yearly = ( YearlyRecurrenceSettings ) this.radioToSettingsDictionary[ radioYearly ];
            yearly.Location = new Point( 85 , 40 );

            RadRadioButton radioDayOfMonth = ( RadRadioButton ) yearly.Controls[ "radioDayOfMonth" ];

            radioDayOfMonth.Location = new Point( 10 , 4 );

            RadRadioButton radioWeekOfMonth = ( RadRadioButton ) yearly.Controls[ "radioWeekOfMonth" ];

            radioWeekOfMonth.Location = new Point( 10 , 36 );
            radioWeekOfMonth.Size = new Size( 70 , 16 );

            RadDropDownList cmbWeekNumber = ( RadDropDownList ) yearly.Controls [ "comboBoxWeekNumber" ];

            cmbWeekNumber.Location = new Point( 60 , 34 );
            cmbWeekNumber.Size = new Size( 84 , 20  );

            RadDropDownList cmbMonth1 = ( RadDropDownList ) yearly.Controls [ "comboBoxMonth1" ];

            cmbMonth1.Location = new Point( 110 , 2 );

            RadSpinEditor spinDayNumber = ( RadSpinEditor ) yearly.Controls[ "spinDayNumber" ];

            spinDayNumber.Location = new Point( 60 , 2 );
        }

        private void RearrangeControlsInMonthlySettings( ref RadRadioButton radioMonthly )
        {
            MonthlyRecurrenceSettings monthly = ( MonthlyRecurrenceSettings ) this.radioToSettingsDictionary[ radioMonthly ];
            monthly.Location = new Point( 85 , 40 );

            RadRadioButton radioDayOfMonth = ( RadRadioButton ) monthly.Controls[ "radioDayOfMonth" ];

            radioDayOfMonth.Location = new Point( 10 , 4 );

            RadLabel lblDayOfMonth = ( RadLabel ) monthly.Controls[ "lblDayOfMonth" ];

            lblDayOfMonth.Location = new Point( 100 , 5 );

            RadSpinEditor spinInterval1 = ( RadSpinEditor ) monthly.Controls[ "spinInterval1" ];

            spinInterval1.Location = new Point( 162 , 2 );

            RadLabel lblMonths1 = ( RadLabel ) monthly.Controls[ "lblMonths1" ];

            lblMonths1.Location = new Point( 213 , 5 );

            RadRadioButton radioWeekOfMonth = ( RadRadioButton ) monthly.Controls[ "radioWeekOfMonth" ];

            radioWeekOfMonth.Location = new Point( 10 , 34 );
            /*
            RadSchedulerLocalizationProvider localizationProvider = RadSchedulerLocalizationProvider.CurrentProvider;
            Dictionary<string , WeekDays> weekdays = new Dictionary<string , WeekDays>( );
            weekdays.Add( localizationProvider.GetLocalizedString( RadSchedulerStringId.WeeklyRecurrenceDay ) , WeekDays.EveryDay );
            weekdays.Add( localizationProvider.GetLocalizedString( RadSchedulerStringId.WeeklyRecurrenceWeekday ) , WeekDays.WorkDays );
            weekdays.Add( localizationProvider.GetLocalizedString( RadSchedulerStringId.WeeklyRecurrenceWeekendDay ) , WeekDays.WeekendDays );
            weekdays.Add( localizationProvider.GetLocalizedString( RadSchedulerStringId.WeeklyRecurrenceMonday ) , WeekDays.Monday );
            weekdays.Add( localizationProvider.GetLocalizedString( RadSchedulerStringId.WeeklyRecurrenceTuesday ) , WeekDays.Tuesday );
            weekdays.Add( localizationProvider.GetLocalizedString( RadSchedulerStringId.WeeklyRecurrenceWednesday ) , WeekDays.Wednesday );
            weekdays.Add( localizationProvider.GetLocalizedString( RadSchedulerStringId.WeeklyRecurrenceThursday ) , WeekDays.Thursday );
            weekdays.Add( localizationProvider.GetLocalizedString( RadSchedulerStringId.WeeklyRecurrenceFriday ) , WeekDays.Friday );
            weekdays.Add( localizationProvider.GetLocalizedString( RadSchedulerStringId.WeeklyRecurrenceSaturday ) , WeekDays.Saturday );
            weekdays.Add( localizationProvider.GetLocalizedString( RadSchedulerStringId.WeeklyRecurrenceSunday ) , WeekDays.Sunday );

            RadComboBox comboBoxWeekdays = ( RadComboBox ) Monthly.Controls[ "cmbWeekDays" ];

            comboBoxWeekdays.Items.Clear( );
            foreach ( KeyValuePair<string , WeekDays> weekday in weekdays )
            {
                RadComboBoxItem item = new RadComboBoxItem( weekday.Key , weekday.Value );
                comboBoxWeekdays.Items.Add( item );
            }

            comboBoxWeekdays.SelectedIndex = 0;
             */ 
        }

        private void RearrangeControlsInDailySettings( ref RadRadioButton radioDaily )
        {
            DailyRecurrenceSettings daily = ( DailyRecurrenceSettings ) this.radioToSettingsDictionary[ radioDaily ];
            daily.Location = new Point( 85 , 40 );

            RadRadioButton radioEveryWeekDay = ( RadRadioButton ) daily.Controls[ "radioEveryWeekDay" ];

            radioEveryWeekDay.Location = new Point( 10 , 36 );
            radioEveryWeekDay.Size = new Size( 150 , 16 );

            RadRadioButton radioEveryDay = ( RadRadioButton ) daily.Controls[ "radioEveryDay" ];

            radioEveryDay.Location = new Point( 10 , 4 );
        }

        private static void RearrangeControlsInGroupBoxRecurrence( ref RadRadioButton radioYearly , ref RadRadioButton radioMonthly , 
                                                                   ref RadRadioButton radioWeekly , ref RadRadioButton radioDaily ,
                                                                   ref RadSeparator separator )
        {
            radioYearly.Size = new Size( 70 , 16 );
            
            radioMonthly.Size = new Size( 70 , 16 );
            
            radioWeekly.Size = new Size( 80 , 16 );
            
            radioDaily.Size = new Size( 70 , 16 );
            
            separator.Location = new Point( 85 , 22 );
        }

        private void RearrangeControlsInGroupBoxRange( )
        {
            RadGroupBox grpRange = ( RadGroupBox ) this.Controls[ "groupBoxRange" ];
            RadDateTimePicker dateStart = ( RadDateTimePicker ) grpRange.Controls[ "dateStart" ];

            dateStart.Location = new Point( 65 , 19 );
            dateStart.Size = new Size( 144 , 20 );

            RadRadioButton radioNoEndDate = ( RadRadioButton ) grpRange.Controls[ "radioNoEndDate" ];

            radioNoEndDate.Size = new Size( 100 , 16 );

            RadRadioButton radioEndAfter = ( RadRadioButton ) grpRange.Controls[ "radioEndAfter" ];

            radioEndAfter.Size = new Size( 80 , 16 );

            RadRadioButton radioEndBy = ( RadRadioButton ) grpRange.Controls[ "radioEndBy" ];

            radioEndBy.Size = new Size( 80 , 16 );

            RadLabel lblOccurrences = ( RadLabel ) grpRange.Controls[ "labelOccurrences" ];

            lblOccurrences.Size = new Size( 80 , 16 );
        }

        private void RearrangeControlsInGroupBoxAppointmentTime( )
        {
            RadGroupBox grpAppointmentTime = ( RadGroupBox ) this.Controls [ "groupBoxAppointmentTime" ];
            RadDateTimePicker timeStart = ( RadDateTimePicker ) grpAppointmentTime.Controls[ "timeStart" ];

            timeStart.Location = new Point( 65 , 19 );
        }

    }
}
