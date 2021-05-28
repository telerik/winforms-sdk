Imports Microsoft.VisualBasic
Imports System
Namespace VirtualMultiColumnComboBox
	Public Partial Class MainWindow
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
			Me.virtualRadMultiColumnComboBox1 = New VirtualMultiColumnComboBox.Implementation.VirtualMultiColumnComboBox()
			CType(Me.virtualRadMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.virtualRadMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radMultiColumnComboBox1
			' 
			Me.virtualRadMultiColumnComboBox1.DataSource = (CObj(resources.GetObject("radMultiColumnComboBox1.DataSource")))
			' 
			' radMultiColumnComboBox1.NestedRadGridView
			' 
			Me.virtualRadMultiColumnComboBox1.EditorControl.BackColor = System.Drawing.SystemColors.Window
			Me.virtualRadMultiColumnComboBox1.EditorControl.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.virtualRadMultiColumnComboBox1.EditorControl.ForeColor = System.Drawing.Color.Black
			Me.virtualRadMultiColumnComboBox1.EditorControl.Location = New System.Drawing.Point(0, 0)
			' 
			' radMultiColumnComboBox1.NestedRadGridView
			' 
			Me.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate.AllowAddNewRow = False
			Me.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate.AllowCellContextMenu = False
			Me.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate.AllowColumnChooser = False
			Me.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate.EnableGrouping = False
			Me.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate.ShowFilteringRow = False
			Me.virtualRadMultiColumnComboBox1.EditorControl.Name = "NestedRadGridView"
			Me.virtualRadMultiColumnComboBox1.EditorControl.ReadOnly = True
			Me.virtualRadMultiColumnComboBox1.EditorControl.ShowGroupPanel = False
			Me.virtualRadMultiColumnComboBox1.EditorControl.Size = New System.Drawing.Size(506, 33)
			Me.virtualRadMultiColumnComboBox1.EditorControl.TabIndex = 0
			Me.virtualRadMultiColumnComboBox1.EditorControl.ThemeName = "ControlDefault"
			Me.virtualRadMultiColumnComboBox1.EditorControl.VirtualMode = True
			Me.virtualRadMultiColumnComboBox1.Location = New System.Drawing.Point(13, 13)
			Me.virtualRadMultiColumnComboBox1.Name = "radMultiColumnComboBox1"
			Me.virtualRadMultiColumnComboBox1.Size = New System.Drawing.Size(506, 20)
			Me.virtualRadMultiColumnComboBox1.TabIndex = 0
			Me.virtualRadMultiColumnComboBox1.TabStop = False
			Me.virtualRadMultiColumnComboBox1.Text = "radMultiColumnComboBox1"
			' 
			' MainWindow
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(531, 221)
			Me.Controls.Add(Me.virtualRadMultiColumnComboBox1)
			Me.Name = "MainWindow"
			Me.Text = "Form1"
			CType(Me.virtualRadMultiColumnComboBox1.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.virtualRadMultiColumnComboBox1.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.virtualRadMultiColumnComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private virtualRadMultiColumnComboBox1 As VirtualMultiColumnComboBox.Implementation.VirtualMultiColumnComboBox
	End Class
End Namespace

