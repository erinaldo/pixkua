''' <summary>
''' Paquete de información que representa un Presupuesto
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class PresupuestoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Protected Friend _TipoPresupuesto As TipoAdmonPresupuestoEnum = TipoAdmonPresupuestoEnum.No
    Protected Friend _Disponible As Decimal
#End Region

#Region "Propiedades"
    Public Property IdPeriodo As Integer

    Public Property IdDepartamento As Integer

    Public ReadOnly Property TipoPresupuesto As TipoAdmonPresupuestoEnum
        Get
            Return _TipoPresupuesto
        End Get
    End Property

    Public Property MontoPresupuesto As Decimal

    Public Property MontoUtilizado As Decimal

    Public Property MontoApartado As Decimal

    Public ReadOnly Property Disponible As Decimal
        Get
            Return _Disponible
        End Get
    End Property

    Public Property Estatus As String

    Public Property CategoriasTable As ConfiguracionDS.PresupuestoCategoriasDataTable
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        CategoriasTable = New ConfiguracionDS.PresupuestoCategoriasDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Presupuestos
''' </summary>
''' <remarks></remarks>
Public Class PresupuestoService
    Inherits CatalogService(Of PresupuestoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As guid)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "Presupuestos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idPresupuesto As Integer, ByRef Presupuesto As PresupuestoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idPresupuesto, Presupuesto, checkStatus)
        With Presupuesto
            .IdPeriodo = CInt(ItemInfo("IdPeriodo"))
            .IdDepartamento = CInt(ItemInfo("IdDepartamento"))
            .MontoPresupuesto = CDec(ItemInfo("MontoPresupuesto"))
            .MontoUtilizado = CDec(ItemInfo("MontoUtilizado"))
            .MontoApartado = CDec(ItemInfo("MontoApartado"))
            ._Disponible = CDec(ItemInfo("Disponible"))
            ._TipoPresupuesto = DepartamentoService.getTipoAdmonPresupuesto(CStr(ItemInfo("AdmonPresupuesto")))
            .Estatus = CStr(ItemInfo("Estatus"))
        End With

        'Çargamos el detalle cuando es un presupuesto Categorizado
        If Presupuesto.TipoPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then LoadCategorias(Presupuesto)

    End Sub

    Public Overrides Function Update(ByVal Presupuesto As PresupuestoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@IdPeriodo", DbType.Int32).Value = Presupuesto.IdPeriodo
            .Add("@IdDepartamento", DbType.Int32).Value = Presupuesto.IdDepartamento
            .Add("@MontoPresupuesto", DbType.Decimal).Value = Presupuesto.MontoPresupuesto
            ''.Add("@MontoUtilizado", DbType.Decimal).Value = Presupuesto.MontoUtilizado
            ''.Add("@MontoApartado", DbType.Decimal).Value = Presupuesto.MontoApartado
            .Add("@Estatus", DbType.String).Value = Presupuesto.Estatus
        End With
        Dim id As Integer = MyBase.Update(Presupuesto)
        If Presupuesto.TipoPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then SaveCategorias(Presupuesto)
        Return id

    End Function

    Public Overrides Function Create() As PresupuestoInfo
        Return New PresupuestoInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"
    Public Sub LoadCategorias(ByVal info As PresupuestoInfo)
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxPresupuestoCategoriasSEL", Connection, Transaction)
            fx.Parameters.Add("@IdPeriodo", DbType.Int32).Value = info.IdPeriodo
            fx.Parameters.Add("@IdDepartamento", DbType.Int32).Value = info.IdDepartamento
            fx.FillDataTable(info.CategoriasTable)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el detalle del presupuesto.", ex)
        End Try
    End Sub
    Public Sub SaveCategorias(ByVal info As PresupuestoInfo)
        Try
            Dim da As New DataAdapter
            Dim cmd As New Azteca.Data.DbCommand("Purchasing.PresupuestoCategoriasUPD", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdPresupuesto", DbType.Int32).Value = info.Identity
            cmd.Parameters.Add("@IdCategoriaPresupuestal", DbType.Int32, "IdCategoriaPresupuestal")
            cmd.Parameters.Add("@MontoPresupuesto", DbType.Decimal, "Presupuestado")

            da.UpdateCommand = cmd : da.InsertCommand = cmd
            da.Update(info.CategoriasTable)

        Catch ex As Exception
            Throw New Exception("Problemas al intentar guardar las categorias de los presupuestos", ex)
        End Try
    End Sub

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Presupuestos
''' </summary>
''' <remarks></remarks>
Public Class PresupuestoFacade
    Inherits CatalogFacade(Of PresupuestoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un PresupuestoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As guid) As PresupuestoInfo
        Dim PresupuestoSvc As New PresupuestoService(sessionID)
        Return PresupuestoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Presupuestos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPresupuesto">Identificador del Presupuesto que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As guid, ByVal idPresupuesto As Integer)
        Dim PresupuestoSvc As New PresupuestoService(sessionID)
        Delete(PresupuestoSvc, idPresupuesto)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Presupuesto con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPresupuesto">ID de Presupuesto que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As guid, ByVal idPresupuesto As Integer) As Boolean
        Dim PresupuestoSvc As New PresupuestoService(sessionID)
        Return Exists(PresupuestoSvc, idPresupuesto)
    End Function

    ''' <summary>
    ''' Verifica si existe un Presupuesto con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim PresupuestoSvc As New PresupuestoService(sessionID)
        Return Exists(PresupuestoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Presupuesto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPresupuesto">Identificador de Presupuesto a consultar</param>
    ''' <returns>Paquete de información de tipo PresupuestoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As guid, ByVal idPresupuesto As Integer) As PresupuestoInfo
        Return Me.GetDetail(sessionID, idPresupuesto, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Presupuesto.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPresupuesto">Identificador de Presupuesto</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Presupuesto.</param>
    ''' <returns>Paquete de información de tipo PresupuestoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As guid, ByVal idPresupuesto As Integer, ByVal checkStatus As Boolean) As PresupuestoInfo
        Dim PresupuestoSvc As New PresupuestoService(sessionID)
        Dim PresupuestoInf As New PresupuestoInfo(sessionID)
        GetDetail(PresupuestoSvc, PresupuestoInf, idPresupuesto, checkStatus)
        Return PresupuestoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Presupuesto en base a su codigo de usuario
    ''' y verifica que el Presupuesto esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información PresupuestoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer) As PresupuestoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Presupuesto en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Presupuesto</param>
    ''' <returns>Paquete de información PresupuestoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As PresupuestoInfo
        Dim PresupuestoInf As New PresupuestoInfo(sessionID)
        Dim PresupuestoSvc As New PresupuestoService(sessionID)
        GetDetail(PresupuestoSvc, PresupuestoInf, userCode, idSucursal, checkStatus)
        Return PresupuestoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Presupuesto.
    ''' </summary>
    ''' <param name="Presupuesto">Paquete de información del tipo PresupuestoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Presupuesto, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Presupuesto As PresupuestoInfo) As Integer
        Dim PresupuestoSvc As New PresupuestoService(Presupuesto.SessionID)
        Return Update(PresupuestoSvc, Presupuesto)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim PresupuestoSvc As New PresupuestoService(sessionID)
        Return GetNumberOfPages(PresupuestoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Presupuestos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Presupuestos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim PresupuestoSvc As New PresupuestoService(sessionID)
        Return GetSearchResult(PresupuestoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Presupuestos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As guid) As System.Data.DataSet
        Dim PresupuestoSvc As New PresupuestoService(sessionID)
        Return GetSearchStructure(PresupuestoSvc)
    End Function

#End Region

End Class
