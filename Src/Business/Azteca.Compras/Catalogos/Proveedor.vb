Imports Azteca.Kernel
Imports Azteca.Business.Inventario

Partial Class ProveedorService

#Region "General"

    Public Function GetDetailFromCache(idProveedor As Integer) As ProveedorInfo
        Try
            Dim CacheKey As String = "Proveedor_" & idProveedor.ToString
            Dim Proveedor As New ProveedorInfo(SessionID)
            If Cache.Contains(CacheKey) Then
                Proveedor = CType(Cache.Item(CacheKey), ProveedorInfo)
            Else
                Dim ProveedorSvc As New ProveedorService(SessionID, Connection, Transaction)
                ProveedorSvc.GetDetail(idProveedor, Proveedor, False)
                Cache.Add(CacheKey, Proveedor, TimeSpan.FromHours(12))
            End If
            Return Proveedor
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la información del proveedor desde el caché", ex)
        End Try
    End Function

    Public Overloads Function GetDetail(ByVal idEmpresa As Integer, ByVal rfc As String) As ProveedorInfo
        Try
            FXSelect.Schema = "Purchasing"
            FXSelect.Name = "fxProveedoresSELByRFC"
            FXSelect.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            FXSelect.Parameters.Add("@RFC", DbType.String).Value = rfc
            '
            Dim Proveedor As New ProveedorInfo(SessionID)
            MyBase.GetDetail(0, Proveedor, False)
            '
            LoadInfo(Proveedor)
            Return Proveedor
        Catch ex As Exception
            Throw New BusinessException("Error al cargar información del proveedor por RFC", ex)
        End Try
    End Function

    Public Overloads Function Exists(ByVal idEmpresa As Integer, ByVal rfc As String) As Boolean
        Try
            Dim fxExists As New FunctionSQL("Purchasing", "fxProveedorExistsByRFC", Connection, Transaction)
            fxExists.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fxExists.Parameters.Add("@RFC", DbType.String).Value = rfc
            Return CBool(fxExists.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al verificar la existencia del proveedor.", ex)
        End Try
    End Function

    Public Function LoadList(ByVal idEmpresa As Integer) As DataTable
        Dim dtProveedores As DataTable
        Try
            Dim fxProveedores As New FunctionSQL("Purchasing", "fxProveedoresCBO", Connection, Transaction)
            fxProveedores.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            dtProveedores = fxProveedores.GetTable("Proveedores")
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de proveedores.", ex)
        End Try
        Return dtProveedores
    End Function

    Public Function Login(ByVal idEmpresa As Integer, ByVal codigo As String, ByVal clave As String) As Boolean
        Try
            Dim fxLogin As New FunctionSQL("Purchasing", "fxPrveedorLogin", Connection, Transaction)
            fxLogin.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fxLogin.Parameters.Add("@Codigo", DbType.String).Value = codigo
            fxLogin.Parameters.Add("@Clave", DbType.String).Value = clave
            Return CBool(fxLogin.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al iniciar sesión con el código de proveedor " & codigo, ex)
        End Try
    End Function

    Public Function GetIDByCode(codigoServicio As String, idSucursal As Integer) As Integer
        Return MyBase.CodeToID(codigoServicio, idSucursal)
    End Function

#End Region

#Region "Articulos"

    Public Function GetProveedorDefaultArticulo(idZona As Integer, idArticuloStock As Integer) As CompraArticuloInfo
        Try
            Dim fxID As New FunctionSQL("Purchasing", "fxProveedorDefaultArticulo", Connection, Transaction)
            fxID.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZona
            fxID.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            Dim IdProveedor As Integer = CInt(fxID.GetScalar)
            If IdProveedor > 0 Then
                Return CargarArticuloFromCache(idZona, IdProveedor, idArticuloStock)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el proveedor predeterminado del artículo: " & idArticuloStock.ToString, ex)
        End Try
    End Function

    Public Function CargarArticulos(idProveedor As Integer, idZona As Integer) As ProveedoresDS.ArticulosDataTable
        Try
            Dim Articulos As New ProveedoresDS.ArticulosDataTable
            Dim fxArticulos As New FunctionSQL("Purchasing", "fxProveedorArticulosList", Connection, Transaction)
            fxArticulos.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZona
            fxArticulos.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            fxArticulos.FillDataTable(Articulos)
            Return Articulos
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los artículos asignados al proveedor.", ex)
        End Try
    End Function

    Public Function CargarArticuloFromCache(idZonaCompra As Integer, idProveedor As Integer, idArticuloStock As Integer) As CompraArticuloInfo
        Try
            Dim CacheKey As String = "CompraArticulo_" & idZonaCompra.ToString & "_" & idProveedor.ToString & "_" & idArticuloStock.ToString
            Dim Info As New CompraArticuloInfo
            If Not Cache.Contains(CacheKey) Then
                Dim Svc As New ProveedorService(SessionID, Connection, Transaction)
                Info = Svc.CargarArticulo(idZonaCompra, idProveedor, idArticuloStock)
                Cache.Add(CacheKey, Info, TimeSpan.FromDays(1))
            Else
                Info = CType(Cache.Item(CacheKey), CompraArticuloInfo)
            End If
            Return Info
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de compra del artículo: " & idArticuloStock.ToString & " desde el caché", ex)
        End Try
    End Function


    Public Function CargarArticulo(idZonaCompra As Integer, idProveedor As Integer, idArticuloStock As Integer) As CompraArticuloInfo
        Try
            Dim fxArticulo As New FunctionSQL("Purchasing", "fxProveedorArticuloSEL", Connection, Transaction)
            fxArticulo.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            fxArticulo.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            fxArticulo.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            Dim dtArticulo As DataTable = fxArticulo.GetTable("Info")
            If dtArticulo.Rows.Count > 0 Then
                Dim drArticulo As DataRow = dtArticulo.Rows(0)
                Dim Info As New CompraArticuloInfo
                With Info
                    .IdZonaCompra = idZonaCompra
                    .IdProveedor = idProveedor
                    .IdArticuloStock = idArticuloStock
                    .Costo = CDec(drArticulo("Costo"))
                    .IdDivisa = CInt(drArticulo("IdDivisa"))
                    .IdUnidadMedida = CInt(drArticulo("IdUnidadMedida"))
                    .DiasEntrega = CInt(drArticulo("DiasEntrega"))
                    .DiasCredito = CInt(drArticulo("DiasCredito"))
                    .IdImpuesto1 = CInt(drArticulo("IdImpuesto1"))
                    .IdImpuesto2 = CInt(drArticulo("IdImpuesto2"))
                    .IdImpuesto3 = CInt(drArticulo("IdImpuesto3"))
                    .IdRetencion1 = CInt(drArticulo("IdRetencion1"))
                    .IdRetencion2 = CInt(drArticulo("IdRetencion2"))
                    .IdRetencion3 = CInt(drArticulo("IdRetencion3"))
                    .PorcentajeDescuento1 = CDec(drArticulo("PorcDescuento1"))
                    .PorcentajeDescuento2 = CDec(drArticulo("PorcDescuento2"))
                    .PorcentajeDescuento3 = CDec(drArticulo("PorcDescuento3"))
                    .Predeterminado = CBool(drArticulo("Predeterminado"))
                    .Codigo = drArticulo("Codigo").ToString
                    .Nombre = drArticulo("Nombre").ToString
                    .UnidadMedida = drArticulo("UnidadMedida").ToString
                    .IdTipoUnidadMedida = CInt(drArticulo("IdUnidadMedidaTipo"))
                    .CodigoProveedor = drArticulo("CodigoProveedor").ToString
                    .NombreProveedor = drArticulo("NombreProveedor").ToString
                    .Divisa = drArticulo("Divisa").ToString
                    .ZonaCompra = drArticulo("ZonaCompra").ToString
                    .Impuesto1 = drArticulo("Impuesto1").ToString
                    .Impuesto2 = drArticulo("Impuesto2").ToString
                    .Impuesto3 = drArticulo("Impuesto3").ToString
                    .Retencion1 = drArticulo("Retencion1").ToString
                    .Retencion2 = drArticulo("Retencion2").ToString
                    .Retencion3 = drArticulo("Retencion3").ToString
                End With
                Return Info
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de compra del artículo", ex)
        End Try
    End Function

    Public Sub GuardarArticulo(articulo As CompraArticuloInfo)
        Try
            Dim spUpdate As New StoredProcedure("Purchasing", "ProveedorArticuloUPD", Connection, Transaction)
            With articulo
                spUpdate.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = .IdZonaCompra
                spUpdate.Parameters.Add("@IdProveedor", DbType.Int32).Value = .IdProveedor
                spUpdate.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = .IdArticuloStock
                spUpdate.Parameters.Add("@Costo", DbType.Decimal).Value = .Costo
                spUpdate.Parameters.Add("@IdDivisa", DbType.Int32).Value = .IdDivisa
                spUpdate.Parameters.Add("@IdUnidadMedida", DbType.Int32).Value = .IdUnidadMedida
                spUpdate.Parameters.Add("@DiasCredito", DbType.Int32).Value = .DiasCredito
                spUpdate.Parameters.Add("@DiasEntrega", DbType.Int32).Value = .DiasEntrega
                spUpdate.Parameters.Add("@IdImpuesto1", DbType.Int32).Value = .IdImpuesto1
                spUpdate.Parameters.Add("@IdImpuesto2", DbType.Int32).Value = .IdImpuesto2
                spUpdate.Parameters.Add("@IdImpuesto3", DbType.Int32).Value = .IdImpuesto3
                spUpdate.Parameters.Add("@IdRetencion1", DbType.Int32).Value = .IdRetencion1
                spUpdate.Parameters.Add("@IdRetencion2", DbType.Int32).Value = .IdRetencion2
                spUpdate.Parameters.Add("@IdRetencion3", DbType.Int32).Value = .IdRetencion3
                spUpdate.Parameters.Add("@PorcDescuento1", DbType.Decimal).Value = .PorcentajeDescuento1
                spUpdate.Parameters.Add("@PorcDescuento2", DbType.Decimal).Value = .PorcentajeDescuento2
                spUpdate.Parameters.Add("@PorcDescuento3", DbType.Decimal).Value = .PorcentajeDescuento3
                spUpdate.Parameters.Add("@Predeterminado", DbType.Boolean).Value = .Predeterminado
                spUpdate.Execute()
                '
                Cache.Remove("CompraArticulo_" & .IdZonaCompra.ToString & "_" & .IdProveedor.ToString & "_" & .IdArticuloStock.ToString)
            End With
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la información de compra del artículo", ex)
        End Try
    End Sub

    Public Sub EliminarArticulo(idZonaCompra As Integer, idProveedor As Integer, idArticuloStock As Integer)
        Try
            Dim spDelete As New StoredProcedure("Purchasing", "ProveedorArticuloDEL", Connection, Transaction)
            spDelete.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            spDelete.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            spDelete.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            spDelete.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al eliminar el artículo del proveedor.", ex)
        End Try
    End Sub

    Public Function LoadListByArticulo(idZonaCompra As Integer, idArticuloStock As Integer) As ArticulosDS.ProveedoresDataTable
        Try
            Dim fxProveedores As New FunctionSQL("Purchasing", "fxArticuloProveedoresList", Connection, Transaction)
            fxProveedores.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            fxProveedores.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            Dim Proveedores As New ArticulosDS.ProveedoresDataTable
            fxProveedores.FillDataTable(Proveedores)
            Return Proveedores
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de proveedores del artículo: " & idArticuloStock, ex)
        End Try
    End Function

    Public Sub SetArticuloDefault(idZonaCompra As Integer, idProveedor As Integer, idArticuloStock As Integer)
        Try
            Dim spDefault As New StoredProcedure("Purchasing", "ProveedorArticuloDefault", Connection, Transaction)
            spDefault.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            spDefault.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            spDefault.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            spDefault.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al establecer el proveedor predeterminado del artículo " & idArticuloStock, ex)
        End Try
    End Sub

    Public Function VendeArticulo(idZonaCompra As Integer, idProveedor As Integer, idArticuloStock As Integer) As Boolean
        Try
            Dim fxExists As New FunctionSQL("Purchasing", "fxProveedorArticuloExists", Connection, Transaction)
            fxExists.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            fxExists.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            fxExists.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            Return CBool(fxExists.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al verificar la relación del artículo " & idArticuloStock.ToString & " para el proveedor " & idProveedor.ToString, ex)
        End Try
    End Function

    Public Function GetCostoArticulo(idZonaCompra As Integer, idProveedor As Integer, idArticuloStock As Integer) As CostoInfo
        Try
            Dim fxCosto As New FunctionSQL("Purchasing", "fxPrecioArticuloProveedor", Connection, Transaction)
            fxCosto.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            fxCosto.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            fxCosto.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            '
            Dim dtCosto As DataTable = fxCosto.GetTable("Costos")
            Dim drCosto As DataRow = dtCosto.Rows(0)
            'Cargar información de precio en clase especial
            Dim Costo As New CostoInfo()
            With Costo
                .Costo = CDec(drCosto("Costo"))
                .IdDivisa = CInt(drCosto("IdDivisa"))
                .TipoCambio = CDec(drCosto("TipoCambio"))
                'IMPUESTOS
                .IdImpuesto1 = CInt(drCosto("IdImpuesto1"))
                .IdImpuesto2 = CInt(drCosto("IdImpuesto2"))
                .IdImpuesto3 = CInt(drCosto("IdImpuesto3"))
                .IdImpuesto4 = CInt(drCosto("IdImpuesto4"))
                .IdImpuesto5 = CInt(drCosto("IdImpuesto5"))
                .PorcentajeImpuesto1 = CDec(drCosto("PorcImpuesto1"))
                .PorcentajeImpuesto2 = CDec(drCosto("PorcImpuesto2"))
                .PorcentajeImpuesto3 = CDec(drCosto("PorcImpuesto3"))
                .PorcentajeImpuesto4 = CDec(drCosto("PorcImpuesto4"))
                .PorcentajeImpuesto5 = CDec(drCosto("PorcImpuesto5"))
                .MontoImpuesto1 = CDec(drCosto("MontoImpuesto1"))
                .MontoImpuesto2 = CDec(drCosto("MontoImpuesto2"))
                .MontoImpuesto3 = CDec(drCosto("MontoImpuesto3"))
                .MontoImpuesto4 = CDec(drCosto("MontoImpuesto4"))
                .MontoImpuesto5 = CDec(drCosto("MontoImpuesto5"))
                'RETENCIONES
                .IdRetencion1 = CInt(drCosto("IdRetencion1"))
                .IdRetencion2 = CInt(drCosto("IdRetencion2"))
                .IdRetencion3 = CInt(drCosto("IdRetencion3"))
                .IdRetencion4 = CInt(drCosto("IdRetencion4"))
                .IdRetencion5 = CInt(drCosto("IdRetencion5"))
                .PorcentajeRetencion1 = CDec(drCosto("PorcRetencion1"))
                .PorcentajeRetencion2 = CDec(drCosto("PorcRetencion2"))
                .PorcentajeRetencion3 = CDec(drCosto("PorcRetencion3"))
                .PorcentajeRetencion4 = CDec(drCosto("PorcRetencion4"))
                .PorcentajeRetencion5 = CDec(drCosto("PorcRetencion5"))
                .MontoRetencion1 = CDec(drCosto("MontoRetencion1"))
                .MontoRetencion2 = CDec(drCosto("MontoRetencion2"))
                .MontoRetencion3 = CDec(drCosto("MontoRetencion3"))
                .MontoRetencion4 = CDec(drCosto("MontoRetencion4"))
                .MontoRetencion5 = CDec(drCosto("MontoRetencion5"))
                'DESCUENTOS
                .PorcentajeDescuento1 = CDec(drCosto("PorcDescuento1"))
                .PorcentajeDescuento2 = CDec(drCosto("PorcDescuento2"))
                .PorcentajeDescuento3 = CDec(drCosto("PorcDescuento3"))
                .PorcentajeDescuento4 = CDec(drCosto("PorcDescuento4"))
                .PorcentajeDescuento5 = CDec(drCosto("PorcDescuento5"))
                .MontoDescuento1 = CDec(drCosto("MontoDescuento1"))
                .MontoDescuento2 = CDec(drCosto("MontoDescuento2"))
                .MontoDescuento3 = CDec(drCosto("MontoDescuento3"))
                .MontoDescuento4 = CDec(drCosto("MontoDescuento4"))
                .MontoDescuento5 = CDec(drCosto("MontoDescuento5"))
            End With
            Return Costo
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de precio del artículo: " & idArticuloStock.ToString, ex)
        End Try
    End Function

#End Region

#Region "Servicios"

    Public Function GetProveedorDefaultServicio(idZonaCompra As Integer, idServicio As Integer) As CompraServicioInfo
        Try
            Dim fxID As New FunctionSQL("Purchasing", "fxProveedorDefaultServicio", Connection, Transaction)
            fxID.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            fxID.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idServicio
            Dim IdProveedor As Integer = CInt(fxID.GetScalar)
            If IdProveedor > 0 Then
                Return CargarServicioFromCache(idZonaCompra, IdProveedor, idServicio)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el proveedor predeterminado del servicio: " & idServicio.ToString, ex)
        End Try
    End Function

    Public Function LoadListByServicio(idZonaCompra As Integer, idServicio As Integer) As ServiciosDS.ProveedoresDataTable
        Try
            Dim fxProveedores As New FunctionSQL("Purchasing", "fxServicioProveedoresList", Connection, Transaction)
            fxProveedores.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            fxProveedores.Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
            Dim Proveedores As New ServiciosDS.ProveedoresDataTable
            fxProveedores.FillDataTable(Proveedores)
            Return Proveedores
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de proveedores del servicio: " & idServicio, ex)
        End Try
    End Function

    Public Function CargarServicioFromCache(idZonaCompra As Integer, idProveedor As Integer, idServicio As Integer) As CompraServicioInfo
        Try
            Dim Info As New CompraServicioInfo()
            Dim CacheKey As String = "CompraServicio_" & idServicio.ToString & "_" & idProveedor.ToString & "_" & idZonaCompra.ToString
            If Not Cache.Contains(CacheKey) Then
                Dim Svc As New ProveedorService(SessionID, Connection, Transaction)
                Info = Svc.CargarServicio(idZonaCompra, idProveedor, idServicio)
                Cache.Add(CacheKey, Info, TimeSpan.FromDays(1))
            Else
                Info = CType(Cache.Item(CacheKey), CompraServicioInfo)
            End If
            Return Info
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de compra del servicio: " & idServicio.ToString & " desde el caché.", ex)
        End Try
    End Function


    Public Function CargarServicio(idZonaCompra As Integer, idProveedor As Integer, idServicio As Integer) As CompraServicioInfo
        Try
            Dim fxServicio As New FunctionSQL("Purchasing", "fxProveedorServicioSEL", Connection, Transaction)
            fxServicio.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            fxServicio.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            fxServicio.Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
            Dim dtServicio As DataTable = fxServicio.GetTable("Info")
            If dtServicio.Rows.Count > 0 Then
                Dim drServicio As DataRow = dtServicio.Rows(0)
                Dim Info As New CompraServicioInfo
                With Info
                    .IdZonaCompra = idZonaCompra
                    .IdProveedor = idProveedor
                    .IdServicio = idServicio
                    .Costo = CDec(drServicio("Costo"))
                    .IdDivisa = CInt(drServicio("IdDivisa"))
                    .DiasEntrega = CInt(drServicio("DiasEntrega"))
                    .DiasCredito = CInt(drServicio("DiasCredito"))
                    .IdImpuesto1 = CInt(drServicio("IdImpuesto1"))
                    .IdImpuesto2 = CInt(drServicio("IdImpuesto2"))
                    .IdImpuesto3 = CInt(drServicio("IdImpuesto3"))
                    .IdRetencion1 = CInt(drServicio("IdRetencion1"))
                    .IdRetencion2 = CInt(drServicio("IdRetencion2"))
                    .IdRetencion3 = CInt(drServicio("IdRetencion3"))
                    .PorcentajeDescuento1 = CDec(drServicio("PorcDescuento1"))
                    .PorcentajeDescuento2 = CDec(drServicio("PorcDescuento2"))
                    .PorcentajeDescuento3 = CDec(drServicio("PorcDescuento3"))
                    .Predeterminado = CBool(drServicio("Predeterminado"))
                    .Codigo = drServicio("Codigo").ToString
                    .Nombre = drServicio("Nombre").ToString
                    .CodigoProveedor = drServicio("CodigoProveedor").ToString
                    .NombreProveedor = drServicio("NombreProveedor").ToString
                    .Divisa = drServicio("Divisa").ToString
                    .ZonaCompra = drServicio("ZonaCompra").ToString
                    .Impuesto1 = drServicio("Impuesto1").ToString
                    .Impuesto2 = drServicio("Impuesto2").ToString
                    .Impuesto3 = drServicio("Impuesto3").ToString
                    .Retencion1 = drServicio("Retencion1").ToString
                    .Retencion2 = drServicio("Retencion2").ToString
                    .Retencion3 = drServicio("Retencion3").ToString
                End With
                Return Info
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de compra del servicio " & idServicio.ToString, ex)
        End Try
    End Function

    Public Function CargarServicios(idProveedor As Integer, idZona As Integer) As ProveedoresDS.ServiciosDataTable
        Try
            Dim Servicios As New ProveedoresDS.ServiciosDataTable
            Dim fxServicios As New FunctionSQL("Purchasing", "fxProveedorServiciosList", Connection, Transaction)
            fxServicios.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZona
            fxServicios.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            fxServicios.FillDataTable(Servicios)
            Return Servicios
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los servicios asignados al proveedor.", ex)
        End Try
    End Function

    Public Sub GuardarServicio(servicio As CompraServicioInfo)
        Try
            Dim spUpdate As New StoredProcedure("Purchasing", "ProveedorServicioUPD", Connection, Transaction)
            With servicio
                spUpdate.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = .IdZonaCompra
                spUpdate.Parameters.Add("@IdProveedor", DbType.Int32).Value = .IdProveedor
                spUpdate.Parameters.Add("@IdServicio", DbType.Int32).Value = .IdServicio
                spUpdate.Parameters.Add("@Costo", DbType.Decimal).Value = .Costo
                spUpdate.Parameters.Add("@IdDivisa", DbType.Int32).Value = .IdDivisa
                spUpdate.Parameters.Add("@DiasCredito", DbType.Int32).Value = .DiasCredito
                spUpdate.Parameters.Add("@DiasEntrega", DbType.Int32).Value = .DiasEntrega
                spUpdate.Parameters.Add("@IdImpuesto1", DbType.Int32).Value = .IdImpuesto1
                spUpdate.Parameters.Add("@IdImpuesto2", DbType.Int32).Value = .IdImpuesto2
                spUpdate.Parameters.Add("@IdImpuesto3", DbType.Int32).Value = .IdImpuesto3
                spUpdate.Parameters.Add("@IdRetencion1", DbType.Int32).Value = .IdRetencion1
                spUpdate.Parameters.Add("@IdRetencion2", DbType.Int32).Value = .IdRetencion2
                spUpdate.Parameters.Add("@IdRetencion3", DbType.Int32).Value = .IdRetencion3
                spUpdate.Parameters.Add("@PorcDescuento1", DbType.Decimal).Value = .PorcentajeDescuento1
                spUpdate.Parameters.Add("@PorcDescuento2", DbType.Decimal).Value = .PorcentajeDescuento2
                spUpdate.Parameters.Add("@PorcDescuento3", DbType.Decimal).Value = .PorcentajeDescuento3
                spUpdate.Parameters.Add("@Predeterminado", DbType.Boolean).Value = .Predeterminado
                spUpdate.Execute()
                '
                Cache.Remove("CompraServicio_" & .IdServicio.ToString & "_" & .IdProveedor.ToString & "_" & .IdZonaCompra.ToString)
            End With
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la información de compra del servicio", ex)
        End Try
    End Sub

    Public Sub EliminarServicio(idZonaCompra As Integer, idProveedor As Integer, idServicio As Integer)
        Try
            Dim spDelete As New StoredProcedure("Purchasing", "ProveedorServicioDEL", Connection, Transaction)
            spDelete.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            spDelete.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            spDelete.Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
            spDelete.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al eliminar la información de compra de servicio del proveedor", ex)
        End Try
    End Sub

    Public Sub SetServicioDefault(idZonaCompra As Integer, idProveedor As Integer, idServicio As Integer)
        Try
            Dim spDefault As New StoredProcedure("Purchasing", "ProveedorServicioDefault", Connection, Transaction)
            spDefault.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            spDefault.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            spDefault.Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
            spDefault.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al establecer el proveedor predeterminado del servicio: " & idServicio.ToString, ex)
        End Try
    End Sub

    Public Function VendeServicio(idZonaCompra As Integer, idProveedor As Integer, idServicio As Integer) As Boolean
        Try
            Dim fxExists As New FunctionSQL("Purchasing", "fxProveedorServicioExists", Connection, Transaction)
            fxExists.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            fxExists.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            fxExists.Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
            Return CBool(fxExists.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al verificar la relación del servicio " & idServicio.ToString & " para el proveedor " & idProveedor.ToString, ex)
        End Try
    End Function

    Public Function GetCostoServicio(idZonaCompra As Integer, idProveedor As Integer, idServicio As Integer) As CostoInfo
        Try
            Dim fxCosto As New FunctionSQL("Purchasing", "fxPrecioServicioProveedor", Connection, Transaction)
            fxCosto.Parameters.Add("@IdZonaCompra", DbType.Int32).Value = idZonaCompra
            fxCosto.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            fxCosto.Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
            '
            Dim dtCosto As DataTable = fxCosto.GetTable("Costos")
            Dim drCosto As DataRow = dtCosto.Rows(0)
            'Cargar información de precio en clase especial
            Dim Costo As New CostoInfo()
            With Costo
                .Costo = CDec(drCosto("Costo"))
                .IdDivisa = CInt(drCosto("IdDivisa"))
                .TipoCambio = CDec(drCosto("TipoCambio"))
                'IMPUESTOS
                .IdImpuesto1 = CInt(drCosto("IdImpuesto1"))
                .IdImpuesto2 = CInt(drCosto("IdImpuesto2"))
                .IdImpuesto3 = CInt(drCosto("IdImpuesto3"))
                .IdImpuesto4 = CInt(drCosto("IdImpuesto4"))
                .IdImpuesto5 = CInt(drCosto("IdImpuesto5"))
                .PorcentajeImpuesto1 = CDec(drCosto("PorcImpuesto1"))
                .PorcentajeImpuesto2 = CDec(drCosto("PorcImpuesto2"))
                .PorcentajeImpuesto3 = CDec(drCosto("PorcImpuesto3"))
                .PorcentajeImpuesto4 = CDec(drCosto("PorcImpuesto4"))
                .PorcentajeImpuesto5 = CDec(drCosto("PorcImpuesto5"))
                .MontoImpuesto1 = CDec(drCosto("MontoImpuesto1"))
                .MontoImpuesto2 = CDec(drCosto("MontoImpuesto2"))
                .MontoImpuesto3 = CDec(drCosto("MontoImpuesto3"))
                .MontoImpuesto4 = CDec(drCosto("MontoImpuesto4"))
                .MontoImpuesto5 = CDec(drCosto("MontoImpuesto5"))
                'RETENCIONES
                .IdRetencion1 = CInt(drCosto("IdRetencion1"))
                .IdRetencion2 = CInt(drCosto("IdRetencion2"))
                .IdRetencion3 = CInt(drCosto("IdRetencion3"))
                .IdRetencion4 = CInt(drCosto("IdRetencion4"))
                .IdRetencion5 = CInt(drCosto("IdRetencion5"))
                .PorcentajeRetencion1 = CDec(drCosto("PorcRetencion1"))
                .PorcentajeRetencion2 = CDec(drCosto("PorcRetencion2"))
                .PorcentajeRetencion3 = CDec(drCosto("PorcRetencion3"))
                .PorcentajeRetencion4 = CDec(drCosto("PorcRetencion4"))
                .PorcentajeRetencion5 = CDec(drCosto("PorcRetencion5"))
                .MontoRetencion1 = CDec(drCosto("MontoRetencion1"))
                .MontoRetencion2 = CDec(drCosto("MontoRetencion2"))
                .MontoRetencion3 = CDec(drCosto("MontoRetencion3"))
                .MontoRetencion4 = CDec(drCosto("MontoRetencion4"))
                .MontoRetencion5 = CDec(drCosto("MontoRetencion5"))
                'DESCUENTOS
                .PorcentajeDescuento1 = CDec(drCosto("PorcDescuento1"))
                .PorcentajeDescuento2 = CDec(drCosto("PorcDescuento2"))
                .PorcentajeDescuento3 = CDec(drCosto("PorcDescuento3"))
                .PorcentajeDescuento4 = CDec(drCosto("PorcDescuento4"))
                .PorcentajeDescuento5 = CDec(drCosto("PorcDescuento5"))
                .MontoDescuento1 = CDec(drCosto("MontoDescuento1"))
                .MontoDescuento2 = CDec(drCosto("MontoDescuento2"))
                .MontoDescuento3 = CDec(drCosto("MontoDescuento3"))
                .MontoDescuento4 = CDec(drCosto("MontoDescuento4"))
                .MontoDescuento5 = CDec(drCosto("MontoDescuento5"))
            End With
            Return Costo
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de precio del servicio: " & idServicio.ToString, ex)
        End Try
    End Function


#End Region

#Region "Zonas"

#End Region

End Class


Partial Class ProveedorFacade

#Region "General"

    Public Function LoadList(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtProveedores As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection)
            dtProveedores = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtProveedores
    End Function


    Public Function Login(ByVal idEmpresa As Integer, ByVal codigo As String, ByVal clave As String) As Boolean
        Dim LogedIn As Boolean = False
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(Nothing, Connection)
            LogedIn = Svc.Login(idEmpresa, codigo, clave)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return LogedIn
    End Function

    Public Function GetIDByCode(codigoServicio As String, idSucursal As Integer) As Integer
        Dim IdProveedor As Integer
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(Nothing, Connection)
            IdProveedor = Svc.GetIDByCode(codigoServicio, idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return IdProveedor
    End Function

#End Region

#Region "Articulos"

    Public Function CargarArticulos(sessionID As Guid, idProveedor As Integer, idZona As Integer) As ProveedoresDS.ArticulosDataTable
        ValidateSession(sessionID)
        Dim Articulos As ProveedoresDS.ArticulosDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Articulos = Svc.CargarArticulos(idProveedor, idZona)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Articulos
    End Function

    Public Function CargarArticuloFromCache(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, idArticuloStock As Integer) As CompraArticuloInfo
        ValidateSession(sessionID)
        Dim Info As CompraArticuloInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Info = Svc.CargarArticuloFromCache(idZonaCompra, idProveedor, idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Info
    End Function

    Public Function CargarArticuloFromCache(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, codigoArticulo As String, idSucursal As Integer) As CompraArticuloInfo
        ValidateSession(sessionID)
        Dim Info As CompraArticuloInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim ArticuloSvc As New ArticuloStockService(sessionID, Connection, Transaction)
            Dim IdArticuloStock As Integer = ArticuloSvc.CodeToID(codigoArticulo, idSucursal)
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Info = Svc.CargarArticuloFromCache(idZonaCompra, idProveedor, IdArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Info
    End Function


    Public Function CargarArticulo(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, idArticuloStock As Integer) As CompraArticuloInfo
        ValidateSession(sessionID)
        Dim Info As CompraArticuloInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Info = Svc.CargarArticulo(idZonaCompra, idProveedor, idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Info
    End Function

    Public Sub GuardarArticulo(sessionID As Guid, articulo As CompraArticuloInfo)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
                Svc.GuardarArticulo(articulo)
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

    Public Sub EliminarArticulo(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, idArticuloStock As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
                Svc.EliminarArticulo(idZonaCompra, idProveedor, idArticuloStock)
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

    Public Function LoadListByArticulo(sessionID As Guid, idZonaCompra As Integer, idArticuloStock As Integer) As ArticulosDS.ProveedoresDataTable
        ValidateSession(sessionID)
        Dim Proveedores As ArticulosDS.ProveedoresDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Proveedores = Svc.LoadListByArticulo(idZonaCompra, idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Proveedores
    End Function

    Public Sub SetArticuloDefault(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, idArticuloStock As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
                Svc.SetArticuloDefault(idZonaCompra, idProveedor, idArticuloStock)
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

    Public Function VendeArticulo(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, idArticuloStock As Integer) As Boolean
        ValidateSession(sessionID)
        Dim Resultado As Boolean = False
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Resultado = Svc.VendeArticulo(idZonaCompra, idProveedor, idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Resultado
    End Function

    Public Function GetCostoArticulo(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, idArticuloStock As Integer) As CostoInfo
        ValidateSession(sessionID)
        Dim Costo As New CostoInfo
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Costo = Svc.GetCostoArticulo(idZonaCompra, idProveedor, idArticuloStock)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Costo
    End Function

#End Region

#Region "Servicios"

    Public Function LoadListByServicio(sessionID As Guid, idZonaCompra As Integer, idServicio As Integer) As ServiciosDS.ProveedoresDataTable
        ValidateSession(sessionID)
        Dim Proveedores As ServiciosDS.ProveedoresDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Proveedores = Svc.LoadListByServicio(idZonaCompra, idServicio)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Proveedores
    End Function


    Public Function CargarServicios(sessionID As Guid, idProveedor As Integer, idZona As Integer) As ProveedoresDS.ServiciosDataTable
        ValidateSession(sessionID)
        Dim Servicios As ProveedoresDS.ServiciosDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Servicios = Svc.CargarServicios(idProveedor, idZona)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Servicios
    End Function

    Public Function CargarServicioFromCache(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, codigoServicio As String, idSucursal As Integer) As CompraServicioInfo
        ValidateSession(sessionID)
        Dim Info As CompraServicioInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim ServicioSvc As New ServicioService(sessionID, Connection, Transaction)
            Dim IdServicio As Integer = ServicioSvc.GetIdByCode(codigoServicio, idSucursal)
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Info = Svc.CargarServicioFromCache(idZonaCompra, idProveedor, IdServicio)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Info
    End Function


    Public Function CargarServicioFromCache(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, idServicio As Integer) As CompraServicioInfo
        ValidateSession(sessionID)
        Dim Info As CompraServicioInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Info = Svc.CargarServicioFromCache(idZonaCompra, idProveedor, idServicio)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Info
    End Function


    Public Function CargarServicio(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, idServicio As Integer) As CompraServicioInfo
        ValidateSession(sessionID)
        Dim Info As CompraServicioInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Info = Svc.CargarServicio(idZonaCompra, idProveedor, idServicio)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Info
    End Function

    Public Sub GuardarServicio(sessionID As Guid, servicio As CompraServicioInfo)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
                Svc.GuardarServicio(servicio)
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

    Public Sub EliminarServicio(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, idServicio As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
                Svc.EliminarServicio(idZonaCompra, idProveedor, idServicio)
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


    Public Sub SetServicioDefault(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, idServicio As Integer)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
                Svc.SetServicioDefault(idZonaCompra, idProveedor, idServicio)
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

    Public Function VendeServicio(sessionID As Guid, idProveedor As Integer, idZonaCompra As Integer, idServicio As Integer) As Boolean
        ValidateSession(sessionID)
        Dim Resultado As Boolean = False
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Resultado = Svc.VendeServicio(idProveedor, idZonaCompra, idServicio)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Resultado
    End Function

    Public Function GetCostoServicio(sessionID As Guid, idZonaCompra As Integer, idProveedor As Integer, idServicio As Integer) As CostoInfo
        ValidateSession(sessionID)
        Dim Costo As New CostoInfo
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProveedorService(sessionID, Connection, Transaction)
            Costo = Svc.GetCostoServicio(idZonaCompra, idProveedor, idServicio)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Costo
    End Function

#End Region

#Region "Zonas"

#End Region

End Class