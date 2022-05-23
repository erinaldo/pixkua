Imports Azteca.Kernel.BusinessStructure
Imports Azteca.Kernel.Search

''' <summary>
''' Paquete de información que representa un Doctor
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class DoctorInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String = String.Empty

    Public Property Calle As String = String.Empty

    Public Property NumExt As String = String.Empty

    Public Property NumInt As String = String.Empty

    Public Property Colonia As String = String.Empty

    Public Property CP As String = String.Empty

    Public Property IdPoblacion As Integer

    Public Property Telefono As String = String.Empty

    Public Property TelCasa As String = String.Empty

    Public Property Celular As String = String.Empty

    Public Property Correo As String = String.Empty

    Public Property IdEspecialidad As Integer

    Public Property RFC As String = String.Empty

    Public Property Cedula As String = String.Empty

    Public Property IdUsuario As Integer

#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Doctores
''' </summary>
''' <remarks></remarks>
Public Class DoctorService
	Inherits CatalogService(Of DoctorInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Medicine","Doctores", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idDoctor As Integer, ByRef Doctor As DoctorInfo, checkStatus As Boolean)
		MyBase.GetDetail(idDoctor, Doctor, checkStatus)
        With Doctor
			.Nombre = CStr(ItemInfo("Nombre"))
			.Calle = CStr(ItemInfo("Calle"))
			.NumExt = CStr(ItemInfo("NumExt"))
			.NumInt = CStr(ItemInfo("NumInt"))
			.Colonia = CStr(ItemInfo("Colonia"))
			.CP = CStr(ItemInfo("CP"))
			.IdPoblacion = CInt(ItemInfo("IdPoblacion"))
			.Telefono = CStr(ItemInfo("Telefono"))
			.TelCasa = CStr(ItemInfo("TelCasa"))
			.Celular = CStr(ItemInfo("Celular"))
			.Correo = CStr(ItemInfo("Correo"))
			.IdEspecialidad = CInt(ItemInfo("IdEspecialidad"))
			.RFC = CStr(ItemInfo("RFC"))
			.Cedula = CStr(ItemInfo("Cedula"))
            .IdUsuario = CInt(ItemInfo("IdUsuario"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal Doctor As DoctorInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = Doctor.Nombre
			.Add("@Calle", DbType.String).Value = Doctor.Calle
			.Add("@NumExt", DbType.String).Value = Doctor.NumExt
			.Add("@NumInt", DbType.String).Value = Doctor.NumInt
			.Add("@Colonia", DbType.String).Value = Doctor.Colonia
			.Add("@CP", DbType.String).Value = Doctor.CP
			.Add("@IdPoblacion", DbType.Int32).Value = Doctor.IdPoblacion
			.Add("@Telefono", DbType.String).Value = Doctor.Telefono
			.Add("@TelCasa", DbType.String).Value = Doctor.TelCasa
			.Add("@Celular", DbType.String).Value = Doctor.Celular
			.Add("@Correo", DbType.String).Value = Doctor.Correo
			.Add("@IdEspecialidad", DbType.Int32).Value = Doctor.IdEspecialidad
			.Add("@RFC", DbType.String).Value = Doctor.RFC
			.Add("@Cedula", DbType.String).Value = Doctor.Cedula
            .Add("@IdUsuario", DbType.Int32).Value = Doctor.IdUsuario
		End With
		Return MyBase.Update(Doctor)
	End Function
	
	Public Overrides Function Create() As DoctorInfo
		Return New DoctorInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Doctores
''' </summary>
''' <remarks></remarks>
Public Class DoctorFacade
	Inherits CatalogFacade(Of DoctorInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un DoctorInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As DoctorInfo
		Dim DoctorSvc As New DoctorService(sessionID)
		Return DoctorSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Doctores
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDoctor">Identificador del Doctor que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idDoctor As Integer)
		Dim DoctorSvc As New DoctorService(sessionID)
		Delete(DoctorSvc, idDoctor)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Doctor con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDoctor">ID de Doctor que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idDoctor As Integer) As Boolean
		Dim DoctorSvc As New DoctorService(sessionID)
		Return Exists(DoctorSvc, idDoctor)
    End Function

    ''' <summary>
    ''' Verifica si existe un Doctor con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim DoctorSvc As New DoctorService(sessionID)
        Return Exists(DoctorSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Doctor.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDoctor">Identificador de Doctor a consultar</param>
    ''' <returns>Paquete de información de tipo DoctorInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idDoctor As Integer) As DoctorInfo
        Return Me.GetDetail(sessionID, idDoctor, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Doctor.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDoctor">Identificador de Doctor</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Doctor.</param>
    ''' <returns>Paquete de información de tipo DoctorInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idDoctor As Integer, checkStatus As Boolean) As DoctorInfo
   		Dim DoctorSvc As New DoctorService(sessionID)
        Dim DoctorInf As New DoctorInfo(sessionID)
		GetDetail(DoctorSvc, DoctorInf, idDoctor, checkStatus)
        Return DoctorInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un Doctor en base a su codigo de usuario
    ''' y verifica que el Doctor esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información DoctorInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As DoctorInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Doctor en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Doctor</param>
    ''' <returns>Paquete de información DoctorInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As DoctorInfo
        Dim DoctorInf As New DoctorInfo(sessionID)
        Dim DoctorSvc As New DoctorService(sessionID)
        GetDetail(DoctorSvc, DoctorInf, userCode, idSucursal, checkStatus)
        Return DoctorInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Doctor.
    ''' </summary>
    ''' <param name="Doctor">Paquete de información del tipo DoctorInfo con la información a actualizar</param>
    ''' <returns>Identificador de Doctor, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Doctor As DoctorInfo) As Integer
    	Dim DoctorSvc As New DoctorService(Doctor.sessionID)
		Return Update(DoctorSvc, Doctor)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim DoctorSvc As New DoctorService(sessionID)
    	Return GetNumberOfPages(DoctorSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Doctores que coincidan con las condiciones especificadas.
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
    ''' Busca Doctores que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim DoctorSvc As New DoctorService(sessionID)
    	Return GetSearchResult(DoctorSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Doctores.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim DoctorSvc As New DoctorService(sessionID)
    	Return GetSearchStructure(DoctorSvc)
    End Function

#End Region

End Class
