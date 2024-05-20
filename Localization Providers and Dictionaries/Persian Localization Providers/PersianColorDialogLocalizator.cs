using Telerik.WinControls.UI;

namespace Localization
{
	public class PersianLocalizator : ColorDialogLocalizationProvider
	{
		public override string GetLocalizedString(string id)
		{
			switch (id)
			{
				//localizing the static strings
				case ColorDialogStringId.ColorDialogProfessionalTab: return "رنگ های حرفه ای";
				case ColorDialogStringId.ColorDialogWebTab: return "رنگ های وب";
				case ColorDialogStringId.ColorDialogSystemTab: return "رنگ های سیستمی";
				case ColorDialogStringId.ColorDialogBasicTab: return "رنگ های سیستمی";
				case ColorDialogStringId.ColorDialogAddCustomColorButton: return "اضافه به لیست علایق";
				case ColorDialogStringId.ColorDialogOKButton: return "تایید";
				case ColorDialogStringId.ColorDialogCancelButton: return "انصراف";
				case ColorDialogStringId.ColorDialogNewColorLabel: return "جدید";
				case ColorDialogStringId.ColorDialogCurrentColorLabel: return "فعلی";
				case ColorDialogStringId.ColorDialogCaption: return "انتخاب رنگ";

				
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