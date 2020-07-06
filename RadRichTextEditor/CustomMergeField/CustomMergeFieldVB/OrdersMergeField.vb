Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.RichTextEditor.UI
Imports Telerik.WinForms.Documents.Model

Namespace CustomMergeField
	Public Class OrdersMergeField
		Inherits MergeField

		Private Const CustomFieldName As String = "OrdersField"

		Shared Sub New()
			CodeBasedFieldFactory.RegisterFieldType(OrdersMergeField.CustomFieldName, Function()
				Return New OrdersMergeField()
			End Function)
		End Sub

		Public Overrides ReadOnly Property FieldTypeName() As String
			Get
				Return OrdersMergeField.CustomFieldName
			End Get
		End Property

		Public Overrides Function CreateInstance() As Field
			Return New OrdersMergeField()
		End Function

		Protected Overrides Function GetResultFragment() As DocumentFragment
			Dim customer As Customer = TryCast(Me.Document.MailMergeDataSource.CurrentItem, Customer)
			If customer Is Nothing Then
				Return Nothing
			End If

			If Me.PropertyPath = "Orders" Then
				Dim table As New Table()
				Dim grayBorder1 = New Border(1, BorderStyle.Single, Colors.Gray)

				For Each order As Order In customer.Orders
					Dim span As New Span(order.ProductName)
					Dim paragraph As New Paragraph()
					paragraph.Inlines.Add(span)

					Dim cell As New TableCell()
					cell.Borders = New TableCellBorders(grayBorder1)
					cell.Blocks.Add(paragraph)

					Dim row As New TableRow()
					row.Cells.Add(cell)

					table.AddRow(row)
				Next order

				Dim section As New Section()
				section.Blocks.Add(table)

				Dim document As New RadDocument()
				document.Sections.Add(section)

				document.MeasureAndArrangeInDefaultSize()
				Return New DocumentFragment(document)
			End If

			Return Nothing
		End Function
	End Class
End Namespace
