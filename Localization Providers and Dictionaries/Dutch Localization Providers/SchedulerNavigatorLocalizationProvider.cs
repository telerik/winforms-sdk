using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace ParkmanagerPlanning.Localization
{
    public class CustomSchedulerNavigatorLocalizationProvider : SchedulerNavigatorLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case SchedulerNavigatorStringId.DayViewButtonCaption:
                    {
                        return "Dag";
                    }
                case SchedulerNavigatorStringId.WeekViewButtonCaption:
                    {
                        return "Week";
                    }
                case SchedulerNavigatorStringId.MonthViewButtonCaption:
                    {
                        return "Maand";
                    }
                case SchedulerNavigatorStringId.TimelineViewButtonCaption:
                    {
                        return "Planningsweergave";
                    }
                case SchedulerNavigatorStringId.ShowWeekendCheckboxCaption:
                    {
                        return "Weekend tonen";
                    }
                case SchedulerNavigatorStringId.TodayButtonCaptionToday:
                    {
                        return "Vandaag";
                    }
                case SchedulerNavigatorStringId.TodayButtonCaptionThisWeek:
                    {
                        return "Deze week";
                    }
                case SchedulerNavigatorStringId.TodayButtonCaptionThisMonth:
                    {
                        return "Deze month";
                    }
            }

            throw new Exception("Vertaling niet gevonden: stringId " + id + " basetext: "+  base.GetLocalizedString(id));
        }
    }
}
