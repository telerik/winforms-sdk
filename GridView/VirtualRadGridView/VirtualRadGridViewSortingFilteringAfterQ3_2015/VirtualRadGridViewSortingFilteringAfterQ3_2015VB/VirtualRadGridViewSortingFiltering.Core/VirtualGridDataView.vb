
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Namespace VirtualRadGridViewSortingFiltering.Core
    Public Class VirtualGridDataView
        Inherits RadDataView(Of GridViewRowInfo)
        Private m_listSource As GridViewListSource
        Private m_itemsSource As ItemSource
        Private m_filterExpression As String

        Public ReadOnly Property ItemsSource() As ItemSource
            Get
                If Me.m_itemsSource Is Nothing Then
                    Me.m_itemsSource = New ItemSource(TryCast(Me.ListSource.Template, VirtualMasterGridViewTemplate))
                End If

                Return Me.m_itemsSource
            End Get
        End Property

        Public Overrides Property FilterExpression() As String
            Get
                Return Me.m_filterExpression
            End Get
            Set(value As String)
                If Not String.IsNullOrEmpty(value) AndAlso Me.m_filterExpression <> value Then
                    Me.m_filterExpression = value
                End If
            End Set
        End Property

        Public ReadOnly Property ListSource() As GridViewListSource
            Get
                Return Me.m_listSource
            End Get
        End Property

        Public Sub New(listSource As GridViewListSource)
            MyBase.New(listSource)
            Me.m_listSource = listSource
        End Sub

        Protected Overrides Function CreateIndex() As Telerik.Collections.Generic.Index(Of GridViewRowInfo)
            Return New VirtualIndex(Me)
        End Function

        Protected Overrides Function CreateGroupBuilder() As GroupBuilder(Of GridViewRowInfo)
            Return New VirtualGroupBuilder(Me.Indexer, Me)
        End Function
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
