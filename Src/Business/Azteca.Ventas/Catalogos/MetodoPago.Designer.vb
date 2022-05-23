''' <summary>
''' Paquete de informaci�n que representa un MetodoPago
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class MetodoPagoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String


#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de MetodosPago
''' </summary>
''' <remarks></remarks>
Public Class MetodoPagoService
	Inherits CatalogService(Of MetodoPagoInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales","MetodosPago", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idMetodoPago As Integer, ByRef MetodoPago As MetodoPagoInfo, checkStatus As Boolean)
		MyBase.GetDetail(idMetodoPago, MetodoPago, checkStatus)
        With MetodoPago
			.Nombre = CStr(ItemInfo("Nombre"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal MetodoPago As MetodoPagoInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = MetodoPago.Nombre

		End With
		Return MyBase.Update(MetodoPago)
	End Function
	
	Public Overrides Function Create() As MetodoPagoInfo
		Return New MetodoPagoInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de MetodosPago
''' </summary>
''' <remarks></remarks>
Public Class MetodoPagoFacade
	Inherits CatalogFacade(Of MetodoPagoInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un MetodoPagoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As MetodoPagoInfo
		Dim MetodoPagoSvc As New MetodoPagoService(sessionID)
		Return MetodoPagoSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del cat�logo de MetodosPago
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idMetodoPago">Identificador del MetodoPago que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idMetodoPago As Integer)
		Dim MetodoPagoSvc As New MetodoPagoService(sessionID)
		Delete(MetodoPagoSvc, idMetodoPago)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un MetodoPago con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idMetodoPago">ID de MetodoPago que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idMetodoPago As Integer) As Boolean
		Dim MetodoPagoSvc As New MetodoPagoService(sessionID)
		Return Exists(MetodoPagoSvc, idMetodoPago)
    End Function

    ''' <summary>
    ''' Verifica si existe un MetodoPago con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim MetodoPagoSvc As New MetodoPagoService(sessionID)
        Return Exists(MetodoPagoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un MetodoPago.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idMetodoPago">Identificador de MetodoPago a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo MetodoPagoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idMetodoPago As Integer) As MetodoPagoInfo
        Return Me.GetDetail(sessionID, idMetodoPago, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un MetodoPago.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idMetodoPago">Identificador de MetodoPago</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del MetodoPago.</param>
    ''' <returns>Paquete de informaci�n de tipo MetodoPagoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idMetodoPago As Integer, checkStatus As Boolean) As MetodoPagoInfo
   		Dim MetodoPagoSvc As New MetodoPagoService(sessionID)
        Dim MetodoPagoInf As New MetodoPagoInfo(sessionID)
		GetDetail(MetodoPagoSvc, MetodoPagoInf, idMetodoPago, checkStatus)
        Return MetodoPagoInf        
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un MetodoPago en base a su codigo de usuario
    ''' y verifica que el MetodoPago est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n MetodoPagoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As MetodoPagoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un MetodoPago en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del MetodoPago</param>
    ''' <returns>Paquete de informaci�n MetodoPagoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As MetodoPagoInfo
        Dim MetodoPagoInf As New MetodoPagoInfo(sessionID)
        Dim MetodoPagoSvc As New MetodoPagoService(sessionID)
        GetDetail(MetodoPagoSvc, MetodoPagoInf, userCode, idSucursal, checkStatus)
        Return MetodoPagoInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un MetodoPago.
    ''' </summary>
    ''' <param name="MetodoPago">Paquete de informaci�n del tipo MetodoPagoInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de MetodoPago, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal MetodoPago As MetodoPagoInfo) As Integer
    	Dim MetodoPagoSvc As New MetodoPagoService(MetodoPago.sessionID)
		Return Update(MetodoPagoSvc, MetodoPago)
    End Function
	
    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim MetodoPagoSvc As New MetodoPagoService(sessionID)
    	Return GetNumberOfPages(MetodoPagoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca MetodosPago que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca MetodosPago que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim MetodoPagoSvc As New MetodoPagoService(sessionID)
    	Return GetSearchResult(MetodoPagoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de MetodosPago.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim MetodoPagoSvc As New MetodoPagoService(sessionID)
    	Return GetSearchStructure(MetodoPagoSvc)
    End Function

#End Region

End Class
