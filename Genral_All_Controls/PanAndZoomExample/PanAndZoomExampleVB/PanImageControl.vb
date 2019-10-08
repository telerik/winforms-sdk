Imports Telerik.WinControls
Imports System.ComponentModel

<ToolboxItem(True)>
Public Class PanImageControl
    Inherits RadControl

    Private _panImageElement As PanImageElement

    Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
        MyBase.CreateChildItems(parent)
        Me._panImageElement = New PanImageElement()
        parent.Children.Add(Me._panImageElement)
    End Sub

    Public ReadOnly Property PanImageElement As PanImageElement
        Get
            Return _panImageElement
        End Get
    End Property
End Class