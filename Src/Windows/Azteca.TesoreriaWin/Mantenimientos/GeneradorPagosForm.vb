Public Class GeneradorPagosForm
    Private _IdCaja As Integer
    Private ContrarecibosSelTable As PagosDS.ContrarecibosPorPagarDataTable
    Private PagosTable As PagosDS.PagosDataTable


    Public Overloads Function ShowDialog(owner As Form, idCaja As Integer) As DialogResult
        Me._IdCaja = idCaja
        Dim CajaFac As New CajaFacade
        bsChequeras.DataSource = CajaFac.ChequerasList(App.Session.SessionID, _IdCaja)
        dropChequera.Rebind(True)
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub btnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim PagoFac As New PagoFacade
            If optVencidos.Checked Then
                bsPendientes.DataSource = PagoFac.PendientesVencidosList(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value, _IdCaja)
            Else
                bsPendientes.DataSource = PagoFac.PendientesEmitidosList(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value, _IdCaja)
            End If
            grdCheques.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub loadingList()
        Try
            Dim PagoTipoFac As New PagoTipoFacade
            bsPagosTipo.DataSource = PagoTipoFac.LoadList(App.Session.SessionID)
            dropPagoTipo.Rebind(True)
            Dim DateHoy As New Date(Date.Today.Year, Date.Today.Month, Date.Today.Day)
            dtpFechaIni.Value = DateHoy.AddDays(-8)
            dtpFechaFin.Value = DateHoy
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        Try
            Generar()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub Generar()
        ContrarecibosSelTable = New PagosDS.ContrarecibosPorPagarDataTable
        PagosTable = New PagosDS.PagosDataTable
        For Each dr As PagosDS.ContrarecibosPorPagarRow In CType(bsPendientes.DataSource, PagosDS.ContrarecibosPorPagarDataTable)
            If dr.Sel = True Then ContrarecibosSelTable.ImportRow(dr)
        Next

        Dim IdCont As Integer = 0
        Try
            Dim Titulos = From P In ContrarecibosSelTable
                Group By IdChequera = P.IdChequera, IdBeneficiario = P.IdBeneficiario, IdPagoTipo = P.IdPagoTipo, Beneficiario = P.Beneficiario, Banco = P.Banco, CLABE = P.CLABE, Vencimiento = P.Vencimiento
                Into Total = Sum(P.Monto), Contrarecibos = Group

            For Each pagoHeader In Titulos
                IdCont = IdCont + 1
                'Generamos lo encabezados de los pagos
                Dim drHead As PagosDS.PagosRow = PagosTable.NewPagosRow
                PagosTable.AddPagosRow(pagoHeader.IdChequera, pagoHeader.IdBeneficiario, pagoHeader.IdPagoTipo, pagoHeader.Beneficiario, pagoHeader.Banco, pagoHeader.Vencimiento, pagoHeader.CLABE, pagoHeader.Total, IdCont)
                For Each detail In pagoHeader.Contrarecibos
                    Dim dv As New DataView(ContrarecibosSelTable, "IdContrareciboTit='" & detail.IdContrareciboTit & "'", "", DataViewRowState.CurrentRows)
                    dv(0)("IdAgrupador") = IdCont
                Next
            Next
            'Mostramos la pantalla de confirmacion para que el cliente valide lo que se va a generar
            Dim frm As New PagosConfirmacionForm
            If frm.ShowDialog(Me, PagosTable, ContrarecibosSelTable, bsChequeras, bsPagosTipo) = System.Windows.Forms.DialogResult.OK Then
                Dim PagosFac As New PagoFacade
                PagosFac.Generar(App.Session.SessionID, _IdCaja, App.DefaultSite.Identity, PagosTable, ContrarecibosSelTable)
                'Quitamos todos los pagos realizados en la tabla de pendientes para no tener q refrescar toda la consulta
                QuitarPagos()
                MessageBox.Show("Se han generado los Pagos solicitados", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub QuitarPagos()
        For Each dr As PagosDS.ContrarecibosPorPagarRow In CType(bsPendientes.DataSource, PagosDS.ContrarecibosPorPagarDataTable)
            If dr.Sel = True Then dr.Delete()
        Next
        CType(bsPendientes.DataSource, PagosDS.ContrarecibosPorPagarDataTable).AcceptChanges()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub GeneradorPagosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class