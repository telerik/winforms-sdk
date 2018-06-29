Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace _1151916
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Public Sub New()
			InitializeComponent()
			AddHandler radGridView1.CreateRow, AddressOf radGridView1_CreateRow
			radGridView1.DataSource = GetTable()
			radGridView1.AutoSizeRows = True
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			For Each item In radGridView1.Columns
				item.WrapText = True
			Next item

			radGridView1.CachedHeight.Clear()
			radGridView1.TableElement.ScrollToRow(500)
		End Sub
		Private Sub radGridView1_CreateRow(ByVal sender As Object, ByVal e As GridViewCreateRowEventArgs)
			If e.RowType Is GetType(GridDataRowElement) Then
				e.RowType = GetType(CustomRowElement)
			End If
		End Sub
		Private Shared rnd As New Random()
		Private Shared Function GetTable() As DataTable
			Dim table As New DataTable()
			Dim values(29) As String

			For i As Integer = 0 To 29
				table.Columns.Add("Column " & i)
				values(i) = New String("*"c, rnd.Next(20))
			Next i


			For i As Integer = 0 To 99
				values(0) = "Row " & i
				values(1) = New String("*"c, rnd.Next(50))
				table.Rows.Add(values)

			Next i

			Return table
		End Function
		Protected Overrides Sub OnShown(ByVal e As EventArgs)
			MyBase.OnShown(e)


		End Sub
	End Class
	Friend Class MyGrid
		Inherits RadGridView
        Private cachedHeightDict As New Dictionary(Of GridViewRowInfo, Integer)()

        Public ReadOnly Property CachedHeight As Dictionary(Of GridViewRowInfo, Integer)

            Get
                Return cachedHeightDict
            End Get
        End Property
	End Class
	Public Class CustomRowElement
		Inherits GridDataRowElement

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(GridDataRowElement)
			End Get
		End Property
		Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
			Dim cachedHeight = DirectCast(Me.GridControl, MyGrid).CachedHeight

			Dim baseSize As SizeF = MyBase.MeasureOverride(availableSize)

            Dim borderThickness_ As Padding = GetBorderThickness(False)

			If cachedHeight.ContainsKey(Me.RowInfo) Then
				Return New SizeF(baseSize.Width, cachedHeight(Me.RowInfo))
			End If


			Dim provider As New CellElementProvider(Me.TableElement)

            Dim desiredSize_ As SizeF = SizeF.Empty

            For Each column As GridViewColumn In Me.ViewTemplate.Columns
                If Not Me.IsColumnVisible(column) Then
                    Continue For
                End If
                Dim cellElement As GridDataCellElement = TryCast(provider.GetElement(column, Me), GridDataCellElement)
                Me.Children.Add(cellElement)
                If cellElement IsNot Nothing Then
                    cellElement.Measure(New SizeF(column.Width, Single.PositiveInfinity))
                    If desiredSize_.Height < cellElement.DesiredSize.Height Then
                        desiredSize_.Height = cellElement.DesiredSize.Height
                    End If
                End If
                cellElement.Detach()
                Me.Children.Remove(cellElement)
            Next column
            Dim elementSize As SizeF = Me.TableElement.RowScroller.ElementProvider.GetElementSize(Me.RowInfo)
            Dim oldHeight As Integer = If(RowInfo.Height = -1, CInt(elementSize.Height), RowInfo.Height)
            Me.RowInfo.SuspendPropertyNotifications()

            Dim newHeight = Math.Min(Me.RowInfo.Height, CInt(desiredSize_.Height))
            Me.RowInfo.Height = Math.Max(CInt(desiredSize_.Height), Math.Max(newHeight, Math.Max(Me.RowInfo.MinHeight, 24)))
            Me.RowInfo.Height = CInt(desiredSize_.Height)

			If Not cachedHeight.ContainsKey(Me.RowInfo) Then
				cachedHeight.Add(Me.RowInfo, Me.RowInfo.Height)
			End If

			Me.RowInfo.ResumePropertyNotifications()

			If Not Me.RowInfo.IsPinned Then
				Dim delta As Integer = RowInfo.Height - oldHeight
				TableElement.RowScroller.UpdateScrollRange(TableElement.RowScroller.Scrollbar.Maximum + delta, False)
			End If
			baseSize.Height = Me.RowInfo.Height
			Return baseSize
		End Function
		Private Function IsColumnVisible(ByVal column As GridViewColumn) As Boolean
			Return column.IsVisible
		End Function
	End Class
End Namespace
