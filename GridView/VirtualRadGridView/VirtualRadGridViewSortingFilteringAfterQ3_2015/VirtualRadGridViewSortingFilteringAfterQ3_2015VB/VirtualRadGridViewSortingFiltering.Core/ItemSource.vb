
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Data.Expressions
Imports Telerik.WinControls.Data
Imports System.Linq
Imports System.Collections.Concurrent
Imports System.Threading.Tasks
Imports Telerik.WinControls.UI
Imports Telerik.Collections.Generic

Namespace VirtualRadGridViewSortingFiltering.Core
    <Flags> _
    Public Enum ItemSourceOperation
        None = 0
        Filtering = 1
        Sorting = Filtering << 1
    End Enum

    Public Class ItemSourceOperationEventArgs
        Inherits EventArgs
        Public Property OperationType() As ItemSourceOperation
            Get
                Return m_OperationType
            End Get
            Private Set(value As ItemSourceOperation)
                m_OperationType = Value
            End Set
        End Property
        Private m_OperationType As ItemSourceOperation

        Public Sub New(operation As ItemSourceOperation)
            Me.OperationType = operation
        End Sub
    End Class

    Public Class ItemSourceOperationCompletedEventArgs
        Inherits ItemSourceOperationEventArgs
        Public Property Canceled() As Boolean
            Get
                Return m_Canceled
            End Get
            Private Set(value As Boolean)
                m_Canceled = Value
            End Set
        End Property
        Private m_Canceled As Boolean

        Public Sub New(operation As ItemSourceOperation, canceled As Boolean)
            MyBase.New(operation)
            Me.Canceled = canceled
        End Sub
    End Class

    Public Class OperationParameters
        Public Property Operation() As ItemSourceOperation
            Get
                Return m_Operation
            End Get
            Private Set(value As ItemSourceOperation)
                m_Operation = Value
            End Set
        End Property
        Private m_Operation As ItemSourceOperation
        Public Property Descriptors() As IList
            Get
                Return m_Descriptors
            End Get
            Private Set(value As IList)
                m_Descriptors = Value
            End Set
        End Property
        Private m_Descriptors As IList

        Public Sub New(operation As ItemSourceOperation, descriptors As IList)
            Me.Operation = operation
            Me.Descriptors = descriptors
        End Sub
    End Class

    Public Class ItemSource
        Implements IDisposable
        Private m_dataSource As IList
        Private m_view As IList
        Private m_boundProperties As PropertyDescriptorCollection
        Private queuedOperations As ConcurrentQueue(Of OperationParameters)
        Private m_backgroundWorker As BackgroundWorker
        Private masterTemplate As VirtualMasterGridViewTemplate
        Private m_perform As Boolean
        Private lastFilterExpression As String
        Private lastSortExpression As String

        Public Sub New(masterTemplate As VirtualMasterGridViewTemplate)
            Me.m_backgroundWorker = New BackgroundWorker()
            Me.m_backgroundWorker.WorkerReportsProgress = True
            Me.m_backgroundWorker.WorkerSupportsCancellation = True
            AddHandler Me.m_backgroundWorker.DoWork, AddressOf BgWorkerDoWork
            AddHandler Me.m_backgroundWorker.ProgressChanged, AddressOf BgWorkerProgressChanged
            AddHandler Me.m_backgroundWorker.RunWorkerCompleted, AddressOf BgWorkerRunWorkerCompleted

            Me.queuedOperations = New ConcurrentQueue(Of OperationParameters)()
            Me.masterTemplate = masterTemplate
        End Sub

        Protected ReadOnly Property BackgroundWorker() As BackgroundWorker
            Get
                Return Me.m_backgroundWorker
            End Get
        End Property

        Public ReadOnly Property Perform() As Boolean
            Get
                Return Me.m_perform
            End Get
        End Property

        Public Property CurrentOperation() As ItemSourceOperation
            Get
                Return m_CurrentOperation
            End Get
            Private Set(value As ItemSourceOperation)
                m_CurrentOperation = Value
            End Set
        End Property
        Private m_CurrentOperation As ItemSourceOperation

        Public Property DataSource() As Object
            Get
                Return Me.m_dataSource
            End Get
            Set(value As Object)
                If value Is Nothing Then
                    Me.m_dataSource = InlineAssignHelper(Me.m_view, Nothing)
                    Return
                End If

                Dim dsList As IList = TryCast(ListBindingHelper.GetList(value), IList)
                If dsList Is Nothing OrElse Object.Equals(Me.m_dataSource, dsList) Then
                    Return
                End If

                Me.m_dataSource = InlineAssignHelper(Me.m_view, dsList)
                Me.m_boundProperties = Nothing
            End Set
        End Property

        Public ReadOnly Property View() As IList
            Get
                Return Me.m_view
            End Get
        End Property

        Default Public ReadOnly Property Item(index As Integer) As Object
            Get
                Return Me.m_view(index)
            End Get
        End Property

        Public ReadOnly Property BoundProperties() As PropertyDescriptorCollection
            Get
                If Me.m_dataSource Is Nothing OrElse Me.m_dataSource.Count = 0 Then
                    Return New PropertyDescriptorCollection(Nothing)
                End If

                If m_boundProperties Is Nothing Then
                    m_boundProperties = ListBindingHelper.GetListItemProperties(Me.m_dataSource)
                End If

                Return m_boundProperties
            End Get
        End Property

        Public ReadOnly Property Count() As Integer
            Get
                If Me.m_view Is Nothing Then
                    Return 0
                End If

                Return Me.m_view.Count
            End Get
        End Property

        Public Overridable Function SetValue(entry As Object, index As Integer, value As Object) As Boolean
            If Not Me.BoundProperties(index).IsReadOnly Then
                Me.BoundProperties(index).SetValue(entry, value)
                Return True
            End If

            Return False
        End Function

        Public Overridable Function SetValue(entry As Object, member As String, value As Object) As Boolean
            If Not Me.BoundProperties(member).IsReadOnly Then
                Me.BoundProperties(member).SetValue(entry, value)
                Return True
            End If

            Return False
        End Function

        Public Overridable Function GetValue(entry As Object, index As Integer) As Object
            Return Me.BoundProperties(index).GetValue(entry)
        End Function

        Public Overridable Function GetValue(entry As Object, member As String) As Object
            Return Me.BoundProperties(member).GetValue(entry)
        End Function

        Protected Overridable Sub BgWorkerRunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
            If Me.queuedOperations.Count > 0 Then
                Me.m_perform = True
                Me.m_backgroundWorker.RunWorkerAsync()
            End If

            Me.OnOperationCompleted(DirectCast(e.Result, ItemSourceOperationCompletedEventArgs))
        End Sub

        Protected Overridable Sub BgWorkerProgressChanged(sender As Object, e As ProgressChangedEventArgs)
            Me.OnOperationStarted(New ItemSourceOperationEventArgs(CType(e.UserState, ItemSourceOperation)))
        End Sub

        Protected Overridable Sub BgWorkerDoWork(sender As Object, e As DoWorkEventArgs)
            Dim operations As ItemSourceOperation = Nothing
            While Me.queuedOperations.Count > 0 AndAlso Me.m_perform
                Dim currentParams As OperationParameters
                If Not Me.queuedOperations.TryDequeue(currentParams) Then
                    System.Threading.Thread.Sleep(100)
                    Continue While
                End If

                Me.m_backgroundWorker.ReportProgress(0, currentParams.Operation)
                Select Case currentParams.Operation
                    Case ItemSourceOperation.Filtering
                        Me.Filter(TryCast(currentParams.Descriptors, FilterDescriptorCollection))
                        Exit Select
                    Case ItemSourceOperation.Sorting
                        Me.Sort(TryCast(currentParams.Descriptors, SortDescriptorCollection))
                        Exit Select
                    Case Else
                        Exit Select
                End Select

                operations = operations Or currentParams.Operation
            End While

            e.Result = New ItemSourceOperationCompletedEventArgs(operations, Not Me.m_perform)
        End Sub

        Public Sub PerformOperation(operation As ItemSourceOperation, descriptors As IList, Optional force As Boolean = False)
            Select Case operation
                Case ItemSourceOperation.Filtering
                    Dim filterDescriptors As FilterDescriptorCollection = TryCast(descriptors, FilterDescriptorCollection)
                    If Me.lastFilterExpression = filterDescriptors.Expression AndAlso Not force Then
                        Return
                    End If

                    Me.lastFilterExpression = filterDescriptors.Expression
                    Exit Select
                Case ItemSourceOperation.Sorting
                    Dim sortDescriptors As SortDescriptorCollection = TryCast(descriptors, SortDescriptorCollection)
                    If Me.lastSortExpression = sortDescriptors.Expression AndAlso Not force Then
                        Return
                    End If

                    Me.lastSortExpression = sortDescriptors.Expression
                    Exit Select
                Case Else
                    Exit Select
            End Select

            Dim operationParams As New OperationParameters(operation, descriptors)
            Me.queuedOperations.Enqueue(operationParams)
            If Me.m_backgroundWorker.IsBusy Then
                Dim peek As OperationParameters
                Dim peeked As Boolean = Me.queuedOperations.TryPeek(peek)
                If peeked AndAlso peek.Operation = operationParams.Operation AndAlso peek IsNot operationParams Then
                    Dim dequeued As OperationParameters
                    Me.queuedOperations.TryDequeue(dequeued)
                ElseIf peeked AndAlso peek.Operation <> operationParams.Operation Then
                    Me.m_perform = False
                End If
            End If

            If Not Me.m_backgroundWorker.IsBusy Then
                Me.m_perform = True
                Me.m_backgroundWorker.RunWorkerAsync()
                Me.OnOperationStarted(New ItemSourceOperationEventArgs(operationParams.Operation))
            End If
        End Sub

        Protected Overridable Sub Sort(descriptors As SortDescriptorCollection)
            Dim currentDescriptors As SortDescriptor() = descriptors.ToArray()
            If Me.CurrentOperation <> ItemSourceOperation.None Then
                Return
            End If

            If currentDescriptors.Length = 0 Then

                Me.m_view = m_dataSource
                Me.Filter(Me.masterTemplate.FilterDescriptors)

                Return
            End If


            Me.CurrentOperation = ItemSourceOperation.Sorting
            Dim sortView As List(Of Object) = TryCast(Me.m_view, List(Of Object))

            If sortView Is Nothing Then
                sortView = New List(Of Object)()
                For Each item As Object In Me.m_view
                    sortView.Add(item)
                Next
            End If

            Dim query As ParallelQuery(Of Object) = sortView.AsParallel()

            Dim firstDescriptor As SortDescriptor = currentDescriptors.First()
            If firstDescriptor.Direction = ListSortDirection.Descending Then
                query = query.OrderByDescending(Function(x) Me.GetValue(x, firstDescriptor.PropertyName))
            Else
                query = query.OrderBy(Function(x) Me.GetValue(x, firstDescriptor.PropertyName))
            End If

            Dim orderedQuery As OrderedParallelQuery(Of Object) = TryCast(query, OrderedParallelQuery(Of Object))
            For i As Integer = 1 To currentDescriptors.Length - 1
                Dim currentDescriptor As SortDescriptor = currentDescriptors(i)
                If currentDescriptor.Direction = ListSortDirection.Descending Then
                    orderedQuery = orderedQuery.ThenByDescending(Function(x) Me.GetValue(x, currentDescriptor.PropertyName))
                Else
                    orderedQuery = orderedQuery.ThenBy(Function(x) Me.GetValue(x, currentDescriptor.PropertyName))
                End If
            Next

            Me.m_view = orderedQuery.ToList()
            Me.CurrentOperation = ItemSourceOperation.None
        End Sub

        Protected Overridable Sub Filter(descriptors As FilterDescriptorCollection)
            Dim currentDescriptors As FilterDescriptor() = descriptors.ToArray()
            Dim node As ExpressionNode = ExpressionParser.Parse(descriptors.Expression, Me.masterTemplate.CaseSensitive)

            If Me.CurrentOperation <> ItemSourceOperation.None OrElse node Is Nothing OrElse currentDescriptors.Length = 0 Then
                Me.m_view = Me.m_dataSource
                Me.CurrentOperation = ItemSourceOperation.None
                Return
            End If

            Me.CurrentOperation = ItemSourceOperation.Filtering
            Dim newView As New List(Of Object)()
            Dim filteredView As IList = Me.m_dataSource

            For i As Integer = 0 To filteredView.Count - 1
                If Not Me.m_perform Then
                    Me.CurrentOperation = ItemSourceOperation.None
                    Return
                End If

                Dim entry As Object = filteredView(i)
                Dim context As New ExpressionContext()

                For j As Integer = 0 To currentDescriptors.Length - 1
                    Dim member As String = currentDescriptors(j).PropertyName
                    If Not context.ContainsKey(member) Then
                        context.Add(member, Me.GetValue(entry, member))
                    Else
                        context(member) = Me.GetValue(entry, member)
                    End If
                Next

                Dim evalResult As Object = node.Eval(Nothing, context)

                If TypeOf evalResult Is Boolean AndAlso CBool(evalResult) Then
                    newView.Add(entry)
                End If
            Next

            Me.m_view = newView
            Me.CurrentOperation = ItemSourceOperation.None
        End Sub

        Public Overloads Sub Dispose() Implements IDisposable.Dispose
            Me.m_backgroundWorker.CancelAsync()
            RemoveHandler Me.m_backgroundWorker.DoWork, AddressOf BgWorkerDoWork
            RemoveHandler Me.m_backgroundWorker.ProgressChanged, AddressOf BgWorkerProgressChanged
            RemoveHandler Me.m_backgroundWorker.RunWorkerCompleted, AddressOf BgWorkerRunWorkerCompleted
            Me.m_backgroundWorker = Nothing
        End Sub

        Public Event OperationCompleted As EventHandler(Of ItemSourceOperationCompletedEventArgs)
        Public Event OperationStarted As EventHandler(Of ItemSourceOperationEventArgs)

        Protected Overridable Sub OnOperationCompleted(args As ItemSourceOperationCompletedEventArgs)
            RaiseEvent OperationCompleted(Me, args)
        End Sub

        Protected Overridable Sub OnOperationStarted(args As ItemSourceOperationEventArgs)
            RaiseEvent OperationStarted(Me, args)
        End Sub

        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function

    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
