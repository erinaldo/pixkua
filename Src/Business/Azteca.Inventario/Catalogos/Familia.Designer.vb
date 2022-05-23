

''' <summary>
''' Paquete de informaci�n que representa un Familia
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class FamiliaInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property IdEmpresa As Integer


#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As Guid)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de Familias
''' </summary>
''' <remarks></remarks>
Public Class FamiliaService
    Inherits CatalogService(Of FamiliaInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Inventory", "Familias", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idFamilia As Integer, ByRef Familia As FamiliaInfo, checkStatus As Boolean)
        MyBase.GetDetail(idFamilia, Familia, checkStatus)
        With Familia
            .Nombre = CStr(ItemInfo("Nombre"))

        End With
    End Sub

    Public Overrides Function Update(ByVal Familia As FamiliaInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Familia.Nombre

        End With
        Return MyBase.Update(Familia)
    End Function

    Public Overrides Function Create() As FamiliaInfo
        Return New FamiliaInfo(SessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de Familias
''' </summary>
''' <remarks></remarks>
Public Class FamiliaFacade
    Inherits CatalogFacade(Of FamiliaInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un FamiliaInfo
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As FamiliaInfo
        Dim FamiliaSvc As New FamiliaService(sessionID)
        Return FamiliaSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de Familias
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idFamilia">Identificador del Familia que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idFamilia As Integer)
        Dim FamiliaSvc As New FamiliaService(sessionID)
        Delete(FamiliaSvc, idFamilia)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Familia con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idFamilia">ID de Familia que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idFamilia As Integer) As Boolean
        Dim FamiliaSvc As New FamiliaService(sessionID)
        Return Exists(FamiliaSvc, idFamilia)
    End Function

    ''' <summary>
    ''' Verifica si existe un Familia con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim FamiliaSvc As New FamiliaService(sessionID)
        Return Exists(FamiliaSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Familia.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idFamilia">Identificador de Familia a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo FamiliaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idFamilia As Integer) As FamiliaInfo
        Return Me.GetDetail(sessionID, idFamilia, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Familia.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idFamilia">Identificador de Familia</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Familia.</param>
    ''' <returns>Paquete de informaci�n de tipo FamiliaInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idFamilia As Integer, checkStatus As Boolean) As FamiliaInfo
        Dim FamiliaSvc As New FamiliaService(sessionID)
        Dim FamiliaInf As New FamiliaInfo(sessionID)
        GetDetail(FamiliaSvc, FamiliaInf, idFamilia, checkStatus)
        Return FamiliaInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Familia en base a su codigo de usuario
    ''' y verifica que el Familia est� activo.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesion</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n FamiliaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As FamiliaInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un Familia en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesion</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Familia</param>
    ''' <returns>Paquete de informaci�n FamiliaInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As FamiliaInfo
        Dim FamiliaInf As New FamiliaInfo(sessionID)
        Dim FamiliaSvc As New FamiliaService(sessionID)
        GetDetail(FamiliaSvc, FamiliaInf, userCode, idSucursal, checkStatus)
        Return FamiliaInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un Familia.
    ''' </summary>
    ''' <param name="Familia">Paquete de informaci�n del tipo FamiliaInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de Familia, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Familia As FamiliaInfo) As Integer
        Dim FamiliaSvc As New FamiliaService(Familia.sessionID)
        Return Update(FamiliaSvc, Familia)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim FamiliaSvc As New FamiliaService(sessionID)
        Return GetNumberOfPages(FamiliaSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca Familias que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca Familias que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim FamiliaSvc As New FamiliaService(sessionID)
        Return GetSearchResult(FamiliaSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de Familias.
    ''' </summary>
    ''' <param name="sessionID">Objeto de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim FamiliaSvc As New FamiliaService(sessionID)
        Return GetSearchStructure(FamiliaSvc)
    End Function

#End Region

End Class
