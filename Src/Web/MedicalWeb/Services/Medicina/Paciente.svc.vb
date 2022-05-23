Namespace Services.Medicina

    Public Class Paciente
        Implements IPaciente


        Public Overloads Function SearchKeyword(sessionID As Guid, keyword As String) As String Implements IPaciente.SearchKeyword
            Try
                Dim PacienteFac As New PacienteFacade()
                Dim dtResult As DataTable = PacienteFac.Search(sessionID, keyword)
                Return JsonConvert.SerializeObject(dtResult)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return String.Empty
            End Try
        End Function

        Public Sub ChangeStatus(sessionID As System.Guid, itemId As Integer, active As Boolean) Implements Services.Kernel.ICatalogWebService.ChangeStatus
            Try
                Dim PacienteFac As New PacienteFacade()
                PacienteFac.ChangeStatus(sessionID, itemId, active)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
            End Try
        End Sub



        Public Function Create(sessionID As System.Guid) As String Implements Services.Kernel.ICatalogWebService.Create
            Try
                Dim PacienteFac As New PacienteFacade()

                Return PacienteFac.Create(sessionID).GetJSON()
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function Delete(sessionID As System.Guid, itemID As Integer) As Boolean Implements Services.Kernel.ICatalogWebService.Delete
            Try
                Dim PacienteFac As New PacienteFacade()
                PacienteFac.Delete(sessionID, itemID)
                Return True
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function ExistsCode(sessionID As System.Guid, idBranch As Integer, code As String) As Boolean Implements Services.Kernel.ICatalogWebService.ExistsCode
            Try
                Dim PacienteFac As New PacienteFacade()
                Return PacienteFac.Exists(sessionID, code, idBranch)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function ExistsID(sessionID As System.Guid, itemID As Integer) As Boolean Implements Services.Kernel.ICatalogWebService.ExistsID
            Dim returns As Boolean = False
            Try
                Dim PacienteFac As New PacienteFacade()
                returns = PacienteFac.Exists(sessionID, itemID)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
            End Try
            Return returns
        End Function

        Public Function GetDetailByCode(sessionID As System.Guid, idBranch As Integer, code As String, checkStatus As Boolean) As String Implements Services.Kernel.ICatalogWebService.GetDetailByCode
            Try
                Dim PacienteFac As New PacienteFacade()
                Return JsonConvert.SerializeObject(PacienteFac.GetDetail(sessionID, code, idBranch))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function GetDetailByID(sessionID As System.Guid, itemID As Integer, checkStatus As Boolean) As String Implements Services.Kernel.ICatalogWebService.GetDetailByID
            Try
                Dim PacienteFac As New PacienteFacade()
                Return JsonConvert.SerializeObject(PacienteFac.GetDetail(sessionID, itemID, checkStatus))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function LoadList(sessionID As Guid, idBranch As Integer) As String Implements Services.Kernel.ICatalogWebService.LoadList
            Return Nothing
        End Function

        Public Function Search(sessionID As System.Guid, idBranch As Integer, conditions As String, sortOrder As String, page As Integer) As String Implements Services.Kernel.ICatalogWebService.Search
            Try
                Dim PacienteFac As New PacienteFacade()
                Dim Condiciones As Azteca.Kernel.Search.SearchConditionCollection = Nothing
                If Not IsNothing(conditions) Then Condiciones = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchConditionCollection)(conditions)
                Dim Orden As Azteca.Kernel.Search.SearchOrderCollection = Nothing
                If Not IsNothing(sortOrder) Then Orden = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchOrderCollection)(sortOrder)
                'Azteca.Kernel.Search.SearchResult Result =  new SearchResult();
                Dim Result = New Azteca.Web.Services.Kernel.Search.SearchResult
                Dim ds As DataSet = PacienteFac.GetSearchResult(sessionID, idBranch, Condiciones, Orden, page)

                Result.TotalRows = PacienteFac.GetTotalRows(sessionID, idBranch, Condiciones)
                Result.Rows = ds.Tables(0)
                Return Newtonsoft.Json.JsonConvert.SerializeObject(Result)
            Catch Ex As Exception
                Return ErrorHandler.HandleException(Ex)
            End Try
        End Function

        Public Function Update(sessionID As System.Guid, info As String) As String Implements Services.Kernel.ICatalogWebService.Update
            Dim id As Integer = 0
            Try
                Dim PacienteFac As New PacienteFacade()
                Dim Paciente As PacienteInfo = PacienteFac.Create(sessionID, info)
                id = PacienteFac.Update(Paciente)
            Catch ex As Exception
                Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
            End Try
            Return id.ToString
        End Function

        Public Function GuardarRegistro(sessionID As Guid, idExpediente As Integer, idDoctor As Integer, idPaciente As Integer, diagnostico As String, medicina As String, motivo As String, generales As String, observaciones As String, tratamiento As String) As Integer Implements IPaciente.GuardarRegistro
            Try
                Dim PacienteFac As New PacienteFacade
                Return PacienteFac.GuardarRegistro(sessionID, idExpediente, idDoctor, idPaciente, diagnostico, medicina, motivo, generales, observaciones, tratamiento)
            Catch ex As Exception
                Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
                Return 0
            End Try
        End Function


        Public Function LoadRegistros(sessionID As System.Guid, idPaciente As Integer) As String Implements IPaciente.LoadRegistros
            Dim Result As String = String.Empty
            Try
                Dim PacienteFac As New PacienteFacade
                Dim dtList As DataTable = PacienteFac.LoadRegistros(sessionID, idPaciente)
                For Each dr As DataRow In dtList.Rows
                    dr("FechaStr") = CDate(dr("Fecha")).ToString("dd/MM/yyyy hh:mm tt")
                Next
                Result = JsonConvert.SerializeObject(dtList)
            Catch ex As Exception
                Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
            End Try
            Return Result
        End Function

    End Class


End Namespace
