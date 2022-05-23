''' <summary>
''' Paquete de información que representa un Departamento
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class DepartamentoInfo
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
''' Proveedor de servicios para el manejo del catálogo de Departamentos
''' </summary>
''' <remarks></remarks>
Public Class DepartamentoService
	Inherits HierarchyService(Of DepartamentoInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("RH","Departamentos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos Publicos"

    Public Overrides Sub GetDetail(ByVal idDepartamento As Integer, ByRef Departamento As DepartamentoInfo, checkStatus As Boolean)
		MyBase.GetDetail(idDepartamento, Departamento, checkStatus)
        With Departamento
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
        End With
	End Sub
	
	Public Overrides Function Update(ByVal Departamento As DepartamentoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@IdCuenta", DbType.Int32).Value = Departamento.IdCuenta
		End With
		Return MyBase.Update(Departamento)
	End Function
	
	Public Overrides Function Create() As DepartamentoInfo
		Return New DepartamentoInfo(Session.SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de EstCom
''' </summary>
''' <remarks></remarks>
Public Class DepartamentoFacade
	Inherits HierarchyFacade(Of DepartamentoInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un DepartamentoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As DepartamentoInfo
		Dim DepartamentoSvc As New DepartamentoService(sessionID)
		Return DepartamentoSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Departamentos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDepartamento">Identificador del Departamento que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idDepartamento As Integer)
		Dim DepartamentoSvc As New DepartamentoService(sessionID)
		Delete(DepartamentoSvc, idDepartamento)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Departamento con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDepartamento">ID de Departamento que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idDepartamento As Integer) As Boolean
		Dim DepartamentoSvc As New DepartamentoService(sessionID)
		Return Exists(DepartamentoSvc, idDepartamento)
    End Function

    ''' <summary>
    ''' Verifica si existe un Departamento con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, idSucursal as Integer) As Boolean
        Dim DepartamentoSvc As New DepartamentoService(sessionID)
        Return Exists(DepartamentoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Departamento.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDepartamento">Identificador de Departamento a consultar</param>
    ''' <returns>Paquete de información de tipo DepartamentoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idDepartamento As Integer) As DepartamentoInfo
        Return Me.GetDetail(sessionID, idDepartamento, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Departamento.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDepartamento">Identificador de Departamento</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Departamento.</param>
    ''' <returns>Paquete de información de tipo DepartamentoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idDepartamento As Integer, checkStatus As Boolean) As DepartamentoInfo
   		Dim DepartamentoSvc As New DepartamentoService(sessionID)
        Dim DepartamentoInf As New DepartamentoInfo(sessionID)
		GetDetail(DepartamentoSvc, DepartamentoInf, idDepartamento, checkStatus)
        Return DepartamentoInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un Departamento en base a su codigo de usuario
    ''' y verifica que el Departamento esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información DepartamentoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, idSucursal as Integer) As DepartamentoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Departamento en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Departamento</param>
    ''' <returns>Paquete de información DepartamentoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, idSucursal as Integer, ByVal checkStatus As Boolean) As DepartamentoInfo
        Dim DepartamentoInf As New DepartamentoInfo(sessionID)
        Dim DepartamentoSvc As New DepartamentoService(sessionID)
        GetDetail(DepartamentoSvc, DepartamentoInf, userCode, idSucursal, checkStatus)
        Return DepartamentoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Departamento.
    ''' </summary>
    ''' <param name="Departamento">Paquete de información del tipo DepartamentoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Departamento, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Departamento As DepartamentoInfo) As Integer
    	Dim DepartamentoSvc As New DepartamentoService(Departamento.SessionID)
		Return Update(DepartamentoSvc, Departamento)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim DepartamentoSvc As New DepartamentoService(sessionID)
    	Return GetNumberOfPages(DepartamentoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Departamentos que coincidan con las condiciones especificadas.
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
    ''' Busca Departamentos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim DepartamentoSvc As New DepartamentoService(sessionID)
    	Return GetSearchResult(DepartamentoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Departamentos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim DepartamentoSvc As New DepartamentoService(sessionID)
    	Return GetSearchStructure(DepartamentoSvc)
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
		Dim DepartamentoSvc As New DepartamentoService(sessionID)
		Dim Nodes AS New HierarchyDS.HierarchyDataTable
		LoadChilds(DepartamentoSvc, idEmpresa, idPadre, Nodes)
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
		Dim DepartamentoSvc As New DepartamentoService(sessionID)
		MoveNode(DepartamentoSvc, idNodo, idParentDest, order)
    End Sub

#End Region

End Class
