''' <summary>
''' Paquete de información que representa un Banco
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class BancoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdCuenta As Integer

    Public Property Chequeras As ConfiguracionDS.ChequerasDataTable
#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        Me.Status = CatalogState.Active
        Chequeras = New ConfiguracionDS.ChequerasDataTable
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Bancos
''' </summary>
''' <remarks></remarks>
Public Class BancoService
	Inherits CatalogService(Of BancoInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Treasury","Bancos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idBanco As Integer, ByRef Banco As BancoInfo, checkStatus As Boolean)
		MyBase.GetDetail(idBanco, Banco, checkStatus)
        With Banco
			.Nombre = CStr(ItemInfo("Nombre"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))

        End With
        loadChequeras(Banco)
	End Sub
	
	Public Overrides Function Update(ByVal Banco As BancoInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = Banco.Nombre
            .Add("@IdCuenta", DbType.Int32).Value = Banco.IdCuenta
		End With
        Dim Id As Integer = MyBase.Update(Banco)
        saveChequeras(Banco)
        Return Id
	End Function
	
	Public Overrides Function Create() As BancoInfo
		Return New BancoInfo(SessionID)
	End Function

#End Region


#Region "Metodos Privados"
    Private Sub loadChequeras(ByVal info As BancoInfo)
        Try
            info.Chequeras.Rows.Clear()
            Dim fx As New FunctionSQL("Treasury", "fxBancosChequerasSEL", Connection, Transaction)
            fx.Parameters.Add("@IdBanco", DbType.Int32).Value = info.Identity
            fx.FillDataTable(info.Chequeras)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Chequeras.", ex)
        End Try
    End Sub

    Private Sub saveChequeras(ByVal info As BancoInfo)
        Try
            'Definir comando de actualización 
            Dim cmdInsert As New Azteca.Data.DbCommand("Treasury.ChequerasUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@Id", DbType.Int32, "IdChequera")
            cmdInsert.Parameters.Add("@Codigo", DbType.String, "IdChequera")
            cmdInsert.Parameters.Add("@Nombre", DbType.String, "Nombre")
            cmdInsert.Parameters.Add("@IdFormato", DbType.Int32, "IdFormato")
            cmdInsert.Parameters.Add("@IdBanco", DbType.Int32).Value = info.Identity
            cmdInsert.Parameters.Add("@Cuenta", DbType.String, "CuentaBancaria")
            cmdInsert.Parameters.Add("@IdCaja", DbType.Int32, "IdCaja")
            cmdInsert.Parameters.Add("@IdCuenta", DbType.Int32, "IdCuenta")
            cmdInsert.Parameters.Add("@IdStatus", DbType.Int32).Value = info.Status
            cmdInsert.Parameters.Add("@IdSucursal", DbType.Int32).Value = info.IdSucursal
            cmdInsert.Parameters.Add("@IdEmpresa", DbType.Int32).Value = info.IdEmpresa
            cmdInsert.Parameters.Add("@LastUpdate", DbType.DateTime).Value = Date.Today
            cmdInsert.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmdInsert.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity

            Dim cmdDelete As New Azteca.Data.DbCommand("Treasury.ChequerasDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@ID", DbType.Int32, "IdChequera")
            cmdDelete.CommandType = CommandType.StoredProcedure

            'Actualizar 
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.DeleteCommand = cmdDelete
            da.Update(info.Chequeras)
        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de chequeras.", ex)
        End Try
    End Sub


#End Region
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Bancos
''' </summary>
''' <remarks></remarks>
Public Class BancoFacade
	Inherits CatalogFacade(Of BancoInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un BancoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As BancoInfo
		Dim BancoSvc As New BancoService(sessionID)
		Return BancoSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Bancos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idBanco">Identificador del Banco que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idBanco As Integer)
		Dim BancoSvc As New BancoService(sessionID)
		Delete(BancoSvc, idBanco)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Banco con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idBanco">ID de Banco que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idBanco As Integer) As Boolean
		Dim BancoSvc As New BancoService(sessionID)
		Return Exists(BancoSvc, idBanco)
    End Function

    ''' <summary>
    ''' Verifica si existe un Banco con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim BancoSvc As New BancoService(sessionID)
        Return Exists(BancoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Banco.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idBanco">Identificador de Banco a consultar</param>
    ''' <returns>Paquete de información de tipo BancoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idBanco As Integer) As BancoInfo
        Return Me.GetDetail(sessionID, idBanco, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Banco.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idBanco">Identificador de Banco</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Banco.</param>
    ''' <returns>Paquete de información de tipo BancoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idBanco As Integer, checkStatus As Boolean) As BancoInfo
   		Dim BancoSvc As New BancoService(sessionID)
        Dim BancoInf As New BancoInfo(sessionID)
		GetDetail(BancoSvc, BancoInf, idBanco, checkStatus)
        Return BancoInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un Banco en base a su codigo de usuario
    ''' y verifica que el Banco esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información BancoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As BancoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Banco en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Banco</param>
    ''' <returns>Paquete de información BancoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As BancoInfo
        Dim BancoInf As New BancoInfo(sessionID)
        Dim BancoSvc As New BancoService(sessionID)
        GetDetail(BancoSvc, BancoInf, userCode, idSucursal, checkStatus)
        Return BancoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Banco.
    ''' </summary>
    ''' <param name="Banco">Paquete de información del tipo BancoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Banco, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Banco As BancoInfo) As Integer
    	Dim BancoSvc As New BancoService(Banco.sessionID)
		Return Update(BancoSvc, Banco)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim BancoSvc As New BancoService(sessionID)
    	Return GetNumberOfPages(BancoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Bancos que coincidan con las condiciones especificadas.
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
    ''' Busca Bancos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim BancoSvc As New BancoService(sessionID)
    	Return GetSearchResult(BancoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Bancos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim BancoSvc As New BancoService(sessionID)
    	Return GetSearchStructure(BancoSvc)
    End Function

#End Region

End Class
