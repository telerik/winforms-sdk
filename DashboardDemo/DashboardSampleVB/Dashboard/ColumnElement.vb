Imports Telerik.WinControls.UI

Public Class ColumnElement
    Inherits StackLayoutElement

    Private _header As ColumnHeaderElement
    Private _content As StackLayoutElement

    Public ReadOnly Property Header As ColumnHeaderElement
        Get
            Return Me._header
        End Get
    End Property

    Public ReadOnly Property Content As StackLayoutElement
        Get
            Return Me._content
        End Get
    End Property

    Public Sub New(ByVal title As String)
        header.Text = title
    End Sub

    Protected Overrides Sub InitializeFields()
        MyBase.InitializeFields()
        Me.DrawFill = False
        Me.DrawBorder = True
        Me.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        Me.BorderLeftWidth = 0
        Me.BorderTopWidth = 0
        Me.BorderRightWidth = 1
        Me.BorderRightColor = Color.Gray
        Me.StretchHorizontally = True
        Me.StretchVertically = True
        Me.Orientation = System.Windows.Forms.Orientation.Vertical
    End Sub

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        _header = New ColumnHeaderElement()
        Me.Children.Add(_header)
        _content = New StackLayoutElement()
        _content.Orientation = Orientation.Vertical
        _content.StretchHorizontally = True
        _content.StretchVertically = True
        _content.AllowDrop = True
        Me.Children.Add(content)
    End Sub
End Class