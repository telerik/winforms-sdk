Imports Telerik.WinControls.UI

Public Class Form1

    Public Sub New()
        InitializeComponent()

        Dim colors As Color() = New Color() {Color.LightBlue, Color.LightGreen, Color.LightYellow, Color.Red, Color.Orange, Color.Pink, _
 Color.Purple, Color.Peru, Color.PowderBlue}

        Dim names As String() = New String() {"Alan Smith", "Anne Dodsworth", "Boyan Mastoni", "Richard Duncan", "Maria Shnaider"}

        For i As Integer = 0 To names.Length - 1
            Dim resource As New Resource()
            resource.Id = New EventId(i)
            resource.Name = names(i)
            resource.Color = colors(i)

            Me.RadScheduler1.Resources.Add(resource)
        Next

        RadScheduler1.GroupType = GroupType.Resource

    End Sub

    Private Sub RadScheduler1_AppointmentEditDialogShowing(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.AppointmentEditDialogShowingEventArgs) Handles RadScheduler1.AppointmentEditDialogShowing
        e.AppointmentEditDialog = New MultipleResourcesDialog()
    End Sub

End Class
