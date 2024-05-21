using Telerik.WinControls.UI.Localization;
using System.Windows.Forms;

namespace GermanRadControlsLocalization
{
    public class GermanRadGridViewLocalizationProvider : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
           switch (id)
           {
               case RadGridStringId.FilterFunctionBetween: return "Zwischen...";
               case RadGridStringId.FilterFunctionContains: return "Enthält...";
               case RadGridStringId.FilterFunctionDoesNotContain: return "Enthält nicht...";
               case RadGridStringId.FilterFunctionEndsWith: return "Endet mit...";
               case RadGridStringId.FilterFunctionEqualTo: return "Ist gleich...";
               case RadGridStringId.FilterFunctionGreaterThan: return "Größer als...";
               case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Größer oder gleich...";
               case RadGridStringId.FilterFunctionIsEmpty: return "Ist leer...";
               case RadGridStringId.FilterFunctionIsNull: return "Ist null...";
               case RadGridStringId.FilterFunctionLessThan: return "Kleiner als...";
               case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Kleiner oder gleich...";
               case RadGridStringId.FilterFunctionNoFilter: return "Kein Filter";
               case RadGridStringId.FilterFunctionNotBetween: return "Nicht zwischen...";
               case RadGridStringId.FilterFunctionNotEqualTo: return "Ist nicht gleich...";
               case RadGridStringId.FilterFunctionNotIsEmpty: return "Ist nicht leer...";
               case RadGridStringId.FilterFunctionNotIsNull: return "Ist nicht null...";
               case RadGridStringId.FilterFunctionStartsWith: return "Beginnt mit...";
			   case RadGridStringId.FilterFunctionCustom: return "Benutzerdefinierter Filter";

               case RadGridStringId.FilterOperatorBetween: return "Zwischen";
               case RadGridStringId.FilterOperatorContains: return "Enthält";
               case RadGridStringId.FilterOperatorDoesNotContain: return "Enthält nicht";
               case RadGridStringId.FilterOperatorEndsWith: return "Endet mit";
               case RadGridStringId.FilterOperatorEqualTo: return "Ist gleich";
               case RadGridStringId.FilterOperatorGreaterThan: return "Größer als";
               case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "Größer oder gleich";
               case RadGridStringId.FilterOperatorIsEmpty: return "Ist leer";
               case RadGridStringId.FilterOperatorIsNull: return "Ist null";
               case RadGridStringId.FilterOperatorLessThan: return "Kleiner";
               case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "Kleiner oder gleich";
               case RadGridStringId.FilterOperatorNoFilter: return "Kein Filter";
               case RadGridStringId.FilterOperatorNotBetween: return "Zwischen";
               case RadGridStringId.FilterOperatorNotEqualTo: return "Ist nicht gleich";
               case RadGridStringId.FilterOperatorNotIsEmpty: return "Ist nicht leer";
               case RadGridStringId.FilterOperatorNotIsNull: return "Ist nicht null";
               case RadGridStringId.FilterOperatorStartsWith: return "Beginnt mit";
			   case RadGridStringId.FilterOperatorIsLike: return "Ist ähnlich";
			   case RadGridStringId.FilterOperatorNotIsLike: return "Ist nicht ähnlich";
			   case RadGridStringId.FilterOperatorIsContainedIn: return "Ist enthalten in";
			   case RadGridStringId.FilterOperatorNotIsContainedIn: return "Ist nicht enthalten in";
			   case RadGridStringId.FilterOperatorCustom: return "Benuzterdefiniert";

               case RadGridStringId.CustomFilterMenuItem: return "Benutzerdefinierter Filter";
               case RadGridStringId.CustomFilterDialogCaption: return "Benutzerdefinierter Filter [{0}]";
               case RadGridStringId.CustomFilterDialogLabel: return "Zeilen anzeigen:"; //"Filterbedingung:";
               case RadGridStringId.CustomFilterDialogRbAnd: return "Und";
               case RadGridStringId.CustomFilterDialogRbOr: return "Oder";
			   case RadGridStringId.CustomFilterDialogBtnOk: return "Bestätigen";
			   case RadGridStringId.CustomFilterDialogBtnCancel: return "Abbrechen";
			   case RadGridStringId.CustomFilterDialogCheckBoxNot: return "Nicht";
			   case RadGridStringId.CustomFilterDialogTrue: return "Wahr";
               case RadGridStringId.CustomFilterDialogFalse: return "Falsch";

               case RadGridStringId.FilterMenuAvailableFilters: return "Verfügbare Filter";
               case RadGridStringId.FilterMenuSearchBoxText: return "Suchen...";
               case RadGridStringId.FilterMenuClearFilters: return "Filter löschen";
               case RadGridStringId.FilterMenuButtonOK: return "Bestätigen";
               case RadGridStringId.FilterMenuButtonCancel: return "Abbrechen";
               case RadGridStringId.FilterMenuSelectionAll: return "Alle";
               case RadGridStringId.FilterMenuSelectionAllSearched: return "Alle Suchergebnisse";
               case RadGridStringId.FilterMenuSelectionNull: return "Null";
               case RadGridStringId.FilterMenuSelectionNotNull: return "Nicht Null";

			   case RadGridStringId.FilterFunctionSelectedDates: return "Filter nach speziellen Daten:";
			   case RadGridStringId.FilterFunctionToday: return "Heute";
			   case RadGridStringId.FilterFunctionYesterday: return "Gestern";
			   case RadGridStringId.FilterFunctionDuringLast7days: return "Während der letzten 7 Tage";

               case RadGridStringId.FilterLogicalOperatorAnd: return "UND";
               case RadGridStringId.FilterLogicalOperatorOr: return "ODER";
               case RadGridStringId.FilterCompositeNotOperator: return "NICHT";

               case RadGridStringId.DeleteRowMenuItem: return "Zeile löschen";
               case RadGridStringId.SortAscendingMenuItem: return "Sortieren in aufsteigender Reihenfolge";
               case RadGridStringId.SortDescendingMenuItem: return "Sortieren in absteigender Reihenfolge";
               case RadGridStringId.ClearSortingMenuItem: return "Sortierung entfernen";
               case RadGridStringId.ConditionalFormattingMenuItem: return "Bedingte Formatierung";
               case RadGridStringId.GroupByThisColumnMenuItem: return "Nach dieser Spalte gruppieren";
               case RadGridStringId.UngroupThisColumn: return "Gruppierung entfernen";
               case RadGridStringId.ColumnChooserMenuItem: return "Spalte einblenden"; // "Spalte auswählen";
               case RadGridStringId.HideMenuItem: return "Spalte ausblenden";
			   case RadGridStringId.HideGroupMenuItem: return "Gruppe ausblenden";
               case RadGridStringId.UnpinMenuItem: return "Fixierung aufheben";
               case RadGridStringId.UnpinRowMenuItem: return "Fixierung der Zeile aufheben";
               case RadGridStringId.PinMenuItem: return "Spalte fixieren";
               case RadGridStringId.PinAtLeftMenuItem: return "Spalte links fixieren";
               case RadGridStringId.PinAtRightMenuItem: return "Spalte rechts fixieren";
               case RadGridStringId.PinAtBottomMenuItem: return "Spalte unten fixieren";
               case RadGridStringId.PinAtTopMenuItem: return "Spalte oben fixieren";
               case RadGridStringId.BestFitMenuItem: return "Optimale Spaltenbreite";
               case RadGridStringId.PasteMenuItem: return "Einfügen";
               case RadGridStringId.EditMenuItem: return "Bearbeiten";
               case RadGridStringId.ClearValueMenuItem: return "Wert löschen";
               case RadGridStringId.CopyMenuItem: return "Kopieren";
			   case RadGridStringId.CutMenuItem: return "Ausschneiden";
               case RadGridStringId.AddNewRowString: return "Klicken Sie hier, um eine neue Zeile einzufügen.";

			   case RadGridStringId.ConditionalFormattingSortAlphabetically: return "Sortiere Spalten";
			   case RadGridStringId.ConditionalFormattingCaption: return "Editor für die bedingte Formatierung";
			   case RadGridStringId.ConditionalFormattingLblColumn: return "Formatiere nur Zellen mit";
			   case RadGridStringId.ConditionalFormattingLblName: return "Regelname:";
			   case RadGridStringId.ConditionalFormattingLblType: return "Zellenwert:";
			   case RadGridStringId.ConditionalFormattingLblValue1: return "Wert1:";
			   case RadGridStringId.ConditionalFormattingLblValue2: return "Wert2:";
			   case RadGridStringId.ConditionalFormattingGrpConditions: return "Regeln";
			   case RadGridStringId.ConditionalFormattingGrpProperties: return "Eigenschaften der Regel";
			   case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Regel auf ganze Zeile anwenden";
			   case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows: return "Regel auf ausgewählte Zeilen anweden";
			   case RadGridStringId.ConditionalFormattingBtnAdd: return "Neue Regel";
			   case RadGridStringId.ConditionalFormattingBtnRemove: return "Entferne Regel";
			   case RadGridStringId.ConditionalFormattingBtnOK: return "Bestätigen";
			   case RadGridStringId.ConditionalFormattingBtnCancel: return "Abbrechen";
			   case RadGridStringId.ConditionalFormattingBtnApply: return "Anwenden";
			   case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "Regel anwenden auf:";
			   case RadGridStringId.ConditionalFormattingCondition: return "Bedingung";
			   case RadGridStringId.ConditionalFormattingExpression: return "Ausdruck";
			   case RadGridStringId.ConditionalFormattingChooseOne: return "[Wähle aus]";
			   case RadGridStringId.ConditionalFormattingEqualsTo: return "Ist gleich [Wert1]";
			   case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "Ist nicht gleich [Wert1]";
			   case RadGridStringId.ConditionalFormattingStartsWith: return "Beginnt mit [Wert1]";
			   case RadGridStringId.ConditionalFormattingEndsWith: return "Endet mit [Wert1]";
			   case RadGridStringId.ConditionalFormattingContains: return "Enthält [Wert1]";
               case RadGridStringId.ConditionalFormattingDoesNotContain: return "Enthält nicht [Wert1]";
			   case RadGridStringId.ConditionalFormattingIsGreaterThan: return "Ist größer als [Wert1]";
			   case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "Ist größer oder gleich [Wert1]";
			   case RadGridStringId.ConditionalFormattingIsLessThan: return "Ist kleiner [Wert1]";
			   case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "Ist kleiner oder gleich [Wert1]";
			   case RadGridStringId.ConditionalFormattingIsBetween: return "Ist zwischen [Wert1] und [Wert2]";
               case RadGridStringId.ConditionalFormattingIsNotBetween: return "Ist nicht zwischen [Wert1] und [Wert2]";
               case RadGridStringId.ConditionalFormattingLblFormat: return "Formatierung";

			   case RadGridStringId.ConditionalFormattingBtnExpression: return "Ausdruck";
			   case RadGridStringId.ConditionalFormattingTextBoxExpression: return "Ausdruck";

			   case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive: return "Groß-/Kleinschreibung";
			   case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor: return "Zelle Hintergrundfarbe";
			   case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor: return "Zelle Vordergrundfarbe";
			   case RadGridStringId.ConditionalFormattingPropertyGridEnabled: return "Eingeschaltet";
			   case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor: return "Zeile Hintergrundfarbe";
			   case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor: return "Zeile Vordergrundfarbe";
			   case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment: return "Zeile Textausrichtung";
			   case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment: return "Textausrictung";

               case RadGridStringId.ColumnChooserFormCaption: return "Spaltenauswahl";
               case RadGridStringId.ColumnChooserFormMessage: return "Um eine Spalte auszublenden,\nverschieben Sie diese von der Tabelle\nin dieses Fenster";
               case RadGridStringId.GroupingPanelDefaultMessage: return "Ziehen Sie eine Spalte hierhin, um nach dieser Spalte zu gruppieren";
               case RadGridStringId.GroupingPanelHeader: return "Gruppieren nach:";
               case RadGridStringId.NoDataText: return "Keine Daten vorhanden";
               case RadGridStringId.CompositeFilterFormErrorCaption: return "Filter Fehler";
			   case RadGridStringId.CompositeFilterFormInvalidFilter: return "Der Filter ist ungültig.";

               case RadGridStringId.ExpressionMenuItem: return "Ausdruck";
               case RadGridStringId.ExpressionFormTitle: return "Ausdrucks-Generator";
               case RadGridStringId.ExpressionFormFunctions: return "Funktionen";
               case RadGridStringId.ExpressionFormFunctionsText: return "Textfunktionen";
               case RadGridStringId.ExpressionFormFunctionsAggregate: return "Aggregationsfunktionen";
               case RadGridStringId.ExpressionFormFunctionsDateTime: return "Datum- und Zeitfunktionen";
               case RadGridStringId.ExpressionFormFunctionsLogical: return "Logische Funktionen";
               case RadGridStringId.ExpressionFormFunctionsMath: return "Mathematische Funktionen";
               case RadGridStringId.ExpressionFormFunctionsOther: return "Sonstige Funktionen";
               case RadGridStringId.ExpressionFormOperators: return "Operatoren";
               case RadGridStringId.ExpressionFormConstants: return "Konstanten";
               case RadGridStringId.ExpressionFormFields: return "Tabellenspalten";
               case RadGridStringId.ExpressionFormDescription: return "Beschreibung";
               case RadGridStringId.ExpressionFormResultPreview: return "Ergebnis Vorschau";
               case RadGridStringId.ExpressionFormTooltipPlus: return "addieren";
               case RadGridStringId.ExpressionFormTooltipMinus: return "subtrahieren";
               case RadGridStringId.ExpressionFormTooltipMultiply: return "multiplizieren";
               case RadGridStringId.ExpressionFormTooltipDivide: return "dividieren";
               case RadGridStringId.ExpressionFormTooltipModulo: return "modulo";
               case RadGridStringId.ExpressionFormTooltipEqual: return "Gleich";
               case RadGridStringId.ExpressionFormTooltipNotEqual: return "Ungleich";
               case RadGridStringId.ExpressionFormTooltipLess: return "Kleiner";
               case RadGridStringId.ExpressionFormTooltipLessOrEqual: return "Kleiner oder gleich";
               case RadGridStringId.ExpressionFormTooltipGreaterOrEqual: return "Größer oder gleich";
               case RadGridStringId.ExpressionFormTooltipGreater: return "Größer";
               case RadGridStringId.ExpressionFormTooltipAnd: return "Logisches \"UND\"";
               case RadGridStringId.ExpressionFormTooltipOr: return "Logisches \"ODER\"";
               case RadGridStringId.ExpressionFormTooltipNot: return "Logisches \"NICHT\"";
               case RadGridStringId.ExpressionFormAndButton: return "Und";
               case RadGridStringId.ExpressionFormOrButton: return "Oder";
               case RadGridStringId.ExpressionFormNotButton: return "Nicht";
               case RadGridStringId.ExpressionFormOKButton: return "Bestätigen";
               case RadGridStringId.ExpressionFormCancelButton: return "Abbrechen";

               default:
                   MessageBox.Show( string.Format( "GermanRadGridViewLocalizationProvider: Missing Translation for: {0} {1}" , id , base.GetLocalizedString( id ) ) );
                   return base.GetLocalizedString(id);
           }
       }
    }
}
