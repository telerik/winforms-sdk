Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports System.Collections
Imports System.IO

Namespace GridEditingForm
	Public Partial Class EditingForm
		Inherits Form
		'members
		Private currentRow_Renamed As GridViewRowInfo
		Private addedControls As Hashtable
		Private radButtonUpdate As RadButton
		Private radButtonCancel As RadButton

		Public Sub New()
			InitializeComponent()
			Me.addedControls = New Hashtable()

			radButtonUpdate = New RadButton()
			radButtonUpdate.Text = "Update"
			radButtonUpdate.Size = New Size(75, 23)
			AddHandler radButtonUpdate.Click, AddressOf radButtonUpdate_Click
			radButtonUpdate.EndInit()


			radButtonCancel = New RadButton()
			radButtonCancel.Text = "Cancel"
			radButtonCancel.Size = New Size(75, 23)
			AddHandler radButtonCancel.Click, AddressOf radButtonCancel_Click
			radButtonCancel.EndInit()
		End Sub

		''' <summary>
		'''fill form with controls depend cells from currentRow 
		''' </summary>
		''' <param name="currentRow">row with cell for building form</param>
		Public Sub BuildEditFormFromRow(ByVal currentRow_Renamed As GridViewRowInfo)
			Me.addedControls.Clear()

			Me.CurrentRow = currentRow_Renamed

			If Not Me.CurrentRow Is Nothing Then
				Dim yOffset As Integer = 20
				For Each cell As GridViewCellInfo In currentRow_Renamed.Cells
					Dim ctrl As Control = Nothing
					Dim cellValue As Object = cell.Value

'					#Region "create controls depend from cell type"

					If TypeOf cell.ColumnInfo Is GridViewCommandColumn Then
						Continue For
					ElseIf TypeOf cell.ColumnInfo Is GridViewImageColumn Then
						ctrl = New PictureBox()
						Dim bytes As Byte() = CType(cell.Value, Byte())

						'For old MS pictures in Northwind
						Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()

						' 78 is the size of the OLE header for Northwind images.
						Dim offset As Integer = 78
						ms.Write(bytes, offset, bytes.Length - offset)

						Dim bmp As Bitmap = New Bitmap(ms)
						ms.Close()

						CType(ctrl, PictureBox).Image = bmp
					ElseIf TypeOf cell.ColumnInfo Is GridViewCheckBoxColumn Then
						ctrl = New RadCheckBox()
						CType(ctrl, RadCheckBox).ThemeName = "ControlDefault"
						CType(ctrl, RadCheckBox).EndInit()

						If CBool(cellValue) = True Then
							CType(ctrl, RadCheckBox).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
						Else
							CType(ctrl, RadCheckBox).ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
						End If
					ElseIf TypeOf cell.ColumnInfo Is GridViewDateTimeColumn Then
						ctrl = New RadDateTimePicker()
						CType(ctrl, RadDateTimePicker).ThemeName = "ControlDefault"
						CType(ctrl, RadDateTimePicker).EndInit()
						CType(ctrl, RadDateTimePicker).Value = CDate(cellValue)
					ElseIf TypeOf cell.ColumnInfo Is GridViewDecimalColumn Then
						ctrl = New RadSpinEditor()
						CType(ctrl, RadSpinEditor).ThemeName = "ControlDefault"
						CType(ctrl, RadSpinEditor).EndInit()
						CType(ctrl, RadSpinEditor).Value = Decimal.Parse(cellValue.ToString())
					Else
						ctrl = New RadTextBox()
						CType(ctrl, RadTextBox).ThemeName = "ControlDefault"
						CType(ctrl, RadTextBox).EndInit()
						CType(ctrl, RadTextBox).Text = cellValue.ToString()
					End If

					If cell.ColumnInfo.ReadOnly Then
						ctrl.Enabled = False
					End If
'					#End Region
'					#Region "put control and label in form"

					Dim location As Point = New Point(0, yOffset)
					Dim label As Label = New Label()
					Me.Controls.Add(label)

					label.Location = location
					label.Text = String.Format("{0}:",cell.ColumnInfo.FieldName)

					Me.Controls.Add(ctrl)

					'this cell point to db layer
					Dim dbCell As GridViewCellInfo = cell
					Me.addedControls.Add(ctrl, dbCell) 'Save pair in hashtable- controls from forms and associated cell to this controls

					location = New Point(label.Width + 10, yOffset)
					ctrl.Location = location
					yOffset += ctrl.Size.Height + 8 'vertical offset for next control

'					#End Region
				Next cell
			End If

			Dim ctrl1 As Control = TryCast(Me.Controls(Me.Controls.Count - 1), Control)

			radButtonCancel.Location = New Point(Me.Size.Width - radButtonCancel.Size.Width, ctrl1.Location.Y + ctrl1.Size.Height + 10)
			Me.Controls.Add(radButtonCancel)

			radButtonUpdate.Location = New Point(radButtonCancel.Location.X - radButtonUpdate.Size.Width - 5, ctrl1.Location.Y + ctrl1.Size.Height + 10)
			Me.Controls.Add(radButtonUpdate)
		End Sub

		'get or set the current row
		Public Property CurrentRow() As GridViewRowInfo
			Get
				Return currentRow_Renamed
			End Get
			Set
				currentRow_Renamed = Value
			End Set
		End Property

		Private Sub radButtonUpdate_Click(ByVal sender As Object, ByVal e As EventArgs)
			UpdateRow()
			Me.Close()
		End Sub

		Public Sub UpdateRow()
			'CurrentRow.ViewInfo.ViewTemplate.BeginUpdate();
			For Each de As DictionaryEntry In Me.addedControls
				Dim ctrl As Control = TryCast(de.Key, Control)
				Dim dbCell As GridViewCellInfo = TryCast(de.Value, GridViewCellInfo)

				If TypeOf ctrl Is RadCheckBox Then
					dbCell.Value = (CType(ctrl, RadCheckBox)).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
				ElseIf TypeOf ctrl Is RadDateTimePicker Then
					dbCell.Value = (CType(ctrl, RadDateTimePicker)).Value
				ElseIf TypeOf ctrl Is RadSpinEditor Then
					dbCell.Value = (CType(ctrl, RadSpinEditor)).Value
				ElseIf TypeOf ctrl Is RadTextBox Then
					dbCell.Value = (CType(ctrl, RadTextBox)).Text
				End If
			Next de
			'this.CurrentRow.ViewInfo.ViewTemplate.EndUpdate();            
		End Sub

		Private Sub radButtonCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Close()
		End Sub
	End Class
End Namespace