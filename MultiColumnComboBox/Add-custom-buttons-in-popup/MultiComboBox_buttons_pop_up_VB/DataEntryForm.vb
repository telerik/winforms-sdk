Imports Telerik.WinControls.UI

Partial Public Class DataEntryForm
    Inherits Telerik.WinControls.UI.RadForm

    Private dt As DataTable
    Private mccb As RadMultiColumnComboBoxElement

    Public Sub New(ByVal mccb As RadMultiColumnComboBoxElement)
        InitializeComponent()
        Me.mccb = mccb
        Me.bindingSource1 = New BindingSource()
        Me.bindingSource1.DataSource = mccb.EditorControl.DataSource
        Me.RadDataEntry1.DataSource = Me.bindingSource1
        Me.RadBindingNavigator1.BindingSource = Me.bindingSource1
        Me.RadBindingNavigator1.AutoHandleAddNew = False
        dt = CType(mccb.EditorControl.DataSource, DataTable)
    End Sub

    Private Sub RadBindingNavigator1AddNewItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dr As DataRow = dt.NewRow()
        dr(0) = ""
        dr(1) = ""
        dr(2) = ""
        dr(3) = New DateTime(2020, 1, 1)
        dr(4) = False
        dr(5) = ""
        dt.Rows.Add(dr)
        dt.AcceptChanges()
        Me.bindingSource1.Position = Me.bindingSource1.Count - 1
    End Sub

    Private Sub RadBindingNavigator1DeleteItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.bindingSource1.RemoveCurrent()
    End Sub
End Class

