Imports Microsoft.Reporting.WinForms

Public Class ContrarecibosAdminForm

    Private Sub ContrarecibosAdminForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboCaja.LoadList(App.Session.User.Identity)
        CommandHolder.Commands("cmdNuevo").Visible = False

    End Sub

    Private Sub ContrarecibosAdminForm_LoadingData(sender As Object, e As Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Consultar()
    End Sub

    Private Sub Consultar()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim ContraFac As New ContrareciboFacade
            bsContrarecibos.DataSource = ContraFac.LoadList(App.Session.SessionID, Me.FechaIni, Me.FechaFin, CInt(cboCaja.SelectedValue))
            grdRequisiciones.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ContrarecibosAdminForm_PrintingDocument(sender As Object, e As Forms.BusinessForms.PrintDocumentEventArgs) Handles Me.PrintingDocument
        grdRequisiciones.UpdateData()
        Dim Ids As String = String.Empty
        Dim dv As New DataView(CType(bsContrarecibos.DataSource, DataTable), "Sel=1", "", DataViewRowState.CurrentRows)
        If dv.Count = 0 Then
            MessageBox.Show("Debe marcar los elementos que desea imprimir", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            For Each dr As DataRowView In dv
                Ids = Ids & CStr(dr("ID")) & ","
            Next
            Ids = Ids.Substring(0, Ids.Length - 1)
        End If

        Me.Cursor = Cursors.WaitCursor
        Try
            PrintContrarecibos(Ids)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub PrintContrarecibos(Ids As String)
        Try
            ' Cargar información de impresión de los Presupuestos
            Dim ContraFac As New ContrareciboFacade
            Dim dtSource As DataTable = ContraFac.LoadPrintInfo(App.Session.SessionID, Me.FechaIni, Me.FechaFin, Ids)
            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))

            'Mostrar vista previa de los presupuestos
            Dim frmVenta As New ReportForm
            frmVenta.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Tesoreria.Contrarecibo.rdlc"
            frmVenta.LocalReport.DataSources.Add(New ReportDataSource("Contrarecibos", CType(dtSource, DataTable)))
            frmVenta.LocalReport.SetParameters(Parametros)
            frmVenta.Show("Contrarecibos")
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class