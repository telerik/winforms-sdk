<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.RichTextEditorRibbonBar1 = New Telerik.WinControls.UI.RichTextEditorRibbonBar()
        Me.RadRichTextEditorRuler1 = New Telerik.WinControls.UI.RadRichTextEditorRuler()
        Me.RadRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
        CType(Me.RichTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRichTextEditorRuler1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadRichTextEditorRuler1.SuspendLayout()
        CType(Me.RadRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextEditorRibbonBar1
        '
        Me.RichTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
        Me.RichTextEditorRibbonBar1.AssociatedRichTextEditor = Nothing
        Me.RichTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013
        '
        '
        '
        Me.RichTextEditorRibbonBar1.ExitButton.Text = "Exit"
        Me.RichTextEditorRibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextEditorRibbonBar1.Name = "RichTextEditorRibbonBar1"
        '
        '
        '
        Me.RichTextEditorRibbonBar1.OptionsButton.Text = "Options"
        Me.RichTextEditorRibbonBar1.Size = New System.Drawing.Size(1283, 173)
        Me.RichTextEditorRibbonBar1.TabIndex = 0
        Me.RichTextEditorRibbonBar1.TabStop = False
        Me.RichTextEditorRibbonBar1.Text = "RichTextEditorRibbonBar1"
        '
        'RadRichTextEditorRuler1
        '
        Me.RadRichTextEditorRuler1.AssociatedRichTextBox = Me.RadRichTextEditor1
        Me.RadRichTextEditorRuler1.Controls.Add(Me.RadRichTextEditor1)
        Me.RadRichTextEditorRuler1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadRichTextEditorRuler1.Location = New System.Drawing.Point(0, 173)
        Me.RadRichTextEditorRuler1.Name = "RadRichTextEditorRuler1"
        Me.RadRichTextEditorRuler1.Size = New System.Drawing.Size(1283, 546)
        Me.RadRichTextEditorRuler1.TabIndex = 1
        Me.RadRichTextEditorRuler1.Text = "RadRichTextEditorRuler1"
        '
        'RadRichTextEditor1
        '
        Me.RadRichTextEditor1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RadRichTextEditor1.CaretWidth = Single.NaN
        Me.RadRichTextEditor1.Location = New System.Drawing.Point(29, 29)
        Me.RadRichTextEditor1.Name = "RadRichTextEditor1"
        Me.RadRichTextEditor1.SelectionFill = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadRichTextEditor1.Size = New System.Drawing.Size(1253, 516)
        Me.RadRichTextEditor1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 719)
        Me.Controls.Add(Me.RadRichTextEditorRuler1)
        Me.Controls.Add(Me.RichTextEditorRibbonBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RichTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRichTextEditorRuler1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadRichTextEditorRuler1.ResumeLayout(False)
        CType(Me.RadRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextEditorRibbonBar1 As Telerik.WinControls.UI.RichTextEditorRibbonBar
    Friend WithEvents RadRichTextEditorRuler1 As Telerik.WinControls.UI.RadRichTextEditorRuler
    Friend WithEvents RadRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor

End Class
