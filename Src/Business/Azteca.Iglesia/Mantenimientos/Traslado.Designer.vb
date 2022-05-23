''' <summary>
''' Paquete de informaci�n que representa un Traslado
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class TrasladoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Expediente As String

    Public Property IdParroquiaCura As Integer

    Public Property NumParroquiaDest As String

    Public Property IdSolicitanteEsposo As Integer

    Public Property IdSolicitanteEsposa As Integer

    Public Property Templo As String

    Public Property FechaExpedicion As DateTime



#End Region
	
#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Traslados
''' </summary>
''' <remarks></remarks>
Public Class TrasladoService
    Inherits CatalogService(Of TrasladoInfo)

#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Church", "Traslados", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idTraslado As Integer, ByRef Traslado As TrasladoInfo, checkStatus As Boolean)
        MyBase.GetDetail(idTraslado, Traslado, checkStatus)
        With Traslado
            .Expediente = CStr(ItemInfo("Expediente"))
            .IdParroquiaCura = CInt(ItemInfo("IdParroquiaCura"))
            .NumParroquiaDest = CStr(ItemInfo("NumParroquiaDest"))
            .IdSolicitanteEsposo = CInt(ItemInfo("IdSolicitanteEsposo"))
            .IdSolicitanteEsposa = CInt(ItemInfo("IdSolicitanteEsposa"))
            .Templo = CStr(ItemInfo("Templo"))
            .FechaExpedicion = CDate(ItemInfo("FechaExpedicion"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Traslado As TrasladoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Expediente", DbType.String).Value = Traslado.Expediente
            .Add("@IdParroquiaCura", DbType.Int32).Value = Traslado.IdParroquiaCura
            .Add("@NumParroquiaDest", DbType.String).Value = Traslado.NumParroquiaDest
            .Add("@IdSolicitanteEsposo", DbType.Int32).Value = Traslado.IdSolicitanteEsposo
            .Add("@IdSolicitanteEsposa", DbType.Int32).Value = Traslado.IdSolicitanteEsposa
            .Add("@Templo", DbType.String).Value = Traslado.Templo
            .Add("@FechaExpedicion", DbType.DateTime).Value = Traslado.FechaExpedicion

        End With
        Return MyBase.Update(Traslado)
    End Function

    Public Overrides Function Create() As TrasladoInfo
        Return New TrasladoInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Traslados
''' </summary>
''' <remarks></remarks>
Public Class TrasladoFacade
    Inherits CatalogFacade(Of TrasladoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un TrasladoInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As TrasladoInfo
        Dim TrasladoSvc As New TrasladoService(session)
        Return TrasladoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Traslados
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTraslado">Identificador del Traslado que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idTraslado As Integer)
        Dim TrasladoSvc As New TrasladoService(session)
        Delete(TrasladoSvc, idTraslado)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Traslado con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTraslado">ID de Traslado que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idTraslado As Integer) As Boolean
        Dim TrasladoSvc As New TrasladoService(session)
        Return Exists(TrasladoSvc, idTraslado)
    End Function

    ''' <summary>
    ''' Verifica si existe un Traslado con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim TrasladoSvc As New TrasladoService(session)
        Return Exists(TrasladoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Traslado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTraslado">Identificador de Traslado a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo TrasladoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idTraslado As Integer) As TrasladoInfo
        Return Me.GetDetail(session, idTraslado, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Traslado.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idTraslado">Identificador de Traslado</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Traslado.</param>
    ''' <returns>Paquete de informaci�n de tipo TrasladoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idTraslado As Integer, checkStatus As Boolean) As TrasladoInfo
        Dim TrasladoSvc As New TrasladoService(session)
        Dim TrasladoInf As New TrasladoInfo(session)
        GetDetail(TrasladoSvc, TrasladoInf, idTraslado, checkStatus)
        Return TrasladoInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Traslado en base a su codigo de usuario
    ''' y verifica que el Traslado est� activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n TrasladoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As TrasladoInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Traslado en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Traslado</param>
    ''' <returns>Paquete de informaci�n TrasladoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As TrasladoInfo
        Dim TrasladoInf As New TrasladoInfo(session)
        Dim TrasladoSvc As New TrasladoService(session)
        GetDetail(TrasladoSvc, TrasladoInf, userCode, idSucursal, checkStatus)
        Return TrasladoInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Traslado.
    ''' </summary>
    ''' <param name="Traslado">Paquete de informaci�n del tipo TrasladoInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Traslado, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Traslado As TrasladoInfo) As Integer
        Dim TrasladoSvc As New TrasladoService(Traslado.SessionID)
        Return Update(TrasladoSvc, Traslado)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim TrasladoSvc As New TrasladoService(session)
        Return GetNumberOfPages(TrasladoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Traslados que coincidan con las condiciones especificadas.
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
    ''' Busca Traslados que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim TrasladoSvc As New TrasladoService(session)
        Return GetSearchResult(TrasladoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Traslados.
    ''' </summary>
    ''' <param name="session">Objeto de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim TrasladoSvc As New TrasladoService(session)
        Return GetSearchStructure(TrasladoSvc)
    End Function

#End Region

End Class
