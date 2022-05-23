''' <summary>
''' Paquete de información que representa un Pago
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class PagoInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"

#End Region

#Region "Propiedades"
    Public Property Folio As Integer

    Public Property IdCaja As Integer

    Public Property IdPagoTipo As Integer

    Public Property IdBeneficiario As Integer

    Public Property IdChequera As Integer

    Public Property Monto As Decimal

    Public Property FechaCNL As Date


  'Se debe de agregar un Dataset con este nombre y con esta tabla incluida.
  'Esta tabla es el resultado simetrico de la funcion fxPagoDetSEL
    Public ReadOnly Property Details() As PagosDS.DetalleDataTable
        Get
            Return CType(DetailsTable, PagosDS.DetalleDataTable)
        End Get
    End Property
#End Region
	
#Region "Constructor"
	Public Sub New(ByVal sessionID As GUID)
		MyBase.New(sessionID)
        DetailsTable = New PagosDS.DetalleDataTable
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de PagosTit
''' </summary>
''' <remarks></remarks>
Public Class PagoService
	Inherits DocumentService(Of PagoInfo)
	
#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Treasury", "PagosTit", "PagosDet", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
    
#End Region


	
#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdPago As String, ByVal IdStatus As Integer, ByVal fechaTrabajo As Date)
        MyBase.ApplyWorkflow(IdPago, IdStatus, fechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdPago As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdPago, IdStatus)
    End Sub

	
    Public Overrides Function Create() As PagoInfo
		Return New PagoInfo(SessionID)
    End Function


    Public Overrides Sub GetDetail(ByVal idPago As string, ByRef Pago As PagoInfo)
		MyBase.GetDetail(idPago, Pago)
        With Pago
            .Folio = CInt(DocInfo("Folio"))
            .IdCaja = CInt(DocInfo("IdCaja"))
			.IdPagoTipo = CInt(DocInfo("IdPagoTipo"))
			.IdBeneficiario = CInt(DocInfo("IdBeneficiario"))
			.IdChequera = CInt(DocInfo("IdChequera"))
            .Monto = CDec(DocInfo("Monto"))
            If Not IsDBNull(DocInfo("FechaCNL")) Then .FechaCNL = CDate(DocInfo("FechaCNL"))
        End With
    End Sub
	
    Public Overrides Function Update(ByVal Pago As PagoInfo) As PagoInfo
        With Me.SPUpdate.Parameters
            .Add("@IdCaja", DbType.Int32).Value = Pago.IdCaja
			.Add("@IdPagoTipo", DbType.Int32).Value = Pago.IdPagoTipo
			.Add("@IdBeneficiario", DbType.Int32).Value = Pago.IdBeneficiario
			.Add("@IdChequera", DbType.Int32).Value = Pago.IdChequera
			.Add("@Monto", DbType.Decimal).Value = Pago.Monto
        End With
		Return MyBase.Update(Pago)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de PagosTit
''' </summary>
''' <remarks></remarks>
Public Class PagoFacade
	Inherits DocumentFacade(Of PagoInfo)
        
#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo PagoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As GUID, ByVal IdPago As String, ByVal IdStatus As Integer, fechaTrabajo as Date)
        Dim PagoSvc As New PagoService(sessionID)
        ApplyWorkflow(PagoSvc, IdPago, IdStatus, fechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo PagoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As GUID, ByVal IdPago As String, ByVal IdStatus As Integer)
        Dim PagoSvc As New PagoService(sessionID)
        CancelWorkflow(PagoSvc, IdPago, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un PagoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As PagoInfo
		Dim PagoSvc As New PagoService(sessionID)
		Return PagoSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un Pago.
    ''' </summary>
    ''' <param name="Pago">Paquete de información del tipo PagoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Pago, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Pago As PagoInfo) As PagoInfo
    	Dim PagoSvc As New PagoService(Pago.SessionID)
		Return Update(PagoSvc, Ctype(Pago,PagoInfo))
    End Function
    

    ''' <summary>
    ''' Elimina un elemento del documento de PagosTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPago">Identificador del Pago que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idPago As string)
		Dim PagoSvc As New PagoService(sessionID)
		Delete(PagoSvc, idPago)
    End Sub
	
    ''' <summary>
    ''' Verifica si existe un Pago con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPago">ID de Pago que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idPago As string) As Boolean
		Dim PagoSvc As New PagoService(sessionID)
		Return Exists(PagoSvc, idPago)
    End Function

    
    ''' <summary>
    ''' Obtiene la información de un Pago.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPago">Identificador de Pago a consultar</param>
    ''' <returns>Paquete de información de tipo PagoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPago As string) As PagoInfo
        Return Me.GetDetail(sessionID, idPago, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Pago.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPago">Identificador de Pago</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Pago.</param>
    ''' <returns>Paquete de información de tipo PagoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idPago As string, checkStatus As Boolean) As PagoInfo
   		Dim PagoSvc As New PagoService(sessionID)
        Dim PagoInf As New PagoInfo(sessionID)
		GetDetail(PagoSvc, PagoInf, idPago)
        Return PagoInf        
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim PagoSvc As New PagoService(sessionID)
    	Return GetNumberOfPages(PagoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca PagosTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
		Dim PagoSvc As New PagoService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca PagosTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim PagoSvc As New PagoService(sessionID)
    	Return GetSearchResult(PagoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de PagosTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim PagoSvc As New PagoService(sessionID)
    	Return GetSearchStructure(PagoSvc)
    End Function

#End Region

End Class
