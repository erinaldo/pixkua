''' <summary>
''' Paquete de información que representa un Cripta
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CriptaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property NumeroCripta As String

    Public Property NombrePlaca As String

    Public Property Calle As String

    Public Property NumExt As String

    Public Property NumInt As String

    Public Property Colonia As String

    Public Property CP As String

    Public Property IdPoblacion As Integer

    Public Property TelCasa As String

    Public Property Celular As String

    Public Property Correo As String

    Public Property Observaciones As String

    Public Property Pagado As Boolean

    Public Property FN As Boolean

    Public Property CenizasDe1 As String

    Public Property FechaDeposito1 As Date

    Public Property CenizasDe2 As String

    Public Property FechaDeposito2 As Date

    Public Property CenizasDe3 As String

    Public Property FechaDeposito3 As Date

    Public Property Titular As String

    Public Property Beneficiario As String

    Public Property NumeroContrato As String


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Criptas
''' </summary>
''' <remarks></remarks>
Public Class CriptaService
    Inherits CatalogService(Of CriptaInfo)

#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Church", "Criptas", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCripta As Integer, ByRef Cripta As CriptaInfo, checkStatus As Boolean)
        MyBase.GetDetail(idCripta, Cripta, checkStatus)
        With Cripta
            .NumeroCripta = CStr(ItemInfo("NumeroCripta"))
            .NombrePlaca = CStr(ItemInfo("NombrePlaca"))
            .Calle = CStr(ItemInfo("Calle"))
            .NumExt = CStr(ItemInfo("NumExt"))
            .NumInt = CStr(ItemInfo("NumInt"))
            .Colonia = CStr(ItemInfo("Colonia"))
            .CP = CStr(ItemInfo("CP"))
            .IdPoblacion = CInt(ItemInfo("IdPoblacion"))
            .TelCasa = CStr(ItemInfo("TelCasa"))
            .Celular = CStr(ItemInfo("Celular"))
            .Correo = CStr(ItemInfo("Correo"))
            .Observaciones = CStr(ItemInfo("Observaciones"))
            .Pagado = CBool(ItemInfo("Pagado"))
            .FN = CBool(ItemInfo("FN"))
            .CenizasDe1 = CStr(ItemInfo("CenizasDe1"))
            .FechaDeposito1 = CDate(ItemInfo("FechaDeposito1"))
            .CenizasDe2 = CStr(ItemInfo("CenizasDe2"))
            .FechaDeposito2 = CDate(ItemInfo("FechaDeposito2"))
            .CenizasDe3 = CStr(ItemInfo("CenizasDe3"))
            .FechaDeposito3 = CDate(ItemInfo("FechaDeposito3"))
            .Titular = CStr(ItemInfo("Titular"))
            .Beneficiario = CStr(ItemInfo("Beneficiario"))
            .NumeroContrato = CStr(ItemInfo("NumeroContrato"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Cripta As CriptaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@NumeroCripta", DbType.String).Value = Cripta.NumeroCripta
            .Add("@NombrePlaca", DbType.String).Value = Cripta.NombrePlaca
            .Add("@Calle", DbType.String).Value = Cripta.Calle
            .Add("@NumExt", DbType.String).Value = Cripta.NumExt
            .Add("@NumInt", DbType.String).Value = Cripta.NumInt
            .Add("@Colonia", DbType.String).Value = Cripta.Colonia
            .Add("@CP", DbType.String).Value = Cripta.CP
            .Add("@IdPoblacion", DbType.Int32).Value = Cripta.IdPoblacion
            .Add("@TelCasa", DbType.String).Value = Cripta.TelCasa
            .Add("@Celular", DbType.String).Value = Cripta.Celular
            .Add("@Correo", DbType.String).Value = Cripta.Correo
            .Add("@Observaciones", DbType.String).Value = Cripta.Observaciones
            .Add("@Pagado", DbType.Boolean).Value = Cripta.Pagado
            .Add("@FN", DbType.Boolean).Value = Cripta.FN
            .Add("@CenizasDe1", DbType.String).Value = Cripta.CenizasDe1
            .Add("@FechaDeposito1", DbType.DateTime).Value = Cripta.FechaDeposito1
            .Add("@CenizasDe2", DbType.String).Value = Cripta.CenizasDe2
            .Add("@FechaDeposito2", DbType.DateTime).Value = Cripta.FechaDeposito2
            .Add("@CenizasDe3", DbType.String).Value = Cripta.CenizasDe3
            .Add("@FechaDeposito3", DbType.DateTime).Value = Cripta.FechaDeposito3
            .Add("@Titular", DbType.String).Value = Cripta.Titular
            .Add("@Beneficiario", DbType.String).Value = Cripta.Beneficiario
            .Add("@NumeroContrato", DbType.String).Value = Cripta.NumeroContrato


        End With
        Return MyBase.Update(Cripta)
    End Function

    Public Overrides Function Create() As CriptaInfo
        Return New CriptaInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Criptas
''' </summary>
''' <remarks></remarks>
Public Class CriptaFacade
    Inherits CatalogFacade(Of CriptaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CriptaInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As CriptaInfo
        Dim CriptaSvc As New CriptaService(session)
        Return CriptaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Criptas
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idCripta">Identificador del Cripta que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idCripta As Integer)
        Dim CriptaSvc As New CriptaService(session)
        Delete(CriptaSvc, idCripta)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Cripta con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idCripta">ID de Cripta que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idCripta As Integer) As Boolean
        Dim CriptaSvc As New CriptaService(session)
        Return Exists(CriptaSvc, idCripta)
    End Function

    ''' <summary>
    ''' Verifica si existe un Cripta con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim CriptaSvc As New CriptaService(session)
        Return Exists(CriptaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Cripta.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idCripta">Identificador de Cripta a consultar</param>
    ''' <returns>Paquete de información de tipo CriptaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idCripta As Integer) As CriptaInfo
        Return Me.GetDetail(session, idCripta, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Cripta.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idCripta">Identificador de Cripta</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Cripta.</param>
    ''' <returns>Paquete de información de tipo CriptaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idCripta As Integer, checkStatus As Boolean) As CriptaInfo
        Dim CriptaSvc As New CriptaService(session)
        Dim CriptaInf As New CriptaInfo(session)
        GetDetail(CriptaSvc, CriptaInf, idCripta, checkStatus)
        Return CriptaInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Cripta en base a su codigo de usuario
    ''' y verifica que el Cripta esté activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información CriptaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As CriptaInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Cripta en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Cripta</param>
    ''' <returns>Paquete de información CriptaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CriptaInfo
        Dim CriptaInf As New CriptaInfo(session)
        Dim CriptaSvc As New CriptaService(session)
        GetDetail(CriptaSvc, CriptaInf, userCode, idSucursal, checkStatus)
        Return CriptaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Cripta.
    ''' </summary>
    ''' <param name="Cripta">Paquete de información del tipo CriptaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Cripta, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Cripta As CriptaInfo) As Integer
        Dim CriptaSvc As New CriptaService(Cripta.SessionID)
        Return Update(CriptaSvc, Cripta)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim CriptaSvc As New CriptaService(session)
        Return GetNumberOfPages(CriptaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Criptas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(session, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Criptas que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim CriptaSvc As New CriptaService(session)
        Return GetSearchResult(CriptaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Criptas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim CriptaSvc As New CriptaService(session)
        Return GetSearchStructure(CriptaSvc)
    End Function

#End Region

End Class
