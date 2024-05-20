Imports Telerik.WinControls.UI.Localization
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

'lokalizacija za RadGrid
Public Class MyEnglishRadGridLocalizationProvider
    Inherits RadGridLocalizationProvider
    Public Overrides Function GetLocalizedString(ByVal id As String) As String
        Select Case id
            Case RadGridStringId.FilterFunctionBetween
                Return "Između"
            Case RadGridStringId.FilterFunctionContains
                Return "Sadrži"
            Case RadGridStringId.FilterFunctionDoesNotContain
                Return "Ne sadrži"
            Case RadGridStringId.FilterFunctionEndsWith
                Return "Završava se sa"
            Case RadGridStringId.FilterFunctionEqualTo
                Return "Jednako"
            Case RadGridStringId.FilterFunctionGreaterThan
                Return "Veće od"
            Case RadGridStringId.FilterFunctionGreaterThanOrEqualTo
                Return "Veće ili jednako od"
            Case RadGridStringId.FilterFunctionIsEmpty
                Return "Prazno je"
            Case RadGridStringId.FilterFunctionIsNull
                Return "Nema vrednost"
            Case RadGridStringId.FilterFunctionLessThan
                Return "Manje od"
            Case RadGridStringId.FilterFunctionLessThanOrEqualTo
                Return "Manje ili jednako od "
            Case RadGridStringId.FilterFunctionNoFilter
                Return "Bez filtera"
            Case RadGridStringId.FilterFunctionNotBetween
                Return "Nije između"
            Case RadGridStringId.FilterFunctionNotEqualTo
                Return "Nije jednako"
            Case RadGridStringId.FilterFunctionNotIsEmpty
                Return "Nije prazno"
            Case RadGridStringId.FilterFunctionNotIsNull
                Return "Ima vrednost"
            Case RadGridStringId.FilterFunctionStartsWith
                Return "Počinje sa"
            Case RadGridStringId.FilterFunctionCustom
                Return "Prilagođen"
            Case RadGridStringId.FilterOperatorBetween
                Return "Između"
            Case RadGridStringId.FilterOperatorContains
                Return "Sadrži"
            Case RadGridStringId.FilterOperatorDoesNotContain
                Return "Ne sadrži"
            Case RadGridStringId.FilterOperatorEndsWith
                Return "Završava se sa"
            Case RadGridStringId.FilterOperatorEqualTo
                Return "Jednako"
            Case RadGridStringId.FilterOperatorGreaterThan
                Return "Veće od"
            Case RadGridStringId.FilterOperatorGreaterThanOrEqualTo
                Return "Veće ili jednako od"
            Case RadGridStringId.FilterOperatorIsEmpty
                Return "Prazno"
            Case RadGridStringId.FilterOperatorIsNull
                Return "nema vrednost"
            Case RadGridStringId.FilterOperatorLessThan
                Return "Manje od"
            Case RadGridStringId.FilterOperatorLessThanOrEqualTo
                Return "Manje ili jednako od"
            Case RadGridStringId.FilterOperatorNoFilter
                Return "Bez filtera"
            Case RadGridStringId.FilterOperatorNotBetween
                Return "Nije između"
            Case RadGridStringId.FilterOperatorNotEqualTo
                Return "Nije jednak"
            Case RadGridStringId.FilterOperatorNotIsEmpty
                Return "Nije prazan"
            Case RadGridStringId.FilterOperatorNotIsNull
                Return "Nije Null"
            Case RadGridStringId.FilterOperatorStartsWith
                Return "Počinje sa"
            Case RadGridStringId.FilterOperatorIsLike
                Return "Nalik"
            Case RadGridStringId.FilterOperatorNotIsLike
                Return "Nije nalik"
            Case RadGridStringId.FilterOperatorIsContainedIn
                Return "Sadržano"
            Case RadGridStringId.FilterOperatorNotIsContainedIn
                Return "Nije sadržano"
            Case RadGridStringId.FilterOperatorCustom
                Return "Prilagođen"
            Case RadGridStringId.CustomFilterMenuItem
                Return "Prilagođen"
            Case RadGridStringId.CustomFilterDialogCaption
                Return "RadGridView filter dijalog"
            Case RadGridStringId.CustomFilterDialogLabel
                Return "Prikaži redove gde je:"
            Case RadGridStringId.CustomFilterDialogRbAnd
                Return "i"
            Case RadGridStringId.CustomFilterDialogRbOr
                Return "ili"
            Case RadGridStringId.CustomFilterDialogBtnOk
                Return "U redu"
            Case RadGridStringId.CustomFilterDialogBtnCancel
                Return "Otkaži"
            Case RadGridStringId.CustomFilterDialogCheckBoxNot
                Return "Nije"
            Case RadGridStringId.CustomFilterDialogTrue
                Return "Ispravno"
            Case RadGridStringId.CustomFilterDialogFalse
                Return "Pogrešno"
            Case RadGridStringId.FilterMenuAvailableFilters
                Return "Dostupni filteri"
            Case RadGridStringId.FilterMenuSearchBoxText
                Return "Pretraži..."
            Case RadGridStringId.FilterMenuClearFilters
                Return "Obriši filter"
            Case RadGridStringId.FilterMenuButtonOK
                Return "U redu"
            Case RadGridStringId.FilterMenuButtonCancel
                Return "Otkaži"
            Case RadGridStringId.FilterMenuSelectionAll
                Return "Sve"
            Case RadGridStringId.FilterMenuSelectionAllSearched
                Return "Rezultat pretrage"
            Case RadGridStringId.FilterMenuSelectionNull
                Return "Null"
            Case RadGridStringId.FilterMenuSelectionNotNull
                Return "Nije Null"
            Case RadGridStringId.FilterLogicalOperatorAnd
                Return "i"
            Case RadGridStringId.FilterLogicalOperatorOr
                Return "ili"
            Case RadGridStringId.FilterCompositeNotOperator
                Return "ne"
            Case RadGridStringId.DeleteRowMenuItem
                Return "Izbriši red"
            Case RadGridStringId.SortAscendingMenuItem
                Return "Sortiraj po rastućem redu"
            Case RadGridStringId.SortDescendingMenuItem
                Return "Sortiraj po opadajućem redu"
            Case RadGridStringId.ClearSortingMenuItem
                Return "Obriši sortiranje"
            Case RadGridStringId.ConditionalFormattingMenuItem
                Return "Uslovno formatiranje"
            Case RadGridStringId.GroupByThisColumnMenuItem
                Return "Grupiši ovu kolonu"
            Case RadGridStringId.UngroupThisColumn
                Return "Razgrupiši ovu kolonu"
            Case RadGridStringId.ColumnChooserMenuItem
                Return "Izbor kolone"
            Case RadGridStringId.HideMenuItem
                Return "Sakrij kolonu"
            Case RadGridStringId.UnpinMenuItem
                Return "Otkači kolonu"
            Case RadGridStringId.UnpinRowMenuItem
                Return "Otkači red"
            Case RadGridStringId.PinMenuItem
                Return "Zakačeno stanje"
            Case RadGridStringId.PinAtLeftMenuItem
                Return "Zakači levo"
            Case RadGridStringId.PinAtRightMenuItem
                Return "Zakači desno"
            Case RadGridStringId.PinAtBottomMenuItem
                Return "Zakači na dno"
            Case RadGridStringId.PinAtTopMenuItem
                Return "Zakači na vrh"
            Case RadGridStringId.BestFitMenuItem
                Return "Najbolje uklopljeno"
            Case RadGridStringId.PasteMenuItem
                Return "Nalepi"
            Case RadGridStringId.EditMenuItem
                Return "Uredi"
            Case RadGridStringId.ClearValueMenuItem
                Return "Obriši vrednost"
            Case RadGridStringId.CopyMenuItem
                Return "Kopiraj"
            Case RadGridStringId.AddNewRowString
                Return "Kliknite ovde za dodavanje novog reda"
            Case RadGridStringId.ConditionalFormattingCaption
                Return "Conditional Formatting Rules Manager"
            Case RadGridStringId.ConditionalFormattingLblColumn
                Return "Formatiraj samo ćelije sa"
            Case RadGridStringId.ConditionalFormattingLblName
                Return "Naziv pravila:"
            Case RadGridStringId.ConditionalFormattingLblType
                Return "Vrednost ćelije:"
            Case RadGridStringId.ConditionalFormattingLblValue1
                Return "Vrednost 1:"
            Case RadGridStringId.ConditionalFormattingLblValue2
                Return "Vrednost 2:"
            Case RadGridStringId.ConditionalFormattingGrpConditions
                Return "Pravila"
            Case RadGridStringId.ConditionalFormattingGrpProperties
                Return "Svojstva pravila"
            Case RadGridStringId.ConditionalFormattingChkApplyToRow
                Return "Promeni ovo pravilo na ceo red"
            Case RadGridStringId.ConditionalFormattingBtnAdd
                Return "Dodaj novo pravilo"
            Case RadGridStringId.ConditionalFormattingBtnRemove
                Return "Ukloni izabrano pravilo"
            Case RadGridStringId.ConditionalFormattingBtnOK
                Return "U redu"
            Case RadGridStringId.ConditionalFormattingBtnCancel
                Return "Otkaži"
            Case RadGridStringId.ConditionalFormattingBtnApply
                Return "Primeni"
            Case RadGridStringId.ConditionalFormattingRuleAppliesOn
                Return "Pravilo se primenjuje na:"
            Case RadGridStringId.ConditionalFormattingChooseOne
                Return "[Izaberi jedan]"
            Case RadGridStringId.ConditionalFormattingEqualsTo
                Return "jednako [Value1]"
            Case RadGridStringId.ConditionalFormattingIsNotEqualTo
                Return "nije jednako [Value1]"
            Case RadGridStringId.ConditionalFormattingStartsWith
                Return "pošinje sa [Value1]"
            Case RadGridStringId.ConditionalFormattingEndsWith
                Return "završava sa [Value1]"
            Case RadGridStringId.ConditionalFormattingContains
                Return "sadrži [Value1]"
            Case RadGridStringId.ConditionalFormattingDoesNotContain
                Return "ne sadrži [Value1]"
            Case RadGridStringId.ConditionalFormattingIsGreaterThan
                Return "is greater than [Value1]"
            Case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual
                Return "veće ili jednako [Value1]"
            Case RadGridStringId.ConditionalFormattingIsLessThan
                Return "manje od [Value1]"
            Case RadGridStringId.ConditionalFormattingIsLessThanOrEqual
                Return "manje ili jednako [Value1]"
            Case RadGridStringId.ConditionalFormattingIsBetween
                Return "između [Value1] and [Value2]"
            Case RadGridStringId.ConditionalFormattingIsNotBetween
                Return "nije između [Value1] and [Value1]"
            Case RadGridStringId.ColumnChooserFormCaption
                Return "Biranje kolone"
            Case RadGridStringId.ColumnChooserFormMessage
                Return "Prevuci zaglavlje kolone sa " & vbLf & "polja da se skine " & vbLf & "sa pregleda."
            Case RadGridStringId.GroupingPanelDefaultMessage
                Return "Prevuci ovde kolonu za sortiranje."
            Case RadGridStringId.GroupingPanelHeader
                Return "Grupiši po:"
            Case RadGridStringId.NoDataText
                Return "Nema podataka"
            Case RadGridStringId.CompositeFilterFormErrorCaption
                Return "Filter greška"
        End Select
        Return String.Empty
    End Function
End Class

Public Class CustomLocalizationProvider
    Inherits RadSchedulerLocalizationProvider
    Public Overrides Function GetLocalizedString(ByVal id As String) As String
        Select Case id
            Case RadSchedulerStringId.NextAppointment
                Return "Naredna obaveza"
            Case RadSchedulerStringId.PreviousAppointment
                Return "Prethodna obaveza"
            Case RadSchedulerStringId.AppointmentDialogTitle
                Return "Izmeni obavezu"
            Case RadSchedulerStringId.AppointmentDialogSubject
                Return "Opis:"
            Case RadSchedulerStringId.AppointmentDialogLocation
                Return "Lokacija:"
            Case RadSchedulerStringId.AppointmentDialogBackground
                Return "Pozadina:"
            Case RadSchedulerStringId.AppointmentDialogDescription
                Return "Opis:"
                'Case RadSchedulerStringId.AppointmentDialogDescription
                '    Return "Opis:"
            Case RadSchedulerStringId.AppointmentDialogStartTime
                Return "Početak:"
            Case RadSchedulerStringId.AppointmentDialogEndTime
                Return "Kraj:"
            Case RadSchedulerStringId.AppointmentDialogAllDay
                Return "Celodnevno"
            Case RadSchedulerStringId.AppointmentDialogResource
                Return "Izvor:"
            Case RadSchedulerStringId.AppointmentDialogStatus
                Return "Prikaži vreme:"
            Case RadSchedulerStringId.AppointmentDialogOK
                Return "U redu"
            Case RadSchedulerStringId.AppointmentDialogCancel
                Return "Otkaži"
            Case RadSchedulerStringId.AppointmentDialogDelete
                Return "Izbriši"
            Case RadSchedulerStringId.AppointmentDialogRecurrence
                Return "Ponavljanje"
            Case RadSchedulerStringId.OpenRecurringDialogTitle
                Return "Otvori ponavljanje"
            Case RadSchedulerStringId.OpenRecurringDialogOK
                Return "U redu"
            Case RadSchedulerStringId.OpenRecurringDialogCancel
                Return "Otkaži"
            Case RadSchedulerStringId.OpenRecurringDialogLabel
                Return """{0}"" je ponavljanje" & vbLf & ". Da li da otvorim" & vbLf & "samo ovaj element ili celu seriju?"
            Case RadSchedulerStringId.OpenRecurringDialogRadioOccurrence
                Return "Otvori ovaj element."
            Case RadSchedulerStringId.OpenRecurringDialogRadioSeries
                Return "Otvori celu seriju."
            Case RadSchedulerStringId.RecurrenceDialogTitle
                Return "Izmeni ponavljanje"
            Case RadSchedulerStringId.RecurrenceDialogAppointmentTimeGroup
                Return "Vreme obaveze"
            Case RadSchedulerStringId.RecurrenceDialogDuration
                Return "Trajanje:"
            Case RadSchedulerStringId.RecurrenceDialogAppointmentEnd
                Return "Kraj:"
            Case RadSchedulerStringId.RecurrenceDialogAppointmentStart
                Return "Početak:"
            Case RadSchedulerStringId.RecurrenceDialogRecurrenceGroup
                Return "Obrazac ponavljanja"
            Case RadSchedulerStringId.RecurrenceDialogRangeGroup
                Return "Domet ponavljanja"
            Case RadSchedulerStringId.RecurrenceDialogOccurrences
                Return "elementi"
            Case RadSchedulerStringId.RecurrenceDialogRecurrenceStart
                Return "Početak:"
            Case RadSchedulerStringId.RecurrenceDialogYearly
                Return "Godišnje"
            Case RadSchedulerStringId.RecurrenceDialogMonthly
                Return "Mesečno"
            Case RadSchedulerStringId.RecurrenceDialogWeekly
                Return "Nedeljno"
            Case RadSchedulerStringId.RecurrenceDialogDaily
                Return "Dnevno"
            Case RadSchedulerStringId.RecurrenceDialogEndBy
                Return "Kraj do:"
            Case RadSchedulerStringId.RecurrenceDialogEndAfter
                Return "Kraj posle:"
            Case RadSchedulerStringId.RecurrenceDialogNoEndDate
                Return "Nema kraja"
            Case RadSchedulerStringId.RecurrenceDialogOK
                Return "U redu"
            Case RadSchedulerStringId.RecurrenceDialogCancel
                Return "Otkaži"
            Case RadSchedulerStringId.RecurrenceDialogRemoveRecurrence
                Return "Izbriši ponavljanje"
            Case RadSchedulerStringId.DailyRecurrenceEveryDay
                Return "Svaki"
            Case RadSchedulerStringId.DailyRecurrenceEveryWeekday
                Return "Svake nedelje"
            Case RadSchedulerStringId.DailyRecurrenceDays
                Return "dan/dana"
            Case RadSchedulerStringId.WeeklyRecurrenceRecurEvery
                Return "Ponovi svaki"
            Case RadSchedulerStringId.WeeklyRecurrenceWeeksOn
                Return "nedelje :"
            Case RadSchedulerStringId.WeeklyRecurrenceSunday
                Return "nedelja"
            Case RadSchedulerStringId.WeeklyRecurrenceMonday
                Return "ponedeljak"
            Case RadSchedulerStringId.WeeklyRecurrenceTuesday
                Return "utorak"
            Case RadSchedulerStringId.WeeklyRecurrenceWednesday
                Return "sreda"
            Case RadSchedulerStringId.WeeklyRecurrenceThursday
                Return "četvrtak"
            Case RadSchedulerStringId.WeeklyRecurrenceFriday
                Return "petak"
            Case RadSchedulerStringId.WeeklyRecurrenceSaturday
                Return "subota"
            Case RadSchedulerStringId.WeeklyRecurrenceDay
                Return "Dan"
            Case RadSchedulerStringId.WeeklyRecurrenceWeekday
                Return "Nedelja"
            Case RadSchedulerStringId.WeeklyRecurrenceWeekendDay
                Return "Vikend"
            Case RadSchedulerStringId.MonthlyRecurrenceDay
                Return "Dan"
            Case RadSchedulerStringId.MonthlyRecurrenceWeek
                Return " "
            Case RadSchedulerStringId.MonthlyRecurrenceDayOfMonth
                Return "svaki"
            Case RadSchedulerStringId.MonthlyRecurrenceMonths
                Return "mesec"
            Case RadSchedulerStringId.MonthlyRecurrenceWeekOfMonth
                Return "svakog"
            Case RadSchedulerStringId.MonthlyRecurrenceFirst
                Return "prvi"
            Case RadSchedulerStringId.MonthlyRecurrenceSecond
                Return "drugi"
            Case RadSchedulerStringId.MonthlyRecurrenceThird
                Return "treći"
            Case RadSchedulerStringId.MonthlyRecurrenceFourth
                Return "četvrti"
            Case RadSchedulerStringId.MonthlyRecurrenceLast
                Return "Poslednji"
            Case RadSchedulerStringId.YearlyRecurrenceDayOfMonth
                Return "Svaki"
            Case RadSchedulerStringId.YearlyRecurrenceWeekOfMonth
                Return " "
            Case RadSchedulerStringId.YearlyRecurrenceOfMonth
                Return "od"
            Case RadSchedulerStringId.YearlyRecurrenceJanuary
                Return "Januar"
            Case RadSchedulerStringId.YearlyRecurrenceFebruary
                Return "Fabruar"
            Case RadSchedulerStringId.YearlyRecurrenceMarch
                Return "Mart"
            Case RadSchedulerStringId.YearlyRecurrenceApril
                Return "April"
            Case RadSchedulerStringId.YearlyRecurrenceMay
                Return "Maj"
            Case RadSchedulerStringId.YearlyRecurrenceJune
                Return "Jun"
            Case RadSchedulerStringId.YearlyRecurrenceJuly
                Return "Jul"
            Case RadSchedulerStringId.YearlyRecurrenceAugust
                Return "Avgust"
            Case RadSchedulerStringId.YearlyRecurrenceSeptember
                Return "Septembar"
            Case RadSchedulerStringId.YearlyRecurrenceOctober
                Return "Oktobar"
            Case RadSchedulerStringId.YearlyRecurrenceNovember
                Return "Novembar"
            Case RadSchedulerStringId.YearlyRecurrenceDecember
                Return "Decembar"
            Case RadSchedulerStringId.BackgroundNone
                Return "Nema" 'svetlo plavo
            Case RadSchedulerStringId.BackgroundImportant
                Return "Važno" 'zeleno
            Case RadSchedulerStringId.BackgroundBusiness
                Return "Poslovno" 'sivo
            Case RadSchedulerStringId.BackgroundPersonal
                Return "Lično" 'narandzasto
            Case RadSchedulerStringId.BackgroundVacation
                Return "Odmor" 'zuto
            Case RadSchedulerStringId.BackgroundMustAttend
                Return "Obavezno prisustvo" 'tamno plavo
            Case RadSchedulerStringId.BackgroundTravelRequired
                Return "Putovanje" 'svetlo zeleno 
            Case RadSchedulerStringId.BackgroundNeedsPreparation
                Return "Prethodno se pripremiti" 'tamno narandzasto
            Case RadSchedulerStringId.BackgroundBirthday
                Return "Rođendan" 'crveno
            Case RadSchedulerStringId.BackgroundAnniversary
                Return "Godišnjica" 'tamno crveno
            Case RadSchedulerStringId.BackgroundPhoneCall
                Return "Telefonski poziv" 'ljubicasto
            Case RadSchedulerStringId.StatusBusy
                Return "Zauzet" 'tamno plavo
            Case RadSchedulerStringId.StatusFree
                Return "Slobodan" 'belo
            Case RadSchedulerStringId.StatusTentative
                Return "Privremeni" 'srafiran
            Case RadSchedulerStringId.StatusUnavailable
                Return "Nedostupan" 'tamno crevno
            Case RadSchedulerStringId.ContextMenuNewAppointment
                Return "Nova obaveza"
            Case RadSchedulerStringId.ContextMenuEditAppointment
                Return "Izmeni obavezu"
                'Case RadSchedulerStringId.ContextMenuEditAppointment
                '    Return "Izmeni obavezu"
            Case RadSchedulerStringId.ContextMenuNewRecurringAppointment
                Return "Nova obaveza - ponavljanje"
            Case RadSchedulerStringId.ContextMenu60Minutes
                Return "60 minuta"
            Case RadSchedulerStringId.ContextMenu30Minutes
                Return "30 minuta"
            Case RadSchedulerStringId.ContextMenu15Minutes
                Return "15 minuta"
            Case RadSchedulerStringId.ContextMenu10Minutes
                Return "10 minuta"
            Case RadSchedulerStringId.ContextMenu6Minutes
                Return "6 minuta"
            Case RadSchedulerStringId.ContextMenu5Minutes
                Return "5 minuta"
            Case RadSchedulerStringId.ContextMenuNavigateToNextView
                Return "Naredni pogled"
            Case RadSchedulerStringId.ContextMenuNavigateToPreviousView
                Return "Prethodni pogled"
            Case RadSchedulerStringId.ContextMenuTimescales
                Return "Vremenska skala"
            Case RadSchedulerStringId.ContextMenuTimescalesYear
                Return "Godina"
            Case RadSchedulerStringId.ContextMenuTimescalesMonth
                Return "Mesec"
            Case RadSchedulerStringId.ContextMenuTimescalesWeek
                Return "Nedelja"
            Case RadSchedulerStringId.ContextMenuTimescalesDay
                Return "Dan"
            Case RadSchedulerStringId.ContextMenuTimescalesHour
                Return "Sat"
            Case RadSchedulerStringId.ContextMenuTimescalesFifteenMinutes
                Return "15 minuta"
            Case RadSchedulerStringId.ErrorProviderWrongAppointmentDates
                Return "Kraj obaveze je u isto vreme ili je pre početka obaveze!"
            Case RadSchedulerStringId.ErrorProviderWrongExceptionDuration
                Return "Interval ponavljanja mora biti veći ili isti od trajanja obeveze!"
            Case RadSchedulerStringId.TimeZoneLocal
                Return "Lokalna"
                'Case RadSchedulerStringId.TimeZoneLocal
                '    Return "Local"
            Case Else
                '                'more translated strings
                Return MyBase.GetLocalizedString(id)
        End Select
        'Return String.Empty
    End Function
End Class
'novi status sada ima id=1-4
'Me.RadScheduler1.Statuses.Add(New AppointmentStatusInfo(5, "test", Color.Purple, Color.Purple, AppointmentStatusFillType.Solid))
'novi background  sada ima id=1-11
'Me.RadScheduler1.Backgrounds.Add(New AppointmentBackgroundInfo(12, "test", Color.Purple))


Public Class MySchedulerNavigatorLocalizationProvider
    Inherits SchedulerNavigatorLocalizationProvider
    Public Overloads Overrides Function GetLocalizedString(ByVal id As String) As String
        Select Case id
            Case SchedulerNavigatorStringId.DayViewButtonCaption
                If True Then
                    Return "  Dan  "
                End If
            Case SchedulerNavigatorStringId.WeekViewButtonCaption
                If True Then
                    Return "Nedelja"
                End If
            Case SchedulerNavigatorStringId.MonthViewButtonCaption
                If True Then
                    Return "Mesec"
                End If
            Case SchedulerNavigatorStringId.ShowWeekendCheckboxCaption
                If True Then
                    Return "Vikend"
                End If
            Case SchedulerNavigatorStringId.TimelineViewButtonCaption
                If True Then
                    Return "Zbirno"
                End If
        End Select
        Return [String].Empty
    End Function
End Class

'lokalizacija za Ekran za poruke Message
Public Class MyRadMessageLocalizationProvider
    Inherits RadMessageLocalizationProvider

    Public Overloads Overrides Function GetLocalizedString(ByVal id As String) As String
        Select Case id
            Case RadMessageStringID.AbortButton
                Return "Odustani"
            Case RadMessageStringID.CancelButton
                Return "Otkaži"
            Case RadMessageStringID.IgnoreButton
                Return "Zanemari"
            Case RadMessageStringID.NoButton
                Return "Ne"
            Case RadMessageStringID.OKButton
                Return "U redu"
            Case RadMessageStringID.RetryButton
                Return "Pokušaj opet"
            Case RadMessageStringID.YesButton
                Return "Da"
            Case Else
                Return MyBase.GetLocalizedString(id)
        End Select
    End Function
End Class
'lokalizacija za CommandBar
Public Class MyEnglishCommandBarLocalizationProvider
    Inherits CommandBarLocalizationProvider
    Public Overrides Function GetLocalizedString(ByVal id As String) As String
        Select Case id
            Case CommandBarStringId.CustomizeDialogChooseToolstripLabelText : Return "Izaberi traku sa alatima za preuređivanje:"
            Case CommandBarStringId.CustomizeDialogCloseButtonText : Return "Zatvori"
            Case CommandBarStringId.CustomizeDialogItemsPageTitle : Return "Stavke"
            Case CommandBarStringId.CustomizeDialogMoveDownButtonText : Return "Pomeri dole"
            Case CommandBarStringId.CustomizeDialogMoveUpButtonText : Return "Pomeri gore"
            Case CommandBarStringId.CustomizeDialogResetButtonText : Return "Poništi"
            Case CommandBarStringId.CustomizeDialogTitle : Return "Prilagodi1"
            Case CommandBarStringId.CustomizeDialogToolstripsPageTitle : Return "Trake sa alatima"
            Case CommandBarStringId.OverflowMenuAddOrRemoveButtonsText : Return "Dodaj ili sklopni tastere"
            Case CommandBarStringId.OverflowMenuCustomizeText : Return "Prilagodi..."
            Case CommandBarStringId.ContextMenuCustomizeText : Return "Prilagodi..."
            Case Else : Return MyBase.GetLocalizedString(id)
        End Select
        Return String.Empty
    End Function
End Class
'RadReminder
'RadReminderLocalizationProvider.CurrentProvider = New EnglishReminderLocalizationProvider()
Public Class EnglishReminderLocalizationProvider
    Inherits RadReminderLocalizationProvider

    Public Overrides Function GetLocalizedString(ByVal id As String) As String
        Select Case id
            Case RadReminderStringId.AlarmFormButtonDismiss
                Return "Odbaci"
            Case RadReminderStringId.AlarmFormButtonDismissAll
                Return "Odbaci sve"
            Case RadReminderStringId.AlarmFormButtonOpenItem
                Return "Otvori stavku"
            Case RadReminderStringId.AlarmFormButtonSnooze
                Return "Odloži"
            Case RadReminderStringId.AlarmFormColumnDueIn
                Return "Krajnji rok"
            Case RadReminderStringId.AlarmFormColumnSubject
                Return "Tema"
            Case RadReminderStringId.AlarmFormLabelSnooze
                Return "Klikni Odloži za ponovno podsećanje u:"
            Case RadReminderStringId.AlarmFormReminder
                Return "Podsetnik"
            Case RadReminderStringId.AlarmFormReminders
                Return "Podsetnici"
            Case RadReminderStringId.AlarmFormSnoozeEightHours
                Return "8 sati"
            Case RadReminderStringId.AlarmFormSnoozeFifteenMinutes
                Return "15 minuta"
            Case RadReminderStringId.AlarmFormSnoozeFiveMinutes
                Return "5 minuta"
            Case RadReminderStringId.AlarmFormSnoozeFourDays
                Return "4 dana"
            Case RadReminderStringId.AlarmFormSnoozeFourHours
                Return "4 sata"
            Case RadReminderStringId.AlarmFormSnoozeHalfDay
                Return "0.5 dana"
            Case RadReminderStringId.AlarmFormSnoozeOneDay
                Return "1 dan"
            Case RadReminderStringId.AlarmFormSnoozeOneHour
                Return "1 sat"
            Case RadReminderStringId.AlarmFormSnoozeOneMinute
                Return "1 minut"
            Case RadReminderStringId.AlarmFormSnoozeOneWeek
                Return "1 nedelja"
            Case RadReminderStringId.AlarmFormSnoozeTenMinutes
                Return "10 minuta"
            Case RadReminderStringId.AlarmFormSnoozeThirtyMinutes
                Return "30 minuta"
            Case RadReminderStringId.AlarmFormSnoozeThreeDays
                Return "3 dana"
            Case RadReminderStringId.AlarmFormSnoozeTwoDays
                Return "2 dana"
            Case RadReminderStringId.AlarmFormSnoozeTwoHours
                Return "2 sata"
            Case RadReminderStringId.AlarmFormSnoozeTwoWeeks
                Return "2 nedelje"
            Case RadReminderStringId.DueInDay
                Return "dan"
            Case RadReminderStringId.DueInDays
                Return "dana"
            Case RadReminderStringId.DueInHour
                Return "sat"
            Case RadReminderStringId.DueInHours
                Return "sati"
            Case RadReminderStringId.DueInMinute
                Return "minut"
            Case RadReminderStringId.DueInWeek
                Return "nedelja"
            Case RadReminderStringId.DueInWeeks
                Return "nedelje"
            Case RadReminderStringId.DueInNow
                Return "sad"
            Case RadReminderStringId.DueInOverdue
                Return "{0} prekoračen rok"
            Case RadReminderStringId.AlarmFormSelectMoreRemindObjects
                Return " podsetnici su selektovani."
        End Select
        Return MyBase.GetLocalizedString(id)
    End Function
End Class
'RadTimePicker
'RadTimePickerLocalizationProvider.CurrentProvider = New MyTimePickerLocalizationProvider()
Class MyTimePickerLocalizationProvider
    Inherits RadTimePickerLocalizationProvider

    Public Overrides Function GetLocalizedString(id As String) As String
        Select Case id
            Case RadTimePickerStringId.HourHeaderText
                Return "Sati"
            Case RadTimePickerStringId.MinutesHeaderText
                Return "Minuti"
            Case RadTimePickerStringId.CloseButtonText
                Return "U redu"
            Case Else
                Return String.Empty
        End Select
    End Function

End Class