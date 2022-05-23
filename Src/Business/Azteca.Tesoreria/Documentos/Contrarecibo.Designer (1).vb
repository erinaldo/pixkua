''' <summary>
''' Paquete de información que representa un Contrarecibo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ContrareciboInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"
    Friend _SubTotal As Decimal
    Friend _TotalImpuestosTras As Decimal
    Friend _TotalImpuestosRet As Decimal
    Friend _Total As Decimal
#End Region

#Region "Propiedades"

    Public Property IdCaja As Integer

    Public Property IdDocumento As String = String.Empty

    Public Property Origen As OrigenContrarecibo

    Public Property FechaDocumento As Date

    Public Property ReferenciaNumerica As Integer

    Public Property ReferenciaAlfanumerica As String = String.Empty

    Public Property FechaPago As Date

    Public Property IdChequeTit As String = String.Empty

    Public Property FechaCheque As Date

    Public Property IdBeneficiario As Integer

    Public ReadOnly Property SubTotal As Decimal
        Get
            Return _SubTotal
        End Get
    End Property

    Public ReadOnly Property TotalImpuestosTras As Decimal
        Get
            Return _TotalImpuestosTras
        End Get
    End Property

    Public ReadOnly Property TotalImpuestosRet As Decimal
        Get
            Return _TotalImpuestosRet
        End Get
    End Property

    Public ReadOnly Property Total As Decimal
        Get
            Return _Total
        End Get
    End Property

    Public Property IdDivisa As Integer

    Public Property TipoCambio As Decimal
    'Se debe de agregar un Dataset con este nombre y con esta tabla incluida.
    'Esta tabla es el resultado simetrico de la funcion fxContrareciboDetSEL
    Public ReadOnly Property Details() As DetalleContrareciboDS.DetalleDataTable
        Get
            Return CType(DetailsTable, DetalleContrareciboDS.DetalleDataTable)
        End Get
    End Property
#End Region

#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        DetailsTable = New DetalleContrareciboDS.DetalleDataTable
    End Sub
#End Region

#Region "Metodos"
    Public Sub CalcularTotales()

        Dim Subtotales = Aggregate D In Me.Details
                       Where D.RowState <> DataRowState.Deleted AndAlso D.RowState <> DataRowState.Detached
                       Into SubTotal = Sum(D.Monto), Otro = Sum(D.Monto)

        Dim ImpuestosTras = Aggregate T In Me.Details
                        Where T.RowState <> DataRowState.Deleted AndAlso T.RowState <> DataRowState.Detached
                        Into Trasladados = Sum(T.MontoImpTras1 + T.MontoImpTras2 + T.MontoImpTras3 + T.MontoImpTras4 + T.MontoImpTras5), Otro = Sum(T.Monto)

        Dim ImpuestosRet = Aggregate R In Me.Details
                         Where R.RowState <> DataRowState.Deleted AndAlso R.RowState <> DataRowState.Detached
                         Into Retenidos = Sum(R.MontoImpRet1 + R.MontoImpRet2 + R.MontoImpRet3 + R.MontoImpRet4 + R.MontoImpRet5), Otro = Sum(R.Monto)


        With Me
            ._SubTotal = (Subtotales.SubTotal)

            ''Impuestos trasladados
            'For Each Tasa In ImpuestosTras
            ._TotalImpuestosTras = CDec(ImpuestosTras.Trasladados)
            'Next

            ''Impuestos retenidos
            '._TotalImpuestosRet = 0
            'For Each Tasa In ImpuestosRet
            ._TotalImpuestosRet = CDec(ImpuestosRet.Retenidos)
            'Next

            ._Total = ._SubTotal + .TotalImpuestosTras - .TotalImpuestosRet
        End With

    End Sub
#End Region

End Class

Public Enum OrigenContrarecibo
    Gasto
    OrdenCompra
End Enum

''' <summary>
''' Proveedor de servicios para el manejo del catálogo de ContrarecibosTit
''' </summary>
''' <remarks></remarks>
Public Class ContrareciboService
	Inherits DocumentService(Of ContrareciboInfo)
	
#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Treasury", "ContrarecibosTit", "ContrarecibosDet", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
    
#End Region

#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdContrarecibo As String, ByVal IdStatus As Integer, ByVal fechaTrabajo As Date)
        MyBase.ApplyWorkflow(IdContrarecibo, IdStatus, fechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdContrarecibo As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdContrarecibo, IdStatus)
    End Sub

	
    Public Overrides Function Create() As ContrareciboInfo
		Return New ContrareciboInfo(SessionID)
    End Function


    Public Overrides Sub GetDetail(ByVal idContrarecibo As string, ByRef Contrarecibo As ContrareciboInfo)
		MyBase.GetDetail(idContrarecibo, Contrarecibo)
        With Contrarecibo
            .IdCaja = CInt(DocInfo("IdCaja"))
            .Origen = GetOrigen(DocInfo("Origen").ToString)
            .IdDocumento = CStr(DocInfo("IdDocumento"))
            .FechaDocumento = CDate(DocInfo("FechaDocumento"))
            .ReferenciaNumerica = CInt(DocInfo("ReferenciaNum"))
            .ReferenciaAlfanumerica = CStr(DocInfo("ReferenciaAlf"))
            If Not IsDBNull(DocInfo("FechaPago")) Then .FechaPago = CDate(DocInfo("FechaPago"))
            .IdChequeTit = CStr(DocInfo("IdChequeTit"))
            If Not IsDBNull(DocInfo("FechaCheque")) Then .FechaCheque = CDate(DocInfo("FechaCheque"))
            .IdDivisa = CInt(DocInfo("IdDivisa"))
            .TipoCambio = CDec(DocInfo("TipoCambio"))
            .IdBeneficiario = CInt(DocInfo("IdBeneficiario"))
            ._SubTotal = CDec(DocInfo("SubTotal"))
            ._TotalImpuestosTras = CDec(DocInfo("TotalImpuestosTras"))
            ._TotalImpuestosRet = CDec(DocInfo("TotalImpuestosRet"))
            ._Total = CDec(DocInfo("Total"))
        End With
    End Sub
	
    Public Overrides Function Update(ByVal Contrarecibo As ContrareciboInfo) As ContrareciboInfo
        Contrarecibo.CalcularTotales()
        With Me.SPUpdate.Parameters
            .Add("@IdCaja", DbType.Int32).Value = Contrarecibo.IdCaja
            .Add("@Origen", DbType.String).Value = GetOrigen(Contrarecibo.Origen)
            .Add("@IdDocumento", DbType.String).Value = Contrarecibo.IdDocumento
            .Add("@FechaDocumento", DbType.DateTime).Value = Contrarecibo.FechaDocumento
            .Add("@ReferenciaNum", DbType.Int32).Value = Contrarecibo.ReferenciaNumerica
            .Add("@ReferenciaAlf", DbType.String).Value = Contrarecibo.ReferenciaAlfanumerica
            .Add("@IdDivisa", DbType.Int32).Value = Contrarecibo.IdDivisa
            .Add("@TipoCambio", DbType.Decimal).Value = Contrarecibo.TipoCambio
            .Add("@IdBeneficiario", DbType.Int32).Value = Contrarecibo.IdBeneficiario
            .Add("@SubTotal", DbType.Decimal).Value = Contrarecibo.SubTotal
            .Add("@TotalImpuestosTras", DbType.Decimal).Value = Contrarecibo.TotalImpuestosTras
            .Add("@TotalImpuestosRet", DbType.Decimal).Value = Contrarecibo.TotalImpuestosRet
            .Add("@Total", DbType.Decimal).Value = Contrarecibo.Total
        End With
        Return MyBase.Update(Contrarecibo)
    End Function

#End Region

#Region "Metodos Privados"

    Private Function GetOrigen(origen As String) As OrigenContrarecibo
        Select Case origen
            Case "O"
                Return OrigenContrarecibo.OrdenCompra
            Case "G"
                Return OrigenContrarecibo.Gasto
            Case Else
                Return OrigenContrarecibo.Gasto
        End Select
    End Function

    Private Function GetOrigen(origen As OrigenContrarecibo) As String
        Select Case origen
            Case OrigenContrarecibo.OrdenCompra
                Return "O"
            Case OrigenContrarecibo.Gasto
                Return "G"
            Case Else
                Return String.Empty
        End Select
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de ContrarecibosTit
''' </summary>
''' <remarks></remarks>
Public Class ContrareciboFacade
	Inherits DocumentFacade(Of ContrareciboInfo)
        
#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo ContrareciboInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As GUID, ByVal IdContrarecibo As String, ByVal IdStatus As Integer, fechaTrabajo as Date)
        Dim ContrareciboSvc As New ContrareciboService(sessionID)
        ApplyWorkflow(ContrareciboSvc, IdContrarecibo, IdStatus, fechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo ContrareciboInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As GUID, ByVal IdContrarecibo As String, ByVal IdStatus As Integer)
        Dim ContrareciboSvc As New ContrareciboService(sessionID)
        CancelWorkflow(ContrareciboSvc, IdContrarecibo, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un ContrareciboInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ContrareciboInfo
		Dim ContrareciboSvc As New ContrareciboService(sessionID)
		Return ContrareciboSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un Contrarecibo.
    ''' </summary>
    ''' <param name="Contrarecibo">Paquete de información del tipo ContrareciboInfo con la información a actualizar</param>
    ''' <returns>Identificador de Contrarecibo, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Contrarecibo As ContrareciboInfo) As ContrareciboInfo
    	Dim ContrareciboSvc As New ContrareciboService(Contrarecibo.SessionID)
		Return Update(ContrareciboSvc, Ctype(Contrarecibo,ContrareciboInfo))
    End Function
    

    ''' <summary>
    ''' Elimina un elemento del documento de ContrarecibosTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idContrarecibo">Identificador del Contrarecibo que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idContrarecibo As string)
		Dim ContrareciboSvc As New ContrareciboService(sessionID)
		Delete(ContrareciboSvc, idContrarecibo)
    End Sub
	
    ''' <summary>
    ''' Verifica si existe un Contrarecibo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idContrarecibo">ID de Contrarecibo que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idContrarecibo As string) As Boolean
		Dim ContrareciboSvc As New ContrareciboService(sessionID)
		Return Exists(ContrareciboSvc, idContrarecibo)
    End Function

    
    ''' <summary>
    ''' Obtiene la información de un Contrarecibo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idContrarecibo">Identificador de Contrarecibo a consultar</param>
    ''' <returns>Paquete de información de tipo ContrareciboInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idContrarecibo As string) As ContrareciboInfo
        Return Me.GetDetail(sessionID, idContrarecibo, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Contrarecibo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idContrarecibo">Identificador de Contrarecibo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Contrarecibo.</param>
    ''' <returns>Paquete de información de tipo ContrareciboInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idContrarecibo As string, checkStatus As Boolean) As ContrareciboInfo
   		Dim ContrareciboSvc As New ContrareciboService(sessionID)
        Dim ContrareciboInf As New ContrareciboInfo(sessionID)
		GetDetail(ContrareciboSvc, ContrareciboInf, idContrarecibo)
        Return ContrareciboInf        
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim ContrareciboSvc As New ContrareciboService(sessionID)
    	Return GetNumberOfPages(ContrareciboSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca ContrarecibosTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
		Dim ContrareciboSvc As New ContrareciboService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca ContrarecibosTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim ContrareciboSvc As New ContrareciboService(sessionID)
    	Return GetSearchResult(ContrareciboSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de ContrarecibosTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim ContrareciboSvc As New ContrareciboService(sessionID)
    	Return GetSearchStructure(ContrareciboSvc)
    End Function

#End Region

End Class
