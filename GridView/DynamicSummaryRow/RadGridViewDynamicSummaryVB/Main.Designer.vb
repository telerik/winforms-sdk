<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.RadGroupOptions = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabelEvents = New Telerik.WinControls.UI.RadLabel()
        Me.RadListControlEvents = New Telerik.WinControls.UI.RadListControl()
        Me.RadLabelColumn = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownListSummaryColumn = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabelSummaryRowPosition = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownListSummaryPosition = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadCheckBoxEnabled = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadGroupBoxGrid = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGridViewDynamicSummary1 = New RadGridViewDynamicSummary.GridView.RadGridViewDynamicSummary()
        CType(Me.RadGroupOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupOptions.SuspendLayout()
        CType(Me.RadLabelEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadListControlEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabelColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownListSummaryColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabelSummaryRowPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownListSummaryPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBoxEnabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBoxGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxGrid.SuspendLayout()
        CType(Me.RadGridViewDynamicSummary1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupOptions
        '
        Me.RadGroupOptions.Controls.Add(Me.RadLabelEvents)
        Me.RadGroupOptions.Controls.Add(Me.RadListControlEvents)
        Me.RadGroupOptions.Controls.Add(Me.RadLabelColumn)
        Me.RadGroupOptions.Controls.Add(Me.RadDropDownListSummaryColumn)
        Me.RadGroupOptions.Controls.Add(Me.RadLabelSummaryRowPosition)
        Me.RadGroupOptions.Controls.Add(Me.RadDropDownListSummaryPosition)
        Me.RadGroupOptions.Controls.Add(Me.RadCheckBoxEnabled)
        Me.RadGroupOptions.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadGroupOptions.FooterImageIndex = -1
        Me.RadGroupOptions.FooterImageKey = ""
        Me.RadGroupOptions.HeaderImageIndex = -1
        Me.RadGroupOptions.HeaderImageKey = ""
        Me.RadGroupOptions.HeaderMargin = New System.Windows.Forms.Padding(0)
        Me.RadGroupOptions.HeaderText = "Options"
        Me.RadGroupOptions.Location = New System.Drawing.Point(540, 0)
        Me.RadGroupOptions.Name = "RadGroupOptions"
        Me.RadGroupOptions.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        '
        '
        '
        Me.RadGroupOptions.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.RadGroupOptions.Size = New System.Drawing.Size(251, 341)
        Me.RadGroupOptions.TabIndex = 0
        Me.RadGroupOptions.Text = "Options"
        '
        'RadLabelEvents
        '
        Me.RadLabelEvents.Location = New System.Drawing.Point(23, 199)
        Me.RadLabelEvents.Name = "RadLabelEvents"
        Me.RadLabelEvents.Size = New System.Drawing.Size(38, 18)
        Me.RadLabelEvents.TabIndex = 5
        Me.RadLabelEvents.Text = "Events"
        '
        'RadListControlEvents
        '
        Me.RadListControlEvents.CaseSensitiveSort = True
        Me.RadListControlEvents.Location = New System.Drawing.Point(23, 223)
        Me.RadListControlEvents.Name = "RadListControlEvents"
        Me.RadListControlEvents.Size = New System.Drawing.Size(215, 105)
        Me.RadListControlEvents.TabIndex = 5
        Me.RadListControlEvents.Text = "RadListControl1"
        '
        'RadLabelColumn
        '
        Me.RadLabelColumn.Location = New System.Drawing.Point(23, 134)
        Me.RadLabelColumn.Name = "RadLabelColumn"
        Me.RadLabelColumn.Size = New System.Drawing.Size(95, 18)
        Me.RadLabelColumn.TabIndex = 4
        Me.RadLabelColumn.Text = "Summary Column"
        '
        'RadDropDownListSummaryColumn
        '
        Me.RadDropDownListSummaryColumn.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Selected = True
        RadListDataItem1.Text = "Income"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Date Paid"
        RadListDataItem2.TextWrap = True
        Me.RadDropDownListSummaryColumn.Items.Add(RadListDataItem1)
        Me.RadDropDownListSummaryColumn.Items.Add(RadListDataItem2)
        Me.RadDropDownListSummaryColumn.Location = New System.Drawing.Point(23, 154)
        Me.RadDropDownListSummaryColumn.Name = "RadDropDownListSummaryColumn"
        Me.RadDropDownListSummaryColumn.Size = New System.Drawing.Size(215, 22)
        Me.RadDropDownListSummaryColumn.TabIndex = 3
        Me.RadDropDownListSummaryColumn.Text = "Income"
        '
        'RadLabelSummaryRowPosition
        '
        Me.RadLabelSummaryRowPosition.Location = New System.Drawing.Point(23, 69)
        Me.RadLabelSummaryRowPosition.Name = "RadLabelSummaryRowPosition"
        Me.RadLabelSummaryRowPosition.Size = New System.Drawing.Size(121, 18)
        Me.RadLabelSummaryRowPosition.TabIndex = 2
        Me.RadLabelSummaryRowPosition.Text = "Summary Row Position"
        '
        'RadDropDownListSummaryPosition
        '
        Me.RadDropDownListSummaryPosition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem3.Text = "Top"
        RadListDataItem3.TextWrap = True
        RadListDataItem4.Selected = True
        RadListDataItem4.Text = "Bottom"
        RadListDataItem4.TextWrap = True
        Me.RadDropDownListSummaryPosition.Items.Add(RadListDataItem3)
        Me.RadDropDownListSummaryPosition.Items.Add(RadListDataItem4)
        Me.RadDropDownListSummaryPosition.Location = New System.Drawing.Point(23, 89)
        Me.RadDropDownListSummaryPosition.Name = "RadDropDownListSummaryPosition"
        Me.RadDropDownListSummaryPosition.Size = New System.Drawing.Size(215, 22)
        Me.RadDropDownListSummaryPosition.TabIndex = 1
        Me.RadDropDownListSummaryPosition.Text = "Bottom"
        '
        'RadCheckBoxEnabled
        '
        Me.RadCheckBoxEnabled.Location = New System.Drawing.Point(23, 34)
        Me.RadCheckBoxEnabled.Name = "RadCheckBoxEnabled"
        Me.RadCheckBoxEnabled.Size = New System.Drawing.Size(175, 18)
        Me.RadCheckBoxEnabled.TabIndex = 0
        Me.RadCheckBoxEnabled.Text = "Enable Dynamic Summary Row"
        '
        'RadGroupBoxGrid
        '
        Me.RadGroupBoxGrid.Controls.Add(Me.RadGridViewDynamicSummary1)
        Me.RadGroupBoxGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBoxGrid.FooterImageIndex = -1
        Me.RadGroupBoxGrid.FooterImageKey = ""
        Me.RadGroupBoxGrid.HeaderImageIndex = -1
        Me.RadGroupBoxGrid.HeaderImageKey = ""
        Me.RadGroupBoxGrid.HeaderMargin = New System.Windows.Forms.Padding(0)
        Me.RadGroupBoxGrid.HeaderText = "RadGridView Dynamic Summary Row"
        Me.RadGroupBoxGrid.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBoxGrid.Name = "RadGroupBoxGrid"
        Me.RadGroupBoxGrid.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        '
        '
        '
        Me.RadGroupBoxGrid.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.RadGroupBoxGrid.Size = New System.Drawing.Size(540, 341)
        Me.RadGroupBoxGrid.TabIndex = 1
        Me.RadGroupBoxGrid.Text = "RadGridView Dynamic Summary Row"
        '
        'RadGridViewDynamicSummary1
        '
        Me.RadGridViewDynamicSummary1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridViewDynamicSummary1.Location = New System.Drawing.Point(10, 20)
        Me.RadGridViewDynamicSummary1.Name = "RadGridViewDynamicSummary1"
        Me.RadGridViewDynamicSummary1.Size = New System.Drawing.Size(520, 311)
        Me.RadGridViewDynamicSummary1.TabIndex = 0
        Me.RadGridViewDynamicSummary1.Text = "RadGridViewDynamicSummary1"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 341)
        Me.Controls.Add(Me.RadGroupBoxGrid)
        Me.Controls.Add(Me.RadGroupOptions)
        Me.Name = "Main"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.RadGroupOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupOptions.ResumeLayout(False)
        Me.RadGroupOptions.PerformLayout()
        CType(Me.RadLabelEvents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadListControlEvents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabelColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownListSummaryColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabelSummaryRowPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownListSummaryPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBoxEnabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBoxGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxGrid.ResumeLayout(False)
        CType(Me.RadGridViewDynamicSummary1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupOptions As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBoxGrid As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGridViewDynamicSummary1 As RadGridViewDynamicSummary.GridView.RadGridViewDynamicSummary
    Friend WithEvents RadLabelColumn As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownListSummaryColumn As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabelSummaryRowPosition As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownListSummaryPosition As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadCheckBoxEnabled As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabelEvents As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadListControlEvents As Telerik.WinControls.UI.RadListControl
End Class

