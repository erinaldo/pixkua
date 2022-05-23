''' <summary>
''' Paquete de información que representa un GastoConceptoTipo
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class GastoConceptoTipoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdCuenta As Integer

    Public Property ConceptosTable As ConfiguracionDS.ConceptosDataTable
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        ConceptosTable = New ConfiguracionDS.ConceptosDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de GastosConceptosTipos
''' </summary>
''' <remarks></remarks>
Public Class GastoConceptoTipoService
    Inherits CatalogService(Of GastoConceptoTipoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As guid)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "GastosConceptosTipos", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idGastoConceptoTipo As Integer, ByRef GastoConceptoTipo As GastoConceptoTipoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idGastoConceptoTipo, GastoConceptoTipo, checkStatus)
        With GastoConceptoTipo
            .Nombre = CStr(ItemInfo("Nombre"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
        End With
        loadConceptos(GastoConceptoTipo)
    End Sub

    Public Overrides Function Update(ByVal GastoConceptoTipo As GastoConceptoTipoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = GastoConceptoTipo.Nombre
            .Add("@IdCuenta", DbType.Int32).Value = GastoConceptoTipo.IdCuenta
        End With
        Dim Id As Integer = MyBase.Update(GastoConceptoTipo)
        saveConceptos(GastoConceptoTipo)
        Return id
    End Function

    Public Overrides Function Create() As GastoConceptoTipoInfo
        Return New GastoConceptoTipoInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"
    Private Sub loadConceptos(ByVal info As GastoConceptoTipoInfo)
        Try
            info.ConceptosTable.Rows.Clear()
            Dim fx As New FunctionSQL("Purchasing", "fxGastosConceptosListSEL", Connection, Transaction)
            fx.Parameters.Add("@IdGastoConceptoTipo", DbType.Int32).Value = info.Identity
            fx.FillDataTable(info.ConceptosTable)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Conceptos del tipo de gasto.", ex)
        End Try
    End Sub
    Private Sub saveConceptos(ByVal info As GastoConceptoTipoInfo)
        Try
            'Definir comando de actualización de detalle
            Dim cmdInsert As New Azteca.Data.DbCommand("Purchasing.GastosConceptosUPD", Connection, Transaction)
            cmdInsert.CommandType = CommandType.StoredProcedure
            cmdInsert.Parameters.Add("@Id", DbType.Int32, "IdGastoConcepto")
            cmdInsert.Parameters.Add("@Nombre", DbType.String, "Concepto")
            cmdInsert.Parameters.Add("@IdGastoConceptoTipo", DbType.Int32).Value = info.Identity
            cmdInsert.Parameters.Add("@IdCategoriaPresupuestal", DbType.Int32, "IdCategoriaPresupuestal")
            cmdInsert.Parameters.Add("@IdCuenta", DbType.Int32, "IdCuenta")
            cmdInsert.Parameters.Add("@IdSucursal", DbType.String).Value = info.IdSucursal
            cmdInsert.Parameters.Add("@IdEmpresa", DbType.String).Value = info.IdEmpresa
            cmdInsert.Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            cmdInsert.Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity

            Dim cmdDelete As New Azteca.Data.DbCommand("Purchasing.GastosConceptosDEL", Connection, Transaction)
            cmdDelete.Parameters.Add("@IdGastoConceptoTipo", DbType.Int32).Value = info.Identity
            cmdDelete.Parameters.Add("@IdGastoConcepto", DbType.Int32, "IdGastoConcepto")
            cmdDelete.CommandType = CommandType.StoredProcedure

            'Actualizar detalle
            Dim da As New Azteca.Data.DataAdapter()
            da.UpdateCommand = cmdInsert
            da.InsertCommand = cmdInsert
            da.DeleteCommand = cmdDelete
            da.Update(info.ConceptosTable)
        Catch concurrencyEx As System.Data.DBConcurrencyException
        Catch ex As Exception
            Throw New BusinessException("Error al guardar los conceptos del Tipo de gasto.", ex)
        End Try
    End Sub
#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de GastosConceptosTipos
''' </summary>
''' <remarks></remarks>
Public Class GastoConceptoTipoFacade
    Inherits CatalogFacade(Of GastoConceptoTipoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un GastoConceptoTipoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As GastoConceptoTipoInfo
        Dim GastoConceptoTipoSvc As New GastoConceptoTipoService(sessionID)
        Return GastoConceptoTipoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de GastosConceptosTipos
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGastoConceptoTipo">Identificador del GastoConceptoTipo que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idGastoConceptoTipo As Integer)
        Dim GastoConceptoTipoSvc As New GastoConceptoTipoService(sessionID)
        Delete(GastoConceptoTipoSvc, idGastoConceptoTipo)
    End Sub

    ''' <summary>
    ''' Verifica si existe un GastoConceptoTipo con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGastoConceptoTipo">ID de GastoConceptoTipo que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idGastoConceptoTipo As Integer) As Boolean
        Dim GastoConceptoTipoSvc As New GastoConceptoTipoService(sessionID)
        Return Exists(GastoConceptoTipoSvc, idGastoConceptoTipo)
    End Function

    ''' <summary>
    ''' Verifica si existe un GastoConceptoTipo con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim GastoConceptoTipoSvc As New GastoConceptoTipoService(sessionID)
        Return Exists(GastoConceptoTipoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un GastoConceptoTipo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGastoConceptoTipo">Identificador de GastoConceptoTipo a consultar</param>
    ''' <returns>Paquete de información de tipo GastoConceptoTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idGastoConceptoTipo As Integer) As GastoConceptoTipoInfo
        Return Me.GetDetail(sessionID, idGastoConceptoTipo, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un GastoConceptoTipo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idGastoConceptoTipo">Identificador de GastoConceptoTipo</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del GastoConceptoTipo.</param>
    ''' <returns>Paquete de información de tipo GastoConceptoTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As guid, ByVal idGastoConceptoTipo As Integer, ByVal checkStatus As Boolean) As GastoConceptoTipoInfo
        Dim GastoConceptoTipoSvc As New GastoConceptoTipoService(sessionID)
        Dim GastoConceptoTipoInf As New GastoConceptoTipoInfo(sessionID)
        GetDetail(GastoConceptoTipoSvc, GastoConceptoTipoInf, idGastoConceptoTipo, checkStatus)
        Return GastoConceptoTipoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un GastoConceptoTipo en base a su codigo de usuario
    ''' y verifica que el GastoConceptoTipo esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información GastoConceptoTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer) As GastoConceptoTipoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un GastoConceptoTipo en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del GastoConceptoTipo</param>
    ''' <returns>Paquete de información GastoConceptoTipoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As GastoConceptoTipoInfo
        Dim GastoConceptoTipoInf As New GastoConceptoTipoInfo(sessionID)
        Dim GastoConceptoTipoSvc As New GastoConceptoTipoService(sessionID)
        GetDetail(GastoConceptoTipoSvc, GastoConceptoTipoInf, userCode, idSucursal, checkStatus)
        Return GastoConceptoTipoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un GastoConceptoTipo.
    ''' </summary>
    ''' <param name="GastoConceptoTipo">Paquete de información del tipo GastoConceptoTipoInfo con la información a actualizar</param>
    ''' <returns>Identificador de GastoConceptoTipo, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal GastoConceptoTipo As GastoConceptoTipoInfo) As Integer
        Dim GastoConceptoTipoSvc As New GastoConceptoTipoService(GastoConceptoTipo.SessionID)
        Return Update(GastoConceptoTipoSvc, GastoConceptoTipo)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim GastoConceptoTipoSvc As New GastoConceptoTipoService(sessionID)
        Return GetNumberOfPages(GastoConceptoTipoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca GastosConceptosTipos que coincidan con las condiciones especificadas.
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
    ''' Busca GastosConceptosTipos que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim GastoConceptoTipoSvc As New GastoConceptoTipoService(sessionID)
        Return GetSearchResult(GastoConceptoTipoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de GastosConceptosTipos.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As guid) As System.Data.DataSet
        Dim GastoConceptoTipoSvc As New GastoConceptoTipoService(sessionID)
        Return GetSearchStructure(GastoConceptoTipoSvc)
    End Function

#End Region

End Class
