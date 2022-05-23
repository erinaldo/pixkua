''' <summary>
''' Paquete de informaci�n que representa un EstructuraComercial
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class EstructuraComercialInfo
	Inherits HierarchyInfo
	
#Region "Campos Privados"

#End Region

#Region "Propiedades"

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del cat�logo de EstCom
''' </summary>
''' <remarks></remarks>
Public Class EstructuraComercialService
    Inherits HierarchyService(Of EstructuraComercialInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Sales", "EstCom", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos Publicos"

    Public Overrides Sub GetDetail(ByVal idEstructuraComercial As Integer, ByRef EstructuraComercial As EstructuraComercialInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idEstructuraComercial, EstructuraComercial, checkStatus)
        With EstructuraComercial

        End With
    End Sub

    Public Overrides Function Update(ByVal EstructuraComercial As EstructuraComercialInfo) As Integer
        With Me.SPUpdate.Parameters

        End With
        Return MyBase.Update(EstructuraComercial)
    End Function

    Public Overrides Function Create() As EstructuraComercialInfo
        Return New EstructuraComercialInfo(sessionID)
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del cat�logo de EstCom
''' </summary>
''' <remarks></remarks>
Public Class EstructuraComercialFacade
    Inherits HierarchyFacade(Of EstructuraComercialInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un EstructuraComercialInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As EstructuraComercialInfo
        Dim EstructuraComercialSvc As New EstructuraComercialService(sessionID)
        Return EstructuraComercialSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del cat�logo de EstCom
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idEstructuraComercial">Identificador del EstructuraComercial que se eliminar�</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idEstructuraComercial As Integer)
        Dim EstructuraComercialSvc As New EstructuraComercialService(sessionID)
        Delete(EstructuraComercialSvc, idEstructuraComercial)
    End Sub

    ''' <summary>
    ''' Verifica si existe un EstructuraComercial con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idEstructuraComercial">ID de EstructuraComercial que ser� verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idEstructuraComercial As Integer) As Boolean
        Dim EstructuraComercialSvc As New EstructuraComercialService(sessionID)
        Return Exists(EstructuraComercialSvc, idEstructuraComercial)
    End Function

    ''' <summary>
    ''' Verifica si existe un EstructuraComercial con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario b�scado</param>
    ''' <returns>True si existe un usuario con ese c�digo, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim EstructuraComercialSvc As New EstructuraComercialService(sessionID)
        Return Exists(EstructuraComercialSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un EstructuraComercial.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idEstructuraComercial">Identificador de EstructuraComercial a consultar</param>
    ''' <returns>Paquete de informaci�n de tipo EstructuraComercialInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idEstructuraComercial As Integer) As EstructuraComercialInfo
        Return Me.GetDetail(sessionID, idEstructuraComercial, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un EstructuraComercial.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idEstructuraComercial">Identificador de EstructuraComercial</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del EstructuraComercial.</param>
    ''' <returns>Paquete de informaci�n de tipo EstructuraComercialInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idEstructuraComercial As Integer, ByVal checkStatus As Boolean) As EstructuraComercialInfo
        Dim EstructuraComercialSvc As New EstructuraComercialService(sessionID)
        Dim EstructuraComercialInf As New EstructuraComercialInfo(sessionID)
        GetDetail(EstructuraComercialSvc, EstructuraComercialInf, idEstructuraComercial, checkStatus)
        Return EstructuraComercialInf
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un EstructuraComercial en base a su codigo de usuario
    ''' y verifica que el EstructuraComercial est� activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">C�digo de usuario a buscar</param>
    ''' <returns>Paquete de informaci�n EstructuraComercialInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As EstructuraComercialInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la informaci�n de un EstructuraComercial en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del EstructuraComercial</param>
    ''' <returns>Paquete de informaci�n EstructuraComercialInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As EstructuraComercialInfo
        Dim EstructuraComercialInf As New EstructuraComercialInfo(sessionID)
        Dim EstructuraComercialSvc As New EstructuraComercialService(sessionID)
        GetDetail(EstructuraComercialSvc, EstructuraComercialInf, userCode, idSucursal, checkStatus)
        Return EstructuraComercialInf
    End Function

    ''' <summary>
    ''' Actualiza la informaci�n de un EstructuraComercial.
    ''' </summary>
    ''' <param name="EstructuraComercial">Paquete de informaci�n del tipo EstructuraComercialInfo con la informaci�n a actualizar</param>
    ''' <returns>Identificador de EstructuraComercial, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal EstructuraComercial As EstructuraComercialInfo) As Integer
        Dim EstructuraComercialSvc As New EstructuraComercialService(EstructuraComercial.SessionID)
        Return Update(EstructuraComercialSvc, EstructuraComercial)
    End Function

    ''' <summary>
    ''' Obtiene el n�mero de p�ginas de la b�squeda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la operaci�n</param>
    ''' <param name="conditions">Colecci�n de condiciones de la b�squeda</param>
    ''' <returns>N�mero de p�ginas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim EstructuraComercialSvc As New EstructuraComercialService(sessionID)
        Return GetNumberOfPages(EstructuraComercialSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca EstCom que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection) As System.Data.DataSet
        Return Me.GetSearchResult(sessionID, idSite, conditions, order, 0)
    End Function

    ''' <summary>
    ''' Busca EstCom que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="conditions">Colecci�n de condiciones</param>
    ''' <param name="order">Orden en que se devolver� el conjunto resultante</param>
    ''' <param name="page">N�mero de p�gina que se devolver�</param>
    ''' <returns>Dataset con las filas del resultado de la b�squeda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim EstructuraComercialSvc As New EstructuraComercialService(sessionID)
        Return GetSearchResult(EstructuraComercialSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de b�squeda del cat�logo de EstCom.
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de b�suqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim EstructuraComercialSvc As New EstructuraComercialService(sessionID)
        Return GetSearchStructure(EstructuraComercialSvc)
    End Function

#End Region

#Region "Implementacion IHierarchyFacade"

    ''' <summary>
    ''' Obtiene los nodos secundarios del nodo especificado
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n que autoriza la llamada</param>
    ''' <param name="idPadre">Identificador del nodo del que se obtendr�n sus nodos secundarios</param>
    ''' <returns>Datatable con la lista de nodos secundarios.</returns>
    ''' <remarks></remarks>
    Public Overrides Function LoadChilds(ByVal sessionID As GUID, ByVal idEmpresa As Integer, ByVal idPadre As Integer) As HierarchyDS.HierarchyDataTable
        Dim EstructuraComercialSvc As New EstructuraComercialService(sessionID)
        Dim Nodes As New HierarchyDS.HierarchyDataTable
        LoadChilds(EstructuraComercialSvc, idEmpresa, idPadre, Nodes)
        Return Nodes
    End Function

    ''' <summary>
    ''' Mueve un nodo al nivel y posici�n especificados
    ''' </summary>
    ''' <param name="sessionID">ID de sesi�n necesario para realizar la operaci�n</param>
    ''' <param name="idNodo">Identificador del nodo que se mover�</param>
    ''' <param name="idParentDest">Identificador del nuevo nodo padre.</param>
    ''' <param name="order">Nueva posici�n del nodo dentro del nivel.</param>
    ''' <remarks></remarks>
    Public Overrides Sub MoveNode(ByVal sessionID As GUID, ByVal idNodo As Integer, ByVal idParentDest As Integer, ByVal order As Integer)
        Dim EstructuraComercialSvc As New EstructuraComercialService(sessionID)
        MoveNode(EstructuraComercialSvc, idNodo, idParentDest, order)
    End Sub

#End Region

End Class
