Public Class FacturarVentaForm

    Private Sub selVenta_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles selVenta.InfoLoaded
        Dim Venta As VentaInfo = CType(selVenta.DocumentPackage, VentaInfo)

        selCliente.LoadInfo(Venta.IdCliente)
        lblTotCantidadTXT.Text = Format(Venta.TotalCantidad, "#.##")
        lblTotSubtotalTXT.Text = Format(Venta.SubTotal, "#.##")
        lblTotImpuestoTXT.Text = Format(Venta.TotalImpuestosTrasladados, "0.##")
        lblTotDescuentosTXT.Text = Format(Venta.TotalDescuentos, "0.##")
        lblTotTotalTXT.Text = Format(Venta.Total, "#.##")

    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim Venta As VentaInfo = CType(selVenta.DocumentPackage, VentaInfo)
            Venta.IdCliente = selCliente.Key
            Dim VtaFac As New VentaFacade
            Venta = VtaFac.FacturacionPOS(App.Session.SessionID, Venta)
            ImprimirFactura(Venta)
            MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ImprimirFactura(Venta As VentaInfo)
        Try
            Dim VentaFac As New VentaFacade

            'Cargar información de la factura
            Dim dtFactura As InformesDS.FacturasDataTable = VentaFac.LoadFacturaPrintInfo(App.Session.SessionID, Venta.IdSerie, Venta.FolioFactura, Venta.UUIDFactura)
            'Mostrar vista previa de la factura
            Dim frmFactura As New ReportForm
            Dim Reader As New System.IO.StringReader(Context.FormatoFactura)
            frmFactura.LocalReport.LoadReportDefinition(Reader)
            frmFactura.LocalReport.DataSources.Add(New ReportDataSource("Facturas", CType(dtFactura, DataTable)))
            '
            Dim Imagenes As New Azteca.Business.Contabilidad.InformesDS.ImagenesDataTable
            Dim dr As Azteca.Business.Contabilidad.InformesDS.ImagenesRow = Imagenes.NewImagenesRow
            dr.Logo = App.DefaultCompany.Logo
            dr.QrCode = Nothing
            Imagenes.AddImagenesRow(dr)
            '
            frmFactura.LocalReport.DataSources.Add(New ReportDataSource("Imagenes", CType(Imagenes, DataTable)))
            frmFactura.Show("Factura " & Venta.SerieFactura & "-" & Venta.FolioFactura.ToString)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class