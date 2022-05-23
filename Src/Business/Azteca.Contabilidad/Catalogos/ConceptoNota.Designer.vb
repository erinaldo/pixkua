''' <summary>
''' Paquete de información que representa un ConceptoNota
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ConceptoNotaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdCuenta As Integer

    Public Property ConceptoLibre As Boolean


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de NotasConceptos
''' </summary>
''' <remarks></remarks>
Public Class ConceptoNotaService
    Inherits CatalogService(Of ConceptoNotaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "NotasConceptos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idConceptoNota As Integer, ByRef ConceptoNota As ConceptoNotaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idConceptoNota, ConceptoNota, checkStatus)
        With ConceptoNota
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .ConceptoLibre = CBool(ItemInfo("ConceptoLibre"))
        End With
    End Sub

    Public Overrides Function Update(ByVal ConceptoNota As ConceptoNotaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = ConceptoNota.Nombre
            .Add("@IdCuenta", DbType.Int32).Value = ConceptoNota.IdCuenta
            .Add("@ConceptoLibre", DbType.Boolean).Value = ConceptoNota.ConceptoLibre
        End With
        Return MyBase.Update(ConceptoNota)
    End Function

    Public Overrides Function Create() As ConceptoNotaInfo
        Return New ConceptoNotaInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de NotasConceptos
''' </summary>
''' <remarks></remarks>
Public Class ConceptoNotaFacade
    Inherits CatalogFacade(Of ConceptoNotaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ConceptoNotaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ConceptoNotaInfo
        Dim ConceptoNotaSvc As New ConceptoNotaService(sessionID)
        Return ConceptoNotaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de NotasConceptos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idConceptoNota">Identificador del ConceptoNota que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idConceptoNota As Integer)
        Dim ConceptoNotaSvc As New ConceptoNotaService(sessionID)
        Delete(ConceptoNotaSvc, idConceptoNota)
    End Sub

    ''' <summary>
    ''' Verifica si existe un ConceptoNota con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idConceptoNota">ID de ConceptoNota que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idConceptoNota As Integer) As Boolean
        Dim ConceptoNotaSvc As New ConceptoNotaService(sessionID)
        Return Exists(ConceptoNotaSvc, idConceptoNota)
    End Function

    ''' <summary>
    ''' Verifica si existe un ConceptoNota con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ConceptoNotaSvc As New ConceptoNotaService(sessionID)
        Return Exists(ConceptoNotaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ConceptoNota.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idConceptoNota">Identificador de ConceptoNota a consultar</param>
    ''' <returns>Paquete de información de tipo ConceptoNotaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idConceptoNota As Integer) As ConceptoNotaInfo
        Return Me.GetDetail(sessionID, idConceptoNota, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ConceptoNota.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idConceptoNota">Identificador de ConceptoNota</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ConceptoNota.</param>
    ''' <returns>Paquete de información de tipo ConceptoNotaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idConceptoNota As Integer, ByVal checkStatus As Boolean) As ConceptoNotaInfo
        Dim ConceptoNotaSvc As New ConceptoNotaService(sessionID)
        Dim ConceptoNotaInf As New ConceptoNotaInfo(sessionID)
        GetDetail(ConceptoNotaSvc, ConceptoNotaInf, idConceptoNota, checkStatus)
        Return ConceptoNotaInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un ConceptoNota en base a su codigo de usuario
    ''' y verifica que el ConceptoNota esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ConceptoNotaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ConceptoNotaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un ConceptoNota en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del ConceptoNota</param>
    ''' <returns>Paquete de información ConceptoNotaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ConceptoNotaInfo
        Dim ConceptoNotaInf As New ConceptoNotaInfo(sessionID)
        Dim ConceptoNotaSvc As New ConceptoNotaService(sessionID)
        GetDetail(ConceptoNotaSvc, ConceptoNotaInf, userCode, idSucursal, checkStatus)
        Return ConceptoNotaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un ConceptoNota.
    ''' </summary>
    ''' <param name="ConceptoNota">Paquete de información del tipo ConceptoNotaInfo con la información a actualizar</param>
    ''' <returns>Identificador de ConceptoNota, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal ConceptoNota As ConceptoNotaInfo) As Integer
        Dim ConceptoNotaSvc As New ConceptoNotaService(ConceptoNota.SessionID)
        Return Update(ConceptoNotaSvc, ConceptoNota)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ConceptoNotaSvc As New ConceptoNotaService(sessionID)
        Return GetNumberOfPages(ConceptoNotaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca NotasConceptos que coincidan con las condiciones especificadas.
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
    ''' Busca NotasConceptos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ConceptoNotaSvc As New ConceptoNotaService(sessionID)
        Return GetSearchResult(ConceptoNotaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de NotasConceptos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ConceptoNotaSvc As New ConceptoNotaService(sessionID)
        Return GetSearchStructure(ConceptoNotaSvc)
    End Function

#End Region

End Class
