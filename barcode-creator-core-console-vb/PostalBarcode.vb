Imports System.IO
Imports ceTe.DynamicBarcode.Creator

Public Class PostalBarcode
    Public Shared Sub AustraliaPostBarcode(ByVal outputPath As String)
        Dim MyBarCode As AustraliaPost = New AustraliaPost("1139549554")
        MyBarCode.BackColor = New ceTe.DynamicBarcode.Creator.Rgb24(0, 191, 255)
        Dim MyBarCodeData As Byte() = MyBarCode.Draw(300, ImageFormat.Png)
        File.WriteAllBytes(outputPath, MyBarCodeData)
    End Sub

    Public Shared Sub DeutschePostIdent(ByVal outputPath As String)
        Dim MyBarCode As DeutschePostIdentcode = New DeutschePostIdentcode("12345678901", 100)
        MyBarCode.BarcodeMargin = New Margin(2)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub DeutschePostLeit(ByVal outputPath As String)
        Dim MyBarCode As DeutschePostLeitcode = New DeutschePostLeitcode("1234567890123", 100)
        MyBarCode.BarColor = New ceTe.DynamicBarcode.Creator.Rgba32(170, 80, 0, 3)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub IntelligentMail(ByVal outputPath As String)
        Dim MyBarCode As IntelligentMailBarcode = New IntelligentMailBarcode("0123456709498765432101234567891")
        MyBarCode.ShowText = True
        MyBarCode.FontSize = 2
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub KixBarcode(ByVal outputPath As String)
        Dim MyBarCode As Kix = New Kix("1231FZ13XHS")
        MyBarCode.SymbolHeight = 12
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub PostnetBarcode(ByVal outputPath As String)
        Dim MyBarCode As Postnet = New Postnet("20815470412")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Rm4sccBarcode(ByVal outputPath As String)
        Dim MyBarCode As Rm4scc = New Rm4scc("20815470412")
        MyBarCode.ShowText = True
        MyBarCode.TextAlign = Align.Right
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub SingaporePostBarcode(ByVal outputPath As String)
        Dim MyBarCode As SingaporePost = New SingaporePost("208154")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub
End Class
