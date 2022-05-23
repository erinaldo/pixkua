''' <summary>
''' Paquete de informaci�n que representa un TipoIncidencia
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class TipoIncidenciaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
	Public Property Nombre As String	Public Property IdCuenta As Integer	Public Property IdEmpresa As Integer
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de IncidenciasTipos
''' </summary>
''' <remarks></remarks>
Public Class TipoIncidenciaService
    Inherits CatalogService(Of TipoIncidenciaInfo)

#Region "Constructores"
    Public Sub New(ByVal session As GUID)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As GUID, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("CDU", "IncidenciasTipos", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idTipoIncidencia As Integer, ByRef TipoIncidencia As TipoIncidenciaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idTipoIncidencia, TipoIncidencia, checkStatus)
        With TipoIncidencia
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .IdEmpresa = CInt(ItemInfo("IdEmpresa"))

        End With
    End Sub

    Public Overrides Function Update(ByVal TipoIncidencia As TipoIncidenciaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = TipoIncidencia.Nombre
            .Add("@IdCuenta", DbType.Int32).Value = TipoIncidencia.IdCuenta
            
        End With
        Return MyBase.Update(TipoIncidencia)
    End Function

    Public Overrides Function Create() As TipoIncidenciaInfo
        Return New TipoIncidenciaInfo(Session.SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de IncidenciasTipos
''' </summary>
''' <remarks></remarks>
Public Class TipoIncidenciaFacade
    Inherits CatalogFacade(Of TipoIncidenciaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un TipoIncidenciaInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As GUID) As TipoIncidenciaInfo
        Dim TipoIncidenciaSvc As New TipoIncidenciaService(session)
        Return TipoIncidenciaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de IncidenciasTipos
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTipoIncidencia">Identificador del TipoIncidencia que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As GUID, ByVal idTipoIncidencia As Integer)
        Dim TipoIncidenciaSvc As New TipoIncidenciaService(session)
        Delete(TipoIncidenciaSvc, idTipoIncidencia)
    End Sub

    ''' <summary>
    ''' Verifica si existe un TipoIncidencia con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTipoIncidencia">ID de TipoIncidencia que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As GUID, ByVal idTipoIncidencia As Integer) As Boolean
        Dim TipoIncidenciaSvc As New TipoIncidenciaService(session)
        Return Exists(TipoIncidenciaSvc, idTipoIncidencia)
    End Function

    ''' <summary>
    ''' Verifica si existe un TipoIncidencia con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim TipoIncidenciaSvc As New TipoIncidenciaService(session)
        Return Exists(TipoIncidenciaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un TipoIncidencia.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTipoIncidencia">Identificador de TipoIncidencia a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo TipoIncidenciaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As GUID, ByVal idTipoIncidencia As Integer) As TipoIncidenciaInfo
        Return Me.GetDetail(session, idTipoIncidencia, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un TipoIncidencia.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTipoIncidencia">Identificador de TipoIncidencia</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del TipoIncidencia.</param>
    ''' <returns>Paquete de informaci�n de tipo TipoIncidenciaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As GUID, ByVal idTipoIncidencia As Integer, ByVal checkStatus As Boolean) As TipoIncidenciaInfo
        Dim TipoIncidenciaSvc As New TipoIncidenciaService(session)
        Dim TipoIncidenciaInf As New TipoIncidenciaInfo(session)
        GetDetail(TipoIncidenciaSvc, TipoIncidenciaInf, idTipoIncidencia, checkStatus)
        Return TipoIncidenciaInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un TipoIncidencia en base a su codigo de usuario
    ''' y verifica que el TipoIncidencia est� activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n TipoIncidenciaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As TipoIncidenciaInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un TipoIncidencia en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del TipoIncidencia</param>
    ''' <returns>Paquete de informaci�n TipoIncidenciaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As TipoIncidenciaInfo
        Dim TipoIncidenciaInf As New TipoIncidenciaInfo(session)
        Dim TipoIncidenciaSvc As New TipoIncidenciaService(session)
        GetDetail(TipoIncidenciaSvc, TipoIncidenciaInf, userCode, idSucursal, checkStatus)
        Return TipoIncidenciaInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un TipoIncidencia.
    ''' </summary>
    ''' <param name="TipoIncidencia">Paquete de informaci�n del tipo TipoIncidenciaInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de TipoIncidencia, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal TipoIncidencia As TipoIncidenciaInfo) As Integer
        Dim TipoIncidenciaSvc As New TipoIncidenciaService(TipoIncidencia.SessionID)
        Return Update(TipoIncidenciaSvc, TipoIncidencia)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim TipoIncidenciaSvc As New TipoIncidenciaService(session)
        Return GetNumberOfPages(TipoIncidenciaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca IncidenciasTipos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(session, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca IncidenciasTipos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim TipoIncidenciaSvc As New TipoIncidenciaService(session)
        Return GetSearchResult(TipoIncidenciaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de IncidenciasTipos.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As GUID) As System.Data.DataSet
        Dim TipoIncidenciaSvc As New TipoIncidenciaService(session)
        Return GetSearchStructure(TipoIncidenciaSvc)
    End Function

#End Region

End Class
