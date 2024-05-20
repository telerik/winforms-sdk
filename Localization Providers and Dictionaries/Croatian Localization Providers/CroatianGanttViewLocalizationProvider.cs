using System;
using System.Linq;
using Telerik.WinControls.UI;

namespace CroatianRadControlsLocalization
{
    public class CroatianGanttViewLocalizationProvider : GanttViewLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case GanttViewStringId.ContextMenuAdd:
                    return "Dodaj";
                case GanttViewStringId.ContextMenuAddChild:
                    return "Dodaj dijete";
                case GanttViewStringId.ContextMenuAddSibling:
                    return "Dodaj rođaka";
                case GanttViewStringId.ContextMenuDelete:
                    return "Obriši";
                case GanttViewStringId.ContextMenuProgress:
                    return "Progres";
                case "TimelineWeek":
                    return "Tjedan";
            }

            return string.Empty;
        }
    }
}
