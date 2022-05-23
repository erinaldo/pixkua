''' <summary>
''' Paquete de información que representa un Empleado
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class EmpleadoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Private _Persona As Azteca.Kernel.General.PersonaInfo
#End Region

#Region "Propiedades"

    Public ReadOnly Property Persona As Azteca.Kernel.General.PersonaInfo
        Get
            Return _Persona
        End Get
    End Property

    Public Property CodigoChecador As Integer

    Public Property NombreCorto As String

    Public Property IdTurno As Integer

    Public Property FechaInicio As Date

    Public Property Genero As String

    Public Property Titulo As String

    Public Property FechaIngreso As Date

    Public Property FechaBaja As Date

    Public Property Sueldo As Decimal

    Public Property IdDepartamento As Integer

    Public Property IdPuesto As Integer

    Public Property FechaNacimiento As Date

    Public Property NSS As String

    Public Property RFC As String

    Public Property CURP As String

    Public Property Foto As Byte()

    Public Property IdCuenta As Integer

    Public Property IdPersona As Integer
#End Region

#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
        _Persona = New Azteca.Kernel.General.PersonaInfo(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de Empleados
''' </summary>
''' <remarks></remarks>
Public Class EmpleadoService
	Inherits CatalogService(Of EmpleadoInfo)
	
#Region "Constructores"
	Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("RH","Empleados", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region
	
#Region "Metodos de CatalogService"

    Public Overrides Sub GetDetail(ByVal idEmpleado As Integer, ByRef Empleado As EmpleadoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idEmpleado, Empleado, checkStatus)
        With Empleado
            .IdPersona = CInt(ItemInfo("IdPersona"))
            .CodigoChecador = CInt(ItemInfo("CodigoChecador"))
            .NombreCorto = CStr(ItemInfo("NombreCorto"))
            .IdTurno = CInt(ItemInfo("IdTurno"))
            .FechaInicio = CDate(ItemInfo("FechaInicio"))
            .Genero = CStr(ItemInfo("Genero"))
            .Titulo = CStr(ItemInfo("Titulo"))
            .FechaIngreso = CDate(ItemInfo("FechaIngreso"))
            If Not IsDBNull(ItemInfo("FechaBaja")) Then .FechaBaja = CDate(ItemInfo("FechaBaja"))
            .Sueldo = CDec(ItemInfo("Sueldo"))
            .IdDepartamento = CInt(ItemInfo("IdDepartamento"))
            .IdPuesto = CInt(ItemInfo("IdPuesto"))
            .FechaNacimiento = CDate(ItemInfo("FechaNacimiento"))
            .NSS = CStr(ItemInfo("NSS"))
            .RFC = CStr(ItemInfo("RFC"))
            .CURP = CStr(ItemInfo("CURP"))
            If Not IsDBNull(ItemInfo("Foto")) Then .Foto = CType(ItemInfo("Foto"), Byte())
            .IdCuenta = CInt(ItemInfo("IdCuenta"))
            'Cargar información de la personas
            Dim IdPersona As Integer = CInt(ItemInfo("IdPersona"))
            Dim PersonaSvc As New Azteca.Kernel.General.PersonaService(SessionID, Me.Connection, Me.Transaction)
            PersonaSvc.GetDetail(IdPersona, .Persona, False)
        End With
    End Sub

    Public Overrides Function Update(ByVal Empleado As EmpleadoInfo) As Integer
        Dim PersonaSvc As New Azteca.Kernel.General.PersonaService(Me.SessionID, Me.Connection, Me.Transaction)
        Empleado.IdPersona = PersonaSvc.Update(Empleado.Persona)

        With Me.SPUpdate.Parameters
            .Add("@IdPersona", DbType.Int32).Value = Empleado.IdPersona
            .Add("@CodigoChecador", DbType.Int32).Value = Empleado.CodigoChecador
            .Add("@NombreCorto", DbType.String).Value = Empleado.NombreCorto
            .Add("@IdTurno", DbType.Int32).Value = Empleado.IdTurno
            .Add("@FechaInicio", DbType.DateTime).Value = Empleado.FechaInicio
            .Add("@Genero", DbType.String).Value = Empleado.Genero
            .Add("@Titulo", DbType.String).Value = Empleado.Titulo
            .Add("@FechaIngreso", DbType.DateTime).Value = Empleado.FechaIngreso
            ''.Add("@FechaBaja", DbType.DateTime).Value = Empleado.FechaBaja
            .Add("@Sueldo", DbType.Decimal).Value = Empleado.Sueldo
            .Add("@IdDepartamento", DbType.Int32).Value = Empleado.IdDepartamento
            .Add("@IdPuesto", DbType.Int32).Value = Empleado.IdPuesto
            .Add("@FechaNacimiento", DbType.DateTime).Value = Empleado.FechaNacimiento
            .Add("@NSS", DbType.String).Value = Empleado.NSS
            .Add("@RFC", DbType.String).Value = Empleado.RFC
            .Add("@CURP", DbType.String).Value = Empleado.CURP
            If Empleado.Foto Is Nothing Then
                .Add("@Foto", DbType.Binary).Value = DBNull.Value
            Else
                .Add("@Foto", DbType.Binary).Value = Empleado.Foto
            End If
            .Add("@IdCuenta", DbType.Int32).Value = Empleado.IdCuenta
        End With
        Return MyBase.Update(Empleado)
    End Function

    Public Overrides Function Create() As EmpleadoInfo
        Return New EmpleadoInfo(SessionID)
    End Function

#End Region
	
End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de Empleados
''' </summary>
''' <remarks></remarks>
Public Class EmpleadoFacade
	Inherits CatalogFacade(Of EmpleadoInfo)
        
#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un EmpleadoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
	Public Overrides Function Create(ByVal sessionID As GUID) As EmpleadoInfo
		Dim EmpleadoSvc As New EmpleadoService(sessionID)
		Return EmpleadoSvc.Create()
	End Function
    
    ''' <summary>
    ''' Elimina un elemento del catálogo de Empleados
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idEmpleado">Identificador del Empleado que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idEmpleado As Integer)
		Dim EmpleadoSvc As New EmpleadoService(sessionID)
		Delete(EmpleadoSvc, idEmpleado)
	End Sub
	
    ''' <summary>
    ''' Verifica si existe un Empleado con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idEmpleado">ID de Empleado que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idEmpleado As Integer) As Boolean
		Dim EmpleadoSvc As New EmpleadoService(sessionID)
		Return Exists(EmpleadoSvc, idEmpleado)
    End Function

    ''' <summary>
    ''' Verifica si existe un Empleado con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal as Integer) As Boolean
        Dim EmpleadoSvc As New EmpleadoService(sessionID)
        Return Exists(EmpleadoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Empleado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idEmpleado">Identificador de Empleado a consultar</param>
    ''' <returns>Paquete de información de tipo EmpleadoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idEmpleado As Integer) As EmpleadoInfo
        Return Me.GetDetail(sessionID, idEmpleado, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Empleado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idEmpleado">Identificador de Empleado</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Empleado.</param>
    ''' <returns>Paquete de información de tipo EmpleadoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idEmpleado As Integer, checkStatus As Boolean) As EmpleadoInfo
   		Dim EmpleadoSvc As New EmpleadoService(sessionID)
        Dim EmpleadoInf As New EmpleadoInfo(sessionID)
		GetDetail(EmpleadoSvc, EmpleadoInf, idEmpleado, checkStatus)
        Return EmpleadoInf        
    End Function

    ''' <summary>
    ''' Obtiene la información de un Empleado en base a su codigo de usuario
    ''' y verifica que el Empleado esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información EmpleadoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As EmpleadoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Empleado en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Empleado</param>
    ''' <returns>Paquete de información EmpleadoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As EmpleadoInfo
        Dim EmpleadoInf As New EmpleadoInfo(sessionID)
        Dim EmpleadoSvc As New EmpleadoService(sessionID)
        GetDetail(EmpleadoSvc, EmpleadoInf, userCode, idSucursal, checkStatus)
        Return EmpleadoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Empleado.
    ''' </summary>
    ''' <param name="Empleado">Paquete de información del tipo EmpleadoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Empleado, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Empleado As EmpleadoInfo) As Integer
    	Dim EmpleadoSvc As New EmpleadoService(Empleado.sessionID)
		Return Update(EmpleadoSvc, Empleado)
    End Function
	
    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection) As Integer
    	Dim EmpleadoSvc As New EmpleadoService(sessionID)
    	Return GetNumberOfPages(EmpleadoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Empleados que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Empleados que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite as Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
    	Dim EmpleadoSvc As New EmpleadoService(sessionID)
    	Return GetSearchResult(EmpleadoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de Empleados.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
    	Dim EmpleadoSvc As New EmpleadoService(sessionID)
    	Return GetSearchStructure(EmpleadoSvc)
    End Function

#End Region

End Class
