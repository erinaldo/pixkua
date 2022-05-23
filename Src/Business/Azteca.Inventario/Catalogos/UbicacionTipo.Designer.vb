''' <summary>
''' Paquete de informaci�n que representa un UbicacionTipo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class UbicacionTipoInfo
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
''' Proveedor de servicios para el manejo del cat�logo de UbicacionesTipo
''' </summary>
''' <remarks></remarks>
Public Class UbicacionTipoService
	Inherits CatalogService(Of UbicacionTipoInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory","UbicacionesTipo", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idUbicacionTipo As Integer, ByRef UbicacionTipo As UbicacionTipoInfo, checkStatus As Boolean)
		MyBase.GetDetail(idUbicacionTipo, UbicacionTipo, checkStatus)
        With UbicacionTipo
			.Nombre = CStr(ItemInfo("Nombre"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal UbicacionTipo As UbicacionTipoInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = UbicacionTipo.Nombre
			.Add("@IdCuenta", DbType.Int32).Value = UbicacionTipo.IdCuenta

		End With
		Return MyBase.Update(UbicacionTipo)
	End Function
	
	Public Overrides Function Create() As UbicacionTipoInfo
		Return New UbicacionTipoInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de UbicacionesTipo
''' </summary>
''' <remarks></remarks>
Public Class UbicacionTipoFacade
	Inherits CatalogFacade(Of UbicacionTipoInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un UbicacionTipoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As UbicacionTipoInfo
		Dim UbicacionTipoSvc As New UbicacionTipoService(sessionID)
		Return UbicacionTipoSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del cat�logo de UbicacionesTipo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idUbicacionTipo">Identificador del UbicacionTipo que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idUbicacionTipo As Integer)
		Dim UbicacionTipoSvc As New UbicacionTipoService(sessionID)
		Delete(UbicacionTipoSvc, idUbicacionTipo)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un UbicacionTipo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idUbicacionTipo">ID de UbicacionTipo que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idUbicacionTipo As Integer) As Boolean
		Dim UbicacionTipoSvc As New UbicacionTipoService(sessionID)
		Return Exists(UbicacionTipoSvc, idUbicacionTipo)
    End Function

    ''' <summary>
    ''' Verifica si existe un UbicacionTipo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim UbicacionTipoSvc As New UbicacionTipoService(sessionID)
        Return Exists(UbicacionTipoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un UbicacionTipo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idUbicacionTipo">Identificador de UbicacionTipo a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo UbicacionTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idUbicacionTipo As Integer) As UbicacionTipoInfo
        Return Me.GetDetail(sessionID, idUbicacionTipo, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un UbicacionTipo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idUbicacionTipo">Identificador de UbicacionTipo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del UbicacionTipo.</param>
    ''' <returns>Paquete de informaci�n de tipo UbicacionTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idUbicacionTipo As Integer, checkStatus As Boolean) As UbicacionTipoInfo
   		Dim UbicacionTipoSvc As New UbicacionTipoService(sessionID)
        Dim UbicacionTipoInf As New UbicacionTipoInfo(sessionID)
		GetDetail(UbicacionTipoSvc, UbicacionTipoInf, idUbicacionTipo, checkStatus)
        Return UbicacionTipoInf        
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un UbicacionTipo en base a su codigo de usuario
    ''' y verifica que el UbicacionTipo est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n UbicacionTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As UbicacionTipoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un UbicacionTipo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del UbicacionTipo</param>
    ''' <returns>Paquete de informaci�n UbicacionTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As UbicacionTipoInfo
        Dim UbicacionTipoInf As New UbicacionTipoInfo(sessionID)
        Dim UbicacionTipoSvc As New UbicacionTipoService(sessionID)
        GetDetail(UbicacionTipoSvc, UbicacionTipoInf, userCode, idSucursal, checkStatus)
        Return UbicacionTipoInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un UbicacionTipo.
    ''' </summary>
    ''' <param name="UbicacionTipo">Paquete de informaci�n del tipo UbicacionTipoInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de UbicacionTipo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal UbicacionTipo As UbicacionTipoInfo) As Integer
    	Dim UbicacionTipoSvc As New UbicacionTipoService(UbicacionTipo.sessionID)
		Return Update(UbicacionTipoSvc, UbicacionTipo)
    End Function
	
    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim UbicacionTipoSvc As New UbicacionTipoService(sessionID)
    	Return GetNumberOfPages(UbicacionTipoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca UbicacionesTipo que coincidan con las condiciones especificadas.
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
    ''' Busca UbicacionesTipo que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim UbicacionTipoSvc As New UbicacionTipoService(sessionID)
    	Return GetSearchResult(UbicacionTipoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de UbicacionesTipo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim UbicacionTipoSvc As New UbicacionTipoService(sessionID)
    	Return GetSearchStructure(UbicacionTipoSvc)
    End Function

#End Region

End Class
