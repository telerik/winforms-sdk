Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders.Html
Imports Telerik.WinForms.Documents.Model

Public Class RichTextEditorCellElement
    Inherits GridDataCellElement

    Private _editor As RichTextEditor

    Public Sub New(ByVal col As GridViewColumn, ByVal row As GridRowElement)
        MyBase.New(col, row)
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType As Type
        Get
            Return GetType(GridDataCellElement)
        End Get
    End Property

    Public Overrides ReadOnly Property Editor As IInputEditor
        Get
            Return Me._editor
        End Get
    End Property

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        Me._editor = New RichTextEditor()
        Me.Children.Add(Me._editor.EditorElement)
    End Sub

    Protected Overrides Sub SetContentCore(ByVal value As Object)
        Try
            Me.editor.Value = Convert.ToString(value)

            If Me.Value IsNot Nothing AndAlso Not Me.Value.Equals(DBNull.Value) AndAlso Not Me.Value.ToString().Equals(String.Empty) Then
                Dim element As RichTextEditorElement = CType(Me._editor.EditorElement, RichTextEditorElement)
                Dim textBox As RadRichTextEditor = CType(element.HostedControl, RadRichTextEditor)
                Dim provider As HtmlFormatProvider = New HtmlFormatProvider()
                Dim document As RadDocument = provider.Import(Me.Value.ToString())
                textBox.Document = document
                document.LayoutMode = DocumentLayoutMode.Flow
            End If

        Catch ex As Exception
            MessageBox.Show(Nothing, ex.ToString(), "EXCEPTION", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Public Overrides Sub Attach(ByVal data As GridViewColumn, ByVal context As Object)
        MyBase.Attach(data, context)

        If Me.RowElement IsNot Nothing Then
            Me.GridViewElement.EditorManager.RegisterPermanentEditorType(GetType(RichTextEditor))
        End If
    End Sub
End Class
