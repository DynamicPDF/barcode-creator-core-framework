Imports System.IO
Imports ceTe.DynamicBarcode.Creator

Public Class TwoDimensionalBarcode
    Public Shared Sub AztecBarcode(ByVal outputPath As String)
        Dim MyBarCode As Aztec = New Aztec("Hello World", AztecSymbolSize.Full)
        Dim MyBarCodeData As Byte() = MyBarCode.Draw(96, 96, ImageFormat.Png)
        File.WriteAllBytes(outputPath, MyBarCodeData)
    End Sub

    Public Shared Sub DataMatrix(ByVal outputPath As String)
        Dim MyBarCode As DataMatrixBarcode = New DataMatrixBarcode("Hello World")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub MacroPdf417Barcode(ByVal outputPath As String)
        Dim MyBarCode As MacroPdf417 = New MacroPdf417("Hello World", 3)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub Pdf417Barcode(ByVal outputPath As String)
        Dim MyBarCode As Pdf417 = New Pdf417("Hello World", 3)
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub

    Public Shared Sub QRCodeBarcode(ByVal outputPath As String)
        Dim MyBarCode As QRCode = New QRCode("Hello World")
        MyBarCode.Draw(outputPath, 300, ImageFormat.Png)
    End Sub
End Class
