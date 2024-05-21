using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public class SchedulerOutlookLikeAppointment : Appointment
    {
        private string _email = string.Empty;

        public SchedulerOutlookLikeAppointment( )
        {
        }

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                if ( this._email != value )
                {
                    this._email = value;
                    this.OnPropertyChanged( "Email" );
                }
            }
        }

        protected override Event CreateOccurrenceInstance( )
        {
            SchedulerOutlookLikeAppointment occurrence = new SchedulerOutlookLikeAppointment
                                                            {
                                                                _email = this._email
                                                            };


            return occurrence;
        }
    }
}
