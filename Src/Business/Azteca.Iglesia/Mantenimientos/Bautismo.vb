Partial Public Class BautismoService

#Region "Actas"

    Public Function ActaBautismo(ByVal idBautismo As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Church", "fxActaBautismo", Connection, Transaction)
            fxList.Parameters.Add("@IdBautismo", DbType.Int32).Value = idBautismo
            Dim dtList As DataTable = fxList.GetTable("ActaBautismo")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el acta de bautismo.", ex)
        End Try
    End Function

#End Region
    
End Class

Partial Public Class BautismoFacade

#Region "Actas"

    Public Function ActaBautismo(ByVal sessionID As Guid, ByVal idBautismo As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New BautismoService(sessionID, Connection, Transaction)
            dtList = Svc.ActaBautismo(idBautismo)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

#End Region

    
End Class
