Imports Telerik.WinControls.UI

Public Class Form1
    Public Sub New()
        InitializeComponent()

        Me.RadGridView1.ViewDefinition = New MyTableViewDefinition()

        For i As Integer = 1 To 9
            Me.RadGridView1.Columns.Add("Col"& i)
        Next

        Me.RadGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        For i As Integer = 0 To 19
            Dim row As GridViewRowInfo = Me.RadGridView1.Rows.NewRow()
            Me.RadGridView1.Rows.Add(row)
        Next
    End Sub

    Public Class MyGridTableElement
    Inherits GridTableElement
        Private splitterWidth As Integer = 3
        Private freezePaneSplitter As MySplitter

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()

            Me.freezePaneSplitter = New MySplitter(Me)
            Me.freezePaneSplitter.DrawFill = True
            Me.freezePaneSplitter.BackColor = Color.CadetBlue
            Me.freezePaneSplitter.GradientStyle = Telerik.WinControls.GradientStyles.Solid

            Me.Children.Add(Me.freezePaneSplitter)
        End Sub

        Public Overrides Sub Initialize(gridRootElement As RadGridViewElement, viewInfo As GridViewInfo)
            MyBase.Initialize(gridRootElement, viewInfo)
            Me.freezePaneSplitter.Visibility = Telerik.WinControls.ElementVisibility.Visible
        End Sub

        Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
            Get
                Return GetType(GridTableElement)
            End Get
        End Property

        Protected Overrides Function MeasureCore(availableSize As SizeF) As SizeF
            Dim size As SizeF = MyBase.MeasureCore(availableSize)
            Me.freezePaneSplitter.Measure(New SizeF(Me.splitterWidth, size.Height))
            Return size
        End Function

        Protected Overrides Function ArrangeOverride(finalSize As SizeF) As SizeF
            Dim size As SizeF = MyBase.ArrangeOverride(finalSize)
            Dim clientRect As RectangleF = Me.GetClientRectangle(finalSize)
            Dim traverser As New PinnedColumnTraverser(Me.ViewElement.RowLayout.RenderColumns, PinnedColumnPosition.Left)
            Dim leftPinnedColumns As SizeF = Me.ViewElement.RowLayout.MeasurePinnedColumns(traverser)
            Me.freezePaneSplitter.Arrange(New RectangleF(leftPinnedColumns.Width - Me.splitterWidth / 2, clientRect.Y, Me.splitterWidth, clientRect.Height))
            Return size
        End Function
    End Class

    Public Class MyTableViewDefinition
    Inherits TableViewDefinition
        Public Overrides Function CreateViewUIElement(viewInfo As GridViewInfo) As IRowView
            Return New MyGridTableElement()
        End Function
    End Class

    Public Class MySplitter
    Inherits LightVisualElement
        Private moving As Boolean = False
        Private mouseDownLocation As Point
        Private owner As GridTableElement

        Public Sub New(owner As GridTableElement)
            Me.owner = owner
        End Sub

        Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
            MyBase.OnMouseDown(e)

            Me.Capture = True
            Me.moving = True
            Me.mouseDownLocation = e.Location
        End Sub

        Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
            MyBase.OnMouseMove(e)

            If Not Me.moving Then
                Return
            End If

            Me.PositionOffset = New SizeF(e.X - Me.mouseDownLocation.X, 0)
        End Sub

        Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
            MyBase.OnMouseUp(e)

            Me.Capture = False
            Me.moving = False

            Dim headerRowElement As GridTableHeaderRowElement = TryCast(Me.owner.GetRowElement(Me.owner.ViewInfo.TableHeaderRow), GridTableHeaderRowElement)

            If headerRowElement IsNot Nothing Then
                Dim point As New Point(e.X, headerRowElement.ControlBoundingRectangle.Y + headerRowElement.ControlBoundingRectangle.Height / 2)
                Dim cellElement As GridHeaderCellElement = Me.ElementTree.GetElementAtPoint(Of GridHeaderCellElement)(point)

                If cellElement IsNot Nothing Then
                    Dim half As Integer = 0

                    If e.X > cellElement.ControlBoundingRectangle.X + cellElement.ControlBoundingRectangle.Width / 2 Then
                        half += 1
                    End If

                    While Me.owner.ViewTemplate.PinnedColumns.Count > 0
                        Me.owner.ViewTemplate.PinnedColumns(0).IsPinned = False
                    End While

                    For i As Integer = 0 To cellElement.ColumnIndex + (half - 1)
                        Me.owner.ViewTemplate.Columns(i).IsPinned = True
                    Next
                Else
                    If e.X < Me.owner.RowHeaderColumnWidth Then
                        While Me.owner.ViewTemplate.PinnedColumns.Count > 0
                            Me.owner.ViewTemplate.PinnedColumns(0).IsPinned = False
                        End While
                    ElseIf e.X > Me.owner.ControlBoundingRectangle.Right - Me.owner.VScrollBar.Size.Width Then
                        For Each col As GridViewColumn In Me.owner.ViewTemplate.Columns
                            col.IsPinned = True
                        Next
                    End If
                End If
            End If

            Me.PositionOffset = SizeF.Empty
            Me.owner.InvalidateMeasure()
            Me.owner.UpdateLayout()
        End Sub
    End Class
End Class
