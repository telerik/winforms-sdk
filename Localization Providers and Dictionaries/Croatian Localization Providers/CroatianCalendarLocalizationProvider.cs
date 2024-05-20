using System;
using System.Linq;
using Telerik.WinControls.UI;

namespace CroatianRadControlsLocalization
{
    public class CroatianCalendarLocalizationProvider : CalendarLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case CalendarStringId.CalendarClearButton:
                    return "Zatvori";
                case CalendarStringId.CalendarTodayButton:
                    return "Danas";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}
