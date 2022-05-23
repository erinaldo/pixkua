Partial Public Class ComunionService

    Public Function InformeComunion(ByVal idComunion As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Church", "fxActaComunion", Connection, Transaction)
            fxList.Parameters.Add("@IdComunion", DbType.Int32).Value = idComunion
            Dim dtList As DataTable = fxList.GetTable("Comunion")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el acta de primera comunion.", ex)
        End Try
    End Function


End Class

Partial Public Class ComunionFacade

    Public Function InformeComunion(ByVal sessionID As Guid, ByVal idComunion As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComunionService(sessionID, Connection, Transaction)
            dtList = Svc.InformeComunion(idComunion)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function


End Class
