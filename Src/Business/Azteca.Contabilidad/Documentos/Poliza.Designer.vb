''' <summary>
''' Paquete de informaci�n que representa un Poliza
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class PolizaInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"

#End Region

#Region "Propiedades"
    Public Property IdPolizaPerfil As Integer
    Public Property Folio As Integer
    Friend _IdPolizaTipo As Integer
    Friend _AfectarSistemaExterno As Boolean

    Public ReadOnly Property IdPolizaTipo As Integer
        Get
            Return _IdPolizaTipo
        End Get
    End Property

    Public ReadOnly Property AfectarSistemaExterno As Boolean
        Get
            Return _AfectarSistemaExterno
        End Get
    End Property

  'Se debe de agregar un Dataset con este nombre y con esta tabla incluida.
  'Esta tabla es el resultado simetrico de la funcion fxPolizaDetSEL
    Public ReadOnly Property Details() As PolizasDS.PolizasDetDataTable
        Get
            Return CType(DetailsTable, PolizasDS.PolizasDetDataTable)
        End Get
    End Property
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        DetailsTable = New PolizasDS.PolizasDetDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de PolizasTit
''' </summary>
''' <remarks></remarks>
Public Class PolizaService
    Inherits DocumentService(Of PolizaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "PolizasTit", "PolizasDet", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub

#End Region


#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdPoliza As String, ByVal IdStatus As Integer, ByVal FechaTrabajo As Date)
        MyBase.ApplyWorkflow(IdPoliza, IdStatus, FechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdPoliza As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdPoliza, IdStatus)
    End Sub


    Public Overrides Function Create() As PolizaInfo
        Return New PolizaInfo(sessionID)
    End Function


    Public Overrides Sub GetDetail(ByVal idPoliza As String, ByRef Poliza As PolizaInfo)
        MyBase.GetDetail(idPoliza, Poliza)
        With Poliza
            .Fecha = CDate(DocInfo("Fecha"))
            .IdPolizaPerfil = CInt(DocInfo("IdPolizaPerfil"))
            ._IdPolizaTipo = CInt(DocInfo("IdPolizaTipo"))
            ._AfectarSistemaExterno = CBool(DocInfo("AfectarSistemaExterno"))
            .Folio = CInt(DocInfo("Folio"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Poliza As PolizaInfo) As PolizaInfo
        With Me.SPUpdate.Parameters
            .Add("@IdPolizaPerfil", DbType.Int32).Value = Poliza.IdPolizaPerfil
            .Add("@Folio", DbType.Int32).Value = Poliza.Folio

        End With
        Return MyBase.Update(Poliza)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de PolizasTit
''' </summary>
''' <remarks></remarks>
Public Class PolizaFacade
    Inherits DocumentFacade(Of PolizaInfo)

#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo PolizaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As GUID, ByVal IdPoliza As String, ByVal IdStatus As Integer, ByVal FechaTrabajo As Date)
        Dim PolizaSvc As New PolizaService(sessionID)
        ApplyWorkflow(PolizaSvc, IdPoliza, IdStatus, FechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo PolizaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As GUID, ByVal IdPoliza As String, ByVal IdStatus As Integer)
        Dim PolizaSvc As New PolizaService(sessionID)
        CancelWorkflow(PolizaSvc, IdPoliza, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un PolizaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As PolizaInfo
        Dim PolizaSvc As New PolizaService(sessionID)
        Return PolizaSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Poliza.
    ''' </summary>
    ''' <param name="Poliza">Paquete de informaci�n del tipo PolizaInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Poliza, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Poliza As PolizaInfo) As PolizaInfo
        Dim PolizaSvc As New PolizaService(Poliza.SessionID)
        Return Update(PolizaSvc, CType(Poliza, PolizaInfo))
    End Function


    ''' <summary>
    ''' Elimina un elemento del documento de PolizasTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idPoliza">Identificador del Poliza que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idPoliza As String)
        Dim PolizaSvc As New PolizaService(sessionID)
        Delete(PolizaSvc, idPoliza)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Poliza con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idPoliza">ID de Poliza que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idPoliza As String) As Boolean
        Dim PolizaSvc As New PolizaService(sessionID)
        Return Exists(PolizaSvc, idPoliza)
    End Function


    ''' <summary>
    ''' Obtiene la informaci�n de un Poliza.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idPoliza">Identificador de Poliza a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo PolizaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPoliza As String) As PolizaInfo
        Return Me.GetDetail(sessionID, idPoliza, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Poliza.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idPoliza">Identificador de Poliza</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Poliza.</param>
    ''' <returns>Paquete de informaci�n de tipo PolizaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPoliza As String, ByVal checkStatus As Boolean) As PolizaInfo
        Dim PolizaSvc As New PolizaService(sessionID)
        Dim PolizaInf As New PolizaInfo(sessionID)
        GetDetail(PolizaSvc, PolizaInf, idPoliza)
        Return PolizaInf
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim PolizaSvc As New PolizaService(sessionID)
        Return GetNumberOfPages(PolizaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca PolizasTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Dim PolizaSvc As New PolizaService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca PolizasTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim PolizaSvc As New PolizaService(sessionID)
        Return GetSearchResult(PolizaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de PolizasTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim PolizaSvc As New PolizaService(sessionID)
        Return GetSearchStructure(PolizaSvc)
    End Function

#End Region

End Class
