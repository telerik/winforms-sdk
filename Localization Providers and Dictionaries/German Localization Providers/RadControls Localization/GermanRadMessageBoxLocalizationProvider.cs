using System.Windows.Forms;
using Telerik.WinControls;

namespace GermanRadControlsLocalization
{
    public class GermanRadMessageBoxLocalizationProvider : RadMessageLocalizationProvider
    {
       public override string GetLocalizedString(string id)
       {
           switch (id)
           {
               case RadMessageStringID.AbortButton: return "Abbrechen";
               case RadMessageStringID.CancelButton: return "Abbrechen";
               case RadMessageStringID.IgnoreButton: return "Ignorieren";
               case RadMessageStringID.NoButton: return "Nein";
               case RadMessageStringID.OKButton: return "Bestätigen";
               case RadMessageStringID.RetryButton: return "Wiederholen";
               case RadMessageStringID.YesButton: return "Ja";                 
               default:
                   MessageBox.Show( string.Format( "GermanRadMessageBoxLocalizationProvider: Missing Translation for: {0}" , id ) );
                   return base.GetLocalizedString(id);
           }
       }
    }
}
