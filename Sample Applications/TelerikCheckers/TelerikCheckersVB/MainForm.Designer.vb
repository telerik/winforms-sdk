Imports Microsoft.VisualBasic
Imports System
Namespace TelerikCheckers
	Public Partial Class MainForm
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
			Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.radPanel5 = New Telerik.WinControls.UI.RadPanel()
			Me.pictureBox6 = New System.Windows.Forms.PictureBox()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radPanel4 = New Telerik.WinControls.UI.RadPanel()
			Me.pictureBox4 = New System.Windows.Forms.PictureBox()
			Me.pictureBox3 = New System.Windows.Forms.PictureBox()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
			Me.pictureBox5 = New System.Windows.Forms.PictureBox()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox5 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox4 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel5.SuspendLayout()
			CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel4.SuspendLayout()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel3.SuspendLayout()
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel2.SuspendLayout()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanel1
			' 
            Me.radPanel1.BackgroundImage = Resources.main_bg
			Me.radPanel1.Controls.Add(Me.pictureBox2)
			Me.radPanel1.Controls.Add(Me.radPanel5)
			Me.radPanel1.Controls.Add(Me.radPanel4)
			Me.radPanel1.Controls.Add(Me.radPanel3)
			Me.radPanel1.Controls.Add(Me.radPanel2)
			Me.radPanel1.Controls.Add(Me.radGridView1)
			Me.radPanel1.Controls.Add(Me.radButton1)
			Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radPanel1.Location = New System.Drawing.Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New System.Drawing.Size(826, 640)
			Me.radPanel1.TabIndex = 11
			' 
			' pictureBox2
			' 
			Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
            Me.pictureBox2.Image = Resources.game_logo
			Me.pictureBox2.Location = New System.Drawing.Point(44, 43)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(515, 54)
			Me.pictureBox2.TabIndex = 15
			Me.pictureBox2.TabStop = False
			' 
			' radPanel5
			' 
			Me.radPanel5.BackColor = System.Drawing.Color.Transparent
			Me.radPanel5.Controls.Add(Me.pictureBox6)
			Me.radPanel5.Controls.Add(Me.radLabel5)
			Me.radPanel5.Location = New System.Drawing.Point(664, 239)
			Me.radPanel5.Name = "radPanel5"
			Me.radPanel5.Size = New System.Drawing.Size(87, 55)
			Me.radPanel5.TabIndex = 14
			' 
			' pictureBox6
			' 
            Me.pictureBox6.Image = Resources.checker_black_small
			Me.pictureBox6.Location = New System.Drawing.Point(44, 15)
			Me.pictureBox6.Name = "pictureBox6"
			Me.pictureBox6.Size = New System.Drawing.Size(26, 26)
			Me.pictureBox6.TabIndex = 2
			Me.pictureBox6.TabStop = False
			' 
			' radLabel5
			' 
			Me.radLabel5.BackColor = System.Drawing.Color.Transparent
			Me.radLabel5.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel5.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(177))))), (CInt(Fix((CByte(94))))))
			Me.radLabel5.Location = New System.Drawing.Point(7, 15)
			Me.radLabel5.Name = "radLabel5"
			' 
			' 
			' 
			Me.radLabel5.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(177))))), (CInt(Fix((CByte(94))))))
			Me.radLabel5.Size = New System.Drawing.Size(31, 25)
			Me.radLabel5.TabIndex = 1
			Me.radLabel5.Text = "0 x"
			' 
			' radPanel4
			' 
			Me.radPanel4.BackColor = System.Drawing.Color.Transparent
			Me.radPanel4.Controls.Add(Me.pictureBox4)
			Me.radPanel4.Controls.Add(Me.pictureBox3)
			Me.radPanel4.Controls.Add(Me.pictureBox1)
			Me.radPanel4.Location = New System.Drawing.Point(575, 103)
			Me.radPanel4.Name = "radPanel4"
			Me.radPanel4.Size = New System.Drawing.Size(176, 136)
			Me.radPanel4.TabIndex = 13
			' 
			' pictureBox4
			' 
			Me.pictureBox4.BackColor = System.Drawing.Color.Transparent
            Me.pictureBox4.Image = Resources.out
			Me.pictureBox4.Location = New System.Drawing.Point(69, 115)
			Me.pictureBox4.Name = "pictureBox4"
			Me.pictureBox4.Size = New System.Drawing.Size(41, 18)
			Me.pictureBox4.TabIndex = 6
			Me.pictureBox4.TabStop = False
			' 
			' pictureBox3
			' 
			Me.pictureBox3.BackColor = System.Drawing.Color.Transparent
            Me.pictureBox3.Image = Resources.next_turn
			Me.pictureBox3.Location = New System.Drawing.Point(33, 13)
			Me.pictureBox3.Name = "pictureBox3"
			Me.pictureBox3.Size = New System.Drawing.Size(109, 16)
			Me.pictureBox3.TabIndex = 5
			Me.pictureBox3.TabStop = False
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
			Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.pictureBox1.Location = New System.Drawing.Point(61, 40)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(60, 60)
			Me.pictureBox1.TabIndex = 4
			Me.pictureBox1.TabStop = False
			' 
			' radPanel3
			' 
			Me.radPanel3.BackColor = System.Drawing.Color.Transparent
			Me.radPanel3.Controls.Add(Me.pictureBox5)
			Me.radPanel3.Controls.Add(Me.radLabel4)
			Me.radPanel3.Location = New System.Drawing.Point(575, 239)
			Me.radPanel3.Name = "radPanel3"
			Me.radPanel3.Size = New System.Drawing.Size(89, 55)
			Me.radPanel3.TabIndex = 12
			' 
			' pictureBox5
			' 
            Me.pictureBox5.Image = Resources.checker_white_small
			Me.pictureBox5.Location = New System.Drawing.Point(46, 15)
			Me.pictureBox5.Name = "pictureBox5"
			Me.pictureBox5.Size = New System.Drawing.Size(26, 26)
			Me.pictureBox5.TabIndex = 2
			Me.pictureBox5.TabStop = False
			' 
			' radLabel4
			' 
			Me.radLabel4.BackColor = System.Drawing.Color.Transparent
			Me.radLabel4.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold)
			Me.radLabel4.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(177))))), (CInt(Fix((CByte(94))))))
			Me.radLabel4.Location = New System.Drawing.Point(9, 15)
			Me.radLabel4.Name = "radLabel4"
			' 
			' 
			' 
			Me.radLabel4.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(177))))), (CInt(Fix((CByte(94))))))
			Me.radLabel4.Size = New System.Drawing.Size(31, 25)
			Me.radLabel4.TabIndex = 1
			Me.radLabel4.Text = "0 x"
			' 
			' radPanel2
			' 
			Me.radPanel2.BackColor = System.Drawing.Color.Transparent
			Me.radPanel2.Controls.Add(Me.radCheckBox1)
			Me.radPanel2.Controls.Add(Me.radCheckBox5)
			Me.radPanel2.Controls.Add(Me.radCheckBox4)
			Me.radPanel2.Controls.Add(Me.radCheckBox3)
			Me.radPanel2.Controls.Add(Me.radCheckBox2)
			Me.radPanel2.Location = New System.Drawing.Point(575, 294)
			Me.radPanel2.Name = "radPanel2"
			Me.radPanel2.Size = New System.Drawing.Size(176, 158)
			Me.radPanel2.TabIndex = 11
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox1.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.radCheckBox1.ForeColor = System.Drawing.Color.White
			Me.radCheckBox1.Location = New System.Drawing.Point(15, 18)
			Me.radCheckBox1.Name = "radCheckBox1"
			' 
			' 
			' 
			Me.radCheckBox1.RootElement.ForeColor = System.Drawing.Color.White
			Me.radCheckBox1.Size = New System.Drawing.Size(86, 19)
			Me.radCheckBox1.TabIndex = 6
			Me.radCheckBox1.Text = "Format cells"
'			Me.radCheckBox1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox1_ToggleStateChanged);
			' 
			' radCheckBox5
			' 
			Me.radCheckBox5.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox5.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.radCheckBox5.ForeColor = System.Drawing.Color.White
			Me.radCheckBox5.Location = New System.Drawing.Point(15, 118)
			Me.radCheckBox5.Name = "radCheckBox5"
			' 
			' 
			' 
			Me.radCheckBox5.RootElement.ForeColor = System.Drawing.Color.White
			Me.radCheckBox5.Size = New System.Drawing.Size(111, 19)
			Me.radCheckBox5.TabIndex = 10
			Me.radCheckBox5.Text = "Drop restrictions"
'			Me.radCheckBox5.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox5_ToggleStateChanged);
			' 
			' radCheckBox4
			' 
			Me.radCheckBox4.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox4.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.radCheckBox4.ForeColor = System.Drawing.Color.White
			Me.radCheckBox4.Location = New System.Drawing.Point(15, 93)
			Me.radCheckBox4.Name = "radCheckBox4"
			' 
			' 
			' 
			Me.radCheckBox4.RootElement.ForeColor = System.Drawing.Color.White
			Me.radCheckBox4.Size = New System.Drawing.Size(110, 19)
			Me.radCheckBox4.TabIndex = 9
			Me.radCheckBox4.Text = "Drag restrictions"
'			Me.radCheckBox4.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox4_ToggleStateChanged);
			' 
			' radCheckBox3
			' 
			Me.radCheckBox3.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox3.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.radCheckBox3.ForeColor = System.Drawing.Color.White
			Me.radCheckBox3.Location = New System.Drawing.Point(15, 68)
			Me.radCheckBox3.Name = "radCheckBox3"
			' 
			' 
			' 
			Me.radCheckBox3.RootElement.ForeColor = System.Drawing.Color.White
			Me.radCheckBox3.Size = New System.Drawing.Size(118, 19)
			Me.radCheckBox3.TabIndex = 8
			Me.radCheckBox3.Text = "Move cell content"
'			Me.radCheckBox3.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox3_ToggleStateChanged);
			' 
			' radCheckBox2
			' 
			Me.radCheckBox2.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox2.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.radCheckBox2.ForeColor = System.Drawing.Color.White
			Me.radCheckBox2.Location = New System.Drawing.Point(15, 43)
			Me.radCheckBox2.Name = "radCheckBox2"
			' 
			' 
			' 
			Me.radCheckBox2.RootElement.ForeColor = System.Drawing.Color.White
			Me.radCheckBox2.Size = New System.Drawing.Size(150, 19)
			Me.radCheckBox2.TabIndex = 7
			Me.radCheckBox2.Text = "Use custom drag image"
'			Me.radCheckBox2.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox2_ToggleStateChanged);
			' 
			' radGridView1
			' 
			Me.radGridView1.Location = New System.Drawing.Point(44, 103)
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			' 
			' 
			' 
			Me.radGridView1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridView1.Size = New System.Drawing.Size(515, 488)
			Me.radGridView1.TabIndex = 1
			' 
			' radButton1
			' 
            Me.radButton1.Image = Resources.new_game
			Me.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton1.Location = New System.Drawing.Point(575, 470)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(176, 33)
			Me.radButton1.TabIndex = 3
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(0))))))
			Me.ClientSize = New System.Drawing.Size(826, 640)
			Me.Controls.Add(Me.radPanel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Name = "MainForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Telerik Checkers"
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel5.ResumeLayout(False)
			Me.radPanel5.PerformLayout()
			CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel4.ResumeLayout(False)
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel3.ResumeLayout(False)
			Me.radPanel3.PerformLayout()
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel2.ResumeLayout(False)
			Me.radPanel2.PerformLayout()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox3 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox4 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox5 As Telerik.WinControls.UI.RadCheckBox
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private desertTheme1 As Telerik.WinControls.Themes.DesertTheme
		Private radPanel2 As Telerik.WinControls.UI.RadPanel
		Private radPanel5 As Telerik.WinControls.UI.RadPanel
		Private radPanel4 As Telerik.WinControls.UI.RadPanel
		Private radPanel3 As Telerik.WinControls.UI.RadPanel
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private pictureBox2 As System.Windows.Forms.PictureBox
		Private pictureBox4 As System.Windows.Forms.PictureBox
		Private pictureBox3 As System.Windows.Forms.PictureBox
		Private pictureBox6 As System.Windows.Forms.PictureBox
		Private pictureBox5 As System.Windows.Forms.PictureBox
	End Class
End Namespace

