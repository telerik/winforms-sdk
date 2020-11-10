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
        Me.components = New System.ComponentModel.Container()
        Dim SchedulerDailyPrintStyle1 As Telerik.WinControls.UI.SchedulerDailyPrintStyle = New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
        Dim AppointmentMappingInfo1 As Telerik.WinControls.UI.AppointmentMappingInfo = New Telerik.WinControls.UI.AppointmentMappingInfo()
        Dim ResourceMappingInfo1 As Telerik.WinControls.UI.ResourceMappingInfo = New Telerik.WinControls.UI.ResourceMappingInfo()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadScheduler1 = New Telerik.WinControls.UI.RadScheduler()
        Me.SchedulerBindingDataSource1 = New Telerik.WinControls.UI.SchedulerBindingDataSource()
        Me.SchedulerDataDataSet = New SchedulerDataBindingTutorialVB.SchedulerDataDataSet()
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentsTableAdapter = New SchedulerDataBindingTutorialVB.SchedulerDataDataSetTableAdapters.AppointmentsTableAdapter()
        Me.AppointmentsResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentsResourcesTableAdapter = New SchedulerDataBindingTutorialVB.SchedulerDataDataSetTableAdapters.AppointmentsResourcesTableAdapter()
        Me.ResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResourcesTableAdapter = New SchedulerDataBindingTutorialVB.SchedulerDataDataSetTableAdapters.ResourcesTableAdapter()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerBindingDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerBindingDataSource1.EventProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerBindingDataSource1.ResourceProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton1
        '
        Me.RadButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadButton1.Location = New System.Drawing.Point(0, 0)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(629, 24)
        Me.RadButton1.TabIndex = 0
        Me.RadButton1.Text = "Save"
        '
        'RadScheduler1
        '
        Me.RadScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.RadScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadScheduler1.Location = New System.Drawing.Point(0, 24)
        Me.RadScheduler1.Name = "RadScheduler1"
        SchedulerDailyPrintStyle1.AppointmentFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SchedulerDailyPrintStyle1.DateEndRange = New Date(2020, 11, 15, 0, 0, 0, 0)
        SchedulerDailyPrintStyle1.DateHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        SchedulerDailyPrintStyle1.DateStartRange = New Date(2020, 11, 10, 0, 0, 0, 0)
        SchedulerDailyPrintStyle1.PageHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold)
        Me.RadScheduler1.PrintStyle = SchedulerDailyPrintStyle1
        Me.RadScheduler1.Size = New System.Drawing.Size(629, 586)
        Me.RadScheduler1.TabIndex = 1
        '
        'SchedulerBindingDataSource1
        '
        '
        '
        '
        Me.SchedulerBindingDataSource1.EventProvider.Mapping = AppointmentMappingInfo1
        '
        '
        '
        Me.SchedulerBindingDataSource1.ResourceProvider.Mapping = ResourceMappingInfo1
        '
        'SchedulerDataDataSet
        '
        Me.SchedulerDataDataSet.DataSetName = "SchedulerDataDataSet"
        Me.SchedulerDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "Appointments"
        Me.AppointmentsBindingSource.DataSource = Me.SchedulerDataDataSet
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'AppointmentsResourcesBindingSource
        '
        Me.AppointmentsResourcesBindingSource.DataMember = "AppointmentsResources"
        Me.AppointmentsResourcesBindingSource.DataSource = Me.SchedulerDataDataSet
        '
        'AppointmentsResourcesTableAdapter
        '
        Me.AppointmentsResourcesTableAdapter.ClearBeforeFill = True
        '
        'ResourcesBindingSource
        '
        Me.ResourcesBindingSource.DataMember = "Resources"
        Me.ResourcesBindingSource.DataSource = Me.SchedulerDataDataSet
        '
        'ResourcesTableAdapter
        '
        Me.ResourcesTableAdapter.ClearBeforeFill = True
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 610)
        Me.Controls.Add(Me.RadScheduler1)
        Me.Controls.Add(Me.RadButton1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerBindingDataSource1.EventProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerBindingDataSource1.ResourceProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerBindingDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadScheduler1 As Telerik.WinControls.UI.RadScheduler
    Friend WithEvents SchedulerBindingDataSource1 As Telerik.WinControls.UI.SchedulerBindingDataSource
    Friend WithEvents SchedulerDataDataSet As SchedulerDataBindingTutorialVB.SchedulerDataDataSet
    Friend WithEvents AppointmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentsTableAdapter As SchedulerDataBindingTutorialVB.SchedulerDataDataSetTableAdapters.AppointmentsTableAdapter
    Friend WithEvents AppointmentsResourcesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentsResourcesTableAdapter As SchedulerDataBindingTutorialVB.SchedulerDataDataSetTableAdapters.AppointmentsResourcesTableAdapter
    Friend WithEvents ResourcesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResourcesTableAdapter As SchedulerDataBindingTutorialVB.SchedulerDataDataSetTableAdapters.ResourcesTableAdapter
End Class
