
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports System.Threading.Tasks

Namespace VirtualRadGridViewSortingFiltering.Core
    Public Class VirtualGroupBuilder
        Inherits GroupBuilder(Of GridViewRowInfo)
        Private dataView As VirtualGridDataView

        Public Sub New(index As Telerik.Collections.Generic.Index(Of GridViewRowInfo), dataView As VirtualGridDataView)
            MyBase.New(index)
            Me.dataView = dataView
        End Sub

        Protected Overrides Function GetItemKey(item As GridViewRowInfo, descriptor As SortDescriptor) As Object
            Return Me.dataView.ItemsSource.GetValue(item.DataBoundItem, descriptor.PropertyIndex)
        End Function
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
