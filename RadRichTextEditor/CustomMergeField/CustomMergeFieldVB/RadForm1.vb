Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.Layout
Imports Telerik.WinForms.Documents.Model

Namespace CustomMergeField
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Public Sub New()
			InitializeComponent()

			Me.radRichTextEditor1.Document.MailMergeDataSource.ItemsSource = New List(Of Customer)() _
				From {
					New Customer() With {
						.FirstName = "John",
						.LastName = "Doe",
						.Orders = New List(Of Order)() From {
							New Order() With {.ProductName = "Product 1"},
							New Order() With {.ProductName = "Product 2"}
						}
					},
					New Customer() With {
						.FirstName = "Sara",
						.LastName = "Doe",
						.Orders = New List(Of Order)() From {
							New Order() With {.ProductName = "Product 3"},
							New Order() With {.ProductName = "Product 4"}
						}
					}
				}

			Me.radRichTextEditor1.InsertField(New MergeField() With {.PropertyPath = "FirstName"})
			Me.radRichTextEditor1.Insert(FormattingSymbolLayoutBox.ENTER)
			Me.radRichTextEditor1.InsertField(New OrdersMergeField() With {.PropertyPath = "Orders"})

		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			Dim docuemnt = radRichTextEditor1.MailMerge()
			radRichTextEditor1.Document = docuemnt
		End Sub
	End Class
End Namespace
