Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports Telerik.WinControls
Imports Telerik.WinControls.Themes.Serialization
Imports Telerik.WinControls.UI

Namespace RotatorSlideShow
	Public Partial Class Form1
		Inherits RadForm
		Private running As Boolean = False
		Private args As String()

		Public Sub New(ByVal args As String())
			InitializeComponent()
			Me.args = args
		End Sub

		Public ReadOnly Property RadRotator() As RadRotator
			Get
				Return Me.radRotator1
			End Get
		End Property

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.radRotator1.Running = False
			If args.Length <> 0 Then
				OpenDocument(args(0))
			End If
			SetLocationAnimation("0,-1")
		End Sub

		Private selectImagesFileForm As SelectImagesFileForm = New SelectImagesFileForm()

		Private Sub btnCreateSlideShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreateSlideShow.Click
			selectImagesFileForm.RadRotator = Me.radRotator1
			selectImagesFileForm.ShowDialog()
		End Sub

		Private Sub btnLoadSlideShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadSlideShow.Click
			openFileDialog1.FileName = ""
			If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				OpenDocument(openFileDialog1.FileName)
			End If
		End Sub

		Public Function OpenDocument(ByVal path As String) As Boolean
			Me.Text = path
			If File.Exists(path) Then
				Try
					Dim ser As StyleXmlSerializer = New StyleXmlSerializer()
					Using reader As StreamReader = New StreamReader(path)
						Using textReader As XmlTextReader = New XmlTextReader(reader)
							textReader.Read()
							Dim list As RotatorSlideShowFile = New RotatorSlideShowFile()
							ser.ReadObjectElement(textReader, list)
							BuildRotatorItems(list.Files)
						End Using
					End Using
				Catch e1 As SerializationException
					MessageBox.Show("The file can not be opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return False
				Finally
					Me.Text = path
				End Try
				Return True
			End If
			Return False
		End Function

		Private Sub BuildRotatorItems(ByVal images As ArrayList)
			Me.radRotator1.Stop()
			Me.radRotator1.Items.Clear()
			For Each image As RadImageItem In images
				image.Alignment = ContentAlignment.MiddleCenter
				Dim radItemsContainer As RadItemsContainer = New RadItemsContainer()
				radItemsContainer.Items.Add(image)
				radItemsContainer.Visibility = Telerik.WinControls.ElementVisibility.Hidden
				radItemsContainer.Alignment = System.Drawing.ContentAlignment.MiddleCenter
				Me.radRotator1.Items.Add(radItemsContainer)
			Next image
			Me.radRotator1.Start()
			Me.btnStart.Text = "Stop"
			Me.running = True
		End Sub

		Private Sub btnStepBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStepBack.Click
			Me.radRotator1.Previous()
		End Sub

		Private Sub btnStepForward_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStepForward.Click
			Me.radRotator1.Next()
		End Sub

		Private Sub btnStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStart.Click
			If Me.running Then
				Me.btnStart.Text = "Start"
				Me.radRotator1.Stop()
				Me.running = False
			Else
				Me.btnStart.Text = "Stop"
				If Me.radRotator1.Items.Count = 0 Then
					openFileDialog1.FileName = ""
					If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
						OpenDocument(openFileDialog1.FileName)
					End If
				End If
				Me.radRotator1.Start()
				Me.running = True
			End If
		End Sub

		Private Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApply.Click
			Dim newFramesValue As String = SetFramesInterval(tbInterval.Text)
			Dim newLocationValue As String = SetLocationAnimation(tbLocationAnimation.Text)

			If Not newFramesValue Is Nothing Then
				Me.tbInterval.Text = newFramesValue
			End If

			If Not newLocationValue Is Nothing Then
				Me.tbLocationAnimation.Text = newLocationValue
			End If
		End Sub

		Private Function SetFramesInterval(ByVal value As String) As String
			Dim interval As Integer = 0

			Try
				interval = Convert.ToInt32(value)
			Catch e1 As Exception
				Return "500"
			End Try

			Dim result As String = Nothing

			If interval < 500 Then
				result = "500"
				interval = 500
			End If

			radRotator1.Interval = interval

			Return result
		End Function

		Private Function SetLocationAnimation(ByVal value As String) As String
			Dim values As String() = value.Split(","c)

			If values.Length <> 2 Then
				Return SizeFToString(radRotator1.LocationAnimation)
			End If

			Dim newValue As SizeF = New SizeF(0, 0)

			Try
				newValue.Width = Single.Parse(values(0), CultureInfo.InvariantCulture)
				newValue.Height = Single.Parse(values(1), CultureInfo.InvariantCulture)
			Catch e1 As Exception
				Return SizeFToString(radRotator1.LocationAnimation)
			End Try

			radRotator1.LocationAnimation = newValue

			Return Nothing
		End Function

		Private Function SizeFToString(ByVal value As SizeF) As String
			Return String.Format("{0}, {1}", value.Width, value.Height)
		End Function

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Application.Exit()
		End Sub
	End Class
End Namespace