''' <summary>
''' Paquete de información que representa un Rac
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class RacInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Private _RacDet As RacDetDS.RacDetDataTable
#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdPolizaPerfil As Integer
    Public Property IdSegmentoNegocio As Integer

    Public Property RacDet As RacDetDS.RacDetDataTable
        Get
            Return _RacDet
        End Get
        Set(ByVal value As RacDetDS.RacDetDataTable)
            _RacDet = value
        End Set
    End Property

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        Me.RacDet = New RacDetDS.RacDetDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de RacTit
''' </summary>
''' <remarks></remarks>
Public Class RacService
    Inherits CatalogService(Of RacInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "RacTit", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idRac As Integer, ByRef info As RacInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idRac, info, checkStatus)
        With info
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdPolizaPerfil = CInt(ItemInfo("IdPolizaPerfil"))
            .IdSegmentoNegocio = CInt(ItemInfo("IdSegmentoNegocio"))
        End With
        loadDetail(info)
    End Sub

    Public Overrides Function Update(ByVal Rac As RacInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Rac.Nombre
            .Add("@IdPolizaPerfil", DbType.Int32).Value = Rac.IdPolizaPerfil
            .Add("@IdSegmentoNegocio", DbType.Int32).Value = Rac.IdSegmentoNegocio
        End With
        Dim Id As Integer = MyBase.Update(Rac)
        saveDetail(Rac)
        Return Id
    End Function

    Public Overrides Function Create() As RacInfo
        Return New RacInfo(sessionID)
    End Function

#End Region

    Private Sub loadDetail(ByVal Info As RacInfo)
        Try
            Dim fx As New FunctionSQL("Accounting", "fxRacDetSEL", Connection, Transaction)
            fx.Parameters.Add("@Id", DbType.Int32).Value = Info.Identity
            fx.Parameters.Add("@IdUsuario", DbType.Int32).Value = -1
            fx.FillDataTable(Info.RacDet)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los origenes de las pólizas", ex)
        End Try
    End Sub

    Private Sub saveDetail(ByVal Info As RacInfo)
        Try
            Dim da As New DataAdapter
            Dim cmd As New Azteca.Data.DbCommand("Accounting.RacDetUPD", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id", DbType.Int32, "Id")
            cmd.Parameters.Add("@IdRacTit", DbType.Int32).Value = Info.Identity
            cmd.Parameters.Add("@IdCuenta", DbType.Int32, "IdCuenta")
            cmd.Parameters.Add("@IdEntidad", DbType.Int32, "IdEntidad")
            cmd.Parameters.Add("@CampoFK", DbType.String, "CampoFK")
            cmd.Parameters.Add("@isEntidadConcepto", DbType.Boolean, "isEntidadConcepto")
            cmd.Parameters.Add("@Afectador", DbType.String, "Afectador")
            cmd.Parameters.Add("@Rojo", DbType.Boolean, "Rojo")
            cmd.Parameters.Add("@IdImporte", DbType.AnsiString, "IdImporte")
            cmd.Parameters.Add("@Orden", DbType.Int32, "Orden")

            Dim cmdDEL As New Azteca.Data.DbCommand("Accounting.RacDetDEL", Me.Connection, Me.Transaction)
            cmdDEL.Parameters.Add("@Id", DbType.Int32, "Id")
            cmdDEL.CommandType = CommandType.StoredProcedure

            da.UpdateCommand = cmd : da.InsertCommand = cmd : da.DeleteCommand = cmdDEL
            da.Update(Info.RacDet)

        Catch ex As Exception
            Throw New Exception("Problemas al intentar guardar el detalle del RAC", ex)
        End Try

    End Sub
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de RacTit
''' </summary>
''' <remarks></remarks>
Public Class RacFacade
    Inherits CatalogFacade(Of RacInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un RacInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As RacInfo
        Dim RacSvc As New RacService(sessionID)
        Return RacSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de RacTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRac">Identificador del Rac que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idRac As Integer)
        Dim RacSvc As New RacService(sessionID)
        Delete(RacSvc, idRac)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Rac con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRac">ID de Rac que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idRac As Integer) As Boolean
        Dim RacSvc As New RacService(sessionID)
        Return Exists(RacSvc, idRac)
    End Function

    ''' <summary>
    ''' Verifica si existe un Rac con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim RacSvc As New RacService(sessionID)
        Return Exists(RacSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Rac.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRac">Identificador de Rac a consultar</param>
    ''' <returns>Paquete de información de tipo RacInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idRac As Integer) As RacInfo
        Return Me.GetDetail(sessionID, idRac, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Rac.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idRac">Identificador de Rac</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Rac.</param>
    ''' <returns>Paquete de información de tipo RacInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idRac As Integer, ByVal checkStatus As Boolean) As RacInfo
        Dim RacSvc As New RacService(sessionID)
        Dim RacInf As New RacInfo(sessionID)
        GetDetail(RacSvc, RacInf, idRac, checkStatus)
        Return RacInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Rac en base a su codigo de usuario
    ''' y verifica que el Rac esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información RacInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As RacInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Rac en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Rac</param>
    ''' <returns>Paquete de información RacInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As RacInfo
        Dim RacInf As New RacInfo(sessionID)
        Dim RacSvc As New RacService(sessionID)
        GetDetail(RacSvc, RacInf, userCode, idSucursal, checkStatus)
        Return RacInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Rac.
    ''' </summary>
    ''' <param name="Rac">Paquete de información del tipo RacInfo con la información a actualizar</param>
    ''' <returns>Identificador de Rac, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Rac As RacInfo) As Integer
        Dim RacSvc As New RacService(Rac.SessionID)
        Return Update(RacSvc, Rac)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim RacSvc As New RacService(sessionID)
        Return GetNumberOfPages(RacSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca RacTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca RacTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim RacSvc As New RacService(sessionID)
        Return GetSearchResult(RacSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de RacTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim RacSvc As New RacService(sessionID)
        Return GetSearchStructure(RacSvc)
    End Function

#End Region

End Class
