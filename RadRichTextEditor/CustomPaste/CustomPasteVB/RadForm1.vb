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
Imports Telerik.WinForms.Documents.Base
Imports Telerik.WinForms.Documents.FormatProviders.Txt
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinForms.Documents.RichTextBoxCommands

Namespace _1431704
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Public Sub New()
			InitializeComponent()

			AddHandler radRichTextEditor1.CommandExecuting, AddressOf RadRichTextEditor1_CommandExecuting
		End Sub

		Private pasteTextOnly As Boolean = False

		Private Sub RadRichTextEditor1_CommandExecuting(ByVal sender As Object, ByVal e As Telerik.WinForms.Documents.RichTextBoxCommands.CommandExecutingEventArgs)

			If TypeOf e.Command Is PasteCommand AndAlso pasteTextOnly Then
				e.Cancel = True
				PasteNewText()
				pasteTextOnly = False

			End If
		End Sub


		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			pasteTextOnly = True
			Me.radRichTextEditor1.RichTextBoxElement.Commands.PasteCommand.Execute()
		End Sub
		Private provider As New TxtFormatProvider()
		Public Sub PasteNewText()
			Dim clipboardDocument As DocumentFragment = Nothing
			Dim clipboardText As String = Nothing
			Dim clipboardContainsData As Boolean = False

			If ClipboardEx.ContainsDocument(Nothing) Then
				clipboardDocument = ClipboardEx.GetDocument()
				clipboardContainsData = True
			ElseIf ClipboardEx.ContainsText(Nothing) Then
				clipboardText = ClipboardEx.GetText(Nothing)
				clipboardContainsData = True
			End If

			If Not clipboardContainsData Then
				Return
			End If

			Me.radRichTextEditor1.ChangeFontFamily(New Telerik.WinControls.RichTextEditor.UI.FontFamily("Consolas"))

			If clipboardDocument IsNot Nothing Then
				Dim doc As New RadDocument()
				Dim editor As New RadDocumentEditor(doc)
				editor.InsertFragment(clipboardDocument)

				Dim text As String = provider.Export(doc)

				Me.radRichTextEditor1.RichTextBoxElement.ActiveDocumentEditor.Insert(text)
			ElseIf Not String.IsNullOrEmpty(clipboardText) Then
				Me.radRichTextEditor1.RichTextBoxElement.ActiveDocumentEditor.Insert(clipboardText)
			End If
		End Sub


		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			pasteTextOnly = True
			radRichTextEditor1.RichTextBoxElement.Commands.PasteCommand.Execute()
			pasteTextOnly = False

		End Sub
	End Class
End Namespace
