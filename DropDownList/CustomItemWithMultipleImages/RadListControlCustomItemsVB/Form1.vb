' --------------------------------------------------------------------------------------------------------------------
' <copyright file="Form1.cs" company="">
'
' </copyright>
' <summary>
'   The form 1.
' </summary>
' --------------------------------------------------------------------------------------------------------------------

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
''' <summary>
''' The form 1.
''' </summary>
Partial Public Class Form1
    Inherits Form
#Region "Constants and Fields"

    ''' <summary>
    ''' The rad list control 1.
    ''' </summary>
    Private WithEvents radListControl1 As RadListControl

#End Region

#Region "Constructors and Destructors"

    ''' <summary>
    ''' Initializes a new instance of the <see cref="Form1"/> class.
    ''' </summary>
    Public Sub New()
        Me.InitializeComponent()
        Me.radListControl1 = New RadListControl()
        Me.Size = New Size(500, 300)
    End Sub

#End Region

#Region "Methods"

    ''' <summary>
    ''' The creating visual list item.
    ''' </summary>
    ''' <param name="sender">
    ''' The sender.
    ''' </param>
    ''' <param name="args">
    ''' The args.
    ''' </param>
    Private Sub CreatingVisualListItem(ByVal sender As Object, ByVal args As CreatingVisualListItemEventArgs) Handles radListControl1.CreatingVisualListItem
        args.VisualItem = New CustomListVisualItem()
    End Sub

    ''' <summary>
    ''' The form 1_ load.
    ''' </summary>
    ''' <param name="sender">
    ''' The sender.
    ''' </param>
    ''' <param name="e">
    ''' The e.
    ''' </param>
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.radListControl1.Dock = DockStyle.Fill

        Me.Controls.Add(Me.radListControl1)

        Me.PrepareDataSourceAndShowDropDown(1000)
    End Sub

    ''' <summary>
    ''' The item data binding.
    ''' </summary>
    ''' <param name="sender">
    ''' The sender.
    ''' </param>
    ''' <param name="args">
    ''' The args.
    ''' </param>
    Private Sub ItemDataBinding(ByVal sender As Object, ByVal args As ListItemDataBindingEventArgs) Handles radListControl1.ItemDataBinding
        args.NewItem = New CustomListDataItem()
    End Sub

    ''' <summary>
    ''' The item data bound.
    ''' </summary>
    ''' <param name="sender">
    ''' The sender.
    ''' </param>
    ''' <param name="args">
    ''' The args.
    ''' </param>
    Private Sub ItemDataBound(ByVal sender As Object, ByVal args As ListItemDataBoundEventArgs) Handles radListControl1.ItemDataBound
        Dim listDataItem = DirectCast(args.NewItem, CustomListDataItem)
        Dim dataObject = DirectCast(listDataItem.DataBoundItem, BussinessObject)

        listDataItem.Name = dataObject.Name
        listDataItem.Image = dataObject.Image
        listDataItem.Image2 = dataObject.Image2
    End Sub

    ''' <summary>
    ''' The prepare data source and show drop down.
    ''' </summary>
    ''' <param name="noObjects">
    ''' The no objects.
    ''' </param>
    Private Sub PrepareDataSourceAndShowDropDown(ByVal noObjects As Integer)
        Me.radListControl1.DataSource = Nothing
        Me.radListControl1.DisplayMember = "Name"

        Dim list = New BindingList(Of BussinessObject)()
        For i As Integer = 0 To noObjects - 1
            Dim businessObject = New BussinessObject()
            businessObject.Image = My.Resources.Resource1.combobox
            businessObject.Image2 = If(i Mod 2 = 0, My.Resources.Resource1.calendar, Nothing)
            businessObject.Name = " Item " + (i + 1).ToString()
            list.Add(businessObject)
        Next

        Me.radListControl1.DataSource = list
    End Sub

#End Region
End Class





