using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.UI;

namespace GermanRadSchedulerLocalization
{
    public class GermanRadSchedulerLocalization : RadSchedulerLocalizationProvider
    {
        public override string GetLocalizedString( string id )
        {
            switch ( id )
            {
                case RadSchedulerStringId.AppointmentDialogAllDay:
                    return "Ganztägiges Ereignis";
                case RadSchedulerStringId.AppointmentDialogBackground:
                    return "Kategorie:";
                case RadSchedulerStringId.AppointmentDialogCancel:
                    return "Abbrechen";
                case RadSchedulerStringId.AppointmentDialogDelete:
                    return "Löschen";
                case RadSchedulerStringId.AppointmentDialogEndTime:
                    return "Endet um:";
                case RadSchedulerStringId.AppointmentDialogLocation:
                    return "Ort:";
                case RadSchedulerStringId.AppointmentDialogOK:
                    return "OK";
                case RadSchedulerStringId.AppointmentDialogRecurrence:
                    return "Serie";
                case RadSchedulerStringId.AppointmentDialogResource:
                    return "Ressource";
                case RadSchedulerStringId.AppointmentDialogStartTime:
                    return "Beginnt um:";
                case RadSchedulerStringId.AppointmentDialogStatus:
                    return "Anzeigen als";
                case RadSchedulerStringId.AppointmentDialogSubject:
                    return "Betreff:";
                case RadSchedulerStringId.AppointmentDialogTitle:
                    return "Termin";
                case RadSchedulerStringId.BackgroundAnniversary:
                    return "Jubiläum";
                case RadSchedulerStringId.BackgroundBirthday:
                    return "Geburtstag";
                case RadSchedulerStringId.BackgroundBusiness:
                    return "Geschäftlich";
                case RadSchedulerStringId.BackgroundImportant:
                    return "Wichtig";
                case RadSchedulerStringId.BackgroundMustAttend:
                    return "Teilnahme verpflichtend";
                case RadSchedulerStringId.BackgroundNeedsPreparation:
                    return "Benötigt Vorbereitung";
                case RadSchedulerStringId.BackgroundNone:
                    return "Keine";
                case RadSchedulerStringId.BackgroundPersonal:
                    return "Privat";
                case RadSchedulerStringId.BackgroundPhoneCall:
                    return "Telefonanruf";
                case RadSchedulerStringId.BackgroundTravelRequired:
                    return "Reise notwendig";
                case RadSchedulerStringId.BackgroundVacation:
                    return "Urlaub";
                case RadSchedulerStringId.ContextMenu10Minutes:
                    return "10 Minuten";
                case RadSchedulerStringId.ContextMenu15Minutes:
                    return "15 Minuten";
                case RadSchedulerStringId.ContextMenu30Minutes:
                    return "30 Minuten";
                case RadSchedulerStringId.ContextMenu5Minutes:
                    return "5 Minuten";
                case RadSchedulerStringId.ContextMenu60Minutes:
                    return "60 Minuten";
                case RadSchedulerStringId.ContextMenu6Minutes:
                    return "6 Minuten";
                case RadSchedulerStringId.ContextMenuNavigateToNextView:
                    return "nächste Zeitspanne";
                case RadSchedulerStringId.ContextMenuNavigateToPreviousView:
                    return "vorherige Zeitspanne";
                case RadSchedulerStringId.ContextMenuNewAppointment:
                    return "Neuer Termin";
                case RadSchedulerStringId.ContextMenuNewRecurringAppointment:
                    return "Neue Terminserie";
                case RadSchedulerStringId.DailyRecurrenceDays:
                    return "Tag(e)";
                case RadSchedulerStringId.DailyRecurrenceEveryDay:
                    return "Alle";
                case RadSchedulerStringId.DailyRecurrenceEveryWeekday:
                    return "Jeden Arbeitstag";
                case RadSchedulerStringId.MonthlyRecurrenceDay:
                    return "Am";
                case RadSchedulerStringId.MonthlyRecurrenceDayOfMonth:
                    return ". Tag jedes";
                case RadSchedulerStringId.MonthlyRecurrenceFirst:
                    return "ersten";
                case RadSchedulerStringId.MonthlyRecurrenceFourth:
                    return "vierten";
                case RadSchedulerStringId.MonthlyRecurrenceLast:
                    return "letzten";
                case RadSchedulerStringId.MonthlyRecurrenceMonths:
                    return ". Monats";
                case RadSchedulerStringId.MonthlyRecurrenceSecond:
                    return "zweiten";
                case RadSchedulerStringId.MonthlyRecurrenceThird:
                    return "dritten";
                case RadSchedulerStringId.MonthlyRecurrenceWeek:
                    return "Am";
                case RadSchedulerStringId.MonthlyRecurrenceWeekOfMonth:
                    return "jedes";
                case RadSchedulerStringId.NextAppointment:
                    return "nächster Termin";
                case RadSchedulerStringId.OpenRecurringDialogCancel:
                    return "Abbrechen";
                case RadSchedulerStringId.OpenRecurringDialogLabel:
                    return "\"{0}\" ist eine\nTerminserie. Möchten Sie nur diesen\nTermin oder die Terminserie öffnen?";
                case RadSchedulerStringId.OpenRecurringDialogOK:
                    return "OK";
                case RadSchedulerStringId.OpenRecurringDialogRadioOccurrence:
                    return "Dieses Serienelement öffnen.";
                case RadSchedulerStringId.OpenRecurringDialogRadioSeries:
                    return "Die Serie öffnen.";
                case RadSchedulerStringId.OpenRecurringDialogTitle:
                    return "Terminserie öffnen";
                case RadSchedulerStringId.PreviousAppointment:
                    return "vorheriger Termin";
                case RadSchedulerStringId.RecurrenceDialogAppointmentEnd:
                    return "Ende:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentStart:
                    return "Beginn:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentTimeGroup:
                    return "Termin";
                case RadSchedulerStringId.RecurrenceDialogCancel:
                    return "Abbrechen";
                case RadSchedulerStringId.RecurrenceDialogDaily:
                    return "Täglich";
                case RadSchedulerStringId.RecurrenceDialogDuration:
                    return "Dauer:";
                case RadSchedulerStringId.RecurrenceDialogEndAfter:
                    return "Endet nach:";
                case RadSchedulerStringId.RecurrenceDialogEndBy:
                    return "Endet am:";
                case RadSchedulerStringId.RecurrenceDialogMonthly:
                    return "Monatlich";
                case RadSchedulerStringId.RecurrenceDialogNoEndDate:
                    return "kein Enddatum";
                case RadSchedulerStringId.RecurrenceDialogOccurrences:
                    return "Terminen";
                case RadSchedulerStringId.RecurrenceDialogOK:
                    return "OK";
                case RadSchedulerStringId.RecurrenceDialogRangeGroup:
                    return "Seriendauer";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceGroup:
                    return "Serienmuster";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceStart:
                    return "Beginn:";
                case RadSchedulerStringId.RecurrenceDialogRemoveRecurrence:
                    return "Serie entfernen";
                case RadSchedulerStringId.RecurrenceDialogTitle:
                    return "Terminserie";
                case RadSchedulerStringId.RecurrenceDialogWeekly:
                    return "Wöchentlich";
                case RadSchedulerStringId.RecurrenceDialogYearly:
                    return "Jährlich";
                case RadSchedulerStringId.StatusBusy:
                    return "Beschäftigt";
                case RadSchedulerStringId.StatusFree:
                    return "Frei";
                case RadSchedulerStringId.StatusTentative:
                    return "Mit Vorbehalt";
                case RadSchedulerStringId.StatusUnavailable:
                    return "Abwesend";
                case RadSchedulerStringId.WeeklyRecurrenceDay:
                    return "Tag";
                case RadSchedulerStringId.WeeklyRecurrenceFriday:
                    return "Freitag";
                case RadSchedulerStringId.WeeklyRecurrenceMonday:
                    return "Montag";
                case RadSchedulerStringId.WeeklyRecurrenceRecurEvery:
                    return "Jede/Alle";
                case RadSchedulerStringId.WeeklyRecurrenceSaturday:
                    return "Samstag";
                case RadSchedulerStringId.WeeklyRecurrenceSunday:
                    return "Sonntag";
                case RadSchedulerStringId.WeeklyRecurrenceThursday:
                    return "Donnerstag";
                case RadSchedulerStringId.WeeklyRecurrenceTuesday:
                    return "Dienstag";
                case RadSchedulerStringId.WeeklyRecurrenceWednesday:
                    return "Mittwoch";
                case RadSchedulerStringId.WeeklyRecurrenceWeekday:
                    return "Arbeitstag";
                case RadSchedulerStringId.WeeklyRecurrenceWeekendDay:
                    return "Wochenendtag";
                case RadSchedulerStringId.WeeklyRecurrenceWeeksOn:
                    return "Woche(n) am";
                case RadSchedulerStringId.YearlyRecurrenceApril:
                    return "April";
                case RadSchedulerStringId.YearlyRecurrenceAugust:
                    return "August";
                case RadSchedulerStringId.YearlyRecurrenceDayOfMonth:
                    return "Am:";
                case RadSchedulerStringId.YearlyRecurrenceDecember:
                    return "Dezember";
                case RadSchedulerStringId.YearlyRecurrenceFebruary:
                    return "Februar";
                case RadSchedulerStringId.YearlyRecurrenceJanuary:
                    return "Januar";
                case RadSchedulerStringId.YearlyRecurrenceJuly:
                    return "Juli";
                case RadSchedulerStringId.YearlyRecurrenceJune:
                    return "Juni";
                case RadSchedulerStringId.YearlyRecurrenceMarch:
                    return "März";
                case RadSchedulerStringId.YearlyRecurrenceMay:
                    return "Mai";
                case RadSchedulerStringId.YearlyRecurrenceNovember:
                    return "November";
                case RadSchedulerStringId.YearlyRecurrenceOctober:
                    return "Oktober";
                case RadSchedulerStringId.YearlyRecurrenceOfMonth:
                    return "im";
                case RadSchedulerStringId.YearlyRecurrenceSeptember:
                    return "September";
                case RadSchedulerStringId.YearlyRecurrenceWeekOfMonth:
                    return "Jeden:";
 
                //more translated strings
                default:
                    return base.GetLocalizedString( id );
            }
        }
    }
}
