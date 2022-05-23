''' <summary>
''' Paquete de información que representa un Puesto
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class PuestoInfo
	Inherits HierarchyInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property IdCuenta As Integer
#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Puestos
''' </summary>
''' <remarks></remarks>
Public Class PuestoService
	Inherits HierarchyService(Of PuestoInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("RH","Puestos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos Publicos"

    Public Overrides Sub GetDetail(ByVal idPuesto As Integer, ByRef Puesto As PuestoInfo, checkStatus As Boolean)
		MyBase.GetDetail(idPuesto, Puesto, checkStatus)
        With Puesto
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
		End With
	End Sub
	
	Public Overrides Function Update(ByVal Puesto As PuestoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@IdCuenta", DbType.Int32).Value = Puesto.IdCuenta
		End With
		Return MyBase.Update(Puesto)
	End Function
	
	Public Overrides Function Create() As PuestoInfo
		Return New PuestoInfo(Session.SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de EstCom
''' </summary>
''' <remarks></remarks>
Public Class PuestoFacade
	Inherits HierarchyFacade(Of PuestoInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un PuestoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As PuestoInfo
		Dim PuestoSvc As New PuestoService(sessionID)
		Return PuestoSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Puestos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPuesto">Identificador del Puesto que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idPuesto As Integer)
		Dim PuestoSvc As New PuestoService(sessionID)
		Delete(PuestoSvc, idPuesto)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Puesto con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPuesto">ID de Puesto que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idPuesto As Integer) As Boolean
		Dim PuestoSvc As New PuestoService(sessionID)
		Return Exists(PuestoSvc, idPuesto)
    End Function

    ''' <summary>
    ''' Verifica si existe un Puesto con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, idSucursal as Integer) As Boolean
        Dim PuestoSvc As New PuestoService(sessionID)
        Return Exists(PuestoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Puesto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPuesto">Identificador de Puesto a consultar</param>
    ''' <returns>Paquete de información de tipo PuestoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPuesto As Integer) As PuestoInfo
        Return Me.GetDetail(sessionID, idPuesto, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Puesto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPuesto">Identificador de Puesto</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Puesto.</param>
    ''' <returns>Paquete de información de tipo PuestoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPuesto As Integer, checkStatus As Boolean) As PuestoInfo
   		Dim PuestoSvc As New PuestoService(sessionID)
        Dim PuestoInf As New PuestoInfo(sessionID)
		GetDetail(PuestoSvc, PuestoInf, idPuesto, checkStatus)
        Return PuestoInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un Puesto en base a su codigo de usuario
    ''' y verifica que el Puesto esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información PuestoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, idSucursal as Integer) As PuestoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Puesto en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Puesto</param>
    ''' <returns>Paquete de información PuestoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, idSucursal as Integer, ByVal checkStatus As Boolean) As PuestoInfo
        Dim PuestoInf As New PuestoInfo(sessionID)
        Dim PuestoSvc As New PuestoService(sessionID)
        GetDetail(PuestoSvc, PuestoInf, userCode, idSucursal, checkStatus)
        Return PuestoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Puesto.
    ''' </summary>
    ''' <param name="Puesto">Paquete de información del tipo PuestoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Puesto, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Puesto As PuestoInfo) As Integer
    	Dim PuestoSvc As New PuestoService(Puesto.SessionID)
		Return Update(PuestoSvc, Puesto)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim PuestoSvc As New PuestoService(sessionID)
    	Return GetNumberOfPages(PuestoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Puestos que coincidan con las condiciones especificadas.
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
    ''' Busca Puestos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim PuestoSvc As New PuestoService(sessionID)
    	Return GetSearchResult(PuestoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Puestos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim PuestoSvc As New PuestoService(sessionID)
    	Return GetSearchStructure(PuestoSvc)
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
		Dim PuestoSvc As New PuestoService(sessionID)
		Dim Nodes AS New HierarchyDS.HierarchyDataTable
		LoadChilds(PuestoSvc, idEmpresa, idPadre, Nodes)
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
		Dim PuestoSvc As New PuestoService(sessionID)
		MoveNode(PuestoSvc, idNodo, idParentDest, order)
    End Sub

#End Region

End Class
