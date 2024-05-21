using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls;

namespace Guardian.Dan.Presentation.Localization
{
    public class HebrewMessageLocalizationProvider : RadMessageLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadMessageStringID.AbortButton: return "הפסק";
                case RadMessageStringID.CancelButton: return "בטל";
                case RadMessageStringID.IgnoreButton: return "התעלם";
                case RadMessageStringID.NoButton: return "לא";
                case RadMessageStringID.OKButton: return "אשר";
                case RadMessageStringID.RetryButton: return "נסה שנית";
                case RadMessageStringID.YesButton: return "כן";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}
