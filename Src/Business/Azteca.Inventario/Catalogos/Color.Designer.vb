''' <summary>
''' Paquete de informaci�n que representa un Color
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ColorInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property CodigoColor As String

    Public Property Referencia As String

    Public Property IdCuenta As Integer


#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Colores
''' </summary>
''' <remarks></remarks>
Public Class ColorService
	Inherits CatalogService(Of ColorInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory","Colores", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idColor As Integer, ByRef Color As ColorInfo, checkStatus As Boolean)
		MyBase.GetDetail(idColor, Color, checkStatus)
        With Color
			.Nombre = CStr(ItemInfo("Nombre"))
            .CodigoColor = ItemInfo("CodigoColor").ToString()
			.Referencia = CStr(ItemInfo("Referencia"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal Color As ColorInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = Color.Nombre
			.Add("@CodigoColor", DbType.String).Value = Color.CodigoColor
			.Add("@Referencia", DbType.String).Value = Color.Referencia
			.Add("@IdCuenta", DbType.Int32).Value = Color.IdCuenta

		End With
		Return MyBase.Update(Color)
	End Function
	
	Public Overrides Function Create() As ColorInfo
		Return New ColorInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Colores
''' </summary>
''' <remarks></remarks>
Public Class ColorFacade
	Inherits CatalogFacade(Of ColorInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ColorInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As ColorInfo
		Dim ColorSvc As New ColorService(sessionID)
		Return ColorSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del cat�logo de Colores
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idColor">Identificador del Color que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idColor As Integer)
		Dim ColorSvc As New ColorService(sessionID)
		Delete(ColorSvc, idColor)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Color con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idColor">ID de Color que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idColor As Integer) As Boolean
		Dim ColorSvc As New ColorService(sessionID)
		Return Exists(ColorSvc, idColor)
    End Function

    ''' <summary>
    ''' Verifica si existe un Color con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim ColorSvc As New ColorService(sessionID)
        Return Exists(ColorSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Color.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idColor">Identificador de Color a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo ColorInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idColor As Integer) As ColorInfo
        Return Me.GetDetail(sessionID, idColor, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Color.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idColor">Identificador de Color</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Color.</param>
    ''' <returns>Paquete de informaci�n de tipo ColorInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idColor As Integer, checkStatus As Boolean) As ColorInfo
   		Dim ColorSvc As New ColorService(sessionID)
        Dim ColorInf As New ColorInfo(sessionID)
		GetDetail(ColorSvc, ColorInf, idColor, checkStatus)
        Return ColorInf        
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Color en base a su codigo de usuario
    ''' y verifica que el Color est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n ColorInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ColorInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Color en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Color</param>
    ''' <returns>Paquete de informaci�n ColorInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ColorInfo
        Dim ColorInf As New ColorInfo(sessionID)
        Dim ColorSvc As New ColorService(sessionID)
        GetDetail(ColorSvc, ColorInf, userCode, idSucursal, checkStatus)
        Return ColorInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Color.
    ''' </summary>
    ''' <param name="Color">Paquete de informaci�n del tipo ColorInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Color, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Color As ColorInfo) As Integer
    	Dim ColorSvc As New ColorService(Color.sessionID)
		Return Update(ColorSvc, Color)
    End Function
	
    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim ColorSvc As New ColorService(sessionID)
    	Return GetNumberOfPages(ColorSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Colores que coincidan con las condiciones especificadas.
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
    ''' Busca Colores que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim ColorSvc As New ColorService(sessionID)
    	Return GetSearchResult(ColorSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Colores.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim ColorSvc As New ColorService(sessionID)
    	Return GetSearchStructure(ColorSvc)
    End Function

#End Region

End Class
