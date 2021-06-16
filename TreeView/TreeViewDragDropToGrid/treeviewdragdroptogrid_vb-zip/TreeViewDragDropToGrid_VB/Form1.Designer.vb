Imports Microsoft.VisualBasic
Imports System
Namespace TreeViewDragDropToGrid
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
			Dim gridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim radTreeNode1 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode2 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode3 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode4 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode5 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode6 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode7 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode8 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode9 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode10 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode11 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode12 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode13 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode14 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode15 As Telerik.WinControls.UI.RadTreeNode = New Telerik.WinControls.UI.RadTreeNode()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radGridView1
			' 
			Me.radGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radGridView1.Location = New System.Drawing.Point(316, 12)
			' 
			' radGridView1
			' 
			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
			gridViewDecimalColumn1.HeaderText = "column1"
			gridViewDecimalColumn1.Name = "column1"
			gridViewDecimalColumn1.Width = 142
			gridViewTextBoxColumn1.HeaderText = "column2"
			gridViewTextBoxColumn1.Name = "column2"
			gridViewTextBoxColumn1.Width = 143
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewDecimalColumn1, gridViewTextBoxColumn1})
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(305, 238)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			' 
			' radTreeView1
			' 
			Me.radTreeView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radTreeView1.BackColor = System.Drawing.SystemColors.Control
			Me.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default
			Me.radTreeView1.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.radTreeView1.ForeColor = System.Drawing.Color.Black
			Me.radTreeView1.Location = New System.Drawing.Point(4, 12)
			Me.radTreeView1.Name = "radTreeView1"
			radTreeNode1.Expanded = True
			radTreeNode1.Name = "Node1"
			radTreeNode2.Name = "Node6"
			radTreeNode2.Text = "Node6"
			radTreeNode3.Name = "Node7"
			radTreeNode3.Text = "Node7"
			radTreeNode1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode2, radTreeNode3})
			radTreeNode1.Text = "Node1"
			radTreeNode4.Expanded = True
			radTreeNode4.Name = "Node2"
			radTreeNode5.Name = "Node8"
			radTreeNode5.Text = "Node8"
			radTreeNode6.Name = "Node9"
			radTreeNode6.Text = "Node9"
			radTreeNode4.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode5, radTreeNode6})
			radTreeNode4.Text = "Node2"
			radTreeNode7.Expanded = True
			radTreeNode7.Name = "Node3"
			radTreeNode8.Name = "Node10"
			radTreeNode8.Text = "Node10"
			radTreeNode9.Name = "Node11"
			radTreeNode9.Text = "Node11"
			radTreeNode7.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode8, radTreeNode9})
			radTreeNode7.Text = "Node3"
			radTreeNode10.Expanded = True
			radTreeNode10.Name = "Node4"
			radTreeNode11.Name = "Node12"
			radTreeNode11.Text = "Node12"
			radTreeNode12.Name = "Node13"
			radTreeNode12.Text = "Node13"
			radTreeNode10.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode11, radTreeNode12})
			radTreeNode10.Text = "Node4"
			radTreeNode13.Expanded = True
			radTreeNode13.Name = "Node5"
			radTreeNode14.Name = "Node14"
			radTreeNode14.Text = "Node14"
			radTreeNode15.Name = "Node15"
			radTreeNode15.Text = "Node15"
			radTreeNode13.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode14, radTreeNode15})
			radTreeNode13.Text = "Node5"
			Me.radTreeView1.Nodes.AddRange(New Telerik.WinControls.UI.RadTreeNode() { radTreeNode1, radTreeNode4, radTreeNode7, radTreeNode10, radTreeNode13})
			Me.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.radTreeView1.Size = New System.Drawing.Size(306, 238)
			Me.radTreeView1.SpacingBetweenNodes = -1
			Me.radTreeView1.TabIndex = 1
			Me.radTreeView1.Text = "radTreeView1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(633, 262)
			Me.Controls.Add(Me.radTreeView1)
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
	End Class
End Namespace

