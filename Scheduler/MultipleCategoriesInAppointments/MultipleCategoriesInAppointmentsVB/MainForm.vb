Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class MainForm
    Public Sub New()
        InitializeComponent()
        Me.radScheduler1.ElementProvider = New MyElementProvider(Me.radScheduler1)
        Me.radScheduler1.AppointmentFactory = New CustomAppointmentFactory()
        AddHandler Me.radScheduler1.AppointmentEditDialogShowing, AddressOf RadScheduler1_AppointmentEditDialogShowing
        Dim a As AppointmentWithCategories = New AppointmentWithCategories() With {
            .Summary = "Telerik UI for WinForms",
            .Start = DateTime.Now,
            .Duration = TimeSpan.FromHours(2)
        }
        a.CategoryIds.Add(3)
        a.CategoryIds.Add(6)
        Me.radScheduler1.Appointments.Add(a)
    End Sub

    Private Sub RadScheduler1_AppointmentEditDialogShowing(ByVal sender As Object, ByVal e As AppointmentEditDialogShowingEventArgs)
        If Me.appointmentDialog Is Nothing Then
            Me.appointmentDialog = New CustomAppointmentEditForm()
        End If

        e.AppointmentEditDialog = Me.appointmentDialog
    End Sub

    Private appointmentDialog As CustomAppointmentEditForm = Nothing

    Public Class MyElementProvider
        Inherits SchedulerElementProvider

        Public Sub New(ByVal scheduler As RadScheduler)
            MyBase.New(scheduler)
        End Sub
        Protected Overrides Function CreateElement(Of T As SchedulerVisualElement)(view As SchedulerView, context As Object) As T
            If GetType(T) = GetType(AppointmentElement) Then
                Return TryCast(New CustomAppointmentElement(Me.Scheduler, view, CType(context, IEvent)), T)
            End If

            Return MyBase.CreateElement(Of T)(view, context)
        End Function
    End Class

    Public Class CustomAppointmentElement
        Inherits AppointmentElement

        Public Sub New(ByVal scheduler As RadScheduler, ByVal view As SchedulerView, ByVal appointment As IEvent)
            MyBase.New(scheduler, view, appointment)
        End Sub

        Private categoriesStack As StackLayoutElement

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            categoriesStack = New StackLayoutElement()
            categoriesStack.StretchHorizontally = False
            categoriesStack.Alignment = ContentAlignment.BottomRight
            categoriesStack.ShouldHandleMouseInput = False
            categoriesStack.NotifyParentOnMouseInput = True
            Me.Children.Add(categoriesStack)
        End Sub

        Public Overrides Sub Synchronize()
            MyBase.Synchronize()
            categoriesStack.Children.Clear()
            Dim categorizedAppointment As AppointmentWithCategories = TryCast(Me.Appointment, AppointmentWithCategories)

            For Each categoryId As Integer In categorizedAppointment.CategoryIds
                Dim lve As LightVisualElement = New LightVisualElement()
                lve.Alignment = ContentAlignment.MiddleRight
                lve.StretchHorizontally = False
                lve.ShouldHandleMouseInput = False
                lve.NotifyParentOnMouseInput = True
                lve.DrawFill = True
                lve.DrawBorder = True
                lve.BorderGradientStyle = GradientStyles.Solid
                lve.BorderColor = Color.Gray
                lve.MinSize = New Size(10, 20)
                lve.GradientStyle = GradientStyles.Solid
                lve.BackColor = GetBackgroundById(categoryId)
                categoriesStack.Children.Add(lve)
            Next
        End Sub

        Public Function GetBackgroundById(ByVal categoryId As Integer) As Color
            For Each bc As AppointmentBackgroundInfo In Me.Scheduler.Backgrounds

                If bc.Id = categoryId Then

                    If Me.Scheduler.UseModernAppointmentStyles Then
                        Return bc.BackColor
                    End If

                    Return bc.BackColor2
                End If
            Next

            Return Color.Red
        End Function
    End Class

    Public Class CustomAppointmentFactory
        Implements IAppointmentFactory

        Public Function CreateNewAppointment() As IEvent Implements IAppointmentFactory.CreateNewAppointment
            Return New AppointmentWithCategories()
        End Function

    End Class

    Public Class AppointmentWithCategories
        Inherits Appointment

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Function CreateOccurrenceInstance() As [Event]
            Return New AppointmentWithCategories()
        End Function

        Private _categoryIds As BindingList(Of Integer) = New BindingList(Of Integer)()

        Public Property CategoryIds As BindingList(Of Integer)
            Get
                Return Me._categoryIds
            End Get
            Set(ByVal value As BindingList(Of Integer))

                If Not Me._categoryIds.Equals(value) Then
                    Me._categoryIds = value
                    Me.OnPropertyChanged("CategoryIds")
                End If
            End Set
        End Property
    End Class
End Class
