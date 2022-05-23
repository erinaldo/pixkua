Partial Class ComandaFacade

    Public Sub EstablecerRepartidor(ByVal sessionID As Guid, ByVal idComandaTit As String, ByVal idRepartidor As Integer)
        Try
            Connection = DataServices.OpenConnection
            Dim Comandascv As New ComandaService(sessionID, Me.Connection, Me.Transaction)
            Comandascv.EstablecerRepartidor(idComandaTit, idRepartidor)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Sub MarcarPedimentoImpreso(ByVal sessionID As Guid, ByVal idComandaTit As String, ByVal IdCentrosProdImpresos As String)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Comandascv As New ComandaService(sessionID, Me.Connection, Me.Transaction)
                Comandascv.MarcarPedimentoImpreso(idComandaTit, IdCentrosProdImpresos)
                DataServices.CommitTransaction(Transaction)
            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function Pagar(ByVal sessionID As Guid, ByVal Comanda As ComandaInfo, ByVal Venta As VentaInfo, ByVal FormasPago As DetalleVentaDS.FormasPagoDataTable) As ComandaInfo
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)

                Dim Comandascv As New ComandaService(sessionID, Me.Connection, Me.Transaction)
                If Comanda.Identity = "" Then Comanda = Comandascv.Update(Comanda)
                If Comanda.IdMesa <> 0 Then Comandascv.LiberarMesa(Comanda.IdMesa)

                Venta.IdReferencia = Comanda.Identity
                Dim VentaSvc As New VentaService(sessionID, Me.Connection, Me.Transaction)
                VentaSvc.Update(Venta)
                VentaSvc.Aplicar(Venta.Identity, Venta.Fecha, FormasPago)

                DataServices.CommitTransaction(Transaction)

            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Comanda
    End Function

    Public Function TicketPrint(ByVal sessionID As Guid, ByVal IdComanda As String) As InformesDS.ComandaTicketDataTable
        ValidateSession(sessionID)
        Dim dtList As New InformesDS.ComandaTicketDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComandaService(sessionID, Connection, Transaction)
            dtList = Svc.TicketPrint(IdComanda)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function TicketPedimentoPrint(ByVal sessionID As Guid, ByVal IdComandaTit As String) As InformesDS.ComandaTicketPedimentoDataTable
        ValidateSession(sessionID)
        Dim dtList As New InformesDS.ComandaTicketPedimentoDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComandaService(sessionID, Connection, Transaction)
            dtList = Svc.TicketPedimentoPrint(IdComandaTit)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function MesasCuentasLST(ByVal sessionID As Guid, ByVal IdCaja As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComandaService(sessionID, Connection, Transaction)
            dtList = Svc.MesasCuentasLST(IdCaja)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function ToVentaInfo(ByVal sessionID As Guid, ByVal idComandaTit As String, ByVal idCliente As Integer, PoliticaDescuento As PoliticaDescuento) As VentaInfo
        ValidateSession(sessionID)
        Dim Venta As New VentaInfo(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Comanda As New ComandaInfo(sessionID)
            Dim Svc As New ComandaService(sessionID, Connection, Transaction)
            Svc.GetDetail(idComandaTit, Comanda)
            Venta = ToVenta(sessionID, Comanda, idCliente, PoliticaDescuento)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Venta
    End Function

    Public Function ToVentaInfo(ByVal sessionID As Guid, ByVal Comanda As ComandaInfo, ByVal idCliente As Integer, PoliticaDescuento As PoliticaDescuento) As VentaInfo
        ValidateSession(sessionID)
        Dim Venta As New VentaInfo(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Venta = ToVenta(sessionID, Comanda, idCliente, PoliticaDescuento)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Venta
    End Function

    Private Function ToVenta(ByVal sessionID As Guid, ByVal Comanda As ComandaInfo, ByVal IdCliente As Integer, PoliticaDescuento As PoliticaDescuento) As VentaInfo
        Dim Venta As New Azteca.Business.Ventas.VentaInfo(sessionID)
        With Venta

            .IdCliente = IdCliente
            .Hora = Date.Today
            .IdReferencia = Comanda.Identity
            .IdSucursal = Comanda.IdSucursal : .Observaciones = "POS Restaurante"
            .Origen = Azteca.Business.Ventas.OrigenVenta.POS
            .IdDivisa = Comanda.IdDivisa
            .IdCaja = Comanda.IdCaja
            For Each drComanda As ComandaDS.ComandaDetRow In Comanda.Details
                Dim drArticulo As Azteca.Business.Ventas.DetalleVentaDS.ArticulosRow
                drArticulo = .Articulos.FindByIdArticuloStock(drComanda.IdArticulo)
                If IsNothing(drArticulo) Then
                    drArticulo = .Articulos.NewArticulosRow : drArticulo.IdDivisa = Comanda.IdDivisa
                    drArticulo.IdArticuloStock = drComanda.IdArticuloStock : drArticulo.Cantidad = drComanda.Cantidad : drArticulo.Descripcion = drComanda.Articulo
                    drArticulo.PrecioUnitario = drComanda.PrecioUnitario : drArticulo.IdImpuesto1 = drComanda.IdImpuesto1 : drArticulo.IdImpuesto2 = drComanda.IdImpuesto2 : drArticulo.IdImpuesto3 = drComanda.IdImpuesto3
                    drArticulo.PorcImpTras1 = drComanda.PorImpto1 : drArticulo.PorcImpTras2 = drComanda.PorImpto2 : drArticulo.PorcImpTras3 = drComanda.PorImpto3
                    .Articulos.AddArticulosRow(drArticulo)
                Else
                    drArticulo.Cantidad = drArticulo.Cantidad + drComanda.Entregado
                End If
            Next

            Venta.CalcularTotales(PoliticaDescuento)
        End With

        Return Venta
    End Function

    Public Function ServicioDomicilioList(ByVal sessionID As Guid, ByVal FechaIni As Date, ByVal FechaFin As Date) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComandaService(sessionID, Connection, Transaction)
            dtList = Svc.ServicioDomicilioList(FechaIni, FechaFin)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class

Partial Class ComandaService
    Public Sub LiberarMesa(ByVal IdMesa As Integer)
        Try
            Dim sp As New StoredProcedure("Restaurant", "ComandaLiberarMesa", Me.Connection, Me.Transaction)
            sp.Parameters.Add("@IdMesa", DbType.Int32).Value = IdMesa
            sp.Execute()
        Catch ex As Exception
            Throw New BusinessException("No se ha podido liberar la mesa.", ex)
        End Try
    End Sub

    Public Sub EstablecerRepartidor(ByVal idComandaTit As String, ByVal idRepartidor As Integer)
        Try
            Dim sp As New StoredProcedure("Restaurant", "ComandaPonerRepartidor", Me.Connection, Me.Transaction)
            sp.Parameters.Add("@IdComandaTit", DbType.String).Value = idComandaTit
            sp.Parameters.Add("@IdRepartidor", DbType.Int32).Value = IdRepartidor
            sp.Execute()
        Catch ex As Exception
            Throw New BusinessException("No se ha podido establecer el repartidor de la comanda.", ex)
        End Try
    End Sub

    Public Sub MarcarPedimentoImpreso(ByVal idComandaTit As String, ByVal IdCentrosProdImpresos As String)
        Try
            Dim sp As New StoredProcedure("Restaurant", "MarcarPedimentoImpreso", Me.Connection, Me.Transaction)
            sp.Parameters.Add("@IdComandaTit", DbType.String).Value = idComandaTit
            sp.Parameters.Add("@IdCentrosProdImpresos", DbType.String).Value = IdCentrosProdImpresos
            sp.Execute()
        Catch ex As Exception
            Throw New BusinessException("No se pudieron marcar los centros de produccion con pedimento impreso.", ex)
        End Try
    End Sub


    Public Function TicketPrint(ByVal IdComandaTit As String) As InformesDS.ComandaTicketDataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxComandaTicket", Connection, Transaction)
            fxList.Parameters.Add("@IdComandaTit", DbType.String).Value = IdComandaTit
            Dim dtList As New InformesDS.ComandaTicketDataTable()
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el detalle de la comanda.", ex)
        End Try
    End Function

    Public Function TicketPedimentoPrint(ByVal IdComandaTit As String) As InformesDS.ComandaTicketPedimentoDataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxComandaTicketPedimento", Connection, Transaction)
            fxList.Parameters.Add("@IdComandaTit", DbType.String).Value = IdComandaTit
            Dim dtList As New InformesDS.ComandaTicketPedimentoDataTable
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el detalle de la comanda.", ex)
        End Try
    End Function

    Public Function MesasCuentasLST(ByVal IdCaja As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxComandaCuentasLST", Connection, Transaction)
            fxList.Parameters.Add("@IdCaja", DbType.String).Value = IdCaja
            Dim dtList As DataTable = fxList.GetTable("ComandaTicketPedimento")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de mesas por cobrar.", ex)
        End Try
    End Function

    Public Function ServicioDomicilioList(ByVal FechaIni As Date, ByVal FechaFin As Date) As DataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxComandaTitServicioDomicilioLST", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni.ToShortDateString
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin.ToShortDateString
            Dim dtList As DataTable = fxList.GetTable("ComandaTicketPedimento")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de comandas.", ex)
        End Try

    End Function

End Class