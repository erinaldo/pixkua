Partial Class ListaPreciosFacade

    Public Function ServicioPreciosList(ByVal sessionID As Guid, ByVal idServicio As Integer, IdSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ListaPreciosService(sessionID, Connection, Transaction)
            dtList = Svc.ServicioPreciosList(idServicio, IdSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function ArticuloPreciosList(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, IdSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ListaPreciosService(sessionID, Connection, Transaction)
            dtList = Svc.ArticuloPreciosList(idArticuloStock, IdSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Sub ArticulosPreciosSave(ByVal sessionID As Guid, ByVal idArticuloStock As Integer, PreciosTable As DataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ListaPreciosService(sessionID, Connection, Transaction)
            Svc.ArticulosPreciosSave(idArticuloStock, PreciosTable)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Sub ServiciosPreciosSave(ByVal sessionID As Guid, ByVal idServicio As Integer, PreciosTable As DataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ListaPreciosService(sessionID, Connection, Transaction)
            Svc.ServiciosPreciosSave(idServicio, PreciosTable)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function ArticulosLoad(ByVal sessionID As Guid, ByVal idListaPrecios As Integer) As ListaPreciosDS.ArticulosDataTable
        ValidateSession(sessionID)
        Dim dtList As New ListaPreciosDS.ArticulosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ListaPreciosService(sessionID, Connection, Transaction)
            dtList = Svc.ArticulosLoad(idListaPrecios)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function ServiciosLoad(ByVal sessionID As Guid, ByVal idListaPrecios As Integer) As ListaPreciosDS.ServiciosDataTable
        ValidateSession(sessionID)
        Dim dtList As New ListaPreciosDS.ServiciosDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ListaPreciosService(sessionID, Connection, Transaction)
            dtList = Svc.ServiciosLoad(idListaPrecios)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function ClientesLoad(ByVal sessionID As Guid, ByVal idEmpresa As Integer, ByVal idListaPrecios As Integer) As ListaPreciosDS.ClientesDataTable
        ValidateSession(sessionID)
        Dim dtList As New ListaPreciosDS.ClientesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ListaPreciosService(sessionID, Connection, Transaction)
            dtList = Svc.ClientesLoad(IdEmpresa, idListaPrecios)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Sub ClientesSave(ByVal sessionID As Guid, ByVal IdListaPrecios As Integer, ByVal ListaClientes As ListaPreciosDS.ClientesDataTable)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ListaPreciosService(sessionID, Connection, Transaction)
            Svc.saveClientes(IdListaPrecios, ListaClientes)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

End Class
