using FreeImageAPI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Filters;

namespace CustomDecoder
{
    class JpxDecoder : IPdfFilter
    {
        private readonly string OpenJpegPath = @"..\..\openjpeg-2.1.0-win32-x86\bin\opj_decompress";

        public byte[] Encode(PdfObject encodedObject, byte[] inputData)
        {
            throw new NotImplementedException();
        }

        public byte[] Decode(PdfObject decodedObject, byte[] inputData, DecodeParameters decodeParameters)
        {
            string filename = Guid.NewGuid().ToString();

            File.WriteAllBytes(filename + ".j2k", inputData);
            ProcessStartInfo processInfo = new ProcessStartInfo(OpenJpegPath, " -i " + filename + ".j2k -o " + filename + ".bmp");
            processInfo.WorkingDirectory = Directory.GetCurrentDirectory();
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.CreateNoWindow = true;
            var process = Process.Start(processInfo);
            process.WaitForExit();
            System.Drawing.Bitmap bitmap = System.Drawing.Image.FromFile(filename + ".bmp") as Bitmap;
            if (bitmap == null)
            {
                return new byte[0];
            }

            BitmapData bitmapData = bitmap.LockBits(new Rectangle(Point.Empty, bitmap.Size), ImageLockMode.ReadOnly, bitmap.PixelFormat);

            int length = bitmapData.Stride * bitmapData.Height;
            int stride = bitmapData.Stride;
            byte[] bytes = new byte[length];

            System.Runtime.InteropServices.Marshal.Copy(bitmapData.Scan0, bytes, 0, length);
            bitmap.UnlockBits(bitmapData);

            byte[] bytePixels = new byte[bitmapData.Width * bitmapData.Height * 3];

            int resLength = bytePixels.Length;
            for (int i = 0; i < resLength; i++)
            {
                int row = i / (bitmapData.Width * 3);
                int col = i % (bitmapData.Width * 3);
                bytePixels[i] = bytes[row * stride + col];
            }

            bitmap.Dispose();
            File.Delete(filename + ".j2k");
            File.Delete(filename + ".bmp");

            return bytePixels;
        }

        public string Name
        {
            get { return "JPXDecode"; }
        }
    }
}
