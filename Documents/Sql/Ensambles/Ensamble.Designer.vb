''' <summary>
''' Paquete de informaci�n que representa un Ensamble
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class EnsambleInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
	Public Property Nombre As String	Public Property IdRecepcionUM As Integer	Public Property IdEntregaUM As Integer	Public Property IdCuenta As Integer	Public Property IdEmpresa As Integer
#End Region
	
#Region "Constructor"
	Public Sub New(ByVal session As UserSession)
		MyBase.New(session)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Ensambles
''' </summary>
''' <remarks></remarks>
Public Class EnsambleService
	Inherits CatalogService(Of EnsambleInfo)
	
#Region "Constructores"
	Public Sub New(ByVal session As UserSession)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As UserSession, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As UserSession, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Production","Ensambles", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idEnsamble As Integer, ByRef Ensamble As EnsambleInfo, checkStatus As Boolean)
		MyBase.GetDetail(idEnsamble, Ensamble, checkStatus)
        With Ensamble
			.Nombre = CStr(Me.ItemInfo("Nombre"))
			.IdRecepcionUM = CInt(Me.ItemInfo("IdRecepcionUM"))
			.IdEntregaUM = CInt(Me.ItemInfo("IdEntregaUM"))
			.IdCuenta = CInt(Me.ItemInfo("IdCuenta"))
			.IdEmpresa = CInt(Me.ItemInfo("IdEmpresa"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal Ensamble As EnsambleInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = Ensamble.Nombre
			.Add("@IdRecepcionUM", DbType.Int32).Value = Ensamble.IdRecepcionUM
			.Add("@IdEntregaUM", DbType.Int32).Value = Ensamble.IdEntregaUM
			.Add("@IdCuenta", DbType.Int32).Value = Ensamble.IdCuenta
			.Add("@IdEmpresa", DbType.Int32).Value = Ensamble.IdEmpresa

		End With
		Return MyBase.Update(Ensamble)
	End Function
	
	Public Overrides Function Create() As EnsambleInfo
		Return New EnsambleInfo(Session)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Ensambles
''' </summary>
''' <remarks></remarks>
Public Class EnsambleFacade
	Inherits CatalogFacade(Of EnsambleInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un EnsambleInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal session As UserSession) As EnsambleInfo
		Dim EnsambleSvc As New EnsambleService(session)
		Return EnsambleSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del cat�logo de Ensambles
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idEnsamble">Identificador del Ensamble que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As UserSession, ByVal idEnsamble As Integer)
		Dim EnsambleSvc As New EnsambleService(session)
		Delete(EnsambleSvc, idEnsamble)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Ensamble con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idEnsamble">ID de Ensamble que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As UserSession, ByVal idEnsamble As Integer) As Boolean
		Dim EnsambleSvc As New EnsambleService(session)
		Return Exists(EnsambleSvc, idEnsamble)
    End Function

    ''' <summary>
    ''' Verifica si existe un Ensamble con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As UserSession, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim EnsambleSvc As New EnsambleService(session)
        Return Exists(EnsambleSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Ensamble.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idEnsamble">Identificador de Ensamble a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo EnsambleInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As UserSession, ByVal idEnsamble As Integer) As EnsambleInfo
        Return Me.GetDetail(session, idEnsamble, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Ensamble.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idEnsamble">Identificador de Ensamble</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Ensamble.</param>
    ''' <returns>Paquete de informaci�n de tipo EnsambleInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As UserSession, ByVal idEnsamble As Integer, checkStatus As Boolean) As EnsambleInfo
   		Dim EnsambleSvc As New EnsambleService(session)
        Dim EnsambleInf As New EnsambleInfo(session)
		GetDetail(EnsambleSvc, EnsambleInf, idEnsamble, checkStatus)
        Return EnsambleInf        
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Ensamble en base a su codigo de usuario
    ''' y verifica que el Ensamble est� activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n EnsambleInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As UserSession, ByVal userCode As String, ByVal idSucursal As Integer) As EnsambleInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Ensamble en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Ensamble</param>
    ''' <returns>Paquete de informaci�n EnsambleInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As UserSession, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As EnsambleInfo
        Dim EnsambleInf As New EnsambleInfo(session)
        Dim EnsambleSvc As New EnsambleService(session)
        GetDetail(EnsambleSvc, EnsambleInf, userCode, idSucursal, checkStatus)
        Return EnsambleInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Ensamble.
    ''' </summary>
    ''' <param name="Ensamble">Paquete de informaci�n del tipo EnsambleInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Ensamble, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Ensamble As EnsambleInfo) As Integer
    	Dim EnsambleSvc As New EnsambleService(Ensamble.session)
		Return Update(EnsambleSvc, Ensamble)
    End Function
	
    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As UserSession, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim EnsambleSvc As New EnsambleService(session)
    	Return GetNumberOfPages(EnsambleSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Ensambles que coincidan con las condiciones especificadas.
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
    ''' Busca Ensambles que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As UserSession, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim EnsambleSvc As New EnsambleService(session)
    	Return GetSearchResult(EnsambleSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Ensambles.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As UserSession) As System.Data.DataSet
    	Dim EnsambleSvc As New EnsambleService(session)
    	Return GetSearchStructure(EnsambleSvc)
    End Function

#End Region

End Class
