Imports Telerik.WinControls.UI
Imports System.Collections.ObjectModel


Public Class RadReadOnlyTreeView
    Inherits RadTreeView

    Private m_ReadOnly As Boolean = False

    Public Overrides Property ThemeClassName() As String
        Get
            Return GetType(RadTreeView).FullName
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    Private Shadows Sub NodeFormatting(sender As System.Object, e As Telerik.WinControls.UI.TreeNodeFormattingEventArgs) Handles MyBase.NodeFormatting
        If MyBase.CheckBoxes Then
            If m_ReadOnly Then
                CType(e.NodeElement.Children(2), RadCheckBoxElement).Enabled = False
            Else
                CType(e.NodeElement.Children(2), RadCheckBoxElement).Enabled = True
            End If
        End If
    End Sub

    <System.ComponentModel.Browsable(True)> _
    <System.ComponentModel.DefaultValue(False)> _
    <System.ComponentModel.Category("Behavior")> _
    <System.ComponentModel.Description("If the tree view has checkboxes, then allows the treeview checkboxes to be read only")> _
    Public Property CheckBoxReadOnly() As Boolean
        Get
            Return m_ReadOnly
        End Get
        Set(value As Boolean)
            m_ReadOnly = value
        End Set
    End Property

End Class
