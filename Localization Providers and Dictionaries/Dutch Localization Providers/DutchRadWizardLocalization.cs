using Telerik.WinControls.UI;

namespace Localization
{
	public class DutchWizardLocalizationProvider : RadWizardLocalizationProvider
	{
		public override string GetLocalizedString(string id)
		{
			switch (id)
			{
				case RadWizardStringId.BackButtonText:
					return "Vorige";

				case RadWizardStringId.CancelButtonText:
					return "Annuleren";

				case RadWizardStringId.FinishButtonText:
					return "Voltooien";

				case RadWizardStringId.HelpButtonText:
					return "Help";

				case RadWizardStringId.NextButtonText:
					return "Volgende";
			}

			return "";
		}
	}
}