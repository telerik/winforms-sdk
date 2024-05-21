Imports Microsoft.VisualBasic
Imports System
Namespace RotatorSlideShow
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radRotator1 = New Telerik.WinControls.UI.RadRotator()
			Me.pnlRotator = New Telerik.WinControls.UI.RadPanel()
			Me.btnCreateSlideShow = New Telerik.WinControls.UI.RadButton()
			Me.btnLoadSlideShow = New Telerik.WinControls.UI.RadButton()
			Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
			Me.btnStepBack = New Telerik.WinControls.UI.RadButton()
			Me.btnStepForward = New Telerik.WinControls.UI.RadButton()
			Me.btnStart = New Telerik.WinControls.UI.RadButton()
			Me.tbInterval = New Telerik.WinControls.UI.RadTextBox()
			Me.lblInterval = New Telerik.WinControls.UI.RadLabel()
			Me.btnApply = New Telerik.WinControls.UI.RadButton()
			Me.tbLocationAnimation = New Telerik.WinControls.UI.RadTextBox()
			Me.lblLocationAnimation = New Telerik.WinControls.UI.RadLabel()
			Me.gboxSettings = New System.Windows.Forms.GroupBox()
			Me.btnClose = New Telerik.WinControls.UI.RadButton()
			CType(Me.radRotator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlRotator, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlRotator.SuspendLayout()
			CType(Me.btnCreateSlideShow, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnLoadSlideShow, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnStepBack, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnStepForward, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnStart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbInterval, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblInterval, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnApply, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbLocationAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblLocationAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gboxSettings.SuspendLayout()
			CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radRotator1
			' 
			Me.radRotator1.BackColor = System.Drawing.Color.Transparent
			Me.radRotator1.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.radRotator1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radRotator1.Location = New System.Drawing.Point(0, 0)
			Me.radRotator1.LocationAnimation = New System.Drawing.SizeF(0F, -1F)
			Me.radRotator1.Name = "radRotator1"
			Me.radRotator1.Running = False
			Me.radRotator1.Size = New System.Drawing.Size(498, 333)
			Me.radRotator1.TabIndex = 0
			Me.radRotator1.Text = "radRotator1"
			' 
			' pnlRotator
			' 
			Me.pnlRotator.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pnlRotator.BackColor = System.Drawing.Color.Transparent
			Me.pnlRotator.Controls.Add(Me.radRotator1)
			Me.pnlRotator.Location = New System.Drawing.Point(15, 10)
			Me.pnlRotator.Name = "pnlRotator"
			Me.pnlRotator.Size = New System.Drawing.Size(498, 333)
			Me.pnlRotator.TabIndex = 1
			' 
			' btnCreateSlideShow
			' 
			Me.btnCreateSlideShow.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.btnCreateSlideShow.Location = New System.Drawing.Point(15, 349)
			Me.btnCreateSlideShow.Name = "btnCreateSlideShow"
			Me.btnCreateSlideShow.Size = New System.Drawing.Size(101, 23)
			Me.btnCreateSlideShow.TabIndex = 2
			Me.btnCreateSlideShow.Text = "Create SlideShow"
			Me.btnCreateSlideShow.ThemeName = "ControlDefault"
'			Me.btnCreateSlideShow.Click += New System.EventHandler(Me.btnCreateSlideShow_Click);
			' 
			' btnLoadSlideShow
			' 
			Me.btnLoadSlideShow.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.btnLoadSlideShow.Location = New System.Drawing.Point(123, 349)
			Me.btnLoadSlideShow.Name = "btnLoadSlideShow"
			Me.btnLoadSlideShow.Size = New System.Drawing.Size(97, 23)
			Me.btnLoadSlideShow.TabIndex = 3
			Me.btnLoadSlideShow.Text = "Load SlideShow"
'			Me.btnLoadSlideShow.Click += New System.EventHandler(Me.btnLoadSlideShow_Click);
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.DefaultExt = "xml"
			Me.openFileDialog1.Filter = "Rotator Slide Show Files|*.xml"
			' 
			' btnStepBack
			' 
			Me.btnStepBack.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnStepBack.Location = New System.Drawing.Point(463, 349)
			Me.btnStepBack.Name = "btnStepBack"
			Me.btnStepBack.Size = New System.Drawing.Size(22, 23)
			Me.btnStepBack.TabIndex = 4
			Me.btnStepBack.Text = "<"
'			Me.btnStepBack.Click += New System.EventHandler(Me.btnStepBack_Click);
			' 
			' btnStepForward
			' 
			Me.btnStepForward.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnStepForward.Location = New System.Drawing.Point(491, 349)
			Me.btnStepForward.Name = "btnStepForward"
			Me.btnStepForward.Size = New System.Drawing.Size(22, 23)
			Me.btnStepForward.TabIndex = 4
			Me.btnStepForward.Text = ">"
'			Me.btnStepForward.Click += New System.EventHandler(Me.btnStepForward_Click);
			' 
			' btnStart
			' 
			Me.btnStart.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnStart.Location = New System.Drawing.Point(382, 349)
			Me.btnStart.Name = "btnStart"
			Me.btnStart.Size = New System.Drawing.Size(75, 23)
			Me.btnStart.TabIndex = 5
			Me.btnStart.Text = "Start"
'			Me.btnStart.Click += New System.EventHandler(Me.btnStart_Click);
			' 
			' tbInterval
			' 
			Me.tbInterval.ForeColor = System.Drawing.Color.Black
			Me.tbInterval.Location = New System.Drawing.Point(125, 26)
			Me.tbInterval.MaxLength = 5
			Me.tbInterval.Name = "tbInterval"
			Me.tbInterval.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
			' 
			' 
			' 
			Me.tbInterval.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.tbInterval.RootElement.ForeColor = System.Drawing.Color.Black
			Me.tbInterval.Size = New System.Drawing.Size(42, 20)
			Me.tbInterval.TabIndex = 8
			Me.tbInterval.Text = "2000"
			' 
			' lblInterval
			' 
			Me.lblInterval.BackColor = System.Drawing.Color.Transparent
			Me.lblInterval.ForeColor = System.Drawing.Color.Black
			Me.lblInterval.Location = New System.Drawing.Point(15, 30)
			Me.lblInterval.Name = "lblInterval"
			' 
			' 
			' 
			Me.lblInterval.RootElement.ForeColor = System.Drawing.Color.Black
			Me.lblInterval.Size = New System.Drawing.Size(47, 16)
			Me.lblInterval.TabIndex = 7
			Me.lblInterval.Text = "Interval:"
			' 
			' btnApply
			' 
			Me.btnApply.ForeColor = System.Drawing.Color.Black
			Me.btnApply.Location = New System.Drawing.Point(125, 80)
			Me.btnApply.Name = "btnApply"
			' 
			' 
			' 
			Me.btnApply.RootElement.ForeColor = System.Drawing.Color.Black
			Me.btnApply.Size = New System.Drawing.Size(49, 21)
			Me.btnApply.TabIndex = 14
			Me.btnApply.Text = "Apply"
'			Me.btnApply.Click += New System.EventHandler(Me.btnApply_Click);
			' 
			' tbLocationAnimation
			' 
			Me.tbLocationAnimation.ForeColor = System.Drawing.Color.Black
			Me.tbLocationAnimation.Location = New System.Drawing.Point(125, 54)
			Me.tbLocationAnimation.Name = "tbLocationAnimation"
			Me.tbLocationAnimation.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
			' 
			' 
			' 
			Me.tbLocationAnimation.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.tbLocationAnimation.RootElement.ForeColor = System.Drawing.Color.Black
			Me.tbLocationAnimation.Size = New System.Drawing.Size(42, 20)
			Me.tbLocationAnimation.TabIndex = 12
			Me.tbLocationAnimation.Text = "0, -1"
			' 
			' lblLocationAnimation
			' 
			Me.lblLocationAnimation.BackColor = System.Drawing.Color.Transparent
			Me.lblLocationAnimation.ForeColor = System.Drawing.Color.Black
			Me.lblLocationAnimation.Location = New System.Drawing.Point(15, 58)
			Me.lblLocationAnimation.Name = "lblLocationAnimation"
			' 
			' 
			' 
			Me.lblLocationAnimation.RootElement.ForeColor = System.Drawing.Color.Black
			Me.lblLocationAnimation.Size = New System.Drawing.Size(104, 16)
			Me.lblLocationAnimation.TabIndex = 13
			Me.lblLocationAnimation.Text = "Location animation:"
			' 
			' gboxSettings
			' 
			Me.gboxSettings.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.gboxSettings.BackColor = System.Drawing.Color.Transparent
			Me.gboxSettings.Controls.Add(Me.lblInterval)
			Me.gboxSettings.Controls.Add(Me.tbLocationAnimation)
			Me.gboxSettings.Controls.Add(Me.lblLocationAnimation)
			Me.gboxSettings.Controls.Add(Me.tbInterval)
			Me.gboxSettings.Controls.Add(Me.btnApply)
			Me.gboxSettings.Location = New System.Drawing.Point(15, 378)
			Me.gboxSettings.Name = "gboxSettings"
			Me.gboxSettings.Size = New System.Drawing.Size(187, 112)
			Me.gboxSettings.TabIndex = 15
			Me.gboxSettings.TabStop = False
			Me.gboxSettings.Text = "Settings"
			' 
			' btnClose
			' 
			Me.btnClose.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnClose.Location = New System.Drawing.Point(441, 472)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New System.Drawing.Size(75, 23)
			Me.btnClose.TabIndex = 16
			Me.btnClose.Text = "Close"
'			Me.btnClose.Click += New System.EventHandler(Me.btnClose_Click);
			' 
			' Form1
			' 
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
			Me.ClientSize = New System.Drawing.Size(528, 507)
			Me.Controls.Add(Me.btnClose)
			Me.Controls.Add(Me.gboxSettings)
			Me.Controls.Add(Me.btnStart)
			Me.Controls.Add(Me.btnStepForward)
			Me.Controls.Add(Me.btnStepBack)
			Me.Controls.Add(Me.btnLoadSlideShow)
			Me.Controls.Add(Me.btnCreateSlideShow)
			Me.Controls.Add(Me.pnlRotator)
			Me.Name = "Form1"
			Me.Text = "Empty"
			Me.ThemeName = "ControlDefault"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.radRotator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlRotator, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlRotator.ResumeLayout(False)
			CType(Me.btnCreateSlideShow, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnLoadSlideShow, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnStepBack, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnStepForward, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnStart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbInterval, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblInterval, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnApply, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbLocationAnimation, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblLocationAnimation, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gboxSettings.ResumeLayout(False)
			Me.gboxSettings.PerformLayout()
			CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radRotator1 As Telerik.WinControls.UI.RadRotator
		Private pnlRotator As Telerik.WinControls.UI.RadPanel
		Private WithEvents btnCreateSlideShow As Telerik.WinControls.UI.RadButton
		Private WithEvents btnLoadSlideShow As Telerik.WinControls.UI.RadButton
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private WithEvents btnStepBack As Telerik.WinControls.UI.RadButton
		Private WithEvents btnStepForward As Telerik.WinControls.UI.RadButton
		Private WithEvents btnStart As Telerik.WinControls.UI.RadButton
		Private tbInterval As Telerik.WinControls.UI.RadTextBox
		Private lblInterval As Telerik.WinControls.UI.RadLabel
		Private WithEvents btnApply As Telerik.WinControls.UI.RadButton
		Private tbLocationAnimation As Telerik.WinControls.UI.RadTextBox
		Private lblLocationAnimation As Telerik.WinControls.UI.RadLabel
		Private gboxSettings As System.Windows.Forms.GroupBox
		Private WithEvents btnClose As Telerik.WinControls.UI.RadButton
	End Class
End Namespace

