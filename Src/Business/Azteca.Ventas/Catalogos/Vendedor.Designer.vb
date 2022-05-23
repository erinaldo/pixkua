Imports Azteca.Kernel.General
Imports Azteca.Business.RH

''' <summary>
''' Paquete de informaci�n que representa un Vendedor
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class VendedorInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

    Private _Empleado As EmpleadoInfo

#End Region

#Region "Propiedades"

    Public Property IdEmpleado As Integer
    Public Property IdCuenta As Integer

    Public ReadOnly Property Empleado As EmpleadoInfo
        Get
            Return _Empleado
        End Get
    End Property

#End Region
	
#Region "Constructor"

    Public Sub New(ByVal sessionId As Guid)
        MyBase.New(sessionId)
        _Empleado = New EmpleadoInfo(sessionId)
    End Sub

#End Region
	
End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Vendedores
''' </summary>
''' <remarks></remarks>
Public Class VendedorService
	Inherits CatalogService(Of VendedorInfo)
	
#Region "Constructores"
    Public Sub New(ByVal sessionId As Guid)
        Me.New(sessionId, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionId As Guid, ByVal cnn As IDbConnection)
        Me.New(sessionId, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionId As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "Vendedores", sessionId)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idVendedor As Integer, ByRef Vendedor As VendedorInfo, checkStatus As Boolean)
		MyBase.GetDetail(idVendedor, Vendedor, checkStatus)
        With Vendedor
            .IdEmpleado = CInt(ItemInfo("IdEmpleado"))
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
        End With
        'Cargar informaci�n del empleado
        Dim EmpleadoSvc As New EmpleadoService(SessionID, Connection, Transaction)
        EmpleadoSvc.GetDetail(Vendedor.IdEmpleado, Vendedor.Empleado, False)
	End Sub
	
	Public Overrides Function Update(ByVal Vendedor As VendedorInfo) As Integer
        With Me.SPUpdate.Parameters
			.Add("@IdEmpleado", DbType.Int32).Value = Vendedor.IdEmpleado
            .Add("@IdCuenta", DbType.Int32).Value = Vendedor.IdCuenta
		End With
		Return MyBase.Update(Vendedor)
	End Function
	
	Public Overrides Function Create() As VendedorInfo
        Return New VendedorInfo(SessionID)
	End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Vendedores
''' </summary>
''' <remarks></remarks>
Public Class VendedorFacade
	Inherits CatalogFacade(Of VendedorInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un VendedorInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionId As Guid) As VendedorInfo
        Dim VendedorSvc As New VendedorService(sessionId)
        Return VendedorSvc.Create()
    End Function
    
    ''' <summary>
    ''' Elimina un elemento del cat�logo de Vendedores
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idVendedor">Identificador del Vendedor que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionId As Guid, ByVal idVendedor As Integer)
        Dim VendedorSvc As New VendedorService(sessionId)
        Delete(VendedorSvc, idVendedor)
    End Sub
	
    ''' <summary>
    ''' Verifica si existe un Vendedor con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idVendedor">ID de Vendedor que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionId As Guid, ByVal idVendedor As Integer) As Boolean
        Dim VendedorSvc As New VendedorService(sessionId)
        Return Exists(VendedorSvc, idVendedor)
    End Function

    ''' <summary>
    ''' Verifica si existe un Vendedor con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionId As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim VendedorSvc As New VendedorService(sessionId)
        Return Exists(VendedorSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Vendedor.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idVendedor">Identificador de Vendedor a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo VendedorInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionId As Guid, ByVal idVendedor As Integer) As VendedorInfo
        Return Me.GetDetail(sessionId, idVendedor, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Vendedor.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idVendedor">Identificador de Vendedor</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Vendedor.</param>
    ''' <returns>Paquete de informaci�n de tipo VendedorInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionId As Guid, ByVal idVendedor As Integer, ByVal checkStatus As Boolean) As VendedorInfo
        Dim VendedorSvc As New VendedorService(sessionId)
        Dim VendedorInf As New VendedorInfo(sessionId)
        GetDetail(VendedorSvc, VendedorInf, idVendedor, checkStatus)
        Return VendedorInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Vendedor en base a su codigo de usuario
    ''' y verifica que el Vendedor est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n VendedorInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionId As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As VendedorInfo
        Return Me.GetDetail(sessionId, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Vendedor en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Vendedor</param>
    ''' <returns>Paquete de informaci�n VendedorInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionId As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As VendedorInfo
        Dim VendedorInf As New VendedorInfo(sessionId)
        Dim VendedorSvc As New VendedorService(sessionId)
        GetDetail(VendedorSvc, VendedorInf, userCode, idSucursal, checkStatus)
        Return VendedorInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Vendedor.
    ''' </summary>
    ''' <param name="Vendedor">Paquete de informaci�n del tipo VendedorInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Vendedor, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Vendedor As VendedorInfo) As Integer
        Dim VendedorSvc As New VendedorService(Vendedor.SessionID)
		Return Update(VendedorSvc, Vendedor)
    End Function
	
    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionId As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim VendedorSvc As New VendedorService(sessionId)
        Return GetNumberOfPages(VendedorSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Vendedores que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionId As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionId, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Vendedores que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionId As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim VendedorSvc As New VendedorService(sessionId)
        Return GetSearchResult(VendedorSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Vendedores.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionId As Guid) As System.Data.DataSet
        Dim VendedorSvc As New VendedorService(sessionId)
        Return GetSearchStructure(VendedorSvc)
    End Function

#End Region

End Class
