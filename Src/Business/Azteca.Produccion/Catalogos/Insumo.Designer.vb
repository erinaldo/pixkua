''' <summary>
''' Paquete de información que representa un Insumo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class InsumoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdCuenta As Integer

    Public Property IdUnidadMedida As Integer

    Public Property ArticulosTable As InsumosArticulosDS.InsumosArticulosDataTable

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        ArticulosTable = New InsumosArticulosDS.InsumosArticulosDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Insumos
''' </summary>
''' <remarks></remarks>
Public Class InsumoService
    Inherits CatalogService(Of InsumoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Production", "Insumos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idInsumo As Integer, ByRef Insumo As InsumoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idInsumo, Insumo, checkStatus)
        With Insumo
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .IdUnidadMedida = CInt(ItemInfo("IdUnidadMedida"))
            loadArticulos(Insumo)
        End With
    End Sub

    Public Overrides Function Update(ByVal Insumo As InsumoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Insumo.Nombre
            .Add("@IdCuenta", DbType.Int32).Value = Insumo.IdCuenta
            .Add("@IdUnidadMedida", DbType.Int32).Value = Insumo.IdUnidadMedida
        End With
        Dim Id As Integer = MyBase.Update(Insumo)
        saveArticulos(Insumo)
        Return Id

    End Function

    Public Overrides Function Create() As InsumoInfo
        Return New InsumoInfo(sessionID)
    End Function

#End Region


#Region "Metodos Privados"
    Private Sub loadArticulos(ByVal info As InsumoInfo)
        Try
            info.ArticulosTable.Rows.Clear()
            Dim fx As New FunctionSQL("Production", "fxInsumosArticulosSEL", Connection, Transaction)
            fx.Parameters.Add("@IdInsumo", DbType.Int32).Value = info.Identity
            fx.FillDataTable(info.ArticulosTable)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de articulos.", ex)
        End Try

    End Sub

    Private Sub saveArticulos(ByVal info As InsumoInfo)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Production.InsumosArticulosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdInsumo", DbType.Int32).Value = info.Identity
            cmdInsert.Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
            cmdInsert.Parameters.Add("@Predeterminado", DbType.Int32, "Predeterminado")
            cmdInsert.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Today
            cmdInsert.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmdInsert.Parameters.Add("@UserUpdate", DbType.String).Value = Session.User.Identity

            Dim cmdDelete As New Azteca.Data.DbCommand("Production.InsumosArticulosDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdInsumo", DbType.Int32).Value = info.Identity
            cmdDelete.Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
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
''' Business Facade con servicios para el manejo del catálogo de Insumos
''' </summary>
''' <remarks></remarks>
Public Class InsumoFacade
    Inherits CatalogFacade(Of InsumoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un InsumoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As InsumoInfo
        Dim InsumoSvc As New InsumoService(sessionID)
        Return InsumoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Insumos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idInsumo">Identificador del Insumo que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idInsumo As Integer)
        Dim InsumoSvc As New InsumoService(sessionID)
        Delete(InsumoSvc, idInsumo)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Insumo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idInsumo">ID de Insumo que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idInsumo As Integer) As Boolean
        Dim InsumoSvc As New InsumoService(sessionID)
        Return Exists(InsumoSvc, idInsumo)
    End Function

    ''' <summary>
    ''' Verifica si existe un Insumo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim InsumoSvc As New InsumoService(sessionID)
        Return Exists(InsumoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Insumo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idInsumo">Identificador de Insumo a consultar</param>
    ''' <returns>Paquete de información de tipo InsumoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idInsumo As Integer) As InsumoInfo
        Return Me.GetDetail(sessionID, idInsumo, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Insumo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idInsumo">Identificador de Insumo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Insumo.</param>
    ''' <returns>Paquete de información de tipo InsumoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idInsumo As Integer, ByVal checkStatus As Boolean) As InsumoInfo
        Dim InsumoSvc As New InsumoService(sessionID)
        Dim InsumoInf As New InsumoInfo(sessionID)
        GetDetail(InsumoSvc, InsumoInf, idInsumo, checkStatus)
        Return InsumoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Insumo en base a su codigo de usuario
    ''' y verifica que el Insumo esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información InsumoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As InsumoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Insumo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Insumo</param>
    ''' <returns>Paquete de información InsumoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As InsumoInfo
        Dim InsumoInf As New InsumoInfo(sessionID)
        Dim InsumoSvc As New InsumoService(sessionID)
        GetDetail(InsumoSvc, InsumoInf, userCode, idSucursal, checkStatus)
        Return InsumoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Insumo.
    ''' </summary>
    ''' <param name="Insumo">Paquete de información del tipo InsumoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Insumo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Insumo As InsumoInfo) As Integer
        Dim InsumoSvc As New InsumoService(Insumo.SessionID)
        Return Update(InsumoSvc, Insumo)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim InsumoSvc As New InsumoService(sessionID)
        Return GetNumberOfPages(InsumoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Insumos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Insumos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim InsumoSvc As New InsumoService(sessionID)
        Return GetSearchResult(InsumoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Insumos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim InsumoSvc As New InsumoService(sessionID)
        Return GetSearchStructure(InsumoSvc)
    End Function

#End Region

End Class
