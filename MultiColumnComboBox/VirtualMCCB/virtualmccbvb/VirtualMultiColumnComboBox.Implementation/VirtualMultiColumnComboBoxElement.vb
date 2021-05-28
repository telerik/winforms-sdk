Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Threading
Imports System.Windows.Forms
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports TrieImplementation

Namespace VirtualMultiColumnComboBox.Implementation
	Public Delegate Sub InvokeDelegate()
	Public Delegate Sub SearchCompletedEventHandler(ByVal sender As Object, ByVal e As SearchCompletedEventArgs)
	Public Delegate Sub SearchStartingEventHandler(ByVal sender As Object, ByVal e As SearchStartingEventArgs)
	Public Delegate Sub EditorControlCellValueNeededEventHandler(ByVal sender As Object, ByVal e As EditorControlCellValueNeededEventArgs)

	Public Class VirtualMultiColumnComboBoxElement
		Inherits RadMultiColumnComboBoxElement
		#Region "Fields"
		Private trie As Trie
		Private actualDataSource_Renamed As Dictionary(Of String, List(Of Object))
		Private virtualDataSource As Object
		Private currencyManager As CurrencyManager
		Private bindingContext As Object
		Private updatedVersion As Integer
		Private setCurrentStateMethod As MethodInfo
		Private loadDatasourceAsync_Renamed As Boolean
		Private enqueuedSearchText As String
		Private enqueuedSearchType As SearchType
		Private startSearchInterval_Renamed As Integer = 100
		Private autoShowHidePopup_Renamed As Boolean

        Private m_ignoreCase As Boolean = True
		Private valueMember_Renamed As String = ""
		Private valueObjectPropertyName As String
		Private dataSourceInitialized As Boolean
		Private searchType_Renamed As SearchType = SearchType.Contains
		Private searching As Boolean
		Private dataSourceInitializing As Boolean

		Private typeProperties As Dictionary(Of String, PropertyDescriptor)
		#End Region

#Region "Properties"

        Public Property IgnoreCase As Boolean
            Get
                Return Me.m_ignoreCase
            End Get
            Set(value As Boolean)
                Me.m_ignoreCase = value
                Me.ResetAllVitalFields()
                If (Not (Me.virtualDataSource Is Nothing)) Then
                    Me.InitializeDataSource()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or Sets the type of the search. Can be Contains or StartsWith
        ''' </summary>
        Public Property SearchType() As SearchType
            Get
                Return Me.searchType_Renamed
            End Get
            Set(value As SearchType)
                Me.searchType_Renamed = Value
            End Set
        End Property

        ''' <summary>
        ''' Gets or Sets the Virtual Data Source. The Virtual Data Source contains the Data after the filtering operation.
        ''' It can also be used to set the Data Source initially
        ''' </summary>
        Public Overrides Property DataSource() As Object
            Get
                Return Me.virtualDataSource
            End Get
            Set(value As Object)
                If Value Is Nothing Then
                    Throw New ArgumentNullException("The Virtual Data Source can not be null")
                End If

                If Me.virtualDataSource Is Value Then
                    Return
                End If

                Me.virtualDataSource = Value
                Me.InitializeDataSource()
            End Set
        End Property

        ''' <summary>
        ''' Gets the original data from the DataSource. The Key equals the ValueMember property.
        ''' </summary>
        Public ReadOnly Property ActualDataSource() As Dictionary(Of String, List(Of Object))
            Get
                Return Me.actualDataSource_Renamed
            End Get
        End Property

        ''' <summary>
        ''' Gets or Sets the ValueMember. It defines what property will be used by the filtering operation.
        ''' If null or empty the ToString() method will be used
        ''' </summary>
        Public Overrides Property ValueMember() As String
            Get
                Return Me.valueMember_Renamed
            End Get
            Set(value As String)
                If Value Is Nothing Then
                    Throw New ArgumentNullException("The value member can not be null")
                End If

                If Me.valueMember_Renamed = Value Then
                    Return
                End If

                Me.valueMember_Renamed = Value
                Dim allProperties As String() = Value.Split("."c)
                Me.valueObjectPropertyName = allProperties(allProperties.Length - 1)
                If Me.dataSourceInitialized Then
                    Me.InitializeDataSourceCore()
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets the value which indicates if the events are suspended
        ''' </summary>
        Public ReadOnly Property IsSuspended() As Boolean
            Get
                Return Me.updatedVersion > 0
            End Get
        End Property

        ''' <summary>
        ''' Gets or Sets the value which indicates whether the DataSource will be loaded
        ''' in another thread in the background. The <see cref="DataSourceLoaded"/> event is
        ''' fired when the DataSource is completely loaded
        ''' </summary>
        Public Property LoadDataSourceAsync() As Boolean
            Get
                Return Me.loadDatasourceAsync_Renamed
            End Get
            Set(value As Boolean)
                Me.loadDatasourceAsync_Renamed = Value
            End Set
        End Property

        ''' <summary>
        ''' Gets or Sets the value which indicates after how many milliseconds after
        ''' a key press a search will be made
        ''' </summary>
        Public Property StartSearchInterval() As Integer
            Get
                Return Me.startSearchInterval_Renamed
            End Get
            Set(value As Integer)
                If Value < 0 Then
                    Throw New ArgumentException("The value can not be null")
                End If

                Me.startSearchInterval_Renamed = Value
            End Set
        End Property

        ''' <summary>
        ''' Gets or Sets the value which indicates if the GridViewPopup will be automatically
        ''' shown/closed during search operations
        ''' </summary>
        Public Property AutoShowHidePopup() As Boolean
            Get
                Return Me.autoShowHidePopup_Renamed
            End Get
            Set(value As Boolean)
                Me.autoShowHidePopup_Renamed = Value
            End Set
        End Property

        ''' <summary>
        ''' Gets or Sets the text of the MulticolumnComboBox
        ''' </summary>
        Public Overrides Property Text() As String
            Get
                Return Me.textBox.Text
            End Get
            Set(value As String)
                Me.textBox.Text = Value
                Me.SetValue(RadMultiColumnComboBoxElement.TextProperty, Value)
            End Set
        End Property


#End Region

		#Region "Initialization"
		''' <summary>
		''' Used to Initialize all important fields and some event handlers
		''' </summary>
		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()
			Me.trie = New Trie(Me.ignoreCase)
			Me.actualDataSource_Renamed = New Dictionary(Of String, List(Of Object))(StringComparer.OrdinalIgnoreCase) 'todo case insensitive
			Me.typeProperties = New Dictionary(Of String, PropertyDescriptor)()
			Me.DropDownHeight = 250
		End Sub

		#Region "MethodsWhichShouldNotCallBase"
		Protected Overrides Sub CheckForCompleteMatchAndUpdateText()
		End Sub

		Public Overrides Sub ProcessReturnKey(ByVal e As KeyEventArgs)
		End Sub

		Protected Overrides Sub ProcessPopupTabKey(ByVal e As KeyEventArgs)
		End Sub
		#End Region
		''' <summary>
		''' Initializes the Virtual Data Source.
		''' </summary>


        Private Sub InitializeDataSource()
            Me.dataSourceInitializing = True
            'Reinitialize all important fields if the Data Source has already been initialized.
            If Me.dataSourceInitialized Then
                Me.ResetAllVitalFields()
            End If

            'starts a new thread to load the datasource if specified.
            If Me.LoadDataSourceAsync Then
                Dim loadDataSourceThread As New Thread(Sub() Me.InitializeDataSourceCore())
                loadDataSourceThread.IsBackground = True
                loadDataSourceThread.Start()
            Else
                Me.InitializeDataSourceCore()
            End If
        End Sub

       Protected Overridable Sub InitializeDataSourceCore()
    'Add a data binding in order to use the data with a CurrencyManager later
    Dim tempDataSource As New List(Of Object)()
    Me.EditorControl.BindingContext = If(Me.EditorControl.BindingContext, New BindingContext())

    Dim collectionChangedObject As INotifyCollectionChanged = TryCast(Me.virtualDataSource, INotifyCollectionChanged)
    If collectionChangedObject IsNot Nothing Then
        AddHandler collectionChangedObject.CollectionChanged, AddressOf CollectionChangedObject_CollectionChanged
    End If

    'Iterate all items in the Data Source with the currency manager and set up the Trie.
    'Will use the ToString method of the object if no ValueMember is supplied

    Me.currencyManager = DirectCast(Me.EditorControl.BindingContext(Me.virtualDataSource), CurrencyManager)
    If Me.currencyManager.List.Count = 0 Then
        Return
    End If

    Me.bindingContext = Me.EditorControl.BindingContext(Me.virtualDataSource, Me.valueMember)
    Dim position As Integer = 0
    Me.currencyManager.Position = position
    If Not String.IsNullOrEmpty(Me.valueMember) Then
        While position < currencyManager.Count - 1
            If Me.EditorControl Is Nothing Then
                Return
            End If

            Dim current As Object = Me.currencyManager.List(System.Math.Max(System.Threading.Interlocked.Increment(position),position - 1))
            Dim key As String = Me.GetProperty(Me.valueMember, current) & ""
            Dim obj As Object = current
            AddItemToDataSource(key, obj)
            tempDataSource.Add(current)
        End While
    Else
        For Each item As Object In currencyManager.List
            Dim key As String = item.ToString()
            Me.AddItemToDataSource(key, item)
            tempDataSource.Add(item)
        Next
    End If

    'Get the properties of the current object in order to build the columns of the grid
    If Me.EditorControl.InvokeRequired Then
        Me.EditorControl.Invoke(New InvokeDelegate(Function() 
        AddDataSource(tempDataSource)
        Me.EditorControl.RowCount = tempDataSource.Count

End Function))
    Else
        AddDataSource(tempDataSource)
        Me.EditorControl.RowCount = tempDataSource.Count
    End If
End Sub

Private cache As New Dictionary(Of String, PropertyInfo)()
Private Function GetProperty([property] As String, obj As Object) As Object
    Dim splittedProps As String() = [property].Split("."C)
    Dim currentObj As Object = obj

    For i As Integer = 0 To splittedProps.Length - 1
        Dim objType As Type = currentObj.[GetType]()
        Dim key As String = objType.FullName + ";" + splittedProps(i)
        If Not cache.ContainsKey(key) Then
            cache(key) = objType.GetProperty(splittedProps(i))
        End If

        Dim prop As PropertyInfo = cache(key)
        If prop Is Nothing Then
            Return Nothing
        End If

        currentObj = prop.GetValue(currentObj, Nothing)
    Next

    Return currentObj
End Function

        Private Sub AddDataSource(tempDataSource As List(Of Object))
            Me.CacheProperties()
            Me.GenerateGridColumns()

            'replace the original data source with a List<object> which will enable us to easily modify it.
            'Also mark the data source as completely initialized
            Me.virtualDataSource = tempDataSource
            Me.dataSourceInitialized = True
            Me.dataSourceInitializing = False
            Me.OnDataSourceLoaded()
        End Sub


        ''' <summary>
        ''' Adds an item to the <see cref="ActualDataSource"/> and the <see cref="Trie"/>.
        ''' </summary>
        ''' <param name="key">The search key</param>
        ''' <param name="obj">The actual object</param>
        Private Sub AddItemToDataSource(ByVal key As String, ByVal obj As Object)
            Me.trie.Insert(key)
            Me.AddItemToAccessItems(key, obj)
        End Sub

        Private Sub RemoveitemFromDataSource(ByVal key As String, ByVal obj As Object)
            Me.trie.RemovedWords.Add(key)
            If Me.ActualDataSource.ContainsKey(key) Then
                For Each item As Object In Me.actualDataSource_Renamed(key).ToArray()
                    If item.Equals(obj) Then
                        Me.actualDataSource_Renamed(key).Remove(item)
                    End If
                Next item
            End If
        End Sub

        ''' <summary>
        ''' Fired when the colllection changes, in case it is an <see cref="INotifyCollectionChanged"/>
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CollectionChangedObject_CollectionChanged(sender As Object, e As NotifyCollectionChangedEventArgs)
            If e.Action = NotifyCollectionChangedAction.Add Then
                For Each item As Object In e.NewItems
                    Me.currencyManager.Position = Me.currencyManager.List.Count - 1

                    Dim propManager As PropertyManager = DirectCast(Me.bindingContext, PropertyManager)
                    Dim key As String = propManager.Current.ToString()
                    Dim obj As Object = currencyManager.Current
                    Me.AddItemToDataSource(key, obj)
                Next
            ElseIf e.Action = NotifyCollectionChangedAction.Remove Then
                For Each item As Object In e.NewItems
                    Dim manager As CurrencyManager = DirectCast(Me.EditorControl.BindingContext(e.NewItems), CurrencyManager)
                    Dim propManager As PropertyManager = DirectCast(Me.EditorControl.BindingContext(e.NewItems, Me.ValueMember), PropertyManager)
                    Dim key As String = propManager.Current.ToString()
                    Dim obj As Object = manager.Current
                    Me.RemoveitemFromDataSource(key, obj)
                    manager.Position += 1
                Next
            End If
        End Sub


		''' <summary>
		''' Saves the properties for later use
		''' </summary>
		Private Sub CacheProperties()
			Dim properties As PropertyDescriptorCollection = Me.currencyManager.GetItemProperties()
			For Each descriptor As PropertyDescriptor In properties
				Me.typeProperties(descriptor.Name) = descriptor
			Next descriptor
		End Sub

		''' <summary>
		''' Generates the Columns of the grid in case <see cref="AutoGenerateColumns"/> is set to true
		''' </summary>
		Private Sub GenerateGridColumns()
			'Get the properties of the current object in order to build the columns of the grid
			If Me.EditorControl.AutoGenerateColumns Then
				For Each prop As PropertyDescriptor In typeProperties.Values
					'if the property has its Browsable attribute set to false, no column will be generated
					If prop.IsBrowsable Then
						Dim column As GridViewDataColumn = Me.ParseColumnFromProperty(prop)
						If (Not Me.EditorControl.Columns.Contains(column.Name)) Then
							Me.EditorControl.Columns.Add(column)
						End If
					End If
				Next prop
			End If
		End Sub

		''' <summary>
		''' Gets the appropriate column from a property's type
		''' </summary>
		''' <param name="prop">The property used for parsing</param>
		''' <returns></returns>
		Private Function ParseColumnFromProperty(ByVal prop As PropertyDescriptor) As GridViewDataColumn
			If prop.PropertyType Is GetType(Int32) Then
				Return New GridViewDecimalColumn(prop.Name, prop.Name)
			ElseIf prop.PropertyType Is GetType(Boolean) Then
				Return New GridViewCheckBoxColumn(prop.Name, prop.Name)
			ElseIf prop.PropertyType Is GetType(Color) Then
				Return New GridViewColorColumn(prop.Name, prop.Name)
			ElseIf prop.PropertyType Is GetType(IEnumerable) OrElse prop.PropertyType Is GetType(ICollection) OrElse prop.PropertyType Is GetType(IList) Then
				Return New GridViewComboBoxColumn(prop.Name, prop.Name)
			ElseIf prop.PropertyType Is GetType(DateTime) Then
				Return New GridViewDateTimeColumn(prop.Name, prop.Name)
			ElseIf prop.PropertyType Is GetType(Image) Then
				Return New GridViewImageColumn(prop.Name, prop.Name)
			Else
				Return New GridViewTextBoxColumn(prop.Name, prop.Name)
			End If
		End Function

		''' <summary>
		''' Resets the important fields and data structures since it is better to reset
		''' them instead of clearing them. Also clears the columns of the grid
		''' </summary>
		Private Sub ResetAllVitalFields()
			Me.trie = New Trie(Me.ignoreCase)
			Me.actualDataSource_Renamed = New Dictionary(Of String, List(Of Object))()
			Me.EditorControl.Columns.Clear()
		End Sub

		''' <summary>
		''' Adds and object to the AllDataSource which enables us to easily access items by ValueMember
		''' with Constant time
		''' </summary>
		''' <param name="key">The ValueMember</param>
		''' <param name="value">The object from the datasource</param>
		Private Sub AddItemToAccessItems(ByVal key As String, ByVal value As Object)
			If (Not Me.actualDataSource_Renamed.ContainsKey(key)) Then
				Me.actualDataSource_Renamed(key) = New List(Of Object)()
			End If

			Me.actualDataSource_Renamed(key).Add(value)
		End Sub

		''' <summary>
		''' Wires all events which can be wired at this point and enables virtual mode of the grid
		''' </summary>
		Protected Overrides Sub WireEvents()
			 MyBase.WireEvents()
			Me.EditorControl.VirtualMode = True
			AddHandler Me.EditorControl.CellValueNeeded, AddressOf GridCellValueNeeded
		End Sub

		''' <summary>
		''' Processes a keyup event in the textbox
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
        Protected Overrides Sub ProcessTextKeyUp(sender As Object, e As KeyEventArgs)
            If Char.IsLetterOrDigit(CChar(ChrW(e.KeyCode))) OrElse e.KeyCode = Keys.Space OrElse e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Delete Then
                If Not Me.dataSourceInitializing Then
                    Me.SetCurrentState(PopupEditorState.Filtering)
                    Me.PerformSearchCore(Me.Text, TrieImplementation.SearchType.Contains)
                End If
            End If

            Me.ShowHidePopup(e)
        End Sub

		''' <summary>
		''' Shows or hides the popup based on certain conditions
		''' </summary>
		''' <param name="e"></param>
		Protected Overridable Sub ShowHidePopup(ByVal e As KeyEventArgs)
			If e.KeyCode = Keys.Back AndAlso String.IsNullOrEmpty(Me.Text) AndAlso Me.IsDroppedDown AndAlso Me.AutoShowHidePopup Then
				Me.ClosePopup()
            ElseIf (e.KeyCode <> Keys.Back OrElse e.KeyCode <> Keys.Delete OrElse (Not Char.IsLetterOrDigit(CChar(ChrW(e.KeyCode))))) AndAlso (Not Me.IsDropDownShown) AndAlso Me.AutoShowHidePopup Then
                Me.ShowPopup()
			End If
		End Sub

		''' <summary>
		''' Sets the grids current <see cref="PopupEditorState"/>. We are using <see cref="System.Reflection"/>
		''' since the method is private.
		''' </summary>
		''' <param name="state"></param>
		Protected Overridable Sub SetCurrentState(ByVal state As PopupEditorState)
			If Me.setCurrentStateMethod Is Nothing Then
				Me.setCurrentStateMethod = Me.GetType().BaseType.GetMethod("SetCurrentState", BindingFlags.NonPublic Or BindingFlags.Instance)
			End If

			Me.setCurrentStateMethod.Invoke(Me, New Object() { state })
		End Sub

		''' <summary>
		''' Unwires all events for safer disposal
		''' </summary>
		Protected Overrides Sub UnwireEvents()
			MyBase.UnwireEvents()
			RemoveHandler Me.EditorControl.CellValueNeeded, AddressOf GridCellValueNeeded
		End Sub
		#End Region

		#Region "Implementation"
		''' <summary>
		''' The exposed method which can be used to perform a search operation
		''' </summary>
		''' <param name="text">The text to search</param>
		Public Sub PerformSearch(ByVal text As String)
			Me.PerformSearch(text, TrieImplementation.SearchType.Contains)
		End Sub

		Public Sub PerformSearch(ByVal text As String, ByVal searchType_Renamed As SearchType)
			Me.PerformSearchCore(text, Me.SearchType)
		End Sub

		''' <summary>
		''' If too many search operations are requested in short period of time,
		''' the last is enqueued and when the previous search operation finishes,
		''' the enqueued one will be executed.
		''' </summary>
		Private Sub PerformNewSearchFromQueue()
			Dim newSearchText As String = Me.enqueuedSearchText
			Dim newSearchType As TrieImplementation.SearchType = Me.enqueuedSearchType
			Me.enqueuedSearchText = Nothing
			Me.PerformSearchCore(newSearchText, newSearchType)
		End Sub

		''' <summary>
		''' The core method which performs the search operation
		''' </summary>
		''' <param name="text">The text to search</param>
		Protected Overridable Sub PerformSearchCore(ByVal text As String, ByVal searchType_Renamed As SearchType)
			If (Not Me.OnSearchStarting(text)) Then
				Return
			End If

			If (Not Me.searching) Then
				Dim searchThread As Thread = Me.CreateSearchThread(searchType_Renamed, text)
				searchThread.IsBackground = True
				searchThread.Start()
			Else
				Me.enqueuedSearchType = searchType_Renamed
				Me.enqueuedSearchText = text
			End If

		End Sub

		''' <summary>
		''' Creates a <see cref="Thread"/> to perform search operations
		''' </summary>
		''' <param name="searchType">The <see cref="SearchType"/></param>
		''' <param name="text">The text to search</param>
		''' <returns></returns>
        Private Function CreateSearchThread(searchType As SearchType, text As String) As Thread
            Dim searchThread As New Thread(Sub()
                                               If Me.searching Then
                                                   Me.enqueuedSearchType = searchType
                                                   Me.enqueuedSearchText = text
                                                   Return
                                               End If

                                               Thread.Sleep(Me.StartSearchInterval)
                                               If Me.enqueuedSearchText IsNot Nothing Then
                                                   Me.PerformNewSearchFromQueue()
                                                   Return
                                               End If

                                               Me.searching = True
                                               Dim results As ICollection(Of String) = Me.trie.Search(Me.Text, searchType)

                                               If Not (TypeOf Me.virtualDataSource Is List(Of Object)) Then
                                                   Me.virtualDataSource = New List(Of Object)()
                                               End If

                                               Dim dataSource As List(Of Object) = TryCast(Me.virtualDataSource, List(Of Object))
                                               dataSource.Clear()
                                               For Each result As String In results
                                                   If Me.ActualDataSource.ContainsKey(result) Then
                                                       For Each item As Object In Me.ActualDataSource(result)
                                                           dataSource.Add(item)
                                                       Next
                                                   End If
                                               Next

                                               searching = False
                                               Me.EditorControl.Invoke(New InvokeDelegate(Function()
                                                                                              If Me.EditorControl.RowCount <> results.Count Then
                                                                                                  Me.EditorControl.RowCount = results.Count
                                                                                              End If

                                                                                              Me.SetCurrentState(PopupEditorState.Ready)
                                                                                              Me.OnSearchCompleted(text, results)

                                                                                          End Function))

                                           End Sub)

            Return searchThread
        End Function


		''' <summary>
		''' This event controls the displayed values using VirtualMode - http://www.telerik.com/help/winforms/gridview-virtual-mode.html
		''' </summary>
		Private Sub GridCellValueNeeded(ByVal sender As Object, ByVal e As GridViewCellValueEventArgs)
			Me.OnCellValueNeeded(e)
		End Sub

		''' <summary>
		''' Suspends all events from firing
		''' </summary>
		Public Overrides Sub BeginUpdate()
			MyBase.BeginUpdate()
			Me.updatedVersion += 1
		End Sub

		''' <summary>
		''' Resumes events from firing
		''' </summary>
		Public Overrides Sub EndUpdate()
			MyBase.EndUpdate()
			Me.updatedVersion -= 1
			If Me.updatedVersion < 0 Then
				Me.updatedVersion = 0
			End If
		End Sub

		#End Region

		#Region "Ctors"
		''' <summary>
		''' Initializes the VirtualMultiColumnComboBoxElement
		''' </summary>
		''' <param name="ignoreCase">Defines if the performed search operations will be case sensitive</param>
        Public Sub New()
            MyBase.New()
            Me.EditorControl.LoadElementTree()
        End Sub

		''' <summary>
		''' Needed for proper theming
		''' </summary>
		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(RadMultiColumnComboBoxElement)
			End Get
		End Property

		#End Region

		#Region "Events"
		''' <summary>
		''' Fired when the Search method is done searching
		''' </summary>
		Public Event SearchCompleted As SearchCompletedEventHandler
		Protected Overridable Sub OnSearchCompleted(ByVal text As String, ByVal results As IEnumerable(Of String))
			If Not Me.enqueuedSearchText Is Nothing Then
				Me.PerformNewSearchFromQueue()
			End If

			If Not Me.SearchCompletedEvent Is Nothing AndAlso (Not Me.IsSuspended) Then
				RaiseEvent SearchCompleted(Me, New SearchCompletedEventArgs(text, results))
			End If
		End Sub

		''' <summary>
		''' Fires before the searching has begun. Cancelable.
		''' </summary>
		Public Event SearchStarting As SearchStartingEventHandler
		Protected Overridable Function OnSearchStarting(ByVal text As String) As Boolean
			Dim e As SearchStartingEventArgs = New SearchStartingEventArgs(text)
			If Not Me.SearchStartingEvent Is Nothing AndAlso (Not Me.IsSuspended) Then
				RaiseEvent SearchStarting(Me, e)
			End If

			Return Not e.Cancel
		End Function


		''' <summary>
		''' Fired when value for a cell is needed. Also provides the datasource.
		''' </summary>
		Public Event EditorControlCellValueNeeded As EditorControlCellValueNeededEventHandler
		Protected Overridable Sub OnCellValueNeeded(ByVal e As GridViewCellValueEventArgs)
			If Me.IsSuspended Then
				Return
			End If

			Dim args As EditorControlCellValueNeededEventArgs = New EditorControlCellValueNeededEventArgs (e.ColumnIndex, e.RowIndex, CType(Me.virtualDataSource, List(Of Object)))

			If args.RowIndex < args.VirtualDataSource.Count AndAlso args.RowIndex <> -1 Then
				Dim currentObject As Object = args.VirtualDataSource(args.RowIndex)
				Dim columnName As String = Me.EditorControl.Columns(e.ColumnIndex).Name
				If Me.typeProperties.ContainsKey(columnName) Then
					args.Value = Me.typeProperties(columnName).GetValue(currentObject)
				End If
			End If

			If Not Me.EditorControlCellValueNeededEvent Is Nothing AndAlso args.VirtualDataSource.Count >= 0 AndAlso args.RowIndex <> -1 AndAlso args.VirtualDataSource.Count > args.RowIndex Then
				RaiseEvent EditorControlCellValueNeeded(Me, args)
			End If

			e.Value = args.Value
		End Sub

		''' <summary>
		''' Fired when the DataSource is completely loaded
		''' </summary>
		Public Event DataSourceLoaded As EventHandler
		Protected Overridable Sub OnDataSourceLoaded()
			If Not Me.DataSourceLoadedEvent Is Nothing Then
				RaiseEvent DataSourceLoaded(Me, EventArgs.Empty)
			End If
		End Sub
		#End Region
	End Class
End Namespace
