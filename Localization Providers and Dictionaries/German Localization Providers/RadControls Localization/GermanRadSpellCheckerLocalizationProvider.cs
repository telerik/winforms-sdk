using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
	public class GermanRadSpellCheckerLocalizationProvider : RadSpellCheckerLocalizationProvider  
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
				case RadSpellCheckerStringId.Title: return "Rechtschreibung";
				case RadSpellCheckerStringId.OK: return "Bestätigen";
				case RadSpellCheckerStringId.Cancel: return "Abbrechen";
				case RadSpellCheckerStringId.Close: return "Schließen";
				case RadSpellCheckerStringId.Change: return "Ändern";
				case RadSpellCheckerStringId.Complete: return "Die Prüfung der Rechtschreibung ist vollständig.";
				case RadSpellCheckerStringId.AddToDictionary: return "Zum Wörterbuch hinzufügen";
				case RadSpellCheckerStringId.IngoreAll: return "Alle ignorieren";
				case RadSpellCheckerStringId.Suggestions: return "Vorschläge:";
				case RadSpellCheckerStringId.ChangeTo: return "Ändern in:";
				case RadSpellCheckerStringId.NotInDictionary: return "Nicht im Wörterbuch:";
				default:
					MessageBox.Show( string.Format( "GermanRadSpellCheckerLocalizationProvider: Missing Translation for: {0}" , id ) );
                    return base.GetLocalizedString( id );
            }
        }
    }
}
