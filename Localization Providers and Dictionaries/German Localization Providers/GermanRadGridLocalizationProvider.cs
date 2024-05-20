
using Telerik.WinControls.UI.Localization;

namespace GermanRadGridViewLocalization
{
        public class GermanRadGridLocalizationProvider : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue: return "Bitte wählen Sie einen gültigen Wert aus";
                case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue: return "Bitte legen Sie einen gültigen Zellenwert fest";
                case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues: return "Bitte legen Sie gültige Zellenwerte fest";
                case RadGridStringId.ConditionalFormattingPleaseSetValidExpression: return "Bitte legen Sie einen gültigen Ausdruck fest";
                case RadGridStringId.ConditionalFormattingItem: return "Artikel";
                case RadGridStringId.ConditionalFormattingInvalidParameters: return "Ungültige Parameter";
                
                case RadGridStringId.FilterFunctionBetween: return "Zwischen";
                case RadGridStringId.FilterFunctionContains: return "Enthält";
                case RadGridStringId.FilterFunctionDoesNotContain: return "Enthält nicht";
                case RadGridStringId.FilterFunctionEndsWith: return "Endet mit";
                case RadGridStringId.FilterFunctionEqualTo: return "Ist Gleich";
                case RadGridStringId.FilterFunctionGreaterThan: return "Größer als";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Größer oder gleich";
                case RadGridStringId.FilterFunctionIsEmpty: return "Ist leer";
                case RadGridStringId.FilterFunctionIsNull: return "Ist null";
                case RadGridStringId.FilterFunctionLessThan: return "Kleiner als";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Kleiner oder gleich";
                case RadGridStringId.FilterFunctionNoFilter: return "Kein Filter";
                case RadGridStringId.FilterFunctionNotBetween: return "Nicht dazwischen";
                case RadGridStringId.FilterFunctionNotEqualTo: return "Nicht gleich";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Ist nicht leer";
                case RadGridStringId.FilterFunctionNotIsNull: return "Ist nicht null";
                case RadGridStringId.FilterFunctionStartsWith: return "Beginnt mit";
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
                case RadGridStringId.FilterOperatorLessThan: return "Weniger als";
                case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "Kleiner oder gleich";
                case RadGridStringId.FilterOperatorNoFilter: return "Kein Filter";
                case RadGridStringId.FilterOperatorNotBetween: return "Nicht dazwischen";
                case RadGridStringId.FilterOperatorNotEqualTo: return "Ist nicht Gleich";
                case RadGridStringId.FilterOperatorNotIsEmpty: return "Ist nicht Leer";
                case RadGridStringId.FilterOperatorNotIsNull: return "Ist nicht Null";
                case RadGridStringId.FilterOperatorStartsWith: return "Beginnt mit";
                case RadGridStringId.FilterOperatorIsLike: return "Ähnlich";
                case RadGridStringId.FilterOperatorNotIsLike: return "Nicht ähnlich";
                case RadGridStringId.FilterOperatorIsContainedIn: return "Enthalten in";
                case RadGridStringId.FilterOperatorNotIsContainedIn: return "Nicht enthalten in";
                case RadGridStringId.FilterOperatorCustom: return "Benutzerdefiniert";

                case RadGridStringId.CustomFilterMenuItem: return "Benutzerdefiniert";
                case RadGridStringId.CustomFilterDialogCaption: return "RadGridView Filter Dialog [{0}]";
                case RadGridStringId.CustomFilterDialogLabel: return "Zeilen anzeigen die:";
                case RadGridStringId.CustomFilterDialogRbAnd: return "UND";
                case RadGridStringId.CustomFilterDialogRbOr: return "ODER";
                case RadGridStringId.CustomFilterDialogBtnOk: return "Ok";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Abbrechen";
                case RadGridStringId.CustomFilterDialogCheckBoxNot: return "Nicht";
                case RadGridStringId.CustomFilterDialogTrue: return "Wahr";
                case RadGridStringId.CustomFilterDialogFalse: return "Falsch";

                case RadGridStringId.FilterMenuBlanks: return "Leer";
                case RadGridStringId.FilterMenuAvailableFilters: return "Verfügbare Filter";
                case RadGridStringId.FilterMenuSearchBoxText: return "Suche...";
                case RadGridStringId.FilterMenuClearFilters: return "Filter löschen";
                case RadGridStringId.FilterMenuButtonOK: return "OK";
                case RadGridStringId.FilterMenuButtonCancel: return "Abbrechen";
                case RadGridStringId.FilterMenuSelectionAll: return "Alle";
                case RadGridStringId.FilterMenuSelectionAllSearched: return "Alle such Ergebnisse";
                case RadGridStringId.FilterMenuSelectionNull: return "Null";
                case RadGridStringId.FilterMenuSelectionNotNull: return "Nicht Null";

                case RadGridStringId.FilterFunctionSelectedDates: return "Filter nach spezifischem Datum:";
                case RadGridStringId.FilterFunctionToday: return "Heute";
                case RadGridStringId.FilterFunctionYesterday: return "Gestern";
                case RadGridStringId.FilterFunctionDuringLast7days: return "In den letzten 7 Tagen";

                case RadGridStringId.FilterLogicalOperatorAnd: return "UND";
                case RadGridStringId.FilterLogicalOperatorOr: return "ODER";
                case RadGridStringId.FilterCompositeNotOperator: return "NICHT";

                case RadGridStringId.DeleteRowMenuItem: return "Zeile löschen";
                case RadGridStringId.SortAscendingMenuItem: return "Aufsteigend sortieren";
                case RadGridStringId.SortDescendingMenuItem: return "Absteigend sortieren";
                case RadGridStringId.ClearSortingMenuItem: return "Sortierung entfernen";
                case RadGridStringId.ConditionalFormattingMenuItem: return "Bedingte Formatierung";
                case RadGridStringId.GroupByThisColumnMenuItem: return "Nach dieser Spalte gruppieren";
                case RadGridStringId.UngroupThisColumn: return "Gruppierung dieser Spalte aufheben";
                case RadGridStringId.ColumnChooserMenuItem: return "Spalten auswahl";
                case RadGridStringId.HideMenuItem: return "Spalte verbergen";
                case RadGridStringId.HideGroupMenuItem: return "Gruppe verbergen";
                case RadGridStringId.UnpinMenuItem: return "Fixierung lösen";
                case RadGridStringId.UnpinRowMenuItem: return "Fixierung lösen";
                case RadGridStringId.PinMenuItem: return "Fixierungs status";
                case RadGridStringId.PinAtLeftMenuItem: return "Links fixieren";
                case RadGridStringId.PinAtRightMenuItem: return "Rechts fixieren";
                case RadGridStringId.PinAtBottomMenuItem: return "Unten fixieren";
                case RadGridStringId.PinAtTopMenuItem: return "Oben fixieren";
                case RadGridStringId.BestFitMenuItem: return "Optimale Spaltenbreite";
                case RadGridStringId.PasteMenuItem: return "Einfügen";
                case RadGridStringId.EditMenuItem: return "Editieren";
                case RadGridStringId.ClearValueMenuItem: return "Wert entfernen";
                case RadGridStringId.CopyMenuItem: return "Kopieren";
                case RadGridStringId.CutMenuItem: return "Ausschneiden";
                case RadGridStringId.AddNewRowString: return "Klicken Sie hier, um eine neue Zeile einzufügen.";

                case RadGridStringId.ConditionalFormattingSortAlphabetically: return "Spalten alphabetisch sortieren";
                case RadGridStringId.ConditionalFormattingCaption: return "Bedingte Formatierungsregeln Manager";
                case RadGridStringId.ConditionalFormattingLblColumn: return "Formatiere nur Zellen mit";
                case RadGridStringId.ConditionalFormattingLblName: return "Regelname";
                case RadGridStringId.ConditionalFormattingLblType: return "Zellenwert";
                case RadGridStringId.ConditionalFormattingLblValue1: return "Wert 1";
                case RadGridStringId.ConditionalFormattingLblValue2: return "Wert 2";
                case RadGridStringId.ConditionalFormattingGrpConditions: return "Regeln";
                case RadGridStringId.ConditionalFormattingGrpProperties: return "Regel Eigenschaften";
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Wenden Sie diese Formatierung auf ganze Zeile an";
                case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows: return "Wenden Sie diese Formatierung an, wenn die Zeile ausgewählt ist";
                case RadGridStringId.ConditionalFormattingBtnAdd: return "Neue Regel hinzufügen";
                case RadGridStringId.ConditionalFormattingBtnRemove: return "Entfernen";
                case RadGridStringId.ConditionalFormattingBtnOK: return "OK";
                case RadGridStringId.ConditionalFormattingBtnCancel: return "Abbrechen";
                case RadGridStringId.ConditionalFormattingBtnApply: return "Übernehmen";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "Regel gilt für:";
                case RadGridStringId.ConditionalFormattingCondition: return "Bedingung";
                case RadGridStringId.ConditionalFormattingExpression: return "Ausdruck";
                case RadGridStringId.ConditionalFormattingChooseOne: return "[Wähle einen]";
                case RadGridStringId.ConditionalFormattingEqualsTo: return "Ist gleich[Wert1]";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "Nicht gleich [Wert1]";
                case RadGridStringId.ConditionalFormattingStartsWith: return "Beginnt mit [Wert1]";
                case RadGridStringId.ConditionalFormattingEndsWith: return "Endet mit [Wert1]";
                case RadGridStringId.ConditionalFormattingContains: return "Enthält [Wert1]";
                case RadGridStringId.ConditionalFormattingDoesNotContain: return "Enthält nicht [Wert1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThan: return "Ist größer als [Wert1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "Ist größer oder gleich [Wert1]";
                case RadGridStringId.ConditionalFormattingIsLessThan: return "Ist kleiner als [Wert1]";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "Ist kleiner oder gleich [Wert1]";
                case RadGridStringId.ConditionalFormattingIsBetween: return "Ist zwischen [Wert1] und [Wert2]";
                case RadGridStringId.ConditionalFormattingIsNotBetween: return "Ist nicht zwischen [Wert1] und [Wert1]";
                case RadGridStringId.ConditionalFormattingLblFormat: return "Formatierung";

                case RadGridStringId.ConditionalFormattingBtnExpression: return "Ausdruckseditor";
                case RadGridStringId.ConditionalFormattingTextBoxExpression: return "Ausdruck";

                case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive: return "Groß-/Kleinschreibung ";
                case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor: return "Zellen Hintergrundfarbe";
                case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor: return "Zellen Schriftfarbe";
                case RadGridStringId.ConditionalFormattingPropertyGridEnabled: return "Aktiviert";
                case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor: return "Zeilen Hintergrundfarbe";
                case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor: return "Zeilen Schriftfarbe";
                case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment: return "Zeilen Textausrichtung";
                case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment: return "Textausrichtung";
                case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription: return "Bestimmt, ob Groß- / Kleinschreibung bei der Auswertung von Text-Werten berücksichtigt wird.";
                case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription: return "Geben Sie die Hintergrundfarbe ein, die für die Zelle verwendet werden soll.";
                case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription: return "Geben Sie die Schriftfarbe ein, die für die Zelle verwendet werden soll.";
                case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription: return "Bestimmt, ob die Bedingung aktiviert ist (ausgewertet und angewendet werden kann).";
                case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription: return "Geben Sie die Hintergrundfarbe ein, die für die gesamte Zeile verwendet werden soll.";
                case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription: return "Geben Sie die Schriftfarbe ein, die für die gesamte Zeile verwendet werden soll.";
                case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription: return "Geben Sie die Ausrichtung ein, die für die Zellenwerte verwendet werden soll, wenn AufZeileAnwenden wahr ist.";
                case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription: return "Geben Sie die Ausrichtung ein, die für die Zellenwerte verwendet werden soll.";
                
                case RadGridStringId.ColumnChooserFormCaption: return "Spaltenauswahl";
                case RadGridStringId.ColumnChooserFormMessage: return "Ziehen sie einen Spaltenkopf aus der Tablle,\num ihn aus der aktuellen Ansicht zu entfernen.";
                case RadGridStringId.GroupingPanelDefaultMessage: return "Ziehen Sie eine Spalte hier hin, um durch diese Spalte zu gruppieren.";
                case RadGridStringId.GroupingPanelHeader: return "Gruppieren nach:";
                case RadGridStringId.PagingPanelPagesLabel: return "Seite";
                case RadGridStringId.PagingPanelOfPagesLabel: return "von";
                case RadGridStringId.NoDataText: return "Keine Daten vorhanden";
                case RadGridStringId.CompositeFilterFormErrorCaption: return "Filter Fehler";
                case RadGridStringId.CompositeFilterFormInvalidFilter: return "Der zusammengesetzte Filterausdruck ist nicht gültig.";

                case RadGridStringId.ExpressionMenuItem: return "Ausdruck";
                case RadGridStringId.ExpressionFormTitle: return "Ausdrucksgenerator";
                case RadGridStringId.ExpressionFormFunctions: return "Funktionen";
                case RadGridStringId.ExpressionFormFunctionsText: return "Text";
                case RadGridStringId.ExpressionFormFunctionsAggregate: return "Aggregat";
                case RadGridStringId.ExpressionFormFunctionsDateTime: return "Datum";
                case RadGridStringId.ExpressionFormFunctionsLogical: return "Logisch";
                case RadGridStringId.ExpressionFormFunctionsMath: return "Mathematische";
                case RadGridStringId.ExpressionFormFunctionsOther: return "Andere";
                case RadGridStringId.ExpressionFormOperators: return "Operatoren";
                case RadGridStringId.ExpressionFormConstants: return "Konstanten";
                case RadGridStringId.ExpressionFormFields: return "Felder";
                case RadGridStringId.ExpressionFormDescription: return "Beschreibung";
                case RadGridStringId.ExpressionFormResultPreview: return "Ergebniss Vorschau";
                case RadGridStringId.ExpressionFormTooltipPlus: return "Addieren";
                case RadGridStringId.ExpressionFormTooltipMinus: return "Subtrahieren";
                case RadGridStringId.ExpressionFormTooltipMultiply: return "Multiplizieren";
                case RadGridStringId.ExpressionFormTooltipDivide: return "Dividieren";
                case RadGridStringId.ExpressionFormTooltipModulo: return "Modulo";
                case RadGridStringId.ExpressionFormTooltipEqual: return "Gleich";
                case RadGridStringId.ExpressionFormTooltipNotEqual: return "Nicht gleich";
                case RadGridStringId.ExpressionFormTooltipLess: return "Kleiner";
                case RadGridStringId.ExpressionFormTooltipLessOrEqual: return "Kleiner oder Gleich";
                case RadGridStringId.ExpressionFormTooltipGreaterOrEqual: return "Größer oder Gleich";
                case RadGridStringId.ExpressionFormTooltipGreater: return "Größer";
                case RadGridStringId.ExpressionFormTooltipAnd: return "Logisches \"UND\"";
                case RadGridStringId.ExpressionFormTooltipOr: return "Logisches \"ODER\"";
                case RadGridStringId.ExpressionFormTooltipNot: return "Logisches \"NICHT\"";
                case RadGridStringId.ExpressionFormAndButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOrButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormNotButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOKButton: return "OK";
                case RadGridStringId.ExpressionFormCancelButton: return "Abbrechen";
                    //The translation for this in german sounds wierd :). So i don´t did it.
                case RadGridStringId.SearchRowChooseColumns: return "SearchRowChooseColumns";
                case RadGridStringId.SearchRowSearchFromCurrentPosition: return "SearchRowSearchFromCurrentPosition";
                case RadGridStringId.SearchRowMenuItemMasterTemplate: return "SearchRowMenuItemMasterTemplate";
                case RadGridStringId.SearchRowMenuItemChildTemplates: return "SearchRowMenuItemChildTemplates";
                case RadGridStringId.SearchRowMenuItemAllColumns: return "SearchRowMenuItemAllColumns";
                case RadGridStringId.SearchRowTextBoxNullText: return "SearchRowTextBoxNullText";
                case RadGridStringId.SearchRowResultsOfLabel: return "SearchRowResultsOfLabel";
                case RadGridStringId.SearchRowMatchCase: return "Übereinstimmung";
            }
            return string.Empty;
        }
    }
}
