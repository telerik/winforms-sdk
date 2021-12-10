Imports Telerik.WinControls.UI

Public Class TaskElement
    Inherits LightVisualElement

    Public Sub New(ByVal text As String)
        Me.Text = text
    End Sub

    Protected Overrides Sub InitializeFields()
        MyBase.InitializeFields()
        Me.DrawFill = True
        Me.DrawBorder = True
        Me.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.BackColor = Color.Yellow
        Me.BorderColor = Color.Black
        Me.AllowDrag = True
        Me.StretchHorizontally = True
        Me.StretchVertically = False
        Me.TextWrap = True
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Margin = New System.Windows.Forms.Padding(5)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        Dim dashboard As DashboardElement = FindAncestor(Of DashboardElement)()
        dashboard.DragDropService.Start(Me)
    End Sub
End Class