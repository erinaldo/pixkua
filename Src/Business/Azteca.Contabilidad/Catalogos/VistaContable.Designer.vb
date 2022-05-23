''' <summary>
''' Paquete de información que representa un VistaContable
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class VistaContableInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Descripcion As String

    Public Property Schema As String

    Public Property Objeto As String

    Public Property IdObjeto As String

    Public Property Referencia As String

    Public Property IdDocumentoTipo As Integer

    Public Property EntidadesTable As VistaContableDS.EntidadesDataTable

    Public Property ImportesTable As VistaContableDS.ImportesDataTable
#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        EntidadesTable = New VistaContableDS.EntidadesDataTable
        ImportesTable = New VistaContableDS.ImportesDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de VistasContablesTit
''' </summary>
''' <remarks></remarks>
Public Class VistaContableService
    Inherits CatalogService(Of VistaContableInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "VistasContablesTit", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idVistaContable As Integer, ByRef VistaContable As VistaContableInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idVistaContable, VistaContable, checkStatus)
        With VistaContable
            .Descripcion = CStr(ItemInfo("Descripcion"))
            .Schema = CStr(ItemInfo("Schema"))
            .Objeto = CStr(ItemInfo("Objeto"))
            .IdObjeto = CStr(ItemInfo("IdObjeto"))
            .Referencia = CStr(ItemInfo("Referencia"))
            .IdDocumentoTipo = CInt(ItemInfo("IdDocumentoTipo"))
            LoadEntidades(VistaContable)
            LoadImportes(VistaContable)
        End With
    End Sub

    Public Overrides Function Update(ByVal VistaContable As VistaContableInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Descripcion", DbType.String).Value = VistaContable.Descripcion
            .Add("@Schema", DbType.String).Value = VistaContable.Schema
            .Add("@Objeto", DbType.String).Value = VistaContable.Objeto
            .Add("@IdObjeto", DbType.String).Value = VistaContable.IdObjeto
            .Add("@Referencia", DbType.String).Value = VistaContable.Referencia
            .Add("@IdDocumentoTipo", DbType.Int32).Value = VistaContable.IdDocumentoTipo
            saveEntidades(VistaContable)
            saveImportes(VistaContable)
        End With
        Return MyBase.Update(VistaContable)
    End Function

    Public Overrides Function Create() As VistaContableInfo
        Return New VistaContableInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"
    Private Sub LoadEntidades(ByVal VistaContable As VistaContableInfo)
        Try
            Dim fx As New FunctionSQL("Accounting", "fxVistasContablesEntidadesSEL", Connection, Transaction)
            fx.Parameters.Add("@Schema", DbType.String).Value = VistaContable.Schema
            fx.Parameters.Add("@Objeto", DbType.String).Value = VistaContable.Objeto
            fx.Parameters.Add("@IdVistaContableTit", DbType.Int32).Value = VistaContable.Identity
            fx.FillDataTable(VistaContable.EntidadesTable)
            For Each dr As VistaContableDS.EntidadesRow In VistaContable.EntidadesTable
                dr.SetModified()
            Next
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de Entidades", ex)
        End Try
    End Sub
    Private Sub LoadImportes(ByVal VistaContable As VistaContableInfo)
        Try
            Dim fx As New FunctionSQL("Accounting", "fxVistasContablesImportesSEL", Connection, Transaction)
            fx.Parameters.Add("@Schema", DbType.String).Value = VistaContable.Schema
            fx.Parameters.Add("@Objeto", DbType.String).Value = VistaContable.Objeto
            fx.Parameters.Add("@IdVistaContableTit", DbType.Int32).Value = VistaContable.Identity
            fx.FillDataTable(VistaContable.ImportesTable)
            For Each dr As VistaContableDS.ImportesRow In VistaContable.ImportesTable
                dr.SetModified()
            Next
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de importes", ex)
        End Try
    End Sub

    Private Sub saveEntidades(ByVal VistaContable As VistaContableInfo)
        Try
            Dim cmd As New DbCommand("Accounting.VistasContablesEntidadUPD", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id", DbType.Int32, "IdVistaContableEntidad")
            cmd.Parameters.Add("@IdVistaContableTit", DbType.Int32).Value = VistaContable.Identity
            cmd.Parameters.Add("@Columna", DbType.String, "Columna")
            cmd.Parameters.Add("@IdEntidad", DbType.Int32, "IdEntidad")

            Dim dv As New DataView(VistaContable.EntidadesTable, "IdEntidad>0", "", DataViewRowState.ModifiedCurrent)

            Dim da As New Azteca.Data.DataAdapter
            da.InsertCommand = cmd : da.UpdateCommand = cmd '': da.DeleteCommand = cmdDEL
            Dim i As Integer = da.Update(VistaContable.EntidadesTable)

        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de Entidades", ex)
        End Try
    End Sub

    Private Sub saveImportes(ByVal VistaContable As VistaContableInfo)
        Try
            Dim cmd As New DbCommand("Accounting.VistasContablesImporteUPD", Me.Connection, Me.Transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Id", DbType.Int32, "IdVistaContableImporte")
            cmd.Parameters.Add("@IdVistaContableTit", DbType.Int32).Value = VistaContable.Identity
            cmd.Parameters.Add("@Columna", DbType.String, "Columna")
            cmd.Parameters.Add("@IdImporte", DbType.Int32, "IdImporte")

            Dim dv As New DataView(VistaContable.ImportesTable, "IdImporte>0", "", DataViewRowState.ModifiedCurrent)

            Dim da As New Azteca.Data.DataAdapter
            da.InsertCommand = cmd : da.UpdateCommand = cmd '': da.DeleteCommand = cmdDEL
            da.Update(VistaContable.ImportesTable)
        Catch ex As Exception
            Throw New BusinessException("Error al guardar la lista de Importes", ex)
        End Try
    End Sub


#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de VistasContablesTit
''' </summary>
''' <remarks></remarks>
Public Class VistaContableFacade
    Inherits CatalogFacade(Of VistaContableInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un VistaContableInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As VistaContableInfo
        Dim VistaContableSvc As New VistaContableService(sessionID)
        Return VistaContableSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de VistasContablesTit
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idVistaContable">Identificador del VistaContable que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idVistaContable As Integer)
        Dim VistaContableSvc As New VistaContableService(sessionID)
        Delete(VistaContableSvc, idVistaContable)
    End Sub

    ''' <summary>
    ''' Verifica si existe un VistaContable con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idVistaContable">ID de VistaContable que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idVistaContable As Integer) As Boolean
        Dim VistaContableSvc As New VistaContableService(sessionID)
        Return Exists(VistaContableSvc, idVistaContable)
    End Function

    ''' <summary>
    ''' Verifica si existe un VistaContable con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim VistaContableSvc As New VistaContableService(sessionID)
        Return Exists(VistaContableSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un VistaContable.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idVistaContable">Identificador de VistaContable a consultar</param>
    ''' <returns>Paquete de información de tipo VistaContableInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idVistaContable As Integer) As VistaContableInfo
        Return Me.GetDetail(sessionID, idVistaContable, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un VistaContable.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idVistaContable">Identificador de VistaContable</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del VistaContable.</param>
    ''' <returns>Paquete de información de tipo VistaContableInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idVistaContable As Integer, ByVal checkStatus As Boolean) As VistaContableInfo
        Dim VistaContableSvc As New VistaContableService(sessionID)
        Dim VistaContableInf As New VistaContableInfo(sessionID)
        GetDetail(VistaContableSvc, VistaContableInf, idVistaContable, checkStatus)
        Return VistaContableInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un VistaContable en base a su codigo de usuario
    ''' y verifica que el VistaContable esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información VistaContableInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As VistaContableInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un VistaContable en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del VistaContable</param>
    ''' <returns>Paquete de información VistaContableInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As VistaContableInfo
        Dim VistaContableInf As New VistaContableInfo(sessionID)
        Dim VistaContableSvc As New VistaContableService(sessionID)
        GetDetail(VistaContableSvc, VistaContableInf, userCode, idSucursal, checkStatus)
        Return VistaContableInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un VistaContable.
    ''' </summary>
    ''' <param name="VistaContable">Paquete de información del tipo VistaContableInfo con la información a actualizar</param>
    ''' <returns>Identificador de VistaContable, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal VistaContable As VistaContableInfo) As Integer
        Dim VistaContableSvc As New VistaContableService(VistaContable.SessionID)
        Return Update(VistaContableSvc, VistaContable)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim VistaContableSvc As New VistaContableService(sessionID)
        Return GetNumberOfPages(VistaContableSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca VistasContablesTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca VistasContablesTit que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim VistaContableSvc As New VistaContableService(sessionID)
        Return GetSearchResult(VistaContableSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de VistasContablesTit.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim VistaContableSvc As New VistaContableService(sessionID)
        Return GetSearchStructure(VistaContableSvc)
    End Function

#End Region

End Class
