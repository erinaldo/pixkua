''' <summary>
''' Paquete de información que representa un CentroProduccion
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CentroProduccionInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdImpresora As Integer

    Public Property Imagen As Byte()

    Public Property IdLinea As Integer

    Public Property IdCuenta As Integer

    Public Property ArticulosTable As ArticulosConfigDS.CentroProduccionArticuloDataTable

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        ArticulosTable = New ArticulosConfigDS.CentroProduccionArticuloDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de CentrosProduccion
''' </summary>
''' <remarks></remarks>
Public Class CentroProduccionService
    Inherits CatalogService(Of CentroProduccionInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Restaurant", "CentrosProduccion", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCentroProduccion As Integer, ByRef CentroProduccion As CentroProduccionInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idCentroProduccion, CentroProduccion, checkStatus)
        With CentroProduccion
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdImpresora = CInt(ItemInfo("IdImpresora"))
            If Not IsDBNull(ItemInfo("Imagen")) Then
                .Imagen = CType(ItemInfo("Imagen"), Byte())
            End If
            .IdLinea = CInt(ItemInfo("IdLinea"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
        End With
        loadArticulos(CentroProduccion)
    End Sub

    Public Overrides Function Update(ByVal CentroProduccion As CentroProduccionInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = CentroProduccion.Nombre
            .Add("@IdImpresora", DbType.Int32).Value = CentroProduccion.IdImpresora
            If CentroProduccion.Imagen Is Nothing Then
                .Add("@Imagen", DbType.Binary).Value = DBNull.Value
            Else
                .Add("@Imagen", DbType.Binary).Value = CentroProduccion.Imagen
            End If
            .Add("@IdLinea", DbType.Int32).Value = CentroProduccion.IdLinea
            .Add("@IdCuenta", DbType.Int32).Value = CentroProduccion.IdCuenta
        End With
        Dim Id As Integer = MyBase.Update(CentroProduccion)
        saveArticulos(CentroProduccion)
        Return Id

    End Function

    Public Overrides Function Create() As CentroProduccionInfo
        Return New CentroProduccionInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"
    Private Sub loadArticulos(ByVal info As CentroProduccionInfo)
        Try
            info.ArticulosTable.Rows.Clear()
            Dim fx As New FunctionSQL("Restaurant", "fxCentrosProduccionArticulosSEL", Connection, Transaction)
            fx.Parameters.Add("@IdCentroProduccion", DbType.Int32).Value = info.Identity
            fx.FillDataTable(info.ArticulosTable)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de articulos.", ex)
        End Try

    End Sub

    Private Sub saveArticulos(ByVal info As CentroProduccionInfo)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Restaurant.CentrosProduccionArticulosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdCentroProduccionArticulo", DbType.Int32, "IdCentroProduccionArticulo")
            cmdInsert.Parameters.Add("@IdCentroProduccion", DbType.Int32).Value = info.Identity
            cmdInsert.Parameters.Add("@IdArticulo", DbType.Int32, "IdArticulo")
            cmdInsert.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Today
            cmdInsert.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmdInsert.Parameters.Add("@UserUpdate", DbType.String).Value = Session.User.Identity

            Dim cmdDelete As New Azteca.Data.DbCommand("Restaurant.CentrosProduccionArticulosDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdCentroProduccionArticulo", DbType.Int32, "IdCentroProduccionArticulo")
            cmdDelete.CommandType = CommandType.StoredProcedure

            'Actualizar Articulos
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.DeleteCommand = cmdDelete
            da.Update(info.ArticulosTable)
        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de articulos.", ex)
        End Try

    End Sub

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de CentrosProduccion
''' </summary>
''' <remarks></remarks>
Public Class CentroProduccionFacade
    Inherits CatalogFacade(Of CentroProduccionInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CentroProduccionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As CentroProduccionInfo
        Dim CentroProduccionSvc As New CentroProduccionService(sessionID)
        Return CentroProduccionSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de CentrosProduccion
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentroProduccion">Identificador del CentroProduccion que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idCentroProduccion As Integer)
        Dim CentroProduccionSvc As New CentroProduccionService(sessionID)
        Delete(CentroProduccionSvc, idCentroProduccion)
    End Sub

    ''' <summary>
    ''' Verifica si existe un CentroProduccion con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentroProduccion">ID de CentroProduccion que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idCentroProduccion As Integer) As Boolean
        Dim CentroProduccionSvc As New CentroProduccionService(sessionID)
        Return Exists(CentroProduccionSvc, idCentroProduccion)
    End Function

    ''' <summary>
    ''' Verifica si existe un CentroProduccion con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim CentroProduccionSvc As New CentroProduccionService(sessionID)
        Return Exists(CentroProduccionSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CentroProduccion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentroProduccion">Identificador de CentroProduccion a consultar</param>
    ''' <returns>Paquete de información de tipo CentroProduccionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCentroProduccion As Integer) As CentroProduccionInfo
        Return Me.GetDetail(sessionID, idCentroProduccion, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CentroProduccion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCentroProduccion">Identificador de CentroProduccion</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del CentroProduccion.</param>
    ''' <returns>Paquete de información de tipo CentroProduccionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCentroProduccion As Integer, ByVal checkStatus As Boolean) As CentroProduccionInfo
        Dim CentroProduccionSvc As New CentroProduccionService(sessionID)
        Dim CentroProduccionInf As New CentroProduccionInfo(sessionID)
        GetDetail(CentroProduccionSvc, CentroProduccionInf, idCentroProduccion, checkStatus)
        Return CentroProduccionInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un CentroProduccion en base a su codigo de usuario
    ''' y verifica que el CentroProduccion esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información CentroProduccionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As CentroProduccionInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un CentroProduccion en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del CentroProduccion</param>
    ''' <returns>Paquete de información CentroProduccionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CentroProduccionInfo
        Dim CentroProduccionInf As New CentroProduccionInfo(sessionID)
        Dim CentroProduccionSvc As New CentroProduccionService(sessionID)
        GetDetail(CentroProduccionSvc, CentroProduccionInf, userCode, idSucursal, checkStatus)
        Return CentroProduccionInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un CentroProduccion.
    ''' </summary>
    ''' <param name="CentroProduccion">Paquete de información del tipo CentroProduccionInfo con la información a actualizar</param>
    ''' <returns>Identificador de CentroProduccion, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal CentroProduccion As CentroProduccionInfo) As Integer
        Dim CentroProduccionSvc As New CentroProduccionService(CentroProduccion.SessionID)
        Return Update(CentroProduccionSvc, CentroProduccion)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim CentroProduccionSvc As New CentroProduccionService(sessionID)
        Return GetNumberOfPages(CentroProduccionSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca CentrosProduccion que coincidan con las condiciones especificadas.
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
    ''' Busca CentrosProduccion que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim CentroProduccionSvc As New CentroProduccionService(sessionID)
        Return GetSearchResult(CentroProduccionSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de CentrosProduccion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim CentroProduccionSvc As New CentroProduccionService(sessionID)
        Return GetSearchStructure(CentroProduccionSvc)
    End Function

#End Region

End Class
