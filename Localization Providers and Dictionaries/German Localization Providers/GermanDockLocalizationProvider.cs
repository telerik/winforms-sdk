using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI.Localization;

namespace GermanRadDockLocalization
{
    /// <summary>
    /// German RadDockLocalizationProvider
    /// </summary>
    class GermanDockLocalizationProvider : RadDockLocalizationProvider
    {
        public override string GetLocalizedString( string id )
        {
            switch ( id )
            {
                case RadDockStringId.ContextMenuAutoHide:
                    return "Automatisch im Hintergrund";
                case RadDockStringId.ContextMenuCancel:
                    return "Abbrechen";
                case RadDockStringId.ContextMenuClose:
                    return "Schließen";
                case RadDockStringId.ContextMenuCloseAll:
                    return "Alle schließen";
                case RadDockStringId.ContextMenuCloseAllButThis:
                    return "Alle außer diesem schließen";
                case RadDockStringId.ContextMenuDockable:
                    return "Andockbar";
                case RadDockStringId.ContextMenuFloating:
                    return "Unverankert";
                case RadDockStringId.ContextMenuHide:
                    return "Ausblenden";
                case RadDockStringId.ContextMenuMoveToNextTabGroup:
                    return "In nächste Registerkartengruppe verschieben";
                case RadDockStringId.ContextMenuMoveToPreviousTabGroup:
                    return "In vorherige Registerkartengruppe verschieben";
                case RadDockStringId.ContextMenuNewHorizontalTabGroup:
                    return "Neue horizontale Registerkartengruppe";
                case RadDockStringId.ContextMenuNewVerticalTabGroup:
                    return "Neue vertikale Registerkartengruppe";
                case RadDockStringId.ContextMenuTabbedDocument:
                    return "Dokument im Registerkartenformat";
                default:
                    //MessageBox.Show( id );
                    return base.GetLocalizedString( id );
            }
        }
    }
}
