Imports Telerik.WinControls.UI

Public Class RadForm1
    Public Sub New()
        InitializeComponent()
        Me.RadGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        Me.RadGridView1.Columns.Add(New GridViewRichTextColumn("Text", "Text"))
        Dim row As GridViewRowInfo = RadGridView1.Rows.AddNew()
        row.Height = 200
        row.Cells(0).Value = "<html><span style=""background-color:red"">Highlighted Text</span></html>"
        row = RadGridView1.Rows.AddNew()
        row.Height = 200
        row.Cells(0).Value = "<html><span style=""background-color:red"">Second Text</span></html>"
        row = RadGridView1.Rows.AddNew()
        row.Height = 200
        row.Cells(0).Value = "<html><span style=""background-color:red"">Third Text</span></html>"
        AddHandler Me.RadGridView1.CurrentCellChanged, AddressOf RadGridView1_CurrentCellChanged
    End Sub

    Private Sub RadGridView1_CurrentCellChanged(ByVal sender As Object, ByVal e As CurrentCellChangedEventArgs)
        If e.NewCell IsNot Nothing AndAlso TypeOf e.NewCell.ColumnInfo Is GridViewRichTextColumn Then
            Dim cellElement As RichTextEditorCellElement = TryCast(Me.RadGridView1.TableElement.GetCellElement(e.NewCell.RowInfo,
                                                                    e.NewCell.ColumnInfo), RichTextEditorCellElement)

            If cellElement IsNot Nothing Then
                Dim element As RichTextEditorElement = CType((CType(cellElement.Editor, RichTextEditor)).EditorElement, RichTextEditorElement)
                Dim textBox As RadRichTextEditor = CType(element.HostedControl, RadRichTextEditor)
                Me.RichTextEditorRibbonBar1.AssociatedRichTextEditor = textBox
                Console.WriteLine(textBox.GetHashCode())
            End If
        End If
    End Sub
End Class
