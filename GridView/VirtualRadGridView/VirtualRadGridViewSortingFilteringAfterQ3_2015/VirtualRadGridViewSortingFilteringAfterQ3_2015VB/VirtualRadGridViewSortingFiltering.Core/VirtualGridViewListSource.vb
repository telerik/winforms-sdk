
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI

Namespace VirtualRadGridViewSortingFiltering.Core
    Public Class VirtualGridViewListSource
        Inherits GridViewListSource
        Public Property DataView() As VirtualGridDataView
            Get
                Return m_DataView
            End Get
            Private Set(value As VirtualGridDataView)
                m_DataView = Value
            End Set
        End Property
        Private m_DataView As VirtualGridDataView

        Public Sub New(template As GridViewTemplate)
            MyBase.New(template)
        End Sub


        Protected Overrides Sub InsertItem(index As Integer, item As GridViewRowInfo)
            MyBase.InsertItem(index, item)
            Me.InitializeBoundRow(item, Me.DataView.ItemsSource(index))
        End Sub

        Protected Overrides Function CreateDefaultCollectionView() As Telerik.WinControls.Data.RadCollectionView(Of GridViewRowInfo)
            Me.DataView = New VirtualGridDataView(Me)
            Return Me.DataView
        End Function

    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
