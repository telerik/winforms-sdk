
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI

Namespace VirtualRadGridViewSortingFiltering.Core
    Public Class VirtualRadGridViewElement
        Inherits RadGridViewElement
        Public ReadOnly Property ItemsSource() As ItemSource
            Get
                Return TryCast(Me.Template.ListSource, VirtualGridViewListSource).DataView.ItemsSource
            End Get
        End Property

        Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
            Get
                Return GetType(RadGridViewElement)
            End Get
        End Property

        Protected Overrides Function CreateTemplate() As MasterGridViewTemplate
            Return New VirtualMasterGridViewTemplate()
        End Function
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
