''' <summary>
''' Paquete de informaci�n que representa un Caja
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CajaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdCorteActual As Guid

    Public Property IdCuenta As Integer

    Public Property IdImpresora As Integer

    Public Property GenerarFacturaGlobal As Boolean

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Cajas
''' </summary>
''' <remarks></remarks>
Public Class CajaService
    Inherits CatalogService(Of CajaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "Cajas", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCaja As Integer, ByRef Caja As CajaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idCaja, Caja, checkStatus)
        With Caja
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdCorteActual = CType(ItemInfo("IdCorteActual"), Guid)
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .IdImpresora = CInt(ItemInfo("IdImpresora"))
            .GenerarFacturaGlobal = CBool(ItemInfo("GenFactGlobal"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Caja As CajaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Caja.Nombre            
            .Add("@IdCuenta", DbType.Int32).Value = Caja.IdCuenta
            .Add("@IdImpresora", DbType.Int32).Value = Caja.IdImpresora
            .Add("@GenFactGlobal", DbType.Boolean).Value = Caja.GenerarFacturaGlobal
        End With
        Return MyBase.Update(Caja)
    End Function

    Public Overrides Function Create() As CajaInfo
        Return New CajaInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Cajas
''' </summary>
''' <remarks></remarks>
Public Class CajaFacade
    Inherits CatalogFacade(Of CajaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CajaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As CajaInfo
        Dim CajaSvc As New CajaService(sessionID)
        Return CajaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Cajas
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idCaja">Identificador del Caja que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idCaja As Integer)
        Dim CajaSvc As New CajaService(sessionID)
        Delete(CajaSvc, idCaja)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Caja con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idCaja">ID de Caja que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idCaja As Integer) As Boolean
        Dim CajaSvc As New CajaService(sessionID)
        Return Exists(CajaSvc, idCaja)
    End Function

    ''' <summary>
    ''' Verifica si existe un Caja con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim CajaSvc As New CajaService(sessionID)
        Return Exists(CajaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Caja.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idCaja">Identificador de Caja a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo CajaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCaja As Integer) As CajaInfo
        Return Me.GetDetail(sessionID, idCaja, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Caja.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idCaja">Identificador de Caja</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Caja.</param>
    ''' <returns>Paquete de informaci�n de tipo CajaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCaja As Integer, ByVal checkStatus As Boolean) As CajaInfo
        Dim CajaSvc As New CajaService(sessionID)
        Dim CajaInf As New CajaInfo(sessionID)
        GetDetail(CajaSvc, CajaInf, idCaja, checkStatus)
        Return CajaInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Caja en base a su codigo de usuario
    ''' y verifica que el Caja est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n CajaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As CajaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Caja en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Caja</param>
    ''' <returns>Paquete de informaci�n CajaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CajaInfo
        Dim CajaInf As New CajaInfo(sessionID)
        Dim CajaSvc As New CajaService(sessionID)
        GetDetail(CajaSvc, CajaInf, userCode, idSucursal, checkStatus)
        Return CajaInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Caja.
    ''' </summary>
    ''' <param name="Caja">Paquete de informaci�n del tipo CajaInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Caja, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Caja As CajaInfo) As Integer
        Dim CajaSvc As New CajaService(Caja.SessionID)
        Return Update(CajaSvc, Caja)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim CajaSvc As New CajaService(sessionID)
        Return GetNumberOfPages(CajaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Cajas que coincidan con las condiciones especificadas.
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
    ''' Busca Cajas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim CajaSvc As New CajaService(sessionID)
        Return GetSearchResult(CajaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Cajas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim CajaSvc As New CajaService(sessionID)
        Return GetSearchStructure(CajaSvc)
    End Function

#End Region

End Class
