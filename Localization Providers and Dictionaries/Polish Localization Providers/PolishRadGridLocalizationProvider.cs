using Telerik.WinControls.UI.Localization;
public class PolishRadGridLocalizationProvider : RadGridLocalizationProvider
{
    public override string GetLocalizedString(string id)
    {
        switch (id)
        {
            case RadGridStringId.AddNewRowString:
                return "Dodaj nowy wiersz";
            case RadGridStringId.BestFitMenuItem:
                return "Najlepsze dopasowanie";
            case RadGridStringId.ClearSortingMenuItem:
                return "Wyczysc sortowanie";
            case RadGridStringId.ClearValueMenuItem:
                return "Wyczysc wartosc";
            case RadGridStringId.ColumnChooserFormCaption:
                return "Wybór kolumn";
            case RadGridStringId.ColumnChooserFormMessage:
                return "Przeciagnij tu z tabeli naglówek kolumny\naby usunac ja\nz biezacego widoku.";
            case RadGridStringId.ColumnChooserMenuItem:
                return "Wybierz kolumny";
            case RadGridStringId.CompositeFilterFormErrorCaption:
                return "Blad filtru";
            case RadGridStringId.ConditionalFormattingBtnAdd:
                return "Dodaj nowa regule";
            case RadGridStringId.ConditionalFormattingBtnApply:
                return "Zastosuj";
            case RadGridStringId.ConditionalFormattingBtnCancel:
                return "Anuluj";
            case RadGridStringId.ConditionalFormattingBtnOK:
                return "OK";
            case RadGridStringId.ConditionalFormattingBtnRemove:
                return "Usun";
            case RadGridStringId.ConditionalFormattingCaption:
                return "Menedzer regul formatowania warunkowego";
            case RadGridStringId.ConditionalFormattingChkApplyToRow:
                return "Zastosuj ta regule do calego wiersza";
            case RadGridStringId.ConditionalFormattingChooseOne:
                return "[Wybierz jedna z opcji]";
            case RadGridStringId.ConditionalFormattingContains:
                return "zawiera [Wartosc 1]";
            case RadGridStringId.ConditionalFormattingDoesNotContain:
                return "nie zawiera [Wartosc 1]";
            case RadGridStringId.ConditionalFormattingEndsWith:
                return "konczy sie na [Wartosc 1]";
            case RadGridStringId.ConditionalFormattingEqualsTo:
                return "jest równa [Wartosc 1]";
            case RadGridStringId.ConditionalFormattingGrpConditions:
                return "Reguly";
            case RadGridStringId.ConditionalFormattingGrpProperties:
                return "Wlasciwosci reguly";
            case RadGridStringId.ConditionalFormattingIsBetween:
                return "jest z przedzialu od [Wartosc 1] do [Wartosc 2]";
            case RadGridStringId.ConditionalFormattingIsGreaterThan:
                return "jest wieksza niz [Wartosc 1]";
            case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual:
                return "jest wieksza lub równe [Wartosc 1]";
            case RadGridStringId.ConditionalFormattingIsLessThan:
                return "jest mniejsza niz [Wartosc 1]";
            case RadGridStringId.ConditionalFormattingIsLessThanOrEqual:
                return "jest mniejsza lub równe [Wartosc 1]";
            case RadGridStringId.ConditionalFormattingIsNotBetween:
                return "jest spoza przedzialu od [Wartosc 1] do [Wartosc 2]";
            case RadGridStringId.ConditionalFormattingIsNotEqualTo:
                return "jest rózna od [Wartosc 1]";
            case RadGridStringId.ConditionalFormattingLblColumn:
                return "Formatuj jedynie komórki, które";
            case RadGridStringId.ConditionalFormattingLblName:
                return "Nazwa reguly:";
            case RadGridStringId.ConditionalFormattingLblType:
                return "Wartosc:";
            case RadGridStringId.ConditionalFormattingLblValue1:
                return "Wartosc 1:";
            case RadGridStringId.ConditionalFormattingLblValue2:
                return "Wartosc 2:";
            case RadGridStringId.ConditionalFormattingMenuItem:
                return "Formatowanie warunkowe";
            case RadGridStringId.ConditionalFormattingRuleAppliesOn:
                return "Regula jest stosowana dla:";
            case RadGridStringId.ConditionalFormattingStartsWith:
                return "zaczyna sie od [Wartosc 1]";
            case RadGridStringId.CopyMenuItem:
                return "Kopiuj";
            case RadGridStringId.CustomFilterDialogBtnCancel:
                return "Anuluj";
            case RadGridStringId.CustomFilterDialogBtnOk:
                return "OK";
            case RadGridStringId.CustomFilterDialogCaption:
                return "Wlasny filtr";
            case RadGridStringId.CustomFilterDialogCheckBoxNot:
                return "Nie";
            case RadGridStringId.CustomFilterDialogFalse:
                return "Falsz";
            case RadGridStringId.CustomFilterDialogLabel:
                return "Pokazuj wiersze, dla których:";
            case RadGridStringId.CustomFilterDialogRbAnd:
                return "Oraz";
            case RadGridStringId.CustomFilterDialogRbOr:
                return "Lub";
            case RadGridStringId.CustomFilterDialogTrue:
                return "Prawda";
            case RadGridStringId.CustomFilterMenuItem:
                return "Wlasny filtr";
            case RadGridStringId.DeleteRowMenuItem:
                return "Usun wiersz";
            case RadGridStringId.EditMenuItem:
                return "Edytuj";
            case RadGridStringId.FilterCompositeNotOperator:
                return "NIE";
            case RadGridStringId.FilterFunctionBetween:
                return "Pomiedzy";
            case RadGridStringId.FilterFunctionContains:
                return "Zawiera";
            case RadGridStringId.FilterFunctionCustom:
                return "Wlasny";
            case RadGridStringId.FilterFunctionDoesNotContain:
                return "Nie zawiera";
            case RadGridStringId.FilterFunctionEndsWith:
                return "Konczy sie na";
            case RadGridStringId.FilterFunctionEqualTo:
                return "Jest równe";
            case RadGridStringId.FilterFunctionGreaterThan:
                return "Jest wieksze niz";
            case RadGridStringId.FilterFunctionGreaterThanOrEqualTo:
                return "Jest wieksze lub równe";
            case RadGridStringId.FilterFunctionIsEmpty:
                return "Jest puste";
            case RadGridStringId.FilterFunctionIsNull:
                return "Jest równe NULL";
            case RadGridStringId.FilterFunctionLessThan:
                return "Jest mniejsze niz";
            case RadGridStringId.FilterFunctionLessThanOrEqualTo:
                return "Jest mniejsze lub równe";
            case RadGridStringId.FilterFunctionNoFilter:
                return "Bez filtrowania";
            case RadGridStringId.FilterFunctionNotBetween:
                return "Jest spoza zakresu";
            case RadGridStringId.FilterFunctionNotEqualTo:
                return "Jest rózne od";
            case RadGridStringId.FilterFunctionNotIsEmpty:
                return "Jest niepuste";
            case RadGridStringId.FilterFunctionNotIsNull:
                return "Jest rózne od NULL";
            case RadGridStringId.FilterFunctionStartsWith:
                return "Zaczyna sie od";
            case RadGridStringId.FilterLogicalOperatorAnd:
                return "ORAZ";
            case RadGridStringId.FilterLogicalOperatorOr:
                return "LUB";
            case RadGridStringId.FilterMenuAvailableFilters:
                return "Dostepne filtry";
            case RadGridStringId.FilterMenuButtonCancel:
                return "Anuluj";
            case RadGridStringId.FilterMenuButtonOK:
                return "OK";
            case RadGridStringId.FilterMenuClearFilters:
                return "Wyczysc filtry";
            case RadGridStringId.FilterMenuSearchBoxText:
                return "Szukaj...";
            case RadGridStringId.FilterMenuSelectionAll:
                return "Wszystkie";
            case RadGridStringId.FilterMenuSelectionAllSearched:
                return "Wszystkie wyniki wyszukiwania";
            case RadGridStringId.FilterMenuSelectionNotNull:
                return "Rózne od NULL";
            case RadGridStringId.FilterMenuSelectionNull:
                return "Równe NULL";
            case RadGridStringId.FilterOperatorBetween:
                return "Pomiedzy";
            case RadGridStringId.FilterOperatorContains:
                return "Zawiera";
            case RadGridStringId.FilterOperatorCustom:
                return "Wlasny filtr";
            case RadGridStringId.FilterOperatorDoesNotContain:
                return "Nie zawiera";
            case RadGridStringId.FilterOperatorEndsWith:
                return "Konczy sie na";
            case RadGridStringId.FilterOperatorEqualTo:
                return "Jest równe";
            case RadGridStringId.FilterOperatorGreaterThan:
                return "Jest wieksze niz";
            case RadGridStringId.FilterOperatorGreaterThanOrEqualTo:
                return "Jest wieksze lub równe";
            case RadGridStringId.FilterOperatorIsContainedIn:
                return "Zawiera sie w";
            case RadGridStringId.FilterOperatorIsEmpty:
                return "Jest puste";
            case RadGridStringId.FilterOperatorIsLike:
                return "Wyglada jak";
            case RadGridStringId.FilterOperatorIsNull:
                return "Jest równe NULL";
            case RadGridStringId.FilterOperatorLessThan:
                return "Jest mniejsze niz";
            case RadGridStringId.FilterOperatorLessThanOrEqualTo:
                return "Jest mniejsze lub równe";
            case RadGridStringId.FilterOperatorNoFilter:
                return "Brak filtru";
            case RadGridStringId.FilterOperatorNotBetween:
                return "Nie zawiera sie w przedziale";
            case RadGridStringId.FilterOperatorNotEqualTo:
                return "Jest rózne od";
            case RadGridStringId.FilterOperatorNotIsContainedIn:
                return "Nie zawiera sie w";
            case RadGridStringId.FilterOperatorNotIsEmpty:
                return "Jest niepuste";
            case RadGridStringId.FilterOperatorNotIsLike:
                return "Nie wyglada jak";
            case RadGridStringId.FilterOperatorNotIsNull:
                return "Jest rózne od NULL";
            case RadGridStringId.FilterOperatorStartsWith:
                return "Zaczyna sie od";
            case RadGridStringId.GroupByThisColumnMenuItem:
                return "Grupuj wedlug tej kolumny";
            case RadGridStringId.GroupingPanelDefaultMessage:
                return "Przeciagnij tu kolumne aby pogrupowac";
            case RadGridStringId.GroupingPanelHeader:
                return "Grupuj wedlug:";
            case RadGridStringId.HideMenuItem:
                return "Ukryj kolumne";
            case RadGridStringId.NoDataText:
                return "Brak danych do wyswietlenia";
            case RadGridStringId.PasteMenuItem:
                return "Wklej";
            case RadGridStringId.PinAtBottomMenuItem:
                return "Przypnij na dole";
            case RadGridStringId.PinAtLeftMenuItem:
                return "Przypnij po lewej";
            case RadGridStringId.PinAtRightMenuItem:
                return "Przypnij po prawej";
            case RadGridStringId.PinAtTopMenuItem:
                return "Przypnij na górze";
            case RadGridStringId.PinMenuItem:
                return "Przypnij";
            case RadGridStringId.SortAscendingMenuItem:
                return "Sortuj rosnaco";
            case RadGridStringId.SortDescendingMenuItem:
                return "Sortuj malejaco";
            case RadGridStringId.UngroupThisColumn:
                return "Rozgrupuj ta kolumne";
            case RadGridStringId.UnpinMenuItem:
                return "Odepnij kolumne";
            case RadGridStringId.UnpinRowMenuItem:
                return "Odepnij wiersz";
        }
 
        return string.Empty;
    }
}