Imports Azteca.Kernel

''' <summary>
''' Paquete de información que representa un Serie
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class SerieInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Friend _UltimoFolio As Integer
    Friend _FolioLimite As Integer
    Friend _Certificado As String
    Private _Folios As CertificadoDS.FoliosDataTable
#End Region

#Region "Propiedades"

    Public Property Serie As String

    Public Property IdCertificado As Integer

    Public ReadOnly Property UltimoFolio As Integer
        Get
            Return _UltimoFolio
        End Get
    End Property

    Public ReadOnly Property FolioLimite As Integer
        Get
            Return _FolioLimite
        End Get
    End Property

    Public ReadOnly Property Certificado As String
        Get
            Return _Certificado
        End Get
    End Property

    Public ReadOnly Property Folios As CertificadoDS.FoliosDataTable
        Get
            Return _Folios
        End Get
    End Property

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        _Folios = New CertificadoDS.FoliosDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de CFDSeries
''' </summary>
''' <remarks></remarks>
Public Class SerieService
    Inherits CatalogService(Of SerieInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "CFDSeries", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idSerie As Integer, ByRef Serie As SerieInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idSerie, Serie, checkStatus)
        With Serie
            .Serie = CStr(Me.ItemInfo("Serie")).Trim
            .IdCertificado = CInt(Me.ItemInfo("IdCFDCertificado"))
            ._UltimoFolio = CInt(Me.ItemInfo("UltimoFolio"))
            ._FolioLimite = CInt(Me.ItemInfo("FolioLimite"))
            ._Certificado = ItemInfo("Certificado").ToString
        End With
    End Sub

    Public Overrides Function Update(ByVal Serie As SerieInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Serie", DbType.String).Value = Serie.Serie
            .Add("@IdCFDCertificado", DbType.Int32).Value = Serie.IdCertificado
        End With
        Dim IdSerie As Integer = MyBase.Update(Serie)
        Dim CacheKey As String = "CFDSerie" & IdSerie.ToString
        If Cache.Item(CacheKey) IsNot Nothing Then Cache.Remove(CacheKey)
        Return IdSerie
    End Function

    Public Overrides Function Create() As SerieInfo
        Return New SerieInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de CFDSeries
''' </summary>
''' <remarks></remarks>
Public Class SerieFacade
    Inherits CatalogFacade(Of SerieInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un SerieInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As SerieInfo
        Dim SerieSvc As New SerieService(sessionID)
        Return SerieSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de CFDSeries
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idSerie">Identificador del Serie que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idSerie As Integer)
        Dim SerieSvc As New SerieService(sessionID)
        Delete(SerieSvc, idSerie)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Serie con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idSerie">ID de Serie que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idSerie As Integer) As Boolean
        Dim SerieSvc As New SerieService(sessionID)
        Return Exists(SerieSvc, idSerie)
    End Function

    ''' <summary>
    ''' Verifica si existe un Serie con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim SerieSvc As New SerieService(sessionID)
        Return Exists(SerieSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Serie.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idSerie">Identificador de Serie a consultar</param>
    ''' <returns>Paquete de información de tipo SerieInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idSerie As Integer) As SerieInfo
        Return Me.GetDetail(sessionID, idSerie, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Serie.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idSerie">Identificador de Serie</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Serie.</param>
    ''' <returns>Paquete de información de tipo SerieInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idSerie As Integer, ByVal checkStatus As Boolean) As SerieInfo
        Dim SerieSvc As New SerieService(sessionID)
        Dim SerieInf As New SerieInfo(sessionID)
        GetDetail(SerieSvc, SerieInf, idSerie, checkStatus)
        Return SerieInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Serie en base a su codigo de usuario
    ''' y verifica que el Serie esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información SerieInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As SerieInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Serie en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Serie</param>
    ''' <returns>Paquete de información SerieInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As SerieInfo
        Dim SerieInf As New SerieInfo(sessionID)
        Dim SerieSvc As New SerieService(sessionID)
        GetDetail(SerieSvc, SerieInf, userCode, idSucursal, checkStatus)
        Return SerieInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Serie.
    ''' </summary>
    ''' <param name="Serie">Paquete de información del tipo SerieInfo con la información a actualizar</param>
    ''' <returns>Identificador de Serie, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Serie As SerieInfo) As Integer
        Dim SerieSvc As New SerieService(Serie.SessionID)
        Return Update(SerieSvc, Serie)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim SerieSvc As New SerieService(sessionID)
        Return GetNumberOfPages(SerieSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca CFDSeries que coincidan con las condiciones especificadas.
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
    ''' Busca CFDSeries que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim SerieSvc As New SerieService(sessionID)
        Return GetSearchResult(SerieSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de CFDSeries.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim SerieSvc As New SerieService(sessionID)
        Return GetSearchStructure(SerieSvc)
    End Function

#End Region

End Class
