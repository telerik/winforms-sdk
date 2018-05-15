Imports System.ComponentModel
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private orderedItems As New BindingList(Of OrderItem)()

    Public Sub New()
        InitializeComponent()
        AddHandler radListView1.VisualItemCreating, AddressOf RadListView1_VisualItemCreating

        Dim view = TryCast(radListView1.ListViewElement.ViewElement, SimpleListViewElement)
        view.ItemSize = New Size(20, 60)
        radListView1.AllowEdit = False
        AddHandler radListView2.ItemMouseDoubleClick, AddressOf RadListView2_ItemMouseDoubleClick
        radListView1.DataSource = orderedItems

        AddHandler orderedItems.ListChanged, AddressOf OrderedItems_ListChanged
    End Sub

    Private Sub OrderedItems_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
        Dim total As Decimal = 0
        For Each item In orderedItems
            total += item.Price * item.Amount
        Next item
        radLabel4.Text = total.ToString("C")
    End Sub

    Private Sub RadListView2_ItemMouseDoubleClick(ByVal sender As Object, ByVal e As ListViewItemEventArgs)
        e.Item.Enabled = False
        Dim product = CType(e.Item.DataBoundItem, DataRowView).Row
        Dim newItem = New OrderItem()
        newItem.Amount = 1
        newItem.Name = product("ProductName").ToString()
        newItem.Price = (DirectCast(product("UnitPrice"), Decimal))
        newItem.QuantityPerUnit = product("QuantityPerUnit").ToString()
        orderedItems.Add(newItem)
    End Sub

    Private Sub RadListView1_VisualItemCreating(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewVisualItemCreatingEventArgs)
        If Me.radListView1.ViewType = ListViewType.ListView Then
            e.VisualItem = New CartVisualItem()
        End If
    End Sub

    Private Sub RadForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NwindDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.NwindDataSet.Products)

    End Sub
End Class
