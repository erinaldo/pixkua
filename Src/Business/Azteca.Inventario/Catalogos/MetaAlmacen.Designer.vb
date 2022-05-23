''' <summary>
''' Paquete de información que representa un MetaAlmacen
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class MetaAlmacenInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String


#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de MetaAlmacenes
''' </summary>
''' <remarks></remarks>
Public Class MetaAlmacenService
	Inherits CatalogService(Of MetaAlmacenInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory","MetaAlmacenes", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idMetaAlmacen As Integer, ByRef MetaAlmacen As MetaAlmacenInfo, checkStatus As Boolean)
		MyBase.GetDetail(idMetaAlmacen, MetaAlmacen, checkStatus)
        With MetaAlmacen
			.Nombre = CStr(ItemInfo("Nombre"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal MetaAlmacen As MetaAlmacenInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = MetaAlmacen.Nombre

		End With
		Return MyBase.Update(MetaAlmacen)
	End Function
	
	Public Overrides Function Create() As MetaAlmacenInfo
		Return New MetaAlmacenInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de MetaAlmacenes
''' </summary>
''' <remarks></remarks>
Public Class MetaAlmacenFacade
	Inherits CatalogFacade(Of MetaAlmacenInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un MetaAlmacenInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As MetaAlmacenInfo
		Dim MetaAlmacenSvc As New MetaAlmacenService(sessionID)
		Return MetaAlmacenSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de MetaAlmacenes
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMetaAlmacen">Identificador del MetaAlmacen que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idMetaAlmacen As Integer)
		Dim MetaAlmacenSvc As New MetaAlmacenService(sessionID)
		Delete(MetaAlmacenSvc, idMetaAlmacen)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un MetaAlmacen con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMetaAlmacen">ID de MetaAlmacen que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idMetaAlmacen As Integer) As Boolean
		Dim MetaAlmacenSvc As New MetaAlmacenService(sessionID)
		Return Exists(MetaAlmacenSvc, idMetaAlmacen)
    End Function

    ''' <summary>
    ''' Verifica si existe un MetaAlmacen con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim MetaAlmacenSvc As New MetaAlmacenService(sessionID)
        Return Exists(MetaAlmacenSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un MetaAlmacen.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMetaAlmacen">Identificador de MetaAlmacen a consultar</param>
    ''' <returns>Paquete de información de tipo MetaAlmacenInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idMetaAlmacen As Integer) As MetaAlmacenInfo
        Return Me.GetDetail(sessionID, idMetaAlmacen, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un MetaAlmacen.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idMetaAlmacen">Identificador de MetaAlmacen</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del MetaAlmacen.</param>
    ''' <returns>Paquete de información de tipo MetaAlmacenInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idMetaAlmacen As Integer, checkStatus As Boolean) As MetaAlmacenInfo
   		Dim MetaAlmacenSvc As New MetaAlmacenService(sessionID)
        Dim MetaAlmacenInf As New MetaAlmacenInfo(sessionID)
		GetDetail(MetaAlmacenSvc, MetaAlmacenInf, idMetaAlmacen, checkStatus)
        Return MetaAlmacenInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un MetaAlmacen en base a su codigo de usuario
    ''' y verifica que el MetaAlmacen esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información MetaAlmacenInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As MetaAlmacenInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un MetaAlmacen en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del MetaAlmacen</param>
    ''' <returns>Paquete de información MetaAlmacenInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As MetaAlmacenInfo
        Dim MetaAlmacenInf As New MetaAlmacenInfo(sessionID)
        Dim MetaAlmacenSvc As New MetaAlmacenService(sessionID)
        GetDetail(MetaAlmacenSvc, MetaAlmacenInf, userCode, idSucursal, checkStatus)
        Return MetaAlmacenInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un MetaAlmacen.
    ''' </summary>
    ''' <param name="MetaAlmacen">Paquete de información del tipo MetaAlmacenInfo con la información a actualizar</param>
    ''' <returns>Identificador de MetaAlmacen, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal MetaAlmacen As MetaAlmacenInfo) As Integer
    	Dim MetaAlmacenSvc As New MetaAlmacenService(MetaAlmacen.sessionID)
		Return Update(MetaAlmacenSvc, MetaAlmacen)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim MetaAlmacenSvc As New MetaAlmacenService(sessionID)
    	Return GetNumberOfPages(MetaAlmacenSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca MetaAlmacenes que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca MetaAlmacenes que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim MetaAlmacenSvc As New MetaAlmacenService(sessionID)
    	Return GetSearchResult(MetaAlmacenSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de MetaAlmacenes.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim MetaAlmacenSvc As New MetaAlmacenService(sessionID)
    	Return GetSearchStructure(MetaAlmacenSvc)
    End Function

#End Region

End Class
