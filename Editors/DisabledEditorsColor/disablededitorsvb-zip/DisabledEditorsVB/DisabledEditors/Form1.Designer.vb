Namespace DisabledEditors
	Partial Public Class Form1
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
			Me.myRadSpinEditor1 = New DisabledEditors.MyRadSpinEditor()
			Me.myRadMaskedEditBox1 = New DisabledEditors.MyRadMaskedEditBox()
			Me.myRadDateTimePicker1 = New DisabledEditors.MyRadDateTimePicker()
			Me.myTextBox1 = New DisabledEditors.MyRadTextBox()
			Me.myRadDropDownList1 = New DisabledEditors.MyRadDropDownList()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			CType(Me.myRadSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myRadMaskedEditBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myRadDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myRadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myRadSpinEditor1
			' 
			Me.myRadSpinEditor1.Location = New Point(22, 38)
			Me.myRadSpinEditor1.Name = "myRadSpinEditor1"
			' 
			' 
			' 
			Me.myRadSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.myRadSpinEditor1.ShowBorder = True
			Me.myRadSpinEditor1.Size = New Size(150, 20)
			Me.myRadSpinEditor1.TabIndex = 5
			Me.myRadSpinEditor1.TabStop = False
			Me.myRadSpinEditor1.Value = New Decimal(New Integer() { 99, 0, 0, 0})
			' 
			' myRadMaskedEditBox1
			' 
			Me.myRadMaskedEditBox1.AllowPromptAsInput = False
			Me.myRadMaskedEditBox1.AutoSize = True
			Me.myRadMaskedEditBox1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.myRadMaskedEditBox1.Location = New Point(22, 64)
			Me.myRadMaskedEditBox1.MaskType = Telerik.WinControls.UI.MaskType.DateTime
			Me.myRadMaskedEditBox1.Name = "myRadMaskedEditBox1"
			Me.myRadMaskedEditBox1.SelectedText = "10"
			Me.myRadMaskedEditBox1.SelectionLength = 2
			Me.myRadMaskedEditBox1.Size = New Size(150, 20)
			Me.myRadMaskedEditBox1.TabIndex = 4
			Me.myRadMaskedEditBox1.TabStop = False
			Me.myRadMaskedEditBox1.Text = "10/4/2011 12:58 PM"
			Me.myRadMaskedEditBox1.Value = New Date(2011, 10, 4, 12, 58, 44, 670)
			' 
			' myRadDateTimePicker1
			' 
			Me.myRadDateTimePicker1.Format = DateTimePickerFormat.Long
			Me.myRadDateTimePicker1.Location = New Point(22, 90)
			Me.myRadDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
			Me.myRadDateTimePicker1.MinDate = New Date((CLng(Fix(0))))
			Me.myRadDateTimePicker1.Name = "myRadDateTimePicker1"
			Me.myRadDateTimePicker1.NullableValue = New Date(2011, 10, 4, 12, 54, 8, 247)
			Me.myRadDateTimePicker1.NullDate = New Date((CLng(Fix(0))))
			Me.myRadDateTimePicker1.Size = New Size(150, 20)
			Me.myRadDateTimePicker1.TabIndex = 3
			Me.myRadDateTimePicker1.TabStop = False
			Me.myRadDateTimePicker1.Text = "myRadDateTimePicker1"
			Me.myRadDateTimePicker1.Value = New Date(2011, 10, 4, 12, 54, 8, 247)
			' 
			' myTextBox1
			' 
			Me.myTextBox1.Location = New Point(22, 114)
			Me.myTextBox1.Name = "myTextBox1"
			Me.myTextBox1.Size = New Size(150, 20)
			Me.myTextBox1.TabIndex = 1
			Me.myTextBox1.TabStop = False
			Me.myTextBox1.Text = "This is a long long long text"
			' 
			' myRadDropDownList1
			' 
			Me.myRadDropDownList1.DropDownAnimationEnabled = True
			Me.myRadDropDownList1.Location = New Point(22, 12)
			Me.myRadDropDownList1.Name = "myRadDropDownList1"
			Me.myRadDropDownList1.ShowImageInEditorArea = True
			Me.myRadDropDownList1.Size = New Size(150, 20)
			Me.myRadDropDownList1.TabIndex = 6
			Me.myRadDropDownList1.Text = "myRadDropDownList1"
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(57, 140)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(75, 24)
			Me.radButton1.TabIndex = 7
			Me.radButton1.Text = "!Enable"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(196, 176)
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.myRadDropDownList1)
			Me.Controls.Add(Me.myRadSpinEditor1)
			Me.Controls.Add(Me.myRadMaskedEditBox1)
			Me.Controls.Add(Me.myRadDateTimePicker1)
			Me.Controls.Add(Me.myTextBox1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myRadSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myRadMaskedEditBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myRadDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myRadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private myTextBox1 As MyRadTextBox
		Private myRadDateTimePicker1 As MyRadDateTimePicker
		Private myRadMaskedEditBox1 As MyRadMaskedEditBox
		Private myRadSpinEditor1 As MyRadSpinEditor
		Private myRadDropDownList1 As MyRadDropDownList
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace

