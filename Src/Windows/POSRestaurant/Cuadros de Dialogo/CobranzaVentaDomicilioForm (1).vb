Public Class CobranzaVentaDomicilioForm
    Private _ComandasDataTable As DataTable
    Private _ComandasDataTableCopy As DataTable

    Private Sub cboRepartidores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRepartidores.SelectedIndexChanged
        If IsNothing(_ComandasDataTable) Then Exit Sub
        _ComandasDataTable.Rows.Clear()

        Dim dv As New DataView(_ComandasDataTableCopy, "IdRepartidor=" & CInt(cboRepartidores.SelectedValue), "IdComandaTit", DataViewRowState.CurrentRows)
        For Each dr As DataRowView In dv
            ''Incluimos cada comanda de este repartidor 
            Dim drNew As DataRow = _ComandasDataTable.NewRow
            drNew("IdComandaTit") = dr("IdComandaTit") : drNew("HoraInicio") = dr("HoraInicio") : drNew("Cliente") = dr("Cliente") : drNew("Total") = dr("Total")
            drNew("IdRepartidor") = dr("IdRepartidor") : drNew("FormaPago") = 1 : drNew("Status") = dr("Status") : drNew("Observaciones") = dr("Observaciones")
            _ComandasDataTable.Rows.Add(drNew)
        Next
    End Sub

    Public Sub LoadData(ByVal dtRepartidores As DataTable, ByVal dtComandas As DataTable)

        _ComandasDataTableCopy = dtComandas
        _ComandasDataTable = _ComandasDataTableCopy.Clone

        ''Incluir la columna de check de seleccion
        'Dim selColumn As New DataColumn("sel")
        'selColumn.DataType = System.Type.GetType("System.Boolean")
        'selColumn.DefaultValue = True
        '_ComandasDataTable.Columns.Add(selColumn)
        'Incluir la columna de forma de pago
        Dim IdFormaPagoColumn As New DataColumn("FormaPago")
        IdFormaPagoColumn.DataType = System.Type.GetType("System.String")
        IdFormaPagoColumn.DefaultValue = True
        _ComandasDataTable.Columns.Add(IdFormaPagoColumn)

        ''Cargamos las formas de pago
        'Dim FormasPagoFac As New Business.Ventas.FormaPagoFacade
        'Dim formasPagoTable As DataTable = FormasPagoFac.LoadList(App.Session.SessionID)
        'bsFormaPago.DataSource = formasPagoTable
        'dropFormaPago.DataSource = bsFormaPago
        'dropFormaPago.Rebind(True)

        bsComanda.DataSource = _ComandasDataTable
        grdComandas.Rebind(True)

        'Llenamos el combo de Repartidores
        cboRepartidores.DisplayMember = "Repartidor" : cboRepartidores.ValueMember = "IdRepartidor"
        cboRepartidores.DataSource = dtRepartidores

    End Sub
    
    Private Sub btnRegresar_ClickButtonArea(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRegresar.ClickButtonArea
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub grdComandas_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdComandas.ButtonClick
        Try
            If e.Column.Name = "Cobrar" Then
                Dim ComandaFac As New ComandaFacade
                Dim Comanda As ComandaInfo = ComandaFac.GetDetail(App.Session.SessionID, grdComandas.Columns("Comanda").Value)
                Dim frmCobro As New CobranzaForm
                Dim Venta As VentaInfo = ComandaFac.ToVentaInfo(App.Session.SessionID, Comanda, Comanda.IdCliente, Context.UnidadNegocio.PoliticaDescuento)
                Venta.IdCaja = Context.SessionTerminal.IdCaja
                If frmCobro.ShowDialog(1, Venta.Total) = DialogResult.OK Then
                    'Aqui se va a pagar
                    Comanda = ComandaFac.Pagar(App.Session.SessionID, Comanda, Venta, frmCobro.FormaPagoTable)

                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class