Imports Azteca.Business.Contabilidad

Public Class AdminVentasForm
    Dim frmDocument As VentasForm
    Private FormatoFactura As String

    Private Sub AdminVentasForm_AddingDocument(sender As Object, e As Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingDocument
        Try
            OnAddingVenta()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub AdminVentasForm_ApplyingWorkflow(sender As Object, e As Forms.BusinessForms.ApplyingWorkflowEventArgs) Handles Me.ApplyingWorkflow
        grdVentas.UpdateData()
    End Sub

    Private Sub AdminVentasForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            Try
                frmDocument = New VentasForm
                frmDocument.LoadLists() : frmDocument.StartPosition = FormStartPosition.CenterParent
                'Cargar formato de factura asignado a la sucursal
                Dim FormatMgr As New Azteca.Kernel.General.FormatManager
                FormatoFactura = FormatMgr.LoadFormat(App.Session.SessionID, Context.UnidadNegocio.IdFormatoFacturas)
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


    Private Sub AdminVentasForm_LoadingData(sender As Object, e As Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Try
            Dim VentasFac As New VentaFacade
            bsVentas.DataSource = VentasFac.LoadList(App.Session.SessionID, Me.FechaIni, Me.FechaFin, App.Session.User.Identity, App.DefaultSite.Identity)
            grdVentas.Rebind(True)
            Me.DocumentBindingSource = bsVentas
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


    Private Sub AdminVentasForm_PrintingDocument(sender As Object, e As Forms.BusinessForms.PrintDocumentEventArgs) Handles Me.PrintingDocument
        grdVentas.UpdateData()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim row As DataRowView = CType(bsVentas.Current, DataRowView)
            ' Cargar información de impresión de los Presupuestos
            Dim VentaFac As New VentaFacade
            Dim IdSerie As Integer = CInt(row("IdCFDSerie"))
            Dim Folio As Integer = CInt(row("Factura"))
            Dim UUID As String = row("UUID").ToString

            If CInt(row("IdStatus")) = WorkflowSteps.Invoice Or (CInt(row("IdStatus")) = WorkflowSteps.Cancel And Folio > 0) Then
                'Cargar información del certificado
                Dim SerieFac As New SerieFacade
                Dim Serie As SerieInfo = SerieFac.GetDetail(App.Session.SessionID, IdSerie, False)
                Dim CertificadoFac As New CertificadoFacade
                Dim Certifiado As CertificadoInfo = CertificadoFac.GetDetail(App.Session.SessionID, Serie.IdCertificado, False)

                'Cargar información de la factura
                Dim dtFactura As Azteca.Business.Ventas.InformesDS.FacturasDataTable = VentaFac.LoadFacturaPrintInfo(App.Session.SessionID, IdSerie, Folio, UUID)
                'Mostrar vista previa de la factura
                Dim frmFactura As New ReportForm
                Dim Reader As New System.IO.StringReader(FormatoFactura)
                frmFactura.LocalReport.LoadReportDefinition(Reader)
                frmFactura.LocalReport.DataSources.Add(New ReportDataSource("Facturas", CType(dtFactura, DataTable)))
                Dim ComprobanteFac As New ComprobanteFiscalFacade
                Dim Comprobante As ComprobanteFiscalInfo = ComprobanteFac.Load(App.Session.SessionID, IdSerie, Folio, UUID)
                Dim Imagenes As New Azteca.Business.Contabilidad.InformesDS.ImagenesDataTable
                Dim dr As Azteca.Business.Contabilidad.InformesDS.ImagenesRow = Imagenes.NewImagenesRow
                dr.Logo = App.DefaultCompany.Logo
                dr.QrCode = Comprobante.QrCode
                Imagenes.AddImagenesRow(dr)
                frmFactura.LocalReport.DataSources.Add(New ReportDataSource("Imagenes", CType(Imagenes, DataTable)))
                frmFactura.Show("Factura " & Serie.Serie & "-" & Folio.ToString)
            Else
                'Cargar información de impresión de la venta
                Dim dtVenta As DataTable = VentaFac.LoadPrintInfo(App.Session.SessionID, CStr(row("Id")))
                'Definir parametros del informe
                Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
                Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
                'Mostrar vista previa de la venta
                Dim frmVenta As New ReportForm
                frmVenta.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Ventas.Orden_PLEC.rdlc"
                frmVenta.LocalReport.DataSources.Add(New ReportDataSource("Venta", CType(dtVenta, DataTable)))
                frmVenta.LocalReport.SetParameters(Parametros)
                frmVenta.Show("Orden de Venta " & CStr(row("Id")))
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub AdminVentasForm_SelectedStatusChanged(sender As Object, e As System.EventArgs) Handles Me.SelectedStatusChanged
        If SelectedStatus > 0 Then
            grdVentas.Splits(0).DisplayColumns("Sel").Visible = True
        Else
            grdVentas.Splits(0).DisplayColumns("Sel").Visible = False
        End If
    End Sub

    Private Sub grdVentas_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdVentas.ButtonClick
        If bsVentas.Current IsNot Nothing Then
            Try
                onEditarVenta(grdVentas.Columns("Venta").Text)
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub btnUnloadXML_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
        If bsVentas.Current IsNot Nothing Then
            Dim drFactura As DataRowView = CType(bsVentas.Current, DataRowView)
            dlgSaveXML.FileName = CStr(drFactura("Serie")).Trim & CStr(drFactura("Factura")).Trim & ".xml"
            If dlgSaveXML.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    Dim Comprobante As New Azteca.Business.Contabilidad.ComprobanteFiscalFacade
                    Dim Factura As String = Comprobante.LoadXML(App.Session.SessionID, CInt(drFactura("IdCFDSerie")), CInt(drFactura("Factura")), drFactura("UUID").ToString)
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

    Private Sub btnEnviarXML_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
        If bsVentas.Current IsNot Nothing Then
            Dim drFactura As DataRowView = CType(bsVentas.Current, DataRowView)
            If CInt(drFactura("IdCliente")) > 0 Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    OnSendMail(CInt(drFactura("IdCliente")), CDate(drFactura("FechaFactura")).Date, CInt(drFactura("IdCFDSerie")), CInt(drFactura("Factura")), drFactura("UUID").ToString)
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

    Private Sub grdVentas_RowColChange(sender As Object, e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdVentas.RowColChange
        If bsVentas.Current IsNot Nothing Then
            Dim drFactura As DataRowView = CType(bsVentas.Current, DataRowView)
            cmdEnviarXML.Enabled = CInt(drFactura("IdStatus")) = WorkflowSteps.Invoice
            cmdUnloadXML.Enabled = CInt(drFactura("IdStatus")) = WorkflowSteps.Invoice
        End If
    End Sub

    Protected Overridable Sub OnEditarVenta(IdVentaTit As String)
        Dim frmVenta As New VentasForm
        frmVenta.StartPosition = FormStartPosition.CenterScreen

        If frmVenta.ShowDialog(IdVentaTit, "Editar la Venta") = System.Windows.Forms.DialogResult.OK Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            LoadData()
        End If
    End Sub

    Protected Overridable Sub OnAddingVenta()
        Dim frmVenta As New VentasForm
        frmVenta.StartPosition = FormStartPosition.CenterScreen

        If frmVenta.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            LoadData()
        End If
    End Sub

    Protected Overridable Sub OnSendMail(idCliente As Integer, fechaFactura As Date, idSerie As Integer, folio As Integer, uuid As String)
        'Cargar información del cliente de la factura
        Dim ClienteFac As New ClienteFacade
        Dim Cliente As ClienteInfo = ClienteFac.GetDetail(App.Session.SessionID, idCliente)
        Dim frmMail As New DestinatarioMailForm

        If frmMail.ShowDialog(Cliente.Correo, "", "Envio de Comprobante Fiscal desde " & App.DefaultCompany.RazonSocial) = System.Windows.Forms.DialogResult.OK Then
            Dim VentaFac As New VentaFacade
            VentaFac.EnviarFactura(App.Session.SessionID, frmMail.txtPara.Text.Trim, fechaFactura, idSerie, folio, uuid, App.DefaultSite.Identity, frmMail.txtMensaje.Text)
            MessageBox.Show("El comprobante ha sido enviado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class