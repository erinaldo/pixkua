''' <summary>
''' Paquete de informaci�n que representa un CausaDevolucion
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CausaDevolucionInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdCuenta As Integer


#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de DevolucionesCausas
''' </summary>
''' <remarks></remarks>
Public Class CausaDevolucionService
	Inherits CatalogService(Of CausaDevolucionInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales","DevolucionesCausas", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCausaDevolucion As Integer, ByRef CausaDevolucion As CausaDevolucionInfo, checkStatus As Boolean)
		MyBase.GetDetail(idCausaDevolucion, CausaDevolucion, checkStatus)
        With CausaDevolucion
			.Nombre = CStr(ItemInfo("Nombre"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))
		End With
	End Sub
	
	Public Overrides Function Update(ByVal CausaDevolucion As CausaDevolucionInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = CausaDevolucion.Nombre
			.Add("@IdCuenta", DbType.Int32).Value = CausaDevolucion.IdCuenta
		End With
		Return MyBase.Update(CausaDevolucion)
	End Function
	
	Public Overrides Function Create() As CausaDevolucionInfo
		Return New CausaDevolucionInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de DevolucionesCausas
''' </summary>
''' <remarks></remarks>
Public Class CausaDevolucionFacade
	Inherits CatalogFacade(Of CausaDevolucionInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CausaDevolucionInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As CausaDevolucionInfo
		Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
		Return CausaDevolucionSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del cat�logo de DevolucionesCausas
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idCausaDevolucion">Identificador del CausaDevolucion que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idCausaDevolucion As Integer)
		Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
		Delete(CausaDevolucionSvc, idCausaDevolucion)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un CausaDevolucion con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idCausaDevolucion">ID de CausaDevolucion que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idCausaDevolucion As Integer) As Boolean
		Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
		Return Exists(CausaDevolucionSvc, idCausaDevolucion)
    End Function

    ''' <summary>
    ''' Verifica si existe un CausaDevolucion con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
        Return Exists(CausaDevolucionSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un CausaDevolucion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idCausaDevolucion">Identificador de CausaDevolucion a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo CausaDevolucionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCausaDevolucion As Integer) As CausaDevolucionInfo
        Return Me.GetDetail(sessionID, idCausaDevolucion, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un CausaDevolucion.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idCausaDevolucion">Identificador de CausaDevolucion</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del CausaDevolucion.</param>
    ''' <returns>Paquete de informaci�n de tipo CausaDevolucionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCausaDevolucion As Integer, checkStatus As Boolean) As CausaDevolucionInfo
   		Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
        Dim CausaDevolucionInf As New CausaDevolucionInfo(sessionID)
		GetDetail(CausaDevolucionSvc, CausaDevolucionInf, idCausaDevolucion, checkStatus)
        Return CausaDevolucionInf        
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un CausaDevolucion en base a su codigo de usuario
    ''' y verifica que el CausaDevolucion est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n CausaDevolucionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As CausaDevolucionInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un CausaDevolucion en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del CausaDevolucion</param>
    ''' <returns>Paquete de informaci�n CausaDevolucionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CausaDevolucionInfo
        Dim CausaDevolucionInf As New CausaDevolucionInfo(sessionID)
        Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
        GetDetail(CausaDevolucionSvc, CausaDevolucionInf, userCode, idSucursal, checkStatus)
        Return CausaDevolucionInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un CausaDevolucion.
    ''' </summary>
    ''' <param name="CausaDevolucion">Paquete de informaci�n del tipo CausaDevolucionInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de CausaDevolucion, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal CausaDevolucion As CausaDevolucionInfo) As Integer
    	Dim CausaDevolucionSvc As New CausaDevolucionService(CausaDevolucion.sessionID)
		Return Update(CausaDevolucionSvc, CausaDevolucion)
    End Function
	
    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
    	Return GetNumberOfPages(CausaDevolucionSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca DevolucionesCausas que coincidan con las condiciones especificadas.
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
    ''' Busca DevolucionesCausas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
    	Return GetSearchResult(CausaDevolucionSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de DevolucionesCausas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim CausaDevolucionSvc As New CausaDevolucionService(sessionID)
    	Return GetSearchStructure(CausaDevolucionSvc)
    End Function

#End Region

End Class
