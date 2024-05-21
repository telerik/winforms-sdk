using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public class SchedulerCustomAppointmentFactory : IAppointmentFactory
    {
        #region IAppointmentFactory Members

        public IEvent CreateNewAppointment( )
        {
            return new SchedulerOutlookLikeAppointment();
        }

        #endregion
    }
}
