''' <summary>
''' Paquete de información que representa un EjercicioFiscal
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class EjercicioFiscalInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"

#End Region

#Region "Propiedades"
    Public Property Anio As Integer

    Public Property IdEmpresa As Integer

    Public Property FechaIni As Date

    Public Property FechaFin As Date


  'Se debe de agregar un Dataset con este nombre y con esta tabla incluida.
  'Esta tabla es el resultado simetrico de la funcion fxEjercicioFiscalDetSEL
    Public ReadOnly Property PeriodosTable() As EjercicioFiscalDS.PeriodosDataTable
        Get
            Return CType(DetailsTable, EjercicioFiscalDS.PeriodosDataTable)
        End Get
    End Property
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        DetailsTable = New EjercicioFiscalDS.PeriodosDataTable
    End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de EjerciciosFiscalesTit
''' </summary>
''' <remarks></remarks>
Public Class EjercicioFiscalService
	Inherits DocumentService(Of EjercicioFiscalInfo)
	
#Region "Constructores"
    Public Sub New(ByVal SessionID As Guid)
        Me.New(SessionID, Nothing)
    End Sub

    Public Sub New(ByVal SessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(SessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal SessionID As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "EjerciciosFiscalesTit", "EjerciciosFiscalesDet", SessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
    
#End Region

#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdEjercicioFiscal As String, ByVal IdStatus As Integer, ByVal FechaTrabajo As Date)
        MyBase.ApplyWorkflow(IdEjercicioFiscal, IdStatus, FechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdEjercicioFiscal As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdEjercicioFiscal, IdStatus)
    End Sub

	
    Public Overrides Function Create() As EjercicioFiscalInfo
        Return New EjercicioFiscalInfo(SessionID)
    End Function


    Public Overrides Sub GetDetail(ByVal idEjercicioFiscal As string, ByRef EjercicioFiscal As EjercicioFiscalInfo)
		MyBase.GetDetail(idEjercicioFiscal, EjercicioFiscal)
        With EjercicioFiscal
            .IdEmpresa = CInt(DocInfo("IdEmpresa"))
			.FechaIni = CDate(DocInfo("FechaIni"))
            .FechaFin = CDate(DocInfo("FechaFin"))
		End With
    End Sub
	
    Public Overrides Function Update(ByVal EjercicioFiscal As EjercicioFiscalInfo) As EjercicioFiscalInfo
        With Me.SPUpdate.Parameters
			.Add("@IdEmpresa", DbType.Int32).Value = EjercicioFiscal.IdEmpresa
			.Add("@FechaIni", DbType.DateTime).Value = EjercicioFiscal.FechaIni
            .Add("@FechaFin", DbType.DateTime).Value = EjercicioFiscal.FechaFin
		End With
		Return MyBase.Update(EjercicioFiscal)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de EjerciciosFiscalesTit
''' </summary>
''' <remarks></remarks>
Public Class EjercicioFiscalFacade
	Inherits DocumentFacade(Of EjercicioFiscalInfo)
        
#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo EjercicioFiscalInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As Guid, ByVal IdEjercicioFiscal As String, ByVal IdStatus As Integer, ByVal FechaTrabajo As Date)
        Dim EjercicioFiscalSvc As New EjercicioFiscalService(sessionID)
        ApplyWorkflow(EjercicioFiscalSvc, IdEjercicioFiscal, IdStatus, FechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo EjercicioFiscalInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As Guid, ByVal IdEjercicioFiscal As String, ByVal IdStatus As Integer)
        Dim EjercicioFiscalSvc As New EjercicioFiscalService(sessionID)
        CancelWorkflow(EjercicioFiscalSvc, IdEjercicioFiscal, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un EjercicioFiscalInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As EjercicioFiscalInfo
        Dim EjercicioFiscalSvc As New EjercicioFiscalService(sessionID)
        Return EjercicioFiscalSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un EjercicioFiscal.
    ''' </summary>
    ''' <param name="EjercicioFiscal">Paquete de información del tipo EjercicioFiscalInfo con la información a actualizar</param>
    ''' <returns>Identificador de EjercicioFiscal, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal EjercicioFiscal As EjercicioFiscalInfo) As EjercicioFiscalInfo
        Dim EjercicioFiscalSvc As New EjercicioFiscalService(EjercicioFiscal.SessionID)
		Return Update(EjercicioFiscalSvc, Ctype(EjercicioFiscal,EjercicioFiscalInfo))
    End Function
    

    ''' <summary>
    ''' Elimina un elemento del documento de EjerciciosFiscalesTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idEjercicioFiscal">Identificador del EjercicioFiscal que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idEjercicioFiscal As String)
        Dim EjercicioFiscalSvc As New EjercicioFiscalService(sessionID)
        Delete(EjercicioFiscalSvc, idEjercicioFiscal)
    End Sub
	
    ''' <summary>
    ''' Verifica si existe un EjercicioFiscal con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idEjercicioFiscal">ID de EjercicioFiscal que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idEjercicioFiscal As String) As Boolean
        Dim EjercicioFiscalSvc As New EjercicioFiscalService(sessionID)
        Return Exists(EjercicioFiscalSvc, idEjercicioFiscal)
    End Function

    
    ''' <summary>
    ''' Obtiene la información de un EjercicioFiscal.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idEjercicioFiscal">Identificador de EjercicioFiscal a consultar</param>
    ''' <returns>Paquete de información de tipo EjercicioFiscalInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idEjercicioFiscal As String) As EjercicioFiscalInfo
        Return Me.GetDetail(sessionID, idEjercicioFiscal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un EjercicioFiscal.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idEjercicioFiscal">Identificador de EjercicioFiscal</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del EjercicioFiscal.</param>
    ''' <returns>Paquete de información de tipo EjercicioFiscalInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idEjercicioFiscal As String, ByVal checkStatus As Boolean) As EjercicioFiscalInfo
        Dim EjercicioFiscalSvc As New EjercicioFiscalService(sessionID)
        Dim EjercicioFiscalInf As New EjercicioFiscalInfo(sessionID)
        GetDetail(EjercicioFiscalSvc, EjercicioFiscalInf, idEjercicioFiscal)
        Return EjercicioFiscalInf
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim EjercicioFiscalSvc As New EjercicioFiscalService(sessionID)
        Return GetNumberOfPages(EjercicioFiscalSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca EjerciciosFiscalesTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Dim EjercicioFiscalSvc As New EjercicioFiscalService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca EjerciciosFiscalesTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim EjercicioFiscalSvc As New EjercicioFiscalService(sessionID)
        Return GetSearchResult(EjercicioFiscalSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de EjerciciosFiscalesTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As Guid) As System.Data.DataSet
        Dim EjercicioFiscalSvc As New EjercicioFiscalService(sessionID)
        Return GetSearchStructure(EjercicioFiscalSvc)
    End Function

#End Region

End Class
