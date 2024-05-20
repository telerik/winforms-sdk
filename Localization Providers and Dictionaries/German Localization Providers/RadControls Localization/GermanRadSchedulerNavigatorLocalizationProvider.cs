using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public class GermanRadSchedulerNavigatorLocalizationProvider : SchedulerNavigatorLocalizationProvider
    {
        public override string GetLocalizedString( string id )
        {
            switch ( id )
            {
                case SchedulerNavigatorStringId.DayViewButtonCaption:
                        return "Tag";
                case SchedulerNavigatorStringId.MonthViewButtonCaption:
                        return "Monat";
                case SchedulerNavigatorStringId.ShowWeekendCheckboxCaption:
                        return "Volle Woche anzeigen";
                case SchedulerNavigatorStringId.TimelineViewButtonCaption:
                        return "Zeitreihe";
                case SchedulerNavigatorStringId.TodayButtonCaptionThisMonth:
                        return "Dieser Monat";
                case SchedulerNavigatorStringId.TodayButtonCaptionThisWeek:
                        return "Diese Woche";
                case SchedulerNavigatorStringId.TodayButtonCaptionToday:
                        return "Heute";
                case SchedulerNavigatorStringId.WeekViewButtonCaption:
                        return "Woche";
                default:
                    MessageBox.Show( string.Format( "GermanRadSchedulerNavigatorLocalizationProvider: Missing Translation for: {0}" , id ) );
                    return base.GetLocalizedString( id );
            }
        }
    }
}
