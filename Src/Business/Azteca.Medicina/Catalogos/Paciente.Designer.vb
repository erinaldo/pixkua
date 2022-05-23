Imports Azteca.Kernel.BusinessStructure
Imports Azteca.Kernel.Search
Imports Newtonsoft.Json.Linq

''' <summary>
''' Paquete de información que representa un Paciente
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class PacienteInfo
    Inherits CatalogInfo

#Region "Campos Privados"
    Protected Friend _Cliente As ClienteInfo
#End Region

#Region "Propiedades"

    Public Property Sexo As SexoEnum

    Public Property FechaNacimiento As Date

    Public Property IdUltimoDoctor As Integer

    Public Property Ocupacion As String

    Public Property Afiliado As Boolean

    Public Property Diagnostico As String

    Public Property PrimeraConsulta As Date

    Public Property UltimaConsulta As Date

    Public Property IdCliente As Integer

    Public ReadOnly Property Cliente As ClienteInfo
        Get
            Return _Cliente
        End Get
    End Property


#End Region

#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        Me.Status = CatalogState.Active
        Me._Cliente = New ClienteInfo(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Pacientes
''' </summary>                                                                                                                                                                                                                                                                                          
''' <remarks></remarks>
Public Class PacienteService
    Inherits CatalogService(Of PacienteInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As Guid)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Medicine", "Pacientes", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region


#Region "Metodos de CatalogService"
    Private Function getSexo(Sexo As String) As SexoEnum
        Select Case Sexo
            Case "M" : Return SexoEnum.Masculino
            Case Else : Return SexoEnum.Femenino
        End Select
    End Function

    Private Function getSexo(Sexo As SexoEnum) As String
        Select Case Sexo
            Case SexoEnum.Masculino : Return "M"
            Case Else : Return "F"
        End Select
    End Function

    Public Overrides Sub GetDetail(ByVal idPaciente As Integer, ByRef Paciente As PacienteInfo, checkStatus As Boolean)
        MyBase.GetDetail(idPaciente, Paciente, checkStatus)
        With Paciente
            .Sexo = getSexo(CStr(ItemInfo("Sexo")))
            .FechaNacimiento = CDate(ItemInfo("FechaNacimiento"))
            .IdUltimoDoctor = CInt(ItemInfo("IdUltimoDoctor"))
            .Ocupacion = CStr(ItemInfo("Ocupacion"))
            .Afiliado = CBool(ItemInfo("Afiliado"))
            .Diagnostico = CStr(ItemInfo("Diagnostico"))
            If Not IsDBNull(ItemInfo("PrimeraConsulta")) Then .PrimeraConsulta = CDate(ItemInfo("PrimeraConsulta"))
            If Not IsDBNull(ItemInfo("UltimaConsulta")) Then .UltimaConsulta = CDate(ItemInfo("UltimaConsulta"))
            .IdCliente = CInt(ItemInfo("IdCliente"))
            Dim ClienteSvc As New ClienteService(SessionID, Me.Connection, Me.Transaction)
            ClienteSvc.GetDetail(CInt(ItemInfo("IdCliente")), .Cliente, False)

        End With
    End Sub

    Public Overrides Function Update(ByVal Paciente As PacienteInfo) As Integer
        Paciente.Cliente.Status = Paciente.Status

        If Paciente.Identity = 0 Then
            Paciente.Cliente.Status = CatalogState.Active
        Else
            Paciente.Cliente.Status = Paciente.Status
        End If

        Dim ClienteSvc As New ClienteService(SessionID, Me.Connection, Me.Transaction)
        Dim IdCliente As Integer = ClienteSvc.Update(Paciente.Cliente)

        With Me.SPUpdate.Parameters
            .Add("@IdCliente", DbType.Int32).Value = IdCliente
            .Add("@Sexo", DbType.String).Value = getSexo(Paciente.Sexo)
            .Add("@FechaNacimiento", DbType.DateTime).Value = Paciente.FechaNacimiento.ToShortDateString
            '.Add("@IdUltimoDoctor", DbType.Int32).Value = Paciente.IdUltimoDoctor
            .Add("@Ocupacion", DbType.String).Value = Paciente.Ocupacion
            .Add("@Afiliado", DbType.Boolean).Value = Paciente.Afiliado
            '.Add("@Diagnostico", DbType.String).Value = Paciente.Diagnostico
            '.Add("@PrimeraConsulta", DbType.DateTime).Value = Paciente.PrimeraConsulta
            '.Add("@UltimaConsulta", DbType.DateTime).Value = Paciente.UltimaConsulta

        End With
        Return MyBase.Update(Paciente)
    End Function

    Public Overrides Function Create() As PacienteInfo
        Return New PacienteInfo(SessionID)
    End Function

    Public Overrides Function Create(json As String) As PacienteInfo
        Dim Paciente As PacienteInfo = MyBase.Create(json)
        Dim Query As JObject = JObject.Parse(json)
        Dim ClienteSvc As ClienteService = New ClienteService(SessionID, Connection, Transaction)
        Paciente._Cliente = ClienteSvc.Create(Query("Cliente").ToString())
        Return Paciente
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Pacientes
''' </summary>
''' <remarks></remarks>
Public Class PacienteFacade
    Inherits CatalogFacade(Of PacienteInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un PacienteInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As Guid) As PacienteInfo
        Dim PacienteSvc As New PacienteService(sessionID)
        Return PacienteSvc.Create()
    End Function

    Public Overloads Function Create(ByVal sessionID As Guid, json As String) As PacienteInfo
        Dim PacienteSvc As New PacienteService(sessionID)
        Return PacienteSvc.Create(json)
    End Function
    ''' <summary>
    ''' Elimina un elemento del catálogo de Pacientes
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPaciente">Identificador del Paciente que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As Guid, ByVal idPaciente As Integer)
        Dim PacienteSvc As New PacienteService(sessionID)
        Delete(PacienteSvc, idPaciente)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Paciente con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPaciente">ID de Paciente que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As Guid, ByVal idPaciente As Integer) As Boolean
        Dim PacienteSvc As New PacienteService(sessionID)
        Return Exists(PacienteSvc, idPaciente)
    End Function

    ''' <summary>
    ''' Verifica si existe un Paciente con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim PacienteSvc As New PacienteService(sessionID)
        Return Exists(PacienteSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Paciente.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPaciente">Identificador de Paciente a consultar</param>
    ''' <returns>Paquete de información de tipo PacienteInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idPaciente As Integer) As PacienteInfo
        Return Me.GetDetail(sessionID, idPaciente, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Paciente.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idPaciente">Identificador de Paciente</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Paciente.</param>
    ''' <returns>Paquete de información de tipo PacienteInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As Guid, ByVal idPaciente As Integer, checkStatus As Boolean) As PacienteInfo
        Dim PacienteSvc As New PacienteService(sessionID)
        Dim PacienteInf As New PacienteInfo(sessionID)
        GetDetail(PacienteSvc, PacienteInf, idPaciente, checkStatus)
        Return PacienteInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Paciente en base a su codigo de usuario
    ''' y verifica que el Paciente esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información PacienteInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer) As PacienteInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Paciente en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Paciente</param>
    ''' <returns>Paquete de información PacienteInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As Guid, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As PacienteInfo
        Dim PacienteInf As New PacienteInfo(sessionID)
        Dim PacienteSvc As New PacienteService(sessionID)
        GetDetail(PacienteSvc, PacienteInf, userCode, idSucursal, checkStatus)
        Return PacienteInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Paciente.
    ''' </summary>
    ''' <param name="Paciente">Paquete de información del tipo PacienteInfo con la información a actualizar</param>
    ''' <returns>Identificador de Paciente, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Paciente As PacienteInfo) As Integer
        Dim PacienteSvc As New PacienteService(Paciente.SessionID)
        Return Update(PacienteSvc, Paciente)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim PacienteSvc As New PacienteService(sessionID)
        Return GetNumberOfPages(PacienteSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Pacientes que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Pacientes que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As Guid, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim PacienteSvc As New PacienteService(sessionID)
        Return GetSearchResult(PacienteSvc, idSite, conditions, order, page)
    End Function


    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Pacientes.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As Guid) As System.Data.DataSet
        Dim PacienteSvc As New PacienteService(sessionID)
        Return GetSearchStructure(PacienteSvc)
    End Function

#End Region

End Class

Public Enum SexoEnum
    Masculino
    Femenino
End Enum