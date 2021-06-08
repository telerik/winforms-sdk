Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives

Public Class RadioButtonCellElement
    Inherits GridDataCellElement

    Private radioButtonElement1 As RadRadioButtonElement
    Private radioButtonElement2 As RadRadioButtonElement
    Private radioButtonElement3 As RadRadioButtonElement

    Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
        MyBase.New(column, row)
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(GridDataCellElement)
        End Get
    End Property

    Public Overrides Sub Initialize(ByVal column As GridViewColumn, ByVal row As GridRowElement)
        MyBase.Initialize(column, row)

        DirectCast(radioButtonElement1.Children(1).Children(1).Children(0), RadioPrimitive).BackColor2 = Color.Red
        DirectCast(radioButtonElement2.Children(1).Children(1).Children(0), RadioPrimitive).BackColor2 = Color.Blue
        DirectCast(radioButtonElement3.Children(1).Children(1).Children(0), RadioPrimitive).BackColor2 = Color.Green
    End Sub

    Protected Overrides Sub DisposeManagedResources()
        RemoveHandler radioButtonElement1.MouseDown, AddressOf radioButtonElement1_MouseDown
        RemoveHandler radioButtonElement2.MouseDown, AddressOf radioButtonElement2_MouseDown
        RemoveHandler radioButtonElement3.MouseDown, AddressOf radioButtonElement3_MouseDown
        MyBase.DisposeManagedResources()
    End Sub

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()

        radioButtonElement1 = New RadRadioButtonElement()
        radioButtonElement1.Margin = New Padding(0, 2, 0, 0)
        radioButtonElement1.MinSize = New Size(50, 20)
        radioButtonElement1.Text = "Red"

        radioButtonElement2 = New RadRadioButtonElement()
        radioButtonElement2.Margin = New Padding(0, 2, 0, 0)
        radioButtonElement2.MinSize = New Size(50, 20)
        radioButtonElement2.Text = "Blue"

        radioButtonElement3 = New RadRadioButtonElement()
        radioButtonElement3.Margin = New Padding(0, 2, 0, 0)
        radioButtonElement3.MinSize = New Size(50, 20)
        radioButtonElement3.Text = "Green"

        Me.Children.Add(radioButtonElement1)
        Me.Children.Add(radioButtonElement2)
        Me.Children.Add(radioButtonElement3)

        AddHandler radioButtonElement1.MouseDown, AddressOf radioButtonElement1_MouseDown
        AddHandler radioButtonElement2.MouseDown, AddressOf radioButtonElement2_MouseDown
        AddHandler radioButtonElement3.MouseDown, AddressOf radioButtonElement3_MouseDown
    End Sub

    Protected Overrides Sub SetContentCore(ByVal value As Object)
        If Not Me.Value Is Nothing AndAlso Not Me.Value Is DBNull.Value Then
            Dim i As Integer = 0
            Do While i < Me.Children.Count
                CType(Me.Children(i), RadRadioButtonElement).ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
                i += 1
            Loop

            Select Case Integer.Parse((CType(Me, GridDataCellElement)).Value.ToString())
                Case 0
                    CType(Me.Children(0), RadRadioButtonElement).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
                Case 1
                    CType(Me.Children(1), RadRadioButtonElement).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
                Case 2
                    CType(Me.Children(2), RadRadioButtonElement).ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            End Select
        End If
    End Sub

    Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
        If Me.Children.Count = 3 Then
            Me.Children(0).Arrange(New RectangleF(0, 0, 50, 20))
            Me.Children(1).Arrange(New RectangleF(55, 0, 50, 20))
            Me.Children(2).Arrange(New RectangleF(110, 0, 50, 20))
        End If

        Return finalSize
    End Function

    Public Overrides Function IsCompatible(ByVal data As Telerik.WinControls.UI.GridViewColumn, ByVal context As Object) As Boolean
        Return TypeOf data Is RadioButtonColumn AndAlso TypeOf context Is GridDataRowElement
    End Function

    Private Sub radioButtonElement1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Value = 0
    End Sub

    Private Sub radioButtonElement2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Value = 1
    End Sub

    Private Sub radioButtonElement3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Value = 2
    End Sub

End Class