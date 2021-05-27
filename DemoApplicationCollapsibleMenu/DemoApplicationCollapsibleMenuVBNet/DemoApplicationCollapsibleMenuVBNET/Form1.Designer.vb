Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits RadForm

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
        Me.RadCollapsiblePanel1 = New Telerik.WinControls.UI.RadCollapsiblePanel()
        Me.RadPanorama1 = New Telerik.WinControls.UI.RadPanorama()
        Me.RadListControl1 = New Telerik.WinControls.UI.RadListControl()
        CType(Me.RadCollapsiblePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadCollapsiblePanel1.PanelContainer.SuspendLayout()
        CType(Me.RadPanorama1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadCollapsiblePanel1
        '
        Me.RadCollapsiblePanel1.Location = New System.Drawing.Point(13, 13)
        Me.RadCollapsiblePanel1.Name = "RadCollapsiblePanel1"
        '
        'RadCollapsiblePanel1.PanelContainer
        '
        Me.RadCollapsiblePanel1.PanelContainer.Controls.Add(Me.RadListControl1)
        Me.RadCollapsiblePanel1.PanelContainer.Size = New System.Drawing.Size(148, 172)
        Me.RadCollapsiblePanel1.Size = New System.Drawing.Size(150, 200)
        Me.RadCollapsiblePanel1.TabIndex = 0
        Me.RadCollapsiblePanel1.Text = "RadCollapsiblePanel1"
        '
        'RadPanorama1
        '
        Me.RadPanorama1.Location = New System.Drawing.Point(295, 30)
        Me.RadPanorama1.Name = "RadPanorama1"
        Me.RadPanorama1.Size = New System.Drawing.Size(240, 150)
        Me.RadPanorama1.TabIndex = 1
        Me.RadPanorama1.Text = "RadPanorama1"
        '
        'RadListControl1
        '
        Me.RadListControl1.Location = New System.Drawing.Point(4, 4)
        Me.RadListControl1.Name = "RadListControl1"
        Me.RadListControl1.Size = New System.Drawing.Size(120, 95)
        Me.RadListControl1.TabIndex = 0
        Me.RadListControl1.Text = "RadListControl1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 377)
        Me.Controls.Add(Me.RadPanorama1)
        Me.Controls.Add(Me.RadCollapsiblePanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.RadCollapsiblePanel1.PanelContainer.ResumeLayout(False)
        CType(Me.RadCollapsiblePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanorama1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadListControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadCollapsiblePanel1 As Telerik.WinControls.UI.RadCollapsiblePanel
    Friend WithEvents RadListControl1 As Telerik.WinControls.UI.RadListControl
    Friend WithEvents RadPanorama1 As Telerik.WinControls.UI.RadPanorama

End Class
