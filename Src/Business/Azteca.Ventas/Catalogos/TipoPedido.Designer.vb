''' <summary>
''' Paquete de información que representa un TipoPedido
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class TipoPedidoInfo
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
''' Proveedor de servicios para el manejo del catálogo de PedidosTipos
''' </summary>
''' <remarks></remarks>
Public Class TipoPedidoService
	Inherits CatalogService(Of TipoPedidoInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales","PedidosTipos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idTipoPedido As Integer, ByRef TipoPedido As TipoPedidoInfo, checkStatus As Boolean)
		MyBase.GetDetail(idTipoPedido, TipoPedido, checkStatus)
        With TipoPedido
			.Nombre = CStr(ItemInfo("Nombre"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))
		End With
	End Sub
	
	Public Overrides Function Update(ByVal TipoPedido As TipoPedidoInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = TipoPedido.Nombre
			.Add("@IdCuenta", DbType.Int32).Value = TipoPedido.IdCuenta
		End With
		Return MyBase.Update(TipoPedido)
	End Function
	
	Public Overrides Function Create() As TipoPedidoInfo
		Return New TipoPedidoInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de PedidosTipos
''' </summary>
''' <remarks></remarks>
Public Class TipoPedidoFacade
	Inherits CatalogFacade(Of TipoPedidoInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un TipoPedidoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As TipoPedidoInfo
		Dim TipoPedidoSvc As New TipoPedidoService(sessionID)
		Return TipoPedidoSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de PedidosTipos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTipoPedido">Identificador del TipoPedido que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idTipoPedido As Integer)
		Dim TipoPedidoSvc As New TipoPedidoService(sessionID)
		Delete(TipoPedidoSvc, idTipoPedido)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un TipoPedido con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTipoPedido">ID de TipoPedido que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idTipoPedido As Integer) As Boolean
		Dim TipoPedidoSvc As New TipoPedidoService(sessionID)
		Return Exists(TipoPedidoSvc, idTipoPedido)
    End Function

    ''' <summary>
    ''' Verifica si existe un TipoPedido con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim TipoPedidoSvc As New TipoPedidoService(sessionID)
        Return Exists(TipoPedidoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un TipoPedido.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTipoPedido">Identificador de TipoPedido a consultar</param>
    ''' <returns>Paquete de información de tipo TipoPedidoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTipoPedido As Integer) As TipoPedidoInfo
        Return Me.GetDetail(sessionID, idTipoPedido, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un TipoPedido.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTipoPedido">Identificador de TipoPedido</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del TipoPedido.</param>
    ''' <returns>Paquete de información de tipo TipoPedidoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTipoPedido As Integer, checkStatus As Boolean) As TipoPedidoInfo
   		Dim TipoPedidoSvc As New TipoPedidoService(sessionID)
        Dim TipoPedidoInf As New TipoPedidoInfo(sessionID)
		GetDetail(TipoPedidoSvc, TipoPedidoInf, idTipoPedido, checkStatus)
        Return TipoPedidoInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un TipoPedido en base a su codigo de usuario
    ''' y verifica que el TipoPedido esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información TipoPedidoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As TipoPedidoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un TipoPedido en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del TipoPedido</param>
    ''' <returns>Paquete de información TipoPedidoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As TipoPedidoInfo
        Dim TipoPedidoInf As New TipoPedidoInfo(sessionID)
        Dim TipoPedidoSvc As New TipoPedidoService(sessionID)
        GetDetail(TipoPedidoSvc, TipoPedidoInf, userCode, idSucursal, checkStatus)
        Return TipoPedidoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un TipoPedido.
    ''' </summary>
    ''' <param name="TipoPedido">Paquete de información del tipo TipoPedidoInfo con la información a actualizar</param>
    ''' <returns>Identificador de TipoPedido, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal TipoPedido As TipoPedidoInfo) As Integer
    	Dim TipoPedidoSvc As New TipoPedidoService(TipoPedido.sessionID)
		Return Update(TipoPedidoSvc, TipoPedido)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim TipoPedidoSvc As New TipoPedidoService(sessionID)
    	Return GetNumberOfPages(TipoPedidoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca PedidosTipos que coincidan con las condiciones especificadas.
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
    ''' Busca PedidosTipos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim TipoPedidoSvc As New TipoPedidoService(sessionID)
    	Return GetSearchResult(TipoPedidoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de PedidosTipos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim TipoPedidoSvc As New TipoPedidoService(sessionID)
    	Return GetSearchStructure(TipoPedidoSvc)
    End Function

#End Region

End Class
