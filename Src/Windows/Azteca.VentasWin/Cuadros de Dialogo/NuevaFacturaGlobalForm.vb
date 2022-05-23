Imports Azteca.Business.Contabilidad

Public Class NuevaFacturaGlobalForm
    Private VentaFac As VentaFacade
    Private FormatoFactura As String

    Private Sub NuevaFacturaGlobalForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        VentaFac = New VentaFacade
        dtpFecha.Value = Date.Today
        Try
            'Cargar formato de factura asignado a la sucursal
            Dim FormatMgr As New Azteca.Kernel.General.FormatManager
            FormatoFactura = FormatMgr.LoadFormat(App.Session.SessionID, Context.UnidadNegocio.IdFormatoFacturas)
            'Cargar la lista de cajas
            cboCaja.LoadList()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdGenerar.Click
        If cboCaja.SelectedIndex >= 0 Then
            Try
                Cursor.Current = Cursors.WaitCursor
                Dim Comprobante As ComprobanteFiscalInfo = VentaFac.GenerarFacturaGlobal(App.Session.SessionID, App.DefaultSite.Identity, CInt(cboCaja.SelectedValue), dtpFecha.Value)

                'Cargar información de la factura
                Dim dtFactura As Azteca.Business.Ventas.InformesDS.FacturasDataTable = VentaFac.LoadFacturaPrintInfo(App.Session.SessionID, Comprobante.IdSerie, Comprobante.Folio, Comprobante.UUID)
                'Mostrar vista previa de la factura
                Dim frmFactura As New ReportForm
                Dim Reader As New System.IO.StringReader(FormatoFactura)
                frmFactura.LocalReport.LoadReportDefinition(Reader)
                frmFactura.LocalReport.DataSources.Add(New ReportDataSource("Facturas", CType(dtFactura, DataTable)))
                Dim Imagenes As New Azteca.Business.Contabilidad.InformesDS.ImagenesDataTable
                Dim dr As Azteca.Business.Contabilidad.InformesDS.ImagenesRow = Imagenes.NewImagenesRow
                dr.Logo = App.DefaultCompany.Logo
                dr.QrCode = Comprobante.QrCode
                Imagenes.AddImagenesRow(dr)
                frmFactura.LocalReport.DataSources.Add(New ReportDataSource("Imagenes", CType(Imagenes, DataTable)))
                frmFactura.Show("Factura " & Comprobante.Serie & "-" & Comprobante.Folio.ToString)

                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Debe elegir una caja.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdCargar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCargar.Click
        If cboCaja.SelectedIndex >= 0 Then

            Try
                If Not VentaFac.FacturaGlobalExists(App.Session.SessionID, App.DefaultSite.Identity, CInt(cboCaja.SelectedValue), dtpFecha.Value) Then
                    Cursor.Current = Cursors.WaitCursor
                    Dim dtVentas As DataTable = VentaFac.CargarVentasFacturaGlobal(App.Session.SessionID, App.DefaultSite.Identity, CInt(cboCaja.SelectedValue), dtpFecha.Value)
                    bsVentas.DataSource = dtVentas
                    grdVentas.Rebind(True)
                    'Mostrar totales en footer
                    Dim Totales = Aggregate V In dtVentas
                    Into SubTotal = Sum(CDec(V!SubTotal)), Descuento = Sum(CDec(V!TotalDescuento)), Traslados = Sum(CDec(V!TotalTraslados)), Retenciones = Sum(CDec(V!TotalRetenciones)), Total = Sum(CDec(V!Total))

                    grdVentas.Columns("Sub Total").FooterText = Totales.SubTotal.ToString("C")
                    grdVentas.Columns("Imp. Trasladados").FooterText = Totales.Traslados.ToString("C")
                    grdVentas.Columns("Imp. Retenidos").FooterText = Totales.Retenciones.ToString("C")
                    grdVentas.Columns("Total").FooterText = Totales.Total.ToString("C")

                    cmdGenerar.Enabled = True
                Else
                    MessageBox.Show("Ya existe una factura global para la fecha seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Debe elegir una caja.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As System.EventArgs) Handles dtpFecha.ValueChanged
        cmdGenerar.Enabled = False
        bsVentas.DataSource = Nothing
    End Sub

    Private Sub cboCaja_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCaja.SelectedIndexChanged
        cmdGenerar.Enabled = False
        bsVentas.DataSource = Nothing
    End Sub

End Class