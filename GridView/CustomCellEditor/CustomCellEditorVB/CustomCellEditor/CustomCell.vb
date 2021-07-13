Imports Telerik.WinControls.UI

Public Class CustomInfoCell
    Inherits GridComboBoxCellElement

    Private buttonWidth As Integer = 20
    Private buttonPadding As Integer = 2

    Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
        MyBase.New(column, row)
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType() As System.Type
        Get
            Return GetType(GridComboBoxCellElement)
        End Get
    End Property

    Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
        MyBase.ArrangeOverride(finalSize)
        Dim rect As RectangleF = GetClientRectangle(finalSize)
        Dim rectEdit As RectangleF = New RectangleF(rect.X, rect.Y, rect.Width - (buttonWidth + buttonPadding), rect.Height)
        Dim rectButton As RectangleF = New RectangleF(rectEdit.Right + buttonPadding, rectEdit.Y, buttonWidth, rect.Height)
        If Me.Children.Count = 2 Then
            Me.Children(0).Arrange(rectButton)
            Me.Children(1).Arrange(rectEdit)
        End If

        Return finalSize
    End Function
End Class