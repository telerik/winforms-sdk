using System;
using System.Linq;
using Telerik.WinControls.UI;

namespace CroatianRadControlsLocalization
{
    public class CroatianWizardLocalizationProvider : RadWizardLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadWizardStringId.BackButtonText: return "Nazad";
                case RadWizardStringId.NextButtonText: return "Sljedeće";
                case RadWizardStringId.CancelButtonText: return "Otkaži";
                case RadWizardStringId.FinishButtonText: return "Završi";
                case RadWizardStringId.HelpButtonText: return "<html><u>Pomoć</u></html>";
                default: return string.Empty;
            }
        }
    }
}
