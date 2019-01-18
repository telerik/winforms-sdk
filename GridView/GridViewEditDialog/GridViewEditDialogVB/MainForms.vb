Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace GridViewEditDialog
	Partial Public Class MainForms
		Inherits Telerik.WinControls.UI.RadForm
		Public Sub New()
			InitializeComponent()

			ThemeResolutionService.ApplicationThemeName = "Fluent"
		End Sub

		Public Class Student
			Implements System.ComponentModel.INotifyPropertyChanged
			Private m_id As Integer
			Private m_name As String
			Private m_grade As String

			Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

			Public Sub New(ByVal m_id As Integer, ByVal m_name As String, ByVal m_grade As String)
				Me.m_id = m_id
				Me.m_name = m_name
				Me.m_grade = m_grade
			End Sub

			Public Property Id() As Integer
				Get
					Return m_id
				End Get
				Set(ByVal value As Integer)
					If Me.m_id <> value Then
						Me.m_id = value
						OnPropertyChanged("Id")
					End If
				End Set
			End Property

			Public Property Name() As String
				Get
					Return m_name
				End Get
				Set(ByVal value As String)
					If Me.m_name <> value Then
						Me.m_name = value
						OnPropertyChanged("Name")
					End If
				End Set
			End Property

			Public Property Grade() As String
				Get
					Return m_grade
				End Get
				Set(ByVal value As String)
					If Me.m_grade <> value Then
						Me.m_grade = value
						OnPropertyChanged("Grade")
					End If
				End Set
			End Property

			Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End Sub
		End Class

		Private collectionOfStudents As New BindingList(Of Student)()

		Private Sub RadForm1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			collectionOfStudents.Add(New Student(0, "Peter", "A+"))
			collectionOfStudents.Add(New Student(1, "John", "D-"))
			collectionOfStudents.Add(New Student(2, "Antony", "B+"))
			collectionOfStudents.Add(New Student(3, "David", "A-"))
			collectionOfStudents.Add(New Student(4, "John", "D-"))
			Me.radGridView1.DataSource = collectionOfStudents

			Dim editColumn As New GridViewCommandColumn("Edit")
			editColumn.UseDefaultText = True
			editColumn.DefaultText = "Edit"
			radGridView1.MasterTemplate.Columns.Add(editColumn)

			Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			AddHandler Me.radGridView1.CommandCellClick, AddressOf radGridView1_CommandCellClick
		End Sub

		Private Sub radGridView1_CommandCellClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
			Dim f As New EditForm(TryCast(Me.radGridView1.CurrentRow.DataBoundItem, Student))
			f.StartPosition = FormStartPosition.Manual
			f.Location = New Point(Me.Location.X + Me.Size.Width \ 2 - f.Size.Width \ 2, Me.Location.Y + Me.Size.Height \ 2 - f.Size.Height \ 2)
			f.ShowDialog()
		End Sub
	End Class
End Namespace