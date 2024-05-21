using Telerik.WinControls.UI;

namespace Psz.LoginokNet.Localization
{
    class MyRadSchedulerNavigatorLocalizationProviderHUN : SchedulerNavigatorLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case SchedulerNavigatorStringId.DayViewButtonCaption: return "Napi nézet"; //"Day View";
                case SchedulerNavigatorStringId.WeekViewButtonCaption: return "Heti nézet"; //"Week View";
                case SchedulerNavigatorStringId.MonthViewButtonCaption: return "Havi nézet"; //"Month View";
                case SchedulerNavigatorStringId.TimelineViewButtonCaption: return "Idővonal nézet"; //"Timeline View";
                case SchedulerNavigatorStringId.ShowWeekendCheckboxCaption: return "Hétvége mutatása"; //"Show Weekend";
                case SchedulerNavigatorStringId.TodayButtonCaptionToday: return "Ma"; //"Today";
                case SchedulerNavigatorStringId.TodayButtonCaptionThisWeek: return "Aktuális hét"; //"This week";
                case SchedulerNavigatorStringId.TodayButtonCaptionThisMonth: return "Aktuális hónap"; //"This month";
                    
            }
            return string.Empty;
        }
    }
}
