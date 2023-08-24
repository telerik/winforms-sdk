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
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewImageColumn1 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim RowDetailsViewDefinition1 As RowDetailsInGridViewVB.RowDetailsViewDefinition = New RowDetailsInGridViewVB.RowDetailsViewDefinition()
        Me.NwindDataSet = New RowDetailsInGridViewVB.NwindDataSet()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New RowDetailsInGridViewVB.NwindDataSetTableAdapters.EmployeesTableAdapter()
        Me.radGridView1 = New RowDetailsInGridViewVB.RowDetailsGrid()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NwindDataSet
        '
        Me.NwindDataSet.DataSetName = "NwindDataSet"
        Me.NwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.NwindDataSet
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'radGridView1
        '
        Me.radGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radGridView1.DetailsColumn = Nothing
        Me.radGridView1.Location = New System.Drawing.Point(12, 32)
        '
        '
        '
        GridViewDecimalColumn1.DataType = GetType(Integer)
        GridViewDecimalColumn1.FieldName = "EmployeeID"
        GridViewDecimalColumn1.HeaderText = "EmployeeID"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.Name = "EmployeeID"
        GridViewTextBoxColumn1.FieldName = "LastName"
        GridViewTextBoxColumn1.HeaderText = "LastName"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "LastName"
        GridViewTextBoxColumn2.FieldName = "FirstName"
        GridViewTextBoxColumn2.HeaderText = "FirstName"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.Name = "FirstName"
        GridViewTextBoxColumn3.FieldName = "Title"
        GridViewTextBoxColumn3.HeaderText = "Title"
        GridViewTextBoxColumn3.IsAutoGenerated = True
        GridViewTextBoxColumn3.Name = "Title"
        GridViewTextBoxColumn4.FieldName = "TitleOfCourtesy"
        GridViewTextBoxColumn4.HeaderText = "TitleOfCourtesy"
        GridViewTextBoxColumn4.IsAutoGenerated = True
        GridViewTextBoxColumn4.Name = "TitleOfCourtesy"
        GridViewDateTimeColumn1.FieldName = "BirthDate"
        GridViewDateTimeColumn1.HeaderText = "BirthDate"
        GridViewDateTimeColumn1.IsAutoGenerated = True
        GridViewDateTimeColumn1.Name = "BirthDate"
        GridViewDateTimeColumn2.FieldName = "HireDate"
        GridViewDateTimeColumn2.HeaderText = "HireDate"
        GridViewDateTimeColumn2.IsAutoGenerated = True
        GridViewDateTimeColumn2.Name = "HireDate"
        GridViewTextBoxColumn5.FieldName = "Address"
        GridViewTextBoxColumn5.HeaderText = "Address"
        GridViewTextBoxColumn5.IsAutoGenerated = True
        GridViewTextBoxColumn5.Name = "Address"
        GridViewTextBoxColumn6.FieldName = "City"
        GridViewTextBoxColumn6.HeaderText = "City"
        GridViewTextBoxColumn6.IsAutoGenerated = True
        GridViewTextBoxColumn6.Name = "City"
        GridViewTextBoxColumn7.FieldName = "Region"
        GridViewTextBoxColumn7.HeaderText = "Region"
        GridViewTextBoxColumn7.IsAutoGenerated = True
        GridViewTextBoxColumn7.Name = "Region"
        GridViewTextBoxColumn8.FieldName = "PostalCode"
        GridViewTextBoxColumn8.HeaderText = "PostalCode"
        GridViewTextBoxColumn8.IsAutoGenerated = True
        GridViewTextBoxColumn8.Name = "PostalCode"
        GridViewTextBoxColumn9.FieldName = "Country"
        GridViewTextBoxColumn9.HeaderText = "Country"
        GridViewTextBoxColumn9.IsAutoGenerated = True
        GridViewTextBoxColumn9.Name = "Country"
        GridViewTextBoxColumn10.FieldName = "HomePhone"
        GridViewTextBoxColumn10.HeaderText = "HomePhone"
        GridViewTextBoxColumn10.IsAutoGenerated = True
        GridViewTextBoxColumn10.Name = "HomePhone"
        GridViewImageColumn1.DataType = GetType(Byte())
        GridViewImageColumn1.FieldName = "Photo"
        GridViewImageColumn1.HeaderText = "Photo"
        GridViewImageColumn1.IsAutoGenerated = True
        GridViewImageColumn1.Name = "Photo"
        GridViewTextBoxColumn11.FieldName = "Notes"
        GridViewTextBoxColumn11.HeaderText = "Notes"
        GridViewTextBoxColumn11.IsAutoGenerated = True
        GridViewTextBoxColumn11.Name = "Notes"
        Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewDateTimeColumn1, GridViewDateTimeColumn2, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewImageColumn1, GridViewTextBoxColumn11})
        Me.radGridView1.MasterTemplate.DataSource = Me.EmployeesBindingSource
        Me.radGridView1.MasterTemplate.ViewDefinition = RowDetailsViewDefinition1
        Me.radGridView1.Name = "radGridView1"
        Me.radGridView1.Size = New System.Drawing.Size(961, 465)
        Me.radGridView1.TabIndex = 0
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1005, 509)
        Me.Controls.Add(Me.radGridView1)
        Me.Name = "RadForm1"
        Me.Text = "RadForm1"
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radGridView1 As RowDetailsGrid
    Friend WithEvents NwindDataSet As NwindDataSet
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents EmployeesTableAdapter As NwindDataSetTableAdapters.EmployeesTableAdapter
End Class

