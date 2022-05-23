
Imports Azteca.Kernel
''' <summary>
''' Paquete de información que representa un Sacerdote
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class SacerdoteInfo
    Inherits CatalogInfo
#Region "Campos Privados"
    Private _Persona As PersonaInfo
#End Region

#Region "Propiedades"

    Public ReadOnly Property Persona As PersonaInfo
        Get
            Return _Persona
        End Get
    End Property

    Public Property IdPersona As Integer

    Public Property NombreCorto As String

    Public Property Genero As String

    Public Property Titulo As String

    Public Property FechaIngreso As Date

    Public Property FechaNacimiento As Date

    Public Property NSS As String

    Public Property RFC As String

    Public Property CURP As String

    Public Property TipoSacerdote As String



#End Region

#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
        _Persona = New PersonaInfo(SessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Sacerdotes
''' </summary>
''' <remarks></remarks>
Public Class SacerdoteService
	Inherits CatalogService(Of SacerdoteInfo)
	
#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Church", "Sacerdotes", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idSacerdote As Integer, ByRef Sacerdote As SacerdoteInfo, checkStatus As Boolean)
		MyBase.GetDetail(idSacerdote, Sacerdote, checkStatus)
        With Sacerdote
			.IdPersona = CInt(ItemInfo("IdPersona"))
			.NombreCorto = CStr(ItemInfo("NombreCorto"))
			.Genero = CStr(ItemInfo("Genero"))
			.Titulo = CStr(ItemInfo("Titulo"))
			.FechaIngreso = CDate(ItemInfo("FechaIngreso"))
			.FechaNacimiento = CDate(ItemInfo("FechaNacimiento"))
			.NSS = CStr(ItemInfo("NSS"))
			.RFC = CStr(ItemInfo("RFC"))
			.CURP = CStr(ItemInfo("CURP"))

            'Cargar Informacion de la Persona
            Dim PersonaSvc As New PersonaService(SessionID, Connection, Transaction)
            PersonaSvc.GetDetail(.IdPersona, .Persona, False)
		End With
	End Sub
	
    Public Overrides Function Update(ByVal Sacerdote As SacerdoteInfo) As Integer
        Dim PersonaSvc As New PersonaService(SessionID, Connection, Transaction)
        Sacerdote.IdPersona = PersonaSvc.Update(Sacerdote.Persona)

        With Me.SPUpdate.Parameters
            .Add("@IdPersona", DbType.Int32).Value = Sacerdote.IdPersona
            .Add("@NombreCorto", DbType.String).Value = Sacerdote.NombreCorto
            .Add("@Genero", DbType.String).Value = Sacerdote.Genero
            .Add("@Titulo", DbType.String).Value = Sacerdote.Titulo
            .Add("@FechaIngreso", DbType.DateTime).Value = Sacerdote.FechaIngreso
            .Add("@FechaNacimiento", DbType.DateTime).Value = Sacerdote.FechaNacimiento
            .Add("@NSS", DbType.String).Value = Sacerdote.NSS
            .Add("@RFC", DbType.String).Value = Sacerdote.RFC
            .Add("@CURP", DbType.String).Value = Sacerdote.CURP

        End With
        Return MyBase.Update(Sacerdote)
    End Function
	
	Public Overrides Function Create() As SacerdoteInfo
        Return New SacerdoteInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Sacerdotes
''' </summary>
''' <remarks></remarks>
Public Class SacerdoteFacade
	Inherits CatalogFacade(Of SacerdoteInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un SacerdoteInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As SacerdoteInfo
        Dim SacerdoteSvc As New SacerdoteService(session)
        Return SacerdoteSvc.Create()
    End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Sacerdotes
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idSacerdote">Identificador del Sacerdote que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idSacerdote As Integer)
        Dim SacerdoteSvc As New SacerdoteService(session)
        Delete(SacerdoteSvc, idSacerdote)
    End Sub
	
    ''' <summary>
    ''' Verifica si existe un Sacerdote con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idSacerdote">ID de Sacerdote que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idSacerdote As Integer) As Boolean
        Dim SacerdoteSvc As New SacerdoteService(session)
        Return Exists(SacerdoteSvc, idSacerdote)
    End Function

    ''' <summary>
    ''' Verifica si existe un Sacerdote con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim SacerdoteSvc As New SacerdoteService(session)
        Return Exists(SacerdoteSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Sacerdote.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idSacerdote">Identificador de Sacerdote a consultar</param>
    ''' <returns>Paquete de información de tipo SacerdoteInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idSacerdote As Integer) As SacerdoteInfo
        Return Me.GetDetail(session, idSacerdote, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Sacerdote.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idSacerdote">Identificador de Sacerdote</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Sacerdote.</param>
    ''' <returns>Paquete de información de tipo SacerdoteInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idSacerdote As Integer, checkStatus As Boolean) As SacerdoteInfo
        Dim SacerdoteSvc As New SacerdoteService(session)
        Dim SacerdoteInf As New SacerdoteInfo(session)
        GetDetail(SacerdoteSvc, SacerdoteInf, idSacerdote, checkStatus)
        Return SacerdoteInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Sacerdote en base a su codigo de usuario
    ''' y verifica que el Sacerdote esté activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información SacerdoteInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As SacerdoteInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Sacerdote en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Sacerdote</param>
    ''' <returns>Paquete de información SacerdoteInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As SacerdoteInfo
        Dim SacerdoteInf As New SacerdoteInfo(session)
        Dim SacerdoteSvc As New SacerdoteService(session)
        GetDetail(SacerdoteSvc, SacerdoteInf, userCode, idSucursal, checkStatus)
        Return SacerdoteInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Sacerdote.
    ''' </summary>
    ''' <param name="Sacerdote">Paquete de información del tipo SacerdoteInfo con la información a actualizar</param>
    ''' <returns>Identificador de Sacerdote, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Sacerdote As SacerdoteInfo) As Integer
        Dim SacerdoteSvc As New SacerdoteService(Sacerdote.SessionID)
		Return Update(SacerdoteSvc, Sacerdote)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim SacerdoteSvc As New SacerdoteService(session)
        Return GetNumberOfPages(SacerdoteSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Sacerdotes que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(session, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Sacerdotes que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim SacerdoteSvc As New SacerdoteService(session)
        Return GetSearchResult(SacerdoteSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Sacerdotes.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim SacerdoteSvc As New SacerdoteService(session)
        Return GetSearchStructure(SacerdoteSvc)
    End Function

#End Region

End Class
