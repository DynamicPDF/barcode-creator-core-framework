Imports ceTe.DynamicBarcode.Creator

Public Class LinearBarcode
    Public Shared Sub CodaBarBarcode(ByVal outputPath As String)
        Dim MyBarCode As Codabar = New Codabar("A1234A", 150)
        MyBarCode.BackColor = New ceTe.DynamicBarcode.Creator.Rgb24(0, 191, 255)
        MyBarCode.Draw(outputPath, 100, ImageFormat.Png)
    End Sub

    Public Shared Sub Code11Barcode(ByVal outputPath As String)
        Dim MyBarCode As Code11 = New Code11("12345678", 50)
        MyBarCode.BarcodeMargin = New Margin(2)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Code128Barcode(ByVal outputPath As String)
        Dim MyBarCode As Code128 = New Code128("Hello World", 100)
        MyBarCode.BarColor = New ceTe.DynamicBarcode.Creator.Rgba32(170, 80, 0, 3)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Code25Barcode(ByVal outputPath As String)
        Dim MyBarCode As Code25 = New Code25("123456789", 100)
        MyBarCode.ShowText = True
        MyBarCode.FontSize = 2
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Code39Barcode(ByVal outputPath As String)
        Dim MyBarCode As Code39 = New Code39("123456789", 100)
        MyBarCode.SymbolHeight = 12
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Code93Barcode(ByVal outputPath As String)
        Dim MyBarCode As Code93 = New Code93("1234567890", 50)
        MyBarCode.ShowText = True
        MyBarCode.TextAlign = Align.Right
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Ean13Barcode(ByVal outputPath As String)
        Dim MyBarCode As Ean13 = New Ean13("123456789012")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Ean13Supplement2Barcode(ByVal outputPath As String)
        Dim MyBarCode As Ean13Supplement2 = New Ean13Supplement2("123456789012", "12")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Ean13Supplement5Barcode(ByVal outputPath As String)
        Dim MyBarCode As Ean13Supplement5 = New Ean13Supplement5("123456789012", "12345")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Ean14Barcode(ByVal outputPath As String)
        Dim MyBarCode As Ean14 = New Ean14("1234567890123", 100)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Ean8Barcode(ByVal outputPath As String)
        Dim MyBarCode As Ean8 = New Ean8("12345670")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Ean8Supplement2Barcode(ByVal outputPath As String)
        Dim MyBarCode As Ean8Supplement2 = New Ean8Supplement2("12345670", "12")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Ean8Supplement5Barcode(ByVal outputPath As String)
        Dim MyBarCode As Ean8Supplement5 = New Ean8Supplement5("12345670", "12345")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub GS1DataBarBarcode(ByVal outputPath As String)
        Dim MyBarCode As GS1DataBar = New GS1DataBar("(01)9889876543210", 100, GS1DataBarType.Omnidirectional)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Iata25Barcode(ByVal outputPath As String)
        Dim MyBarCode As Iata25 = New Iata25("1234567890", 100)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Interleaved25Barcode(ByVal outputPath As String)
        Dim MyBarCode As Interleaved25 = New Interleaved25("1234567890", 100)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub IsbnBarcode(ByVal outputPath As String)
        Dim MyBarCode As Isbn = New Isbn("978-1-23-456789-7")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub IsbnSupplement2Barcode(ByVal outputPath As String)
        Dim MyBarCode As IsbnSupplement2 = New IsbnSupplement2("978-1-23-456789-7", "12")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub IsbnSupplement5Barcode(ByVal outputPath As String)
        Dim MyBarCode As IsbnSupplement5 = New IsbnSupplement5("978-1-23-456789-7", "12345")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub IsmnBarcode(ByVal outputPath As String)
        Dim MyBarCode As Ismn = New Ismn("979-0-1234-5678")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub IsmnSupplement2Barcode(ByVal outputPath As String)
        Dim MyBarCode As IsmnSupplement2 = New IsmnSupplement2("979-0-1234-5678", "12")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub IsmnSupplement5Barcode(ByVal outputPath As String)
        Dim MyBarCode As IsmnSupplement5 = New IsmnSupplement5("979-0-1234-5678", "12345")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub IssnBarcode(ByVal outputPath As String)
        Dim MyBarCode As Issn = New Issn("977-1234-56700")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub IssnSupplement2Barcode(ByVal outputPath As String)
        Dim MyBarCode As IssnSupplement2 = New IssnSupplement2("977-1234-56700", "12")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub IssnSupplement5Barcode(ByVal outputPath As String)
        Dim MyBarCode As IssnSupplement5 = New IssnSupplement5("977-1234-56700", "12345")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Itf14Barcode(ByVal outputPath As String)
        Dim MyBarCode As Itf14 = New Itf14("1234567890123", 100)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub MsiBarcodeBarcode(ByVal outputPath As String)
        Dim MyBarCode As MsiBarcode = New MsiBarcode("123456789", 100)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub StackedGS1DatabarBarcode(ByVal outputPath As String)
        Dim MyBarCode As StackedGS1DataBar = New StackedGS1DataBar("(01)9889876543210", 50, StackedGS1DataBarType.StackedOmnidirectional)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub UpcABarcode(ByVal outputPath As String)
        Dim MyBarCode As UpcA = New UpcA("12345678901")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub UpcASupplement5Barcode(ByVal outputPath As String)
        Dim MyBarCode As UpcASupplement5 = New UpcASupplement5("12345678901", "12345")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub UpcASupplement2Barcode(ByVal outputPath As String)
        Dim MyBarCode As UpcASupplement2 = New UpcASupplement2("12345678901", "12")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub UpcEBarcode(ByVal outputPath As String)
        Dim MyBarCode As UpcE = New UpcE("0123456")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub UpcESupplement5Barcode(ByVal outputPath As String)
        Dim MyBarCode As UpcESupplement5 = New UpcESupplement5("0123456", "12345")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub UpcESupplement2Barcode(ByVal outputPath As String)
        Dim MyBarCode As UpcESupplement2 = New UpcESupplement2("0123456", "12")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub
End Class
