public class FrenshRadReminderLocalizationProvider : RadReminderLocalizationProvider
        {
            public override string GetLocalizedString(string id)
            {
                switch (id)
                {
                    case RadReminderStringId.AlarmFormButtonDismiss:
                        return "Faire disparaître";
                    case RadReminderStringId.AlarmFormButtonDismissAll:
                        return "Faire tout disparaître";
                    case RadReminderStringId.AlarmFormButtonOpenItem:
                        return "Ouvrir l'élément";
                    case RadReminderStringId.AlarmFormButtonSnooze:
                        return "Répéter";
                    case RadReminderStringId.AlarmFormColumnDueIn:
                        return "Echéance";
                    case RadReminderStringId.AlarmFormColumnSubject:
                        return "Objet";
                    case RadReminderStringId.AlarmFormLabelSnooze:
                        return "Cliquez sur Répéter pour recevoir un rappel dans :";
                    case RadReminderStringId.AlarmFormReminder:
                        return "Mémoire";
                    case RadReminderStringId.AlarmFormReminders:
                        return "Souvenirs";
                    case RadReminderStringId.AlarmFormSelectMoreRemindObjects:
                        return "Les souvenirs sont sélectionnés.";
                    case RadReminderStringId.AlarmFormSnoozeEightHours:
                        return "8 heures";
                    case RadReminderStringId.AlarmFormSnoozeFifteenMinutes:
                        return "15 minutes";
                    case RadReminderStringId.AlarmFormSnoozeFiveMinutes:
                        return "5 minutes";
                    case RadReminderStringId.AlarmFormSnoozeFourDays:
                        return "4 jours";
                    case RadReminderStringId.AlarmFormSnoozeFourHours:
                        return "4 heures";
                    case RadReminderStringId.AlarmFormSnoozeHalfDay:
                        return "0,5 jour";
                    case RadReminderStringId.AlarmFormSnoozeOneDay:
                        return "1 jour";
                    case RadReminderStringId.AlarmFormSnoozeOneHour:
                        return "1 heure";
                    case RadReminderStringId.AlarmFormSnoozeOneMinute:
                        return "1 minute";
                    case RadReminderStringId.AlarmFormSnoozeOneWeek:
                        return "1 semaine";
                    case RadReminderStringId.AlarmFormSnoozeTenMinutes:
                        return "10 minutes";
                    case RadReminderStringId.AlarmFormSnoozeThirtyMinutes:
                        return "30 minutes";
                    case RadReminderStringId.AlarmFormSnoozeThreeDays:
                        return "3 jours";
                    case RadReminderStringId.AlarmFormSnoozeTwoDays:
                        return "2 jours";
                    case RadReminderStringId.AlarmFormSnoozeTwoHours:
                        return "2 heures";
                    case RadReminderStringId.AlarmFormSnoozeTwoWeeks:
                        return "2 semaines";
                    case RadReminderStringId.DueInDay:
                        return "Jour de retard";
                    case RadReminderStringId.DueInDays:
                        return "Jours de retard";
                    case RadReminderStringId.DueInHour:
                        return "Heure de retard";
                    case RadReminderStringId.DueInHours:
                        return "Heures de retard";
                    case RadReminderStringId.DueInMinute:
                        return "Minute de retard";
                    case RadReminderStringId.DueInMinutes:
                        return "Minutes de retard";
                    case RadReminderStringId.DueInOverdue:
                        return "Depuis {0}";
                    case RadReminderStringId.DueInWeek:
                        return "Semaine de retard";
                    case RadReminderStringId.DueInWeeks:
                        return "Semaines de retard";
                    case RadReminderStringId.DueInNow:
                        return "Maintenant";
                    default:
                          break;
                }
 
                return String.Empty;
            }
        }