using System;
using System.Diagnostics;
using System.IO;

namespace barcode_creator_core_console_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTypes();
        }
        private static void DisplayTypes()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the DynamicBarcode Creator for .NET Examples");
                Console.WriteLine();
                Console.WriteLine("DynamicBarcode Creator for .NET supports 36 linear barcodes, eight postal barcodes and five 2D barcodes.:");
                Console.WriteLine(" A : Linear Barcode");
                Console.WriteLine("     Examples for Linear Barcode types.");
                Console.WriteLine(" B : Postal Barcode");
                Console.WriteLine("     Examples for Postal Barcode types.");
                Console.WriteLine(" C : Two Dimensional Barcode");
                Console.WriteLine("     Examples for Two Dimensional Barcode types.");
                Console.WriteLine();
                Console.WriteLine("Press 'Esc' to exit the application");
                Console.WriteLine();

                ConsoleKeyInfo runKey = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();

                switch (runKey.Key)
                {
                    case ConsoleKey.A:
                        DisplayLinearBarcodeExamples();
                        break;
                    case ConsoleKey.B:
                        DisplayPostalBarcodeExamples();
                        break;
                    case ConsoleKey.C:
                        DisplayTwoDimensionalBarcodeExamples();
                        break;
                    case ConsoleKey.Escape:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Key not recognized.");
                        break;
                }
            }
        }

        private static void DisplayLinearBarcodeExamples()
        {
            bool exitToProducts = false;
            while (!exitToProducts)
            {
                Console.WriteLine("Select a Linear Barcode example to run:");
                Console.WriteLine(" A : CodaBar");
                Console.WriteLine(" B : Code 11");
                Console.WriteLine(" C : Code 128");
                Console.WriteLine(" D : Code 2 of 5");
                Console.WriteLine(" E : Code 3 of 9");
                Console.WriteLine(" F : Code 93");
                Console.WriteLine(" G : Ean 13");
                Console.WriteLine(" H : Ean 13 Supplement 2");
                Console.WriteLine(" I : Ean 13 Supplement 5");
                Console.WriteLine(" J : Ean 14 Barcode");
                Console.WriteLine(" K : EAN-8");
                Console.WriteLine(" L : EAN-8 Supplement 2");
                Console.WriteLine(" M : EAN-8 Supplement 5");
                Console.WriteLine(" N : GS1 DataBar Barcode");
                Console.WriteLine(" O : Iata 25 Barcode");
                Console.WriteLine(" P : Interleaved 2 of 5");
                Console.WriteLine(" Q : ISBN");
                Console.WriteLine(" R : ISBN Supplement 2");
                Console.WriteLine(" S : ISBN Supplement 5");
                Console.WriteLine(" T : ISMN");
                Console.WriteLine(" U : ISMN Supplement 2");
                Console.WriteLine(" V : ISMN Supplement 5");
                Console.WriteLine(" W : ISSN Barcode");
                Console.WriteLine(" X : ISSN Supplement 2");
                Console.WriteLine(" Y : ISSN Supplement 5");
                Console.WriteLine(" Z : ITF 14");
                Console.WriteLine(" 1 : Msi Barcode");
                Console.WriteLine(" 2 : Stacked GS1 Databar");
                Console.WriteLine(" 3 : UPC Version A");
                Console.WriteLine(" 4 : UPC-A Supplement 2");
                Console.WriteLine(" 5 : UPC-A Supplement 5");
                Console.WriteLine(" 6 : UPC Version E Barcode");
                Console.WriteLine(" 7 : UPC-E Supplement 2");
                Console.WriteLine(" 8 : UPC-E Supplement 5");
                Console.WriteLine();
                Console.WriteLine("Press 'Backspace' for the main products menu");
                Console.WriteLine("Press 'Esc' to exit application");
                Console.WriteLine();
                ConsoleKeyInfo runKey = Console.ReadKey();
                Console.WriteLine();

                string exampleName = string.Empty;
                string fileName = string.Empty;
                switch (runKey.Key)
                {
                    case ConsoleKey.A:
                        exampleName = "CodaBar Barcode";
                        fileName = "CodaBarBarcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.CodaBarBarcode(fileName);
                        break;
                    case ConsoleKey.B:
                        exampleName = "Code11 Barcode";
                        fileName = "Code11Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Code11Barcode(fileName);
                        break;
                    case ConsoleKey.C:
                        exampleName = "Code128 Barcode";
                        fileName = "Code128Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Code128Barcode(fileName);
                        break;
                    case ConsoleKey.D:
                        exampleName = "Code25 Barcode";
                        fileName = "Code25Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Code25Barcode(fileName);
                        break;
                    case ConsoleKey.E:
                        exampleName = "Code39 Barcode";
                        fileName = "Code39Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Code39Barcode(fileName);
                        break;
                    case ConsoleKey.F:
                        Console.Clear();
                        exampleName = "Code93 Barcode";
                        fileName = "Code93Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Code93Barcode(fileName);
                        break;
                    case ConsoleKey.G:
                        exampleName = "Ean13 Barcode";
                        fileName = "Ean13Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Ean13Barcode(fileName);
                        break;
                    case ConsoleKey.H:
                        exampleName = "Ean13Supplement2 Barcode";
                        fileName = "Ean13Supplement2Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Ean13Supplement2Barcode(fileName);
                        break;
                    case ConsoleKey.I:
                        exampleName = "Ean13Supplement5 Barcode";
                        fileName = "Ean13Supplement5Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Ean13Supplement5Barcode(fileName);
                        break;
                    case ConsoleKey.J:
                        exampleName = "Ean14 Barcode";
                        fileName = "Ean14Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Ean14Barcode(fileName);
                        break;
                    case ConsoleKey.K:
                        exampleName = "Ean8 Barcode";
                        fileName = "Ean8Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Ean8Barcode(fileName);
                        break;
                    case ConsoleKey.L:
                        exampleName = "Ean8Supplement2 Barcode";
                        fileName = "Ean8Supplement2Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Ean8Supplement2Barcode(fileName);
                        break;
                    case ConsoleKey.M:
                        exampleName = "Ean8Supplement5 Barcode";
                        fileName = "Ean8Supplement5Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Ean8Supplement5Barcode(fileName);
                        break;
                    case ConsoleKey.N:
                        exampleName = "GS1DataBar Barcode";
                        fileName = "GS1DataBarBarcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.GS1DataBarBarcode(fileName);
                        break;
                    case ConsoleKey.O:
                        exampleName = "Iata25 Barcode";
                        fileName = "Iata25Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Iata25Barcode(fileName);
                        break;
                    case ConsoleKey.P:
                        exampleName = "Interleaved25 Barcode";
                        fileName = "Interleaved25Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Interleaved25Barcode(fileName);
                        break;
                    case ConsoleKey.Q:
                        exampleName = "Isbn Barcode";
                        fileName = "IsbnBarcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.IsbnBarcode(fileName);
                        break;
                    case ConsoleKey.R:
                        exampleName = "IsbnSupplement2 Barcode";
                        fileName = "IsbnSupplement2Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.IsbnSupplement2Barcode(fileName);
                        break;
                    case ConsoleKey.S:
                        exampleName = "IsbnSupplement5 Barcode";
                        fileName = "IsbnSupplement5Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.IsbnSupplement5Barcode(fileName);
                        break;
                    case ConsoleKey.T:
                        exampleName = "Ismn Barcode";
                        fileName = "IsmnBarcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.IsmnBarcode(fileName);
                        break;
                    case ConsoleKey.U:
                        exampleName = "IsmnSupplement2 Barcode";
                        fileName = "IsmnSupplement2Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.IsmnSupplement2Barcode(fileName);
                        break;
                    case ConsoleKey.V:
                        exampleName = "IsmnSupplement5 Barcode";
                        fileName = "IsmnSupplement5Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.IsmnSupplement5Barcode(fileName);
                        break;
                    case ConsoleKey.W:
                        exampleName = "Issn Barcode";
                        fileName = "IssnBarcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.IssnBarcode(fileName);
                        break;
                    case ConsoleKey.X:
                        exampleName = "IssnSupplement2 Barcode";
                        fileName = "IssnSupplement2Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.IssnSupplement2Barcode(fileName);
                        break;
                    case ConsoleKey.Y:
                        exampleName = "IssnSupplement5 Barcode";
                        fileName = "IssnSupplement5Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.IssnSupplement5Barcode(fileName);
                        break;
                    case ConsoleKey.Z:
                        exampleName = "Itf14 Barcode";
                        fileName = "Itf14Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.Itf14Barcode(fileName);
                        break;
                    case ConsoleKey.D1:
                        exampleName = "MsiBarcode Barcode";
                        fileName = "MsiBarcodeBarcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.MsiBarcodeBarcode(fileName);
                        break;
                    case ConsoleKey.D2:
                        exampleName = "StackedGS1Databar Barcode";
                        fileName = "StackedGS1DatabarBarcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.StackedGS1DatabarBarcode(fileName);
                        break;
                    case ConsoleKey.D3:
                        exampleName = "UpcA Barcode";
                        fileName = "UpcABarcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.UpcABarcode(fileName);
                        break;
                    case ConsoleKey.D4:
                        exampleName = "UpcASupplement2 Barcode";
                        fileName = "UpcASupplement2Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.UpcASupplement2Barcode(fileName);
                        break;
                    case ConsoleKey.D5:
                        exampleName = "UpcASupplement5 Barcode";
                        fileName = "UpcASupplement5Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.UpcASupplement5Barcode(fileName);
                        break;
                    case ConsoleKey.D6:
                        exampleName = "UpcE Barcode";
                        fileName = "UpcEBarcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.UpcEBarcode(fileName);
                        break;
                    case ConsoleKey.D7:
                        exampleName = "UpcESupplement2 Barcode";
                        fileName = "UpcESupplement2Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.UpcESupplement2Barcode(fileName);
                        break;
                    case ConsoleKey.D8:
                        exampleName = "UpcESupplement5 Barcode";
                        fileName = "UpcESupplement5Barcode.png";
                        Console.WriteLine(exampleName + " example is running...");
                        LinearBarcode.UpcESupplement5Barcode(fileName);
                        break;
                    case ConsoleKey.Escape:
                        System.Environment.Exit(0);
                        break;
                    case ConsoleKey.Backspace:
                        exitToProducts = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Key not recognized.");
                        break;
                }
                if (fileName != string.Empty)
                {
                    DisplayOutputPathWithOptionToOpen(fileName);
                }
            }
        }

        private static void DisplayPostalBarcodeExamples()
        {
            bool exitToProducts = false;
            while (!exitToProducts)
            {
                Console.WriteLine("Select a Postal Barcode example to run:");
                Console.WriteLine("     A : Australia Post");
                Console.WriteLine("     B : Deutsche Post Identcode");
                Console.WriteLine("     C : Deutsche Post Leitcode");
                Console.WriteLine("     D : Intelligent Mail Barcode");
                Console.WriteLine("     E : Kix Barcode");
                Console.WriteLine("     F : Postnet");
                Console.WriteLine("     G : Rm4scc Barcode");
                Console.WriteLine("     H : SingaporePost");
                Console.WriteLine();
                Console.WriteLine("Press 'Backspace' for the main products menu");
                Console.WriteLine("Press 'Esc' to exit application");
                Console.WriteLine();

                ConsoleKeyInfo runKey = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();

                string exampleName = string.Empty;
                string fileName = string.Empty;
                switch (runKey.Key)
                {
                    case ConsoleKey.A:
                        exampleName = "AustraliaPost Barcode";
                        fileName = "AustraliaPostBarcode.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        PostalBarcode.AustraliaPostBarcode(fileName);
                        break;
                    case ConsoleKey.B:
                        exampleName = "DeutschePostIdent";
                        fileName = "DeutschePostIdent.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        PostalBarcode.DeutschePostIdent(fileName);
                        break;
                    case ConsoleKey.C:
                        exampleName = "DeutschePostLeit";
                        fileName = "DeutschePostLeit.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        PostalBarcode.DeutschePostLeit(fileName);
                        break;
                    case ConsoleKey.D:
                        exampleName = "IntelligentMail";
                        fileName = "IntelligentMail.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        PostalBarcode.IntelligentMail(fileName);
                        break;
                    case ConsoleKey.E:
                        exampleName = "Kix Barcode";
                        fileName = "KixBarcode.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        PostalBarcode.KixBarcode(fileName);
                        break;
                    case ConsoleKey.F:
                        exampleName = "Postnet Barcode";
                        fileName = "PostnetBarcode.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        PostalBarcode.PostnetBarcode(fileName);
                        break;
                    case ConsoleKey.G:
                        exampleName = "Rm4scc Barcode";
                        fileName = "Rm4sccBarcode.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        PostalBarcode.Rm4sccBarcode(fileName);
                        break;
                    case ConsoleKey.H:
                        exampleName = "SingaporePost Barcode";
                        fileName = "SingaporePostBarcode.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        PostalBarcode.SingaporePostBarcode(fileName);
                        break;
                    case ConsoleKey.Escape:
                        System.Environment.Exit(0);
                        break;
                    case ConsoleKey.Backspace:
                        exitToProducts = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Key not recognized.");
                        break;
                }

                if (fileName != string.Empty)
                {
                    DisplayOutputPathWithOptionToOpen(fileName);
                }
            }
        }

        private static void DisplayTwoDimensionalBarcodeExamples()
        {
            bool exitToProducts = false;
            while (!exitToProducts)
            {
                Console.WriteLine("Select a Two Dimensional barcode example to run:");
                Console.WriteLine("     A : Aztec Barcode");
                Console.WriteLine("     B : Data Matrix Barcode");
                Console.WriteLine("     C : Macro Pdf417");
                Console.WriteLine("     D : Pdf417");
                Console.WriteLine("     E : QR Code");
                Console.WriteLine();
                Console.WriteLine("Press 'Backspace' for the main products menu");
                Console.WriteLine("Press 'Esc' to exit application");
                Console.WriteLine();

                ConsoleKeyInfo runKey = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();

                string exampleName = "";
                string fileName = "";
                switch (runKey.Key)
                {
                    case ConsoleKey.A:
                        exampleName = "Aztec Barcode";
                        fileName = "AztecBarcode.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        TwoDimensionalBarcode.AztecBarcode(fileName);
                        break;
                    case ConsoleKey.B:
                        exampleName = "DataMatrix";
                        fileName = "DataMatrix.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        TwoDimensionalBarcode.DataMatrix(fileName);
                        break;
                    case ConsoleKey.C:
                        exampleName = "MacroPdf417 Barcode";
                        fileName = "MacroPdf417Barcode.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        TwoDimensionalBarcode.MacroPdf417Barcode(fileName);
                        break;
                    case ConsoleKey.D:
                        exampleName = "Pdf417 Barcode";
                        fileName = "Pdf417Barcode.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        TwoDimensionalBarcode.Pdf417Barcode(fileName);
                        break;
                    case ConsoleKey.E:
                        exampleName = "QRCode Barcode";
                        fileName = "QRCodeBarcode.png";
                        Console.WriteLine("Example " + exampleName + " is Running...");
                        TwoDimensionalBarcode.QRCodeBarcode(fileName);
                        break;
                    case ConsoleKey.Escape:
                        System.Environment.Exit(0);
                        break;
                    case ConsoleKey.Backspace:
                        exitToProducts = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Key not recognized.");
                        break;
                }

                if (fileName != string.Empty)
                {
                    DisplayOutputPathWithOptionToOpen(fileName);
                }
            }
        }

        private static void DisplayOutputPathWithOptionToOpen(string fileName)
        {
            string fullFileName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) + @"\" + fileName;
            Console.WriteLine();
            Console.WriteLine("The ouptut file was saved at:");
            Console.WriteLine(fullFileName);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.WriteLine();
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
        }
    }
}
