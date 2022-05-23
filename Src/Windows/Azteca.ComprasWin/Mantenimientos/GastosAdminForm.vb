Imports Microsoft.Reporting.WinForms

Public Class GastosAdminForm
    Dim frmDocument As GastosForm

    Private Sub GastosAdminForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Try
                frmDocument = New GastosForm
                frmDocument.LoadLists() : frmDocument.StartPosition = FormStartPosition.CenterParent
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub GastosAdminForm_LoadingData(ByVal sender As Object, ByVal e As Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        cargaInfo()
    End Sub

    Private Sub GastosAdminForm_NewDocument(ByVal sender As Object, ByVal e As Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingDocument
        Try
            Dim frmCaptura As New CapturaGastosForm
            If frmCaptura.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                cargaInfo()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cargaInfo()
        Try
            Dim GastosFac As New GastoFacade
            bsGastos.DataSource = GastosFac.LoadList(App.Session.SessionID, Me.FechaIni, Me.FechaFin, App.Session.User.Identity, App.DefaultSite.Identity)
            grdGastos.Rebind(True)
            Me.DocumentBindingSource = bsGastos
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdGastos_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdGastos.ButtonClick
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dr As DataRowView = CType(bsGastos.Current, DataRowView)
            Dim frm As New GastosForm
            frm.LoadLists() : frm.StartPosition = FormStartPosition.CenterParent
            frm.ShowDialog(CStr(dr("Id")), "Editando Gasto")
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub ContrarecibosAdminForm_PrintingDocument(sender As Object, e As Forms.BusinessForms.PrintDocumentEventArgs) Handles Me.PrintingDocument
        grdGastos.UpdateData()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim row As DataRowView = CType(bsGastos.Current, DataRowView)
            ' Cargar información de impresión de los Presupuestos
            Dim GastoFac As New GastoFacade
            Dim dtSource As DataTable = GastoFac.LoadPrintInfo(App.Session.SessionID, CStr(row("Id")))
            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))

            'Mostrar vista previa de los presupuestos
            Dim frmVenta As New ReportForm
            frmVenta.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Compras.Gasto.rdlc"
            frmVenta.LocalReport.DataSources.Add(New ReportDataSource("GastoInfo", CType(dtSource, DataTable)))
            frmVenta.LocalReport.SetParameters(Parametros)
            frmVenta.Show("Gasto")
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class