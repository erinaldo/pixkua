''' <summary>
''' Paquete de información que representa un GastoConcepto
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class GastoConceptoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Protected Friend _GastoConceptoTipo As String
    Protected Friend _Cuenta As String
    Protected Friend _DescrCuenta As String
    Protected Friend _CategoriaPresupuestal As String
#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdGastoConceptoTipo As Integer

    Public Property IdCategoriaPresupuestal As Integer

    Public Property IdCuenta As Integer

    Public ReadOnly Property GastoConceptoTipo As String
        Get
            Return _GastoConceptoTipo
        End Get
    End Property
    Public ReadOnly Property Cuenta As String
        Get
            Return _Cuenta
        End Get
    End Property
    Public ReadOnly Property DescrCuenta As String
        Get
            Return _DescrCuenta
        End Get
    End Property
    Public ReadOnly Property CategoriaPresupuestal As String
        Get
            Return _CategoriaPresupuestal
        End Get
    End Property

#End Region

#Region "Constructor"
    Public Sub New(ByVal SessionID As Guid)
        MyBase.New(SessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de GastosConceptos
''' </summary>
''' <remarks></remarks>
Public Class GastoConceptoService
    Inherits CatalogService(Of GastoConceptoInfo)

#Region "Constructores"
    Public Sub New(ByVal SessionID As Guid)
        Me.New(SessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal SessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(SessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal SessionID As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "GastosConceptos", SessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idGastoConcepto As Integer, ByRef GastoConcepto As GastoConceptoInfo, checkStatus As Boolean)
        MyBase.GetDetail(idGastoConcepto, GastoConcepto, checkStatus)
        With GastoConcepto
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdGastoConceptoTipo = CInt(ItemInfo("IdGastoConceptoTipo"))
            .IdCategoriaPresupuestal = CInt(ItemInfo("IdCategoriaPresupuestal"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            ._GastoConceptoTipo = CStr(ItemInfo("GastoConceptoTipo"))
            ._Cuenta = CStr(ItemInfo("Cuenta"))
            ._DescrCuenta = CStr(ItemInfo("DescrCuenta"))
            ._CategoriaPresupuestal = CStr(ItemInfo("CategoriaPresupuestal"))
        End With
    End Sub

    Public Overrides Function Update(ByVal GastoConcepto As GastoConceptoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = GastoConcepto.Nombre
            .Add("@IdGastoConceptoTipo", DbType.Int32).Value = GastoConcepto.IdGastoConceptoTipo
            .Add("@IdCategoriaPresupuestal", DbType.Int32).Value = GastoConcepto.IdCategoriaPresupuestal
            .Add("@IdCuenta", DbType.Int32).Value = GastoConcepto.IdCuenta
        End With
        Return MyBase.Update(GastoConcepto)
    End Function

    Public Overrides Function Create() As GastoConceptoInfo
        Return New GastoConceptoInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de GastosConceptos
''' </summary>
''' <remarks></remarks>
Public Class GastoConceptoFacade
    Inherits CatalogFacade(Of GastoConceptoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un GastoConceptoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal SessionID As Guid) As GastoConceptoInfo
        Dim GastoConceptoSvc As New GastoConceptoService(SessionID)
        Return GastoConceptoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de GastosConceptos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGastoConcepto">Identificador del GastoConcepto que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal SessionID As Guid, ByVal idGastoConcepto As Integer)
        Dim GastoConceptoSvc As New GastoConceptoService(sessionID)
        Delete(GastoConceptoSvc, idGastoConcepto)
    End Sub

    ''' <summary>
    ''' Verifica si existe un GastoConcepto con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGastoConcepto">ID de GastoConcepto que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal SessionID As Guid, ByVal idGastoConcepto As Integer) As Boolean
        Dim GastoConceptoSvc As New GastoConceptoService(sessionID)
        Return Exists(GastoConceptoSvc, idGastoConcepto)
    End Function

    ''' <summary>
    ''' Verifica si existe un GastoConcepto con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal SessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim GastoConceptoSvc As New GastoConceptoService(sessionID)
        Return Exists(GastoConceptoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un GastoConcepto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGastoConcepto">Identificador de GastoConcepto a consultar</param>
    ''' <returns>Paquete de información de tipo GastoConceptoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal SessionID As Guid, ByVal idGastoConcepto As Integer) As GastoConceptoInfo
        Return Me.GetDetail(SessionID, idGastoConcepto, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un GastoConcepto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGastoConcepto">Identificador de GastoConcepto</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del GastoConcepto.</param>
    ''' <returns>Paquete de información de tipo GastoConceptoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal SessionID As Guid, ByVal idGastoConcepto As Integer, checkStatus As Boolean) As GastoConceptoInfo
        Dim GastoConceptoSvc As New GastoConceptoService(sessionID)
        Dim GastoConceptoInf As New GastoConceptoInfo(sessionID)
        GetDetail(GastoConceptoSvc, GastoConceptoInf, idGastoConcepto, checkStatus)
        Return GastoConceptoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un GastoConcepto en base a su codigo de usuario
    ''' y verifica que el GastoConcepto esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información GastoConceptoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal SessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As GastoConceptoInfo
        Return Me.GetDetail(SessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un GastoConcepto en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del GastoConcepto</param>
    ''' <returns>Paquete de información GastoConceptoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal SessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As GastoConceptoInfo
        Dim GastoConceptoInf As New GastoConceptoInfo(sessionID)
        Dim GastoConceptoSvc As New GastoConceptoService(sessionID)
        GetDetail(GastoConceptoSvc, GastoConceptoInf, userCode, idSucursal, checkStatus)
        Return GastoConceptoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un GastoConcepto.
    ''' </summary>
    ''' <param name="GastoConcepto">Paquete de información del tipo GastoConceptoInfo con la información a actualizar</param>
    ''' <returns>Identificador de GastoConcepto, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal GastoConcepto As GastoConceptoInfo) As Integer
        Dim GastoConceptoSvc As New GastoConceptoService(GastoConcepto.SessionID)
        Return Update(GastoConceptoSvc, GastoConcepto)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal SessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim GastoConceptoSvc As New GastoConceptoService(sessionID)
        Return GetNumberOfPages(GastoConceptoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca GastosConceptos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal SessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(SessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca GastosConceptos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal SessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim GastoConceptoSvc As New GastoConceptoService(sessionID)
        Return GetSearchResult(GastoConceptoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de GastosConceptos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal SessionID As Guid) As System.Data.DataSet
        Dim GastoConceptoSvc As New GastoConceptoService(sessionID)
        Return GetSearchStructure(GastoConceptoSvc)
    End Function

#End Region

End Class
