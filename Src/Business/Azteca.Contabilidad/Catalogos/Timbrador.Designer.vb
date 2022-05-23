''' <summary>
''' Paquete de informaci�n que representa un Timbrador
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class TimbradorInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property Clase As String

    Public Property Ensamblado As String

    Public Property Usuario As String

    Public Property Password As String


#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Timbradores
''' </summary>
''' <remarks></remarks>
Public Class TimbradorService
	Inherits CatalogService(Of TimbradorInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting","Timbradores", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idTimbrador As Integer, ByRef Timbrador As TimbradorInfo, checkStatus As Boolean)
		MyBase.GetDetail(idTimbrador, Timbrador, checkStatus)
        With Timbrador
			.Nombre = CStr(ItemInfo("Nombre"))
			.Clase = CStr(ItemInfo("Clase"))
			.Ensamblado = CStr(ItemInfo("Ensamblado"))
			.Usuario = CStr(ItemInfo("Usuario"))
			.Password = CStr(ItemInfo("Password"))
		End With
	End Sub
	
	Public Overrides Function Update(ByVal Timbrador As TimbradorInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = Timbrador.Nombre
			.Add("@Clase", DbType.String).Value = Timbrador.Clase
			.Add("@Ensamblado", DbType.String).Value = Timbrador.Ensamblado
			.Add("@Usuario", DbType.String).Value = Timbrador.Usuario
			.Add("@Password", DbType.String).Value = Timbrador.Password
		End With
		Return MyBase.Update(Timbrador)
	End Function
	
	Public Overrides Function Create() As TimbradorInfo
		Return New TimbradorInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Timbradores
''' </summary>
''' <remarks></remarks>
Public Class TimbradorFacade
	Inherits CatalogFacade(Of TimbradorInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un TimbradorInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As TimbradorInfo
		Dim TimbradorSvc As New TimbradorService(sessionID)
		Return TimbradorSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del cat�logo de Timbradores
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTimbrador">Identificador del Timbrador que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idTimbrador As Integer)
		Dim TimbradorSvc As New TimbradorService(sessionID)
		Delete(TimbradorSvc, idTimbrador)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Timbrador con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTimbrador">ID de Timbrador que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idTimbrador As Integer) As Boolean
		Dim TimbradorSvc As New TimbradorService(sessionID)
		Return Exists(TimbradorSvc, idTimbrador)
    End Function

    ''' <summary>
    ''' Verifica si existe un Timbrador con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim TimbradorSvc As New TimbradorService(sessionID)
        Return Exists(TimbradorSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Timbrador.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTimbrador">Identificador de Timbrador a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo TimbradorInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTimbrador As Integer) As TimbradorInfo
        Return Me.GetDetail(sessionID, idTimbrador, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Timbrador.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTimbrador">Identificador de Timbrador</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Timbrador.</param>
    ''' <returns>Paquete de informaci�n de tipo TimbradorInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTimbrador As Integer, checkStatus As Boolean) As TimbradorInfo
   		Dim TimbradorSvc As New TimbradorService(sessionID)
        Dim TimbradorInf As New TimbradorInfo(sessionID)
		GetDetail(TimbradorSvc, TimbradorInf, idTimbrador, checkStatus)
        Return TimbradorInf        
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Timbrador en base a su codigo de usuario
    ''' y verifica que el Timbrador est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n TimbradorInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As TimbradorInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Timbrador en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Timbrador</param>
    ''' <returns>Paquete de informaci�n TimbradorInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As TimbradorInfo
        Dim TimbradorInf As New TimbradorInfo(sessionID)
        Dim TimbradorSvc As New TimbradorService(sessionID)
        GetDetail(TimbradorSvc, TimbradorInf, userCode, idSucursal, checkStatus)
        Return TimbradorInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Timbrador.
    ''' </summary>
    ''' <param name="Timbrador">Paquete de informaci�n del tipo TimbradorInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Timbrador, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Timbrador As TimbradorInfo) As Integer
    	Dim TimbradorSvc As New TimbradorService(Timbrador.sessionID)
		Return Update(TimbradorSvc, Timbrador)
    End Function
	
    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim TimbradorSvc As New TimbradorService(sessionID)
    	Return GetNumberOfPages(TimbradorSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Timbradores que coincidan con las condiciones especificadas.
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
    ''' Busca Timbradores que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim TimbradorSvc As New TimbradorService(sessionID)
    	Return GetSearchResult(TimbradorSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Timbradores.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim TimbradorSvc As New TimbradorService(sessionID)
    	Return GetSearchStructure(TimbradorSvc)
    End Function

#End Region

End Class
