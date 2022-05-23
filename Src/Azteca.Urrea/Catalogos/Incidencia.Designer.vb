''' <summary>
''' Paquete de informaci�n que representa un Incidencia
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class IncidenciaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
	Public Property Nombre As String	Public Property IdTipoIncidencia As Integer	Public Property IdCuenta As Integer	Public Property IdEmpresa As Integer
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Incidencias
''' </summary>
''' <remarks></remarks>
Public Class IncidenciaService
    Inherits CatalogService(Of IncidenciaInfo)

#Region "Constructores"
    Public Sub New(ByVal session As GUID)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As GUID, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("CDU", "Incidencias", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idIncidencia As Integer, ByRef Incidencia As IncidenciaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idIncidencia, Incidencia, checkStatus)
        With Incidencia
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdTipoIncidencia = CInt(ItemInfo("IdTipoIncidencia"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .IdEmpresa = CInt(ItemInfo("IdEmpresa"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Incidencia As IncidenciaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Incidencia.Nombre
            .Add("@IdTipoIncidencia", DbType.Int32).Value = Incidencia.IdTipoIncidencia
            .Add("@IdCuenta", DbType.Int32).Value = Incidencia.IdCuenta
           
        End With
        Return MyBase.Update(Incidencia)
    End Function

    Public Overrides Function Create() As IncidenciaInfo
        Return New IncidenciaInfo(Session.SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Incidencias
''' </summary>
''' <remarks></remarks>
Public Class IncidenciaFacade
    Inherits CatalogFacade(Of IncidenciaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un IncidenciaInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As GUID) As IncidenciaInfo
        Dim IncidenciaSvc As New IncidenciaService(session)
        Return IncidenciaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Incidencias
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idIncidencia">Identificador del Incidencia que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As GUID, ByVal idIncidencia As Integer)
        Dim IncidenciaSvc As New IncidenciaService(session)
        Delete(IncidenciaSvc, idIncidencia)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Incidencia con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idIncidencia">ID de Incidencia que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As GUID, ByVal idIncidencia As Integer) As Boolean
        Dim IncidenciaSvc As New IncidenciaService(session)
        Return Exists(IncidenciaSvc, idIncidencia)
    End Function

    ''' <summary>
    ''' Verifica si existe un Incidencia con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim IncidenciaSvc As New IncidenciaService(session)
        Return Exists(IncidenciaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Incidencia.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idIncidencia">Identificador de Incidencia a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo IncidenciaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As GUID, ByVal idIncidencia As Integer) As IncidenciaInfo
        Return Me.GetDetail(session, idIncidencia, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Incidencia.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idIncidencia">Identificador de Incidencia</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Incidencia.</param>
    ''' <returns>Paquete de informaci�n de tipo IncidenciaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As GUID, ByVal idIncidencia As Integer, ByVal checkStatus As Boolean) As IncidenciaInfo
        Dim IncidenciaSvc As New IncidenciaService(session)
        Dim IncidenciaInf As New IncidenciaInfo(session)
        GetDetail(IncidenciaSvc, IncidenciaInf, idIncidencia, checkStatus)
        Return IncidenciaInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Incidencia en base a su codigo de usuario
    ''' y verifica que el Incidencia est� activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n IncidenciaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As IncidenciaInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Incidencia en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Incidencia</param>
    ''' <returns>Paquete de informaci�n IncidenciaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As IncidenciaInfo
        Dim IncidenciaInf As New IncidenciaInfo(session)
        Dim IncidenciaSvc As New IncidenciaService(session)
        GetDetail(IncidenciaSvc, IncidenciaInf, userCode, idSucursal, checkStatus)
        Return IncidenciaInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Incidencia.
    ''' </summary>
    ''' <param name="Incidencia">Paquete de informaci�n del tipo IncidenciaInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Incidencia, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Incidencia As IncidenciaInfo) As Integer
        Dim IncidenciaSvc As New IncidenciaService(Incidencia.SessionID)
        Return Update(IncidenciaSvc, Incidencia)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim IncidenciaSvc As New IncidenciaService(session)
        Return GetNumberOfPages(IncidenciaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Incidencias que coincidan con las condiciones especificadas.
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
    ''' Busca Incidencias que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim IncidenciaSvc As New IncidenciaService(session)
        Return GetSearchResult(IncidenciaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Incidencias.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As GUID) As System.Data.DataSet
        Dim IncidenciaSvc As New IncidenciaService(session)
        Return GetSearchStructure(IncidenciaSvc)
    End Function

#End Region

End Class
