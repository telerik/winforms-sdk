Imports Telerik.WinControls.UI

#Region "CustomGridRowHeaderCellElement"

Public Class MyGridRowHeaderCellElement
    Inherits GridRowHeaderCellElement

    Private clearImage As Image

    Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
        MyBase.New(column, row)
        Me.clearImage = Image.FromFile("..\..\cross16x16.png")
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType As Type
        Get
            Return GetType(GridRowHeaderCellElement)
        End Get
    End Property

    Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
        Return TypeOf context Is GridFilterRowElement
    End Function

    Protected Overrides Sub UpdateImage()
        If Me.GridControl IsNot Nothing AndAlso Me.GridControl.FilterDescriptors.Count > 0 AndAlso Not Me.RowElement.IsCurrent AndAlso TypeOf Me.RowElement Is GridFilterRowElement Then
            Me.Image = Me.clearImage
            Return
        End If

        MyBase.UpdateImage()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MyBase.OnMouseDown(e)

        If Me.GridControl IsNot Nothing AndAlso Me.GridControl.FilterDescriptors.Count > 0 AndAlso Not Me.RowElement.IsCurrent AndAlso TypeOf Me.RowElement Is GridFilterRowElement Then
            Me.GridControl.FilterDescriptors.Clear()
        End If
    End Sub
End Class
#End Region