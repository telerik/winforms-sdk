Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI
Imports TrieImplementation

Namespace VirtualMultiColumnComboBox.Implementation
	Public Class VirtualMultiColumnComboBox
		Inherits RadMultiColumnComboBox
#Region "Properties"

        Public Property IgnoreCase() As Boolean
            Get
                Return (CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement)).IgnoreCase
            End Get
            Set(value As Boolean)
                CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).IgnoreCase = value
            End Set
        End Property


        ''' <summary>
        ''' Gets or Sets the type of the search. Can be Contains or StartsWith
        ''' </summary>
        Public Property SearchType() As SearchType
            Get
                Return (CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement)).SearchType
            End Get
            Set(value As SearchType)
                CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).SearchType = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or Sets the value which indicates whether the DataSource will be loaded
        ''' in another thread in the background. The <see cref="DataSourceLoaded"/> event is
        ''' fired when the DataSource is completely loaded
        ''' </summary>
        Public Property LoadDataSourceAsync() As Boolean
            Get
                Return (CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement)).LoadDataSourceAsync
            End Get
            Set(value As Boolean)
                CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).LoadDataSourceAsync = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or Sets the value which indicates after how many milliseconds after
        ''' a key press a search will be made
        ''' </summary>
        Public Property StartSearchInterval() As Integer
            Get
                Return (CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement)).StartSearchInterval
            End Get
            Set(value As Integer)
                CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).StartSearchInterval = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or Sets the value which indicates if the GridViewPopup will be automatically
        ''' shown/closed during search operations
        ''' </summary>
        Public Property AutoShowHidePopup() As Boolean
            Get
                Return (CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement)).AutoShowHidePopup
            End Get
            Set(value As Boolean)
                CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).AutoShowHidePopup = value
            End Set
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' Creates our VirtualMultiColumnComboBoxElemnt
        ''' </summary>
        ''' <returns></returns>
        Protected Overrides Function CreateMultiColumnComboBoxElement() As RadMultiColumnComboBoxElement
            Return New VirtualMultiColumnComboBoxElement()
        End Function

        ''' <summary>
        ''' Needed for proper theming
        ''' </summary>
        Public Overrides Property ThemeClassName() As String
            Get
                Return GetType(RadMultiColumnComboBox).FullName
            End Get
            Set(value As String)
            End Set
        End Property

        ''' <summary>
        ''' Performs a search operation with the specified text.
        ''' </summary>
        ''' <param name="text">The text to search</param>
        Public Sub PerformSearch(ByVal text As String)
            Me.PerformSearch(text, TrieImplementation.SearchType.Contains)
        End Sub

        Public Sub PerformSearch(ByVal text As String, ByVal searchType As SearchType)
            CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).PerformSearch(text, Me.SearchType)
        End Sub

#End Region

#Region "Events"

        ''' <summary>
        ''' Fired when the Search method is done searching
        ''' </summary>
        Public Custom Event SearchCompleted As SearchCompletedEventHandler
            AddHandler(ByVal value As SearchCompletedEventHandler)
                AddHandler CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).SearchCompleted, value
            End AddHandler
            RemoveHandler(ByVal value As SearchCompletedEventHandler)
                RemoveHandler CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).SearchCompleted, value
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As SearchCompletedEventArgs)
            End RaiseEvent
        End Event

        ''' <summary>
        ''' Fires before the searching has begun. Cancelable.
        ''' </summary>
        Public Custom Event SearchStarting As SearchStartingEventHandler
            AddHandler(ByVal value As SearchStartingEventHandler)
                AddHandler CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).SearchStarting, value
            End AddHandler
            RemoveHandler(ByVal value As SearchStartingEventHandler)
                RemoveHandler CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).SearchStarting, value
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As SearchStartingEventArgs)
            End RaiseEvent
        End Event

        ''' <summary>
        ''' Fired when value for a cell is needed. Also provides the datasource.
        ''' </summary>
        Public Custom Event EditorControlCellValueNeeded As EditorControlCellValueNeededEventHandler
            AddHandler(ByVal value As EditorControlCellValueNeededEventHandler)
                AddHandler CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).EditorControlCellValueNeeded, value
            End AddHandler
            RemoveHandler(ByVal value As EditorControlCellValueNeededEventHandler)
                RemoveHandler CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).EditorControlCellValueNeeded, value
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As EditorControlCellValueNeededEventArgs)
            End RaiseEvent
        End Event

        ''' <summary>
        ''' Fired when the DataSource is completely loaded
        ''' </summary>
        Public Custom Event DataSourceLoaded As EventHandler
            AddHandler(ByVal value As EventHandler)
                AddHandler CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).DataSourceLoaded, value
            End AddHandler
            RemoveHandler(ByVal value As EventHandler)
                RemoveHandler CType(Me.MultiColumnComboBoxElement, VirtualMultiColumnComboBoxElement).DataSourceLoaded, value
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
            End RaiseEvent
        End Event

#End Region
    End Class
End Namespace