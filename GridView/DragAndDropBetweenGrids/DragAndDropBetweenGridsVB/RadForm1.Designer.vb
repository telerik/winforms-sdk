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
        Dim TableViewDefinition7 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition8 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.leftGrid = New DragAndDropBetweenGridsVB.DragAndDropRadGrid()
        Me.rightGrid = New DragAndDropBetweenGridsVB.DragAndDropRadGrid()
        Me.btnUnbound = New Telerik.WinControls.UI.RadButton()
        Me.btnBoundObjects = New Telerik.WinControls.UI.RadButton()
        Me.btnBoundDataSet = New Telerik.WinControls.UI.RadButton()
        CType(Me.leftGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leftGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUnbound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBoundObjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBoundDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leftGrid
        '
        Me.leftGrid.Location = New System.Drawing.Point(42, 65)
        '
        '
        '
        Me.leftGrid.MasterTemplate.MultiSelect = True
        Me.leftGrid.MasterTemplate.ViewDefinition = TableViewDefinition7
        Me.leftGrid.Name = "leftGrid"
        Me.leftGrid.Size = New System.Drawing.Size(240, 150)
        Me.leftGrid.TabIndex = 0
        '
        'rightGrid
        '
        Me.rightGrid.Location = New System.Drawing.Point(407, 65)
        '
        '
        '
        Me.rightGrid.MasterTemplate.MultiSelect = True
        Me.rightGrid.MasterTemplate.ViewDefinition = TableViewDefinition8
        Me.rightGrid.Name = "rightGrid"
        Me.rightGrid.Size = New System.Drawing.Size(240, 150)
        Me.rightGrid.TabIndex = 1
        '
        'btnUnbound
        '
        Me.btnUnbound.Location = New System.Drawing.Point(4, 283)
        Me.btnUnbound.Name = "btnUnbound"
        Me.btnUnbound.Size = New System.Drawing.Size(110, 24)
        Me.btnUnbound.TabIndex = 2
        Me.btnUnbound.Text = "Unbound"
        '
        'btnBoundObjects
        '
        Me.btnBoundObjects.Location = New System.Drawing.Point(157, 282)
        Me.btnBoundObjects.Name = "btnBoundObjects"
        Me.btnBoundObjects.Size = New System.Drawing.Size(110, 24)
        Me.btnBoundObjects.TabIndex = 3
        Me.btnBoundObjects.Text = "Bound Objects"
        '
        'btnBoundDataSet
        '
        Me.btnBoundDataSet.Location = New System.Drawing.Point(330, 281)
        Me.btnBoundDataSet.Name = "btnBoundDataSet"
        Me.btnBoundDataSet.Size = New System.Drawing.Size(110, 24)
        Me.btnBoundDataSet.TabIndex = 4
        Me.btnBoundDataSet.Text = "Bound DataSet"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 321)
        Me.Controls.Add(Me.btnBoundDataSet)
        Me.Controls.Add(Me.btnBoundObjects)
        Me.Controls.Add(Me.btnUnbound)
        Me.Controls.Add(Me.rightGrid)
        Me.Controls.Add(Me.leftGrid)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.leftGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leftGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUnbound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBoundObjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBoundDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents leftGrid As DragAndDropRadGrid
    Friend WithEvents rightGrid As DragAndDropRadGrid
    Friend WithEvents btnUnbound As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnBoundObjects As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnBoundDataSet As Telerik.WinControls.UI.RadButton
End Class
