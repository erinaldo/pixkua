''' <summary>
''' Paquete de información que representa un Departamento
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class DepartamentoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property IdCuenta As Integer

    Public Property IdCentral As Integer

    Public Property Departamento As Azteca.Business.RH.DepartamentoInfo

    Public Property TipoAdmonPresupuesto As TipoAdmonPresupuestoEnum

    Public Property IdCajaGastos As Integer

    Public Property CategoriasPresup As New ConfiguracionDS.CategoriasPresupuestalesDataTable

    Public Property ConceptosTable As ConfiguracionDS.DepartamentosGastosConceptosDataTable

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        Me.Departamento = New Azteca.Business.RH.DepartamentoInfo(sessionID)
        CategoriasPresup = New ConfiguracionDS.CategoriasPresupuestalesDataTable
        ConceptosTable = New ConfiguracionDS.DepartamentosGastosConceptosDataTable
    End Sub
#End Region

#Region "Metodos Compartidos"

    Shared Function GetTipoAdmonPresupuesto(ByVal Tipo As String) As TipoAdmonPresupuestoEnum
        If Tipo = "C" Then
            Return TipoAdmonPresupuestoEnum.Categorizado
        ElseIf Tipo = "G" Then
            Return TipoAdmonPresupuestoEnum.Global_Depto
        Else
            Return TipoAdmonPresupuestoEnum.No
        End If
    End Function

#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Departamentos
''' </summary>
''' <remarks></remarks>
Public Class DepartamentoService
    Inherits CatalogService(Of DepartamentoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As guid)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "Departamentos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idDepartamento As Integer, ByRef Departamento As DepartamentoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idDepartamento, Departamento, checkStatus)
        With Departamento
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            .IdCentral = CInt(ItemInfo("IdCentral"))
            .IdCajaGastos = CInt(ItemInfo("IdCaja"))
            .TipoAdmonPresupuesto = getTipoAdmonPresupuesto(CStr(ItemInfo("AdmonPresupuesto")))
            Dim DeptoRH As New Azteca.Business.RH.DepartamentoService(Me.SessionID, Me.Connection, Me.Transaction)
            DeptoRH.GetDetail(Departamento.Identity, Departamento.Departamento, False)
            If .TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then loadCategorias(Departamento)
            loadConceptos(Departamento)
        End With

    End Sub

    Public Overrides Function Update(ByVal Departamento As DepartamentoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@IdCuenta", DbType.Int32).Value = Departamento.IdCuenta
            .Add("@IdCentral", DbType.Int32).Value = Departamento.IdCentral
            .Add("@IdCaja", DbType.Int32).Value = Departamento.IdCajaGastos
            .Add("@AdmonPresupuesto", DbType.String).Value = getTipoAdmonPresupuesto(Departamento.TipoAdmonPresupuesto)
        End With
        Azteca.Kernel.Cache.Remove("Purchasing_Departamentos" & Departamento.Identity.ToString)
        Dim Id As Integer = MyBase.Update(Departamento)
        If Departamento.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then saveCategorias(Departamento)
        saveConceptos(Departamento)

        Return Id
    End Function

    Public Overrides Function Create() As DepartamentoInfo
        Return New DepartamentoInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"
    Private Sub loadConceptos(info As DepartamentoInfo)
        Try
            info.ConceptosTable.Rows.Clear()
            Dim fx As New FunctionSQL("Purchasing", "fxDepartamentosGastosConceptosSEL", Connection, Transaction)
            fx.Parameters.Add("@IdDepartamento", DbType.Int32).Value = info.Identity
            fx.FillDataTable(info.ConceptosTable)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Conceptos de gastos que maneja el departamento.", ex)
        End Try
    End Sub

    Private Sub loadCategorias(ByVal info As DepartamentoInfo)
        Try
            info.CategoriasPresup.Rows.Clear()
            Dim fx As New FunctionSQL("Purchasing", "fxDepartamentosCategoriasSEL", Connection, Transaction)
            fx.Parameters.Add("@IdDepartamento", DbType.Int32).Value = info.Identity
            fx.FillDataTable(info.CategoriasPresup)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Categorias presupuestales.", ex)
        End Try
    End Sub

    Private Sub saveConceptos(ByVal info As DepartamentoInfo)
        Try
            'Definir comando de actualización de detalle 
            Dim cmdInsert As New Azteca.Data.DbCommand("Purchasing.DepartamentosGastosConceptosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure
            cmdInsert.Parameters.Add("@IdDepartamento", DbType.Int32).Value = info.Identity
            cmdInsert.Parameters.Add("@IdGastoConcepto", DbType.Int32, "IdGastoConcepto")
            cmdInsert.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmdInsert.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity

            Dim cmdDelete As New Azteca.Data.DbCommand("Purchasing.DepartamentosGastosConceptosDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdDepartamento", DbType.Int32).Value = info.Identity
            cmdDelete.Parameters.Add("@IdGastoConcepto", DbType.Int32, "IdGastoConcepto")
            cmdDelete.CommandType = CommandType.StoredProcedure

            'Actualizar detalles
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.DeleteCommand = cmdDelete
            da.Update(info.ConceptosTable)
        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de Conceptos de Gastos.", ex)
        End Try
    End Sub

    Private Sub saveCategorias(ByVal info As DepartamentoInfo)
        Try
            'Definir comando de actualización de detalle de racs
            Dim cmdInsert As New Azteca.Data.DbCommand("Purchasing.DepartamentosCategoriasUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure
            cmdInsert.Parameters.Add("@IdDepartamento", DbType.Int32).Value = info.Identity
            cmdInsert.Parameters.Add("@IdCategoriaPresupuestal", DbType.Int32, "IdCategoriaPresupuestal")
            cmdInsert.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmdInsert.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity

            Dim cmdDelete As New Azteca.Data.DbCommand("Purchasing.DepartamentosCategoriasDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdDepartamento", DbType.Int32).Value = info.Identity
            cmdDelete.Parameters.Add("@IdCategoriaPresupuestal", DbType.Int32, "IdCategoriaPresupuestal")
            cmdDelete.CommandType = CommandType.StoredProcedure

            'Actualizar Articulos
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.DeleteCommand = cmdDelete
            da.Update(info.CategoriasPresup)
        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de Categorias Presupuestales.", ex)
        End Try
    End Sub


    Shared Function getTipoAdmonPresupuesto(ByVal Tipo As TipoAdmonPresupuestoEnum) As String
        If Tipo = TipoAdmonPresupuestoEnum.Categorizado Then
            Return "C"
        ElseIf Tipo = TipoAdmonPresupuestoEnum.Global_Depto Then
            Return "G"
        Else ' 
            Return "N"
        End If
    End Function

    Shared Function getTipoAdmonPresupuesto(ByVal Tipo As String) As TipoAdmonPresupuestoEnum
        If Tipo = "C" Then
            Return TipoAdmonPresupuestoEnum.Categorizado
        ElseIf Tipo = "G" Then
            Return TipoAdmonPresupuestoEnum.Global_Depto
        Else
            Return TipoAdmonPresupuestoEnum.No
        End If
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Departamentos
''' </summary>
''' <remarks></remarks>
Public Class DepartamentoFacade
    Inherits CatalogFacade(Of DepartamentoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un DepartamentoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As guid) As DepartamentoInfo
        Dim DepartamentoSvc As New DepartamentoService(sessionID)
        Return DepartamentoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Departamentos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDepartamento">Identificador del Departamento que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As guid, ByVal idDepartamento As Integer)
        Dim DepartamentoSvc As New DepartamentoService(sessionID)
        Delete(DepartamentoSvc, idDepartamento)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Departamento con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDepartamento">ID de Departamento que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As guid, ByVal idDepartamento As Integer) As Boolean
        Dim DepartamentoSvc As New DepartamentoService(sessionID)
        Return Exists(DepartamentoSvc, idDepartamento)
    End Function

    ''' <summary>
    ''' Verifica si existe un Departamento con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim DepartamentoSvc As New DepartamentoService(sessionID)
        Return Exists(DepartamentoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Departamento.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDepartamento">Identificador de Departamento a consultar</param>
    ''' <returns>Paquete de información de tipo DepartamentoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As guid, ByVal idDepartamento As Integer) As DepartamentoInfo
        Return Me.GetDetail(sessionID, idDepartamento, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Departamento.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idDepartamento">Identificador de Departamento</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Departamento.</param>
    ''' <returns>Paquete de información de tipo DepartamentoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As guid, ByVal idDepartamento As Integer, ByVal checkStatus As Boolean) As DepartamentoInfo
        Dim DepartamentoSvc As New DepartamentoService(sessionID)
        Dim DepartamentoInf As New DepartamentoInfo(sessionID)
        GetDetail(DepartamentoSvc, DepartamentoInf, idDepartamento, checkStatus)
        Return DepartamentoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Departamento en base a su codigo de usuario
    ''' y verifica que el Departamento esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información DepartamentoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer) As DepartamentoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Departamento en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Departamento</param>
    ''' <returns>Paquete de información DepartamentoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As DepartamentoInfo
        Dim DepartamentoInf As New DepartamentoInfo(sessionID)
        Dim DepartamentoSvc As New DepartamentoService(sessionID)
        GetDetail(DepartamentoSvc, DepartamentoInf, userCode, idSucursal, checkStatus)
        Return DepartamentoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Departamento.
    ''' </summary>
    ''' <param name="Departamento">Paquete de información del tipo DepartamentoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Departamento, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Departamento As DepartamentoInfo) As Integer
        Dim DepartamentoSvc As New DepartamentoService(Departamento.SessionID)
        Return Update(DepartamentoSvc, Departamento)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim DepartamentoSvc As New DepartamentoService(sessionID)
        Return GetNumberOfPages(DepartamentoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Departamentos que coincidan con las condiciones especificadas.
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
    ''' Busca Departamentos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim DepartamentoSvc As New DepartamentoService(sessionID)
        Return GetSearchResult(DepartamentoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Departamentos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As guid) As System.Data.DataSet
        Dim DepartamentoSvc As New DepartamentoService(sessionID)
        Return GetSearchStructure(DepartamentoSvc)
    End Function

#End Region

End Class

Public Enum TipoAdmonPresupuestoEnum
    No
    Global_Depto
    Categorizado
End Enum