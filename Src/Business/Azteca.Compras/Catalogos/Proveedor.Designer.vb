''' <summary>
''' Paquete de información que representa un Proveedor
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ProveedorInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Friend _Saldo As Decimal
    Private _Contactos As ProveedoresDS.ContactosDataTable
#End Region

#Region "Propiedades"
    Public Property Nombre As String = String.Empty

    Public Property Calle As String = String.Empty

    Public Property NumExt As String = String.Empty

    Public Property NumInt As String = String.Empty

    Public Property Colonia As String = String.Empty

    Public Property CP As String = String.Empty

    Public Property IdPoblacion As Integer

    Public Property FacturaElectronica As Boolean

    Public Property RFC As String = String.Empty

    Public Property RazonSocial As String = String.Empty

    Public Property CalleFiscal As String = String.Empty

    Public Property NumExtFiscal As String = String.Empty

    Public Property NumIntFiscal As String = String.Empty

    Public Property ColoniaFiscal As String = String.Empty

    Public Property CPFiscal As String = String.Empty

    Public Property IdPoblacionFiscal As Integer

    Public Property Telefono As String = String.Empty

    Public Property Fax As String = String.Empty

    Public Property Correo As String = String.Empty

    Public Property PaginaWeb As String = String.Empty

    Public ReadOnly Property Saldo As Decimal
        Get
            Return _Saldo
        End Get
    End Property

    Public Property LimiteCredito As Decimal

    Public Property DiasCredito As Integer

    Public Property DiasEntrega As Integer

    Public Property PagoAnticipado As Boolean

    Public Property PorcentajeAnticipo As Decimal

    Public Property IdBanco As Integer

    Public Property CLABE As String = String.Empty

    Public Property LeyendaCheque As Boolean

    Public Property IdCuentaContable As Integer

    Public Property WebPassword As String = String.Empty


    Public ReadOnly Property Contactos As ProveedoresDS.ContactosDataTable
        Get
            Return _Contactos
        End Get
    End Property

#End Region
	
#Region "Constructor"

    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        _Contactos = New ProveedoresDS.ContactosDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Proveedores
''' </summary>
''' <remarks></remarks>
Public Class ProveedorService
    Inherits CatalogService(Of ProveedorInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Purchasing", "Proveedores", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idProveedor As Integer, ByRef Proveedor As ProveedorInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idProveedor, Proveedor, checkStatus)
        LoadInfo(Proveedor)
    End Sub

    Private Sub LoadInfo(ByVal proveedor As ProveedorInfo)
        With proveedor
            .Nombre = CStr(ItemInfo("Nombre"))
            .Calle = CStr(ItemInfo("Calle"))
            .NumExt = CStr(ItemInfo("NumExt"))
            .NumInt = CStr(ItemInfo("NumInt"))
            .Colonia = CStr(ItemInfo("Colonia"))
            .CP = CStr(ItemInfo("CP"))
            .IdPoblacion = CInt(ItemInfo("IdPoblacion"))
            .FacturaElectronica = CBool(ItemInfo("FacturaElectronica"))
            .RFC = CStr(ItemInfo("RFC"))
            .RazonSocial = CStr(ItemInfo("RazonSocial"))
            .CalleFiscal = CStr(ItemInfo("CalleFIS"))
            .NumExtFiscal = CStr(ItemInfo("NumExtFIS"))
            .NumIntFiscal = CStr(ItemInfo("NumIntFIS"))
            .ColoniaFiscal = CStr(ItemInfo("ColoniaFIS"))
            .CPFiscal = CStr(ItemInfo("CPFis"))
            .IdPoblacionFiscal = CInt(ItemInfo("IdPoblacionFIS"))
            .Telefono = CStr(ItemInfo("Telefono"))
            .Fax = CStr(ItemInfo("Fax"))
            .Correo = CStr(ItemInfo("Correo"))
            .PaginaWeb = CStr(ItemInfo("PagWeb"))
            ._Saldo = CDec(ItemInfo("Saldo"))
            .LimiteCredito = CDec(ItemInfo("LimiteCredito"))
            .DiasCredito = CInt(ItemInfo("DiasCredito"))
            .DiasEntrega = CInt(ItemInfo("DiasEntrega"))
            .PagoAnticipado = CBool(ItemInfo("PagoAnticipado"))
            .PorcentajeAnticipo = CDec(ItemInfo("PorcAnticipo"))
            .IdBanco = CInt(ItemInfo("IdBanco"))
            .CLABE = ItemInfo("CLABE").ToString
            .LeyendaCheque = CBool(ItemInfo("LeyendaCheque"))
            .IdCuentaContable = CInt(ItemInfo("IdCuenta"))
            .WebPassword = CStr(ItemInfo("WebPassword"))

            Call CargarContactos(proveedor)

        End With
    End Sub

    Public Overrides Function Update(ByVal Proveedor As ProveedorInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Proveedor.Nombre
            .Add("@Calle", DbType.String).Value = Proveedor.Calle
            .Add("@NumExt", DbType.String).Value = Proveedor.NumExt
            .Add("@NumInt", DbType.String).Value = Proveedor.NumInt
            .Add("@Colonia", DbType.String).Value = Proveedor.Colonia
            .Add("@CP", DbType.String).Value = Proveedor.CP
            .Add("@IdPoblacion", DbType.Int32).Value = Proveedor.IdPoblacion
            .Add("@FacturaElectronica", DbType.Boolean).Value = Proveedor.FacturaElectronica
            .Add("@RFC", DbType.String).Value = Proveedor.RFC
            .Add("@RazonSocial", DbType.String).Value = Proveedor.RazonSocial
            .Add("@CalleFIS", DbType.String).Value = Proveedor.CalleFiscal
            .Add("@NumExtFIS", DbType.String).Value = Proveedor.NumExtFiscal
            .Add("@NumIntFIS", DbType.String).Value = Proveedor.NumIntFiscal
            .Add("@ColoniaFIS", DbType.String).Value = Proveedor.ColoniaFiscal
            .Add("@CPFis", DbType.String).Value = Proveedor.CPFiscal
            .Add("@IdPoblacionFIS", DbType.Int32).Value = Proveedor.IdPoblacionFiscal
            .Add("@Telefono", DbType.String).Value = Proveedor.Telefono
            .Add("@Fax", DbType.String).Value = Proveedor.Fax
            .Add("@Correo", DbType.String).Value = Proveedor.Correo
            .Add("@PagWeb", DbType.String).Value = Proveedor.PaginaWeb
            .Add("@Saldo", DbType.Decimal).Value = Proveedor.Saldo
            .Add("@LimiteCredito", DbType.Decimal).Value = Proveedor.LimiteCredito
            .Add("@DiasCredito", DbType.Int32).Value = Proveedor.DiasCredito
            .Add("@DiasEntrega", DbType.Int32).Value = Proveedor.DiasEntrega
            .Add("@PagoAnticipado", DbType.Boolean).Value = Proveedor.PagoAnticipado
            .Add("@PorcAnticipo", DbType.Decimal).Value = Proveedor.PorcentajeAnticipo
            .Add("@IdBanco", DbType.Int32).Value = Proveedor.IdBanco
            .Add("@CLABE", DbType.String).Value = Proveedor.CLABE
            .Add("@LeyendaCheque", DbType.Boolean).Value = Proveedor.LeyendaCheque
            .Add("@IdCuenta", DbType.Int32).Value = Proveedor.IdCuentaContable
            .Add("@WebPassword", DbType.String).Value = Proveedor.WebPassword
        End With
        Dim IdProveedor As Integer = MyBase.Update(Proveedor)
        Azteca.Kernel.Cache.Remove("Proveedor_" & IdProveedor.ToString)

        'Guardamos el contacto
        Call GuardarContactos(IdProveedor, Proveedor.Contactos)

        Return IdProveedor
    End Function

    Public Overrides Function Create() As ProveedorInfo
        Return New ProveedorInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"

    Private Sub CargarContactos(ByVal proveedor As ProveedorInfo)
        Try
            Dim fxLoad As New FunctionSQL("Purchasing", "fxProveedorContactosSEL", Connection, Transaction)
            fxLoad.Parameters.Add("@IdProveedor", DbType.Int32).Value = proveedor.Identity
            fxLoad.FillDataTable(proveedor.Contactos)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar los contactos del proveedor.", ex)
        End Try
    End Sub

    Private Sub GuardarContactos(ByVal idProveedor As Integer, ByVal contactos As ProveedoresDS.ContactosDataTable)
        Try
            Dim comUpdate As New DbCommand("Purchasing.ProveedorContactosUPD", Connection, Transaction)
            comUpdate.CommandType = CommandType.StoredProcedure
            comUpdate.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            comUpdate.Parameters.Add("@IdPersona", DbType.Int32, "IdPersona")
            '
            Dim comDelete As New DbCommand("Purchasing.ProveedorContactosDEL", Connection, Transaction)
            comDelete.CommandType = CommandType.StoredProcedure
            comDelete.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            comDelete.Parameters.Add("@IdPersona", DbType.Int32, "IdPersona")
            '
            Dim da As New DataAdapter
            da.InsertCommand = comUpdate
            da.DeleteCommand = comDelete
            da.Update(contactos)
        Catch concurrencyEx As DBConcurrencyException

        Catch ex As Exception
            Throw New BusinessException("Error al guardar los contactos del proveedor.", ex)
        End Try
    End Sub

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Proveedores
''' </summary>
''' <remarks></remarks>
Public Class ProveedorFacade
    Inherits CatalogFacade(Of ProveedorInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ProveedorInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As ProveedorInfo
        Dim ProveedorSvc As New ProveedorService(sessionID)
        Return ProveedorSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Proveedores
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idProveedor">Identificador del Proveedor que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idProveedor As Integer)
        Dim ProveedorSvc As New ProveedorService(sessionID)
        Delete(ProveedorSvc, idProveedor)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Proveedor con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idProveedor">ID de Proveedor que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idProveedor As Integer) As Boolean
        Dim ProveedorSvc As New ProveedorService(sessionID)
        Return Exists(ProveedorSvc, idProveedor)
    End Function

    ''' <summary>
    ''' Verifica si existe un Proveedor con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ProveedorSvc As New ProveedorService(sessionID)
        Return Exists(ProveedorSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Proveedor.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idProveedor">Identificador de Proveedor a consultar</param>
    ''' <returns>Paquete de información de tipo ProveedorInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idProveedor As Integer) As ProveedorInfo
        Return Me.GetDetail(sessionID, idProveedor, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Proveedor.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idProveedor">Identificador de Proveedor</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Proveedor.</param>
    ''' <returns>Paquete de información de tipo ProveedorInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idProveedor As Integer, ByVal checkStatus As Boolean) As ProveedorInfo
        Dim ProveedorSvc As New ProveedorService(sessionID)
        Dim ProveedorInf As New ProveedorInfo(sessionID)
        GetDetail(ProveedorSvc, ProveedorInf, idProveedor, checkStatus)
        Return ProveedorInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Proveedor en base a su codigo de usuario
    ''' y verifica que el Proveedor esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ProveedorInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As ProveedorInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Proveedor en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Proveedor</param>
    ''' <returns>Paquete de información ProveedorInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ProveedorInfo
        Dim ProveedorInf As New ProveedorInfo(sessionID)
        Dim ProveedorSvc As New ProveedorService(sessionID)
        GetDetail(ProveedorSvc, ProveedorInf, userCode, idSucursal, checkStatus)
        Return ProveedorInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Proveedor.
    ''' </summary>
    ''' <param name="Proveedor">Paquete de información del tipo ProveedorInfo con la información a actualizar</param>
    ''' <returns>Identificador de Proveedor, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Proveedor As ProveedorInfo) As Integer
        Dim ProveedorSvc As New ProveedorService(Proveedor.SessionID)
        Return Update(ProveedorSvc, Proveedor)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ProveedorSvc As New ProveedorService(sessionID)
        Return GetNumberOfPages(ProveedorSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Proveedores que coincidan con las condiciones especificadas.
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
    ''' Busca Proveedores que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ProveedorSvc As New ProveedorService(sessionID)
        Return GetSearchResult(ProveedorSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Proveedores.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim ProveedorSvc As New ProveedorService(sessionID)
        Return GetSearchStructure(ProveedorSvc)
    End Function

#End Region

End Class
