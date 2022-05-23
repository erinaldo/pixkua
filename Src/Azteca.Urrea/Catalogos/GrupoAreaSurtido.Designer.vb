Imports Azteca.Kernel.BusinessStructure
Imports Azteca.Kernel.Search

''' <summary>
''' Paquete de informaci�n que representa un GrupoAreaSurtido
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class GrupoAreaSurtidoInfo
    Inherits CatalogInfo

#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String    Public Property IdEmpresa As Integer
#End Region

#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de GruposAreasSurtido
''' </summary>
''' <remarks></remarks>
Public Class GrupoAreaSurtidoService
    Inherits CatalogService(Of GrupoAreaSurtidoInfo)

#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("CDU", "GruposAreasSurtido", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idGrupoAreaSurtido As Integer, ByRef GrupoAreaSurtido As GrupoAreaSurtidoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idGrupoAreaSurtido, GrupoAreaSurtido, checkStatus)
        With GrupoAreaSurtido
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdEmpresa = CInt(ItemInfo("IdEmpresa"))

        End With
    End Sub

    Public Overrides Function Update(ByVal GrupoAreaSurtido As GrupoAreaSurtidoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = GrupoAreaSurtido.Nombre


        End With
        Return MyBase.Update(GrupoAreaSurtido)
    End Function

    Public Overrides Function Create() As GrupoAreaSurtidoInfo
        Return New GrupoAreaSurtidoInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de GruposAreasSurtido
''' </summary>
''' <remarks></remarks>
Public Class GrupoAreaSurtidoFacade
    Inherits CatalogFacade(Of GrupoAreaSurtidoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un GrupoAreaSurtidoInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As GrupoAreaSurtidoInfo
        Dim GrupoAreaSurtidoSvc As New GrupoAreaSurtidoService(session)
        Return GrupoAreaSurtidoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de GruposAreasSurtido
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idGrupoAreaSurtido">Identificador del GrupoAreaSurtido que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idGrupoAreaSurtido As Integer)
        Dim GrupoAreaSurtidoSvc As New GrupoAreaSurtidoService(session)
        Delete(GrupoAreaSurtidoSvc, idGrupoAreaSurtido)
    End Sub

    ''' <summary>
    ''' Verifica si existe un GrupoAreaSurtido con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idGrupoAreaSurtido">ID de GrupoAreaSurtido que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idGrupoAreaSurtido As Integer) As Boolean
        Dim GrupoAreaSurtidoSvc As New GrupoAreaSurtidoService(session)
        Return Exists(GrupoAreaSurtidoSvc, idGrupoAreaSurtido)
    End Function

    ''' <summary>
    ''' Verifica si existe un GrupoAreaSurtido con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim GrupoAreaSurtidoSvc As New GrupoAreaSurtidoService(session)
        Return Exists(GrupoAreaSurtidoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un GrupoAreaSurtido.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idGrupoAreaSurtido">Identificador de GrupoAreaSurtido a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo GrupoAreaSurtidoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idGrupoAreaSurtido As Integer) As GrupoAreaSurtidoInfo
        Return Me.GetDetail(session, idGrupoAreaSurtido, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un GrupoAreaSurtido.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idGrupoAreaSurtido">Identificador de GrupoAreaSurtido</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del GrupoAreaSurtido.</param>
    ''' <returns>Paquete de informaci�n de tipo GrupoAreaSurtidoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idGrupoAreaSurtido As Integer, ByVal checkStatus As Boolean) As GrupoAreaSurtidoInfo
        Dim GrupoAreaSurtidoSvc As New GrupoAreaSurtidoService(session)
        Dim GrupoAreaSurtidoInf As New GrupoAreaSurtidoInfo(session)
        GetDetail(GrupoAreaSurtidoSvc, GrupoAreaSurtidoInf, idGrupoAreaSurtido, checkStatus)
        Return GrupoAreaSurtidoInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un GrupoAreaSurtido en base a su codigo de usuario
    ''' y verifica que el GrupoAreaSurtido est� activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n GrupoAreaSurtidoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As GrupoAreaSurtidoInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un GrupoAreaSurtido en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del GrupoAreaSurtido</param>
    ''' <returns>Paquete de informaci�n GrupoAreaSurtidoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As GrupoAreaSurtidoInfo
        Dim GrupoAreaSurtidoInf As New GrupoAreaSurtidoInfo(session)
        Dim GrupoAreaSurtidoSvc As New GrupoAreaSurtidoService(session)
        GetDetail(GrupoAreaSurtidoSvc, GrupoAreaSurtidoInf, userCode, idSucursal, checkStatus)
        Return GrupoAreaSurtidoInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un GrupoAreaSurtido.
    ''' </summary>
    ''' <param name="GrupoAreaSurtido">Paquete de informaci�n del tipo GrupoAreaSurtidoInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de GrupoAreaSurtido, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal GrupoAreaSurtido As GrupoAreaSurtidoInfo) As Integer
        Dim GrupoAreaSurtidoSvc As New GrupoAreaSurtidoService(GrupoAreaSurtido.SessionID)
        Return Update(GrupoAreaSurtidoSvc, GrupoAreaSurtido)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim GrupoAreaSurtidoSvc As New GrupoAreaSurtidoService(session)
        Return GetNumberOfPages(GrupoAreaSurtidoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca GruposAreasSurtido que coincidan con las condiciones especificadas.
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
    ''' Busca GruposAreasSurtido que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim GrupoAreaSurtidoSvc As New GrupoAreaSurtidoService(session)
        Return GetSearchResult(GrupoAreaSurtidoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de GruposAreasSurtido.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim GrupoAreaSurtidoSvc As New GrupoAreaSurtidoService(session)
        Return GetSearchStructure(GrupoAreaSurtidoSvc)
    End Function

#End Region

End Class
