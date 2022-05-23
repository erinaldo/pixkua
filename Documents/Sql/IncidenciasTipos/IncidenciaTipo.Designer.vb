''' <summary>
''' Paquete de información que representa un IncidenciaTipo
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
''' Proveedor de servicios para el manejo del catálogo de IncidenciasTipos
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
''' Business Facade con servicios para el manejo del catálogo de IncidenciasTipos
''' </summary>
''' <remarks></remarks>
Public Class IncidenciaTipoFacade
	Inherits CatalogFacade(Of IncidenciaTipoInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un IncidenciaTipoInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal session As UserSession) As IncidenciaTipoInfo
		Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
		Return IncidenciaTipoSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de IncidenciasTipos
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idIncidenciaTipo">Identificador del IncidenciaTipo que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As UserSession, ByVal idIncidenciaTipo As Integer)
		Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
		Delete(IncidenciaTipoSvc, idIncidenciaTipo)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un IncidenciaTipo con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idIncidenciaTipo">ID de IncidenciaTipo que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As UserSession, ByVal idIncidenciaTipo As Integer) As Boolean
		Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
		Return Exists(IncidenciaTipoSvc, idIncidenciaTipo)
    End Function

    ''' <summary>
    ''' Verifica si existe un IncidenciaTipo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As UserSession, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
        Return Exists(IncidenciaTipoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un IncidenciaTipo.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idIncidenciaTipo">Identificador de IncidenciaTipo a consultar</param>
    ''' <returns>Paquete de información de tipo IncidenciaTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As UserSession, ByVal idIncidenciaTipo As Integer) As IncidenciaTipoInfo
        Return Me.GetDetail(session, idIncidenciaTipo, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un IncidenciaTipo.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idIncidenciaTipo">Identificador de IncidenciaTipo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del IncidenciaTipo.</param>
    ''' <returns>Paquete de información de tipo IncidenciaTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As UserSession, ByVal idIncidenciaTipo As Integer, checkStatus As Boolean) As IncidenciaTipoInfo
   		Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
        Dim IncidenciaTipoInf As New IncidenciaTipoInfo(session)
		GetDetail(IncidenciaTipoSvc, IncidenciaTipoInf, idIncidenciaTipo, checkStatus)
        Return IncidenciaTipoInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un IncidenciaTipo en base a su codigo de usuario
    ''' y verifica que el IncidenciaTipo esté activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información IncidenciaTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As UserSession, ByVal userCode As String, ByVal idSucursal As Integer) As IncidenciaTipoInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un IncidenciaTipo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del IncidenciaTipo</param>
    ''' <returns>Paquete de información IncidenciaTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As UserSession, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As IncidenciaTipoInfo
        Dim IncidenciaTipoInf As New IncidenciaTipoInfo(session)
        Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
        GetDetail(IncidenciaTipoSvc, IncidenciaTipoInf, userCode, idSucursal, checkStatus)
        Return IncidenciaTipoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un IncidenciaTipo.
    ''' </summary>
    ''' <param name="IncidenciaTipo">Paquete de información del tipo IncidenciaTipoInfo con la información a actualizar</param>
    ''' <returns>Identificador de IncidenciaTipo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal IncidenciaTipo As IncidenciaTipoInfo) As Integer
    	Dim IncidenciaTipoSvc As New IncidenciaTipoService(IncidenciaTipo.session)
		Return Update(IncidenciaTipoSvc, IncidenciaTipo)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As UserSession, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
    	Return GetNumberOfPages(IncidenciaTipoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca IncidenciasTipos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As UserSession, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(session, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca IncidenciasTipos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As UserSession, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
    	Return GetSearchResult(IncidenciaTipoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de IncidenciasTipos.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As UserSession) As System.Data.DataSet
    	Dim IncidenciaTipoSvc As New IncidenciaTipoService(session)
    	Return GetSearchStructure(IncidenciaTipoSvc)
    End Function

#End Region

End Class
