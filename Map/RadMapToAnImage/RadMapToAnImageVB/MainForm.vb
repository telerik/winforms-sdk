Imports System.Drawing.Imaging
Imports Telerik.WinControls.Paint
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Map

Public Class MainForm
#Region "InitialSetup"
    Sub New()

        InitializeComponent()

        Dim pinLayer As MapLayer = New MapLayer("PinsLayer")
        Me.RadMap1.Layers.Add(pinLayer)
        Dim osmProvider As OpenStreetMapProvider = New OpenStreetMapProvider()
        Dim tileDownloader As MapTileDownloader = TryCast(osmProvider.TileDownloader, MapTileDownloader)
        tileDownloader.WebHeaders.Add(System.Net.HttpRequestHeader.UserAgent, "your application name")
        AddHandler osmProvider.InitializationComplete, AddressOf OsmProvider_InitializationComplete
        Me.RadMap1.MapElement.Providers.Add(osmProvider)

    End Sub

    Private Sub OsmProvider_InitializationComplete(sender As Object, e As EventArgs)
        Dim element As MapPin = New MapPin(New PointG(34.0140562, -118.2880489))
        element.Text = "Los Angeles"
        element.BackColor = Color.Red
        Me.RadMap1.Layers("PinsLayer").Add(element)
        Me.RadMap1.BringIntoView(element.Location, 10)
    End Sub
#End Region

#Region "ExportToImage"
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim bitmap As Bitmap = New Bitmap(CInt(Me.RadMap1.MapElement.ViewportInPixels.Size.Width), CInt(Me.RadMap1.MapElement.ViewportInPixels.Height))
        Dim g As Graphics = Graphics.FromImage(bitmap)
        Dim gg As RadGdiGraphics = New RadGdiGraphics(g)
        For Each element As MapVisualElement In Me.RadMap1.MapElement.Providers(0).GetContent(Me.RadMap1.MapElement)
            element.Paint(gg, Me.RadMap1.MapElement)
        Next
        Dim state As Object = gg.SaveState()
        'As of R2 2021 calling TranslateTransform is not necessary
        'gg.TranslateTransform(-Me.RadMap1.MapElement.ViewportInPixels.X, -Me.RadMap1.MapElement.ViewportInPixels.Y)
        Me.RadMap1.MapElement.Layers("PinsLayer").Paint(gg, Me.RadMap1.MapElement)
        gg.RestoreState(state)
        bitmap.Save("..\..\test.png", ImageFormat.Png)
    End Sub
#End Region
End Class
