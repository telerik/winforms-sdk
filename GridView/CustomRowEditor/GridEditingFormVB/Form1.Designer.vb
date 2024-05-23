Imports Microsoft.VisualBasic
Imports System
Namespace GridEditingForm
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
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.rrbEmployees = New Telerik.WinControls.UI.RadRadioButton()
            Me.rrbCustomers = New Telerik.WinControls.UI.RadRadioButton()
            Me.rrbCategories = New Telerik.WinControls.UI.RadRadioButton()
            Me.rrbCars = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
            Me.groupBox1.SuspendLayout()
            CType(Me.rrbEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rrbCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rrbCategories, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.rrbCars, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.rrbEmployees)
            Me.groupBox1.Controls.Add(Me.rrbCustomers)
            Me.groupBox1.Controls.Add(Me.rrbCategories)
            Me.groupBox1.Controls.Add(Me.rrbCars)
            Me.groupBox1.Location = New System.Drawing.Point(13, 384)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(304, 47)
            Me.groupBox1.TabIndex = 1
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Data tables"
            '
            'rrbEmployees
            '
            Me.rrbEmployees.Location = New System.Drawing.Point(219, 19)
            Me.rrbEmployees.Name = "rrbEmployees"
            Me.rrbEmployees.Size = New System.Drawing.Size(76, 16)
            Me.rrbEmployees.TabIndex = 3
            Me.rrbEmployees.Text = "Employees"
            '
            'rrbCustomers
            '
            Me.rrbCustomers.Location = New System.Drawing.Point(138, 20)
            Me.rrbCustomers.Name = "rrbCustomers"
            Me.rrbCustomers.Size = New System.Drawing.Size(75, 16)
            Me.rrbCustomers.TabIndex = 2
            Me.rrbCustomers.Text = "Customers"
            '
            'rrbCategories
            '
            Me.rrbCategories.Location = New System.Drawing.Point(57, 20)
            Me.rrbCategories.Name = "rrbCategories"
            Me.rrbCategories.Size = New System.Drawing.Size(75, 16)
            Me.rrbCategories.TabIndex = 1
            Me.rrbCategories.Text = "Categories"
            '
            'rrbCars
            '
            Me.rrbCars.Location = New System.Drawing.Point(7, 20)
            Me.rrbCars.Name = "rrbCars"
            Me.rrbCars.Size = New System.Drawing.Size(44, 16)
            Me.rrbCars.TabIndex = 0
            Me.rrbCars.Text = "Cars"
            '
            'radGridView1
            '
            Me.radGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radGridView1.Location = New System.Drawing.Point(12, 12)
            Me.radGridView1.Name = "radGridView1"
            Me.radGridView1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
            '
            '
            '
            Me.radGridView1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
            Me.radGridView1.Size = New System.Drawing.Size(637, 366)
            Me.radGridView1.TabIndex = 2
            Me.radGridView1.Text = "radGridView1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(661, 444)
            Me.Controls.Add(Me.radGridView1)
            Me.Controls.Add(Me.groupBox1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.groupBox1.ResumeLayout(False)
            CType(Me.rrbEmployees, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rrbCustomers, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rrbCategories, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.rrbCars, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents rrbEmployees As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents rrbCustomers As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents rrbCategories As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents rrbCars As Telerik.WinControls.UI.RadRadioButton
		Private radGridView1 As Telerik.WinControls.UI.RadGridView

	End Class
End Namespace

