''' <summary>
''' Paquete de informaci�n que representa un Impuesto
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ImpuestoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property Porcentaje As Decimal

    Public Property Abreviatura As String

    Public Property TipoImpuestoTransaladado As TipoImpuestoTraslado = TipoImpuestoTraslado.IVA

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Impuestos
''' </summary>
''' <remarks></remarks>
Public Class ImpuestoService
    Inherits CatalogService(Of ImpuestoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "Impuestos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idImpuesto As Integer, ByRef Impuesto As ImpuestoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idImpuesto, Impuesto, checkStatus)
        With Impuesto
            .Nombre = CStr(ItemInfo("Nombre"))
            .Porcentaje = CDec(ItemInfo("Porcentaje"))
            .Abreviatura = CStr(ItemInfo("Abrev"))
            .TipoImpuestoTransaladado = CInt(ItemInfo("TipoImpuesto"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Impuesto As ImpuestoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Impuesto.Nombre
            .Add("@Porcentaje", DbType.Decimal).Value = Impuesto.Porcentaje
            .Add("@Abrev", DbType.String).Value = Impuesto.Abreviatura
            .Add("@TipoImpuesto", DbType.Int32).Value = Impuesto.TipoImpuestoTransaladado
        End With
        Dim IdImpuesto As Integer = MyBase.Update(Impuesto)
        Azteca.Kernel.Cache.Remove("Impuesto_" & IdImpuesto.ToString)
        Return IdImpuesto
    End Function

    Public Overrides Function Create() As ImpuestoInfo
        Return New ImpuestoInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Impuestos
''' </summary>
''' <remarks></remarks>
Public Class ImpuestoFacade
    Inherits CatalogFacade(Of ImpuestoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ImpuestoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ImpuestoInfo
        Dim ImpuestoSvc As New ImpuestoService(sessionID)
        Return ImpuestoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Impuestos
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idImpuesto">Identificador del Impuesto que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idImpuesto As Integer)
        Dim ImpuestoSvc As New ImpuestoService(sessionID)
        Delete(ImpuestoSvc, idImpuesto)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Impuesto con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idImpuesto">ID de Impuesto que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idImpuesto As Integer) As Boolean
        Dim ImpuestoSvc As New ImpuestoService(sessionID)
        Return Exists(ImpuestoSvc, idImpuesto)
    End Function

    ''' <summary>
    ''' Verifica si existe un Impuesto con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ImpuestoSvc As New ImpuestoService(sessionID)
        Return Exists(ImpuestoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Impuesto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idImpuesto">Identificador de Impuesto a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo ImpuestoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idImpuesto As Integer) As ImpuestoInfo
        Return Me.GetDetail(sessionID, idImpuesto, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Impuesto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idImpuesto">Identificador de Impuesto</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Impuesto.</param>
    ''' <returns>Paquete de informaci�n de tipo ImpuestoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idImpuesto As Integer, ByVal checkStatus As Boolean) As ImpuestoInfo
        Dim ImpuestoSvc As New ImpuestoService(sessionID)
        Dim ImpuestoInf As New ImpuestoInfo(sessionID)
        GetDetail(ImpuestoSvc, ImpuestoInf, idImpuesto, checkStatus)
        Return ImpuestoInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Impuesto en base a su codigo de usuario
    ''' y verifica que el Impuesto est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n ImpuestoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ImpuestoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Impuesto en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Impuesto</param>
    ''' <returns>Paquete de informaci�n ImpuestoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ImpuestoInfo
        Dim ImpuestoInf As New ImpuestoInfo(sessionID)
        Dim ImpuestoSvc As New ImpuestoService(sessionID)
        GetDetail(ImpuestoSvc, ImpuestoInf, userCode, idSucursal, checkStatus)
        Return ImpuestoInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Impuesto.
    ''' </summary>
    ''' <param name="Impuesto">Paquete de informaci�n del tipo ImpuestoInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Impuesto, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Impuesto As ImpuestoInfo) As Integer
        Dim ImpuestoSvc As New ImpuestoService(Impuesto.SessionID)
        Return Update(ImpuestoSvc, Impuesto)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ImpuestoSvc As New ImpuestoService(sessionID)
        Return GetNumberOfPages(ImpuestoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Impuestos que coincidan con las condiciones especificadas.
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
    ''' Busca Impuestos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ImpuestoSvc As New ImpuestoService(sessionID)
        Return GetSearchResult(ImpuestoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Impuestos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ImpuestoSvc As New ImpuestoService(sessionID)
        Return GetSearchStructure(ImpuestoSvc)
    End Function

#End Region

End Class
