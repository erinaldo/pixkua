Partial Class ServicioService

#Region "Metodos Generales"

    Public Function GetIdByCode(ByVal codigo As String, ByVal idSucursal As Integer) As Integer
        Return CodeToID(codigo, idSucursal)
    End Function

    Public Function GetDetailFromCache(ByVal idServicio As Integer) As ServicioInfo
        Dim CacheKey As String = "ServicioVenta" & idServicio.ToString
        Try
            Dim ServicioInf As New ServicioInfo(SessionID)
            If Azteca.Kernel.Cache.Item(CacheKey) Is Nothing Then
                Dim ServicioSvc As New ServicioService(SessionID, Connection, Transaction)
                ServicioSvc.GetDetail(idServicio, ServicioInf, False)
                Azteca.Kernel.Cache.Add(CacheKey, ServicioInf, TimeSpan.FromDays(1))
            Else
                ServicioInf = CType(Azteca.Kernel.Cache.Item(CacheKey), ServicioInfo)
            End If
            Return ServicioInf
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el servicio desde el caché de sistema.", ex)
        End Try
    End Function

    Public Function GetDetailFromCache(ByVal codigo As String, ByVal idSucursal As Integer) As ServicioInfo
        Try
            Dim IdServicio As Integer = GetIdByCode(codigo, idSucursal)
            Return GetDetailFromCache(IdServicio)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el servicio desde el caché de sistema.", ex)
        End Try
    End Function

#End Region

#Region "Precios"

    Public Function GetPrecio(ByVal idServicio As Integer, ByVal idCliente As Integer, ByVal idSucursal As Integer) As PrecioInfo
        Return GetPrecio(idServicio, idCliente, idSucursal, 0)
    End Function


    Public Function GetPrecio(ByVal idServicio As Integer, ByVal idCliente As Integer, ByVal idSucursal As Integer, ByVal precioFijo As Decimal) As PrecioInfo
        Try
            'Obtener la información de precio del articulo especificado
            Dim fxPrecio As New FunctionSQL("Sales", "fxPrecioServicioCliente", Connection, Transaction)
            fxPrecio.Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
            fxPrecio.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxPrecio.Parameters.Add("@IdCliente", DbType.Int32).Value = idCliente
            fxPrecio.Parameters.Add("@PrecioFijo", DbType.Decimal).Value = precioFijo
            Dim dtPrecio As DataTable = fxPrecio.GetTable("Precios")
            Dim drPrecio As DataRow = dtPrecio.Rows(0)
            'Cargar información de precio en clase especial
            Dim Precio As New PrecioInfo()
            With Precio
                .Precio = CDec(drPrecio("Precio"))
                .IdDivisa = CInt(drPrecio("IdDivisa"))
                .TipoCambio = CDec(drPrecio("TipoCambio"))
                'IMPUESTOS
                .IdImpuesto1 = CInt(drPrecio("IdImpuesto1"))
                .IdImpuesto2 = CInt(drPrecio("IdImpuesto2"))
                .IdImpuesto3 = CInt(drPrecio("IdImpuesto3"))
                .IdImpuesto4 = CInt(drPrecio("IdImpuesto4"))
                .IdImpuesto5 = CInt(drPrecio("IdImpuesto5"))
                .PorcentajeImpuesto1 = CDec(drPrecio("PorcImpuesto1"))
                .PorcentajeImpuesto2 = CDec(drPrecio("PorcImpuesto2"))
                .PorcentajeImpuesto3 = CDec(drPrecio("PorcImpuesto3"))
                .PorcentajeImpuesto4 = CDec(drPrecio("PorcImpuesto4"))
                .PorcentajeImpuesto5 = CDec(drPrecio("PorcImpuesto5"))
                .MontoImpuesto1 = CDec(drPrecio("MontoImpuesto1"))
                .MontoImpuesto2 = CDec(drPrecio("MontoImpuesto2"))
                .MontoImpuesto3 = CDec(drPrecio("MontoImpuesto3"))
                .MontoImpuesto4 = CDec(drPrecio("MontoImpuesto4"))
                .MontoImpuesto5 = CDec(drPrecio("MontoImpuesto5"))
                'RETENCIONES
                .PorcentajeRetencion1 = CDec(drPrecio("PorcRetencion1"))
                .PorcentajeRetencion2 = CDec(drPrecio("PorcRetencion2"))
                .PorcentajeRetencion3 = CDec(drPrecio("PorcRetencion3"))
                .PorcentajeRetencion4 = CDec(drPrecio("PorcRetencion4"))
                .PorcentajeRetencion5 = CDec(drPrecio("PorcRetencion5"))
                .MontoRetencion1 = CDec(drPrecio("MontoRetencion1"))
                .MontoRetencion2 = CDec(drPrecio("MontoRetencion2"))
                .MontoRetencion3 = CDec(drPrecio("MontoRetencion3"))
                .MontoRetencion4 = CDec(drPrecio("MontoRetencion4"))
                .MontoRetencion5 = CDec(drPrecio("MontoRetencion5"))
                'DESCUENTOS
                .PorcentajeDescuento1 = CDec(drPrecio("PorcDescuento1"))
                .PorcentajeDescuento2 = CDec(drPrecio("PorcDescuento2"))
                .PorcentajeDescuento3 = CDec(drPrecio("PorcDescuento3"))
                .PorcentajeDescuento4 = CDec(drPrecio("PorcDescuento4"))
                .PorcentajeDescuento5 = CDec(drPrecio("PorcDescuento5"))
                .MontoDescuento1 = CDec(drPrecio("MontoDescuento1"))
                .MontoDescuento2 = CDec(drPrecio("MontoDescuento2"))
                .MontoDescuento3 = CDec(drPrecio("MontoDescuento3"))
                .MontoDescuento4 = CDec(drPrecio("MontoDescuento4"))
                .MontoDescuento5 = CDec(drPrecio("MontoDescuento5"))
            End With
            Return Precio
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la información de precios del servicio.", ex)
        End Try
    End Function

    Public Function GetPrecio(ByVal idServicio As Integer, ByVal idZonaVenta As Integer) As PrecioInfo
        Try
            'Obtener la información de precio del articulo especificado
            Dim fxPrecio As New FunctionSQL("Sales", "fxPrecioServicioZona", Connection, Transaction)
            fxPrecio.Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
            fxPrecio.Parameters.Add("@IdZonaVenta", DbType.Int32).Value = idZonaVenta            
            fxPrecio.Parameters.Add("@PrecioFijo", DbType.Decimal).Value = 0D
            Dim dtPrecio As DataTable = fxPrecio.GetTable("Precios")
            Dim drPrecio As DataRow = dtPrecio.Rows(0)
            'Cargar información de precio en clase especial
            Dim Precio As New PrecioInfo()
            With Precio
                .Precio = CDec(drPrecio("Precio"))
                .IdDivisa = CInt(drPrecio("IdDivisa"))
                .TipoCambio = CDec(drPrecio("TipoCambio"))
                'IMPUESTOS
                .IdImpuesto1 = CInt(drPrecio("IdImpuesto1"))
                .IdImpuesto2 = CInt(drPrecio("IdImpuesto2"))
                .IdImpuesto3 = CInt(drPrecio("IdImpuesto3"))
                .IdImpuesto4 = CInt(drPrecio("IdImpuesto4"))
                .IdImpuesto5 = CInt(drPrecio("IdImpuesto5"))
                .PorcentajeImpuesto1 = CDec(drPrecio("PorcImpuesto1"))
                .PorcentajeImpuesto2 = CDec(drPrecio("PorcImpuesto2"))
                .PorcentajeImpuesto3 = CDec(drPrecio("PorcImpuesto3"))
                .PorcentajeImpuesto4 = CDec(drPrecio("PorcImpuesto4"))
                .PorcentajeImpuesto5 = CDec(drPrecio("PorcImpuesto5"))
                .MontoImpuesto1 = CDec(drPrecio("MontoImpuesto1"))
                .MontoImpuesto2 = CDec(drPrecio("MontoImpuesto2"))
                .MontoImpuesto3 = CDec(drPrecio("MontoImpuesto3"))
                .MontoImpuesto4 = CDec(drPrecio("MontoImpuesto4"))
                .MontoImpuesto5 = CDec(drPrecio("MontoImpuesto5"))
                'RETENCIONES
                .PorcentajeRetencion1 = CDec(drPrecio("PorcRetencion1"))
                .PorcentajeRetencion2 = CDec(drPrecio("PorcRetencion2"))
                .PorcentajeRetencion3 = CDec(drPrecio("PorcRetencion3"))
                .PorcentajeRetencion4 = CDec(drPrecio("PorcRetencion4"))
                .PorcentajeRetencion5 = CDec(drPrecio("PorcRetencion5"))
                .MontoRetencion1 = CDec(drPrecio("MontoRetencion1"))
                .MontoRetencion2 = CDec(drPrecio("MontoRetencion2"))
                .MontoRetencion3 = CDec(drPrecio("MontoRetencion3"))
                .MontoRetencion4 = CDec(drPrecio("MontoRetencion4"))
                .MontoRetencion5 = CDec(drPrecio("MontoRetencion5"))
                'DESCUENTOS
                .PorcentajeDescuento1 = CDec(drPrecio("PorcDescuento1"))
                .PorcentajeDescuento2 = CDec(drPrecio("PorcDescuento2"))
                .PorcentajeDescuento3 = CDec(drPrecio("PorcDescuento3"))
                .PorcentajeDescuento4 = CDec(drPrecio("PorcDescuento4"))
                .PorcentajeDescuento5 = CDec(drPrecio("PorcDescuento5"))
                .MontoDescuento1 = CDec(drPrecio("MontoDescuento1"))
                .MontoDescuento2 = CDec(drPrecio("MontoDescuento2"))
                .MontoDescuento3 = CDec(drPrecio("MontoDescuento3"))
                .MontoDescuento4 = CDec(drPrecio("MontoDescuento4"))
                .MontoDescuento5 = CDec(drPrecio("MontoDescuento5"))
            End With
            Return Precio
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la información de precios del servicio.", ex)
        End Try
    End Function


#End Region

End Class


Partial Class ServicioFacade

#Region "Metodos Generales"


    Public Function GetDetailFromCache(ByVal sessionID As GUID, ByVal idServicio As Integer) As ServicioInfo
        ValidateSession(sessionID)
        Dim ServicioInf As ServicioInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ServicioService(sessionID, Connection)
            ServicioInf = Svc.GetDetailFromCache(idServicio)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return ServicioInf
    End Function


    Public Function GetDetailFromCache(ByVal sessionID As GUID, ByVal codigo As String, ByVal idSucursal As Integer) As ServicioInfo
        ValidateSession(sessionID)
        Dim ServicioInf As ServicioInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ServicioService(sessionID, Connection)
            ServicioInf = Svc.GetDetailFromCache(codigo, idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return ServicioInf
    End Function

#End Region

#Region "Precios"

    Public Function GetPrecio(ByVal sessionID As Guid, ByVal idServicio As Integer, ByVal idCliente As Integer, ByVal idSucursal As Integer) As PrecioInfo
        Return GetPrecio(sessionID, idServicio, idCliente, idSucursal, 0)
    End Function

    Public Function GetPrecio(ByVal sessionID As Guid, ByVal idServicio As Integer, ByVal idCliente As Integer, ByVal idSucursal As Integer, ByVal precioFijo As Decimal) As PrecioInfo
        ValidateSession(sessionID)
        Dim Precio As PrecioInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ServicioService(sessionID, Connection)
            Precio = Svc.GetPrecio(idServicio, idCliente, idSucursal, precioFijo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Precio
    End Function

#End Region

End Class
