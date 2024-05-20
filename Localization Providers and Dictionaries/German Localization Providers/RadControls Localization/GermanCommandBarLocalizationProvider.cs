using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public class GermanCommandBarLocalizationProvider : CommandBarLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case CommandBarStringId.CustomizeDialogChooseToolstripLabelText: return "Wähle eine neu anzuordnende Symbolleiste:";
                case CommandBarStringId.CustomizeDialogCloseButtonText: return "Schließen";
                case CommandBarStringId.CustomizeDialogItemsPageTitle: return "Befehle auswählen";
                case CommandBarStringId.CustomizeDialogMoveDownButtonText: return "Nach unten";
                case CommandBarStringId.CustomizeDialogMoveUpButtonText: return "Nach oben";
                case CommandBarStringId.CustomizeDialogResetButtonText: return "Zurücksetzen";
                case CommandBarStringId.CustomizeDialogTitle: return "Symbolleisten anpassen";
                case CommandBarStringId.CustomizeDialogToolstripsPageTitle: return "Symbolleisten";
                case CommandBarStringId.OverflowMenuAddOrRemoveButtonsText:return "Schaltflächen hinzufügen oder entfernen";
                case CommandBarStringId.OverflowMenuCustomizeText: return "Anpassen...";
                case CommandBarStringId.ContextMenuCustomizeText: return "Anpassen...";                   
                default:
                    MessageBox.Show( string.Format( "GermanCommandBarLocalizationProvider: Missing Translation for: {0}" , id ) );
                    return base.GetLocalizedString( id );
            }
        }
    }
}
