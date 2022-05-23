''' <summary>
''' Paquete de información que representa un PolizaPerfil
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class PolizaPerfilInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Descripcion As String

    Public Property IdPolizaOrigen As Integer

    Public Property IdPolizaTipo As Integer

    Public Property IdPolizaSumarizacion As Integer

    Public Property Acumulable As Boolean

    Public Property AfectarSistemaExterno As Boolean

    Public Property IdVistaContableTit As Integer

    Public Property IdDocumentoTipo As Integer


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de PolizasPerfiles
''' </summary>
''' <remarks></remarks>
Public Class PolizaPerfilService
    Inherits CatalogService(Of PolizaPerfilInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "PolizasPerfiles", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idPolizaPerfil As Integer, ByRef PolizaPerfil As PolizaPerfilInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idPolizaPerfil, PolizaPerfil, checkStatus)
        With PolizaPerfil
            .Descripcion = CStr(ItemInfo("Descripcion"))
            .IdPolizaOrigen = CInt(ItemInfo("IdPolizaOrigen"))
            .IdPolizaTipo = CInt(ItemInfo("IdPolizaTipo"))
            .IdPolizaSumarizacion = CInt(ItemInfo("IdPolizaSumarizacion"))
            .Acumulable = CBool(ItemInfo("Acumulable"))
            .AfectarSistemaExterno = CBool(ItemInfo("AfectarSistemaExterno"))
            .IdDocumentoTipo = CInt(ItemInfo("IdDocumentoTipo"))
            .IdVistaContableTit = CInt(ItemInfo("IdVistaContableTit"))
        End With
    End Sub

    Public Overrides Function Update(ByVal PolizaPerfil As PolizaPerfilInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Descripcion", DbType.String).Value = PolizaPerfil.Descripcion
            .Add("@IdPolizaOrigen", DbType.Int32).Value = PolizaPerfil.IdPolizaOrigen
            .Add("@IdPolizaTipo", DbType.Int32).Value = PolizaPerfil.IdPolizaTipo
            .Add("@IdPolizaSumarizacion", DbType.Int32).Value = PolizaPerfil.IdPolizaSumarizacion
            .Add("@Acumulable", DbType.Boolean).Value = PolizaPerfil.Acumulable
            .Add("@AfectarSistemaExterno", DbType.Boolean).Value = PolizaPerfil.AfectarSistemaExterno
            .Add("@IdDocumentoTipo", DbType.Int32).Value = PolizaPerfil.IdDocumentoTipo
            .Add("@IdVistaContableTit", DbType.Int32).Value = PolizaPerfil.IdVistaContableTit
        End With
        Return MyBase.Update(PolizaPerfil)
    End Function

    Public Overrides Function Create() As PolizaPerfilInfo
        Return New PolizaPerfilInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de PolizasPerfiles
''' </summary>
''' <remarks></remarks>
Public Class PolizaPerfilFacade
    Inherits CatalogFacade(Of PolizaPerfilInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un PolizaPerfilInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As PolizaPerfilInfo
        Dim PolizaPerfilSvc As New PolizaPerfilService(sessionID)
        Return PolizaPerfilSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de PolizasPerfiles
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPolizaPerfil">Identificador del PolizaPerfil que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idPolizaPerfil As Integer)
        Dim PolizaPerfilSvc As New PolizaPerfilService(sessionID)
        Delete(PolizaPerfilSvc, idPolizaPerfil)
    End Sub

    ''' <summary>
    ''' Verifica si existe un PolizaPerfil con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPolizaPerfil">ID de PolizaPerfil que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idPolizaPerfil As Integer) As Boolean
        Dim PolizaPerfilSvc As New PolizaPerfilService(sessionID)
        Return Exists(PolizaPerfilSvc, idPolizaPerfil)
    End Function

    ''' <summary>
    ''' Verifica si existe un PolizaPerfil con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim PolizaPerfilSvc As New PolizaPerfilService(sessionID)
        Return Exists(PolizaPerfilSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un PolizaPerfil.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPolizaPerfil">Identificador de PolizaPerfil a consultar</param>
    ''' <returns>Paquete de información de tipo PolizaPerfilInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPolizaPerfil As Integer) As PolizaPerfilInfo
        Return Me.GetDetail(sessionID, idPolizaPerfil, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un PolizaPerfil.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPolizaPerfil">Identificador de PolizaPerfil</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del PolizaPerfil.</param>
    ''' <returns>Paquete de información de tipo PolizaPerfilInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPolizaPerfil As Integer, ByVal checkStatus As Boolean) As PolizaPerfilInfo
        Dim PolizaPerfilSvc As New PolizaPerfilService(sessionID)
        Dim PolizaPerfilInf As New PolizaPerfilInfo(sessionID)
        GetDetail(PolizaPerfilSvc, PolizaPerfilInf, idPolizaPerfil, checkStatus)
        Return PolizaPerfilInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un PolizaPerfil en base a su codigo de usuario
    ''' y verifica que el PolizaPerfil esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información PolizaPerfilInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As PolizaPerfilInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un PolizaPerfil en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del PolizaPerfil</param>
    ''' <returns>Paquete de información PolizaPerfilInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As PolizaPerfilInfo
        Dim PolizaPerfilInf As New PolizaPerfilInfo(sessionID)
        Dim PolizaPerfilSvc As New PolizaPerfilService(sessionID)
        GetDetail(PolizaPerfilSvc, PolizaPerfilInf, userCode, idSucursal, checkStatus)
        Return PolizaPerfilInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un PolizaPerfil.
    ''' </summary>
    ''' <param name="PolizaPerfil">Paquete de información del tipo PolizaPerfilInfo con la información a actualizar</param>
    ''' <returns>Identificador de PolizaPerfil, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal PolizaPerfil As PolizaPerfilInfo) As Integer
        Dim PolizaPerfilSvc As New PolizaPerfilService(PolizaPerfil.SessionID)
        Return Update(PolizaPerfilSvc, PolizaPerfil)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim PolizaPerfilSvc As New PolizaPerfilService(sessionID)
        Return GetNumberOfPages(PolizaPerfilSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca PolizasPerfiles que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca PolizasPerfiles que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim PolizaPerfilSvc As New PolizaPerfilService(sessionID)
        Return GetSearchResult(PolizaPerfilSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de PolizasPerfiles.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim PolizaPerfilSvc As New PolizaPerfilService(sessionID)
        Return GetSearchStructure(PolizaPerfilSvc)
    End Function

#End Region

End Class
