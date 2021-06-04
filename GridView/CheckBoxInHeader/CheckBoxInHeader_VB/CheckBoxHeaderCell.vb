Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.Drawing

Public Class CheckBoxHeaderCell
    Inherits GridHeaderCellElement
    Private checkbox As RadCheckBoxElement

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(GridHeaderCellElement)
        End Get
    End Property

    Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
        MyBase.New(column, row)

    End Sub

    Public Overrides Sub Initialize(ByVal column As GridViewColumn, ByVal row As GridRowElement)
        MyBase.Initialize(column, row)
        column.AllowSort = False
    End Sub


    Public Overloads Overrides Sub SetContent()
    End Sub

    Protected Overrides Sub DisposeManagedResources()
        RemoveHandler checkbox.ToggleStateChanged, AddressOf checkbox_ToggleStateChanged
        MyBase.DisposeManagedResources()
    End Sub

    Protected Overloads Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        checkbox = New RadCheckBoxElement()
        AddHandler checkbox.ToggleStateChanged, AddressOf checkbox_ToggleStateChanged
        Me.Children.Add(checkbox)
    End Sub

    Protected Overloads Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
        Dim size As SizeF = MyBase.ArrangeOverride(finalSize)

        Dim rect As RectangleF = GetClientRectangle(finalSize)
        Me.checkbox.Arrange(New RectangleF((finalSize.Width - Me.checkbox.DesiredSize.Width) / 2, (rect.Height - 20) / 2, 20, 20))

        Return size
    End Function

    Public Overloads Overrides Function IsCompatible(ByVal data As Telerik.WinControls.UI.GridViewColumn, ByVal context As Object) As Boolean
        Return data.Name = "Select" AndAlso TypeOf context Is GridTableHeaderRowElement AndAlso MyBase.IsCompatible(data, context)
    End Function

    Private Sub checkbox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
        If TypeOf Me.ColumnInfo Is GridViewCheckBoxColumn Then
            Dim valueState As Boolean = False

            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
                valueState = True
            End If

            For i As Integer = 0 To Me.ViewTemplate.RowCount - 1
                Me.ViewTemplate.Rows(i).Cells(Me.ColumnIndex).Value = valueState
            Next
        End If
    End Sub
End Class