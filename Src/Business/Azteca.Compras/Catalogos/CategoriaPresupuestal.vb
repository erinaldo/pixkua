Partial Class CategoriaPresupuestalService

    Public Function List(ByVal idEmpresa As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxCategoriasPresupuestalesListSEL", Connection, Transaction)
            fx.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fx.FillDataTable(dt)

        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Categorias Presupuestales.", ex)
        End Try
        Return dt
    End Function

    Public Function LoadListByArticulo(idArticuloStock As Integer, idUsuario As Integer) As DataTable
        Dim dt As New DataTable("Articulos")
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxCategoriasPresupuestalesByArticulo", Connection, Transaction)
            fx.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            fx.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Categorias Presupuestales del artículo: " & idArticuloStock, ex)
        End Try
        Return dt
    End Function

    Public Function LoadListByServicio(idServicio As Integer, idUsuario As Integer) As DataTable
        Dim dt As New DataTable("Servicios")
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxCategoriasPresupuestalesByServicio", Connection, Transaction)
            fx.Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
            fx.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Categorias Presupuestales del servicio: " & idServicio, ex)
        End Try
        Return dt
    End Function


    Public Function ArticulosList(ByVal idCategoriaPresupuestal As Integer) As ConfiguracionDS.CategoriasPresupuestalesArticulosDataTable
        Dim dt As New ConfiguracionDS.CategoriasPresupuestalesArticulosDataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxCategoriasPresupuestalesArticulosSEL", Connection, Transaction)
            fx.Parameters.Add("@IdCategoriaPresupuestal", DbType.Int32).Value = idCategoriaPresupuestal
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de articulos.", ex)
        End Try
        Return dt
    End Function

    Public Sub ArticulosSave(ByVal sessionID As Guid, ByVal idCategoriaPresupuestal As Integer, ByVal ArticulosTable As ConfiguracionDS.CategoriasPresupuestalesArticulosDataTable)
        Try
            Dim da As New DataAdapter
            Dim cmd As New Azteca.Data.DbCommand("Purchasing.CategoriasPresupuestalesArticulosSave", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdCategoriaPresupuestal", DbType.Int32).Value = idCategoriaPresupuestal
            cmd.Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
            cmd.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmd.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity

            Dim cmdDEL As New Azteca.Data.DbCommand("Purchasing.CategoriasPresupuestalesArticulosDEL", Me.Connection, Me.Transaction)
            cmdDEL.Parameters.Add("@IdCategoriaPresupuestal", DbType.Int32).Value = idCategoriaPresupuestal
            cmdDEL.Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
            cmdDEL.CommandType = CommandType.StoredProcedure

            da.UpdateCommand = cmd : da.InsertCommand = cmd : da.DeleteCommand = cmdDEL
            da.Update(ArticulosTable)

        Catch ex As Exception
            Throw New Exception("Problemas al intentar guardar los articulos en la Categoria Presupuestal", ex)
        End Try
    End Sub

    Public Function ServiciosList(ByVal idCategoriaPresupuestal As Integer) As ConfiguracionDS.CategoriasPresupuestalesServiciosDataTable
        Dim dt As New ConfiguracionDS.CategoriasPresupuestalesServiciosDataTable
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxCategoriasPresupuestalesServiciosSEL", Connection, Transaction)
            fx.Parameters.Add("@IdCategoriaPresupuestal", DbType.Int32).Value = idCategoriaPresupuestal
            fx.FillDataTable(dt)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de servicios.", ex)
        End Try
        Return dt
    End Function

    Public Sub ServiciosSave(ByVal sessionID As Guid, ByVal idCategoriaPresupuestal As Integer, ByVal ServiciosTable As ConfiguracionDS.CategoriasPresupuestalesServiciosDataTable)
        Try
            Dim da As New DataAdapter
            Dim cmd As New Azteca.Data.DbCommand("Purchasing.CategoriasPresupuestalesServiciosSave", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdCategoriaPresupuestal", DbType.Int32).Value = idCategoriaPresupuestal
            cmd.Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
            cmd.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmd.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity

            Dim cmdDEL As New Azteca.Data.DbCommand("Purchasing.CategoriasPresupuestalesServiciosDEL", Me.Connection, Me.Transaction)
            cmdDEL.Parameters.Add("@IdCategoriaPresupuestal", DbType.Int32).Value = idCategoriaPresupuestal
            cmdDEL.Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
            cmdDEL.CommandType = CommandType.StoredProcedure

            da.UpdateCommand = cmd : da.InsertCommand = cmd : da.DeleteCommand = cmdDEL
            da.Update(ServiciosTable)

        Catch ex As Exception
            Throw New Exception("Problemas al intentar guardar los servicios en la Categoria Presupuestal", ex)
        End Try
    End Sub

End Class

Partial Class CategoriaPresupuestalFacade
    Public Function List(ByVal sessionID As Guid, ByVal idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dt As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CategoriaPresupuestalService(sessionID, Connection)
            dt = Svc.List(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function

    Public Function LoadListByArticulo(sessionID As Guid, idArticuloStock As Integer, idUsuario As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dt As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CategoriaPresupuestalService(sessionID, Connection)
            dt = Svc.LoadListByArticulo(idArticuloStock, idUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function

    Public Function LoadListByServicio(sessionID As Guid, idServicio As Integer, idUsuario As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dt As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CategoriaPresupuestalService(sessionID, Connection)
            dt = Svc.LoadListByServicio(idServicio, idUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dt
    End Function



    Public Function ArticulosList(ByVal sessionID As Guid, ByVal idCategoriaPresupuestal As Integer) As ConfiguracionDS.CategoriasPresupuestalesArticulosDataTable
        ValidateSession(sessionID)
        Dim dtReturn As ConfiguracionDS.CategoriasPresupuestalesArticulosDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CategoriaPresupuestalService(sessionID, Connection)
            dtReturn = Svc.ArticulosList(idCategoriaPresupuestal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function

    Public Sub ArticulosSave(ByVal sessionID As Guid, ByVal idCategoriaPresupuestal As Integer, ByVal ArticulosTable As ConfiguracionDS.CategoriasPresupuestalesArticulosDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CategoriaPresupuestalService(sessionID, Connection)
            Svc.ArticulosSave(sessionID, idCategoriaPresupuestal, ArticulosTable)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function ServiciosList(ByVal sessionID As Guid, ByVal idCategoriaPresupuestal As Integer) As ConfiguracionDS.CategoriasPresupuestalesServiciosDataTable
        ValidateSession(sessionID)
        Dim dtReturn As ConfiguracionDS.CategoriasPresupuestalesServiciosDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CategoriaPresupuestalService(sessionID, Connection)
            dtReturn = Svc.ServiciosList(idCategoriaPresupuestal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtReturn
    End Function

    Public Sub ServiciosSave(ByVal sessionID As Guid, ByVal idCategoriaPresupuestal As Integer, ByVal ServiciosTable As ConfiguracionDS.CategoriasPresupuestalesServiciosDataTable)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CategoriaPresupuestalService(sessionID, Connection)
            Svc.ServiciosSave(sessionID, idCategoriaPresupuestal, ServiciosTable)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub
End Class

Public Enum ArticuloServicioEnum
    Articulo
    Servicio
End Enum