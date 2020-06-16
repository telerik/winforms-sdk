Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Filters

Namespace CustomDecoder
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Private filter As JpxDecoder
		Public Sub New()
			filter = New JpxDecoder()
			FiltersManager.RegisterFilter(filter)

			InitializeComponent()

			radPdfViewer1.LoadDocument("../../SampleData/test.pdf")

		End Sub
	End Class
End Namespace
