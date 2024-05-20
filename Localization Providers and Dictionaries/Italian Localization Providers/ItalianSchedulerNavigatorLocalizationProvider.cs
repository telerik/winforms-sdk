using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace LocProviders
{
    public class ItalianSchedulerNavigatorLocalizationProvider : SchedulerNavigatorLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case SchedulerNavigatorStringId.DayViewButtonCaption:
                    return "Giornaliero";
                case SchedulerNavigatorStringId.WeekViewButtonCaption:
                    return "Settimanale";
                case SchedulerNavigatorStringId.MonthViewButtonCaption:
                    return "Mensile";
                case SchedulerNavigatorStringId.ShowWeekendCheckboxCaption:
                    return "Vedi Fine Settimana";
            }

            System.Diagnostics.Debug.WriteLine("SCHEDNAV:" + id);
            return String.Empty;
        }
    }
}
