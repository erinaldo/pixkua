Partial Class Categoriafacade
    Public Function LoadList(ByVal sessionID As GUID, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CategoriaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadDataButtons(ByVal sessionID As GUID, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As New DataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CategoriaService(sessionID, Connection, Transaction)
            dtList = Svc.LoadDataButtons(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class

Partial Class CategoriaService
    Public Function LoadList(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxCategoriasCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As DataTable = fxList.GetTable("Categorias")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de categorias.", ex)
        End Try
    End Function
    Public Function LoadDataButtons(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Restaurant", "fxCategoriasLoadButtons", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As DataTable = fxList.GetTable("Categorias")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de categorias.", ex)
        End Try
    End Function

End Class