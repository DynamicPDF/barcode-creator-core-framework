using ceTe.DynamicBarcode.Creator;
using System;
using System.IO;

namespace barcode_creator_core_console_cs
{
    class TwoDimensionalBarcode
    {
        public static void AztecBarcode(string outputPath)
        {
            Aztec barcode = new Aztec("Hello World", AztecSymbolSize.Full);
            byte[] barcodeData = barcode.Draw(96, 96, ImageFormat.Png);
            File.WriteAllBytes(outputPath, barcodeData);
        }
        public static void DataMatrix(string outputPath)
        {
            DataMatrixBarcode barcode = new DataMatrixBarcode("Hello World");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void MacroPdf417Barcode(string outputPath)
        {
            MacroPdf417 barcode = new MacroPdf417("Hello World", 3);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }

        public static void Pdf417Barcode(string outputPath)
        {
            Pdf417 barcode = new Pdf417("Hello World", 3);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }

        public static void QRCodeBarcode(string outputPath)
        {
            QRCode barcode = new QRCode("Hello World");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
    }
}
