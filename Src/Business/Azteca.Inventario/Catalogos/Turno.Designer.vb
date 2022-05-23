''' <summary>
''' Paquete de informaci�n que representa un Turno
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class TurnoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property HoraInicial As Date

    Public Property HoraFinal As Date


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Turnos
''' </summary>
''' <remarks></remarks>
Public Class TurnoService
    Inherits CatalogService(Of TurnoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "Turnos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idTurno As Integer, ByRef Turno As TurnoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idTurno, Turno, checkStatus)
        With Turno
            .Nombre = CStr(ItemInfo("Nombre"))
            .HoraInicial = CDate(ItemInfo("HoraInicial"))
            .HoraFinal = CDate(ItemInfo("HoraFinal"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Turno As TurnoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Turno.Nombre
            .Add("@HoraInicial", DbType.DateTime).Value = Turno.HoraInicial
            .Add("@HoraFinal", DbType.DateTime).Value = Turno.HoraFinal
        End With
        Return MyBase.Update(Turno)
    End Function

    Public Overrides Function Create() As TurnoInfo
        Return New TurnoInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Turnos
''' </summary>
''' <remarks></remarks>
Public Class TurnoFacade
    Inherits CatalogFacade(Of TurnoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un TurnoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As TurnoInfo
        Dim TurnoSvc As New TurnoService(sessionID)
        Return TurnoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Turnos
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTurno">Identificador del Turno que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idTurno As Integer)
        Dim TurnoSvc As New TurnoService(sessionID)
        Delete(TurnoSvc, idTurno)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Turno con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTurno">ID de Turno que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idTurno As Integer) As Boolean
        Dim TurnoSvc As New TurnoService(sessionID)
        Return Exists(TurnoSvc, idTurno)
    End Function

    ''' <summary>
    ''' Verifica si existe un Turno con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim TurnoSvc As New TurnoService(sessionID)
        Return Exists(TurnoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Turno.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTurno">Identificador de Turno a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo TurnoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTurno As Integer) As TurnoInfo
        Return Me.GetDetail(sessionID, idTurno, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Turno.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTurno">Identificador de Turno</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Turno.</param>
    ''' <returns>Paquete de informaci�n de tipo TurnoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idTurno As Integer, ByVal checkStatus As Boolean) As TurnoInfo
        Dim TurnoSvc As New TurnoService(sessionID)
        Dim TurnoInf As New TurnoInfo(sessionID)
        GetDetail(TurnoSvc, TurnoInf, idTurno, checkStatus)
        Return TurnoInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Turno en base a su codigo de usuario
    ''' y verifica que el Turno est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n TurnoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As TurnoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Turno en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Turno</param>
    ''' <returns>Paquete de informaci�n TurnoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As TurnoInfo
        Dim TurnoInf As New TurnoInfo(sessionID)
        Dim TurnoSvc As New TurnoService(sessionID)
        GetDetail(TurnoSvc, TurnoInf, userCode, idSucursal, checkStatus)
        Return TurnoInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Turno.
    ''' </summary>
    ''' <param name="Turno">Paquete de informaci�n del tipo TurnoInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Turno, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Turno As TurnoInfo) As Integer
        Dim TurnoSvc As New TurnoService(Turno.SessionID)
        Return Update(TurnoSvc, Turno)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim TurnoSvc As New TurnoService(sessionID)
        Return GetNumberOfPages(TurnoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Turnos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Turnos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim TurnoSvc As New TurnoService(sessionID)
        Return GetSearchResult(TurnoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Turnos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim TurnoSvc As New TurnoService(sessionID)
        Return GetSearchStructure(TurnoSvc)
    End Function

#End Region

End Class
