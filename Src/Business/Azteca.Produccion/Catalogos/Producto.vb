Partial Class ProductoFacade
    Public Function InsumosOpcionales(ByVal sessionID As GUID, ByVal idProducto As Integer) As ProductosDS.InsumosOpcionalesDataTable
        ValidateSession(sessionID)
        Dim dtList As New ProductosDS.InsumosOpcionalesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ProductoService(sessionID, Connection, Transaction)
            dtList = Svc.InsumosOpcionales(idProducto)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

End Class

Partial Class ProductoService

    Public Function InsumosOpcionales(ByVal idProducto As Integer) As ProductosDS.InsumosOpcionalesDataTable
        Try
            Dim fxList As New FunctionSQL("Production", "fxProductoInsumosOpcionalesSEL", Connection, Transaction)
            fxList.Parameters.Add("@idProducto", DbType.Int32).Value = idProducto
            Dim dtList As New ProductosDS.InsumosOpcionalesDataTable
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de insumos opcionales.", ex)
        End Try
    End Function

End Class
