Imports Microsoft.VisualBasic
Imports System
Namespace VirtualMultiColumnComboBox.Implementation
    Public Class SearchStartingEventArgs
        Inherits System.ComponentModel.CancelEventArgs
        Public Property Text() As String
            Get
                Return m_Text
            End Get
            Private Set(value As String)
                m_Text = value
            End Set
        End Property
        Private m_Text As String

        Public Sub New(text As String)
            Me.Text = text
        End Sub
    End Class
End Namespace
