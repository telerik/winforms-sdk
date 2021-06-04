<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.textBox = New Telerik.WinControls.UI.RadTextBox()
        Me.dateTimePicker = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.saveButton = New Telerik.WinControls.UI.RadButton()
        CType(Me.textBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saveButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' textBox
        ' 
        Me.textBox.Location = New System.Drawing.Point(7, 4)
        Me.textBox.Name = "textBox"
        Me.textBox.Size = New System.Drawing.Size(146, 20)
        Me.textBox.TabIndex = 0
        Me.textBox.TabStop = False
        ' 
        ' dateTimePicker
        ' 
        Me.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long
        Me.dateTimePicker.Location = New System.Drawing.Point(159, 4)
        Me.dateTimePicker.MaxDate = New System.DateTime(9998, 12, 31, 0, 0, 0, 0)
        Me.dateTimePicker.MinDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
        Me.dateTimePicker.Name = "dateTimePicker"
        Me.dateTimePicker.NullableValue = New System.DateTime(2010, 7, 28, 9, 22, 47, 0)
        Me.dateTimePicker.NullDate = New System.DateTime(1753, 1, 1, 0, 0, 0, 0)
        Me.dateTimePicker.Size = New System.Drawing.Size(150, 20)
        Me.dateTimePicker.TabIndex = 1
        Me.dateTimePicker.TabStop = False
        Me.dateTimePicker.Text = "Wednesday, July 28, 2010"
        Me.dateTimePicker.Value = New System.DateTime(2010, 7, 28, 9, 22, 47, 0)
        ' 
        ' saveButton
        ' 
        Me.saveButton.Location = New System.Drawing.Point(332, 4)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(105, 20)
        Me.saveButton.TabIndex = 2
        Me.saveButton.Text = "Save"
        ' 
        ' UserControl1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.dateTimePicker)
        Me.Controls.Add(Me.textBox)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(440, 28)
        CType(Me.textBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saveButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private textBox As Telerik.WinControls.UI.RadTextBox
    Private dateTimePicker As Telerik.WinControls.UI.RadDateTimePicker
    Private saveButton As Telerik.WinControls.UI.RadButton
End Class
