Imports AllowEndUsersAddItemsComboBoxEditorVB.NwindDataSetTableAdapters
Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadGridView1_CellEndEdit(sender As Object, e As GridViewCellEventArgs)
        If Me.RadGridView1.CurrentCell.Tag IsNot Nothing Then
            Me.RadGridView1.CurrentCell.Value = Me.RadGridView1.CurrentCell.Tag
            Me.RadGridView1.CurrentCell.Tag = Nothing
        End If
    End Sub

    Private Sub RadGridView1_EditorRequired(ByVal sender As Object, ByVal e As EditorRequiredEventArgs)
        If e.EditorType = GetType(RadDropDownListEditor) Then
            e.Editor = New CustomDropDownEditor()
        End If
    End Sub

    Public ReadOnly Property DataSet() As NwindDataSet
        Get
            Return Me.NwindDataSet
        End Get
    End Property
    Public ReadOnly Property CategoriesTA() As CategoriesTableAdapter
        Get
            Return Me.CategoriesTableAdapter
        End Get
    End Property

    Private Sub RadForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RadGridView1.Dock = DockStyle.Fill
        Dim categoriesColumn As GridViewComboBoxColumn = New GridViewComboBoxColumn()
        categoriesColumn.DisplayMember = "CategoryName"
        categoriesColumn.ValueMember = "CategoryID"
        categoriesColumn.FieldName = "CategoryID"
        categoriesColumn.HeaderText = "Category"
        categoriesColumn.DataSource = Me.CategoriesBindingSource
        categoriesColumn.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        categoriesColumn.Width = 150
        Me.RadGridView1.Columns.Insert(4, categoriesColumn)
        AddHandler Me.RadGridView1.CellEndEdit, AddressOf RadGridView1_CellEndEdit
        AddHandler Me.RadGridView1.EditorRequired, AddressOf RadGridView1_EditorRequired
        'TODO: This line of code loads data into the 'NwindDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.NwindDataSet.Categories)
        'TODO: This line of code loads data into the 'NwindDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.NwindDataSet.Products)

    End Sub
End Class
