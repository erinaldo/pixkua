''' <summary>
''' Paquete de información que representa un CentroConsumo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CentroConsumoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdCuenta As Integer

    Public Property IdCaja As Integer

    Public Property Mesas As CentrosConsumoDS.MesasDataTable

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        Mesas = New CentrosConsumoDS.MesasDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de CentrosConsumo
''' </summary>
''' <remarks></remarks>
Public Class CentroConsumoService
    Inherits CatalogService(Of CentroConsumoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Restaurant", "CentrosConsumo", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCentroConsumo As Integer, ByRef CentroConsumo As CentroConsumoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idCentroConsumo, CentroConsumo, checkStatus)
        With CentroConsumo
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdCaja = CInt(ItemInfo("IdCaja"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            LoadMesas(CentroConsumo)
        End With
    End Sub

    Public Overrides Function Update(ByVal CentroConsumo As CentroConsumoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = CentroConsumo.Nombre
            .Add("@IdCaja", DbType.Int32).Value = CentroConsumo.IdCaja
            .Add("@IdCuenta", DbType.Int32).Value = CentroConsumo.IdCuenta
        End With
        Dim id As Integer = MyBase.Update(CentroConsumo)
        saveMesas(CentroConsumo)
        Return Id
    End Function

    Public Overrides Function Create() As CentroConsumoInfo
        Return New CentroConsumoInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"
    Private Sub loadMesas(ByVal info As CentroConsumoInfo)
        Try
            info.Mesas.Rows.Clear()
            Dim fx As New FunctionSQL("Restaurant", "fxCentroConsumoMesasSEL", Connection, Transaction)
            fx.Parameters.Add("@IdCentroConsumo", DbType.Int32).Value = info.Identity
            fx.FillDataTable(info.Mesas)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de mesas.", ex)
        End Try
    End Sub

    Private Sub saveMesas(ByVal info As CentroConsumoInfo)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Restaurant.CentroConsumoMesasUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdCentroConsumo", DbType.Int32).Value = info.Identity
            cmdInsert.Parameters.Add("@IdMesa", DbType.Int32, "IdMesa")

            'Dim cmdDelete As New Azteca.Data.DbCommand("Restaurant.CategoriasArticulosDEL", Connection, Transaction)
            'cmdDelete.Parameters.Add("@IdCategoria", DbType.Int32).Value = info.Identity
            'cmdDelete.Parameters.Add("@IdArticulo", DbType.Int32, "IdArticulo")
            'cmdDelete.CommandType = CommandType.StoredProcedure

            'Actualizar Articulos
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            '            da.DeleteCommand = cmdDelete
            da.Update(info.Mesas)
        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de mesas.", ex)
        End Try
    End Sub


#End Region
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de CentrosConsumo
''' </summary>
''' <remarks></remarks>
Public Class CentroConsumoFacade
    Inherits CatalogFacade(Of CentroConsumoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CentroConsumoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As CentroConsumoInfo
        Dim CentroConsumoSvc As New CentroConsumoService(sessionID)
        Return CentroConsumoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de CentrosConsumo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentroConsumo">Identificador del CentroConsumo que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idCentroConsumo As Integer)
        Dim CentroConsumoSvc As New CentroConsumoService(sessionID)
        Delete(CentroConsumoSvc, idCentroConsumo)
    End Sub

    ''' <summary>
    ''' Verifica si existe un CentroConsumo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentroConsumo">ID de CentroConsumo que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idCentroConsumo As Integer) As Boolean
        Dim CentroConsumoSvc As New CentroConsumoService(sessionID)
        Return Exists(CentroConsumoSvc, idCentroConsumo)
    End Function

    ''' <summary>
    ''' Verifica si existe un CentroConsumo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim CentroConsumoSvc As New CentroConsumoService(sessionID)
        Return Exists(CentroConsumoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CentroConsumo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentroConsumo">Identificador de CentroConsumo a consultar</param>
    ''' <returns>Paquete de información de tipo CentroConsumoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCentroConsumo As Integer) As CentroConsumoInfo
        Return Me.GetDetail(sessionID, idCentroConsumo, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CentroConsumo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentroConsumo">Identificador de CentroConsumo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del CentroConsumo.</param>
    ''' <returns>Paquete de información de tipo CentroConsumoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCentroConsumo As Integer, ByVal checkStatus As Boolean) As CentroConsumoInfo
        Dim CentroConsumoSvc As New CentroConsumoService(sessionID)
        Dim CentroConsumoInf As New CentroConsumoInfo(sessionID)
        GetDetail(CentroConsumoSvc, CentroConsumoInf, idCentroConsumo, checkStatus)
        Return CentroConsumoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un CentroConsumo en base a su codigo de usuario
    ''' y verifica que el CentroConsumo esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información CentroConsumoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As CentroConsumoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CentroConsumo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del CentroConsumo</param>
    ''' <returns>Paquete de información CentroConsumoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CentroConsumoInfo
        Dim CentroConsumoInf As New CentroConsumoInfo(sessionID)
        Dim CentroConsumoSvc As New CentroConsumoService(sessionID)
        GetDetail(CentroConsumoSvc, CentroConsumoInf, userCode, idSucursal, checkStatus)
        Return CentroConsumoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un CentroConsumo.
    ''' </summary>
    ''' <param name="CentroConsumo">Paquete de información del tipo CentroConsumoInfo con la información a actualizar</param>
    ''' <returns>Identificador de CentroConsumo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal CentroConsumo As CentroConsumoInfo) As Integer
        Dim CentroConsumoSvc As New CentroConsumoService(CentroConsumo.SessionID)
        Return Update(CentroConsumoSvc, CentroConsumo)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim CentroConsumoSvc As New CentroConsumoService(sessionID)
        Return GetNumberOfPages(CentroConsumoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca CentrosConsumo que coincidan con las condiciones especificadas.
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
    ''' Busca CentrosConsumo que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim CentroConsumoSvc As New CentroConsumoService(sessionID)
        Return GetSearchResult(CentroConsumoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de CentrosConsumo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim CentroConsumoSvc As New CentroConsumoService(sessionID)
        Return GetSearchStructure(CentroConsumoSvc)
    End Function

#End Region

End Class
