Imports Azteca.Business.Contabilidad
Imports Azteca.Windows

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

        If frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
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
                FormatoComprobante = FormatMgr.LoadFormat(App.Session.SessionID, Context.UnidadNegocio.IdFormatoFacturas)
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
            frmComprobante.LocalReport.DataSources.Add(New ReportDataSource("Facturas", CType(dtComprobante, DataTable)))

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

End Class