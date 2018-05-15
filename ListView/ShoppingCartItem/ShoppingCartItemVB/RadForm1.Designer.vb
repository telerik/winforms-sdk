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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.radListView1 = New Telerik.WinControls.UI.RadListView()
        Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.fluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
        Me.radListView2 = New Telerik.WinControls.UI.RadListView()
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.NwindDataSet = New ShoppingCartItemVB.NwindDataSet()
        Me.ProductsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New ShoppingCartItemVB.NwindDataSetTableAdapters.ProductsTableAdapter()
        CType(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radListView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radListView1
        '
        Me.radListView1.GroupItemSize = New System.Drawing.Size(200, 28)
        Me.radListView1.ItemSize = New System.Drawing.Size(200, 28)
        Me.radListView1.Location = New System.Drawing.Point(32, 66)
        Me.radListView1.Name = "radListView1"
        Me.radListView1.Size = New System.Drawing.Size(503, 491)
        Me.radListView1.TabIndex = 0
        Me.radListView1.ThemeName = "Fluent"
        '
        'productsBindingSource
        '
        Me.productsBindingSource.DataMember = "Products"
        '
        'radListView2
        '
        Me.radListView2.DataSource = Me.ProductsBindingSource1
        Me.radListView2.DisplayMember = "ProductName"
        Me.radListView2.GroupItemSize = New System.Drawing.Size(200, 28)
        Me.radListView2.ItemSize = New System.Drawing.Size(200, 28)
        Me.radListView2.Location = New System.Drawing.Point(648, 66)
        Me.radListView2.Name = "radListView2"
        Me.radListView2.Size = New System.Drawing.Size(441, 603)
        Me.radListView2.TabIndex = 1
        Me.radListView2.ThemeName = "Fluent"
        Me.radListView2.ValueMember = "ProductID"
        '
        'radLabel1
        '
        Me.radLabel1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel1.Location = New System.Drawing.Point(32, 25)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(50, 33)
        Me.radLabel1.TabIndex = 2
        Me.radLabel1.Text = "Cart"
        Me.radLabel1.ThemeName = "Fluent"
        '
        'radLabel2
        '
        Me.radLabel2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel2.Location = New System.Drawing.Point(648, 20)
        Me.radLabel2.Name = "radLabel2"
        Me.radLabel2.Size = New System.Drawing.Size(328, 33)
        Me.radLabel2.TabIndex = 3
        Me.radLabel2.Text = "Products (Double Click to Order)"
        Me.radLabel2.ThemeName = "Fluent"
        '
        'radLabel3
        '
        Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel3.Location = New System.Drawing.Point(392, 587)
        Me.radLabel3.Name = "radLabel3"
        Me.radLabel3.Size = New System.Drawing.Size(63, 33)
        Me.radLabel3.TabIndex = 4
        Me.radLabel3.Text = "Total:"
        '
        'radLabel4
        '
        Me.radLabel4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLabel4.Location = New System.Drawing.Point(461, 587)
        Me.radLabel4.Name = "radLabel4"
        Me.radLabel4.Size = New System.Drawing.Size(74, 33)
        Me.radLabel4.TabIndex = 5
        Me.radLabel4.Text = "000.00"
        '
        'NwindDataSet
        '
        Me.NwindDataSet.DataSetName = "NwindDataSet"
        Me.NwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource1
        '
        Me.ProductsBindingSource1.DataMember = "Products"
        Me.ProductsBindingSource1.DataSource = Me.NwindDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 736)
        Me.Controls.Add(Me.radLabel4)
        Me.Controls.Add(Me.radLabel3)
        Me.Controls.Add(Me.radLabel2)
        Me.Controls.Add(Me.radLabel1)
        Me.Controls.Add(Me.radListView2)
        Me.Controls.Add(Me.radListView1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "ShoppingCartExample"
        Me.ThemeName = "Fluent"
        CType(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radListView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private radListView1 As Telerik.WinControls.UI.RadListView
    Private fluentTheme1 As Telerik.WinControls.Themes.FluentTheme

    Private productsBindingSource As System.Windows.Forms.BindingSource

    Private radListView2 As Telerik.WinControls.UI.RadListView
    Private radLabel1 As Telerik.WinControls.UI.RadLabel
    Private radLabel2 As Telerik.WinControls.UI.RadLabel
    Private radLabel3 As Telerik.WinControls.UI.RadLabel
    Private radLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents NwindDataSet As NwindDataSet
    Friend WithEvents ProductsBindingSource1 As BindingSource
    Friend WithEvents ProductsTableAdapter As NwindDataSetTableAdapters.ProductsTableAdapter
End Class


