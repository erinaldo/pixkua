''' <summary>
''' Paquete de información que representa un Talla
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class TallaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property Abreviatura As String

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
''' Proveedor de servicios para el manejo del catálogo de Tallas
''' </summary>
''' <remarks></remarks>
Public Class TallaService
	Inherits CatalogService(Of TallaInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory","Tallas", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idTalla As Integer, ByRef Talla As TallaInfo, checkStatus As Boolean)
		MyBase.GetDetail(idTalla, Talla, checkStatus)
        With Talla
			.Nombre = CStr(ItemInfo("Nombre"))
			.Abreviatura = CStr(ItemInfo("Abreviatura"))
			.Referencia = CStr(ItemInfo("Referencia"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal Talla As TallaInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = Talla.Nombre
			.Add("@Abreviatura", DbType.String).Value = Talla.Abreviatura
			.Add("@Referencia", DbType.String).Value = Talla.Referencia
			.Add("@IdCuenta", DbType.Int32).Value = Talla.IdCuenta

		End With
		Return MyBase.Update(Talla)
	End Function
	
	Public Overrides Function Create() As TallaInfo
		Return New TallaInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Tallas
''' </summary>
''' <remarks></remarks>
Public Class TallaFacade
	Inherits CatalogFacade(Of TallaInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un TallaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As TallaInfo
		Dim TallaSvc As New TallaService(sessionID)
		Return TallaSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Tallas
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTalla">Identificador del Talla que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idTalla As Integer)
		Dim TallaSvc As New TallaService(sessionID)
		Delete(TallaSvc, idTalla)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Talla con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTalla">ID de Talla que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idTalla As Integer) As Boolean
		Dim TallaSvc As New TallaService(sessionID)
		Return Exists(TallaSvc, idTalla)
    End Function

    ''' <summary>
    ''' Verifica si existe un Talla con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim TallaSvc As New TallaService(sessionID)
        Return Exists(TallaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Talla.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTalla">Identificador de Talla a consultar</param>
    ''' <returns>Paquete de información de tipo TallaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTalla As Integer) As TallaInfo
        Return Me.GetDetail(sessionID, idTalla, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Talla.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTalla">Identificador de Talla</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Talla.</param>
    ''' <returns>Paquete de información de tipo TallaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTalla As Integer, checkStatus As Boolean) As TallaInfo
   		Dim TallaSvc As New TallaService(sessionID)
        Dim TallaInf As New TallaInfo(sessionID)
		GetDetail(TallaSvc, TallaInf, idTalla, checkStatus)
        Return TallaInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un Talla en base a su codigo de usuario
    ''' y verifica que el Talla esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información TallaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As TallaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Talla en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Talla</param>
    ''' <returns>Paquete de información TallaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As TallaInfo
        Dim TallaInf As New TallaInfo(sessionID)
        Dim TallaSvc As New TallaService(sessionID)
        GetDetail(TallaSvc, TallaInf, userCode, idSucursal, checkStatus)
        Return TallaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Talla.
    ''' </summary>
    ''' <param name="Talla">Paquete de información del tipo TallaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Talla, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Talla As TallaInfo) As Integer
    	Dim TallaSvc As New TallaService(Talla.sessionID)
		Return Update(TallaSvc, Talla)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim TallaSvc As New TallaService(sessionID)
    	Return GetNumberOfPages(TallaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Tallas que coincidan con las condiciones especificadas.
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
    ''' Busca Tallas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim TallaSvc As New TallaService(sessionID)
    	Return GetSearchResult(TallaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Tallas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim TallaSvc As New TallaService(sessionID)
    	Return GetSearchStructure(TallaSvc)
    End Function

#End Region

End Class
