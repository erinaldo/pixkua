Imports Microsoft.Reporting.WinForms


Public Class AdminFacturasForm
    Private VentaFac As VentaFacade
    Private ComprobanteFiscalFac As Azteca.Business.Contabilidad.ComprobanteFiscalFacade
    Private dtList As InformesDS.FacturasListDataTable
    Private FormatoFactura As String

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            dtList = VentaFac.LoadFacturasList(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value, App.DefaultCompany.Identity, CInt(cboSucursal.SelectedValue), txtCliente.Key)
            bsFacturas.DataSource = dtList
            grdFacturas.Rebind(True)
            btnVerFactura.Enabled = True
            btnCancelarFactura.Enabled = True
            btnImprimirLista.Enabled = True
            btnGetXML.Enabled = True
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub ImpresionFacturasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VentaFac = New VentaFacade
        ComprobanteFiscalFac = New Azteca.Business.Contabilidad.ComprobanteFiscalFacade
        dtpFechaIni.Value = Date.Today.AddDays(-30)
        dtpFechaFin.Value = Date.Today
        cboSucursal.LoadList(App.DefaultCompany.Identity, App.Session.User.Identity)
        cboSucursal.SelectedValue = App.DefaultSite.Identity
        'Cargar formato de factura asignado a la sucursal
        Dim FormatMgr As New Azteca.Kernel.General.FormatManager
        FormatoFactura = FormatMgr.LoadFormatFromCache(App.Session.SessionID, Context.UnidadNegocio.IdFormatoFacturas)
    End Sub

    Private Sub btnCancelarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarFactura.Click
        If bsFacturas.Current IsNot Nothing Then
            Dim drFactura As InformesDS.FacturasListRow = CType(CType(bsFacturas.Current, DataRowView).Row, InformesDS.FacturasListRow)
            If Not drFactura.IsFechaCancelacionNull Then
                MessageBox.Show("La factura seleccioada ya está cancelada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim Resp As DialogResult = MessageBox.Show("La factura que intenta cancelar podría estar ligada a un documento de venta." _
                                                         & "Es recomendable que cancele el documento de venta para que éste cancele la factura y evitar incongruencias" & ControlChars.NewLine _
                                                         & "¿Esta seguro que desea cancelar la factura de todas formas?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                If Resp = System.Windows.Forms.DialogResult.Yes Then
                    Try
                        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                        ComprobanteFiscalFac.Cancelar(App.Session.SessionID, drFactura.IdCFDSerie, drFactura.Folio, drFactura.UUID)
                        drFactura.Estatus = "Cancelada"
                        drFactura.FechaCancelacion = Date.Now
                        MessageBox.Show("La factura ha sido cancelada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MsgInfo.Show(ex)
                    Finally
                        System.Windows.Forms.Cursor.Current = Cursors.Default
                    End Try
                End If
            End If
        Else
            MessageBox.Show("No hay una factura seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnVerFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerFactura.Click
        If bsFacturas.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Dim drFactura As InformesDS.FacturasListRow = CType(CType(bsFacturas.Current, DataRowView).Row, InformesDS.FacturasListRow)
                'Cargar información de la factura
                Dim dtFactura As InformesDS.FacturasDataTable = VentaFac.LoadFacturaPrintInfo(App.Session.SessionID, drFactura.IdCFDSerie, drFactura.Folio, drFactura.UUID)
                'Cargar información del certificado
                Dim SerieFac As New Azteca.Business.Contabilidad.SerieFacade
                Dim Serie As Azteca.Business.Contabilidad.SerieInfo = SerieFac.GetDetail(App.Session.SessionID, drFactura.IdCFDSerie, False)
                Dim CertificadoFac As New Azteca.Business.Contabilidad.CertificadoFacade
                Dim Certifiado As Azteca.Business.Contabilidad.CertificadoInfo = CertificadoFac.GetDetail(App.Session.SessionID, Serie.IdCertificado, False)
                'Mostrar vista previa de la factura
                Dim frmFactura As New ReportForm
                Dim Reader As New System.IO.StringReader(FormatoFactura)
                frmFactura.LocalReport.LoadReportDefinition(Reader)
                frmFactura.LocalReport.DataSources.Add(New ReportDataSource("Facturas", CType(dtFactura, DataTable)))
                Dim ComprobanteFac As New Azteca.Business.Contabilidad.ComprobanteFiscalFacade
                Dim Comprobante As Azteca.Business.Contabilidad.ComprobanteFiscalInfo = ComprobanteFac.Load(App.Session.SessionID, drFactura.IdCFDSerie, drFactura.Folio, drFactura.UUID)
                Dim Imagenes As New Azteca.Business.Contabilidad.InformesDS.ImagenesDataTable
                Dim dr As Azteca.Business.Contabilidad.InformesDS.ImagenesRow = Imagenes.NewImagenesRow
                dr.Logo = App.DefaultCompany.Logo
                dr.QrCode = Comprobante.QrCode
                Imagenes.AddImagenesRow(dr)
                frmFactura.LocalReport.DataSources.Add(New ReportDataSource("Imagenes", CType(Imagenes, DataTable)))
                frmFactura.Show("Factura " & drFactura.Serie.Trim & "-" & drFactura.Folio.ToString)
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("No hay una factura seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnImprimirLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirLista.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            'Generar parametros
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            Parametros.Add(New ReportParameter("Sucursal", cboSucursal.Text))
            Parametros.Add(New ReportParameter("FechaIni", dtpFechaIni.Value.ToString("dd/MM/yyyy")))
            Parametros.Add(New ReportParameter("FechaFin", dtpFechaFin.Value.ToString("dd/MM/yyyy")))
            'Configurar reporte
            Dim frmFacturas As New ReportForm
            frmFacturas.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Ventas.FacturasList.rdlc"
            frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("Facturas", CType(dtList, DataTable)))
            frmFacturas.LocalReport.SetParameters(Parametros)
            frmFacturas.Show("Reporte de Facturación")
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnGetXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetXML.Click
        If bsFacturas.Current IsNot Nothing Then
            Dim drFactura As InformesDS.FacturasListRow = CType(CType(bsFacturas.Current, DataRowView).Row, InformesDS.FacturasListRow)
            dlgSaveXML.FileName = drFactura.Serie.Trim & drFactura.Folio & ".xml"
            If dlgSaveXML.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    Dim Comprobante As New Azteca.Business.Contabilidad.ComprobanteFiscalFacade
                    Dim Factura As String = Comprobante.LoadXML(App.Session.SessionID, drFactura.IdCFDSerie, drFactura.Folio, drFactura.UUID)
                    Dim xmlFactura As New System.Xml.XmlDocument()
                    xmlFactura.LoadXml(Factura)
                    'Guardar archivo xml
                    xmlFactura.Save(dlgSaveXML.FileName)
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                End Try
            End If
        End If
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        If bsFacturas.Current IsNot Nothing Then
            Dim drFactura As InformesDS.FacturasListRow = CType(CType(bsFacturas.Current, DataRowView).Row, InformesDS.FacturasListRow)
            If drFactura.IdCliente > 0 Then
                Try
                    'Cargar información del cliente de la factura
                    Dim ClienteFac As New ClienteFacade
                    Dim Cliente As ClienteInfo = ClienteFac.GetDetail(App.Session.SessionID, drFactura.IdCliente)
                    If Cliente.Correo.Trim <> String.Empty Then
                        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                        VentaFac.EnviarFactura(App.Session.SessionID, Cliente.Correo.Trim, drFactura.FechaComprobante, drFactura.IdCFDSerie, drFactura.Folio, drFactura.UUID, App.DefaultSite.Identity)
                        MessageBox.Show("El comprobante ha sido enviado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("El cliente del comprobante no tiene asignado un correo electrónico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                End Try
            Else
                MessageBox.Show("La factura no tiene un cliente registrado en el sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub grdFacturas_FetchRowStyle(sender As Object, e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles grdFacturas.FetchRowStyle
        If grdFacturas.Columns("Fecha Cancelación").CellValue(e.Row) IsNot DBNull.Value Then
            e.CellStyle.BackColor = Drawing.Color.Moccasin
        End If
    End Sub
End Class