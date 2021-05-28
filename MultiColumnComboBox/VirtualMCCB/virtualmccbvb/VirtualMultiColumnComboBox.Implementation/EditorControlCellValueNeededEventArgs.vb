Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Telerik.WinControls.UI

Namespace VirtualMultiColumnComboBox.Implementation
    Public Class EditorControlCellValueNeededEventArgs
        Inherits GridViewCellValueEventArgs
        Public Property VirtualDataSource() As List(Of Object)
            Get
                Return m_VirtualDataSource
            End Get
            Private Set(value As List(Of Object))
                m_VirtualDataSource = value
            End Set
        End Property
        Private m_VirtualDataSource As List(Of Object)

        Public Sub New(columnIndex As Integer, rowIndex As Integer, virtualDataSource As List(Of Object))
            MyBase.New(columnIndex, rowIndex)
            Me.VirtualDataSource = virtualDataSource
        End Sub
    End Class

End Namespace

