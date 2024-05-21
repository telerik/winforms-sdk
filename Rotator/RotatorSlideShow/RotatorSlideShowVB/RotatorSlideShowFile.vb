Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports RotatorSlideShow.Properties

Namespace RotatorSlideShow
	<Serializable> _
	Public Class RotatorSlideShowFile
		Private files_Renamed As ArrayList

		Public Sub New()
			files_Renamed = New ArrayList()
		End Sub

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property Files() As ArrayList
			Get
				Return files_Renamed
			End Get
		End Property
	End Class
End Namespace