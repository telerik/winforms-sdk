Imports Telerik.WinControls.UI

Public Class Form1

    Private items As New List(Of Item)()

    Public Sub New()
        InitializeComponent()
        Me.RadGridView1.TableElement.CurrentRowHeaderImage = Nothing

        AddHandler Me.RadGridView1.RowValidating, AddressOf radGridView1_RowValidating
        AddHandler Me.RadGridView1.RowValidated, AddressOf radGridView1_RowValidated
        AddHandler Me.RadGridView1.CurrentRowChanged, AddressOf radGridView1_CurrentRowChanged
        AddHandler Me.RadGridView1.CellValidating, AddressOf radGridView1_CellValidating
        AddHandler Me.RadGridView1.PreviewKeyDown, AddressOf radGridView1_PreviewKeyDown

        For i As Integer = 0 To 9
            items.Add(New Item(i, "Item" & i, i Mod 2 = 0, DateTime.Now.AddDays(i)))
        Next

        Me.RadGridView1.DataSource = items
        Me.RadGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub radGridView1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)
        If TypeOf Me.radGridView1.CurrentRow Is GridViewDataRowInfo AndAlso e.KeyData = Keys.Escape Then
            'revert the previous cell value which is stored in advance.
            If Me.radGridView1.ActiveEditor Is Nothing AndAlso Me.radGridView1.Tag = "RowNotValidated" Then
                For Each cell As KeyValuePair(Of Integer, Object) In initialValues
                    Me.radGridView1.CurrentRow.Cells(cell.Key).Value = cell.Value
                Next
                Me.radGridView1.CurrentRow.ErrorText = String.Empty
            End If
        End If
    End Sub

    Private Sub radGridView1_RowValidated(sender As Object, e As RowValidatedEventArgs)
        Me.RadGridView1.Tag = Nothing
    End Sub
  
    Private Sub radGridView1_CellValidating(sender As Object, e As CellValidatingEventArgs)
        If Me.RadGridView1.CurrentCell IsNot Nothing Then
            Dim cellIndex As Integer = e.ColumnIndex
            Dim initialCellValue As Object = e.Row.Cells(cellIndex).Value
            If Not initialValues.ContainsKey(cellIndex) Then
                initialValues.Add(cellIndex, initialCellValue)
            End If
        End If
    End Sub

    Private Sub radGridView1_CurrentRowChanged(sender As Object, e As CurrentRowChangedEventArgs)
        If e.CurrentRow IsNot Nothing Then
            initialValues = New Dictionary(Of Integer, Object)()
        End If
    End Sub

    Private Sub radGridView1_RowValidating(sender As Object, e As RowValidatingEventArgs)
        e.Row.ErrorText = String.Empty
        If TypeOf e.Row Is GridViewDataRowInfo Then
            If e.Row.Cells(1).Value Is Nothing OrElse [String].IsNullOrEmpty(e.Row.Cells(1).Value.ToString()) Then
                e.Row.ErrorText = "Empty value is not allowed"
                e.Cancel = True
                Me.RadGridView1.Tag = "RowNotValidated"
            End If
        End If
    End Sub

    'Cell index as a Key, cell value as Value
    Dim initialValues As Dictionary(Of Integer, Object)

    Public Class Item
        Public Property Id() As Integer
            Get
                Return m_Id
            End Get
            Set(value As Integer)
                m_Id = value
            End Set
        End Property
        Private m_Id As Integer

        Public Property Title() As String
            Get
                Return m_Title
            End Get
            Set(value As String)
                m_Title = value
            End Set
        End Property
        Private m_Title As String

        Public Property IsActive() As Boolean
            Get
                Return m_IsActive
            End Get
            Set(value As Boolean)
                m_IsActive = value
            End Set
        End Property
        Private m_IsActive As Boolean

        Public Property CreatedOn() As DateTime
            Get
                Return m_CreatedOn
            End Get
            Set(value As DateTime)
                m_CreatedOn = value
            End Set
        End Property
        Private m_CreatedOn As DateTime

        Public Sub New(id As Integer, title As String, isActive As Boolean, createdOn As DateTime)
            Me.Id = id
            Me.Title = title
            Me.IsActive = isActive
            Me.CreatedOn = createdOn
        End Sub
    End Class

End Class
