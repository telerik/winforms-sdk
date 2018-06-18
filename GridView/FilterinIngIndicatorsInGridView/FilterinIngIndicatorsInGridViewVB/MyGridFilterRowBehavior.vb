Imports Telerik.WinControls.UI

#Region "CustomGridFilterRowBehavior"
Public Class MyGridFilterRowBehavior
    Inherits GridFilterRowBehavior

    Protected Overrides Function OnMouseDownLeft(ByVal e As MouseEventArgs) As Boolean
        Dim filterCell As MyGridFilterCellElement = TryCast(Me.GetCellAtPoint(e.Location), MyGridFilterCellElement)

        If filterCell IsNot Nothing AndAlso filterCell.ClearButtonElement.ControlBoundingRectangle.Contains(e.Location) Then
            Return False
        End If

        Return MyBase.OnMouseDownLeft(e)
    End Function
End Class
#End Region