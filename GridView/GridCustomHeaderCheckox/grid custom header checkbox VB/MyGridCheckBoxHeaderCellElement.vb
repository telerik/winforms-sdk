Imports System
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace _1171173
	Friend Class MyGridCheckBoxHeaderCellElement
		Inherits GridHeaderCellElement

		Private checkBox As RadCheckBoxElement
		Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
			MyBase.New(column, row)

		End Sub
		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			checkBox = New RadCheckBoxElement()
			AddHandler checkBox.ToggleStateChanged, AddressOf CheckBox_ToggleStateChanged
			Me.Children.Add(checkBox)
		End Sub

		Private Sub CheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)

			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				For Each item In Me.GridControl.ChildRows
					item.Cells(Me.ColumnIndex).Value = True
				Next item
			Else
				For Each item In Me.GridControl.ChildRows
					item.Cells(Me.ColumnIndex).Value = False
				Next item
			End If

		End Sub
		Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
			Return MyBase.IsCompatible(data, context) AndAlso data.Name = "Bool"
		End Function
		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(GridHeaderCellElement)
			End Get
		End Property
	End Class

	Public Class CustomColumn
		Inherits GridViewCheckBoxColumn

		Public Sub New(ByVal fieldName As String)
			MyBase.New(fieldName)
		End Sub

		Public Overrides Function GetCellType(ByVal row As GridViewRowInfo) As Type
			If TypeOf row Is GridViewTableHeaderRowInfo Then
				Return GetType(MyGridCheckBoxHeaderCellElement)
			End If
			Return MyBase.GetCellType(row)
		End Function

	End Class
End Namespace