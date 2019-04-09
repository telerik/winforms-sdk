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
        Me.RadVirtualGrid1 = New CustomVirtualGrid()
        Me.NwindDataSet = New VirtualGridHeaderCheckBoxVB.NwindDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New VirtualGridHeaderCheckBoxVB.NwindDataSetTableAdapters.ProductsTableAdapter()
        CType(Me.RadVirtualGrid1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NwindDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ProductsBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'RadVirtualGrid1
        '
        Me.RadVirtualGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadVirtualGrid1.Location = New System.Drawing.Point(0, 0)
        Me.RadVirtualGrid1.Name = "RadVirtualGrid1"
        Me.RadVirtualGrid1.Size = New System.Drawing.Size(292, 270)
        Me.RadVirtualGrid1.TabIndex = 0
        '
        'NwindDataSet
        '
        Me.NwindDataSet.DataSetName = "NwindDataSet"
        Me.NwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.NwindDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = true
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 270)
        Me.Controls.Add(Me.RadVirtualGrid1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = true
        Me.Text = "RadForm1"
        CType(Me.RadVirtualGrid1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NwindDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ProductsBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents RadVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
    Friend WithEvents NwindDataSet As VirtualGridHeaderCheckBoxVB.NwindDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As VirtualGridHeaderCheckBoxVB.NwindDataSetTableAdapters.ProductsTableAdapter
End Class
