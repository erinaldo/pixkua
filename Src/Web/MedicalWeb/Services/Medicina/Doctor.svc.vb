Namespace Services.Medicina

    Public Class Doctor
        Implements IDoctor

        Public Overloads Function SearchKeyword(sessionID As Guid, keyword As String) As String Implements IDoctor.SearchKeyword
            Try
                Dim DoctorFac As New DoctorFacade()
                Dim dtResult As DataTable = DoctorFac.Search(sessionID, keyword)
                Return JsonConvert.SerializeObject(dtResult)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return String.Empty
            End Try
        End Function

        Public Sub ChangeStatus(sessionID As System.Guid, itemId As Integer, Active As Boolean) Implements Services.Kernel.ICatalogWebService.ChangeStatus
            Try
                Dim DoctorFac As New DoctorFacade()
                DoctorFac.ChangeStatus(sessionID, itemId, Active)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
            End Try
        End Sub

        Public Function Create(sessionID As System.Guid) As String Implements Services.Kernel.ICatalogWebService.Create
            Try
                Dim DoctorFac As New DoctorFacade()
                Return DoctorFac.Create(sessionID).GetJSON()
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function Delete(sessionID As System.Guid, itemID As Integer) As Boolean Implements Services.Kernel.ICatalogWebService.Delete
            Try
                Dim DoctorFac As New DoctorFacade()
                DoctorFac.Delete(sessionID, itemID)
                Return True
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function ExistsCode(sessionID As System.Guid, idBranch As Integer, code As String) As Boolean Implements Services.Kernel.ICatalogWebService.ExistsCode
            Try
                Dim DoctorFac As New DoctorFacade()
                Return DoctorFac.Exists(sessionID, code, idBranch)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function ExistsID(sessionID As System.Guid, itemID As Integer) As Boolean Implements Services.Kernel.ICatalogWebService.ExistsID
            Dim returns As Boolean = False
            Try
                Dim DoctorFac As New DoctorFacade()
                returns = DoctorFac.Exists(sessionID, itemID)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
            End Try
            Return returns
        End Function

        Public Function GetDetailByCode(sessionID As System.Guid, idBranch As Integer, code As String, checkStatus As Boolean) As String Implements Services.Kernel.ICatalogWebService.GetDetailByCode
            Try
                Dim DoctorFac As New DoctorFacade()
                Return JsonConvert.SerializeObject(DoctorFac.GetDetail(sessionID, code, idBranch))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function GetDetailByID(sessionID As System.Guid, itemID As Integer, checkStatus As Boolean) As String Implements Services.Kernel.ICatalogWebService.GetDetailByID
            Try
                Dim DoctorFac As New DoctorFacade()
                Return JsonConvert.SerializeObject(DoctorFac.GetDetail(sessionID, itemID, checkStatus))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function LoadList(sessionID As Guid, idBranch As Integer) As String Implements Services.Kernel.ICatalogWebService.LoadList
            Return Nothing
        End Function

        Public Function Search(sessionID As System.Guid, idBranch As Integer, conditions As String, sortOrder As String, page As Integer) As String Implements Services.Kernel.ICatalogWebService.Search
            Try
                Dim DoctorFac As New DoctorFacade()
                Dim Condiciones As Azteca.Kernel.Search.SearchConditionCollection = Nothing
                If Not IsNothing(conditions) Then Condiciones = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchConditionCollection)(conditions)
                Dim Orden As Azteca.Kernel.Search.SearchOrderCollection = Nothing
                If Not IsNothing(sortOrder) Then Orden = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchOrderCollection)(sortOrder)
                'Azteca.Kernel.Search.SearchResult Result =  new SearchResult();
                Dim Result = New Azteca.Web.Services.Kernel.Search.SearchResult
                Dim ds As DataSet = DoctorFac.GetSearchResult(sessionID, idBranch, Condiciones, Orden, page)

                Result.TotalRows = DoctorFac.GetTotalRows(sessionID, idBranch, Condiciones)
                Result.Rows = ds.Tables(0)
                Return Newtonsoft.Json.JsonConvert.SerializeObject(Result)
            Catch Ex As Exception
                Return ErrorHandler.HandleException(Ex)
            End Try
        End Function

        Public Function Update(sessionID As System.Guid, info As String) As String Implements Services.Kernel.ICatalogWebService.Update
            Dim id As Integer = 0
            Try
                Dim DoctorFac As New DoctorFacade()
                Dim Doctor As DoctorInfo = DoctorFac.Create(info)
                id = DoctorFac.Update(Doctor)
            Catch ex As Exception
                Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
            End Try
            Return id.ToString
        End Function

        Public Function CargarEspecialidades(sessionID As Guid) As String Implements IDoctor.CargarEspecialidades
            Try
                Dim DoctorFac As New DoctorFacade()
                Dim dtResult As DataTable = DoctorFac.CargarEspecialidades(sessionID)
                Return JsonConvert.SerializeObject(dtResult)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return String.Empty
            End Try
        End Function

        Public Function GetDoctorByUser(sessionID As System.Guid, idUsuario As Integer) As String Implements IDoctor.GetDoctorByUser
            Try
                Dim DoctorFac As New DoctorFacade()
                Return JsonConvert.SerializeObject(DoctorFac.GetDoctorByUser(sessionID, idUsuario))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function
    End Class

End Namespace