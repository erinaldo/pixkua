''' <summary>
''' Paquete de información que representa un Regleta
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class RegletaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdCuenta As Integer

    Public Property TallasTable As TallasDS.TallasDataTable
#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        TallasTable = New TallasDS.TallasDataTable
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Regletas
''' </summary>
''' <remarks></remarks>
Public Class RegletaService
	Inherits CatalogService(Of RegletaInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory","Regletas", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idRegleta As Integer, ByRef Regleta As RegletaInfo, checkStatus As Boolean)
		MyBase.GetDetail(idRegleta, Regleta, checkStatus)
        With Regleta
			.Nombre = CStr(ItemInfo("Nombre"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))
            LoadTallas(Regleta)
		End With
	End Sub
	
	Public Overrides Function Update(ByVal Regleta As RegletaInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = Regleta.Nombre
			.Add("@IdCuenta", DbType.Int32).Value = Regleta.IdCuenta
        End With
        Dim Id As Integer = MyBase.Update(Regleta)
        saveTallas(Id, Regleta)
        Return Id
	End Function
	
	Public Overrides Function Create() As RegletaInfo
		Return New RegletaInfo(SessionID)
	End Function

#End Region



#Region "Metodos Privados"
    Private Sub loadTallas(ByVal info As RegletaInfo)
        Try
            info.TallasTable.Rows.Clear()
            Dim fx As New FunctionSQL("Inventory", "fxRegletasTallasSEL", Connection, Transaction)
            fx.Parameters.Add("@IdRegleta", DbType.Int32).Value = info.Identity
            fx.FillDataTable(info.TallasTable)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Tallas.", ex)
        End Try
    End Sub

    Private Sub saveTallas(IdRegleta As Integer, ByVal info As RegletaInfo)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Inventory.RegletasTallasUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure
            cmdInsert.Parameters.Add("@IdRegleta", DbType.Int32).Value = IdRegleta
            cmdInsert.Parameters.Add("@IdTalla", DbType.Int32, "IdTalla")
            cmdInsert.Parameters.Add("@Nombre", DbType.String, "Nombre")
            cmdInsert.Parameters.Add("@Abreviatura", DbType.String, "Abreviatura")


            Dim cmdDelete As New Azteca.Data.DbCommand("Inventory.RegletasTallasDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdTalla", DbType.Int32, "IdTalla")
            cmdDelete.CommandType = CommandType.StoredProcedure

            'Actualizar Articulos
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            '            da.DeleteCommand = cmdDelete
            da.Update(info.TallasTable)
        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de Tallas.", ex)
        End Try
    End Sub

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Regletas
''' </summary>
''' <remarks></remarks>
Public Class RegletaFacade
	Inherits CatalogFacade(Of RegletaInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un RegletaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As RegletaInfo
		Dim RegletaSvc As New RegletaService(sessionID)
		Return RegletaSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Regletas
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRegleta">Identificador del Regleta que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idRegleta As Integer)
		Dim RegletaSvc As New RegletaService(sessionID)
		Delete(RegletaSvc, idRegleta)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Regleta con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRegleta">ID de Regleta que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idRegleta As Integer) As Boolean
		Dim RegletaSvc As New RegletaService(sessionID)
		Return Exists(RegletaSvc, idRegleta)
    End Function

    ''' <summary>
    ''' Verifica si existe un Regleta con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim RegletaSvc As New RegletaService(sessionID)
        Return Exists(RegletaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Regleta.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRegleta">Identificador de Regleta a consultar</param>
    ''' <returns>Paquete de información de tipo RegletaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idRegleta As Integer) As RegletaInfo
        Return Me.GetDetail(sessionID, idRegleta, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Regleta.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRegleta">Identificador de Regleta</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Regleta.</param>
    ''' <returns>Paquete de información de tipo RegletaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idRegleta As Integer, checkStatus As Boolean) As RegletaInfo
   		Dim RegletaSvc As New RegletaService(sessionID)
        Dim RegletaInf As New RegletaInfo(sessionID)
		GetDetail(RegletaSvc, RegletaInf, idRegleta, checkStatus)
        Return RegletaInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un Regleta en base a su codigo de usuario
    ''' y verifica que el Regleta esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información RegletaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As RegletaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Regleta en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Regleta</param>
    ''' <returns>Paquete de información RegletaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As RegletaInfo
        Dim RegletaInf As New RegletaInfo(sessionID)
        Dim RegletaSvc As New RegletaService(sessionID)
        GetDetail(RegletaSvc, RegletaInf, userCode, idSucursal, checkStatus)
        Return RegletaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Regleta.
    ''' </summary>
    ''' <param name="Regleta">Paquete de información del tipo RegletaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Regleta, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Regleta As RegletaInfo) As Integer
    	Dim RegletaSvc As New RegletaService(Regleta.sessionID)
		Return Update(RegletaSvc, Regleta)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim RegletaSvc As New RegletaService(sessionID)
    	Return GetNumberOfPages(RegletaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Regletas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Regletas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim RegletaSvc As New RegletaService(sessionID)
    	Return GetSearchResult(RegletaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Regletas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim RegletaSvc As New RegletaService(sessionID)
    	Return GetSearchStructure(RegletaSvc)
    End Function

#End Region

End Class
