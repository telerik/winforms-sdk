using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI.Localization;

namespace LocProviders
{
    public class ItalianGridViewLocalizationProvider : RadGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadGridStringId.FilterFunctionBetween: return "Compreso tra";
                case RadGridStringId.FilterFunctionContains: return "Contiene";
                case RadGridStringId.FilterFunctionDoesNotContain: return "Non contiene";
                case RadGridStringId.FilterFunctionEndsWith: return "Finisce per";
                case RadGridStringId.FilterFunctionEqualTo: return "Uguale";
                case RadGridStringId.FilterFunctionGreaterThan: return "Più grande di";
                case RadGridStringId.FilterFunctionGreaterThanOrEqualTo: return "Più grande o uguale a";
                case RadGridStringId.FilterFunctionIsEmpty: return "E' vuoto";
                case RadGridStringId.FilterFunctionIsNull: return "E' nullo";
                case RadGridStringId.FilterFunctionLessThan: return "Minore di";
                case RadGridStringId.FilterFunctionLessThanOrEqualTo: return "Minore o uguale a";
                case RadGridStringId.FilterFunctionNoFilter: return "Nessun filtro";
                case RadGridStringId.FilterFunctionNotBetween: return "Non compreso tra";
                case RadGridStringId.FilterFunctionNotEqualTo: return "Non uguale a";
                case RadGridStringId.FilterFunctionNotIsEmpty: return "Non è vuoto";
                case RadGridStringId.FilterFunctionNotIsNull: return "Non è nullo";
                case RadGridStringId.FilterFunctionStartsWith: return "Inizia per";
                case RadGridStringId.FilterFunctionCustom: return "Personalizzato";
                case RadGridStringId.CustomFilterMenuItem: return "Personalizzato";
                case RadGridStringId.CustomFilterDialogCaption: return "Impostazioni filtro personalizzate";
                case RadGridStringId.CustomFilterDialogLabel: return "Mostra righe dove:";
                case RadGridStringId.CustomFilterDialogRbAnd: return "AND";
                case RadGridStringId.CustomFilterDialogRbOr: return "OR";
                case RadGridStringId.CustomFilterDialogBtnOk: return "OK";
                case RadGridStringId.CustomFilterDialogBtnCancel: return "Annulla";
                case RadGridStringId.DeleteRowMenuItem: return "Cancella riga";
                case RadGridStringId.SortAscendingMenuItem: return "Ordinamento crescente";
                case RadGridStringId.SortDescendingMenuItem: return "Ordinamento discendente";
                case RadGridStringId.ClearSortingMenuItem: return "Annulla ordinamento";
                case RadGridStringId.ConditionalFormattingMenuItem: return "Formattazione condizionale";
                case RadGridStringId.GroupByThisColumnMenuItem: return "Raggruppa su questa colonna";
                case RadGridStringId.UngroupThisColumn: return "Annulla ragruppamento sulla colonna";
                case RadGridStringId.ColumnChooserMenuItem: return "Selezione colonne";
                case RadGridStringId.HideMenuItem: return "Nascondi colonna";
                case RadGridStringId.UnpinMenuItem: return "Sblocca colonna";
                case RadGridStringId.PinMenuItem: return "Blocca colonna";
                case RadGridStringId.BestFitMenuItem: return "Miglior dimensione";
                case RadGridStringId.PasteMenuItem: return "Incolla";
                case RadGridStringId.EditMenuItem: return "Modifica";
                case RadGridStringId.ClearValueMenuItem: return "Annulla valore";
                case RadGridStringId.CopyMenuItem: return "Copia";
                case RadGridStringId.AddNewRowString: return "Cliccare qui per aggiungere una nuova riga";
                case RadGridStringId.ConditionalFormattingCaption: return "Gestione regole per la formattazione condizionale";
                case RadGridStringId.ConditionalFormattingLblColumn: return "Formatta solo le celle con";
                case RadGridStringId.ConditionalFormattingLblName: return "Nome regola:";
                case RadGridStringId.ConditionalFormattingLblType: return "Valore cella:";
                case RadGridStringId.ConditionalFormattingLblValue1: return "Valore 1:";
                case RadGridStringId.ConditionalFormattingLblValue2: return "Valore 2:";
                case RadGridStringId.ConditionalFormattingGrpConditions: return "Regole";
                case RadGridStringId.ConditionalFormattingGrpProperties: return "Proprietà regola";
                case RadGridStringId.ConditionalFormattingChkApplyToRow: return "Applica questa regola all'intera riga";
                case RadGridStringId.ConditionalFormattingBtnAdd: return "Nuova regola";
                case RadGridStringId.ConditionalFormattingBtnRemove: return "Rimuovi regola";
                case RadGridStringId.ConditionalFormattingBtnOK: return "OK";
                case RadGridStringId.ConditionalFormattingBtnCancel: return "Annulla";
                case RadGridStringId.ConditionalFormattingBtnApply: return "Applica";
                case RadGridStringId.ConditionalFormattingRuleAppliesOn: return "La regola si applica su:";
                case RadGridStringId.ConditionalFormattingChooseOne: return "[Scegliere una condizione]";
                case RadGridStringId.ConditionalFormattingEqualsTo: return "uguale a [Valore 1]";
                case RadGridStringId.ConditionalFormattingIsNotEqualTo: return "non è uguale a [Valore 1]";
                case RadGridStringId.ConditionalFormattingStartsWith: return "inizia con [Valore 1]";
                case RadGridStringId.ConditionalFormattingEndsWith: return "finisce con [Valore 1]";
                case RadGridStringId.ConditionalFormattingContains: return "contiene [Valore 1]";
                case RadGridStringId.ConditionalFormattingDoesNotContain: return "non contiene [Valore 1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThan: return "è più grande di [Valore 1]";
                case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual: return "è più grande o uguale a [Valore 1]";
                case RadGridStringId.ConditionalFormattingIsLessThan: return "è minore di [Valore 1]";
                case RadGridStringId.ConditionalFormattingIsLessThanOrEqual: return "è minore o uguale a [Valore 1]";
                case RadGridStringId.ConditionalFormattingIsBetween: return "è compreso tra [Valore 1] e [Valore 2]";
                case RadGridStringId.ConditionalFormattingIsNotBetween: return "non è compreso tra [Valore 1] e [Valore 2]";
                case RadGridStringId.ColumnChooserFormCaption: return "Selezione colonne";
                case RadGridStringId.ColumnChooserFormMessage: return "Trascinare qui l'intestazione di una colonna\ndella griglia per nasconderla alla vista.";
                case RadGridStringId.GroupingPanelDefaultMessage: return "Trascinare qui una colonna per raggruppare sulla colonna.";
                case RadGridStringId.NoDataText: return "Nessun dato da visualizzare";
            }

            System.Diagnostics.Debug.WriteLine("GRIDVIEW:" + id);
            return string.Empty;
        }
    }
}
