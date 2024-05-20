using System;
using System.Linq;
using Telerik.WinControls.UI.Localization;

namespace CroatianRadControlsLocalization
{
    public class CroatianSchedulerLocalizationProvider : RadSchedulerLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadSchedulerStringId.NextAppointment:
                    return "Slijedeći Termin";
                case RadSchedulerStringId.PreviousAppointment:
                    return "Prethodni Termin";
                case RadSchedulerStringId.AppointmentDialogTitle:
                    return "Ažuriraj Termin";
                case RadSchedulerStringId.AppointmentDialogSubject:
                    return "Predmet:";
                case RadSchedulerStringId.AppointmentDialogLocation:
                    return "Lokacija:";
                case RadSchedulerStringId.AppointmentDialogBackground:
                    return "Pozadina:";
                case RadSchedulerStringId.AppointmentDialogDescription:
                    return "Opis:";
                case RadSchedulerStringId.AppointmentDialogStartTime:
                    return "Vrijeme početka:";
                case RadSchedulerStringId.AppointmentDialogEndTime:
                    return "Vrijeme završetka:";
                case RadSchedulerStringId.AppointmentDialogAllDay:
                    return "Cijelodnevni događaj";
                case RadSchedulerStringId.AppointmentDialogResource:
                    return "Resursi:";
                case RadSchedulerStringId.AppointmentDialogStatus:
                    return "Prikaži vrijeme kao:";
                case RadSchedulerStringId.AppointmentDialogOK:
                    return "OK";
                case RadSchedulerStringId.AppointmentDialogCancel:
                    return "Otkaži";
                case RadSchedulerStringId.AppointmentDialogDelete:
                    return "Obriši";
                case RadSchedulerStringId.AppointmentDialogRecurrence:
                    return "Ponavljanje";
                case RadSchedulerStringId.OpenRecurringDialogTitle:
                    return "Otvori ponavljajuće stavke";
                case RadSchedulerStringId.OpenRecurringDialogOK:
                    return "OK";
                case RadSchedulerStringId.OpenRecurringDialogCancel:
                    return "Otkaži";
                case RadSchedulerStringId.OpenRecurringDialogLabel:
                    return "\"{0}\" je ponavljajući\ntermin. Želite li otvoriti\nsamo ovaj ili cijelu seriju?";
                case RadSchedulerStringId.OpenRecurringDialogRadioOccurrence:
                    return "Otvori ovaj događaj.";
                case RadSchedulerStringId.OpenRecurringDialogRadioSeries:
                    return "Otvori seriju.";
                case RadSchedulerStringId.RecurrenceDialogTitle:
                    return "Ažuriraj ponavljanje.";
                case RadSchedulerStringId.RecurrenceDialogAppointmentTimeGroup:
                    return "Vrijeme događaja";
                case RadSchedulerStringId.RecurrenceDialogDuration:
                    return "Trajanje:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentEnd:
                    return "Kraj:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentStart:
                    return "Početak:";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceGroup:
                    return "Uzorak ponavljanja";
                case RadSchedulerStringId.RecurrenceDialogRangeGroup:
                    return "Raspon ponavljanja";
                case RadSchedulerStringId.RecurrenceDialogOccurrences:
                    return "Događaj";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceStart:
                    return "Početak:";
                case RadSchedulerStringId.RecurrenceDialogYearly:
                    return "Godišnje";
                case RadSchedulerStringId.RecurrenceDialogMonthly:
                    return "Mjesečno";
                case RadSchedulerStringId.RecurrenceDialogWeekly:
                    return "Tjedno";
                case RadSchedulerStringId.RecurrenceDialogDaily:
                    return "Dnevno";
                case RadSchedulerStringId.RecurrenceDialogEndBy:
                    return "Završetak do:";
                case RadSchedulerStringId.RecurrenceDialogEndAfter:
                    return "Završetak nakon:";
                case RadSchedulerStringId.RecurrenceDialogNoEndDate:
                    return "Bez datuma završetka";
                case RadSchedulerStringId.RecurrenceDialogOK:
                    return "OK";
                case RadSchedulerStringId.RecurrenceDialogCancel:
                    return "Otkaži";
                case RadSchedulerStringId.RecurrenceDialogRemoveRecurrence:
                    return "Ukloni ponavljanje";
                case RadSchedulerStringId.DailyRecurrenceEveryDay:
                    return "Svaki";
                case RadSchedulerStringId.DailyRecurrenceEveryWeekday:
                    return "Svaki radni dan";
                case RadSchedulerStringId.DailyRecurrenceDays:
                    return "dan(i)";
                case RadSchedulerStringId.WeeklyRecurrenceRecurEvery:
                    return "Ponovi svaki";
                case RadSchedulerStringId.WeeklyRecurrenceWeeksOn:
                    return "tjedan na:";
                case RadSchedulerStringId.WeeklyRecurrenceSunday:
                    return "Nedjelja";
                case RadSchedulerStringId.WeeklyRecurrenceMonday:
                    return "Ponedjeljak";
                case RadSchedulerStringId.WeeklyRecurrenceTuesday:
                    return "Utorak";
                case RadSchedulerStringId.WeeklyRecurrenceWednesday:
                    return "Srijeda";
                case RadSchedulerStringId.WeeklyRecurrenceThursday:
                    return "Četvrtak";
                case RadSchedulerStringId.WeeklyRecurrenceFriday:
                    return "Petak";
                case RadSchedulerStringId.WeeklyRecurrenceSaturday:
                    return "Subota";
                case RadSchedulerStringId.WeeklyRecurrenceDay:
                    return "Dan";
                case RadSchedulerStringId.WeeklyRecurrenceWeekday:
                    return "Radni dan";
                case RadSchedulerStringId.WeeklyRecurrenceWeekendDay:
                    return "Dan vikenda";
                case RadSchedulerStringId.MonthlyRecurrenceDay:
                    return "Dan";
                case RadSchedulerStringId.MonthlyRecurrenceWeek:
                    return "";
                case RadSchedulerStringId.MonthlyRecurrenceDayOfMonth:
                    return "svakog";
                case RadSchedulerStringId.MonthlyRecurrenceMonths:
                    return "mjesec(i)";
                case RadSchedulerStringId.MonthlyRecurrenceWeekOfMonth:
                    return "svaki";
                case RadSchedulerStringId.MonthlyRecurrenceFirst:
                    return "Prvi";
                case RadSchedulerStringId.MonthlyRecurrenceSecond:
                    return "Drugi";
                case RadSchedulerStringId.MonthlyRecurrenceThird:
                    return "Treći";
                case RadSchedulerStringId.MonthlyRecurrenceFourth:
                    return "Četvrti";
                case RadSchedulerStringId.MonthlyRecurrenceLast:
                    return "Posljednji";
                case RadSchedulerStringId.YearlyRecurrenceDayOfMonth:
                    return "Svaki";
                case RadSchedulerStringId.YearlyRecurrenceWeekOfMonth:
                    return "";
                case RadSchedulerStringId.YearlyRecurrenceOfMonth:
                    return "";
                case RadSchedulerStringId.YearlyRecurrenceJanuary:
                    return "Siječanj";
                case RadSchedulerStringId.YearlyRecurrenceFebruary:
                    return "Veljača";
                case RadSchedulerStringId.YearlyRecurrenceMarch:
                    return "Ožujak";
                case RadSchedulerStringId.YearlyRecurrenceApril:
                    return "Travanj";
                case RadSchedulerStringId.YearlyRecurrenceMay:
                    return "Svibanj";
                case RadSchedulerStringId.YearlyRecurrenceJune:
                    return "Lipanj";
                case RadSchedulerStringId.YearlyRecurrenceJuly:
                    return "Srpanj";
                case RadSchedulerStringId.YearlyRecurrenceAugust:
                    return "Kolovoz";
                case RadSchedulerStringId.YearlyRecurrenceSeptember:
                    return "Rujan";
                case RadSchedulerStringId.YearlyRecurrenceOctober:
                    return "Listopad";
                case RadSchedulerStringId.YearlyRecurrenceNovember:
                    return "Studeni";
                case RadSchedulerStringId.YearlyRecurrenceDecember:
                    return "Prosinac";
                case RadSchedulerStringId.BackgroundNone:
                    return "Nijedan";
                case RadSchedulerStringId.BackgroundImportant:
                    return "Važno";
                case RadSchedulerStringId.BackgroundBusiness:
                    return "Poslovno";
                case RadSchedulerStringId.BackgroundPersonal:
                    return "Osobno";
                case RadSchedulerStringId.BackgroundVacation:
                    return "Odmor";
                case RadSchedulerStringId.BackgroundMustAttend:
                    return "Mora pohađati";
                case RadSchedulerStringId.BackgroundTravelRequired:
                    return "Potreban put";
                case RadSchedulerStringId.BackgroundNeedsPreparation:
                    return "Potrebne pripreme";
                case RadSchedulerStringId.BackgroundBirthday:
                    return "Rođendan";
                case RadSchedulerStringId.BackgroundAnniversary:
                    return "Godišnjica";
                case RadSchedulerStringId.BackgroundPhoneCall:
                    return "Telefonski poziv";
                case RadSchedulerStringId.StatusBusy:
                    return "Zauzet";
                case RadSchedulerStringId.StatusFree:
                    return "Slobodan";
                case RadSchedulerStringId.StatusTentative:
                    return "Privremeno";
                case RadSchedulerStringId.StatusUnavailable:
                    return "Nedostupan";
                case RadSchedulerStringId.ContextMenuNewAppointment:
                    return "Novi termin";
                case RadSchedulerStringId.ContextMenuEditAppointment:
                    return "Ažuriraj termin";
                case RadSchedulerStringId.ContextMenuNewRecurringAppointment:
                    return "Novi ponavljajući termin";
                case RadSchedulerStringId.ContextMenu60Minutes:
                    return "60 minuta";
                case RadSchedulerStringId.ContextMenu30Minutes:
                    return "30 minuta";
                case RadSchedulerStringId.ContextMenu15Minutes:
                    return "15 minuta";
                case RadSchedulerStringId.ContextMenu10Minutes:
                    return "10 minuta";
                case RadSchedulerStringId.ContextMenu6Minutes:
                    return "6 minuta";
                case RadSchedulerStringId.ContextMenu5Minutes:
                    return "5 minuta";
                case RadSchedulerStringId.ContextMenuNavigateToNextView:
                    return "Sljedeći pregled";
                case RadSchedulerStringId.ContextMenuNavigateToPreviousView:
                    return "Prethodni pregled";
                case RadSchedulerStringId.ContextMenuTimescales:
                    return "Vremensko mjerilo";
                case RadSchedulerStringId.ContextMenuTimescalesYear:
                    return "Godina";
                case RadSchedulerStringId.ContextMenuTimescalesMonth:
                    return "Mjesec";
                case RadSchedulerStringId.ContextMenuTimescalesWeek:
                    return "Tjedan";
                case RadSchedulerStringId.ContextMenuTimescalesDay:
                    return "Dan";
                case RadSchedulerStringId.ContextMenuTimescalesHour:
                    return "Sat";
                case RadSchedulerStringId.ContextMenuTimescalesFifteenMinutes:
                    return "15 minuta";
                case RadSchedulerStringId.ErrorProviderWrongAppointmentDates:
                    return "Vrijeme završetka termina je manje ili jednako vremenu početka!";
                case RadSchedulerStringId.ErrorProviderWrongExceptionDuration:
                    return "Interval ponavljanja mora biti veći ili jednak trajanju termina!";
                case RadSchedulerStringId.TimeZoneLocal:
                    return "Lokalno";
            }

            return string.Empty;
        }
    }
}
