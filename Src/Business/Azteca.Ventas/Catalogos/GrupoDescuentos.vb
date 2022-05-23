Partial Class GrupoDescuentosFacade

    Public Function ArticulosLoad(ByVal sessionID As Guid, ByVal idListaPrecios As Integer) As GrupoDescuentosDS.ArticulosDataTable
        ValidateSession(sessionID)
        Dim dtList As New GrupoDescuentosDS.ArticulosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New GrupoDescuentosService(sessionID, Connection, Transaction)
            dtList = Svc.ArticulosLoad(idListaPrecios)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function ServiciosLoad(ByVal sessionID As Guid, ByVal idListaPrecios As Integer) As GrupoDescuentosDS.ServiciosDataTable
        ValidateSession(sessionID)
        Dim dtList As New GrupoDescuentosDS.ServiciosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New GrupoDescuentosService(sessionID, Connection, Transaction)
            dtList = Svc.ServiciosLoad(idListaPrecios)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function ClientesLoad(ByVal sessionID As Guid, ByVal idEmpresa As Integer, ByVal idListaPrecios As Integer) As GrupoDescuentosDS.ClientesDataTable
        ValidateSession(sessionID)
        Dim dtList As New GrupoDescuentosDS.ClientesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New GrupoDescuentosService(sessionID, Connection, Transaction)
            dtList = Svc.ClientesLoad(idEmpresa, idListaPrecios)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Sub ClientesSave(ByVal sessionID As Guid, ByVal IdListaPrecios As Integer, ByVal ListaClientes As GrupoDescuentosDS.ClientesDataTable)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New GrupoDescuentosService(sessionID, Connection, Transaction)
            Svc.saveClientes(IdListaPrecios, ListaClientes)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub


End Class
