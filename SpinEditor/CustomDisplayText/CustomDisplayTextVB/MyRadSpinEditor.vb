Imports Telerik.WinControls.UI

#Region "CustomRadSpinEditor"
Public Class MyRadSpinEditor
    Inherits RadSpinEditor

    Private spinElement As MyRadSpinElement

    Public Overrides Property ThemeClassName As String
        Get
            Return GetType(RadSpinEditor).FullName
        End Get
        Set(value As String)
            MyBase.ThemeClassName = value
        End Set
    End Property
    Public Property ScientificNatation As Boolean
        Get
            Return Me.spinElement.ScientificNation
        End Get
        Set(ByVal value As Boolean)
            Me.spinElement.ScientificNation = value
        End Set
    End Property

    Public Property LeadingZero As Boolean
        Get
            Return Me.spinElement.LeadingZero
        End Get
        Set(ByVal value As Boolean)
            Me.spinElement.LeadingZero = value
        End Set
    End Property

    Protected Overrides Function CreateSpinElement() As RadSpinElement
        Me.spinElement = New MyRadSpinElement()
        Return Me.spinElement
    End Function
End Class
#End Region
