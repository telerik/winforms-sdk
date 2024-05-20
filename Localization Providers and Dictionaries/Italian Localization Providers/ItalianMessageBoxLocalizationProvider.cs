using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;

namespace LocProviders
{
    public class ItalianMessageBoxLocalizationProvider : RadMessageLocalizationProvider 
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadMessageStringID.AbortButton: return "Interrompi";
                case RadMessageStringID.CancelButton: return "Annulla";
                case RadMessageStringID.IgnoreButton: return "Ignora";
                case RadMessageStringID.NoButton: return "No";
                case RadMessageStringID.OKButton: return "OK";
                case RadMessageStringID.RetryButton: return "Riprova";
                case RadMessageStringID.YesButton: return "Sì";
            }

            System.Diagnostics.Debug.WriteLine("MSGBOX:" + id);
            return string.Empty;
        }
    }
}
