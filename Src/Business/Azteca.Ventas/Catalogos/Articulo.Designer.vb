''' <summary>
''' Paquete de informaci�n que representa un Articulo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ArticuloInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Friend _IdTipoUnidad As Integer
    Friend _UnidadMedida As String
#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdUnidadMedida As Integer

    Public Property IdMarca As Integer

    Public Property Modelo As String

    Public Property IdEstCom As Integer

    Public Property IdCategoriaFlujo As Integer

    Public Property IdRegleta As Integer

    Public ReadOnly Property IdTipoUnidadMedida As Integer
        Get
            Return _IdTipoUnidad
        End Get
    End Property

    Public ReadOnly Property UnidadMedida As String
        Get
            Return _UnidadMedida
        End Get
    End Property
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Articulos
''' </summary>
''' <remarks></remarks>
Public Class ArticuloService
    Inherits CatalogService(Of ArticuloInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "Articulos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idArticulo As Integer, ByRef Articulo As ArticuloInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idArticulo, Articulo, checkStatus)
        With Articulo
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdUnidadMedida = CInt(ItemInfo("IdUnidadMedida"))
            .IdMarca = CInt(ItemInfo("IdMarca"))
            .Modelo = CStr(ItemInfo("Modelo"))
            .IdEstCom = CInt(ItemInfo("IdEstCom"))
            .IdCategoriaFlujo = CInt(ItemInfo("IdCategoriaFlujo"))
            ._IdTipoUnidad = CInt(ItemInfo("IdUnidadMedidaTipo"))
            ._UnidadMedida = ItemInfo("UnidadMedida").ToString
            .IdRegleta = CInt(ItemInfo("IdRegleta"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Articulo As ArticuloInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Articulo.Nombre
            .Add("@IdUnidadMedida", DbType.Int32).Value = Articulo.IdUnidadMedida
            .Add("@IdMarca", DbType.Int32).Value = Articulo.IdMarca
            .Add("@Modelo", DbType.String).Value = Articulo.Modelo
            .Add("@IdEstCom", DbType.Int32).Value = Articulo.IdEstCom
            .Add("@IdCategoriaFlujo", DbType.Int32).Value = Articulo.IdCategoriaFlujo
            .Add("@IdRegleta", DbType.Int32).Value = Articulo.IdRegleta
        End With
        Dim IdArticulo As Integer = MyBase.Update(Articulo)
        Azteca.Kernel.Cache.Remove("Articulo_" & IdArticulo.ToString)
        Return IdArticulo
    End Function

    Public Overrides Function Create() As ArticuloInfo
        Return New ArticuloInfo(sessionID)
    End Function

#Region "Metodos Privados"

#End Region

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Articulos
''' </summary>
''' <remarks></remarks>
Public Class ArticuloFacade
    Inherits CatalogFacade(Of ArticuloInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ArticuloInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ArticuloInfo
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Return ArticuloSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Articulos
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idArticulo">Identificador del Articulo que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idArticulo As Integer)
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Delete(ArticuloSvc, idArticulo)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Articulo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idArticulo">ID de Articulo que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idArticulo As Integer) As Boolean
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Return Exists(ArticuloSvc, idArticulo)
    End Function

    ''' <summary>
    ''' Verifica si existe un Articulo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Return Exists(ArticuloSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Articulo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idArticulo">Identificador de Articulo a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo ArticuloInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idArticulo As Integer) As ArticuloInfo
        Return Me.GetDetail(sessionID, idArticulo, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Articulo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idArticulo">Identificador de Articulo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Articulo.</param>
    ''' <returns>Paquete de informaci�n de tipo ArticuloInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idArticulo As Integer, ByVal checkStatus As Boolean) As ArticuloInfo
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Dim ArticuloInf As New ArticuloInfo(sessionID)
        GetDetail(ArticuloSvc, ArticuloInf, idArticulo, checkStatus)
        Return ArticuloInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Articulo en base a su codigo de usuario
    ''' y verifica que el Articulo est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n ArticuloInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As ArticuloInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Articulo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Articulo</param>
    ''' <returns>Paquete de informaci�n ArticuloInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ArticuloInfo
        Dim ArticuloInf As New ArticuloInfo(sessionID)
        Dim ArticuloSvc As New ArticuloService(sessionID)
        GetDetail(ArticuloSvc, ArticuloInf, userCode, idSucursal, checkStatus)
        Return ArticuloInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Articulo.
    ''' </summary>
    ''' <param name="Articulo">Paquete de informaci�n del tipo ArticuloInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Articulo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Articulo As ArticuloInfo) As Integer
        Dim ArticuloSvc As New ArticuloService(Articulo.SessionID)
        Return Update(ArticuloSvc, Articulo)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Return GetNumberOfPages(ArticuloSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Articulos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Articulos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Return GetSearchResult(ArticuloSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Articulos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ArticuloSvc As New ArticuloService(sessionID)
        Return GetSearchStructure(ArticuloSvc)
    End Function

#End Region

End Class
