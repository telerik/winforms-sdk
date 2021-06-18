<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim DateTimeInterval1 As Telerik.WinControls.UI.DateTimeInterval = New Telerik.WinControls.UI.DateTimeInterval
        Me.RadScheduler1 = New Telerik.WinControls.UI.RadScheduler
        Me.RadSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator
        CType(Me.RadScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadScheduler1
        '
        DateTimeInterval1.End = New Date(CType(0, Long))
        DateTimeInterval1.Start = New Date(CType(0, Long))
        Me.RadScheduler1.AccessibleInterval = DateTimeInterval1
        Me.RadScheduler1.AppointmentTitleFormat = Nothing
        Me.RadScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.RadScheduler1.DataSource = Nothing
        Me.RadScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
        Me.RadScheduler1.HeaderFormat = "dd dddd"
        Me.RadScheduler1.Location = New System.Drawing.Point(0, 77)
        Me.RadScheduler1.Name = "RadScheduler1"
        Me.RadScheduler1.Size = New System.Drawing.Size(596, 409)
        Me.RadScheduler1.TabIndex = 0
        Me.RadScheduler1.Text = "RadScheduler1"
        '
        'RadSchedulerNavigator1
        '
        Me.RadSchedulerNavigator1.AssociatedScheduler = Nothing
        Me.RadSchedulerNavigator1.DateFormat = "yyyy/MM/dd"
        Me.RadSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadSchedulerNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.RadSchedulerNavigator1.Name = "RadSchedulerNavigator1"
        Me.RadSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
        '
        '
        '
        Me.RadSchedulerNavigator1.RootElement.StretchVertically = False
        Me.RadSchedulerNavigator1.Size = New System.Drawing.Size(596, 77)
        Me.RadSchedulerNavigator1.TabIndex = 1
        Me.RadSchedulerNavigator1.Text = "RadSchedulerNavigator1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 486)
        Me.Controls.Add(Me.RadScheduler1)
        Me.Controls.Add(Me.RadSchedulerNavigator1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadScheduler1 As Telerik.WinControls.UI.RadScheduler
    Friend WithEvents RadSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator

End Class
