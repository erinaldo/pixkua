Imports Azteca.Business.Contabilidad

Partial Class OrdenService

#Region "Metodos Generales"

    Public Function LoadList(fechaInicial As Date, fechaFinal As Date, idUsuario As Integer, idSucursal As Integer) As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Dim fxList As New FunctionSQL("Purchasing", "fxOrdenesList", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal
            fxList.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            dtList = fxList.GetTable
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de ordenes de compra.", ex)
        End Try
        Return dtList
    End Function

    Public Function LoadRecepciones(idOrden As String) As DataTable
        Try
            Dim fxRecepciones As New FunctionSQL("Purchasing", "fxRecepcionesOrden", Connection, Transaction)
            fxRecepciones.Parameters.Add("@IdOrden", DbType.String).Value = idOrden
            Dim dtRecepciones As DataTable = fxRecepciones.GetTable("Recepciones")
            Return dtRecepciones
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las recepciones de la orden de compra.", ex)
        End Try
    End Function

#End Region

#Region "Informes"

    Public Function LoadPrintInfo(idOrden As String) As InformesDS.OrdenesDataTable
        Try
            Dim fxOrden As New FunctionSQL("Purchasing", "fxOrdenRPT", Connection, Transaction)
            fxOrden.Parameters.Add("@IdOrden", DbType.String).Value = idOrden
            Dim dtInfo As New InformesDS.OrdenesDataTable
            fxOrden.FillDataTable(dtInfo)
            Return dtInfo
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de impresión de la orden: " & idOrden, ex)
        End Try
    End Function

#End Region

#Region "Generador"

    Public Function AsignarProveedores(requisiciones As GeneradorOrdenesDS.RequisicionesDataTable) As GeneradorOrdenesDS.ProveedoresDataTable
        Try
            Dim Proveedores As New GeneradorOrdenesDS.ProveedoresDataTable
            'Agrupar las requisiciones por zona de compra, articulo y servicio
            Dim Items = From R In requisiciones
                      Group By R.IdZonaCompra, R.IdArticuloStock, R.IdServicio, R.Codigo, R.Descripcion, R.ZonaCompra Into Group

            'Asignar (si existe) el proveedor predeterminado para cada artículo o servicio
            For Each Item In Items
                Dim drProveedor As GeneradorOrdenesDS.ProveedoresRow = Proveedores.NewProveedoresRow
                With drProveedor
                    .IdZonaCompra = Item.IdZonaCompra
                    .IdArticuloStock = Item.IdArticuloStock
                    .IdServicio = Item.IdServicio
                    .Codigo = Item.Codigo
                    .Descripcion = Item.Descripcion
                    .ZonaCompra = Item.ZonaCompra
                    If .IdArticuloStock > 0 Then
                        Dim ProveedorSvc As New ProveedorService(SessionID, Connection, Transaction)
                        Dim Articulo As CompraArticuloInfo = ProveedorSvc.GetProveedorDefaultArticulo(.IdZonaCompra, .IdArticuloStock)
                        If Articulo IsNot Nothing Then
                            .IdProveedor = Articulo.IdProveedor
                            .CodigoProveedor = Articulo.CodigoProveedor
                            .NombreProveedor = Articulo.NombreProveedor
                            .IdUnidadMedida = Articulo.IdUnidadMedida
                            .UnidadMedida = Articulo.UnidadMedida
                            .PrecioUnitario = Articulo.Costo
                            .IdDivisa = Articulo.IdDivisa
                            .Divisa = Articulo.Divisa
                            .IdImpuesto1 = Articulo.IdImpuesto1
                            .IdImpuesto2 = Articulo.IdImpuesto2
                            .IdImpuesto3 = Articulo.IdImpuesto3
                            If .IdImpuesto1 > 0 Then .Impuesto1 = Articulo.Impuesto1
                            If .IdImpuesto2 > 0 Then .Impuesto2 = Articulo.Impuesto2
                            If .IdImpuesto3 > 0 Then .Impuesto3 = Articulo.Impuesto3
                            .IdRetencion1 = Articulo.IdRetencion1
                            .IdRetencion2 = Articulo.IdRetencion1
                            .IdRetencion3 = Articulo.IdRetencion1
                            If .IdRetencion1 > 0 Then .Retencion1 = Articulo.Retencion1
                            If .IdRetencion2 > 0 Then .Retencion2 = Articulo.Retencion2
                            If .IdRetencion3 > 0 Then .Retencion3 = Articulo.Retencion3
                        End If
                    ElseIf .IdServicio > 0 Then
                        Dim ProveedorSvc As New ProveedorService(SessionID, Connection, Transaction)
                        Dim Servicio As CompraServicioInfo = ProveedorSvc.GetProveedorDefaultServicio(.IdZonaCompra, .IdServicio)
                        If Servicio IsNot Nothing Then
                            .IdProveedor = Servicio.IdProveedor
                            .CodigoProveedor = Servicio.CodigoProveedor
                            .NombreProveedor = Servicio.NombreProveedor
                            .PrecioUnitario = Servicio.Costo
                            .IdDivisa = Servicio.IdDivisa
                            .Divisa = Servicio.Divisa
                            .IdImpuesto1 = Servicio.IdImpuesto1
                            .IdImpuesto2 = Servicio.IdImpuesto2
                            .IdImpuesto3 = Servicio.IdImpuesto3
                            If .IdImpuesto1 > 0 Then .Impuesto1 = Servicio.Impuesto1
                            If .IdImpuesto2 > 0 Then .Impuesto2 = Servicio.Impuesto2
                            If .IdImpuesto3 > 0 Then .Impuesto3 = Servicio.Impuesto3
                            .IdRetencion1 = Servicio.IdRetencion1
                            .IdRetencion2 = Servicio.IdRetencion1
                            .IdRetencion3 = Servicio.IdRetencion1
                            If .IdRetencion1 > 0 Then .Retencion1 = Servicio.Retencion1
                            If .IdRetencion2 > 0 Then .Retencion2 = Servicio.Retencion2
                            If .IdRetencion3 > 0 Then .Retencion3 = Servicio.Retencion3
                        End If
                    End If
                End With
                Proveedores.AddProveedoresRow(drProveedor)
            Next
            Return Proveedores
        Catch ex As Exception
            Throw New BusinessException("Error al asignar el proveedor predeterminado a las requisiciones", ex)
        End Try
    End Function

    Public Function GenerarOrdenes(idSucursal As Integer, ordenes As GeneradorOrdenesDS) As GeneradorOrdenesDS
        Try
            For Each drOrden As GeneradorOrdenesDS.OrdenesTitRow In ordenes.OrdenesTit
                Try
                    CType(Transaction, SqlClient.SqlTransaction).Save("T" & drOrden.IdOrden.ToString)
                    Dim Orden As New OrdenInfo(SessionID)
                    With Orden
                        .Fecha = Date.Today
                        .IdProveedor = drOrden.IdProveedor
                        .IdDivisa = drOrden.IdDivisa
                        .IdDepartamento = 0
                        .IdPresupuesto = 0
                        .IdSucursal = idSucursal
                        .IdCentroRecepcion = drOrden.IdCentroRecepcion
                        .IdCentralCompras = drOrden.IdCentralCompras
                        .Origen = "G"
                        Dim vwDetalle As New DataView(ordenes.OrdenesDet, "IdOrden=" & drOrden.IdOrden.ToString, String.Empty, DataViewRowState.CurrentRows)
                        For Each drvOrdenDet As DataRowView In vwDetalle
                            Dim drOrdenDet As GeneradorOrdenesDS.OrdenesDetRow = CType(drvOrdenDet.Row, GeneradorOrdenesDS.OrdenesDetRow)
                            If drOrdenDet.IdArticuloStock > 0 Then
                                Dim drPartida As DetalleOrdenDS.ArticulosRow = Orden.Articulos.NewArticulosRow
                                With drPartida
                                    .IdArticuloStock = drOrdenDet.IdArticuloStock
                                    .Cantidad = drOrdenDet.Cantidad
                                    .Recibido = 0
                                    .IdUnidadMedida = drOrdenDet.IdUnidadMedida
                                    .IdPresupuesto = drOrdenDet.IdPresupuesto
                                    .IdCategoriaPresupuestal = drOrdenDet.IdCategoriaPresupuestal
                                    .IdRequisicion = drOrdenDet.IdRequisicion
                                    .FechaRequisicion = Azteca.Kernel.BusinessStructure.DocumentInfo.GetDocumentDate(drOrdenDet.IdRequisicion)
                                End With
                                Orden.Articulos.AddArticulosRow(drPartida)
                            ElseIf drOrdenDet.IdServicio > 0 Then
                                Dim drPartida As DetalleOrdenDS.ServiciosRow = Orden.Servicios.NewServiciosRow
                                With drPartida
                                    .IdServicio = drOrdenDet.IdServicio
                                    .Cantidad = drOrdenDet.Cantidad
                                    .Recibido = 0
                                    .IdPresupuesto = drOrdenDet.IdPresupuesto
                                    .IdCategoriaPresupuestal = drOrdenDet.IdCategoriaPresupuestal
                                    .IdRequisicion = drOrdenDet.IdRequisicion
                                    .FechaRequisicion = Azteca.Kernel.BusinessStructure.DocumentInfo.GetDocumentDate(drOrdenDet.IdRequisicion)
                                End With
                                Orden.Servicios.AddServiciosRow(drPartida)
                            End If
                        Next
                    End With
                    Dim OrdenSvc As New OrdenService(SessionID, Connection, Transaction)
                    Orden = OrdenSvc.Update(Orden)
                    OrdenSvc.ApplyWorkflow(Orden.Identity, WorkflowSteps.Apply, Date.Today)
                    drOrden.Generada = True
                Catch ex As Exception
                    CType(Transaction, SqlClient.SqlTransaction).Rollback("T" & drOrden.IdOrden.ToString)
                    drOrden.ErrorText = ex.Message
                    Azteca.Kernel.General.AppEventLog.LogException(ex)
                End Try
            Next
            Return ordenes
        Catch ex As Exception
            Throw New BusinessException("Error al generar las ordenes de compra", ex)
        End Try
    End Function

#End Region

End Class



Partial Class OrdenFacade

#Region "Metodos Generales"
    Public Function LoadList(sessionID As Guid, fechaInicial As Date, fechaFinal As Date, idUsuario As Integer, idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenService(sessionID, Connection)
            dtList = Svc.LoadList(fechaInicial, fechaFinal, idUsuario, idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadRecepciones(sessionID As Guid, idOrden As String) As DataTable
        ValidateSession(sessionID)
        Dim dtRecepciones As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenService(sessionID, Connection)
            dtRecepciones = Svc.LoadRecepciones(idOrden)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtRecepciones
    End Function

#End Region

#Region "Informes"

    Public Function LoadPrintInfo(sessionID As Guid, idOrden As String) As InformesDS.OrdenesDataTable
        ValidateSession(sessionID)
        Dim dtInfo As InformesDS.OrdenesDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenService(sessionID, Connection, Transaction)
            dtInfo = Svc.LoadPrintInfo(idOrden)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInfo
    End Function

#End Region

#Region "Generador"

    Public Function AsignarProveedores(sessionID As Guid, requisiciones As GeneradorOrdenesDS.RequisicionesDataTable) As GeneradorOrdenesDS.ProveedoresDataTable
        ValidateSession(sessionID)
        Dim Proveedores As GeneradorOrdenesDS.ProveedoresDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New OrdenService(sessionID, Connection)
            Proveedores = Svc.AsignarProveedores(requisiciones)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Proveedores
    End Function

    Public Function GenerarOrdenes(sessionID As Guid, idSucursal As Integer, ordenes As GeneradorOrdenesDS) As GeneradorOrdenesDS
        ValidateSession(sessionID)
        Dim OrdenesRet As GeneradorOrdenesDS = Nothing
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New OrdenService(sessionID, Connection, Transaction)
                OrdenesRet = Svc.GenerarOrdenes(idSucursal, ordenes)
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
        Return OrdenesRet
    End Function

#End Region

End Class