''' <summary>
''' Paquete de informaci�n que representa un ContabilizadorDocumentos
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ContabilizadorDocumentosInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property IdDocumentoTipo As Integer

    Public Property IdVistaContableTit As Integer

    Public Property racsVariables As Boolean

    Public Property WorkflowTable As ContabilizadorWorkflowDS.WorkflowContableDataTable

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        _WorkflowTable = New ContabilizadorWorkflowDS.WorkflowContableDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de ContabilizacionDocumentosTit
''' </summary>
''' <remarks></remarks>
Public Class ContabilizadorDocumentosService
    Inherits CatalogService(Of ContabilizadorDocumentosInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "ContabilizacionDocumentosTit", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idContabilizadorDocumentos As Integer, ByRef ContabilizadorDocumentos As ContabilizadorDocumentosInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idContabilizadorDocumentos, ContabilizadorDocumentos, checkStatus)
        With ContabilizadorDocumentos
            .IdDocumentoTipo = CInt(ItemInfo("IdDocumentoTipo"))
            .IdVistaContableTit = CInt(ItemInfo("IdVistaContableTit"))
        End With
        loadWorkflow(ContabilizadorDocumentos)
    End Sub

    Public Overrides Function Update(ByVal ContabilizadorDocumentos As ContabilizadorDocumentosInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@IdDocumentoTipo", DbType.Int32).Value = ContabilizadorDocumentos.IdDocumentoTipo
            .Add("@IdVistaContableTit", DbType.String).Value = ContabilizadorDocumentos.IdVistaContableTit
        End With
        Dim id As Integer = MyBase.Update(ContabilizadorDocumentos)
        saveWorkflow(ContabilizadorDocumentos)
        Return id
    End Function

    Public Overrides Function Create() As ContabilizadorDocumentosInfo
        Return New ContabilizadorDocumentosInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"
    Private Sub saveWorkflow(ByVal info As ContabilizadorDocumentosInfo)
        Dim cmd As New DbCommand("Accounting.ContabilizacionDocumentosDetUPD", Me.Connection, Me.Transaction)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@IdcontabilizacionDocumentoDet", DbType.Int32, "IdcontabilizacionDocumentoDet")
        cmd.Parameters.Add("@IdcontabilizacionDocumentoTit", DbType.Int32).Value = info.Identity
        cmd.Parameters.Add("@Variante", DbType.Boolean, "Variante")
        cmd.Parameters.Add("@IdStatus", DbType.Int32, "IdStatus")
        cmd.Parameters.Add("@IdRacTit", DbType.Int32, "IdRacTit")

        Dim da As New Azteca.Data.DataAdapter
        da.InsertCommand = cmd : da.UpdateCommand = cmd
        da.Update(info.WorkflowTable)
    End Sub

    Private Sub loadWorkflow(ByVal info As ContabilizadorDocumentosInfo)
        Try
            Dim fx As New FunctionSQL("Accounting", "fxContabilizacionDocumentosDetSEL", Connection, Transaction)
            fx.Parameters.Add("@IdContabilizacionDocumentoTit", DbType.Int32).Value = info.Identity
            fx.FillDataTable(info.WorkflowTable)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el flujo de trabajo", ex)
        End Try
    End Sub

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de ContabilizacionDocumentosTit
''' </summary>
''' <remarks></remarks>
Public Class ContabilizadorDocumentosFacade
    Inherits CatalogFacade(Of ContabilizadorDocumentosInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ContabilizadorDocumentosInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ContabilizadorDocumentosInfo
        Dim ContabilizadorDocumentosSvc As New ContabilizadorDocumentosService(sessionID)
        Return ContabilizadorDocumentosSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de ContabilizacionDocumentosTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idContabilizadorDocumentos">Identificador del ContabilizadorDocumentos que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idContabilizadorDocumentos As Integer)
        Dim ContabilizadorDocumentosSvc As New ContabilizadorDocumentosService(sessionID)
        Delete(ContabilizadorDocumentosSvc, idContabilizadorDocumentos)
    End Sub

    ''' <summary>
    ''' Verifica si existe un ContabilizadorDocumentos con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idContabilizadorDocumentos">ID de ContabilizadorDocumentos que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idContabilizadorDocumentos As Integer) As Boolean
        Dim ContabilizadorDocumentosSvc As New ContabilizadorDocumentosService(sessionID)
        Return Exists(ContabilizadorDocumentosSvc, idContabilizadorDocumentos)
    End Function

    ''' <summary>
    ''' Verifica si existe un ContabilizadorDocumentos con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ContabilizadorDocumentosSvc As New ContabilizadorDocumentosService(sessionID)
        Return Exists(ContabilizadorDocumentosSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un ContabilizadorDocumentos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idContabilizadorDocumentos">Identificador de ContabilizadorDocumentos a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo ContabilizadorDocumentosInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idContabilizadorDocumentos As Integer) As ContabilizadorDocumentosInfo
        Return Me.GetDetail(sessionID, idContabilizadorDocumentos, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un ContabilizadorDocumentos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idContabilizadorDocumentos">Identificador de ContabilizadorDocumentos</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ContabilizadorDocumentos.</param>
    ''' <returns>Paquete de informaci�n de tipo ContabilizadorDocumentosInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idContabilizadorDocumentos As Integer, ByVal checkStatus As Boolean) As ContabilizadorDocumentosInfo
        Dim ContabilizadorDocumentosSvc As New ContabilizadorDocumentosService(sessionID)
        Dim ContabilizadorDocumentosInf As New ContabilizadorDocumentosInfo(sessionID)
        GetDetail(ContabilizadorDocumentosSvc, ContabilizadorDocumentosInf, idContabilizadorDocumentos, checkStatus)
        Return ContabilizadorDocumentosInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un ContabilizadorDocumentos en base a su codigo de usuario
    ''' y verifica que el ContabilizadorDocumentos est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n ContabilizadorDocumentosInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ContabilizadorDocumentosInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un ContabilizadorDocumentos en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ContabilizadorDocumentos</param>
    ''' <returns>Paquete de informaci�n ContabilizadorDocumentosInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ContabilizadorDocumentosInfo
        Dim ContabilizadorDocumentosInf As New ContabilizadorDocumentosInfo(sessionID)
        Dim ContabilizadorDocumentosSvc As New ContabilizadorDocumentosService(sessionID)
        GetDetail(ContabilizadorDocumentosSvc, ContabilizadorDocumentosInf, userCode, idSucursal, checkStatus)
        Return ContabilizadorDocumentosInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un ContabilizadorDocumentos.
    ''' </summary>
    ''' <param name="ContabilizadorDocumentos">Paquete de informaci�n del tipo ContabilizadorDocumentosInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de ContabilizadorDocumentos, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal ContabilizadorDocumentos As ContabilizadorDocumentosInfo) As Integer
        Dim ContabilizadorDocumentosSvc As New ContabilizadorDocumentosService(ContabilizadorDocumentos.SessionID)
        Return Update(ContabilizadorDocumentosSvc, ContabilizadorDocumentos)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ContabilizadorDocumentosSvc As New ContabilizadorDocumentosService(sessionID)
        Return GetNumberOfPages(ContabilizadorDocumentosSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca ContabilizacionDocumentosTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca ContabilizacionDocumentosTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ContabilizadorDocumentosSvc As New ContabilizadorDocumentosService(sessionID)
        Return GetSearchResult(ContabilizadorDocumentosSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de ContabilizacionDocumentosTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ContabilizadorDocumentosSvc As New ContabilizadorDocumentosService(sessionID)
        Return GetSearchStructure(ContabilizadorDocumentosSvc)
    End Function

#End Region

End Class
