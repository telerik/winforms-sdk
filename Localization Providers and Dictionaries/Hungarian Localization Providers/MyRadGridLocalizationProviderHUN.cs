using Telerik.WinControls.UI.Localization;

namespace MetaFeltoltes.Localization
{
    class MyRadGridLocalizationProviderHUN : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.FilterFunctionBetween: return "Között"; //"Between";
                case RadGridStringId.FilterFunctionContains: return "Tartalmazza";// "Contains";
                case RadGridStringId.FilterFunctionDoesNotContain: return "Nem tartalmazza"; // "Does not contain";
                case RadGridStringId.FilterFunctionEndsWith: return "Végződik";// "Ends with";
                case RadGridStringId.FilterFunctionEqualTo: return "Egyenlő";// "Equals";
                case RadGridStringId.FilterFunctionGreaterThan: return "Nagyobb mint"; // "Greater than";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Nagyobb vagy egyenlő mint";// "Greater than or equal to";
                case RadGridStringId.FilterFunctionIsEmpty: return "Üres";// "Is empty";
                case RadGridStringId.FilterFunctionIsNull: return "Null";// "Is null";
                case RadGridStringId.FilterFunctionLessThan: return "Kisebb mint";// "Less than";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Kisebb egyenlő mint"; // "Less than or equal to";
                case RadGridStringId.FilterFunctionNoFilter: return "Szűrés törlése";// "No filter";
                case RadGridStringId.FilterFunctionNotBetween: return "Not between";
                case RadGridStringId.FilterFunctionNotEqualTo: return "Nem egyenlő";// "Not equal to";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Nem üres";// "Is not empty";
                case RadGridStringId.FilterFunctionNotIsNull: return "Nem null";// "Is not null";
                case RadGridStringId.FilterFunctionStartsWith: return "Kezdődik";//"Starts with";
                case RadGridStringId.FilterFunctionCustom: return "Egyedi"; //"Custom";

                case RadGridStringId.FilterOperatorBetween: return "Between";
                case RadGridStringId.FilterOperatorContains: return "Tartalmazza";// "Contains";
                case RadGridStringId.FilterOperatorDoesNotContain: return "Nem tartalmazza";// "NotContain";
                case RadGridStringId.FilterOperatorEndsWith: return "Végződik";// "EndsWith";
                case RadGridStringId.FilterOperatorEqualTo: return "Egyenlő"; // "Equal";
                case RadGridStringId.FilterOperatorGreaterThan: return "Nagyobb mint"; //"GreaterThan";
                case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "Nagyobb vagy egyenlő"; //"GreaterThanOrEqual";
                case RadGridStringId.FilterOperatorIsEmpty: return "Üres"; //"IsEmpty";
                case RadGridStringId.FilterOperatorIsNull: return "Null"; //"IsNull";
                case RadGridStringId.FilterOperatorLessThan: return "Kisebb mint"; //"LessThan";
                case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "Kisebb egyenlő"; //"LessThanOrEqual";
                case RadGridStringId.FilterOperatorNoFilter: return "Nincs szűrés"; //"No filter";
                case RadGridStringId.FilterOperatorNotBetween: return "Nincs közte"; //"NotBetween";
                case RadGridStringId.FilterOperatorNotEqualTo: return "Nem egyenlő"; //"NotEqual";
                case RadGridStringId.FilterOperatorNotIsEmpty: return "Nem üres"; //"NotEmpty";
                case RadGridStringId.FilterOperatorNotIsNull: return "Nem null"; //"NotNull";
                case RadGridStringId.FilterOperatorStartsWith: return "Kezdődik"; //"StartsWith";
                case RadGridStringId.FilterOperatorIsLike: return "Like"; //"Like";
                case RadGridStringId.FilterOperatorNotIsLike: return "NotLike"; //"NotLike";
                case RadGridStringId.FilterOperatorIsContainedIn: return "Tartalmazza"; //"ContainedIn";
                case RadGridStringId.FilterOperatorNotIsContainedIn: return "Nem tartalmazza"; // "NotContainedIn";
                case RadGridStringId.FilterOperatorCustom: return "Egyedi"; //"Custom";

                case RadGridStringId.CustomFilterMenuItem: return "Egyedi"; //"Custom";
                case RadGridStringId.CustomFilterDialogCaption: return "Lista szűrés"; //"RadGridView Filter Dialog";
                case RadGridStringId.CustomFilterDialogLabel: return "Mutasd a sorokat ahol:"; //"Show rows where:";
                case RadGridStringId.CustomFilterDialogRbAnd: return "És"; //"And";
                case RadGridStringId.CustomFilterDialogRbOr: return "Vagy"; //"Or";
                case RadGridStringId.CustomFilterDialogBtnOk: return "OK"; //"OK";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Mégsem"; //"Cancel";
                case RadGridStringId.CustomFilterDialogCheckBoxNot: return "Nem"; //"Not";
                case RadGridStringId.CustomFilterDialogTrue: return "Igaz"; //"True";
                case RadGridStringId.CustomFilterDialogFalse: return "Hamis"; //"False";

                case RadGridStringId.FilterMenuAvailableFilters: return "Lehetséges szűrések"; //"Available Filters";
                case RadGridStringId.FilterMenuSearchBoxText: return "Keresés..."; //"Search...";
                case RadGridStringId.FilterMenuClearFilters: return "Szűrés törlése"; //"Clear Filter";
                case RadGridStringId.FilterMenuButtonOK: return "OK"; //"OK";
                case RadGridStringId.FilterMenuButtonCancel: return "Mégsem"; //"Cancel";
                case RadGridStringId.FilterMenuSelectionAll: return "Összes"; //"All";
                case RadGridStringId.FilterMenuSelectionAllSearched: return "Összes keresési eredmény"; //"All Search Result";
                case RadGridStringId.FilterMenuSelectionNull: return "Null"; //"Null";
                case RadGridStringId.FilterMenuSelectionNotNull: return "Nem null"; //"Not Null";

                case RadGridStringId.FilterLogicalOperatorAnd: return "AND";
                case RadGridStringId.FilterLogicalOperatorOr: return "OR";
                case RadGridStringId.FilterCompositeNotOperator: return "NOT";

                case RadGridStringId.DeleteRowMenuItem: return "Sor törlése"; //"Delete Row";
                case RadGridStringId.SortAscendingMenuItem: return "Növekvő rendezés"; //"Sort Ascending";
                case RadGridStringId.SortDescendingMenuItem: return "Csökkenő rendezés"; //"Sort Descending";
                case RadGridStringId.ClearSortingMenuItem: return "Rendezés törlése"; //"Clear Sorting";
                case RadGridStringId.ConditionalFormattingMenuItem: return "Formázási feltételek"; //"Conditional Formatting";
                case RadGridStringId.GroupByThisColumnMenuItem: return "Csoportosítás az oszlop szerint"; //"Group by this column";
                case RadGridStringId.UngroupThisColumn: return "Csoportosítás megszüntetése"; //"Ungroup this column";
                case RadGridStringId.ColumnChooserMenuItem: return "Oszlop választó"; //"Column Chooser";
                case RadGridStringId.HideMenuItem: return "Oszlop elrejtése"; //"Hide Column";
                case RadGridStringId.UnpinMenuItem: return "Oszlop rögzítés feloldása"; //"Unpin Column";
                case RadGridStringId.UnpinRowMenuItem: return "Sor rögzítés feloldása"; //"Unpin Row";
                case RadGridStringId.PinMenuItem: return "Rögzítés állapota"; //"Pinned state";
                case RadGridStringId.PinAtLeftMenuItem: return "Balra rögzít"; //"Pin at left";
                case RadGridStringId.PinAtRightMenuItem: return "Jobbra rögzít"; //"Pin at right";
                case RadGridStringId.PinAtBottomMenuItem: return "Alúlra rögzít"; //"Pin at bottom";
                case RadGridStringId.PinAtTopMenuItem: return "Felűlre rögzít"; //"Pin at top";
                case RadGridStringId.BestFitMenuItem: return "Legjobb kitöltés"; //"Best Fit";
                case RadGridStringId.PasteMenuItem: return "Beillesztés"; //"Paste";
                case RadGridStringId.EditMenuItem: return "Szerkesztés"; //"Edit";
                case RadGridStringId.ClearValueMenuItem: return "Érték törlése"; //"Clear Value";
                case RadGridStringId.CopyMenuItem: return "Másolás"; //"Copy";
                case RadGridStringId.AddNewRowString: return "Ide kattintva új sort adhata listához";//"Click here to add a new row";
                case RadGridStringId.ConditionalFormattingCaption: return "Formázási feltétel szabályok"; //"Conditional Formatting Rules Manager";
                case RadGridStringId.ConditionalFormattingLblColumn: return "Csak azokat a cellákat formázza ami"; //"Format only cells with";
                case RadGridStringId.ConditionalFormattingLblName: return "Szabály neve:";//"Rule name:";
                case RadGridStringId.ConditionalFormattingLblType: return "Mező érték:";//"Cell value:";
                case RadGridStringId.ConditionalFormattingLblValue1: return "Érték 1:";//"Value 1:";
                case RadGridStringId.ConditionalFormattingLblValue2: return "Érték 2:";//"Value 2:";
                case RadGridStringId.ConditionalFormattingGrpConditions: return "Szabályok";// "Rules";
                case RadGridStringId.ConditionalFormattingGrpProperties: return "Szabály tulajdonságok"; //"Rule Properties";
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Szabály alkalmazása az összes sorra"; //"Apply this rule to entire row";
                case RadGridStringId.ConditionalFormattingBtnAdd: return "Új szabály hozzáadása"; //"Add new rule";
                case RadGridStringId.ConditionalFormattingBtnRemove: return "Kiválasztott szabály elvétele"; //"Remove selected rule";
                case RadGridStringId.ConditionalFormattingBtnOK: return "OK"; //"OK";
                case RadGridStringId.ConditionalFormattingBtnCancel: return "Mégsem"; //"Cancel";
                case RadGridStringId.ConditionalFormattingBtnApply: return "Alkalmaz"; //"Apply";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "Szabály alkalmazása:"; //"Rule applies on:";
                case RadGridStringId.ConditionalFormattingChooseOne: return "[Válassz]"; //"[Choose one]";
                case RadGridStringId.ConditionalFormattingEqualsTo: return "egyenlő [Érték1]"; //"equals to [Value1]";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "nem egyenlő [Érték1]"; //"is not equal to [Value1]";
                case RadGridStringId.ConditionalFormattingStartsWith: return "kezdődik [Érték1]"; //"starts with [Value1]";
                case RadGridStringId.ConditionalFormattingEndsWith: return "végződik [Érték1]"; //"ends with [Value1]";
                case RadGridStringId.ConditionalFormattingContains: return "tartalmazza [Érték1]"; //"contains [Value1]";
                case RadGridStringId.ConditionalFormattingDoesNotContain: return "nem tartalmazza [Érték1]"; //"does not contain [Value1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThan: return "nagyobb mint [Érték1]"; //"is greater than [Value1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "nagyobb egyenlő mint [Érték1]"; //"is greater than or equal [Value1]";
                case RadGridStringId.ConditionalFormattingIsLessThan: return "kevesebb mint [Érték1]"; //"is less than [Value1]";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "kisebb egyenlő mint [Érték1]"; //"is less than or equal to [Value1]";
                case RadGridStringId.ConditionalFormattingIsBetween: return "[Érték1] és [Érték2] között van"; //"is between [Value1] and [Value2]";
                case RadGridStringId.ConditionalFormattingIsNotBetween: return "nincs [Érték1] és [Érték2] között"; //"is not between [Value1] and [Value1]";

                case RadGridStringId.ColumnChooserFormCaption: return "Oszlop választó";// "Column Chooser";
                case RadGridStringId.ColumnChooserFormMessage: return "Húzza ide az eltávolítandó\noszlopot a listából."; //"Drag a column header from the\ngrid here to remove it from\nthe current view.";
                case RadGridStringId.GroupingPanelDefaultMessage: return "Húzza ide a csoportosítandó oszlopot";// "Drag a column here to group by this column.";
                case RadGridStringId.GroupingPanelHeader: return "Csoportosítás:";// "Group by:";
                case RadGridStringId.NoDataText: return "Nincs megjeleníthető adat"; //"No data to display";
                case RadGridStringId.CompositeFilterFormErrorCaption: return "filter hiba";// "Filter Error";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}