Partial Public Class MatrimonioService

#Region "Actas"

    Public Function ActaMatrimonio(ByVal idMatrimonio As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Church", "fxActaMatrimonio", Connection, Transaction)
            fxList.Parameters.Add("@IdMatrimonio", DbType.Int32).Value = idMatrimonio
            Dim dtList As DataTable = fxList.GetTable("ActaMatrimonio")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el acta de matrimonio.", ex)
        End Try
    End Function

#End Region

End Class

Partial Public Class MatrimonioFacade



#Region "Actas"

    Public Function ActaMatrimonio(ByVal sessionID As Guid, ByVal idMatrimonio As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New MatrimonioService(sessionID, Connection, Transaction)
            dtList = Svc.ActaMatrimonio(idMatrimonio)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

#End Region

End Class
