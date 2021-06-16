Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace TreeViewDragDropToGrid
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			Me.radGridView1.RowCount = 10

			Dim treeViewDragDrop As TreeViewDragDropService = Me.radTreeView1.TreeViewElement.DragDropService
			AddHandler treeViewDragDrop.PreviewDragOver, AddressOf OnPreviewDragOver
			AddHandler treeViewDragDrop.PreviewDragDrop, AddressOf OnPreviewDragDrop

			Me.radTreeView1.AllowDragDrop = True
			AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting
		End Sub

		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			e.CellElement.AllowDrop = True
		End Sub

		Private Sub OnPreviewDragDrop(ByVal sender As Object, ByVal e As Telerik.WinControls.RadDropEventArgs)
			Dim dataCell As GridDataCellElement = TryCast(e.HitTarget, GridDataCellElement)

			If Not dataCell Is Nothing Then
				Dim element As TreeNodeElement = TryCast(e.DragInstance, TreeNodeElement)
				dataCell.Value = element.Data.Name
				e.Handled = True
			End If
		End Sub

		Private Sub OnPreviewDragOver(ByVal sender As Object, ByVal e As Telerik.WinControls.RadDragOverEventArgs)
			Dim dataCell As GridDataCellElement = TryCast(e.HitTarget, GridDataCellElement)

			If Not dataCell Is Nothing Then
				Dim element As TreeNodeElement = TryCast(e.DragInstance, TreeNodeElement)

				Dim value As Object = Nothing
				e.CanDrop = RadDataConverter.Instance.TryParse(TryCast(dataCell, IDataConversionInfoProvider), element.Data.Name, value) Is Nothing
			End If
		End Sub

	End Class
End Namespace
