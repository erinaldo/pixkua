Partial Class UbicacionFacade
    Public Function LoadChildsFirst(ByVal sessionID As Guid, idEmpresa As Integer, ByVal idPadre As Integer, IdAlmacen As Integer) As HierarchyDS.HierarchyDataTable
        Dim UbicacionSvc As New UbicacionService(sessionID)
        Dim Nodes As New HierarchyDS.HierarchyDataTable
        LoadChildsFirst(UbicacionSvc, idEmpresa, idPadre, Nodes, IdAlmacen)
        Return Nodes
    End Function

    Protected Sub LoadChildsFirst(UbicacionSvc As UbicacionService, ByVal idEmpresa As Integer, ByVal idPadre As Integer, ByRef retNodes As HierarchyDS.HierarchyDataTable, IdAlmacen As Integer)
        ValidateSession(UbicacionSvc.Session.SessionID)
        Try
            Connection = DataServices.OpenConnection
            UbicacionSvc.Connection = Connection
            retNodes = UbicacionSvc.LoadChildsFirst(idEmpresa, idPadre, IdAlmacen)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function LoadChildsFill(ByVal sessionID As Guid, idEmpresa As Integer, ByVal idPadre As Integer, ByRef retNodes As HierarchyDS.HierarchyDataTable) As HierarchyDS.HierarchyDataTable
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim UbicnSvc As New UbicacionService(sessionID, Me.Connection, Me.Transaction)
            retNodes = UbicnSvc.LoadChildsFill(idEmpresa, idPadre, retNodes)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return retNodes
    End Function
End Class


Partial Class UbicacionService

    Public Function LoadChildsFill(ByVal idEmpresa As Integer, ByVal IdPadre As Integer, Nodes As HierarchyDS.HierarchyDataTable) As HierarchyDS.HierarchyDataTable
        Try
            Dim fxChilds As New FunctionSQL(CatalogSchema, "fx" & CatalogTable & "Childs", Connection, Transaction)
            fxChilds.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fxChilds.Parameters.Add("@IdPadre", DbType.Int32).Value = IdPadre
            fxChilds.FillDataTable(Nodes)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los nodos secundarios.", ex)
        End Try
        Return Nodes
    End Function

    Public Function LoadChildsFirst(ByVal idEmpresa As Integer, ByVal IdPadre As Integer, IdAlmacen As Integer) As HierarchyDS.HierarchyDataTable
        Dim Nodes As New HierarchyDS.HierarchyDataTable
        Try
            Dim fxChilds As New FunctionSQL(CatalogSchema, "fx" & CatalogTable & "ChildsFirst", Connection, Transaction)
            fxChilds.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fxChilds.Parameters.Add("@IdPadre", DbType.Int32).Value = IdPadre
            fxChilds.Parameters.Add("@IdAlmacen", DbType.Int32).Value = IdAlmacen
            fxChilds.FillDataTable(Nodes)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los nodos secundarios.", ex)
        End Try
        Return Nodes
    End Function

End Class