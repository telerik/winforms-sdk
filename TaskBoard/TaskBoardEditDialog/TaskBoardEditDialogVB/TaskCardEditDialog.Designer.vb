<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskCardEditDialog
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
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
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.usersCheckedDropDownList = New Telerik.WinControls.UI.RadCheckedDropDownList()
        Me.titleTextBox = New Telerik.WinControls.UI.RadTextBox()
        Me.descriptionTextBox = New Telerik.WinControls.UI.RadTextBox()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.radButtonOK = New Telerik.WinControls.UI.RadButton()
        Me.radButtonCancel = New Telerik.WinControls.UI.RadButton()
        Me.tagsAutoCompleteBox = New Telerik.WinControls.UI.RadAutoCompleteBox()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usersCheckedDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.titleTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.descriptionTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        CType(Me.radButtonOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radButtonCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tagsAutoCompleteBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radLabel1
        '
        Me.radLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.radLabel1.Location = New System.Drawing.Point(3, 3)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(109, 18)
        Me.radLabel1.TabIndex = 0
        Me.radLabel1.Text = "Title:"
        '
        'radLabel2
        '
        Me.radLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.radLabel2.Location = New System.Drawing.Point(3, 29)
        Me.radLabel2.Name = "radLabel2"
        Me.radLabel2.Size = New System.Drawing.Size(109, 18)
        Me.radLabel2.TabIndex = 1
        Me.radLabel2.Text = "Description:"
        '
        'radLabel3
        '
        Me.radLabel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.radLabel3.Location = New System.Drawing.Point(3, 107)
        Me.radLabel3.Name = "radLabel3"
        Me.radLabel3.Size = New System.Drawing.Size(109, 18)
        Me.radLabel3.TabIndex = 2
        Me.radLabel3.Text = "Users:"
        '
        'radLabel4
        '
        Me.radLabel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.radLabel4.Location = New System.Drawing.Point(3, 185)
        Me.radLabel4.Name = "radLabel4"
        Me.radLabel4.Size = New System.Drawing.Size(109, 18)
        Me.radLabel4.TabIndex = 3
        Me.radLabel4.Text = "Tags:"
        '
        'usersCheckedDropDownList
        '
        Me.usersCheckedDropDownList.AutoSize = False
        Me.usersCheckedDropDownList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.usersCheckedDropDownList.DropDownAnimationEnabled = True
        Me.usersCheckedDropDownList.ItemHeight = 20
        Me.usersCheckedDropDownList.Location = New System.Drawing.Point(118, 107)
        Me.usersCheckedDropDownList.Multiline = True
        Me.usersCheckedDropDownList.Name = "usersCheckedDropDownList"
        Me.usersCheckedDropDownList.Size = New System.Drawing.Size(341, 72)
        Me.usersCheckedDropDownList.TabIndex = 4
        '
        'titleTextBox
        '
        Me.titleTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titleTextBox.Location = New System.Drawing.Point(118, 3)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New System.Drawing.Size(341, 20)
        Me.titleTextBox.TabIndex = 6
        '
        'descriptionTextBox
        '
        Me.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.descriptionTextBox.Location = New System.Drawing.Point(118, 29)
        Me.descriptionTextBox.Multiline = True
        Me.descriptionTextBox.Name = "descriptionTextBox"
        '
        '
        '
        Me.descriptionTextBox.RootElement.StretchVertically = True
        Me.descriptionTextBox.Size = New System.Drawing.Size(341, 72)
        Me.descriptionTextBox.TabIndex = 7
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.radLabel1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.radLabel4, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.descriptionTextBox, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.usersCheckedDropDownList, 1, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.titleTextBox, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.radLabel2, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.radLabel3, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 1, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.tagsAutoCompleteBox, 1, 3)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 5
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(462, 261)
        Me.tableLayoutPanel1.TabIndex = 8
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.radButtonOK, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.radButtonCancel, 1, 0)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(259, 224)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 1
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(200, 34)
        Me.tableLayoutPanel2.TabIndex = 10
        '
        'radButtonOK
        '
        Me.radButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.radButtonOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radButtonOK.Location = New System.Drawing.Point(3, 3)
        Me.radButtonOK.Name = "radButtonOK"
        Me.radButtonOK.Size = New System.Drawing.Size(94, 28)
        Me.radButtonOK.TabIndex = 8
        Me.radButtonOK.Text = "OK"
        '
        'radButtonCancel
        '
        Me.radButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.radButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radButtonCancel.Location = New System.Drawing.Point(103, 3)
        Me.radButtonCancel.Name = "radButtonCancel"
        Me.radButtonCancel.Size = New System.Drawing.Size(94, 28)
        Me.radButtonCancel.TabIndex = 9
        Me.radButtonCancel.Text = "Cancel"
        '
        'tagsAutoCompleteBox
        '
        Me.tagsAutoCompleteBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tagsAutoCompleteBox.Location = New System.Drawing.Point(118, 185)
        Me.tagsAutoCompleteBox.Name = "tagsAutoCompleteBox"
        Me.tagsAutoCompleteBox.Size = New System.Drawing.Size(341, 33)
        Me.tagsAutoCompleteBox.TabIndex = 11
        '
        'TaskCardEditDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 261)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "TaskCardEditDialog"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "TaskCardEditDialog"
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usersCheckedDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.titleTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.descriptionTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.tableLayoutPanel2.ResumeLayout(False)
        CType(Me.radButtonOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radButtonCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tagsAutoCompleteBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private radLabel2 As Telerik.WinControls.UI.RadLabel
    Private radLabel3 As Telerik.WinControls.UI.RadLabel
    Private radLabel4 As Telerik.WinControls.UI.RadLabel
    Private usersCheckedDropDownList As Telerik.WinControls.UI.RadCheckedDropDownList
    Private titleTextBox As Telerik.WinControls.UI.RadTextBox
    Private descriptionTextBox As Telerik.WinControls.UI.RadTextBox
    Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents radButtonOK As Telerik.WinControls.UI.RadButton
    Private radButtonCancel As Telerik.WinControls.UI.RadButton
    Private tagsAutoCompleteBox As Telerik.WinControls.UI.RadAutoCompleteBox
End Class

