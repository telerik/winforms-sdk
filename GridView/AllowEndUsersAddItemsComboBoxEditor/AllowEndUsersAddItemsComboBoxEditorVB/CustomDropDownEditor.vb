Imports Telerik.WinControls.UI

Public Class CustomDropDownEditor
    Inherits RadDropDownListEditor


    Public Overrides Function EndEdit() As Boolean
        Dim cellElement As GridComboBoxCellElement = TryCast(Me.OwnerElement, GridComboBoxCellElement)
        Dim grid As RadGridView = cellElement.GridControl
        Dim f As RadForm1 = CType(grid.FindForm(), RadForm1)
        Dim dt As NwindDataSet.CategoriesDataTable = f.DataSet.Categories

        For i As Integer = 0 To dt.Rows.Count - 1

            If dt.Rows(i)("CategoryName").ToString() = (CType(Me.EditorElement, RadDropDownListEditorElement)).Text Then
                Return MyBase.EndEdit()
            End If
        Next

        Dim newCategoriesRow As NwindDataSet.CategoriesRow = dt.NewCategoriesRow()
        newCategoriesRow.CategoryName = (CType(Me.EditorElement, RadDropDownListEditorElement)).Text

        f.DataSet.Categories.Rows.Add(newCategoriesRow)
        f.CategoriesTA.Update(f.DataSet.Categories)
        cellElement.Tag = newCategoriesRow.CategoryID
        Return MyBase.EndEdit()
    End Function
End Class
