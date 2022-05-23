''' <summary>
''' Paquete de información que representa un Solicitante
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class SolicitanteInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Private _Persona As Azteca.Kernel.General.PersonaInfo
#End Region

#Region "Propiedades"

    Public ReadOnly Property Persona As Azteca.Kernel.General.PersonaInfo
        Get
            Return _Persona
        End Get
    End Property

    Public Property IdPersona As Integer

    Public Property NombreCorto As String

    Public Property Genero As String

    Public Property FechaNacimiento As Date

    Public Property IdPoblacionNacimiento As Integer

    Public Property NombrePadre As String

    Public Property NombreMadre As String

    Public Property AbuelosPaternos As String

    Public Property AbuelosMaternos As String

    Public Property LugarNacimiento As String

    Public Property FechaAlta As Date

    Public Property FechaBautismo As Date

    Public Property LibroBautismo As String

    Public Property PaginaBautismo As String

    Public Property ActaBautismo As String

    Public Property Foto As Byte()

    Public Property IdBautismo As Integer
    Public Property ParroquiaBautismo As String
    Public Property CalleBautismo As String
    Public Property ColoniaBautismo As String
    Public Property CPBautismo As String
    Public Property NumExtBautismo As String
    Public Property NumIntBautismo As String
    Public Property IdPoblacionBautismo As Integer

#End Region

#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
        _Persona = New Azteca.Kernel.General.PersonaInfo(SessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Solicitantes
''' </summary>
''' <remarks></remarks>
Public Class SolicitanteService
    Inherits CatalogService(Of SolicitanteInfo)

#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Church", "Solicitantes", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idSolicitante As Integer, ByRef Solicitante As SolicitanteInfo, checkStatus As Boolean)
        MyBase.GetDetail(idSolicitante, Solicitante, checkStatus)
        With Solicitante
            .IdPersona = CInt(ItemInfo("IdPersona"))
            .NombreCorto = CStr(ItemInfo("NombreCorto"))
            .Genero = CStr(ItemInfo("Genero"))
            .FechaNacimiento = CDate(ItemInfo("FechaNacimiento"))
            .IdPoblacionNacimiento = CInt(ItemInfo("IdPoblacionNacimiento"))
            .NombrePadre = CStr(ItemInfo("NombrePadre"))
            .NombreMadre = CStr(ItemInfo("NombreMadre"))
            .AbuelosPaternos = CStr(ItemInfo("AbuelosPaternos"))
            .AbuelosMaternos = CStr(ItemInfo("AbuelosMaternos"))
            .LugarNacimiento = CStr(ItemInfo("LugarNacimiento"))
            .FechaAlta = CDate(ItemInfo("FechaAlta"))
            .FechaBautismo = CDate(ItemInfo("FechaBautismo"))
            .LibroBautismo = CStr(ItemInfo("LibroBautismo"))
            .PaginaBautismo = CStr(ItemInfo("PaginaBautismo"))
            .ActaBautismo = CStr(ItemInfo("ActaBautismo"))

            .IdBautismo = CInt(ItemInfo("IdBautismo"))
            .ParroquiaBautismo = CStr(ItemInfo("ParroquiaBautismo"))
            .CalleBautismo = CStr(ItemInfo("CalleBautismo"))
            .ColoniaBautismo = CStr(ItemInfo("ColoniaBautismo"))
            .CPBautismo = CStr(ItemInfo("CPBautismo"))
            .NumExtBautismo = CStr(ItemInfo("NumExtBautismo"))
            .NumIntBautismo = CStr(ItemInfo("NumIntBautismo"))
            .IdPoblacionBautismo = CInt(ItemInfo("IdPoblacionBautismo"))

            If Not IsDBNull(ItemInfo("Foto")) Then .Foto = CType(ItemInfo("Foto"), Byte())
            'Cargar información de la personas
            Dim IdPersona As Integer = CInt(ItemInfo("IdPersona"))
            Dim PersonaSvc As New Azteca.Kernel.General.PersonaService(SessionID, Me.Connection, Me.Transaction)
            PersonaSvc.GetDetail(IdPersona, .Persona, False)

        End With
    End Sub

    Public Overrides Function Update(ByVal Solicitante As SolicitanteInfo) As Integer
        Dim PersonaSvc As New Azteca.Kernel.General.PersonaService(Me.SessionID, Me.Connection, Me.Transaction)
        Solicitante.IdPersona = PersonaSvc.Update(Solicitante.Persona)

        With Me.SPUpdate.Parameters
            .Add("@IdPersona", DbType.Int32).Value = Solicitante.IdPersona
            .Add("@NombreCorto", DbType.String).Value = Solicitante.NombreCorto
            .Add("@Genero", DbType.String).Value = Solicitante.Genero
            .Add("@FechaNacimiento", DbType.DateTime).Value = Solicitante.FechaNacimiento
            .Add("@IdPoblacionNacimiento", DbType.Int32).Value = Solicitante.IdPoblacionNacimiento
            .Add("@NombrePadre", DbType.String).Value = Solicitante.NombrePadre
            .Add("@NombreMadre", DbType.String).Value = Solicitante.NombreMadre
            .Add("@AbuelosPaternos", DbType.String).Value = Solicitante.AbuelosPaternos
            .Add("@AbuelosMaternos", DbType.String).Value = Solicitante.AbuelosMaternos
            .Add("@LugarNacimiento", DbType.String).Value = Solicitante.LugarNacimiento
            .Add("@FechaAlta", DbType.DateTime).Value = Solicitante.FechaAlta
            .Add("@FechaBautismo", DbType.DateTime).Value = Solicitante.FechaBautismo
            .Add("@LibroBautismo", DbType.String).Value = Solicitante.LibroBautismo
            .Add("@PaginaBautismo", DbType.String).Value = Solicitante.PaginaBautismo
            .Add("@ActaBautismo", DbType.String).Value = Solicitante.ActaBautismo
            If Solicitante.Foto Is Nothing Then
                .Add("@Foto", DbType.Binary).Value = DBNull.Value
            Else
                .Add("@Foto", DbType.Binary).Value = Solicitante.Foto
            End If

            .Add("@IdBautismo", DbType.Int32).Value = Solicitante.IdBautismo
            .Add("@ParroquiaBautismo", DbType.String).Value = Solicitante.ParroquiaBautismo
            .Add("@CalleBautismo", DbType.String).Value = Solicitante.CalleBautismo
            .Add("@ColoniaBautismo", DbType.String).Value = Solicitante.ColoniaBautismo
            .Add("@CPBautismo", DbType.String).Value = Solicitante.CPBautismo
            .Add("@NumExtBautismo", DbType.String).Value = Solicitante.NumExtBautismo
            .Add("@NumIntBautismo", DbType.String).Value = Solicitante.NumIntBautismo
            .Add("@IdPoblacionBautismo", DbType.Int32).Value = Solicitante.IdPoblacionBautismo

        End With
        Return MyBase.Update(Solicitante)
    End Function

    Public Overrides Function Create() As SolicitanteInfo
        Return New SolicitanteInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Solicitantes
''' </summary>
''' <remarks></remarks>
Public Class SolicitanteFacade
    Inherits CatalogFacade(Of SolicitanteInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un SolicitanteInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As SolicitanteInfo
        Dim SolicitanteSvc As New SolicitanteService(session)
        Return SolicitanteSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Solicitantes
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idSolicitante">Identificador del Solicitante que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idSolicitante As Integer)
        Dim SolicitanteSvc As New SolicitanteService(session)
        Delete(SolicitanteSvc, idSolicitante)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Solicitante con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idSolicitante">ID de Solicitante que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idSolicitante As Integer) As Boolean
        Dim SolicitanteSvc As New SolicitanteService(session)
        Return Exists(SolicitanteSvc, idSolicitante)
    End Function

    ''' <summary>
    ''' Verifica si existe un Solicitante con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim SolicitanteSvc As New SolicitanteService(session)
        Return Exists(SolicitanteSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Solicitante.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idSolicitante">Identificador de Solicitante a consultar</param>
    ''' <returns>Paquete de información de tipo SolicitanteInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idSolicitante As Integer) As SolicitanteInfo
        Return Me.GetDetail(session, idSolicitante, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Solicitante.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idSolicitante">Identificador de Solicitante</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Solicitante.</param>
    ''' <returns>Paquete de información de tipo SolicitanteInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idSolicitante As Integer, checkStatus As Boolean) As SolicitanteInfo
        Dim SolicitanteSvc As New SolicitanteService(session)
        Dim SolicitanteInf As New SolicitanteInfo(session)
        GetDetail(SolicitanteSvc, SolicitanteInf, idSolicitante, checkStatus)
        Return SolicitanteInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Solicitante en base a su codigo de usuario
    ''' y verifica que el Solicitante esté activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información SolicitanteInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As SolicitanteInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Solicitante en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Solicitante</param>
    ''' <returns>Paquete de información SolicitanteInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As SolicitanteInfo
        Dim SolicitanteInf As New SolicitanteInfo(session)
        Dim SolicitanteSvc As New SolicitanteService(session)
        GetDetail(SolicitanteSvc, SolicitanteInf, userCode, idSucursal, checkStatus)
        Return SolicitanteInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Solicitante.
    ''' </summary>
    ''' <param name="Solicitante">Paquete de información del tipo SolicitanteInfo con la información a actualizar</param>
    ''' <returns>Identificador de Solicitante, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Solicitante As SolicitanteInfo) As Integer
        Dim SolicitanteSvc As New SolicitanteService(Solicitante.SessionID)
        Return Update(SolicitanteSvc, Solicitante)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim SolicitanteSvc As New SolicitanteService(session)
        Return GetNumberOfPages(SolicitanteSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Solicitantes que coincidan con las condiciones especificadas.
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
    ''' Busca Solicitantes que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim SolicitanteSvc As New SolicitanteService(session)
        Return GetSearchResult(SolicitanteSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Solicitantes.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim SolicitanteSvc As New SolicitanteService(session)
        Return GetSearchStructure(SolicitanteSvc)
    End Function

#End Region

End Class
