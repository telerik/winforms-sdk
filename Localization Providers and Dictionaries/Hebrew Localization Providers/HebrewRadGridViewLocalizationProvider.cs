using Telerik.WinControls.UI.Localization;
using System.Threading;
public class HebrewRadGridLocalizationProvider : RadGridLocalizationProvider
{
    public HebrewRadGridLocalizationProvider()
    {
    }

    public override string GetLocalizedString(string id)
    {
        switch (id)
        {
            // Filter
            case RadGridStringId.FilterFunctionBetween: return "בין";
            case RadGridStringId.FilterFunctionContains: return "מכיל";
            case RadGridStringId.FilterFunctionDoesNotContain: return "לא מכיל";
            case RadGridStringId.FilterFunctionEndsWith: return "נגמר ב";
            case RadGridStringId.FilterFunctionEqualTo: return "שווה ל";
            case RadGridStringId.FilterFunctionGreaterThan: return "גדול מ";
            case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "שווה או גדול מ";
            case RadGridStringId.FilterFunctionIsEmpty: return "ריק";
            case RadGridStringId.FilterFunctionIsNull: return "לא תקף";
            case RadGridStringId.FilterFunctionLessThan: return "קטן מ";
            case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "שווה או קטן מ";
            case RadGridStringId.FilterFunctionNoFilter: return "ללא סינון";
            case RadGridStringId.FilterFunctionNotBetween: return "לא בין";
            case RadGridStringId.FilterFunctionNotEqualTo: return "לא שווה ל";
            case RadGridStringId.FilterFunctionNotIsEmpty: return "לא ריק";
            case RadGridStringId.FilterFunctionNotIsNull: return "תקף";
            case RadGridStringId.FilterFunctionStartsWith: return "מתחיל ב";
            case RadGridStringId.FilterFunctionCustom: return "מותאם אישית";

            case RadGridStringId.CustomFilterMenuItem: return "מותאם אישית"; //Custom          
            case RadGridStringId.CustomFilterDialogCaption: return "דיאלוג סינון"; //RadGridView Custom Filter Dialog          
            case RadGridStringId.CustomFilterDialogLabel: return "הצג רשומות ש:"; //Show rows where:          
            case RadGridStringId.CustomFilterDialogRbAnd: return "וגם"; //And          
            case RadGridStringId.CustomFilterDialogRbOr: return "או"; //Or           
            case RadGridStringId.CustomFilterDialogBtnOk: return "אישור"; //OK          
            case RadGridStringId.CustomFilterDialogBtnCancel: return "ביטול"; //Cancel   


            case RadGridStringId.DeleteRowMenuItem: return "מחק שורה";
            case RadGridStringId.SortAscendingMenuItem: return "מיון בסדר יורד";
            case RadGridStringId.SortDescendingMenuItem: return "מיון בסדר עולה";
            case RadGridStringId.ClearSortingMenuItem: return "בטל מיון";
            case RadGridStringId.ConditionalFormattingMenuItem: return "עיצוב מותנה";
            case RadGridStringId.GroupByThisColumnMenuItem: return "קבץ לפי העמודה הזאת";
            case RadGridStringId.UngroupThisColumn: return "בטל קיבוץ";
            case RadGridStringId.ColumnChooserMenuItem: return "בחר עמודה";
            case RadGridStringId.HideMenuItem: return "הסתר";
            case RadGridStringId.PinMenuItem: return "הצמד";
            case RadGridStringId.UnpinMenuItem: return "בטל הצמדה";
            case RadGridStringId.BestFitMenuItem: return "התאמה מיטבית";
            case RadGridStringId.CopyMenuItem: return "העתק";
            case RadGridStringId.PasteMenuItem: return "הדבק";
            case RadGridStringId.EditMenuItem: return "ערוך";
            case RadGridStringId.ClearValueMenuItem: return "נקה ערכים";
            case RadGridStringId.AddNewRowString: return "הוסף שורה";

            case RadGridStringId.ConditionalFormattingCaption: return "עיצוב מותאם אישית מצב עורך";
            case RadGridStringId.ConditionalFormattingLblColumn: return "עמודה:";
            case RadGridStringId.ConditionalFormattingLblName: return "שם:"; //Name:           
            case RadGridStringId.ConditionalFormattingLblType: return "סוג:"; //Type:          
            case RadGridStringId.ConditionalFormattingLblValue1: return "ערך 1:"; //Value 1:          
            case RadGridStringId.ConditionalFormattingLblValue2: return "ערך 2:"; //Value 2:          
            case RadGridStringId.ConditionalFormattingGrpConditions: return "תנאים"; //Conditions          
            case RadGridStringId.ConditionalFormattingGrpProperties: return "מאפיינים"; //Properties          
            case RadGridStringId.ConditionalFormattingChkApplyToRow: return "החל בשורה"; //Apply to row          
            case RadGridStringId.ConditionalFormattingBtnAdd: return "הוסף"; //Add          
            case RadGridStringId.ConditionalFormattingBtnRemove: return "מחק"; //Remove          
            case RadGridStringId.ConditionalFormattingBtnOK: return "אישור"; //OK          
            case RadGridStringId.ConditionalFormattingBtnCancel: return "ביטול"; //Cancel          
            case RadGridStringId.ConditionalFormattingBtnApply: return "החל"; //Apply     
            case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "תקף על";
            case RadGridStringId.ConditionalFormattingChooseOne: return "בחר אחד";
            case RadGridStringId.ConditionalFormattingEqualsTo: return "שווה ל";
            case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "";
            case RadGridStringId.ConditionalFormattingStartsWith: return "מתחיל ב";
            case RadGridStringId.ConditionalFormattingEndsWith: return "נגמר ב";
            case RadGridStringId.ConditionalFormattingContains: return "מכיל";
            case RadGridStringId.ConditionalFormattingDoesNotContain: return "לא מכיל";
            case RadGridStringId.ConditionalFormattingIsGreaterThan: return "גדול מ";
            case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "שווה או גדול מ";
            case RadGridStringId.ConditionalFormattingIsLessThan: return "קטן מ";
            case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "שווה או קטן מ";
            case RadGridStringId.ConditionalFormattingIsBetween: return "בין";
            case RadGridStringId.ConditionalFormattingIsNotBetween: return "לא בין";



            case RadGridStringId.ColumnChooserFormCaption: return "בחר עמודה"; //Column Chooser          
            case RadGridStringId.ColumnChooserFormMessage: return "גרור את כותרת העמודה על מנת להסירה מהתצוגה הנוכחית."; //Drag a column header from the grid here to remove it from the current view.          

            case RadGridStringId.GroupingPanelDefaultMessage: return "גרור עמודה לכאן על מנת לקבץ לפיה";

            case RadGridStringId.NoDataText: return "אין מידע";

            default:
                return base.GetLocalizedString(id);
        }
    }

}