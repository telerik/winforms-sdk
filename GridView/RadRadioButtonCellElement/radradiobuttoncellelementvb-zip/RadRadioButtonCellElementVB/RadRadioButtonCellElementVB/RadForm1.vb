Imports Telerik.WinControls
Imports Telerik.WinControls.UI


Public Class RadForm1
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub


    Private Sub RadForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add(New DataColumn("Id", GetType(Integer)))
        dt.Columns.Add(New DataColumn("Name", GetType(String)))
        dt.Columns.Add(New DataColumn("FavouriteColor", GetType(Integer)))

        Dim rand As Random = New Random()
        For i As Integer = 0 To 49
            Dim dr As DataRow = dt.NewRow()
            dr(0) = i
            dr(1) = "John" & i.ToString()
            dr(2) = rand.Next(3)
            dt.Rows.Add(dr)
        Next i

        Me.radGridView1.DataSource = dt

        Me.radGridView1.MasterTemplate.BeginUpdate()

        Me.radGridView1.Columns.RemoveAt(2)

        Dim column As RadioButtonColumn = New RadioButtonColumn("FavouriteColor")
        column.HeaderText = "Favourite Color"
        column.Width = 180
        column.ReadOnly = True
        Me.radGridView1.Columns.Add(column)

        Me.radGridView1.MasterTemplate.EndUpdate()
    End Sub
End Class
