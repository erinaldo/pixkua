Imports Azteca.Kernel.BusinessStructure
Imports Azteca.Kernel.Search

''' <summary>
''' Paquete de informaci�n que representa un Sala
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class SalaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property TiempoAtencion As Integer


#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        Status = CatalogState.Active
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Salas
''' </summary>
''' <remarks></remarks>
Public Class SalaService
	Inherits CatalogService(Of SalaInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Medicine","Salas", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idSala As Integer, ByRef Sala As SalaInfo, checkStatus As Boolean)
		MyBase.GetDetail(idSala, Sala, checkStatus)
        With Sala
			.Nombre = CStr(ItemInfo("Nombre"))
			.TiempoAtencion = CInt(ItemInfo("TiempoAtencion"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal Sala As SalaInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = Sala.Nombre
			.Add("@TiempoAtencion", DbType.Int32).Value = Sala.TiempoAtencion

		End With
		Return MyBase.Update(Sala)
	End Function
	
	Public Overrides Function Create() As SalaInfo
		Return New SalaInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Salas
''' </summary>
''' <remarks></remarks>
Public Class SalaFacade
	Inherits CatalogFacade(Of SalaInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un SalaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As SalaInfo
		Dim SalaSvc As New SalaService(sessionID)
		Return SalaSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del cat�logo de Salas
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idSala">Identificador del Sala que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idSala As Integer)
		Dim SalaSvc As New SalaService(sessionID)
		Delete(SalaSvc, idSala)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Sala con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idSala">ID de Sala que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idSala As Integer) As Boolean
		Dim SalaSvc As New SalaService(sessionID)
		Return Exists(SalaSvc, idSala)
    End Function

    ''' <summary>
    ''' Verifica si existe un Sala con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim SalaSvc As New SalaService(sessionID)
        Return Exists(SalaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Sala.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idSala">Identificador de Sala a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo SalaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idSala As Integer) As SalaInfo
        Return Me.GetDetail(sessionID, idSala, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Sala.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idSala">Identificador de Sala</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Sala.</param>
    ''' <returns>Paquete de informaci�n de tipo SalaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idSala As Integer, checkStatus As Boolean) As SalaInfo
   		Dim SalaSvc As New SalaService(sessionID)
        Dim SalaInf As New SalaInfo(sessionID)
		GetDetail(SalaSvc, SalaInf, idSala, checkStatus)
        Return SalaInf        
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Sala en base a su codigo de usuario
    ''' y verifica que el Sala est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n SalaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As SalaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Sala en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Sala</param>
    ''' <returns>Paquete de informaci�n SalaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As SalaInfo
        Dim SalaInf As New SalaInfo(sessionID)
        Dim SalaSvc As New SalaService(sessionID)
        GetDetail(SalaSvc, SalaInf, userCode, idSucursal, checkStatus)
        Return SalaInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Sala.
    ''' </summary>
    ''' <param name="Sala">Paquete de informaci�n del tipo SalaInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Sala, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Sala As SalaInfo) As Integer
    	Dim SalaSvc As New SalaService(Sala.sessionID)
		Return Update(SalaSvc, Sala)
    End Function
	
    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim SalaSvc As New SalaService(sessionID)
    	Return GetNumberOfPages(SalaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Salas que coincidan con las condiciones especificadas.
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
    ''' Busca Salas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim SalaSvc As New SalaService(sessionID)
    	Return GetSearchResult(SalaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Salas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim SalaSvc As New SalaService(sessionID)
    	Return GetSearchStructure(SalaSvc)
    End Function

#End Region

End Class
