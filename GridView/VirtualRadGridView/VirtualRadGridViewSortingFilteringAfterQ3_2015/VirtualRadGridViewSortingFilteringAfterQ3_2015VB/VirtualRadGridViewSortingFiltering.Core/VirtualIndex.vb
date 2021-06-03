
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.Collections.Generic
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Namespace VirtualRadGridViewSortingFiltering.Core
    Public Class VirtualIndex
        Inherits Index(Of GridViewRowInfo)
        Public Sub New(collectionView As RadCollectionView(Of GridViewRowInfo))
            MyBase.New(collectionView)
        End Sub

        Public Overrides ReadOnly Property Items() As IList(Of GridViewRowInfo)
            Get
                Return TryCast(Me.CollectionView, VirtualGridDataView).ListSource
            End Get
        End Property

        Protected Overrides Sub Perform()
        End Sub
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
