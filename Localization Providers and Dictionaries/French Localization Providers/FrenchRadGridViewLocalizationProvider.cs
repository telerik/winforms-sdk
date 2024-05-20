using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI.Localization;

namespace GermanRadGridViewLocalization
{
    public class FrenchRadGridViewLocalizationProvider : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.FilterFunctionBetween: return "Compris entre";
                case RadGridStringId.FilterFunctionContains: return "Contient";
                case RadGridStringId.FilterFunctionDoesNotContain: return "Ne contient pas";
                case RadGridStringId.FilterFunctionEndsWith: return "Finit par";
                case RadGridStringId.FilterFunctionEqualTo: return "Est égal à";
                case RadGridStringId.FilterFunctionGreaterThan: return "Est supérieur à";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Est supérieur ou égal à";
                case RadGridStringId.FilterFunctionIsEmpty: return "Est vide";
                case RadGridStringId.FilterFunctionIsNull: return "Est nul";
                case RadGridStringId.FilterFunctionLessThan: return "Est inférieur à";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Est inférieur ou égal à";
                case RadGridStringId.FilterFunctionNoFilter: return "Pas de filtre";
                case RadGridStringId.FilterFunctionNotBetween: return "Non compris entre";
                case RadGridStringId.FilterFunctionNotEqualTo: return "Est différent de";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Est non vide";
                case RadGridStringId.FilterFunctionNotIsNull: return "Est non nul";
                case RadGridStringId.FilterFunctionStartsWith: return "Commence par";
                case RadGridStringId.FilterFunctionCustom: return "Filtre personnalisé";
                case RadGridStringId.CustomFilterMenuItem: return "Menu filtre personnalisé";
                case RadGridStringId.CustomFilterDialogCaption: return "Filtre personnalisé";
                case RadGridStringId.CustomFilterDialogLabel: return "Afficher les lignes où";
                case RadGridStringId.CustomFilterDialogRbAnd: return "Et";
                case RadGridStringId.CustomFilterDialogRbOr: return "Ou";
                case RadGridStringId.CustomFilterDialogBtnOk: return "OK";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Annuler";
                case RadGridStringId.DeleteRowMenuItem: return "Effacer la ligne";
                case RadGridStringId.SortAscendingMenuItem: return "Trier (ordre croissant)";
                case RadGridStringId.SortDescendingMenuItem: return "Trier (ordre décroissant)";
                case RadGridStringId.ClearSortingMenuItem: return "Annuler les tris";
                case RadGridStringId.ConditionalFormattingMenuItem: return "Formatage conditionnel";
                case RadGridStringId.GroupByThisColumnMenuItem: return "Grouper par cette colonne";
                case RadGridStringId.UngroupThisColumn: return "Dégrouper cette colonne";
                case RadGridStringId.ColumnChooserMenuItem: return "Masqueur de colonnes";
                case RadGridStringId.HideMenuItem: return "Masquer cette colonne";
                case RadGridStringId.UnpinMenuItem: return "Masquer automatiquement";
                case RadGridStringId.PinMenuItem: return "Epingler";
                case RadGridStringId.BestFitMenuItem: return "Ajuster la taille de la colonne";
                case RadGridStringId.PasteMenuItem: return "Coller";
                case RadGridStringId.EditMenuItem: return "Edition";
                case RadGridStringId.CopyMenuItem: return "Copier";
                case RadGridStringId.AddNewRowString: return "Cliquer pour ajouter une nouvelle ligne";
                case RadGridStringId.ConditionalFormattingCaption: return "Surligneur conditionnel";
                case RadGridStringId.ConditionalFormattingLblColumn: return "Colonne:";
                case RadGridStringId.ConditionalFormattingLblName: return "Nom:";
                case RadGridStringId.ConditionalFormattingLblType: return "Type:";
                case RadGridStringId.ConditionalFormattingLblValue1: return "Valeur 1:";
                case RadGridStringId.ConditionalFormattingLblValue2: return "Valeur 2:";
                case RadGridStringId.ConditionalFormattingGrpConditions: return "Conditions";
                case RadGridStringId.ConditionalFormattingGrpProperties: return "Propriétés";
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Appliquer aux lignes existantes";
                case RadGridStringId.ConditionalFormattingBtnAdd: return "Ajouter";
                case RadGridStringId.ConditionalFormattingBtnRemove: return "Supprimer";
                case RadGridStringId.ConditionalFormattingBtnOK: return "OK";
                case RadGridStringId.ConditionalFormattingBtnCancel: return "Annuler";
                case RadGridStringId.ConditionalFormattingBtnApply: return "Appliquer";
                case RadGridStringId.ColumnChooserFormCaption: return "Masqueur de colonnes";
                case RadGridStringId.ColumnChooserFormMessage: return "Ajouter ici une colonne\npour la faire disparaitre\ntemporairement de la vue";
                case RadGridStringId.GroupingPanelDefaultMessage: return "Ajouter ici une colonne pour faire un regroupement par cette colonne";
                case RadGridStringId.ClearValueMenuItem: return "Effacer la Valeur";
                case RadGridStringId.ConditionalFormattingContains: return "Contient [Valeur1]";
                case RadGridStringId.ConditionalFormattingDoesNotContain: return "Ne contient pas [Valeur1]";
                case RadGridStringId.ConditionalFormattingEndsWith: return "Finit par [Valeur1]";
                case RadGridStringId.ConditionalFormattingEqualsTo: return "Est égal à [Valeur1]";
                case RadGridStringId.ConditionalFormattingIsBetween: return "Est compris entre [Valeur1] et [Valeur2]";
                case RadGridStringId.ConditionalFormattingIsGreaterThan: return "Est supérieur à [Valeur1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "Est supérieur ou égal à [Valeur1]";
                case RadGridStringId.ConditionalFormattingIsLessThan: return "Est inférieur à [Valeur1]";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "Est inférieur ou égal à [Valeur1]";
                case RadGridStringId.ConditionalFormattingIsNotBetween: return "Non compris entre [Valeur1] et [Valeur2]";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "Est différent de [Valeur1]";
                case RadGridStringId.ConditionalFormattingStartsWith: return "Commence par [Valeur1]";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "La règle s'applique au champ:";
                case RadGridStringId.ConditionalFormattingChooseOne: return "[Choisir un type]";
                case RadGridStringId.NoDataText: return "Pas de données à afficher";

                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}
