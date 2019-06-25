Imports System.ComponentModel
Imports DragAndDropBetweenGridsVB
Imports Telerik.WinControls.UI

Public Class RadForm1
    Public Sub New()
        InitializeComponent()
        leftGrid.ShowGroupPanel = False
        rightGrid.ShowGroupPanel = False
        leftGrid.AllowAddNewRow = False
        rightGrid.AllowAddNewRow = False
        leftGrid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        rightGrid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
    End Sub
    Private Sub ResetGrids()
        leftGrid.DataSource = Nothing
        leftGrid.Rows.Clear()
        leftGrid.Columns.Clear()
        rightGrid.DataSource = Nothing
        rightGrid.Rows.Clear()
        rightGrid.Columns.Clear()
    End Sub

    Private Sub btnUnbound_Click(sender As Object, e As EventArgs) Handles btnUnbound.Click
        ResetGrids()
        PrepareUnboundGrid(leftGrid)
        leftGrid.Rows.Add("Carey", "Payette")
        leftGrid.Rows.Add("Michael", "Crump")
        leftGrid.Rows.Add("Jeff", "Fritz")
        PrepareUnboundGrid(rightGrid)
        rightGrid.Rows.Add("Phil", "Japikse")
        rightGrid.Rows.Add("Jesse", "Liberty")
        rightGrid.Rows.Add("Iris", "Classon")
    End Sub

    Private Sub PrepareUnboundGrid(leftGrid As DragAndDropRadGrid)
        Dim firstName As GridViewTextBoxColumn = New GridViewTextBoxColumn("FirstName", "FirstName")
        firstName.HeaderText = "First Name"
        Dim lastName As GridViewTextBoxColumn = New GridViewTextBoxColumn("LastName", "LastName")
        lastName.HeaderText = "Last Name"
        leftGrid.Columns.AddRange(firstName, lastName)
    End Sub

    Private Sub btnBoundObjects_Click(sender As Object, e As EventArgs) Handles btnBoundObjects.Click
        ResetGrids()
        Dim dataList1 As New BindingList(Of Player)()
        dataList1.Add(New Player() With {
            .FirstName = "Carey",
            .LastName = "Payette"
        })
        dataList1.Add(New Player() With {
            .FirstName = "Michael",
            .LastName = "Crump"
        })
        dataList1.Add(New Player() With {
            .FirstName = "Jeff",
            .LastName = "Fritz"
        })
        Dim dataList2 As New BindingList(Of Player)()
        dataList2.Add(New Player() With {
            .FirstName = "Phil",
            .LastName = "Japikse"
        })
        dataList2.Add(New Player() With {
            .FirstName = "Jesse",
            .LastName = "Liberty"
        })
        dataList2.Add(New Player() With {
            .FirstName = "Iris",
            .LastName = "Classon"
        })
        leftGrid.DataSource = dataList1
        rightGrid.DataSource = dataList2
    End Sub

    Public Class Player
        Public Property FirstName() As String
            Get
                Return m_FirstName
            End Get
            Set(ByVal value As String)
                m_FirstName = value
            End Set
        End Property
        Private m_FirstName As String
        Public Property LastName() As String
            Get
                Return m_LastName
            End Get
            Set(ByVal value As String)
                m_LastName = value
            End Set
        End Property
        Private m_LastName As String
    End Class

    Private Sub btnBoundDataSet_Click(sender As Object, e As EventArgs) Handles btnBoundDataSet.Click
        ResetGrids()
        Dim ds1 As DataSet = New DataSet()
        Dim team1 As DataTable = New DataTable()
        team1.Columns.Add("First Name", GetType(String))
        team1.Columns.Add("Last Name", GetType(String))
        team1.Rows.Add("Carey", "Payette")
        team1.Rows.Add("Michael", "Crump")
        team1.Rows.Add("Jeff", "Fritz")
        ds1.Tables.Add(team1)
        Dim ds2 As DataSet = New DataSet()
        Dim team2 As DataTable = New DataTable()
        team2.Columns.Add("First Name", GetType(String))
        team2.Columns.Add("Last Name", GetType(String))
        team2.Rows.Add("Phil", "Japikse")
        team2.Rows.Add("Jesse", "Liberty")
        team2.Rows.Add("Iris", "Classon")
        ds2.Tables.Add(team2)
        leftGrid.DataSource = ds1
        leftGrid.DataMember = "Table1"
        rightGrid.DataSource = ds2
        rightGrid.DataMember = "Table1"
    End Sub
End Class

