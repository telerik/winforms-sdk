Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports System.Collections.Generic

Namespace RadGridViewExample
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
            'This project demonstrates how to show the summary cells when the groups are collpased
'			#Region "Populate with data"
			For i As Integer = 0 To 4
				Dim col As GridViewDecimalColumn = New GridViewDecimalColumn("Col " & (i + 1))
				Me.radGridView1.Columns.Add(col)
			Next i

			For i As Integer = 0 To 19
				Me.radGridView1.Rows.Add(i Mod 5, i Mod 3, i Mod 2, i, i)
			Next i
'			#End Region

'			#Region "Add summary items"
			Dim item1 As GridViewSummaryItem = New GridViewSummaryItem("Col 1", "Sum = {0}", GridAggregateFunction.Sum)
			Dim item2 As GridViewSummaryItem = New GridViewSummaryItem("Col 2", "Avg = {0}", GridAggregateFunction.Avg)
			Dim item4 As GridViewSummaryItem = New GridViewSummaryItem("Col 4", "Max = {0}", GridAggregateFunction.Max)
			Dim item5 As GridViewSummaryItem = New GridViewSummaryItem("Col 5", "First = {0}", GridAggregateFunction.First)
			Dim row As GridViewSummaryRowItem = New GridViewSummaryRowItem(New GridViewSummaryItem() { item1, item2, item4, item5 })
			Me.radGridView1.SummaryRowsTop.Add(row)
'			#End Region

			Me.radGridView1.TableElement.GroupHeaderHeight = 50
            Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			AddHandler radGridView1.CreateCell, AddressOf radGridView1_CreateCell
			AddHandler radGridView1.Columns.CollectionChanged, AddressOf Columns_CollectionChanged
		End Sub

		Private Sub Columns_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
			'invalidate when columns are rearrangerd
			Me.radGridView1.MasterTemplate.Refresh()
		End Sub

		Private Sub radGridView1_CreateCell(ByVal sender As Object, ByVal e As GridViewCreateCellEventArgs)
			If e.CellType Is GetType(GridGroupContentCellElement) Then
				e.CellElement = New MyGridGroupContentCellElement(e.Column, e.Row)
			End If
		End Sub
	End Class

	Public Class MyGridGroupContentCellElement
		Inherits GridGroupContentCellElement
		Private stack As StackLayoutElement
		Private showSummaryCells_Renamed As Boolean = True

		Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
			MyBase.New(column, row)
			'creating the elements here in order to have a valid insance of a row
			If Me.stack Is Nothing Then
				Me.CreateStackElement(row)
			End If

            Me.ClipDrawing = True
            AddHandler row.GridControl.TableElement.HScrollBar.Scroll, AddressOf HScrollBar_Scroll
            AddHandler row.GridControl.ColumnWidthChanged, AddressOf GridControl_ColumnWidthChanged
			AddHandler row.GridControl.GroupDescriptors.CollectionChanged, AddressOf GroupDescriptors_CollectionChanged
		End Sub

		Private Sub GroupDescriptors_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
			If TypeOf Me.RowInfo.Parent Is GridViewGroupRowInfo AndAlso (CType(Me.RowInfo.Parent, GridViewGroupRowInfo)).IsExpanded Then
				Me.InvalidateArrange()
			End If
		End Sub

        Private Sub HScrollBar_Scroll(sender As Object, e As ScrollEventArgs)
            If e.NewValue <> e.OldValue Then
                Me.stack.PositionOffset = New SizeF(0 - e.NewValue, 0)
            End If
        End Sub


		Private Sub CreateStackElement(ByVal row As GridRowElement)
			Me.stack = New StackLayoutElement()
			Me.stack.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			Me.stack.AutoSize = True
			Me.stack.StretchHorizontally = True
			Me.stack.Alignment = ContentAlignment.BottomCenter
			Me.stack.DrawFill = True
			Me.stack.BackColor = Color.White

			Dim i As Integer = 0
			Do While i < row.RowInfo.Cells.Count
				Dim element As SummaryCellElement = New SummaryCellElement()
				element.ColumnName = row.RowInfo.Cells(i).ColumnInfo.Name
				element.StretchHorizontally = False
				element.StretchVertically = True
				element.DrawBorder = True
				element.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
				element.BorderColor = Color.LightBlue
				Me.stack.Children.Add(element)
				i += 1
			Loop

			Me.Children.Add(Me.stack)
		End Sub

		Public Overrides Sub Initialize(ByVal column As GridViewColumn, ByVal row As GridRowElement)
			MyBase.Initialize(column, row)
			Me.ShowSummaryCells = (Not row.Data.IsExpanded) OrElse row.Data.Group.Groups.Count > 0
		End Sub

		Protected Overrides Sub DisposeManagedResources()
			If Not Me.GridControl Is Nothing Then
				RemoveHandler Me.GridControl.ColumnWidthChanged, AddressOf GridControl_ColumnWidthChanged
				RemoveHandler Me.GridControl.GroupDescriptors.CollectionChanged, AddressOf GroupDescriptors_CollectionChanged
			End If

			MyBase.DisposeManagedResources()
		End Sub

		Public Property ShowSummaryCells() As Boolean
			Get
				Return Me.showSummaryCells_Renamed
			End Get
			Set
				If Me.showSummaryCells_Renamed <> Value Then
					Me.showSummaryCells_Renamed = Value

					If Me.stack Is Nothing Then
						Me.CreateStackElement(Me.RowElement)
					End If

					If Me.showSummaryCells_Renamed Then
						Me.stack.Visibility = ElementVisibility.Visible
					Else
						Me.stack.Visibility = ElementVisibility.Hidden
					End If
				End If
			End Set
		End Property

		Private Sub GridControl_ColumnWidthChanged(ByVal sender As Object, ByVal e As ColumnWidthChangedEventArgs)
			Me.InvalidateArrange()
		End Sub

		Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
			Dim size As SizeF = MyBase.ArrangeOverride(finalSize)

			Dim x As Single = Me.GridControl.TableElement.GroupIndent * (Me.GridControl.GroupDescriptors.Count - Me.RowInfo.Group.Level - 1)
			Dim y As Single = size.Height - Me.stack.DesiredSize.Height - 2f
			Dim width As Single = size.Width - x
			Dim height As Single = Me.stack.DesiredSize.Height

			Me.stack.Arrange(New RectangleF(x, y, width, height))

			For Each element As SummaryCellElement In Me.stack.Children
				Dim elementSize As Size = New Size(Me.RowInfo.Cells(element.ColumnName).ColumnInfo.Width + Me.GridControl.TableElement.CellSpacing, 0)
				element.MinSize = elementSize
				element.MaxSize = elementSize
			Next element

			Return size
		End Function

		Public Overrides Sub SetContent()
			MyBase.SetContent()

			Me.ShowSummaryCells = (Not Me.RowInfo.Group.IsExpanded) OrElse Me.RowInfo.Group.Groups.Count > 0

			Dim rowInfo As GridViewGroupRowInfo = CType(Me.RowInfo, GridViewGroupRowInfo)

			If TypeOf rowInfo.Parent Is GridViewGroupRowInfo AndAlso Not(CType(rowInfo.Parent, GridViewGroupRowInfo)).IsExpanded Then
				Return
			End If

			Dim values As Dictionary(Of String, String) = Me.GetSummaryValues()
			Dim index As Integer = 0

            For Each column As KeyValuePair(Of String, String) In values
                Dim element As SummaryCellElement = (CType(Me.stack.Children(index), SummaryCellElement))
                index += 1

                If Me.ViewTemplate.Columns(column.Key).IsGrouped Then
                    element.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
                Else
                    element.Visibility = Telerik.WinControls.ElementVisibility.Visible
                    element.Text = column.Value
                End If
            Next column
		End Sub

		Public Overridable Function GetSummaryValues() As Dictionary(Of String, String)
			If Me.ElementTree Is Nothing Then
				Return New Dictionary(Of String, String)()
			End If

			Dim result As Dictionary(Of String, String) = New Dictionary(Of String, String)()

			For Each cell As SummaryCellElement In Me.stack.Children
				If Me.GridControl.SummaryRowsTop(0)(cell.ColumnName) Is Nothing Then
					result.Add(cell.ColumnName, String.Empty)
				Else
					Dim summaryItem As GridViewSummaryItem = Me.GridControl.SummaryRowsTop(0)(cell.ColumnName)(0)
					Dim value As Object = Me.ViewTemplate.DataView.Evaluate(summaryItem.GetSummaryExpression(), Me.GetDataRows())
					Dim text As String = String.Format(summaryItem.FormatString, value)
					result.Add(summaryItem.Name, text)
				End If
			Next cell

			Return result
		End Function

		Private Function GetDataRows() As IEnumerable(Of GridViewRowInfo)
			Dim queue As Queue(Of GridViewRowInfo) = New Queue(Of GridViewRowInfo)()
			queue.Enqueue(Me.RowInfo)

            Dim list As New List(Of GridViewRowInfo)

			Do While queue.Count <> 0
				Dim currentRow As GridViewRowInfo = queue.Dequeue()

				If TypeOf currentRow Is GridViewDataRowInfo Then

                    list.Add(currentRow)
				End If

				For Each row As GridViewRowInfo In currentRow.ChildRows
					queue.Enqueue(row)
				Next row
            Loop

            Return list
		End Function

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(GridGroupContentCellElement)
			End Get
        End Property

    End Class

	Public Class SummaryCellElement
		Inherits LightVisualElement
		Private columnName_Renamed As String

		Public Property ColumnName() As String
			Get
				Return Me.columnName_Renamed
			End Get
			Set
				Me.columnName_Renamed = Value
			End Set
		End Property
	End Class
End Namespace
