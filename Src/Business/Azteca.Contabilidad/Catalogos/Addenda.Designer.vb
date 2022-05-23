''' <summary>
''' Paquete de información que representa un Addenda
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class AddendaInfo
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
''' Proveedor de servicios para el manejo del catálogo de CFDAddendas
''' </summary>
''' <remarks></remarks>
Public Class AddendaService
    Inherits CatalogService(Of AddendaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "CFDAddendas", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idAddenda As Integer, ByRef Addenda As AddendaInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idAddenda, Addenda, checkStatus)
        With Addenda
            .Nombre = CStr(Me.ItemInfo("Nombre"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Addenda As AddendaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Addenda.Nombre

        End With
        Return MyBase.Update(Addenda)
    End Function

    Public Overrides Function Create() As AddendaInfo
        Return New AddendaInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de CFDAddendas
''' </summary>
''' <remarks></remarks>
Public Class AddendaFacade
    Inherits CatalogFacade(Of AddendaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un AddendaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As AddendaInfo
        Dim AddendaSvc As New AddendaService(sessionID)
        Return AddendaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de CFDAddendas
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idAddenda">Identificador del Addenda que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idAddenda As Integer)
        Dim AddendaSvc As New AddendaService(sessionID)
        Delete(AddendaSvc, idAddenda)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Addenda con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idAddenda">ID de Addenda que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idAddenda As Integer) As Boolean
        Dim AddendaSvc As New AddendaService(sessionID)
        Return Exists(AddendaSvc, idAddenda)
    End Function

    ''' <summary>
    ''' Verifica si existe un Addenda con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim AddendaSvc As New AddendaService(sessionID)
        Return Exists(AddendaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Addenda.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idAddenda">Identificador de Addenda a consultar</param>
    ''' <returns>Paquete de información de tipo AddendaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idAddenda As Integer) As AddendaInfo
        Return Me.GetDetail(sessionID, idAddenda, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Addenda.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idAddenda">Identificador de Addenda</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Addenda.</param>
    ''' <returns>Paquete de información de tipo AddendaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idAddenda As Integer, ByVal checkStatus As Boolean) As AddendaInfo
        Dim AddendaSvc As New AddendaService(sessionID)
        Dim AddendaInf As New AddendaInfo(sessionID)
        GetDetail(AddendaSvc, AddendaInf, idAddenda, checkStatus)
        Return AddendaInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Addenda en base a su codigo de usuario
    ''' y verifica que el Addenda esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información AddendaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As AddendaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Addenda en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Addenda</param>
    ''' <returns>Paquete de información AddendaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As AddendaInfo
        Dim AddendaInf As New AddendaInfo(sessionID)
        Dim AddendaSvc As New AddendaService(sessionID)
        GetDetail(AddendaSvc, AddendaInf, userCode, idSucursal, checkStatus)
        Return AddendaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Addenda.
    ''' </summary>
    ''' <param name="Addenda">Paquete de información del tipo AddendaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Addenda, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Addenda As AddendaInfo) As Integer
        Dim AddendaSvc As New AddendaService(Addenda.SessionID)
        Return Update(AddendaSvc, Addenda)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim AddendaSvc As New AddendaService(sessionID)
        Return GetNumberOfPages(AddendaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca CFDAddendas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca CFDAddendas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim AddendaSvc As New AddendaService(sessionID)
        Return GetSearchResult(AddendaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de CFDAddendas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim AddendaSvc As New AddendaService(sessionID)
        Return GetSearchStructure(AddendaSvc)
    End Function

#End Region

End Class
