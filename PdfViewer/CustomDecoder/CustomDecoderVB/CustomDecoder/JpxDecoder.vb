Imports FreeImageAPI
Imports System
Imports System.Drawing
Imports System.IO
Imports Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Filters
Imports Bitmap = System.Drawing.Bitmap

Namespace CustomDecoder
    Public Class JpxDecoder
        Implements IPdfFilter

        Public ReadOnly Property Name As String Implements IPdfFilter.Name
            Get
                Return PdfFilterNames.JPXDecode
            End Get
        End Property

        Public Function Decode(ByVal decodedObject As PdfObject, ByVal inputData As Byte(), ByVal decodeParameters As DecodeParameters) As Byte() Implements IPdfFilter.Decode
            Dim myImage As FIBITMAP = New FIBITMAP()

            Using stream As MemoryStream = New MemoryStream(inputData)
                myImage = FreeImage.LoadFromStream(stream)
            End Using

            Dim bitmap As Bitmap = FreeImage.GetBitmap(myImage)
            Dim result As Byte()

            If decodedObject.ColorSpace = ColorSpace.Gray Then
                result = New Byte(decodedObject.Width * decodedObject.Height - 1) {}

                For i As Integer = 0 To decodedObject.Width - 1

                    For j As Integer = 0 To decodedObject.Height - 1
                        Dim pixel As Color = bitmap.GetPixel(i, j)
                        Dim index As Integer = j * decodedObject.Width + i
                        Dim grayColor As Byte = CByte((0.2126 * pixel.R + 0.7152 * pixel.G + 0.0722 * pixel.B))
                        result(index) = grayColor
                    Next
                Next
            Else
                result = New Byte(decodedObject.Width * decodedObject.Height * 3 - 1) {}

                For i As Integer = 0 To decodedObject.Width - 1

                    For j As Integer = 0 To decodedObject.Height - 1
                        Dim pixel As Color = bitmap.GetPixel(i, j)
                        Dim index As Integer = j * decodedObject.Width + i
                        result(index * 3) = pixel.R
                        result(index * 3 + 1) = pixel.G
                        result(index * 3 + 2) = pixel.B
                    Next
                Next
            End If

            Return result
        End Function

        Private Function IPdfFilter_Encode(encodedObject As PdfObject, inputData() As Byte) As Byte() Implements IPdfFilter.Encode
            Throw New NotImplementedException()
        End Function


    End Class
End Namespace
