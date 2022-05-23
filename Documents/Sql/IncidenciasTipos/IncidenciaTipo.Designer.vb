''' <summary>
''' Paquete de informaci�n que representa un IncidenciaTipo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class IncidenciaTipoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
	Public Property Nombre As String	Public Property IdCuenta As Integer	Public Property IdEmpresa As Integer
#End Region
	
#Region "Constructor"
	Public Sub New(ByVal session As UserSession)
		MyBase.New(session)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de IncidenciasTipos
''' </summary>
''' <remarks></remarks>
Public Class IncidenciaTipoService
	Inherits CatalogService(Of IncidenciaTipoInfo)
	
#Region "Constructores"
	Public Sub New(ByVal session As UserSession)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As UserSession, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As UserSession, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Production","IncidenciasTipos", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idIncidenciaTipo As Integer, ByRef IncidenciaTipo As IncidenciaTipoInfo, checkStatus As Boolean)
		MyBase.GetDetail(idIncidenciaTipo, IncidenciaTipo, checkStatus)
        With IncidenciaTipo
			.Nombre = CStr(Me.ItemInfo("Nombre"))
			.IdCuenta = CInt(Me.ItemInfo("IdCuenta"))
			.IdEmpresa = CInt(Me.ItemInfo("IdEmpresa"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal IncidenciaTipo As IncidenciaTipoInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = IncidenciaTipo.Nombre
			.Add("@IdCuenta", DbType.Int32).Value = IncidenciaTipo.IdCuenta
			.Add("@IdEmpresa", DbType.Int32).Value = IncidenciaTipo.IdEmpresa

		End With
		Return MyBase.Update(IncidenciaTipo)
	End Function
	
	Public Overrides Function Create() As IncidenciaTipoInfo
		Return New IncidenciaTipoInfo(Session)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de IncidenciasTipos
''' </summary>
''' <remarks></remarks>
Public Class IncidenciaTipoFacade
	Inherits CatalogFacade(Of IncidenciaTipoInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un IncidenciaTipoInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal session As UserSession) As IncidenciaTipoInfo
		Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
		Return IncidenciaTipoSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del cat�logo de IncidenciasTipos
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idIncidenciaTipo">Identificador del IncidenciaTipo que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As UserSession, ByVal idIncidenciaTipo As Integer)
		Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
		Delete(IncidenciaTipoSvc, idIncidenciaTipo)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un IncidenciaTipo con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idIncidenciaTipo">ID de IncidenciaTipo que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As UserSession, ByVal idIncidenciaTipo As Integer) As Boolean
		Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
		Return Exists(IncidenciaTipoSvc, idIncidenciaTipo)
    End Function

    ''' <summary>
    ''' Verifica si existe un IncidenciaTipo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As UserSession, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
        Return Exists(IncidenciaTipoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un IncidenciaTipo.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idIncidenciaTipo">Identificador de IncidenciaTipo a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo IncidenciaTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As UserSession, ByVal idIncidenciaTipo As Integer) As IncidenciaTipoInfo
        Return Me.GetDetail(session, idIncidenciaTipo, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un IncidenciaTipo.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idIncidenciaTipo">Identificador de IncidenciaTipo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del IncidenciaTipo.</param>
    ''' <returns>Paquete de informaci�n de tipo IncidenciaTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As UserSession, ByVal idIncidenciaTipo As Integer, checkStatus As Boolean) As IncidenciaTipoInfo
   		Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
        Dim IncidenciaTipoInf As New IncidenciaTipoInfo(session)
		GetDetail(IncidenciaTipoSvc, IncidenciaTipoInf, idIncidenciaTipo, checkStatus)
        Return IncidenciaTipoInf        
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un IncidenciaTipo en base a su codigo de usuario
    ''' y verifica que el IncidenciaTipo est� activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n IncidenciaTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As UserSession, ByVal userCode As String, ByVal idSucursal As Integer) As IncidenciaTipoInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un IncidenciaTipo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del IncidenciaTipo</param>
    ''' <returns>Paquete de informaci�n IncidenciaTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As UserSession, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As IncidenciaTipoInfo
        Dim IncidenciaTipoInf As New IncidenciaTipoInfo(session)
        Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
        GetDetail(IncidenciaTipoSvc, IncidenciaTipoInf, userCode, idSucursal, checkStatus)
        Return IncidenciaTipoInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un IncidenciaTipo.
    ''' </summary>
    ''' <param name="IncidenciaTipo">Paquete de informaci�n del tipo IncidenciaTipoInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de IncidenciaTipo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal IncidenciaTipo As IncidenciaTipoInfo) As Integer
    	Dim IncidenciaTipoSvc As New IncidenciaTipoService(IncidenciaTipo.session)
		Return Update(IncidenciaTipoSvc, IncidenciaTipo)
    End Function
	
    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As UserSession, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
    	Return GetNumberOfPages(IncidenciaTipoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca IncidenciasTipos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As UserSession, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(session, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca IncidenciasTipos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As UserSession, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
    	Return GetSearchResult(IncidenciaTipoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de IncidenciasTipos.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As UserSession) As System.Data.DataSet
    	Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
    	Return GetSearchStructure(IncidenciaTipoSvc)
    End Function

#End Region

End Class
