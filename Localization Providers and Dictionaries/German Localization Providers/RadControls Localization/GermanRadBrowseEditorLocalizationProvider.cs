using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
	public class GermanRadBrowseEditorLocalizationProvider : RadBrowseEditorLocalizationProvider 
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
				case RadBrowseEditorStringId.None: return "(kein)";
                default:
					MessageBox.Show( string.Format( "GermanRadBrowseEditorLocalizationProvider: Missing Translation for: {0}" , id ) );
                    return base.GetLocalizedString( id );
            }
        }
    }
}
