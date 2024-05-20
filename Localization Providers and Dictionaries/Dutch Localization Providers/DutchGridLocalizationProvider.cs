using Telerik.WinControls.UI.Localization;

namespace Gui.Localization
{
    public class DutchGridLocalizationProvider : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.AddNewRowString: return "Klik hier om een nieuwe rij toe te voegen";
                case RadGridStringId.BestFitMenuItem: return "Automatische grootte";
                case RadGridStringId.ClearSortingMenuItem: return "Verwijder sortering";
                case RadGridStringId.ClearValueMenuItem: return "Waarde wissen";
                case RadGridStringId.ColumnChooserFormCaption: return "Kolomkiezer";
                case RadGridStringId.ColumnChooserFormMessage: return "Om een kolom te verbergen, sleep hem naar dit venster";
                case RadGridStringId.ColumnChooserMenuItem: return "Kolomkiezer";
                case RadGridStringId.ConditionalFormattingBtnAdd: return "Toevoegen";
                case RadGridStringId.ConditionalFormattingBtnApply: return "Toepassen";
                case RadGridStringId.ConditionalFormattingBtnCancel: return "&Annuleren";
                case RadGridStringId.ConditionalFormattingBtnOK: return "&OK";
                case RadGridStringId.ConditionalFormattingBtnRemove: return "Verwijder";
                case RadGridStringId.ConditionalFormattingCaption: return "Voorwaardelijke opmaak";
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Toepassen op rij";
                case RadGridStringId.ConditionalFormattingChooseOne: return "[Kies voorwaarde]";
                case RadGridStringId.ConditionalFormattingContains: return "bevat [Waarde1]";
                case RadGridStringId.ConditionalFormattingDoesNotContain: return "bevat niet [Waarde1]";
                case RadGridStringId.ConditionalFormattingEndsWith: return "eindigt op [Waarde1]";
                case RadGridStringId.ConditionalFormattingEqualsTo: return "gelijk aan [Waarde1]";
                case RadGridStringId.ConditionalFormattingGrpConditions: return "Voorwaarden";
                case RadGridStringId.ConditionalFormattingGrpProperties: return "Eigenschappen";
                case RadGridStringId.ConditionalFormattingIsBetween: return "ligt tussen [Waarde1] en [Waarde2]";
                case RadGridStringId.ConditionalFormattingIsGreaterThan: return "is groter dan [Waarde1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "is groter dan of gelijk aan [Waarde1]";
                case RadGridStringId.ConditionalFormattingIsLessThan: return "is kleiner dan [Waarde1]";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "is kleiner dan of gelijk aan [Waarde1]";
                case RadGridStringId.ConditionalFormattingIsNotBetween: return "is niet tussen [Waarde1] en [Waarde1]";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "is niet gelijk aan [Waarde1]";
                case RadGridStringId.ConditionalFormattingLblColumn: return "Kolom:";
                case RadGridStringId.ConditionalFormattingLblName: return "Naam:";
                case RadGridStringId.ConditionalFormattingLblType: return "Type";
                case RadGridStringId.ConditionalFormattingLblValue1: return "Waarde 1";
                case RadGridStringId.ConditionalFormattingLblValue2: return "Waarde 2";
                case RadGridStringId.ConditionalFormattingMenuItem: return "Voorwaardelijke opmaak";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "Regel van toepassing op:";
                case RadGridStringId.ConditionalFormattingStartsWith: return "begint met [Waarde1]";
                case RadGridStringId.CopyMenuItem: return "Kopiëren";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "&Annuleren";
                case RadGridStringId.CustomFilterDialogBtnOk: return "&OK";
                case RadGridStringId.CustomFilterDialogCaption: return "Aangepast filter";
                case RadGridStringId.CustomFilterDialogCheckBoxNot: return "Niet";
                case RadGridStringId.CustomFilterDialogLabel: return "Toon rijen die";
                case RadGridStringId.CustomFilterDialogRbAnd: return "En";
                case RadGridStringId.CustomFilterDialogRbOr: return "Of";
                case RadGridStringId.CustomFilterMenuItem: return "Aangepast menu";
                case RadGridStringId.DeleteRowMenuItem: return "Verwijder rij";
                case RadGridStringId.EditMenuItem: return "Bewerken";
                case RadGridStringId.FilterFunctionBetween: return "Tussen";
                case RadGridStringId.FilterFunctionContains: return "Bevat";
                case RadGridStringId.FilterFunctionCustom: return "Aangepast";
                case RadGridStringId.FilterFunctionDoesNotContain: return "Bevat niet";
                case RadGridStringId.FilterFunctionEndsWith: return "Eindigt op";
                case RadGridStringId.FilterFunctionEqualTo: return "Gelijk aan";
                case RadGridStringId.FilterFunctionGreaterThan: return "Groter dan";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Groter dan of gelijk aan";
                case RadGridStringId.FilterFunctionIsEmpty: return "Is leeg";
                case RadGridStringId.FilterFunctionIsNull: return "Is nul";
                case RadGridStringId.FilterFunctionLessThan: return "Kleiner dan";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Kleiner dan of gelijk aan";
                case RadGridStringId.FilterFunctionNoFilter: return "Geen filter";
                case RadGridStringId.FilterFunctionNotBetween: return "Niet tussen";
                case RadGridStringId.FilterFunctionNotEqualTo: return "Niet gelijk aan";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Niet leeg";
                case RadGridStringId.FilterFunctionNotIsNull: return "Niet nul";
                case RadGridStringId.FilterFunctionStartsWith: return "Begint met";
                case RadGridStringId.FilterOperatorBetween: return "Tussen";
                case RadGridStringId.FilterOperatorContains: return "Bevat";
                case RadGridStringId.FilterOperatorCustom: return "Aangepast filter";
                case RadGridStringId.FilterOperatorDoesNotContain: return "Bevat niet";
                case RadGridStringId.FilterOperatorEndsWith: return "Eindigt op";
                case RadGridStringId.FilterOperatorEqualTo: return "Gelijk aan";
                case RadGridStringId.FilterOperatorGreaterThan: return "Groter dan";
                case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "Groter dan of gelijk aan";
                case RadGridStringId.FilterOperatorIsContainedIn: return "Opgenomen in";
                case RadGridStringId.FilterOperatorIsEmpty: return "Is leeg";
                case RadGridStringId.FilterOperatorIsLike: return "Is ongeveer";
                case RadGridStringId.FilterOperatorIsNull: return "Is nul";
                case RadGridStringId.FilterOperatorLessThan: return "Kleiner dan";
                case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "Kleiner dan of gelijk aan";
                case RadGridStringId.FilterOperatorNoFilter: return "Geen filter";
                case RadGridStringId.FilterOperatorNotBetween: return "Niet tussen";
                case RadGridStringId.FilterOperatorNotEqualTo: return "Niet gelijk aan";
                case RadGridStringId.FilterOperatorNotIsContainedIn: return "Niet opgenomen in";
                case RadGridStringId.FilterOperatorNotIsEmpty: return "Is niet leeg";
                case RadGridStringId.FilterOperatorNotIsLike: return "Is ongeveer";
                case RadGridStringId.FilterOperatorNotIsNull: return "Is niet nul";
                case RadGridStringId.FilterOperatorStartsWith: return "Begint met";
                case RadGridStringId.GroupByThisColumnMenuItem: return "Groeperen op deze kolom";
                case RadGridStringId.GroupingPanelDefaultMessage: return "Sleep hier een kolom naar toe om daarop te groeperen";
                case RadGridStringId.GroupingPanelHeader: return "Gegroepeerd op:";
                case RadGridStringId.HideMenuItem: return "Verbergen";
                case RadGridStringId.NoDataText: return "Er is geen data beschikbaar";
                case RadGridStringId.PasteMenuItem: return "Plakken";
                case RadGridStringId.PinAtLeftMenuItem: return "Kolom links vastzetten";
                case RadGridStringId.PinAtRightMenuItem: return "Kolom rechts vastzetten";
                case RadGridStringId.PinMenuItem: return "Vastmaken";
                case RadGridStringId.SortAscendingMenuItem: return "Sorteer oplopend";
                case RadGridStringId.SortDescendingMenuItem: return "Sorteer aflopend";
                case RadGridStringId.UngroupThisColumn: return "Niet langer groeperen op";
                case RadGridStringId.UnpinMenuItem: return "Kolom losmaken";
                case RadGridStringId.FilterMenuButtonCancel: return "&Annuleren";
                case RadGridStringId.FilterMenuButtonOK: return "&OK";
                case RadGridStringId.PinAtBottomMenuItem: return "Onderaan vastzetten";
                case RadGridStringId.PinAtTopMenuItem: return "Bovenaan vastzetten";
                case RadGridStringId.UnpinRowMenuItem: return "Rij losmaken";

                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}