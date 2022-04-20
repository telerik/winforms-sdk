Imports System.Drawing.Imaging
Imports System.IO

Public Class RadForm1
    Private tiffImage As Image
    Private editedImage As Bitmap
    Private currentPage As Integer = 0
    Private images As List(Of Image)
    Private path As String = "..\..\multipage_tif_example.tif"

    Public Sub New()
        InitializeComponent()
        Me.tiffImage = Image.FromFile("..\..\multipage_tif_example.tif")
        Me.images = Me.GetAllPages(tiffImage)
        Me.tiffImage.SelectActiveFrame(FrameDimension.Page, Me.currentPage)
        Me.editedImage = New Bitmap(Me.tiffImage)
        Me.RadImageEditor1.OpenImage(Me.editedImage)
        Me.RadLabel1.Text = Convert.ToString(Me.currentPage + 1)
    End Sub

    Private Function GetAllPages(ByVal multiPageImage As Image) As List(Of Image)
        Dim images As List(Of Image) = New List(Of Image)()
        Dim count As Integer = multiPageImage.GetFrameCount(FrameDimension.Page)

        For i As Integer = 0 To count - 1
            multiPageImage.SelectActiveFrame(FrameDimension.Page, i)
            Dim byteStream As MemoryStream = New MemoryStream()
            multiPageImage.Save(byteStream, ImageFormat.Tiff)
            images.Add(Image.FromStream(byteStream))
            byteStream.Dispose()
        Next

        Return images
    End Function

    Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadButton1.Click
        If Me.currentPage > 0 Then
            Dim byteStream As MemoryStream = New MemoryStream()
            Me.RadImageEditor1.SaveImage(byteStream, ImageFormat.Tiff)
            Me.images(Me.currentPage) = Image.FromStream(byteStream)
            byteStream.Dispose()
            Me.currentPage -= 1
            Me.UpdateImage(Me.currentPage)
        End If
    End Sub

    Private Sub UpdateImage(ByVal page As Integer)
        Me.editedImage = New Bitmap(Me.images(page))
        Me.RadImageEditor1.OpenImage(Me.editedImage)
        Me.RadLabel1.Text = Convert.ToString(page + 1)
        Me.RadImageEditor1.Invalidate()
    End Sub

    Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadButton2.Click
        If Me.currentPage < Me.images.Count - 1 Then
            Dim byteStream As MemoryStream = New MemoryStream()
            Me.RadImageEditor1.SaveImage(byteStream, ImageFormat.Tiff)
            Me.images(Me.currentPage) = Image.FromStream(byteStream)
            byteStream.Dispose()
            Me.currentPage += 1
            Me.UpdateImage(Me.currentPage)
        End If
    End Sub
End Class
