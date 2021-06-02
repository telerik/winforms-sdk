Partial Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
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
        Dim customListDataItem1 As New CustomListDataItem()
        Dim customListDataItem2 As New CustomListDataItem()
        Dim customListDataItem3 As New CustomListDataItem()
        Dim customListDataItem4 As New CustomListDataItem()
        Me.customDropDownList1 = New CustomDropDownList()
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
        DirectCast(Me.customDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' customDropDownList1
        ' 
        customListDataItem1.Text = "ListItem 1"
        customListDataItem1.TextWrap = True
        customListDataItem2.Text = "ListItem 2"
        customListDataItem2.TextWrap = True
        customListDataItem3.Text = "ListItem 3"
        customListDataItem3.TextWrap = True
        customListDataItem4.Text = "ListItem 4"
        customListDataItem4.TextWrap = True
        Me.customDropDownList1.Items.Add(customListDataItem1)
        Me.customDropDownList1.Items.Add(customListDataItem2)
        Me.customDropDownList1.Items.Add(customListDataItem3)
        Me.customDropDownList1.Items.Add(customListDataItem4)
        Me.customDropDownList1.Location = New System.Drawing.Point(128, 184)
        Me.customDropDownList1.Name = "customDropDownList1"
        Me.customDropDownList1.Size = New System.Drawing.Size(233, 21)
        Me.customDropDownList1.TabIndex = 0
        ' 
        ' radLabel1
        ' 
        Me.radLabel1.Location = New System.Drawing.Point(13, 184)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(101, 18)
        Me.radLabel1.TabIndex = 1
        Me.radLabel1.Text = "Added design time"
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.radLabel1)
        Me.Controls.Add(Me.customDropDownList1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        AddHandler Load, AddressOf Form1_Load
        DirectCast(Me.customDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private customDropDownList1 As CustomDropDownList
    Private radLabel1 As Telerik.WinControls.UI.RadLabel



End Class