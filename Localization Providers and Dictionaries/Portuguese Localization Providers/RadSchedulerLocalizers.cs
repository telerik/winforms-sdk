using System;
using System.Linq;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace RadScheduler.Localization
{
    #region Telerik.RadSchedulerNavigator

    /// <summary>
    /// "Provider" para providenciar lozalização em Português Europeu (pt_PT) ao <see cref="RadSchedulerNavigator"/> do scheduler TELERIK
    /// </summary>
    public class RadSchedulerNavigatorLocalizationProviderPT_PT : SchedulerNavigatorLocalizationProvider
    {
        /// <summary>
        /// Tradução da <see cref="RadSchedulerNavigator"/> para Português Europeu (pt_PT)
        /// </summary>
        /// <param name="id">O ID da string a traduzir</param>
        /// <returns>A <see cref="string"/> traduzida</returns>
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case SchedulerNavigatorStringId.DayViewButtonCaption:
                    return "Vista Diária";
                case SchedulerNavigatorStringId.WeekViewButtonCaption:
                    return "Vista Semanal";
                case SchedulerNavigatorStringId.MonthViewButtonCaption:
                    return "Vista Mensal";
                case SchedulerNavigatorStringId.ShowWeekendCheckboxCaption:
                    return "Mostrar Fim-de-Semana";
                case SchedulerNavigatorStringId.TimelineViewButtonCaption:
                    return "Vista de \"time-line\"";
                case SchedulerNavigatorStringId.TodayButtonCaptionThisMonth:
                    return "Mês atual";
                case SchedulerNavigatorStringId.TodayButtonCaptionThisWeek:
                    return "Semana atual";
                case SchedulerNavigatorStringId.TodayButtonCaptionToday:
                    return "Hoje";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }

    #endregion

    #region Telerik.RadScheduler

    /// <summary>
    /// Classe para providenciar lozalização em Português Europeu (pt_PT) ao <see cref="RadScheduler"/> TELERIK
    /// </summary>
    public class RadSchedulerLocalizationProviderPT_PT : RadSchedulerLocalizationProvider
    {
        /// <summary>
        /// Tradução do <see cref="RadScheduler"/> para Português Europeu (pt_PT)
        /// </summary>
        /// <param name="id">O ID da string a traduzir</param>
        /// <returns>A <see cref="string"/> traduzida</returns>
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadSchedulerStringId.AppointmentDialogAllDay:
                    return "todo o dia";
                case RadSchedulerStringId.AppointmentDialogBackground:
                    return "Cor:";
                case RadSchedulerStringId.AppointmentDialogCancel:
                    return "Cancelar";
                case RadSchedulerStringId.AppointmentDialogDelete:
                    return "Apagar";
                case RadSchedulerStringId.AppointmentDialogEndTime:
                    return "Hora de fim:";
                case RadSchedulerStringId.AppointmentDialogLocation:
                    return "Local :";
                case RadSchedulerStringId.AppointmentDialogOK:
                    return "OK";
                case RadSchedulerStringId.AppointmentDialogRecurrence:
                    return "Recorrência";
                case RadSchedulerStringId.AppointmentDialogResource:
                    return "Recurso";
                case RadSchedulerStringId.AppointmentDialogStartTime:
                    return "Hora de início:";
                case RadSchedulerStringId.AppointmentDialogStatus:
                    return "Estado";
                case RadSchedulerStringId.AppointmentDialogSubject:
                    return "Assunto:";
                case RadSchedulerStringId.AppointmentDialogTitle:
                    return "Editar agendamento";
                case RadSchedulerStringId.BackgroundAnniversary:
                    return "Aniversário corporativo";
                case RadSchedulerStringId.BackgroundBirthday:
                    return "Aniversário social";
                case RadSchedulerStringId.BackgroundBusiness:
                    return "Negócio";
                case RadSchedulerStringId.BackgroundImportant:
                    return "Importante";
                case RadSchedulerStringId.BackgroundMustAttend:
                    return "Obrigatório assistir";
                case RadSchedulerStringId.BackgroundNeedsPreparation:
                    return "Necessita de preparação";
                case RadSchedulerStringId.BackgroundNone:
                    return "Nenhum";
                case RadSchedulerStringId.BackgroundPersonal:
                    return "Pessoal";
                case RadSchedulerStringId.BackgroundPhoneCall:
                    return "Chamada telefónica";
                case RadSchedulerStringId.BackgroundTravelRequired:
                    return "Implica viagem";
                case RadSchedulerStringId.BackgroundVacation:
                    return "Férias";
                case RadSchedulerStringId.ContextMenu10Minutes:
                    return "10 minutos";
                case RadSchedulerStringId.ContextMenu15Minutes:
                    return "15 minutos";
                case RadSchedulerStringId.ContextMenu30Minutes:
                    return "30 minutos";
                case RadSchedulerStringId.ContextMenu5Minutes:
                    return "5 minutos";
                case RadSchedulerStringId.ContextMenu60Minutes:
                    return "60 minutos";
                case RadSchedulerStringId.ContextMenu6Minutes:
                    return "6 minutos";
                case RadSchedulerStringId.ContextMenuEditAppointment:
                    return "Editar";
                case RadSchedulerStringId.ContextMenuNavigateToNextView:
                    return "Próximo";
                case RadSchedulerStringId.ContextMenuNavigateToPreviousView:
                    return "Anterior";
                case RadSchedulerStringId.ContextMenuNewAppointment:
                    return "Novo agendamento";
                case RadSchedulerStringId.ContextMenuNewRecurringAppointment:
                    return "Novo agendamento recorrente";
                case RadSchedulerStringId.ContextMenuTimescales:
                    return "Escala de tempo";
                case RadSchedulerStringId.ContextMenuTimescalesDay:
                    return "Dia";
                case RadSchedulerStringId.ContextMenuTimescalesFifteenMinutes:
                    return "15 minutos";
                case RadSchedulerStringId.ContextMenuTimescalesHour:
                    return "Hora";
                case RadSchedulerStringId.ContextMenuTimescalesMonth:
                    return "Mês";
                case RadSchedulerStringId.ContextMenuTimescalesWeek:
                    return "Semana";
                case RadSchedulerStringId.ContextMenuTimescalesYear:
                    return "Dia";
                case RadSchedulerStringId.DailyRecurrenceDays:
                    return "Dia(s)"; // era Dia(e)
                case RadSchedulerStringId.DailyRecurrenceEveryDay:
                    return "A cada";
                case RadSchedulerStringId.DailyRecurrenceEveryWeekday:
                    return "Todos os dias de semana";
                case RadSchedulerStringId.ErrorProviderWrongAppointmentDates:
                    return "As datas introduzidas são inválidas!";
                case RadSchedulerStringId.ErrorProviderWrongExceptionDuration:
                    return "A duração introduzida é inválida!";
                case RadSchedulerStringId.MonthlyRecurrenceDay:
                    return "Dia";
                case RadSchedulerStringId.MonthlyRecurrenceDayOfMonth:
                    return "a cada"; // Alterar
                case RadSchedulerStringId.MonthlyRecurrenceFirst:
                    return "primeiro";
                case RadSchedulerStringId.MonthlyRecurrenceFourth:
                    return "quarto";
                case RadSchedulerStringId.MonthlyRecurrenceLast:
                    return "último";
                case RadSchedulerStringId.MonthlyRecurrenceMonths:
                    return "Meses"; // Alterar
                case RadSchedulerStringId.MonthlyRecurrenceSecond:
                    return "segundo";
                case RadSchedulerStringId.MonthlyRecurrenceThird:
                    return "terceiro";
                case RadSchedulerStringId.MonthlyRecurrenceWeek:
                    return "No";
                case RadSchedulerStringId.MonthlyRecurrenceWeekOfMonth:
                    return "a cada";
                case RadSchedulerStringId.NextAppointment:
                    return "Próximo agendamento";
                case RadSchedulerStringId.OpenRecurringDialogCancel:
                    return "Cancelar";
                case RadSchedulerStringId.OpenRecurringDialogLabel:
                    return "\"{0}\" é um agendamento recorrente.\n Abrir apenas esta ocorrência ou toda a série?";
                case RadSchedulerStringId.OpenRecurringDialogOK:
                    return "OK";
                case RadSchedulerStringId.OpenRecurringDialogRadioOccurrence:
                    return "Abrir esta ocorrência.";
                case RadSchedulerStringId.OpenRecurringDialogRadioSeries:
                    return "Abrir a série.";
                case RadSchedulerStringId.OpenRecurringDialogTitle:
                    return "Abrir agendamento recorrente";
                case RadSchedulerStringId.PreviousAppointment:
                    return "Agendamento anterior";
                case RadSchedulerStringId.RecurrenceDialogAppointmentEnd:
                    return "Fim:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentStart:
                    return "Início:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentTimeGroup:
                    return "Data";
                case RadSchedulerStringId.RecurrenceDialogCancel:
                    return "Cancelar";
                case RadSchedulerStringId.RecurrenceDialogDaily:
                    return "Diário";
                case RadSchedulerStringId.RecurrenceDialogDuration:
                    return "Duração:";
                case RadSchedulerStringId.RecurrenceDialogEndAfter:
                    return "Termina depois de:";
                case RadSchedulerStringId.RecurrenceDialogEndBy:
                    return "Termina em:";
                case RadSchedulerStringId.RecurrenceDialogMessageBoxTitle:
                    return "Erro de validação:";
                case RadSchedulerStringId.RecurrenceDialogMessageBoxText:
                    return "Padrão de recorrência inválido.";
                case RadSchedulerStringId.RecurrenceDialogMonthly:
                    return "Mensal";
                case RadSchedulerStringId.RecurrenceDialogNoEndDate:
                    return "Sem data de fim";
                case RadSchedulerStringId.RecurrenceDialogOccurrences:
                    return "Ocorrências";
                case RadSchedulerStringId.RecurrenceDialogOK:
                    return "OK";
                case RadSchedulerStringId.RecurrenceDialogRangeGroup:
                    return "Intervalo";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceGroup:
                    return "Padrão de recorrência";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceStart:
                    return "Início:";
                case RadSchedulerStringId.RecurrenceDialogRemoveRecurrence:
                    return "Remover recorrência";
                case RadSchedulerStringId.RecurrenceDialogTitle:
                    return "Agendamento recorrente";
                case RadSchedulerStringId.RecurrenceDialogWeekly:
                    return "Semanal";
                case RadSchedulerStringId.RecurrenceDialogYearly:
                    return "Anual";
                case RadSchedulerStringId.StatusBusy:
                    return "Ocupado";
                case RadSchedulerStringId.StatusFree:
                    return "Livre";
                case RadSchedulerStringId.StatusTentative:
                    return "Possivelmente livre";
                case RadSchedulerStringId.StatusUnavailable:
                    return "Indisponível";
                case RadSchedulerStringId.TimeZoneLocal:
                    return "local";
                case RadSchedulerStringId.WeeklyRecurrenceDay:
                    return "Dia";
                case RadSchedulerStringId.WeeklyRecurrenceFriday:
                    return "sexta-feira";
                case RadSchedulerStringId.WeeklyRecurrenceMonday:
                    return "segunda-feira";
                case RadSchedulerStringId.WeeklyRecurrenceRecurEvery:
                    return "A cada";
                case RadSchedulerStringId.WeeklyRecurrenceSaturday:
                    return "sábado";
                case RadSchedulerStringId.WeeklyRecurrenceSunday:
                    return "domingo";
                case RadSchedulerStringId.WeeklyRecurrenceThursday:
                    return "quinta-feira";
                case RadSchedulerStringId.WeeklyRecurrenceTuesday:
                    return "terça-feira";
                case RadSchedulerStringId.WeeklyRecurrenceWednesday:
                    return "quarta-feira";
                case RadSchedulerStringId.WeeklyRecurrenceWeekday:
                    return "dia de semana";
                case RadSchedulerStringId.WeeklyRecurrenceWeekendDay:
                    return "fim de semana";
                case RadSchedulerStringId.WeeklyRecurrenceWeeksOn:
                    return "Semana(s) na(o)"; //em
                case RadSchedulerStringId.YearlyRecurrenceApril:
                    return "Abril";
                case RadSchedulerStringId.YearlyRecurrenceAugust:
                    return "Agosto";
                case RadSchedulerStringId.YearlyRecurrenceDayOfMonth:
                    return "Em:";
                case RadSchedulerStringId.YearlyRecurrenceDecember:
                    return "Dezembro";
                case RadSchedulerStringId.YearlyRecurrenceFebruary:
                    return "Fevereiro";
                case RadSchedulerStringId.YearlyRecurrenceJanuary:
                    return "Janeiro";
                case RadSchedulerStringId.YearlyRecurrenceJuly:
                    return "Julho";
                case RadSchedulerStringId.YearlyRecurrenceJune:
                    return "Junho";
                case RadSchedulerStringId.YearlyRecurrenceMarch:
                    return "Março";
                case RadSchedulerStringId.YearlyRecurrenceMay:
                    return "Maio";
                case RadSchedulerStringId.YearlyRecurrenceNovember:
                    return "Novembro";
                case RadSchedulerStringId.YearlyRecurrenceOctober:
                    return "Outubro";
                case RadSchedulerStringId.YearlyRecurrenceOfMonth:
                    return "em";
                case RadSchedulerStringId.YearlyRecurrenceSeptember:
                    return "Setembro";
                case RadSchedulerStringId.YearlyRecurrenceWeekOfMonth:
                    return "Cada:";
                case RadSchedulerStringId.DeleteRecurrenceDialogCancel:
                    return "Cancelar";
                case RadSchedulerStringId.DeleteRecurrenceDialogLabel:
                    return "\"{0}\" é um agendamento recorrente.\n Abrir apenas esta ocorrência ou toda a série?";
                case RadSchedulerStringId.DeleteRecurrenceDialogRadioOccurrence:
                    return "Remover esta ocorrência";
                case RadSchedulerStringId.DeleteRecurrenceDialogRadioSeries:
                    return "Remover a série";
                case RadSchedulerStringId.DeleteRecurrenceDialogTitle:
                    return "Remover agendamento recorrente";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }

    #endregion

    #region Telerik.RadReminder

    /// <summary>
    /// Classe para providenciar lozalização em Português Europeu (pt_PT) ao <see cref="RadReminder"/> TELERIK
    /// </summary>
    public class RadReminderLocalizationProviderPT_PT : RadReminderLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadReminderStringId.AlarmFormButtonDismiss:
                    return "Descartar";
                case RadReminderStringId.AlarmFormButtonDismissAll:
                    return "Descartar todos";
                case RadReminderStringId.AlarmFormButtonOpenItem:
                    return "Abrir item";
                case RadReminderStringId.AlarmFormButtonSnooze:
                    return "Snooze";
                case RadReminderStringId.AlarmFormColumnDueIn:
                    return "Prazo em";
                case RadReminderStringId.AlarmFormColumnSubject:
                    return "Assunto";
                case RadReminderStringId.AlarmFormLabelSnooze:
                    return "Clique em \"Snooze\", para voltar a ser lebrado no fim do período abaixo.";
                case RadReminderStringId.AlarmFormReminder:
                    return "Lembrete";
                case RadReminderStringId.AlarmFormReminders:
                    return "Lembretes";
                case RadReminderStringId.AlarmFormSelectMoreRemindObjects:
                    return " Lembretes selecionados.";
                case RadReminderStringId.AlarmFormSnoozeEightHours:
                    return "8 horas";
                case RadReminderStringId.AlarmFormSnoozeFifteenMinutes:
                    return "15 minutos";
                case RadReminderStringId.AlarmFormSnoozeFiveMinutes:
                    return "5 minutos";
                case RadReminderStringId.AlarmFormSnoozeFourDays:
                    return "4 dias";
                case RadReminderStringId.AlarmFormSnoozeFourHours:
                    return "4 horas";
                case RadReminderStringId.AlarmFormSnoozeHalfDay:
                    return "0,5 dia";
                case RadReminderStringId.AlarmFormSnoozeOneDay:
                    return "1 dia";
                case RadReminderStringId.AlarmFormSnoozeOneHour:
                    return "1 hora";
                case RadReminderStringId.AlarmFormSnoozeOneMinute:
                    return "1 minuto";
                case RadReminderStringId.AlarmFormSnoozeOneWeek:
                    return "1 semana";
                case RadReminderStringId.AlarmFormSnoozeTenMinutes:
                    return "10 minutos";
                case RadReminderStringId.AlarmFormSnoozeThirtyMinutes:
                    return "30 minutos";
                case RadReminderStringId.AlarmFormSnoozeThreeDays:
                    return "3 dias";
                case RadReminderStringId.AlarmFormSnoozeTwoDays:
                    return "2 dias";
                case RadReminderStringId.AlarmFormSnoozeTwoHours:
                    return "2 horas";
                case RadReminderStringId.AlarmFormSnoozeTwoWeeks:
                    return "2 semanas";
                case RadReminderStringId.DueInDay:
                    return "dia atrasado";
                case RadReminderStringId.DueInDays:
                    return "dias atrasado";
                case RadReminderStringId.DueInHour:
                    return "hora atrasado";
                case RadReminderStringId.DueInHours:
                    return "horas atrasado";
                case RadReminderStringId.DueInMinute:
                    return "minuto atrasado";
                case RadReminderStringId.DueInMinutes:
                    return "minutos atrasado";
                case RadReminderStringId.DueInOverdue:
                    return "desde {0}";
                case RadReminderStringId.DueInWeek:
                    return "Numa semana";
                case RadReminderStringId.DueInWeeks:
                    return "Em duas semanas";
                case RadReminderStringId.DueInNow:
                    return "Agora";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }

    #endregion

    #region Telerik.PrintDialogsLocalizationProvider

    class PrintDialogsLocalizationProviderPT_PT : Telerik.WinControls.UI.PrintDialogsLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case PrintDialogsStringId.PreviewDialogTitle: return "Pré-visualização";
                case PrintDialogsStringId.PreviewDialogPrint: return "Imprimir...";
                case PrintDialogsStringId.PreviewDialogPrintSettings: return "Definições de Impressão...";
                case PrintDialogsStringId.PreviewDialogWatermark: return "Marca d'água...";
                case PrintDialogsStringId.PreviewDialogPreviousPage: return "Pág. Anterior";
                case PrintDialogsStringId.PreviewDialogNextPage: return "Pág. Seguinte";
                case PrintDialogsStringId.PreviewDialogZoomIn: return "Aumentar";
                case PrintDialogsStringId.PreviewDialogZoomOut: return "Diminuir";
                case PrintDialogsStringId.PreviewDialogZoom: return "Zoom";
                case PrintDialogsStringId.PreviewDialogAuto: return "Auto";
                case PrintDialogsStringId.PreviewDialogLayout: return "Layout";
                case PrintDialogsStringId.PreviewDialogFile: return "Ficheiro";
                case PrintDialogsStringId.PreviewDialogView: return "Ver";
                case PrintDialogsStringId.PreviewDialogTools: return "Ferramentas";
                case PrintDialogsStringId.PreviewDialogExit: return "Sair";
                case PrintDialogsStringId.PreviewDialogStripTools: return "Ferramentas";
                case PrintDialogsStringId.PreviewDialogStripNavigation: return "Navegação";


                case PrintDialogsStringId.WatermarkDialogTitle: return "Definições de Marca d'água";
                case PrintDialogsStringId.WatermarkDialogButtonOK: return "OK";
                case PrintDialogsStringId.WatermarkDialogButtonCancel: return "Cancelar";
                case PrintDialogsStringId.WatermarkDialogLabelPreview: return "Pré-visualizar";
                case PrintDialogsStringId.WatermarkDialogButtonRemove: return "Remover marca d'água";
                case PrintDialogsStringId.WatermarkDialogLabelPosition: return "Posição";
                case PrintDialogsStringId.WatermarkDialogRadioInFront: return "Na frente";
                case PrintDialogsStringId.WatermarkDialogRadioBehind: return "Atrás";
                case PrintDialogsStringId.WatermarkDialogLabelPageRange: return "Intervalo de páginas";
                case PrintDialogsStringId.WatermarkDialogRadioAll: return "Todas";
                case PrintDialogsStringId.WatermarkDialogRadioPages: return "Páginas";
                case PrintDialogsStringId.WatermarkDialogLabelPagesDescription: return "(ex. 1,3,5-12)";
                case PrintDialogsStringId.WatermarkDialogTabText: return "Texto";
                case PrintDialogsStringId.WatermarkDialogTabPicture: return "Imagem";
                case PrintDialogsStringId.WatermarkDialogLabelText: return "Texto";
                case PrintDialogsStringId.WatermarkDialogWatermarkText: return "Texto da marca d'água";
                case PrintDialogsStringId.WatermarkDialogLabelHOffset: return "Offset horizontal";
                case PrintDialogsStringId.WatermarkDialogLabelVOffset: return "Offset vertical";
                case PrintDialogsStringId.WatermarkDialogLabelRotation: return "Rotação";
                case PrintDialogsStringId.WatermarkDialogLabelFont: return "Font:";
                case PrintDialogsStringId.WatermarkDialogLabelSize: return "Tamanho:";
                case PrintDialogsStringId.WatermarkDialogLabelColor: return "Cor:";
                case PrintDialogsStringId.WatermarkDialogLabelOpacity: return "Opacidade:";
                case PrintDialogsStringId.WatermarkDialogLabelLoadImage: return "Carregar imagem:";
                case PrintDialogsStringId.WatermarkDialogCheckboxTiling: return "Mosaico";


                case PrintDialogsStringId.SettingDialogTitle: return "Definições de Impressão";
                case PrintDialogsStringId.SettingDialogButtonPrint: return "Imprimir";
                case PrintDialogsStringId.SettingDialogButtonPreview: return "Pré-visualizar";
                case PrintDialogsStringId.SettingDialogButtonCancel: return "Cancelar";
                case PrintDialogsStringId.SettingDialogButtonOK: return "OK";
                case PrintDialogsStringId.SettingDialogPageFormat: return "Formato";
                case PrintDialogsStringId.SettingDialogPagePaper: return "Papel";
                case PrintDialogsStringId.SettingDialogPageHeaderFooter: return "Cabeçalho/Rodapé";
                case PrintDialogsStringId.SettingDialogButtonPageNumber: return "N.º Página";
                case PrintDialogsStringId.SettingDialogButtonTotalPages: return "Total de páginas";
                case PrintDialogsStringId.SettingDialogButtonCurrentDate: return "Data atual";
                case PrintDialogsStringId.SettingDialogButtonCurrentTime: return "Hora atual";
                case PrintDialogsStringId.SettingDialogButtonUserName: return "Nome utilizador";
                case PrintDialogsStringId.SettingDialogButtonFont: return "Font...";
                case PrintDialogsStringId.SettingDialogLabelHeader: return "Cabeçalho";
                case PrintDialogsStringId.SettingDialogLabelFooter: return "Rodapé";
                case PrintDialogsStringId.SettingDialogCheckboxReverse: return "Inverte nas páginas pares";
                case PrintDialogsStringId.SettingDialogLabelPage: return "Página";
                case PrintDialogsStringId.SettingDialogLabelType: return "Tipo";
                case PrintDialogsStringId.SettingDialogLabelPageSource: return "Origem da página";
                case PrintDialogsStringId.SettingDialogLabelMargins: return "Margens (polegadas)";
                case PrintDialogsStringId.SettingDialogLabelOrientation: return "Orientação";
                case PrintDialogsStringId.SettingDialogLabelTop: return "Topo:";
                case PrintDialogsStringId.SettingDialogLabelBottom: return "Fundo:";
                case PrintDialogsStringId.SettingDialogLabelLeft: return "Esquerda:";
                case PrintDialogsStringId.SettingDialogLabelRight: return "Direita:";
                case PrintDialogsStringId.SettingDialogRadioPortrait: return "Retrato";
                case PrintDialogsStringId.SettingDialogRadioLandscape: return "Paisagem";


                case PrintDialogsStringId.SchedulerSettingsLabelPrintStyle: return "Estilo de impressão";
                case PrintDialogsStringId.SchedulerSettingsDailyStyle: return "Estilo diário";
                case PrintDialogsStringId.SchedulerSettingsWeeklyStyle: return "Estilo semanal";
                case PrintDialogsStringId.SchedulerSettingsMonthlyStyle: return "Estilo mensal";
                case PrintDialogsStringId.SchedulerSettingsDetailStyle: return "Estilo detalhe";
                case PrintDialogsStringId.SchedulerSettingsButtonWatermark: return "Marca d'água...";
                case PrintDialogsStringId.SchedulerSettingsButtonFont: return "Font...";
                case PrintDialogsStringId.SchedulerSettingsLabelPrintRange: return "Imprimir intervalo";
                case PrintDialogsStringId.SchedulerSettingsLabelStyleSettings: return "Definições de estilo";
                case PrintDialogsStringId.SchedulerSettingsLabelPrintSettings: return "Definições de impressão";
                case PrintDialogsStringId.SchedulerSettingsLabelStartDate: return "Data inicial";
                case PrintDialogsStringId.SchedulerSettingsLabelEndDate: return "Data final";
                case PrintDialogsStringId.SchedulerSettingsLabelStartTime: return "Hora inicial";
                case PrintDialogsStringId.SchedulerSettingsLabelEndTime: return "Hora final";
                case PrintDialogsStringId.SchedulerSettingsLabelDateFont: return "Font da data";
                case PrintDialogsStringId.SchedulerSettingsLabelAppointmentFont: return "Fonte do agendamento";
                case PrintDialogsStringId.SchedulerSettingsLabelLayout: return "Layout";
                case PrintDialogsStringId.SchedulerSettingsPrintPageTitle: return "Imprimir título página";
                case PrintDialogsStringId.SchedulerSettingsPrintCalendar: return "Incluir calendário no título";
                case PrintDialogsStringId.SchedulerSettingsPrintTimezone: return "Imprimir o fuso horário selecionado";
                case PrintDialogsStringId.SchedulerSettingsPrintNotesBlank: return "Area de notas (vazia)";
                case PrintDialogsStringId.SchedulerSettingsPrintNotesLined: return "Area de notas (c/ linhas)";
                case PrintDialogsStringId.SchedulerSettingsNonworkingDays: return "Excluir dias não laborais";
                case PrintDialogsStringId.SchedulerSettingsExactlyOneMonth: return "Imprimir exatamente um mês";
                case PrintDialogsStringId.SchedulerSettingsLabelWeeksPerPage: return "Semanas por página";
                case PrintDialogsStringId.SchedulerSettingsNewPageEach: return "Iniciar nova página a cada";
                case PrintDialogsStringId.SchedulerSettingsStringDay: return "Dia";
                case PrintDialogsStringId.SchedulerSettingsStringMonth: return "Mês";
                case PrintDialogsStringId.SchedulerSettingsStringWeek: return "Semana";
                case PrintDialogsStringId.SchedulerSettingsStringPage: return "Página";
                case PrintDialogsStringId.SchedulerSettingsStringPages: return "Páginas";
                case PrintDialogsStringId.SchedulerSettingsLabelGroupBy: return "Agrupar por:";
                case PrintDialogsStringId.SchedulerSettingsGroupByNone: return "Nenhum";
                case PrintDialogsStringId.SchedulerSettingsGroupByResource: return "Recurso";
                case PrintDialogsStringId.SchedulerSettingsGroupByDate: return "Data";


                case PrintDialogsStringId.GridSettingsLabelPreview: return "Pré-visualizar";
                case PrintDialogsStringId.GridSettingsLabelStyleSettings: return "Definições de estilo";
                case PrintDialogsStringId.GridSettingsLabelFitMode: return "Modo de arranjo de página:";
                case PrintDialogsStringId.GridSettingsLabelHeaderCells: return "Células do cabeçalho";
                case PrintDialogsStringId.GridSettingsLabelGroupCells: return "Células de grupo";
                case PrintDialogsStringId.GridSettingsLabelDataCells: return "Células da data";
                case PrintDialogsStringId.GridSettingsLabelSummaryCells: return "Células de resumo";
                case PrintDialogsStringId.GridSettingsLabelBackground: return "Background";
                case PrintDialogsStringId.GridSettingsLabelBorderColor: return "Cor da borda";
                case PrintDialogsStringId.GridSettingsLabelAlternatingRowColor: return "Cor da linha alternada";
                case PrintDialogsStringId.GridSettingsLabelPadding: return "Margem";
                case PrintDialogsStringId.GridSettingsPrintGrouping: return "Imprimir agrupamento";
                case PrintDialogsStringId.GridSettingsPrintSummaries: return "Imprimir resumos";
                case PrintDialogsStringId.GridSettingsPrintHiddenRows: return "Imprimir linhas escondidas";
                case PrintDialogsStringId.GridSettingsPrintHiddenColumns: return "Imprimir colunas escondidas";
                case PrintDialogsStringId.GridSettingsPrintHeader: return "Imprimir cabeçalho em cada página";
                case PrintDialogsStringId.GridSettingsButtonWatermark: return "Marca d'água...";
                case PrintDialogsStringId.GridSettingsButtonFont: return "Font...";
                case PrintDialogsStringId.GridSettingsFitPageWidth: return "Ajustar à largura";
                case PrintDialogsStringId.GridSettingsNoFit: return "Sem ajuste";
                case PrintDialogsStringId.GridSettingsNoFitCentered: return "Centrar";
                case PrintDialogsStringId.GridSettingsLabelPrint: return "Imprimir";
            }

            return String.Empty;
        }
    }

    #endregion
}