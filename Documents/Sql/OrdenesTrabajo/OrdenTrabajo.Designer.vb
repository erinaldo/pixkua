''' <summary>
''' Paquete de información que representa un OrdenTrabajo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class OrdenTrabajoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
	Public Property Nombre As String	Public Property Fecha As Date	Public Property IdArticuloStock As Integer	Public Property CantDeseada As Decimal	Public Property CantRecibida As Decimal	Public Property Version As Integer	Public Property IdOrdenTrabajoTipo As Integer	Public Property FechaPromEntrega As Date	Public Property HoraAplicado As Date	Public Property HoraCierre As Date	Public Property EntregasParciales As Boolean	Public Property ExigirRecepcion As Boolean	Public Property Observaciones As String	Public Property IdCuenta As Integer
#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de OrdenesTrabajo
''' </summary>
''' <remarks></remarks>
Public Class OrdenTrabajoService
	Inherits CatalogService(Of OrdenTrabajoInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Production","OrdenesTrabajo", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idOrdenTrabajo As Integer, ByRef OrdenTrabajo As OrdenTrabajoInfo, checkStatus As Boolean)
		MyBase.GetDetail(idOrdenTrabajo, OrdenTrabajo, checkStatus)
        With OrdenTrabajo
			.Nombre = CStr(ItemInfo("Nombre"))
			.Fecha = CDate(ItemInfo("Fecha"))
			.IdArticuloStock = CInt(ItemInfo("IdArticuloStock"))
			.CantDeseada = CDec(ItemInfo("CantDeseada"))
			.CantRecibida = CDec(ItemInfo("CantRecibida"))
			.Version = CInt(ItemInfo("Version"))
			.IdOrdenTrabajoTipo = CInt(ItemInfo("IdOrdenTrabajoTipo"))
			.FechaPromEntrega = CDate(ItemInfo("FechaPromEntrega"))
			.HoraAplicado = CDate(ItemInfo("HoraAplicado"))
			.HoraCierre = CDate(ItemInfo("HoraCierre"))
			.EntregasParciales = CBool(ItemInfo("EntregasParciales"))
			.ExigirRecepcion = CBool(ItemInfo("ExigirRecepcion"))
			.Observaciones = CStr(ItemInfo("Observaciones"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal OrdenTrabajo As OrdenTrabajoInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = OrdenTrabajo.Nombre
			.Add("@Fecha", DbType.DateTime).Value = OrdenTrabajo.Fecha
			.Add("@IdArticuloStock", DbType.Int32).Value = OrdenTrabajo.IdArticuloStock
			.Add("@CantDeseada", DbType.Decimal).Value = OrdenTrabajo.CantDeseada
			.Add("@CantRecibida", DbType.Decimal).Value = OrdenTrabajo.CantRecibida
			.Add("@Version", DbType.Int32).Value = OrdenTrabajo.Version
			.Add("@IdOrdenTrabajoTipo", DbType.Int32).Value = OrdenTrabajo.IdOrdenTrabajoTipo
			.Add("@FechaPromEntrega", DbType.DateTime).Value = OrdenTrabajo.FechaPromEntrega
			.Add("@HoraAplicado", DbType.DateTime).Value = OrdenTrabajo.HoraAplicado
			.Add("@HoraCierre", DbType.DateTime).Value = OrdenTrabajo.HoraCierre
			.Add("@EntregasParciales", DbType.Boolean).Value = OrdenTrabajo.EntregasParciales
			.Add("@ExigirRecepcion", DbType.Boolean).Value = OrdenTrabajo.ExigirRecepcion
			.Add("@Observaciones", DbType.String).Value = OrdenTrabajo.Observaciones
			.Add("@IdCuenta", DbType.Int32).Value = OrdenTrabajo.IdCuenta

		End With
		Return MyBase.Update(OrdenTrabajo)
	End Function
	
	Public Overrides Function Create() As OrdenTrabajoInfo
		Return New OrdenTrabajoInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de OrdenesTrabajo
''' </summary>
''' <remarks></remarks>
Public Class OrdenTrabajoFacade
	Inherits CatalogFacade(Of OrdenTrabajoInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un OrdenTrabajoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As OrdenTrabajoInfo
		Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
		Return OrdenTrabajoSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de OrdenesTrabajo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idOrdenTrabajo">Identificador del OrdenTrabajo que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idOrdenTrabajo As Integer)
		Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
		Delete(OrdenTrabajoSvc, idOrdenTrabajo)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un OrdenTrabajo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idOrdenTrabajo">ID de OrdenTrabajo que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idOrdenTrabajo As Integer) As Boolean
		Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
		Return Exists(OrdenTrabajoSvc, idOrdenTrabajo)
    End Function

    ''' <summary>
    ''' Verifica si existe un OrdenTrabajo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
        Return Exists(OrdenTrabajoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un OrdenTrabajo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idOrdenTrabajo">Identificador de OrdenTrabajo a consultar</param>
    ''' <returns>Paquete de información de tipo OrdenTrabajoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idOrdenTrabajo As Integer) As OrdenTrabajoInfo
        Return Me.GetDetail(sessionID, idOrdenTrabajo, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un OrdenTrabajo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idOrdenTrabajo">Identificador de OrdenTrabajo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del OrdenTrabajo.</param>
    ''' <returns>Paquete de información de tipo OrdenTrabajoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idOrdenTrabajo As Integer, checkStatus As Boolean) As OrdenTrabajoInfo
   		Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
        Dim OrdenTrabajoInf As New OrdenTrabajoInfo(sessionID)
		GetDetail(OrdenTrabajoSvc, OrdenTrabajoInf, idOrdenTrabajo, checkStatus)
        Return OrdenTrabajoInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un OrdenTrabajo en base a su codigo de usuario
    ''' y verifica que el OrdenTrabajo esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información OrdenTrabajoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As OrdenTrabajoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un OrdenTrabajo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del OrdenTrabajo</param>
    ''' <returns>Paquete de información OrdenTrabajoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As OrdenTrabajoInfo
        Dim OrdenTrabajoInf As New OrdenTrabajoInfo(sessionID)
        Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
        GetDetail(OrdenTrabajoSvc, OrdenTrabajoInf, userCode, idSucursal, checkStatus)
        Return OrdenTrabajoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un OrdenTrabajo.
    ''' </summary>
    ''' <param name="OrdenTrabajo">Paquete de información del tipo OrdenTrabajoInfo con la información a actualizar</param>
    ''' <returns>Identificador de OrdenTrabajo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal OrdenTrabajo As OrdenTrabajoInfo) As Integer
    	Dim OrdenTrabajoSvc As New OrdenTrabajoService(OrdenTrabajo.sessionID)
		Return Update(OrdenTrabajoSvc, OrdenTrabajo)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
    	Return GetNumberOfPages(OrdenTrabajoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca OrdenesTrabajo que coincidan con las condiciones especificadas.
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
    ''' Busca OrdenesTrabajo que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
    	Return GetSearchResult(OrdenTrabajoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de OrdenesTrabajo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim OrdenTrabajoSvc As New OrdenTrabajoService(sessionID)
    	Return GetSearchStructure(OrdenTrabajoSvc)
    End Function

#End Region

End Class
