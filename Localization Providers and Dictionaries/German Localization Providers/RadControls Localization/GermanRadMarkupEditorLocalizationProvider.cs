using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    public class GermanRadMarkupEditorLocalizationProvider : RadMarkupEditorLocalizationProvider 
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadMarkupEditorStringId.MarkupEditorTitle: return "Markup-Editor";
                case RadMarkupEditorStringId.MarkupEditorUndoString: return "Rückgängig";
                case RadMarkupEditorStringId.MarkupEditorRedoString: return "Wiederholen";
                case RadMarkupEditorStringId.MarkupEditorCopyString: return "Kopieren";
                case RadMarkupEditorStringId.MarkupEditorCutString: return "Ausschneiden";
                case RadMarkupEditorStringId.MarkupEditorPasteString: return "Einfügen";
                case RadMarkupEditorStringId.MarkupEditorBoldString: return "Fett";
                case RadMarkupEditorStringId.MarkupEditorItalicString: return "Kursiv";
                case RadMarkupEditorStringId.MarkupEditorUnderlineString: return "Unterstrichen";
                case RadMarkupEditorStringId.MarkupEditorClipboardString: return "Zwischenablage";
                case RadMarkupEditorStringId.MarkupEditorFontString: return "Schriftart";
                case RadMarkupEditorStringId.MarkupEditorFontColorString: return "Schriftfarbe";
                case RadMarkupEditorStringId.MarkupEditorHighlightString: return "Hervorheben";
                case RadMarkupEditorStringId.MarkupEditorBulletsString: return "Aufzählungen";
                case RadMarkupEditorStringId.MarkupEditorUnorderedListString: return "Ungeordnete Liste";
                case RadMarkupEditorStringId.MarkupEditorListsString: return "Listen";
                case RadMarkupEditorStringId.MarkupEditorNumberingString: return "Nummerierung";
                case RadMarkupEditorStringId.MarkupEditorOrderedListString: return "Geordnete Liste";
                case RadMarkupEditorStringId.MarkupEditorLinksString: return "Links";
                case RadMarkupEditorStringId.MarkupEditorLinkString: return "Link";
                case RadMarkupEditorStringId.MarkupEditorHyperlinkString: return "Hyperlink";
                case RadMarkupEditorStringId.MarkupEditorApplyString: return "Anwenden";
                case RadMarkupEditorStringId.MarkupEditorDesignString: return "Design";
                case RadMarkupEditorStringId.MarkupEditorMarkupString: return "Markup";

                case RadMarkupEditorStringId.RibbonBarQuickAccessAboveItemText: return "Über dem &Menüband anzeigen";
                case RadMarkupEditorStringId.RibbonBarQuickAccessBelowItemText:return "Unter dem &Menüband anzeigen";
                case RadMarkupEditorStringId.RibbonBarMinimizeItemText: return "Menüband mi&nimieren";
                case RadMarkupEditorStringId.RibbonBarMaximizeItemText: return "Menüband ma&ximieren";

                case RadMarkupEditorStringId.AddHyperLinkDialogTitle: return "Neuer Hyperlink";
                case RadMarkupEditorStringId.AddHyperlinkType: return "Typ:";
                case RadMarkupEditorStringId.AddHyperlinkURI: return "URL:";
                case RadMarkupEditorStringId.AddHyperlinkDialogOK: return "Bestätigen";
                case RadMarkupEditorStringId.AddHyperlinkDialogCancel: return "Abbrechen";

                default:
                    MessageBox.Show( string.Format( "GermanRadMarkupEditorLocalizationProvider: Missing Translation for: {0}" , id ) );
                    return base.GetLocalizedString( id );
            }
        }
    }
}
