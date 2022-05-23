Partial Class DoctorService

    Public Function GetDoctorByUser(idUsuario As Integer) As DoctorInfo
        Try
            Dim IdUsuarioToLoad = idUsuario
            If IdUsuarioToLoad = 0 Then IdUsuarioToLoad = Session.User.Identity
            Dim fxDoctorId As New FunctionSQL("Medicine", "fxDoctorByUser", Connection, Transaction)
            fxDoctorId.Parameters.Add("@IdUsuario", DbType.Int32).Value = IdUsuarioToLoad
            Dim IdDoctor As Integer = CInt(fxDoctorId.GetScalar)
            If IdDoctor > 0 Then
                Dim DoctorSvc As New DoctorService(SessionID, Connection, Transaction)
                Dim DoctorInf As New DoctorInfo(SessionID)
                DoctorSvc.GetDetail(IdDoctor, DoctorInf, False)
                Return DoctorInf
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la información del doctor perteneciente al usuario: " & idUsuario)
        End Try
    End Function

    Public Function CargarEspecialidades() As DataTable
        Dim dtEspecialidades As DataTable = Nothing
        Try
            Dim fxEspecialidades As New FunctionSQL("Medicine", "fxEspecialidadesList", Connection, Transaction)
            dtEspecialidades = fxEspecialidades.GetTable()
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de especialidades", ex)
        End Try
        Return dtEspecialidades
    End Function

    Public Function ResumenConsultas(FechaIni As Date, FechaFin As Date) As DataTable
        Try
            Dim fxSearch As New FunctionSQL("Medicine", "fxResumenConsultarRPT", Connection, Transaction)
            fxSearch.Parameters.Add("@FechaINI", DbType.Date).Value = FechaIni.ToShortDateString
            fxSearch.Parameters.Add("@FechaFIN", DbType.Date).Value = FechaFin.ToShortDateString
            Dim dtResult As DataTable = fxSearch.GetTable()
            Return dtResult
        Catch ex As Exception
            Throw New BusinessException("Error al Consultar el Resumen de Consultas Medicas", ex)
        End Try
    End Function

    Public Function Search(keyword As String) As DataTable
        Try
            Dim fxSearch As New FunctionSQL("Medicine", "fxDoctoresSearch", Connection, Transaction)
            fxSearch.Parameters.Add("@Keyword", DbType.String).Value = keyword
            Dim dtResult As DataTable = fxSearch.GetTable()
            Return dtResult
        Catch ex As Exception
            Throw New BusinessException("Error al realizar la búsqueda por palabra clave: '" & keyword & "'", ex)
        End Try
    End Function
End Class


Partial Class DoctorFacade

    Public Function GetDoctorByUser(sessionID As Guid, idUsuario As Integer) As DoctorInfo
        Dim Doctor As DoctorInfo = Nothing
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New DoctorService(sessionID, Connection, Transaction)
            Doctor = Svc.GetDoctorByUser(idUsuario)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Doctor
    End Function


    Public Function CargarEspecialidades(sessionID As Guid) As DataTable
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New DoctorService(sessionID, Connection, Transaction)
            dtList = Svc.CargarEspecialidades()
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Sub ChangeStatus(sessionID As Guid, itemID As Integer, active As Boolean)
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New DoctorService(sessionID, Connection, Transaction)
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
            Dim Svc As New DoctorService(sessionID, Connection, Transaction)
            dtResult = Svc.Search(keyword)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtResult
    End Function

    Public Function GetTotalRows(sessionID As Guid, idSite As Integer, conditions As Azteca.Kernel.Search.SearchConditionCollection) As Integer
        Dim TotalRows As Integer = 0
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New DoctorService(sessionID, Connection, Transaction)
            TotalRows = Svc.GetTotalRows(idSite, conditions)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return TotalRows
    End Function

    Public Function ResumenConsultas(sessionID As Guid, FechaIni As Date, FechaFin As Date) As DataTable
        Dim dtResult As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection()
            Dim Svc As New DoctorService(sessionID, Connection, Transaction)
            dtResult = Svc.ResumenConsultas(FechaIni, FechaFin)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtResult
    End Function
End Class
