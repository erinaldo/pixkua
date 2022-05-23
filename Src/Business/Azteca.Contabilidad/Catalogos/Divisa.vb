Imports System.Xml
Imports Azteca.Kernel
Imports <xmlns:bm='http://www.banxico.org.mx/structure/key_families/dgie/sie/series/compact'>

Partial Class DivisaService

    Public Function LoadList() As DataTable
        Try
            Dim fxList As New FunctionSQL("Accounting", "fxDivisasCBO", Connection, Transaction)
            Dim dtList As DataTable = fxList.GetTable("Divisas")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de divisas.", ex)
        End Try
    End Function

    Public Function GetDetailFromCache(ByVal idDivisa As Integer) As DivisaInfo
        Dim Divisa As New DivisaInfo(sessionID)
        Try
            Dim CacheKey As String = "Divisa" & idDivisa.ToString
            If Cache.Item(CacheKey) Is Nothing Then
                Dim DivisaSvc As New DivisaService(sessionID, Connection, Transaction)
                DivisaSvc.GetDetail(idDivisa, Divisa, False)
                Cache.Add(CacheKey, Divisa, TimeSpan.FromDays(1))
            Else
                Divisa = CType(Cache.Item(CacheKey), DivisaInfo)
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de la divisa " & idDivisa.ToString & " desde el caché de sistema.")
        End Try
        Return Divisa
    End Function

    Public Function GetDivisaBase() As Integer
        Return CInt(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Contabilidad/Divisas", "Base"))
    End Function


#Region "Tipos de Cambio"

    Public Function CargarTiposCambio(ByVal idDivisa As Integer) As DataTable
        Try
            Dim fxTiposCambio As New FunctionSQL("Accounting", "fxTiposCambioSEL", Connection, Transaction)
            fxTiposCambio.Parameters.Add("@IdDivisa", DbType.Int32).Value = idDivisa
            Dim dtTiposCambio As DataTable = fxTiposCambio.GetTable("TiposCambio")
            Return dtTiposCambio
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los tipos de cambio de la divisa " & idDivisa, ex)
        End Try
    End Function

    Public Sub GuardarTipoCambio(ByVal idDivisaOrigen As Integer, ByVal idDivisaDestino As Integer, ByVal precioCompra As Decimal, ByVal precioVenta As Decimal)
        Try
            Dim spUpdate As New StoredProcedure("Accounting", "TiposCambioHistUPD", Connection, Transaction)
            spUpdate.Parameters.Add("@IdDivisaOrigen", DbType.Int32).Value = idDivisaOrigen
            spUpdate.Parameters.Add("@IdDivisaDestino", DbType.Int32).Value = idDivisaDestino
            spUpdate.Parameters.Add("@PrecioCompra", DbType.Decimal).Value = precioCompra
            spUpdate.Parameters.Add("@PrecioVenta", DbType.Decimal).Value = precioVenta
            spUpdate.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity
            spUpdate.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al guardar el tipo de cambio de la divisa.", ex)
        End Try
    End Sub

    Public Function GetTipoCambioActual(ByVal idDivisaOrigen As Integer, ByVal idDivisaDestino As Integer) As Decimal
        Try
            Dim fxTipoCambio As New FunctionSQL("Accounting", "fxTipoCambioActual", Connection, Transaction)
            fxTipoCambio.Parameters.Add("@IdDivisaOrigen", DbType.Int32).Value = idDivisaOrigen
            fxTipoCambio.Parameters.Add("@IdDivisaDestino", DbType.Int32).Value = idDivisaDestino
            Return CDec(fxTipoCambio.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al obtener el tipo de cambio de la divisa " & idDivisaOrigen)
        End Try
    End Function

    Public Function GetTipoCambioActual(ByVal idDivisaOrigen As Integer) As Decimal
        Dim IdDivisaBase As Integer = GetDivisaBase()
        Return GetTipoCambioActual(idDivisaOrigen, IdDivisaBase)
    End Function

    Public Function GetTipoCambioBanxico(ByVal idDivisa As Integer) As Decimal
        Try
            'Cargar información de la divisa
            Dim DivisaSvc As New DivisaService(sessionID, Connection, Transaction)
            Dim Divisa As New DivisaInfo(sessionID)
            DivisaSvc.GetDetail(idDivisa, Divisa, False)
            'Obtener información de tipo de cambio a través de web service
            Dim Svc As New Banxico.DgieWSPortClient
            Dim strResult As String = Svc.tiposDeCambioBanxico()
            Dim xmlResult As New XmlDocument
            Dim reader As New System.IO.StringReader(strResult)
            Dim root As XElement = XElement.Load(reader)
            'Consultar en resultado xml el valor del tipo de cambio

            Dim Serie As IEnumerable(Of XElement) =
                From el In root.<bm:DataSet>.<bm:Series>
                Where el.@IDSERIE = Divisa.SerieBanxico
                Select el

            Dim Valor As Decimal = 0
            For Each el As XElement In Serie.<bm:Obs>
                Valor = CDec(Val(el.@OBS_VALUE))
            Next
            Return Valor
        Catch ex As Exception
            Throw New BusinessException("Error al consultar el tipo de cambio a través de servicio WEB de Banxico.", ex)
        End Try
    End Function

#End Region


End Class


Partial Class DivisaFacade

    Public Function LoadList(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DivisaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function GetDetailFromCache(ByVal sessionID As GUID, ByVal idDivisa As Integer) As DivisaInfo
        ValidateSession(sessionID)
        Dim Divisa As DivisaInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DivisaService(sessionID, Connection, Transaction)
            Divisa = Svc.GetDetailFromCache(idDivisa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Divisa
    End Function

    Public Function GetDivisaBase(ByVal sessionID As Guid) As Integer
        ValidateSession(sessionID)
        Dim IdDivisa As Integer = 0
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DivisaService(sessionID, Connection, Transaction)
            IdDivisa = Svc.GetDivisaBase
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return IdDivisa
    End Function


#Region "Tipos de Cambio"

    Public Function CargarTiposCambio(ByVal sessionID As Guid, ByVal idDivisa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtTiposCambio As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DivisaService(sessionID, Connection, Transaction)
            dtTiposCambio = Svc.CargarTiposCambio(idDivisa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtTiposCambio
    End Function

    Public Sub GuardarTipoCambio(ByVal sessionID As Guid, ByVal idDivisaOrigen As Integer, ByVal idDivisaDestino As Integer, ByVal precioCompra As Decimal, ByVal precioVenta As Decimal)
        ValidateSession(sessionID)
        Dim dtTiposCambio As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New DivisaService(sessionID, Connection, Transaction)
                Svc.GuardarTipoCambio(idDivisaOrigen, idDivisaDestino, precioCompra, precioVenta)
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

    Public Function GetTipoCambioActual(ByVal sessionID As Guid, ByVal idDivisaOrigen As Integer) As Decimal
        ValidateSession(sessionID)
        Dim TipoCambio As Decimal = 0
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DivisaService(sessionID, Connection, Transaction)
            TipoCambio = Svc.GetTipoCambioActual(idDivisaOrigen)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return TipoCambio
    End Function


    Public Function GetTipoCambioBanxico(ByVal sessionID As Guid, ByVal idDivisa As Integer) As Decimal
        Dim Result As Decimal = 0
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New DivisaService(sessionID, Connection, Transaction)
            Result = Svc.GetTipoCambioBanxico(idDivisa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Result
    End Function


#End Region


End Class
