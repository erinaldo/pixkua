''' <summary>
''' Paquete de información que representa un GrupoDescuentos
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class GrupoDescuentosInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property ArticulosTable As GrupoDescuentosDS.ArticulosDataTable
    Public Property ServiciosTable As GrupoDescuentosDS.ServiciosDataTable
    Public Property ClientesTable As New GrupoDescuentosDS.ClientesDataTable

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal SessionID As Guid)
        MyBase.New(SessionID)
        ArticulosTable = New GrupoDescuentosDS.ArticulosDataTable
        ServiciosTable = New GrupoDescuentosDS.ServiciosDataTable
        ClientesTable = New GrupoDescuentosDS.ClientesDataTable
    End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de GruposDescuento
''' </summary>
''' <remarks></remarks>
Public Class GrupoDescuentosService
	Inherits CatalogService(Of GrupoDescuentosInfo)
	
#Region "Constructores"
    Public Sub New(ByVal SessionID As Guid)
        Me.New(SessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal SessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(SessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal SessionID As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "GruposDescuento", SessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idGrupoDescuentos As Integer, ByRef GrupoDescuentos As GrupoDescuentosInfo, checkStatus As Boolean)
		MyBase.GetDetail(idGrupoDescuentos, GrupoDescuentos, checkStatus)
        With GrupoDescuentos
			.Nombre = CStr(ItemInfo("Nombre"))
            .ArticulosTable = ArticulosLoad(.Identity)
            .ServiciosTable = ServiciosLoad(.Identity)
		End With
	End Sub
	
	Public Overrides Function Update(ByVal GrupoDescuentos As GrupoDescuentosInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = GrupoDescuentos.Nombre

		End With
        Dim id As Integer = MyBase.Update(GrupoDescuentos)
        saveArticulos(id, GrupoDescuentos.ArticulosTable)
        saveServicios(id, GrupoDescuentos.ServiciosTable)
        Return id
	End Function

    Public Function ArticulosLoad(ByVal idGrupoDescuentos As Integer) As GrupoDescuentosDS.ArticulosDataTable
        Dim dtList As New GrupoDescuentosDS.ArticulosDataTable()
        Try
            Dim fxList As New FunctionSQL("Sales", "fxGrupoDescuentosArticulosSEL", Connection, Transaction)
            fxList.Parameters.Add("@idGrupoDescuentos", DbType.Int32).Value = idGrupoDescuentos
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Articulos.", ex)
        End Try
    End Function

    Public Function ServiciosLoad(ByVal idGrupoDescuentos As Integer) As GrupoDescuentosDS.ServiciosDataTable
        Dim dtList As New GrupoDescuentosDS.ServiciosDataTable()
        Try
            Dim fxList As New FunctionSQL("Sales", "fxGrupoDescuentosServiciosSEL", Connection, Transaction)
            fxList.Parameters.Add("@idGrupoDescuentos", DbType.Int32).Value = idGrupoDescuentos
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Servicios.", ex)
        End Try
    End Function

    Public Function ClientesLoad(ByVal IdEmpresa As Integer, ByVal idGrupoDescuentos As Integer) As GrupoDescuentosDS.ClientesDataTable
        Dim dtList As New GrupoDescuentosDS.ClientesDataTable()
        Try
            Dim fxList As New FunctionSQL("Sales", "fxGrupoDescuentosClientesSEL", Connection, Transaction)
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = IdEmpresa
            fxList.Parameters.Add("@idGrupoDescuentos", DbType.Int32).Value = idGrupoDescuentos
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Clientes.", ex)
        End Try
    End Function

    Private Sub saveArticulos(ByVal id As Integer, ByVal ArticulosTB As GrupoDescuentosDS.ArticulosDataTable)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Sales.GrupoDescuentosArticulosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdGrupoDescuento", DbType.Int32).Value = id
            cmdInsert.Parameters.Add("@IdArticuloStock", DbType.Int32, "IdArticuloStock")
            cmdInsert.Parameters.Add("@PorcDescuento1", DbType.Decimal, "PorcDescuento1")
            cmdInsert.Parameters.Add("@PorcDescuento2", DbType.Decimal, "PorcDescuento2")
            cmdInsert.Parameters.Add("@PorcDescuento3", DbType.Decimal, "PorcDescuento3")
            cmdInsert.Parameters.Add("@PorcDescuento4", DbType.Decimal, "PorcDescuento4")
            cmdInsert.Parameters.Add("@PorcDescuento5", DbType.Decimal, "PorcDescuento5")
            cmdInsert.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Today
            cmdInsert.Parameters.Add("@PCUpdate", DbType.String).Value = Me.Session.WorkStation
            cmdInsert.Parameters.Add("@UserUpdate", DbType.Int32).Value = Me.Session.User.Identity

            'Actualizar Articulos
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.Update(ArticulosTB)

        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de articulos.", ex)
        End Try
    End Sub

    Private Sub saveServicios(ByVal id As Integer, ByVal ServiciosTB As GrupoDescuentosDS.ServiciosDataTable)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Sales.GrupoDescuentosServiciosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdGrupoDescuento", DbType.Int32).Value = id
            cmdInsert.Parameters.Add("@IdServicio", DbType.Int32, "IdServicio")
            cmdInsert.Parameters.Add("@PorcDescuento1", DbType.Decimal, "PorcDescuento1")
            cmdInsert.Parameters.Add("@PorcDescuento2", DbType.Decimal, "PorcDescuento2")
            cmdInsert.Parameters.Add("@PorcDescuento3", DbType.Decimal, "PorcDescuento3")
            cmdInsert.Parameters.Add("@PorcDescuento4", DbType.Decimal, "PorcDescuento4")
            cmdInsert.Parameters.Add("@PorcDescuento5", DbType.Decimal, "PorcDescuento5")
            cmdInsert.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Today
            cmdInsert.Parameters.Add("@PCUpdate", DbType.String).Value = Me.Session.WorkStation
            cmdInsert.Parameters.Add("@UserUpdate", DbType.Int32).Value = Me.Session.User.Identity

            'Actualizar servicios
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.Update(ServiciosTB)

        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de servicios.", ex)
        End Try
    End Sub

    Public Sub saveClientes(ByVal id As Integer, ByVal ClientesTB As GrupoDescuentosDS.ClientesDataTable)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Sales.GrupoDescuentosClientesUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdGrupoDescuentos", DbType.Int32).Value = id
            cmdInsert.Parameters.Add("@IdCliente", DbType.Int32, "IdCliente")

            'Actualizar Clientes
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.Update(ClientesTB)

        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de clientes.", ex)
        End Try
    End Sub


	Public Overrides Function Create() As GrupoDescuentosInfo
        Return New GrupoDescuentosInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de GruposDescuento
''' </summary>
''' <remarks></remarks>
Public Class GrupoDescuentosFacade
	Inherits CatalogFacade(Of GrupoDescuentosInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un GrupoDescuentosInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal SessionID As Guid) As GrupoDescuentosInfo
        Dim GrupoDescuentosSvc As New GrupoDescuentosService(SessionID)
        Return GrupoDescuentosSvc.Create()
    End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de GruposDescuento
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGrupoDescuentos">Identificador del GrupoDescuentos que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal SessionID As Guid, ByVal idGrupoDescuentos As Integer)
        Dim GrupoDescuentosSvc As New GrupoDescuentosService(SessionID)
        Delete(GrupoDescuentosSvc, idGrupoDescuentos)
    End Sub
	
    ''' <summary>
    ''' Verifica si existe un GrupoDescuentos con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGrupoDescuentos">ID de GrupoDescuentos que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal SessionID As Guid, ByVal idGrupoDescuentos As Integer) As Boolean
        Dim GrupoDescuentosSvc As New GrupoDescuentosService(SessionID)
        Return Exists(GrupoDescuentosSvc, idGrupoDescuentos)
    End Function

    ''' <summary>
    ''' Verifica si existe un GrupoDescuentos con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal SessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim GrupoDescuentosSvc As New GrupoDescuentosService(SessionID)
        Return Exists(GrupoDescuentosSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un GrupoDescuentos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGrupoDescuentos">Identificador de GrupoDescuentos a consultar</param>
    ''' <returns>Paquete de información de tipo GrupoDescuentosInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal SessionID As Guid, ByVal idGrupoDescuentos As Integer) As GrupoDescuentosInfo
        Return Me.GetDetail(SessionID, idGrupoDescuentos, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un GrupoDescuentos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGrupoDescuentos">Identificador de GrupoDescuentos</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del GrupoDescuentos.</param>
    ''' <returns>Paquete de información de tipo GrupoDescuentosInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal SessionID As Guid, ByVal idGrupoDescuentos As Integer, ByVal checkStatus As Boolean) As GrupoDescuentosInfo
        Dim GrupoDescuentosSvc As New GrupoDescuentosService(SessionID)
        Dim GrupoDescuentosInf As New GrupoDescuentosInfo(SessionID)
        GetDetail(GrupoDescuentosSvc, GrupoDescuentosInf, idGrupoDescuentos, checkStatus)
        Return GrupoDescuentosInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un GrupoDescuentos en base a su codigo de usuario
    ''' y verifica que el GrupoDescuentos esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información GrupoDescuentosInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal SessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As GrupoDescuentosInfo
        Return Me.GetDetail(SessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un GrupoDescuentos en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del GrupoDescuentos</param>
    ''' <returns>Paquete de información GrupoDescuentosInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal SessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As GrupoDescuentosInfo
        Dim GrupoDescuentosInf As New GrupoDescuentosInfo(SessionID)
        Dim GrupoDescuentosSvc As New GrupoDescuentosService(SessionID)
        GetDetail(GrupoDescuentosSvc, GrupoDescuentosInf, userCode, idSucursal, checkStatus)
        Return GrupoDescuentosInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un GrupoDescuentos.
    ''' </summary>
    ''' <param name="GrupoDescuentos">Paquete de información del tipo GrupoDescuentosInfo con la información a actualizar</param>
    ''' <returns>Identificador de GrupoDescuentos, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal GrupoDescuentos As GrupoDescuentosInfo) As Integer
        Dim GrupoDescuentosSvc As New GrupoDescuentosService(GrupoDescuentos.SessionID)
		Return Update(GrupoDescuentosSvc, GrupoDescuentos)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal SessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim GrupoDescuentosSvc As New GrupoDescuentosService(SessionID)
        Return GetNumberOfPages(GrupoDescuentosSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca GruposDescuento que coincidan con las condiciones especificadas.
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
    ''' Busca GruposDescuento que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal SessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim GrupoDescuentosSvc As New GrupoDescuentosService(SessionID)
        Return GetSearchResult(GrupoDescuentosSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de GruposDescuento.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal SessionID As Guid) As System.Data.DataSet
        Dim GrupoDescuentosSvc As New GrupoDescuentosService(SessionID)
        Return GetSearchStructure(GrupoDescuentosSvc)
    End Function

#End Region

End Class
