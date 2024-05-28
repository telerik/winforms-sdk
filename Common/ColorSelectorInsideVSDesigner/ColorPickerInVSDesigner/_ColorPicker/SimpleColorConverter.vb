Imports System.ComponentModel

Class SimpleColorConverter
	Inherits ColorConverter
	' reference: System.Drawing.Design.dll
	Public Overrides Function GetStandardValuesSupported(ByVal context As ITypeDescriptorContext) As Boolean
		Return False
	End Function

End Class

