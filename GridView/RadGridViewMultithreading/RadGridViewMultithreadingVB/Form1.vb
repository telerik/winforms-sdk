Imports System.ComponentModel
Imports System.Threading
Imports Telerik.WinControls.UI
  
Public Class Form1
    Private books As New BindingList(Of Book)()
    Private radGridView1 As New RadGridView()

    Public Sub New()
        InitializeComponent()

        Me.Controls.Add(Me.radGridView1)
        Me.radGridView1.Dock = DockStyle.Fill

        Me.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.radGridView1.DataSource = Me.books
        Me.FetchData(Me.books, 5000)
    End Sub

    Private [stop] As Boolean
    Public Sub FetchData(dataSourceToFill As IList(Of Book), interval As Integer, Optional maxFetches As Integer = -1)
        Dim dataThread = New Thread(Sub() Me.FetchDataCore(dataSourceToFill, maxFetches, interval))
        dataThread.IsBackground = True
        dataThread.Start()
    End Sub

    Private Sub FetchDataCore(dataSourceToFill As IList(Of Book), maxFetches As Integer, interval As Integer)
        Dim fetchesCount As Integer = 0
        While fetchesCount <= maxFetches OrElse Not Me.[stop]
            Dim fetchedBooks As IEnumerable(Of Book) = Me.GetAndParseData(15)
            'simulate server wait time
            Thread.Sleep(1500)

            'actual wait time passed as a parameter
            Thread.Sleep(interval)
            Me.AddBooks(fetchedBooks, dataSourceToFill)

            fetchesCount += 1
        End While
    End Sub

    Private Sub AddBooks(fetchedBooks As IEnumerable(Of Book), dataSourceToFill As IList(Of Book))
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(Sub() Me.AddBooks(fetchedBooks, dataSourceToFill)))
            Return
        End If

        For Each book As Book In fetchedBooks
            dataSourceToFill.Add(book)
        Next
    End Sub

    Private Function GetAndParseData(count As Integer) As IEnumerable(Of Book)
        Dim rawFormatBooks As String() = DataGenerator.GenerateBooks(count)
        Dim parsedBooks As New List(Of Book)()

        For Each rawBook As String In rawFormatBooks
            Dim bookParams As String() = rawBook.Split(","C)
            Dim id As Integer = Integer.Parse(bookParams(0))
            Dim name As String = bookParams(1)
            Dim authorName As String = bookParams(2)
            Dim publishDate As DateTime = DateTime.Parse(bookParams(3))
            Dim newBook As New Book(id, name, authorName, publishDate)
            parsedBooks.Add(newBook)
        Next

        Return parsedBooks
    End Function
End Class

Public Class Book
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set
            m_Id = Value
        End Set
    End Property
    Private m_Id As Integer
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set
            m_Name = Value
        End Set
    End Property
    Private m_Name As String
    Public Property AuthorName() As String
        Get
            Return m_AuthorName
        End Get
        Set
            m_AuthorName = Value
        End Set
    End Property
    Private m_AuthorName As String
    Public Property PublishDate() As DateTime
        Get
            Return m_PublishDate
        End Get
        Set
            m_PublishDate = Value
        End Set
    End Property
    Private m_PublishDate As DateTime

    Public Sub New(id As Integer, name As String, authorName As String, publishDate As DateTime)
        Me.Id = id
        Me.Name = name
        Me.AuthorName = authorName
        Me.PublishDate = publishDate
    End Sub
End Class

Public NotInheritable Class DataGenerator
    Private Sub New()
    End Sub
    Private Shared m_random As New Random()

    Public Shared ReadOnly Property Random() As Random
        Get
            Return m_random
        End Get
    End Property

    Public Shared Function GenerateBooks(count As Integer) As String()
        Dim books As String() = New String(count - 1) {}
        For i As Integer = 0 To books.Length - 1
            books(i) = GenerateBook()
        Next

        Return books
    End Function

    Public Shared Function GenerateBook() As String
        Dim id As Integer = Random.[Next]()
        Dim name As String = String.Format("Book {0}", id)
        Dim authorName As String = String.Format("Author {0}", id)
        Dim publishDate As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(-Random.[Next](100, 1000))

        Dim book As String = String.Format("{0},{1},{2},{3}", id, name, authorName, publishDate)
        Return book
    End Function
End Class