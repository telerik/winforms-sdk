Imports FreeImageAPI
Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Filters

Namespace CustomDecoder
	Friend Class JpxDecoder
		Implements IPdfFilter

		Private ReadOnly OpenJpegPath As String = "..\..\openjpeg-2.1.0-win32-x86\bin\opj_decompress"

		Public Function Encode(ByVal encodedObject As PdfObject, ByVal inputData() As Byte) As Byte() Implements IPdfFilter.Encode
			Throw New NotImplementedException()
		End Function

		Public Function Decode(ByVal decodedObject As PdfObject, ByVal inputData() As Byte, ByVal decodeParameters As DecodeParameters) As Byte() Implements IPdfFilter.Decode

			Dim filename As String = Guid.NewGuid().ToString()

			File.WriteAllBytes(filename & ".j2k", inputData)
			Dim processInfo As New ProcessStartInfo(OpenJpegPath, " -i " & filename & ".j2k -o " & filename & ".bmp")
			processInfo.WorkingDirectory = Directory.GetCurrentDirectory()
			processInfo.WindowStyle = ProcessWindowStyle.Hidden
			processInfo.CreateNoWindow = True
			Dim process = System.Diagnostics.Process.Start(processInfo)
			process.WaitForExit()
			Dim bitmap As Drawing.Bitmap = TryCast(System.Drawing.Image.FromFile(filename & ".bmp"), Drawing.Bitmap)
			If bitmap Is Nothing Then
				Return New Byte() {}
			End If

			Dim bitmapData As BitmapData = bitmap.LockBits(New Rectangle(Point.Empty, bitmap.Size), ImageLockMode.ReadOnly, bitmap.PixelFormat)

			Dim length As Integer = bitmapData.Stride * bitmapData.Height
			Dim stride As Integer = bitmapData.Stride
			Dim bytes(length - 1) As Byte

			System.Runtime.InteropServices.Marshal.Copy(bitmapData.Scan0, bytes, 0, length)
			bitmap.UnlockBits(bitmapData)

			Dim bytePixels((bitmapData.Width * bitmapData.Height * 3) - 1) As Byte

			Dim resLength As Integer = bytePixels.Length
			For i As Integer = 0 To resLength - 1
				Dim row As Integer = i \ (bitmapData.Width * 3)
				Dim col As Integer = i Mod (bitmapData.Width * 3)
				bytePixels(i) = bytes(row * stride + col)
			Next i

			bitmap.Dispose()
			File.Delete(filename & ".j2k")
			File.Delete(filename & ".bmp")

			Return bytePixels
		End Function

		Public ReadOnly Property Name() As String Implements IPdfFilter.Name
			Get
				Return "JPXDecode"
			End Get
		End Property
	End Class
End Namespace
