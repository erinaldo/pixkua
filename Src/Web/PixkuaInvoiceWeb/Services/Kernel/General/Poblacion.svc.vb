' NOTE: You can use the "Rename" command on the context menu to change the class name "Poblacion" in code, svc and config file together.
Imports Azteca.Kernel.General

Namespace Services.Kernel.General

    Public Class Poblacion
        Implements IPoblacion

        Public Function LoadList(sessionID As Guid, idMunicipio As Integer) As String Implements IPoblacion.LoadList
            Dim PoblacionFac As New PoblacionFacade
            Dim dtList As DataTable = PoblacionFac.LoadList(sessionID, idMunicipio)
            Return Newtonsoft.Json.JsonConvert.SerializeObject(dtList)
        End Function

        Public Function Search(sessionID As Guid, idBranch As Integer, conditions As String, sortOrder As String, page As Integer) As String Implements IPoblacion.Search
            Dim PoblacionFac As New PoblacionFacade
            Dim Condiciones As Azteca.Kernel.Search.SearchConditionCollection = Nothing
            If Not IsNothing(conditions) Then Condiciones = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchConditionCollection)(conditions)

            Dim Orden As Azteca.Kernel.Search.SearchOrderCollection = Nothing
            If Not IsNothing(sortOrder) Then Orden = JsonConvert.DeserializeObject(Of Azteca.Kernel.Search.SearchOrderCollection)(sortOrder)
            'Azteca.Kernel.Search.SearchResult Result =  new SearchResult();
            Dim Result = New Azteca.Web.Services.Kernel.Search.SearchResult
            Dim ds As DataSet = PoblacionFac.GetSearchResult(sessionID, idBranch, Condiciones, Orden, page)

            Result.TotalRows = PoblacionFac.GetSearchResult(sessionID, idBranch, Condiciones, Orden, 0).Tables(0).Rows.Count
            Result.Rows = ds.Tables(0) 'ClienteFac.Search(sessionID, idBranch, Condiciones, Orden, page)
            Return Newtonsoft.Json.JsonConvert.SerializeObject(Result)
        End Function

    End Class

End Namespace