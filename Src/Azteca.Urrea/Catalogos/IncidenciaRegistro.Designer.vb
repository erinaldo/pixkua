''' <summary>
''' Paquete de información que representa un IncidenciaRegistro
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class IncidenciaRegistroInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"

    Public Property IdIncidencia As Integer
    Public Property Paquete As String    Public Property Entrega As String    Public Property OrdenTransporte As String    Public Property FechaInicio As Date    Public Property HoraInicio As Date    Public Property FechaCierre As Nullable(Of Date)    Public Property HoraCierre As Nullable(Of Date)    Public Property Figura As String    Public Property Cantidad As Decimal    Public Property NumColaborador As String    Public Property NumContenedor As String    Public Property IdCaja As String    Public Property RevisaOT As String    Public Property RevisaFigura As String    Public Property Comentarios As String    Public Property IdEmpresa As Integer    Public Property Area As String    Public Property Responsable As String
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de IncidenciasRegitro
''' </summary>
''' <remarks></remarks>
Public Class IncidenciaRegistroService
    Inherits CatalogService(Of IncidenciaRegistroInfo)

#Region "Constructores"
    Public Sub New(ByVal session As GUID)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As GUID, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("CDU", "IncidenciasRegitro", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idIncidenciaRegistro As Integer, ByRef IncidenciaRegistro As IncidenciaRegistroInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idIncidenciaRegistro, IncidenciaRegistro, checkStatus)
        With IncidenciaRegistro
            .Paquete = CStr(ItemInfo("Paquete"))
            .Entrega = CStr(ItemInfo("Entrega"))
            .OrdenTransporte = CStr(ItemInfo("OrdenTransporte"))
            .FechaInicio = CDate(ItemInfo("FechaInicio"))
            .HoraInicio = CDate(ItemInfo("HoraInicio"))
            .IdIncidencia = CInt(ItemInfo("IdIncidencia"))
            If (Not IsDBNull(ItemInfo("FechaCierre"))) Then
                .FechaCierre = CDate(ItemInfo("FechaCierre"))
            End If

            If (Not IsDBNull(ItemInfo("HoraCierre"))) Then
                .HoraCierre = CDate(ItemInfo("HoraCierre"))
            End If

            .Figura = CStr(ItemInfo("Figura"))
            .Cantidad = CDec(ItemInfo("Cantidad"))
            .NumColaborador = CStr(ItemInfo("NumColaborador"))
            .NumContenedor = CStr(ItemInfo("NumContenedor"))
            .IdCaja = CStr(ItemInfo("IdCaja"))
            .RevisaOT = CStr(ItemInfo("RevisaOT"))
            .RevisaFigura = CStr(ItemInfo("RevisaFigura"))
            .Comentarios = CStr(ItemInfo("Comentarios"))
            .IdEmpresa = CInt(ItemInfo("IdEmpresa"))

            .Area = CStr(ItemInfo("Area"))
            .Responsable = CStr(ItemInfo("Responsable"))

        End With
    End Sub

    Public Overrides Function Update(ByVal IncidenciaRegistro As IncidenciaRegistroInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Paquete", DbType.String).Value = IncidenciaRegistro.Paquete
            .Add("@Entrega", DbType.String).Value = IncidenciaRegistro.Entrega
            .Add("@OrdenTransporte", DbType.String).Value = IncidenciaRegistro.OrdenTransporte
            .Add("@FechaInicio", DbType.DateTime).Value = IncidenciaRegistro.FechaInicio
            .Add("@HoraInicio", DbType.DateTime).Value = IncidenciaRegistro.HoraInicio
            '.Add("@FechaCierre", DbType.DateTime).Value = IncidenciaRegistro.FechaCierre
            '.Add("@HoraCierre", DbType.DateTime).Value = IncidenciaRegistro.HoraCierre
            .Add("@Figura", DbType.String).Value = IncidenciaRegistro.Figura
            .Add("@IdIncidencia", DbType.Int32).Value = IncidenciaRegistro.IdIncidencia
            .Add("@Cantidad", DbType.Decimal).Value = IncidenciaRegistro.Cantidad
            .Add("@NumColaborador", DbType.String).Value = IncidenciaRegistro.NumColaborador
            .Add("@NumContenedor", DbType.String).Value = IncidenciaRegistro.NumContenedor
            .Add("@IdCaja", DbType.String).Value = IncidenciaRegistro.IdCaja
            .Add("@RevisaOT", DbType.String).Value = IncidenciaRegistro.RevisaOT
            .Add("@RevisaFigura", DbType.String).Value = IncidenciaRegistro.RevisaFigura
            .Add("@Comentarios", DbType.String).Value = IncidenciaRegistro.Comentarios
            .Add("@Area", DbType.String).Value = IncidenciaRegistro.Area
            .Add("@Responsable", DbType.String).Value = IncidenciaRegistro.Responsable

           
        End With
        Return MyBase.Update(IncidenciaRegistro)
    End Function

    Public Overrides Function Create() As IncidenciaRegistroInfo
        Return New IncidenciaRegistroInfo(Session.SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de IncidenciasRegitro
''' </summary>
''' <remarks></remarks>
Public Class IncidenciaRegistroFacade
    Inherits CatalogFacade(Of IncidenciaRegistroInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un IncidenciaRegistroInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As GUID) As IncidenciaRegistroInfo
        Dim IncidenciaRegistroSvc As New IncidenciaRegistroService(session)
        Return IncidenciaRegistroSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de IncidenciasRegitro
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idIncidenciaRegistro">Identificador del IncidenciaRegistro que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As GUID, ByVal idIncidenciaRegistro As Integer)
        Dim IncidenciaRegistroSvc As New IncidenciaRegistroService(session)
        Delete(IncidenciaRegistroSvc, idIncidenciaRegistro)
    End Sub

    ''' <summary>
    ''' Verifica si existe un IncidenciaRegistro con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idIncidenciaRegistro">ID de IncidenciaRegistro que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As GUID, ByVal idIncidenciaRegistro As Integer) As Boolean
        Dim IncidenciaRegistroSvc As New IncidenciaRegistroService(session)
        Return Exists(IncidenciaRegistroSvc, idIncidenciaRegistro)
    End Function

    ''' <summary>
    ''' Verifica si existe un IncidenciaRegistro con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim IncidenciaRegistroSvc As New IncidenciaRegistroService(session)
        Return Exists(IncidenciaRegistroSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un IncidenciaRegistro.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idIncidenciaRegistro">Identificador de IncidenciaRegistro a consultar</param>
    ''' <returns>Paquete de información de tipo IncidenciaRegistroInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As GUID, ByVal idIncidenciaRegistro As Integer) As IncidenciaRegistroInfo
        Return Me.GetDetail(session, idIncidenciaRegistro, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un IncidenciaRegistro.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idIncidenciaRegistro">Identificador de IncidenciaRegistro</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del IncidenciaRegistro.</param>
    ''' <returns>Paquete de información de tipo IncidenciaRegistroInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As GUID, ByVal idIncidenciaRegistro As Integer, ByVal checkStatus As Boolean) As IncidenciaRegistroInfo
        Dim IncidenciaRegistroSvc As New IncidenciaRegistroService(session)
        Dim IncidenciaRegistroInf As New IncidenciaRegistroInfo(session)
        GetDetail(IncidenciaRegistroSvc, IncidenciaRegistroInf, idIncidenciaRegistro, checkStatus)
        Return IncidenciaRegistroInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un IncidenciaRegistro en base a su codigo de usuario
    ''' y verifica que el IncidenciaRegistro esté activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información IncidenciaRegistroInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As IncidenciaRegistroInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un IncidenciaRegistro en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del IncidenciaRegistro</param>
    ''' <returns>Paquete de información IncidenciaRegistroInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As IncidenciaRegistroInfo
        Dim IncidenciaRegistroInf As New IncidenciaRegistroInfo(session)
        Dim IncidenciaRegistroSvc As New IncidenciaRegistroService(session)
        GetDetail(IncidenciaRegistroSvc, IncidenciaRegistroInf, userCode, idSucursal, checkStatus)
        Return IncidenciaRegistroInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un IncidenciaRegistro.
    ''' </summary>
    ''' <param name="IncidenciaRegistro">Paquete de información del tipo IncidenciaRegistroInfo con la información a actualizar</param>
    ''' <returns>Identificador de IncidenciaRegistro, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal IncidenciaRegistro As IncidenciaRegistroInfo) As Integer
        Dim IncidenciaRegistroSvc As New IncidenciaRegistroService(IncidenciaRegistro.SessionID)
        Return Update(IncidenciaRegistroSvc, IncidenciaRegistro)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim IncidenciaRegistroSvc As New IncidenciaRegistroService(session)
        Return GetNumberOfPages(IncidenciaRegistroSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca IncidenciasRegitro que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(session, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca IncidenciasRegitro que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim IncidenciaRegistroSvc As New IncidenciaRegistroService(session)
        Return GetSearchResult(IncidenciaRegistroSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de IncidenciasRegitro.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As GUID) As System.Data.DataSet
        Dim IncidenciaRegistroSvc As New IncidenciaRegistroService(session)
        Return GetSearchStructure(IncidenciaRegistroSvc)
    End Function

#End Region

End Class
