Imports Telerik.WinControls.UI
Imports ServerSideDropDownListVB.Core

Public Class Form1
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim list As New RadDropDownList() With { _
                .Parent = Me, _
                .Dock = DockStyle.Top _
        }

        Dim dbContext As New LargeDataEntities()
        list.DropDownListElement.AutoCompleteValueMember = "Name"

        list.DropDownListElement.AutoCompleteSuggest = New ServerAutoCompleteSuggestHelper(Of Datum)(list.DropDownListElement, dbContext.Data)

        list.DropDownListElement.AutoCompleteAppend = New ServerAutoCompleteAppendHelper(Of Datum)(list.DropDownListElement, dbContext.Data)

    End Sub
End Class
