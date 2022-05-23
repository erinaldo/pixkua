''' <summary>
''' Paquete de información que representa un Matrimonio
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class MatrimonioInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Libro As Integer

    Public Property Pagina As Integer

    Public Property ActaIzq As Integer

    Public Property ActaDer As Integer

    Public Property ExpedienteIzq As Integer

    Public Property ExpedienteDer As Integer

    Public Property IdSacerdote As Integer

    Public Property Suscrito As String

    Public Property IdParroquiaSacerdote As Integer

    Public Property Fecha As Date

    Public Property FechaExpedicion As Date

    Public Property IdSolicitanteEsposo As Integer

    Public Property IdSolicitanteEsposa As Integer

    Public Property ContrajeronEn As String

    Public Property SacerdoteAsistio As String

    Public Property Testigo1 As String

    Public Property Testigo2 As String

    Public Property Padrino1 As String

    Public Property Padrino2 As String

    Public Property LugarTraslado As String




#End Region
	
#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Matrimonios
''' </summary>
''' <remarks></remarks>
Public Class MatrimonioService
    Inherits CatalogService(Of MatrimonioInfo)

#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Church", "Matrimonios", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idMatrimonio As Integer, ByRef Matrimonio As MatrimonioInfo, checkStatus As Boolean)
        MyBase.GetDetail(idMatrimonio, Matrimonio, checkStatus)
        With Matrimonio
            .Libro = CInt(ItemInfo("Libro"))
            .Pagina = CInt(ItemInfo("Pagina"))
            .ActaIzq = CInt(ItemInfo("ActaIzq"))
            .ActaDer = CInt(ItemInfo("ActaDer"))
            .ExpedienteIzq = CInt(ItemInfo("ExpedienteIzq"))
            .ExpedienteDer = CInt(ItemInfo("ExpedienteDer"))
            .IdSacerdote = CInt(ItemInfo("IdSacerdote"))
            .Suscrito = CStr(ItemInfo("Suscrito"))
            .IdParroquiaSacerdote = CInt(ItemInfo("IdParroquiaSacerdote"))
            .Fecha = CDate(ItemInfo("Fecha"))
            .FechaExpedicion = CDate(ItemInfo("FechaExpedicion"))
            .IdSolicitanteEsposo = CInt(ItemInfo("IdSolicitanteEsposo"))
            .IdSolicitanteEsposa = CInt(ItemInfo("IdSolicitanteEsposa"))
            .ContrajeronEn = CStr(ItemInfo("ContrajeronEn"))
            .SacerdoteAsistio = CStr(ItemInfo("SacerdoteAsistio"))
            .Testigo1 = CStr(ItemInfo("Testigo1"))
            .Testigo2 = CStr(ItemInfo("Testigo2"))
            .Padrino1 = CStr(ItemInfo("Padrino1"))
            .Padrino2 = CStr(ItemInfo("Padrino2"))
            .LugarTraslado = CStr(ItemInfo("LugarTraslado"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Matrimonio As MatrimonioInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Libro", DbType.Int32).Value = Matrimonio.Libro
            .Add("@Pagina", DbType.Int32).Value = Matrimonio.Pagina
            .Add("@ActaIzq", DbType.Int32).Value = Matrimonio.ActaIzq
            .Add("@ActaDer", DbType.Int32).Value = Matrimonio.ActaDer
            .Add("@ExpedienteIzq", DbType.Int32).Value = Matrimonio.ExpedienteIzq
            .Add("@ExpedienteDer", DbType.Int32).Value = Matrimonio.ExpedienteDer
            .Add("@IdSacerdote", DbType.Int32).Value = Matrimonio.IdSacerdote
            .Add("@Suscrito", DbType.String).Value = Matrimonio.Suscrito
            .Add("@IdParroquiaSacerdote", DbType.Int32).Value = Matrimonio.IdParroquiaSacerdote
            .Add("@Fecha", DbType.DateTime).Value = Matrimonio.Fecha
            .Add("@FechaExpedicion", DbType.DateTime).Value = Matrimonio.FechaExpedicion
            .Add("@IdSolicitanteEsposo", DbType.Int32).Value = Matrimonio.IdSolicitanteEsposo
            .Add("@IdSolicitanteEsposa", DbType.Int32).Value = Matrimonio.IdSolicitanteEsposa
            .Add("@ContrajeronEn", DbType.String).Value = Matrimonio.ContrajeronEn
            .Add("@SacerdoteAsistio", DbType.String).Value = Matrimonio.SacerdoteAsistio
            .Add("@Testigo1", DbType.String).Value = Matrimonio.Testigo1
            .Add("@Testigo2", DbType.String).Value = Matrimonio.Testigo2
            .Add("@Padrino1", DbType.String).Value = Matrimonio.Padrino1
            .Add("@Padrino2", DbType.String).Value = Matrimonio.Padrino2
            .Add("@LugarTraslado", DbType.String).Value = Matrimonio.LugarTraslado

        End With
        Return MyBase.Update(Matrimonio)
    End Function

    Public Overrides Function Create() As MatrimonioInfo
        Return New MatrimonioInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Matrimonios
''' </summary>
''' <remarks></remarks>
Public Class MatrimonioFacade
    Inherits CatalogFacade(Of MatrimonioInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un MatrimonioInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As MatrimonioInfo
        Dim MatrimonioSvc As New MatrimonioService(session)
        Return MatrimonioSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Matrimonios
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idMatrimonio">Identificador del Matrimonio que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idMatrimonio As Integer)
        Dim MatrimonioSvc As New MatrimonioService(session)
        Delete(MatrimonioSvc, idMatrimonio)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Matrimonio con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idMatrimonio">ID de Matrimonio que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idMatrimonio As Integer) As Boolean
        Dim MatrimonioSvc As New MatrimonioService(session)
        Return Exists(MatrimonioSvc, idMatrimonio)
    End Function

    ''' <summary>
    ''' Verifica si existe un Matrimonio con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim MatrimonioSvc As New MatrimonioService(session)
        Return Exists(MatrimonioSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Matrimonio.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idMatrimonio">Identificador de Matrimonio a consultar</param>
    ''' <returns>Paquete de información de tipo MatrimonioInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idMatrimonio As Integer) As MatrimonioInfo
        Return Me.GetDetail(session, idMatrimonio, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Matrimonio.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idMatrimonio">Identificador de Matrimonio</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Matrimonio.</param>
    ''' <returns>Paquete de información de tipo MatrimonioInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idMatrimonio As Integer, checkStatus As Boolean) As MatrimonioInfo
        Dim MatrimonioSvc As New MatrimonioService(session)
        Dim MatrimonioInf As New MatrimonioInfo(session)
        GetDetail(MatrimonioSvc, MatrimonioInf, idMatrimonio, checkStatus)
        Return MatrimonioInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Matrimonio en base a su codigo de usuario
    ''' y verifica que el Matrimonio esté activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información MatrimonioInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As MatrimonioInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Matrimonio en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Matrimonio</param>
    ''' <returns>Paquete de información MatrimonioInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As MatrimonioInfo
        Dim MatrimonioInf As New MatrimonioInfo(session)
        Dim MatrimonioSvc As New MatrimonioService(session)
        GetDetail(MatrimonioSvc, MatrimonioInf, userCode, idSucursal, checkStatus)
        Return MatrimonioInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Matrimonio.
    ''' </summary>
    ''' <param name="Matrimonio">Paquete de información del tipo MatrimonioInfo con la información a actualizar</param>
    ''' <returns>Identificador de Matrimonio, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Matrimonio As MatrimonioInfo) As Integer
        Dim MatrimonioSvc As New MatrimonioService(Matrimonio.SessionID)
        Return Update(MatrimonioSvc, Matrimonio)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim MatrimonioSvc As New MatrimonioService(session)
        Return GetNumberOfPages(MatrimonioSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Matrimonios que coincidan con las condiciones especificadas.
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
    ''' Busca Matrimonios que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim MatrimonioSvc As New MatrimonioService(session)
        Return GetSearchResult(MatrimonioSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Matrimonios.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim MatrimonioSvc As New MatrimonioService(session)
        Return GetSearchStructure(MatrimonioSvc)
    End Function

#End Region

End Class
