''' <summary>
''' Paquete de informaci�n que representa un Tipo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class TipoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdEmpresa As Integer


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Tipos
''' </summary>
''' <remarks></remarks>
Public Class TipoService
    Inherits CatalogService(Of TipoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "Tipos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idTipo As Integer, ByRef Tipo As TipoInfo, checkStatus As Boolean)
        MyBase.GetDetail(idTipo, Tipo, checkStatus)
        With Tipo
            .Nombre = CStr(ItemInfo("Nombre"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Tipo As TipoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Tipo.Nombre

        End With
        Return MyBase.Update(Tipo)
    End Function

    Public Overrides Function Create() As TipoInfo
        Return New TipoInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Tipos
''' </summary>
''' <remarks></remarks>
Public Class TipoFacade
    Inherits CatalogFacade(Of TipoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un TipoInfo
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As TipoInfo
        Dim TipoSvc As New TipoService(sessionID)
        Return TipoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Tipos
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTipo">Identificador del Tipo que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idTipo As Integer)
        Dim TipoSvc As New TipoService(sessionID)
        Delete(TipoSvc, idTipo)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Tipo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTipo">ID de Tipo que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idTipo As Integer) As Boolean
        Dim TipoSvc As New TipoService(sessionID)
        Return Exists(TipoSvc, idTipo)
    End Function

    ''' <summary>
    ''' Verifica si existe un Tipo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim TipoSvc As New TipoService(sessionID)
        Return Exists(TipoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Tipo.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTipo">Identificador de Tipo a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo TipoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTipo As Integer) As TipoInfo
        Return Me.GetDetail(sessionID, idTipo, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Tipo.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTipo">Identificador de Tipo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Tipo.</param>
    ''' <returns>Paquete de informaci�n de tipo TipoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTipo As Integer, checkStatus As Boolean) As TipoInfo
        Dim TipoSvc As New TipoService(sessionID)
        Dim TipoInf As New TipoInfo(sessionID)
        GetDetail(TipoSvc, TipoInf, idTipo, checkStatus)
        Return TipoInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Tipo en base a su codigo de usuario
    ''' y verifica que el Tipo est� activo.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n TipoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As TipoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Tipo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Tipo</param>
    ''' <returns>Paquete de informaci�n TipoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As TipoInfo
        Dim TipoInf As New TipoInfo(sessionID)
        Dim TipoSvc As New TipoService(sessionID)
        GetDetail(TipoSvc, TipoInf, userCode, idSucursal, checkStatus)
        Return TipoInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Tipo.
    ''' </summary>
    ''' <param name="Tipo">Paquete de informaci�n del tipo TipoInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Tipo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Tipo As TipoInfo) As Integer
        Dim TipoSvc As New TipoService(Tipo.sessionID)
        Return Update(TipoSvc, Tipo)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim TipoSvc As New TipoService(sessionID)
        Return GetNumberOfPages(TipoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Tipos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Tipos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim TipoSvc As New TipoService(sessionID)
        Return GetSearchResult(TipoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Tipos.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim TipoSvc As New TipoService(sessionID)
        Return GetSearchStructure(TipoSvc)
    End Function

#End Region

End Class
