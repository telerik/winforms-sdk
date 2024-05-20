using Telerik.WinControls;

namespace Localization
{
	public class RadMessagePersianLocalizator : RadMessageLocalizationProvider
	{
		public override string GetLocalizedString(string id)
		{
			switch (id)
			{
				//localizing the static strings
                case RadMessageStringID.AbortButton: return "انصراف";
                case RadMessageStringID.CancelButton: return "انصراف";
                case RadMessageStringID.IgnoreButton: return "نادیده گرفتن";
                case RadMessageStringID.NoButton: return "خیر";
                case RadMessageStringID.OKButton: return "تایید";
                case RadMessageStringID.RetryButton: return "تلاش مجدد";
                case RadMessageStringID.YesButton: return "بله";

				default:
					return base.ToString();
			}
		}
	}
}