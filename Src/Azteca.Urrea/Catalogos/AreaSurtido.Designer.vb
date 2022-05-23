Imports Azteca.Kernel.BusinessStructure
Imports Azteca.Kernel.Search

''' <summary>
''' Paquete de informaci�n que representa un AreaSurtido
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class AreaSurtidoInfo
    Inherits CatalogInfo

#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String    Public Property CapacidadHoraXUsuario As Integer    Public Property CantUsuariosDef As Integer    Public Property IdGrupoAreaSurtido As Integer    Public Property IdEmpresa As Integer
#End Region

#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de AreasSurtido
''' </summary>
''' <remarks></remarks>
Public Class AreaSurtidoService
    Inherits CatalogService(Of AreaSurtidoInfo)

#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("CDU", "AreasSurtido", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idAreaSurtido As Integer, ByRef AreaSurtido As AreaSurtidoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idAreaSurtido, AreaSurtido, checkStatus)
        With AreaSurtido
            .Nombre = CStr(ItemInfo("Nombre"))
            .CapacidadHoraXUsuario = CInt(ItemInfo("CapacidadHoraXUsuario"))
            .CantUsuariosDef = CInt(ItemInfo("CantUsuariosDef"))
            .IdGrupoAreaSurtido = CInt(ItemInfo("IdGrupoAreaSurtido"))
            .IdEmpresa = CInt(ItemInfo("IdEmpresa"))

        End With
    End Sub

    Public Overrides Function Update(ByVal AreaSurtido As AreaSurtidoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = AreaSurtido.Nombre
            .Add("@CapacidadHoraXUsuario", DbType.Int32).Value = AreaSurtido.CapacidadHoraXUsuario
            .Add("@CantUsuariosDef", DbType.Int32).Value = AreaSurtido.CantUsuariosDef
            .Add("@IdGrupoAreaSurtido", DbType.Int32).Value = AreaSurtido.IdGrupoAreaSurtido
          
        End With
        Return MyBase.Update(AreaSurtido)
    End Function

    Public Overrides Function Create() As AreaSurtidoInfo
        Return New AreaSurtidoInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de AreasSurtido
''' </summary>
''' <remarks></remarks>
Public Class AreaSurtidoFacade
    Inherits CatalogFacade(Of AreaSurtidoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un AreaSurtidoInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As AreaSurtidoInfo
        Dim AreaSurtidoSvc As New AreaSurtidoService(session)
        Return AreaSurtidoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de AreasSurtido
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idAreaSurtido">Identificador del AreaSurtido que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idAreaSurtido As Integer)
        Dim AreaSurtidoSvc As New AreaSurtidoService(session)
        Delete(AreaSurtidoSvc, idAreaSurtido)
    End Sub

    ''' <summary>
    ''' Verifica si existe un AreaSurtido con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idAreaSurtido">ID de AreaSurtido que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idAreaSurtido As Integer) As Boolean
        Dim AreaSurtidoSvc As New AreaSurtidoService(session)
        Return Exists(AreaSurtidoSvc, idAreaSurtido)
    End Function

    ''' <summary>
    ''' Verifica si existe un AreaSurtido con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim AreaSurtidoSvc As New AreaSurtidoService(session)
        Return Exists(AreaSurtidoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un AreaSurtido.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idAreaSurtido">Identificador de AreaSurtido a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo AreaSurtidoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idAreaSurtido As Integer) As AreaSurtidoInfo
        Return Me.GetDetail(session, idAreaSurtido, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un AreaSurtido.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idAreaSurtido">Identificador de AreaSurtido</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del AreaSurtido.</param>
    ''' <returns>Paquete de informaci�n de tipo AreaSurtidoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idAreaSurtido As Integer, ByVal checkStatus As Boolean) As AreaSurtidoInfo
        Dim AreaSurtidoSvc As New AreaSurtidoService(session)
        Dim AreaSurtidoInf As New AreaSurtidoInfo(session)
        GetDetail(AreaSurtidoSvc, AreaSurtidoInf, idAreaSurtido, checkStatus)
        Return AreaSurtidoInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un AreaSurtido en base a su codigo de usuario
    ''' y verifica que el AreaSurtido est� activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n AreaSurtidoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As AreaSurtidoInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un AreaSurtido en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del AreaSurtido</param>
    ''' <returns>Paquete de informaci�n AreaSurtidoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As AreaSurtidoInfo
        Dim AreaSurtidoInf As New AreaSurtidoInfo(session)
        Dim AreaSurtidoSvc As New AreaSurtidoService(session)
        GetDetail(AreaSurtidoSvc, AreaSurtidoInf, userCode, idSucursal, checkStatus)
        Return AreaSurtidoInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un AreaSurtido.
    ''' </summary>
    ''' <param name="AreaSurtido">Paquete de informaci�n del tipo AreaSurtidoInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de AreaSurtido, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal AreaSurtido As AreaSurtidoInfo) As Integer
        Dim AreaSurtidoSvc As New AreaSurtidoService(AreaSurtido.SessionID)
        Return Update(AreaSurtidoSvc, AreaSurtido)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim AreaSurtidoSvc As New AreaSurtidoService(session)
        Return GetNumberOfPages(AreaSurtidoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca AreasSurtido que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(session, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca AreasSurtido que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim AreaSurtidoSvc As New AreaSurtidoService(session)
        Return GetSearchResult(AreaSurtidoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de AreasSurtido.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim AreaSurtidoSvc As New AreaSurtidoService(session)
        Return GetSearchStructure(AreaSurtidoSvc)
    End Function

#End Region

End Class
