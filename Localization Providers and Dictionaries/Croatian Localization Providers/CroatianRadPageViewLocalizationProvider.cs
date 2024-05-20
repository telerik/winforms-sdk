using System;
using System.Linq;
using Telerik.WinControls.UI;

namespace CroatianRadControlsLocalization
{
    public class CroatianRadPageViewLocalizationProvider : RadPageViewLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadPageViewStringId.CloseButtonTooltip:
                    return "Zatvori odabranu stranicu";
                case RadPageViewStringId.ItemListButtonTooltip:
                    return "Dostupne stranice";
                case RadPageViewStringId.LeftScrollButtonTooltip:
                    return "Pomakni lijevo";
                case RadPageViewStringId.RightScrollButtonTooltip:
                    return "Pomakni desno";
                case RadPageViewStringId.ShowMoreButtonsItemCaption:
                    return "Prikaži više dugmi";
                case RadPageViewStringId.ShowFewerButtonsItemCaption:
                    return "Prikaži manje dugmi";
                case RadPageViewStringId.AddRemoveButtonsItemCaption:
                    return "Dodaj ili ukloni dugme";
                case RadPageViewStringId.ItemCloseButtonTooltip:
                    return "Zatvori stranicu";
                case RadPageViewStringId.NewItemTooltipText:
                    return "Dodaj novu stranicu";
            }

            return base.GetLocalizedString(id);
        }
    }
}
