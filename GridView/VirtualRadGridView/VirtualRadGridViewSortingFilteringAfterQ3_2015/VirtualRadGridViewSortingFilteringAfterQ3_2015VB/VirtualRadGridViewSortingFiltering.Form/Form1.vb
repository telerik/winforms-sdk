Imports Telerik.WinControls.UI
Imports VirtualRadGridViewSortingFiltering.Core.VirtualRadGridViewSortingFiltering.Core
Imports System.ComponentModel

Partial Public Class Form1
    Private dataSource As BindingList(Of Dummy)
    Private stopWatch As Stopwatch
    Private grid As VirtualRadGridView
    Private textBox As RadTextBox
    Private rnd As Random

    Public Const RowsCount As Integer = 2000000

    Public Sub New()
        InitializeComponent()

        Me.rnd = New Random()
        Me.stopWatch = New Stopwatch()
        Me.grid = New VirtualRadGridView() With { _
            .Parent = Me, _
            .Dock = DockStyle.Fill _
        }

        Me.textBox = New RadTextBox() With { _
           .Parent = Me, _
           .Dock = DockStyle.Bottom, _
           .Enabled = False _
        }

        Me.dataSource = New BindingList(Of Dummy)()

        For i As Integer = 0 To RowsCount / 2 - 1
            Me.dataSource.Add(New Dummy() With { _
               .Id = i, _
               .Name = Me.GenerateName(), _
               .CreationDate = DateTime.Now _
            })

            Me.dataSource.Add(New Dummy() With { _
                .Id = i, _
                .Name = Me.GenerateName(), _
                .CreationDate = DateTime.Now _
            })
        Next

        grid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        grid.VirtualDataSource = Me.dataSource

        AddHandler Me.grid.ItemsSource.OperationStarted, AddressOf ItemsSource_OperationStarted
        AddHandler Me.grid.ItemsSource.OperationCompleted, AddressOf ItemsSource_OperationCompleted
    End Sub

    Private Function GenerateName() As String
        Dim random As Integer = rnd.[Next](5, 13)
        Dim chars As Char() = New Char(random - 1) {}
        For j As Integer = 0 To random - 1
            chars(j) = CChar(ChrW(rnd.[Next](AscW("a"c), AscW("z"c) + 1)))
        Next

        Return New String(chars)
    End Function

    Private Sub ItemsSource_OperationCompleted(sender As Object, e As ItemSourceOperationCompletedEventArgs)
        Me.textBox.Text = "Last operation took " & Me.stopWatch.Elapsed.ToString()
        Me.stopWatch.[Stop]()
    End Sub

    Private Sub ItemsSource_OperationStarted(sender As Object, e As ItemSourceOperationEventArgs)
        Me.stopWatch.Reset()
        Me.stopWatch.Start()
    End Sub
End Class

Public Class Dummy
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set(value As Integer)
            m_Id = value
        End Set
    End Property
    Private m_Id As Integer
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property
    Private m_Name As String
    Public Property CreationDate() As DateTime
        Get
            Return m_CreationDate
        End Get
        Set(value As DateTime)
            m_CreationDate = value
        End Set
    End Property
    Private m_CreationDate As DateTime
End Class