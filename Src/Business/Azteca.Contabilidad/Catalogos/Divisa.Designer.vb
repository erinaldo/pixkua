Imports Azteca.Kernel

''' <summary>
''' Paquete de información que representa un Divisa
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class DivisaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"

    Public Property Nombre As String

    Public Property Abreviatura As String

    Public Property SerieBanxico As String

    Public Property Tipo As String

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Divisas
''' </summary>
''' <remarks></remarks>
Public Class DivisaService
    Inherits CatalogService(Of DivisaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "Divisas", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idDivisa As Integer, ByRef Divisa As DivisaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idDivisa, Divisa, checkStatus)
        With Divisa
            .Nombre = CStr(ItemInfo("Nombre"))
            .Abreviatura = CStr(ItemInfo("Abrev"))
            .Tipo = ItemInfo("Tipo").ToString
            .SerieBanxico = ItemInfo("SerieBanxico").ToString
        End With
    End Sub

    Public Overrides Function Update(ByVal Divisa As DivisaInfo) As Integer
        If Divisa.Identity > 0 Then Azteca.Kernel.Cache.Remove("Divisa" & Divisa.Identity)
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Divisa.Nombre
            .Add("@Abrev", DbType.String).Value = Divisa.Abreviatura
            .Add("@Tipo", DbType.String).Value = Divisa.Tipo
            .Add("@SerieBanxico", DbType.String).Value = Divisa.SerieBanxico
        End With
        Dim IdDivisa As Integer = MyBase.Update(Divisa)
        Dim CacheKey As String = "Divisa" & IdDivisa.ToString
        If Cache.Item(CacheKey) IsNot Nothing Then Cache.Remove(CacheKey)
        Return IdDivisa
    End Function

    Public Overrides Function Create() As DivisaInfo
        Return New DivisaInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Divisas
''' </summary>
''' <remarks></remarks>
Public Class DivisaFacade
    Inherits CatalogFacade(Of DivisaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un DivisaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As DivisaInfo
        Dim DivisaSvc As New DivisaService(sessionID)
        Return DivisaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Divisas
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDivisa">Identificador del Divisa que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idDivisa As Integer)
        Dim DivisaSvc As New DivisaService(sessionID)
        Delete(DivisaSvc, idDivisa)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Divisa con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDivisa">ID de Divisa que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idDivisa As Integer) As Boolean
        Dim DivisaSvc As New DivisaService(sessionID)
        Return Exists(DivisaSvc, idDivisa)
    End Function

    ''' <summary>
    ''' Verifica si existe un Divisa con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim DivisaSvc As New DivisaService(sessionID)
        Return Exists(DivisaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Divisa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDivisa">Identificador de Divisa a consultar</param>
    ''' <returns>Paquete de información de tipo DivisaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idDivisa As Integer) As DivisaInfo
        Return Me.GetDetail(sessionID, idDivisa, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Divisa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDivisa">Identificador de Divisa</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Divisa.</param>
    ''' <returns>Paquete de información de tipo DivisaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idDivisa As Integer, ByVal checkStatus As Boolean) As DivisaInfo
        Dim DivisaSvc As New DivisaService(sessionID)
        Dim DivisaInf As New DivisaInfo(sessionID)
        GetDetail(DivisaSvc, DivisaInf, idDivisa, checkStatus)
        Return DivisaInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Divisa en base a su codigo de usuario
    ''' y verifica que el Divisa esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información DivisaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As DivisaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Divisa en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Divisa</param>
    ''' <returns>Paquete de información DivisaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As DivisaInfo
        Dim DivisaInf As New DivisaInfo(sessionID)
        Dim DivisaSvc As New DivisaService(sessionID)
        GetDetail(DivisaSvc, DivisaInf, userCode, idSucursal, checkStatus)
        Return DivisaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Divisa.
    ''' </summary>
    ''' <param name="Divisa">Paquete de información del tipo DivisaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Divisa, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Divisa As DivisaInfo) As Integer
        Dim DivisaSvc As New DivisaService(Divisa.SessionID)
        Return Update(DivisaSvc, Divisa)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim DivisaSvc As New DivisaService(sessionID)
        Return GetNumberOfPages(DivisaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Divisas que coincidan con las condiciones especificadas.
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
    ''' Busca Divisas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim DivisaSvc As New DivisaService(sessionID)
        Return GetSearchResult(DivisaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Divisas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim DivisaSvc As New DivisaService(sessionID)
        Return GetSearchStructure(DivisaSvc)
    End Function

#End Region

End Class
