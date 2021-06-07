Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Namespace GridSortExtend
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Private rnd As New Random()
		Private data As BindingList(Of GridItem)

		Public Sub New()
			InitializeComponent()
			data = New BindingList(Of GridItem)()
			For i As Integer = 0 To 99999
				data.Add(New GridItem("Text " & rnd.Next(100), i))
			Next i

			radGridView1.DataSource = data
			radGridView1.MasterTemplate.SortComparer = New CustomComparer(Me.radGridView1.SortDescriptors)
		End Sub
	End Class

	Public Class GridItem
		Public Property TextValue() As String

		Public Property IntValue() As Integer

		Public Sub New(ByVal textValue As String, ByVal intValue As Integer)
			Me.TextValue = textValue
			Me.IntValue = intValue
		End Sub
	End Class

	Public Class CustomComparer
		Implements IComparer(Of GridViewRowInfo)

		Private sortDescriptors As SortDescriptorCollection

		Public Sub New(ByVal sortDescriptors As SortDescriptorCollection)
			Me.sortDescriptors = sortDescriptors
		End Sub

		Public Function Compare(ByVal x As GridViewRowInfo, ByVal y As GridViewRowInfo) As Integer Implements IComparer(Of GridViewRowInfo).Compare
			Dim item1 As GridItem = DirectCast(x.DataBoundItem, GridItem)
			Dim item2 As GridItem = DirectCast(y.DataBoundItem, GridItem)

			Dim result As Integer = 0

			For i As Integer = 0 To Me.sortDescriptors.Count - 1
				result = Me.CompareDataItems(item1, item2, Me.sortDescriptors(i).PropertyName, Me.sortDescriptors(i).Direction = ListSortDirection.Ascending)

				If result <> 0 Then
					Return result
				End If
			Next i

			Return result
		End Function

		Private Function CompareDataItems(ByVal x As GridItem, ByVal y As GridItem, ByVal propertyName As String, ByVal ascending As Boolean) As Integer
			Dim asc As Integer = If(ascending, 1, -1)

			Select Case propertyName
				Case "TextValue"
					Return x.TextValue.CompareTo(y.TextValue) * asc
				Case "IntValue"
					Return x.IntValue.CompareTo(y.IntValue) * asc
			End Select

			Return 0
		End Function
	End Class
End Namespace