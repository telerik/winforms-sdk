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
        Me.RadTreeView1 = New Telerik.WinControls.UI.RadTreeView()
        Me.NwindDataSet = New TreeViewDifferentCustomNodesVB.NwindDataSet()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesTableAdapter = New TreeViewDifferentCustomNodesVB.NwindDataSetTableAdapters.CategoriesTableAdapter()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New TreeViewDifferentCustomNodesVB.NwindDataSetTableAdapters.ProductsTableAdapter()
        CType(Me.RadTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTreeView1
        '
        Me.RadTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadTreeView1.Location = New System.Drawing.Point(0, 0)
        Me.RadTreeView1.Name = "RadTreeView1"
        Me.RadTreeView1.Size = New System.Drawing.Size(292, 270)
        Me.RadTreeView1.SpacingBetweenNodes = -1
        Me.RadTreeView1.TabIndex = 0
        '
        'NwindDataSet
        '
        Me.NwindDataSet.DataSetName = "NwindDataSet"
        Me.NwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "Categories"
        Me.CategoriesBindingSource.DataSource = Me.NwindDataSet
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.NwindDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 270)
        Me.Controls.Add(Me.RadTreeView1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.RadTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadTreeView1 As Telerik.WinControls.UI.RadTreeView
    Friend WithEvents NwindDataSet As TreeViewDifferentCustomNodesVB.NwindDataSet
    Friend WithEvents CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriesTableAdapter As TreeViewDifferentCustomNodesVB.NwindDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As TreeViewDifferentCustomNodesVB.NwindDataSetTableAdapters.ProductsTableAdapter
End Class
