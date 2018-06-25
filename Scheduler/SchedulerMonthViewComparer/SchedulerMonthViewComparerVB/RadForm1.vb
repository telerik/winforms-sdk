Imports Telerik.WinControls.UI

Public Class RadForm1
    Sub New()

        InitializeComponent()

        Me.RadScheduler1.ActiveViewType = SchedulerViewType.Month
        Dim monthViewElement As SchedulerMonthViewElement = TryCast(Me.RadScheduler1.SchedulerElement.ViewElement, SchedulerMonthViewElement)
        monthViewElement.MonthViewAreaElement.AppointmentsComparer = New MyComparer()
        Me.RadScheduler1.Appointments.Add(New Appointment(DateTime.Today.AddHours(12), TimeSpan.FromHours(1), "A1"))
        Me.RadScheduler1.Appointments.Add(New Appointment(DateTime.Today.AddHours(8), TimeSpan.FromHours(1), "A2"))
        Me.RadScheduler1.Appointments.Add(New Appointment(DateTime.Today.AddHours(10), TimeSpan.FromHours(1), "A3"))

    End Sub

    Public Class MyComparer
        Implements IComparer(Of AppointmentElement)
        Public Function [Compare](x As AppointmentElement, y As AppointmentElement) As Integer _
                                               Implements IComparer(Of AppointmentElement).[Compare]
            Return x.Appointment.Summary.CompareTo(y.Appointment.Summary)
        End Function
    End Class 
End Class

