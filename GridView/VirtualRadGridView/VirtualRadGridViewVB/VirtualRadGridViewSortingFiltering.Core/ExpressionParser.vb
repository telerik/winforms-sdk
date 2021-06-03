
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Text
Imports Telerik.Data.Expressions

Namespace VirtualRadGridViewSortingFiltering.Core
    Public Class ExpressionParser
        Private Delegate Function ParseDelegate(expression As String, caseSensitive As Boolean) As ExpressionNode
        Private Shared m_parse As ParseDelegate

        Shared Sub New()
            For Each telerikAssembly As Assembly In AppDomain.CurrentDomain.GetAssemblies()
                Dim expressionParserType As Type = telerikAssembly.[GetType]("Telerik.Data.Expressions.ExpressionParser")
                If expressionParserType IsNot Nothing Then
                    Dim parseMethod As MethodInfo = expressionParserType.GetMethod("Parse")
                    parse = DirectCast([Delegate].CreateDelegate(GetType(ParseDelegate), parseMethod), ParseDelegate)
                    Return
                End If
            Next
        End Sub

        Public Shared Function Parse(expression As String, caseSensitive As Boolean) As ExpressionNode
            Return m_parse(expression, caseSensitive)
        End Function
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
