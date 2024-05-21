Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
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
	Public Partial Class SelectImagesFileForm
		Inherits RadForm
		Private isdirty As Boolean = False
		Private path As String = String.Empty
		Private exists As Boolean
		Private radRotator_Renamed As RadRotator

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Property RadRotator() As RadRotator
			Get
				Return radRotator_Renamed
			End Get
			Set
				radRotator_Renamed = Value
			End Set
		End Property

		Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse.Click
			openFileDialog.FileName = String.Empty
			If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Dim index As Integer = radListControl1.SelectedIndex
				Dim i As Integer = 0
				Do While i < openFileDialog.FileNames.Length
					radListControl1.Items.Add(openFileDialog.FileNames(i))
					isdirty = True
					i += 1
				Loop
				If index > -1 Then
					radListControl1.SelectedIndex = index
				Else
					radListControl1.SelectedIndex = 0
				End If
				radListControl1.Focus()
			End If
		End Sub

		Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
			If Not radListControl1.SelectedItem Is Nothing Then
				radListControl1.Items.Remove(radListControl1.SelectedItem)
				isdirty = True
			End If
		End Sub

		Private Sub btnMoveTop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMoveTop.Click
			Dim item As RadListDataItem = radListControl1.SelectedItem
			radListControl1.Items.Remove(item)
			radListControl1.Items.Insert(0, item)
			radListControl1.SelectedIndex = 0
			isdirty = True
		End Sub

		Private Sub btnMoveUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMoveUp.Click
			Dim index As Integer = radListControl1.SelectedIndex - 1
			If index >= 0 Then
				Dim item As RadListDataItem = radListControl1.SelectedItem
				radListControl1.Items.Remove(item)
				radListControl1.Items.Insert(index, item)
				radListControl1.SelectedIndex = index
				isdirty = True
			End If
		End Sub

		Private Sub btnMoveDown_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMoveDown.Click
			Dim index As Integer = radListControl1.SelectedIndex + 1
			If index <= radListControl1.Items.Count - 1 Then
				Dim item As RadListDataItem = radListControl1.SelectedItem
				radListControl1.Items.Remove(item)
				radListControl1.Items.Insert(index, item)
				radListControl1.SelectedIndex = index
				isdirty = True
			End If
		End Sub

		Private Sub btnMoveBottom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMoveBottom.Click
			Dim item As RadListDataItem = radListControl1.SelectedItem
			radListControl1.Items.Remove(item)
			radListControl1.Items.Add(item)
			radListControl1.SelectedIndex = radListControl1.Items.Count - 1
			isdirty = True
		End Sub

		Private Sub SelectImagesFileForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			If isdirty Then
				Dim result As DialogResult = MessageBox.Show(" Files has been modified. Do you want to save?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
				If result = DialogResult.Yes Then
					Dim pathtosave As String = path
					If (Not exists) Then
						saveFileDialog1.FileName = String.Empty
						If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
							pathtosave = saveFileDialog1.FileName
						Else
							e.Cancel = True
							Return
						End If
					End If
					SaveFile(pathtosave)
				End If

				If result = DialogResult.Cancel Then
					e.Cancel = True
				End If
			End If
		End Sub

		Public Sub SaveFile(ByVal path As String)
			Dim serializer As StyleXmlSerializer = New StyleXmlSerializer(False)

			Using xmlWriter As XmlTextWriter = New XmlTextWriter(path, Encoding.UTF8)
				xmlWriter.Formatting = Formatting.Indented
				xmlWriter.WriteStartElement("SlideShow")
				serializer.WriteObjectElement(xmlWriter, Me.GetImages())
			End Using
			isdirty = False
		End Sub

		Private Function GetImages() As RotatorSlideShowFile
			Dim images As RotatorSlideShowFile = New RotatorSlideShowFile()
			Dim i As Integer = 0
			Do While i < radListControl1.Items.Count
				Dim item As RadImageItem = New RadImageItem()
				item.Image = New Bitmap(Image.FromFile(radListControl1.Items(i).ToString()))
				images.Files.Add(item)
				i += 1
			Loop
			Return images
		End Function

		Private Sub radListControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles radListControl1.SelectedIndexChanged
			Dim temp As Image = Nothing
			If Not radListControl1.SelectedItem Is Nothing Then
				temp = Image.FromFile(radListControl1.SelectedItem.Text)
				previewBox.SizeMode = PictureBoxSizeMode.CenterImage
			End If

			previewBox.Image = temp
			radListControl1.Focus()
		End Sub

		Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
			Me.Close()
		End Sub

		Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Dim pathtosave As String = path
			If (Not exists) Then
				saveFileDialog1.FileName = String.Empty
				If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					pathtosave = saveFileDialog1.FileName
					SaveFile(pathtosave)
				End If
			End If
		End Sub
	End Class
End Namespace