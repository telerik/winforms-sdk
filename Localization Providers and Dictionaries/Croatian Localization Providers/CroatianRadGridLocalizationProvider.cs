using System;
using System.Linq;
using Telerik.WinControls.UI.Localization;

namespace CroatianRadControlsLocalization
{
    public class CroatianRadGridLocalizationProvider : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.FilterFunctionBetween: return "Između";
                case RadGridStringId.FilterFunctionContains: return "Sadrži";
                case RadGridStringId.FilterFunctionDoesNotContain: return "Ne sadrži";
                case RadGridStringId.FilterFunctionEndsWith: return "Završava s";
                case RadGridStringId.FilterFunctionEqualTo: return "Je jednako";
                case RadGridStringId.FilterFunctionGreaterThan: return "Veće od";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Veće ili jednako";
                case RadGridStringId.FilterFunctionIsEmpty: return "Je prazno";
                case RadGridStringId.FilterFunctionIsNull: return "Ima vrijednost null";
                case RadGridStringId.FilterFunctionLessThan: return "Manje od";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Manje ili jednako";
                case RadGridStringId.FilterFunctionNoFilter: return "Bez filtra";
                case RadGridStringId.FilterFunctionNotBetween: return "Nije između";
                case RadGridStringId.FilterFunctionNotEqualTo: return "Nije jednak";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Nije prazno";
                case RadGridStringId.FilterFunctionNotIsNull: return "Nema vrijednost null";
                case RadGridStringId.FilterFunctionStartsWith: return "Započinje s";
                case RadGridStringId.FilterFunctionCustom: return "Korisnički određeno";

                case RadGridStringId.FilterOperatorBetween: return "Između";
                case RadGridStringId.FilterOperatorContains: return "Sadrži";
                case RadGridStringId.FilterOperatorDoesNotContain: return "Ne sadrži";
                case RadGridStringId.FilterOperatorEndsWith: return "Završava s";
                case RadGridStringId.FilterOperatorEqualTo: return "Je jednako";
                case RadGridStringId.FilterOperatorGreaterThan: return "Veće od";
                case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "Veće ili jednako";
                case RadGridStringId.FilterOperatorIsEmpty: return "Je prazno";
                case RadGridStringId.FilterOperatorIsNull: return "Ima vrijednost null";
                case RadGridStringId.FilterOperatorLessThan: return "Manje od";
                case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "Manje ili jednako";
                case RadGridStringId.FilterOperatorNoFilter: return "Bez filtra";
                case RadGridStringId.FilterOperatorNotBetween: return "Nije između";
                case RadGridStringId.FilterOperatorNotEqualTo: return "Nije jednak";
                case RadGridStringId.FilterOperatorNotIsEmpty: return "Nije prazno";
                case RadGridStringId.FilterOperatorNotIsNull: return "Nema vrijednost null";
                case RadGridStringId.FilterOperatorStartsWith: return "Započinje s";
                case RadGridStringId.FilterOperatorIsLike: return "Slično";
                case RadGridStringId.FilterOperatorNotIsLike: return "Nije slično";
                case RadGridStringId.FilterOperatorIsContainedIn: return "Sadržano u";
                case RadGridStringId.FilterOperatorNotIsContainedIn: return "Nije sadržano u";
                case RadGridStringId.FilterOperatorCustom: return "Korisnički određeno";

                case RadGridStringId.CustomFilterMenuItem: return "Korisnički određeno";
                case RadGridStringId.CustomFilterDialogCaption: return "RadGridView filter dijalog [{0}]";
                case RadGridStringId.CustomFilterDialogLabel: return "Prikaži redove gdje:";
                case RadGridStringId.CustomFilterDialogRbAnd: return "I";
                case RadGridStringId.CustomFilterDialogRbOr: return "Ili";
                case RadGridStringId.CustomFilterDialogBtnOk: return "OK";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Otkaži";
                case RadGridStringId.CustomFilterDialogCheckBoxNot: return "Ne";
                case RadGridStringId.CustomFilterDialogTrue: return "Je";
                case RadGridStringId.CustomFilterDialogFalse: return "Nije";

                case RadGridStringId.FilterMenuAvailableFilters: return "Dostupni filtri";
                case RadGridStringId.FilterMenuSearchBoxText: return "Pretraži...";
                case RadGridStringId.FilterMenuClearFilters: return "Očisti filter";
                case RadGridStringId.FilterMenuButtonOK: return "OK";
                case RadGridStringId.FilterMenuButtonCancel: return "Otkaži";
                case RadGridStringId.FilterMenuSelectionAll: return "Sve";
                case RadGridStringId.FilterMenuSelectionAllSearched: return "Svi rezultati pretrage";
                case RadGridStringId.FilterMenuSelectionNull: return "Null";
                case RadGridStringId.FilterMenuSelectionNotNull: return "Nije null";

                case RadGridStringId.FilterFunctionSelectedDates: return "Filtriraj po određenim datumima:";
                case RadGridStringId.FilterFunctionToday: return "Danas";
                case RadGridStringId.FilterFunctionYesterday: return "Jučer";
                case RadGridStringId.FilterFunctionDuringLast7days: return "Tijekom zadnjih 7 dana";

                case RadGridStringId.FilterLogicalOperatorAnd: return "I";
                case RadGridStringId.FilterLogicalOperatorOr: return "ILI";
                case RadGridStringId.FilterCompositeNotOperator: return "NE";

                case RadGridStringId.DeleteRowMenuItem: return "Obriši red";
                case RadGridStringId.SortAscendingMenuItem: return "Sortiraj uzlazno";
                case RadGridStringId.SortDescendingMenuItem: return "Sortiraj silazno";
                case RadGridStringId.ClearSortingMenuItem: return "Očisti sortiranje";
                case RadGridStringId.ConditionalFormattingMenuItem: return "Uvjetno oblikovanje";
                case RadGridStringId.GroupByThisColumnMenuItem: return "Grupiraj po ovom stupcu";
                case RadGridStringId.UngroupThisColumn: return "Razgrupiraj ovaj stupac";
                case RadGridStringId.ColumnChooserMenuItem: return "Birač stupaca";
                case RadGridStringId.HideMenuItem: return "Sakrij stupac";
                case RadGridStringId.HideGroupMenuItem: return "Sakrij grupu";
                case RadGridStringId.UnpinMenuItem: return "Otkači stupac";
                case RadGridStringId.UnpinRowMenuItem: return "Otkači red";
                case RadGridStringId.PinMenuItem: return "Stanje zakačenosti";
                case RadGridStringId.PinAtLeftMenuItem: return "Zakači lijevo";
                case RadGridStringId.PinAtRightMenuItem: return "Zakači desno";
                case RadGridStringId.PinAtBottomMenuItem: return "Zakači na dnu";
                case RadGridStringId.PinAtTopMenuItem: return "Zakači na vrhu";
                case RadGridStringId.BestFitMenuItem: return "Najbolje pristaje";
                case RadGridStringId.PasteMenuItem: return "Zalijepi";
                case RadGridStringId.EditMenuItem: return "Uredi";
                case RadGridStringId.ClearValueMenuItem: return "Očisti vrijednost";
                case RadGridStringId.CopyMenuItem: return "Kopiraj";
                case RadGridStringId.CutMenuItem: return "Izreži";
                case RadGridStringId.AddNewRowString: return "Klikni ovdje za dodavanje novog reda";
                case RadGridStringId.ConditionalFormattingSortAlphabetically: return "Sortiraj stupce abecedno";
                case RadGridStringId.ConditionalFormattingCaption: return "Administrator pravila uvjetnog oblikovanja";
                case RadGridStringId.ConditionalFormattingLblColumn: return "Uredi samo čelije sa";
                case RadGridStringId.ConditionalFormattingLblName: return "Ime pravila";
                case RadGridStringId.ConditionalFormattingLblType: return "Vrijednost čelije";
                case RadGridStringId.ConditionalFormattingLblValue1: return "Vrijednost 1";
                case RadGridStringId.ConditionalFormattingLblValue2: return "Vrijednost 2";
                case RadGridStringId.ConditionalFormattingGrpConditions: return "Pravila";
                case RadGridStringId.ConditionalFormattingGrpProperties: return "Svojstva pravila";
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Primjeni ovo oblikovanje na cijeli red";
                case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows: return "Primjeni ovo oblikovanje ako je red odabran";
                case RadGridStringId.ConditionalFormattingBtnAdd: return "Dodaj novo pravilo";
                case RadGridStringId.ConditionalFormattingBtnRemove: return "Ukloni";
                case RadGridStringId.ConditionalFormattingBtnOK: return "OK";
                case RadGridStringId.ConditionalFormattingBtnCancel: return "Otkaži";
                case RadGridStringId.ConditionalFormattingBtnApply: return "Primjeni";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "Pravilo vrijedi za";
                case RadGridStringId.ConditionalFormattingCondition: return "Stanje";
                case RadGridStringId.ConditionalFormattingExpression: return "Izraz";
                case RadGridStringId.ConditionalFormattingChooseOne: return "[Izaberite jednu]";
                case RadGridStringId.ConditionalFormattingEqualsTo: return "jednako je [Vrijednost1]";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "nije jednako [Vrijednost1]";
                case RadGridStringId.ConditionalFormattingStartsWith: return "započinje s [Vrijednost1]";
                case RadGridStringId.ConditionalFormattingEndsWith: return "završava s [Vrijednost1]";
                case RadGridStringId.ConditionalFormattingContains: return "sadrži [Vrijednost1]";
                case RadGridStringId.ConditionalFormattingDoesNotContain: return "ne sadrži [Vrijednost1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThan: return "veće od [Vrijednost1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "veće ili jednako [Vrijednost1]";
                case RadGridStringId.ConditionalFormattingIsLessThan: return "manje od [Vrijednost1]";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "manje ili jednako [Vrijednost1]";
                case RadGridStringId.ConditionalFormattingIsBetween: return "je između [Vrijednost1] i [Vrijednost2]";
                case RadGridStringId.ConditionalFormattingIsNotBetween: return "nije između [Vrijednost1] i [Vrijednost1]";
                case RadGridStringId.ConditionalFormattingLblFormat: return "Format";

                case RadGridStringId.ConditionalFormattingBtnExpression: return "Urednik izraza";
                case RadGridStringId.ConditionalFormattingTextBoxExpression: return "Izraz";

                case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive: return "Osjetljivost na veliko malo slovo";
                case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor: return "Boja pozadine čelije";
                case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor: return "Boja znakova u čeliji";
                case RadGridStringId.ConditionalFormattingPropertyGridEnabled: return "Omogućeno";
                case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor: return "Boja pozadine reda";
                case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor: return "Boja znakova u redu";
                case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment: return "Poravnanje texta u redu";
                case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment: return "Poravnanje texta";

                case RadGridStringId.ColumnChooserFormCaption: return "Birač Stupca";
                case RadGridStringId.ColumnChooserFormMessage: return "Dovucite zaglavlje stupca iz\ntablice ovdje da bi ste ga uklonili iz \ntrenutnog prikaza tablice.";
                case RadGridStringId.GroupingPanelDefaultMessage: return "Dovucite stupac za grupiranje po tom stupcu.";
                case RadGridStringId.GroupingPanelHeader: return "Grupiraj po:";
                case RadGridStringId.NoDataText: return "Nema podataka za prikaz";
                case RadGridStringId.CompositeFilterFormErrorCaption: return "Greška filtra";
                case RadGridStringId.CompositeFilterFormInvalidFilter: return "Composite filter descriptor nije valjan.";

                case RadGridStringId.ExpressionMenuItem: return "Izraz";
                case RadGridStringId.ExpressionFormTitle: return "Kreator izraza";
                case RadGridStringId.ExpressionFormFunctions: return "Funkcije";
                case RadGridStringId.ExpressionFormFunctionsText: return "Tekst";
                case RadGridStringId.ExpressionFormFunctionsAggregate: return "Skup";
                case RadGridStringId.ExpressionFormFunctionsDateTime: return "Datum-Vrijeme";
                case RadGridStringId.ExpressionFormFunctionsLogical: return "Logičke";
                case RadGridStringId.ExpressionFormFunctionsMath: return "Matematičke";
                case RadGridStringId.ExpressionFormFunctionsOther: return "Ostale";
                case RadGridStringId.ExpressionFormOperators: return "Operatori";
                case RadGridStringId.ExpressionFormConstants: return "Konstante";
                case RadGridStringId.ExpressionFormFields: return "Polja";
                case RadGridStringId.ExpressionFormDescription: return "Opis";
                case RadGridStringId.ExpressionFormResultPreview: return "Pregled rezultata";
                case RadGridStringId.ExpressionFormTooltipPlus: return "Zbroji";
                case RadGridStringId.ExpressionFormTooltipMinus: return "Oduzmi";
                case RadGridStringId.ExpressionFormTooltipMultiply: return "Pomnoži";
                case RadGridStringId.ExpressionFormTooltipDivide: return "Podijeli";
                case RadGridStringId.ExpressionFormTooltipModulo: return "Modulo";
                case RadGridStringId.ExpressionFormTooltipEqual: return "Je jednako";
                case RadGridStringId.ExpressionFormTooltipNotEqual: return "Nije jednako";
                case RadGridStringId.ExpressionFormTooltipLess: return "Manje";
                case RadGridStringId.ExpressionFormTooltipLessOrEqual: return "Manje ili jednako";
                case RadGridStringId.ExpressionFormTooltipGreaterOrEqual: return "Veće ili jednako";
                case RadGridStringId.ExpressionFormTooltipGreater: return "Veće";
                case RadGridStringId.ExpressionFormTooltipAnd: return "Logički \"I\"";
                case RadGridStringId.ExpressionFormTooltipOr: return "Logički \"ILI\"";
                case RadGridStringId.ExpressionFormTooltipNot: return "Logički \"NE\"";
                case RadGridStringId.ExpressionFormAndButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOrButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormNotButton: return string.Empty; //if empty, default button image is used
                case RadGridStringId.ExpressionFormOKButton: return "OK";
                case RadGridStringId.ExpressionFormCancelButton: return "Otkaži";
            }

            return string.Empty;
        }
    }
}
