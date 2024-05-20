using Telerik.WinControls.UI.Localization;

namespace MyApplicationName
{
    public
    class
    CustomSchedulerLocalizationProvider : RadSchedulerLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadSchedulerStringId.NextAppointment:
                    return "Sonraki Hatırlatma";

                case RadSchedulerStringId.PreviousAppointment:
                    return "Önceki Hatırlatma";

                case RadSchedulerStringId.AppointmentDialogTitle:

                    return "Hatırlatma Düzenle";

                case RadSchedulerStringId.AppointmentDialogSubject:

                    return "Konu:";

                case RadSchedulerStringId.AppointmentDialogLocation:

                    return "Yer:";

                case RadSchedulerStringId.AppointmentDialogBackground:

                    return "Arka Plan:";

                case RadSchedulerStringId.AppointmentDialogDescription:

                    return "Açıklama:";

                case RadSchedulerStringId.AppointmentDialogStartTime:

                    return "Başlangıç:";

                case RadSchedulerStringId.AppointmentDialogEndTime:

                    return "Bitiş:";

                case RadSchedulerStringId.AppointmentDialogAllDay:

                    return "Tüm Gün Hatırlat";

                case RadSchedulerStringId.AppointmentDialogResource:

                    return "Kaynak:";

                case RadSchedulerStringId.AppointmentDialogStatus:

                    return "Durumum:";

                case RadSchedulerStringId.AppointmentDialogOK:

                    return "Tamam";

                case RadSchedulerStringId.AppointmentDialogCancel:

                    return "İptal";

                case RadSchedulerStringId.AppointmentDialogDelete:

                    return "Sil";

                case RadSchedulerStringId.AppointmentDialogRecurrence:

                    return "Yineleme";

                case RadSchedulerStringId.OpenRecurringDialogTitle:

                    return "Yinelenen Nesneyi Aç";

                case RadSchedulerStringId.OpenRecurringDialogOK:

                    return "Tamam";

                case RadSchedulerStringId.OpenRecurringDialogCancel:

                    return "İptal";

                case RadSchedulerStringId.OpenRecurringDialogLabel:

                    return "\"{0}\" yinelenen\nolay. Sadece bu olay veya\nseriyi açmak ister misiniz?";

                case RadSchedulerStringId.OpenRecurringDialogRadioOccurrence:

                    return "Bu Oluşumu Aç.";

                case RadSchedulerStringId.OpenRecurringDialogRadioSeries:

                    return "Serileri Aç.";
                case RadSchedulerStringId.RecurrenceDialogTitle:

                    return "Yineleme Düzenle";

                case RadSchedulerStringId.RecurrenceDialogAppointmentTimeGroup:

                    return "Olay Zamanı";

                case RadSchedulerStringId.RecurrenceDialogDuration:

                    return "Süre:";

                case RadSchedulerStringId.RecurrenceDialogAppointmentEnd:

                    return "Son:";

                case RadSchedulerStringId.RecurrenceDialogAppointmentStart:

                    return "Başla:";

                case RadSchedulerStringId.RecurrenceDialogRecurrenceGroup:

                    return "Yinelenme";

                case RadSchedulerStringId.RecurrenceDialogRangeGroup:

                    return "Yineleme Aralığı";

                case RadSchedulerStringId.RecurrenceDialogOccurrences:

                    return "Oluşumlar";

                case RadSchedulerStringId.RecurrenceDialogRecurrenceStart:

                    return "Başla:";

                case RadSchedulerStringId.RecurrenceDialogYearly:

                    return "Yıllık";

                case RadSchedulerStringId.RecurrenceDialogMonthly:

                    return "Aylık";

                case RadSchedulerStringId.RecurrenceDialogWeekly:

                    return "Haftalık";

                case RadSchedulerStringId.RecurrenceDialogDaily:

                    return "Günlük";

                case RadSchedulerStringId.RecurrenceDialogEndBy:

                    return "Sonuna Kadar:";

                case RadSchedulerStringId.RecurrenceDialogEndAfter:

                    return "Sonra Bitir:";

                case RadSchedulerStringId.RecurrenceDialogNoEndDate:

                    return "Bitiş Tarihi Yok";

                case RadSchedulerStringId.RecurrenceDialogOK:

                    return "Tamam";

                case RadSchedulerStringId.RecurrenceDialogCancel:

                    return "İptal";

                case RadSchedulerStringId.RecurrenceDialogRemoveRecurrence:

                    return "Yinelemeyi Kaldır";

                case RadSchedulerStringId.DailyRecurrenceEveryDay:

                    return "Her";

                case RadSchedulerStringId.DailyRecurrenceEveryWeekday:

                    return "Hafta İçi";

                case RadSchedulerStringId.DailyRecurrenceDays:

                    return "gün(ler)";

                case RadSchedulerStringId.WeeklyRecurrenceRecurEvery:

                    return "Yinele Her";

                case RadSchedulerStringId.WeeklyRecurrenceWeeksOn:

                    return "hafta(lar) da:";

                case RadSchedulerStringId.WeeklyRecurrenceSunday:

                    return "Pazar";

                case RadSchedulerStringId.WeeklyRecurrenceMonday:

                    return "Pazartesi";

                case RadSchedulerStringId.WeeklyRecurrenceTuesday:

                    return "Salı";

                case RadSchedulerStringId.WeeklyRecurrenceWednesday:

                    return "Çarşamba";

                case RadSchedulerStringId.WeeklyRecurrenceThursday:

                    return "Perşembe";

                case RadSchedulerStringId.WeeklyRecurrenceFriday:

                    return "Cuma";

                case RadSchedulerStringId.WeeklyRecurrenceSaturday:

                    return "Cumartesi";

                case RadSchedulerStringId.WeeklyRecurrenceDay:

                    return "Gün";

                case RadSchedulerStringId.WeeklyRecurrenceWeekday:

                    return "Hafta İçi";

                case RadSchedulerStringId.WeeklyRecurrenceWeekendDay:

                    return "Haftasonu";

                case RadSchedulerStringId.MonthlyRecurrenceDay:

                    return "Gün";

                /* case RadSchedulerStringId.MonthlyRecurrenceWeek:
                return "The";*/
                /* case RadSchedulerStringId.MonthlyRecurrenceDayOfMonth:
                return "of every";*/

                case RadSchedulerStringId.MonthlyRecurrenceMonths:

                    return "ay(lar)";
                /*
                case RadSchedulerStringId.MonthlyRecurrenceWeekOfMonth:
                return "of every";*/

                case RadSchedulerStringId.MonthlyRecurrenceFirst:

                    return "Birinci";

                case RadSchedulerStringId.MonthlyRecurrenceSecond:

                    return "İkinci";

                case RadSchedulerStringId.MonthlyRecurrenceThird:

                    return "Üçüncü";

                case RadSchedulerStringId.MonthlyRecurrenceFourth:

                    return "Dördüncü";

                case RadSchedulerStringId.MonthlyRecurrenceLast:

                    return "Son";

                case RadSchedulerStringId.YearlyRecurrenceDayOfMonth:

                    return "Her";

                /* case RadSchedulerStringId.YearlyRecurrenceWeekOfMonth:


                return "The";*/

                /*case RadSchedulerStringId.YearlyRecurrenceOfMonth:


                return "of";*/

                case RadSchedulerStringId.YearlyRecurrenceJanuary:

                    return "Ocak";

                case RadSchedulerStringId.YearlyRecurrenceFebruary:

                    return "Şubat";

                case RadSchedulerStringId.YearlyRecurrenceMarch:

                    return "Mart";

                case RadSchedulerStringId.YearlyRecurrenceApril:

                    return "Nisan";

                case RadSchedulerStringId.YearlyRecurrenceMay:

                    return "Mayıs";

                case RadSchedulerStringId.YearlyRecurrenceJune:

                    return "Haziran";

                case RadSchedulerStringId.YearlyRecurrenceJuly:

                    return "Temmuz";

                case RadSchedulerStringId.YearlyRecurrenceAugust:

                    return "Ağustos";

                case RadSchedulerStringId.YearlyRecurrenceSeptember:

                    return "Eylül";

                case RadSchedulerStringId.YearlyRecurrenceOctober:

                    return "Ekim";

                case RadSchedulerStringId.YearlyRecurrenceNovember:

                    return "Kasım";

                case RadSchedulerStringId.YearlyRecurrenceDecember:

                    return "Aralık";

                case RadSchedulerStringId.BackgroundNone:

                    return "Boş";

                case RadSchedulerStringId.BackgroundImportant:

                    return "Önemli";

                case RadSchedulerStringId.BackgroundBusiness:

                    return "İş";

                case RadSchedulerStringId.BackgroundPersonal:

                    return "Personel";

                case RadSchedulerStringId.BackgroundVacation:

                    return "Tatil";

                case RadSchedulerStringId.BackgroundMustAttend:

                    return "Katılmalıyım";

                case RadSchedulerStringId.BackgroundTravelRequired:

                    return "Zorunlu Seyahat";

                case RadSchedulerStringId.BackgroundNeedsPreparation:

                    return "Hazırlık";

                case RadSchedulerStringId.BackgroundBirthday:

                    return "Doğum Günü";

                case RadSchedulerStringId.BackgroundAnniversary:

                    return "Yıldönümü";

                case RadSchedulerStringId.BackgroundPhoneCall:

                    return "Telefon Görüşmesi";

                case RadSchedulerStringId.StatusBusy:

                    return "Meşgul";

                case RadSchedulerStringId.StatusFree:

                    return "Uygun";

                case RadSchedulerStringId.StatusTentative:

                    return "Geçici";

                case RadSchedulerStringId.StatusUnavailable:

                    return "Tanımsız";

                case RadSchedulerStringId.ContextMenuNewAppointment:

                    return "Yeni Görev";

                case RadSchedulerStringId.ContextMenuEditAppointment:

                    return "Görevi Düzenle";

                case RadSchedulerStringId.ContextMenuNewRecurringAppointment:

                    return "Yeni Yineleme Görevi";

                case RadSchedulerStringId.ContextMenu60Minutes:

                    return "60 Dakika";

                case RadSchedulerStringId.ContextMenu30Minutes:

                    return "30 Dakika";

                case RadSchedulerStringId.ContextMenu15Minutes:

                    return "15 Dakika";

                case RadSchedulerStringId.ContextMenu10Minutes:

                    return "10 Dakika";

                case RadSchedulerStringId.ContextMenu6Minutes:

                    return "6 Dakika";

                case RadSchedulerStringId.ContextMenu5Minutes:

                    return "5 Dakika";

                case RadSchedulerStringId.ContextMenuNavigateToNextView:

                    return "Sonraki Görüntü";

                case RadSchedulerStringId.ContextMenuNavigateToPreviousView:

                    return "Önceki Görüntü";

                case RadSchedulerStringId.ContextMenuTimescales:

                    return "Zaman Skalaları";

                case RadSchedulerStringId.ContextMenuTimescalesYear:

                    return "Yıl";

                case RadSchedulerStringId.ContextMenuTimescalesMonth:

                    return "Ay";

                case RadSchedulerStringId.ContextMenuTimescalesWeek:

                    return "Hafta";

                case RadSchedulerStringId.ContextMenuTimescalesDay:

                    return "Gün";

                case RadSchedulerStringId.ContextMenuTimescalesHour:

                    return "Saat";

                case RadSchedulerStringId.ContextMenuTimescalesFifteenMinutes:

                    return "15 dakika";

                case RadSchedulerStringId.ErrorProviderWrongAppointmentDates:

                    return "Görev bitiş saati başlangıç zamanından daha az veya eşit olamaz!";

                case RadSchedulerStringId.ErrorProviderWrongExceptionDuration:

                    return "Tekrarlanma aralıkları randevu süresinden büyük veya  eşit olmalıdır!";

                case RadSchedulerStringId.TimeZoneLocal:

                    return "Yerel";

            }
            return string.Empty;
        }

    }
}