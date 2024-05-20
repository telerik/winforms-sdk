using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls;

namespace GermanRadControlsLocalization
{
    public class GermanRadMessageBoxLocalization : RadMessageLocalizationProvider
    {
       public override string GetLocalizedString(string id)
       {
           switch (id)
           {
               case RadMessageStringID.AbortButton: return "Abbrechen";
               case RadMessageStringID.CancelButton: return "Abbrechen";
               case RadMessageStringID.IgnoreButton: return "Ignorieren";
               case RadMessageStringID.NoButton: return "Nein";
               case RadMessageStringID.OKButton: return "OK";
               case RadMessageStringID.RetryButton: return "Wiederholen";
               case RadMessageStringID.YesButton: return "Ja";
               default:
                   return base.GetLocalizedString(id);
           }
       }
    }
}
