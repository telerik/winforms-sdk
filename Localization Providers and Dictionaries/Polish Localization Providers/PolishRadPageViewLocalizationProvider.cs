using Telerik.WinControls.UI;

public class PolishRadPageViewLocalizationProvider: RadPageViewLocalizationProvider
{
    public override string GetLocalizedString(string id)
    {
        switch (id)
        {
            case RadPageViewStringId.AddRemoveButtonsItemCaption:
                return "Dodaj lub usun przyciski";
            case RadPageViewStringId.CloseButtonTooltip:
                return "Zamknij wybrana strone";
            case RadPageViewStringId.CloseSelectedPageCaption:
                return "Zamknij wybrana strone";
            case RadPageViewStringId.ItemCloseButtonTooltip:
                return "Zamknij strone";
            case RadPageViewStringId.ItemListButtonTooltip:
                return "Dostepne strony";
            case RadPageViewStringId.LeftScrollButtonTooltip:
                return "Przewin w lewo";
            case RadPageViewStringId.NewItemTooltipText:
                return "Dodaj nowa strone";
            case RadPageViewStringId.RightScrollButtonTooltip:
                return "Przewin w prawo";
            case RadPageViewStringId.ScrollStripLeftCaption:
                return "Przewin w lewo";
            case RadPageViewStringId.ScrollStripRightCaption:
                return "Przewin w prawo";
            case RadPageViewStringId.ShowFewerButtonsItemCaption:
                return "Pokazuj mniej przycisków";
            case RadPageViewStringId.ShowMoreButtonsItemCaption:
                return "Pokazuj wiecej przycisków";
        }
 
        return string.Empty;
    }
}