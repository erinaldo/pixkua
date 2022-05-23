''' <summary>
''' Paquete de información que representa un Chequera
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ChequeraInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdBanco As Integer

    Public Property Cuenta As String

    Public Property IdCaja As Integer

    Public Property IdCuenta As Integer


#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Chequeras
''' </summary>
''' <remarks></remarks>
Public Class ChequeraService
	Inherits CatalogService(Of ChequeraInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Treasury","Chequeras", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idChequera As Integer, ByRef Chequera As ChequeraInfo, checkStatus As Boolean)
		MyBase.GetDetail(idChequera, Chequera, checkStatus)
        With Chequera
			.Nombre = CStr(ItemInfo("Nombre"))
			.IdBanco = CInt(ItemInfo("IdBanco"))
			.Cuenta = CStr(ItemInfo("Cuenta"))
			.IdCaja = CInt(ItemInfo("IdCaja"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal Chequera As ChequeraInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = Chequera.Nombre
			.Add("@IdBanco", DbType.Int32).Value = Chequera.IdBanco
			.Add("@Cuenta", DbType.String).Value = Chequera.Cuenta
			.Add("@IdCaja", DbType.Int32).Value = Chequera.IdCaja
			.Add("@IdCuenta", DbType.Int32).Value = Chequera.IdCuenta

		End With
		Return MyBase.Update(Chequera)
	End Function
	
	Public Overrides Function Create() As ChequeraInfo
		Return New ChequeraInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Chequeras
''' </summary>
''' <remarks></remarks>
Public Class ChequeraFacade
	Inherits CatalogFacade(Of ChequeraInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ChequeraInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As ChequeraInfo
		Dim ChequeraSvc As New ChequeraService(sessionID)
		Return ChequeraSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Chequeras
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idChequera">Identificador del Chequera que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idChequera As Integer)
		Dim ChequeraSvc As New ChequeraService(sessionID)
		Delete(ChequeraSvc, idChequera)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Chequera con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idChequera">ID de Chequera que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idChequera As Integer) As Boolean
		Dim ChequeraSvc As New ChequeraService(sessionID)
		Return Exists(ChequeraSvc, idChequera)
    End Function

    ''' <summary>
    ''' Verifica si existe un Chequera con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim ChequeraSvc As New ChequeraService(sessionID)
        Return Exists(ChequeraSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Chequera.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idChequera">Identificador de Chequera a consultar</param>
    ''' <returns>Paquete de información de tipo ChequeraInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idChequera As Integer) As ChequeraInfo
        Return Me.GetDetail(sessionID, idChequera, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Chequera.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idChequera">Identificador de Chequera</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Chequera.</param>
    ''' <returns>Paquete de información de tipo ChequeraInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idChequera As Integer, checkStatus As Boolean) As ChequeraInfo
   		Dim ChequeraSvc As New ChequeraService(sessionID)
        Dim ChequeraInf As New ChequeraInfo(sessionID)
		GetDetail(ChequeraSvc, ChequeraInf, idChequera, checkStatus)
        Return ChequeraInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un Chequera en base a su codigo de usuario
    ''' y verifica que el Chequera esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ChequeraInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ChequeraInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Chequera en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Chequera</param>
    ''' <returns>Paquete de información ChequeraInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ChequeraInfo
        Dim ChequeraInf As New ChequeraInfo(sessionID)
        Dim ChequeraSvc As New ChequeraService(sessionID)
        GetDetail(ChequeraSvc, ChequeraInf, userCode, idSucursal, checkStatus)
        Return ChequeraInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Chequera.
    ''' </summary>
    ''' <param name="Chequera">Paquete de información del tipo ChequeraInfo con la información a actualizar</param>
    ''' <returns>Identificador de Chequera, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Chequera As ChequeraInfo) As Integer
    	Dim ChequeraSvc As New ChequeraService(Chequera.sessionID)
		Return Update(ChequeraSvc, Chequera)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim ChequeraSvc As New ChequeraService(sessionID)
    	Return GetNumberOfPages(ChequeraSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Chequeras que coincidan con las condiciones especificadas.
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
    ''' Busca Chequeras que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim ChequeraSvc As New ChequeraService(sessionID)
    	Return GetSearchResult(ChequeraSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Chequeras.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim ChequeraSvc As New ChequeraService(sessionID)
    	Return GetSearchStructure(ChequeraSvc)
    End Function

#End Region

End Class
