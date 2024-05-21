using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI.Localization;

namespace LocProviders
{
    public class ItalianSchedulerLocalizationProvider : RadSchedulerLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadSchedulerStringId.NextAppointment:
                    return "Prossimo appuntamento";
                case RadSchedulerStringId.PreviousAppointment:
                    return "Precedente appuntamento";
                case RadSchedulerStringId.AppointmentDialogTitle:
                    return "Modifica appuntamento";
                case RadSchedulerStringId.AppointmentDialogSubject:
                    return "Descrizione:";
                case RadSchedulerStringId.AppointmentDialogLocation:
                    return "Luogo:";
                case RadSchedulerStringId.AppointmentDialogBackground:
                    return "Tipologia:";
                case RadSchedulerStringId.AppointmentDialogStartTime:
                    return "Data/Ora inizio:";
                case RadSchedulerStringId.AppointmentDialogEndTime:
                    return "Data/Ora fine:";
                case RadSchedulerStringId.AppointmentDialogAllDay:
                    return "Giornaliero";
                case RadSchedulerStringId.AppointmentDialogResource:
                    return "Risorsa:";
                case RadSchedulerStringId.AppointmentDialogStatus:
                    return "Stato:";
                case RadSchedulerStringId.AppointmentDialogOK:
                    return "OK";
                case RadSchedulerStringId.AppointmentDialogCancel:
                    return "Annulla";
                case RadSchedulerStringId.AppointmentDialogDelete:
                    return "Cancella";
                case RadSchedulerStringId.AppointmentDialogRecurrence:
                    return "Ricorrenza";
                case RadSchedulerStringId.OpenRecurringDialogTitle:
                    return "Apri azione ricorrente";
                case RadSchedulerStringId.OpenRecurringDialogOK:
                    return "OK";
                case RadSchedulerStringId.OpenRecurringDialogCancel:
                    return "Annulla";
                case RadSchedulerStringId.OpenRecurringDialogLabel:
                    return "\"{0}\" è un appuntamento\nricorrente. Si desidera aprire solo\nquesta ricorrenza o tutta la serie?";
                case RadSchedulerStringId.OpenRecurringDialogRadioOccurrence:
                    return "Apri questa ricorrenza.";
                case RadSchedulerStringId.OpenRecurringDialogRadioSeries:
                    return "Apri tutta la serie.";
                case RadSchedulerStringId.RecurrenceDialogTitle:
                    return "Modifica ricorrenza";
                case RadSchedulerStringId.RecurrenceDialogAppointmentTimeGroup:
                    return "Durata appuntamento";
                case RadSchedulerStringId.RecurrenceDialogDuration:
                    return "Durata:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentEnd:
                    return "Fine:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentStart:
                    return "Inizio:";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceGroup:
                    return "Modello ricorrenza";
                case RadSchedulerStringId.RecurrenceDialogRangeGroup:
                    return "Periodo di ricorrenza";
                case RadSchedulerStringId.RecurrenceDialogOccurrences:
                    return "ripetizioni";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceStart:
                    return "Inizio:";
                case RadSchedulerStringId.RecurrenceDialogYearly:
                    return "Settimanale";
                case RadSchedulerStringId.RecurrenceDialogMonthly:
                    return "Mensile";
                case RadSchedulerStringId.RecurrenceDialogWeekly:
                    return "Settimanale";
                case RadSchedulerStringId.RecurrenceDialogDaily:
                    return "Giornaliero";
                case RadSchedulerStringId.RecurrenceDialogEndBy:
                    return "Fine entro:";
                case RadSchedulerStringId.RecurrenceDialogEndAfter:
                    return "Fine dopo:";
                case RadSchedulerStringId.RecurrenceDialogNoEndDate:
                    return "Nessuna data finale";
                case RadSchedulerStringId.RecurrenceDialogOK:
                    return "OK";
                case RadSchedulerStringId.RecurrenceDialogCancel:
                    return "Annulla";
                case RadSchedulerStringId.RecurrenceDialogRemoveRecurrence:
                    return "Remuovi ricorrenza";
                case RadSchedulerStringId.DailyRecurrenceEveryDay:
                    return "Ogni";
                case RadSchedulerStringId.DailyRecurrenceEveryWeekday:
                    return "Ogni giorno della settimana";
                case RadSchedulerStringId.DailyRecurrenceDays:
                    return "giorno(i)";
                case RadSchedulerStringId.WeeklyRecurrenceRecurEvery:
                    return "Ripeti ogni";
                case RadSchedulerStringId.WeeklyRecurrenceWeeksOn:
                    return "settimana(e) su:";
                case RadSchedulerStringId.WeeklyRecurrenceSunday:
                    return "Domenica";
                case RadSchedulerStringId.WeeklyRecurrenceMonday:
                    return "Lunedì";
                case RadSchedulerStringId.WeeklyRecurrenceTuesday:
                    return "Martedì";
                case RadSchedulerStringId.WeeklyRecurrenceWednesday:
                    return "Mercoledì";
                case RadSchedulerStringId.WeeklyRecurrenceThursday:
                    return "Giovedì";
                case RadSchedulerStringId.WeeklyRecurrenceFriday:
                    return "Venerdì";
                case RadSchedulerStringId.WeeklyRecurrenceSaturday:
                    return "Sabato";
                case RadSchedulerStringId.WeeklyRecurrenceDay:
                    return "Giorno";
                case RadSchedulerStringId.WeeklyRecurrenceWeekday:
                    return "feriale";
                case RadSchedulerStringId.WeeklyRecurrenceWeekendDay:
                    return "festivo";
                case RadSchedulerStringId.MonthlyRecurrenceDay:
                    return "Giorno";
                case RadSchedulerStringId.MonthlyRecurrenceWeek:
                    return "Il";
                case RadSchedulerStringId.MonthlyRecurrenceDayOfMonth:
                    return "di ogni";
                case RadSchedulerStringId.MonthlyRecurrenceMonths:
                    return "mese(i)";
                case RadSchedulerStringId.MonthlyRecurrenceWeekOfMonth:
                    return "di ogni";
                case RadSchedulerStringId.MonthlyRecurrenceFirst:
                    return "primo";
                case RadSchedulerStringId.MonthlyRecurrenceSecond:
                    return "secondo";
                case RadSchedulerStringId.MonthlyRecurrenceThird:
                    return "terzo";
                case RadSchedulerStringId.MonthlyRecurrenceFourth:
                    return "quarto";
                case RadSchedulerStringId.MonthlyRecurrenceLast:
                    return "Ultimo";
                case RadSchedulerStringId.YearlyRecurrenceDayOfMonth:
                    return "Ogni";
                case RadSchedulerStringId.YearlyRecurrenceWeekOfMonth:
                    return "Il";
                case RadSchedulerStringId.YearlyRecurrenceOfMonth:
                    return "di";
                case RadSchedulerStringId.YearlyRecurrenceJanuary:
                    return "Gennaio";
                case RadSchedulerStringId.YearlyRecurrenceFebruary:
                    return "Febbraio";
                case RadSchedulerStringId.YearlyRecurrenceMarch:
                    return "Marzo";
                case RadSchedulerStringId.YearlyRecurrenceApril:
                    return "Aprile";
                case RadSchedulerStringId.YearlyRecurrenceMay:
                    return "Maggio";
                case RadSchedulerStringId.YearlyRecurrenceJune:
                    return "Giugno";
                case RadSchedulerStringId.YearlyRecurrenceJuly:
                    return "Luglio";
                case RadSchedulerStringId.YearlyRecurrenceAugust:
                    return "Agosto";
                case RadSchedulerStringId.YearlyRecurrenceSeptember:
                    return "Settembre";
                case RadSchedulerStringId.YearlyRecurrenceOctober:
                    return "Ottobre";
                case RadSchedulerStringId.YearlyRecurrenceNovember:
                    return "Novembre";
                case RadSchedulerStringId.YearlyRecurrenceDecember:
                    return "Dicembre";
                case RadSchedulerStringId.BackgroundNone:
                    return "Nessuno";
                case RadSchedulerStringId.BackgroundImportant:
                    return "Importante";
                case RadSchedulerStringId.BackgroundBusiness:
                    return "Lavoro";
                case RadSchedulerStringId.BackgroundPersonal:
                    return "Personale";
                case RadSchedulerStringId.BackgroundVacation:
                    return "Vacanza";
                case RadSchedulerStringId.BackgroundMustAttend:
                    return "Obbligo presenza";
                case RadSchedulerStringId.BackgroundTravelRequired:
                    return "Viggio richiesto";
                case RadSchedulerStringId.BackgroundNeedsPreparation:
                    return "Preparazione necessaria";
                case RadSchedulerStringId.BackgroundBirthday:
                    return "Compleanno";
                case RadSchedulerStringId.BackgroundAnniversary:
                    return "Anniversario";
                case RadSchedulerStringId.BackgroundPhoneCall:
                    return "Telefonata";
                case RadSchedulerStringId.StatusBusy:
                    return "Occupato";
                case RadSchedulerStringId.StatusFree:
                    return "Libero";
                case RadSchedulerStringId.StatusTentative:
                    return "Tentativo";
                case RadSchedulerStringId.StatusUnavailable:
                    return "Indisponibile";
                case RadSchedulerStringId.ContextMenuNewAppointment:
                    return "Nuovo appuntamento";
                case RadSchedulerStringId.ContextMenuNewRecurringAppointment:
                    return "Nuovo appuntamento ripetuto";
                case RadSchedulerStringId.ContextMenu60Minutes:
                    return "60 Minuti";
                case RadSchedulerStringId.ContextMenu30Minutes:
                    return "30 Minuti";
                case RadSchedulerStringId.ContextMenu15Minutes:
                    return "15 Minuti";
                case RadSchedulerStringId.ContextMenu10Minutes:
                    return "10 Minuti";
                case RadSchedulerStringId.ContextMenu6Minutes:
                    return "6 Minuti";
                case RadSchedulerStringId.ContextMenu5Minutes:
                    return "5 Minuti";
                case RadSchedulerStringId.ContextMenuNavigateToNextView:
                    return "Prossima vista";
                case RadSchedulerStringId.ContextMenuNavigateToPreviousView:
                    return "Vista precedente";
            }
            System.Diagnostics.Debug.WriteLine("SCHEDULER:" + id);
            return string.Empty;
        }
    }
}
