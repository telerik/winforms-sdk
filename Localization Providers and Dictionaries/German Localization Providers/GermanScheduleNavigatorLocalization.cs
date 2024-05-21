using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.UI;

namespace GermanRadSchedulerLocalization
{    
    public class GermanScheduleNavigatorLocalization : SchedulerNavigatorLocalizationProvider
    {
        public override string GetLocalizedString( string id )
        {
            switch ( id )
            {
                case SchedulerNavigatorStringId.DayViewButtonCaption:
                    {
                        return "Tag";
                    }
                case SchedulerNavigatorStringId.MonthViewButtonCaption:
                    {
                        return "Monat";
                    }
                case SchedulerNavigatorStringId.ShowWeekendCheckboxCaption:
                    {
                        return "Volle Woche anzeigen";
                    }
                case SchedulerNavigatorStringId.WeekViewButtonCaption:
                    {
                        return "Woche";
                    }
            }

            return String.Empty;
        }
    }
}