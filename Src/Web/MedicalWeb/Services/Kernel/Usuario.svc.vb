Imports Azteca.Kernel.Security
Imports Azteca.Data

Namespace Services.Kernel


    Public Class Usuario
        Implements IUsuario

        Public Overloads Function SearchKeyword(sessionID As Guid, keyword As String) As String Implements IUsuario.SearchKeyword
            Try
                Dim UsuarioFac As New UsuarioFacade()
                Dim dtResult As DataTable = UsuarioFac.Search(sessionID, keyword)
                Return JsonConvert.SerializeObject(dtResult)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return String.Empty
            End Try
        End Function

        Public Function Login(userName As String, password As String) As String Implements IUsuario.Login
            Try
                Dim UsuarioFac As New UsuarioFacade()
                Dim Sesssion As SessionInfo = UsuarioFac.LogIn(userName, password, String.Empty)
                If Sesssion Is Nothing Then
                    Throw New Exception("Nombre de usuario o password incorrectos")
                Else
                    Return JsonConvert.SerializeObject(Sesssion)
                End If
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function


        Public Sub ChangeStatus(sessionID As System.Guid, itemId As Integer, active As Boolean) Implements ICatalogWebService.ChangeStatus
            Try
                Dim UsuarioFac As New UsuarioFacade()
                UsuarioFac.ChangeStatus(sessionID, itemId, active)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
            End Try
        End Sub

        Public Function Create(sessionID As System.Guid) As String Implements ICatalogWebService.Create
            Try
                Dim UsuarioFac As New UsuarioFacade()
                Return UsuarioFac.Create(sessionID).GetJSON()
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function Delete(sessionID As System.Guid, itemID As Integer) As Boolean Implements ICatalogWebService.Delete
            Try
                Dim UsuarioFac As New UsuarioFacade()
                UsuarioFac.Delete(sessionID, itemID)
                Return True
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function ExistsCode(sessionID As System.Guid, idBranch As Integer, code As String) As Boolean Implements ICatalogWebService.ExistsCode
            Try
                Dim UsuarioFac As New UsuarioFacade()
                Return UsuarioFac.Exists(sessionID, code, idBranch)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
                Return False
            End Try
        End Function

        Public Function ExistsID(sessionID As System.Guid, itemID As Integer) As Boolean Implements ICatalogWebService.ExistsID
            Dim returns As Boolean = False
            Try
                Dim UsuarioFac As New UsuarioFacade()
                returns = UsuarioFac.Exists(sessionID, itemID)
            Catch ex As Exception
                ErrorHandler.HandleException(ex)
            End Try
            Return returns
        End Function

        Public Function GetDetailByCode(sessionID As System.Guid, idBranch As Integer, code As String, checkStatus As Boolean) As String Implements ICatalogWebService.GetDetailByCode
            Try
                Dim UsuarioFac As New UsuarioFacade()
                Return JsonConvert.SerializeObject(UsuarioFac.GetDetail(sessionID, code, idBranch))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function GetDetailByID(sessionID As System.Guid, itemID As Integer, checkStatus As Boolean) As String Implements ICatalogWebService.GetDetailByID
            Try
                Dim UsuarioFac As New UsuarioFacade()
                Return JsonConvert.SerializeObject(UsuarioFac.GetDetail(sessionID, itemID, checkStatus))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

        Public Function LoadList(sessionID As Guid, idBranch As Integer) As String Implements ICatalogWebService.LoadList

        End Function

        Public Function Search(sessionID As System.Guid, idBranch As Integer, conditions As String, sortOrder As String, page As Integer) As String Implements ICatalogWebService.Search
            Try
                Dim UsuarioFac As New UsuarioFacade()
                Dim Condiciones As Azteca.Kernel.Search.SearchConditionCollection = Nothing
                If Not IsNothing(conditions) Then Condiciones = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchConditionCollection)(conditions)
                Dim Orden As Azteca.Kernel.Search.SearchOrderCollection = Nothing
                If Not IsNothing(sortOrder) Then Orden = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchOrderCollection)(sortOrder)
                'Azteca.Kernel.Search.SearchResult Result =  new SearchResult();
                Dim Result = New Azteca.Web.Services.Kernel.Search.SearchResult
                Dim ds As DataSet = UsuarioFac.GetSearchResult(sessionID, idBranch, Condiciones, Orden, page)

                Result.TotalRows = UsuarioFac.GetTotalRows(sessionID, idBranch, Condiciones)
                Result.Rows = ds.Tables(0)
                Return Newtonsoft.Json.JsonConvert.SerializeObject(Result)
            Catch Ex As Exception
                Return ErrorHandler.HandleException(Ex)
            End Try
        End Function

        Public Function Update(sessionID As System.Guid, info As String) As String Implements ICatalogWebService.Update
            Dim id As Integer = 0
            Try
                Dim UsuarioFac As New UsuarioFacade()
                Dim Usuario As UsuarioInfo = UsuarioFac.Create(info)
                id = UsuarioFac.Update(Usuario)
            Catch ex As Exception
                Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
            End Try
            Return id.ToString
        End Function

        Public Function CargarAccesos(sessionID As System.Guid, idUsuario As Integer) As String Implements IUsuario.CargarAccesos
            Dim Connection As IDbConnection = Nothing
            Dim Result As String = String.Empty
            Try
                Connection = DataServices.OpenConnection()
                Dim fxAccesos As New FunctionSQL("Medicine", "fxUsuarioAccesos", Connection, Nothing)
                fxAccesos.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
                fxAccesos.SortExpression = "Nombre"
                Dim dtAccesos As DataTable = fxAccesos.GetTable()
                Result = JsonConvert.SerializeObject(dtAccesos)
            Catch ex As Exception
                Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
            Finally
                DataServices.CloseConnection(Connection)
            End Try
            Return Result
        End Function

        Public Function GuardarAccesos(sessionID As System.Guid, idUsuario As Integer, accesos As String) As String Implements IUsuario.GuardarAccesos
            Dim Connection As IDbConnection = Nothing
            Dim Result As String = String.Empty
            Try
                Connection = DataServices.OpenConnection()
                Dim dtAccesos As DataTable = JsonConvert.DeserializeObject(Of DataTable)(accesos)
                For Each dr As DataRow In dtAccesos.Rows
                    Dim spUpdate As New StoredProcedure("Medicine", "UsuarioAccesosUPD", Connection, Nothing)
                    spUpdate.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
                    spUpdate.Parameters.Add("@IdProceso", DbType.Int32).Value = CInt(dr("IdProceso"))
                    spUpdate.Parameters.Add("@Acceso", DbType.Boolean).Value = CInt(dr("Acceso"))
                    spUpdate.Execute()
                Next            
            Catch ex As Exception
                Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
            Finally
                DataServices.CloseConnection(Connection)
            End Try
            Return Result
        End Function
    End Class

End Namespace