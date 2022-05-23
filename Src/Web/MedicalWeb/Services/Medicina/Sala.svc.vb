Namespace Services.Medicina

    Public Class Sala
        Implements ISala

        Public Overloads Function SearchKeyword(sessionID As Guid, keyword As String) As String Implements ISala.SearchKeyword
            Try
                Dim SalaFac As New SalaFacade()
                Dim dtResult As DataTable = SalaFac.Search(sessionID, keyword)
                Return JsonConvert.SerializeObject(dtResult)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return String.Empty
            End Try
        End Function

        Public Sub ChangeStatus(sessionID As System.Guid, itemId As Integer, Active As Boolean) Implements Services.Kernel.ICatalogWebService.ChangeStatus
            Try
                Dim SalaFac As New SalaFacade()
                SalaFac.ChangeStatus(sessionID, itemId, Active)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
            End Try
        End Sub

        Public Function Create(sessionID As System.Guid) As String Implements Services.Kernel.ICatalogWebService.Create
            Try
                Dim SalaFac As New SalaFacade()
                Return SalaFac.Create(sessionID).GetJSON()
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function Delete(sessionID As System.Guid, itemID As Integer) As Boolean Implements Services.Kernel.ICatalogWebService.Delete
            Try
                Dim SalaFac As New SalaFacade()
                SalaFac.Delete(sessionID, itemID)
                Return True
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function ExistsCode(sessionID As System.Guid, idBranch As Integer, code As String) As Boolean Implements Services.Kernel.ICatalogWebService.ExistsCode
            Try
                Dim SalaFac As New SalaFacade()
                Return SalaFac.Exists(sessionID, code, idBranch)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function ExistsID(sessionID As System.Guid, itemID As Integer) As Boolean Implements Services.Kernel.ICatalogWebService.ExistsID
            Dim returns As Boolean = False
            Try
                Dim SalaFac As New SalaFacade()
                returns = SalaFac.Exists(sessionID, itemID)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
            End Try
            Return returns
        End Function

        Public Function GetDetailByCode(sessionID As System.Guid, idBranch As Integer, code As String, checkStatus As Boolean) As String Implements Services.Kernel.ICatalogWebService.GetDetailByCode
            Try
                Dim SalaFac As New SalaFacade()
                Return JsonConvert.SerializeObject(SalaFac.GetDetail(sessionID, code, idBranch))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function GetDetailByID(sessionID As System.Guid, itemID As Integer, checkStatus As Boolean) As String Implements Services.Kernel.ICatalogWebService.GetDetailByID
            Try
                Dim SalaFac As New SalaFacade()
                Return JsonConvert.SerializeObject(SalaFac.GetDetail(sessionID, itemID, checkStatus))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function LoadList(sessionID As Guid, idBranch As Integer) As String Implements Services.Kernel.ICatalogWebService.LoadList
            Try
                Dim SalaFac As New SalaFacade()
                Dim dtList As DataTable = SalaFac.LoadList(sessionID)
                Return JsonConvert.SerializeObject(dtList)
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function Search(sessionID As System.Guid, idBranch As Integer, conditions As String, sortOrder As String, page As Integer) As String Implements Services.Kernel.ICatalogWebService.Search
            Try
                Dim SalaFac As New SalaFacade()
                Dim Condiciones As Azteca.Kernel.Search.SearchConditionCollection = Nothing
                If Not IsNothing(conditions) Then Condiciones = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchConditionCollection)(conditions)
                Dim Orden As Azteca.Kernel.Search.SearchOrderCollection = Nothing
                If Not IsNothing(sortOrder) Then Orden = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchOrderCollection)(sortOrder)
                'Azteca.Kernel.Search.SearchResult Result =  new SearchResult();
                Dim Result = New Azteca.Web.Services.Kernel.Search.SearchResult
                Dim ds As DataSet = SalaFac.GetSearchResult(sessionID, idBranch, Condiciones, Orden, page)

                Result.TotalRows = SalaFac.GetTotalRows(sessionID, idBranch, Condiciones)
                Result.Rows = ds.Tables(0)
                Return Newtonsoft.Json.JsonConvert.SerializeObject(Result)
            Catch Ex As Exception
                Return ErrorHandler.HandleException(Ex)
            End Try
        End Function

        Public Function Update(sessionID As System.Guid, info As String) As String Implements Services.Kernel.ICatalogWebService.Update
            Dim id As Integer = 0
            Try
                Dim SalaFac As New SalaFacade()
                Dim Sala As SalaInfo = SalaFac.Create(info)
                id = SalaFac.Update(Sala)
            Catch ex As Exception
                Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
            End Try
            Return id.ToString
        End Function

        Public Function AgendarEvento(sessionID As Guid, evento As String) As String Implements ISala.AgendarEvento
            Try
                Dim SalaFac As New SalaFacade
                Dim NewEvent As EventoSala = JsonConvert.DeserializeObject(Of EventoSala)(evento)
                NewEvent.FechaRegistro = Date.Now
                Dim RetEvent As EventoSala = SalaFac.AgendarEvento(sessionID, NewEvent)
                Return JsonConvert.SerializeObject(RetEvent)
            Catch ex As Exception
                Return Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function CargarAgenda(sessionID As Guid, idSala As Integer) As String Implements ISala.CargarAgenda
            Try
                Dim SalaFac As New SalaFacade()
                Dim Agenda As List(Of EventoSala) = SalaFac.CargarAgenda(sessionID, idSala, Date.Today.AddDays(-60), Date.Today.AddDays(30))
                Return JsonConvert.SerializeObject(Agenda)
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function EliminarEvento(sessionID As System.Guid, idEvento As Integer) As Boolean Implements ISala.EliminarEvento
            Try
                Dim SalaFac As New SalaFacade
                SalaFac.EliminarEvento(sessionID, idEvento)
                Return True
            Catch ex As Exception
                Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function


#Region "Seguridad"

        Public Function AddUser(sessionID As Guid, idSala As Integer, idUsuario As Integer) As Boolean Implements ISala.AddUser
            Try
                Dim SalaFac As New SalaFacade
                SalaFac.AddUser(sessionID, idSala, idUsuario)
                Return True
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function RemoveUser(sessionID As Guid, idSala As Integer, idUsuario As Integer) As Boolean Implements ISala.RemoveUser
            Try
                Dim SalaFac As New SalaFacade
                SalaFac.RemoveUser(sessionID, idSala, idUsuario)
                Return True
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try

        End Function

        Public Function LoadUserAccess(sessionID As Guid, idSala As Integer) As String Implements ISala.LoadUserAccess
            Dim dtRet As New DataTable
            Try
                Dim SalaFac As New SalaFacade
                dtRet = SalaFac.LoadUserAccess(sessionID, idSala)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
            End Try
            Return Newtonsoft.Json.JsonConvert.SerializeObject(dtRet)
        End Function

        'Public Function UpdateUser(sessionID As Guid, idSala As Integer, idUsuario As Integer) As Boolean
        'Try
        '        Dim SalaFac As New SalaFacade
        '        SalaFac.UpdateUser(sessionID, idSala, idUsuario)
        '        Return True
        '    Catch ex As Exception
        '        ErrorHandler.HandleException(ex)
        '        Return False
        '    End Try
        'End Function
#End Region

    End Class

End Namespace
