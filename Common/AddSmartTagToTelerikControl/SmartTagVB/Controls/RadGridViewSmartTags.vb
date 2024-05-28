#Region "Imports"
Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics.CodeAnalysis
Imports System.Globalization
Imports System.Windows.Forms
Imports Telerik.WinControls.Data
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
#End Region

<Designer(GetType(RadGridViewSmartTagsControlDesigner))> _
Public Class RadGridViewSmartTags
    Inherits Telerik.WinControls.UI.RadGridView

    Private m_MyContextMenuEnabled As Boolean
    Private m_MyContextMenuVisible As Boolean = True

    <Category("Context Menus")> _
    <Browsable(True)> _
    <Description("Occurs when the sample context menu item is clicked")> _
    Public Event SampleContextMenu_Clicked As EventHandler(Of EventArgs)


#Region "Constructor"
    ''' <summary>Initializes a new instance of the GridView class.</summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.ThemeClassName = "Telerik.WinControls.UI.RadGridView"
    End Sub
#End Region

#Region " Public Properties "

#Region "ThemeName"
    ''' <summary>Theme Name</summary>
    ''' <value>The name of the theme</value>
    ''' <returns>Theme name as string</returns>
    ''' <remarks>Ensures the Theme name cannot be changed in the designer</remarks>
    <[ReadOnly](True)> _
    Public Overloads ReadOnly Property ThemeName() As String
        Get
            Return MyBase.ThemeName
        End Get
    End Property
#End Region

#Region "AllowColumnChooser"
    <Browsable(True)> _
    <Category("Columns")> _
    <DefaultValue(True)> _
    Public Overloads Property AllowColumnChooser() As Boolean
        Get
            Return Me.MasterTemplate.AllowColumnChooser
        End Get
        Set(ByVal value As Boolean)
            Me.MasterTemplate.AllowColumnChooser = value
        End Set
    End Property
#End Region

#Region "MyContextMenuEnabled"
    <Browsable(True)> _
    <Category("Context Menus")> _
    Public Overloads Property MyContextMenuEnabled() As Boolean
        Get
            Return m_MyContextMenuEnabled
        End Get
        Set(ByVal value As Boolean)
            m_MyContextMenuEnabled = value
        End Set
    End Property
#End Region

#Region "MyContextMenuVisible"
    <Browsable(True)> _
    <Category("Context Menus")> _
    Public Overloads Property MyContextMenuVisible() As Boolean
        Get
            Return m_MyContextMenuVisible
        End Get
        Set(ByVal value As Boolean)
            m_MyContextMenuVisible = value
        End Set
    End Property
#End Region

#End Region

#Region "GridView_ContextMenuOpening"
    ''' <summary>Grid View Context Menu Opening Event Handler.</summary>
    ''' <param name="sender">The event source</param>
    ''' <param name="e">The event arguments.</param>
    ''' <remarks></remarks>
    Private Sub GridView_ContextMenuOpening(ByVal sender As System.Object, _
        ByVal e As ContextMenuOpeningEventArgs) Handles MyBase.ContextMenuOpening

        ' if this is not the filter menu
        If TypeOf e.ContextMenuProvider Is Telerik.WinControls.UI.GridDataCellElement _
        AndAlso Me.SelectedRows.Count > 0 Then

            If m_MyContextMenuVisible Then
                Dim contextMenuItemSample As New RadMenuItem()
                With contextMenuItemSample
                    .Text = "My Sample Context Menu"
                    .ToolTipText = "Some tooltip"
                    .Enabled = m_MyContextMenuEnabled
                End With
                e.ContextMenu.Items.Insert(0, contextMenuItemSample)
                AddHandler contextMenuItemSample.Click, AddressOf ContextMenuItemSample_Click
            End If

        End If

    End Sub
#End Region

#Region "ContextMenuItemSendToSample_Click"
    ''' <summary>Send to Branches Context Menu Item Click Event Handler.</summary>
    ''' <param name="sender">The event source.</param>
    ''' <param name="e">The event arguments.</param>
    ''' <remarks></remarks>
    Private Sub ContextMenuItemSample_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs)

        RaiseEvent SampleContextMenu_Clicked(Me, New EventArgs())
        Me.Focus()
    End Sub
#End Region

End Class

#Region " Smart Tag "

#Region "GridView Control Designer Class"
Public Class RadGridViewSmartTagsControlDesigner
    Inherits System.Windows.Forms.Design.ControlDesigner

    Private lists As DesignerActionListCollection

    Public Overrides ReadOnly Property ActionLists() _
       As DesignerActionListCollection
        Get
            If lists Is Nothing Then
                lists = New _
                   DesignerActionListCollection()
                lists.Add( _
                   New RadGridViewSmartTagsControlActionList(Me.Component))
            End If
            Return lists
        End Get
    End Property

End Class
#End Region

#Region "GridView Control Action List Class"
<ComplexBindingProperties("DataSource", "DataMember")> _
Public Class RadGridViewSmartTagsControlActionList
    Inherits System.ComponentModel. _
       Design.DesignerActionList

#Region " Variables "

    Private m_GridView As RadGridViewSmartTags

    ''' <summary>Reference to DesignerActionUIService</summary>
    ''' <remarks></remarks>
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Justification:="This field only requires an assigned value.")> _
    Private m_DesignerActionSvc As DesignerActionUIService

#End Region

#Region "Constructor"
    ''' <summary>Initialises a new instance of the GridViewStandardControlActionList class.</summary>
    ''' <param name="component"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal component As IComponent)

        MyBase.New(component)
        Me.m_GridView = DirectCast(component, RadGridViewSmartTags)

        Me.m_DesignerActionSvc = CType(GetService(GetType(DesignerActionUIService)), DesignerActionUIService)
    End Sub
#End Region

#Region "GridView"
    ''' <summary>Gets or sets the GridView.</summary>
    <CLSCompliant(False)> _
    Public Property GridView() As RadGridViewSmartTags
        Get
            Return m_GridView
        End Get
        Set(ByVal value As RadGridViewSmartTags)
            m_GridView = value
        End Set
    End Property
#End Region

#Region "GetPropertyByName"
    ''' <summary></summary>
    ''' <param name="propName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetPropertyByName(ByVal propName As String) As PropertyDescriptor

        Dim prop As PropertyDescriptor

        prop = TypeDescriptor.GetProperties(m_GridView)(propName)

        If prop Is Nothing Then
            Throw New ArgumentException("Invalid property.", propName)
        Else
            Return prop
        End If
    End Function
#End Region

#Region "Dock"
    Public Property Dock() As System.Windows.Forms.DockStyle
        Get
            Return m_GridView.Dock
        End Get
        Set(ByVal value As System.Windows.Forms.DockStyle)
            GetPropertyByName("Dock").SetValue(m_GridView, value)
        End Set
    End Property
#End Region

#Region "AllowColumnChooser"
    Public Property AllowColumnChooser() As Boolean
        Get
            Return m_GridView.AllowColumnChooser
        End Get
        Set(ByVal value As Boolean)
            GetPropertyByName("AllowColumnChooser").SetValue(m_GridView, value)
        End Set
    End Property
#End Region

#Region "MyContextMenuEnabled"
    Public Property MyContextMenuEnabled() As Boolean
        Get
            Return m_GridView.MyContextMenuEnabled
        End Get
        Set(ByVal value As Boolean)
            GetPropertyByName("MyContextMenuEnabled").SetValue(m_GridView, value)
        End Set
    End Property
#End Region

#Region "MyContextMenuVisible"
    Public Property MyContextMenuVisible() As Boolean
        Get
            Return m_GridView.MyContextMenuVisible
        End Get
        Set(ByVal value As Boolean)
            GetPropertyByName("MyContextMenuVisible").SetValue(m_GridView, value)
        End Set
    End Property
#End Region

#Region "DataSource"
    <RefreshProperties(RefreshProperties.Repaint)> _
    <Editor("System.Windows.Forms.Design.DataSourceListEditor", "System.Drawing.Design.UITypeEditor")> _
    Public Property DataSource() As Object
        Get
            Return m_GridView.DataSource
        End Get
        Set(ByVal value As Object)
            GetPropertyByName("DataSource").SetValue(m_GridView, value)
        End Set
    End Property
#End Region

#Region "DataMember"
    <Editor("System.Windows.Forms.Design.DataMemberListEditor", "System.Drawing.Design.UITypeEditor")> _
    Public Property DataMember() As String
        Get
            Return m_GridView.DataMember
        End Get
        Set(ByVal value As String)
            GetPropertyByName("DataMember").SetValue(m_GridView, value)
        End Set
    End Property
#End Region

#Region "get Sorted Action Items"
    Public Overrides Function GetSortedActionItems() _
      As DesignerActionItemCollection
        Dim items As New DesignerActionItemCollection()

        items.Add(New _
           DesignerActionHeaderItem("Columns"))
        items.Add(New _
            DesignerActionPropertyItem("AllowColumnChooser", "Allow Column Chooser", "Columns", "Determines if the column chooser is available"))

        items.Add(New _
           DesignerActionHeaderItem("Context Menu"))
        items.Add(New _
            DesignerActionPropertyItem("MyContextMenuEnabled", "My Menu Enabled", "Context Menus", "Determines if my context menu is enabled"))
        items.Add(New _
            DesignerActionPropertyItem("MyContextMenuVisible", "My Menu Visible", "Context Menus", "Determines if my context menu is visible"))

        items.Add(New _
           DesignerActionHeaderItem("Data"))
        items.Add(New _
            DesignerActionPropertyItem("DataSource", "Data Source", "Data", "Sets the data source"))
        items.Add(New _
            DesignerActionPropertyItem("DataMember", "Data Member", "Data", "Sets the data member"))

        items.Add(New _
           DesignerActionHeaderItem("Layout"))
        items.Add(New _
            DesignerActionPropertyItem("Dock", "Dock position", "Layout", "Determines the dock position"))

        items.Add(New _
            DesignerActionHeaderItem("Advanced"))
        items.Add(New _
            DesignerActionMethodItem(Me, "OnLaunchBuilder", "Property Builder", "Advanced", "Launches the Telerik Property Builder", False))

        Return items
    End Function
#End Region

#Region "Launch Property Builder"
    ''' <summary>
    ''' This launches the property builder
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub OnLaunchBuilder()

        Dim service As IDesignerHost = TryCast(m_GridView.Site.GetService(GetType(IDesignerHost)), IDesignerHost)
        Dim transaction As DesignerTransaction = service.CreateTransaction(String.Format(CultureInfo.InvariantCulture, "RadGridView{0}LaunchBuilderTransaction", DirectCast(m_GridView, RadGridView).Name))

        Dim propertyBuilder As New Telerik.WinControls.UI.Design.RadGridViewPropertyBuilder(DirectCast(m_GridView, RadGridView))
        Try
            If propertyBuilder.ShowDialog = DialogResult.OK Then
                transaction.Commit()
                transaction = Nothing

                Dim actionUIService As DesignerActionUIService = TryCast(m_GridView.Site.GetService(GetType(DesignerActionUIService)), DesignerActionUIService)
                If actionUIService IsNot Nothing Then
                    actionUIService.HideUI(m_GridView)
                End If
            End If
        Finally
            If transaction IsNot Nothing Then
                transaction.Cancel()
            End If
        End Try
    End Sub
#End Region

End Class

#End Region

#End Region

