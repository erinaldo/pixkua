''' <summary>
''' Paquete de informaci�n que representa un Defuncion
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class DefuncionInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Libro As Integer

    Public Property Pagina As Integer

    Public Property Acta As Integer

    Public Property Fecha As Date

    Public Property IdSolicitante As Integer

    Public Property FamiliaresSobreviven As String

    Public Property Causa As String

    Public Property DomicilioSepultura As String

    Public Property IdSacerdote As Integer

    Public Property Reconcialiacion As Boolean

    Public Property Viatico As Boolean

    Public Property UncionEnfermos As Boolean

    Public Property ActaCivilDefuncion As Integer

    Public Property IdPoblacionDefuncion As Integer



#End Region
	
#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Defunciones
''' </summary>
''' <remarks></remarks>
Public Class DefuncionService
    Inherits CatalogService(Of DefuncionInfo)

#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Church", "Defunciones", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idDefuncion As Integer, ByRef Defuncion As DefuncionInfo, checkStatus As Boolean)
        MyBase.GetDetail(idDefuncion, Defuncion, checkStatus)
        With Defuncion
            .Libro = CInt(ItemInfo("Libro"))
            .Pagina = CInt(ItemInfo("Pagina"))
            .Acta = CInt(ItemInfo("Acta"))
            .Fecha = CDate(ItemInfo("Fecha"))
            .IdSolicitante = CInt(ItemInfo("IdSolicitante"))
            .FamiliaresSobreviven = CStr(ItemInfo("FamiliaresSobreviven"))
            .Causa = CStr(ItemInfo("Causa"))
            .DomicilioSepultura = CStr(ItemInfo("DomicilioSepultura"))
            .IdSacerdote = CInt(ItemInfo("IdSacerdote"))
            .Reconcialiacion = CBool(ItemInfo("Reconcialiacion"))
            .Viatico = CBool(ItemInfo("Viatico"))
            .UncionEnfermos = CBool(ItemInfo("UncionEnfermos"))
            .ActaCivilDefuncion = CInt(ItemInfo("ActaCivilDefuncion"))
            .IdPoblacionDefuncion = CInt(ItemInfo("IdPoblacionDefuncion"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Defuncion As DefuncionInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Libro", DbType.Int32).Value = Defuncion.Libro
            .Add("@Pagina", DbType.Int32).Value = Defuncion.Pagina
            .Add("@Acta", DbType.Int32).Value = Defuncion.Acta
            .Add("@Fecha", DbType.DateTime).Value = Defuncion.Fecha
            .Add("@IdSolicitante", DbType.Int32).Value = Defuncion.IdSolicitante
            .Add("@FamiliaresSobreviven", DbType.String).Value = Defuncion.FamiliaresSobreviven
            .Add("@Causa", DbType.String).Value = Defuncion.Causa
            .Add("@DomicilioSepultura", DbType.String).Value = Defuncion.DomicilioSepultura
            .Add("@IdSacerdote", DbType.Int32).Value = Defuncion.IdSacerdote
            .Add("@Reconcialiacion", DbType.Boolean).Value = Defuncion.Reconcialiacion
            .Add("@Viatico", DbType.Boolean).Value = Defuncion.Viatico
            .Add("@UncionEnfermos", DbType.Boolean).Value = Defuncion.UncionEnfermos
            .Add("@ActaCivilDefuncion", DbType.Int32).Value = Defuncion.ActaCivilDefuncion
            .Add("@IdPoblacionDefuncion", DbType.Int32).Value = Defuncion.IdPoblacionDefuncion

        End With
        Return MyBase.Update(Defuncion)
    End Function

    Public Overrides Function Create() As DefuncionInfo
        Return New DefuncionInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Defunciones
''' </summary>
''' <remarks></remarks>
Public Class DefuncionFacade
    Inherits CatalogFacade(Of DefuncionInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un DefuncionInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As DefuncionInfo
        Dim DefuncionSvc As New DefuncionService(session)
        Return DefuncionSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Defunciones
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idDefuncion">Identificador del Defuncion que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idDefuncion As Integer)
        Dim DefuncionSvc As New DefuncionService(session)
        Delete(DefuncionSvc, idDefuncion)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Defuncion con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idDefuncion">ID de Defuncion que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idDefuncion As Integer) As Boolean
        Dim DefuncionSvc As New DefuncionService(session)
        Return Exists(DefuncionSvc, idDefuncion)
    End Function

    ''' <summary>
    ''' Verifica si existe un Defuncion con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim DefuncionSvc As New DefuncionService(session)
        Return Exists(DefuncionSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Defuncion.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idDefuncion">Identificador de Defuncion a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo DefuncionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idDefuncion As Integer) As DefuncionInfo
        Return Me.GetDetail(session, idDefuncion, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Defuncion.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idDefuncion">Identificador de Defuncion</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Defuncion.</param>
    ''' <returns>Paquete de informaci�n de tipo DefuncionInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idDefuncion As Integer, checkStatus As Boolean) As DefuncionInfo
        Dim DefuncionSvc As New DefuncionService(session)
        Dim DefuncionInf As New DefuncionInfo(session)
        GetDetail(DefuncionSvc, DefuncionInf, idDefuncion, checkStatus)
        Return DefuncionInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Defuncion en base a su codigo de usuario
    ''' y verifica que el Defuncion est� activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n DefuncionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As DefuncionInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Defuncion en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Defuncion</param>
    ''' <returns>Paquete de informaci�n DefuncionInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As DefuncionInfo
        Dim DefuncionInf As New DefuncionInfo(session)
        Dim DefuncionSvc As New DefuncionService(session)
        GetDetail(DefuncionSvc, DefuncionInf, userCode, idSucursal, checkStatus)
        Return DefuncionInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Defuncion.
    ''' </summary>
    ''' <param name="Defuncion">Paquete de informaci�n del tipo DefuncionInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Defuncion, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Defuncion As DefuncionInfo) As Integer
        Dim DefuncionSvc As New DefuncionService(Defuncion.SessionID)
        Return Update(DefuncionSvc, Defuncion)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim DefuncionSvc As New DefuncionService(session)
        Return GetNumberOfPages(DefuncionSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Defunciones que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(session, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Defunciones que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim DefuncionSvc As New DefuncionService(session)
        Return GetSearchResult(DefuncionSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Defunciones.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim DefuncionSvc As New DefuncionService(session)
        Return GetSearchStructure(DefuncionSvc)
    End Function

#End Region

End Class
