''' <summary>
''' Paquete de informaci�n que representa un PagoTipo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class PagoTipoInfo
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
''' Proveedor de servicios para el manejo del cat�logo de PagosTipos
''' </summary>
''' <remarks></remarks>
Public Class PagoTipoService
	Inherits CatalogService(Of PagoTipoInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Treasury","PagosTipos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idPagoTipo As Integer, ByRef PagoTipo As PagoTipoInfo, checkStatus As Boolean)
		MyBase.GetDetail(idPagoTipo, PagoTipo, checkStatus)
        With PagoTipo
			.Nombre = CStr(ItemInfo("Nombre"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal PagoTipo As PagoTipoInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = PagoTipo.Nombre
			.Add("@IdCuenta", DbType.Int32).Value = PagoTipo.IdCuenta

		End With
		Return MyBase.Update(PagoTipo)
	End Function
	
	Public Overrides Function Create() As PagoTipoInfo
		Return New PagoTipoInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de PagosTipos
''' </summary>
''' <remarks></remarks>
Public Class PagoTipoFacade
	Inherits CatalogFacade(Of PagoTipoInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un PagoTipoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As PagoTipoInfo
		Dim PagoTipoSvc As New PagoTipoService(sessionID)
		Return PagoTipoSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del cat�logo de PagosTipos
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idPagoTipo">Identificador del PagoTipo que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idPagoTipo As Integer)
		Dim PagoTipoSvc As New PagoTipoService(sessionID)
		Delete(PagoTipoSvc, idPagoTipo)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un PagoTipo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idPagoTipo">ID de PagoTipo que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idPagoTipo As Integer) As Boolean
		Dim PagoTipoSvc As New PagoTipoService(sessionID)
		Return Exists(PagoTipoSvc, idPagoTipo)
    End Function

    ''' <summary>
    ''' Verifica si existe un PagoTipo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim PagoTipoSvc As New PagoTipoService(sessionID)
        Return Exists(PagoTipoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un PagoTipo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idPagoTipo">Identificador de PagoTipo a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo PagoTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPagoTipo As Integer) As PagoTipoInfo
        Return Me.GetDetail(sessionID, idPagoTipo, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un PagoTipo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idPagoTipo">Identificador de PagoTipo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del PagoTipo.</param>
    ''' <returns>Paquete de informaci�n de tipo PagoTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPagoTipo As Integer, checkStatus As Boolean) As PagoTipoInfo
   		Dim PagoTipoSvc As New PagoTipoService(sessionID)
        Dim PagoTipoInf As New PagoTipoInfo(sessionID)
		GetDetail(PagoTipoSvc, PagoTipoInf, idPagoTipo, checkStatus)
        Return PagoTipoInf        
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un PagoTipo en base a su codigo de usuario
    ''' y verifica que el PagoTipo est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n PagoTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As PagoTipoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un PagoTipo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del PagoTipo</param>
    ''' <returns>Paquete de informaci�n PagoTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As PagoTipoInfo
        Dim PagoTipoInf As New PagoTipoInfo(sessionID)
        Dim PagoTipoSvc As New PagoTipoService(sessionID)
        GetDetail(PagoTipoSvc, PagoTipoInf, userCode, idSucursal, checkStatus)
        Return PagoTipoInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un PagoTipo.
    ''' </summary>
    ''' <param name="PagoTipo">Paquete de informaci�n del tipo PagoTipoInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de PagoTipo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal PagoTipo As PagoTipoInfo) As Integer
    	Dim PagoTipoSvc As New PagoTipoService(PagoTipo.sessionID)
		Return Update(PagoTipoSvc, PagoTipo)
    End Function
	
    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim PagoTipoSvc As New PagoTipoService(sessionID)
    	Return GetNumberOfPages(PagoTipoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca PagosTipos que coincidan con las condiciones especificadas.
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
    ''' Busca PagosTipos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim PagoTipoSvc As New PagoTipoService(sessionID)
    	Return GetSearchResult(PagoTipoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de PagosTipos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim PagoTipoSvc As New PagoTipoService(sessionID)
    	Return GetSearchStructure(PagoTipoSvc)
    End Function

#End Region

End Class
