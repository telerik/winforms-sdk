
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI

Namespace VirtualRadGridViewSortingFiltering.Core
    Public Class VirtualMasterGridViewTemplate
        Inherits MasterGridViewTemplate
        Public Sub New()
            Me.ThrowExceptionOnDataOperationInVirtualMode = False
        End Sub
        Protected Overrides Function CreateListSource() As GridViewListSource
            Return New VirtualGridViewListSource(Me)
        End Function
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
