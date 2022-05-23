Imports System.Drawing.Printing
Imports System.Drawing
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public NotInheritable Class ImprimeEtiqueta
    Private ListaEtiquetas As List(Of Etiqueta)
    Private bIsInventario As Boolean
    Const tipoLetra As String = "Tahoma"
    Private iLong As Integer
    Private blackBrush As SolidBrush = New SolidBrush(Color.Black)
    Private fontNorm06 As Font = New Font(tipoLetra, 6, FontStyle.Regular)
    Private fontBold08 As Font = New Font(tipoLetra, 8, FontStyle.Bold)
    Private fontBold10 As Font = New Font(tipoLetra, 10, FontStyle.Bold)
    Private fontBold12 As Font = New Font(tipoLetra, 12, FontStyle.Bold)
    Private fontBold15 As Font = New Font(tipoLetra, 15, FontStyle.Bold)
    Private fontNorm07 As Font = New Font(tipoLetra, 7, FontStyle.Regular)
    Private fontNorm08 As Font = New Font(tipoLetra, 8, FontStyle.Regular)
    Private fontNorm10 As Font = New Font(tipoLetra, 10, FontStyle.Regular)
    Private fontNormal As Font = New Font(tipoLetra, 12, FontStyle.Regular)
    Private iCol As Integer = 5
    Private iRen As Integer = 5
    Dim sOC As String = String.Empty
    Dim sCArticulo As String = String.Empty
    Dim sDArticulo As String = String.Empty
    Dim dCantidad As Decimal = 0
    Dim sUMedida As String = String.Empty
    Dim sCProveedor As String = String.Empty
    Dim sNProveedor As String = String.Empty
    Dim sEtiquetaReimpresion As String
    Dim sLabelEtiqueta As String = String.Empty
    Dim iEtiquetas As Integer = 0
    Dim numEtiquetaAImprimir = 0

    Private Sub imprimeLineaEnEtiqueta(ByVal e As PrintPageEventArgs, ByVal aRen As Integer, ByVal aLenRect As Integer)
        iRen += aRen
        e.Graphics.DrawLine(Pens.Black, iCol, iRen, aLenRect, iRen)
        iRen += 5
    End Sub

    Function TruncaCadena(ByVal cadena As String, ByVal longitud As Integer) As String
        If cadena.Length > longitud Then
            cadena = cadena.Substring(0, longitud)
        End If

        Return cadena
    End Function
    '
    Public Overloads Function ShowDialog(ByVal owner As Form,
                                         ByVal idOrden As String,
                                         ByVal lEtiquetas As List(Of Azteca.Business.Inventario.Etiqueta),
                                         ByVal bInventario As Boolean,
                                         ByVal numEtiqueta As Integer) As DialogResult
        ListaEtiquetas = lEtiquetas
        bIsInventario = bInventario
        numEtiquetaAImprimir = numEtiqueta
        Return MyBase.ShowDialog(owner)
    End Function


    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim cantImp As Integer = 0
        Dim iLenCad As Integer = 0

        sLabelEtiqueta = "Etiqueta " + numEtiquetaAImprimir.ToString() + " de " + ListaEtiquetas(0).Etiqueta.ToString()
        'sEtiquetaReimpresion = e.PageSettings.PrinterSettings.IIf(ListaEtiquetas.Item(0).Reimpresion = False, "Etiqueta " + CInt(cantImp).ToString() + " de " + iEtiquetas.ToString(), "").ToString()

        'For i = 0 To ListaEtiquetas.Count - 1
        sOC = ListaEtiquetas(0).OrdenCompra
        sCArticulo = ListaEtiquetas(0).CodigoArticulo
        sDArticulo = ListaEtiquetas(0).DescArticulo
        dCantidad = CDec(ListaEtiquetas(0).Cantidad)
        c1bcCodArticulo.Text = sCArticulo
        sUMedida = ListaEtiquetas(0).UnidMedida
        sCProveedor = ListaEtiquetas(0).CodigoProveedor
        sNProveedor = ListaEtiquetas(0).NombreProveedor
        c1bcCodProveedor.Text = sCProveedor
        iEtiquetas = CInt(ListaEtiquetas.Item(0).Etiqueta)
        iEtiquetas = CInt(IIf(iEtiquetas < 0, 0, iEtiquetas))
        'Imprimir Rectángulo de la Etiqueta
        Dim dTotalRec As Decimal = dCantidad / iEtiquetas
        Dim rect As Rectangle = New Rectangle(iCol, iRen, 216, 165)
        Dim rectPlectron As Rectangle = New Rectangle(iCol + 80, iRen, 136, 20)
        e.Graphics.DrawRectangle(Pens.Black, rect)
        ' Imprimir Rectángulo que encierra a PLECTON
        e.Graphics.DrawRectangle(Pens.Black, rectPlectron)
        e.Graphics.FillRectangle(blackBrush, rectPlectron)
        e.Graphics.DrawString("APROBADO", fontBold08, Brushes.Black, iCol + 8, iRen + 4)
        e.Graphics.DrawString("P L E C T O N", fontBold10, Brushes.White, iCol + 100, iRen + 2)
        imprimeLineaEnEtiqueta(e, 20, 221)
        e.Graphics.DrawString("Entrada: ", fontBold08, Brushes.Black, iCol + 2, iRen - 1)
        'e.Graphics.DrawString(sOC.Substring(sOC.Length - 6, 6), fontNorm08, Brushes.Black, iCol + 50, iRen - 1)
        e.Graphics.DrawString(sOC, fontNorm08, Brushes.Black, iCol + 50, iRen - 1)
        e.Graphics.DrawString("Fecha: ", fontBold08, Brushes.Black, iCol + 110, iRen)
        e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fontNorm08, Brushes.Black, iCol + 150, iRen - 1)
        imprimeLineaEnEtiqueta(e, 15, 221)
        e.Graphics.DrawString("Insumo: ", fontBold08, Brushes.Black, iCol + 2, iRen)
        If sCArticulo.Length > 9 Then
            sCArticulo = sCArticulo.Substring(0, 9)
        End If
        e.Graphics.DrawString(sCArticulo, fontNorm08, Brushes.Black, iCol + 50, iRen)
        e.Graphics.DrawString("Cantidad: ", fontBold08, Brushes.Black, iCol + 105, iRen)

        Dim sCantAux As String = Math.Round(Convert.ToDouble(ListaEtiquetas(0).Cantidad), 2).ToString() + " " + ListaEtiquetas(0).UnidMedida
        If sCantAux.Length > 9 Then
            sCantAux = sCantAux.Substring(0, 9)
        End If
        e.Graphics.DrawString(sCantAux, fontNorm08, Brushes.Black, iCol + 160, iRen)
        iRen += 15
        iLenCad = sDArticulo.Length
        iLong = Convert.ToInt32(IIf(iLenCad <= 40, ((220 - (iLenCad * 5.5)) / 2), 4))
        If iLenCad > 40 Then
            sDArticulo = sDArticulo.Substring(0, 40)
        End If
        e.Graphics.DrawString(sDArticulo, fontNorm08, Brushes.Black, iCol + iLong, iRen)
        iRen += 15
        If c1bcCodArticulo.Image IsNot Nothing Then
            e.Graphics.DrawImage(c1bcCodArticulo.Image, iCol + 10, iRen - 2, 85, 15)
        End If
        e.Graphics.DrawString("Lote: ", fontBold08, Brushes.Black, iCol + 100, iRen - 1)
        e.Graphics.DrawString("", fontNorm08, Brushes.Black, iCol + 130, iRen)
        imprimeLineaEnEtiqueta(e, 15, 221)
        e.Graphics.DrawString("", fontBold08, Brushes.Black, iCol + 55, iRen - 1)
        e.Graphics.DrawString(sLabelEtiqueta, fontNorm08, Brushes.Black, iCol + 65, iRen - 1)
        imprimeLineaEnEtiqueta(e, 15, 221)

        e.Graphics.DrawString("Proveedor:", fontBold08, Brushes.Black, iCol, iRen)
        e.Graphics.DrawString(sCProveedor, fontNorm08, Brushes.Black, iCol + 65, iRen + 1)
        iRen += 15
        iLenCad = sNProveedor.Length
        iLong = Convert.ToInt32(IIf(iLenCad <= 40, (220 - (iLenCad * 5.5)) / 2, 5))
        If iLenCad > 40 Then
            sNProveedor = sNProveedor.Substring(0, 40)
        End If
        e.Graphics.DrawString(sNProveedor, fontNorm07, Brushes.Black, iCol + iLong, iRen - 2)
        iRen += 15
        iLenCad = Convert.ToInt32(220 / sCProveedor.Length)
        iLong = CInt((220 - (sCProveedor.Length * (iLenCad / 2))) / 4)
        If c1bcCodProveedor.Image IsNot Nothing Then
            e.Graphics.DrawImage(c1bcCodProveedor.Image, iCol + iLong, iRen - 3, 150, 16)
        End If
        iRen += 30
        'If etiquetaImpresa < ListaEtiquetas.Count - 1 Then
        ' e.HasMorePages = True
        ' Else
        ' e.HasMorePages = False
        ' End If

        ' etiquetaImpresa += 1
        ' Next

    End Sub


    Private Sub ImprimeEtiqueta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim rutaActual As String = System.IO.Directory.GetCurrentDirectory + "\Printer.txt"
            Dim existPrinter As Boolean = False
            Dim pdDocument As PrintDocument = New PrintDocument()
            Dim defaultPrinter As String = "Brother QL-570"
            Dim qtyCopies As Integer = 1
            Dim settings As PrinterSettings = New PrinterSettings()
            Dim paperSz As PaperSize = New PaperSize("PCTN_VER", 62, 50)

            If File.Exists(rutaActual) Then
                For Each line As String In File.ReadLines(rutaActual)
                    If line.Length <> 0 Then
                        defaultPrinter = line.Trim()
                    End If
                Next
                pdDocument.DefaultPageSettings.PaperSize = paperSz
                pdDocument.PrinterSettings.DefaultPageSettings.PaperSize = paperSz
                pdDocument.PrinterSettings.Copies = Convert.ToInt16(qtyCopies)
                pdDocument.PrinterSettings.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)
                pdDocument.PrinterSettings.DefaultPageSettings.Landscape = True
                Dim strPrinter = String.Empty
                For Each strPrinter In PrinterSettings.InstalledPrinters
                    If strPrinter.Contains(defaultPrinter) Then
                        defaultPrinter = strPrinter
                        existPrinter = True
                        Exit For
                    End If
                Next

                If existPrinter Then
                    sOC = ListaEtiquetas(0).OrdenCompra
                    sCArticulo = ListaEtiquetas(0).CodigoArticulo
                    sDArticulo = ListaEtiquetas(0).DescArticulo
                    dCantidad = ListaEtiquetas(0).Cantidad
                    sUMedida = ListaEtiquetas(0).UnidMedida
                    sCProveedor = ListaEtiquetas(0).CodigoProveedor
                    sNProveedor = ListaEtiquetas(0).NombreProveedor

                    pdDocument.PrinterSettings.PrinterName = defaultPrinter
                    AddHandler pdDocument.PrintPage, AddressOf PrintDocument1_PrintPage
                    pdDocument.Print()
                End If
            Else
                MessageBox.Show("No existe el archivo Printer.txt en la ruta " + System.IO.Directory.GetCurrentDirectory + "\Printer.txt")
            End If

        Catch ex As Exception
        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class


'Dim impresoraDefault As String = String.Empty
'Dim bExisteTxtImpresora As Boolean = False
'Dim sPrinterFile As String = IO.Directory.GetCurrentDirectory + "\Printer.txt"
'            If File.Exists(sPrinterFile) Then
'                Using reader As StreamReader = New StreamReader(sPrinterFile)
'                    impresoraDefault = reader.ReadLine
'                    bExisteTxtImpresora = True
'                End Using
'            Else
'                MessageBox.Show("No se ha encontrado el archivo Printer.txt el cual debe contener el nombre de la impresora en la cual se imprimirán las Etiquetas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'            End If
'
'            If bExisteTxtImpresora Then
'Dim Parametros As System.Collections.Generic.List(Of ReportParameter)
'Dim frmEtiqueta As ReportForm
'Dim sEtiqueta As String = String.Empty
'
'                For i = 0 To ListaEtiquetas.Count - 1
'                    Parametros = New System.Collections.Generic.List(Of ReportParameter)
'                    Parametros.Add(New ReportParameter("OC", ListaEtiquetas(i).OrdenCompra.Substring(ListaEtiquetas(i).OrdenCompra.Length - 6, 6)))
'                    Parametros.Add(New ReportParameter("Articulo_Codigo", ListaEtiquetas(i).CodigoArticulo))
'                    Parametros.Add(New ReportParameter("Articulo_Descripcion", TruncaCadena(ListaEtiquetas(i).DescArticulo, 35)))
'                    Parametros.Add(New ReportParameter("Proveedor_Codigo", ListaEtiquetas(i).CodigoProveedor))
'                    Parametros.Add(New ReportParameter("Proveedor_Descripcion", TruncaCadena(ListaEtiquetas(i).NombreProveedor, 35)))
'                    Parametros.Add(New ReportParameter("Cantidad", ListaEtiquetas(i).Cantidad.ToString()))
'                    Parametros.Add(New ReportParameter("Unidad_Medida", TruncaCadena(ListaEtiquetas(i).UnidMedida, 7)))
'                    Parametros.Add(New ReportParameter("Fecha", DateTime.Now.ToShortDateString()))
'                    For j = 1 To ListaEtiquetas(i).Etiqueta
'                        frmEtiqueta = New ReportForm
''sEtiqueta = "Etiqueta " + j.ToString() + " de " + ListaEtiquetas(i).Etiqueta.ToString()
''Parametros.Add(New ReportParameter("pEtiquetaNumero", sEtiqueta))
'                        frmEtiqueta.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Inventario.EtiquetasRPT.rdlc"
'                        frmEtiqueta.LocalReport.SetParameters(Parametros)
'                        frmEtiqueta.PrintToPrinter(impresoraDefault)
'                    Next
'                Next
'            End If


'    Const tipoLetra As String = "Tahoma"
'Private ListaEtiquetas As List(Of Etiqueta)
'Private bIsInventario As Boolean
'    Private iLong As Integer
'    Private blackBrush As SolidBrush = New SolidBrush(Color.Black)
'    Private fontNorm06 As Font = New Font(tipoLetra, 6, FontStyle.Regular)
'    Private fontBold08 As Font = New Font(tipoLetra, 8, FontStyle.Bold)
'    Private fontBold10 As Font = New Font(tipoLetra, 10, FontStyle.Bold)
'    Private fontBold12 As Font = New Font(tipoLetra, 12, FontStyle.Bold)
'    Private fontBold15 As Font = New Font(tipoLetra, 15, FontStyle.Bold)
'    Private fontNorm07 As Font = New Font(tipoLetra, 7, FontStyle.Regular)
'    Private fontNorm08 As Font = New Font(tipoLetra, 8, FontStyle.Regular)
'    Private fontNorm10 As Font = New Font(tipoLetra, 10, FontStyle.Regular)
'    Private fontNormal As Font = New Font(tipoLetra, 12, FontStyle.Regular)
'    Private iCol As Integer = 5
'    Private iRen As Integer = 5
'    Dim sOC As String = String.Empty
'    Dim sCArticulo As String = String.Empty
'    Dim sDArticulo As String = String.Empty
'    Dim dCantidad As Decimal = 0
'    Dim sUMedida As String = String.Empty
'    Dim sCProveedor As String = String.Empty
'    Dim sNProveedor As String = String.Empty
'    Dim sEtiquetaReimpresion As String
'    Dim iEtiquetas As Integer = 0
'    Dim etiquetaImpresa = 0

'    Private Sub imprimeLineaEnEtiqueta(ByVal e As PrintPageEventArgs, ByVal aRen As Integer, ByVal aLenRect As Integer)
'        iRen += aRen
'        e.Graphics.DrawLine(Pens.Black, iCol, iRen, aLenRect, iRen)
'        iRen += 5
'    End Sub

'    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
' Dim cantImp As Integer = 0
' Dim iLenCad As Integer = 0
' ' sEtiquetaReimpresion = e.PageSettings.PrinterSettings.IIf(ListaEtiquetas.Item(0).Reimpresion = False, "Etiqueta " + CInt(cantImp).ToString() + " de " + iEtiquetas.ToString(), "").ToString()
'    ' For i = 0 To ListaEtiquetas.Count - 1
'    'sOC = ListaEtiquetas(i).OrdenCompra
'    'sCArticulo = ListaEtiquetas(i).CodigoArticulo
'    'sDArticulo = ListaEtiquetas(i).DescArticulo
'    'dCantidad = CDec(ListaEtiquetas(i).Cantidad)
'    'c1bcCodArticulo.Text = sCArticulo
'    'sUMedida = ListaEtiquetas(i).UnidMedida
'    'sCProveedor = ListaEtiquetas(i).CodigoProveedor
'    'sNProveedor = ListaEtiquetas(i).NombreProveedor
'    'c1bcCodProveedor.Text = sCProveedor
'
'    'iEtiquetas = CInt(ListaEtiquetas.Item(i).Etiqueta)
'    'iEtiquetas = CInt(IIf(iEtiquetas < 0, 0, iEtiquetas))
'    ' Imprimir Rectángulo de la Etiqueta
'
'    Dim dTotalRec As Decimal = dCantidad / iEtiquetas
'    Dim rect As Rectangle = New Rectangle(iCol, iRen, 216, 165)
'    Dim rectPlectron As Rectangle = New Rectangle(iCol + 70, iRen, 146, 20)
'        e.Graphics.DrawRectangle(Pens.Black, rect)
'    ' Imprimir Rectángulo que encierra a PLECTON
'        e.Graphics.DrawRectangle(Pens.Black, rectPlectron)
'        e.Graphics.FillRectangle(blackBrush, rectPlectron)
'        e.Graphics.DrawString("Entrada", fontBold08, Brushes.Black, iCol + 11, iRen + 4)
'        e.Graphics.DrawString("P L E C T O N", fontBold10, Brushes.White, iCol + 100, iRen + 2)
'        imprimeLineaEnEtiqueta(e, 20, 221)
'        e.Graphics.DrawString("Ingreso: ", fontBold08, Brushes.Black, iCol + 8, iRen - 1)
'        e.Graphics.DrawString(sOC.Substring(sOC.Length - 6, 6), fontNorm08, Brushes.Black, iCol + 55, iRen - 1)
'        e.Graphics.DrawString("Fecha: ", fontBold08, Brushes.Black, iCol + 110, iRen)
'        e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fontNorm08, Brushes.Black, iCol + 150, iRen - 1)
'        imprimeLineaEnEtiqueta(e, 15, 221)
'        e.Graphics.DrawString("Producto: ", fontBold08, Brushes.Black, iCol + 1, iRen)
'        e.Graphics.DrawString(sCArticulo, fontNorm08, Brushes.Black, iCol + 55, iRen)
'        e.Graphics.DrawString("Cantidad: ", fontBold08, Brushes.Black, iCol + 110, iRen)
'        e.Graphics.DrawString(dTotalRec.ToString(), fontNorm08, Brushes.Black, iCol + 165, iRen)
'        iRen += 15
'        iLenCad = sDArticulo.Length
'        iLong = Convert.ToInt32(IIf(iLenCad <= 40, ((220 - (iLenCad * 5.5)) / 2), 0))
'        If iLenCad > 40 Then
'            sDArticulo = sDArticulo.Substring(0, 40)
'        End If
'        e.Graphics.DrawString(sDArticulo, fontNorm08, Brushes.Black, iCol + iLong, iRen)
'        iRen += 15
'        If c1bcCodArticulo.Image IsNot Nothing Then
'            e.Graphics.DrawImage(c1bcCodArticulo.Image, iCol + 15, iRen - 2, 80, 15)
'        End If
'        e.Graphics.DrawString("U.Medida: ", fontBold08, Brushes.Black, iCol + 105, iRen)
'        e.Graphics.DrawString(sUMedida, fontNorm08, Brushes.Black, iCol + 165, iRen)
'        imprimeLineaEnEtiqueta(e, 15, 221)
'        e.Graphics.DrawString("", fontBold08, Brushes.Black, iCol + 55, iRen - 1)
'        e.Graphics.DrawString(sEtiquetaReimpresion, fontNorm08, Brushes.Black, iCol + 65, iRen - 1)
'        imprimeLineaEnEtiqueta(e, 15, 221)
'
'        e.Graphics.DrawString("Proveedor:", fontBold08, Brushes.Black, iCol, iRen)
'        e.Graphics.DrawString(sCProveedor, fontNorm08, Brushes.Black, iCol + 65, iRen + 1)
'        iRen += 15
'        iLenCad = sNProveedor.Length
'        iLong = Convert.ToInt32(IIf(iLenCad <= 40, (220 - (iLenCad * 5.5)) / 2, 0))
'        If iLenCad > 40 Then
'            sNProveedor = sNProveedor.Substring(0, 40)
'        End If
'        e.Graphics.DrawString(sNProveedor, fontNorm07, Brushes.Black, iCol + iLong, iRen)
'        iRen += 15
'        iLenCad = Convert.ToInt32(220 / sCProveedor.Length)
'        iLong = CInt((220 - (sCProveedor.Length * (iLenCad / 2))) / 4)
'        If c1bcCodProveedor.Image IsNot Nothing Then
'            e.Graphics.DrawImage(c1bcCodProveedor.Image, iCol + iLong, iRen, 150, 18)
'        End If
'        iRen += 30
'    '  If etiquetaImpresa < ListaEtiquetas.Count - 1 Then
'    ' e.HasMorePages = True
'    ' Else
'    ' e.HasMorePages = False
'    ' End If
'    ' etiquetaImpresa += 1
'    'Next
'
'    End Sub


