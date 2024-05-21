Imports Microsoft.VisualBasic
Imports System
Namespace RotatorSlideShow
	Public Partial Class SelectImagesFileForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btnBrowse = New Telerik.WinControls.UI.RadButton()
			Me.radListControl1 = New Telerik.WinControls.UI.RadListControl()
			Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
			Me.btnOK = New Telerik.WinControls.UI.RadButton()
			Me.btnDelete = New Telerik.WinControls.UI.RadButton()
			Me.btnMoveTop = New Telerik.WinControls.UI.RadButton()
			Me.btnMoveUp = New Telerik.WinControls.UI.RadButton()
			Me.btnMoveDown = New Telerik.WinControls.UI.RadButton()
			Me.btnMoveBottom = New Telerik.WinControls.UI.RadButton()
			Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
			Me.previewBox = New System.Windows.Forms.PictureBox()
			Me.btnCancel = New Telerik.WinControls.UI.RadButton()
			Me.btnSave = New Telerik.WinControls.UI.RadButton()
			CType(Me.btnBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnOK, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnMoveTop, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnMoveUp, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnMoveDown, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnMoveBottom, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.previewBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnBrowse
			' 
			Me.btnBrowse.Location = New System.Drawing.Point(12, 12)
			Me.btnBrowse.Name = "btnBrowse"
			Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
			Me.btnBrowse.TabIndex = 0
			Me.btnBrowse.Text = "Browse"
'			Me.btnBrowse.Click += New System.EventHandler(Me.btnBrowse_Click);
			' 
			' radListControl1
			' 
			Me.radListControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radListControl1.FormattingEnabled = True
			Me.radListControl1.Location = New System.Drawing.Point(95, 12)
			Me.radListControl1.Name = "radListControl1"
			Me.radListControl1.Size = New System.Drawing.Size(600, 212)
			Me.radListControl1.TabIndex = 19
'			Me.radListControl1.SelectedIndexChanged+= New Telerik.WinControls.UI.Data.PositionChangedEventHandler(radListControl1_SelectedIndexChanged);
			' 
			' openFileDialog
			' 
			Me.openFileDialog.Filter = "Image Files|*.jpg;*.bmp;*.png"
			Me.openFileDialog.Multiselect = True
			Me.openFileDialog.RestoreDirectory = True
			Me.openFileDialog.Title = "Choose images for slideshow"
			' 
			' btnOK
			' 
			Me.btnOK.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.btnOK.Location = New System.Drawing.Point(12, 439)
			Me.btnOK.Name = "btnOK"
			Me.btnOK.Size = New System.Drawing.Size(75, 23)
			Me.btnOK.TabIndex = 20
			Me.btnOK.Text = "OK"
'			Me.btnOK.Click += New System.EventHandler(Me.btnOK_Click);
			' 
			' btnDelete
			' 
			Me.btnDelete.Location = New System.Drawing.Point(12, 42)
			Me.btnDelete.Name = "btnDelete"
			Me.btnDelete.Size = New System.Drawing.Size(75, 23)
			Me.btnDelete.TabIndex = 21
			Me.btnDelete.Text = "Delete"
'			Me.btnDelete.Click += New System.EventHandler(Me.btnDelete_Click);
			' 
			' btnMoveTop
			' 
			Me.btnMoveTop.Location = New System.Drawing.Point(12, 72)
			Me.btnMoveTop.Name = "btnMoveTop"
			Me.btnMoveTop.Size = New System.Drawing.Size(75, 23)
			Me.btnMoveTop.TabIndex = 22
			Me.btnMoveTop.Text = "Move Top"
'			Me.btnMoveTop.Click += New System.EventHandler(Me.btnMoveTop_Click);
			' 
			' btnMoveUp
			' 
			Me.btnMoveUp.Location = New System.Drawing.Point(12, 102)
			Me.btnMoveUp.Name = "btnMoveUp"
			Me.btnMoveUp.Size = New System.Drawing.Size(75, 23)
			Me.btnMoveUp.TabIndex = 23
			Me.btnMoveUp.Text = "Move Up"
'			Me.btnMoveUp.Click += New System.EventHandler(Me.btnMoveUp_Click);
			' 
			' btnMoveDown
			' 
			Me.btnMoveDown.Location = New System.Drawing.Point(12, 132)
			Me.btnMoveDown.Name = "btnMoveDown"
			Me.btnMoveDown.Size = New System.Drawing.Size(75, 23)
			Me.btnMoveDown.TabIndex = 24
			Me.btnMoveDown.Text = "Move Down"
'			Me.btnMoveDown.Click += New System.EventHandler(Me.btnMoveDown_Click);
			' 
			' btnMoveBottom
			' 
			Me.btnMoveBottom.Location = New System.Drawing.Point(12, 162)
			Me.btnMoveBottom.Name = "btnMoveBottom"
			Me.btnMoveBottom.Size = New System.Drawing.Size(75, 23)
			Me.btnMoveBottom.TabIndex = 25
			Me.btnMoveBottom.Text = "Move Bottom"
'			Me.btnMoveBottom.Click += New System.EventHandler(Me.btnMoveBottom_Click);
			' 
			' saveFileDialog1
			' 
			Me.saveFileDialog1.DefaultExt = "xml"
			Me.saveFileDialog1.Filter = "Rotator Slide Show Files|*.xml"
			' 
			' previewBox
			' 
			Me.previewBox.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.previewBox.BackColor = System.Drawing.Color.Transparent
			Me.previewBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.previewBox.Location = New System.Drawing.Point(12, 230)
			Me.previewBox.Name = "previewBox"
			Me.previewBox.Size = New System.Drawing.Size(683, 203)
			Me.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.previewBox.TabIndex = 26
			Me.previewBox.TabStop = False
			' 
			' btnCancel
			' 
			Me.btnCancel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.Location = New System.Drawing.Point(93, 439)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(75, 23)
			Me.btnCancel.TabIndex = 27
			Me.btnCancel.Text = "Cancel"
			' 
			' btnSave
			' 
			Me.btnSave.Location = New System.Drawing.Point(12, 192)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New System.Drawing.Size(75, 23)
			Me.btnSave.TabIndex = 28
			Me.btnSave.Text = "Save"
'			Me.btnSave.Click += New System.EventHandler(Me.btnSave_Click);
			' 
			' SelectImagesFileForm
			' 
			Me.AcceptButton = Me.btnOK
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New System.Drawing.Size(707, 473)
			Me.Controls.Add(Me.btnOK)
			Me.Controls.Add(Me.btnSave)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.previewBox)
			Me.Controls.Add(Me.btnMoveBottom)
			Me.Controls.Add(Me.btnMoveDown)
			Me.Controls.Add(Me.btnMoveUp)
			Me.Controls.Add(Me.btnMoveTop)
			Me.Controls.Add(Me.btnDelete)
			Me.Controls.Add(Me.radListControl1)
			Me.Controls.Add(Me.btnBrowse)
			Me.Name = "SelectImagesFileForm"
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.Text = "SelectImagesFileForm"
			Me.ThemeName = "Vista"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.SelectImagesFileForm_FormClosing);
			CType(Me.btnBrowse, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnOK, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnMoveTop, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnMoveUp, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnMoveDown, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnMoveBottom, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.previewBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub


		#End Region

		Private WithEvents btnBrowse As Telerik.WinControls.UI.RadButton
		Private WithEvents radListControl1 As Telerik.WinControls.UI.RadListControl
		Private openFileDialog As System.Windows.Forms.OpenFileDialog
		Private WithEvents btnOK As Telerik.WinControls.UI.RadButton
		Private WithEvents btnDelete As Telerik.WinControls.UI.RadButton
		Private WithEvents btnMoveTop As Telerik.WinControls.UI.RadButton
		Private WithEvents btnMoveUp As Telerik.WinControls.UI.RadButton
		Private WithEvents btnMoveDown As Telerik.WinControls.UI.RadButton
		Private WithEvents btnMoveBottom As Telerik.WinControls.UI.RadButton
		Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
		Private previewBox As System.Windows.Forms.PictureBox
		Private btnCancel As Telerik.WinControls.UI.RadButton
		Private WithEvents btnSave As Telerik.WinControls.UI.RadButton
	End Class
End Namespace