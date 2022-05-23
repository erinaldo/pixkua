''' <summary>
''' Paquete de informaci�n que representa un Cajero
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CajeroInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property IdEmpleado As Integer

    Public Property IdUsuario As Integer

    Public Property IdCuenta As Integer


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Cajeros
''' </summary>
''' <remarks></remarks>
Public Class CajeroService
    Inherits CatalogService(Of CajeroInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "Cajeros", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCajero As Integer, ByRef Cajero As CajeroInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idCajero, Cajero, checkStatus)
        With Cajero
            .IdEmpleado = CInt(ItemInfo("IdEmpleado"))
            .IdUsuario = CInt(ItemInfo("IdUsuario"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Cajero As CajeroInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@IdEmpleado", DbType.Int32).Value = Cajero.IdEmpleado
            .Add("@IdUsuario", DbType.Int32).Value = Cajero.IdUsuario
            .Add("@IdCuenta", DbType.Int32).Value = Cajero.IdCuenta

        End With
        Return MyBase.Update(Cajero)
    End Function

    Public Overrides Function Create() As CajeroInfo
        Return New CajeroInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Cajeros
''' </summary>
''' <remarks></remarks>
Public Class CajeroFacade
    Inherits CatalogFacade(Of CajeroInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CajeroInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As CajeroInfo
        Dim CajeroSvc As New CajeroService(sessionID)
        Return CajeroSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Cajeros
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idCajero">Identificador del Cajero que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idCajero As Integer)
        Dim CajeroSvc As New CajeroService(sessionID)
        Delete(CajeroSvc, idCajero)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Cajero con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idCajero">ID de Cajero que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idCajero As Integer) As Boolean
        Dim CajeroSvc As New CajeroService(sessionID)
        Return Exists(CajeroSvc, idCajero)
    End Function

    ''' <summary>
    ''' Verifica si existe un Cajero con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim CajeroSvc As New CajeroService(sessionID)
        Return Exists(CajeroSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Cajero.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idCajero">Identificador de Cajero a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo CajeroInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCajero As Integer) As CajeroInfo
        Return Me.GetDetail(sessionID, idCajero, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Cajero.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idCajero">Identificador de Cajero</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Cajero.</param>
    ''' <returns>Paquete de informaci�n de tipo CajeroInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCajero As Integer, ByVal checkStatus As Boolean) As CajeroInfo
        Dim CajeroSvc As New CajeroService(sessionID)
        Dim CajeroInf As New CajeroInfo(sessionID)
        GetDetail(CajeroSvc, CajeroInf, idCajero, checkStatus)
        Return CajeroInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Cajero en base a su codigo de usuario
    ''' y verifica que el Cajero est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n CajeroInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As CajeroInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Cajero en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Cajero</param>
    ''' <returns>Paquete de informaci�n CajeroInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CajeroInfo
        Dim CajeroInf As New CajeroInfo(sessionID)
        Dim CajeroSvc As New CajeroService(sessionID)
        GetDetail(CajeroSvc, CajeroInf, userCode, idSucursal, checkStatus)
        Return CajeroInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Cajero.
    ''' </summary>
    ''' <param name="Cajero">Paquete de informaci�n del tipo CajeroInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Cajero, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Cajero As CajeroInfo) As Integer
        Dim CajeroSvc As New CajeroService(Cajero.SessionID)
        Return Update(CajeroSvc, Cajero)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim CajeroSvc As New CajeroService(sessionID)
        Return GetNumberOfPages(CajeroSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Cajeros que coincidan con las condiciones especificadas.
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
    ''' Busca Cajeros que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim CajeroSvc As New CajeroService(sessionID)
        Return GetSearchResult(CajeroSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Cajeros.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim CajeroSvc As New CajeroService(sessionID)
        Return GetSearchStructure(CajeroSvc)
    End Function

#End Region

End Class
