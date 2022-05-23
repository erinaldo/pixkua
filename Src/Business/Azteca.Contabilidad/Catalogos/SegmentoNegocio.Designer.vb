''' <summary>
''' Paquete de información que representa un SegmentoNegocio
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class SegmentoNegocioInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Descripcion As String

    Public Property IdCuentaContable As Integer


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de SegmentosNegocio
''' </summary>
''' <remarks></remarks>
Public Class SegmentoNegocioService
    Inherits CatalogService(Of SegmentoNegocioInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "SegmentosNegocio", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idSegmentoNegocio As Integer, ByRef SegmentoNegocio As SegmentoNegocioInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idSegmentoNegocio, SegmentoNegocio, checkStatus)
        With SegmentoNegocio
            .Descripcion = CStr(ItemInfo("Descripcion"))
        End With
    End Sub

    Public Overrides Function Update(ByVal SegmentoNegocio As SegmentoNegocioInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Descripcion", DbType.String).Value = SegmentoNegocio.Descripcion
        End With
        Return MyBase.Update(SegmentoNegocio)
    End Function

    Public Overrides Function Create() As SegmentoNegocioInfo
        Return New SegmentoNegocioInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de SegmentosNegocio
''' </summary>
''' <remarks></remarks>
Public Class SegmentoNegocioFacade
    Inherits CatalogFacade(Of SegmentoNegocioInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un SegmentoNegocioInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As SegmentoNegocioInfo
        Dim SegmentoNegocioSvc As New SegmentoNegocioService(sessionID)
        Return SegmentoNegocioSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de SegmentosNegocio
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idSegmentoNegocio">Identificador del SegmentoNegocio que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idSegmentoNegocio As Integer)
        Dim SegmentoNegocioSvc As New SegmentoNegocioService(sessionID)
        Delete(SegmentoNegocioSvc, idSegmentoNegocio)
    End Sub

    ''' <summary>
    ''' Verifica si existe un SegmentoNegocio con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idSegmentoNegocio">ID de SegmentoNegocio que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idSegmentoNegocio As Integer) As Boolean
        Dim SegmentoNegocioSvc As New SegmentoNegocioService(sessionID)
        Return Exists(SegmentoNegocioSvc, idSegmentoNegocio)
    End Function

    ''' <summary>
    ''' Verifica si existe un SegmentoNegocio con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim SegmentoNegocioSvc As New SegmentoNegocioService(sessionID)
        Return Exists(SegmentoNegocioSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un SegmentoNegocio.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idSegmentoNegocio">Identificador de SegmentoNegocio a consultar</param>
    ''' <returns>Paquete de información de tipo SegmentoNegocioInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idSegmentoNegocio As Integer) As SegmentoNegocioInfo
        Return Me.GetDetail(sessionID, idSegmentoNegocio, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un SegmentoNegocio.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idSegmentoNegocio">Identificador de SegmentoNegocio</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del SegmentoNegocio.</param>
    ''' <returns>Paquete de información de tipo SegmentoNegocioInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idSegmentoNegocio As Integer, ByVal checkStatus As Boolean) As SegmentoNegocioInfo
        Dim SegmentoNegocioSvc As New SegmentoNegocioService(sessionID)
        Dim SegmentoNegocioInf As New SegmentoNegocioInfo(sessionID)
        GetDetail(SegmentoNegocioSvc, SegmentoNegocioInf, idSegmentoNegocio, checkStatus)
        Return SegmentoNegocioInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un SegmentoNegocio en base a su codigo de usuario
    ''' y verifica que el SegmentoNegocio esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información SegmentoNegocioInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As SegmentoNegocioInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un SegmentoNegocio en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del SegmentoNegocio</param>
    ''' <returns>Paquete de información SegmentoNegocioInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As SegmentoNegocioInfo
        Dim SegmentoNegocioInf As New SegmentoNegocioInfo(sessionID)
        Dim SegmentoNegocioSvc As New SegmentoNegocioService(sessionID)
        GetDetail(SegmentoNegocioSvc, SegmentoNegocioInf, userCode, idSucursal, checkStatus)
        Return SegmentoNegocioInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un SegmentoNegocio.
    ''' </summary>
    ''' <param name="SegmentoNegocio">Paquete de información del tipo SegmentoNegocioInfo con la información a actualizar</param>
    ''' <returns>Identificador de SegmentoNegocio, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal SegmentoNegocio As SegmentoNegocioInfo) As Integer
        Dim SegmentoNegocioSvc As New SegmentoNegocioService(SegmentoNegocio.SessionID)
        Return Update(SegmentoNegocioSvc, SegmentoNegocio)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim SegmentoNegocioSvc As New SegmentoNegocioService(sessionID)
        Return GetNumberOfPages(SegmentoNegocioSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca SegmentosNegocio que coincidan con las condiciones especificadas.
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
    ''' Busca SegmentosNegocio que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim SegmentoNegocioSvc As New SegmentoNegocioService(sessionID)
        Return GetSearchResult(SegmentoNegocioSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de SegmentosNegocio.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim SegmentoNegocioSvc As New SegmentoNegocioService(sessionID)
        Return GetSearchStructure(SegmentoNegocioSvc)
    End Function

#End Region

End Class
