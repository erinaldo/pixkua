Imports Azteca.Business.Ventas
Imports Newtonsoft.Json
Imports Azteca.Kernel.Search
Imports Azteca.Web.Services.Kernel

Namespace Services.Ventas

    Public Class Cliente
        Implements Services.Ventas.ICliente

        Public Function Create(sessionID As System.Guid) As String Implements Services.Kernel.ICatalogWebService.Create
            Try
                Dim ClienteFac As New ClienteFacade
                Return JsonConvert.SerializeObject(ClienteFac.Create(sessionID))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function Delete(sessionID As System.Guid, itemID As Integer) As Boolean Implements Services.Kernel.ICatalogWebService.Delete
            Try
                Dim ClienteFac As New ClienteFacade
                ClienteFac.Delete(sessionID, itemID)
                Return True
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function ExistsCode(sessionID As System.Guid, idBranch As Integer, code As String) As Boolean Implements Services.Kernel.ICatalogWebService.ExistsCode
            Try
                Dim ClienteFac As New ClienteFacade
                Return ClienteFac.Exists(sessionID, code, idBranch)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function ExistsID(sessionID As System.Guid, itemID As Integer) As Boolean Implements Services.Kernel.ICatalogWebService.ExistsID
            Dim returns As Boolean = False
            Try
                Dim ClienteFac As New ClienteFacade
                returns = ClienteFac.Exists(sessionID, itemID)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
            End Try
            Return returns
        End Function

        Public Function GetDetailByCode(sessionID As System.Guid, idBranch As Integer, code As String, checkStatus As Boolean) As Object Implements Services.Kernel.ICatalogWebService.GetDetailByCode
            Try
                Dim ClienteFac As New ClienteFacade
                Return JsonConvert.SerializeObject(ClienteFac.GetDetail(sessionID, code, idBranch))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function GetDetailByID(sessionID As System.Guid, itemID As Integer, checkStatus As Boolean) As Object Implements Services.Kernel.ICatalogWebService.GetDetailByID
            Try
                Dim ClienteFac As New ClienteFacade
                Return JsonConvert.SerializeObject(ClienteFac.GetDetail(sessionID, itemID, checkStatus))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function LoadList(idBranch As Integer) As String Implements Services.Kernel.ICatalogWebService.LoadList
            Return Nothing
        End Function

        Public Function Update(sessionID As System.Guid, info As String) As String Implements Services.Kernel.ICatalogWebService.Update
            Dim id As Integer
            Try
                Dim ClienteFac As New ClienteFacade
                Dim Cliente As ClienteInfo = JsonConvert.DeserializeObject(Of ClienteInfo)(info)
                Cliente = ClienteFac.Create(info)
                id = ClienteFac.Update(Cliente)
            Catch ex As Exception
                Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
            End Try
            Return id.ToString
        End Function

        Public Function Search(sessionID As Guid, idBranch As Integer, conditions As String, sortOrder As String, page As Integer) As String Implements ICatalogWebService.Search

            Try
                Dim ClienteFac As New ClienteFacade
                Dim Condiciones As Azteca.Kernel.Search.SearchConditionCollection = Nothing
                If Not IsNothing(conditions) Then Condiciones = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchConditionCollection)(conditions)
                Dim Orden As Azteca.Kernel.Search.SearchOrderCollection = Nothing
                If Not IsNothing(sortOrder) Then Orden = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchOrderCollection)(sortOrder)
                'Azteca.Kernel.Search.SearchResult Result =  new SearchResult();
                Dim Result = New Azteca.Web.Services.Kernel.Search.SearchResult
                Dim ds As DataSet = ClienteFac.GetSearchResult(sessionID, idBranch, Condiciones, Orden, page)

                Result.TotalRows = Result.TotalRows = ClienteFac.GetSearchResult(sessionID, idBranch, Condiciones, Orden, 0).Tables(0).Rows.Count
                Result.Rows = ds.Tables(0) 'ClienteFac.Search(sessionID, idBranch, Condiciones, Orden, page)
                Return Newtonsoft.Json.JsonConvert.SerializeObject(Result)
            Catch Ex As Exception
                Return ErrorHandler.HandleException(Ex)
            End Try
        End Function

        Public Sub ChangeStatus(sessionID As Guid, itemId As Integer, Active As Boolean) Implements ICatalogWebService.ChangeStatus
            Try
                Dim ClienteSvc As New ClienteService(sessionID)
                Dim ClienteFac As New ClienteFacade
                'ClienteFac.ChangeStatus(ClienteSvc, itemId, Active)
            Catch ex As Exception
                Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
            End Try
        End Sub

    End Class

 

End Namespace