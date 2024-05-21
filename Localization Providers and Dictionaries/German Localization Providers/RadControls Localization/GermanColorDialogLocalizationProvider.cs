using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public class GermanColorDialogLocalizationProvider : ColorDialogLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case ColorDialogStringId.ColorDialogProfessionalTab: return "Benutzerdefiniert";
                case ColorDialogStringId.ColorDialogWebTab: return "Web";
                case ColorDialogStringId.ColorDialogSystemTab: return "System";
                case ColorDialogStringId.ColorDialogBasicTab: return "Standard";
                case ColorDialogStringId.ColorDialogAddCustomColorButton: return "Farbe hinzufügen";
                case ColorDialogStringId.ColorDialogOKButton: return "Bestätigen";
                case ColorDialogStringId.ColorDialogCancelButton: return "Abbrechen";
                case ColorDialogStringId.ColorDialogNewColorLabel: return "Neu";
                case ColorDialogStringId.ColorDialogCurrentColorLabel: return "Aktuell";
                case ColorDialogStringId.ColorDialogCaption: return "Farben";
                default:
                    //MessageBox.Show( string.Format( "GermanColorDialogLocalizationProvider: Missing Translation for: {0}" , id ) );
                    return base.GetLocalizedString( id );
            }
        }
    }
}
