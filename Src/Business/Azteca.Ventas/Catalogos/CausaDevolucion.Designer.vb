''' <summary>
''' Paquete de información que representa un CausaDevolucion
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CausaDevolucionInfo
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
''' Proveedor de servicios para el manejo del catálogo de DevolucionesCausas
''' </summary>
''' <remarks></remarks>
Public Class CausaDevolucionService
	Inherits CatalogService(Of CausaDevolucionInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales","DevolucionesCausas", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCausaDevolucion As Integer, ByRef CausaDevolucion As CausaDevolucionInfo, checkStatus As Boolean)
		MyBase.GetDetail(idCausaDevolucion, CausaDevolucion, checkStatus)
        With CausaDevolucion
			.Nombre = CStr(ItemInfo("Nombre"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))
		End With
	End Sub
	
	Public Overrides Function Update(ByVal CausaDevolucion As CausaDevolucionInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = CausaDevolucion.Nombre
			.Add("@IdCuenta", DbType.Int32).Value = CausaDevolucion.IdCuenta
		End With
		Return MyBase.Update(CausaDevolucion)
	End Function
	
	Public Overrides Function Create() As CausaDevolucionInfo
		Return New CausaDevolucionInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de DevolucionesCausas
''' </summary>
''' <remarks></remarks>
Public Class CausaDevolucionFacade
	Inherits CatalogFacade(Of CausaDevolucionInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CausaDevolucionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As CausaDevolucionInfo
		Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
		Return CausaDevolucionSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de DevolucionesCausas
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCausaDevolucion">Identificador del CausaDevolucion que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idCausaDevolucion As Integer)
		Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
		Delete(CausaDevolucionSvc, idCausaDevolucion)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un CausaDevolucion con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCausaDevolucion">ID de CausaDevolucion que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idCausaDevolucion As Integer) As Boolean
		Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
		Return Exists(CausaDevolucionSvc, idCausaDevolucion)
    End Function

    ''' <summary>
    ''' Verifica si existe un CausaDevolucion con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
        Return Exists(CausaDevolucionSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CausaDevolucion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCausaDevolucion">Identificador de CausaDevolucion a consultar</param>
    ''' <returns>Paquete de información de tipo CausaDevolucionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCausaDevolucion As Integer) As CausaDevolucionInfo
        Return Me.GetDetail(sessionID, idCausaDevolucion, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CausaDevolucion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCausaDevolucion">Identificador de CausaDevolucion</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del CausaDevolucion.</param>
    ''' <returns>Paquete de información de tipo CausaDevolucionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCausaDevolucion As Integer, checkStatus As Boolean) As CausaDevolucionInfo
   		Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
        Dim CausaDevolucionInf As New CausaDevolucionInfo(sessionID)
		GetDetail(CausaDevolucionSvc, CausaDevolucionInf, idCausaDevolucion, checkStatus)
        Return CausaDevolucionInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un CausaDevolucion en base a su codigo de usuario
    ''' y verifica que el CausaDevolucion esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información CausaDevolucionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As CausaDevolucionInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CausaDevolucion en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del CausaDevolucion</param>
    ''' <returns>Paquete de información CausaDevolucionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CausaDevolucionInfo
        Dim CausaDevolucionInf As New CausaDevolucionInfo(sessionID)
        Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
        GetDetail(CausaDevolucionSvc, CausaDevolucionInf, userCode, idSucursal, checkStatus)
        Return CausaDevolucionInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un CausaDevolucion.
    ''' </summary>
    ''' <param name="CausaDevolucion">Paquete de información del tipo CausaDevolucionInfo con la información a actualizar</param>
    ''' <returns>Identificador de CausaDevolucion, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal CausaDevolucion As CausaDevolucionInfo) As Integer
    	Dim CausaDevolucionSvc As New CausaDevolucionService(CausaDevolucion.sessionID)
		Return Update(CausaDevolucionSvc, CausaDevolucion)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
    	Return GetNumberOfPages(CausaDevolucionSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca DevolucionesCausas que coincidan con las condiciones especificadas.
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
    ''' Busca DevolucionesCausas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
    	Return GetSearchResult(CausaDevolucionSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de DevolucionesCausas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
    	Return GetSearchStructure(CausaDevolucionSvc)
    End Function

#End Region

End Class
