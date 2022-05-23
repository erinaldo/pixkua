''' <summary>
''' Paquete de información que representa un Beneficiario
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class BeneficiarioInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property RazonSocial As String

    Public Property TipoBeneficiario As String

    Public Property IdReferencia As Integer

    Public Property IdBanco As Integer

    Public Property CLABE As String

    Public Property DiasCredito As Integer

    Public Property LeyendaCheque As Boolean

    Public Property IdCuenta As Integer


#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        TipoBeneficiario = "B"
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Beneficiarios
''' </summary>
''' <remarks></remarks>
Public Class BeneficiarioService
	Inherits CatalogService(Of BeneficiarioInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Treasury","Beneficiarios", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idBeneficiario As Integer, ByRef Beneficiario As BeneficiarioInfo, checkStatus As Boolean)
		MyBase.GetDetail(idBeneficiario, Beneficiario, checkStatus)
        With Beneficiario
			.RazonSocial = CStr(ItemInfo("RazonSocial"))
			.TipoBeneficiario = CStr(ItemInfo("TipoBeneficiario"))
			.IdReferencia = CInt(ItemInfo("IdReferencia"))
            .IdBanco = CInt(ItemInfo("IdBanco"))
            .DiasCredito = CInt(ItemInfo("DiasCredito"))
			.CLABE = CStr(ItemInfo("CLABE"))
			.LeyendaCheque = CBool(ItemInfo("LeyendaCheque"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal Beneficiario As BeneficiarioInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@RazonSocial", DbType.String).Value = Beneficiario.RazonSocial
			.Add("@TipoBeneficiario", DbType.String).Value = Beneficiario.TipoBeneficiario
			.Add("@IdReferencia", DbType.Int32).Value = Beneficiario.IdReferencia
			.Add("@IdBanco", DbType.Int32).Value = Beneficiario.IdBanco
			.Add("@CLABE", DbType.String).Value = Beneficiario.CLABE
            .Add("@LeyendaCheque", DbType.Boolean).Value = Beneficiario.LeyendaCheque
            .Add("@DiasCredito", DbType.Int32).Value = Beneficiario.DiasCredito
            .Add("@IdCuenta", DbType.Int32).Value = Beneficiario.IdCuenta
		End With
		Return MyBase.Update(Beneficiario)
	End Function
	
	Public Overrides Function Create() As BeneficiarioInfo
		Return New BeneficiarioInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Beneficiarios
''' </summary>
''' <remarks></remarks>
Public Class BeneficiarioFacade
	Inherits CatalogFacade(Of BeneficiarioInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un BeneficiarioInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As BeneficiarioInfo
		Dim BeneficiarioSvc As New BeneficiarioService(sessionID)
		Return BeneficiarioSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Beneficiarios
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idBeneficiario">Identificador del Beneficiario que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idBeneficiario As Integer)
		Dim BeneficiarioSvc As New BeneficiarioService(sessionID)
		Delete(BeneficiarioSvc, idBeneficiario)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Beneficiario con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idBeneficiario">ID de Beneficiario que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idBeneficiario As Integer) As Boolean
		Dim BeneficiarioSvc As New BeneficiarioService(sessionID)
		Return Exists(BeneficiarioSvc, idBeneficiario)
    End Function

    ''' <summary>
    ''' Verifica si existe un Beneficiario con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim BeneficiarioSvc As New BeneficiarioService(sessionID)
        Return Exists(BeneficiarioSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Beneficiario.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idBeneficiario">Identificador de Beneficiario a consultar</param>
    ''' <returns>Paquete de información de tipo BeneficiarioInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idBeneficiario As Integer) As BeneficiarioInfo
        Return Me.GetDetail(sessionID, idBeneficiario, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Beneficiario.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idBeneficiario">Identificador de Beneficiario</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Beneficiario.</param>
    ''' <returns>Paquete de información de tipo BeneficiarioInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idBeneficiario As Integer, checkStatus As Boolean) As BeneficiarioInfo
   		Dim BeneficiarioSvc As New BeneficiarioService(sessionID)
        Dim BeneficiarioInf As New BeneficiarioInfo(sessionID)
		GetDetail(BeneficiarioSvc, BeneficiarioInf, idBeneficiario, checkStatus)
        Return BeneficiarioInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un Beneficiario en base a su codigo de usuario
    ''' y verifica que el Beneficiario esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información BeneficiarioInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As BeneficiarioInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Beneficiario en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Beneficiario</param>
    ''' <returns>Paquete de información BeneficiarioInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As BeneficiarioInfo
        Dim BeneficiarioInf As New BeneficiarioInfo(sessionID)
        Dim BeneficiarioSvc As New BeneficiarioService(sessionID)
        GetDetail(BeneficiarioSvc, BeneficiarioInf, userCode, idSucursal, checkStatus)
        Return BeneficiarioInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Beneficiario.
    ''' </summary>
    ''' <param name="Beneficiario">Paquete de información del tipo BeneficiarioInfo con la información a actualizar</param>
    ''' <returns>Identificador de Beneficiario, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Beneficiario As BeneficiarioInfo) As Integer
    	Dim BeneficiarioSvc As New BeneficiarioService(Beneficiario.sessionID)
		Return Update(BeneficiarioSvc, Beneficiario)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim BeneficiarioSvc As New BeneficiarioService(sessionID)
    	Return GetNumberOfPages(BeneficiarioSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Beneficiarios que coincidan con las condiciones especificadas.
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
    ''' Busca Beneficiarios que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim BeneficiarioSvc As New BeneficiarioService(sessionID)
    	Return GetSearchResult(BeneficiarioSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Beneficiarios.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim BeneficiarioSvc As New BeneficiarioService(sessionID)
    	Return GetSearchStructure(BeneficiarioSvc)
    End Function

#End Region

End Class
