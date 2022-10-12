using ceTe.DynamicBarcode.Creator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barcode_creator_framework_console_cs
{
    class PostalBarcode
    {
        public static void AustraliaPostBarcode(string outputPath)
        {
            AustraliaPost barcode = new AustraliaPost("1139549554");
            Byte[] barcodeData = barcode.Draw(300, ImageFormat.Png);
            File.WriteAllBytes(outputPath, barcodeData);
        }
        public static void DeutschePostIdent(string outputPath)
        {
            DeutschePostIdentcode barcode = new DeutschePostIdentcode("12345678901", 100);
            barcode.BarcodeMargin = new Margin(2);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void DeutschePostLeit(string outputPath)
        {
            DeutschePostLeitcode barcode = new DeutschePostLeitcode("1234567890123", 100);
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void IntelligentMail(string outputPath)
        {
            IntelligentMailBarcode barcode = new IntelligentMailBarcode("0123456709498765432101234567891");
            barcode.ShowText = true;
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void KixBarcode(string outputPath)
        {
            Kix barcode = new Kix("1231FZ13XHS");
            barcode.SymbolHeight = 12;
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void PostnetBarcode(string outputPath)
        {
            Postnet barcode = new Postnet("20815470412");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void Rm4sccBarcode(string outputPath)
        {
            Rm4scc barcode = new Rm4scc("20815470412");
            barcode.ShowText = true;
            barcode.TextAlign = Align.Right;
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
        public static void SingaporePostBarcode(string outputPath)
        {
            SingaporePost barcode = new SingaporePost("208154");
            barcode.Draw(outputPath, 300, ImageFormat.Png);
        }
    }
}
