Imports System.ComponentModel
Imports Telerik.WinControls.UI

Public Class RowDetailsGrid
    Inherits RadGridView
    'INSTANT VB NOTE: The variable detailsColumn was renamed since Visual Basic does not allow class members with the same name:
    Private detailsColumn_Renamed As GridViewDataColumn
    'INSTANT VB NOTE: The variable detailsRowHeight was renamed since Visual Basic does not allow class members with the same name:
    Private detailsRowHeight_Renamed As Integer = 185

    Public Sub New()
        Me.ViewDefinition = New RowDetailsViewDefinition()
    End Sub

    Public Overrides Property ThemeClassName() As String
        Get
            Return GetType(RadGridView).FullName
        End Get

        Set(ByVal value As String)
        End Set
    End Property

    Public Property DetailsColumn() As GridViewDataColumn
        Get
            Return Me.detailsColumn_Renamed
        End Get

        Set(ByVal value As GridViewDataColumn)
            If detailsColumn_Renamed IsNot value Then
                detailsColumn_Renamed = value
                If detailsColumn_Renamed IsNot Nothing Then
                    detailsColumn_Renamed.ReadOnly = True
                    detailsColumn_Renamed.MinWidth = 0
                    detailsColumn_Renamed.Width = 1
                End If
                Me.TableElement.UpdateView()
            End If
        End Set
    End Property

    <DefaultValue(185)>
    Public Property DetailsRowHeight() As Integer
        Get
            Return Me.detailsRowHeight_Renamed
        End Get

        Set(ByVal value As Integer)
            If detailsRowHeight_Renamed <> value Then
                detailsRowHeight_Renamed = value
                TableElement.UpdateView()
            End If
        End Set
    End Property

    Protected Overrides Sub OnCreateRow(ByVal sender As Object, ByVal e As GridViewCreateRowEventArgs)
        If e.RowType Is GetType(GridDataRowElement) Then
            e.RowType = GetType(RowDetailsRowElement)
        End If
        MyBase.OnCreateRow(sender, e)
    End Sub
End Class
