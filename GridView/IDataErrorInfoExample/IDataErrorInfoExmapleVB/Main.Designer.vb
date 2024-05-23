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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.RadGroupBoxGridview = New Telerik.WinControls.UI.RadGroupBox
        Me.RadGridView = New Telerik.WinControls.UI.RadGridView
        Me.RadGroupBoxOptions = New Telerik.WinControls.UI.RadGroupBox
        Me.RadPanelBorderColor = New Telerik.WinControls.UI.RadPanel
        Me.RadButtonBorderColor = New Telerik.WinControls.UI.RadButton
        Me.RadLabelTextImageRelation = New Telerik.WinControls.UI.RadLabel
        Me.RadDropDownTextImageRelation = New Telerik.WinControls.UI.RadDropDownList
        Me.RadCheckBoxIncludeCellImage = New Telerik.WinControls.UI.RadCheckBox
        Me.RadCheckBoxShowRowHeaderColumn = New Telerik.WinControls.UI.RadCheckBox
        Me.RadColorDialog = New Telerik.WinControls.RadColorDialog
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.RadGroupBoxGridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxGridview.SuspendLayout()
        CType(Me.RadGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBoxOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBoxOptions.SuspendLayout()
        CType(Me.RadPanelBorderColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButtonBorderColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabelTextImageRelation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownTextImageRelation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBoxIncludeCellImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBoxShowRowHeaderColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBoxGridview
        '
        Me.RadGroupBoxGridview.Controls.Add(Me.RadGridView)
        Me.RadGroupBoxGridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBoxGridview.FooterImageIndex = -1
        Me.RadGroupBoxGridview.FooterImageKey = ""
        Me.RadGroupBoxGridview.HeaderImageIndex = -1
        Me.RadGroupBoxGridview.HeaderImageKey = ""
        Me.RadGroupBoxGridview.HeaderMargin = New System.Windows.Forms.Padding(0)
        Me.RadGroupBoxGridview.HeaderText = "Grid"
        Me.RadGroupBoxGridview.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBoxGridview.Name = "RadGroupBoxGridview"
        Me.RadGroupBoxGridview.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        '
        '
        '
        Me.RadGroupBoxGridview.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.RadGroupBoxGridview.Size = New System.Drawing.Size(586, 234)
        Me.RadGroupBoxGridview.TabIndex = 0
        Me.RadGroupBoxGridview.Text = "Grid"
        '
        'RadGridView
        '
        Me.RadGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGridView.AutoSizeRows = True
        Me.RadGridView.Location = New System.Drawing.Point(13, 23)
        Me.RadGridView.Name = "RadGridView"
        Me.RadGridView.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        '
        '
        '
        Me.RadGridView.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.RadGridView.Size = New System.Drawing.Size(368, 198)
        Me.RadGridView.TabIndex = 0
        '
        'RadGroupBoxOptions
        '
        Me.RadGroupBoxOptions.Controls.Add(Me.RadPanelBorderColor)
        Me.RadGroupBoxOptions.Controls.Add(Me.RadButtonBorderColor)
        Me.RadGroupBoxOptions.Controls.Add(Me.RadLabelTextImageRelation)
        Me.RadGroupBoxOptions.Controls.Add(Me.RadDropDownTextImageRelation)
        Me.RadGroupBoxOptions.Controls.Add(Me.RadCheckBoxIncludeCellImage)
        Me.RadGroupBoxOptions.Controls.Add(Me.RadCheckBoxShowRowHeaderColumn)
        Me.RadGroupBoxOptions.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadGroupBoxOptions.FooterImageIndex = -1
        Me.RadGroupBoxOptions.FooterImageKey = ""
        Me.RadGroupBoxOptions.HeaderImageIndex = -1
        Me.RadGroupBoxOptions.HeaderImageKey = ""
        Me.RadGroupBoxOptions.HeaderMargin = New System.Windows.Forms.Padding(0)
        Me.RadGroupBoxOptions.HeaderText = "Options"
        Me.RadGroupBoxOptions.Location = New System.Drawing.Point(396, 0)
        Me.RadGroupBoxOptions.Name = "RadGroupBoxOptions"
        Me.RadGroupBoxOptions.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        '
        '
        '
        Me.RadGroupBoxOptions.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.RadGroupBoxOptions.Size = New System.Drawing.Size(190, 234)
        Me.RadGroupBoxOptions.TabIndex = 1
        Me.RadGroupBoxOptions.Text = "Options"
        '
        'RadPanelBorderColor
        '
        Me.RadPanelBorderColor.BackColor = System.Drawing.Color.Red
        Me.RadPanelBorderColor.Location = New System.Drawing.Point(139, 160)
        Me.RadPanelBorderColor.Name = "RadPanelBorderColor"
        Me.RadPanelBorderColor.Size = New System.Drawing.Size(29, 24)
        Me.RadPanelBorderColor.TabIndex = 5
        '
        'RadButtonBorderColor
        '
        Me.RadButtonBorderColor.Location = New System.Drawing.Point(14, 160)
        Me.RadButtonBorderColor.Name = "RadButtonBorderColor"
        Me.RadButtonBorderColor.Size = New System.Drawing.Size(119, 24)
        Me.RadButtonBorderColor.TabIndex = 4
        Me.RadButtonBorderColor.Text = "Error Border Color"
        '
        'RadLabelTextImageRelation
        '
        Me.RadLabelTextImageRelation.BackColor = System.Drawing.Color.Transparent
        Me.RadLabelTextImageRelation.Location = New System.Drawing.Point(13, 98)
        Me.RadLabelTextImageRelation.Name = "RadLabelTextImageRelation"
        Me.RadLabelTextImageRelation.Size = New System.Drawing.Size(99, 18)
        Me.RadLabelTextImageRelation.TabIndex = 3
        Me.RadLabelTextImageRelation.Text = "TextImageRelation"
        '
        'RadDropDownTextImageRelation
        '
        Me.RadDropDownTextImageRelation.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.RadDropDownTextImageRelation.Enabled = False
        Me.RadDropDownTextImageRelation.Location = New System.Drawing.Point(14, 122)
        Me.RadDropDownTextImageRelation.Name = "RadDropDownTextImageRelation"
        Me.RadDropDownTextImageRelation.Size = New System.Drawing.Size(154, 20)
        Me.RadDropDownTextImageRelation.TabIndex = 2
        '
        'RadCheckBoxIncludeCellImage
        '
        Me.RadCheckBoxIncludeCellImage.BackColor = System.Drawing.Color.Transparent
        Me.RadCheckBoxIncludeCellImage.Location = New System.Drawing.Point(14, 68)
        Me.RadCheckBoxIncludeCellImage.Name = "RadCheckBoxIncludeCellImage"
        Me.RadCheckBoxIncludeCellImage.Size = New System.Drawing.Size(112, 18)
        Me.RadCheckBoxIncludeCellImage.TabIndex = 1
        Me.RadCheckBoxIncludeCellImage.Text = "Include Cell Image"
        '
        'RadCheckBoxShowRowHeaderColumn
        '
        Me.RadCheckBoxShowRowHeaderColumn.BackColor = System.Drawing.Color.Transparent
        Me.RadCheckBoxShowRowHeaderColumn.Location = New System.Drawing.Point(14, 35)
        Me.RadCheckBoxShowRowHeaderColumn.Name = "RadCheckBoxShowRowHeaderColumn"
        Me.RadCheckBoxShowRowHeaderColumn.Size = New System.Drawing.Size(154, 18)
        Me.RadCheckBoxShowRowHeaderColumn.TabIndex = 0
        Me.RadCheckBoxShowRowHeaderColumn.Text = "Show Row Header Column"
        Me.RadCheckBoxShowRowHeaderColumn.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadColorDialog
        '
        Me.RadColorDialog.SelectedColor = System.Drawing.Color.Red
        Me.RadColorDialog.SelectedHslColor = Telerik.WinControls.HslColor.FromAhsl(0, 1, 1)
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "error.png")
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 234)
        Me.Controls.Add(Me.RadGroupBoxOptions)
        Me.Controls.Add(Me.RadGroupBoxGridview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "IDataErrorInfo Example"
        CType(Me.RadGroupBoxGridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxGridview.ResumeLayout(False)
        CType(Me.RadGridView.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBoxOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBoxOptions.ResumeLayout(False)
        Me.RadGroupBoxOptions.PerformLayout()
        CType(Me.RadPanelBorderColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButtonBorderColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabelTextImageRelation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownTextImageRelation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBoxIncludeCellImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBoxShowRowHeaderColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBoxGridview As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBoxOptions As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGridView As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadCheckBoxShowRowHeaderColumn As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBoxIncludeCellImage As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadDropDownTextImageRelation As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabelTextImageRelation As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadColorDialog As Telerik.WinControls.RadColorDialog
    Friend WithEvents RadButtonBorderColor As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanelBorderColor As Telerik.WinControls.UI.RadPanel
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
End Class
