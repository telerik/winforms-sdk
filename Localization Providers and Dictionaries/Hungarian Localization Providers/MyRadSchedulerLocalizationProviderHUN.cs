using Telerik.WinControls.UI.Localization;

namespace Psz.LoginokNet.Localization
{
    public class MyRadSchedulerLocalizationProviderHUN : RadSchedulerLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadSchedulerStringId.NextAppointment: return "Következő találkozó"; //"Next Appointment";
                case RadSchedulerStringId.PreviousAppointment: return "Előző találkozó";// "Previous Appointment";
                case RadSchedulerStringId.AppointmentDialogTitle: return "Találkozó szerkesztése";// "Edit Appointment";
                case RadSchedulerStringId.AppointmentDialogSubject: return "Tárgy:";// "Subject:";
                case RadSchedulerStringId.AppointmentDialogLocation: return "Hely:";// "Location:";
                case RadSchedulerStringId.AppointmentDialogBackground: return "Háttér:";// "Background:"; ??????????????????????
                case RadSchedulerStringId.AppointmentDialogDescription: return "Leírás:";// "Description:";
                case RadSchedulerStringId.AppointmentDialogStartTime: return "Kezdete:";// "Start time:";
                case RadSchedulerStringId.AppointmentDialogEndTime: return "Vége:";// "End time:";
                case RadSchedulerStringId.AppointmentDialogAllDay: return "Napi esemény";// "All day event";
                case RadSchedulerStringId.AppointmentDialogResource: return "Forrás:";// "Resource:"; ?????????????????????????????????
                case RadSchedulerStringId.AppointmentDialogStatus: return "Idő mint:";// "Show time as:";
                case RadSchedulerStringId.AppointmentDialogOK: return "Rendben";// "OK";
                case RadSchedulerStringId.AppointmentDialogCancel: return "Mégsem"; //"Cancel";
                case RadSchedulerStringId.AppointmentDialogDelete: return "Törlés";// "Delete";
                case RadSchedulerStringId.AppointmentDialogRecurrence: return "Ismétlés";// "Recurrence";
                case RadSchedulerStringId.OpenRecurringDialogTitle: return "Ismétlődő esemény megnyitása";// "Open Recurring Item";
                case RadSchedulerStringId.OpenRecurringDialogOK: return "Rendben";// "OK";
                case RadSchedulerStringId.OpenRecurringDialogCancel: return "Mégsem";// "Cancel";
                case RadSchedulerStringId.OpenRecurringDialogLabel: return "\"{0}\" is a recurring\nappointment. Do you want to open\nonly this occurrence or the series?";
                case RadSchedulerStringId.OpenRecurringDialogRadioOccurrence: return "Esemény megnyitása";// "Open this occurrence.";
                case RadSchedulerStringId.OpenRecurringDialogRadioSeries: return "Series megnyitása";// "Open the series."; ???????????????????
                case RadSchedulerStringId.RecurrenceDialogTitle: return "Esemény szerkesztése";// "Edit Recurrence";
                case RadSchedulerStringId.RecurrenceDialogAppointmentTimeGroup: return "Találkozó ideje";// "Appointment time";
                case RadSchedulerStringId.RecurrenceDialogDuration: return "Időtartam:";// "Duration:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentEnd: return "Vége:";// "End:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentStart: return "Kezdete:";// "Start:";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceGroup: return "Ismétlési minta";// "Recurrence pattern";
                case RadSchedulerStringId.RecurrenceDialogRangeGroup: return "Ismétlés hatásköre";// "Range of recurrence"; ?????????????????
                case RadSchedulerStringId.RecurrenceDialogOccurrences: return "Események";// "occurrences";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceStart: return "Kezdet:";// "Start:";
                case RadSchedulerStringId.RecurrenceDialogYearly: return "Éves";// "Yearly";
                case RadSchedulerStringId.RecurrenceDialogMonthly: return "Havi";// "Monthly";
                case RadSchedulerStringId.RecurrenceDialogWeekly: return "Heti";//  "Weekly";
                case RadSchedulerStringId.RecurrenceDialogDaily: return "Napi";// "Daily";
                case RadSchedulerStringId.RecurrenceDialogEndBy: return "Végződik:";// "End by:";
                case RadSchedulerStringId.RecurrenceDialogEndAfter: return "Utána végződik";// "End after:";????????????
                case RadSchedulerStringId.RecurrenceDialogNoEndDate: return "Nincs vége dátum";// "No end date";
                case RadSchedulerStringId.RecurrenceDialogOK: return "Rendben";// "OK";
                case RadSchedulerStringId.RecurrenceDialogCancel: return "Mégsem";// "Cancel";
                case RadSchedulerStringId.RecurrenceDialogRemoveRecurrence: return "Ismétlés törlése";// "Remove Recurrence";
                case RadSchedulerStringId.DailyRecurrenceEveryDay: return "Mindig";// "Every"; 
                case RadSchedulerStringId.DailyRecurrenceEveryWeekday: return "Minden hétköznap";// "Every weekday"; 
                case RadSchedulerStringId.DailyRecurrenceDays: return "nap(ok)";// "day(s)";
                case RadSchedulerStringId.WeeklyRecurrenceRecurEvery: return "Mindig ismétlődik";// "Recur every";
                case RadSchedulerStringId.WeeklyRecurrenceWeeksOn: return "Hét(ek):";// "week(s) on:";
                case RadSchedulerStringId.WeeklyRecurrenceSunday: return "Vasárnap";// "Sunday";
                case RadSchedulerStringId.WeeklyRecurrenceMonday: return "Hétfő";// "Monday";
                case RadSchedulerStringId.WeeklyRecurrenceTuesday: return "Kedd";// "Tuesday";
                case RadSchedulerStringId.WeeklyRecurrenceWednesday: return "Szerda";// "Wednesday";
                case RadSchedulerStringId.WeeklyRecurrenceThursday: return "Csütörtök";// "Thursday";
                case RadSchedulerStringId.WeeklyRecurrenceFriday: return "Péntek";// "Friday";
                case RadSchedulerStringId.WeeklyRecurrenceSaturday: return "Szombat";// "Saturday";
                case RadSchedulerStringId.WeeklyRecurrenceDay: return "Nap";// "Day";
                case RadSchedulerStringId.WeeklyRecurrenceWeekday: return "Hétköznap";// "Weekday";
                case RadSchedulerStringId.WeeklyRecurrenceWeekendDay: return "Hétvége";// "Weekend day";
                case RadSchedulerStringId.MonthlyRecurrenceDay: return "Nap";// "Day";
                case RadSchedulerStringId.MonthlyRecurrenceWeek: return "A(z)";// "The"; ????
                case RadSchedulerStringId.MonthlyRecurrenceDayOfMonth: return "összes";// "of every";
                case RadSchedulerStringId.MonthlyRecurrenceMonths: return "hónap(ok)";// "month(s)";
                case RadSchedulerStringId.MonthlyRecurrenceWeekOfMonth: return "összes";// "of every";
                case RadSchedulerStringId.MonthlyRecurrenceFirst: return "Első";// "First";
                case RadSchedulerStringId.MonthlyRecurrenceSecond: return "Második";// "Second";
                case RadSchedulerStringId.MonthlyRecurrenceThird: return "Harmadik";// "Third";
                case RadSchedulerStringId.MonthlyRecurrenceFourth: return "Negyedik";// "Fourth";
                case RadSchedulerStringId.MonthlyRecurrenceLast: return "Utolsó";// "Last";
                case RadSchedulerStringId.YearlyRecurrenceDayOfMonth: return "Minden";// "Every";
                case RadSchedulerStringId.YearlyRecurrenceWeekOfMonth: return "A(z)";// "The";
                case RadSchedulerStringId.YearlyRecurrenceOfMonth: return "of"; //????????
                case RadSchedulerStringId.YearlyRecurrenceJanuary: return "Január";// "January";
                case RadSchedulerStringId.YearlyRecurrenceFebruary: return "Február";// "February";
                case RadSchedulerStringId.YearlyRecurrenceMarch: return "Március";// "March";
                case RadSchedulerStringId.YearlyRecurrenceApril: return "Április";// "April";
                case RadSchedulerStringId.YearlyRecurrenceMay: return "Május";// "May";
                case RadSchedulerStringId.YearlyRecurrenceJune: return "Június";// "June";
                case RadSchedulerStringId.YearlyRecurrenceJuly: return "Július";// "July";
                case RadSchedulerStringId.YearlyRecurrenceAugust: return "Augusztus";// "August";
                case RadSchedulerStringId.YearlyRecurrenceSeptember: return "Szeptember";// "September";
                case RadSchedulerStringId.YearlyRecurrenceOctober: return "Október";// "October";
                case RadSchedulerStringId.YearlyRecurrenceNovember: return "November";// "November";
                case RadSchedulerStringId.YearlyRecurrenceDecember: return "December";// "December";
                case RadSchedulerStringId.BackgroundNone: return "Nincs";// "None";
                case RadSchedulerStringId.BackgroundImportant: return "Fontos";// "Important";
                case RadSchedulerStringId.BackgroundBusiness: return "Munka";// "Business";
                case RadSchedulerStringId.BackgroundPersonal: return "Személyes";// "Personal";
                case RadSchedulerStringId.BackgroundVacation: return "Szabadság";// "Vacation";
                case RadSchedulerStringId.BackgroundMustAttend: return "Kötelező";// "Must Attend"; ????????
                case RadSchedulerStringId.BackgroundTravelRequired: return "Utazni kell";// "Travel Required";
                case RadSchedulerStringId.BackgroundNeedsPreparation: return "Előkészületet igényel";// "Needs Preparation";
                case RadSchedulerStringId.BackgroundBirthday: return "Születésnap";// "Birthday";
                case RadSchedulerStringId.BackgroundAnniversary: return "Évforduló";// "Anniversary";
                case RadSchedulerStringId.BackgroundPhoneCall: return "Telefon hívás";// "Phone Call";
                case RadSchedulerStringId.StatusBusy: return "Elfoglalt";// "Busy";
                case RadSchedulerStringId.StatusFree: return "Szabad";// "Free";
                case RadSchedulerStringId.StatusTentative: return "Próba";// "Tentative"; ?????
                case RadSchedulerStringId.StatusUnavailable: return "Nem elérhető";// "Unavailable";
                case RadSchedulerStringId.ContextMenuNewAppointment: return "Új találkozó";// "New Appointment";
                case RadSchedulerStringId.ContextMenuEditAppointment: return "Találkozó szerkesztése";// "Edit Appointment";
                case RadSchedulerStringId.ContextMenuNewRecurringAppointment: return "Új ismétlődő találkozó";// "New Recurring Appointment";
                case RadSchedulerStringId.ContextMenu60Minutes: return "60 perc";// "60 Minutes";
                case RadSchedulerStringId.ContextMenu30Minutes: return "30 perc";// "30 Minutes";
                case RadSchedulerStringId.ContextMenu15Minutes: return "15 perc";// "15 Minutes";
                case RadSchedulerStringId.ContextMenu10Minutes: return "10 perc";// "10 Minutes";
                case RadSchedulerStringId.ContextMenu6Minutes: return "6 perc";// "6 Minutes";
                case RadSchedulerStringId.ContextMenu5Minutes: return "5 perc";// "5 Minutes";
                case RadSchedulerStringId.ContextMenuNavigateToNextView: return "Következő";// "Next View";
                case RadSchedulerStringId.ContextMenuNavigateToPreviousView: return "Előző";// "Previous View";
                case RadSchedulerStringId.ContextMenuTimescales: return "Idő skála";// "Time Scales";
                case RadSchedulerStringId.ContextMenuTimescalesYear: return "Év";// "Year";
                case RadSchedulerStringId.ContextMenuTimescalesMonth: return "Hónap";// "Month";
                case RadSchedulerStringId.ContextMenuTimescalesWeek: return "Hét";// "Week";
                case RadSchedulerStringId.ContextMenuTimescalesDay: return "Nap";// "Day";
                case RadSchedulerStringId.ContextMenuTimescalesHour: return "Óra";// "Hour";
                case RadSchedulerStringId.ContextMenuTimescalesFifteenMinutes: return "15 perc";// "15 minutes";
                case RadSchedulerStringId.ErrorProviderWrongAppointmentDates: return "Találkozó vége kisebb vagy egyenlő mint a kezdete";// "Appointment end time is less or equal to start time!";
                case RadSchedulerStringId.ErrorProviderWrongExceptionDuration: return "Az ismétlés intervalluma nagyobb egyenőnek kell lennie a találkozó idejenél";// "Recurrence interval must be greater or equal to appointment duration!";
                case RadSchedulerStringId.TimeZoneLocal: return "Helyi";// "Local";
            }

            return string.Empty;
        }
    }
}
