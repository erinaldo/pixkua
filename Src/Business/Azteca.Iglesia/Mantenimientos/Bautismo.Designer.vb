''' <summary>
''' Paquete de información que representa un Bautismo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class BautismoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Libro As Integer

    Public Property Pagina As Integer

    Public Property Acta As Integer

    Public Property IdSacerdoteCertifica As Integer

    Public Property PBRO1 As String

    Public Property Lugar As String

    Public Property IdParroquia As Integer

    Public Property Fecha As Date

    Public Property IdSacerdoteBautizo As Integer

    Public Property IdSolicitante As Integer

    Public Property Padrinos As String

    Public Property NotasMarginales As String

    Public Property NumOfina As String

    Public Property LibroActa As Integer

    Public Property NumeroActa As Integer

    Public Property LugarRegistro As String

    Public Property Ilegitimo As Boolean

    Public Property Tenor As String

    Public Property FechaExpedicion As DateTime


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Bautismos
''' </summary>
''' <remarks></remarks>
Public Class BautismoService
    Inherits CatalogService(Of BautismoInfo)

#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Church", "Bautismos", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idBautismo As Integer, ByRef Bautismo As BautismoInfo, checkStatus As Boolean)
        MyBase.GetDetail(idBautismo, Bautismo, checkStatus)
        With Bautismo
            .Libro = CInt(ItemInfo("Libro"))
            .Pagina = CInt(ItemInfo("Pagina"))
            .Acta = CInt(ItemInfo("Acta"))
            .IdSacerdoteCertifica = CInt(ItemInfo("IdSacerdoteCertifica"))
            .PBRO1 = CStr(ItemInfo("PBRO1"))
            .Lugar = CStr(ItemInfo("Lugar"))
            .IdParroquia = CInt(ItemInfo("IdParroquia"))
            .Fecha = CDate(ItemInfo("Fecha"))
            .IdSacerdoteBautizo = CStr(ItemInfo("IdSacerdoteBautizo"))
            .IdSolicitante = CInt(ItemInfo("IdSolicitante"))
            .Padrinos = CStr(ItemInfo("Padrinos"))
            .NotasMarginales = CStr(ItemInfo("NotasMarginales"))
            .NumOfina = CStr(ItemInfo("NumOfina"))
            .LibroActa = CInt(ItemInfo("LibroActa"))
            .NumeroActa = CInt(ItemInfo("NumeroActa"))
            .LugarRegistro = CStr(ItemInfo("LugarRegistro"))
            .Ilegitimo = CBool(ItemInfo("Ilegitimo"))
            .Tenor = CStr(ItemInfo("Tenor"))
            .FechaExpedicion = CDate(ItemInfo("FechaExpedicion"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Bautismo As BautismoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Libro", DbType.Int32).Value = Bautismo.Libro
            .Add("@Pagina", DbType.Int32).Value = Bautismo.Pagina
            .Add("@Acta", DbType.Int32).Value = Bautismo.Acta
            .Add("@IdSacerdoteCertifica", DbType.Int32).Value = Bautismo.IdSacerdoteCertifica
            .Add("@PBRO1", DbType.String).Value = Bautismo.PBRO1
            .Add("@Lugar", DbType.String).Value = Bautismo.Lugar
            .Add("@IdParroquia", DbType.String).Value = Bautismo.IdParroquia
            .Add("@Fecha", DbType.DateTime).Value = Bautismo.Fecha
            .Add("@IdSacerdoteBautizo", DbType.String).Value = Bautismo.IdSacerdoteBautizo
            .Add("@IdSolicitante", DbType.Int32).Value = Bautismo.IdSolicitante
            .Add("@Padrinos", DbType.String).Value = Bautismo.Padrinos
            .Add("@NotasMarginales", DbType.String).Value = Bautismo.NotasMarginales
            .Add("@NumOfina", DbType.String).Value = Bautismo.NumOfina
            .Add("@LibroActa", DbType.Int32).Value = Bautismo.LibroActa
            .Add("@NumeroActa", DbType.Int32).Value = Bautismo.NumeroActa
            .Add("@LugarRegistro", DbType.String).Value = Bautismo.LugarRegistro
            .Add("@Ilegitimo", DbType.Boolean).Value = Bautismo.Ilegitimo
            .Add("@Tenor", DbType.String).Value = Bautismo.Tenor
            .Add("@FechaExpedicion", DbType.DateTime).Value = Bautismo.FechaExpedicion


        End With
        Return MyBase.Update(Bautismo)
    End Function

    Public Overrides Function Create() As BautismoInfo
        Return New BautismoInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Bautismos
''' </summary>
''' <remarks></remarks>
Public Class BautismoFacade
    Inherits CatalogFacade(Of BautismoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un BautismoInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As BautismoInfo
        Dim BautismoSvc As New BautismoService(session)
        Return BautismoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Bautismos
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idBautismo">Identificador del Bautismo que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idBautismo As Integer)
        Dim BautismoSvc As New BautismoService(session)
        Delete(BautismoSvc, idBautismo)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Bautismo con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idBautismo">ID de Bautismo que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idBautismo As Integer) As Boolean
        Dim BautismoSvc As New BautismoService(session)
        Return Exists(BautismoSvc, idBautismo)
    End Function

    ''' <summary>
    ''' Verifica si existe un Bautismo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim BautismoSvc As New BautismoService(session)
        Return Exists(BautismoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Bautismo.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idBautismo">Identificador de Bautismo a consultar</param>
    ''' <returns>Paquete de información de tipo BautismoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idBautismo As Integer) As BautismoInfo
        Return Me.GetDetail(session, idBautismo, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Bautismo.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idBautismo">Identificador de Bautismo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Bautismo.</param>
    ''' <returns>Paquete de información de tipo BautismoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idBautismo As Integer, checkStatus As Boolean) As BautismoInfo
        Dim BautismoSvc As New BautismoService(session)
        Dim BautismoInf As New BautismoInfo(session)
        GetDetail(BautismoSvc, BautismoInf, idBautismo, checkStatus)
        Return BautismoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Bautismo en base a su codigo de usuario
    ''' y verifica que el Bautismo esté activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información BautismoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As BautismoInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Bautismo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Bautismo</param>
    ''' <returns>Paquete de información BautismoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As BautismoInfo
        Dim BautismoInf As New BautismoInfo(session)
        Dim BautismoSvc As New BautismoService(session)
        GetDetail(BautismoSvc, BautismoInf, userCode, idSucursal, checkStatus)
        Return BautismoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Bautismo.
    ''' </summary>
    ''' <param name="Bautismo">Paquete de información del tipo BautismoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Bautismo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Bautismo As BautismoInfo) As Integer
        Dim BautismoSvc As New BautismoService(Bautismo.SessionID)
        Return Update(BautismoSvc, Bautismo)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim BautismoSvc As New BautismoService(session)
        Return GetNumberOfPages(BautismoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Bautismos que coincidan con las condiciones especificadas.
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
    ''' Busca Bautismos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim BautismoSvc As New BautismoService(session)
        Return GetSearchResult(BautismoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Bautismos.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim BautismoSvc As New BautismoService(session)
        Return GetSearchStructure(BautismoSvc)
    End Function

#End Region

End Class
