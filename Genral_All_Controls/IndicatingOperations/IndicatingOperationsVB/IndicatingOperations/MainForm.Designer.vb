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
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.rbtnBind = New Telerik.WinControls.UI.RadButton()
        Me.rbtnPrepareDataSource = New Telerik.WinControls.UI.RadButton()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.RadWaitingBar1 = New Telerik.WinControls.UI.RadWaitingBar()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.rbtnBind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtnPrepareDataSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGridView1.SuspendLayout()
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.rbtnBind)
        Me.RadPanel1.Controls.Add(Me.rbtnPrepareDataSource)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadPanel1.Location = New System.Drawing.Point(0, 315)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(463, 26)
        Me.RadPanel1.TabIndex = 0
        Me.RadPanel1.Text = "RadPanel1"
        '
        'rbtnBind
        '
        Me.rbtnBind.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbtnBind.Location = New System.Drawing.Point(232, 0)
        Me.rbtnBind.Name = "rbtnBind"
        Me.rbtnBind.Size = New System.Drawing.Size(231, 26)
        Me.rbtnBind.TabIndex = 1
        Me.rbtnBind.Text = "2. Bind"
        '
        'rbtnPrepareDataSource
        '
        Me.rbtnPrepareDataSource.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbtnPrepareDataSource.Location = New System.Drawing.Point(0, 0)
        Me.rbtnPrepareDataSource.Name = "rbtnPrepareDataSource"
        Me.rbtnPrepareDataSource.Size = New System.Drawing.Size(232, 26)
        Me.rbtnPrepareDataSource.TabIndex = 0
        Me.rbtnPrepareDataSource.Text = "1. Prepare Data Source"
        '
        'RadGridView1
        '
        Me.RadGridView1.Controls.Add(Me.RadWaitingBar1)
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridView1.Location = New System.Drawing.Point(0, 0)
        '
        'RadGridView1
        '
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Size = New System.Drawing.Size(463, 315)
        Me.RadGridView1.TabIndex = 1
        Me.RadGridView1.Text = "RadGridView1"
        '
        'RadWaitingBar1
        '
        Me.RadWaitingBar1.Location = New System.Drawing.Point(129, 145)
        Me.RadWaitingBar1.Name = "RadWaitingBar1"
        Me.RadWaitingBar1.Size = New System.Drawing.Size(220, 30)
        Me.RadWaitingBar1.TabIndex = 0
        Me.RadWaitingBar1.Text = "RadWaitingBar1"
        Me.RadWaitingBar1.WaitingIndicatorSize = New System.Drawing.Size(50, 30)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 341)
        Me.Controls.Add(Me.RadGridView1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "MainForm"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "MainForm"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.rbtnBind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtnPrepareDataSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGridView1.ResumeLayout(False)
        CType(Me.RadWaitingBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rbtnBind As Telerik.WinControls.UI.RadButton
    Friend WithEvents rbtnPrepareDataSource As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadWaitingBar1 As Telerik.WinControls.UI.RadWaitingBar

End Class
