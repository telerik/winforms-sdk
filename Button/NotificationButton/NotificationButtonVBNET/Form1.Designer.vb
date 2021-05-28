Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits RadRibbonForm

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
        Me.RadButton1 = New NotificationButtonVBNET.NotificationButton()
        Me.RadButton2 = New NotificationButtonVBNET.NotificationButton()
        Me.RadButton3 = New NotificationButtonVBNET.NotificationButton()
        Me.RadRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
        Me.RibbonTab1 = New Telerik.WinControls.UI.RibbonTab()
        Me.RadRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RadButtonElement1 = New NotificationButtonElement()
        Me.RadButtonElement2 = New NotificationButtonElement()
        Me.RadButtonElement3 = New NotificationButtonElement()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(12, 193)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(150, 50)
        Me.RadButton1.TabIndex = 0
        Me.RadButton1.Text = "RadButton1"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(203, 193)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(150, 50)
        Me.RadButton2.TabIndex = 1
        Me.RadButton2.Text = "RadButton2"
        '
        'RadButton3
        '
        Me.RadButton3.Location = New System.Drawing.Point(388, 193)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(150, 50)
        Me.RadButton3.TabIndex = 2
        Me.RadButton3.Text = "RadButton3"
        '
        'RadRibbonBar1
        '
        Me.RadRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.RadItem() {Me.RibbonTab1})
        '
        '
        '
        Me.RadRibbonBar1.ExitButton.Text = "Exit"
        Me.RadRibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadRibbonBar1.Name = "RadRibbonBar1"
        '
        '
        '
        Me.RadRibbonBar1.OptionsButton.Text = "Options"
        Me.RadRibbonBar1.Size = New System.Drawing.Size(585, 162)
        Me.RadRibbonBar1.TabIndex = 3
        Me.RadRibbonBar1.Text = "Form1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.IsSelected = True
        Me.RibbonTab1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadRibbonBarGroup1})
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Notification Tab"
        '
        'RadRibbonBarGroup1
        '
        Me.RadRibbonBarGroup1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadButtonElement1, Me.RadButtonElement2, Me.RadButtonElement3})
        Me.RadRibbonBarGroup1.Name = "RadRibbonBarGroup1"
        Me.RadRibbonBarGroup1.Text = "Notification group"
        '
        'RadButtonElement1
        '
        Me.RadButtonElement1.Name = "RadButtonElement1"
        Me.RadButtonElement1.Text = "RadButtonElement1"
        '
        'RadButtonElement2
        '
        Me.RadButtonElement2.Name = "RadButtonElement2"
        Me.RadButtonElement2.Text = "RadButtonElement2"
        '
        'RadButtonElement3
        '
        Me.RadButtonElement3.Name = "RadButtonElement3"
        Me.RadButtonElement3.Text = "RadButtonElement3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 349)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadRibbonBar1)
        Me.Name = "Form1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Form1"
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadButton1 As NotificationButton
    Friend WithEvents RadButton2 As NotificationButton
    Friend WithEvents RadButton3 As NotificationButton
    Friend WithEvents RadRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
    Friend WithEvents RibbonTab1 As Telerik.WinControls.UI.RibbonTab
    Friend WithEvents RadRibbonBarGroup1 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RadButtonElement1 As NotificationButtonElement
    Friend WithEvents RadButtonElement2 As NotificationButtonElement
    Friend WithEvents RadButtonElement3 As NotificationButtonElement

End Class
