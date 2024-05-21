using Telerik.WinControls.UI;

namespace Localization
{
	public class DutchColorDialogLocalizationProvider : ColorDialogLocalizationProvider
	{
		public override string GetLocalizedString(string id)
		{
			switch (id)
			{
				//localizing the static strings
				case ColorDialogStringId.ColorDialogProfessionalTab: return "Professioneel";
				case ColorDialogStringId.ColorDialogWebTab: return "Web";
				case ColorDialogStringId.ColorDialogSystemTab: return "Systeem";
				case ColorDialogStringId.ColorDialogBasicTab: return "Standaard";
				case ColorDialogStringId.ColorDialogAddCustomColorButton: return "Aangepaste kleur toevoegen";
				case ColorDialogStringId.ColorDialogOKButton: return "OK";
				case ColorDialogStringId.ColorDialogCancelButton: return "Annuleren";
				case ColorDialogStringId.ColorDialogNewColorLabel: return "Nieuw";
				case ColorDialogStringId.ColorDialogCurrentColorLabel: return "Huidig";
				case ColorDialogStringId.ColorDialogCaption: return "Kleuren bewerken";
				
				//you can also localize the names of the colors
				/*case "Black": return "Localized Black";
				case "Blue": return "Localized Blue";
				case "Aqua": return "Localized Aqua";*/

				default:
					return base.GetLocalizedString(id);
				
			}
		}
	}
}