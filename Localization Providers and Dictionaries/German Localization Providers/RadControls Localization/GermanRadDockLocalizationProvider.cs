using Telerik.WinControls.UI.Localization;
using System.Windows.Forms;

namespace GermanRadControlsLocalization
{
    public class GermanRadDockLocalizationProvider : RadDockLocalizationProvider
    {
        public override string GetLocalizedString( string id )
        {
            switch ( id )
            {
				case RadDockStringId.ContextMenuFloating:
					return "Verankerung aufheben";
				case RadDockStringId.ContextMenuDockable:
					return "Andocken";
				case RadDockStringId.ContextMenuTabbedDocument:
					return "Als Dokument im Registerkartenformat andocken";
				case RadDockStringId.ContextMenuAutoHide:
                    return "Automatisch im Hintergrund";
				case RadDockStringId.ContextMenuHide:
					return "Ausblenden";
				//case RadDockStringId.ContextMenuCancel:
                //    return "Abbrechen";
                case RadDockStringId.ContextMenuClose:
                    return "Schließen";
                case RadDockStringId.ContextMenuCloseAll:
                    return "Alle schließen";
                case RadDockStringId.ContextMenuCloseAllButThis:
                    return "Alle außer diesem schließen";
				case RadDockStringId.ContextMenuMoveToPreviousTabGroup:
					return "In vorherige Registerkartengruppe verschieben";
				case RadDockStringId.ContextMenuMoveToNextTabGroup:
                    return "In nächste Registerkartengruppe verschieben";
                case RadDockStringId.ContextMenuNewHorizontalTabGroup:
                    return "Neue horizontale Registerkartengruppe";
                case RadDockStringId.ContextMenuNewVerticalTabGroup:
                    return "Neue vertikale Registerkartengruppe";
                case RadDockStringId.ToolTabStripCloseButton:
                    return "Schließen";
                case RadDockStringId.ToolTabStripDockStateButton:
                    return "Position des Fensters";
                case RadDockStringId.ToolTabStripPinButton:
                    return "Automatisch im Hintergrund";
                case RadDockStringId.ToolTabStripUnpinButton:
					return "Automatisch im Hintergrund";
				case RadDockStringId.DocumentTabStripCloseButton:
					return "Schließen";
				case RadDockStringId.DocumentTabStripListButton:
					return "Liste der offenen Registerkarten";
				default:
                    MessageBox.Show( string.Format( "GermanRadDockLocalizationProvider: Missing Translation for: {0}" , id ) );
                    return base.GetLocalizedString( id );
            }
        }
    }
}
