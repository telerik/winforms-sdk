using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI.Localization;

namespace PersianLocalization
{
    public class PersianRadGridLocalizationProvider : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.FilterFunctionBetween: return "بین"; //Between  
                case RadGridStringId.FilterOperatorBetween: return "بین";
                case RadGridStringId.FilterFunctionContains: return "حاوی";
                case RadGridStringId.FilterOperatorContains: return "حاوی";
                case RadGridStringId.FilterFunctionDoesNotContain: return "شامل نشود"; //Does not contain
                case RadGridStringId.FilterOperatorDoesNotContain: return "شامل نشود";
                case RadGridStringId.FilterFunctionEndsWith: return "پایان پذیرد با"; //Ends with 
                case RadGridStringId.FilterOperatorEndsWith: return "پایان پذیرد با";
                case RadGridStringId.FilterFunctionEqualTo: return "برابر با"; //Equals     
                case RadGridStringId.FilterOperatorEqualTo: return "برابر با";
                case RadGridStringId.FilterFunctionGreaterThan: return "بزرگتر از"; //Greater than
                case RadGridStringId.FilterOperatorGreaterThan: return "بزرگتر از";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "بزرگتر یا مساوی با"; //Greater than or equal to 
                case RadGridStringId.FilterOperatorGreaterThanOrEqualTo: return "بزرگتر یا مساوی با";
                case RadGridStringId.FilterFunctionIsEmpty: return "خالی باشد"; //Is empty
                case RadGridStringId.FilterOperatorIsEmpty: return "خالی باشد";
                case RadGridStringId.FilterFunctionIsNull: return "باشد null"; //Is null
                case RadGridStringId.FilterOperatorIsNull: return "باشد null";
                case RadGridStringId.FilterFunctionLessThan: return "کمتر از"; //Less than 
                case RadGridStringId.FilterOperatorLessThan: return "کمتر از";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "کمتر یا مساوی با"; //Less than or equal to
                case RadGridStringId.FilterOperatorLessThanOrEqualTo: return "کمتر یا مساوی با";
                case RadGridStringId.FilterFunctionNoFilter: return "بدون شرط"; //No filter 
                case RadGridStringId.FilterOperatorNoFilter: return "بدون شرط";
                case RadGridStringId.FilterFunctionNotBetween: return "نباشد بین"; //Not between
                case RadGridStringId.FilterOperatorNotBetween: return "نباشد بین"; //Operator
                case RadGridStringId.FilterFunctionNotEqualTo: return "برابر نباشد با"; //Not equal to 
                case RadGridStringId.FilterOperatorNotEqualTo: return "برابر نباشد با";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "خالی نباشد"; //Is not empty          
                case RadGridStringId.FilterFunctionNotIsNull: return "نباشد null"; //Is not null         
                case RadGridStringId.FilterFunctionStartsWith: return "شروع شود با"; //Starts with          
                case RadGridStringId.FilterFunctionCustom: return "شرط دلخواه"; //Custom          
                case RadGridStringId.CustomFilterMenuItem: return "شرط دلخواه منو"; //Custom         
                case RadGridStringId.CustomFilterDialogCaption: return "انتخاب شرط دلخواه"; //RadGridView Custom Filter Dialog         
                case RadGridStringId.CustomFilterDialogLabel: return ":نشان دادن سطرهایی که"; //Show rows where:         
                case RadGridStringId.CustomFilterDialogRbAnd: return "و"; //And         
                case RadGridStringId.CustomFilterDialogRbOr: return "یا"; //Or          
                case RadGridStringId.CustomFilterDialogBtnOk: return "تایید"; //OK         
                case RadGridStringId.CustomFilterDialogBtnCancel: return "انصراف"; //Cancel 
                case RadGridStringId.AddNewRowString: return "برای افزودن سطر جدید اینجا کلیک کنید";
                case RadGridStringId.ClearValueMenuItem: return "پاک کردن مقدار سلول";
                case RadGridStringId.DeleteRowMenuItem: return "حذف سطر"; //Delete Row          
                case RadGridStringId.SortAscendingMenuItem: return "مرتب سازی صعودی"; //Sort Ascending         
                case RadGridStringId.SortDescendingMenuItem: return "مرتب سازی نزولی"; //Sort Descending         
                case RadGridStringId.ClearSortingMenuItem: return "حذف مرتب سازی"; //Clear Sorting         
                case RadGridStringId.ConditionalFormattingMenuItem: return "قالب بندی مشروط"; //Conditional Formatting         
                case RadGridStringId.GroupByThisColumnMenuItem: return "گروهبندی بر حسب این ستون"; //Group by this column         
                case RadGridStringId.UngroupThisColumn: return "حذف این ستون از گروهبندی "; //Ungroup this column         
                case RadGridStringId.ColumnChooserMenuItem: return "انتخابگر ستون"; //Column Chooser         
                case RadGridStringId.HideMenuItem: return "مخفی کردن ستون"; //Hide         
                case RadGridStringId.UnpinMenuItem: return "حالت پیش فرض"; //Unpin         
                case RadGridStringId.PinMenuItem: return "حالت ستون"; //Pin       
                case RadGridStringId.PinAtLeftMenuItem: return "چسپیدن به سمت چپ";
                case RadGridStringId.PinAtRightMenuItem: return "چسپیدن به سمت راست";
                case RadGridStringId.PinAtTopMenuItem: return "چسپیدن به بالا";
                case RadGridStringId.PinAtBottomMenuItem: return "چسپیدن به پایین";
                case RadGridStringId.BestFitMenuItem: return "اندازه بهینه ستون"; //Best Fit         
                case RadGridStringId.PasteMenuItem: return "چسپاندن"; //Paste         
                case RadGridStringId.EditMenuItem: return "ویرایش"; //Edit         
                case RadGridStringId.CopyMenuItem: return "کپی"; //Copy         
                case RadGridStringId.ConditionalFormattingCaption: return "قالب بندی مشروط"; //Custom Formatting Condition Editor   
                case RadGridStringId.ConditionalFormattingLblColumn: return "قالب بندی سلولهایی با شرط:"; //Column:         
                case RadGridStringId.ConditionalFormattingLblName: return "نام شرط:"; //Name:          
                case RadGridStringId.ConditionalFormattingLblType: return "مقدار سلول:"; //Type:         
                case RadGridStringId.ConditionalFormattingLblValue1: return "مقدار اول:"; //Value 1:         
                case RadGridStringId.ConditionalFormattingLblValue2: return "مقدار دوم:"; //Value 2:         
                case RadGridStringId.ConditionalFormattingGrpConditions: return "شرایط"; //Conditions         
                case RadGridStringId.ConditionalFormattingGrpProperties: return "مشخصات"; //Properties         
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "اعمال این شرط به کل سطر"; //Apply to row         
                case RadGridStringId.ConditionalFormattingBtnAdd: return "افزودن شرایط"; //Add         
                case RadGridStringId.ConditionalFormattingBtnRemove: return "حذف شرایط انتخابی"; //Remove         
                case RadGridStringId.ConditionalFormattingBtnOK: return "تایید"; //OK         
                case RadGridStringId.ConditionalFormattingBtnCancel: return "انصراف"; //Cancel         
                case RadGridStringId.ConditionalFormattingBtnApply: return "اعمال قالب بندی"; //Apply         
                case RadGridStringId.ColumnChooserFormCaption: return "انتخاب ستون ها"; //Column Chooser         
                case RadGridStringId.ColumnChooserFormMessage: return "برای حذف یکی از ستونها، آن ستون را به اینجا بکشید";//"Drag a column header from the grid here to remove it from the current view.";
                case RadGridStringId.CompositeFilterFormErrorCaption: return "خطا";
                case RadGridStringId.ConditionalFormattingChooseOne: return "[یکی را انتخاب کنید]";
                case RadGridStringId.ConditionalFormattingContains: return "[حاوی [مقدار اول";
                case RadGridStringId.ConditionalFormattingDoesNotContain: return "حاوی [مقدار اول] نباشد";
                case RadGridStringId.ConditionalFormattingEndsWith: return "با [مقدار اول] پایان یابد";
                case RadGridStringId.ConditionalFormattingEqualsTo: return "[برابر با [مقدار اول";
                case RadGridStringId.ConditionalFormattingIsBetween: return "بین [مقدار اول] و [مقدار دوم] باشد";
                case RadGridStringId.ConditionalFormattingIsGreaterThan: return "[بزرگتر از [مقدار اول";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "[بزرگتر یا مساوی با [مقدار اول";
                case RadGridStringId.ConditionalFormattingIsLessThan: return "کوچکتر از [مقدار اول]";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "کوچکتر یا مساوی با [مقدار اول]";
                case RadGridStringId.ConditionalFormattingIsNotBetween: return "بین [مقدار اول] و [مقدار دوم] نباشد";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "برابر با [مقدار اول] نباشد";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "اعمال شرایط روی:";
                case RadGridStringId.ConditionalFormattingStartsWith: return "با [مقدار اول] شروع می شود";
                case RadGridStringId.CustomFilterDialogCheckBoxNot: return "با این شرایط نباشد";
                case RadGridStringId.CustomFilterDialogFalse: return "False";
                case RadGridStringId.CustomFilterDialogTrue: return "True";
                case RadGridStringId.FilterCompositeNotOperator: return "نباشد";
                case RadGridStringId.FilterLogicalOperatorAnd: return "و";
                case RadGridStringId.FilterLogicalOperatorOr: return "یا";
                case RadGridStringId.FilterMenuAvailableFilters: return "فیلتر شده";
                case RadGridStringId.FilterMenuButtonCancel: return "انصراف";
                case RadGridStringId.FilterMenuButtonOK: return "تایید";
                case RadGridStringId.FilterMenuClearFilters: return "پاک کردن فیلتر";
                case RadGridStringId.FilterMenuSearchBoxText: return "جستجو...";
                case RadGridStringId.FilterMenuSelectionAll: return "همه";
                case RadGridStringId.FilterMenuSelectionAllSearched: return "نتیجه همه جستجو";
                case RadGridStringId.FilterMenuSelectionNotNull: return "نباشد null";
                case RadGridStringId.FilterMenuSelectionNull: return "باشد null";
                case RadGridStringId.FilterOperatorCustom: return "دلخواه";
                case RadGridStringId.FilterOperatorIsLike: return "مانند";
                case RadGridStringId.FilterOperatorNotIsContainedIn: return "نباشد در";
                case RadGridStringId.FilterOperatorNotIsEmpty: return "خالی نباشد";
                case RadGridStringId.FilterOperatorNotIsLike: return "نباشد شبیه";
                case RadGridStringId.FilterOperatorNotIsNull: return "نباشد null";
                case RadGridStringId.FilterOperatorStartsWith: return "شروع شود با";
                case RadGridStringId.GroupingPanelDefaultMessage: return "برای گروهبندی ستونها، ستونی را به اینجا بکشید";
                case RadGridStringId.GroupingPanelHeader: return ":گروهبندی بر حسب";
                case RadGridStringId.NoDataText: return "داده ای برای نمایش وجود ندارد";
                case RadGridStringId.UnpinRowMenuItem: return "حالت پیش فرض";

                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}
