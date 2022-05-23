''' <summary>
''' Paquete de información que representa un Marca
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class MarcaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String
    Public Property IdCuenta As Integer

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Marcas
''' </summary>
''' <remarks></remarks>
Public Class MarcaService
    Inherits CatalogService(Of MarcaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "Marcas", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idMarca As Integer, ByRef Marca As MarcaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idMarca, Marca, checkStatus)
        With Marca
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Marca As MarcaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Marca.Nombre
            .Add("@IdCuenta", DbType.Int32).Value = Marca.IdCuenta
        End With
        Return MyBase.Update(Marca)
    End Function

    Public Overrides Function Create() As MarcaInfo
        Return New MarcaInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Marcas
''' </summary>
''' <remarks></remarks>
Public Class MarcaFacade
    Inherits CatalogFacade(Of MarcaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un MarcaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As MarcaInfo
        Dim MarcaSvc As New MarcaService(sessionID)
        Return MarcaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Marcas
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMarca">Identificador del Marca que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idMarca As Integer)
        Dim MarcaSvc As New MarcaService(sessionID)
        Delete(MarcaSvc, idMarca)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Marca con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMarca">ID de Marca que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idMarca As Integer) As Boolean
        Dim MarcaSvc As New MarcaService(sessionID)
        Return Exists(MarcaSvc, idMarca)
    End Function

    ''' <summary>
    ''' Verifica si existe un Marca con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim MarcaSvc As New MarcaService(sessionID)
        Return Exists(MarcaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Marca.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMarca">Identificador de Marca a consultar</param>
    ''' <returns>Paquete de información de tipo MarcaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idMarca As Integer) As MarcaInfo
        Return Me.GetDetail(sessionID, idMarca, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Marca.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMarca">Identificador de Marca</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Marca.</param>
    ''' <returns>Paquete de información de tipo MarcaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idMarca As Integer, ByVal checkStatus As Boolean) As MarcaInfo
        Dim MarcaSvc As New MarcaService(sessionID)
        Dim MarcaInf As New MarcaInfo(sessionID)
        GetDetail(MarcaSvc, MarcaInf, idMarca, checkStatus)
        Return MarcaInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Marca en base a su codigo de usuario
    ''' y verifica que el Marca esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información MarcaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As MarcaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Marca en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Marca</param>
    ''' <returns>Paquete de información MarcaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As MarcaInfo
        Dim MarcaInf As New MarcaInfo(sessionID)
        Dim MarcaSvc As New MarcaService(sessionID)
        GetDetail(MarcaSvc, MarcaInf, userCode, idSucursal, checkStatus)
        Return MarcaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Marca.
    ''' </summary>
    ''' <param name="Marca">Paquete de información del tipo MarcaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Marca, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Marca As MarcaInfo) As Integer
        Dim MarcaSvc As New MarcaService(Marca.SessionID)
        Return Update(MarcaSvc, Marca)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim MarcaSvc As New MarcaService(sessionID)
        Return GetNumberOfPages(MarcaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Marcas que coincidan con las condiciones especificadas.
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
    ''' Busca Marcas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim MarcaSvc As New MarcaService(sessionID)
        Return GetSearchResult(MarcaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Marcas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim MarcaSvc As New MarcaService(sessionID)
        Return GetSearchStructure(MarcaSvc)
    End Function

#End Region

End Class
