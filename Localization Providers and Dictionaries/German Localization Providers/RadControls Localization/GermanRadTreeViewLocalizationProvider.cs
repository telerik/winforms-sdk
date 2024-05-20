using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public class GermanRadTreeViewLocalizationProvider : TreeViewLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case TreeViewStringId.ContextMenuCollapse:
                    return "Reduzieren";
                case TreeViewStringId.ContextMenuDelete:
                    return "Löschen";
                case TreeViewStringId.ContextMenuEdit:
                    return "Umbenennen";
                case TreeViewStringId.ContextMenuExpand:
                    return "Erweitern";
                case TreeViewStringId.ContextMenuNew:
                    return "Neu";
                case TreeViewStringId.ContextMenuCopy:
                    return "Kopieren";
                case TreeViewStringId.ContextMenuCut:
                    return "Ausschneiden";
                case TreeViewStringId.ContextMenuPaste:
                    return "Einfügen";
                default:
                    MessageBox.Show( string.Format( "GermanRadTreeViewLocalizationProvider: Missing Translation for: {0}" , id ) );
                    return base.GetLocalizedString( id );
            }
        }
    }
}
