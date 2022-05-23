''' <summary>
''' Paquete de información que representa un ListaPrecios
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ListaPreciosInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property ArticulosTable As ListaPreciosDS.ArticulosDataTable
    Public Property ServiciosTable As ListaPreciosDS.ServiciosDataTable
    Public Property ClientesTable As New ListaPreciosDS.ClientesDataTable
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        ArticulosTable = New ListaPreciosDS.ArticulosDataTable
        ServiciosTable = New ListaPreciosDS.ServiciosDataTable
        ClientesTable = New ListaPreciosDS.ClientesDataTable
    End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de ListasPrecios
''' </summary>
''' <remarks></remarks>
Public Class ListaPreciosService
	Inherits CatalogService(Of ListaPreciosInfo)
	
#Region "Constructores"
    Public Sub New(ByVal sessionID As Guid)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "ListasPrecios", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idListaPrecios As Integer, ByRef ListaPrecios As ListaPreciosInfo, checkStatus As Boolean)
		MyBase.GetDetail(idListaPrecios, ListaPrecios, checkStatus)
        With ListaPrecios
            .Nombre = CStr(ItemInfo("Nombre"))
            .ArticulosTable = ArticulosLoad(.Identity)
            .ServiciosTable = ServiciosLoad(.Identity)
        End With
	End Sub
	
    Public Overrides Function Update(ByVal ListaPrecios As ListaPreciosInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = ListaPrecios.Nombre
        End With
        Dim id As Integer = MyBase.Update(ListaPrecios)
        saveArticulos(id, ListaPrecios.ArticulosTable)
        saveServicios(id, ListaPrecios.ServiciosTable)
        Return id
    End Function

	Public Overrides Function Create() As ListaPreciosInfo
        Return New ListaPreciosInfo(SessionID)
	End Function

    Public Function ArticulosLoad(ByVal idListaPrecios As Integer) As ListaPreciosDS.ArticulosDataTable
        Dim dtList As New ListaPreciosDS.ArticulosDataTable()
        Try
            Dim fxList As New FunctionSQL("Sales", "fxListasPreciosArticulosSEL", Connection, Transaction)
            fxList.Parameters.Add("@IdListaPrecio", DbType.Int32).Value = idListaPrecios
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Articulos.", ex)
        End Try
    End Function


    Public Function ArticuloPreciosList(ByVal idArticuloStock As Integer, IdSucursal As Integer) As DataTable
        Dim dtList As New DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxArticulosPreciosList", Connection, Transaction)
            fxList.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Precios.", ex)
        End Try
    End Function

    Public Function ServicioPreciosList(ByVal idServicio As Integer, IdSucursal As Integer) As DataTable
        Dim dtList As New DataTable
        Try
            Dim fxList As New FunctionSQL("Sales", "fxServiciosPreciosList", Connection, Transaction)
            fxList.Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = IdSucursal
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Precios.", ex)
        End Try
    End Function

    Public Sub ArticulosPreciosSave(ByVal idArticuloStock As Integer, PreciosTable As DataTable)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Sales.ListasPreciosArticulosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdListaPrecios", DbType.Int32, "IdListaPrecio")
            cmdInsert.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = idArticuloStock
            cmdInsert.Parameters.Add("@Precio", DbType.Decimal, "Precio")
            cmdInsert.Parameters.Add("@IdDivisa", DbType.Int32, "IdDivisa")
            cmdInsert.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Today
            cmdInsert.Parameters.Add("@PCUpdate", DbType.String).Value = Me.Session.WorkStation
            cmdInsert.Parameters.Add("@UserUpdate", DbType.Int32).Value = Me.Session.User.Identity

            'Actualizar Articulos
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            Dim actualizados As Integer = da.Update(PreciosTable)
            actualizados = actualizados

        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de precios de los articulos.", ex)
        End Try
    End Sub

    Public Sub ServiciosPreciosSave(ByVal idServicio As Integer, PreciosTable As DataTable)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Sales.ListasPreciosServiciosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdListaPrecios", DbType.Int32, "IdListaPrecio")
            cmdInsert.Parameters.Add("@IdServicio", DbType.Int32).Value = idServicio
            cmdInsert.Parameters.Add("@Precio", DbType.Decimal, "Precio")
            cmdInsert.Parameters.Add("@IdDivisa", DbType.Int32, "IdDivisa")
            cmdInsert.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Today
            cmdInsert.Parameters.Add("@PCUpdate", DbType.String).Value = Me.Session.WorkStation
            cmdInsert.Parameters.Add("@UserUpdate", DbType.Int32).Value = Me.Session.User.Identity

            'Actualizar Articulos
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            Dim actualizados As Integer = da.Update(PreciosTable)
            actualizados = actualizados

        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de precios de los articulos.", ex)
        End Try
    End Sub

    Public Function ServiciosLoad(ByVal idListaPrecios As Integer) As ListaPreciosDS.ServiciosDataTable
        Dim dtList As New ListaPreciosDS.ServiciosDataTable()
        Try
            Dim fxList As New FunctionSQL("Sales", "fxListasPreciosServiciosSEL", Connection, Transaction)
            fxList.Parameters.Add("@IdListaPrecio", DbType.Int32).Value = idListaPrecios
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Servicios.", ex)
        End Try
    End Function

    Public Function ClientesLoad(ByVal IdEmpresa As Integer, ByVal idListaPrecios As Integer) As ListaPreciosDS.ClientesDataTable
        Dim dtList As New ListaPreciosDS.ClientesDataTable()
        Try
            Dim fxList As New FunctionSQL("Sales", "fxListasPreciosClientesSEL", Connection, Transaction)
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = IdEmpresa
            fxList.Parameters.Add("@IdListaPrecio", DbType.Int32).Value = idListaPrecios
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Clientes.", ex)
        End Try
    End Function

#End Region

    Protected Overridable Sub SaveArticulos(ByVal id As Integer, ByVal articulos As ListaPreciosDS.ArticulosDataTable)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Sales.ListasPreciosArticulosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdListaPrecios", DbType.Int32).Value = id
            cmdInsert.Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
            cmdInsert.Parameters.Add("@Precio", DbType.Decimal, "Precio")
            cmdInsert.Parameters.Add("@IdDivisa", DbType.Int32, "IdDivisa")
            cmdInsert.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Today
            cmdInsert.Parameters.Add("@PCUpdate", DbType.String).Value = Me.Session.WorkStation
            cmdInsert.Parameters.Add("@UserUpdate", DbType.Int32).Value = Me.Session.User.Identity

            'Actualizar Articulos
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.Update(articulos)

        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de articulos.", ex)
        End Try
    End Sub

    Protected Overridable Sub SaveServicios(ByVal id As Integer, ByVal servicios As ListaPreciosDS.ServiciosDataTable)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Sales.ListasPreciosServiciosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdListaPrecios", DbType.Int32).Value = id
            cmdInsert.Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
            cmdInsert.Parameters.Add("@Precio", DbType.Decimal, "Precio")
            cmdInsert.Parameters.Add("@IdDivisa", DbType.Int32, "IdDivisa")
            cmdInsert.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Today
            cmdInsert.Parameters.Add("@PCUpdate", DbType.String).Value = Me.Session.WorkStation
            cmdInsert.Parameters.Add("@UserUpdate", DbType.Int32).Value = Me.Session.User.Identity

            'Actualizar servicios
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.Update(servicios)

        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de servicios.", ex)
        End Try
    End Sub

    Public Overridable Sub SaveClientes(ByVal id As Integer, ByVal clientes As ListaPreciosDS.ClientesDataTable)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Sales.ListasPreciosClientesUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdListaPrecios", DbType.Int32).Value = id
            cmdInsert.Parameters.Add("@IdCliente", DbType.Int32, "IdCliente")

            'Actualizar Clientes
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.Update(clientes)

        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de clientes.", ex)
        End Try
    End Sub

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de ListasPrecios
''' </summary>
''' <remarks></remarks>
Public Class ListaPreciosFacade
	Inherits CatalogFacade(Of ListaPreciosInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ListaPreciosInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As ListaPreciosInfo
        Dim ListaPreciosSvc As New ListaPreciosService(sessionID)
        Return ListaPreciosSvc.Create()
    End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de ListasPrecios
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idListaPrecios">Identificador del ListaPrecios que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idListaPrecios As Integer)
        Dim ListaPreciosSvc As New ListaPreciosService(sessionID)
        Delete(ListaPreciosSvc, idListaPrecios)
    End Sub
	
    ''' <summary>
    ''' Verifica si existe un ListaPrecios con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idListaPrecios">ID de ListaPrecios que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idListaPrecios As Integer) As Boolean
        Dim ListaPreciosSvc As New ListaPreciosService(sessionID)
        Return Exists(ListaPreciosSvc, idListaPrecios)
    End Function

    ''' <summary>
    ''' Verifica si existe un ListaPrecios con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ListaPreciosSvc As New ListaPreciosService(sessionID)
        Return Exists(ListaPreciosSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ListaPrecios.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idListaPrecios">Identificador de ListaPrecios a consultar</param>
    ''' <returns>Paquete de información de tipo ListaPreciosInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idListaPrecios As Integer) As ListaPreciosInfo
        Return Me.GetDetail(sessionID, idListaPrecios, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ListaPrecios.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idListaPrecios">Identificador de ListaPrecios</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ListaPrecios.</param>
    ''' <returns>Paquete de información de tipo ListaPreciosInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idListaPrecios As Integer, ByVal checkStatus As Boolean) As ListaPreciosInfo
        Dim ListaPreciosSvc As New ListaPreciosService(sessionID)
        Dim ListaPreciosInf As New ListaPreciosInfo(sessionID)
        GetDetail(ListaPreciosSvc, ListaPreciosInf, idListaPrecios, checkStatus)
        Return ListaPreciosInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un ListaPrecios en base a su codigo de usuario
    ''' y verifica que el ListaPrecios esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ListaPreciosInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As ListaPreciosInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ListaPrecios en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ListaPrecios</param>
    ''' <returns>Paquete de información ListaPreciosInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ListaPreciosInfo
        Dim ListaPreciosInf As New ListaPreciosInfo(sessionID)
        Dim ListaPreciosSvc As New ListaPreciosService(sessionID)
        GetDetail(ListaPreciosSvc, ListaPreciosInf, userCode, idSucursal, checkStatus)
        Return ListaPreciosInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un ListaPrecios.
    ''' </summary>
    ''' <param name="ListaPrecios">Paquete de información del tipo ListaPreciosInfo con la información a actualizar</param>
    ''' <returns>Identificador de ListaPrecios, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal ListaPrecios As ListaPreciosInfo) As Integer
        Dim ListaPreciosSvc As New ListaPreciosService(ListaPrecios.SessionID)
		Return Update(ListaPreciosSvc, ListaPrecios)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ListaPreciosSvc As New ListaPreciosService(sessionID)
        Return GetNumberOfPages(ListaPreciosSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca ListasPrecios que coincidan con las condiciones especificadas.
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
    ''' Busca ListasPrecios que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ListaPreciosSvc As New ListaPreciosService(sessionID)
        Return GetSearchResult(ListaPreciosSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de ListasPrecios.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As Guid) As System.Data.DataSet
        Dim ListaPreciosSvc As New ListaPreciosService(sessionID)
        Return GetSearchStructure(ListaPreciosSvc)
    End Function

#End Region

End Class
