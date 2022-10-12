Imports System

Module Program
    Sub Main()
        DisplayTypes()
    End Sub

    Private Sub DisplayTypes()
        While True
            Console.WriteLine("Welcome to the DynamicBarcode Creator for .NET Examples")
            Console.WriteLine()
            Console.WriteLine("DynamicBarcode Creator for .NET supports 36 linear barcodes, eight postal barcodes and five 2D barcodes.:")
            Console.WriteLine(" A : Linear Barcode")
            Console.WriteLine("     Examples for Linear Barcode types.")
            Console.WriteLine(" B : Postal Barcode")
            Console.WriteLine("     Examples for Postal Barcode types.")
            Console.WriteLine(" C : Two Dimensional Barcode")
            Console.WriteLine("     Examples for Two Dimensional Barcode types.")
            Console.WriteLine()
            Console.WriteLine("Press 'Esc' to exit the application")
            Console.WriteLine()
            Dim runKey As ConsoleKeyInfo = Console.ReadKey()
            Console.WriteLine()
            Console.WriteLine()

            Select Case runKey.Key
                Case ConsoleKey.A
                    DisplayLinearBarcodeExamples()
                Case ConsoleKey.B
                    DisplayPostalBarcodeExamples()
                Case ConsoleKey.C
                    DisplayTwoDimensionalBarcodeExamples()
                Case ConsoleKey.Escape
                    System.Environment.Exit(0)
                Case Else
                    Console.WriteLine("Key not recognized.")
            End Select
        End While
    End Sub

    Private Sub DisplayLinearBarcodeExamples()

        Dim exitToProducts As Boolean = False
        While (exitToProducts = False)
            Console.WriteLine("Select a Linear Barcode example to run:")
            Console.WriteLine(" A : CodaBar")
            Console.WriteLine(" B : Code 11")
            Console.WriteLine(" C : Code 128")
            Console.WriteLine(" D : Code 2 of 5")
            Console.WriteLine(" E : Code 3 of 9")
            Console.WriteLine(" F : Code 93")
            Console.WriteLine(" G : Ean 13")
            Console.WriteLine(" H : Ean 13 Supplement 2")
            Console.WriteLine(" I : Ean 13 Supplement 5")
            Console.WriteLine(" J : Ean 14 Barcode")
            Console.WriteLine(" K : EAN-8")
            Console.WriteLine(" L : EAN-8 Supplement 2")
            Console.WriteLine(" M : EAN-8 Supplement 5")
            Console.WriteLine(" N : GS1 DataBar Barcode")
            Console.WriteLine(" O : Iata 25 Barcode")
            Console.WriteLine(" P : Interleaved 2 of 5")
            Console.WriteLine(" Q : ISBN")
            Console.WriteLine(" R : ISBN Supplement 2")
            Console.WriteLine(" S : ISBN Supplement 5")
            Console.WriteLine(" T : ISMN")
            Console.WriteLine(" U : ISMN Supplement 2")
            Console.WriteLine(" V : ISMN Supplement 5")
            Console.WriteLine(" W : ISSN Barcode")
            Console.WriteLine(" X : ISSN Supplement 2")
            Console.WriteLine(" Y : ISSN Supplement 5")
            Console.WriteLine(" Z : ITF 14")
            Console.WriteLine(" 1 : Msi Barcode")
            Console.WriteLine(" 2 : Stacked GS1 Databar")
            Console.WriteLine(" 3 : UPC Version A")
            Console.WriteLine(" 4 : UPC-A Supplement 2")
            Console.WriteLine(" 5 : UPC-A Supplement 5")
            Console.WriteLine(" 6 : UPC Version E Barcode")
            Console.WriteLine(" 7 : UPC-E Supplement 2")
            Console.WriteLine(" 8 : UPC-E Supplement 5")
            Console.WriteLine()
            Console.WriteLine("Press 'Backspace' for the main products menu")
            Console.WriteLine("Press 'Esc' to exit application")
            Console.WriteLine()

            Dim runKey As ConsoleKeyInfo = Console.ReadKey()
            Console.WriteLine()
            Dim exampleName As String = String.Empty
            Dim fileName As String = String.Empty

            Select Case runKey.Key
                Case ConsoleKey.A
                    exampleName = "CodaBar Barcode"
                    fileName = "CodaBarBarcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.CodaBarBarcode(fileName)
                Case ConsoleKey.B
                    exampleName = "Code11 Barcode"
                    fileName = "Code11Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Code11Barcode(fileName)
                Case ConsoleKey.C
                    exampleName = "Code128 Barcode"
                    fileName = "Code128Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Code128Barcode(fileName)
                Case ConsoleKey.D
                    exampleName = "Code25 Barcode"
                    fileName = "Code25Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Code25Barcode(fileName)
                Case ConsoleKey.E
                    exampleName = "Code39 Barcode"
                    fileName = "Code39Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Code39Barcode(fileName)
                Case ConsoleKey.F
                    Console.Clear()
                    exampleName = "Code93 Barcode"
                    fileName = "Code93Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Code93Barcode(fileName)
                Case ConsoleKey.G
                    exampleName = "Ean13 Barcode"
                    fileName = "Ean13Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Ean13Barcode(fileName)
                Case ConsoleKey.H
                    exampleName = "Ean13Supplement2 Barcode"
                    fileName = "Ean13Supplement2Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Ean13Supplement2Barcode(fileName)
                Case ConsoleKey.I
                    exampleName = "Ean13Supplement5 Barcode"
                    fileName = "Ean13Supplement5Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Ean13Supplement5Barcode(fileName)
                Case ConsoleKey.J
                    exampleName = "Ean14 Barcode"
                    fileName = "Ean14Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Ean14Barcode(fileName)
                Case ConsoleKey.K
                    exampleName = "Ean8 Barcode"
                    fileName = "Ean8Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Ean8Barcode(fileName)
                Case ConsoleKey.L
                    exampleName = "Ean8Supplement2 Barcode"
                    fileName = "Ean8Supplement2Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Ean8Supplement2Barcode(fileName)
                Case ConsoleKey.M
                    exampleName = "Ean8Supplement5 Barcode"
                    fileName = "Ean8Supplement5Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Ean8Supplement5Barcode(fileName)
                Case ConsoleKey.N
                    exampleName = "GS1DataBar Barcode"
                    fileName = "GS1DataBarBarcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.GS1DataBarBarcode(fileName)
                Case ConsoleKey.O
                    exampleName = "Iata25 Barcode"
                    fileName = "Iata25Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Iata25Barcode(fileName)
                Case ConsoleKey.P
                    exampleName = "Interleaved25 Barcode"
                    fileName = "Interleaved25Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Interleaved25Barcode(fileName)
                Case ConsoleKey.Q
                    exampleName = "Isbn Barcode"
                    fileName = "IsbnBarcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.IsbnBarcode(fileName)
                Case ConsoleKey.R
                    exampleName = "IsbnSupplement2 Barcode"
                    fileName = "IsbnSupplement2Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.IsbnSupplement2Barcode(fileName)
                Case ConsoleKey.S
                    exampleName = "IsbnSupplement5 Barcode"
                    fileName = "IsbnSupplement5Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.IsbnSupplement5Barcode(fileName)
                Case ConsoleKey.T
                    exampleName = "Ismn Barcode"
                    fileName = "IsmnBarcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.IsmnBarcode(fileName)
                Case ConsoleKey.U
                    exampleName = "IsmnSupplement2 Barcode"
                    fileName = "IsmnSupplement2Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.IsmnSupplement2Barcode(fileName)
                Case ConsoleKey.V
                    exampleName = "IsmnSupplement5 Barcode"
                    fileName = "IsmnSupplement5Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.IsmnSupplement5Barcode(fileName)
                Case ConsoleKey.W
                    exampleName = "Issn Barcode"
                    fileName = "IssnBarcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.IssnBarcode(fileName)
                Case ConsoleKey.X
                    exampleName = "IssnSupplement2 Barcode"
                    fileName = "IssnSupplement2Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.IssnSupplement2Barcode(fileName)
                Case ConsoleKey.Y
                    exampleName = "IssnSupplement5 Barcode"
                    fileName = "IssnSupplement5Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.IssnSupplement5Barcode(fileName)
                Case ConsoleKey.Z
                    exampleName = "Itf14 Barcode"
                    fileName = "Itf14Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.Itf14Barcode(fileName)
                Case ConsoleKey.D1
                    exampleName = "MsiBarcode Barcode"
                    fileName = "MsiBarcodeBarcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.MsiBarcodeBarcode(fileName)
                Case ConsoleKey.D2
                    exampleName = "StackedGS1Databar Barcode"
                    fileName = "StackedGS1DatabarBarcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.StackedGS1DatabarBarcode(fileName)
                Case ConsoleKey.D3
                    exampleName = "UpcA Barcode"
                    fileName = "UpcABarcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.UpcABarcode(fileName)
                Case ConsoleKey.D4
                    exampleName = "UpcASupplement2 Barcode"
                    fileName = "UpcASupplement2Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.UpcASupplement2Barcode(fileName)
                Case ConsoleKey.D5
                    exampleName = "UpcASupplement5 Barcode"
                    fileName = "UpcASupplement5Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.UpcASupplement5Barcode(fileName)
                Case ConsoleKey.D6
                    exampleName = "UpcE Barcode"
                    fileName = "UpcEBarcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.UpcEBarcode(fileName)
                Case ConsoleKey.D7
                    exampleName = "UpcESupplement2 Barcode"
                    fileName = "UpcESupplement2Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.UpcESupplement2Barcode(fileName)
                Case ConsoleKey.D8
                    exampleName = "UpcESupplement5 Barcode"
                    fileName = "UpcESupplement5Barcode.png"
                    Console.WriteLine(exampleName + " example is running...")
                    LinearBarcode.UpcESupplement5Barcode(fileName)
                Case ConsoleKey.Escape
                    System.Environment.Exit(0)
                Case ConsoleKey.Backspace
                    exitToProducts = True
                Case Else
                    Console.WriteLine()
                    Console.WriteLine("Key not recognized.")
            End Select

            If (fileName IsNot String.Empty) Then
                DisplayOutputPathWithOptionToOpen(fileName)
            End If
        End While
    End Sub

    Private Sub DisplayPostalBarcodeExamples()

        Dim exitToProducts As Boolean = False
        While (exitToProducts = False)
            Console.WriteLine("Select a Postal Barcode example to run:")
            Console.WriteLine("     A : Australia Post")
            Console.WriteLine("     B : Deutsche Post Identcode")
            Console.WriteLine("     C : Deutsche Post Leitcode")
            Console.WriteLine("     D : Intelligent Mail Barcode")
            Console.WriteLine("     E : Kix Barcode")
            Console.WriteLine("     F : Postnet")
            Console.WriteLine("     G : Rm4scc Barcode")
            Console.WriteLine("     H : SingaporePost")
            Console.WriteLine()
            Console.WriteLine("Press 'Backspace' for the main products menu")
            Console.WriteLine("Press 'Esc' to exit application")
            Console.WriteLine()
            Dim runKey As ConsoleKeyInfo = Console.ReadKey()
            Console.WriteLine()
            Console.WriteLine()
            Dim exampleName As String = String.Empty
            Dim fileName As String = String.Empty

            Select Case runKey.Key
                Case ConsoleKey.A
                    exampleName = "AustraliaPost Barcode"
                    fileName = "AustraliaPostBarcode.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    PostalBarcode.AustraliaPostBarcode(fileName)
                Case ConsoleKey.B
                    exampleName = "DeutschePostIdent"
                    fileName = "DeutschePostIdent.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    PostalBarcode.DeutschePostIdent(fileName)
                Case ConsoleKey.C
                    exampleName = "DeutschePostLeit"
                    fileName = "DeutschePostLeit.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    PostalBarcode.DeutschePostLeit(fileName)
                Case ConsoleKey.D
                    exampleName = "IntelligentMail"
                    fileName = "IntelligentMail.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    PostalBarcode.IntelligentMail(fileName)
                Case ConsoleKey.E
                    exampleName = "Kix Barcode"
                    fileName = "KixBarcode.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    PostalBarcode.KixBarcode(fileName)
                Case ConsoleKey.F
                    exampleName = "Postnet Barcode"
                    fileName = "PostnetBarcode.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    PostalBarcode.PostnetBarcode(fileName)
                Case ConsoleKey.G
                    exampleName = "Rm4scc Barcode"
                    fileName = "Rm4sccBarcode.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    PostalBarcode.Rm4sccBarcode(fileName)
                Case ConsoleKey.H
                    exampleName = "SingaporePost Barcode"
                    fileName = "SingaporePostBarcode.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    PostalBarcode.SingaporePostBarcode(fileName)
                Case ConsoleKey.Escape
                    System.Environment.Exit(0)
                Case ConsoleKey.Backspace
                    exitToProducts = True
                Case Else
                    Console.WriteLine()
                    Console.WriteLine("Key not recognized.")
            End Select

            If (fileName IsNot String.Empty) Then
                DisplayOutputPathWithOptionToOpen(fileName)
            End If
        End While
    End Sub

    Private Sub DisplayTwoDimensionalBarcodeExamples()

        Dim exitToProducts As Boolean = False
        While (exitToProducts = False)
            Console.WriteLine("Select a Two Dimensional barcode example to run:")
            Console.WriteLine("     A : Aztec Barcode")
            Console.WriteLine("     B : Data Matrix Barcode")
            Console.WriteLine("     C : Macro Pdf417")
            Console.WriteLine("     D : Pdf417")
            Console.WriteLine("     E : QR Code")
            Console.WriteLine()
            Console.WriteLine("Press 'Backspace' for the main products menu")
            Console.WriteLine("Press 'Esc' to exit application")
            Console.WriteLine()
            Dim runKey As ConsoleKeyInfo = Console.ReadKey()
            Console.WriteLine()
            Console.WriteLine()
            Dim exampleName As String = String.Empty
            Dim fileName As String = String.Empty

            Select Case runKey.Key
                Case ConsoleKey.A
                    exampleName = "Aztec Barcode"
                    fileName = "AztecBarcode.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    TwoDimensionalBarcode.AztecBarcode(fileName)
                Case ConsoleKey.B
                    exampleName = "DataMatrix"
                    fileName = "DataMatrix.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    TwoDimensionalBarcode.DataMatrix(fileName)
                Case ConsoleKey.C
                    exampleName = "MacroPdf417 Barcode"
                    fileName = "MacroPdf417Barcode.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    TwoDimensionalBarcode.MacroPdf417Barcode(fileName)
                Case ConsoleKey.D
                    exampleName = "Pdf417 Barcode"
                    fileName = "Pdf417Barcode.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    TwoDimensionalBarcode.Pdf417Barcode(fileName)
                Case ConsoleKey.E
                    exampleName = "QRCode Barcode"
                    fileName = "QRCodeBarcode.png"
                    Console.WriteLine("Example " + exampleName + " is Running...")
                    TwoDimensionalBarcode.QRCodeBarcode(fileName)
                Case ConsoleKey.Escape
                    System.Environment.Exit(0)
                Case ConsoleKey.Backspace
                    exitToProducts = True
                Case Else
                    Console.WriteLine()
                    Console.WriteLine("Key not recognized.")
            End Select

            If (fileName IsNot String.Empty) Then
                DisplayOutputPathWithOptionToOpen(fileName)
            End If
        End While
    End Sub

    Private Sub DisplayOutputPathWithOptionToOpen(ByVal fileName As String)
        Dim fullFileName As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) + "\" + fileName
        Console.WriteLine()
        Console.WriteLine("The ouptut file was saved at:")
        Console.WriteLine(fullFileName)
        Console.WriteLine()
        Console.WriteLine("Press any key to continue.")
        Console.WriteLine()
        Dim key As ConsoleKeyInfo = Console.ReadKey()
        Console.WriteLine()
    End Sub

End Module
