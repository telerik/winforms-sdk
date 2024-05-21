using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public class GermanRadPropertyGridLocalizationProvider : PropertyGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case PropertyGridStringId.ContextMenuReset: return "Zurücksetzen";
                case PropertyGridStringId.ContextMenuEdit: return "Editieren";
                case PropertyGridStringId.ContextMenuExpand: return "Erweitern";
                case PropertyGridStringId.ContextMenuCollapse: return "Reduzieren";
                case PropertyGridStringId.ContextMenuShowDescription: return "Zeige Beschreibung";
                case PropertyGridStringId.ContextMenuShowToolbar: return "Zeige Werkzeugleiste";

                case PropertyGridStringId.ContextMenuSort: return "Sortieren";
                case PropertyGridStringId.ContextMenuNoSort: return "Keine Sortierung";
                case PropertyGridStringId.ContextMenuAlphabetical: return "Alphabetisch";
                case PropertyGridStringId.ContextMenuCategorized: return "Nach Kategorien";
                case PropertyGridStringId.ContextMenuCategorizedAlphabetical: return "In Kategorien alphabetisch";
                default:
                    MessageBox.Show( string.Format( "GermanRadPropertyGridLocalizationProvider: Missing Translation for: {0} {1}" , 
                                                        id , base.GetLocalizedString( id )) );

                    return base.GetLocalizedString( id );
            }
        }
    }
}
