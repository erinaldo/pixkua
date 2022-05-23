''' <summary>
''' Paquete de información que representa un Comanda
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ComandaInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"
    Protected Friend _IdCaja As Integer
#End Region

#Region "Propiedades"

    Public Property IdMesero As Integer

    Public Property IdMesa As Integer

    Public Property Observaciones As String = String.Empty

    Public Property IngredientesExtra As ComandaDS.IngredientesExtraDataTable

    Public Property IdCliente As Integer

    Public Property IdRepartidor As Integer

    Public Property IdDivisa As Integer
    Public ReadOnly Property IdCaja As Integer
        Get
            Return _IdCaja
        End Get
    End Property

  'Se debe de agregar un Dataset con este nombre y con esta tabla incluida.
  'Esta tabla es el resultado simetrico de la funcion fxComandaDetSEL
    Public ReadOnly Property Details() As ComandaDS.ComandaDetDataTable
        Get
            Return CType(DetailsTable, ComandaDS.ComandaDetDataTable)
        End Get
    End Property
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        DetailsTable = New ComandaDS.ComandaDetDataTable
        IngredientesExtra = New ComandaDS.IngredientesExtraDataTable
    End Sub
#End Region

#Region "Metodos Publicos"

#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de ComandaTit
''' </summary>
''' <remarks></remarks>
Public Class ComandaService
    Inherits DocumentService(Of ComandaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Restaurant", "ComandaTit", "ComandaDet", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub

#End Region

#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdComanda As String, ByVal IdStatus As Integer, ByVal FechaTrabajo As DateTime)
        MyBase.ApplyWorkflow(IdComanda, IdStatus, FechaTrabajo)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdComanda As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdComanda, IdStatus)
    End Sub


    Public Overrides Function Create() As ComandaInfo
        Return New ComandaInfo(SessionID)
    End Function


    Public Overrides Sub GetDetail(ByVal idComanda As String, ByRef Comanda As ComandaInfo)
        MyBase.GetDetail(idComanda, Comanda)
        With Comanda
            .IdMesero = CInt(DocInfo("IdMesero"))
            .IdMesa = CInt(DocInfo("IdMesa"))
            .IdCliente = CInt(DocInfo("IdCliente"))
            .IdRepartidor = CInt(DocInfo("IdRepartidor"))
            .Observaciones = CStr(DocInfo("Observaciones"))
            .IdDivisa = CInt(DocInfo("IdDivisa"))
            ._IdCaja = CInt(DocInfo("IdCaja"))
            loadInsumosExtras(Comanda)
        End With
    End Sub

    Public Overrides Function Update(ByVal Comanda As ComandaInfo) As ComandaInfo
        With Me.SPUpdate.Parameters
            .Add("@IdMesero", DbType.Int32).Value = Comanda.IdMesero
            .Add("@IdMesa", DbType.Int32).Value = Comanda.IdMesa
            .Add("@IdCliente", DbType.Int32).Value = Comanda.IdCliente
            .Add("@IdRepartidor", DbType.Int32).Value = Comanda.IdRepartidor
            .Add("@Observaciones", DbType.String).Value = Comanda.Observaciones
            .Add("@IdDivisa", DbType.Int32).Value = Comanda.IdDivisa
        End With
        Comanda = MyBase.Update(Comanda)
        saveInsumosExtras(Comanda)
        Return Comanda

    End Function

#End Region

#Region "Metodos Privados"
    Private Sub loadInsumosExtras(ByVal info As ComandaInfo)
        Try
            info.IngredientesExtra.Rows.Clear()
            Dim fx As New FunctionSQL("Restaurant", "fxComandaDetExtraSEL", Connection, Transaction)
            fx.Parameters.Add("@IdComanda", DbType.String).Value = info.Identity
            fx.FillDataTable(info.IngredientesExtra)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de ingredientes extra.", ex)
        End Try
    End Sub

    Private Sub saveInsumosExtras(ByVal info As ComandaInfo)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Restaurant.ComandaDetExtrasUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure

            cmdInsert.Parameters.Add("@IdComandaTit", DbType.String).Value = info.Identity
            cmdInsert.Parameters.Add("@Fecha", DbType.DateTime).Value = info.Fecha
            cmdInsert.Parameters.Add("@IdArticulo", DbType.Int32, "IdArticulo")
            cmdInsert.Parameters.Add("@Partida", DbType.Int32, "Partida")
            cmdInsert.Parameters.Add("@IdInsumo", DbType.Int32, "IdInsumo")


            Dim cmdDelete As New Azteca.Data.DbCommand("Restaurant.ComandaDetExtrasDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdComandaTit", DbType.String).Value = info.Identity
            cmdDelete.Parameters.Add("@Fecha", DbType.DateTime).Value = info.Fecha
            cmdDelete.Parameters.Add("@IdArticulo", DbType.Int32, "IdArticulo")
            cmdDelete.Parameters.Add("@Partida", DbType.Int32, "Partida")

            cmdDelete.CommandType = CommandType.StoredProcedure

            'Actualizar Insumos Extras
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.DeleteCommand = cmdDelete
            da.Update(info.IngredientesExtra)
        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de Ingredientes extras.", ex)
        End Try

    End Sub

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de ComandaTit
''' </summary>
''' <remarks></remarks>
Public Class ComandaFacade
    Inherits DocumentFacade(Of ComandaInfo)

#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo ComandaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal sessionID As GUID, ByVal IdComanda As String, ByVal IdStatus As Integer, ByVal FechaTrabajo As DateTime)
        Dim ComandaSvc As New ComandaService(sessionID)
        ApplyWorkflow(ComandaSvc, IdComanda, IdStatus, FechaTrabajo)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo ComandaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal sessionID As GUID, ByVal IdComanda As String, ByVal IdStatus As Integer)
        Dim ComandaSvc As New ComandaService(sessionID)
        CancelWorkflow(ComandaSvc, IdComanda, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un ComandaInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ComandaInfo
        Dim ComandaSvc As New ComandaService(sessionID)
        Return ComandaSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un Comanda.
    ''' </summary>
    ''' <param name="Comanda">Paquete de información del tipo ComandaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Comanda, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Comanda As ComandaInfo) As ComandaInfo
        Dim ComandaSvc As New ComandaService(Comanda.SessionID)
        Return Update(ComandaSvc, CType(Comanda, ComandaInfo))
    End Function


    ''' <summary>
    ''' Elimina un elemento del documento de ComandaTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idComanda">Identificador del Comanda que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idComanda As String)
        Dim ComandaSvc As New ComandaService(sessionID)
        Delete(ComandaSvc, idComanda)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Comanda con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idComanda">ID de Comanda que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idComanda As String) As Boolean
        Dim ComandaSvc As New ComandaService(sessionID)
        Return Exists(ComandaSvc, idComanda)
    End Function


    ''' <summary>
    ''' Obtiene la información de un Comanda.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idComanda">Identificador de Comanda a consultar</param>
    ''' <returns>Paquete de información de tipo ComandaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idComanda As String) As ComandaInfo
        Return Me.GetDetail(sessionID, idComanda, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Comanda.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idComanda">Identificador de Comanda</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Comanda.</param>
    ''' <returns>Paquete de información de tipo ComandaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idComanda As String, ByVal checkStatus As Boolean) As ComandaInfo
        Dim ComandaSvc As New ComandaService(sessionID)
        Dim ComandaInf As New ComandaInfo(sessionID)
        GetDetail(ComandaSvc, ComandaInf, idComanda)
        Return ComandaInf
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ComandaSvc As New ComandaService(sessionID)
        Return GetNumberOfPages(ComandaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca ComandaTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Dim ComandaSvc As New ComandaService(sessionID)
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca ComandaTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ComandaSvc As New ComandaService(sessionID)
        Return GetSearchResult(ComandaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de ComandaTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ComandaSvc As New ComandaService(sessionID)
        Return GetSearchStructure(ComandaSvc)
    End Function

#End Region

End Class
