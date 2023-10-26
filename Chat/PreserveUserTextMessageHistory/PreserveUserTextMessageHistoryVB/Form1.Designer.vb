Imports Telerik.WinControls.UI

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.radListControl1 = New Telerik.WinControls.UI.RadListControl()
        Me.radChat1 = New Telerik.WinControls.UI.RadChat()
        Me.radButton1 = New Telerik.WinControls.UI.RadButton()
        Me.radButton2 = New Telerik.WinControls.UI.RadButton()
        CType((Me.radListControl1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.radChat1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.radButton1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.radButton2), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.radListControl1.ItemHeight = 24
        Me.radListControl1.Location = New System.Drawing.Point(12, 13)
        Me.radListControl1.Name = "radListControl1"
        Me.radListControl1.Size = New System.Drawing.Size(106, 213)
        Me.radListControl1.TabIndex = 1
       
        Me.radChat1.Location = New System.Drawing.Point(128, 13)
        Me.radChat1.Name = "radChat1"
        Me.radChat1.Size = New System.Drawing.Size(350, 469)
        Me.radChat1.TabIndex = 2
        Me.radChat1.Text = "radChat1"
        Me.radChat1.TimeSeparatorInterval = System.TimeSpan.Parse("1.00:00:00")
        Me.radButton1.Location = New System.Drawing.Point(12, 232)
        Me.radButton1.Name = "radButton1"
        Me.radButton1.Size = New System.Drawing.Size(106, 86)
        Me.radButton1.TabIndex = 3
        Me.radButton1.Text = "Simulate Message from Selected Member"
        Me.radButton1.TextWrap = True

        Me.radButton2.Location = New System.Drawing.Point(12, 339)
        Me.radButton2.Name = "radButton2"
        Me.radButton2.Size = New System.Drawing.Size(106, 24)
        Me.radButton2.TabIndex = 4
        Me.radButton2.Text = "Bob send message"

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 494)
        Me.Controls.Add(Me.radButton2)
        Me.Controls.Add(Me.radButton1)
        Me.Controls.Add(Me.radChat1)
        Me.Controls.Add(Me.radListControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType((Me.radListControl1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.radChat1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.radButton1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.radButton2), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Private WithEvents radListControl1 As Telerik.WinControls.UI.RadListControl
    Private WithEvents radChat1 As Telerik.WinControls.UI.RadChat
    Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
    Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
End Class
