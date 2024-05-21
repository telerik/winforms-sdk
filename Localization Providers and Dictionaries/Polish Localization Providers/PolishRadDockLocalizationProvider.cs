using Telerik.WinControls.UI.Localization;
public class PolishRadDockLocalizationProvider : RadDockLocalizationProvider
{
    public override string GetLocalizedString(string id)
    {
        switch (id)
        {
            case RadDockStringId.ContextMenuAutoHide:
                return "Autoukrywanie";
            case RadDockStringId.ContextMenuCancel:
                return "Anuluj";
            case RadDockStringId.ContextMenuClose:
                return "Zamknij";
            case RadDockStringId.ContextMenuCloseAll:
                return "Zamknij wszystkie";
            case RadDockStringId.ContextMenuCloseAllButThis:
                return "Zamknij wszystkie poza biezacym";
            case RadDockStringId.ContextMenuDockable:
                return "Dokowalne";
            case RadDockStringId.ContextMenuFloating:
                return "Plywajace";
            case RadDockStringId.ContextMenuHide:
                return "Ukryj";
            case RadDockStringId.ContextMenuMoveToNextTabGroup:
                return "Przenies do kolejnej grupy kart";
            case RadDockStringId.ContextMenuMoveToPreviousTabGroup:
                return "Przenies do poprzedniej grupy kart";
            case RadDockStringId.ContextMenuNewHorizontalTabGroup:
                return "Nowa pozioma grupa kart";
            case RadDockStringId.ContextMenuNewVerticalTabGroup:
                return "Nowa pionowa grupa kart";
            case RadDockStringId.ContextMenuTabbedDocument:
                return "Dokument w karcie";
            case RadDockStringId.DocumentTabStripCloseButton:
                return "Zamknij dokument";
            case RadDockStringId.DocumentTabStripListButton:
                return "Aktywne dokumenty";
            case RadDockStringId.ToolTabStripCloseButton:
                return "Zamknij okno";
            case RadDockStringId.ToolTabStripDockStateButton:
                return "Stan okna";
            case RadDockStringId.ToolTabStripPinButton:
                return "Zadokuj";
            case RadDockStringId.ToolTabStripUnpinButton:
                return "Autoukrywanie";
        }
 
        return string.Empty;
    }
}