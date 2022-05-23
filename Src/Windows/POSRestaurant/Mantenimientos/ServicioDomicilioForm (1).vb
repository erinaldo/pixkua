Public Class ServicioDomicilioForm
    Private RepartidoresTable As DataTable

    Private Sub btnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim frm As New PedidoDomicilioForm
        If frm.ShowDialog("") = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Try

            If IsNothing(bsComandas.Current) Then Exit Sub
            Dim dr As DataRowView = CType(bsComandas.Current, DataRowView)
            Dim IdComandaTit As String = dr("IdComandaTit").ToString

            Dim frm As New PedidoDomicilioForm
            If frm.ShowDialog(IdComandaTit) = System.Windows.Forms.DialogResult.OK Then

            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub btnRegresar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub grdComandas_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdComandas.AfterColUpdate
        Try
            If IsNothing(bsComandas.Current) Then Exit Sub
            Dim dr As DataRowView = CType(bsComandas.Current, DataRowView)
            Dim IdComandaTit As String = dr("IdComandaTit").ToString

            If e.Column.Name = "Repartidor" Then
                Dim ComandaFac As New ComandaFacade
                ComandaFac.EstablecerRepartidor(App.Session.SessionID, IdComandaTit, grdComandas.Columns("Repartidor").Value)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdComandas_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdComandas.FetchCellStyle

    End Sub

    Private Sub btnRefrescar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefrescar.Click
        Try
            Dim comandaFac As New ComandaFacade
            Dim dtComandas As DataTable = comandaFac.ServicioDomicilioList(App.Session.SessionID, dtpFechaINI.Value, dtpFechaFIN.Value)
            bsComandas.DataSource = dtComandas
            grdComandas.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


    Private Sub ServicioDomicilioForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim RepartidoresFac As New RepartidorFacade
        Try
            RepartidoresTable = RepartidoresFac.LoadList(App.Session.SessionID, App.DefaultSite.Identity)
            bsRepartidores.DataSource = RepartidoresTable
            dropRepartidor.DataSource = bsRepartidores
            dropRepartidor.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
            Close()
        End Try

    End Sub

    Private Sub btnCobrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCobrar.Click
        ''Try
        Dim dtRepartidores As DataTable = fillRepartidoresTable()
        Dim frm As New CobranzaVentaDomicilioForm
        frm.LoadData(dtRepartidores, CType(bsComandas.DataSource, DataTable))
        If frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

        End If
        ''Catch ex As Exception
        ''MsgInfo.Show(ex)
        ''End Try
    End Sub

    Private Function fillRepartidoresTable() As DataTable
        Dim IdRepartidorAnt As Integer = 0
        Dim repartidoresTB As New DataTable("Repartidores")

        Dim IdRepartidorColumn As New DataColumn("IdRepartidor")
        IdRepartidorColumn.DataType = System.Type.GetType("System.Int32")
        repartidoresTB.Columns.Add(IdRepartidorColumn)

        Dim RepartidorColumn As New DataColumn("Repartidor")
        RepartidorColumn.DataType = System.Type.GetType("System.String")
        repartidoresTB.Columns.Add(RepartidorColumn)


        Dim dv As New DataView(CType(bsComandas.DataSource, DataTable), "IdRepartidor>0 AND IdStatus=1", "IdRepartidor", DataViewRowState.CurrentRows)

        For Each dr As DataRowView In dv
            If dr("IdRepartidor") <> IdRepartidorAnt Then
                Dim dvRepartidores As New DataView(CType(bsRepartidores.DataSource, DataTable), "IdRepartidor=" & dr("IdRepartidor"), "", DataViewRowState.CurrentRows)
                Dim drNew As DataRow = repartidoresTB.NewRow
                drNew("IdRepartidor") = dr("IdRepartidor")
                drNew("Repartidor") = dvRepartidores(0)("Nombre Corto")
                repartidoresTB.Rows.Add(drNew)
            End If
            IdRepartidorAnt = dr("IdRepartidor")
        Next

        Return repartidoresTB

    End Function

End Class