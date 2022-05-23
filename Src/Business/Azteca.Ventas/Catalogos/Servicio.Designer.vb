Imports Azteca.Kernel

''' <summary>
''' Paquete de información que representa un Servicio
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ServicioInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Private _ZonasVenta As ZonasVentaDS.ZonasDataTable
#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdEstructuraComercial As Integer

    Public Property IdCategoriaFlujo As Integer

    Public Property ConceptoLibre As Boolean

    Public Property IdCuenta As Integer

    Public ReadOnly Property ZonasVenta As ZonasVentaDS.ZonasDataTable
        Get
            Return _ZonasVenta
        End Get
    End Property

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        _ZonasVenta = New ZonasVentaDS.ZonasDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Servicios
''' </summary>
''' <remarks></remarks>
Public Class ServicioService
    Inherits CatalogService(Of ServicioInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "Servicios", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idServicio As Integer, ByRef Servicio As ServicioInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idServicio, Servicio, checkStatus)
        With Servicio
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdEstructuraComercial = CInt(ItemInfo("IdEstCom"))
            .IdCategoriaFlujo = CInt(ItemInfo("IdCategoriaFlujo"))
            .ConceptoLibre = CBool(ItemInfo("ConceptoLibre"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
        End With
        CargarZonas(Servicio)
    End Sub

    Public Overrides Function Update(ByVal Servicio As ServicioInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Servicio.Nombre
            .Add("@IdEstCom", DbType.Int32).Value = Servicio.IdEstructuraComercial
            .Add("@IdCategoriaFlujo", DbType.Int32).Value = Servicio.IdCategoriaFlujo
            .Add("@ConceptoLibre", DbType.Boolean).Value = Servicio.ConceptoLibre
            .Add("@IdCuenta", DbType.Int32).Value = Servicio.IdCuenta
        End With
        Dim IdServicio As Integer = MyBase.Update(Servicio)
        GuardarZonas(IdServicio, Servicio)
        Dim CacheKey As String = "ServicioVenta" & IdServicio.ToString
        If Cache.Item(CacheKey) IsNot Nothing Then Cache.Remove(CacheKey)
        Return IdServicio
    End Function

    Public Overrides Function Create() As ServicioInfo
        Return New ServicioInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"

    Private Sub CargarZonas(ByVal servicio As ServicioInfo)
        Try
            Dim fxZonas As New FunctionSQL("Sales", "fxServicioZonasVentaSEL", Connection, Transaction)
            fxZonas.Parameters.Add("@IdServicio", DbType.Int32).Value = servicio.Identity
            fxZonas.FillDataTable(servicio.ZonasVenta)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las zonas de venta", ex)
        End Try
    End Sub

    Private Sub GuardarZonas(ByVal idServicio As Integer, ByVal servicio As ServicioInfo)
        Try
            Dim comUpdate As New DbCommand("Sales.ServicioZonaVentaUPD", Connection, Transaction)
            With comUpdate
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
                .Parameters.Add("@IdZonaVenta", DbType.Int32, "IdZonaVenta")
                .Parameters.Add("@IdDivisa", DbType.Int32, "IdDivisa")
                .Parameters.Add("@Precio", DbType.Decimal, "Precio")
                .Parameters.Add("@DiasEntrega", DbType.Int32, "DiasEntrega")
                .Parameters.Add("@IdImpuesto1", DbType.Int32, "IdImpuesto1")
                .Parameters.Add("@IdImpuesto2", DbType.Int32, "IdImpuesto2")
                .Parameters.Add("@IdImpuesto3", DbType.Int32, "IdImpuesto3")
                .Parameters.Add("@PorcRetencion1", DbType.Decimal, "PorcRetencion1")
                .Parameters.Add("@PorcRetencion2", DbType.Decimal, "PorcRetencion2")
                .Parameters.Add("@PorcRetencion3", DbType.Decimal, "PorcRetencion3")
            End With
            '
            Dim comDelete As New DbCommand("Sales.ServicioZonaVentaDEL", Connection, Transaction)
            With comDelete
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
                .Parameters.Add("@IdZonaVenta", DbType.Int32, "IdZonaVenta")
            End With
            '
            Dim daUpdate As New DataAdapter()
            daUpdate.InsertCommand = comUpdate
            daUpdate.UpdateCommand = comUpdate
            daUpdate.DeleteCommand = comDelete
            daUpdate.Update(servicio.ZonasVenta)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar las zonas de venta.", ex)
        End Try
    End Sub
#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Servicios
''' </summary>
''' <remarks></remarks>
Public Class ServicioFacade
    Inherits CatalogFacade(Of ServicioInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ServicioInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ServicioInfo
        Dim ServicioSvc As New ServicioService(sessionID)
        Return ServicioSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Servicios
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idServicio">Identificador del Servicio que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idServicio As Integer)
        Dim ServicioSvc As New ServicioService(sessionID)
        Delete(ServicioSvc, idServicio)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Servicio con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idServicio">ID de Servicio que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idServicio As Integer) As Boolean
        Dim ServicioSvc As New ServicioService(sessionID)
        Return Exists(ServicioSvc, idServicio)
    End Function

    ''' <summary>
    ''' Verifica si existe un Servicio con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ServicioSvc As New ServicioService(sessionID)
        Return Exists(ServicioSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Servicio.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idServicio">Identificador de Servicio a consultar</param>
    ''' <returns>Paquete de información de tipo ServicioInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idServicio As Integer) As ServicioInfo
        Return Me.GetDetail(sessionID, idServicio, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Servicio.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idServicio">Identificador de Servicio</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Servicio.</param>
    ''' <returns>Paquete de información de tipo ServicioInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idServicio As Integer, ByVal checkStatus As Boolean) As ServicioInfo
        Dim ServicioSvc As New ServicioService(sessionID)
        Dim ServicioInf As New ServicioInfo(sessionID)
        GetDetail(ServicioSvc, ServicioInf, idServicio, checkStatus)
        Return ServicioInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Servicio en base a su codigo de usuario
    ''' y verifica que el Servicio esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ServicioInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ServicioInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Servicio en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Servicio</param>
    ''' <returns>Paquete de información ServicioInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ServicioInfo
        Dim ServicioInf As New ServicioInfo(sessionID)
        Dim ServicioSvc As New ServicioService(sessionID)
        GetDetail(ServicioSvc, ServicioInf, userCode, idSucursal, checkStatus)
        Return ServicioInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Servicio.
    ''' </summary>
    ''' <param name="Servicio">Paquete de información del tipo ServicioInfo con la información a actualizar</param>
    ''' <returns>Identificador de Servicio, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Servicio As ServicioInfo) As Integer
        Dim ServicioSvc As New ServicioService(Servicio.SessionID)
        Return Update(ServicioSvc, Servicio)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ServicioSvc As New ServicioService(sessionID)
        Return GetNumberOfPages(ServicioSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Servicios que coincidan con las condiciones especificadas.
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
    ''' Busca Servicios que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ServicioSvc As New ServicioService(sessionID)
        Return GetSearchResult(ServicioSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Servicios.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ServicioSvc As New ServicioService(sessionID)
        Return GetSearchStructure(ServicioSvc)
    End Function

#End Region

End Class
