Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Layouts

Public Class Form1
    Public Sub New()
        InitializeComponent()

        Dim dt As DataTable = New DataTable()

        Dim id As DataColumn = New DataColumn()
        id.Caption = "Id"
        id.AutoIncrement = True
        dt.Columns.Add(id)

        Dim name As DataColumn = New DataColumn()
        name.Caption = "Name"
        dt.Columns.Add(name)

        Dim linkLabelCol As DataColumn = New DataColumn()
        linkLabelCol.Caption = "Web site"
        dt.Columns.Add(linkLabelCol)

        Dim webAddressCol As DataColumn = New DataColumn()
        webAddressCol.Caption = "HiddenWebAddressCol"
        dt.Columns.Add(webAddressCol)

        For i As Integer = 0 To 999
            Dim row As DataRow = dt.NewRow()
            row(1) = "John" & i.ToString()
            If i Mod 2 = 0 Then
                row(2) = "Telerik"
                row(3) = "http://www.telerik.com"
            ElseIf i Mod 5 = 0 Then
                row(2) = "Google"
                row(3) = "http://www.google.com"
            Else
                row(2) = "Yahoo"
                row(3) = "http://www.yahoo.com"
            End If
            dt.Rows.Add(row)
        Next i

        AddHandler RadGridView1.CellFormatting, AddressOf radGridView1_CellFormatting
        AddHandler RadGridView1.CellClick, AddressOf radGridView1_CellClick
        AddHandler RadGridView1.MouseMove, AddressOf radGridView1_MouseMove

        Me.RadGridView1.DataSource = dt

        Me.RadGridView1.MasterTemplate.BestFitColumns()
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        Me.RadGridView1.Columns(3).IsVisible = False
        Me.RadGridView1.Columns(2).ReadOnly = True
    End Sub

    ' If the mouse cursor is on the cell of the linklabel column,
    ' the cursor becomes a hand
    Private Sub radGridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim cellElement As LightVisualElement = TryCast(Me.RadGridView1.ElementTree.GetElementAtPoint(e.Location), LightVisualElement)
        If cellElement Is Nothing Then
            Return
        End If
        If TypeOf cellElement Is GridDataCellElement Then
            If DirectCast(cellElement, GridDataCellElement).ColumnIndex = 2 Then
                Dim mgr As Telerik.WinControls.UI.LayoutManagerPart = TryCast(DirectCast(cellElement, LightVisualElement).Layout, LayoutManagerPart)
                Dim size As SizeF = TextRenderer.MeasureText(cellElement.Text, cellElement.Font)
                Dim textRectangle As RectangleF = LayoutUtils.Align(size, mgr.RightPart.Bounds, cellElement.TextAlignment)

                If (textRectangle.Contains(cellElement.PointFromControl(e.Location))) Then
                    Me.RadGridView1.Cursor = Cursors.Hand
                Else
                    Me.RadGridView1.Cursor = Cursors.[Default]
                End If
            End If
        Else
            Me.RadGridView1.Cursor = Cursors.Arrow
        End If
    End Sub

    ' If you click on a cell which belongs to the linklabel column
    ' this opens the corresponding web site. The URL is taken from the invisible column
    Private Sub radGridView1_CellClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
        If e.ColumnIndex = 2 AndAlso e.RowIndex >= 0 Then
            Process.Start(Me.RadGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value.ToString())
        End If
    End Sub

    Private font_ As Font = New Font("Tahoma", 9.0F, FontStyle.Underline)

    ' Here I am formatting the text
    Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
        If e.CellElement.RowIndex >= 0 Then
            If e.CellElement.ColumnIndex = 2 Then
                If e.CellElement.ForeColor <> Color.Blue Then
                    e.CellElement.Font = font_
                    e.CellElement.ForeColor = Color.Blue
                End If
            End If
        End If
    End Sub
End Class
