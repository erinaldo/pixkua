''' <summary>
''' Paquete de información que representa un Pasillo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class PasilloInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdAlmacen As Integer

    Public Property IdCuenta As Integer

    Public Property IdImpresora As Integer

#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Pasillos
''' </summary>
''' <remarks></remarks>
Public Class PasilloService
	Inherits CatalogService(Of PasilloInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory","Pasillos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idPasillo As Integer, ByRef Pasillo As PasilloInfo, checkStatus As Boolean)
		MyBase.GetDetail(idPasillo, Pasillo, checkStatus)
        With Pasillo
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdAlmacen = CInt(ItemInfo("IdAlmacen"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))
			.IdImpresora = CInt(ItemInfo("IdImpresora"))
        End With
	End Sub
	
	Public Overrides Function Update(ByVal Pasillo As PasilloInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Pasillo.Nombre
            .Add("@IdAlmacen", DbType.Int32).Value = Pasillo.IdAlmacen
			.Add("@IdCuenta", DbType.Int32).Value = Pasillo.IdCuenta
            .Add("@IdImpresora", DbType.Int32).Value = Pasillo.IdImpresora
		End With
		Return MyBase.Update(Pasillo)
	End Function
	
	Public Overrides Function Create() As PasilloInfo
		Return New PasilloInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Pasillos
''' </summary>
''' <remarks></remarks>
Public Class PasilloFacade
	Inherits CatalogFacade(Of PasilloInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un PasilloInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As PasilloInfo
		Dim PasilloSvc As New PasilloService(sessionID)
		Return PasilloSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Pasillos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPasillo">Identificador del Pasillo que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idPasillo As Integer)
		Dim PasilloSvc As New PasilloService(sessionID)
		Delete(PasilloSvc, idPasillo)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Pasillo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPasillo">ID de Pasillo que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idPasillo As Integer) As Boolean
		Dim PasilloSvc As New PasilloService(sessionID)
		Return Exists(PasilloSvc, idPasillo)
    End Function

    ''' <summary>
    ''' Verifica si existe un Pasillo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim PasilloSvc As New PasilloService(sessionID)
        Return Exists(PasilloSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Pasillo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPasillo">Identificador de Pasillo a consultar</param>
    ''' <returns>Paquete de información de tipo PasilloInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPasillo As Integer) As PasilloInfo
        Return Me.GetDetail(sessionID, idPasillo, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Pasillo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPasillo">Identificador de Pasillo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Pasillo.</param>
    ''' <returns>Paquete de información de tipo PasilloInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPasillo As Integer, checkStatus As Boolean) As PasilloInfo
   		Dim PasilloSvc As New PasilloService(sessionID)
        Dim PasilloInf As New PasilloInfo(sessionID)
		GetDetail(PasilloSvc, PasilloInf, idPasillo, checkStatus)
        Return PasilloInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un Pasillo en base a su codigo de usuario
    ''' y verifica que el Pasillo esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información PasilloInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As PasilloInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Pasillo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Pasillo</param>
    ''' <returns>Paquete de información PasilloInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As PasilloInfo
        Dim PasilloInf As New PasilloInfo(sessionID)
        Dim PasilloSvc As New PasilloService(sessionID)
        GetDetail(PasilloSvc, PasilloInf, userCode, idSucursal, checkStatus)
        Return PasilloInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Pasillo.
    ''' </summary>
    ''' <param name="Pasillo">Paquete de información del tipo PasilloInfo con la información a actualizar</param>
    ''' <returns>Identificador de Pasillo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Pasillo As PasilloInfo) As Integer
    	Dim PasilloSvc As New PasilloService(Pasillo.sessionID)
		Return Update(PasilloSvc, Pasillo)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim PasilloSvc As New PasilloService(sessionID)
    	Return GetNumberOfPages(PasilloSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Pasillos que coincidan con las condiciones especificadas.
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
    ''' Busca Pasillos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim PasilloSvc As New PasilloService(sessionID)
    	Return GetSearchResult(PasilloSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Pasillos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim PasilloSvc As New PasilloService(sessionID)
    	Return GetSearchStructure(PasilloSvc)
    End Function

#End Region

End Class
