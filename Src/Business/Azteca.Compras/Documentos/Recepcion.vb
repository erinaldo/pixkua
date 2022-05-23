Imports Azteca.Business.Inventario

Partial Class RecepcionFacade
    Public Function LoadPrintInfo(ByVal sessionID As Guid, ByVal IdRecepcion As String) As InformesDS.RecepcionesDataTable
        ValidateSession(sessionID)
        Dim dtRet As New InformesDS.RecepcionesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New RecepcionService(sessionID, Connection, Transaction)
            dtRet = Svc.LoadPrintInfo(IdRecepcion)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtRet
    End Function
End Class

Partial Class RecepcionService

    Public Function LoadPrintInfo(IdRecepcion As String) As InformesDS.RecepcionesDataTable
        Dim dtList As New InformesDS.RecepcionesDataTable
        Try
            Dim fxList As New FunctionSQL("Purchasing", "fxRecepcionesRPT", Connection, Transaction)
            fxList.Parameters.Add("@IdRecepcionTit", DbType.String).Value = IdRecepcion
            fxList.FillDataTable(dtList)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los datos del informe.", ex)
        End Try
        Return dtList
    End Function

    Private Sub Aplicar(recepcion As RecepcionInfo, idEntrada As String)
        Try
            Dim spAplicar As New StoredProcedure("Purchasing", "RecepcionAplicar", Connection, Transaction)
            spAplicar.Parameters.Add("@IdRecepcion", DbType.String).Value = recepcion.Identity
            spAplicar.Parameters.Add("@IdEntrada", DbType.String).Value = idEntrada
            spAplicar.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al aplicar la recepción de compra (" & recepcion.Identity & ")", ex)
        End Try
    End Sub

    Private Function GenerarEntrada(recepcion As RecepcionInfo) As String
        Try
            'Cargar información de la orden para determina el almacén al que ingresarán los artículos de la recepción
            Dim Orden As New OrdenInfo(SessionID)
            Dim OrdenSvc As New OrdenService(SessionID, Connection, Transaction)
            OrdenSvc.GetDetail(recepcion.IdOrdenTit, Orden)
            '
            Dim CentroRecepcion As New CentroRecepcionInfo(SessionID)
            Dim CentroRecepcionSvc As New CentroRecepcionService(SessionID, Connection, Transaction)
            CentroRecepcionSvc.GetDetail(Orden.IdCentroRecepcion, CentroRecepcion, False)
            '
            Dim Entrada As New MovimientoInfo(SessionID)
            With Entrada
                .IdAlmacen = CentroRecepcion.IdAlmacen
                .Direccion = TipoMovimiento.Entrada
                .Fecha = Date.Today
                'Obtener el identificador de concepto de la salida por venta
                Dim IdConcepto As Integer = CInt(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Inventario/Conceptos", "EntradaRecepcion"))
                .IdConcepto = IdConcepto
                .IdSucursal = Orden.IdSucursal
                .Observaciones = "Recepción: " & recepcion.Identity
                .Referencia = recepcion.Identity
            End With
            For Each drPartida As DetalleRecepcionDS.ArticulosRow In recepcion.Articulos
                If drPartida.Cantidad > 0 Then
                    Dim drArticulo As DetalleMovimientoDS.DetalleRow = Entrada.Details.NewDetalleRow
                    With drArticulo
                        .IdArticuloStock = drPartida.IdArticuloStock
                        '.Cantidad = drPartida.Cantidad
                        .Cantidad = drPartida.Recibido
                        .IdUnidadMedida = drPartida.IdUnidadMedida
                        .CostoUnitario = drPartida.CostoUnitario
                    End With
                    Entrada.Details.AddDetalleRow(drArticulo)
                End If
            Next
            If Entrada.Details.Count > 0 Then
                Dim SalidaSvc As New MovimientoService(SessionID, Connection, Transaction)
                Entrada = SalidaSvc.Update(Entrada)
                SalidaSvc.ApplyWorkflow(Entrada.Identity, WorkflowSteps.Apply, Date.Today)
                Return Entrada.Identity
            Else
                Return String.Empty
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al generar la entrada de artículos de la recepción de compra.", ex)
        End Try

    End Function

End Class
