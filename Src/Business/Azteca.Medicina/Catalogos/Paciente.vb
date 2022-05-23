Partial Class PacienteService

    Public Function Search(keyword As String) As DataTable
        Try
            Dim fxSearch As New FunctionSQL("Medicine", "fxPacienteSearch", Connection, Transaction)
            fxSearch.Parameters.Add("@Keyword", DbType.String).Value = keyword
            fxSearch.SortExpression = "Nombre"
            Dim dtResult As DataTable = fxSearch.GetTable()
            Return dtResult
        Catch ex As Exception
            Throw New BusinessException("Error al realizar la búsqueda por palabra clave: '" & keyword & "'", ex)
        End Try
    End Function

    Public Function GuardarRegistro(idExpediente As Integer, idDoctor As Integer, idPaciente As Integer, diagnostico As String, medicina As String, motivo As String, generales As String, observaciones As String, tratamiento As String) As Integer
        Try
            Dim spUpdate As New StoredProcedure("Medicine", "ExpedienteUPD", Connection, Transaction)
            spUpdate.Parameters.Add("@IdExpediente", DbType.Int32, ParameterDirection.InputOutput).Value = idExpediente
            spUpdate.Parameters.Add("@IdDoctor", DbType.Int32).Value = idDoctor
            spUpdate.Parameters.Add("@IdPaciente", DbType.Int32).Value = idPaciente
            spUpdate.Parameters.Add("@Diagnostico", DbType.String).Value = diagnostico
            spUpdate.Parameters.Add("@Medicina", DbType.String).Value = medicina
            spUpdate.Parameters.Add("@Motivo", DbType.String).Value = motivo
            spUpdate.Parameters.Add("@Generales", DbType.String).Value = generales
            spUpdate.Parameters.Add("@Observaciones", DbType.String).Value = observaciones
            spUpdate.Parameters.Add("@Tratamiento", DbType.String).Value = tratamiento
            spUpdate.Execute()
            Dim RetExpediente As Integer = CInt(spUpdate.Parameters("@IdExpediente").Value)
            Return RetExpediente
        Catch ex As Exception
            Throw New BusinessException("Error al guardar un registro al expediente del paciente: " & idPaciente, ex)
        End Try
    End Function

    Public Function LoadRegistros(idPaciente As Integer) As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Dim fxList As New FunctionSQL("Medicine", "fxPacienteExpediente", Connection, Transaction)
            fxList.Parameters.Add("@IdPaciente", DbType.Int32).Value = idPaciente
            dtList = fxList.GetTable("Registros")
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el expediente del paciente: " & idPaciente.ToString, ex)
        End Try
        Return dtList
    End Function
End Class


Partial Class PacienteFacade

    Public Sub ChangeStatus(sessionID As Guid, itemID As Integer, active As Boolean)
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New PacienteService(sessionID, Connection, Transaction)
            Svc.ChangeStatus(itemID, active)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Function Search(sessionID As Guid, keyword As String) As DataTable
        Dim dtResult As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New PacienteService(sessionID, Connection, Transaction)
            dtResult = Svc.Search(keyword)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtResult
    End Function

    Public Function GuardarRegistro(sessionID As Guid, idExpediente As Integer, idDoctor As Integer, idPaciente As Integer, diagnostico As String, medicina As String, motivo As String, generales As String, observaciones As String, tratamiento As String) As Integer
        Dim RetExpediente As Integer = 0
        Try
            Connection = DataServices.OpenConnection()
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New PacienteService(sessionID, Connection, Transaction)
                RetExpediente = Svc.GuardarRegistro(idExpediente, idDoctor, idPaciente, diagnostico, medicina, motivo, generales, observaciones, tratamiento)
                Transaction.Commit()
            Catch ex As Exception
                Transaction.Rollback()
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return RetExpediente
    End Function


    Public Function LoadRegistros(sessionID As Guid, idPaciente As Integer) As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New PacienteService(sessionID, Connection, Transaction)
            dtList = Svc.LoadRegistros(idPaciente)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function GetTotalRows(sessionID As Guid, idSite As Integer, conditions As Azteca.Kernel.Search.SearchConditionCollection) As Integer
        Dim TotalRows As Integer = 0
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New PacienteService(sessionID, Connection, Transaction)
            TotalRows = Svc.GetTotalRows(idSite, conditions)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return TotalRows
    End Function
End Class
