using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
	public class GermanRadTextBoxLocalizationProvider : TextBoxControlLocalizationProvider  
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
				case TextBoxControlStringId.ContextMenuCopy: return "Kopieren";
				case TextBoxControlStringId.ContextMenuCut: return "Ausschneiden";
				case TextBoxControlStringId.ContextMenuPaste: return "Einfügen";
				case TextBoxControlStringId.ContextMenuDelete: return "Löschen";
				case TextBoxControlStringId.ContextMenuSelectAll: return "Alle auswählen";
				default:
					MessageBox.Show( string.Format( "GermanRadTextBoxLocalizationProvider: Missing Translation for: {0}" , id ) );
                    return base.GetLocalizedString( id );
            }
        }
    }
}
