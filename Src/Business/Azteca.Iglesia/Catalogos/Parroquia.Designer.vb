''' <summary>
''' Paquete de información que representa un Parroquia
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class ParroquiaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property Calle As String

    Public Property NumExt As String

    Public Property NumInt As String

    Public Property Colonia As String

    Public Property CP As String

    Public Property IdPoblacion As Integer

    Public Property FacturaElectronica As Boolean

    Public Property RFC As String

    Public Property RazonSocial As String

    Public Property Telefono As String

    Public Property Fax As String

    Public Property Correo As String

    Public Property PagWeb As String

    Public Property IdSacerdote As Integer

    Public Property Arquidiocesis As String

    Public Property Numero As String


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal session As Guid)
        MyBase.New(session)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Parroquias
''' </summary>
''' <remarks></remarks>
Public Class ParroquiaService
    Inherits CatalogService(Of ParroquiaInfo)

#Region "Constructores"
    Public Sub New(ByVal session As Guid)
        Me.New(session, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection)
        Me.New(session, cnn, Nothing)
    End Sub

    Public Sub New(ByVal session As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Church", "Parroquias", session)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idParroquia As Integer, ByRef Parroquia As ParroquiaInfo, checkStatus As Boolean)
        MyBase.GetDetail(idParroquia, Parroquia, checkStatus)
        With Parroquia
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
            .Telefono = CStr(ItemInfo("Telefono"))
            .Fax = CStr(ItemInfo("Fax"))
            .Correo = CStr(ItemInfo("Correo"))
            .PagWeb = CStr(ItemInfo("PagWeb"))
            .IdSacerdote = CInt(ItemInfo("IdSacerdote"))
            .Arquidiocesis = CStr(ItemInfo("Arquidiocesis"))
            .Numero = CStr(ItemInfo("Numero"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Parroquia As ParroquiaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Parroquia.Nombre
            .Add("@Calle", DbType.String).Value = Parroquia.Calle
            .Add("@NumExt", DbType.String).Value = Parroquia.NumExt
            .Add("@NumInt", DbType.String).Value = Parroquia.NumInt
            .Add("@Colonia", DbType.String).Value = Parroquia.Colonia
            .Add("@CP", DbType.String).Value = Parroquia.CP
            .Add("@IdPoblacion", DbType.Int32).Value = Parroquia.IdPoblacion
            .Add("@FacturaElectronica", DbType.Boolean).Value = Parroquia.FacturaElectronica
            .Add("@RFC", DbType.String).Value = Parroquia.RFC
            .Add("@RazonSocial", DbType.String).Value = Parroquia.RazonSocial
            .Add("@Telefono", DbType.String).Value = Parroquia.Telefono
            .Add("@Fax", DbType.String).Value = Parroquia.Fax
            .Add("@Correo", DbType.String).Value = Parroquia.Correo
            .Add("@PagWeb", DbType.String).Value = Parroquia.PagWeb
            .Add("@IdSacerdote", DbType.Int32).Value = Parroquia.IdSacerdote
            .Add("@Arquidiocesis", DbType.String).Value = Parroquia.Arquidiocesis
            .Add("@Numero", DbType.String).Value = Parroquia.Numero

        End With
        Return MyBase.Update(Parroquia)
    End Function

    Public Overrides Function Create() As ParroquiaInfo
        Return New ParroquiaInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Parroquias
''' </summary>
''' <remarks></remarks>
Public Class ParroquiaFacade
    Inherits CatalogFacade(Of ParroquiaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un ParroquiaInfo
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal session As Guid) As ParroquiaInfo
        Dim ParroquiaSvc As New ParroquiaService(session)
        Return ParroquiaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de Parroquias
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idParroquia">Identificador del Parroquia que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal session As Guid, ByVal idParroquia As Integer)
        Dim ParroquiaSvc As New ParroquiaService(session)
        Delete(ParroquiaSvc, idParroquia)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Parroquia con el Identificador especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idParroquia">ID de Parroquia que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal session As Guid, ByVal idParroquia As Integer) As Boolean
        Dim ParroquiaSvc As New ParroquiaService(session)
        Return Exists(ParroquiaSvc, idParroquia)
    End Function

    ''' <summary>
    ''' Verifica si existe un Parroquia con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="session">Objeto de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim ParroquiaSvc As New ParroquiaService(session)
        Return Exists(ParroquiaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Parroquia.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idParroquia">Identificador de Parroquia a consultar</param>
    ''' <returns>Paquete de información de tipo ParroquiaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idParroquia As Integer) As ParroquiaInfo
        Return Me.GetDetail(session, idParroquia, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Parroquia.
    ''' </summary>
    ''' <param name="session">Objeto de sesión necesario para realizar la operación</param>
    ''' <param name="idParroquia">Identificador de Parroquia</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Parroquia.</param>
    ''' <returns>Paquete de información de tipo ParroquiaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal session As Guid, ByVal idParroquia As Integer, checkStatus As Boolean) As ParroquiaInfo
        Dim ParroquiaSvc As New ParroquiaService(session)
        Dim ParroquiaInf As New ParroquiaInfo(session)
        GetDetail(ParroquiaSvc, ParroquiaInf, idParroquia, checkStatus)
        Return ParroquiaInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Parroquia en base a su codigo de usuario
    ''' y verifica que el Parroquia esté activo.
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información ParroquiaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As ParroquiaInfo
        Return Me.GetDetail(session, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Parroquia en base a su codigo de usuario
    ''' </summary>
    ''' <param name="session">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Parroquia</param>
    ''' <returns>Paquete de información ParroquiaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal session As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As ParroquiaInfo
        Dim ParroquiaInf As New ParroquiaInfo(session)
        Dim ParroquiaSvc As New ParroquiaService(session)
        GetDetail(ParroquiaSvc, ParroquiaInf, userCode, idSucursal, checkStatus)
        Return ParroquiaInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Parroquia.
    ''' </summary>
    ''' <param name="Parroquia">Paquete de información del tipo ParroquiaInfo con la información a actualizar</param>
    ''' <returns>Identificador de Parroquia, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Parroquia As ParroquiaInfo) As Integer
        Dim ParroquiaSvc As New ParroquiaService(Parroquia.SessionID)
        Return Update(ParroquiaSvc, Parroquia)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim ParroquiaSvc As New ParroquiaService(session)
        Return GetNumberOfPages(ParroquiaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Parroquias que coincidan con las condiciones especificadas.
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
    ''' Busca Parroquias que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal session As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim ParroquiaSvc As New ParroquiaService(session)
        Return GetSearchResult(ParroquiaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Parroquias.
    ''' </summary>
    ''' <param name="session">Objeto de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal session As Guid) As System.Data.DataSet
        Dim ParroquiaSvc As New ParroquiaService(session)
        Return GetSearchStructure(ParroquiaSvc)
    End Function

#End Region

End Class
