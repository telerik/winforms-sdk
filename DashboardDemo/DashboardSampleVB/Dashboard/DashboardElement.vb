Imports Telerik.WinControls.UI

Public Class DashboardElement
    Inherits StackLayoutElement

    Private _pending As ColumnElement
    Private _inProgress As ColumnElement
    Private _readyForTest As ColumnElement
    Private _done As ColumnElement
    Private _dragDropService As DashboardDragDropService = New DashboardDragDropService()

    Public ReadOnly Property Pending As ColumnElement
        Get
            Return Me._pending
        End Get
    End Property

    Public ReadOnly Property InProgress As ColumnElement
        Get
            Return Me._inProgress
        End Get
    End Property

    Public ReadOnly Property ReadyForTest As ColumnElement
        Get
            Return Me._readyForTest
        End Get
    End Property

    Public ReadOnly Property Done As ColumnElement
        Get
            Return Me._done
        End Get
    End Property

    Public ReadOnly Property DragDropService As DashboardDragDropService
        Get
            Return Me._dragDropService
        End Get
    End Property

    Protected Overrides Sub InitializeFields()
        MyBase.InitializeFields()
        Me.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.StretchHorizontally = True
        Me.StretchVertically = True
        Me.BackColor = Color.White
        Me.DrawFill = True
        Me.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.DrawBorder = False
    End Sub

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        _pending = New ColumnElement("Pending")
        Me.Children.Add(_pending)
        _inProgress = New ColumnElement("In Progress")
        Me.Children.Add(_inProgress)
        _readyForTest = New ColumnElement("Ready for test")
        Me.Children.Add(_readyForTest)
        _done = New ColumnElement("Done")
        Me.Children.Add(done)
    End Sub
End Class