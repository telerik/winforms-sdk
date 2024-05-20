using System;
using System.Linq;
using Telerik.WinControls.UI.Localization;

namespace CroatianRadControlsLocalization
{
    public class CroatianDockLocalizationProvider : RadDockLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadDockStringId.ContextMenuFloating:
                    return "Plutajuće";
                case RadDockStringId.ContextMenuDockable:
                    return "Usidrivo";
                case RadDockStringId.ContextMenuTabbedDocument:
                    return "Kartični dokument";
                case RadDockStringId.ContextMenuAutoHide:
                    return "Automatski sakrij";
                case RadDockStringId.ContextMenuHide:
                    return "Sakrij";
                case RadDockStringId.ContextMenuClose:
                    return "Zatvori";
                case RadDockStringId.ContextMenuCloseAll:
                    return "Zatvori sve";
                case RadDockStringId.ContextMenuCloseAllButThis:
                    return "Zatvori sve osim ovoga";
                case RadDockStringId.ContextMenuMoveToPreviousTabGroup:
                    return "Pomakni na prethodnu grupu kartica";
                case RadDockStringId.ContextMenuMoveToNextTabGroup:
                    return "Pomakni u slijedeću grupu kartica";
                case RadDockStringId.ContextMenuNewHorizontalTabGroup:
                    return "Nova horizontalna grupa kartica";
                case RadDockStringId.ContextMenuNewVerticalTabGroup:
                    return "Nova vertikalna grupa kartica";
                case RadDockStringId.ToolTabStripCloseButton:
                    return "Zatvori prozor";
                case RadDockStringId.ToolTabStripDockStateButton:
                    return "Stanje prozora";
                case RadDockStringId.ToolTabStripUnpinButton:
                    return "Automatski sakrij";
                case RadDockStringId.ToolTabStripPinButton:
                    return "Usidreno";
                case RadDockStringId.DocumentTabStripCloseButton:
                    return "Zatvori dokument";
                case RadDockStringId.DocumentTabStripListButton:
                    return "Aktivni dokumenti";
            }

            return string.Empty;
        }
    }
}
