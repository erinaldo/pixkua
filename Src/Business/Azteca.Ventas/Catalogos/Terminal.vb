Partial Class TerminalFacade
    Public Function LogIn(ByVal sessionID As Guid, ByVal IdSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New TerminalService(sessionID, Connection, Transaction)
            dtList = Svc.LogIn(IdSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LogInID(ByVal sessionID As Guid, ByVal IdTerminal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New TerminalService(sessionID, Connection, Transaction)
            dtList = Svc.LogInID(IdTerminal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function
End Class

Partial Class TerminalService
    Public Function LogIn(ByVal IdSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxTerminalesLogIn", Connection, Transaction)
            fxList.Parameters.Add("@PC", DbType.String).Value = Session.WorkStation
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            Dim dtList As DataTable = fxList.GetTable("Terminal")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los datos de la terminal", ex)
        End Try
    End Function

    Public Function LogInID(ByVal IdTerminal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxTerminalesLogInID", Connection, Transaction)
            fxList.Parameters.Add("@IdTerminal", DbType.Int32).Value = IdTerminal
            Dim dtList As DataTable = fxList.GetTable("Terminal")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los datos de la terminal", ex)
        End Try
    End Function

End Class
