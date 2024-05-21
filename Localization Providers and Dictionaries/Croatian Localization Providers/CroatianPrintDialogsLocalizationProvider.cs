using System;
using System.Linq;
using Telerik.WinControls.UI;

namespace CroatianRadControlsLocalization
{
    public class CroatianPrintDialogsLocalizationProvider : PrintDialogsLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case PrintDialogsStringId.PreviewDialogTitle: return "Pregled ispisa";
                case PrintDialogsStringId.PreviewDialogPrint: return "Ispis...";
                case PrintDialogsStringId.PreviewDialogPrintSettings: return "Postavke ispisa...";
                case PrintDialogsStringId.PreviewDialogWatermark: return "Vodeni pečat...";
                case PrintDialogsStringId.PreviewDialogPreviousPage: return "Prethodna stranica";
                case PrintDialogsStringId.PreviewDialogNextPage: return "Slijedeća stranica";
                case PrintDialogsStringId.PreviewDialogZoomIn: return "Zumiraj";
                case PrintDialogsStringId.PreviewDialogZoomOut: return "Odzumiraj";
                case PrintDialogsStringId.PreviewDialogZoom: return "Zoom";
                case PrintDialogsStringId.PreviewDialogAuto: return "Auto";
                case PrintDialogsStringId.PreviewDialogLayout: return "Izgled";
                case PrintDialogsStringId.PreviewDialogFile: return "Datoteka";
                case PrintDialogsStringId.PreviewDialogView: return "Prikaz";
                case PrintDialogsStringId.PreviewDialogTools: return "Alati";
                case PrintDialogsStringId.PreviewDialogExit: return "Izlaz";
                case PrintDialogsStringId.PreviewDialogStripTools: return "Alati";
                case PrintDialogsStringId.PreviewDialogStripNavigation: return "Navigacija";


                case PrintDialogsStringId.WatermarkDialogTitle: return "Postavke vodenog pečata";
                case PrintDialogsStringId.WatermarkDialogButtonOK: return "OK";
                case PrintDialogsStringId.WatermarkDialogButtonCancel: return "Otkaži";
                case PrintDialogsStringId.WatermarkDialogLabelPreview: return "Pregled";
                case PrintDialogsStringId.WatermarkDialogButtonRemove: return "Ukloni vodeni pečat";
                case PrintDialogsStringId.WatermarkDialogLabelPosition: return "Položaj";
                case PrintDialogsStringId.WatermarkDialogRadioInFront: return "Ispred";
                case PrintDialogsStringId.WatermarkDialogRadioBehind: return "Iza";
                case PrintDialogsStringId.WatermarkDialogLabelPageRange: return "Raspon stranica";
                case PrintDialogsStringId.WatermarkDialogRadioAll: return "Sve";
                case PrintDialogsStringId.WatermarkDialogRadioPages: return "Stranice";
                case PrintDialogsStringId.WatermarkDialogLabelPagesDescription: return "(pr. 1,3,5-12)";
                case PrintDialogsStringId.WatermarkDialogTabText: return "Tekst";
                case PrintDialogsStringId.WatermarkDialogTabPicture: return "Slika";
                case PrintDialogsStringId.WatermarkDialogLabelText: return "Tekst";
                case PrintDialogsStringId.WatermarkDialogWatermarkText: return "Tekst vodenog pečata";
                case PrintDialogsStringId.WatermarkDialogLabelHOffset: return "Horizontalni pomak";
                case PrintDialogsStringId.WatermarkDialogLabelVOffset: return "Vertikalni pomak";
                case PrintDialogsStringId.WatermarkDialogLabelRotation: return "Rotacija";
                case PrintDialogsStringId.WatermarkDialogLabelFont: return "Font:";
                case PrintDialogsStringId.WatermarkDialogLabelSize: return "Veličina:";
                case PrintDialogsStringId.WatermarkDialogLabelColor: return "Boja:";
                case PrintDialogsStringId.WatermarkDialogLabelOpacity: return "Prozirnost:";
                case PrintDialogsStringId.WatermarkDialogLabelLoadImage: return "Učitavanje slike:";
                case PrintDialogsStringId.WatermarkDialogCheckboxTiling: return "Popločavanje";


                case PrintDialogsStringId.SettingDialogTitle: return "Postavke ispisa";
                case PrintDialogsStringId.SettingDialogButtonPrint: return "Ispis";
                case PrintDialogsStringId.SettingDialogButtonPreview: return "Pregled";
                case PrintDialogsStringId.SettingDialogButtonCancel: return "Otkaži";
                case PrintDialogsStringId.SettingDialogButtonOK: return "OK";
                case PrintDialogsStringId.SettingDialogPageFormat: return "Format";
                case PrintDialogsStringId.SettingDialogPagePaper: return "Papir";
                case PrintDialogsStringId.SettingDialogPageHeaderFooter: return "Zaglavlje/Podnožje";
                case PrintDialogsStringId.SettingDialogButtonPageNumber: return "Broj stranica";
                case PrintDialogsStringId.SettingDialogButtonTotalPages: return "Ukupno stranica";
                case PrintDialogsStringId.SettingDialogButtonCurrentDate: return "Trenutni datum";
                case PrintDialogsStringId.SettingDialogButtonCurrentTime: return "Trenutno vrijeme";
                case PrintDialogsStringId.SettingDialogButtonUserName: return "Korisničko ime";
                case PrintDialogsStringId.SettingDialogLabelHeader: return "Zaglavlje";
                case PrintDialogsStringId.SettingDialogLabelFooter: return "Podnožje";
                case PrintDialogsStringId.SettingDialogCheckboxReverse: return "Obrnuti na parnim stranicama";
                case PrintDialogsStringId.SettingDialogLabelPage: return "Stranica";
                case PrintDialogsStringId.SettingDialogLabelType: return "Tip";
                case PrintDialogsStringId.SettingDialogLabelPageSource: return "Izvor stranice";
                case PrintDialogsStringId.SettingDialogLabelMargins: return "Margine (inča)";
                case PrintDialogsStringId.SettingDialogLabelOrientation: return "Orijentacija";
                case PrintDialogsStringId.SettingDialogLabelTop: return "Vrh:";
                case PrintDialogsStringId.SettingDialogLabelBottom: return "Dno:";
                case PrintDialogsStringId.SettingDialogLabelLeft: return "Lijevo:";
                case PrintDialogsStringId.SettingDialogLabelRight: return "Desno:";
                case PrintDialogsStringId.SettingDialogRadioPortrait: return "Portret";
                case PrintDialogsStringId.SettingDialogRadioLandscape: return "Pejzaž";


                case PrintDialogsStringId.SchedulerSettingsLabelPrintStyle: return "Stil ispisa";
                case PrintDialogsStringId.SchedulerSettingsDailyStyle: return "Dnevni stil";
                case PrintDialogsStringId.SchedulerSettingsWeeklyStyle: return "Tjedni stil";
                case PrintDialogsStringId.SchedulerSettingsMonthlyStyle: return "Mjesečni stil";
                case PrintDialogsStringId.SchedulerSettingsDetailStyle: return "Stil detalja";
                case PrintDialogsStringId.SchedulerSettingsButtonWatermark: return "Vodeni pečat...";
                case PrintDialogsStringId.SchedulerSettingsLabelPrintRange: return "Raspon ispisa";
                case PrintDialogsStringId.SchedulerSettingsLabelStyleSettings: return "Postavke stila";
                case PrintDialogsStringId.SchedulerSettingsLabelPrintSettings: return "Postavke ispisa";
                case PrintDialogsStringId.SchedulerSettingsLabelStartDate: return "Datum početka";
                case PrintDialogsStringId.SchedulerSettingsLabelEndDate: return "Datum završetka";
                case PrintDialogsStringId.SchedulerSettingsLabelStartTime: return "Vrijeme početka";
                case PrintDialogsStringId.SchedulerSettingsLabelEndTime: return "Vrijeme završetka";
                case PrintDialogsStringId.SchedulerSettingsLabelDateFont: return "Font zaglavlja datuma";
                case PrintDialogsStringId.SchedulerSettingsLabelAppointmentFont: return "Font termina";
                case PrintDialogsStringId.SchedulerSettingsLabelLayout: return "Izgled";
                case PrintDialogsStringId.SchedulerSettingsPrintPageTitle: return "Ispis naslova stranice";
                case PrintDialogsStringId.SchedulerSettingsPrintCalendar: return "Uključi kalendar u naslovu";
                case PrintDialogsStringId.SchedulerSettingsPrintTimezone: return "Ispiši označenu vremensku zonu";
                case PrintDialogsStringId.SchedulerSettingsPrintNotesBlank: return "Bilješke (prazno)";
                case PrintDialogsStringId.SchedulerSettingsPrintNotesLined: return "Bilješke (u nizu)";
                case PrintDialogsStringId.SchedulerSettingsNonworkingDays: return "Isključi neradne dane";
                case PrintDialogsStringId.SchedulerSettingsExactlyOneMonth: return "Ispiši točno jedan mjesec";
                case PrintDialogsStringId.SchedulerSettingsLabelWeeksPerPage: return "Tjedana po stranici";
                case PrintDialogsStringId.SchedulerSettingsNewPageEach: return "Započni novu stranicu svaki";
                case PrintDialogsStringId.SchedulerSettingsStringDay: return "Dan";
                case PrintDialogsStringId.SchedulerSettingsStringMonth: return "Mjesec";
                case PrintDialogsStringId.SchedulerSettingsStringWeek: return "Tjedan";
                case PrintDialogsStringId.SchedulerSettingsStringPage: return "Stranica";
                case PrintDialogsStringId.SchedulerSettingsStringPages: return "Stranice";
                case PrintDialogsStringId.SchedulerSettingsLabelGroupBy: return "Grupiraj po:";
                case PrintDialogsStringId.SchedulerSettingsGroupByNone: return "Nijedan";
                case PrintDialogsStringId.SchedulerSettingsGroupByResource: return "Resurs";
                case PrintDialogsStringId.SchedulerSettingsGroupByDate: return "Datum";


                case PrintDialogsStringId.GridSettingsLabelPreview: return "Pregled";
                case PrintDialogsStringId.GridSettingsLabelStyleSettings: return "Postavke stila";
                case PrintDialogsStringId.GridSettingsLabelFitMode: return "Način pristajanja stranice:";
                case PrintDialogsStringId.GridSettingsLabelHeaderCells: return "Čelija zaglavlja";
                case PrintDialogsStringId.GridSettingsLabelGroupCells: return "Čelija grupe";
                case PrintDialogsStringId.GridSettingsLabelDataCells: return "Podatkovna čelija";
                case PrintDialogsStringId.GridSettingsLabelSummaryCells: return "Čelija sažetka";
                case PrintDialogsStringId.GridSettingsLabelBackground: return "Pozadina";
                case PrintDialogsStringId.GridSettingsLabelBorderColor: return "Boja obruba";
                case PrintDialogsStringId.GridSettingsLabelAlternatingRowColor: return "Boja naizmjeničnog reda";
                case PrintDialogsStringId.GridSettingsLabelPadding: return "Ispunjavanje";
                case PrintDialogsStringId.GridSettingsPrintGrouping: return "Ispis grupiranja";
                case PrintDialogsStringId.GridSettingsPrintSummaries: return "Ispis sažetaka";
                case PrintDialogsStringId.GridSettingsPrintHiddenRows: return "Ispis skrivenih redova";
                case PrintDialogsStringId.GridSettingsPrintHiddenColumns: return "Ispis skrivenih stupaca";
                case PrintDialogsStringId.GridSettingsPrintHeader: return "Ispisi zaglavlje na svakoj stranici";
                case PrintDialogsStringId.GridSettingsButtonWatermark: return "Vodeni pečat...";
                case PrintDialogsStringId.GridSettingsFitPageWidth: return "Širina pristajane stranice";
                case PrintDialogsStringId.GridSettingsNoFit: return "Bez pristajanja";
                case PrintDialogsStringId.GridSettingsNoFitCentered: return "Pristajanje nije centrirano";
                case PrintDialogsStringId.GridSettingsLabelPrint: return "Ispis";
            }

            return String.Empty;
        }
    }
}
