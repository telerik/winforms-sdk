<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
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
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.lblSelectedValue = New Telerik.WinControls.UI.RadLabel()
        Me.lblSelectedItem = New Telerik.WinControls.UI.RadLabel()
        Me.lblSelectedIndex = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSelectedValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSelectedItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSelectedIndex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.DropDownAnimationEnabled = True
        Me.RadDropDownList1.Location = New System.Drawing.Point(131, 12)
        Me.RadDropDownList1.MaxDropDownItems = 0
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.ShowImageInEditorArea = True
        Me.RadDropDownList1.Size = New System.Drawing.Size(167, 20)
        Me.RadDropDownList1.TabIndex = 0
        Me.RadDropDownList1.Text = "RadDropDownList1"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 14)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(103, 18)
        Me.RadLabel1.TabIndex = 1
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(304, 14)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(76, 18)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "SelectedIndex"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(304, 38)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(71, 18)
        Me.RadLabel3.TabIndex = 3
        Me.RadLabel3.Text = "SelectedItem"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(304, 63)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(76, 18)
        Me.RadLabel4.TabIndex = 4
        Me.RadLabel4.Text = "SelectedValue"
        '
        'lblSelectedValue
        '
        Me.lblSelectedValue.Location = New System.Drawing.Point(386, 63)
        Me.lblSelectedValue.Name = "lblSelectedValue"
        Me.lblSelectedValue.Size = New System.Drawing.Size(32, 18)
        Me.lblSelectedValue.TabIndex = 5
        Me.lblSelectedValue.Text = "value"
        '
        'lblSelectedItem
        '
        Me.lblSelectedItem.Location = New System.Drawing.Point(386, 38)
        Me.lblSelectedItem.Name = "lblSelectedItem"
        Me.lblSelectedItem.Size = New System.Drawing.Size(29, 18)
        Me.lblSelectedItem.TabIndex = 6
        Me.lblSelectedItem.Text = "Item"
        '
        'lblSelectedIndex
        '
        Me.lblSelectedIndex.Location = New System.Drawing.Point(386, 14)
        Me.lblSelectedIndex.Name = "lblSelectedIndex"
        Me.lblSelectedIndex.Size = New System.Drawing.Size(33, 18)
        Me.lblSelectedIndex.TabIndex = 7
        Me.lblSelectedIndex.Text = "Index"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Location = New System.Drawing.Point(12, 87)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(49, 20)
        Me.RadTextBox1.TabIndex = 8
        Me.RadTextBox1.TabStop = False
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(70, 87)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(184, 18)
        Me.RadLabel5.TabIndex = 9
        Me.RadLabel5.Text = "(Focus to leave RadDropDownList1)"
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(12, 113)
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(524, 150)
        Me.RadGridView1.TabIndex = 10
        Me.RadGridView1.Text = "RadGridView1"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 278)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.lblSelectedIndex)
        Me.Controls.Add(Me.lblSelectedItem)
        Me.Controls.Add(Me.lblSelectedValue)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadDropDownList1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "VB Example"
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSelectedValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSelectedItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSelectedIndex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblSelectedValue As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblSelectedItem As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblSelectedIndex As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
End Class

