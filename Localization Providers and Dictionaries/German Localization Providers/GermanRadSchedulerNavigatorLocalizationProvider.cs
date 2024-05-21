using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.UI;

namespace GermanRadSchedulerLocalization_Q3_2010
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
                    MessageBox.Show( "GermanRadSchedulerNavigatorLocalizationProvider: Missing Translation for: " + id );
                    break;
            }

            return String.Empty;
        }
    }
}
