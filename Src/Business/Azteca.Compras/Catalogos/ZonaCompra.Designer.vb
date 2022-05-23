''' <summary>
''' Paquete de informaci�n que representa un ZonaCompra
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ZonaCompraInfo
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
''' Proveedor de servicios para el manejo del cat�logo de ZonasCompra
''' </summary>
''' <remarks></remarks>
Public Class ZonaCompraService
	Inherits CatalogService(Of ZonaCompraInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing","ZonasCompra", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idZonaCompra As Integer, ByRef ZonaCompra As ZonaCompraInfo, checkStatus As Boolean)
		MyBase.GetDetail(idZonaCompra, ZonaCompra, checkStatus)
        With ZonaCompra
			.Nombre = CStr(ItemInfo("Nombre"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal ZonaCompra As ZonaCompraInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = ZonaCompra.Nombre

		End With
		Return MyBase.Update(ZonaCompra)
	End Function
	
	Public Overrides Function Create() As ZonaCompraInfo
		Return New ZonaCompraInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de ZonasCompra
''' </summary>
''' <remarks></remarks>
Public Class ZonaCompraFacade
	Inherits CatalogFacade(Of ZonaCompraInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ZonaCompraInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As ZonaCompraInfo
		Dim ZonaCompraSvc As New ZonaCompraService(sessionID)
		Return ZonaCompraSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del cat�logo de ZonasCompra
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idZonaCompra">Identificador del ZonaCompra que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idZonaCompra As Integer)
		Dim ZonaCompraSvc As New ZonaCompraService(sessionID)
		Delete(ZonaCompraSvc, idZonaCompra)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un ZonaCompra con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idZonaCompra">ID de ZonaCompra que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idZonaCompra As Integer) As Boolean
		Dim ZonaCompraSvc As New ZonaCompraService(sessionID)
		Return Exists(ZonaCompraSvc, idZonaCompra)
    End Function

    ''' <summary>
    ''' Verifica si existe un ZonaCompra con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim ZonaCompraSvc As New ZonaCompraService(sessionID)
        Return Exists(ZonaCompraSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un ZonaCompra.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idZonaCompra">Identificador de ZonaCompra a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo ZonaCompraInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idZonaCompra As Integer) As ZonaCompraInfo
        Return Me.GetDetail(sessionID, idZonaCompra, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un ZonaCompra.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idZonaCompra">Identificador de ZonaCompra</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ZonaCompra.</param>
    ''' <returns>Paquete de informaci�n de tipo ZonaCompraInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idZonaCompra As Integer, checkStatus As Boolean) As ZonaCompraInfo
   		Dim ZonaCompraSvc As New ZonaCompraService(sessionID)
        Dim ZonaCompraInf As New ZonaCompraInfo(sessionID)
		GetDetail(ZonaCompraSvc, ZonaCompraInf, idZonaCompra, checkStatus)
        Return ZonaCompraInf        
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un ZonaCompra en base a su codigo de usuario
    ''' y verifica que el ZonaCompra est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n ZonaCompraInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ZonaCompraInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un ZonaCompra en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ZonaCompra</param>
    ''' <returns>Paquete de informaci�n ZonaCompraInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ZonaCompraInfo
        Dim ZonaCompraInf As New ZonaCompraInfo(sessionID)
        Dim ZonaCompraSvc As New ZonaCompraService(sessionID)
        GetDetail(ZonaCompraSvc, ZonaCompraInf, userCode, idSucursal, checkStatus)
        Return ZonaCompraInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un ZonaCompra.
    ''' </summary>
    ''' <param name="ZonaCompra">Paquete de informaci�n del tipo ZonaCompraInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de ZonaCompra, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal ZonaCompra As ZonaCompraInfo) As Integer
    	Dim ZonaCompraSvc As New ZonaCompraService(ZonaCompra.sessionID)
		Return Update(ZonaCompraSvc, ZonaCompra)
    End Function
	
    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim ZonaCompraSvc As New ZonaCompraService(sessionID)
    	Return GetNumberOfPages(ZonaCompraSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca ZonasCompra que coincidan con las condiciones especificadas.
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
    ''' Busca ZonasCompra que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim ZonaCompraSvc As New ZonaCompraService(sessionID)
    	Return GetSearchResult(ZonaCompraSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de ZonasCompra.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim ZonaCompraSvc As New ZonaCompraService(sessionID)
    	Return GetSearchStructure(ZonaCompraSvc)
    End Function

#End Region

End Class
