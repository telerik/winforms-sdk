using System;
using System.Linq;
using Telerik.WinControls.UI;

namespace CroatianRadControlsLocalization
{
    public class CroatianTreeViewLocalizationProvider : TreeViewLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case TreeViewStringId.ContextMenuCollapse:
                    return "Zatvori";
                case TreeViewStringId.ContextMenuDelete:
                    return "Obriši";
                case TreeViewStringId.ContextMenuEdit:
                    return "Izmjeni";
                case TreeViewStringId.ContextMenuExpand:
                    return "Proširi";
                case TreeViewStringId.ContextMenuNew:
                    return "Novi";
            }

            return "";
        }
    }
}
