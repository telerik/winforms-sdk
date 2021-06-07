Imports Telerik.WinControls.UI

Partial Public Class StandaloneExpressionEditorForm
    Inherits RadExpressionEditorForm
    Private Shared hiddenGrid As RadGridView
    Private Shared dataColumn As GridViewDataColumn

    Shared Sub New()
        hiddenGrid = New RadGridView()
        dataColumn = New GridViewTextBoxColumn()
        hiddenGrid.Columns.Add(dataColumn)
        hiddenGrid.Rows.AddNew()
    End Sub

    Public Sub New()
        MyBase.New(dataColumn)
    End Sub

    Public ReadOnly Property ReturnValue() As String
        Get
            Return hiddenGrid.Rows(0).Cells(0).Value.ToString()
        End Get
    End Property


    Public Function ShowDialog(initialValue As Object) As DialogResult
        Me.Expression = initialValue.ToString()
        Return MyBase.ShowDialog()
    End Function
End Class