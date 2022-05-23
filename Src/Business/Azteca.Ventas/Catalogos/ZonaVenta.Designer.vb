''' <summary>
''' Paquete de información que representa un ZonaVenta
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ZonaVentaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Private _Articulos As ZonasVentaDS.ArticulosDataTable
    Private _Servicios As ZonasVentaDS.ServiciosDataTable
#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public ReadOnly Property Articulos As ZonasVentaDS.ArticulosDataTable
        Get
            Return _Articulos
        End Get
    End Property

    Public ReadOnly Property Servicios As ZonasVentaDS.ServiciosDataTable
        Get
            Return _Servicios
        End Get
    End Property

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        _Articulos = New ZonasVentaDS.ArticulosDataTable
        _Servicios = New ZonasVentaDS.ServiciosDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de ZonasVenta
''' </summary>
''' <remarks></remarks>
Public Class ZonaVentaService
    Inherits CatalogService(Of ZonaVentaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "ZonasVenta", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idZonaVenta As Integer, ByRef ZonaVenta As ZonaVentaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idZonaVenta, ZonaVenta, checkStatus)
        With ZonaVenta
            .Nombre = CStr(Me.ItemInfo("Nombre"))
        End With
        CargarArticulos(ZonaVenta)
        CargarServicios(ZonaVenta)
    End Sub

    Public Overrides Function Update(ByVal ZonaVenta As ZonaVentaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = ZonaVenta.Nombre
        End With
        Dim IdZona As Integer = MyBase.Update(ZonaVenta)
        GuardarArticulos(IdZona, ZonaVenta)
        GuardarServicios(IdZona, ZonaVenta)
        Return IdZona
    End Function

    Public Overrides Function Create() As ZonaVentaInfo
        Return New ZonaVentaInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"

    Private Sub CargarArticulos(ByVal zona As ZonaVentaInfo)
        Try
            Dim fxZonas As New FunctionSQL("Sales", "fxZonasVentaArticuloSEL", Connection, Transaction)
            fxZonas.Parameters.Add("@IdZonaVenta", DbType.Int32).Value = zona.Identity
            fxZonas.FillDataTable(zona.Articulos)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los artículos de la zona de ventas.", ex)
        End Try
    End Sub

    Private Sub GuardarArticulos(ByVal idZonaVenta As Integer, ByVal zona As ZonaVentaInfo)
        Try
            Dim comUpdate As New DbCommand("Sales.ZonaVentaArticulosUPD", Connection, Transaction)
            With comUpdate
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdZonaVenta", DbType.Int32).Value = idZonaVenta
                .Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
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
            Dim comDelete As New DbCommand("Sales.ZonaVentaArticulosDEL", Connection, Transaction)
            With comDelete
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdZonaVenta", DbType.Int32).Value = idZonaVenta
                .Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticulostock")
            End With
            '
            Dim daUpdate As New DataAdapter()
            daUpdate.InsertCommand = comUpdate
            daUpdate.UpdateCommand = comUpdate
            daUpdate.DeleteCommand = comDelete
            daUpdate.Update(zona.Articulos)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar las zonas de venta.", ex)
        End Try
    End Sub

    Private Sub CargarServicios(ByVal zona As ZonaVentaInfo)
        Try
            Dim fxZonas As New FunctionSQL("Sales", "fxZonaVentaServiciosSEL", Connection, Transaction)
            fxZonas.Parameters.Add("@IdServicio", DbType.Int32).Value = zona.Identity
            fxZonas.FillDataTable(zona.Servicios)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los servicios de la zona de ventas.", ex)
        End Try
    End Sub

    Private Sub GuardarServicios(ByVal idZonaVenta As Integer, ByVal zona As ZonaVentaInfo)
        Try
            Dim comUpdate As New DbCommand("Sales.ZonaVentaServiciosUPD", Connection, Transaction)
            With comUpdate
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdZonaVenta", DbType.Int32).Value = idZonaVenta
                .Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
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
            Dim comDelete As New DbCommand("Sales.ZonaVentaServiciosDEL", Connection, Transaction)
            With comDelete
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@IdZonaVenta", DbType.Int32).Value = idZonaVenta
                .Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
            End With
            '
            Dim daUpdate As New DataAdapter()
            daUpdate.InsertCommand = comUpdate
            daUpdate.UpdateCommand = comUpdate
            daUpdate.DeleteCommand = comDelete
            daUpdate.Update(zona.Servicios)

        Catch ex As Exception
            Throw New BusinessException("Error al guardar los servicios de la zona de ventas.", ex)
        End Try
    End Sub

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de ZonasVenta
''' </summary>
''' <remarks></remarks>
Public Class ZonaVentaFacade
    Inherits CatalogFacade(Of ZonaVentaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ZonaVentaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ZonaVentaInfo
        Dim ZonaVentaSvc As New ZonaVentaService(sessionID)
        Return ZonaVentaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de ZonasVenta
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idZonaVenta">Identificador del ZonaVenta que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idZonaVenta As Integer)
        Dim ZonaVentaSvc As New ZonaVentaService(sessionID)
        Delete(ZonaVentaSvc, idZonaVenta)
    End Sub

    ''' <summary>
    ''' Verifica si existe un ZonaVenta con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idZonaVenta">ID de ZonaVenta que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idZonaVenta As Integer) As Boolean
        Dim ZonaVentaSvc As New ZonaVentaService(sessionID)
        Return Exists(ZonaVentaSvc, idZonaVenta)
    End Function

    ''' <summary>
    ''' Verifica si existe un ZonaVenta con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ZonaVentaSvc As New ZonaVentaService(sessionID)
        Return Exists(ZonaVentaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ZonaVenta.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idZonaVenta">Identificador de ZonaVenta a consultar</param>
    ''' <returns>Paquete de información de tipo ZonaVentaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idZonaVenta As Integer) As ZonaVentaInfo
        Return Me.GetDetail(sessionID, idZonaVenta, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ZonaVenta.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idZonaVenta">Identificador de ZonaVenta</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ZonaVenta.</param>
    ''' <returns>Paquete de información de tipo ZonaVentaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idZonaVenta As Integer, ByVal checkStatus As Boolean) As ZonaVentaInfo
        Dim ZonaVentaSvc As New ZonaVentaService(sessionID)
        Dim ZonaVentaInf As New ZonaVentaInfo(sessionID)
        GetDetail(ZonaVentaSvc, ZonaVentaInf, idZonaVenta, checkStatus)
        Return ZonaVentaInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un ZonaVenta en base a su codigo de usuario
    ''' y verifica que el ZonaVenta esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ZonaVentaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ZonaVentaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ZonaVenta en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ZonaVenta</param>
    ''' <returns>Paquete de información ZonaVentaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ZonaVentaInfo
        Dim ZonaVentaInf As New ZonaVentaInfo(sessionID)
        Dim ZonaVentaSvc As New ZonaVentaService(sessionID)
        GetDetail(ZonaVentaSvc, ZonaVentaInf, userCode, idSucursal, checkStatus)
        Return ZonaVentaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un ZonaVenta.
    ''' </summary>
    ''' <param name="ZonaVenta">Paquete de información del tipo ZonaVentaInfo con la información a actualizar</param>
    ''' <returns>Identificador de ZonaVenta, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal ZonaVenta As ZonaVentaInfo) As Integer
        Dim ZonaVentaSvc As New ZonaVentaService(ZonaVenta.SessionID)
        Return Update(ZonaVentaSvc, ZonaVenta)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ZonaVentaSvc As New ZonaVentaService(sessionID)
        Return GetNumberOfPages(ZonaVentaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca ZonasVenta que coincidan con las condiciones especificadas.
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
    ''' Busca ZonasVenta que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ZonaVentaSvc As New ZonaVentaService(sessionID)
        Return GetSearchResult(ZonaVentaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de ZonasVenta.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ZonaVentaSvc As New ZonaVentaService(sessionID)
        Return GetSearchStructure(ZonaVentaSvc)
    End Function

#End Region

End Class
