using Telerik.WinControls;

namespace Psz.LoginokNet.Localization
{
    class MyRadMessageBoxLocalizationProviderHUN : RadMessageLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadMessageStringID.AbortButton: return "Leállítás";
                case RadMessageStringID.CancelButton: return "Mégsem";
                case RadMessageStringID.IgnoreButton: return "Kihagyás";
                case RadMessageStringID.NoButton: return "Nem";
                case RadMessageStringID.OKButton: return "OK";
                case RadMessageStringID.RetryButton: return "Ismét";
                case RadMessageStringID.YesButton: return "Igen";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}

   