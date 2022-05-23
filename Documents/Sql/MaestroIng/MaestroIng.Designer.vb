''' <summary>
''' Paquete de información que representa un MaestroIng
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class MaestroIngInfo
	Inherits DocumentInfo
	
#Region "Variables Privadas"
	Private _Fecha AS Date
	Private _IdOrdenTrabajoTipo AS Integer
	Private _IdArticuloStock AS Integer
	Private _IdInsumo AS Integer
	Private _Cantidad AS Decimal
	Private _Saldo AS Decimal
	Private _IdUnidadMedida AS Integer
	Private _IdOrdenTrabajoUltima AS String
	Private _FechaOrdenTrabajoUltima AS Date
	Private _Observaciones AS String

#End Region

#Region "Propiedades"
	Public Property Fecha As Date	Public Property IdOrdenTrabajoTipo As Integer	Public Property IdArticuloStock As Integer	Public Property IdInsumo As Integer	Public Property Cantidad As Decimal	Public Property Saldo As Decimal	Public Property IdUnidadMedida As Integer	Public Property IdOrdenTrabajoUltima As String	Public Property FechaOrdenTrabajoUltima As Date	Public Property Observaciones As String
  'Se debe de agregar un Dataset con este nombre y con esta tabla incluida.
  'Esta tabla es el resultado simetrico de la funcion fxMaestroIngDetSEL
   Public ReadOnly Property Details() As DetalleMaestroIngDS.MaestroIngDataTable
        Get
            Return CType(DetailsTable, DetalleMaestroIngDS.DetalleDataTable)
        End Get
    End Property
#End Region
	
#Region "Constructor"
	Public Sub New(ByVal session As UserSession)
		MyBase.New(session)
		DetailsTable = New DetalleMaestroIngDS.DetalleDataTable
	End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de MaestrosIng
''' </summary>
''' <remarks></remarks>
Public Class MaestroIngService
	Inherits DocumentService(Of MaestroIngInfo)
	
#Region "Constructores"
    Public Sub New(ByVal Session As UserSession)
        Me.New(Session, Nothing)
    End Sub

    Public Sub New(ByVal Session As UserSession, ByVal cnn As IDbConnection)
        Me.New(Session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal Session As UserSession, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Production", "", "", Session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
    
#End Region


	
#Region "Metodos de DocumentService"

    Public Overrides Sub ApplyWorkflow(ByVal IdMaestroIng As String, ByVal IdStatus As Integer)
        MyBase.ApplyWorkflow(IdMaestroIng, IdStatus)
    End Sub

    Public Overrides Sub CancelWorkflow(ByVal IdMaestroIng As String, ByVal IdStatus As Integer)
        MyBase.CancelWorkflow(IdMaestroIng, IdStatus)
    End Sub

	
    Public Overrides Function Create() As MaestroIngInfo
	Return New MaestroIngInfo(Session)
    End Function


    Public Overrides Sub GetDetail(ByVal idMaestroIng As string, ByRef MaestroIng As MaestroIngInfo)
		MyBase.GetDetail(idMaestroIng, MaestroIng)
        With MaestroIng
			.Fecha = CDate(Me.ItemInfo("Fecha"))
			.IdOrdenTrabajoTipo = CInt(Me.ItemInfo("IdOrdenTrabajoTipo"))
			.IdArticuloStock = CInt(Me.ItemInfo("IdArticuloStock"))
			.IdInsumo = CInt(Me.ItemInfo("IdInsumo"))
			.Cantidad = CDec(Me.ItemInfo("Cantidad"))
			.Saldo = CDec(Me.ItemInfo("Saldo"))
			.IdUnidadMedida = CInt(Me.ItemInfo("IdUnidadMedida"))
			.IdOrdenTrabajoUltima = CStr(Me.ItemInfo("IdOrdenTrabajoUltima"))
			.FechaOrdenTrabajoUltima = CDate(Me.ItemInfo("FechaOrdenTrabajoUltima"))
			.Observaciones = CStr(Me.ItemInfo("Observaciones"))

		End With
    End Sub
	
    Public Overrides Function Update(ByVal MaestroIng As MaestroIngInfo) As MaestroIngInfo
        With Me.SPUpdate.Parameters
			.Add("@Fecha", DbType.DateTime).Value = MaestroIng.Fecha
			.Add("@IdOrdenTrabajoTipo", DbType.Int32).Value = MaestroIng.IdOrdenTrabajoTipo
			.Add("@IdArticuloStock", DbType.Int32).Value = MaestroIng.IdArticuloStock
			.Add("@IdInsumo", DbType.Int32).Value = MaestroIng.IdInsumo
			.Add("@Cantidad", DbType.Decimal).Value = MaestroIng.Cantidad
			.Add("@Saldo", DbType.Decimal).Value = MaestroIng.Saldo
			.Add("@IdUnidadMedida", DbType.Int32).Value = MaestroIng.IdUnidadMedida
			.Add("@IdOrdenTrabajoUltima", DbType.String).Value = MaestroIng.IdOrdenTrabajoUltima
			.Add("@FechaOrdenTrabajoUltima", DbType.DateTime).Value = MaestroIng.FechaOrdenTrabajoUltima
			.Add("@Observaciones", DbType.String).Value = MaestroIng.Observaciones

		End With
		Return MyBase.Update(MaestroIng)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del documento de MaestrosIng
''' </summary>
''' <remarks></remarks>
Public Class MaestroIngFacade
	Inherits DocumentFacade(Of MaestroIngInfo)
        
#Region "Metodos de DocumentFacade"

    ''' <summary>
    ''' Generar las acciones necesarias para el flujo de trabajo MaestroIngInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub ApplyWorkflow(ByVal session As CI.Kernel.Security.UserSession, ByVal IdMaestroIng As String, ByVal IdStatus As Integer)
        Dim MaestroIngSvc As New MaestroIngService(session)
        ApplyWorkflow(MaestroIngSvc, IdMaestroIng, IdStatus)
    End Sub

    ''' <summary>
    ''' Cancelar las acciones de regreso al flujo de trabajo MaestroIngInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Sub CancelWorkflow(ByVal session As CI.Kernel.Security.UserSession, ByVal IdMaestroIng As String, ByVal IdStatus As Integer)
        Dim MaestroIngSvc As New MaestroIngService(session)
        CancelWorkflow(MaestroIngSvc, IdMaestroIng, IdStatus)
    End Sub


    ''' <summary>
    ''' Crea una nueva instancia de un MaestroIngInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As UserSession) As MaestroIngInfo
		Dim MaestroIngSvc As New MaestroIngService(session)
		Return MaestroIngSvc.Create()
    End Function

    ''' <summary>
    ''' Actualiza la información de un MaestroIng.
    ''' </summary>
    ''' <param name="MaestroIng">Paquete de información del tipo MaestroIngInfo con la información a actualizar</param>
    ''' <returns>Identificador de MaestroIng, si es nuevo, regresa el .</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal MaestroIng As MaestroIngInfo) As MaestroIngInfo
    	Dim MaestroIngSvc As New MaestroIngService(MaestroIng.Session)
		Return Update(MaestroIngSvc, Ctype(MaestroIng,MaestroIngInfo))
    End Function
    

    ''' <summary>
    ''' Elimina un elemento del documento de MaestrosIng
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idMaestroIng">Identificador del MaestroIng que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As UserSession, ByVal idMaestroIng As string)
		Dim MaestroIngSvc As New MaestroIngService(session)
		Delete(MaestroIngSvc, idMaestroIng)
    End Sub
	
    ''' <summary>
    ''' Verifica si existe un MaestroIng con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idMaestroIng">ID de MaestroIng que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As UserSession, ByVal idMaestroIng As string) As Boolean
		Dim MaestroIngSvc As New MaestroIngService(session)
		Return Exists(MaestroIngSvc, idMaestroIng)
    End Function

    
    ''' <summary>
    ''' Obtiene la información de un MaestroIng.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idMaestroIng">Identificador de MaestroIng a consultar</param>
    ''' <returns>Paquete de información de tipo MaestroIngInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As UserSession, ByVal idMaestroIng As string) As MaestroIngInfo
        Return Me.GetDetail(session, idMaestroIng, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un MaestroIng.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idMaestroIng">Identificador de MaestroIng</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del MaestroIng.</param>
    ''' <returns>Paquete de información de tipo MaestroIngInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As UserSession, ByVal idMaestroIng As string, checkStatus As Boolean) As MaestroIngInfo
   		Dim MaestroIngSvc As New MaestroIngService(session)
        Dim MaestroIngInf As New MaestroIngInfo(session)
		GetDetail(MaestroIngSvc, MaestroIngInf, idMaestroIng)
        Return MaestroIngInf        
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As UserSession, ByVal idSite as Integer, ByVal conditions As Search.SearchConditionCollection) As Integer
    	Dim MaestroIngSvc As New MaestroIngService(session)
    	Return GetNumberOfPages(MaestroIngSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca MaestrosIng que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As UserSession, ByVal idSite as Integer, ByVal conditions As Search.SearchConditionCollection, ByVal order As Search.SearchOrderCollection) As System.Data.DataSet
		Dim MaestroIngSvc As New MaestroIngService(session)
        Return Me.GetSearchResult(session, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca MaestrosIng que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As UserSession, ByVal idSite as Integer, ByVal conditions As Search.SearchConditionCollection, ByVal order As Search.SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim MaestroIngSvc As New MaestroIngService(session)
    	Return GetSearchResult(MaestroIngSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de MaestrosIng.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As UserSession) As System.Data.DataSet
    	Dim MaestroIngSvc As New MaestroIngService(session)
    	Return GetSearchStructure(MaestroIngSvc)
    End Function

#End Region

End Class
