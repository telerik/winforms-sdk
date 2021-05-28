Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports TrieImplementation

Namespace VirtualMultiColumnComboBox
    Partial Public Class MainWindow
        Inherits Form
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
            Public Property DummysDummy() As DummysDummy
                Get
                    Return m_DummysDummy
                End Get
                Set(value As DummysDummy)
                    m_DummysDummy = value
                End Set
            End Property
            Private m_DummysDummy As DummysDummy
        End Class

        Public Class DummysDummy

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
        End Class

        Private ds As New ObservableCollection(Of Dummy)()

        Public Sub New()
            InitializeComponent()

            Dim letter As Char = "a"c
            For i As Integer = 0 To 99999
                Dim dummy As New Dummy()
                dummy.Id = i
                letter = Chr(Asc(letter) + 1)
                If letter = "z"c Then
                    letter = "a"c
                End If

                dummy.Name = letter

                dummy.DummysDummy = New DummysDummy() With {.Id = i, _
                    .Name = letter
                }

                ds.Add(dummy)
            Next

            AddHandler ds.CollectionChanging, AddressOf ds_CollectionChanging

            Me.virtualRadMultiColumnComboBox1.LoadDataSourceAsync = True
            Me.virtualRadMultiColumnComboBox1.ValueMember = "DummysDummy.Name"
            Me.virtualRadMultiColumnComboBox1.DisplayMember = "DummysDummy"
            Me.virtualRadMultiColumnComboBox1.DataSource = Me.ds
            Me.virtualRadMultiColumnComboBox1.AutoFilter = True
            Me.virtualRadMultiColumnComboBox1.AutoShowHidePopup = True
            Me.virtualRadMultiColumnComboBox1.SearchType = SearchType.Contains
            Me.virtualRadMultiColumnComboBox1.EditorControl.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

            AddHandler Me.virtualRadMultiColumnComboBox1.SearchCompleted, AddressOf radMultiColumnComboBox1_SearchCompleted
            AddHandler Me.virtualRadMultiColumnComboBox1.SearchStarting, AddressOf radMultiColumnComboBox1_SearchStarting
            AddHandler Me.virtualRadMultiColumnComboBox1.EditorControlCellValueNeeded, AddressOf virtualRadMultiColumnComboBox1_EditorControlCellValueNeeded


            AddHandler Me.virtualRadMultiColumnComboBox1.DataSourceLoaded, AddressOf virtualRadMultiColumnComboBox1_DataSourceLoaded
        End Sub

        Private Sub virtualRadMultiColumnComboBox1_DataSourceLoaded(sender As Object, e As EventArgs)
            RadMessageBox.Show("LOADED")
        End Sub

        Private Sub ds_CollectionChanging(sender As Object, e As NotifyCollectionChangingEventArgs)
        End Sub

        Private Sub virtualRadMultiColumnComboBox1_EditorControlCellValueNeeded(sender As Object, e As Implementation.EditorControlCellValueNeededEventArgs)
            If e.ColumnIndex = 2 Then
                e.Value = TryCast(e.VirtualDataSource(e.RowIndex), Dummy).DummysDummy.Name
            End If
        End Sub

        Private Sub radMultiColumnComboBox1_SearchStarting(sender As Object, e As Implementation.SearchStartingEventArgs)
        End Sub

        Private Sub radMultiColumnComboBox1_SearchCompleted(sender As Object, e As Implementation.SearchCompletedEventArgs)
        End Sub
    End Class

    Public NotInheritable Class Generator
        Private Sub New()
        End Sub
        Public Shared ReadOnly Random As New Random()

        Public Shared Function GenerateName(length As Integer) As String
            Dim sb As New StringBuilder()
            For i As Integer = 0 To length - 1
                sb.Append("f")
            Next

            sb(0) = Char.ToUpper(sb(0))

            Return sb.ToString()
        End Function
    End Class
End Namespace

