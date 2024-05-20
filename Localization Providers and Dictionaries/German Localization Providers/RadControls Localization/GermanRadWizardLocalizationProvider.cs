using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public class GermanRadWizardLocalizationProvider : RadWizardLocalizationProvider 
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadWizardStringId.BackButtonText: return "<   Zurück";
                case RadWizardStringId.NextButtonText: return "Weiter   >";
                case RadWizardStringId.CancelButtonText: return "Abbrechen";
                case RadWizardStringId.FinishButtonText: return "Beenden";
                case RadWizardStringId.HelpButtonText: return "<html><u>Hilfe</u></html>";
                default:
                    MessageBox.Show( string.Format( "GermanRadWizardLocalizationProvider: Missing Translation for: {0}" , id ) );
                    return base.GetLocalizedString( id );
            }
        }
    }
}
