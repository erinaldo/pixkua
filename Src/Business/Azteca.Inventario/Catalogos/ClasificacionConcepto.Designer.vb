''' <summary>
''' Paquete de información que representa un ClasificacionConcepto
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ClasificacionConceptoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de ConceptosClasificaciones
''' </summary>
''' <remarks></remarks>
Public Class ClasificacionConceptoService
    Inherits CatalogService(Of ClasificacionConceptoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "ConceptosClasificaciones", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idClasificacionConcepto As Integer, ByRef ClasificacionConcepto As ClasificacionConceptoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idClasificacionConcepto, ClasificacionConcepto, checkStatus)
        With ClasificacionConcepto
            .Nombre = CStr(ItemInfo("Nombre"))

        End With
    End Sub

    Public Overrides Function Update(ByVal ClasificacionConcepto As ClasificacionConceptoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = ClasificacionConcepto.Nombre

        End With
        Return MyBase.Update(ClasificacionConcepto)
    End Function

    Public Overrides Function Create() As ClasificacionConceptoInfo
        Return New ClasificacionConceptoInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de ConceptosClasificaciones
''' </summary>
''' <remarks></remarks>
Public Class ClasificacionConceptoFacade
    Inherits CatalogFacade(Of ClasificacionConceptoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ClasificacionConceptoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ClasificacionConceptoInfo
        Dim ClasificacionConceptoSvc As New ClasificacionConceptoService(sessionID)
        Return ClasificacionConceptoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de ConceptosClasificaciones
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idClasificacionConcepto">Identificador del ClasificacionConcepto que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idClasificacionConcepto As Integer)
        Dim ClasificacionConceptoSvc As New ClasificacionConceptoService(sessionID)
        Delete(ClasificacionConceptoSvc, idClasificacionConcepto)
    End Sub

    ''' <summary>
    ''' Verifica si existe un ClasificacionConcepto con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idClasificacionConcepto">ID de ClasificacionConcepto que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idClasificacionConcepto As Integer) As Boolean
        Dim ClasificacionConceptoSvc As New ClasificacionConceptoService(sessionID)
        Return Exists(ClasificacionConceptoSvc, idClasificacionConcepto)
    End Function

    ''' <summary>
    ''' Verifica si existe un ClasificacionConcepto con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ClasificacionConceptoSvc As New ClasificacionConceptoService(sessionID)
        Return Exists(ClasificacionConceptoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ClasificacionConcepto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idClasificacionConcepto">Identificador de ClasificacionConcepto a consultar</param>
    ''' <returns>Paquete de información de tipo ClasificacionConceptoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idClasificacionConcepto As Integer) As ClasificacionConceptoInfo
        Return Me.GetDetail(sessionID, idClasificacionConcepto, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ClasificacionConcepto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idClasificacionConcepto">Identificador de ClasificacionConcepto</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ClasificacionConcepto.</param>
    ''' <returns>Paquete de información de tipo ClasificacionConceptoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idClasificacionConcepto As Integer, ByVal checkStatus As Boolean) As ClasificacionConceptoInfo
        Dim ClasificacionConceptoSvc As New ClasificacionConceptoService(sessionID)
        Dim ClasificacionConceptoInf As New ClasificacionConceptoInfo(sessionID)
        GetDetail(ClasificacionConceptoSvc, ClasificacionConceptoInf, idClasificacionConcepto, checkStatus)
        Return ClasificacionConceptoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un ClasificacionConcepto en base a su codigo de usuario
    ''' y verifica que el ClasificacionConcepto esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ClasificacionConceptoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ClasificacionConceptoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ClasificacionConcepto en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ClasificacionConcepto</param>
    ''' <returns>Paquete de información ClasificacionConceptoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ClasificacionConceptoInfo
        Dim ClasificacionConceptoInf As New ClasificacionConceptoInfo(sessionID)
        Dim ClasificacionConceptoSvc As New ClasificacionConceptoService(sessionID)
        GetDetail(ClasificacionConceptoSvc, ClasificacionConceptoInf, userCode, idSucursal, checkStatus)
        Return ClasificacionConceptoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un ClasificacionConcepto.
    ''' </summary>
    ''' <param name="ClasificacionConcepto">Paquete de información del tipo ClasificacionConceptoInfo con la información a actualizar</param>
    ''' <returns>Identificador de ClasificacionConcepto, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal ClasificacionConcepto As ClasificacionConceptoInfo) As Integer
        Dim ClasificacionConceptoSvc As New ClasificacionConceptoService(ClasificacionConcepto.SessionID)
        Return Update(ClasificacionConceptoSvc, ClasificacionConcepto)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ClasificacionConceptoSvc As New ClasificacionConceptoService(sessionID)
        Return GetNumberOfPages(ClasificacionConceptoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca ConceptosClasificaciones que coincidan con las condiciones especificadas.
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
    ''' Busca ConceptosClasificaciones que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ClasificacionConceptoSvc As New ClasificacionConceptoService(sessionID)
        Return GetSearchResult(ClasificacionConceptoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de ConceptosClasificaciones.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ClasificacionConceptoSvc As New ClasificacionConceptoService(sessionID)
        Return GetSearchStructure(ClasificacionConceptoSvc)
    End Function

#End Region

End Class
