using ceTe.DynamicBarcode.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barcode_creator_framework_console_cs
{
    class LinearBarcode
    {
        public static void CodaBarBarcode(string outputPath)
        {
            Codabar barcode = new Codabar("A1234A", 150);
            barcode.Draw(outputPath, 100, ImageFormat.Png);
        }

        public static void Code11Barcode(string outputPath)
        {
            Code11 barcode = new Code11("12345678", 50);
            barcode.BarcodeMargin = new Margin(2);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Code128Barcode(string outputPath)
        {
            Code128 barcode = new Code128("Hello World", 100);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Code25Barcode(string outputPath)
        {
            Code25 barcode = new Code25("123456789", 100);
            barcode.ShowText = true;
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Code39Barcode(string outputPath)
        {
            Code39 barcode = new Code39("123456789", 100);
            barcode.SymbolHeight = 12;
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Code93Barcode(string outputPath)
        {
            Code93 barcode = new Code93("1234567890", 50);
            barcode.ShowText = true;
            barcode.TextAlign = Align.Right;
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Ean13Barcode(string outputPath)
        {
            Ean13 barcode = new Ean13("123456789012");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Ean13Supplement2Barcode(string outputPath)
        {
            Ean13Supplement2 barcode = new Ean13Supplement2("123456789012", "12");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Ean13Supplement5Barcode(string outputPath)
        {
            Ean13Supplement5 barcode = new Ean13Supplement5("123456789012", "12345");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Ean14Barcode(string outputPath)
        {
            Ean14 barcode = new Ean14("1234567890123", 100);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Ean8Barcode(string outputPath)
        {
            Ean8 barcode = new Ean8("12345670");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Ean8Supplement2Barcode(string outputPath)
        {
            Ean8Supplement2 barcode = new Ean8Supplement2("12345670", "12");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Ean8Supplement5Barcode(string outputPath)
        {
            Ean8Supplement5 barcode = new Ean8Supplement5("12345670", "12345");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void GS1DataBarBarcode(string outputPath)
        {
            GS1DataBar barcode = new GS1DataBar("(01)9889876543210", 100, GS1DataBarType.Omnidirectional);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Iata25Barcode(string outputPath)
        {
            Iata25 barcode = new Iata25("1234567890", 100);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Interleaved25Barcode(string outputPath)
        {
            Interleaved25 barcode = new Interleaved25("1234567890", 100);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void IsbnBarcode(string outputPath)
        {
            Isbn barcode = new Isbn("978-1-23-456789-7");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void IsbnSupplement2Barcode(string outputPath)
        {
            IsbnSupplement2 barcode = new IsbnSupplement2("978-1-23-456789-7", "12");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }

        public static void IsbnSupplement5Barcode(string outputPath)
        {
            IsbnSupplement5 barcode = new IsbnSupplement5("978-1-23-456789-7", "12345");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void IsmnBarcode(string outputPath)
        {
            Ismn barcode = new Ismn("979-0-1234-5678");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void IsmnSupplement2Barcode(string outputPath)
        {
            IsmnSupplement2 barcode = new IsmnSupplement2("979-0-1234-5678", "12");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void IsmnSupplement5Barcode(string outputPath)
        {
            IsmnSupplement5 barcode = new IsmnSupplement5("979-0-1234-5678", "12345");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void IssnBarcode(string outputPath)
        {
            Issn barcode = new Issn("977-1234-56700");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void IssnSupplement2Barcode(string outputPath)
        {
            IssnSupplement2 barcode = new IssnSupplement2("977-1234-56700", "12");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void IssnSupplement5Barcode(string outputPath)
        {
            IssnSupplement5 barcode = new IssnSupplement5("977-1234-56700", "12345");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Itf14Barcode(string outputPath)
        {
            Itf14 barcode = new Itf14("1234567890123", 100);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }

        public static void MsiBarcodeBarcode(string outputPath)
        {
            MsiBarcode barcode = new MsiBarcode("123456789", 100);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }

        public static void StackedGS1DatabarBarcode(string outputPath)
        {
            StackedGS1DataBar barcode = new StackedGS1DataBar("(01)9889876543210", 50, StackedGS1DataBarType.StackedOmnidirectional);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void UpcABarcode(string outputPath)
        {
            UpcA barcode = new UpcA("12345678901");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void UpcASupplement5Barcode(string outputPath)
        {
            UpcASupplement5 barcode = new UpcASupplement5("12345678901", "12345");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void UpcASupplement2Barcode(string outputPath)
        {
            UpcASupplement2 barcode = new UpcASupplement2("12345678901", "12");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void UpcEBarcode(string outputPath)
        {
            UpcE barcode = new UpcE("0123456");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void UpcESupplement5Barcode(string outputPath)
        {
            UpcESupplement5 barcode = new UpcESupplement5("0123456", "12345");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void UpcESupplement2Barcode(string outputPath)
        {
            UpcESupplement2 barcode = new UpcESupplement2("0123456", "12");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
    }
}
