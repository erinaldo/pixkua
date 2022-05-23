Imports Azteca.Kernel

''' <summary>
''' Paquete de información que representa un UnidadMedida
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class UnidadMedidaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"

    Public Property Nombre As String

    Public Property Abreviatura As String

    Public Property IdTipoUnidad As Integer

    Public Property Base As Boolean

    Public Property Factor As Decimal

    Public Property Fraccionable As Boolean


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de UnidadesMedida
''' </summary>
''' <remarks></remarks>
Public Class UnidadMedidaService
    Inherits CatalogService(Of UnidadMedidaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "UnidadesMedida", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"

    Public Overrides Sub GetDetail(ByVal idUnidadMedida As Integer, ByRef UnidadMedida As UnidadMedidaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idUnidadMedida, UnidadMedida, checkStatus)
        With UnidadMedida
            .Nombre = CStr(ItemInfo("Nombre"))
            .Abreviatura = ItemInfo("Abreviatura").ToString
            .IdTipoUnidad = CInt(ItemInfo("IdUnidadMedidaTipo"))
            .Base = CBool(ItemInfo("Base"))
            .Factor = CDec(ItemInfo("Factor"))
            .Fraccionable = CBool(ItemInfo("Fraccionable"))
        End With
    End Sub

    Public Overrides Function Update(ByVal UnidadMedida As UnidadMedidaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = UnidadMedida.Nombre
            .Add("@Abreviatura", DbType.String).Value = UnidadMedida.Abreviatura
            .Add("@IdUnidadMedidaTipo", DbType.Int32).Value = UnidadMedida.IdTipoUnidad
            .Add("@Base", DbType.Boolean).Value = UnidadMedida.Base
            .Add("@Factor", DbType.Decimal).Value = UnidadMedida.Factor
            .Add("@Fraccionable", DbType.Boolean).Value = UnidadMedida.Fraccionable
        End With
        Dim IdUnidadMedida As Integer = MyBase.Update(UnidadMedida)
        Dim CacheKey As String = "UnidadMedida" & IdUnidadMedida
        Cache.Remove(CacheKey)
        Cache.Remove("UnidadesMedida")
        Return IdUnidadMedida
    End Function

    Public Overrides Sub Delete(ByVal idUnidadMedida As Integer)
        Dim TipoUnidadFac As New TipoUnidadMedidaFacade
        'Cargar la información de la unidad de medida
        Dim UnidadMedida As New UnidadMedidaInfo(sessionID)
        Dim UnidadMedidaSvc As New UnidadMedidaService(sessionID, Connection, Transaction)
        UnidadMedidaSvc.GetDetail(idUnidadMedida, UnidadMedida, False)
        'Si es la unidad de medida base, no permitir la eliminación
        If UnidadMedida.Base Then
            Throw New BusinessException("No es posible eliminar la unidad de medida base. Primero debe reemplazarla con otra unidad de medida.")
        Else
            MyBase.Delete(idUnidadMedida)
        End If
    End Sub

    Public Overrides Function Create() As UnidadMedidaInfo
        Return New UnidadMedidaInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"

    Public Function IsValid() As Boolean
        IsValid = False

    End Function
#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de UnidadesMedida
''' </summary>
''' <remarks></remarks>
Public Class UnidadMedidaFacade
    Inherits CatalogFacade(Of UnidadMedidaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un UnidadMedidaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As UnidadMedidaInfo
        Dim UnidadMedidaSvc As New UnidadMedidaService(sessionID)
        Return UnidadMedidaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de UnidadesMedida
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idUnidadMedida">Identificador del UnidadMedida que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idUnidadMedida As Integer)
        Dim UnidadMedidaSvc As New UnidadMedidaService(sessionID)
        Delete(UnidadMedidaSvc, idUnidadMedida)
    End Sub

    ''' <summary>
    ''' Verifica si existe un UnidadMedida con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idUnidadMedida">ID de UnidadMedida que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idUnidadMedida As Integer) As Boolean
        Dim UnidadMedidaSvc As New UnidadMedidaService(sessionID)
        Return Exists(UnidadMedidaSvc, idUnidadMedida)
    End Function

    ''' <summary>
    ''' Verifica si existe un UnidadMedida con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim UnidadMedidaSvc As New UnidadMedidaService(sessionID)
        Return Exists(UnidadMedidaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un UnidadMedida.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idUnidadMedida">Identificador de UnidadMedida a consultar</param>
    ''' <returns>Paquete de información de tipo UnidadMedidaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idUnidadMedida As Integer) As UnidadMedidaInfo
        Return Me.GetDetail(sessionID, idUnidadMedida, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un UnidadMedida.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idUnidadMedida">Identificador de UnidadMedida</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del UnidadMedida.</param>
    ''' <returns>Paquete de información de tipo UnidadMedidaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idUnidadMedida As Integer, ByVal checkStatus As Boolean) As UnidadMedidaInfo
        Dim UnidadMedidaSvc As New UnidadMedidaService(sessionID)
        Dim UnidadMedidaInf As New UnidadMedidaInfo(sessionID)
        GetDetail(UnidadMedidaSvc, UnidadMedidaInf, idUnidadMedida, checkStatus)
        Return UnidadMedidaInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un UnidadMedida en base a su codigo de usuario
    ''' y verifica que el UnidadMedida esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información UnidadMedidaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As UnidadMedidaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un UnidadMedida en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del UnidadMedida</param>
    ''' <returns>Paquete de información UnidadMedidaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As UnidadMedidaInfo
        Dim UnidadMedidaInf As New UnidadMedidaInfo(sessionID)
        Dim UnidadMedidaSvc As New UnidadMedidaService(sessionID)
        GetDetail(UnidadMedidaSvc, UnidadMedidaInf, userCode, idSucursal, checkStatus)
        Return UnidadMedidaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un UnidadMedida.
    ''' </summary>
    ''' <param name="UnidadMedida">Paquete de información del tipo UnidadMedidaInfo con la información a actualizar</param>
    ''' <returns>Identificador de UnidadMedida, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal UnidadMedida As UnidadMedidaInfo) As Integer
        Dim UnidadMedidaSvc As New UnidadMedidaService(UnidadMedida.SessionID)
        Return Update(UnidadMedidaSvc, UnidadMedida)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim UnidadMedidaSvc As New UnidadMedidaService(sessionID)
        Return GetNumberOfPages(UnidadMedidaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca UnidadesMedida que coincidan con las condiciones especificadas.
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
    ''' Busca UnidadesMedida que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim UnidadMedidaSvc As New UnidadMedidaService(sessionID)
        Return GetSearchResult(UnidadMedidaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de UnidadesMedida.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim UnidadMedidaSvc As New UnidadMedidaService(sessionID)
        Return GetSearchStructure(UnidadMedidaSvc)
    End Function

#End Region

End Class
