''' <summary>
''' Paquete de informaci�n que representa un Entidad
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class EntidadInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Entidad As String

    Public Property Schema As String

    Public Property Objeto As String

    Public Property Aliass As String

    Public Property CampoPK As String

    Public Property CampoName As String

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Entidades
''' </summary>
''' <remarks></remarks>
Public Class EntidadService
    Inherits CatalogService(Of EntidadInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "Entidades", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idEntidad As Integer, ByRef Entidad As EntidadInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idEntidad, Entidad, checkStatus)
        With Entidad
            .Entidad = CStr(ItemInfo("Entidad"))
            .Schema = CStr(ItemInfo("Schema"))
            .Objeto = CStr(ItemInfo("Objeto"))
            .Aliass = CStr(ItemInfo("Alias"))
            .CampoPK = CStr(ItemInfo("CampoPK"))
            .CampoName = CStr(ItemInfo("CampoName"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Entidad As EntidadInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Entidad", DbType.String).Value = Entidad.Entidad
            .Add("@Schema", DbType.String).Value = Entidad.Schema
            .Add("@Objeto", DbType.String).Value = Entidad.Objeto
            .Add("@Alias", DbType.String).Value = Entidad.Aliass
            .Add("@CampoPK", DbType.String).Value = Entidad.CampoPK
            .Add("@CampoName", DbType.String).Value = Entidad.CampoName
        End With
        Return MyBase.Update(Entidad)
    End Function

    Public Overrides Function Create() As EntidadInfo
        Return New EntidadInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Entidades
''' </summary>
''' <remarks></remarks>
Public Class EntidadFacade
    Inherits CatalogFacade(Of EntidadInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un EntidadInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As EntidadInfo
        Dim EntidadSvc As New EntidadService(sessionID)
        Return EntidadSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Entidades
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idEntidad">Identificador del Entidad que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idEntidad As Integer)
        Dim EntidadSvc As New EntidadService(sessionID)
        Delete(EntidadSvc, idEntidad)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Entidad con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idEntidad">ID de Entidad que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idEntidad As Integer) As Boolean
        Dim EntidadSvc As New EntidadService(sessionID)
        Return Exists(EntidadSvc, idEntidad)
    End Function

    ''' <summary>
    ''' Verifica si existe un Entidad con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim EntidadSvc As New EntidadService(sessionID)
        Return Exists(EntidadSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Entidad.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idEntidad">Identificador de Entidad a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo EntidadInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idEntidad As Integer) As EntidadInfo
        Return Me.GetDetail(sessionID, idEntidad, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Entidad.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idEntidad">Identificador de Entidad</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Entidad.</param>
    ''' <returns>Paquete de informaci�n de tipo EntidadInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idEntidad As Integer, ByVal checkStatus As Boolean) As EntidadInfo
        Dim EntidadSvc As New EntidadService(sessionID)
        Dim EntidadInf As New EntidadInfo(sessionID)
        GetDetail(EntidadSvc, EntidadInf, idEntidad, checkStatus)
        Return EntidadInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Entidad en base a su codigo de usuario
    ''' y verifica que el Entidad est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n EntidadInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As EntidadInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Entidad en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Entidad</param>
    ''' <returns>Paquete de informaci�n EntidadInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As EntidadInfo
        Dim EntidadInf As New EntidadInfo(sessionID)
        Dim EntidadSvc As New EntidadService(sessionID)
        GetDetail(EntidadSvc, EntidadInf, userCode, idSucursal, checkStatus)
        Return EntidadInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Entidad.
    ''' </summary>
    ''' <param name="Entidad">Paquete de informaci�n del tipo EntidadInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Entidad, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Entidad As EntidadInfo) As Integer
        Dim EntidadSvc As New EntidadService(Entidad.SessionID)
        Return Update(EntidadSvc, Entidad)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim EntidadSvc As New EntidadService(sessionID)
        Return GetNumberOfPages(EntidadSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Entidades que coincidan con las condiciones especificadas.
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
    ''' Busca Entidades que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim EntidadSvc As New EntidadService(sessionID)
        Return GetSearchResult(EntidadSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Entidades.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim EntidadSvc As New EntidadService(sessionID)
        Return GetSearchStructure(EntidadSvc)
    End Function

#End Region

End Class
