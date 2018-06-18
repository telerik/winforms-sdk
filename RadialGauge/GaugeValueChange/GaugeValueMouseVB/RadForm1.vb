Public Class RadForm1
    Private timer As Timer = New Timer()

    Public Sub New()
        InitializeComponent()
        AddHandler Me.RadRadialGauge1.MouseMove, AddressOf radRadialGauge1_MouseMove
        Me.radialGaugeNeedle1.BindValue = True
        AddHandler Me.RadRadialGauge1.PreviewKeyDown, AddressOf radRadialGauge1_PreviewKeyDown
        AddHandler Me.RadRadialGauge1.KeyUp, AddressOf radRadialGauge1_KeyUp
        AddHandler timer.Tick, AddressOf timer_Tick
        timer.Interval = 100
        timer.Start()
    End Sub
    Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Dim newValue As Single

        If isDownArrow Then
            newValue = Math.Max(0, Me.radRadialGauge1.Value - 1)
            Me.radRadialGauge1.Value = newValue
        ElseIf isUpArrow Then
            newValue = Math.Max(Me.radRadialGauge1.Value + 1, CSng(Me.radRadialGauge1.RangeEnd))
            Me.radRadialGauge1.Value += 1
        End If
    End Sub

    Private Sub radRadialGauge1_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        isDownArrow = False
        isUpArrow = False
        timer.[Stop]()
    End Sub

    Private isDownArrow As Boolean = False
    Private isUpArrow As Boolean = False

    Private Sub radRadialGauge1_PreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs)
        If e.KeyData = Keys.Down Then
            isDownArrow = True
        ElseIf e.KeyData = Keys.Up Then
            isUpArrow = True
        End If

        timer.Start()
    End Sub

    Private Sub radRadialGauge1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            UpdateValue(e.Location)
        End If
    End Sub

    Private Sub UpdateValue(ByVal pointLocation As Point)
        Dim centerX As Single = Me.radRadialGauge1.GaugeElement.GaugeCenter.X + Me.radialGaugeNeedle1.TotalTransform.DX
        Dim centerY As Single = Me.radRadialGauge1.GaugeElement.GaugeCenter.Y + Me.radialGaugeNeedle1.TotalTransform.DY
        Dim center As PointF = New PointF(centerX, centerY)
        Dim radian As Double = Math.Atan2(pointLocation.Y - center.Y, pointLocation.X - center.X)
        Dim angle As Double = radian * (180 / Math.PI)

        If angle < 0.0 Then
            angle += 360.0
        End If

        Dim newValue As Single = CalculateValueByAngle(angle, Me.radRadialGauge1.RangeStart, Me.radRadialGauge1.RangeEnd, Me.radRadialGauge1.StartAngle, Me.radRadialGauge1.SweepAngle)
        Me.radRadialGauge1.Value = Math.Min(newValue, CSng(Me.radRadialGauge1.RangeEnd))
    End Sub

    Public Function CalculateValueByAngle(ByVal needleAngleDegree As Double, ByVal rangeStart As Double, ByVal rangeEnd As Double, ByVal startAngle As Double, ByVal sweepAngle As Double) As Single
        Dim value As Single = 0
        Dim angleDiff As Double = needleAngleDegree - startAngle

        If angleDiff < 0 Then
            angleDiff += 360
        End If

        Dim ratio As Double = (angleDiff) / sweepAngle
        value = CSng((ratio * Math.Abs(rangeEnd - rangeStart) + rangeStart))
        Return value
    End Function
End Class
