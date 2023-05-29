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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim schedulerDailyPrintStyle1 As Telerik.WinControls.UI.SchedulerDailyPrintStyle = New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
        Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
        Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
        CType((Me.radSchedulerNavigator1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.radScheduler1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1
        Me.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd"
        Me.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.radSchedulerNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
        Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
        Me.radSchedulerNavigator1.RootElement.StretchVertically = False
        Me.radSchedulerNavigator1.Size = New System.Drawing.Size(745, 77)
        Me.radSchedulerNavigator1.TabIndex = 0
        Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radScheduler1.Location = New System.Drawing.Point(0, 77)
        Me.radScheduler1.Name = "radScheduler1"
        Me.radScheduler1.PrintStyle = schedulerDailyPrintStyle1
        Me.radScheduler1.Size = New System.Drawing.Size(745, 463)
        Me.radScheduler1.TabIndex = 1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 540)
        Me.Controls.Add(Me.radScheduler1)
        Me.Controls.Add(Me.radSchedulerNavigator1)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType((Me.radSchedulerNavigator1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.radScheduler1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
    Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
End Class
