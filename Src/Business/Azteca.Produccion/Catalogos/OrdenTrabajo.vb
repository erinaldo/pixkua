Imports Azteca.Kernel
Imports Azteca.Business.Inventario

Partial Class OrdenTrabajoService

#Region "Informes"

    Public Function GetInformeIncidencias(ByVal fechaIni As DateTime, ByVal fechaFin As DateTime) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoIncidenciasRPT", Connection, Transaction)
            fx.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaIni
            fx.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFin
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los datos para el reporte de seguimiento.", ex)
        End Try
    End Function

    Public Function GetInformeSeguimiento(ByVal fechaIni As DateTime, ByVal fechaFin As DateTime) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoSeguimientoRPT", Connection, Transaction)
            fx.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaIni
            fx.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFin
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los datos para el reporte de seguimiento.", ex)
        End Try
    End Function

    Public Function GetInformeOrdenTrabajo(ByVal idOrdenTrabajo As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoReport", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los datos para el reporte de Orden de Trabajo.", ex)
        End Try
    End Function

#End Region

    Public Function LoadMovimientosInventarioByOT(ByVal idOrdenTrabajo As Integer, ByVal idSucursal As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoMovsInventario", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            fx.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de movimientos en inventario.", ex)
        End Try
    End Function

    Public Sub SetCantidadRecibidaByOT(ByVal idOrdenTrabajo As Integer, ByVal Cantidad As Decimal, ByVal direccion As Integer, ByVal idConcepto As Integer, ByVal idArticuloStock As Integer)
        Try
            Dim cmdUpdate As New StoredProcedure("Production", "OrdenesTrabajoCantidadRecibidaUPD", Connection, Transaction)
            cmdUpdate.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            cmdUpdate.Parameters.Add("@Cantidad", DbType.Int32).Value = Cantidad
            cmdUpdate.Parameters.Add("@Direccion", DbType.Int32).Value = direccion
            cmdUpdate.Parameters.Add("@IdConcepto", DbType.Int32).Value = idConcepto
            cmdUpdate.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            cmdUpdate.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al actualizar la cantidad de descarga.", ex)
        End Try
    End Sub

    Public Sub EditarMovimiento(ByVal movInfo As Produccion.Movimiento)
        Try
            Dim cmdUpdate As New StoredProcedure("Production", "MovimientosEditar", Connection, Transaction)
            cmdUpdate.Parameters.Add("@IdMovimiento", DbType.Int32).Value = movInfo.IdMovimiento
            cmdUpdate.Parameters.Add("@Cantidad", DbType.Int32).Value = movInfo.Cantidad
            cmdUpdate.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity
            cmdUpdate.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation

            cmdUpdate.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al editar el movimiento.", ex)
        End Try
    End Sub

    

    Public Function LoadMovimientosByOT(ByVal idOrdenTrabajo As Integer, ByVal idEnsamble As Integer) As OrdenesTrabajoDS.MovimientosDataTable

        Dim dt As New OrdenesTrabajoDS.MovimientosDataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoMovsByOT", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            fx.Parameters.Add("@IdEnsamble", DbType.Int32).Value = idEnsamble
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de movimientos.", ex)
        End Try
    End Function

    Public Function AddMovimiento(ByVal movimiento As Movimiento) As String
        Dim msgError As String = ""
        Try
            Dim cmdUpdate As New StoredProcedure("Production", "MovimientosUPD", Connection, Transaction)
            cmdUpdate.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = movimiento.IdOrdenTrabajo
            cmdUpdate.Parameters.Add("@IdEnsamble", DbType.Int32).Value = movimiento.IdEnsamble
            cmdUpdate.Parameters.Add("@IdIncidencia", DbType.Int32).Value = movimiento.IdIncidencia
            cmdUpdate.Parameters.Add("@Clase", DbType.String).Value = movimiento.Clase
            cmdUpdate.Parameters.Add("@Cantidad", DbType.Decimal).Value = movimiento.Cantidad
            cmdUpdate.Parameters.Add("@Observaciones", DbType.String).Value = movimiento.Observaciones
            cmdUpdate.Parameters.Add("@IdSucursal", DbType.Int32).Value = Session.User.IdSucursal
            cmdUpdate.Parameters.Add("@IdEmpresa", DbType.Int32).Value = Session.User.IdEmpresa
            cmdUpdate.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmdUpdate.Parameters.Add("@UserCreate", DbType.Int32).Value = Session.User.Identity
            cmdUpdate.Parameters.Add("@IdEmpleado", DbType.Int32).Value = movimiento.IdEmpleado

            cmdUpdate.Execute()
        Catch ex As Exception
            msgError = "Error al agregar el movimiento: " & ex.Message
            Return msgError
            Throw New BusinessException("Error al agregar el movimiento.", ex)
        End Try

        Return msgError
    End Function

    Public Sub ApplyWorkflow(ByVal otInfo As OrdenTrabajoInfo, ByVal workFlowStatus As WorkFlowStatus)
        Try
            Dim cmdUpdate As New StoredProcedure("Production", "OrdenesTrabajoWorkFlow", Connection, Transaction)
            cmdUpdate.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = otInfo.Identity
            cmdUpdate.Parameters.Add("@IdWorkFlowStatus", DbType.Int32).Value = CInt(workFlowStatus)
            cmdUpdate.Parameters.Add("@IdEnsamble", DbType.Int32).Value = otInfo.EnsambleSiguiente.Identity
            cmdUpdate.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity
            cmdUpdate.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmdUpdate.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al asignar el WorkFlow a la OT.", ex)
        End Try
    End Sub

    Public Function LoadMovimientosByOT(ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.MovimientosDataTable
        Dim dt As New OrdenesTrabajoDS.MovimientosDataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoMovsByOT", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            fx.Parameters.Add("@IdEnsamble", DbType.Int32).Value = 0
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de movimientos.", ex)
        End Try
    End Function

    Public Function LoadIncidenciasByOT(ByVal idOrdenTrabajo As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxIncidenciasByOT", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Incidencias.", ex)
        End Try
    End Function

    Public Function LoadProcesosByOT(ByVal idOrdenTrabajo As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxProcesosByOT", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Procesos.", ex)
        End Try
    End Function

    Public Function GenerarMovimientoByOT(otInfo As OrdenTrabajoInfo, ByVal direccion As TipoMovimiento, ByVal articulo As ArticuloStockInfo, ByVal cantidad As Decimal, ByVal idAlmacen As Integer) As String
        Try

            '
            Dim MovInfo As New MovimientoInfo(SessionID)
            Dim IdConcepto As Integer

            With MovInfo
                If (direccion = TipoMovimiento.Salida) Then
                    'Obtener el identificador de concepto de la salida por movimiento en Orden de Trabajo
                    IdConcepto = CInt(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Inventario/Conceptos", "SalidaPorOT"))
                Else
                    IdConcepto = CInt(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Inventario/Conceptos", "EntradaPorOT"))
                End If
                .IdAlmacen = idAlmacen
                .Direccion = direccion
                .Fecha = Date.Today
                .IdConcepto = IdConcepto
                .IdSucursal = otInfo.IdSucursal
                .Observaciones = "Orden de Trabajo: " & otInfo.Identity.ToString()
                .Referencia = otInfo.UserCode
            End With

            Dim drArticulo As DetalleMovimientoDS.DetalleRow = MovInfo.Details.NewDetalleRow
            Dim ArticuloSvc As New Inventario.ArticuloStockService(SessionID, Connection, Transaction)

            With drArticulo
                .IdArticuloStock = articulo.Identity
                .Cantidad = cantidad
                .IdUnidadMedida = articulo.IdUnidadMedida
                .CostoUnitario = ArticuloSvc.GetCostoByIssue(otInfo.IdSucursal, .IdArticuloStock)
            End With

            MovInfo.Details.AddDetalleRow(drArticulo)

            If MovInfo.Details.Count > 0 Then
                Dim MovimientoSvc As New MovimientoService(SessionID, Connection, Transaction)
                MovInfo = MovimientoSvc.Update(MovInfo)
                MovimientoSvc.ApplyWorkflow(MovInfo.Identity, WorkflowSteps.Apply, Date.Today)

                'Actualizamos la cantidad de descarga
                Call SetCantidadRecibidaByOT(otInfo.Identity, drArticulo.Cantidad, direccion, MovInfo.IdConcepto, drArticulo.IdArticuloStock)

                Return MovInfo.Identity
            Else
                Return String.Empty
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al generar el movimiento del articulo referente la orden de trabajo (" & otInfo.UserCode & ")", ex)
        End Try
    End Function

    

    Public Function GenerarSalidaInumos(ByVal otInfo As OrdenTrabajoInfo, ByVal afectarInventario As Boolean, ByVal idEmpleado As Integer) As String
        Try

            '
            Dim Salida As New MovimientoInfo(SessionID)
            Dim ArticuloSvc As New ArticuloStockService(SessionID, Connection, Transaction)
            'Obtener el identificador de concepto de la salida por OT
            Dim IdConcepto As Integer = CInt(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Inventario/Conceptos", "SalidaPorOT"))
            With Salida
                .IdAlmacen = otInfo.IdAlmacenInsumos
                .Direccion = TipoMovimiento.Salida
                .Fecha = Date.Today
                .IdConcepto = IdConcepto
                .IdSucursal = otInfo.IdSucursal
                .Observaciones = "Orden de Trabajo: " & otInfo.Identity.ToString()
                .Referencia = otInfo.UserCode
            End With
            For Each drPartida As OrdenesTrabajoDS.InsumosRow In otInfo.Insumos
                If drPartida.Cantidad > 0 Then
                    Dim drArticulo As DetalleMovimientoDS.DetalleRow = Salida.Details.NewDetalleRow
                    With drArticulo
                        .IdArticuloStock = drPartida.IdArticuloStock

                        Dim Merma As Decimal = 0

                        If (drPartida.MermaPorc > 0) Then
                            If (drPartida.TipoMerma = "C") Then
                                Merma = drPartida.MermaPorc
                            Else
                                Merma = drPartida.Cantidad * (drPartida.MermaPorc / 100)
                            End If
                        End If

                        .Cantidad = drPartida.Cantidad + Merma
                        .IdUnidadMedida = drPartida.IdUnidadMedida
                        .CostoUnitario = ArticuloSvc.GetCostoByIssue(otInfo.IdSucursal, .IdArticuloStock)
                    End With
                    If (drPartida.Surtir = True) Then
                        Salida.Details.AddDetalleRow(drArticulo)
                    End If

                End If
            Next

            If (afectarInventario) Then
                Dim SalidaSvc As New MovimientoService(SessionID, Connection, Transaction)
                Salida = SalidaSvc.Update(Salida)
                SalidaSvc.ApplyWorkflow(Salida.Identity, WorkflowSteps.Apply, Date.Today)
                For Each item As DetalleMovimientoDS.DetalleRow In Salida.Details.Rows
                    'Actualizamos la cantidad de descarga
                    Call SetCantidadRecibidaByOT(otInfo.Identity, item.Cantidad, TipoMovimiento.Salida, IdConcepto, item.IdArticuloStock)
                Next
            End If

            'Aplicamos el WorkFlow a la Orden de Trabajo
            Dim OTSvc As New OrdenTrabajoService(SessionID, Connection, Transaction)
            OTSvc.ApplyWorkflow(otInfo, WorkFlowStatus.Liberado)
            'Insertamos en los movimientos el inicio de proceso de la OT actual.
            Dim mov As New Movimiento()
            mov.IdEnsamble = otInfo.EnsambleSiguiente.Identity
            mov.IdOrdenTrabajo = otInfo.Identity
            mov.Clase = TipoMovimientoOT.InicioProceso
            mov.IdEmpleado = idEmpleado
            OTSvc.AddMovimiento(mov)

            Return Salida.Identity
        Catch ex As Exception
            Throw New BusinessException("Error al generar la salida de insumos para surtir la orden de trabajo.", ex)
        End Try
    End Function




    Public Function GetEnsambleSiguienteSEL(ByVal idOrdenTrabajo As Integer) As EnsambleInfo
        Dim infoID As Integer
        Dim Ensambleinfo As New EnsambleInfo(SessionID)
        Dim EnsambleFac As New EnsambleFacade()
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoEnsambleSigID", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            'Si la funcion retorna 0 = no existen ensambles asignados a la OT, Si retorna -1 ha llegado al ensamble final
            infoID = CInt(fx.GetScalar())
            If (infoID > 0) Then
                Ensambleinfo = EnsambleFac.GetDetail(SessionID, infoID)
            Else
                Ensambleinfo.SetIdentity(infoID)
            End If

        Catch ex As Exception
            Throw New BusinessException("Error al obtener el ensamble siguiente.", ex)
        End Try
        Return Ensambleinfo
    End Function

    Public Function GetEnsambleAnteriorSEL(ByVal idOrdenTrabajo As Integer) As EnsambleInfo
        Dim infoID As Integer
        Dim Ensambleinfo As New EnsambleInfo(SessionID)
        Dim EnsambleFac As New EnsambleFacade()
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoEnsambleAntID", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            infoID = CInt(fx.GetScalar())
            If (infoID > 0) Then
                Ensambleinfo = EnsambleFac.GetDetail(SessionID, infoID)
            End If

        Catch ex As Exception
            Throw New BusinessException("Error al obtener el ensamble siguiente.", ex)
        End Try
        Return Ensambleinfo
    End Function

    Public Function ExistenInicenciasAbiertas(ByVal idOrdenTrabajo As Integer) As Boolean
        Dim Existen As Boolean

        Try
            Dim fx As New FunctionSQL("Production", "fxCheckIncidenciasAbiertas", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            Existen = CBool(fx.GetScalar())

        Catch ex As Exception
            Throw New BusinessException("Error al obtener las incidencias abiertas.", ex)
        End Try
        Return Existen
    End Function

    Public Function LoadInsumosLiberar(ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.InsumosLiberarDataTable
        Dim dt As New OrdenesTrabajoDS.InsumosLiberarDataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoInsumosLiberar", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de insumos a surtir.", ex)
        End Try
    End Function

    Public Function LoadInsumosLiberarCBO(ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.InsumosLiberarCBODataTable
        Dim dt As New OrdenesTrabajoDS.InsumosLiberarCBODataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoInsumosLiberarCBO", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de insumos a surtir.", ex)
        End Try
    End Function

    Public Function LoadOrdenesTrabajoAdmin(ByVal idWorkFlow As WorkFlowStatus, ByVal idEnsamble As Integer, ByVal idSucursal As Integer) As OrdenesTrabajoDS.OrdenesTrabajoDataTable
        Dim dt As New OrdenesTrabajoDS.OrdenesTrabajoDataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoAdminLST", Connection, Transaction)
            fx.Parameters.Add("@IdWorkFlow", DbType.Int32).Value = idWorkFlow
            fx.Parameters.Add("@IdEnsamble", DbType.Int32).Value = idEnsamble
            fx.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal

            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de ordenes de trabajo.", ex)
        End Try
    End Function

    Public Function LoadInsumosOT(ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.InsumosDataTable
        Dim dt As New OrdenesTrabajoDS.InsumosDataTable()
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoInsumosSEL", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de insumos.", ex)
        End Try
    End Function

    Public Function LoadServiciosOT(ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.ServiciosDataTable
        Dim dt As New OrdenesTrabajoDS.ServiciosDataTable()
        Try
            Dim fx As New FunctionSQL("Production", "[fxOrdenesTrabajoServiciosSEL]", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de insumos.", ex)
        End Try
    End Function

    Public Function LoadEnsamblesOT(ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.EnsamblesDataTable
        Dim dt As New OrdenesTrabajoDS.EnsamblesDataTable
        Try
            Dim fx As New FunctionSQL("Production", "fxOrdenesTrabajoEnsamblesSEL", Connection, Transaction)
            fx.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            fx.FillDataTable(dt)
            Return dt
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de ensambles.", ex)
        End Try
    End Function

    Public Sub SaveInsumoOT(ByVal idOrdenTrabajo As Integer, ByVal InsumoRow As OrdenesTrabajoDS.InsumosRow)
        Try
            Dim cmdInsert As New StoredProcedure("Production", "OrdenesTrabajoInsumosUPD", Connection, Transaction)
            cmdInsert.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            cmdInsert.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = InsumoRow.IdArticuloStock
            cmdInsert.Parameters.Add("@Cantidad", DbType.Decimal).Value = InsumoRow.Cantidad
            cmdInsert.Parameters.Add("@IdUnidadMedida", DbType.Int32).Value = InsumoRow.IdUnidadMedida
            cmdInsert.Parameters.Add("@Costo", DbType.Decimal).Value = InsumoRow.Costo
            cmdInsert.Parameters.Add("@Surtir", DbType.Boolean).Value = InsumoRow.Surtir
            cmdInsert.Parameters.Add("@MermaPorc", DbType.Decimal).Value = InsumoRow.MermaPorc
            cmdInsert.Parameters.Add("@TipoMerma", DbType.String).Value = InsumoRow.TipoMerma
            cmdInsert.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al asignar el insumo a la OT.", ex)
        End Try
    End Sub

    Public Sub SaveServicioOT(ByVal idOrdenTrabajo As Integer, ByVal servicioRow As OrdenesTrabajoDS.ServiciosRow)
        Try
            Dim cmdInsert As New StoredProcedure("Production", "[OrdenesTrabajoServiciosUPD]", Connection, Transaction)
            cmdInsert.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            cmdInsert.Parameters.Add("@IdServicio", DbType.Int32).Value = servicioRow.IdServicio
            cmdInsert.Parameters.Add("@Cantidad", DbType.Decimal).Value = servicioRow.Cantidad
            cmdInsert.Parameters.Add("@Costo", DbType.Decimal).Value = servicioRow.Costo
            cmdInsert.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al asignar el servicio a la OT.", ex)
        End Try
    End Sub

    Public Sub SaveEnsambleOT(ByVal idOrdenTrabajo As Integer, ByVal EnsambleRow As OrdenesTrabajoDS.EnsamblesRow)
        Try
            Dim cmdInsert As New StoredProcedure("Production", "OrdenesTrabajoEnsamblesUPD", Connection, Transaction)
            cmdInsert.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            cmdInsert.Parameters.Add("@IdEnsamble", DbType.Int32).Value = EnsambleRow.IdEnsamble
            cmdInsert.Parameters.Add("@Orden", DbType.Int16).Value = EnsambleRow.Orden
            cmdInsert.Parameters.Add("@HorasMaquina", DbType.Decimal).Value = EnsambleRow.HorasMaquina
            cmdInsert.Parameters.Add("@CostoMaquina", DbType.Decimal).Value = EnsambleRow.CostoMaquina
            cmdInsert.Parameters.Add("@HorasLabor", DbType.Decimal).Value = EnsambleRow.HorasLabor
            cmdInsert.Parameters.Add("@CostoLabor", DbType.Decimal).Value = EnsambleRow.CostoLabor
            cmdInsert.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al asignar el ensamble a la OT.", ex)
        End Try
    End Sub

    Public Sub DeleteInsumoOT(ByVal idOrdenTrabajo As Integer, ByVal idInsumo As Integer)
        Try
            Dim cmdDelete As New StoredProcedure("Production", "OrdenesTrabajoInsumosDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            cmdDelete.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idInsumo
            cmdDelete.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al eliminar el insumo de la OT.", ex)
        End Try
    End Sub

    Public Sub DeleteEnsambleOT(ByVal idOrdenTrabajo As Integer, ByVal idEnsamble As Integer)
        Try
            Dim cmdDelete As New StoredProcedure("Production", "OrdenesTrabajoEnsamblesDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            cmdDelete.Parameters.Add("@IdEnsamble", DbType.Int32).Value = idEnsamble
            cmdDelete.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al eliminar el ensamble de la OT.", ex)
        End Try
    End Sub

    Public Sub DeleteServicioOT(ByVal idOrdenTrabajo As Integer, ByVal idServicio As Integer)
        Try
            Dim cmdDelete As New StoredProcedure("Production", "OrdenesTrabajoServiciosDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdOrdenTrabajo", DbType.Int32).Value = idOrdenTrabajo
            cmdDelete.Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
            cmdDelete.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al eliminar el servicio de la OT.", ex)
        End Try
    End Sub


#Region "Generador de Ordenes de Trabajo"


    Public Function GenerarOrdenTrabajoByMaestro(ByVal otBaseInfo As OrdenTrabajoInfo, ByVal cantidad As Decimal, ByVal fechaRecepcion As DateTime, ByVal fechaEntrega As DateTime, ByVal fechaRequerida As DateTime) As Integer

        Try


            Dim OTNew As New OrdenTrabajoInfo(SessionID)
            Dim OTSvc As New OrdenTrabajoService(SessionID, Connection, Transaction)
            Dim newIdentity As Integer = 0

            With OTNew

                .Nombre = otBaseInfo.Nombre
                .Fecha = Today.Date.Date
                .IdArticuloStock = otBaseInfo.IdArticuloStock
                .CantDeseada = cantidad
                .CantRecibida = otBaseInfo.CantRecibida
                .Version = otBaseInfo.Version
                .IdOrdenTrabajoTipo = otBaseInfo.IdOrdenTrabajoTipo
                .FechaPromEntrega = fechaEntrega
                .FechaRecepcion = fechaRecepcion
                .EntregasParciales = otBaseInfo.EntregasParciales
                .ExigirRecepcion = otBaseInfo.ExigirRecepcion
                .Observaciones = otBaseInfo.Observaciones
                .EnsambleActual = otBaseInfo.EnsambleActual
                .IncidenciaActual = otBaseInfo.IncidenciaActual
                .IdAlmacenInsumos = otBaseInfo.IdAlmacenInsumos
                .IdAlmacenPT = otBaseInfo.IdAlmacenPT
                .IdCuenta = otBaseInfo.IdCuenta
                .Status = otBaseInfo.Status
                .WorkFlowStatus = otBaseInfo.WorkFlowStatus
                .IdSucursal = otBaseInfo.IdSucursal
                .IdEmpresa = otBaseInfo.IdEmpresa
                .FechaRequerida = fechaRequerida
                .CantidadPlanillas = otBaseInfo.CantidadPlanillas
                .Area = otBaseInfo.Area
                .Tipo = "W"
            End With

            newIdentity = OTSvc.Update(OTNew)

            

            Return newIdentity
        Catch ex As Exception
            Throw New BusinessException("Error al clonar la orden de trabajo.", ex)
        End Try

    End Function

    Public Function GenerarDetalleFromMaestro(ByVal otBaseInfo As OrdenTrabajoInfo, ByVal newIdentity As Integer, ByVal cantidadFabricar As Decimal) As Boolean
        Dim res As Boolean = False

        Try
            Dim OTFacade As New OrdenTrabajoFacade()

            'Agregamos los insumos y consumibles
            For Each item As OrdenesTrabajoDS.InsumosRow In otBaseInfo.Insumos.Rows
                Dim NewRow As OrdenesTrabajoDS.InsumosRow = otBaseInfo.Insumos.NewInsumosRow



                With (NewRow)
                    .IdArticuloStock = item.IdArticuloStock
                    .NombreInsumo = item.NombreInsumo
                    If (item.IsCantidadFija) Then
                        .Cantidad = item.Cantidad
                    Else
                        .Cantidad = (item.Cantidad / otBaseInfo.CantDeseada) * cantidadFabricar
                    End If

                    .Costo = item.Costo
                    .IdUnidadMedida = item.IdUnidadMedida
                    .IdUnidadMedidaTipo = item.IdUnidadMedidaTipo
                    .UM = item.UM
                    .Surtir = item.Surtir

                    Dim Merma As Decimal = 0

                    If (item.MermaPorc > 0) Then
                        If (item.TipoMerma = "C") Then
                            If (item.IsCantidadFija) Then
                                Merma = item.MermaPorc
                            Else
                                Merma = (item.MermaPorc / otBaseInfo.CantDeseada) * cantidadFabricar
                            End If
                        Else
                            Merma = item.MermaPorc
                        End If
                    End If
                    
                    .MermaPorc = Merma
                    .TipoMerma = item.TipoMerma
                End With
                OTFacade.SaveInsumoOT(SessionID, newIdentity, NewRow)
            Next

            'Agregamos los Servicios
            For Each item As OrdenesTrabajoDS.ServiciosRow In otBaseInfo.Servicios.Rows
                Dim NewServicio As OrdenesTrabajoDS.ServiciosRow = otBaseInfo.Servicios.NewServiciosRow

                With (NewServicio)
                    .IdServicio = item.IdServicio
                    .Nombre = item.Nombre
                    .Cantidad = item.Cantidad
                    .Costo = (item.Costo / otBaseInfo.CantDeseada) * cantidadFabricar
                End With

                OTFacade.SaveServicioOT(SessionID, newIdentity, NewServicio)
            Next

            'Agregamos los ensambles
            For Each item As OrdenesTrabajoDS.EnsamblesRow In otBaseInfo.Ensambles.Rows
                Dim NewEnsamble As OrdenesTrabajoDS.EnsamblesRow = otBaseInfo.Ensambles.NewEnsamblesRow

                With (NewEnsamble)
                    .IdEnsamble = item.IdEnsamble
                    .NombreEnsamble = item.NombreEnsamble
                    .Orden = item.Orden
                    .HorasMaquina = (item.HorasMaquina / otBaseInfo.CantDeseada) * cantidadFabricar
                    .CostoMaquina = item.CostoMaquina
                    .HorasLabor = (item.HorasLabor / otBaseInfo.CantDeseada) * cantidadFabricar
                    .CostoLabor = item.CostoLabor
                End With

                OTFacade.SaveEnsambleOT(SessionID, newIdentity, NewEnsamble)

            Next


            res = True

        Catch ex As Exception
            Throw New BusinessException("Error al generar el detalle de la orden de trabajo", ex)
        End Try

        Return res

    End Function

#End Region

End Class

Partial Class OrdenTrabajoFacade

#Region "Generador de Ordenes de Trabajo"

    Public Function GenerarOrdenTrabajoByMaestro(ByVal sessionID As Guid, ByVal otBaseInfo As OrdenTrabajoInfo, ByVal cantidad As Decimal, ByVal fechaRecepcion As DateTime, ByVal fechaEntrega As DateTime, ByVal fechaRequerida As DateTime) As Integer
        Dim identity As Integer
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                identity = Svc.GenerarOrdenTrabajoByMaestro(otBaseInfo, cantidad, fechaRecepcion, fechaEntrega, fechaRequerida)
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

        Return identity
    End Function

    Public Function GenerarDetalleFromMaestro(ByVal sessionID As Guid, ByVal otBaseInfo As OrdenTrabajoInfo, ByVal newIdentity As Integer, ByVal cantidadFab As Decimal) As Boolean
        Dim res As Boolean = False
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                res = Svc.GenerarDetalleFromMaestro(otBaseInfo, newIdentity, cantidadFab)
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

        Return res
    End Function



#End Region



#Region "Informes"

    Public Function GetInformeIncidencias(ByVal sessionID As Guid, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime) As DataTable

        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.GetInformeIncidencias(fechaIni, fechaFin)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function GetInformeSeguimiento(ByVal sessionID As Guid, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime) As DataTable

        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.GetInformeSeguimiento(fechaIni, fechaFin)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function GetInformeOrdenTrabajo(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As DataTable

        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.GetInformeOrdenTrabajo(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

#End Region

    Public Function LoadMovimientosInventarioByOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer, ByVal idSucursal As Integer) As DataTable

        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadMovimientosInventarioByOT(idOrdenTrabajo, idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function GenerarMovimientoByOT(ByVal sessionID As Guid, ByVal otInfo As OrdenTrabajoInfo, ByVal direccion As TipoMovimiento, ByVal articulo As ArticuloStockInfo, ByVal cantidad As Decimal, ByVal idAlmacen As Integer) As String
        Dim idMovto As String = ""
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                idMovto = Svc.GenerarMovimientoByOT(otInfo, direccion, articulo, cantidad, idAlmacen)
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

        Return idMovto
    End Function

    Public Function LoadMovimientosByOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.MovimientosDataTable

        ValidateSession(sessionID)
        Dim dtList As New OrdenesTrabajoDS.MovimientosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadMovimientosByOT(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadIncidenciasByOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As DataTable

        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadIncidenciasByOT(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadProcesosByOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As DataTable

        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadProcesosByOT(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadMovimientosByOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer, ByVal idEnsamble As Integer) As OrdenesTrabajoDS.MovimientosDataTable

        ValidateSession(sessionID)
        Dim dtList As New OrdenesTrabajoDS.MovimientosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadMovimientosByOT(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function AddMovimiento(ByVal sessionID As Guid, ByVal movimiento As Movimiento) As String
        Dim msgError As String = ""
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                msgError = Svc.AddMovimiento(movimiento)
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

        Return msgError
    End Function

    Public Sub ApplyWorkflow(ByVal sessionID As Guid, ByVal otInfo As OrdenTrabajoInfo, ByVal workFlowStatus As WorkFlowStatus)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                Svc.ApplyWorkflow(otInfo, workFlowStatus)
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

    Public Function GenerarSalidaInumos(ByVal sessionID As Guid, ByVal otInfo As OrdenTrabajoInfo, ByVal afectarInventario As Boolean, ByVal idEmpleado As Integer) As String
        Dim idMovto As String = ""
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                idMovto = Svc.GenerarSalidaInumos(otInfo, afectarInventario, idEmpleado)
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

        Return idMovto
    End Function

    Public Function GetEnsambleSiguienteSEL(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As EnsambleInfo
        ValidateSession(sessionID)
        Dim info As New EnsambleInfo(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            info = Svc.GetEnsambleSiguienteSEL(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return info
    End Function

    Public Function GetEnsambleAnteriorSEL(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As EnsambleInfo
        ValidateSession(sessionID)
        Dim info As New EnsambleInfo(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            info = Svc.GetEnsambleAnteriorSEL(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return info
    End Function


    Public Function ExistenInicenciasAbiertas(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As Boolean
        ValidateSession(sessionID)
        Dim info As Boolean
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            info = Svc.ExistenInicenciasAbiertas(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return info
    End Function

    Public Function LoadInsumosLiberar(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.InsumosLiberarDataTable

        ValidateSession(sessionID)
        Dim dtList As New OrdenesTrabajoDS.InsumosLiberarDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadInsumosLiberar(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadInsumosLiberarCBO(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.InsumosLiberarCBODataTable

        ValidateSession(sessionID)
        Dim dtList As New OrdenesTrabajoDS.InsumosLiberarCBODataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadInsumosLiberarCBO(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadOrdenesTrabajoAdmin(ByVal sessionID As Guid, ByVal WorkFlowStatus As WorkFlowStatus, ByVal idEnsamble As Integer, ByVal idSucursal As Integer) As OrdenesTrabajoDS.OrdenesTrabajoDataTable

        ValidateSession(sessionID)
        Dim dtList As New OrdenesTrabajoDS.OrdenesTrabajoDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadOrdenesTrabajoAdmin(WorkFlowStatus, idEnsamble, idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadInsumosOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.InsumosDataTable

        ValidateSession(sessionID)
        Dim dtList As New OrdenesTrabajoDS.InsumosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadInsumosOT(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadServiciosOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.ServiciosDataTable

        ValidateSession(sessionID)
        Dim dtList As New OrdenesTrabajoDS.ServiciosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadServiciosOT(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadEnsamblesOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer) As OrdenesTrabajoDS.EnsamblesDataTable

        ValidateSession(sessionID)
        Dim dtList As New OrdenesTrabajoDS.EnsamblesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadEnsamblesOT(idOrdenTrabajo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Sub SaveInsumoOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer, ByVal InsumoRow As OrdenesTrabajoDS.InsumosRow)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                Svc.SaveInsumoOT(idOrdenTrabajo, InsumoRow)
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

    Public Sub SaveServicioOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer, ByVal ServicioRow As OrdenesTrabajoDS.ServiciosRow)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                Svc.SaveServicioOT(idOrdenTrabajo, ServicioRow)
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

    Public Sub SaveEnsambleOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer, ByVal EnsambleRow As OrdenesTrabajoDS.EnsamblesRow)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                Svc.SaveEnsambleOT(idOrdenTrabajo, EnsambleRow)
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

    Public Sub DeleteInsumoOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer, ByVal idInsumo As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                Svc.DeleteInsumoOT(idOrdenTrabajo, idInsumo)
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

    Public Sub DeleteEnsambleOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer, ByVal idEnsamble As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                Svc.DeleteEnsambleOT(idOrdenTrabajo, idEnsamble)
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

    Public Sub DeleteServicioOT(ByVal sessionID As Guid, ByVal idOrdenTrabajo As Integer, ByVal idServicio As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                Svc.DeleteServicioOT(idOrdenTrabajo, idServicio)
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

    Public Function EditarMovimiento(ByVal sessionID As Guid, ByVal movInfo As Produccion.Movimiento) As String
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenTrabajoService(sessionID, Connection, Transaction)
                Svc.EditarMovimiento(movInfo)
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
    End Function

End Class
