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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadMultiColumnComboBox1 = New MultiComboBox_buttons_pop_up_VB.MyRadMultiColumnComboBox()
        CType(Me.RadMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadMultiColumnComboBox1
        '
        Me.RadMultiColumnComboBox1.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        '
        'RadMultiColumnComboBox1.NestedRadGridView
        '
        Me.RadMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.RadMultiColumnComboBox1.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadMultiColumnComboBox1.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = False
        Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView"
        Me.RadMultiColumnComboBox1.EditorControl.ReadOnly = True
        Me.RadMultiColumnComboBox1.EditorControl.ShowGroupPanel = False
        Me.RadMultiColumnComboBox1.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.RadMultiColumnComboBox1.EditorControl.TabIndex = 0
        Me.RadMultiColumnComboBox1.Location = New System.Drawing.Point(42, 42)
        Me.RadMultiColumnComboBox1.Name = "RadMultiColumnComboBox1"
        Me.RadMultiColumnComboBox1.Size = New System.Drawing.Size(415, 20)
        Me.RadMultiColumnComboBox1.TabIndex = 0
        Me.RadMultiColumnComboBox1.TabStop = False
        Me.RadMultiColumnComboBox1.Text = "RadMultiColumnComboBox1"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 381)
        Me.Controls.Add(Me.RadMultiColumnComboBox1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadMultiColumnComboBox1 As MyRadMultiColumnComboBox
End Class
