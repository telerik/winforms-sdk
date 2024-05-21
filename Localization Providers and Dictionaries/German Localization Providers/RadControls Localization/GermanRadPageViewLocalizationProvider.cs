using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public class GermanRadPageViewLocalizationProvider : RadPageViewLocalizationProvider
    {
       public override string GetLocalizedString(string id)
       {
           switch (id)
           {
               case RadPageViewStringId.AddRemoveButtonsItemCaption: return "Schaltflächen hinzufügen oder entfernen";
               case RadPageViewStringId.CloseButtonTooltip: return "Schließen";
               case RadPageViewStringId.CloseSelectedPageCaption: return "Schließe ausgewählte Schaltfläche";
               case RadPageViewStringId.ItemCloseButtonTooltip: return "Schließe Schaltfläche";
               case RadPageViewStringId.ItemListButtonTooltip: return "Verfügbare Schaltflächen";
               case RadPageViewStringId.LeftScrollButtonTooltip: return "Weitere Schaltflächen links";
               case RadPageViewStringId.NewItemTooltipText: return "Schaltfläche neu";
               case RadPageViewStringId.RightScrollButtonTooltip: return "Weitere Schaltflächen rechts";
               case RadPageViewStringId.ScrollStripLeftCaption: return "Weitere Schaltflächen links";
               case RadPageViewStringId.ScrollStripRightCaption: return "Weitere Schaltflächen rechts";
               case RadPageViewStringId.ShowFewerButtonsItemCaption: return "Weniger Schaltflächen";
               case RadPageViewStringId.ShowMoreButtonsItemCaption: return "Weitere Schaltflächen";
               default:
                   MessageBox.Show( string.Format( "GermanRadPageViewLocalizationProvider: Missing Translation for: {0}" , id ) );
                   return base.GetLocalizedString(id);
           }
       }
    }
}
