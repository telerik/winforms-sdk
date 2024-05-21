using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;


public class SlovenianRadGridLocalizationProvider : RadGridLocalizationProvider
{
    public override string GetLocalizedString(string id)
    {
        switch (id)
        {
            case RadGridStringId.FilterFunctionBetween: return "Med"; //Between          
            case RadGridStringId.FilterFunctionContains: return "Vsebuje"; //Contains           
            case RadGridStringId.FilterFunctionDoesNotContain: return "Ne vsebuje"; //Does not contain           
            case RadGridStringId.FilterFunctionEndsWith: return "Se konča z"; //Ends with           
            case RadGridStringId.FilterFunctionEqualTo: return "Je enako kot"; //Equals           
            case RadGridStringId.FilterFunctionGreaterThan: return "Večje kot"; //Greater than          
            case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Večje ali enako kot"; //Greater than or equal to          
            case RadGridStringId.FilterFunctionIsEmpty: return "Je prazen"; //Is empty          
            case RadGridStringId.FilterFunctionIsNull: return "Je ničen (null)"; //Is null         
            case RadGridStringId.FilterFunctionLessThan: return "Manjše kot"; //Less than           
            case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Manjše ali enako kot"; //Less than or equal to           
            case RadGridStringId.FilterFunctionNoFilter: return "Brez filtra"; //No filter          
            case RadGridStringId.FilterFunctionNotBetween: return "Ni med"; //Not between          
            case RadGridStringId.FilterFunctionNotEqualTo: return "Ni enako kot"; //Not equal to           
            case RadGridStringId.FilterFunctionNotIsEmpty: return "Ni prazen"; //Is not empty           
            case RadGridStringId.FilterFunctionNotIsNull: return "Ni ničen (null)"; //Is not null          
            case RadGridStringId.FilterFunctionStartsWith: return "Se začne z"; //Starts with           
            case RadGridStringId.FilterFunctionCustom: return "Po meri"; //Custom           
            case RadGridStringId.CustomFilterMenuItem: return "Po meri"; //Custom          
            case RadGridStringId.CustomFilterDialogCaption: return "Filter po meri"; //RadGridView Custom Filter Dialog          
            case RadGridStringId.CustomFilterDialogLabel: return "Prikaži vrstice kjer:"; //Show rows where:          
            case RadGridStringId.CustomFilterDialogRbAnd: return "In"; //And          
            case RadGridStringId.CustomFilterDialogRbOr: return "Ali"; //Or           
            case RadGridStringId.CustomFilterDialogBtnOk: return "OK"; //OK          
            case RadGridStringId.CustomFilterDialogBtnCancel: return "Prekliči"; //Cancel          
            case RadGridStringId.DeleteRowMenuItem: return "Izbriši vrstico"; //Delete Row           
            case RadGridStringId.SortAscendingMenuItem: return "Sortiraj naraščujoče"; //Sort Ascending          
            case RadGridStringId.SortDescendingMenuItem: return "Sortiraj padajoče"; //Sort Descending          
            case RadGridStringId.ClearSortingMenuItem: return "Prekliči sortiranje"; //Clear Sorting          
            case RadGridStringId.ConditionalFormattingMenuItem: return "Pogojno urejanje"; //Conditional Formatting          
            case RadGridStringId.GroupByThisColumnMenuItem: return "Grupiraj po tem stolpcu"; //Group by this column          
            case RadGridStringId.UngroupThisColumn: return "Odgrupiraj ta stolpec"; //Ungroup this column          
            case RadGridStringId.ColumnChooserMenuItem: return "Izbira stolpcev"; //Column Chooser          
            case RadGridStringId.HideMenuItem: return "Skrij"; //Hide          
            case RadGridStringId.UnpinMenuItem: return "Odpni"; //Unpin          
            case RadGridStringId.PinMenuItem: return "Pripni"; //Pin          
            case RadGridStringId.BestFitMenuItem: return "Najboljša širina stolpca"; //Best Fit          
            case RadGridStringId.PasteMenuItem: return "Prilepi"; //Paste          
            case RadGridStringId.EditMenuItem: return "Uredi"; //Edit          
            case RadGridStringId.CopyMenuItem: return "Kopiraj"; //Copy          
            case RadGridStringId.AddNewRowString: return "Kliknite tukaj za dodajanje novega zapisa"; //Click here to add a new row          
            case RadGridStringId.ConditionalFormattingCaption: return "Pogojni urejevalec po meri"; //Custom Formatting Condition Editor    
            case RadGridStringId.ConditionalFormattingLblColumn: return "Stolpec:"; //Column:          
            case RadGridStringId.ConditionalFormattingLblName: return "Ime:"; //Name:           
            case RadGridStringId.ConditionalFormattingLblType: return "Tipkaj:"; //Type:          
            case RadGridStringId.ConditionalFormattingLblValue1: return "Vrednost 1:"; //Value 1:          
            case RadGridStringId.ConditionalFormattingLblValue2: return "Vrednost 2:"; //Value 2:          
            case RadGridStringId.ConditionalFormattingGrpConditions: return "Pogoji"; //Conditions          
            case RadGridStringId.ConditionalFormattingGrpProperties: return "Lastnosti"; //Properties          
            case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Uveljavi na vrstico"; //Apply to row          
            case RadGridStringId.ConditionalFormattingBtnAdd: return "Dodaj"; //Add          
            case RadGridStringId.ConditionalFormattingBtnRemove: return "Odstrani"; //Remove          
            case RadGridStringId.ConditionalFormattingBtnOK: return "V redu"; //OK          
            case RadGridStringId.ConditionalFormattingBtnCancel: return "Prekliči"; //Cancel          
            case RadGridStringId.ConditionalFormattingBtnApply: return "Uveljavi"; //Apply          
            case RadGridStringId.ColumnChooserFormCaption: return "Izberi stolpce"; //Column Chooser          
            case RadGridStringId.ColumnChooserFormMessage: return "Povlecite glavo stolpca tukaj,\nda ga umaknete iz\ntrenutnega pogleda"; //Drag a column header from the grid here to remove it from the current view.          
            case RadGridStringId.GroupingPanelDefaultMessage: return "Povlecite stolpec v to polje za grupiranje";
            case RadGridStringId.ClearValueMenuItem: return "Izbriši vrednost"; //clear value
            case RadGridStringId.NoDataText: return "Na voljo ni nobenih podatkov."; // no data to display
            default:
                return base.GetLocalizedString(id);
        }
    }
}