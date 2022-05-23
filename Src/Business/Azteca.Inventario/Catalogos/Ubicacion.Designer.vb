''' <summary>
''' Paquete de información que representa un Ubicacion
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class UbicacionInfo
	Inherits HierarchyInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property IdAlmacen As Integer

    Public Property IdUbicacionTipo As Integer

    Public Property IdImpresora As Integer

    Public Property IdCuenta As Integer


#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region

  
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Ubicaciones
''' </summary>
''' <remarks></remarks>
Public Class UbicacionService
	Inherits HierarchyService(Of UbicacionInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory","Ubicaciones", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos Publicos"

    Public Overrides Sub GetDetail(ByVal idUbicacion As Integer, ByRef Ubicacion As UbicacionInfo, checkStatus As Boolean)
		MyBase.GetDetail(idUbicacion, Ubicacion, checkStatus)
        With Ubicacion
			.IdAlmacen = CInt(ItemInfo("IdAlmacen"))
			.IdUbicacionTipo = CInt(ItemInfo("IdUbicacionTipo"))
			.IdImpresora = CInt(ItemInfo("IdImpresora"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal Ubicacion As UbicacionInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@IdAlmacen", DbType.Int32).Value = Ubicacion.IdAlmacen
			.Add("@IdUbicacionTipo", DbType.Int32).Value = Ubicacion.IdUbicacionTipo
			.Add("@IdImpresora", DbType.Int32).Value = Ubicacion.IdImpresora
			.Add("@IdCuenta", DbType.Int32).Value = Ubicacion.IdCuenta

		End With
		Return MyBase.Update(Ubicacion)
	End Function
	
	Public Overrides Function Create() As UbicacionInfo
		Return New UbicacionInfo(Session.SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de EstCom
''' </summary>
''' <remarks></remarks>
Public Class UbicacionFacade
	Inherits HierarchyFacade(Of UbicacionInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un UbicacionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As UbicacionInfo
		Dim UbicacionSvc As New UbicacionService(sessionID)
		Return UbicacionSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Ubicaciones
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idUbicacion">Identificador del Ubicacion que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idUbicacion As Integer)
		Dim UbicacionSvc As New UbicacionService(sessionID)
		Delete(UbicacionSvc, idUbicacion)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Ubicacion con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idUbicacion">ID de Ubicacion que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idUbicacion As Integer) As Boolean
		Dim UbicacionSvc As New UbicacionService(sessionID)
		Return Exists(UbicacionSvc, idUbicacion)
    End Function

    ''' <summary>
    ''' Verifica si existe un Ubicacion con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, idSucursal as Integer) As Boolean
        Dim UbicacionSvc As New UbicacionService(sessionID)
        Return Exists(UbicacionSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Ubicacion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idUbicacion">Identificador de Ubicacion a consultar</param>
    ''' <returns>Paquete de información de tipo UbicacionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idUbicacion As Integer) As UbicacionInfo
        Return Me.GetDetail(sessionID, idUbicacion, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Ubicacion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idUbicacion">Identificador de Ubicacion</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Ubicacion.</param>
    ''' <returns>Paquete de información de tipo UbicacionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idUbicacion As Integer, checkStatus As Boolean) As UbicacionInfo
   		Dim UbicacionSvc As New UbicacionService(sessionID)
        Dim UbicacionInf As New UbicacionInfo(sessionID)
		GetDetail(UbicacionSvc, UbicacionInf, idUbicacion, checkStatus)
        Return UbicacionInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un Ubicacion en base a su codigo de usuario
    ''' y verifica que el Ubicacion esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información UbicacionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, idSucursal as Integer) As UbicacionInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Ubicacion en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Ubicacion</param>
    ''' <returns>Paquete de información UbicacionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, idSucursal as Integer, ByVal checkStatus As Boolean) As UbicacionInfo
        Dim UbicacionInf As New UbicacionInfo(sessionID)
        Dim UbicacionSvc As New UbicacionService(sessionID)
        GetDetail(UbicacionSvc, UbicacionInf, userCode, idSucursal, checkStatus)
        Return UbicacionInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Ubicacion.
    ''' </summary>
    ''' <param name="Ubicacion">Paquete de información del tipo UbicacionInfo con la información a actualizar</param>
    ''' <returns>Identificador de Ubicacion, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Ubicacion As UbicacionInfo) As Integer
    	Dim UbicacionSvc As New UbicacionService(Ubicacion.SessionID)
		Return Update(UbicacionSvc, Ubicacion)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim UbicacionSvc As New UbicacionService(sessionID)
    	Return GetNumberOfPages(UbicacionSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Ubicaciones que coincidan con las condiciones especificadas.
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
    ''' Busca Ubicaciones que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim UbicacionSvc As New UbicacionService(sessionID)
    	Return GetSearchResult(UbicacionSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Ubicaciones.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim UbicacionSvc As New UbicacionService(sessionID)
    	Return GetSearchStructure(UbicacionSvc)
    End Function

#End Region

#Region "Implementacion IHierarchyFacade"

    ''' <summary>
    ''' Obtiene los nodos secundarios del nodo especificado
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="idPadre">Identificador del nodo del que se obtendrán sus nodos secundarios</param>
    ''' <returns>Datatable con la lista de nodos secundarios.</returns>
    ''' <remarks></remarks>
    Public Overrides Function LoadChilds(ByVal sessionID As GUID, idEmpresa as Integer, ByVal idPadre As Integer) As HierarchyDS.HierarchyDataTable
		Dim UbicacionSvc As New UbicacionService(sessionID)
		Dim Nodes AS New HierarchyDS.HierarchyDataTable
		LoadChilds(UbicacionSvc, idEmpresa, idPadre, Nodes)
		Return Nodes
    End Function
    
    ''' <summary>
    ''' Mueve un nodo al nivel y posición especificados
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idNodo">Identificador del nodo que se moverá</param>
    ''' <param name="idParentDest">Identificador del nuevo nodo padre.</param>
    ''' <param name="order">Nueva posición del nodo dentro del nivel.</param>
    ''' <remarks></remarks>
    Public Overrides Sub MoveNode(ByVal sessionID As GUID, ByVal idNodo As Integer, ByVal idParentDest As Integer, ByVal order As Integer)
		Dim UbicacionSvc As New UbicacionService(sessionID)
		MoveNode(UbicacionSvc, idNodo, idParentDest, order)
    End Sub

#End Region

End Class
