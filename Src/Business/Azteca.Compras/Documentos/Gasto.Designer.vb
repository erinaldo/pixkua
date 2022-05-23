''' <summary>
''' Paquete de información que representa un Gasto
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class GastoInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"
    Protected Friend _IdCaja As Integer
    Protected Friend _IdBeneficiarioTesoreria As Integer
    Protected Friend _Concepto As String
    Protected Friend _IdCuentaConcepto As Integer
#End Region

#Region "Propiedades"

    Public Property IdGastoConcepto As Integer

    Public Property IdDepartamento As Integer

    Public Property IdPresupuesto As Integer

    Public Property IdCategoriaPresupuestal As Integer

    Public Property IdDivisa As Integer

    Public Property TipoCambio As Decimal

    Public Property ModalidadPago As String

    Public Property IdBeneficiario As Integer

    Public Property TipoBeneficiario As String

    Public Property Notas As String

    Public Property IdProveedor As Integer

    Public Property SerieFactura As String

    Public Property FolioFactura As Integer

    Public Property AnioAprobacion As Integer

    Public Property NumAprobacion As Integer

    Public Property SubTotal As Decimal

    Public Property IdImpuesto1 As Integer

    Public Property IdImpuesto2 As Integer

    Public Property IdImpuesto3 As Integer

    Public Property PorcImp1 As Decimal

    Public Property PorcImp2 As Decimal

    Public Property PorcImp3 As Decimal

    Public Property MontoImp1 As Decimal

    Public Property MontoImp2 As Decimal

    Public Property MontoImp3 As Decimal

    Public Property IdRetencion1 As Integer

    Public Property IdRetencion2 As Integer

    Public Property IdRetencion3 As Integer

    Public Property PorcRetencion1 As Decimal

    Public Property PorcRetencion2 As Decimal

    Public Property PorcRetencion3 As Decimal

    Public Property MontoRetencion1 As Decimal

    Public Property MontoRetencion2 As Decimal

    Public Property MontoRetencion3 As Decimal

    Public Property Total As Decimal

    Public Property IdEmpresa As Integer

    Public ReadOnly Property IdCaja As Integer
        Get
            Return _IdCaja
        End Get
    End Property

    Public ReadOnly Property IdBeneficiarioTesoreria As Integer
        Get
            Return _IdBeneficiarioTesoreria
        End Get
    End Property

    Public ReadOnly Property Concepto As String
        Get
            Return _Concepto
        End Get
    End Property

    Public ReadOnly Property IdCuentaConcepto As Integer
        Get
            Return _IdCuentaConcepto
        End Get
    End Property

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Gastos
''' </summary>
''' <remarks></remarks>
Public Class GastoService
    Inherits DocumentService(Of GastoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As guid)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "Gastos", "", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub

#End Region

#Region "Metodos Privados"

    Private Sub GenerarContrarecibo(ByVal IdGasto As String, ByVal FechaTrabajo As Date)
        Try
            Dim GastoSVC As New GastoService(Me.SessionID, Me.Connection, Me.Transaction)
            Dim Gasto As New GastoInfo(Me.SessionID)
            GastoSVC.GetDetail(IdGasto, Gasto)

            Dim ContraRecibo As New Azteca.Business.Tesoreria.ContrareciboInfo(Me.SessionID)
            With ContraRecibo
                .IdCaja = Gasto.IdCaja
                .Origen = Tesoreria.OrigenContrarecibo.Gasto
                .IdDocumento = Gasto.Identity
                .FechaDocumento = Gasto.Fecha
                .ReferenciaNumerica = 0
                .ReferenciaAlfanumerica = Gasto.SerieFactura & "-" & Gasto.FolioFactura ' & Gasto.UUID
                .IdDivisa = Gasto.IdDivisa
                .TipoCambio = Gasto.TipoCambio
                '.Total = Gasto.Total
                '.TotalImpuestosRet = Gasto.MontoRetencion1 + Gasto.MontoRetencion2 + Gasto.MontoRetencion3
                '.TotalImpuestosTras = Gasto.MontoImp1 + Gasto.MontoImp2 + Gasto.MontoImp3
                '.SubTotal = Gasto.SubTotal
                .IdBeneficiario = Gasto.IdBeneficiarioTesoreria
                .IdSucursal = Gasto.IdSucursal
            End With

            With Gasto
                ContraRecibo.Details.AddDetalleRow(CStr(.IdGastoConcepto), .Concepto, .IdCuentaConcepto, .IdDepartamento, .SubTotal,
                                                   .IdImpuesto1, .IdImpuesto2, .IdImpuesto3, 0, 0, .PorcImp1, .PorcImp2, .PorcImp3, 0, 0, .MontoImp1, .MontoImp2, .MontoImp3, 0, 0,
                                                   .IdRetencion1, .IdRetencion2, .IdRetencion3, 0, 0, .PorcRetencion1, .PorcRetencion2, .PorcRetencion3, 0, 0, .MontoRetencion1, .MontoRetencion2, .MontoRetencion3, 0, 0)
            End With

            Dim ContrareciboSVC As New Azteca.Business.Tesoreria.ContrareciboService(Me.SessionID, Me.Connection, Me.Transaction)
            ContrareciboSVC.Update(ContraRecibo)
            ContrareciboSVC.ApplyWorkflow(ContraRecibo.Identity, 3, FechaTrabajo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdGasto As String, ByVal IdStatus As Integer, ByVal FechaTrabajo As Date)
        If IdStatus = WorkflowSteps.Authorize Then GenerarContrarecibo(IdGasto, FechaTrabajo)

        MyBase.ApplyWorkflow(IdGasto, IdStatus, FechaTrabajo)

    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdGasto As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdGasto, IdStatus)
    End Sub


    Public Overrides Function Create() As GastoInfo
        Return New GastoInfo(SessionID)
    End Function


    Public Overrides Sub GetDetail(ByVal idGasto As String, ByRef Gasto As GastoInfo)
        MyBase.GetDetail(idGasto, Gasto)
        With Gasto
            .IdGastoConcepto = CInt(DocInfo("IdGastoConcepto"))
            .IdDepartamento = CInt(DocInfo("IdDepartamento"))
            .IdPresupuesto = CInt(DocInfo("IdPresupuesto"))
            .IdCategoriaPresupuestal = CInt(DocInfo("IdCategoriaPresupuestal"))
            .IdDivisa = CInt(DocInfo("IdDivisa"))
            .TipoCambio = CDec(DocInfo("TipoCambio"))
            .ModalidadPago = CStr(DocInfo("ModalidadPago"))
            .IdBeneficiario = CInt(DocInfo("IdBeneficiario"))
            .TipoBeneficiario = CStr(DocInfo("TipoBeneficiario"))
            .Notas = CStr(DocInfo("Notas"))
            .IdProveedor = CInt(DocInfo("IdProveedor"))
            .SerieFactura = CStr(DocInfo("SerieFactura"))
            .FolioFactura = CInt(DocInfo("FolioFactura"))
            .AnioAprobacion = CInt(DocInfo("AnioAprobacion"))
            .NumAprobacion = CInt(DocInfo("NumAprobacion"))
            .SubTotal = CDec(DocInfo("SubTotal"))
            .IdImpuesto1 = CInt(DocInfo("IdImpuesto1"))
            .IdImpuesto2 = CInt(DocInfo("IdImpuesto2"))
            .IdImpuesto3 = CInt(DocInfo("IdImpuesto3"))
            .PorcImp1 = CDec(DocInfo("PorcImp1"))
            .PorcImp2 = CDec(DocInfo("PorcImp2"))
            .PorcImp3 = CDec(DocInfo("PorcImp3"))
            .MontoImp1 = CDec(DocInfo("MontoImp1"))
            .MontoImp2 = CDec(DocInfo("MontoImp2"))
            .MontoImp3 = CDec(DocInfo("MontoImp3"))
            .IdRetencion1 = CInt(DocInfo("IdRetencion1"))
            .IdRetencion2 = CInt(DocInfo("IdRetencion2"))
            .IdRetencion3 = CInt(DocInfo("IdRetencion3"))
            .PorcRetencion1 = CDec(DocInfo("PorcRetencion1"))
            .PorcRetencion2 = CDec(DocInfo("PorcRetencion2"))
            .PorcRetencion3 = CDec(DocInfo("PorcRetencion3"))
            .MontoRetencion1 = CDec(DocInfo("MontoRetencion1"))
            .MontoRetencion2 = CDec(DocInfo("MontoRetencion2"))
            .MontoRetencion3 = CDec(DocInfo("MontoRetencion3"))
            .Total = CDec(DocInfo("Total"))
            .IdEmpresa = CInt(DocInfo("IdEmpresa"))
            ._IdCaja = CInt(DocInfo("IdCaja"))
            ._IdBeneficiarioTesoreria = CInt(DocInfo("IdBeneficiarioTesoreria"))
            ._Concepto = CStr(DocInfo("Concepto"))
            ._IdCuentaConcepto = CInt(DocInfo("IdCuentaConcepto"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Gasto As GastoInfo) As GastoInfo
        With Me.SPUpdate.Parameters
            .Add("@IdGastoConcepto", DbType.Int32).Value = Gasto.IdGastoConcepto
            .Add("@IdDepartamento", DbType.Int32).Value = Gasto.IdDepartamento
            .Add("@IdPresupuesto", DbType.Int32).Value = Gasto.IdPresupuesto
            .Add("@IdCategoriaPresupuestal", DbType.Int32).Value = Gasto.IdCategoriaPresupuestal
            .Add("@IdDivisa", DbType.Int32).Value = Gasto.IdDivisa
            .Add("@TipoCambio", DbType.Decimal).Value = Gasto.TipoCambio
            .Add("@ModalidadPago", DbType.String).Value = Gasto.ModalidadPago
            .Add("@IdBeneficiario", DbType.Int32).Value = Gasto.IdBeneficiario
            .Add("@TipoBeneficiario", DbType.String).Value = Gasto.TipoBeneficiario
            .Add("@Notas", DbType.String).Value = Gasto.Notas
            .Add("@IdProveedor", DbType.Int32).Value = Gasto.IdProveedor
            .Add("@SerieFactura", DbType.String).Value = Gasto.SerieFactura
            .Add("@FolioFactura", DbType.Int32).Value = Gasto.FolioFactura
            .Add("@AnioAprobacion", DbType.Int32).Value = Gasto.AnioAprobacion
            .Add("@NumAprobacion", DbType.Int32).Value = Gasto.NumAprobacion
            .Add("@SubTotal", DbType.Decimal).Value = Gasto.SubTotal
            .Add("@IdImpuesto1", DbType.Int32).Value = Gasto.IdImpuesto1
            .Add("@IdImpuesto2", DbType.Int32).Value = Gasto.IdImpuesto2
            .Add("@IdImpuesto3", DbType.Int32).Value = Gasto.IdImpuesto3
            .Add("@PorcImp1", DbType.Decimal).Value = Gasto.PorcImp1
            .Add("@PorcImp2", DbType.Decimal).Value = Gasto.PorcImp2
            .Add("@PorcImp3", DbType.Decimal).Value = Gasto.PorcImp3
            .Add("@MontoImp1", DbType.Decimal).Value = Gasto.MontoImp1
            .Add("@MontoImp2", DbType.Decimal).Value = Gasto.MontoImp2
            .Add("@MontoImp3", DbType.Decimal).Value = Gasto.MontoImp3
            .Add("@IdRetencion1", DbType.Int32).Value = Gasto.IdRetencion1
            .Add("@IdRetencion2", DbType.Int32).Value = Gasto.IdRetencion2
            .Add("@IdRetencion3", DbType.Int32).Value = Gasto.IdRetencion3
            .Add("@PorcRetencion1", DbType.Decimal).Value = Gasto.PorcRetencion1
            .Add("@PorcRetencion2", DbType.Decimal).Value = Gasto.PorcRetencion2
            .Add("@PorcRetencion3", DbType.Decimal).Value = Gasto.PorcRetencion3
            .Add("@MontoRetencion1", DbType.Decimal).Value = Gasto.MontoRetencion1
            .Add("@MontoRetencion2", DbType.Decimal).Value = Gasto.MontoRetencion2
            .Add("@MontoRetencion3", DbType.Decimal).Value = Gasto.MontoRetencion3
            .Add("@Total", DbType.Decimal).Value = Gasto.Total
            .Add("@IdEmpresa", DbType.Int32).Value = Gasto.IdEmpresa

        End With
        Return MyBase.Update(Gasto)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de Gastos
''' </summary>
''' <remarks></remarks>
Public Class GastoFacade
    Inherits DocumentFacade(Of GastoInfo)

#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo GastoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As Guid, ByVal IdGasto As String, ByVal IdStatus As Integer, ByVal FechaTrabajo As Date)
        Dim GastoSvc As New GastoService(sessionID)
        ApplyWorkflow(GastoSvc, IdGasto, IdStatus, FechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo GastoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As Guid, ByVal IdGasto As String, ByVal IdStatus As Integer)
        Dim GastoSvc As New GastoService(sessionID)
        CancelWorkflow(GastoSvc, IdGasto, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un GastoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As GastoInfo
        Dim GastoSvc As New GastoService(sessionID)
        Return GastoSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un Gasto.
    ''' </summary>
    ''' <param name="Gasto">Paquete de información del tipo GastoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Gasto, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Gasto As GastoInfo) As GastoInfo
        Dim GastoSvc As New GastoService(Gasto.SessionID)
        Return Update(GastoSvc, CType(Gasto, GastoInfo))
    End Function


    ''' <summary>
    ''' Elimina un elemento del documento de Gastos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGasto">Identificador del Gasto que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idGasto As String)
        Dim GastoSvc As New GastoService(sessionID)
        Delete(GastoSvc, idGasto)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Gasto con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGasto">ID de Gasto que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idGasto As String) As Boolean
        Dim GastoSvc As New GastoService(sessionID)
        Return Exists(GastoSvc, idGasto)
    End Function


    ''' <summary>
    ''' Obtiene la información de un Gasto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGasto">Identificador de Gasto a consultar</param>
    ''' <returns>Paquete de información de tipo GastoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idGasto As String) As GastoInfo
        Return Me.GetDetail(sessionID, idGasto, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Gasto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGasto">Identificador de Gasto</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Gasto.</param>
    ''' <returns>Paquete de información de tipo GastoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idGasto As String, ByVal checkStatus As Boolean) As GastoInfo
        Dim GastoSvc As New GastoService(sessionID)
        Dim GastoInf As New GastoInfo(sessionID)
        GetDetail(GastoSvc, GastoInf, idGasto)
        Return GastoInf
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim GastoSvc As New GastoService(sessionID)
        Return GetNumberOfPages(GastoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Gastos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Dim GastoSvc As New GastoService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Gastos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim GastoSvc As New GastoService(sessionID)
        Return GetSearchResult(GastoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Gastos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As guid) As System.Data.DataSet
        Dim GastoSvc As New GastoService(sessionID)
        Return GetSearchStructure(GastoSvc)
    End Function

#End Region

End Class
