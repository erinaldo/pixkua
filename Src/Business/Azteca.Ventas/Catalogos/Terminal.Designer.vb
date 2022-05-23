''' <summary>
''' Paquete de información que representa un Terminal
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class TerminalInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property PC As String

    Public Property IdCaja As Integer

    Public Property IdCuenta As Integer


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionId As Guid)
        MyBase.New(sessionId)
    End Sub
#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Terminales
''' </summary>
''' <remarks></remarks>
Public Class TerminalService
	Inherits CatalogService(Of TerminalInfo)
	
#Region "Constructores"
    Public Sub New(ByVal sessionId As Guid)
        Me.New(sessionid, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionId As Guid, ByVal cnn As IDbConnection)
        Me.New(sessionId, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionId As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "Terminales", sessionId)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idTerminal As Integer, ByRef Terminal As TerminalInfo, checkStatus As Boolean)
		MyBase.GetDetail(idTerminal, Terminal, checkStatus)
        With Terminal
			.Nombre = CStr(ItemInfo("Nombre"))
			.PC = CStr(ItemInfo("PC"))
			.IdCaja = CInt(ItemInfo("IdCaja"))
			.IdCuenta = CInt(ItemInfo("IdCuenta"))

		End With
	End Sub
	
	Public Overrides Function Update(ByVal Terminal As TerminalInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@Nombre", DbType.String).Value = Terminal.Nombre
			.Add("@PC", DbType.String).Value = Terminal.PC
			.Add("@IdCaja", DbType.Int32).Value = Terminal.IdCaja
			.Add("@IdCuenta", DbType.Int32).Value = Terminal.IdCuenta

		End With
		Return MyBase.Update(Terminal)
	End Function
	
	Public Overrides Function Create() As TerminalInfo
        Return New TerminalInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Terminales
''' </summary>
''' <remarks></remarks>
Public Class TerminalFacade
	Inherits CatalogFacade(Of TerminalInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un TerminalInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionId As Guid) As TerminalInfo
        Dim TerminalSvc As New TerminalService(sessionId)
        Return TerminalSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Terminales
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTerminal">Identificador del Terminal que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionId As Guid, ByVal idTerminal As Integer)
        Dim TerminalSvc As New TerminalService(sessionId)
        Delete(TerminalSvc, idTerminal)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Terminal con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTerminal">ID de Terminal que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionId As Guid, ByVal idTerminal As Integer) As Boolean
        Dim TerminalSvc As New TerminalService(sessionId)
        Return Exists(TerminalSvc, idTerminal)
    End Function

    ''' <summary>
    ''' Verifica si existe un Terminal con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionId As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim TerminalSvc As New TerminalService(sessionId)
        Return Exists(TerminalSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Terminal.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTerminal">Identificador de Terminal a consultar</param>
    ''' <returns>Paquete de información de tipo TerminalInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionId As Guid, ByVal idTerminal As Integer) As TerminalInfo
        Return Me.GetDetail(sessionId, idTerminal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Terminal.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idTerminal">Identificador de Terminal</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Terminal.</param>
    ''' <returns>Paquete de información de tipo TerminalInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionId As Guid, ByVal idTerminal As Integer, ByVal checkStatus As Boolean) As TerminalInfo
        Dim TerminalSvc As New TerminalService(sessionId)
        Dim TerminalInf As New TerminalInfo(sessionId)
        GetDetail(TerminalSvc, TerminalInf, idTerminal, checkStatus)
        Return TerminalInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Terminal en base a su codigo de usuario
    ''' y verifica que el Terminal esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información TerminalInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionId As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As TerminalInfo
        Return Me.GetDetail(sessionId, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Terminal en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Terminal</param>
    ''' <returns>Paquete de información TerminalInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionId As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As TerminalInfo
        Dim TerminalInf As New TerminalInfo(sessionId)
        Dim TerminalSvc As New TerminalService(sessionId)
        GetDetail(TerminalSvc, TerminalInf, userCode, idSucursal, checkStatus)
        Return TerminalInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Terminal.
    ''' </summary>
    ''' <param name="Terminal">Paquete de información del tipo TerminalInfo con la información a actualizar</param>
    ''' <returns>Identificador de Terminal, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Terminal As TerminalInfo) As Integer
        Dim TerminalSvc As New TerminalService(Terminal.SessionID)
		Return Update(TerminalSvc, Terminal)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionId As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim TerminalSvc As New TerminalService(sessionId)
        Return GetNumberOfPages(TerminalSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Terminales que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionId As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionId, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Terminales que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionId As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim TerminalSvc As New TerminalService(sessionId)
        Return GetSearchResult(TerminalSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Terminales.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionId As Guid) As System.Data.DataSet
        Dim TerminalSvc As New TerminalService(sessionId)
        Return GetSearchStructure(TerminalSvc)
    End Function

#End Region

End Class
