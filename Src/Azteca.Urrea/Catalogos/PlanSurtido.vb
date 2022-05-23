Partial Public Class PlanSurtidoService

#Region "General"

    Public Function PlanSurtidoByArea(ByVal idSucursal As Integer, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime, ByVal horaInicio As DateTime, ByVal cantSurtidores As Integer, ByVal cantMontacargas As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("CDU", "fxPlanSurtidoByUser", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaIni
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFin
            fxList.Parameters.Add("@FechaHoraInicio", DbType.DateTime).Value = horaInicio
            fxList.Parameters.Add("@CantPersonas", DbType.Int32).Value = cantSurtidores
            fxList.Parameters.Add("@CantMontacargas", DbType.Int32).Value = cantMontacargas
            Dim dtList As DataTable = fxList.GetTable("PlanCajasCompletas")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al generar el plan de balanceo.", ex)
        End Try
    End Function

    Public Function GetListaOperadores(ByVal idSucursal As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("CDU", "fxListaOperadores", Connection, Transaction)
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim dtList As DataTable = fxList.GetTable("Operadores")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la lista de operadores.", ex)
        End Try
    End Function

#End Region


End Class

Partial Public Class PlanSurtidoFacade


#Region "General"

    Public Function PlanSurtidoByArea(ByVal sessionID As Guid, ByVal idSucursal As Integer, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime, ByVal horaInicio As DateTime, ByVal cantSurtidores As Integer, ByVal cantMontacargas As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PlanSurtidoService(sessionID, Connection, Transaction)
            dtList = Svc.PlanSurtidoByArea(idSucursal, fechaIni, fechaFin, horaInicio, cantSurtidores, cantMontacargas)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function


    Public Function GetListaOperadores(ByVal sessionID As Guid, ByVal idSucursal As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New PlanSurtidoService(sessionID, Connection, Transaction)
            dtList = Svc.GetListaOperadores(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

#End Region


    

End Class
