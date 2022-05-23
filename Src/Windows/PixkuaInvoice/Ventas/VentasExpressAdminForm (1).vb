Imports Azteca.Business.Ventas
Imports Azteca.Business.Contabilidad
Imports Azteca.Kernel.Security
Imports Chilkat

Public Class VentasExpressAdminForm
    Protected Overrides Sub OnAddingVenta()
        Dim frmVenta As New VentaExpresstForm
        frmVenta.StartPosition = FormStartPosition.CenterScreen
        frmVenta.Icon = Me.Icon
        If frmVenta.ShowDialog("", "Agregar Nueva Factura") = System.Windows.Forms.DialogResult.OK Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            LoadData()
        End If
    End Sub

    Protected Overrides Sub OnEditarVenta(IdVentaTit As String)
        Dim frmVenta As New VentaExpresstForm
        frmVenta.StartPosition = FormStartPosition.CenterScreen
        frmVenta.Icon = Me.Icon
        If frmVenta.ShowDialog(IdVentaTit, "Editar los datos de la factura") = System.Windows.Forms.DialogResult.OK Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            LoadData()
        End If
    End Sub

    Protected Overrides Sub OnSendMail(idCliente As Integer, fechaFactura As Date, idSerie As Integer, folio As Integer, uuid As String)
        'Cargar información del cliente de la factura
        Dim ClienteFac As New ClienteFacade
        Dim Cliente As ClienteInfo = ClienteFac.GetDetail(Azteca.Windows.App.Session.SessionID, idCliente)
        Dim frmMail As New Azteca.Windows.Ventas.DestinatarioMailForm

        If frmMail.ShowDialog(Cliente.Correo, "", "Envio de Comprobante Fiscal desde " & Azteca.Windows.App.DefaultCompany.RazonSocial) = System.Windows.Forms.DialogResult.OK Then
            Dim VentaFac As New VentaFacade

            Dim ComprobanteFac As New ComprobanteFiscalFacade
            Dim Comprobante As ComprobanteFiscalInfo = ComprobanteFac.Load(Azteca.Windows.App.Session.SessionID, idSerie, folio, uuid)
            'Obtener información de la unidad de negocios
            Dim UnidadNegocioFac As New UnidadNegocioFacade
            Dim UnidadNegocio As UnidadNegocioInfo = UnidadNegocioFac.GetDetailFromCacheByIdSucursal(Azteca.Windows.App.Session.SessionID, Comprobante.IdSucursal)
            Dim RemitenteFac As New Azteca.Kernel.Mail.RemitenteFacade
            'Cargar información del remitente
            Dim Remitente As Azteca.Kernel.Mail.RemitenteInfo = RemitenteFac.GetDetail(Azteca.Windows.App.Session.SessionID, UnidadNegocio.IdRemitente)

            'Crear mensaje de email y adjuntar xml y pdf
            Dim Email As New Chilkat.Email
            Dim Success As Boolean = Email.AddTo(String.Empty, frmMail.MailTo.Trim)
            If Not Success Then Throw New Azteca.Kernel.BusinessStructure.BusinessException("Error al establecer el destinatario de correo. " & Email.LastErrorText)
            Email.Subject = "Factura Electrónica " & Comprobante.Serie.Trim & Comprobante.Folio.ToString
            Email.Body = frmMail.MailBody
            'Obtener xml y pdf del comprobante fiscal
            Dim xml As String = ComprobanteFac.LoadXML(Azteca.Windows.App.Session.SessionID, Comprobante.IdSerie, Comprobante.Folio, Comprobante.UUID)
            Dim pdf As Byte() = GenerarFacturaPDF(UnidadNegocio, Comprobante)
            Email.AddStringAttachment(Comprobante.Serie.Trim & Comprobante.Folio.ToString & ".xml", xml)
            Email.AddDataAttachment2(Comprobante.Serie.Trim & Comprobante.Folio.ToString & ".pdf", pdf, "PDF")
            SendMail(Remitente, Email)
            MessageBox.Show("El comprobante ha sido enviado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function GenerarFacturaPDF(ByVal unidadNegocio As UnidadNegocioInfo, comprobante As ComprobanteFiscalInfo) As Byte()
        Try
            'Cargar información de la empresa
            Dim EmpresaFac As New EmpresaFacade
            Dim Empresa As EmpresaInfo = EmpresaFac.GetDetailFromCache(Azteca.Windows.App.Session.SessionID, unidadNegocio.IdEmpresa)
            'Cargar información de la factura
            Dim VentaFac As New VentaFacade
            Dim dtFactura As Azteca.Business.Ventas.InformesDS.FacturasDataTable = VentaFac.LoadFacturaPrintInfo(Azteca.Windows.App.Session.SessionID, comprobante.IdSerie, comprobante.Folio, comprobante.UUID)
            'Cargar información del logo y el QR            
            Dim Imagenes As New Azteca.Business.Contabilidad.InformesDS.ImagenesDataTable
            Dim dr As Azteca.Business.Contabilidad.InformesDS.ImagenesRow = Imagenes.NewImagenesRow
            dr.Logo = Empresa.Logo
            dr.QrCode = comprobante.QrCode
            Imagenes.AddImagenesRow(dr)
            'Cargar formato de factura asignado a la sucursal
            Dim Report As New LocalReport()
            Dim FormatMgr As New Azteca.Kernel.General.FormatManager
            Dim FormatoFactura As String = FormatMgr.LoadFormatFromCache(Azteca.Windows.App.Session.SessionID, unidadNegocio.IdFormatoFacturas)
            Dim Reader As New System.IO.StringReader(FormatoFactura)
            Report.LoadReportDefinition(Reader)
            '
            Report.DataSources.Add(New ReportDataSource("Imagenes", CType(Imagenes, DataTable)))
            Report.DataSources.Add(New ReportDataSource("Facturas", CType(dtFactura, DataTable)))
            '
            Dim mimeType As String = String.Empty
            Dim encoding As String = String.Empty
            Dim fileNameExtension As String = String.Empty

            Dim deviceInfo As String = _
              "<DeviceInfo>" + _
              "  <OutputFormat>PDF</OutputFormat>" & _
              "  <PageWidth>8.5in</PageWidth>" & _
              "  <PageHeight>11in</PageHeight>" & _
              "  <MarginTop>0.5in</MarginTop>" & _
              "  <MarginLeft>>0.5in</MarginLeft>" & _
              "  <MarginRight>>0.5in</MarginRight>" & _
              "  <MarginBottom>>0.5in</MarginBottom>" & _
              "</DeviceInfo>"
            '
            Dim warnings() As Warning = Nothing
            Dim streams() As String = Nothing
            Dim renderedBytes() As Byte = Report.Render("PDF", deviceInfo, mimeType, encoding, fileNameExtension, streams, warnings)
            Return renderedBytes
        Catch ex As Exception
            Throw New Azteca.Kernel.BusinessStructure.BusinessException("Error al descargar la factura en formato PDF desde el servidor de informes.", ex)
        End Try
    End Function


    Private Sub SendMail(ByVal remitente As Azteca.Kernel.Mail.RemitenteInfo, ByVal mail As Chilkat.Email)
        Try
            'Agregar información al mail
            mail.From = remitente.MailAddress
            'Configurar servidor smtp
            Dim Success As Boolean = True
            Dim MailMan As New MailMan
            With MailMan
                .UnlockComponent("RICARDMAILQ_sZpMFxBm5JpB")
                .SmtpAuthMethod = remitente.SMTPServer.AutheticationMethod
                .SmtpHost = remitente.SMTPServer.HostName
                If remitente.OverrideSMTPAuthentication Then
                    .SmtpUsername = remitente.UserName
                    .SmtpPassword = remitente.Password
                Else
                    .SmtpUsername = remitente.SMTPServer.UserName
                    .SmtpPassword = remitente.SMTPServer.Password
                End If
                .SmtpPort = remitente.SMTPServer.Port
                .SmtpSsl = remitente.SMTPServer.SSL
                Success = .SendEmail(mail)
                If Not Success Then Throw New Exception("Error al enviar el mail: " & .LastErrorText)
                .CloseSmtpConnection()
            End With
        Catch ex As Exception
            Throw New Exception("Error al enviar el correo electrónico.", ex)
        End Try
    End Sub


End Class