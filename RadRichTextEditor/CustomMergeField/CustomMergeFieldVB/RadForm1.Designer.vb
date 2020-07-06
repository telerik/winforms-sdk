Namespace CustomMergeField
	Partial Public Class RadForm1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
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
			Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
			Me.richTextEditorRibbonBar1 = New Telerik.WinControls.UI.RichTextEditorRibbonBar()
			Me.radRibbonFormBehavior1 = New Telerik.WinControls.UI.RadRibbonFormBehavior()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radRichTextEditor1
			' 
			Me.radRichTextEditor1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(156)))), (CInt((CByte(189)))), (CInt((CByte(232)))))
			Me.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radRichTextEditor1.Location = New System.Drawing.Point(0, 174)
			Me.radRichTextEditor1.Name = "radRichTextEditor1"
			Me.radRichTextEditor1.SelectionFill = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(78)))), (CInt((CByte(158)))), (CInt((CByte(255)))))
			Me.radRichTextEditor1.Size = New System.Drawing.Size(1271, 659)
			Me.radRichTextEditor1.TabIndex = 0
			' 
			' richTextEditorRibbonBar1
			' 
			Me.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
			Me.richTextEditorRibbonBar1.AssociatedRichTextEditor = Me.radRichTextEditor1
			Me.richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013
			Me.richTextEditorRibbonBar1.EnableKeyMap = False
			' 
			' 
			' 
			Me.richTextEditorRibbonBar1.ExitButton.Text = "Exit"
			Me.richTextEditorRibbonBar1.LocalizationSettings.LayoutModeText = "Simplified Layout"
			Me.richTextEditorRibbonBar1.Location = New System.Drawing.Point(0, 0)
			Me.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1"
			' 
			' 
			' 
			Me.richTextEditorRibbonBar1.OptionsButton.Text = "Options"
			Me.richTextEditorRibbonBar1.ShowLayoutModeButton = True
			Me.richTextEditorRibbonBar1.Size = New System.Drawing.Size(1271, 174)
			Me.richTextEditorRibbonBar1.TabIndex = 1
			Me.richTextEditorRibbonBar1.TabStop = False
			Me.richTextEditorRibbonBar1.Text = "RadForm1"
			' 
			' radRibbonFormBehavior1
			' 
			Me.radRibbonFormBehavior1.Form = Me
			' 
			' radButton1
			' 
			Me.radButton1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.radButton1.Location = New System.Drawing.Point(0, 833)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(1271, 24)
			Me.radButton1.TabIndex = 2
			Me.radButton1.Text = "Merge"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
			' 
			' RadForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1271, 857)
			Me.Controls.Add(Me.radRichTextEditor1)
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.richTextEditorRibbonBar1)
			Me.FormBehavior = Me.radRibbonFormBehavior1
			Me.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None
			Me.Name = "RadForm1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "RadForm1"
			CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
		Private richTextEditorRibbonBar1 As Telerik.WinControls.UI.RichTextEditorRibbonBar
		Private radRibbonFormBehavior1 As Telerik.WinControls.UI.RadRibbonFormBehavior
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace