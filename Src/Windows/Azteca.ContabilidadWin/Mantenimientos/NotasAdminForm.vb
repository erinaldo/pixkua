Imports Azteca.Business.Contabilidad
Imports Azteca.Windows
Imports Microsoft.Reporting.WinForms

Public Class NotasAdminForm
    Dim frmDocument As Azteca.Windows.Contabilidad.NotasForm
    Private FormatoComprobante As String

    Private Sub NotasAdminForm_AddingDocument(sender As Object, e As Azteca.Windows.Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingDocument
        Try
            onAddingNota()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub NotasAdminForm_ApplyingWorkflow(sender As Object, e As Azteca.Windows.Forms.BusinessForms.ApplyingWorkflowEventArgs) Handles Me.ApplyingWorkflow
        grdNotas.UpdateData()
    End Sub

    Protected Overridable Sub onAddingNota()
        Dim frm As New Azteca.Windows.Contabilidad.NotasForm
        frm.StartPosition = FormStartPosition.CenterScreen

        If frm.ShowDialog("", "Nueva nota") = System.Windows.Forms.DialogResult.OK Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            LoadData()
        End If
    End Sub
    
    Private Sub NotasAdminForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            Try
                frmDocument = New Azteca.Windows.Contabilidad.NotasForm
                frmDocument.LoadLists() : frmDocument.StartPosition = FormStartPosition.CenterParent
                'Cargar formato de factura asignado a la sucursal
                Dim FormatMgr As New Azteca.Kernel.General.FormatManager
                FormatoComprobante = FormatMgr.LoadFormat(App.Session.SessionID, Context.Sucursal.IdFormatoNotasCredito)
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub NotasAdminForm_LoadingData(sender As Object, e As Azteca.Windows.Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Try
            Dim NotasFac As New Azteca.Business.Contabilidad.NotaFacade
            bsNotas.DataSource = NotasFac.LoadList(App.Session.SessionID, Me.FechaIni, Me.FechaFin, App.Session.User.Identity, App.DefaultSite.Identity)
            grdNotas.Rebind(True)
            Me.DocumentBindingSource = bsNotas
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub NotasAdminForm_PrintingDocument(sender As Object, e As Azteca.Windows.Forms.BusinessForms.PrintDocumentEventArgs) Handles Me.PrintingDocument
        grdNotas.UpdateData()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim row As DataRowView = CType(bsNotas.Current, DataRowView)
            Dim NotaFac As New NotaFacade
            Dim Nota As NotaInfo = NotaFac.GetDetail(App.Session.SessionID, CStr(row("ID")))

            Dim ComprobanteFac As New ComprobanteFiscalFacade
            'Cargar información de la factura
            Dim dtComprobante As InformesDS.ComprobantesFiscalesDataTable = ComprobanteFac.LoadPrintInfo(App.Session.SessionID, Nota.IdCFDSerie, Nota.Folio, Nota.UUID)
            'Mostrar vista previa de la factura
            Dim frmComprobante As New ReportForm
            Dim Reader As New System.IO.StringReader(FormatoComprobante)
            frmComprobante.LocalReport.LoadReportDefinition(Reader)
            frmComprobante.LocalReport.DataSources.Add(New ReportDataSource("Comprobantes", CType(dtComprobante, DataTable)))

            Dim Comprobante As ComprobanteFiscalInfo = ComprobanteFac.Load(App.Session.SessionID, Nota.IdCFDSerie, Nota.Folio, Nota.UUID)
            Dim Imagenes As New Azteca.Business.Contabilidad.InformesDS.ImagenesDataTable
            Dim dr As Azteca.Business.Contabilidad.InformesDS.ImagenesRow = Imagenes.NewImagenesRow
            dr.Logo = App.DefaultCompany.Logo
            dr.QrCode = Comprobante.QrCode
            Imagenes.AddImagenesRow(dr)
            frmComprobante.LocalReport.DataSources.Add(New ReportDataSource("Imagenes", CType(Imagenes, DataTable)))
            frmComprobante.Show("CFD " & Nota.Folio.ToString)

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdNotas_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdNotas.ButtonClick
        If bsNotas.Current IsNot Nothing Then
            Try
                Dim frm As New NotasForm
                frm.StartPosition = FormStartPosition.CenterScreen

                If frm.ShowDialog(grdNotas.Columns("Nota").Text, "Editar la Nota") = System.Windows.Forms.DialogResult.OK Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    LoadData()
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub btnUnloadXML_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
        If bsNotas.Current IsNot Nothing Then
            Dim drFactura As DataRowView = CType(bsNotas.Current, DataRowView)
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
        If bsNotas.Current IsNot Nothing Then
            Dim drFactura As DataRowView = CType(bsNotas.Current, DataRowView)
            If CInt(drFactura("IdCliente")) > 0 Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    OnSendMail(CStr(drFactura("CorreoElectronico")), CDate(drFactura("Fecha")).Date, CInt(drFactura("IdCFDSerie")), CInt(drFactura("Factura")), drFactura("UUID").ToString, CInt(drFactura("IdRemitente")))
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

    Protected Overridable Sub OnSendMail(CorreoElectronico As String, fechaFactura As Date, idSerie As Integer, folio As Integer, uuid As String, IdRemitente As Integer)
        Dim frmMail As New DestinatarioMailForm
        If frmMail.ShowDialog(CorreoElectronico, "", "Envio de Comprobante Fiscal desde " & App.DefaultCompany.RazonSocial) = System.Windows.Forms.DialogResult.OK Then
            Dim NotaFac As New NotaFacade
            NotaFac.EnviarComprobante(App.Session.SessionID, frmMail.txtPara.Text.Trim, fechaFactura, idSerie, folio, uuid, App.DefaultSite.Identity, frmMail.txtMensaje.Text, IdRemitente)
            MessageBox.Show("El comprobante ha sido enviado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub NotasAdminForm_SelectedStatusChanged(sender As Object, e As System.EventArgs) Handles Me.SelectedStatusChanged
        If SelectedStatus > 0 Then
            grdNotas.Splits(0).DisplayColumns("Sel").Visible = True
        Else
            grdNotas.Splits(0).DisplayColumns("Sel").Visible = False
        End If

        cmdUnloadXML.Enabled = SelectedStatus = WorkflowSteps.Invoice
        cmdEnviarXML.Enabled = SelectedStatus = WorkflowSteps.Invoice

    End Sub


End Class