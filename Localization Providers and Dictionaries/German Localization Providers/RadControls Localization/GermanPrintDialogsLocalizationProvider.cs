using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;
using System.Windows.Forms;

namespace GermanRadControlsLocalization
{
    public class GermanPrintDialogsLocalizationProvider : PrintDialogsLocalizationProvider 
    {
        public override string GetLocalizedString(string id)
        {
           switch (id)
           {
               case PrintDialogsStringId.PreviewDialogTitle: return "Druckvorschau";
               case PrintDialogsStringId.PreviewDialogPrint: return "Drucken...";
               case PrintDialogsStringId.PreviewDialogPrintSettings: return "Druckeinstellungen...";
               case PrintDialogsStringId.PreviewDialogWatermark: return "Wasserzeichen...";
               case PrintDialogsStringId.PreviewDialogPreviousPage: return "Vorherige Seite";
               case PrintDialogsStringId.PreviewDialogNextPage: return "Nächste Seite";
               case PrintDialogsStringId.PreviewDialogZoomIn: return "Vergrößern";
               case PrintDialogsStringId.PreviewDialogZoomOut: return "Verkleinern";
               case PrintDialogsStringId.PreviewDialogZoom: return "Zoom";
               case PrintDialogsStringId.PreviewDialogAuto: return "Automatisch";
               case PrintDialogsStringId.PreviewDialogLayout: return "Mehrere Seiten";
               case PrintDialogsStringId.PreviewDialogFile: return "Datei";
               case PrintDialogsStringId.PreviewDialogView: return "Ansicht";
               case PrintDialogsStringId.PreviewDialogTools: return "Werkzeuge";
               case PrintDialogsStringId.PreviewDialogExit: return "Exit";
               case PrintDialogsStringId.PreviewDialogStripTools: return "Werkzeuge";
               case PrintDialogsStringId.PreviewDialogStripNavigation: return "Navigation";


               case PrintDialogsStringId.WatermarkDialogTitle: return "Wasserzeicheneinstellungen";
               case PrintDialogsStringId.WatermarkDialogButtonOK: return "Bestätigen";
               case PrintDialogsStringId.WatermarkDialogButtonCancel: return "Abbrechen";
               case PrintDialogsStringId.WatermarkDialogLabelPreview: return "Vorschau";
               case PrintDialogsStringId.WatermarkDialogButtonRemove: return "Entferne Wasserzeichen";
               case PrintDialogsStringId.WatermarkDialogLabelPosition: return "Position";
               case PrintDialogsStringId.WatermarkDialogRadioInFront: return "Vorne";
               case PrintDialogsStringId.WatermarkDialogRadioBehind: return "Hinten";
               case PrintDialogsStringId.WatermarkDialogLabelPageRange: return "Seitenbereich";
               case PrintDialogsStringId.WatermarkDialogRadioAll: return "Alle";
               case PrintDialogsStringId.WatermarkDialogRadioPages: return "Seiten";
               case PrintDialogsStringId.WatermarkDialogLabelPagesDescription: return "(z.B. 1,3,5-12)";
               case PrintDialogsStringId.WatermarkDialogTabText: return "Text";
               case PrintDialogsStringId.WatermarkDialogTabPicture: return "Bild";
               case PrintDialogsStringId.WatermarkDialogLabelText: return "Text";
               case PrintDialogsStringId.WatermarkDialogWatermarkText: return "Wasserzeichen Text";
               case PrintDialogsStringId.WatermarkDialogLabelHOffset: return "Horizont. Abstand";
               case PrintDialogsStringId.WatermarkDialogLabelVOffset: return "Vertikaler Abstand";
               case PrintDialogsStringId.WatermarkDialogLabelRotation: return "Rotation";
               case PrintDialogsStringId.WatermarkDialogLabelFont: return "Schriftart:";
               case PrintDialogsStringId.WatermarkDialogLabelSize: return "Größe:";
               case PrintDialogsStringId.WatermarkDialogLabelColor: return "Farbe:";
               case PrintDialogsStringId.WatermarkDialogLabelOpacity: return "Transparenz:";
               case PrintDialogsStringId.WatermarkDialogLabelLoadImage: return "Lade Bild:";
               case PrintDialogsStringId.WatermarkDialogCheckboxTiling: return "Kacheln";


               case PrintDialogsStringId.SettingDialogTitle: return "Druckeinstellungen";
               case PrintDialogsStringId.SettingDialogButtonPrint: return "Drucken";
               case PrintDialogsStringId.SettingDialogButtonPreview: return "Vorschau";
               case PrintDialogsStringId.SettingDialogButtonCancel: return "Abbrechen";
               case PrintDialogsStringId.SettingDialogButtonOK: return "Bestätigen";
               case PrintDialogsStringId.SettingDialogPageFormat: return "Format";
               case PrintDialogsStringId.SettingDialogPagePaper: return "Papier";
               case PrintDialogsStringId.SettingDialogPageHeaderFooter: return "Kopf-/Fußzeile";
               case PrintDialogsStringId.SettingDialogButtonPageNumber: return "Seitennummer";
               case PrintDialogsStringId.SettingDialogButtonTotalPages: return "Gesamtseitenzahl";
               case PrintDialogsStringId.SettingDialogButtonCurrentDate: return "Aktuelles Datum";
               case PrintDialogsStringId.SettingDialogButtonCurrentTime: return "Aktuelle Zeit";
               case PrintDialogsStringId.SettingDialogButtonUserName: return "Benutzername";
               case PrintDialogsStringId.SettingDialogLabelHeader: return "Kopfzeile";
               case PrintDialogsStringId.SettingDialogLabelFooter: return "Fußzeile";
               case PrintDialogsStringId.SettingDialogCheckboxReverse: return "Gerade/ungerade Seite anders";
               case PrintDialogsStringId.SettingDialogLabelPage: return "Papier";
               case PrintDialogsStringId.SettingDialogLabelType: return "Größe";
               case PrintDialogsStringId.SettingDialogLabelPageSource: return "Quelle";
               case PrintDialogsStringId.SettingDialogLabelMargins: return "Seitenränder (inches)";
               case PrintDialogsStringId.SettingDialogLabelOrientation: return "Ausrichtung";
               case PrintDialogsStringId.SettingDialogLabelTop: return "Oben:";
               case PrintDialogsStringId.SettingDialogLabelBottom: return "Unten:";
               case PrintDialogsStringId.SettingDialogLabelLeft: return "Links:";
               case PrintDialogsStringId.SettingDialogLabelRight: return "Rechts:";
               case PrintDialogsStringId.SettingDialogRadioPortrait: return "Hochformat";
               case PrintDialogsStringId.SettingDialogRadioLandscape: return "Querformat";


               case PrintDialogsStringId.SchedulerSettingsLabelPrintStyle: return "Druckstil";
               case PrintDialogsStringId.SchedulerSettingsDailyStyle: return "Tagesübersicht";
               case PrintDialogsStringId.SchedulerSettingsWeeklyStyle: return "Wochenübersicht";
               case PrintDialogsStringId.SchedulerSettingsMonthlyStyle: return "Monatsübersicht";
               case PrintDialogsStringId.SchedulerSettingsDetailStyle: return "Detailübersicht";
               case PrintDialogsStringId.SchedulerSettingsButtonWatermark: return "Wasserzeichen...";
               case PrintDialogsStringId.SchedulerSettingsLabelPrintRange: return "Druckbereich";
               case PrintDialogsStringId.SchedulerSettingsLabelStyleSettings: return "Stileinstellungen";
               case PrintDialogsStringId.SchedulerSettingsLabelPrintSettings: return "Druckeinstellungen";
               case PrintDialogsStringId.SchedulerSettingsLabelStartDate: return "Beginndatum";
               case PrintDialogsStringId.SchedulerSettingsLabelEndDate: return "Endedatum";
               case PrintDialogsStringId.SchedulerSettingsLabelStartTime: return "Beginnzeit";
               case PrintDialogsStringId.SchedulerSettingsLabelEndTime: return "Endezeit";
               case PrintDialogsStringId.SchedulerSettingsLabelDateFont: return "Schriftart Kopfdatum";
               case PrintDialogsStringId.SchedulerSettingsLabelAppointmentFont: return "Schriftart Termin";
               case PrintDialogsStringId.SchedulerSettingsLabelLayout: return "Layout";
               case PrintDialogsStringId.SchedulerSettingsPrintPageTitle: return "Drucke Seitenüberschrift";
               case PrintDialogsStringId.SchedulerSettingsPrintCalendar: return "Kalender in der Überschrift";
               case PrintDialogsStringId.SchedulerSettingsPrintTimezone: return "Drucke die ausgewählte Zeitzone";
               case PrintDialogsStringId.SchedulerSettingsPrintNotesBlank: return "Notizen (leer)";
               case PrintDialogsStringId.SchedulerSettingsPrintNotesLined: return "Notizen (liniert)";
               case PrintDialogsStringId.SchedulerSettingsNonworkingDays: return "Schliesse Tage an denen nicht gearbeitet wird aus";
               case PrintDialogsStringId.SchedulerSettingsExactlyOneMonth: return "Drucke genau einen Monat";
               case PrintDialogsStringId.SchedulerSettingsLabelWeeksPerPage: return "Wochen pro Seite";
               case PrintDialogsStringId.SchedulerSettingsNewPageEach: return "Beginne mit neuer Seite jeden";
               case PrintDialogsStringId.SchedulerSettingsStringDay: return "Tag";
               case PrintDialogsStringId.SchedulerSettingsStringMonth: return "Monat";
               case PrintDialogsStringId.SchedulerSettingsStringWeek: return "Woche";
               case PrintDialogsStringId.SchedulerSettingsStringPage: return "Seite";
               case PrintDialogsStringId.SchedulerSettingsStringPages: return "Seiten";
               case PrintDialogsStringId.SchedulerSettingsLabelGroupBy: return "Gruppieren";
               case PrintDialogsStringId.SchedulerSettingsGroupByNone: return "Keine";
               case PrintDialogsStringId.SchedulerSettingsGroupByResource: return "Ressource";
               case PrintDialogsStringId.SchedulerSettingsGroupByDate: return "Datum";


               case PrintDialogsStringId.GridSettingsLabelPreview: return "Vorschau";
               case PrintDialogsStringId.GridSettingsLabelStyleSettings: return "Stileinstellungen";
               case PrintDialogsStringId.GridSettingsLabelPrint: return "Drucken";
               case PrintDialogsStringId.GridSettingsLabelFitMode: return "Seitenanpassungsmodus:";
               case PrintDialogsStringId.GridSettingsLabelHeaderCells: return "Kopfzellen";
               case PrintDialogsStringId.GridSettingsLabelGroupCells: return "Gruppenzellen";
               case PrintDialogsStringId.GridSettingsLabelDataCells: return "Datenzellen";
               case PrintDialogsStringId.GridSettingsLabelSummaryCells: return "Zusammenfassungszellen";
               case PrintDialogsStringId.GridSettingsLabelBackground: return "Hintergrund";
               case PrintDialogsStringId.GridSettingsLabelBorderColor: return "Rahmenfarbe";
               case PrintDialogsStringId.GridSettingsLabelAlternatingRowColor: return "Abwechselnde Zeilenfarbe";
               case PrintDialogsStringId.GridSettingsLabelPadding: return "Füllung";
               case PrintDialogsStringId.GridSettingsPrintGrouping: return "Drucke Gruppierungen";
               case PrintDialogsStringId.GridSettingsPrintSummaries: return "Zusammenfassungen";
               case PrintDialogsStringId.GridSettingsPrintHiddenRows: return "Drucke versteckte Zeilen";
               case PrintDialogsStringId.GridSettingsPrintHiddenColumns: return "Drucke versteckte Spalten";
               case PrintDialogsStringId.GridSettingsPrintHeader: return "Drucke Kopfzeile auf jeder Seite";
               case PrintDialogsStringId.GridSettingsButtonWatermark: return "Wasserzeichen...";
               case PrintDialogsStringId.GridSettingsFitPageWidth: return "Anpassung Seitenbreite";
               case PrintDialogsStringId.GridSettingsNoFit: return "keine Anpassung";
               case PrintDialogsStringId.GridSettingsNoFitCentered: return "keine Anpassung zentriert";

               default:
                   MessageBox.Show( string.Format( "GermanPrintDialogsLocalizationProvider: Missing Translation for: {0} {1}" , id , base.GetLocalizedString( id ) ) );
                   return base.GetLocalizedString(id);
           }
       }
    }
}
