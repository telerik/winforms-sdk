
Imports System.Collections.Generic
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports Telerik.WinControls.UI

Namespace VirtualRadGridViewSortingFiltering.Core
    Public Class GridViewCellValueEventArgsEx
        Inherits GridViewCellValueEventArgs
        Private Shared oldArgsType As Type
        Private Shared rowInfoField As FieldInfo

        Private m_rowInfo As GridViewRowInfo

        Public Property OldArgs() As GridViewCellValueEventArgs
            Get
                Return m_OldArgs
            End Get
            Private Set(value As GridViewCellValueEventArgs)
                m_OldArgs = Value
            End Set
        End Property
        Private m_OldArgs As GridViewCellValueEventArgs

        Public ReadOnly Property RowInfo() As GridViewRowInfo
            Get
                If Me.m_rowInfo Is Nothing Then
                    Me.m_rowInfo = DirectCast(rowInfoField.GetValue(Me.OldArgs), GridViewRowInfo)
                End If

                Return Me.m_rowInfo
            End Get
        End Property

        Shared Sub New()
            oldArgsType = GetType(GridViewCellValueEventArgs)
            rowInfoField = oldArgsType.GetField("rowInfo", BindingFlags.Instance Or BindingFlags.NonPublic)
        End Sub

        Public Sub New(oldArgs As GridViewCellValueEventArgs, columnIndex As Integer, rowIndex As Integer)
            MyBase.New(columnIndex, rowIndex)
            Me.OldArgs = oldArgs
        End Sub
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
