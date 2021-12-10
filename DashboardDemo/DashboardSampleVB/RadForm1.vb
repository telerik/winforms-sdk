Public Class RadForm1
    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        Dim control As DashboardControl = New DashboardControl()
        control.Dock = DockStyle.Fill
        Controls.Add(control)
        control.Element.Pending.Content.Children.Add(New TaskElement("Some hard task"))
        control.Element.Pending.Content.Children.Add(New TaskElement("Another task"))
        control.Element.Pending.Content.Children.Add(New TaskElement("Third task."))
        control.Element.InProgress.Content.Children.Add(New TaskElement("A running task.") With {
            .BackColor = Color.LightGreen
        })
    End Sub
End Class
