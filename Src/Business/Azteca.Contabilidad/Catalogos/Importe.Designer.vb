''' <summary>
''' Paquete de informaci�n que representa un Importe
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ImporteInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Descripcion As String

    Public Property Importe As String


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Importes
''' </summary>
''' <remarks></remarks>
Public Class ImporteService
    Inherits CatalogService(Of ImporteInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "Importes", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idImporte As Integer, ByRef Importe As ImporteInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idImporte, Importe, checkStatus)
        With Importe
            .Descripcion = CStr(ItemInfo("Descripcion"))
            .Importe = CStr(ItemInfo("Importe"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Importe As ImporteInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Descripcion", DbType.String).Value = Importe.Descripcion
            .Add("@Importe", DbType.String).Value = Importe.Importe

        End With
        Return MyBase.Update(Importe)
    End Function

    Public Overrides Function Create() As ImporteInfo
        Return New ImporteInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Importes
''' </summary>
''' <remarks></remarks>
Public Class ImporteFacade
    Inherits CatalogFacade(Of ImporteInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ImporteInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ImporteInfo
        Dim ImporteSvc As New ImporteService(sessionID)
        Return ImporteSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Importes
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idImporte">Identificador del Importe que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idImporte As Integer)
        Dim ImporteSvc As New ImporteService(sessionID)
        Delete(ImporteSvc, idImporte)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Importe con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idImporte">ID de Importe que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idImporte As Integer) As Boolean
        Dim ImporteSvc As New ImporteService(sessionID)
        Return Exists(ImporteSvc, idImporte)
    End Function

    ''' <summary>
    ''' Verifica si existe un Importe con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ImporteSvc As New ImporteService(sessionID)
        Return Exists(ImporteSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Importe.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idImporte">Identificador de Importe a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo ImporteInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idImporte As Integer) As ImporteInfo
        Return Me.GetDetail(sessionID, idImporte, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Importe.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idImporte">Identificador de Importe</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Importe.</param>
    ''' <returns>Paquete de informaci�n de tipo ImporteInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idImporte As Integer, ByVal checkStatus As Boolean) As ImporteInfo
        Dim ImporteSvc As New ImporteService(sessionID)
        Dim ImporteInf As New ImporteInfo(sessionID)
        GetDetail(ImporteSvc, ImporteInf, idImporte, checkStatus)
        Return ImporteInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Importe en base a su codigo de usuario
    ''' y verifica que el Importe est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n ImporteInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ImporteInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Importe en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Importe</param>
    ''' <returns>Paquete de informaci�n ImporteInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ImporteInfo
        Dim ImporteInf As New ImporteInfo(sessionID)
        Dim ImporteSvc As New ImporteService(sessionID)
        GetDetail(ImporteSvc, ImporteInf, userCode, idSucursal, checkStatus)
        Return ImporteInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Importe.
    ''' </summary>
    ''' <param name="Importe">Paquete de informaci�n del tipo ImporteInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Importe, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Importe As ImporteInfo) As Integer
        Dim ImporteSvc As New ImporteService(Importe.SessionID)
        Return Update(ImporteSvc, Importe)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ImporteSvc As New ImporteService(sessionID)
        Return GetNumberOfPages(ImporteSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Importes que coincidan con las condiciones especificadas.
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
    ''' Busca Importes que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ImporteSvc As New ImporteService(sessionID)
        Return GetSearchResult(ImporteSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Importes.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ImporteSvc As New ImporteService(sessionID)
        Return GetSearchStructure(ImporteSvc)
    End Function

#End Region

End Class
