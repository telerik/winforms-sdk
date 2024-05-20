using System;
using System.Linq;
using Telerik.WinControls.UI;

namespace CroatianRadControlsLocalization
{
    public class CroatianCommandBarLocalizationProvider : CommandBarLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case CommandBarStringId.CustomizeDialogChooseToolstripLabelText: return "Izaberite alatnu traku za preuređenje";
                case CommandBarStringId.CustomizeDialogCloseButtonText: return "Zatvori";
                case CommandBarStringId.CustomizeDialogItemsPageTitle: return "Stavke";
                case CommandBarStringId.CustomizeDialogMoveDownButtonText: return "Pomakni dolje";
                case CommandBarStringId.CustomizeDialogMoveUpButtonText: return "Pomakni gore";
                case CommandBarStringId.CustomizeDialogResetButtonText: return "Reset";
                case CommandBarStringId.CustomizeDialogTitle: return "Prilagodi";
                case CommandBarStringId.CustomizeDialogToolstripsPageTitle: return "Alatne trake";
                case CommandBarStringId.OverflowMenuAddOrRemoveButtonsText: return "Dodaj ili ukloni dugme";
                case CommandBarStringId.OverflowMenuCustomizeText: return "Prilagodi...";
                case CommandBarStringId.ContextMenuCustomizeText: return "Prilagodi...";
                default: return base.GetLocalizedString(id);
            }
        }
    }
}
