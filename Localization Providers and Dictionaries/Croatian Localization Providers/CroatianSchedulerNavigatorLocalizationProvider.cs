using System;
using System.Linq;
using Telerik.WinControls.UI;

namespace CroatianRadControlsLocalization
{
    public class CroatianSchedulerNavigatorLocalizationProvider : SchedulerNavigatorLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case SchedulerNavigatorStringId.DayViewButtonCaption:
                    {
                        return "Dan";
                    }
                case SchedulerNavigatorStringId.WeekViewButtonCaption:
                    {
                        return "Tjedan";
                    }
                case SchedulerNavigatorStringId.MonthViewButtonCaption:
                    {
                        return "Mjesec";
                    }
                case SchedulerNavigatorStringId.TimelineViewButtonCaption:
                    {
                        return "Vremenska linija";
                    }
                case SchedulerNavigatorStringId.ShowWeekendCheckboxCaption:
                    {
                        return "Prikaži vikend";
                    }
                case SchedulerNavigatorStringId.TodayButtonCaptionToday:
                    {
                        return "Danas";
                    }
                case SchedulerNavigatorStringId.TodayButtonCaptionThisWeek:
                    {
                        return "Ovaj tjedan";
                    }
                case SchedulerNavigatorStringId.TodayButtonCaptionThisMonth:
                    {
                        return "Ovaj mjesec";
                    }
            }

            return String.Empty;
        }
    }
}
