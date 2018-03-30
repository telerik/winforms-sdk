Imports System.Drawing
Imports Telerik.WinControls.Paint
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Map
Imports Telerik.WinControls.UI.Map.Bing

Public Class RadMapCustomPinForm

    '#region InitialSetup
    Public Sub New()
        InitializeComponent()
        Me.SetupProviders()
        Dim pointLayer As MapLayer = New MapLayer("PointG")
        Me.radMap1.Layers.Add(pointLayer)
        Dim element As MapPin = New CustomMapPin(New PointG(34.04302, -118.26725)) With {.Image = My.Resources.NBALakers}
        element.Text = "Los Angeles"
        element.BackColor = Color.Red
        Me.radMap1.Layers("PointG").Add(element)
    End Sub

    Private Sub SetupProviders()
        Dim osmProvider As OpenStreetMapProvider = New OpenStreetMapProvider()
        Me.radMap1.MapElement.Providers.Add(osmProvider)
    End Sub
End Class
'#endregion

'#region CustomMapPin
Public Class CustomMapPin
    Inherits MapPin

    Private _image As Image

    Private pixelLocation As PointL

    Private drawRect As RectangleL

    Private isImageInViewPort As Boolean

    Public Sub New(ByVal location As PointG)
        MyBase.New(location)
    End Sub

    Public Property Image As Image
        Get
            Return _image
        End Get

        Set(ByVal value As Image)
            Me._image = value
        End Set
    End Property

    Public Overrides ReadOnly Property IsInViewport As Boolean
        Get
            Return If(Me.Image IsNot Nothing, Me.isImageInViewPort, MyBase.IsInViewport)
        End Get
    End Property

    Public Overrides Sub Paint(ByVal graphics As IGraphics, ByVal viewport As IMapViewport)
        If Me.Image Is Nothing Then
            MyBase.Paint(graphics, viewport)
            Return
        End If

        Dim state As Object = graphics.SaveState()
        graphics.TranslateTransform(drawRect.X, drawRect.Y)
        Dim g As Graphics = TryCast(graphics.UnderlayGraphics, Graphics)
        Dim mapSize As Long = MapTileSystemHelper.MapSize(viewport.ZoomLevel)
        For i As Integer = -1 To viewport.NumberOfWraparounds
            g.DrawImage(Me.Image, New RectangleF(i * mapSize, 0, Me.Image.Size.Width, Me.Image.Size.Height))
        Next

        graphics.RestoreState(state)
    End Sub

    Public Overrides Sub ViewportChanged(ByVal viewport As IMapViewport, ByVal action As ViewportChangeAction)
        If Me.Image Is Nothing Then
            MyBase.ViewportChanged(viewport, action)
            Return
        End If

        Dim mapSize As Long = MapTileSystemHelper.MapSize(viewport.ZoomLevel)
        If (action And ViewportChangeAction.Zoom) <> 0 Then
            Me.pixelLocation = MapTileSystemHelper.LatLongToPixelXY(Me.Location, viewport.ZoomLevel)
        End If

        If (action And ViewportChangeAction.Pan) <> 0 Then
            Me.drawRect = New RectangleL(pixelLocation.X - Me.Image.Size.Width / 2, pixelLocation.Y - Me.Image.Size.Height, Me.Image.Size.Width, Me.Image.Size.Height)
        End If

        Dim wraparoundDrawRect As RectangleL = Me.drawRect
        For i As Integer = 0 To viewport.NumberOfWraparounds
            If wraparoundDrawRect.IntersectsWith(viewport.ViewportInPixels) Then
                Me.isImageInViewPort = True
                Exit For
            End If

            wraparoundDrawRect.Offset(mapSize, 0L)
        Next

        If Not Me.IsInViewport Then
            Return
        End If
    End Sub

    Public Overrides Function HitTest(ByVal pointG As PointG, ByVal pointL As PointL, ByVal viewport As IMapViewport) As Boolean
        If Me.Image Is Nothing Then
            Return MyBase.HitTest(pointG, pointL, viewport)
        End If

        Return Me.drawRect.Contains(pointL)
    End Function
End Class
'#endregion