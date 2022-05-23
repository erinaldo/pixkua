Partial Class PolizaPerfilFacade
    Public Function SaveOrigen(ByVal sessionID As GUID, ByVal Descripcion As String) As Integer
        Dim id As Integer = 0
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PolizaPerfilService(sessionID, Connection, Transaction)
            id = Svc.SaveOrigen(Descripcion)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return id
    End Function
    Public Function SaveImporte(ByVal sessionID As GUID, ByVal Descripcion As String) As Integer
        Dim id As Integer = 0
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PolizaPerfilService(sessionID, Connection, Transaction)
            id = Svc.SaveImporte(Descripcion)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return id
    End Function

    Public Function getPolizasOrigenCBO(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtFicha As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PolizaPerfilService(sessionID, Connection)
            dtFicha = Svc.getPolizasOrigenCBO()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtFicha
    End Function

    Public Function getPolizasTiposCBO(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtFicha As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PolizaPerfilService(sessionID, Connection)
            dtFicha = Svc.getPolizasTiposCBO
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtFicha
    End Function

    Public Function getPolizasSumarizacionesCBO(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtFicha As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PolizaPerfilService(sessionID, Connection)
            dtFicha = Svc.getPolizasSumarizacionesCBO
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtFicha
    End Function

    Public Function ListaCBO(ByVal sessionID As GUID) As DataTable
        ValidateSession(sessionID)
        Dim dtFicha As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PolizaPerfilService(sessionID, Connection)
            dtFicha = Svc.ListaCBO
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtFicha
    End Function

    Public Function RacsList(ByVal sessionID As Guid, ByVal IdPolizaPerfil As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dt As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PolizaPerfilService(sessionID, Connection)
            dt = Svc.RacsList(IdPolizaPerfil)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function
End Class

Partial Class PolizaPerfilService
    Public Function SaveOrigen(ByVal Descripcion As String) As Integer
        Try
            Dim sp As New StoredProcedure("Accounting", "PolizaOrigenSave", Connection, Transaction)
            sp.Parameters.Add("@Id", DbType.Int32, ParameterDirection.InputOutput).Value = 0
            sp.Parameters.Add("@Descripcion", DbType.String).Value = Descripcion
            sp.Execute()
            Return CInt(sp.Parameters("@Id").Value)
        Catch ex As Exception
            Throw New BusinessException("Error al registrar el nuevo origen de pólizas", ex)
        End Try
    End Function

    Public Function SaveImporte(ByVal Descripcion As String) As Integer
        Try
            Dim sp As New StoredProcedure("Accounting", "PolizaImporteSave", Connection, Transaction)
            sp.Parameters.Add("@Id", DbType.Int32, ParameterDirection.InputOutput).Value = 0
            sp.Parameters.Add("@Descripcion", DbType.String).Value = Descripcion
            sp.Execute()
            Return CInt(sp.Parameters("@Id").Value)
        Catch ex As Exception
            Throw New BusinessException("Error al registrar el nuevo Importe de pólizas", ex)
        End Try
    End Function

    Public Function getPolizasOrigenCBO() As DataTable
        Dim dtReturn As New DataTable()
        Try
            Dim fx As New FunctionSQL("Accounting", "fxPolizaOrigenCBO", Connection, Transaction)
            dtReturn = fx.GetTable()
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los origenes de las pólizas", ex)
        End Try
        Return dtReturn
    End Function

    Public Function getPolizasTiposCBO() As DataTable
        Dim dtReturn As New DataTable()
        Try
            Dim fx As New FunctionSQL("Accounting", "fxPolizasTipoCBO", Connection, Transaction)
            dtReturn = fx.GetTable()
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de los tipo de polizas.", ex)
        End Try
        Return dtReturn
    End Function

    Public Function getPolizasSumarizacionesCBO() As DataTable
        Dim dtReturn As New DataTable()
        Try
            Dim fx As New FunctionSQL("Accounting", "fxPolizasSumarizacionCBO", Connection, Transaction)
            dtReturn = fx.GetTable()
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las opciones de sumarizacion de la poliza.", ex)
        End Try
        Return dtReturn
    End Function

    Public Function ListaCBO() As DataTable
        Dim dtReturn As New DataTable()
        Try
            Dim fx As New FunctionSQL("Accounting", "fxPolizasPerfilesCBO", Connection, Transaction)
            dtReturn = fx.GetTable()
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las lista de polizas.", ex)
        End Try
        Return dtReturn
    End Function

    Public Function RacsList(ByVal IdPolizaPerfil As Integer) As DataTable
        Dim dtReturn As New DataTable()
        Try
            Dim fx As New FunctionSQL("Accounting", "fxPolizasPerfilesRacList", Connection, Transaction)
            fx.Parameters.Add("@IdPolizaPerfil", DbType.Int32).Value = IdPolizaPerfil
            dtReturn = fx.GetTable()
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las lista de Racs del Perfil de Poliza.", ex)
        End Try
        Return dtReturn
    End Function

End Class
