''' <summary>
''' Paquete de información que representa un Mesero
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class MeseroInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property IdUsuario As Integer

    Public Property IdCuenta As Integer

    Public Property Fotografia As Byte()

    Public NombreCorto As String
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Meseros
''' </summary>
''' <remarks></remarks>
Public Class MeseroService
    Inherits CatalogService(Of MeseroInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Restaurant", "Meseros", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idMesero As Integer, ByRef Mesero As MeseroInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idMesero, Mesero, checkStatus)
        With Mesero
            .IdUsuario = CInt(ItemInfo("IdUsuario"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .NombreCorto = CStr(ItemInfo("NombreCorto"))
            If Not IsDBNull(ItemInfo("Fotografia")) Then
                .Fotografia = CType(ItemInfo("Fotografia"), Byte())
            End If
        End With
    End Sub

    Public Overrides Function Update(ByVal Mesero As MeseroInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@IdUsuario", DbType.Int32).Value = Mesero.IdUsuario
            .Add("@IdCuenta", DbType.Int32).Value = Mesero.IdCuenta
            .Add("@NombreCorto", DbType.String).Value = Mesero.NombreCorto
            If Mesero.Fotografia Is Nothing Then
                .Add("@Fotografia", DbType.Binary).Value = DBNull.Value
            Else
                .Add("@Fotografia", DbType.Binary).Value = Mesero.Fotografia
            End If
        End With
        Return MyBase.Update(Mesero)
    End Function

    Public Overrides Function Create() As MeseroInfo
        Return New MeseroInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Meseros
''' </summary>
''' <remarks></remarks>
Public Class MeseroFacade
    Inherits CatalogFacade(Of MeseroInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un MeseroInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As MeseroInfo
        Dim MeseroSvc As New MeseroService(sessionID)
        Return MeseroSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Meseros
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMesero">Identificador del Mesero que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idMesero As Integer)
        Dim MeseroSvc As New MeseroService(sessionID)
        Delete(MeseroSvc, idMesero)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Mesero con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMesero">ID de Mesero que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idMesero As Integer) As Boolean
        Dim MeseroSvc As New MeseroService(sessionID)
        Return Exists(MeseroSvc, idMesero)
    End Function

    ''' <summary>
    ''' Verifica si existe un Mesero con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim MeseroSvc As New MeseroService(sessionID)
        Return Exists(MeseroSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Mesero.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMesero">Identificador de Mesero a consultar</param>
    ''' <returns>Paquete de información de tipo MeseroInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idMesero As Integer) As MeseroInfo
        Return Me.GetDetail(sessionID, idMesero, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Mesero.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMesero">Identificador de Mesero</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Mesero.</param>
    ''' <returns>Paquete de información de tipo MeseroInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idMesero As Integer, ByVal checkStatus As Boolean) As MeseroInfo
        Dim MeseroSvc As New MeseroService(sessionID)
        Dim MeseroInf As New MeseroInfo(sessionID)
        GetDetail(MeseroSvc, MeseroInf, idMesero, checkStatus)
        Return MeseroInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Mesero en base a su codigo de usuario
    ''' y verifica que el Mesero esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información MeseroInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As MeseroInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Mesero en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Mesero</param>
    ''' <returns>Paquete de información MeseroInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As MeseroInfo
        Dim MeseroInf As New MeseroInfo(sessionID)
        Dim MeseroSvc As New MeseroService(sessionID)
        GetDetail(MeseroSvc, MeseroInf, userCode, idSucursal, checkStatus)
        Return MeseroInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Mesero.
    ''' </summary>
    ''' <param name="Mesero">Paquete de información del tipo MeseroInfo con la información a actualizar</param>
    ''' <returns>Identificador de Mesero, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Mesero As MeseroInfo) As Integer
        Dim MeseroSvc As New MeseroService(Mesero.SessionID)
        Return Update(MeseroSvc, Mesero)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim MeseroSvc As New MeseroService(sessionID)
        Return GetNumberOfPages(MeseroSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Meseros que coincidan con las condiciones especificadas.
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
    ''' Busca Meseros que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim MeseroSvc As New MeseroService(sessionID)
        Return GetSearchResult(MeseroSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Meseros.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim MeseroSvc As New MeseroService(sessionID)
        Return GetSearchStructure(MeseroSvc)
    End Function

#End Region

End Class
