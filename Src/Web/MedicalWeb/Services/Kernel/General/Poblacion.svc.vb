' NOTE: You can use the "Rename" command on the context menu to change the class name "Poblacion" in code, svc and config file together.
Imports Azteca.Kernel.General

Namespace Services.Kernel.General

    Public Class Poblacion
        Implements IPoblacion

        Public Overloads Function SearchKeyword(sessionID As Guid, keyword As String) As String Implements IPoblacion.SearchKeyword
            Try
                Dim PoblacionFac As New PoblacionFacade()                
                Dim dtResult As DataTable = PoblacionFac.Search(sessionID, keyword)
                Return JsonConvert.SerializeObject(dtResult)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return String.Empty
            End Try
        End Function

        Public Sub ChangeStatus(sessionID As System.Guid, itemId As Integer, active As Boolean) Implements Services.Kernel.ICatalogWebService.ChangeStatus
            Try
                Dim PoblacionFac As New PoblacionFacade()
                PoblacionFac.ChangeStatus(sessionID, itemId, active)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
            End Try
        End Sub



        Public Function Create(sessionID As System.Guid) As String Implements Services.Kernel.ICatalogWebService.Create
            Try
                Dim PoblacionFac As New PoblacionFacade()

                Return PoblacionFac.Create(sessionID).GetJSON()
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function Delete(sessionID As System.Guid, itemID As Integer) As Boolean Implements Services.Kernel.ICatalogWebService.Delete
            Try
                Dim PoblacionFac As New PoblacionFacade()
                PoblacionFac.Delete(sessionID, itemID)
                Return True
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function ExistsCode(sessionID As System.Guid, idBranch As Integer, code As String) As Boolean Implements Services.Kernel.ICatalogWebService.ExistsCode
            Try
                Dim PoblacionFac As New PoblacionFacade()
                Return PoblacionFac.Exists(sessionID, code, idBranch)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function ExistsID(sessionID As System.Guid, itemID As Integer) As Boolean Implements Services.Kernel.ICatalogWebService.ExistsID
            Dim returns As Boolean = False
            Try
                Dim PoblacionFac As New PoblacionFacade()
                returns = PoblacionFac.Exists(sessionID, itemID)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
            End Try
            Return returns
        End Function

        Public Function GetDetailByCode(sessionID As System.Guid, idBranch As Integer, code As String, checkStatus As Boolean) As String Implements Services.Kernel.ICatalogWebService.GetDetailByCode
            Try
                Dim PoblacionFac As New PoblacionFacade()
                Return JsonConvert.SerializeObject(PoblacionFac.GetDetail(sessionID, code, idBranch))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function GetDetailByID(sessionID As System.Guid, itemID As Integer, checkStatus As Boolean) As String Implements Services.Kernel.ICatalogWebService.GetDetailByID
            Try
                Dim PoblacionFac As New PoblacionFacade()
                Return JsonConvert.SerializeObject(PoblacionFac.GetDetail(sessionID, itemID, checkStatus))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function LoadList(sessionID As Guid, idBranch As Integer) As String Implements Services.Kernel.ICatalogWebService.LoadList
            Return Nothing
        End Function

        Public Function Search(sessionID As System.Guid, idBranch As Integer, conditions As String, sortOrder As String, page As Integer) As String Implements Services.Kernel.ICatalogWebService.Search
            Try
                Dim PoblacionFac As New PoblacionFacade()
                Dim Condiciones As Azteca.Kernel.Search.SearchConditionCollection = Nothing
                If Not IsNothing(conditions) Then Condiciones = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchConditionCollection)(conditions)
                Dim Orden As Azteca.Kernel.Search.SearchOrderCollection = Nothing
                If Not IsNothing(sortOrder) Then Orden = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchOrderCollection)(sortOrder)
                'Azteca.Kernel.Search.SearchResult Result =  new SearchResult();
                Dim Result = New Azteca.Web.Services.Kernel.Search.SearchResult
                Dim ds As DataSet = PoblacionFac.GetSearchResult(sessionID, idBranch, Condiciones, Orden, page)

                Result.TotalRows = PoblacionFac.GetTotalRows(sessionID, idBranch, Condiciones)
                Result.Rows = ds.Tables(0)
                Return Newtonsoft.Json.JsonConvert.SerializeObject(Result)
            Catch Ex As Exception
                Return ErrorHandler.HandleException(Ex)
            End Try
        End Function

        Public Function Update(sessionID As System.Guid, info As String) As String Implements Services.Kernel.ICatalogWebService.Update
            Dim id As Integer = 0
            Try
                Dim PoblacionFac As New PoblacionFacade()
                Dim Poblacion As PoblacionInfo = PoblacionFac.Create(sessionID)
                id = PoblacionFac.Update(Poblacion)
            Catch ex As Exception
                Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
            End Try
            Return id.ToString
        End Function

    End Class

End Namespace