''' <summary>
''' Paquete de informaci�n que representa un Servicio
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ServicioInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Friend _CostoUltimo As Decimal
#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public ReadOnly Property CostoUltimo As Decimal
        Get
            Return _CostoUltimo
        End Get
    End Property


#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Servicios
''' </summary>
''' <remarks></remarks>
Public Class ServicioService
	Inherits CatalogService(Of ServicioInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing","Servicios", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idServicio As Integer, ByRef Servicio As ServicioInfo, checkStatus As Boolean)
		MyBase.GetDetail(idServicio, Servicio, checkStatus)
        With Servicio
			.Nombre = CStr(ItemInfo("Nombre"))
            ._CostoUltimo = CDec(ItemInfo("CostoUltimo"))
		End With
	End Sub
	
	Public Overrides Function Update(ByVal Servicio As ServicioInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = Servicio.Nombre
		End With
		Return MyBase.Update(Servicio)
	End Function
	
	Public Overrides Function Create() As ServicioInfo
		Return New ServicioInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Servicios
''' </summary>
''' <remarks></remarks>
Public Class ServicioFacade
	Inherits CatalogFacade(Of ServicioInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ServicioInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As ServicioInfo
		Dim ServicioSvc As New ServicioService(sessionID)
		Return ServicioSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del cat�logo de Servicios
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idServicio">Identificador del Servicio que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idServicio As Integer)
		Dim ServicioSvc As New ServicioService(sessionID)
		Delete(ServicioSvc, idServicio)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Servicio con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idServicio">ID de Servicio que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idServicio As Integer) As Boolean
		Dim ServicioSvc As New ServicioService(sessionID)
		Return Exists(ServicioSvc, idServicio)
    End Function

    ''' <summary>
    ''' Verifica si existe un Servicio con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim ServicioSvc As New ServicioService(sessionID)
        Return Exists(ServicioSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Servicio.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idServicio">Identificador de Servicio a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo ServicioInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idServicio As Integer) As ServicioInfo
        Return Me.GetDetail(sessionID, idServicio, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Servicio.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idServicio">Identificador de Servicio</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Servicio.</param>
    ''' <returns>Paquete de informaci�n de tipo ServicioInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idServicio As Integer, checkStatus As Boolean) As ServicioInfo
   		Dim ServicioSvc As New ServicioService(sessionID)
        Dim ServicioInf As New ServicioInfo(sessionID)
		GetDetail(ServicioSvc, ServicioInf, idServicio, checkStatus)
        Return ServicioInf        
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Servicio en base a su codigo de usuario
    ''' y verifica que el Servicio est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n ServicioInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ServicioInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Servicio en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Servicio</param>
    ''' <returns>Paquete de informaci�n ServicioInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ServicioInfo
        Dim ServicioInf As New ServicioInfo(sessionID)
        Dim ServicioSvc As New ServicioService(sessionID)
        GetDetail(ServicioSvc, ServicioInf, userCode, idSucursal, checkStatus)
        Return ServicioInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Servicio.
    ''' </summary>
    ''' <param name="Servicio">Paquete de informaci�n del tipo ServicioInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Servicio, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Servicio As ServicioInfo) As Integer
    	Dim ServicioSvc As New ServicioService(Servicio.sessionID)
		Return Update(ServicioSvc, Servicio)
    End Function
	
    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim ServicioSvc As New ServicioService(sessionID)
    	Return GetNumberOfPages(ServicioSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Servicios que coincidan con las condiciones especificadas.
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
    ''' Busca Servicios que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim ServicioSvc As New ServicioService(sessionID)
    	Return GetSearchResult(ServicioSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Servicios.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim ServicioSvc As New ServicioService(sessionID)
    	Return GetSearchStructure(ServicioSvc)
    End Function

#End Region

End Class
