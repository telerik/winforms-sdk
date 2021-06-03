
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace VirtualRadGridViewSortingFiltering.Core
    Public Class VirtualRadGridView
        Inherits RadGridView
        Private m_loadingOverlay As RadWaitingBar

        Public ReadOnly Property ItemsSource() As ItemSource
            Get
                Return TryCast(Me.GridViewElement, VirtualRadGridViewElement).ItemsSource
            End Get
        End Property

        Public Property VirtualDataSource() As Object
            Get
                Return Me.ItemsSource.DataSource
            End Get
            Set(value As Object)
                Me.FilterDescriptors.Clear()
                Me.SortDescriptors.Clear()
                Me.GroupDescriptors.Clear()
                Me.ItemsSource.DataSource = value
                Me.Initialize()
            End Set
        End Property

        Public Property ShowLoadingOverlay() As Boolean
            Get
                Return m_ShowLoadingOverlay
            End Get
            Set(value As Boolean)
                m_ShowLoadingOverlay = Value
            End Set
        End Property
        Private m_ShowLoadingOverlay As Boolean

        Public Property AutomaticallyRetreiveCellValues() As Boolean
            Get
                Return m_AutomaticallyRetreiveCellValues
            End Get
            Set(value As Boolean)
                m_AutomaticallyRetreiveCellValues = Value
            End Set
        End Property
        Private m_AutomaticallyRetreiveCellValues As Boolean

        Public Property AutomaticallyPushCellValues() As Boolean
            Get
                Return m_AutomaticallyPushCellValues
            End Get
            Set(value As Boolean)
                m_AutomaticallyPushCellValues = Value
            End Set
        End Property
        Private m_AutomaticallyPushCellValues As Boolean

        Public ReadOnly Property LoadingOverlay() As RadWaitingBar
            Get
                Return Me.m_loadingOverlay
            End Get
        End Property

        Public Sub New()
            MyBase.New()
            Me.EnablePaging = True
            Me.EnableSorting = True
            Me.EnableFiltering = True
            Me.EnableGrouping = True
            Me.VirtualMode = True
            Me.AutomaticallyPushCellValues = True
            Me.AutomaticallyRetreiveCellValues = True
            Me.MasterTemplate.PagingBeforeGrouping = True
            Me.ShowLoadingOverlay = True

            Me.m_loadingOverlay = Me.CreateLoadingOverlay()
            Me.m_loadingOverlay.Parent = Me
            Me.m_loadingOverlay.Dock = DockStyle.None
            Me.m_loadingOverlay.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash
            Me.m_loadingOverlay.Visible = False
        End Sub

        Protected Overridable Function CreateLoadingOverlay() As RadWaitingBar
            Return New RadWaitingBar()
        End Function

        Protected Overrides Sub OnBindingContextChanged(e As EventArgs)
            MyBase.OnBindingContextChanged(e)
            Me.Initialize()
        End Sub

        Protected Overridable Sub Initialize()
            If Me.BindingContext Is Nothing Then
                Return
            End If

            If Me.RowCount = Me.ItemsSource.Count AndAlso Me.ColumnCount = Me.ItemsSource.BoundProperties.Count Then
                Return
            End If

            Me.InitializeRowsAndColumns()
        End Sub

        Protected Overridable Sub InitializeRowsAndColumns()
            If Not Me.IsLoaded OrElse Me.VirtualDataSource Is Nothing Then
                Return
            End If

            Me.BeginUpdate()
            Me.InitializeColumns()
            Me.InitializeRows()
            Me.EndUpdate()
        End Sub

        Protected Overridable Sub InitializeColumns()
            If Me.ColumnCount <> Me.ItemsSource.BoundProperties.Count Then
                Me.ColumnCount = Me.ItemsSource.BoundProperties.Count
                For i As Integer = 0 To Me.Columns.Count - 1
                    Dim prop As PropertyDescriptor = Me.ItemsSource.BoundProperties(i)
                    Dim newColumn As GridViewDataColumn = GridViewHelper.AutoGenerateGridColumn(prop.PropertyType, Nothing)
                    newColumn.HeaderText = prop.DisplayName
                    newColumn.Name = prop.Name

                    Me.Columns.RemoveAt(i)
                    Me.Columns.Insert(i, newColumn)
                Next
            End If
        End Sub

        Protected Overridable Sub InitializeRows()
            If Me.RowCount <> Me.ItemsSource.Count Then
                Me.RowCount = Me.ItemsSource.Count
            End If
        End Sub

        Protected Overrides Sub WireEvents()
            MyBase.WireEvents()

            AddHandler Me.SortChanged, AddressOf VirtualRadGridView_SortChanged
            AddHandler Me.FilterChanged, AddressOf VirtualRadGridView_FilterChanged
            AddHandler Me.CellEndEdit, AddressOf VirtualRadGridView_CellEndEdit
            AddHandler Me.ItemsSource.OperationCompleted, AddressOf ItemsSource_OperationCompleted
            AddHandler Me.ItemsSource.OperationStarted, AddressOf ItemsSource_OperationStarted
        End Sub

        Protected Overrides Sub UnWireEvents()
            MyBase.UnWireEvents()

            RemoveHandler Me.SortChanged, AddressOf VirtualRadGridView_SortChanged
            RemoveHandler Me.FilterChanged, AddressOf VirtualRadGridView_FilterChanged
            RemoveHandler Me.CellEndEdit, AddressOf VirtualRadGridView_CellEndEdit
            RemoveHandler Me.ItemsSource.OperationCompleted, AddressOf ItemsSource_OperationCompleted
            RemoveHandler Me.ItemsSource.OperationStarted, AddressOf ItemsSource_OperationStarted
        End Sub

        Protected Overrides Sub Dispose(disposing As Boolean)
            MyBase.Dispose(disposing)

            If disposing Then
                Me.ItemsSource.Dispose()
            End If
        End Sub

        Protected Overrides Function CreateGridViewElement() As RadGridViewElement
            Return New VirtualRadGridViewElement()
        End Function

        Protected Overrides Sub OnResize(e As EventArgs)
            MyBase.OnResize(e)
            If Me.m_loadingOverlay.Visible Then
                Me.PositionLoadingOverlay()
            End If
        End Sub

        Protected Overridable Sub PositionLoadingOverlay()
            Dim x As Integer = (Me.Width / 2) - (Me.m_loadingOverlay.Width / 2)
            Dim y As Integer = (Me.Height / 2) - (Me.m_loadingOverlay.Height / 2)
            Me.m_loadingOverlay.Location = New System.Drawing.Point(x, y)
        End Sub

        Protected Overridable Sub StartWaiting()
            If Not Me.ShowLoadingOverlay Then
                Return
            End If

            Me.PositionLoadingOverlay()

            Me.m_loadingOverlay.Visible = True
            Me.m_loadingOverlay.StartWaiting()
        End Sub

        Protected Overridable Sub StopWaiting()
            Me.m_loadingOverlay.StopWaiting()
            Me.m_loadingOverlay.Visible = False
        End Sub

        Private Sub ItemsSource_OperationStarted(sender As Object, e As ItemSourceOperationEventArgs)
            Me.StartWaiting()
        End Sub

        Private Sub ItemsSource_OperationCompleted(sender As Object, e As ItemSourceOperationCompletedEventArgs)
            If e.Canceled Then
                Me.StopWaiting()
                Return
            End If

            If (e.OperationType And ItemSourceOperation.Filtering) = ItemSourceOperation.Filtering Then
                Me.InitializeRowsAndColumns()
            End If

            If (e.OperationType And ItemSourceOperation.Sorting) = ItemSourceOperation.Sorting Then
                Me.MasterTemplate.DataView.Refresh()
            End If

            Me.StopWaiting()
        End Sub

        Private Sub VirtualRadGridView_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs)
            If Not Me.IsInEditMode Then
                Me.PerformFilter()
            End If
        End Sub

        Private Sub VirtualRadGridView_CellEndEdit(sender As Object, e As GridViewCellEventArgs)
            If TypeOf e.Row Is GridViewFilteringRowInfo Then
                Me.PerformFilter()
            End If

        End Sub

        Private Sub VirtualRadGridView_SortChanged(sender As Object, e As GridViewCollectionChangedEventArgs)
            Me.PerformSort()
        End Sub

        Protected Overridable Sub PerformFilter(Optional force As Boolean = False)
            Me.ItemsSource.PerformOperation(ItemSourceOperation.Filtering, Me.FilterDescriptors, force)
        End Sub

        Protected Overridable Sub PerformSort(Optional force As Boolean = False)
            Me.ItemsSource.PerformOperation(ItemSourceOperation.Sorting, Me.SortDescriptors, force)
        End Sub

        Protected Overrides Sub OnCellValueNeeded(sender As Object, e As GridViewCellValueEventArgs)
            If Not Me.AutomaticallyRetreiveCellValues Then
                MyBase.OnCellValueNeeded(sender, e)
                Return
            End If

            Dim args As New GridViewCellValueEventArgsEx(e, e.ColumnIndex, e.RowIndex)
            If Me.GroupDescriptors.Count = 0 Then
                Dim rowIndex As Integer = Me.GetRowIndexByPage(e.RowIndex)
                args.Value = Me.ItemsSource.GetValue(Me.ItemsSource(rowIndex), e.ColumnIndex)
            Else
                args.Value = Me.ItemsSource.GetValue(args.RowInfo.DataBoundItem, e.ColumnIndex)
            End If

            MyBase.OnCellValueNeeded(sender, args)
            e.Value = args.Value
        End Sub

        Protected Overrides Sub OnCellValuePushed(sender As Object, e As GridViewCellValueEventArgs)
            If Not Me.AutomaticallyPushCellValues Then
                MyBase.OnCellValuePushed(sender, e)
                Return
            End If

            Dim args As New GridViewCellValueEventArgsEx(e, e.ColumnIndex, e.RowIndex)
            If Me.GroupDescriptors.Count = 0 Then
                Dim rowIndex As Integer = Me.GetRowIndexByPage(e.RowIndex)
                Me.ItemsSource.SetValue(Me.ItemsSource(rowIndex), e.ColumnIndex, e.Value)
            Else
                Me.ItemsSource.SetValue(args.RowInfo.DataBoundItem, e.ColumnIndex, e.Value)
            End If

            MyBase.OnCellValuePushed(sender, args)
        End Sub

        Public Overridable Function GetRowIndexByPage(rowIndex As Integer) As Integer
            Dim newRowIndex As Integer = rowIndex
            If Me.MasterTemplate.PageIndex >= 1 Then
                newRowIndex = newRowIndex + (Me.MasterTemplate.PageSize * Me.MasterTemplate.PageIndex)
            End If

            Return newRowIndex
        End Function
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
