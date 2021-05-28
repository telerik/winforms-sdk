Imports Microsoft.VisualBasic
Imports System

Namespace VirtualMultiColumnComboBox.Implementation

    Public Class SearchCompletedEventArgs
        Inherits System.EventArgs
        Public Property Text() As String
            Get
                Return m_Text
            End Get
            Private Set(value As String)
                m_Text = Value
            End Set
        End Property
        Private m_Text As String
        Public Property Results() As System.Collections.Generic.IEnumerable(Of String)
            Get
                Return m_Results
            End Get
            Private Set(value As System.Collections.Generic.IEnumerable(Of String))
                m_Results = Value
            End Set
        End Property
        Private m_Results As System.Collections.Generic.IEnumerable(Of String)

        Public Sub New(text As String, results As System.Collections.Generic.IEnumerable(Of String))
            Me.Text = text
            Me.Results = results
        End Sub
    End Class

End Namespace
