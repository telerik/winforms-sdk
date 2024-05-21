Imports Telerik.WinControls.UI

Public Class LoadOnDemandCellEditor
    Inherits RadMultiColumnComboBoxElement

    Private Const MinDropDownWidth As Integer = 320
    Private Const ShortNameWidth As Integer = 25
    Private Const GridOffset As Integer = 70
    Private Const TimerInterval = 425
    Private Const ItemInfoTableName As String = "ITEMS"

    Private _timer As System.Timers.Timer

    Private _showDropDown As Boolean
    Private Property ShowDropDown() As Boolean
        Get
            Return _showDropDown
        End Get
        Set(ByVal value As Boolean)
            'This property can be updated on a background thread, so we need to ensure thread-safety
            SyncLock Me
                _showDropDown = value
            End SyncLock
        End Set
    End Property

    Private _newItemsLoaded As Boolean
    Private Property NewItemsLoaded() As Boolean
        Get
            Return _newItemsLoaded
        End Get
        Set(ByVal value As Boolean)
            'This property can be updated on a background thread, so we need to ensure thread-safety
            SyncLock Me
                _newItemsLoaded = value
            End SyncLock
        End Set
    End Property

    Private _currentText As String = Nothing
    Private Property CurrentText() As String
        Get
            Return _currentText
        End Get
        Set(ByVal value As String)
            _currentText = value
        End Set
    End Property

    Public Sub New(ByVal text As Object, ByVal columnWidth As Integer, ByVal ownerGrid As RadGridView)
        MyBase.New()
        InitializeCellEditor(text, columnWidth, ownerGrid)
    End Sub

    'Initialize the cell editor (set properties and load matching data)
    Private Sub InitializeCellEditor(ByVal text As Object, ByVal columnWidth As Integer, ByVal ownerGrid As RadGridView)
        Dim grid As RadGridView

        If Not (TypeOf text Is DBNull) AndAlso Not String.IsNullOrEmpty(text) Then
            CurrentText = text.ToString
        End If

        With Me
            .DisplayMember = "COUNTRY"
            .ValueMember = "COUNTRY"
            .Virtualized = False

            'Make sure the drop down is at least minDropDownWidth
            If columnWidth > MinDropDownWidth Then
                .DropDownWidth = columnWidth
            Else
                .DropDownWidth = MinDropDownWidth
            End If

            grid = .EditorControl

            'Setup the grid that is displayed in the drop down list
            InitializeGrid(grid, Me.DropDownWidth)

            'Only load data if we have at least 3 characters
            If CurrentText IsNot Nothing AndAlso CurrentText.Length >= 3 Then

                GetMatchingItems_AsyncBegin(CurrentText, False)

                'Text of the combo gets cleared when the items are loaded, so make sure to set it here
                Me.TextBoxElement.Text = CurrentText

            End If

            'KeyUp and KeyDown events will allow us to load matching data on-demand
            AddHandler Me.KeyDown, AddressOf DropDown_KeyDown
            AddHandler Me.KeyUp, AddressOf DropDown_KeyUp

        End With

        InitializeTimer(ownerGrid)

    End Sub

    'Configure the grid that is displayed within the drop down list.
    Private Sub InitializeGrid(ByRef grid As RadGridView, ByVal gridWidth As Integer)
        Dim gridTextBoxColumn As GridViewTextBoxColumn

        'Set the grid to fill the drop down list
        grid.Width = gridWidth

        grid.AutoSizeRows = True
        grid.VirtualMode = False

        With grid.MasterTemplate

            .AutoGenerateColumns = False
            .ShowColumnHeaders = False
            .AllowColumnResize = False
            .AllowRowResize = False

            .Columns.Clear()

            gridTextBoxColumn = CreateGridTextBoxColumn("SHORTNAME", "SHORTNAME", "SHORTNAME")
            gridTextBoxColumn.Width = ShortNameWidth
            .Columns.Add(gridTextBoxColumn)

            gridTextBoxColumn = CreateGridTextBoxColumn("COUNTRY", "COUNTRY", "COUNTRY")

            'Set the column to fill the remaining space in the drop down
            gridTextBoxColumn.Width = gridWidth - ShortNameWidth - GridOffset
            gridTextBoxColumn.WrapText = True
            .Columns.Add(gridTextBoxColumn)

        End With

    End Sub

    'Initialize the Timer that is used to buffer the requests to the web service. So instead of firing 
    'off a request on every keystroke, we will build in a short wait to make sure the user is done typing. 
    Private Sub InitializeTimer(ByVal ownerGrid As RadGridView)

        _timer = New System.Timers.Timer
        _timer.Interval = TimerInterval

        'The GridViewMultiComboBoxElement does not implement the InvokeRequired property or Invoke() method. 
        'These are needed to update a control that was created on another thread. So we will need to 
        'synchronize the timer with the another control so that we can update the UI in the timers Elasped 
        'event handler, since the timer runs on a background thread. We can't access the grid that hosts this 
        'control from the control itself, so we us a reference to the grid that is passed in the constructor.
        _timer.SynchronizingObject() = ownerGrid

        AddHandler _timer.Elapsed, AddressOf Timer_Elapsed

    End Sub

    'Make an asynchronous call into the web service to get items that match the text that is passed in
    Private Sub GetMatchingItems_AsyncBegin(ByVal text As String, ByVal showDropDownFlag As Boolean)

        Using ws As New localhost.Service
            ShowDropDown = showDropDownFlag
            AddHandler ws.GetMatchingItemsCompleted, AddressOf GetMatchingItems_AsyncCompleted
            ws.GetMatchingItemsAsync(text)
        End Using

    End Sub

    'Asynchronous callback event handler for the GetMatchingItemsAsync call to the web service
    Private Sub GetMatchingItems_AsyncCompleted(ByVal sender As Object, ByVal e As localhost.GetMatchingItemsCompletedEventArgs)
        Dim grid As RadGridView
        Dim returnDataSet As DataSet
        Dim itemInfo As DataTable

        If e.Error IsNot Nothing OrElse e.Result Is Nothing Then
            'WS call errored out, or nothing was returned
            Exit Sub

        End If

        returnDataSet = CType(e.Result, DataSet)
        itemInfo = returnDataSet.Tables(ItemInfoTableName)

        grid = Me.EditorControl
        grid.DataSource = itemInfo

        If ShowDropDown Then
            Me.ShowPopup()
        End If

        NewItemsLoaded = True

    End Sub

    'Handles the KeyDown event for the drop down editor. 
    Private Sub DropDown_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs)

        'Store the current text so that we can tell if it has changed in the KeyUp event.
        CurrentText = Me.Text

        'If the down key was pressed, there are items loaded in the drop down and an item has not already 
        'been selected, then force the selection. This is to workaround an issue where pressing the down
        'key would not force focus to the grid (allowing the user to scroll through the items).       
        If e.KeyCode = Keys.Down Then

            If Me.EditorControl.Rows.Count > 0 AndAlso _
                NewItemsLoaded = True Then

                Me.SelectedIndex = 0
                Me.ShowPopup()

            End If

            'Reset NewItemsLoaded for next iteration
            NewItemsLoaded = False

        End If

    End Sub

    'Handles the KeyUp event for the drop down editor. We load any matching items.
    Private Sub DropDown_KeyUp(ByVal sender As System.Object, ByVal e As KeyEventArgs)

        'Force the timer to stop. We will only start the timer if the text is valid
        _timer.Stop()

        'Escape navigation keys (ex. up/down arrow) so we don't reload the drop down when the
        'user scrolls through the items in the grid.
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down
                Exit Sub
        End Select

        'Just exit if the text has not changed (user could have pressed F1, CTRL, SHIFT, etc.)
        If CurrentText = Me.Text Then
            Exit Sub
        End If

        If Not String.IsNullOrEmpty(Me.Text) Then
            'Restart timer
            _timer.Start()
        Else
            'Not text, close drop down
            Me.ClosePopup()
        End If

    End Sub

    'This event fires after the specified Timer.Interval has passed.
    Private Sub Timer_Elapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
        _timer.Stop()
        GetMatchingItems_AsyncBegin(Me.Text, True)
    End Sub

    'Generic function to create a gridViewTextBoxColumn with common attributes set
    Private Function CreateGridTextBoxColumn(ByVal Name As String, ByVal fieldName As String, ByVal headerText As String) As GridViewTextBoxColumn
        Dim gridViewTextBoxColumn As New GridViewTextBoxColumn

        With gridViewTextBoxColumn
            .Name = Name
            .FieldName = fieldName
            .HeaderText = headerText
            .ReadOnly = True
            .HeaderTextAlignment = ContentAlignment.BottomLeft
        End With

        Return gridViewTextBoxColumn

    End Function

    'Fires when the cell is moved out of edit mode. Perform cleanup.
    Public Overrides Function EndEdit() As Boolean
        _timer.Stop()
        _timer.Dispose()
        MyBase.EndEdit()
    End Function

End Class