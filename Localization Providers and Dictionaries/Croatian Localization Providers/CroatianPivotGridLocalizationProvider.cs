using System;
using System.Linq;
using Telerik.WinControls.UI;

namespace CroatianRadControlsLocalization
{
    public class CroatianPivotGridLocalizationProvider : PivotGridLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case PivotStringId.GrandTotal: return "Sve ukupno";
                case PivotStringId.Values: return "Vrijednosti";
                case PivotStringId.TotalP0: return "Ukupno {0}";
                case PivotStringId.Product: return "Produkt";
                case PivotStringId.StdDevP: return "StdDevP";
                case PivotStringId.Min: return "Min";
                case PivotStringId.Count: return "Račun";
                case PivotStringId.StdDev: return "StdDev";
                case PivotStringId.Sum: return "Suma";
                case PivotStringId.Average: return "Prosjek";
                case PivotStringId.Var: return "Var";
                case PivotStringId.VarP: return "VarP";
                case PivotStringId.GroupP0AggregateP1: return "{0} {1}";
                case PivotStringId.YearGroupField: return "Godina";
                case PivotStringId.MonthGroupField: return "Mjesec";
                case PivotStringId.QuarterGroupField: return "Tromjesečje";
                case PivotStringId.WeekGroupField: return "Tjedan";
                case PivotStringId.DayGroupField: return "Dan";
                case PivotStringId.HourGroupField: return "Sat";
                case PivotStringId.MinuteGroupField: return "Minuta";
                case PivotStringId.SecondsGroupField: return "Sekunda";
                case PivotStringId.P0Total: return "{0} Ukupno";
                case PivotStringId.PivotAggregateP0ofP1: return "{0} od {1}";
                case PivotStringId.ExpandCollapseMenuItem: return "Proširi";
                case PivotStringId.CollapseAllMenuItems: return "Spusti sve";
                case PivotStringId.ExpandAllMenuItems: return "Proširi sve";
                case PivotStringId.CopyMenuItem: return "Kopiraj";
                case PivotStringId.HideMenuItem: return "Sakrij";
                case PivotStringId.SortMenuItem: return "Sortiraj";
                case PivotStringId.BestFitMenuItem: return "Najbolje pristaje";
                case PivotStringId.ReloadDataMenuItem: return "Ponovno učitaj podatke";
                case PivotStringId.FieldListMenuItem: return "Pokaži listu polja";
                case PivotStringId.SortAZMenuItem: return "Sortiraj A-Z";
                case PivotStringId.SortZAMenuItem: return "Sortiraj Z-A";
                case PivotStringId.SortOptionsMenuItem: return "Dodatne opcije sortiranja ...";
                case PivotStringId.ClearFilterMenuItem: return "Očisti filter";
                case PivotStringId.LabelFilterMenuItem: return "Označi filter";

                case PivotStringId.ValueFilterMenuItem: return "Vrijednosni filter";
                case PivotStringId.AllNode: return "(Označi sve)";
                case PivotStringId.FilterMenuItemEqual: return "Jednak je...";
                case PivotStringId.FilterMenuItemDoesNotEquals: return "Nije jednak...";
                case PivotStringId.FilterMenuItemBeginsWith: return "Započinje s...";
                case PivotStringId.FilterMenuItemDoesNotBeginWith: return "Ne započinje s...";
                case PivotStringId.FIlterMenuItemEndsWith: return "Završava s...";
                case PivotStringId.FilterMenuItemDoesNotEndsWith: return "Ne završava s...";
                case PivotStringId.FilterMenuItemContains: return "Sadrži...";
                case PivotStringId.FilterMenuItemDoesNotContain: return "Ne sadrži...";
                case PivotStringId.FilterMenuItemGreaterThan: return "Veće od...";
                case PivotStringId.FilterMenuItemGreaterThanOrEqualTo: return "Veće ili jednako...";
                case PivotStringId.FilterMenuItemLessThan: return "Manje od...";
                case PivotStringId.FilterMenuItemLessThanOrEqualTo: return "Manje ili jednako...";
                case PivotStringId.FilterMenuItemBetween: return "Između...";
                case PivotStringId.FilterMenuItemNotBetween: return "Nije između...";
                case PivotStringId.TopTenItem: return "Top 10...";
                case PivotStringId.AllNodeSelectAllSearchResult: return "(Označi sve rezultate pretrage)";
                case PivotStringId.FilterMenuAvailableFilters: return "Dostupni filtri";
                case PivotStringId.CheckBoxMenuItem: return "Odaberi više stavki";

                case PivotStringId.CalculationOptionsDialogNoCalculation: return "Nema izračuna";
                case PivotStringId.CalculationOptionsDialogPrevious: return "(prethodni)";
                case PivotStringId.CalculationOptionsDialogNext: return "(slijedeći)";
                case PivotStringId.CalculationOptionsDialogGrandTotal: return "% od sveukupnog";
                case PivotStringId.CalculationOptionsDialogColumnTotal: return "% od ukupnog iz stupca";
                case PivotStringId.CalculationOptionsDialogRowTotal: return "% od ukupnog iz reda";
                case PivotStringId.CalculationOptionsDialogOf: return "% od";
                case PivotStringId.CalculationOptionsDialogDifferenceFrom: return "Razlika od";
                case PivotStringId.CalculationOptionsDialogPercentDifferenceFrom: return "% Razlika od";
                case PivotStringId.CalculationOptionsDialogRunningTotalIn: return "Trenutno ukupno u";
                case PivotStringId.CalculationOptionsDialogPercentRunningTotalIn: return "% Trenutno ukupno u";
                case PivotStringId.CalculationOptionsDialogRankSmallestToLargest: return "Poredaj od najmanje do najveće";
                case PivotStringId.CalculationOptionsDialogRankLargestToSmallest: return "Poredaj od najveće do najmanje";
                case PivotStringId.CalculationOptionsDialogIndex: return "Indeks";
                case PivotStringId.CalculationOptionsDialogShowValueAs: return "Prikaži vrijednost kao ({0})";

                case PivotStringId.LabelFilterOptionsDialogEquals: return "je jednako";
                case PivotStringId.LabelFilterOptionsDialogDoesNotEqual: return "nije jednako";
                case PivotStringId.LabelFilterOptionsDialogIsGreaterThen: return "je veće od";
                case PivotStringId.LabelFilterOptionsDialogIsGreaterThanOrEqualTo: return "je veće ili jednako";
                case PivotStringId.LabelFilterOptionsDialogIsLessThan: return "je manje od";
                case PivotStringId.LabelFilterOptionsDialogIsLessThanOrEqualTo: return "je manje ili jednako";
                case PivotStringId.LabelFilterOptionsDialogBeginsWith: return "počinje s";
                case PivotStringId.LabelFilterOptionsDialogDoesNotBeginWith: return "ne počinje s";
                case PivotStringId.LabelFilterOptionsDialogEndsWith: return "završava s";
                case PivotStringId.LabelFilterOptionsDialogDoesNotEndsWith: return "ne završava s";
                case PivotStringId.LabelFilterOptionsDialogContains: return "sadrži";
                case PivotStringId.LabelFilterOptionsDialogDoesNotContain: return "ne sadrži";
                case PivotStringId.LabelFilterOptionsDialogIsBetween: return "je između";
                case PivotStringId.LabelFilterOptionsDialogIsNotBetween: return "nije između";
                case PivotStringId.LabelFilterOptionsDialogLabelFilter: return "Označi filter ({0})";

                case PivotStringId.NumberFormatOptionsDialogCustomFormat: return "Korisnički odabran format";
                case PivotStringId.NumberFormatOptionsDialogFixedPoint: return "Fiksna točka sa 2 decimalna mjesta";
                case PivotStringId.NumberFormatOptionsDialogPrefixedCurrency: return "$ prefiksirana valuta sa 2 decimalna mjesta";
                case PivotStringId.NumberFormatOptionsDialogPostfixedCurrency: return "€ postfiksirana valuta sa 2 decimalna mjesta";
                case PivotStringId.NumberFormatOptionsDialogPostfixedTemperatureC: return "°C postfiksirana temperatura sa 2 decimalna mjesta";
                case PivotStringId.NumberFormatOptionsDialogPostfixedTemperatureF: return "°F postfiksirana temperatura sa 2 decimalna mjesta";
                case PivotStringId.NumberFormatOptionsDialogExponential: return "Eksponencijalni (znanstveni)";
                case PivotStringId.NumberFormatOptionsDialogFormatOptions: return "Opcije formata";
                case PivotStringId.NumberFormatOptionsDialogFormatOptionsDescription: return "Opcije formata ({0})";

                case PivotStringId.SortOptionsDialogSortOptions: return "Opcije sortiranja ({0})";
                case PivotStringId.Top10FilterOptionsDialogTop: return "Na vrhu";
                case PivotStringId.Top10FilterOptionsDialogBottom: return "Na dnu";
                case PivotStringId.Top10FilterOptionsDialogItems: return "Stavke";
                case PivotStringId.Top10FilterOptionsDialogPercent: return "Postotak";
                case PivotStringId.Top10FilterOptionsDialogTop10: return "Top10 filter ({0})";
                case PivotStringId.ValueFilter: return "Vrijednosni filter ({0})";

                case PivotStringId.AggregateOptionsDialogGroupBoxText: return "Sažeti vrijednosti po";
                case PivotStringId.AggregateOptionsDialogLabelCustomName: return "Korisnički određeno ime:";
                case PivotStringId.AggregateOptionsDialogLabelDescription: return "Odaberite vrstu izračuna koji želite koristiti za sažimanje podataka iz odabranog polja.";
                case PivotStringId.AggregateOptionsDialogLabelField: return "Ime oznake polja";
                case PivotStringId.AggregateOptionsDialogLabelSourceName: return "Ime izvora:";
                case PivotStringId.AggregateOptionsDialogText: return "Prozor skupnih opcija";

                case PivotStringId.DialogButtonCancel: return "Otkaži";
                case PivotStringId.DialogButtonOK: return "OK";

                case PivotStringId.CalculationOptionsDialogText: return "Prozor opcija kalkulacija";
                case PivotStringId.CalculationOptionsDialogLabelBaseItem: return "Osnovna stavka:";
                case PivotStringId.CalculationOptionsDialogLabelBaseField: return "Osnovno polje:";
                case PivotStringId.CalculationOptionsDialogGroupBoxText: return "Prikaži vrijednost kao";

                case PivotStringId.LabelFilterOptionsDialogGroupBoxText: return "Prikaži stavke za koje je oznaka";
                case PivotStringId.LabelFilterOptionsDialogText: return "Prozor opcija filtra oznaka";
                case PivotStringId.LabelFilterOptionsDialogLabelAnd: return "I";

                case PivotStringId.NumberFormatOptionsDialogFormat: return "Format";
                case PivotStringId.NumberFormatOptionsDialogLabelDescription: return "Format bi trebao identificirati mjerni tip vrijednosti. ($, ¥, €, kg., lb., m.) Format bi se koristio za osnovna računanja kao što su Zbroj, Prosjek, Min, Max i drugo.";
                case PivotStringId.NumberFormatOptionsDialogText: return "Prozor opcija formata brojeva";
                case PivotStringId.NumberFormatOptionsDialogGroupBoxText: return "Osnovni format";

                case PivotStringId.SortOptionsDialogAscending: return "Sortiraj uzlazno (A-Z) po:";
                case PivotStringId.SortOptionsDialogDescending: return "Sortiraj silazno (Z-A) po:";
                case PivotStringId.SortOptionsDialogGroupBoxText: return "Opcije sortiranja";
                case PivotStringId.SortOptionsDialogText: return "Prozor opcija sortiranja";

                case PivotStringId.Top10FilterOptionsDialogGroupBoxText: return "Prikaži";
                case PivotStringId.Top10FilterOptionsDialogLabelBy: return "po";
                case PivotStringId.Top10FilterOptionsDialogText: return "Prozor opcija Top10 Filtera";

                case PivotStringId.ValueFilterOptionsDialogGroupBox: return "Prikaži stavke za koje";

                case PivotStringId.ValueFilterOptionsDialogText: return "Prozor opcija filtera vrijednosti";
                case PivotStringId.DragDataItemsHere: return "Dovuci podatkovne stavke ovdje";
                case PivotStringId.DragColumnItemsHere: return "Dovuci stavke stupca ovdje";
                case PivotStringId.DragItemsHere: return "Dovuci stavke ovdje";
                case PivotStringId.DragFilterItemsHere: return "Dovuci stavke filtera ovdje";
                case PivotStringId.DragRowItemsHere: return "Dovuci stavke reda ovdje";
                case PivotStringId.ResultItemFormat: return "Ključ: {0}; Skup: {1}";
                case PivotStringId.Error: return "Greška";
                case PivotStringId.KpiSchemaElementValidatorError: return "Treba biti definiran barem jedna KPI član(Cilj, Status, Trend, Vrijednost)";
                case PivotStringId.SchemaElementValidatorMissingPropertyFormat: return "Nedostaje potrebno svojstvo: {0}";
                case PivotStringId.AdomdCellInfoToStringFormat: return "Redni: {0} | Vrijednost: {1}";
                case PivotStringId.Aggregates: return "Skup";
                case PivotStringId.FilterMenuTextBoxItemNullText: return "Pretraži...";
                case PivotStringId.FieldChooserFormButtonAdd: return "Dodaj u";
                case PivotStringId.FieldChooserFormFields: return "Polja:";
                case PivotStringId.FieldChooserFormText: return "Odabirač polja";

                case PivotStringId.FieldChooserFormColumnArea: return "Prostor stupca";
                case PivotStringId.FieldChooserFormDataArea: return "Prostor podatka";
                case PivotStringId.FieldChooserFormFilterArea: return "Prostor filtra";
                case PivotStringId.FieldChooserFormRowArea: return "Prostor reda";

                case PivotStringId.FieldListlabelChooseFields: return "Izaberi polje:";
                case PivotStringId.FieldListButtonUpdate: return "Ažuriraj";
                case PivotStringId.FieldListCheckBoxDeferUpdate: return "Odgodi ažuriranje izgleda";
                case PivotStringId.FieldListLabelDrag: return "Dovuci polja između prostora ispod:";

                case PivotStringId.FieldListLabelRowLabels: return "Oznake reda";
                case PivotStringId.FieldListLabelColumnLabels: return "Oznake stupca";
                case PivotStringId.FieldListLabelReportFilter: return "Filter izvještaja";

                case PivotStringId.None: return "Nijedan";
                case PivotStringId.PrintSettingsFitWidth: return "Prilagodi širini";
                case PivotStringId.PrintSettingsFitHeight: return "Prilagodi visini";
                case PivotStringId.PrintSettingsCompact: return "Kompaktno";
                case PivotStringId.PrintSettingsTabular: return "Tabelarno";
                case PivotStringId.PrintSettingsFitAll: return "Prilagodi sve";

                case PivotStringId.PrintSettingsPrintOrder: return "Poredak ispisivanja";
                case PivotStringId.PrintSettingsThenOver: return "Dolje, zatim preko";
                case PivotStringId.PrintSettingsThenDown: return "Preko, zatim prema dolje";
                case PivotStringId.PrintSettingsFontsAndColors: return "Fontovi i boje";
                case PivotStringId.PrintSettingsBackground: return "Pozadina";
                case PivotStringId.PrintSettingsNone: return "(nijedan)";
                case PivotStringId.PrintSettingsFont: return "Font";
                case PivotStringId.PrintSettingsGrantTotal: return "Čelije sveukupnog:";
                case PivotStringId.PrintSettingsDescriptors: return "Skupni/grupni deskriptori:";
                case PivotStringId.PrintSettingsSubTotal: return "Čelije zbroja stavki:";
                case PivotStringId.PrintSettingsHeaderCells: return "Čelije zaglavlja stupca/reda:";
                case PivotStringId.PrintSettingsDataCells: return "Podatkovne čelije:";
                case PivotStringId.PrintSettingsGridLinesColor: return "Boje linija tablice:";
                case PivotStringId.PrintSettingsSettings: return "Postavke";
                case PivotStringId.PrintSettingsLayuotType: return "Tip plana:";
                case PivotStringId.PrintSettingsScaleMode: return "Mod mjerila:";
                case PivotStringId.PrintSettingsPrintSelectionOnly: return "Samo izbor ispisa";
                case PivotStringId.PrintSettingsShowGridLines: return "Prikaži linije tablice";
                case PivotStringId.CollapseMenuItem: return "Spusti";
                case PivotStringId.CalcualtedFields: return "Izračunata polja";
                case PivotStringId.Max: return "Max";
                default: return base.GetLocalizedString(id);
            }
        }
    }
}
