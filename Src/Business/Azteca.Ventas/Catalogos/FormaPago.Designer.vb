''' <summary>
''' Paquete de informaci�n que representa un FormaPago
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class FormaPagoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String
    Public Property IdCuenta As Integer

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de FormasPago
''' </summary>
''' <remarks></remarks>
Public Class FormaPagoService
    Inherits CatalogService(Of FormaPagoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "FormasPago", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idFormaPago As Integer, ByRef FormaPago As FormaPagoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idFormaPago, FormaPago, checkStatus)
        With FormaPago
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
        End With
    End Sub

    Public Overrides Function Update(ByVal FormaPago As FormaPagoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = FormaPago.Nombre
            .Add("@IdCuenta", DbType.Int32).Value = FormaPago.IdCuenta
        End With
        Return MyBase.Update(FormaPago)
    End Function

    Public Overrides Function Create() As FormaPagoInfo
        Return New FormaPagoInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de FormasPago
''' </summary>
''' <remarks></remarks>
Public Class FormaPagoFacade
    Inherits CatalogFacade(Of FormaPagoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un FormaPagoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As FormaPagoInfo
        Dim FormaPagoSvc As New FormaPagoService(sessionID)
        Return FormaPagoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de FormasPago
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idFormaPago">Identificador del FormaPago que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idFormaPago As Integer)
        Dim FormaPagoSvc As New FormaPagoService(sessionID)
        Delete(FormaPagoSvc, idFormaPago)
    End Sub

    ''' <summary>
    ''' Verifica si existe un FormaPago con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idFormaPago">ID de FormaPago que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idFormaPago As Integer) As Boolean
        Dim FormaPagoSvc As New FormaPagoService(sessionID)
        Return Exists(FormaPagoSvc, idFormaPago)
    End Function

    ''' <summary>
    ''' Verifica si existe un FormaPago con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim FormaPagoSvc As New FormaPagoService(sessionID)
        Return Exists(FormaPagoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un FormaPago.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idFormaPago">Identificador de FormaPago a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo FormaPagoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idFormaPago As Integer) As FormaPagoInfo
        Return Me.GetDetail(sessionID, idFormaPago, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un FormaPago.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idFormaPago">Identificador de FormaPago</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del FormaPago.</param>
    ''' <returns>Paquete de informaci�n de tipo FormaPagoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idFormaPago As Integer, ByVal checkStatus As Boolean) As FormaPagoInfo
        Dim FormaPagoSvc As New FormaPagoService(sessionID)
        Dim FormaPagoInf As New FormaPagoInfo(sessionID)
        GetDetail(FormaPagoSvc, FormaPagoInf, idFormaPago, checkStatus)
        Return FormaPagoInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un FormaPago en base a su codigo de usuario
    ''' y verifica que el FormaPago est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n FormaPagoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As FormaPagoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un FormaPago en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del FormaPago</param>
    ''' <returns>Paquete de informaci�n FormaPagoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As FormaPagoInfo
        Dim FormaPagoInf As New FormaPagoInfo(sessionID)
        Dim FormaPagoSvc As New FormaPagoService(sessionID)
        GetDetail(FormaPagoSvc, FormaPagoInf, userCode, idSucursal, checkStatus)
        Return FormaPagoInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un FormaPago.
    ''' </summary>
    ''' <param name="FormaPago">Paquete de informaci�n del tipo FormaPagoInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de FormaPago, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal FormaPago As FormaPagoInfo) As Integer
        Dim FormaPagoSvc As New FormaPagoService(FormaPago.SessionID)
        Return Update(FormaPagoSvc, FormaPago)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim FormaPagoSvc As New FormaPagoService(sessionID)
        Return GetNumberOfPages(FormaPagoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca FormasPago que coincidan con las condiciones especificadas.
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
    ''' Busca FormasPago que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim FormaPagoSvc As New FormaPagoService(sessionID)
        Return GetSearchResult(FormaPagoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de FormasPago.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim FormaPagoSvc As New FormaPagoService(sessionID)
        Return GetSearchStructure(FormaPagoSvc)
    End Function

#End Region

End Class
