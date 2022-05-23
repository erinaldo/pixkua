''' <summary>
''' Paquete de información que representa un UnidadNegocio
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class UnidadNegocioInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Friend _UltimaFactura As Integer
    Private _Sucursal As SucursalInfo
#End Region

#Region "Propiedades"

    Public ReadOnly Property Sucursal As SucursalInfo
        Get
            Return _Sucursal
        End Get
    End Property

    Public Property Nombre As String
    Public Property AfectarInventario As Boolean
    Public Property AfectarInventarioLinea As Boolean
    Public Property IdAlmacen As Integer
    Public Property IdRegion As Integer
    Public Property IdZonaVenta As Integer
    Public Property FacturacionElectronica As Boolean
    Public Property SerieFacturas As String
    Public Property IdSerieFacturas As Integer
    Public ReadOnly Property UltimaFactura As Integer
        Get
            Return _UltimaFactura
        End Get
    End Property
    Public Property IdFormatoFacturas As Integer
    Public Property IdFormatoDevoluciones As Integer
    Public Property IdFormatoTicketComanda As Integer
    Public Property IdFormatoTicketPedimento As Integer
    Public Property IdFormatoTicketPOS As Integer
    Public Property IdFormatoTicketCortePOS As Integer
    Public Property IdFormatoTicketUbicacionPOS As Integer
    Public Property IdSerieDevoluciones As Integer
    Public Property TipoPrecio As TipoPrecio
    Public Property PoliticaDescuento As PoliticaDescuento
    Public Property IdDivisaBase As Integer
    Public Property IdClienteGenerico As Integer
    Public Property IdClienteFacturacion As Integer
    Public Property GLN As String
    Public Property IdRemitente As Integer
    Public Property IdOperador As Integer
    Public Property EnviarFacturas As Boolean
    Public Property NotificarFacturas As Boolean
    Public Property NotificarFoliosTerminar As Boolean
    Public Property PorcentajeFolios As Decimal

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        _Sucursal = New SucursalInfo(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de UnidadesNegocio
''' </summary>
''' <remarks></remarks>
Public Class UnidadNegocioService
    Inherits CatalogService(Of UnidadNegocioInfo)

    Public Property InizializacionSistema As Boolean = False

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "UnidadesNegocio", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"

    Public Overrides Sub GetDetail(ByVal idUnidadNegocio As Integer, ByRef UnidadNegocio As UnidadNegocioInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idUnidadNegocio, UnidadNegocio, checkStatus)
        With UnidadNegocio
            .Nombre = CStr(Me.ItemInfo("Nombre"))
            .AfectarInventario = CBool(ItemInfo("AfectarInventario"))
            .AfectarInventarioLinea = CBool(ItemInfo("AfectarInvLinea"))
            .IdAlmacen = CInt(Me.ItemInfo("IdAlmacen"))
            .IdRegion = CInt(Me.ItemInfo("IdRegion"))
            .IdZonaVenta = CInt(Me.ItemInfo("IdZonaVenta"))
            .FacturacionElectronica = CBool(Me.ItemInfo("FactElectronica"))
            .SerieFacturas = CStr(Me.ItemInfo("SerieFacturas"))
            ._UltimaFactura = CInt(Me.ItemInfo("UltimaFactura"))
            .IdSerieFacturas = CInt(ItemInfo("IdCFDSerie"))
            .IdFormatoFacturas = CInt(ItemInfo("IdFormatoFactura"))
            .IdSerieDevoluciones = CInt(ItemInfo("IdSerieDevoluciones"))
            .IdFormatoDevoluciones = CInt(ItemInfo("IdFormatoDevoluciones"))
            .IdFormatoTicketComanda = CInt(ItemInfo("IdFormatoTicketComanda"))
            .IdFormatoTicketPedimento = CInt(ItemInfo("IdFormatoTicketPedimento"))
            .IdFormatoTicketPOS = CInt(ItemInfo("IdFormatoTicketPOS"))
            .IdFormatoTicketCortePOS = CInt(ItemInfo("IdFormatoTicketCortePOS"))
            .IdFormatoTicketUbicacionPOS = CInt(ItemInfo("IdFormatoTicketUbicacionPOS"))
            .TipoPrecio = GetTipoPrecio(CStr(ItemInfo("TipoPrecio")))
            'vick
            '.PoliticaDescuento = GetPoliticaDescuento(ItemInfo("PoliticaDescuento").ToString)
            .PoliticaDescuento = PoliticaDescuento.AntesImpuestos
            .IdDivisaBase = CInt(ItemInfo("IdDivisaBase"))
            .IdClienteGenerico = CInt(Me.ItemInfo("IdClienteGenerico"))
            .IdClienteFacturacion = CInt(ItemInfo("IdClienteFacturacion"))
            .GLN = CStr(Me.ItemInfo("GLN"))
            .IdRemitente = CInt(ItemInfo("IdRemitente"))
            .IdOperador = CInt(ItemInfo("IdOperador"))
            .EnviarFacturas = CBool(ItemInfo("EnviarFacturas"))
            .NotificarFacturas = CBool(ItemInfo("NotificarFacturas"))
            .NotificarFoliosTerminar = CBool(ItemInfo("NotificarFoliosTerminar"))
            .PorcentajeFolios = CDec(ItemInfo("PorcentajeFolios"))
            'Cargar información de la sucursal
            Dim SucursalSvc As New SucursalService(sessionID, Connection, Transaction)
            SucursalSvc.GetDetail(.IdSucursal, .Sucursal, False)
        End With

    End Sub

    Public Overrides Function Update(ByVal UnidadNegocio As UnidadNegocioInfo) As Integer
        'Guardar información de la sucursal
        Dim SucursalSvc As New SucursalService(sessionID, Connection, Transaction)
        UnidadNegocio.IdSucursal = SucursalSvc.Update(UnidadNegocio.Sucursal)

        'Si es una unidad de negocio nueva o se esta corriendo la configuracion inicial del sistema paraa l Fact Electronica
        If UnidadNegocio.Identity = 0 Or InizializacionSistema Then
            If UnidadNegocio.Identity = 0 Then
                'Agregamos al admin con permisos de acceso a la sucursal
                Dim UsuarioSVC As New UsuarioService(Me.SessionID, Me.Connection, Me.Transaction)
                Dim dsAccess As New Azteca.Kernel.Security.SiteAccess
                dsAccess.Sucursales.AddSucursalesRow(UnidadNegocio.IdSucursal, UnidadNegocio.IdEmpresa, "", True)
                dsAccess.AcceptChanges()
                dsAccess.Sucursales.Rows(0).SetModified()
                UsuarioSVC.SaveSiteAccess(1, dsAccess)
            End If

            'le agregmos un Area generico
            Dim Area As New Azteca.Business.Inventario.AreaInfo(Me.SessionID)
            Area.IdSucursal = UnidadNegocio.IdSucursal : Area.IdEmpresa = UnidadNegocio.IdEmpresa
            Area.Nombre = "Area General" : Area.Status = CatalogState.Active
            Dim AreaSvc As New Azteca.Business.Inventario.AreaService(Me.SessionID, Me.Connection, Me.Transaction)
            Dim IdArea As Integer = AreaSvc.Update(Area)
            'Agregar admin a los accesos del área
            Dim AreaAccesos As Azteca.Business.Inventario.UsuarioAccesosDS.AreasDataTable = AreaSvc.CargarUsuarioAccesos(1)
            For Each drAreaAcceso As Azteca.Business.Inventario.UsuarioAccesosDS.AreasRow In AreaAccesos
                drAreaAcceso.Selected = True
            Next
            AreaSvc.GuardarUsuarioAccesos(1, AreaAccesos)
            'Le agregamos un almacen
            Dim Almacen As New Azteca.Business.Inventario.AlmacenInfo(Me.SessionID)
            Almacen.IdArea = IdArea : Almacen.Nombre = "Almacen General de " & UnidadNegocio.Nombre : Almacen.PermiteNegativos = False
            Almacen.IdSucursal = UnidadNegocio.IdSucursal : Almacen.IdEmpresa = UnidadNegocio.IdEmpresa : Almacen.Status = CatalogState.Active
            Dim AlmacenSvc As New Azteca.Business.Inventario.AlmacenService(Me.SessionID, Me.Connection, Me.Transaction)
            UnidadNegocio.IdAlmacen = AlmacenSvc.Update(Almacen)

            Dim Svc As New Azteca.Business.Inventario.AlmacenService(SessionID, Connection, Transaction)
            Dim usuarios As New Azteca.Kernel.Security.ObjectAccessDS.UsuariosDataTable
            usuarios.Columns.Add("Entrada", System.Type.GetType("System.Boolean"))
            usuarios.Columns.Add("Salida", System.Type.GetType("System.Boolean"))
            usuarios.AddUsuariosRow(1, "admin", "", "", "")
            usuarios(0)("Entrada") = 1 : usuarios(0)("Salida") = 1
            Svc.SaveAccesos(UnidadNegocio.IdAlmacen, usuarios)

            'Agregamos una caja
            Dim CajaSvc As New CajaService(Me.SessionID, Me.Connection, Me.Transaction)
            Dim Caja As New CajaInfo(Me.SessionID)
            Caja.IdEmpresa = UnidadNegocio.IdEmpresa : Caja.IdSucursal = UnidadNegocio.IdSucursal : Caja.Nombre = "General en " & UnidadNegocio.Nombre
            Caja.Status = CatalogState.Active
            Dim IdCaja As Integer = CajaSvc.Update(Caja)
            CajaSvc.Abrir(IdCaja, 1, 1)
        End If

        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = UnidadNegocio.Nombre
            .Add("@AfectarInventario", DbType.Boolean).Value = UnidadNegocio.AfectarInventario
            .Add("@AfectarInvLinea", DbType.Boolean).Value = UnidadNegocio.AfectarInventarioLinea
            .Add("@IdAlmacen", DbType.Int32).Value = UnidadNegocio.IdAlmacen
            .Add("@IdRegion", DbType.Int32).Value = UnidadNegocio.IdRegion
            .Add("@IdZonaVenta", DbType.Int32).Value = UnidadNegocio.IdZonaVenta
            .Add("@FactElectronica", DbType.Boolean).Value = UnidadNegocio.FacturacionElectronica
            .Add("@SerieFacturas", DbType.String).Value = UnidadNegocio.SerieFacturas
            .Add("@IdCFDSerie", DbType.Int32).Value = UnidadNegocio.IdSerieFacturas
            .Add("@IdFormatoFactura", DbType.Int32).Value = UnidadNegocio.IdFormatoFacturas
            .Add("@IdSerieDevoluciones", DbType.Int32).Value = UnidadNegocio.IdSerieDevoluciones
            .Add("@IdFormatoDevoluciones", DbType.Int32).Value = UnidadNegocio.IdFormatoDevoluciones
            .Add("@IdFormatoTicketComanda", DbType.Int32).Value = UnidadNegocio.IdFormatoTicketComanda
            .Add("@IdFormatoTicketPedimento", DbType.Int32).Value = UnidadNegocio.IdFormatoTicketPedimento
            .Add("@IdFormatoTicketPOS", DbType.Int32).Value = UnidadNegocio.IdFormatoTicketPOS
            .Add("@IdFormatoTicketCortePOS", DbType.Int32).Value = UnidadNegocio.IdFormatoTicketCortePOS
            .Add("@IdFormatoTicketUbicacionPOS ", DbType.Int32).Value = UnidadNegocio.IdFormatoTicketUbicacionPOS
            .Add("@TipoPrecio", DbType.String).Value = GetTipoPrecio(UnidadNegocio.TipoPrecio)
            .Add("@PoliticaDescuento", DbType.String).Value = GetPoliticaDescuento(UnidadNegocio.PoliticaDescuento)
            .Add("@IdDivisaBase", DbType.Int32).Value = UnidadNegocio.IdDivisaBase
            .Add("@IdClienteGenerico", DbType.Int32).Value = UnidadNegocio.IdClienteGenerico
            .Add("@IdClienteFacturacion", DbType.Int32).Value = UnidadNegocio.IdClienteFacturacion
            .Add("@GLN", DbType.String).Value = UnidadNegocio.GLN
            .Add("@IdRemitente", DbType.Int32).Value = UnidadNegocio.IdRemitente
            .Add("@IdOperador", DbType.Int32).Value = UnidadNegocio.IdOperador
            .Add("@EnviarFacturas", DbType.Boolean).Value = UnidadNegocio.EnviarFacturas
            .Add("@NotificarFacturas", DbType.Boolean).Value = UnidadNegocio.NotificarFacturas
            .Add("@NotificarFoliosTerminar", DbType.Boolean).Value = UnidadNegocio.NotificarFoliosTerminar
            .Add("@PorcentajeFolios", DbType.Decimal).Value = UnidadNegocio.PorcentajeFolios
        End With
        Dim IdUnidadNegocio As Integer = MyBase.Update(UnidadNegocio)
        Dim CacheKey As String = "UnidadNegocioSucursal" & UnidadNegocio.IdSucursal
        If Azteca.Kernel.Cache.Item(CacheKey) IsNot Nothing Then Azteca.Kernel.Cache.Remove(CacheKey)
        Return IdUnidadNegocio
    End Function

    Public Overrides Function Create() As UnidadNegocioInfo
        Return New UnidadNegocioInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"

    Private Function GetTipoPrecio(ByVal tipo As TipoPrecio) As String
        Select Case tipo
            Case TipoPrecio.ListaPrecio
                Return "L"
            Case TipoPrecio.ZonasVenta
                Return "Z"
            Case Else
                Return String.Empty
        End Select
    End Function

    Private Function GetTipoPrecio(ByVal tipo As String) As TipoPrecio
        Select Case tipo
            Case "L"
                Return TipoPrecio.ListaPrecio
            Case "Z"
                Return TipoPrecio.ZonasVenta
            Case Else
                Return TipoPrecio.ZonasVenta
        End Select
    End Function

    Private Function GetPoliticaDescuento(politica As PoliticaDescuento) As String
        Select Case politica
            Case PoliticaDescuento.AntesImpuestos
                Return "A"
            Case PoliticaDescuento.DespuesImpuestos
                Return "D"
            Case Else
                Return String.Empty
        End Select
    End Function

    Private Function GetPoliticaDescuento(politica As String) As PoliticaDescuento
        Select Case politica
            Case "A"
                Return PoliticaDescuento.AntesImpuestos
            Case "D"
                Return PoliticaDescuento.DespuesImpuestos
            Case Else
                Return PoliticaDescuento.DespuesImpuestos
        End Select
    End Function
#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de UnidadesNegocio
''' </summary>
''' <remarks></remarks>
Public Class UnidadNegocioFacade
    Inherits CatalogFacade(Of UnidadNegocioInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un UnidadNegocioInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As UnidadNegocioInfo
        Dim UnidadNegocioSvc As New UnidadNegocioService(sessionID)
        Return UnidadNegocioSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de UnidadesNegocio
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idUnidadNegocio">Identificador del UnidadNegocio que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idUnidadNegocio As Integer)
        Dim UnidadNegocioSvc As New UnidadNegocioService(sessionID)
        Delete(UnidadNegocioSvc, idUnidadNegocio)
    End Sub

    ''' <summary>
    ''' Verifica si existe un UnidadNegocio con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idUnidadNegocio">ID de UnidadNegocio que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idUnidadNegocio As Integer) As Boolean
        Dim UnidadNegocioSvc As New UnidadNegocioService(sessionID)
        Return Exists(UnidadNegocioSvc, idUnidadNegocio)
    End Function

    ''' <summary>
    ''' Verifica si existe un UnidadNegocio con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim UnidadNegocioSvc As New UnidadNegocioService(sessionID)
        Return Exists(UnidadNegocioSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un UnidadNegocio.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idUnidadNegocio">Identificador de UnidadNegocio a consultar</param>
    ''' <returns>Paquete de información de tipo UnidadNegocioInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idUnidadNegocio As Integer) As UnidadNegocioInfo
        Return Me.GetDetail(sessionID, idUnidadNegocio, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un UnidadNegocio.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idUnidadNegocio">Identificador de UnidadNegocio</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del UnidadNegocio.</param>
    ''' <returns>Paquete de información de tipo UnidadNegocioInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idUnidadNegocio As Integer, ByVal checkStatus As Boolean) As UnidadNegocioInfo
        Dim UnidadNegocioSvc As New UnidadNegocioService(sessionID)
        Dim UnidadNegocioInf As New UnidadNegocioInfo(sessionID)
        GetDetail(UnidadNegocioSvc, UnidadNegocioInf, idUnidadNegocio, checkStatus)
        Return UnidadNegocioInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un UnidadNegocio en base a su codigo de usuario
    ''' y verifica que el UnidadNegocio esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información UnidadNegocioInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As UnidadNegocioInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un UnidadNegocio en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del UnidadNegocio</param>
    ''' <returns>Paquete de información UnidadNegocioInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As UnidadNegocioInfo
        Dim UnidadNegocioInf As New UnidadNegocioInfo(sessionID)
        Dim UnidadNegocioSvc As New UnidadNegocioService(sessionID)
        GetDetail(UnidadNegocioSvc, UnidadNegocioInf, userCode, idSucursal, checkStatus)
        Return UnidadNegocioInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un UnidadNegocio.
    ''' </summary>
    ''' <param name="UnidadNegocio">Paquete de información del tipo UnidadNegocioInfo con la información a actualizar</param>
    ''' <returns>Identificador de UnidadNegocio, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal UnidadNegocio As UnidadNegocioInfo) As Integer
        Dim UnidadNegocioSvc As New UnidadNegocioService(UnidadNegocio.SessionID)
        Return Update(UnidadNegocioSvc, UnidadNegocio)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim UnidadNegocioSvc As New UnidadNegocioService(sessionID)
        Return GetNumberOfPages(UnidadNegocioSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca UnidadesNegocio que coincidan con las condiciones especificadas.
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
    ''' Busca UnidadesNegocio que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim UnidadNegocioSvc As New UnidadNegocioService(sessionID)
        Return GetSearchResult(UnidadNegocioSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de UnidadesNegocio.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim UnidadNegocioSvc As New UnidadNegocioService(sessionID)
        Return GetSearchStructure(UnidadNegocioSvc)
    End Function

#End Region

End Class


#Region "Enumerados"

Public Enum TipoPrecio As Integer
    ListaPrecio
    ZonasVenta
End Enum


Public Enum PoliticaDescuento As Integer
    AntesImpuestos
    DespuesImpuestos
End Enum

#End Region