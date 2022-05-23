''' <summary>
''' Paquete de información que representa un Periodo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class PeriodoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdEjercicioFiscalTit As String

    Public Property Mes As Integer

    Public Property FechaApertura As Date

    Public Property FechaCierre As Date

    Public Property Estatus As String = "A"


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Periodos
''' </summary>
''' <remarks></remarks>
Public Class PeriodoService
    Inherits CatalogService(Of PeriodoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As guid)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "Periodos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idPeriodo As Integer, ByRef Periodo As PeriodoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idPeriodo, Periodo, checkStatus)
        With Periodo
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdEjercicioFiscalTit = CStr(ItemInfo("IdEjercicioFiscalTit"))
            .Mes = CInt(ItemInfo("Mes"))
            If Not IsDBNull(ItemInfo("FechaApertura")) Then .FechaApertura = CDate(ItemInfo("FechaApertura"))
            If Not IsDBNull(ItemInfo("FechaCierre")) Then .FechaCierre = CDate(ItemInfo("FechaCierre"))
            .Estatus = CStr(ItemInfo("Estatus"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Periodo As PeriodoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Periodo.Nombre
            .Add("@IdEjercicioFiscalTit", DbType.String).Value = Periodo.IdEjercicioFiscalTit
            .Add("@Mes", DbType.Int32).Value = Periodo.Mes
            '.Add("@FechaApertura", DbType.DateTime).Value = Periodo.FechaApertura
            '.Add("@FechaCierre", DbType.DateTime).Value = Periodo.FechaCierre
            .Add("@Estatus", DbType.String).Value = Periodo.Estatus
        End With
        Return MyBase.Update(Periodo)
    End Function

    Public Overrides Function Create() As PeriodoInfo
        Return New PeriodoInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Periodos
''' </summary>
''' <remarks></remarks>
Public Class PeriodoFacade
    Inherits CatalogFacade(Of PeriodoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un PeriodoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As PeriodoInfo
        Dim PeriodoSvc As New PeriodoService(sessionID)
        Return PeriodoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Periodos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPeriodo">Identificador del Periodo que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idPeriodo As Integer)
        Dim PeriodoSvc As New PeriodoService(sessionID)
        Delete(PeriodoSvc, idPeriodo)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Periodo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPeriodo">ID de Periodo que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idPeriodo As Integer) As Boolean
        Dim PeriodoSvc As New PeriodoService(sessionid)
        Return Exists(PeriodoSvc, idPeriodo)
    End Function

    ''' <summary>
    ''' Verifica si existe un Periodo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim PeriodoSvc As New PeriodoService(sessionID)
        Return Exists(PeriodoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Periodo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPeriodo">Identificador de Periodo a consultar</param>
    ''' <returns>Paquete de información de tipo PeriodoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idPeriodo As Integer) As PeriodoInfo
        Return Me.GetDetail(sessionID, idPeriodo, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Periodo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPeriodo">Identificador de Periodo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Periodo.</param>
    ''' <returns>Paquete de información de tipo PeriodoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As guid, ByVal idPeriodo As Integer, ByVal checkStatus As Boolean) As PeriodoInfo
        Dim PeriodoSvc As New PeriodoService(sessionID)
        Dim PeriodoInf As New PeriodoInfo(sessionID)
        GetDetail(PeriodoSvc, PeriodoInf, idPeriodo, checkStatus)
        Return PeriodoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Periodo en base a su codigo de usuario
    ''' y verifica que el Periodo esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información PeriodoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer) As PeriodoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Periodo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Periodo</param>
    ''' <returns>Paquete de información PeriodoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As PeriodoInfo
        Dim PeriodoInf As New PeriodoInfo(sessionID)
        Dim PeriodoSvc As New PeriodoService(sessionID)
        GetDetail(PeriodoSvc, PeriodoInf, userCode, idSucursal, checkStatus)
        Return PeriodoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Periodo.
    ''' </summary>
    ''' <param name="Periodo">Paquete de información del tipo PeriodoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Periodo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Periodo As PeriodoInfo) As Integer
        Dim PeriodoSvc As New PeriodoService(Periodo.SessionID)
        Return Update(PeriodoSvc, Periodo)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim PeriodoSvc As New PeriodoService(sessionID)
        Return GetNumberOfPages(PeriodoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Periodos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Periodos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim PeriodoSvc As New PeriodoService(sessionID)
        Return GetSearchResult(PeriodoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Periodos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As guid) As System.Data.DataSet
        Dim PeriodoSvc As New PeriodoService(sessionID)
        Return GetSearchStructure(PeriodoSvc)
    End Function

#End Region

End Class
