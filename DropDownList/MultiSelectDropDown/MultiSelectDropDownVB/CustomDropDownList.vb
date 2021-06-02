Imports Telerik.WinControls.UI
Imports System.ComponentModel
Imports System.Drawing.Design
Imports Telerik.WinControls

Public Class CustomDropDownList
    Inherits RadDropDownList
    Public Overrides Property ThemeClassName() As String
        Get
            Return GetType(RadDropDownList).FullName
        End Get
        Set(value As String)
        End Set
    End Property

    Protected Overrides Function CreateDropDownListElement() As RadDropDownListElement
        Return New CustomEditorElement()
    End Function

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Editor(GetType(CustomListControlCollectionEditor), GetType(UITypeEditor)), Category(RadDesignCategory.DataCategory)> _
    <Description("Gets a collection representing the items contained in this RadDropDownList.")> _
    Public Shadows ReadOnly Property Items() As RadListDataItemCollection
        Get
            Return MyBase.Items
        End Get
    End Property
End Class

Public Class CustomListControlCollectionEditor
    Inherits Telerik.WinControls.UI.Design.RadListControlCollectionEditor
    Public Sub New(itemType As Type)
        MyBase.New(itemType)
    End Sub

    Protected Overrides Function CreateNewItemTypes() As Type()
        Dim baseTypes As Type() = MyBase.CreateNewItemTypes()
        Dim newTypes As Type() = New Type(baseTypes.Length) {}
        baseTypes.CopyTo(newTypes, 0)
        newTypes(baseTypes.Length) = GetType(CustomListDataItem)
        Return newTypes
    End Function
End Class
