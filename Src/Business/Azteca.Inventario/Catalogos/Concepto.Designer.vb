''' <summary>
''' Paquete de informaci�n que representa un Concepto
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ConceptoInfo
    Inherits CatalogInfo

#Region "Campos Privados"
    Private _TipoDocumento As TipoDocumentoInfo

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property Tipo As TipoConcepto

    Public Property IdClasificacion As Integer

    Public Property Automatico As Boolean

    Public Property DiasVigencia As Integer

    Public Property IdCuenta As Integer

    Public ReadOnly Property TipoDocumento As TipoDocumentoInfo
        Get

            Return _TipoDocumento
        End Get
    End Property

#End Region

#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        _TipoDocumento = New TipoDocumentoInfo(sessionID)
    End Sub
#End Region

End Class

Public Enum TipoConcepto
    Entrada
    Salida
    Traspaso
End Enum


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Conceptos
''' </summary>
''' <remarks></remarks>
Public Class ConceptoService
    Inherits CatalogService(Of ConceptoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "Conceptos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idConcepto As Integer, ByRef Concepto As ConceptoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idConcepto, Concepto, checkStatus)
        With Concepto
            .Nombre = CStr(ItemInfo("Nombre"))
            .Tipo = GetTipoConcepto(CStr(ItemInfo("Tipo")))
            .Automatico = CBool(ItemInfo("Automatico"))
            .DiasVigencia = CInt(ItemInfo("DiasVigencia"))
            .IdClasificacion = CInt(ItemInfo("IdConceptoClasificacion"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            'Obtener informaci�n del tipo de documento
            Dim IdTipoDocumento As Integer = CInt(ItemInfo("IdDocumentoTipo"))
            Dim Svc As New TipoDocumentoService(sessionID, Connection, Transaction)
            Svc.GetDetail(IdTipoDocumento, .TipoDocumento, False)
        End With
    End Sub

    Public Overrides Function Update(ByVal Concepto As ConceptoInfo) As Integer
        'Guardar la informaci�n del concepto
        With Concepto.TipoDocumento
            .UserCode = String.Empty
            .IdSucursal = Concepto.IdSucursal
            .IdEmpresa = Concepto.IdEmpresa
            .Nombre = Concepto.Nombre
            .Status = Concepto.Status
        End With
        Dim Svc As New TipoDocumentoService(sessionID, Connection, Transaction)
        Dim IdTipoDocumento = Svc.Update(Concepto.TipoDocumento)
        'Guardar informaci�n del concepto
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Concepto.Nombre
            .Add("@Tipo", DbType.String).Value = GetTipoConcepto(Concepto.Tipo)
            .Add("@IdConceptoClasificacion", DbType.Int32).Value = Concepto.IdClasificacion
            .Add("@IdDocumentoTipo", DbType.Int32).Value = IdTipoDocumento
            .Add("@Automatico", DbType.Boolean).Value = Concepto.Automatico
            .Add("@DiasVigencia", DbType.Int32).Value = Concepto.DiasVigencia
            .Add("@IdCuenta", DbType.Int32).Value = Concepto.IdCuenta
        End With
        Return MyBase.Update(Concepto)
    End Function

    Public Overrides Function Create() As ConceptoInfo
        Return New ConceptoInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"

    Private Function GetTipoConcepto(ByVal tipo As String) As TipoConcepto
        Select Case tipo
            Case "E"
                Return TipoConcepto.Entrada
            Case "S"
                Return TipoConcepto.Salida
            Case "T"
                Return TipoConcepto.Traspaso
            Case Else
                Return TipoConcepto.Entrada
        End Select
    End Function

    Private Function GetTipoConcepto(ByVal tipo As TipoConcepto) As String
        Select Case tipo
            Case TipoConcepto.Entrada
                Return "E"
            Case TipoConcepto.Salida
                Return "S"
            Case TipoConcepto.Traspaso
                Return "T"
            Case Else
                Return String.Empty
        End Select
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Conceptos
''' </summary>
''' <remarks></remarks>
Public Class ConceptoFacade
    Inherits CatalogFacade(Of ConceptoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ConceptoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ConceptoInfo
        Dim ConceptoSvc As New ConceptoService(sessionID)
        Return ConceptoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Conceptos
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idConcepto">Identificador del Concepto que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idConcepto As Integer)
        Dim ConceptoSvc As New ConceptoService(sessionID)
        Delete(ConceptoSvc, idConcepto)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Concepto con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idConcepto">ID de Concepto que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idConcepto As Integer) As Boolean
        Dim ConceptoSvc As New ConceptoService(sessionID)
        Return Exists(ConceptoSvc, idConcepto)
    End Function

    ''' <summary>
    ''' Verifica si existe un Concepto con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ConceptoSvc As New ConceptoService(sessionID)
        Return Exists(ConceptoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Concepto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idConcepto">Identificador de Concepto a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo ConceptoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idConcepto As Integer) As ConceptoInfo
        Return Me.GetDetail(sessionID, idConcepto, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Concepto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idConcepto">Identificador de Concepto</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Concepto.</param>
    ''' <returns>Paquete de informaci�n de tipo ConceptoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idConcepto As Integer, ByVal checkStatus As Boolean) As ConceptoInfo
        Dim ConceptoSvc As New ConceptoService(sessionID)
        Dim ConceptoInf As New ConceptoInfo(sessionID)
        GetDetail(ConceptoSvc, ConceptoInf, idConcepto, checkStatus)
        Return ConceptoInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Concepto en base a su codigo de usuario
    ''' y verifica que el Concepto est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n ConceptoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ConceptoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Concepto en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Concepto</param>
    ''' <returns>Paquete de informaci�n ConceptoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ConceptoInfo
        Dim ConceptoInf As New ConceptoInfo(sessionID)
        Dim ConceptoSvc As New ConceptoService(sessionID)
        GetDetail(ConceptoSvc, ConceptoInf, userCode, idSucursal, checkStatus)
        Return ConceptoInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Concepto.
    ''' </summary>
    ''' <param name="Concepto">Paquete de informaci�n del tipo ConceptoInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Concepto, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Concepto As ConceptoInfo) As Integer
        Dim ConceptoSvc As New ConceptoService(Concepto.SessionID)
        Return Update(ConceptoSvc, Concepto)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ConceptoSvc As New ConceptoService(sessionID)
        Return GetNumberOfPages(ConceptoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Conceptos que coincidan con las condiciones especificadas.
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
    ''' Busca Conceptos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ConceptoSvc As New ConceptoService(sessionID)
        Return GetSearchResult(ConceptoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Conceptos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ConceptoSvc As New ConceptoService(sessionID)
        Return GetSearchStructure(ConceptoSvc)
    End Function

#End Region

End Class
