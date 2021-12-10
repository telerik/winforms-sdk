Imports Telerik.WinControls.UI

Public Class ColumnHeaderElement
    Inherits LightVisualElement

    Protected Overrides Sub InitializeFields()
        MyBase.InitializeFields()
        Me.DrawFill = True
        Me.DrawBorder = True
        Me.Padding = New Padding(5)
        Me.StretchHorizontally = True
        Me.StretchVertically = False
        Me.Margin = New Padding(1)
    End Sub
End Class