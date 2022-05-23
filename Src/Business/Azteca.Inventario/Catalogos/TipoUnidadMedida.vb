Partial Class TipoUnidadMedidaService

    Public Function LoadList() As DataTable
        Try
            Dim fxList As New FunctionSQL("Inventory", "fxUnidadesMedidaTiposCBO", Connection, Transaction)
            Dim dtList As DataTable = fxList.GetTable("TiposUnidad")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de tipos de unidad de medida.", ex)
        End Try
    End Function

    Public Function LoadUnidades(ByVal idTipoUnidad As Integer) As UnidadesMedidaDS.UnidadesMedidaDataTable
        Try
            Dim fxUnidades As New FunctionSQL("Inventory", "fxTipoUnidadesSEL", Connection, Transaction)
            fxUnidades.Parameters.Add("@IdUnidadMedidaTipo", DbType.Int32).Value = idTipoUnidad
            Dim dtUnidades As New UnidadesMedidaDS.UnidadesMedidaDataTable
            fxUnidades.FillDataTable(dtUnidades)
            Return dtUnidades
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las unidades de medida del tipo especificado.", ex)
        End Try
    End Function

    Public Function GetUnidadBaseID(ByVal idTipoUnidad As Integer) As Integer
        Try
            Dim fxId As New FunctionSQL("Inventory", "fxUnidadMedidaBase", Connection, Transaction)
            fxId.Parameters.Add("@IdUnidadMedidaTipo", DbType.Int32).Value = idTipoUnidad
            Dim IdUnidad As Integer = CInt(fxId.GetScalar)
            Return IdUnidad
        Catch ex As Exception
            Throw New BusinessException("Error al obtener el ID de la unidad de medida base.", ex)
        End Try
    End Function

End Class


Partial Class TipoUnidadMedidaFacade

    Public Function LoadList(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New TipoUnidadMedidaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadUnidades(ByVal sessionID As GUID, ByVal idTipo As Integer) As UnidadesMedidaDS.UnidadesMedidaDataTable
        ValidateSession(sessionID)
        Dim dtList As New UnidadesMedidaDS.UnidadesMedidaDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New TipoUnidadMedidaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadUnidades(idTipo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function GetUnidadBaseID(ByVal sessionID As GUID, ByVal idTipoUnidad As Integer) As Integer
        ValidateSession(sessionID)
        Dim IdUnidad As Integer = 0
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New TipoUnidadMedidaService(sessionID, Connection, Transaction)
            IdUnidad = Svc.GetUnidadBaseID(idTipoUnidad)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return IdUnidad
    End Function


End Class