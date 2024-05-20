using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI.Localization;

namespace LocProviders
{
    public class ItalianDockLocalizationProvider : RadDockLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadDockStringId.ContextMenuFloating:
                    return "Distacca";
                case RadDockStringId.ContextMenuDockable:
                    return "Attacca";
                case RadDockStringId.ContextMenuTabbedDocument:
                    return "Documento a Pagine";
                case RadDockStringId.ContextMenuAutoHide:
                    return "Nascondi automaticamente";
                case RadDockStringId.ContextMenuHide:
                    return "Nascondi";
                case RadDockStringId.ContextMenuClose:
                    return "Chiudi";
                case RadDockStringId.ContextMenuCloseAll:
                    return "Chiudi tutto";
                case RadDockStringId.ContextMenuCloseAllButThis:
                    return "Chiudi tutto tranne questa";
                case RadDockStringId.ContextMenuMoveToPreviousTabGroup:
                    return "Sposta nel gruppo pagine precedente";
                case RadDockStringId.ContextMenuMoveToNextTabGroup:
                    return "Sposta nel gruppo pagine successivo";
                case RadDockStringId.ContextMenuNewHorizontalTabGroup:
                    return "Nuovo gruppo pagine orizzontale";
                case RadDockStringId.ContextMenuNewVerticalTabGroup:
                    return "Nuovo gruppo pagine verticale";
            }

            System.Diagnostics.Debug.WriteLine("DOCKING:" + id);
            return string.Empty;
        }
    }
}
