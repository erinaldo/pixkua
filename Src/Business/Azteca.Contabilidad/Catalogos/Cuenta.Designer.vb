''' <summary>
''' Paquete de información que representa un Cuenta
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CuentaInfo
	Inherits HierarchyInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"

    Public Property IdCuentaTipo As Integer

    Public Property IdCuentaOrden As Integer

    Public Property IdFlujo As Integer

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Cuentas
''' </summary>
''' <remarks></remarks>
Public Class CuentaService
    Inherits HierarchyService(Of CuentaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "Cuentas", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos Publicos"

    Public Overrides Sub GetDetail(ByVal idCuenta As Integer, ByRef Cuenta As CuentaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idCuenta, Cuenta, checkStatus)
        With Cuenta
            .IdCuentaTipo = CInt(ItemInfo("IdCuentaTipo"))
            .IdCuentaOrden = CInt(ItemInfo("IdCuentaOrden"))
            .IdFlujo = CInt(ItemInfo("IdFlujo"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Cuenta As CuentaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@IdCuentaTipo", DbType.Int32).Value = Cuenta.IdCuentaTipo
            .Add("@IdCuentaOrden", DbType.Int32).Value = Cuenta.IdCuentaOrden
            .Add("@IdFlujo", DbType.Int32).Value = Cuenta.IdFlujo
        End With
        Return MyBase.Update(Cuenta)
    End Function

    Public Overrides Function Create() As CuentaInfo
        Return New CuentaInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de EstCom
''' </summary>
''' <remarks></remarks>
Public Class CuentaFacade
    Inherits HierarchyFacade(Of CuentaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CuentaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As CuentaInfo
        Dim CuentaSvc As New CuentaService(sessionID)
        Return CuentaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Cuentas
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCuenta">Identificador del Cuenta que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idCuenta As Integer)
        Dim CuentaSvc As New CuentaService(sessionID)
        Delete(CuentaSvc, idCuenta)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Cuenta con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCuenta">ID de Cuenta que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idCuenta As Integer) As Boolean
        Dim CuentaSvc As New CuentaService(sessionID)
        Return Exists(CuentaSvc, idCuenta)
    End Function

    ''' <summary>
    ''' Verifica si existe un Cuenta con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim CuentaSvc As New CuentaService(sessionID)
        Return Exists(CuentaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Cuenta.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCuenta">Identificador de Cuenta a consultar</param>
    ''' <returns>Paquete de información de tipo CuentaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCuenta As Integer) As CuentaInfo
        Return Me.GetDetail(sessionID, idCuenta, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Cuenta.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCuenta">Identificador de Cuenta</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Cuenta.</param>
    ''' <returns>Paquete de información de tipo CuentaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCuenta As Integer, ByVal checkStatus As Boolean) As CuentaInfo
        Dim CuentaSvc As New CuentaService(sessionID)
        Dim CuentaInf As New CuentaInfo(sessionID)
        GetDetail(CuentaSvc, CuentaInf, idCuenta, checkStatus)
        Return CuentaInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Cuenta en base a su codigo de usuario
    ''' y verifica que el Cuenta esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información CuentaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As CuentaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Cuenta en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Cuenta</param>
    ''' <returns>Paquete de información CuentaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CuentaInfo
        Dim CuentaInf As New CuentaInfo(sessionID)
        Dim CuentaSvc As New CuentaService(sessionID)
        GetDetail(CuentaSvc, CuentaInf, userCode, idSucursal, checkStatus)
        Return CuentaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Cuenta.
    ''' </summary>
    ''' <param name="Cuenta">Paquete de información del tipo CuentaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Cuenta, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Cuenta As CuentaInfo) As Integer
        Dim CuentaSvc As New CuentaService(Cuenta.SessionID)
        Return Update(CuentaSvc, Cuenta)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim CuentaSvc As New CuentaService(sessionID)
        Return GetNumberOfPages(CuentaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Cuentas que coincidan con las condiciones especificadas.
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
    ''' Busca Cuentas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim CuentaSvc As New CuentaService(sessionID)
        Return GetSearchResult(CuentaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Cuentas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim CuentaSvc As New CuentaService(sessionID)
        Return GetSearchStructure(CuentaSvc)
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
    Public Overrides Function LoadChilds(ByVal sessionID As GUID, ByVal idEmpresa As Integer, ByVal idPadre As Integer) As HierarchyDS.HierarchyDataTable
        Dim CuentaSvc As New CuentaService(sessionID)
        Dim Nodes As New HierarchyDS.HierarchyDataTable
        LoadChilds(CuentaSvc, idEmpresa, idPadre, Nodes)
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
        Dim CuentaSvc As New CuentaService(sessionID)
        MoveNode(CuentaSvc, idNodo, idParentDest, order)
    End Sub

#End Region

End Class
