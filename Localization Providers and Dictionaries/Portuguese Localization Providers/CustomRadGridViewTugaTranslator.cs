using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI.Localization;

namespace CRMOS
{
    class CustomRadGridViewTugaTranslator:RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.GroupingPanelDefaultMessage: return "Arraste para aqui uma coluna para odernar por essa mesma coluna";
                case RadGridStringId.NoDataText: return "Sem dados";
                case RadGridStringId.FilterFunctionBetween: return "Entre"; //Between           
                case RadGridStringId.FilterFunctionContains: return "Contem"; //Contains            
                case RadGridStringId.FilterFunctionDoesNotContain: return "Não contem"; //Does not contain            
                case RadGridStringId.FilterFunctionEndsWith: return "Acaba com"; //Ends with            
                case RadGridStringId.FilterFunctionEqualTo: return "Igual"; //Equals            
                case RadGridStringId.FilterFunctionGreaterThan: return "Maior que"; //Greater than           
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Maior ou igual que"; //Greater than or equal to           
                case RadGridStringId.FilterFunctionIsEmpty: return "É vazio"; //Is empty           
                case RadGridStringId.FilterFunctionIsNull: return "É nulo"; //Is null          
                case RadGridStringId.FilterFunctionLessThan: return "Menor que"; //Less than            
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Menor ou igual que"; //Less than or equal to            
                case RadGridStringId.FilterFunctionNoFilter: return "Sem filtro"; //No filter           
                case RadGridStringId.FilterFunctionNotBetween: return "Não está entre"; //Not between           
                case RadGridStringId.FilterFunctionNotEqualTo: return "Diferente de"; //Not equal to            
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Não é vazio"; //Is not empty            
                case RadGridStringId.FilterFunctionNotIsNull: return "Não é nulo"; //Is not null           
                case RadGridStringId.FilterFunctionStartsWith: return "Começa com"; //Starts with            
                case RadGridStringId.FilterFunctionCustom: return "Customizar"; //Custom            
                case RadGridStringId.CustomFilterMenuItem: return "Customizar"; //Custom           
                case RadGridStringId.CustomFilterDialogCaption: return "Custumizador de filtros"; //RadGridView Custom Filter Dialog           
                case RadGridStringId.CustomFilterDialogLabel: return "Mostrar linhas que:"; //Show rows where:           
                case RadGridStringId.CustomFilterDialogRbAnd: return "e"; //And           
                case RadGridStringId.CustomFilterDialogRbOr: return "ou"; //Or            
                case RadGridStringId.CustomFilterDialogBtnOk: return "OK"; //OK           
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Cancelar"; //Cancel           
                case RadGridStringId.DeleteRowMenuItem: return "Eleminar linha"; //Delete Row            
                case RadGridStringId.SortAscendingMenuItem: return "Ascendente"; //Sort Ascending           
                case RadGridStringId.SortDescendingMenuItem: return "Descendente"; //Sort Descending           
                case RadGridStringId.ClearSortingMenuItem: return "Limpar filtro"; //Clear Sorting           
                case RadGridStringId.ConditionalFormattingMenuItem: return "Formatação Condicional"; //Conditional Formatting           
                case RadGridStringId.GroupByThisColumnMenuItem: return "Agrupar por esta coluna"; //Group by this column           
                case RadGridStringId.UngroupThisColumn: return "Desmarcar esta coluna"; //Ungroup this column           
                case RadGridStringId.ColumnChooserMenuItem: return "Escolher coluna"; //Column Chooser           
                case RadGridStringId.HideMenuItem: return "Esconder"; //Hide           
                case RadGridStringId.UnpinMenuItem: return "Desmarcar"; //Unpin           
                case RadGridStringId.PinMenuItem: return "Marcar"; //Pin           
                case RadGridStringId.BestFitMenuItem: return "Melhor encaixe"; //Best Fit           
                case RadGridStringId.PasteMenuItem: return "Colar"; //Paste           
                case RadGridStringId.EditMenuItem: return "Editar"; //Edit           
                case RadGridStringId.CopyMenuItem: return "Copiar"; //Copy           
                case RadGridStringId.AddNewRowString: return "Clique aqui para adicionar uma nova coluna"; //Click here to add a new row           
                case RadGridStringId.ConditionalFormattingCaption: return "Customizador de filtros"; //Custom Formatting Condition Editor     
                case RadGridStringId.ConditionalFormattingLblColumn: return "Coluna:"; //Column:           
                case RadGridStringId.ConditionalFormattingLblName: return "Nome:"; //Name:            
                case RadGridStringId.ConditionalFormattingLblType: return "Tipo:"; //Type:           
                case RadGridStringId.ConditionalFormattingLblValue1: return "Valor 1:"; //Value 1:           
                case RadGridStringId.ConditionalFormattingLblValue2: return "Valor 2:"; //Value 2:           
                case RadGridStringId.ConditionalFormattingGrpConditions: return "Condições"; //Conditions           
                case RadGridStringId.ConditionalFormattingGrpProperties: return "Propriedades"; //Properties           
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Aplicar a linha"; //Apply to row           
                case RadGridStringId.ConditionalFormattingBtnAdd: return "Adicionar"; //Add           
                case RadGridStringId.ConditionalFormattingBtnRemove: return "Remover"; //Remove           
                case RadGridStringId.ConditionalFormattingBtnOK: return "OK"; //OK
                case RadGridStringId.ConditionalFormattingBtnCancel: return "Cancelar"; //Cancel           
                case RadGridStringId.ConditionalFormattingBtnApply: return "Aplicar"; //Apply           
                case RadGridStringId.ColumnChooserFormCaption: return "Seleccionador de colunas"; //Column Chooser           
                case RadGridStringId.ColumnChooserFormMessage: return @"Arraste um cabeçado de uma coluna para qui para a remover da presente vista"; //Drag a column header from the grid here to remove it from the current view.           
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}
