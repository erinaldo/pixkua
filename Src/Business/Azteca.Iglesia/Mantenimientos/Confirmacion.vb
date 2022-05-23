Partial Public Class ConfirmacionService

#Region "Actas"

    Public Function ActaConfirmacion(ByVal idConfirmacion As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Church", "fxActaConfirmacion", Connection, Transaction)
            fxList.Parameters.Add("@IdConfirmacion", DbType.Int32).Value = idConfirmacion
            Dim dtList As DataTable = fxList.GetTable("ActaConfirmacion")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el acta de confirmacion.", ex)
        End Try
    End Function

#End Region

End Class

Partial Public Class ConfirmacionFacade


#Region "Actas"

    Public Function ActaConfirmacion(ByVal sessionID As Guid, ByVal idConfirmacion As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ConfirmacionService(sessionID, Connection, Transaction)
            dtList = Svc.ActaConfirmacion(idConfirmacion)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

#End Region
End Class


