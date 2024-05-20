using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI.Localization;
using System.Windows.Forms;

namespace GermanRadGridViewLocalization
{
    /// <summary>
    /// German Localization of the RadGridView Q2'09 ServicePack 1 - Release
    /// </summary>
    class GermanRadGridViewLocalization : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
       {
           switch (id)
           {
               case RadGridStringId.AddNewRowString:
                   return "Klicken Sie hier, um eine neue Zeile einzufügen.";
               case RadGridStringId.BestFitMenuItem:
                   return "Optimale Spaltenbreite";
               case RadGridStringId.ClearSortingMenuItem:
                   return "Sortierung entfernen";
               case RadGridStringId.ClearValueMenuItem:
                   return "Wert löschen";
               case RadGridStringId.ColumnChooserFormCaption:
                   return "Spaltenauswahl";
               case RadGridStringId.ColumnChooserFormMessage:
                   return "Um eine Spalte auszublenden,\n" +
                            "verschieben Sie diese von der Tabelle\n" +
                            "in dieses Fenster";
               case RadGridStringId.ColumnChooserMenuItem:
                   return "Spalte einblenden"; 
               case RadGridStringId.ConditionalFormattingBtnAdd:
                   return "Neue Regel";
               case RadGridStringId.ConditionalFormattingBtnApply:
                   return "Anwenden";
               case RadGridStringId.ConditionalFormattingBtnCancel:
                   return "Abbrechen";
               case RadGridStringId.ConditionalFormattingBtnOK:
                   return "Bestätigen";
               case RadGridStringId.ConditionalFormattingChooseOne:
                   return "[Wähle aus]";
               case RadGridStringId.ConditionalFormattingBtnRemove:
                   return "Entferne Regel";
               case RadGridStringId.ConditionalFormattingCaption:
                   return "Editor für die bedingte Formatierung";
               case RadGridStringId.ConditionalFormattingChkApplyToRow:
                   return "Regel auf ganze Zeile anwenden";
               case RadGridStringId.ConditionalFormattingContains:
                   return "Enthält [Wert1]";
               case RadGridStringId.ConditionalFormattingDoesNotContain:
                   return "Enthält nicht [Wert1]";
               case RadGridStringId.ConditionalFormattingEndsWith:
                   return "Endet mit [Wert1]";
               case RadGridStringId.ConditionalFormattingEqualsTo:
                   return "Ist gleich [Wert1]";
               case RadGridStringId.ConditionalFormattingGrpConditions:
                   return "Regeln";
               case RadGridStringId.ConditionalFormattingGrpProperties:
                   return "Eigenschaften der Regel";
               case RadGridStringId.ConditionalFormattingIsBetween:
                   return "Ist zwischen [Wert1] und [Wert2]";
               case RadGridStringId.ConditionalFormattingIsGreaterThan:
                   return "Ist größer als [Wert1]";
               case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual:
                   return "Ist größer oder gleich [Wert1]";
               case RadGridStringId.ConditionalFormattingIsLessThan:
                   return "Ist kleiner [Wert1]";
               case RadGridStringId.ConditionalFormattingIsLessThanOrEqual:
                   return "Ist kleiner oder gleich [Wert1]";
               case RadGridStringId.ConditionalFormattingIsNotBetween:
                   return "Ist nicht zwischen [Wert1] und [Wert2]";
               case RadGridStringId.ConditionalFormattingIsNotEqualTo:
                   return "Ist nicht gleich [Wert1]";
               case RadGridStringId.ConditionalFormattingLblColumn:
                   return "Formatiere nur Zellen mit";
               case RadGridStringId.ConditionalFormattingLblName:
                   return "Regelname:";
               case RadGridStringId.ConditionalFormattingLblType:
                   return "Zellenwert:";
               case RadGridStringId.ConditionalFormattingLblValue1:
                   return "Wert1:";
               case RadGridStringId.ConditionalFormattingLblValue2:
                   return "Wert2:";
               case RadGridStringId.ConditionalFormattingMenuItem:
                   return "Bedingte Formatierung";
               case RadGridStringId.ConditionalFormattingRuleAppliesOn:
                   return "Regel anwenden auf:";
               case RadGridStringId.ConditionalFormattingStartsWith:
                   return "Beginnt mit [Wert1]";
               case RadGridStringId.CopyMenuItem:
                   return "Kopieren";
               case RadGridStringId.CustomFilterDialogBtnCancel:
                   return "Abbrechen";
               case RadGridStringId.CustomFilterDialogBtnOk:
                   return "Bestätigen";
               case RadGridStringId.CustomFilterDialogCaption:
                   return "Dialog für das benutzerdefinierte Filtern";
               case RadGridStringId.CustomFilterDialogLabel:
                   return "Zeige Zeilen für die gilt:"; 
               case RadGridStringId.CustomFilterDialogRbAnd:
                   return "Und";
               case RadGridStringId.CustomFilterDialogRbOr:
                   return "Oder";
               case RadGridStringId.CustomFilterMenuItem:
                   return "Benutzerdefinierter Filter";
               case RadGridStringId.DeleteRowMenuItem:
                   return "Zeile löschen";
               case RadGridStringId.EditMenuItem:
                   return "Bearbeiten";
               case RadGridStringId.FilterFunctionBetween:
                   return "Zwischen...";
               case RadGridStringId.FilterFunctionContains:
                   return "Enthält...";
               case RadGridStringId.FilterFunctionCustom:
                   return "Benutzerdefinierter Filter";
               case RadGridStringId.FilterFunctionDoesNotContain:
                   return "Enthält nicht...";
               case RadGridStringId.FilterFunctionEndsWith:
                   return "Endet mit...";
               case RadGridStringId.FilterFunctionEqualTo:
                   return "Ist gleich...";
               case RadGridStringId.FilterFunctionGreaterThan:
                   return "Größer als...";
               case RadGridStringId.FilterFunctionGreaterThanOrEqualTo:
                   return "Größer oder gleich...";
               case RadGridStringId.FilterFunctionIsEmpty:
                   return "Ist leer...";
               case RadGridStringId.FilterFunctionIsNull:
                   return "Ist null...";
               case RadGridStringId.FilterFunctionLessThan:
                   return "Kleiner als...";
               case RadGridStringId.FilterFunctionLessThanOrEqualTo:
                   return "Kleiner oder gleich...";
               case RadGridStringId.FilterFunctionNoFilter:
                   return "Kein Filter";
               case RadGridStringId.FilterFunctionNotBetween:
                   return "Nicht zwischen...";
               case RadGridStringId.FilterFunctionNotEqualTo:
                   return "Ist nicht gleich...";
               case RadGridStringId.FilterFunctionNotIsEmpty:
                   return "Ist nicht leer...";
               case RadGridStringId.FilterFunctionNotIsNull:
                   return "Ist nicht null...";
               case RadGridStringId.FilterFunctionStartsWith:
                   return "Beginnt mit...";
               case RadGridStringId.GroupByThisColumnMenuItem:
                   return "Nach dieser Spalte gruppieren";
               case RadGridStringId.GroupingPanelDefaultMessage:
                   return "Ziehen Sie eine Spalte hierhin, um nach dieser Spalte zu gruppieren";
               case RadGridStringId.HideMenuItem:
                   return "Spalte ausblenden"; 
               case RadGridStringId.NoDataText:
                   return "Keine Daten vorhanden";
               case RadGridStringId.PasteMenuItem:
                   return "Einfügen";
               case RadGridStringId.PinMenuItem:
                   return "Spalte fixieren";
               case RadGridStringId.SortAscendingMenuItem:
                   return "Sortieren in aufsteigender Reihenfolge";
               case RadGridStringId.SortDescendingMenuItem:
                   return "Sortieren in absteigender Reihenfolge";
               case RadGridStringId.UngroupThisColumn:
                   return "Gruppierung entfernen";
               case RadGridStringId.UnpinMenuItem:
                   return "Fixierung aufheben";
               default:
                   MessageBox.Show( id );
                   return base.GetLocalizedString( id );
           }
       }
    }
}
