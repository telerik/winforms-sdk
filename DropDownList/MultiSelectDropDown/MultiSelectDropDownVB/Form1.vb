Imports Telerik.WinControls.UI

Partial Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()

        Dim t As New DataTable()
        t.Columns.Add("ID", GetType(Integer))
        t.Columns.Add("Name", GetType(String))
        t.Rows.Add(1, "one")
        t.Rows.Add(2, "two")
        t.Rows.Add(3, "three")
        t.Rows.Add(4, "four")
        t.Rows.Add(5, "five")
        t.Rows.Add(6, "six")
        t.Rows.Add(7, "seven")
        t.Rows.Add(8, "eight")
        t.Rows.Add(9, "nine")
        t.Rows.Add(10, "ten")

        Dim list As New CustomDropDownList()
        list.Name = "MyDropDown"
        list.Location = New Point(130, 80)
        list.Size = New System.Drawing.Size(230, 20)
        Controls.Add(list)

        list.DisplayMember = "Name"
        list.ValueMember = "ID"
        list.DataSource = t
        AddHandler list.SelectedIndexChanged, AddressOf list_SelectedIndexChanged
    End Sub

    Private Sub list_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
        If e.Position > -1 Then
            Dim list As CustomDropDownList = TryCast(sender, CustomDropDownList)
            DirectCast(list.Items(e.Position), CustomListDataItem).Checked = True
            DirectCast(list.DropDownListElement, CustomEditorElement).SynchronizeText()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        Dim ddl As CustomDropDownList = TryCast(Me.Controls("MyDropDown"), CustomDropDownList)
        DirectCast(ddl.DropDownListElement.ListElement.SelectedItem, CustomListDataItem).Checked = False
        DirectCast(ddl.DropDownListElement.ListElement.SelectedItem, CustomListDataItem).Selected = False
        Dim lve As LightVisualElement = TryCast(ddl.DropDownListElement.EditableElement.Children(1), LightVisualElement)
        lve.Text = String.Empty

        ddl.Items(1).Selected = True
    End Sub
End Class
