''' <summary>
''' Paquete de información que representa un Nota
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class NotaInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"
    Friend _IdCFDSerie As Integer
    Friend _Serie As String = String.Empty
    Friend _Folio As Integer
    Friend _UUID As String = String.Empty
    Friend _FechaCFD As Date
    Friend _SerieRef As String = String.Empty
    Friend _TipoCambio As Decimal
    Friend _SubTotal As Decimal
    Friend _TotalImpuestosTrasladados As Decimal
    Friend _TotalImpuestosRetenidos As Decimal
    Friend _Total As Decimal
#End Region

#Region "Propiedades"

    Public Property Tipo As TipoNota

    Public ReadOnly Property IdCFDSerie As Integer
        Get
            Return _IdCFDSerie
        End Get
    End Property

    Public ReadOnly Property Serie As String
        Get
            Return _Serie
        End Get
    End Property

    Public ReadOnly Property Folio As Integer
        Get
            Return _Folio
        End Get
    End Property

    Public ReadOnly Property UUID As String
        Get
            Return _UUID
        End Get
    End Property

    Public ReadOnly Property FechaCFD As Date
        Get
            Return _FechaCFD
        End Get
    End Property

    Public Property IdSerieRef As Integer

    Public ReadOnly Property SerieRef As String
        Get
            Return _SerieRef
        End Get
    End Property

    Public Property FolioRef As Integer

    Public Property IdCliente As Integer

    Public Property RFC As String = String.Empty

    Public Property RazonSocial As String = String.Empty

    Public Property Calle As String = String.Empty

    Public Property NumExt As String = String.Empty

    Public Property NumInt As String = String.Empty

    Public Property Colonia As String = String.Empty

    Public Property CP As String = String.Empty

    Public Property IdPoblacion As Integer

    Public Property IdDivisa As Integer

    Public ReadOnly Property TipoCambio As Decimal
        Get
            Return _TipoCambio
        End Get
    End Property

    Public ReadOnly Property SubTotal As Decimal
        Get
            Return _SubTotal
        End Get
    End Property

    Public ReadOnly Property TotalImpuestosTrasladados As Decimal
        Get
            Return _TotalImpuestosTrasladados
        End Get
    End Property

    Public ReadOnly Property TotalImpuestosRetenidos As Decimal
        Get
            Return _TotalImpuestosRetenidos
        End Get
    End Property

    Public ReadOnly Property Total As Decimal
        Get
            Return _Total
        End Get
    End Property

    Public Property Observaciones As String = String.Empty


  'Se debe de agregar un Dataset con este nombre y con esta tabla incluida.
  'Esta tabla es el resultado simetrico de la funcion fxNotaDetSEL
    Public ReadOnly Property Details() As DetalleNotaDS.DetalleDataTable
        Get
            Return CType(DetailsTable, DetalleNotaDS.DetalleDataTable)
        End Get
    End Property
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        DetailsTable = New DetalleNotaDS.DetalleDataTable
    End Sub
#End Region

End Class

Public Enum TipoNota
    Cargo
    Credito
End Enum

''' <summary>
''' Proveedor de servicios para el manejo del catálogo de NotasTit
''' </summary>
''' <remarks></remarks>
Public Class NotaService
    Inherits DocumentService(Of NotaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "NotasTit", "NotasDet", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub

#End Region

#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdNota As String, ByVal IdStatus As Integer, ByVal fechaTrabajo As Date)
        'Cargar información de la nota
        Dim NotaSvc As New NotaService(sessionID, Connection, Transaction)
        Dim Nota As New NotaInfo(sessionID)
        NotaSvc.GetDetail(IdNota, Nota)
        'Facturar
        Dim Comprobante As ComprobanteFiscalInfo = NotaSvc.Facturar(Nota)
        MyBase.ApplyWorkflow(IdNota, IdStatus, fechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdNota As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdNota, IdStatus)
    End Sub

    Public Overrides Function Create() As NotaInfo
        Return New NotaInfo(sessionID)
    End Function

    Public Overrides Sub GetDetail(ByVal idNota As String, ByRef Nota As NotaInfo)
        MyBase.GetDetail(idNota, Nota)
        With Nota
            .Fecha = CDate(DocInfo("Fecha"))
            .Tipo = GetTipoNota(CStr(DocInfo("Tipo")))
            ._IdCFDSerie = CInt(DocInfo("IdCFDSerie"))
            ._Serie = CStr(DocInfo("SerieNota")).Trim
            ._Folio = CInt(DocInfo("FolioNota"))
            ._UUID = DocInfo("UUID").ToString()
            If Not DocInfo("FechaNota") Is DBNull.Value Then
                ._FechaCFD = CDate(DocInfo("FechaNota"))
            End If
            .IdSerieRef = CInt(DocInfo("IdSerieRef"))
            .FolioRef = CInt(DocInfo("FolioRef"))
            .IdCliente = CInt(DocInfo("IdCliente"))
            .RFC = CStr(DocInfo("RFC"))
            .RazonSocial = CStr(DocInfo("RazonSocial"))
            .Calle = CStr(DocInfo("Calle"))
            .NumExt = CStr(DocInfo("NumExt"))
            .NumInt = CStr(DocInfo("NumInt"))
            .Colonia = CStr(DocInfo("Colonia"))
            .CP = CStr(DocInfo("CP"))
            .IdPoblacion = CInt(DocInfo("IdPoblacion"))
            .IdDivisa = CInt(DocInfo("IdDivisa"))
            ._TipoCambio = CDec(DocInfo("TipoCambio"))
            ._SubTotal = CDec(DocInfo("SubTotal"))
            ._TotalImpuestosTrasladados = CDec(DocInfo("TotalImpuestosTras"))
            ._TotalImpuestosRetenidos = CDec(DocInfo("TotalImpuestosRet"))
            ._Total = CDec(DocInfo("Total"))
            .Observaciones = CStr(DocInfo("Observaciones"))
        End With
    End Sub

    Public Overrides Function Update(ByVal Nota As NotaInfo) As NotaInfo
        Validate(Nota)
        CalcularTotales(Nota)
        With Me.SPUpdate.Parameters
            .Add("@Tipo", DbType.String).Value = GetTipoNota(Nota.Tipo)
            .Add("@IdSerieRef", DbType.Int32).Value = Nota.IdSerieRef
            .Add("@FolioRef", DbType.Int32).Value = Nota.FolioRef
            .Add("@IdCliente", DbType.Int32).Value = Nota.IdCliente
            .Add("@RFC", DbType.String).Value = Nota.RFC
            .Add("@RazonSocial", DbType.String).Value = Nota.RazonSocial
            .Add("@Calle", DbType.String).Value = Nota.Calle
            .Add("@NumExt", DbType.String).Value = Nota.NumExt
            .Add("@NumInt", DbType.String).Value = Nota.NumInt
            .Add("@Colonia", DbType.String).Value = Nota.Colonia
            .Add("@CP", DbType.String).Value = Nota.CP
            .Add("@IdPoblacion", DbType.Int32).Value = Nota.IdPoblacion
            .Add("@IdDivisa", DbType.Int32).Value = Nota.IdDivisa
            .Add("@SubTotal", DbType.Decimal).Value = Nota.SubTotal
            .Add("@TotalImpuestosTras", DbType.Decimal).Value = Nota.TotalImpuestosTrasladados
            .Add("@TotalImpuestosRet", DbType.Decimal).Value = Nota.TotalImpuestosRetenidos
            .Add("@Total", DbType.Decimal).Value = Nota.Total
            .Add("@Observaciones", DbType.String).Value = Nota.Observaciones
        End With
        Return MyBase.Update(Nota)
    End Function

#End Region

#Region "Metodos Privados"

    Private Function GetTipoNota(ByVal tipo As String) As TipoNota
        Select Case tipo
            Case "C"
                Return TipoNota.Cargo
            Case "A"
                Return TipoNota.Credito
            Case Else
                Return TipoNota.Cargo
        End Select
    End Function

    Private Function GetTipoNota(ByVal tipo As TipoNota) As String
        Select Case tipo
            Case TipoNota.Cargo
                Return "C"
            Case TipoNota.Credito
                Return "A"
            Case Else
                Return String.Empty
        End Select
    End Function

    Private Sub CalcularTotales(ByVal nota As NotaInfo)
        Dim Totales = Aggregate D In nota.Details
                      Where D.RowState <> DataRowState.Deleted
                      Into SubTotal = Sum(D.Monto), ImpuestosTras = Sum(D.MontoImpTras1 + D.MontoImpTras2 + D.MontoImpTras3),
                        ImpuestosRet = Sum(D.MontoImpRet1 + D.MontoImpRet2 + D.MontoImpRet3)
        With nota
            ._SubTotal = Totales.SubTotal
            ._TotalImpuestosTrasladados = Totales.ImpuestosTras
            ._TotalImpuestosRetenidos = Totales.ImpuestosRet
            ._Total = .SubTotal + .TotalImpuestosTrasladados - .TotalImpuestosRetenidos
        End With
    End Sub

    Private Sub Validate(nota As NotaInfo)
        If nota.Details.Count = 0 Then
            Throw New BusinessException("No es posible guardar una nota sin detalle.")
        End If
    End Sub

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de NotasTit
''' </summary>
''' <remarks></remarks>
Public Class NotaFacade
    Inherits DocumentFacade(Of NotaInfo)

#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo NotaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As Guid, ByVal IdNota As String, ByVal IdStatus As Integer, ByVal fechaTrabajo As Date)
        Dim NotaSvc As New NotaService(sessionID)
        ApplyWorkflow(NotaSvc, IdNota, IdStatus, fechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo NotaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As Guid, ByVal IdNota As String, ByVal IdStatus As Integer)
        Dim NotaSvc As New NotaService(sessionID)
        CancelWorkflow(NotaSvc, IdNota, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un NotaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As NotaInfo
        Dim NotaSvc As New NotaService(sessionID)
        Return NotaSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un Nota.
    ''' </summary>
    ''' <param name="Nota">Paquete de información del tipo NotaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Nota, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Nota As NotaInfo) As NotaInfo
        Dim NotaSvc As New NotaService(Nota.SessionID)
        Return Update(NotaSvc, CType(Nota, NotaInfo))
    End Function


    ''' <summary>
    ''' Elimina un elemento del documento de NotasTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idNota">Identificador del Nota que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idNota As String)
        Dim NotaSvc As New NotaService(sessionID)
        Delete(NotaSvc, idNota)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Nota con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idNota">ID de Nota que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idNota As String) As Boolean
        Dim NotaSvc As New NotaService(sessionID)
        Return Exists(NotaSvc, idNota)
    End Function


    ''' <summary>
    ''' Obtiene la información de un Nota.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idNota">Identificador de Nota a consultar</param>
    ''' <returns>Paquete de información de tipo NotaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idNota As String) As NotaInfo
        Return Me.GetDetail(sessionID, idNota, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Nota.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idNota">Identificador de Nota</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Nota.</param>
    ''' <returns>Paquete de información de tipo NotaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idNota As String, ByVal checkStatus As Boolean) As NotaInfo
        Dim NotaSvc As New NotaService(sessionID)
        Dim NotaInf As New NotaInfo(sessionID)
        GetDetail(NotaSvc, NotaInf, idNota)
        Return NotaInf
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim NotaSvc As New NotaService(sessionID)
        Return GetNumberOfPages(NotaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca NotasTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Dim NotaSvc As New NotaService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca NotasTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim NotaSvc As New NotaService(sessionID)
        Return GetSearchResult(NotaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de NotasTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim NotaSvc As New NotaService(sessionID)
        Return GetSearchStructure(NotaSvc)
    End Function

#End Region

End Class
