''' <summary>
''' Paquete de información que representa un Flujo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class FlujoInfo
	Inherits HierarchyInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Tipo As String

    Public Property SegNeg As Boolean


#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Flujo
''' </summary>
''' <remarks></remarks>
Public Class FlujoService
	Inherits HierarchyService(Of FlujoInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting","Flujo", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos Publicos"

    Public Overrides Sub GetDetail(ByVal idFlujo As Integer, ByRef Flujo As FlujoInfo, checkStatus As Boolean)
		MyBase.GetDetail(idFlujo, Flujo, checkStatus)
        With Flujo
			.Tipo = CStr(ItemInfo("Tipo"))
			.SegNeg = CBool(ItemInfo("SegNeg"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal Flujo As FlujoInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Tipo", DbType.String).Value = Flujo.Tipo
			.Add("@SegNeg", DbType.Boolean).Value = Flujo.SegNeg

		End With
		Return MyBase.Update(Flujo)
	End Function
	
	Public Overrides Function Create() As FlujoInfo
		Return New FlujoInfo(Session.SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de EstCom
''' </summary>
''' <remarks></remarks>
Public Class FlujoFacade
	Inherits HierarchyFacade(Of FlujoInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un FlujoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As FlujoInfo
        Dim FlujoSvc As New FlujoService(sessionID)
        Dim FlujoInf As FlujoInfo = FlujoSvc.Create()
        FlujoInf.Tipo = "I"
        Return FlujoInf
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Flujo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idFlujo">Identificador del Flujo que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idFlujo As Integer)
		Dim FlujoSvc As New FlujoService(sessionID)
		Delete(FlujoSvc, idFlujo)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Flujo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idFlujo">ID de Flujo que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idFlujo As Integer) As Boolean
		Dim FlujoSvc As New FlujoService(sessionID)
		Return Exists(FlujoSvc, idFlujo)
    End Function

    ''' <summary>
    ''' Verifica si existe un Flujo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, idSucursal as Integer) As Boolean
        Dim FlujoSvc As New FlujoService(sessionID)
        Return Exists(FlujoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Flujo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idFlujo">Identificador de Flujo a consultar</param>
    ''' <returns>Paquete de información de tipo FlujoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idFlujo As Integer) As FlujoInfo
        Return Me.GetDetail(sessionID, idFlujo, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Flujo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idFlujo">Identificador de Flujo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Flujo.</param>
    ''' <returns>Paquete de información de tipo FlujoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idFlujo As Integer, checkStatus As Boolean) As FlujoInfo
   		Dim FlujoSvc As New FlujoService(sessionID)
        Dim FlujoInf As New FlujoInfo(sessionID)
		GetDetail(FlujoSvc, FlujoInf, idFlujo, checkStatus)
        Return FlujoInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un Flujo en base a su codigo de usuario
    ''' y verifica que el Flujo esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información FlujoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, idSucursal as Integer) As FlujoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Flujo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Flujo</param>
    ''' <returns>Paquete de información FlujoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, idSucursal as Integer, ByVal checkStatus As Boolean) As FlujoInfo
        Dim FlujoInf As New FlujoInfo(sessionID)
        Dim FlujoSvc As New FlujoService(sessionID)
        GetDetail(FlujoSvc, FlujoInf, userCode, idSucursal, checkStatus)
        Return FlujoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Flujo.
    ''' </summary>
    ''' <param name="Flujo">Paquete de información del tipo FlujoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Flujo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Flujo As FlujoInfo) As Integer
    	Dim FlujoSvc As New FlujoService(Flujo.SessionID)
		Return Update(FlujoSvc, Flujo)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim FlujoSvc As New FlujoService(sessionID)
    	Return GetNumberOfPages(FlujoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Flujo que coincidan con las condiciones especificadas.
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
    ''' Busca Flujo que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim FlujoSvc As New FlujoService(sessionID)
    	Return GetSearchResult(FlujoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Flujo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim FlujoSvc As New FlujoService(sessionID)
    	Return GetSearchStructure(FlujoSvc)
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
		Dim FlujoSvc As New FlujoService(sessionID)
		Dim Nodes AS New HierarchyDS.HierarchyDataTable
		LoadChilds(FlujoSvc, idEmpresa, idPadre, Nodes)
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
		Dim FlujoSvc As New FlujoService(sessionID)
		MoveNode(FlujoSvc, idNodo, idParentDest, order)
    End Sub

#End Region

End Class
