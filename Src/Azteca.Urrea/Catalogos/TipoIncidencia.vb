Partial Public Class TipoIncidenciaService


#Region "General"

    Public Function LoadList(ByVal IdSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("CDU", "fxTiposIncidenciaCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            fxList.Parameters.Add("@IdUsuario", DbType.Int32).Value = 1
            Dim dtList As DataTable = fxList.GetTable("Incidencia")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de grupos.", ex)
        End Try
    End Function

#End Region

End Class

Partial Public Class TipoIncidenciaFacade

    Public Function LoadList(ByVal sessionID As Guid, ByVal IdSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New TipoIncidenciaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(IdSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class
