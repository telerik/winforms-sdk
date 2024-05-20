using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI.Localization;

namespace ParkmanagerPlanning.Localization
{
    public class CustomSchedulerLocalization : RadSchedulerLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadSchedulerStringId.NextAppointment:
                    return "Volgende Afspraak";
                case RadSchedulerStringId.PreviousAppointment:
                    return "Vorige Afspraak";
                case RadSchedulerStringId.AppointmentDialogTitle:
                    return "Bewerk Afspraak";
                case RadSchedulerStringId.AppointmentDialogSubject:
                    return "Onderwerp:";
                case RadSchedulerStringId.AppointmentDialogLocation:
                    return "Locatie:";
                case RadSchedulerStringId.AppointmentDialogBackground:
                    return "Achtergrond:";
                case RadSchedulerStringId.AppointmentDialogDescription:
                    return "Omschrijving:";
                case RadSchedulerStringId.AppointmentDialogStartTime:
                    return "Start tijd:";
                case RadSchedulerStringId.AppointmentDialogEndTime:
                    return "Eind tijd:";
                case RadSchedulerStringId.AppointmentDialogAllDay:
                    return "Duurt hele dag";
                case RadSchedulerStringId.AppointmentDialogResource:
                    return "Agenda:";
                case RadSchedulerStringId.AppointmentDialogStatus:
                    return "Laat tijd zien als:";
                case RadSchedulerStringId.AppointmentDialogOK:
                    return "Oke";
                case RadSchedulerStringId.AppointmentDialogCancel:
                    return "Annuleren";
                case RadSchedulerStringId.AppointmentDialogDelete:
                    return "Verwijderen";
                case RadSchedulerStringId.AppointmentDialogRecurrence:
                    return "Terugkeerpatroon";
                case RadSchedulerStringId.OpenRecurringDialogTitle:
                    return "Reeks openen";
                case RadSchedulerStringId.OpenRecurringDialogOK:
                    return "Oke";
                case RadSchedulerStringId.OpenRecurringDialogCancel:
                    return "Annuleren";
                case RadSchedulerStringId.OpenRecurringDialogLabel:
                    return "\"{0}\" is een terugkerende\nafspraak. Wilt u deze afsraak openen\nof de hele reeks?";
                case RadSchedulerStringId.OpenRecurringDialogRadioOccurrence:
                    return "Open deze afspraak.";
                case RadSchedulerStringId.OpenRecurringDialogRadioSeries:
                    return "Open de reeks";
                case RadSchedulerStringId.RecurrenceDialogTitle:
                    return "Bewerk terugkeerpatroon";
                case RadSchedulerStringId.RecurrenceDialogAppointmentTimeGroup:
                    return "Afspraak tijd";
                case RadSchedulerStringId.RecurrenceDialogDuration:
                    return "Duur:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentEnd:
                    return "Eind:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentStart:
                    return "Start:";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceGroup:
                    return "Terugkeerpatroon";
                case RadSchedulerStringId.RecurrenceDialogRangeGroup:
                    return "Bereik van terugkeerpatroon";
                case RadSchedulerStringId.RecurrenceDialogOccurrences:
                    return "keer";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceStart:
                    return "Start:";
                case RadSchedulerStringId.RecurrenceDialogYearly:
                    return "Jaarlijks";
                case RadSchedulerStringId.RecurrenceDialogMonthly:
                    return "Maandelijks";
                case RadSchedulerStringId.RecurrenceDialogWeekly:
                    return "Wekelijks";
                case RadSchedulerStringId.RecurrenceDialogDaily:
                    return "Dagelijks";
                case RadSchedulerStringId.RecurrenceDialogEndBy:
                    return "Eindigt op:";
                case RadSchedulerStringId.RecurrenceDialogEndAfter:
                    return "Eindigt na:";
                case RadSchedulerStringId.RecurrenceDialogNoEndDate:
                    return "Geen einddatum";
                case RadSchedulerStringId.RecurrenceDialogOK:
                    return "Oke";
                case RadSchedulerStringId.RecurrenceDialogCancel:
                    return "Annuleren";
                case RadSchedulerStringId.RecurrenceDialogRemoveRecurrence:
                    return "Terugkeerpatroon verwijderen";
                case RadSchedulerStringId.DailyRecurrenceEveryDay:
                    return "Elke";
                case RadSchedulerStringId.DailyRecurrenceEveryWeekday:
                    return "Elke weekdag";
                case RadSchedulerStringId.DailyRecurrenceDays:
                    return "dagen";
                case RadSchedulerStringId.WeeklyRecurrenceRecurEvery:
                    return "Keert elke";
                case RadSchedulerStringId.WeeklyRecurrenceWeeksOn:
                    return "week/weken terug";
                case RadSchedulerStringId.WeeklyRecurrenceSunday:
                    return "Zondag";
                case RadSchedulerStringId.WeeklyRecurrenceMonday:
                    return "Maandag";
                case RadSchedulerStringId.WeeklyRecurrenceTuesday:
                    return "Dinsdag";
                case RadSchedulerStringId.WeeklyRecurrenceWednesday:
                    return "Woensdag";
                case RadSchedulerStringId.WeeklyRecurrenceThursday:
                    return "Donderdag";
                case RadSchedulerStringId.WeeklyRecurrenceFriday:
                    return "Vrijdag";
                case RadSchedulerStringId.WeeklyRecurrenceSaturday:
                    return "Zaterdag";
                case RadSchedulerStringId.WeeklyRecurrenceDay:
                    return "Dag";
                case RadSchedulerStringId.WeeklyRecurrenceWeekday:
                    return "Weekdag";
                case RadSchedulerStringId.WeeklyRecurrenceWeekendDay:
                    return "Weekend dag";
                case RadSchedulerStringId.MonthlyRecurrenceDay:
                    return "Dag";
                case RadSchedulerStringId.MonthlyRecurrenceWeek:
                    return "De";
                case RadSchedulerStringId.MonthlyRecurrenceDayOfMonth:
                    return "van iedere";
                case RadSchedulerStringId.MonthlyRecurrenceMonths:
                    return "maand(en)";
                case RadSchedulerStringId.MonthlyRecurrenceWeekOfMonth:
                    return "van iedere";
                case RadSchedulerStringId.MonthlyRecurrenceFirst:
                    return "Eerste";
                case RadSchedulerStringId.MonthlyRecurrenceSecond:
                    return "Tweede";
                case RadSchedulerStringId.MonthlyRecurrenceThird:
                    return "Derde";
                case RadSchedulerStringId.MonthlyRecurrenceFourth:
                    return "Vierde";
                case RadSchedulerStringId.MonthlyRecurrenceLast:
                    return "Laatste";
                case RadSchedulerStringId.YearlyRecurrenceDayOfMonth:
                    return "Iedere";
                case RadSchedulerStringId.YearlyRecurrenceWeekOfMonth:
                    return "De";
                case RadSchedulerStringId.YearlyRecurrenceOfMonth:
                    return "van";
                case RadSchedulerStringId.YearlyRecurrenceJanuary:
                    return "Januari";
                case RadSchedulerStringId.YearlyRecurrenceFebruary:
                    return "Februari";
                case RadSchedulerStringId.YearlyRecurrenceMarch:
                    return "Maart";
                case RadSchedulerStringId.YearlyRecurrenceApril:
                    return "April";
                case RadSchedulerStringId.YearlyRecurrenceMay:
                    return "Mei";
                case RadSchedulerStringId.YearlyRecurrenceJune:
                    return "Juni";
                case RadSchedulerStringId.YearlyRecurrenceJuly:
                    return "Juli";
                case RadSchedulerStringId.YearlyRecurrenceAugust:
                    return "Augustus";
                case RadSchedulerStringId.YearlyRecurrenceSeptember:
                    return "September";
                case RadSchedulerStringId.YearlyRecurrenceOctober:
                    return "Oktober";
                case RadSchedulerStringId.YearlyRecurrenceNovember:
                    return "November";
                case RadSchedulerStringId.YearlyRecurrenceDecember:
                    return "December";
                case RadSchedulerStringId.BackgroundNone:
                    return "Geen";
                case RadSchedulerStringId.BackgroundImportant:
                    return "Belangrijk";
                case RadSchedulerStringId.BackgroundBusiness:
                    return "Zakelijk";
                case RadSchedulerStringId.BackgroundPersonal:
                    return "Persoonlijk";
                case RadSchedulerStringId.BackgroundVacation:
                    return "Vakantie";
                case RadSchedulerStringId.BackgroundMustAttend:
                    return "Aanwezigheid vereist";
                case RadSchedulerStringId.BackgroundTravelRequired:
                    return "Reizen benodigd";
                case RadSchedulerStringId.BackgroundNeedsPreparation:
                    return "Voorbereiding benodigd";
                case RadSchedulerStringId.BackgroundBirthday:
                    return "Verjaardag";
                case RadSchedulerStringId.BackgroundAnniversary:
                    return "Jubileum";
                case RadSchedulerStringId.BackgroundPhoneCall:
                    return "Telefoongesprek";
                case RadSchedulerStringId.StatusBusy:
                    return "Bezet";
                case RadSchedulerStringId.StatusFree:
                    return "Vrij";
                case RadSchedulerStringId.StatusTentative:
                    return "Voorlopig";
                case RadSchedulerStringId.StatusUnavailable:
                    return "Niet beschikbaar";
                case RadSchedulerStringId.ContextMenuNewAppointment:
                    return "Nieuwe afspraak";
                case RadSchedulerStringId.ContextMenuEditAppointment:
                    return "Bewerk afspraak";
                case RadSchedulerStringId.ContextMenuNewRecurringAppointment:
                    return "Nieuwe terugkerende afspraak";
                case RadSchedulerStringId.ContextMenu60Minutes:
                    return "60 minuten";
                case RadSchedulerStringId.ContextMenu30Minutes:
                    return "30 minuten";
                case RadSchedulerStringId.ContextMenu15Minutes:
                    return "15 minuten";
                case RadSchedulerStringId.ContextMenu10Minutes:
                    return "10 minuten";
                case RadSchedulerStringId.ContextMenu6Minutes:
                    return "6 minuten";
                case RadSchedulerStringId.ContextMenu5Minutes:
                    return "5 minuten";
                case RadSchedulerStringId.ContextMenuNavigateToNextView:
                    return "Volgende weergave";
                case RadSchedulerStringId.ContextMenuNavigateToPreviousView:
                    return "Vorige weergave";
                case RadSchedulerStringId.ContextMenuTimescales:
                    return "Tijdsbestek";
                case RadSchedulerStringId.ContextMenuTimescalesYear:
                    return "Jaar";
                case RadSchedulerStringId.ContextMenuTimescalesMonth:
                    return "Maand";
                case RadSchedulerStringId.ContextMenuTimescalesWeek:
                    return "Week";
                case RadSchedulerStringId.ContextMenuTimescalesDay:
                    return "Dag";
                case RadSchedulerStringId.ContextMenuTimescalesHour:
                    return "Uur";
                case RadSchedulerStringId.ContextMenuTimescalesFifteenMinutes:
                    return "15 minuten";
                case RadSchedulerStringId.ErrorProviderWrongAppointmentDates:
                    return "Eindtijd van deze afspraak is vroeger of gelijk aan begintijd!";
                case RadSchedulerStringId.ErrorProviderWrongExceptionDuration:
                    return "Terugkeer interval moet groter zijn of gelijk zijn aan afspraakduur!";
                case RadSchedulerStringId.TimeZoneLocal:
                    return "Lokaal";
                case RadSchedulerStringId.ContextMenuTimescalesHalfHour:
                    return "30 minuten";
            }

            throw new Exception("Vertaling niet gevonden: stringId " + id + " basetext: "+  base.GetLocalizedString(id));
        }
    }
}
