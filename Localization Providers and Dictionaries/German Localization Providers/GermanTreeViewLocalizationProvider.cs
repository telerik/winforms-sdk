using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public class GermanTreeViewLocalizationProvider : TreeViewLocalizationProvider
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
            }

            return string.Empty;
        }
    }
}
