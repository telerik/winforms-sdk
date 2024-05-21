using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace LocProviders
{
    public class ItalianTreeViewLocalizationProvider : TreeViewLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case TreeViewStringId.ContextMenuCollapse:
                    return "Comprimi";
                case TreeViewStringId.ContextMenuDelete:
                    return "Cancella";
                case TreeViewStringId.ContextMenuEdit:
                    return "Modifica";
                case TreeViewStringId.ContextMenuExpand:
                    return "Espandi";
                case TreeViewStringId.ContextMenuNew:
                    return "Nuovo";
            }

            System.Diagnostics.Debug.WriteLine("TREEVIEW:" + id);
            return string.Empty;
        }
    }
}
