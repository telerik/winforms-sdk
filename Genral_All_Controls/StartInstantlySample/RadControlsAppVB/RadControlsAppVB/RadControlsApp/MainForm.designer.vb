<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
        Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radDock1.SuspendLayout()
        CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolTabStrip1.SuspendLayout()
        Me.toolWindow1.SuspendLayout()
        CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.documentContainer1.SuspendLayout()
        CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.documentTabStrip1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' radDock1
        ' 
        Me.radDock1.ActiveWindow = Me.toolWindow1
        Me.radDock1.CausesValidation = False
        Me.radDock1.Controls.Add(Me.toolTabStrip1)
        Me.radDock1.Controls.Add(Me.documentContainer1)
        Me.radDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
        Me.radDock1.IsCleanUpTarget = True
        Me.radDock1.Location = New System.Drawing.Point(0, 0)
        Me.radDock1.MainDocumentContainer = Me.documentContainer1
        Me.radDock1.Name = "radDock1"
        Me.radDock1.Padding = New System.Windows.Forms.Padding(5)
        ' 
        ' 
        ' 
        Me.radDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.radDock1.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.radDock1.Size = New System.Drawing.Size(583, 452)
        Me.radDock1.SplitterWidth = 4
        Me.radDock1.TabIndex = 0
        Me.radDock1.TabStop = False
        Me.radDock1.Text = "radDock1"
        ' 
        ' documentWindow1
        ' 
        Me.documentWindow1.Location = New System.Drawing.Point(6, 30)
        Me.documentWindow1.Name = "documentWindow1"
        Me.documentWindow1.Size = New System.Drawing.Size(199, 406)
        Me.documentWindow1.Text = "documentWindow1"
        ' 
        ' toolTabStrip1
        ' 
        Me.toolTabStrip1.Controls.Add(Me.toolWindow1)
        Me.toolTabStrip1.Location = New System.Drawing.Point(5, 5)
        Me.toolTabStrip1.Name = "toolTabStrip1"
        ' 
        ' 
        ' 
        Me.toolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.toolTabStrip1.SelectedIndex = 0
        Me.toolTabStrip1.Size = New System.Drawing.Size(358, 442)
        Me.toolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(358, 200)
        Me.toolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(158, 0)
        Me.toolTabStrip1.TabIndex = 1
        Me.toolTabStrip1.TabStop = False
        ' 
        ' toolWindow1
        ' 
        Me.toolWindow1.Controls.Add(Me.radGridView1)
        Me.toolWindow1.Location = New System.Drawing.Point(1, 24)
        Me.toolWindow1.Name = "toolWindow1"
        Me.toolWindow1.Size = New System.Drawing.Size(356, 416)
        Me.toolWindow1.Text = "toolWindow1"
        ' 
        ' radGridView1
        ' 
        Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radGridView1.Location = New System.Drawing.Point(0, 0)
        Me.radGridView1.Name = "radGridView1"
        Me.radGridView1.Size = New System.Drawing.Size(356, 416)
        Me.radGridView1.TabIndex = 0
        Me.radGridView1.Text = "radGridView1"
        ' 
        ' documentContainer1
        ' 
        Me.documentContainer1.CausesValidation = False
        Me.documentContainer1.Controls.Add(Me.documentTabStrip1)
        Me.documentContainer1.Location = New System.Drawing.Point(367, 5)
        Me.documentContainer1.Name = "documentContainer1"
        ' 
        ' 
        ' 
        Me.documentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.documentContainer1.Size = New System.Drawing.Size(211, 442)
        Me.documentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(211, 200)
        Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.documentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-158, 0)
        Me.documentContainer1.SplitterWidth = 4
        Me.documentContainer1.TabIndex = 0
        Me.documentContainer1.TabStop = False
        ' 
        ' documentTabStrip1
        ' 
        Me.documentTabStrip1.CausesValidation = False
        Me.documentTabStrip1.Controls.Add(Me.documentWindow1)
        Me.documentTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.documentTabStrip1.Name = "documentTabStrip1"
        ' 
        ' 
        ' 
        Me.documentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.documentTabStrip1.SelectedIndex = 0
        Me.documentTabStrip1.Size = New System.Drawing.Size(211, 442)
        Me.documentTabStrip1.TabIndex = 0
        Me.documentTabStrip1.TabStop = False
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 452)
        Me.Controls.Add(Me.radDock1)
        Me.Name = "Form1"
        ' 
        ' 
        ' 
        Me.RootElement.ApplyShapeToControl = True
        CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radDock1.ResumeLayout(False)
        CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolTabStrip1.ResumeLayout(False)
        Me.toolWindow1.ResumeLayout(False)
        CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.documentContainer1.ResumeLayout(False)
        CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.documentTabStrip1.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
    Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Private toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Private radGridView1 As Telerik.WinControls.UI.RadGridView
End Class
