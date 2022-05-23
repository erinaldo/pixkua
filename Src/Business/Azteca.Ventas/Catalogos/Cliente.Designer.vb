''' <summary>
''' Paquete de información que representa un Cliente
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ClienteInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Friend _SaldoCredito As Decimal
    Friend _PrimerCompra As Date
    Friend _UltimaCompra As Date
    Friend _MetodoPago As String = String.Empty
    <NonSerialized()>
     Private _Contactos As ClientesDS.ContactosDataTable
#End Region

#Region "Propiedades"
    Public Property Nombre As String = String.Empty

    Public Property Calle As String = String.Empty

    Public Property Cruce1 As String = String.Empty

    Public Property Cruce2 As String = String.Empty

    Public Property NumExt As String = String.Empty

    Public Property NumInt As String = String.Empty

    Public Property Colonia As String = String.Empty

    Public Property CP As String = String.Empty

    Public Property IdPoblacion As Integer

    Public Property Latitud As Decimal

    Public Property Longitud As Decimal

    Public Property Telefonos As String = String.Empty

    Public Property Fax As String = String.Empty

    Public Property Correo As String = String.Empty

    Public Property PagWeb As String = String.Empty

    Public Property IdListaPrecio As Integer

    Public Property IdGrupoDescuentos As Integer

    Public Property IdGama As Integer

    Public Property CondicionesPago As CondicionesPago

    Public Property LimiteCredito As Decimal

    Public ReadOnly Property SaldoCredito As Decimal
        Get
            Return _SaldoCredito
        End Get
    End Property

    Public Property DiasCredito As Integer

    Public Property IdCuentaContable As Integer

    Public ReadOnly Property PrimerCompra As Date
        Get
            Return _PrimerCompra
        End Get
    End Property

    Public ReadOnly Property UltimaCompra As Date
        Get
            Return _UltimaCompra
        End Get
    End Property

    Public Property Facturable As Boolean

    Public Property FacturacionAnticipada As Boolean

    Public Property RFC As String = String.Empty

    Public Property RazonSocial As String = String.Empty

    Public Property CalleFiscal As String = String.Empty

    Public Property NumExtFiscal As String = String.Empty

    Public Property NumIntFiscal As String = String.Empty

    Public Property ColoniaFiscal As String = String.Empty

    Public Property CPFiscal As String = String.Empty

    Public Property IdPoblacionFiscal As Integer

    Public Property WebPassword As String = String.Empty

    Public Property IdComprobanteAddenda As Integer

    Public Property IdComprobanteDestino As Integer

    Public Property GLN As String = String.Empty

    Public Property GLNTienda As String = String.Empty

    Public Property NumProveedor As Integer

    Public Property IdMetodoPago As Integer

    Public Property CuentaPago As String = String.Empty

    Public ReadOnly Property MetodoPago As String
        Get
            Return _MetodoPago
        End Get
    End Property


    Public ReadOnly Property Contactos As ClientesDS.ContactosDataTable
        Get
            Return _Contactos
        End Get
    End Property

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        _Contactos = New ClientesDS.ContactosDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Clientes
''' </summary>
''' <remarks></remarks>
Public Class ClienteService
    Inherits CatalogService(Of ClienteInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "Clientes", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCliente As Integer, ByRef Cliente As ClienteInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idCliente, Cliente, checkStatus)
        With Cliente
            .Nombre = CStr(Me.ItemInfo("Nombre"))
            .Calle = CStr(Me.ItemInfo("Calle"))
            .Cruce1 = CStr(Me.ItemInfo("Cruce1"))
            .Cruce2 = CStr(Me.ItemInfo("Cruce2"))
            .NumExt = CStr(Me.ItemInfo("NumExt"))
            .NumInt = CStr(Me.ItemInfo("NumInt"))
            .Colonia = CStr(Me.ItemInfo("Colonia"))
            .CP = CStr(Me.ItemInfo("CP"))
            .IdPoblacion = CInt(Me.ItemInfo("IdPoblacion"))
            .Latitud = CDec(Me.ItemInfo("Latitud"))
            .Longitud = CDec(Me.ItemInfo("Longitud"))
            .Telefonos = CStr(Me.ItemInfo("Telefonos"))
            .Fax = CStr(Me.ItemInfo("Fax"))
            .Correo = CStr(Me.ItemInfo("Correo"))
            .PagWeb = CStr(Me.ItemInfo("PagWeb"))
            .IdListaPrecio = CInt(Me.ItemInfo("IdListaPrecio"))
            .IdGrupoDescuentos = CInt(Me.ItemInfo("IdGrupoDescuentos"))
            .IdGama = CInt(Me.ItemInfo("IdGama"))
            .CondicionesPago = GetCondicionesPago(ItemInfo("CondicionesPago").ToString)
            .LimiteCredito = CDec(Me.ItemInfo("LimiteCredito"))
            ._SaldoCredito = CDec(Me.ItemInfo("SaldoCredito"))
            .DiasCredito = CInt(Me.ItemInfo("DiasCredito"))
            .IdCuentaContable = CInt(Me.ItemInfo("IdCuenta"))
            If ItemInfo("PrimerCompra") IsNot DBNull.Value Then ._PrimerCompra = CDate(Me.ItemInfo("PrimerCompra"))
            If ItemInfo("UltimaCompra") IsNot DBNull.Value Then ._UltimaCompra = CDate(Me.ItemInfo("UltimaCompra"))
            .Facturable = CBool(Me.ItemInfo("Facturable"))
            .FacturacionAnticipada = CBool(ItemInfo("FacturacionAnticipada"))
            .RFC = CStr(Me.ItemInfo("RFC"))
            .RazonSocial = CStr(Me.ItemInfo("RazonSocial"))
            .CalleFiscal = CStr(Me.ItemInfo("CalleFIS"))
            .NumExtFiscal = CStr(Me.ItemInfo("NumExtFIS"))
            .NumIntFiscal = CStr(Me.ItemInfo("NumIntFIS"))
            .ColoniaFiscal = CStr(Me.ItemInfo("ColoniaFIS"))
            .CPFiscal = CStr(Me.ItemInfo("CPFis"))
            .IdPoblacionFiscal = CInt(Me.ItemInfo("IdPoblacionFIS"))
            .WebPassword = CStr(Me.ItemInfo("WebPassword"))
            .IdComprobanteAddenda = CInt(Me.ItemInfo("IdComprobanteAddenda"))
            .IdComprobanteDestino = CInt(ItemInfo("IdComprobanteDestino"))
            .GLN = CStr(Me.ItemInfo("GLN"))
            .GLNTienda = CStr(Me.ItemInfo("GLNTienda"))
            .NumProveedor = CInt(Val(ItemInfo("NumProveedor")))
            .IdMetodoPago = CInt(Me.ItemInfo("IdMetodoPago"))
            .CuentaPago = ItemInfo("CuentaPago").ToString
            ._MetodoPago = ItemInfo("MetodoPago").ToString
        End With
        LoadContactos(Cliente)
    End Sub

    Public Overrides Function Update(ByVal Cliente As ClienteInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Cliente.Nombre
            .Add("@Calle", DbType.String).Value = Cliente.Calle
            .Add("@Cruce1", DbType.String).Value = Cliente.Cruce1
            .Add("@Cruce2", DbType.String).Value = Cliente.Cruce2
            .Add("@NumExt", DbType.String).Value = Cliente.NumExt
            .Add("@NumInt", DbType.String).Value = Cliente.NumInt
            .Add("@Colonia", DbType.String).Value = Cliente.Colonia
            .Add("@CP", DbType.String).Value = Cliente.CP
            .Add("@IdPoblacion", DbType.Int32).Value = Cliente.IdPoblacion
            .Add("@Latitud", DbType.Decimal).Value = Cliente.Latitud
            .Add("@Longitud", DbType.Decimal).Value = Cliente.Longitud
            .Add("@Telefonos", DbType.String).Value = Cliente.Telefonos
            .Add("@Fax", DbType.String).Value = Cliente.Fax
            .Add("@Correo", DbType.String).Value = Cliente.Correo
            .Add("@PagWeb", DbType.String).Value = Cliente.PagWeb
            .Add("@IdListaPrecio", DbType.Int32).Value = Cliente.IdListaPrecio
            .Add("@IdGrupoDescuentos", DbType.Int32).Value = Cliente.IdGrupoDescuentos
            .Add("@IdGama", DbType.Int32).Value = Cliente.IdGama
            .Add("@CondicionesPago", DbType.String).Value = GetCondicionesPago(Cliente.CondicionesPago)
            .Add("@LimiteCredito", DbType.Decimal).Value = Cliente.LimiteCredito
            .Add("@DiasCredito", DbType.Int32).Value = Cliente.DiasCredito
            .Add("@IdCuentaContable", DbType.Int32).Value = Cliente.IdCuentaContable
            .Add("@Facturable", DbType.Boolean).Value = Cliente.Facturable
            .Add("@FacturacionAnticipada", DbType.Boolean).Value = Cliente.FacturacionAnticipada
            .Add("@RFC", DbType.String).Value = Cliente.RFC
            .Add("@RazonSocial", DbType.String).Value = Cliente.RazonSocial
            .Add("@CalleFIS", DbType.String).Value = Cliente.CalleFiscal
            .Add("@NumExtFIS", DbType.String).Value = Cliente.NumExtFiscal
            .Add("@NumIntFIS", DbType.String).Value = Cliente.NumIntFiscal
            .Add("@ColoniaFIS", DbType.String).Value = Cliente.ColoniaFiscal
            .Add("@CPFis", DbType.String).Value = Cliente.CPFiscal
            .Add("@IdPoblacionFIS", DbType.Int32).Value = Cliente.IdPoblacionFiscal
            .Add("@WebPassword", DbType.String).Value = Cliente.WebPassword
            .Add("@IdComprobanteAddenda", DbType.Int32).Value = Cliente.IdComprobanteAddenda
            .Add("@IdComprobanteDestino", DbType.Int32).Value = Cliente.IdComprobanteDestino
            .Add("@GLN", DbType.String).Value = Cliente.GLN
            .Add("@GLNTienda", DbType.String).Value = Cliente.GLNTienda
            .Add("@NumProveedor", DbType.Int32).Value = Cliente.NumProveedor
            .Add("@IdMetodoPago", DbType.Int32).Value = Cliente.IdMetodoPago
            .Add("@CuentaPago", DbType.String).Value = Cliente.CuentaPago
        End With
        Dim IdCliente As Integer = MyBase.Update(Cliente)
        If Cliente.Contactos IsNot Nothing Then SaveContactos(IdCliente, Cliente.Contactos)
        Return IdCliente
    End Function

    Public Overrides Function Create() As ClienteInfo
        Return New ClienteInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"

    Private Sub LoadContactos(ByVal cliente As ClienteInfo)
        Try
            Dim fxContactos As New FunctionSQL("Sales", "fxClienteContactosSEL", Connection, Transaction)
            fxContactos.Parameters.Add("@IdCliente", DbType.Int32).Value = cliente.Identity
            fxContactos.FillDataTable(cliente.Contactos)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los contactos de cliente.", ex)
        End Try
    End Sub

    Private Sub SaveContactos(ByVal idCliente As Integer, ByVal contactos As ClientesDS.ContactosDataTable)
        Try
            Dim comUpdate As New DbCommand("Sales.ClienteContactoUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdCliente", DbType.Int32).Value = idCliente
            comUpdate.Parameters.Add("@IdPersona", DbType.Int32, "IdPersona")
            '
            Dim comDelete As New DbCommand("Sales.ClienteContactoDEL", Connection, Transaction)
            comDelete.CommandType = CommandType.StoredProcedure
            comDelete.Parameters.Add("@IdCliente", DbType.Int32).Value = idCliente
            comDelete.Parameters.Add("@IdPersona", DbType.Int32, "IdPersona")
            '
            Dim da As New DataAdapter
            da.InsertCommand = comUpdate
            da.DeleteCommand = comDelete
            da.Update(contactos)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar los contactos de cliente.", ex)
        End Try
    End Sub

    Private Function GetCondicionesPago(ByVal tipo As String) As CondicionesPago
        Select Case tipo
            Case "E"
                Return CondicionesPago.Contado
            Case "C"
                Return CondicionesPago.Credito
            Case Else
                Return CondicionesPago.Contado
        End Select
    End Function

    Private Function GetCondicionesPago(ByVal tipo As CondicionesPago) As String
        Select Case tipo
            Case CondicionesPago.Contado
                Return "E"
            Case CondicionesPago.Credito
                Return "C"
            Case Else
                Return "E"
        End Select
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Clientes
''' </summary>
''' <remarks></remarks>
Public Class ClienteFacade
    Inherits CatalogFacade(Of ClienteInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ClienteInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ClienteInfo
        Dim ClienteSvc As New ClienteService(sessionID)
        Return ClienteSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Clientes
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCliente">Identificador del Cliente que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idCliente As Integer)
        Dim ClienteSvc As New ClienteService(sessionID)
        Delete(ClienteSvc, idCliente)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Cliente con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCliente">ID de Cliente que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idCliente As Integer) As Boolean
        Dim ClienteSvc As New ClienteService(sessionID)
        Return Exists(ClienteSvc, idCliente)
    End Function

    ''' <summary>
    ''' Verifica si existe un Cliente con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ClienteSvc As New ClienteService(sessionID)
        Return Exists(ClienteSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Cliente.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCliente">Identificador de Cliente a consultar</param>
    ''' <returns>Paquete de información de tipo ClienteInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCliente As Integer) As ClienteInfo
        Return Me.GetDetail(sessionID, idCliente, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Cliente.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCliente">Identificador de Cliente</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Cliente.</param>
    ''' <returns>Paquete de información de tipo ClienteInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCliente As Integer, ByVal checkStatus As Boolean) As ClienteInfo
        Dim ClienteSvc As New ClienteService(sessionID)
        Dim ClienteInf As New ClienteInfo(sessionID)
        GetDetail(ClienteSvc, ClienteInf, idCliente, checkStatus)
        Return ClienteInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Cliente en base a su codigo de usuario
    ''' y verifica que el Cliente esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ClienteInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ClienteInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Cliente en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Cliente</param>
    ''' <returns>Paquete de información ClienteInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ClienteInfo
        Dim ClienteInf As New ClienteInfo(sessionID)
        Dim ClienteSvc As New ClienteService(sessionID)
        GetDetail(ClienteSvc, ClienteInf, userCode, idSucursal, checkStatus)
        Return ClienteInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Cliente.
    ''' </summary>
    ''' <param name="Cliente">Paquete de información del tipo ClienteInfo con la información a actualizar</param>
    ''' <returns>Identificador de Cliente, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Cliente As ClienteInfo) As Integer
        Dim ClienteSvc As New ClienteService(Cliente.SessionID)
        Return Update(ClienteSvc, Cliente)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ClienteSvc As New ClienteService(sessionID)
        Return GetNumberOfPages(ClienteSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Clientes que coincidan con las condiciones especificadas.
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
    ''' Busca Clientes que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ClienteSvc As New ClienteService(sessionID)
        Return GetSearchResult(ClienteSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Clientes.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ClienteSvc As New ClienteService(sessionID)
        Return GetSearchStructure(ClienteSvc)
    End Function

#End Region

End Class
