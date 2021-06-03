Imports Telerik.WinControls.UI
Imports System.ComponentModel
Imports Telerik.WinControls

Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        Me.RadGridView1.DataSource = DataContext.Artists
        Me.RadGridView1.AutoGenerateHierarchy = True

        Me.SetupTemplates()
    End Sub

    Private Sub SetupTemplates()
        Me.RadGridView1.EnableFiltering = True
        Me.RadGridView1.Columns("Id").IsVisible = False
        Me.RadGridView1.Columns("Albums").IsVisible = False
        Me.RadGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        Me.RadGridView1.Templates(0).AllowAddNewRow = True
        Me.RadGridView1.Templates(0).Columns("Id").IsVisible = False
        Me.RadGridView1.Templates(0).Columns("ArtistId").IsVisible = False
        Me.RadGridView1.Templates(0).Columns("Tracks").IsVisible = False
        Me.RadGridView1.Templates(0).AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        Me.RadGridView1.Templates(0).Templates(0).AllowAddNewRow = True
        Me.RadGridView1.Templates(0).Templates(0).Columns("Id").IsVisible = False
        Me.RadGridView1.Templates(0).Templates(0).Columns("Size").IsVisible = False
        Me.RadGridView1.Templates(0).Templates(0).AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub radGridView1_CellValueChanged(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellValueChanged
        If TypeOf e.Row Is GridViewNewRowInfo OrElse TypeOf e.Row Is GridViewFilteringRowInfo Then
            Return
        End If

        If e.Row.HierarchyLevel > 0 Then
            Me.SetBoundValue(e.Row.DataBoundItem, e.Column.FieldName, e.Value)
            e.Row.InvalidateRow()
        End If
    End Sub

    Private Sub radGridView1_UserAddingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles RadGridView1.UserAddingRow
        Dim row As GridViewRowInfo = e.Rows(0)
        If row.HierarchyLevel = 0 Then
            Return
        End If

        Dim relation As GridViewRelation = Me.RadGridView1.Relations.Find(row.ViewTemplate.Parent, row.ViewTemplate)
        Dim parentRow As GridViewRowInfo = TryCast(row.Parent, GridViewRowInfo)
        Dim parentProperties As PropertyDescriptorCollection = ListBindingHelper.GetListItemProperties(parentRow.DataBoundItem)
        Dim childDescriptor As PropertyDescriptor = parentProperties.Find(relation.ChildColumnNames(0), True)
        If childDescriptor IsNot Nothing Then
            Dim children As IList = TryCast(childDescriptor.GetValue(parentRow.DataBoundItem), IList)
            If children IsNot Nothing Then
                Dim newItem As Object = Activator.CreateInstance(ListBindingHelper.GetListItemType(children))
                Dim success As Boolean = True
                For Each column As GridViewColumn In row.ViewTemplate.Columns
                    If column.IsVisible AndAlso Not column.[ReadOnly] AndAlso row.Cells(column.FieldName).Value IsNot Nothing AndAlso success Then
                        success = success And Me.SetBoundValue(newItem, column.FieldName, row.Cells(column.FieldName).Value)
                    End If
                Next

                If Not success Then
                    e.Cancel = True
                Else
                    children.Add(newItem)
                End If
            End If
        End If
    End Sub

    Private Sub radGridView1_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles RadGridView1.UserAddedRow
        e.Row.ViewTemplate.Refresh()
    End Sub

    Private Sub radGridView1_UserDeletedRow(sender As Object, e As GridViewRowEventArgs) Handles RadGridView1.UserDeletedRow
        Dim rows As GridViewRowInfo() = e.Rows
        For i As Integer = 0 To CInt(rows.Length) - 1
            Dim row As GridViewRowInfo = rows(i)
            If row.HierarchyLevel <> 0 Then
                Dim relation As GridViewRelation = Me.RadGridView1.Relations.Find(row.ViewTemplate.Parent, row.ViewTemplate)
                Dim parentRow As GridViewRowInfo = TryCast(row.Parent, GridViewRowInfo)
                Dim parentProperties As PropertyDescriptorCollection = ListBindingHelper.GetListItemProperties(parentRow.DataBoundItem)
                Dim childDescriptor As PropertyDescriptor = parentProperties.Find(relation.ChildColumnNames(0), True)
                If childDescriptor IsNot Nothing Then
                    Dim children As IList = TryCast(childDescriptor.GetValue(parentRow.DataBoundItem), IList)
                    If children IsNot Nothing Then
                        children.Remove(row.DataBoundItem)
                        row.ViewInfo.Refresh()

                        For Each childRow In row.ViewInfo.ChildRows
                            childRow.InvalidateRow()
                        Next
                    End If
                End If
            End If
        Next
    End Sub

    Private Function SetBoundValue(dataBoundItem As Object, propertyName As String, value As Object) As Boolean
        Dim descriptor As PropertyDescriptor = TypeDescriptor.GetProperties(dataBoundItem).Find(propertyName, True)
        If value IsNot Nothing Then
            Try
                Dim type As Type = Nullable.GetUnderlyingType(descriptor.PropertyType)
                If descriptor.Converter IsNot Nothing AndAlso type IsNot Nothing AndAlso type.IsGenericType Then
                    value = descriptor.Converter.ConvertFromInvariantString(value.ToString())
                End If
                descriptor.SetValue(dataBoundItem, value)
                Return True
            Catch
                RadMessageBox.Show(String.Concat("Invalid property value for ", propertyName), "Error", MessageBoxButtons.OK, RadMessageIcon.[Error])
                Return False
            End Try
        Else
            Try
                descriptor.SetValue(dataBoundItem, value)
            Catch
                descriptor.SetValue(dataBoundItem, DBNull.Value)
            End Try
        End If

        Return True
    End Function
End Class
