Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.UI

Namespace _1407985
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm
		Public Sub New()
			InitializeComponent()
			radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
			radListView1.Columns.Add("Col1")
			radListView1.Columns.Add("Col2")
			radListView1.Columns.Add("Col3")

			For i As Integer = 0 To 4
				Dim item = New ListViewDataItem()
				item(0) = "Row" & i
				item(1) = "Test"
				item(2) = "Test2"
				radListView1.Items.Add(item)
			Next i

			Dim view = TryCast(radListView1.ListViewElement.ViewElement, DetailListViewElement)


			AddHandler radListView1.EditorRequired, AddressOf RadListView1_EditorRequired

		End Sub



		Private Sub RadListView1_EditorRequired(ByVal sender As Object, ByVal e As ListViewItemEditorRequiredEventArgs)
			If e.ListViewElement.CurrentColumn.Name = "Col2" Then
				Dim editor = New MyListViewDropDownListEditor()
				TryCast(editor.EditorElement, BaseDropDownListEditorElement).Items.Add("Product1")
				TryCast(editor.EditorElement, BaseDropDownListEditorElement).Items.Add("Product2")
				TryCast(editor.EditorElement, BaseDropDownListEditorElement).Items.Add("Product3")

				e.Editor = editor
			End If
		End Sub


	End Class
	Friend Class MyListViewDropDownListEditor
		Inherits ListViewDropDownListEditor
		Public Overrides Sub OnValueChanged()
		   ' base.OnValueChanged();
		End Sub
	End Class
	Friend Class MyRadListView
		Inherits RadListView
		Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
			If keyData = Keys.Tab Then
				Dim view = TryCast(Me.ListViewElement.ViewElement, DetailListViewElement)
				Dim element = Me.ListViewElement
				Dim columnIndex As Integer = element.Columns.IndexOf(element.CurrentColumn)

				Dim colEnumerator As ITraverser(Of ListViewDetailColumn) = CType(view.ColumnScroller.Traverser.GetEnumerator(), ITraverser(Of ListViewDetailColumn))
				colEnumerator.Position = columnIndex

				If colEnumerator.MoveNext() Then
					Dim isEditing = element.IsEditing

					element.CurrentColumn = colEnumerator.Current
					If isEditing Then
						element.BeginEdit()
					End If
					Return True
				Else
					Dim enumerator As ListViewTraverser = TryCast(view.Scroller.Traverser.GetEnumerator(), ListViewTraverser)
					enumerator.Position = element.CurrentItem

					If enumerator.MoveNext() Then
						Dim isEditing = element.IsEditing


						colEnumerator.Reset()
						colEnumerator.MoveNext()
						element.CurrentColumn = colEnumerator.Current
						element.CurrentItem = enumerator.Current
						element.SelectedItem = enumerator.Current

						If isEditing Then
							element.BeginEdit()
						End If

						Return True
					End If
				End If


			End If
			If keyData = (Keys.Tab Or Keys.Shift) Then
				Dim view = TryCast(Me.ListViewElement.ViewElement, DetailListViewElement)
				Dim element = Me.ListViewElement
				Dim columnIndex As Integer = element.Columns.IndexOf(element.CurrentColumn)

				Dim colEnumerator As ITraverser(Of ListViewDetailColumn) = CType(view.ColumnScroller.Traverser.GetEnumerator(), ITraverser(Of ListViewDetailColumn))
				colEnumerator.Position = columnIndex

				If colEnumerator.MovePrevious() Then
					Dim isEditing = element.IsEditing

					element.CurrentColumn = colEnumerator.Current

					If isEditing Then
						element.BeginEdit()
					End If
					Return True
				Else
					Dim enumerator As ListViewTraverser = TryCast(view.Scroller.Traverser.GetEnumerator(), ListViewTraverser)
					enumerator.Position = element.CurrentItem

					If enumerator.MovePrevious() Then
						Dim isEditing = element.IsEditing

						colEnumerator.MoveToEnd()
						element.CurrentColumn = colEnumerator.Current
						element.CurrentItem = enumerator.Current
						element.SelectedItem = enumerator.Current

						If isEditing Then
							element.BeginEdit()
						End If

						Return True
					End If
				End If
			End If
			Return MyBase.ProcessDialogKey(keyData)
		End Function
	End Class
End Namespace
