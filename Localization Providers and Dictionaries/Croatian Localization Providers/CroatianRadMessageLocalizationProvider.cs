using System;
using System.Linq;
using Telerik.WinControls;

namespace CroatianRadControlsLocalization
{
    public class CroatianRadMessageLocalizationProvider : RadMessageLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadMessageStringID.AbortButton: return "Prekini";
                case RadMessageStringID.CancelButton: return "Izbriši";
                case RadMessageStringID.IgnoreButton: return "Ignoriraj";
                case RadMessageStringID.NoButton: return "Ne";
                case RadMessageStringID.OKButton: return "OK";
                case RadMessageStringID.RetryButton: return "Pokušaj ponovno";
                case RadMessageStringID.YesButton: return "Da";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}
