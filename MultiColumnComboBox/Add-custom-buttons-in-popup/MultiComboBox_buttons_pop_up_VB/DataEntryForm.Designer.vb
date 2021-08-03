<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataEntryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataEntryForm))
        Me.RadBindingNavigator1 = New Telerik.WinControls.UI.RadBindingNavigator()
        Me.RadBindingNavigator1RowElement = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.RadBindingNavigator1FirstStrip = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.RadBindingNavigator1MoveFirstItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadBindingNavigator1MovePreviousItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadBindingNavigator1PositionItem = New Telerik.WinControls.UI.CommandBarTextBox()
        Me.RadBindingNavigator1CountItem = New Telerik.WinControls.UI.CommandBarLabel()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadBindingNavigator1MoveNextItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadBindingNavigator1MoveLastItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.RadBindingNavigator1SecondStrip = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.RadBindingNavigator1AddNewItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadBindingNavigator1DeleteItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.RadDataEntry1 = New Telerik.WinControls.UI.RadDataEntry()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.RadBindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDataEntry1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDataEntry1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadBindingNavigator1
        '
        Me.RadBindingNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadBindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.RadBindingNavigator1.Name = "RadBindingNavigator1"
        Me.RadBindingNavigator1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.RadBindingNavigator1RowElement})
        Me.RadBindingNavigator1.Size = New System.Drawing.Size(563, 30)
        Me.RadBindingNavigator1.TabIndex = 0
        '
        'RadBindingNavigator1RowElement
        '
        Me.RadBindingNavigator1RowElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadBindingNavigator1RowElement.Name = "RadBindingNavigator1RowElement"
        Me.RadBindingNavigator1RowElement.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.RadBindingNavigator1FirstStrip, Me.RadBindingNavigator1SecondStrip})
        '
        'RadBindingNavigator1FirstStrip
        '
        Me.RadBindingNavigator1FirstStrip.DisplayName = "RadBindingNavigator1FirstStrip"
        Me.RadBindingNavigator1FirstStrip.EnableDragging = False
        '
        '
        '
        Me.RadBindingNavigator1FirstStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        Me.RadBindingNavigator1FirstStrip.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.RadBindingNavigator1MoveFirstItem, Me.CommandBarSeparator1, Me.RadBindingNavigator1MovePreviousItem, Me.CommandBarSeparator2, Me.RadBindingNavigator1PositionItem, Me.RadBindingNavigator1CountItem, Me.CommandBarSeparator3, Me.RadBindingNavigator1MoveNextItem, Me.CommandBarSeparator4, Me.RadBindingNavigator1MoveLastItem})
        Me.RadBindingNavigator1FirstStrip.MinSize = New System.Drawing.Size(0, 0)
        '
        '
        '
        Me.RadBindingNavigator1FirstStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.RadBindingNavigator1FirstStrip.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.RadBindingNavigator1FirstStrip.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadBindingNavigator1MoveFirstItem
        '
        Me.RadBindingNavigator1MoveFirstItem.Image = CType(resources.GetObject("RadBindingNavigator1MoveFirstItem.Image"), System.Drawing.Image)
        Me.RadBindingNavigator1MoveFirstItem.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RadBindingNavigator1MoveFirstItem.Name = "RadBindingNavigator1MoveFirstItem"
        Me.RadBindingNavigator1MoveFirstItem.SvgImageXml = resources.GetString("RadBindingNavigator1MoveFirstItem.SvgImageXml")
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'RadBindingNavigator1MovePreviousItem
        '
        Me.RadBindingNavigator1MovePreviousItem.Image = CType(resources.GetObject("RadBindingNavigator1MovePreviousItem.Image"), System.Drawing.Image)
        Me.RadBindingNavigator1MovePreviousItem.Name = "RadBindingNavigator1MovePreviousItem"
        Me.RadBindingNavigator1MovePreviousItem.SvgImageXml = resources.GetString("RadBindingNavigator1MovePreviousItem.SvgImageXml")
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'RadBindingNavigator1PositionItem
        '
        Me.RadBindingNavigator1PositionItem.Name = "RadBindingNavigator1PositionItem"
        '
        'RadBindingNavigator1CountItem
        '
        Me.RadBindingNavigator1CountItem.Name = "RadBindingNavigator1CountItem"
        Me.RadBindingNavigator1CountItem.Text = "of {0}"
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'RadBindingNavigator1MoveNextItem
        '
        Me.RadBindingNavigator1MoveNextItem.Image = CType(resources.GetObject("RadBindingNavigator1MoveNextItem.Image"), System.Drawing.Image)
        Me.RadBindingNavigator1MoveNextItem.Name = "RadBindingNavigator1MoveNextItem"
        Me.RadBindingNavigator1MoveNextItem.SvgImageXml = resources.GetString("RadBindingNavigator1MoveNextItem.SvgImageXml")
        '
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
        '
        'RadBindingNavigator1MoveLastItem
        '
        Me.RadBindingNavigator1MoveLastItem.Image = CType(resources.GetObject("RadBindingNavigator1MoveLastItem.Image"), System.Drawing.Image)
        Me.RadBindingNavigator1MoveLastItem.Name = "RadBindingNavigator1MoveLastItem"
        Me.RadBindingNavigator1MoveLastItem.SvgImageXml = resources.GetString("RadBindingNavigator1MoveLastItem.SvgImageXml")
        '
        'RadBindingNavigator1SecondStrip
        '
        Me.RadBindingNavigator1SecondStrip.DisplayName = "RadBindingNavigator1SecondStrip"
        Me.RadBindingNavigator1SecondStrip.EnableDragging = False
        '
        '
        '
        Me.RadBindingNavigator1SecondStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        Me.RadBindingNavigator1SecondStrip.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.RadBindingNavigator1AddNewItem, Me.CommandBarSeparator5, Me.RadBindingNavigator1DeleteItem})
        Me.RadBindingNavigator1SecondStrip.MinSize = New System.Drawing.Size(0, 0)
        '
        '
        '
        Me.RadBindingNavigator1SecondStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.RadBindingNavigator1SecondStrip.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.RadBindingNavigator1SecondStrip.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadBindingNavigator1AddNewItem
        '
        Me.RadBindingNavigator1AddNewItem.Image = CType(resources.GetObject("RadBindingNavigator1AddNewItem.Image"), System.Drawing.Image)
        Me.RadBindingNavigator1AddNewItem.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RadBindingNavigator1AddNewItem.Name = "RadBindingNavigator1AddNewItem"
        Me.RadBindingNavigator1AddNewItem.SvgImageXml = resources.GetString("RadBindingNavigator1AddNewItem.SvgImageXml")
        '
        'CommandBarSeparator5
        '
        Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
        Me.CommandBarSeparator5.VisibleInOverflowMenu = False
        '
        'RadBindingNavigator1DeleteItem
        '
        Me.RadBindingNavigator1DeleteItem.Image = CType(resources.GetObject("RadBindingNavigator1DeleteItem.Image"), System.Drawing.Image)
        Me.RadBindingNavigator1DeleteItem.Name = "RadBindingNavigator1DeleteItem"
        Me.RadBindingNavigator1DeleteItem.SvgImageXml = resources.GetString("RadBindingNavigator1DeleteItem.SvgImageXml")
        '
        'RadDataEntry1
        '
        Me.RadDataEntry1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDataEntry1.Location = New System.Drawing.Point(0, 30)
        Me.RadDataEntry1.Name = "RadDataEntry1"
        '
        'RadDataEntry1.PanelContainer
        '
        Me.RadDataEntry1.PanelContainer.Size = New System.Drawing.Size(561, 347)
        Me.RadDataEntry1.Size = New System.Drawing.Size(563, 349)
        Me.RadDataEntry1.TabIndex = 1
        '
        'DataEntryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 379)
        Me.Controls.Add(Me.RadDataEntry1)
        Me.Controls.Add(Me.RadBindingNavigator1)
        Me.Name = "DataEntryForm"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "DataEntryForm"
        CType(Me.RadBindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDataEntry1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDataEntry1.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadBindingNavigator1 As Telerik.WinControls.UI.RadBindingNavigator
    Friend WithEvents RadBindingNavigator1RowElement As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents RadBindingNavigator1FirstStrip As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents RadBindingNavigator1MoveFirstItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadBindingNavigator1MovePreviousItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadBindingNavigator1PositionItem As Telerik.WinControls.UI.CommandBarTextBox
    Friend WithEvents RadBindingNavigator1CountItem As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadBindingNavigator1MoveNextItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadBindingNavigator1MoveLastItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadBindingNavigator1SecondStrip As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents RadBindingNavigator1AddNewItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadBindingNavigator1DeleteItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadDataEntry1 As Telerik.WinControls.UI.RadDataEntry
    Friend WithEvents BindingSource1 As BindingSource
End Class

