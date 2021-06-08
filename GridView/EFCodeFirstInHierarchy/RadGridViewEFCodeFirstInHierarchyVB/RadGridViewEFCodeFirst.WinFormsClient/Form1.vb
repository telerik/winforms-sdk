Imports RadGridViewEFCodeFirst.Data
Imports Telerik.WinControls.UI
Imports System.Data.Entity
Imports RadGridViewEFCodeFirst.Models

Public Class Form1
    Inherits Form

    Private data As IRadGridViewEFCodeFirstData

    Public Sub New()
        InitializeComponent()

        Me.data = New RadGridViewEFCodeFirstData()
        If Not data.OrderTypes.All().Any() OrElse Not data.Orders.All().Any() OrElse Not data.Shippers.All().Any() Then
            DataGenerator.PopulateData(Me.data)
        End If
        Me.SetUpGrid()

        AddHandler Me.FormClosing, AddressOf Form1_FormClosing
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs)
        Me.data.SaveChanges()
    End Sub

    Private Sub SetUpGrid()
        DirectCast(Me.data.OrderTypes.All(), IDbSet(Of OrderType)).Load()
        Me.RadGridView1.DataSource = DirectCast(Me.data.OrderTypes.All(), IDbSet(Of OrderType)).Local.ToBindingList()
        Me.RadGridView1.Columns("Orders").IsVisible = False
        Me.RadGridView1.Columns("Shippers").IsVisible = False
        Me.RadGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        Dim ordersTemplate As New GridViewTemplate()
        ordersTemplate.Caption = "Orders"
        Me.RadGridView1.MasterTemplate.Templates.Add(ordersTemplate)
        DirectCast(Me.data.Orders.All(), IDbSet(Of Order)).Load()
        ordersTemplate.DataSource = DirectCast(Me.data.Orders.All(), IDbSet(Of Order)).Local.ToBindingList()
        ordersTemplate.Columns("OrderType").IsVisible = False
        ordersTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        Dim relation As New GridViewRelation(RadGridView1.MasterTemplate)
        relation.ChildTemplate = ordersTemplate
        relation.RelationName = "OrderTypesOrders"
        relation.ParentColumnNames.Add("OrderTypeId")
        relation.ChildColumnNames.Add("OrderTypeId")
        RadGridView1.Relations.Add(relation)

        Dim shippersTemplate As New GridViewTemplate()
        shippersTemplate.Caption = "Shippers"
        Me.RadGridView1.MasterTemplate.Templates.Add(shippersTemplate)
        DirectCast(Me.data.Shippers.All(), IDbSet(Of Shipper)).Load()
        shippersTemplate.DataSource = DirectCast(Me.data.Shippers.All(), IDbSet(Of Shipper)).Local.ToBindingList()
        shippersTemplate.Columns("OrderType").IsVisible = False
        shippersTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        Dim relation2 As New GridViewRelation(RadGridView1.MasterTemplate)
        relation2.ChildTemplate = shippersTemplate
        relation2.RelationName = "OrderTypesShippers"
        relation2.ParentColumnNames.Add("OrderTypeId")
        relation2.ChildColumnNames.Add("OrderTypeId")
        Me.RadGridView1.Relations.Add(relation2)
    End Sub
End Class
