Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders.Html

Public Class RichTextEditor
    Inherits BaseGridEditor

    Public Overrides Property Value As Object
        Get
            Dim element As RichTextEditorElement = CType(EditorElement, RichTextEditorElement)
            Dim textBox As RadRichTextEditor = CType(element.HostedControl, RadRichTextEditor)
            Dim provider As HtmlFormatProvider = New HtmlFormatProvider()
            Return provider.Export(textBox.Document)
        End Get
        Set(ByVal value As Object)
            Dim element As RichTextEditorElement = CType(EditorElement, RichTextEditorElement)
            Dim textBox As RadRichTextEditor = CType(element.HostedControl, RadRichTextEditor)
            Dim provider As HtmlFormatProvider = New HtmlFormatProvider()

            If value IsNot Nothing Then
                textBox.Document = provider.Import(value.ToString())
            Else
                textBox.Document = provider.Import("<html><body></body></html>")
            End If
        End Set
    End Property

    Public Overrides Sub BeginEdit()
        MyBase.BeginEdit()
        Dim element As RichTextEditorElement = TryCast(Me.EditorElement, RichTextEditorElement)
        Dim richTextEditor As RadRichTextEditor = TryCast(element.HostedControl, RadRichTextEditor)
        AddHandler richTextEditor.Document.DocumentContentChanged, AddressOf Me.OnDocumentContentChanged
    End Sub

    Private Sub OnDocumentContentChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.OnValueChanged()
    End Sub

    Public Overrides Function EndEdit() As Boolean
        Dim element As RichTextEditorElement = TryCast(Me.EditorElement, RichTextEditorElement)
        Dim richTextEditor As RadRichTextEditor = TryCast(element.HostedControl, RadRichTextEditor)
        RemoveHandler richTextEditor.Document.DocumentContentChanged, AddressOf Me.OnDocumentContentChanged
        Return MyBase.EndEdit()
    End Function

    Protected Overrides Function CreateEditorElement() As RadElement
        Return New RichTextEditorElement()
    End Function
End Class
