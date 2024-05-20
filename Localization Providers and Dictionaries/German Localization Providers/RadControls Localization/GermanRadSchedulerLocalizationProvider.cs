using System.Windows.Forms;
using Telerik.WinControls.UI.Localization;

namespace GermanRadControlsLocalization
{
    public class GermanRadSchedulerLocalizationProvider : RadSchedulerLocalizationProvider
    {
        public override string GetLocalizedString( string id )
        {
            switch ( id )
            {
				case RadSchedulerStringId.NextAppointment:
					return "nächster Termin";
				case RadSchedulerStringId.PreviousAppointment:
					return "vorheriger Termin";
				case RadSchedulerStringId.AppointmentDialogTitle:
					return "Termin";
				case RadSchedulerStringId.AppointmentDialogSubject:
					return "Betreff:";
				case RadSchedulerStringId.AppointmentDialogLocation:
					return "Ort:";
				case RadSchedulerStringId.AppointmentDialogBackground:
					return "Kategorie:";
				case RadSchedulerStringId.AppointmentDialogDescription:
					return "Beschreibung:";
				case RadSchedulerStringId.AppointmentDialogStartTime:
					return "Beginnt um:";
				case RadSchedulerStringId.AppointmentDialogEndTime:
					return "Endet um:";
				case RadSchedulerStringId.AppointmentDialogAllDay:
                    return "Ganztägiges Ereignis";
				case RadSchedulerStringId.AppointmentDialogResource:
					return "Ressource";
				case RadSchedulerStringId.AppointmentDialogStatus:
					return "Anzeigen als";
				case RadSchedulerStringId.AppointmentDialogOK:
					return "Bestätigen";
				case RadSchedulerStringId.AppointmentDialogCancel:
                    return "Abbrechen";
                case RadSchedulerStringId.AppointmentDialogDelete:
                    return "Löschen";
                case RadSchedulerStringId.AppointmentDialogRecurrence:
                    return "SerienTyp";

				case RadSchedulerStringId.OpenRecurringDialogTitle:
					return "Terminserie öffnen";
				case RadSchedulerStringId.DeleteRecurrenceDialogOK:
				case RadSchedulerStringId.OpenRecurringDialogOK:
					return "Bestätigen";
				case RadSchedulerStringId.DeleteRecurrenceDialogCancel:
				case RadSchedulerStringId.OpenRecurringDialogCancel:
					return "Abbrechen";
				case RadSchedulerStringId.OpenRecurringDialogLabel:
					return "\"{0}\" ist eine\nTerminserie. Möchten Sie nur diesen\nTermin oder die Terminserie öffnen?";
				case RadSchedulerStringId.OpenRecurringDialogRadioOccurrence:
					return "Dieses Serienelement öffnen.";
				case RadSchedulerStringId.OpenRecurringDialogRadioSeries:
					return "Die Serie öffnen.";
				case RadSchedulerStringId.DeleteRecurrenceDialogTitle:
					return "Terminserie löschen";
				case RadSchedulerStringId.DeleteRecurrenceDialogRadioOccurrence:
					return "Lösche diesen Termin.";
				case RadSchedulerStringId.DeleteRecurrenceDialogRadioSeries:
					return "Lösche die Terminserie.";
				case RadSchedulerStringId.DeleteRecurrenceDialogLabel:
					return "Möchten Sie alle  Termine der Terminserie \"{0}\" löschen, or nur diesen Termin?";

				case RadSchedulerStringId.RecurrenceDialogMessageBoxText:
					return "Das Beginndatum muss vor dem Endedatum liegen."; //"Das Serienmuster ist ungültig";
				case RadSchedulerStringId.RecurrenceDialogMessageBoxWrongRecurrenceRuleText:
					return "Das Serienmuster ist ungültig.";
				case RadSchedulerStringId.RecurrenceDialogMessageBoxTitle:
					return "Validierungsfehler:";
				case RadSchedulerStringId.RecurrenceDialogTitle:
					return "Terminserie";
				case RadSchedulerStringId.RecurrenceDialogAppointmentTimeGroup:
					return "Termin";
				case RadSchedulerStringId.RecurrenceDialogDuration:
					return "Dauer:";
				case RadSchedulerStringId.RecurrenceDialogAppointmentEnd:
					return "Ende:";
				case RadSchedulerStringId.RecurrenceDialogAppointmentStart:
					return "Beginn:";
				case RadSchedulerStringId.RecurrenceDialogRecurrenceGroup:
					return "Serienmuster";
				case RadSchedulerStringId.RecurrenceDialogRangeGroup:
					return "Seriendauer";
				case RadSchedulerStringId.RecurrenceDialogOccurrences:
					return "Terminen";
				case RadSchedulerStringId.RecurrenceDialogRecurrenceStart:
					return "Beginn:";
				case RadSchedulerStringId.RecurrenceDialogYearly:
					return "Jährlich";
				case RadSchedulerStringId.RecurrenceDialogMonthly:
					return "Monatlich";
				case RadSchedulerStringId.RecurrenceDialogWeekly:
					return "Wöchentlich";
				case RadSchedulerStringId.RecurrenceDialogDaily:
					return "Täglich";
				case RadSchedulerStringId.RecurrenceDialogEndBy:
					return "Endet am:";
				case RadSchedulerStringId.RecurrenceDialogEndAfter:
					return "Endet nach:";
				case RadSchedulerStringId.RecurrenceDialogNoEndDate:
					return "kein Enddatum";
				case RadSchedulerStringId.RecurrenceDialogOK:
					return "Bestätigen";
				case RadSchedulerStringId.RecurrenceDialogCancel:
					return "Abbrechen";
				case RadSchedulerStringId.RecurrenceDialogRemoveRecurrence:
					return "Serie entfernen";

				case RadSchedulerStringId.DailyRecurrenceEveryDay:
					return "Alle";
				case RadSchedulerStringId.DailyRecurrenceEveryWeekday:
					return "Jeden Arbeitstag";
				case RadSchedulerStringId.DailyRecurrenceDays:
					return "Tag(e)";

				case RadSchedulerStringId.WeeklyRecurrenceRecurEvery:
					return "Jede/Alle";
				case RadSchedulerStringId.WeeklyRecurrenceWeeksOn:
					return "Woche(n) am";
				case RadSchedulerStringId.WeeklyRecurrenceSunday:
					return "Sonntag";
				case RadSchedulerStringId.WeeklyRecurrenceMonday:
					return "Montag";
				case RadSchedulerStringId.WeeklyRecurrenceTuesday:
					return "Dienstag";
				case RadSchedulerStringId.WeeklyRecurrenceWednesday:
					return "Mittwoch";
				case RadSchedulerStringId.WeeklyRecurrenceThursday:
					return "Donnerstag";
				case RadSchedulerStringId.WeeklyRecurrenceFriday:
					return "Freitag";
				case RadSchedulerStringId.WeeklyRecurrenceSaturday:
					return "Samstag";

				case RadSchedulerStringId.WeeklyRecurrenceDay:
					return "Tag";
				case RadSchedulerStringId.WeeklyRecurrenceWeekday:
					return "Arbeitstag";
				case RadSchedulerStringId.WeeklyRecurrenceWeekendDay:
					return "Wochenendtag";

				case RadSchedulerStringId.MonthlyRecurrenceDay:
					return "Am";
				case RadSchedulerStringId.MonthlyRecurrenceWeek:
					return "Am";
				case RadSchedulerStringId.MonthlyRecurrenceDayOfMonth:
					return ". Tag jedes";
				case RadSchedulerStringId.MonthlyRecurrenceMonths:
					return ". Monats";
				case RadSchedulerStringId.MonthlyRecurrenceWeekOfMonth:
					return "jedes";
				case RadSchedulerStringId.MonthlyRecurrenceFirst:
					return "ersten";
				case RadSchedulerStringId.MonthlyRecurrenceSecond:
					return "zweiten";
				case RadSchedulerStringId.MonthlyRecurrenceThird:
					return "dritten";
				case RadSchedulerStringId.MonthlyRecurrenceFourth:
					return "vierten";
				case RadSchedulerStringId.MonthlyRecurrenceLast:
					return "letzten";

				case RadSchedulerStringId.YearlyRecurrenceDayOfMonth:
					return "Am:";
				case RadSchedulerStringId.YearlyRecurrenceWeekOfMonth:
					return "Jeden:";
				case RadSchedulerStringId.YearlyRecurrenceOfMonth:
					return "im";
				case RadSchedulerStringId.YearlyRecurrenceJanuary:
					return "Januar";
				case RadSchedulerStringId.YearlyRecurrenceFebruary:
					return "Februar";
				case RadSchedulerStringId.YearlyRecurrenceMarch:
					return "März";
				case RadSchedulerStringId.YearlyRecurrenceApril:
					return "April";
				case RadSchedulerStringId.YearlyRecurrenceMay:
					return "Mai";
				case RadSchedulerStringId.YearlyRecurrenceJune:
					return "Juni";
				case RadSchedulerStringId.YearlyRecurrenceJuly:
					return "Juli";
				case RadSchedulerStringId.YearlyRecurrenceAugust:
					return "August";
				case RadSchedulerStringId.YearlyRecurrenceSeptember:
					return "September";
				case RadSchedulerStringId.YearlyRecurrenceOctober:
					return "Oktober";
				case RadSchedulerStringId.YearlyRecurrenceNovember:
					return "November";
				case RadSchedulerStringId.YearlyRecurrenceDecember:
					return "Dezember";

				case RadSchedulerStringId.BackgroundNone:
					return "Keine";
				case RadSchedulerStringId.BackgroundImportant:
					return "Wichtig";
				case RadSchedulerStringId.BackgroundBusiness:
					return "Geschäftlich";
				case RadSchedulerStringId.BackgroundPersonal:
					return "Privat";
				case RadSchedulerStringId.BackgroundVacation:
					return "Urlaub";
				case RadSchedulerStringId.BackgroundMustAttend:
					return "Teilnahme verpflichtend";
				case RadSchedulerStringId.BackgroundTravelRequired:
					return "Reise notwendig";
				case RadSchedulerStringId.BackgroundNeedsPreparation:
					return "Benötigt Vorbereitung";
				case RadSchedulerStringId.BackgroundBirthday:
					return "Geburtstag";
				case RadSchedulerStringId.BackgroundAnniversary:
					return "Jubiläum";
				case RadSchedulerStringId.BackgroundPhoneCall:
					return "Telefonanruf";

				case RadSchedulerStringId.StatusBusy:
					return "Beschäftigt";
				case RadSchedulerStringId.StatusFree:
					return "Frei";
				case RadSchedulerStringId.StatusTentative:
					return "Mit Vorbehalt";
				case RadSchedulerStringId.StatusUnavailable:
					return "Abwesend";

				case RadSchedulerStringId.ContextMenuNewAppointment:
					return "Neuer Termin";
				case RadSchedulerStringId.ContextMenuEditAppointment:
					return "Öffnen";
				case RadSchedulerStringId.ContextMenuNewRecurringAppointment:
					return "Neue Terminserie";
				case RadSchedulerStringId.ContextMenu60Minutes:
					return "60 Minuten";
				case RadSchedulerStringId.ContextMenu30Minutes:
					return "30 Minuten";
				case RadSchedulerStringId.ContextMenu15Minutes:
					return "15 Minuten";
				case RadSchedulerStringId.ContextMenu10Minutes:
					return "10 Minuten";
				case RadSchedulerStringId.ContextMenu6Minutes:
					return "6 Minuten";
				case RadSchedulerStringId.ContextMenu5Minutes:
					return "5 Minuten";
				case RadSchedulerStringId.ContextMenuNavigateToNextView:
					return "nächste Zeitspanne";
				case RadSchedulerStringId.ContextMenuNavigateToPreviousView:
					return "vorherige Zeitspanne";
				case RadSchedulerStringId.ContextMenuTimescales:
					return "Zeitskala";
				case RadSchedulerStringId.ContextMenuTimescalesYear:
					return "Jahr";
				case RadSchedulerStringId.ContextMenuTimescalesMonth:
					return "Monat";
				case RadSchedulerStringId.ContextMenuTimescalesWeek:
					return "Woche";
				case RadSchedulerStringId.ContextMenuTimescalesDay:
					return "Tag";
				case RadSchedulerStringId.ContextMenuTimescalesHour:
					return "Stunde";
				case RadSchedulerStringId.ContextMenuTimescalesHalfHour:
					return "30 Minuten";
				case RadSchedulerStringId.ContextMenuTimescalesFifteenMinutes:
					return "15 Minuten";

				case RadSchedulerStringId.ErrorProviderWrongAppointmentDates:
					return "Das Endedatum liegt vor dem Beginndatum!";
				case RadSchedulerStringId.ErrorProviderWrongExceptionDuration:
					return "Das Terminserienintervall muß größer oder gleich der Termindauer sein!";
				case RadSchedulerStringId.TimeZoneLocal:
					return "lokal";
                default:
                    MessageBox.Show( string.Format( "GermanRadSchedulerLocalizationProvider: Missing Translation for: {0}" , id ) );
                    return base.GetLocalizedString( id );
            }
        }
    }
}
