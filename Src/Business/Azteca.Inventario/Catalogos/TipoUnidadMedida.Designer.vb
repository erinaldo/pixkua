''' <summary>
''' Paquete de informaci�n que representa un TipoUnidadMedida
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class TipoUnidadMedidaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de UnidadesMedidaTipos
''' </summary>
''' <remarks></remarks>
Public Class TipoUnidadMedidaService
    Inherits CatalogService(Of TipoUnidadMedidaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "UnidadesMedidaTipos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idTipoUnidadMedida As Integer, ByRef TipoUnidadMedida As TipoUnidadMedidaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idTipoUnidadMedida, TipoUnidadMedida, checkStatus)
        With TipoUnidadMedida
            .Nombre = CStr(ItemInfo("Nombre"))

        End With
    End Sub

    Public Overrides Function Update(ByVal TipoUnidadMedida As TipoUnidadMedidaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = TipoUnidadMedida.Nombre

        End With
        Return MyBase.Update(TipoUnidadMedida)
    End Function

    Public Overrides Function Create() As TipoUnidadMedidaInfo
        Return New TipoUnidadMedidaInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de UnidadesMedidaTipos
''' </summary>
''' <remarks></remarks>
Public Class TipoUnidadMedidaFacade
    Inherits CatalogFacade(Of TipoUnidadMedidaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un TipoUnidadMedidaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As TipoUnidadMedidaInfo
        Dim TipoUnidadMedidaSvc As New TipoUnidadMedidaService(sessionID)
        Return TipoUnidadMedidaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de UnidadesMedidaTipos
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTipoUnidadMedida">Identificador del TipoUnidadMedida que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idTipoUnidadMedida As Integer)
        Dim TipoUnidadMedidaSvc As New TipoUnidadMedidaService(sessionID)
        Delete(TipoUnidadMedidaSvc, idTipoUnidadMedida)
    End Sub

    ''' <summary>
    ''' Verifica si existe un TipoUnidadMedida con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTipoUnidadMedida">ID de TipoUnidadMedida que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idTipoUnidadMedida As Integer) As Boolean
        Dim TipoUnidadMedidaSvc As New TipoUnidadMedidaService(sessionID)
        Return Exists(TipoUnidadMedidaSvc, idTipoUnidadMedida)
    End Function

    ''' <summary>
    ''' Verifica si existe un TipoUnidadMedida con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim TipoUnidadMedidaSvc As New TipoUnidadMedidaService(sessionID)
        Return Exists(TipoUnidadMedidaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un TipoUnidadMedida.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTipoUnidadMedida">Identificador de TipoUnidadMedida a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo TipoUnidadMedidaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTipoUnidadMedida As Integer) As TipoUnidadMedidaInfo
        Return Me.GetDetail(sessionID, idTipoUnidadMedida, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un TipoUnidadMedida.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTipoUnidadMedida">Identificador de TipoUnidadMedida</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del TipoUnidadMedida.</param>
    ''' <returns>Paquete de informaci�n de tipo TipoUnidadMedidaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTipoUnidadMedida As Integer, ByVal checkStatus As Boolean) As TipoUnidadMedidaInfo
        Dim TipoUnidadMedidaSvc As New TipoUnidadMedidaService(sessionID)
        Dim TipoUnidadMedidaInf As New TipoUnidadMedidaInfo(sessionID)
        GetDetail(TipoUnidadMedidaSvc, TipoUnidadMedidaInf, idTipoUnidadMedida, checkStatus)
        Return TipoUnidadMedidaInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un TipoUnidadMedida en base a su codigo de usuario
    ''' y verifica que el TipoUnidadMedida est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n TipoUnidadMedidaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As TipoUnidadMedidaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un TipoUnidadMedida en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del TipoUnidadMedida</param>
    ''' <returns>Paquete de informaci�n TipoUnidadMedidaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As TipoUnidadMedidaInfo
        Dim TipoUnidadMedidaInf As New TipoUnidadMedidaInfo(sessionID)
        Dim TipoUnidadMedidaSvc As New TipoUnidadMedidaService(sessionID)
        GetDetail(TipoUnidadMedidaSvc, TipoUnidadMedidaInf, userCode, idSucursal, checkStatus)
        Return TipoUnidadMedidaInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un TipoUnidadMedida.
    ''' </summary>
    ''' <param name="TipoUnidadMedida">Paquete de informaci�n del tipo TipoUnidadMedidaInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de TipoUnidadMedida, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal TipoUnidadMedida As TipoUnidadMedidaInfo) As Integer
        Dim TipoUnidadMedidaSvc As New TipoUnidadMedidaService(TipoUnidadMedida.SessionID)
        Return Update(TipoUnidadMedidaSvc, TipoUnidadMedida)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim TipoUnidadMedidaSvc As New TipoUnidadMedidaService(sessionID)
        Return GetNumberOfPages(TipoUnidadMedidaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca UnidadesMedidaTipos que coincidan con las condiciones especificadas.
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
    ''' Busca UnidadesMedidaTipos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim TipoUnidadMedidaSvc As New TipoUnidadMedidaService(sessionID)
        Return GetSearchResult(TipoUnidadMedidaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de UnidadesMedidaTipos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim TipoUnidadMedidaSvc As New TipoUnidadMedidaService(sessionID)
        Return GetSearchStructure(TipoUnidadMedidaSvc)
    End Function

#End Region

End Class
