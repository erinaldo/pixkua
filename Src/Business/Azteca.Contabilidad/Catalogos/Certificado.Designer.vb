Imports Azteca.Kernel

''' <summary>
''' Paquete de información que representa un Certificado
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class CertificadoInfo
	Inherits CatalogInfo
	
#Region "Campos Privados"
    Private _Series As CertificadoDS.SeriesDataTable
#End Region

#Region "Propiedades"
    Public Property Nombre As String

    Public Property LlavePrivada As Byte()

    Public Property PasswordPrivateKey As String = String.Empty

    Public Property Certificado As Byte()

    Public Property NumeroCertificado As String

    Public Property TipoCFD As FormatoCFD = FormatoCFD.CFD

    Public ReadOnly Property Series As CertificadoDS.SeriesDataTable
        Get
            Return _Series
        End Get
    End Property

#End Region
	
#Region "Constructor"
    Public Sub New(ByVal sessionID As GUID)
        MyBase.New(sessionID)
        _Series = New CertificadoDS.SeriesDataTable
    End Sub
#End Region

End Class


''' <summary>
''' Proveedor de servicios para el manejo del catálogo de CFDCertificados
''' </summary>
''' <remarks></remarks>
Public Class CertificadoService
    Inherits CatalogService(Of CertificadoInfo)

#Region "Constructores"
    Public Sub New(ByVal sessionID As GUID)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As GUID, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        MyBase.New("Accounting", "CFDCertificados", sessionID)
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

#Region "Metodos de CatalogService"
    Public Overrides Sub GetDetail(ByVal idCertificado As Integer, ByRef Certificado As CertificadoInfo, ByVal checkStatus As Boolean)
        MyBase.GetDetail(idCertificado, Certificado, checkStatus)
        With Certificado
            .Nombre = CStr(Me.ItemInfo("Nombre"))
            If ItemInfo("LlavePrivada") Is DBNull.Value Then
                .LlavePrivada = Nothing
            Else
                .LlavePrivada = CType(Me.ItemInfo("LlavePrivada"), Byte())
            End If
            .PasswordPrivateKey = CStr(Me.ItemInfo("PasswordPK"))
            If ItemInfo("Certificado") Is DBNull.Value Then
                .Certificado = Nothing
            Else
                .Certificado = CType(Me.ItemInfo("Certificado"), Byte())
            End If
            .NumeroCertificado = CStr(Me.ItemInfo("NumCertificado"))
            .TipoCFD = GetTipoCFD(ItemInfo("TipoCFD").ToString)
        End With
        CargarSeries(Certificado)
    End Sub

    Public Overrides Function Update(ByVal Certificado As CertificadoInfo) As Integer
        With Me.SPUpdate.Parameters
            .Add("@Nombre", DbType.String).Value = Certificado.Nombre
            .Add("@LlavePrivada", DbType.Binary).Value = Certificado.LlavePrivada
            .Add("@PasswordPK", DbType.String).Value = Certificado.PasswordPrivateKey
            .Add("@Certificado", DbType.Binary).Value = Certificado.Certificado
            .Add("@NumCertificado", DbType.String).Value = Certificado.NumeroCertificado
            .Add("@TipoCFD", DbType.String).Value = GetTipoCFD(Certificado.TipoCFD)
        End With
        Dim IdCertificado As Integer = MyBase.Update(Certificado)
        Dim CertCacheKey As String = "CertificadoCFD" & IdCertificado.ToString
        If Cache.Item(CertCacheKey) IsNot Nothing Then Cache.Remove(CertCacheKey)
        Return IdCertificado
    End Function

    Public Overrides Function Create() As CertificadoInfo
        Return New CertificadoInfo(sessionID)
    End Function

#End Region

#Region "Metodos Privados"

    Private Sub CargarSeries(ByVal certificado As CertificadoInfo)
        Try
            Dim fxSeries As New FunctionSQL("Accounting", "fxCFDCertificadoSeries", Connection, Transaction)
            fxSeries.Parameters.Add("@IdCFDCertificado", DbType.Int32).Value = certificado.Identity
            fxSeries.FillDataTable(certificado.Series)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar las series del certificado.", ex)
        End Try
    End Sub

    Private Function GetTipoCFD(tipo As String) As FormatoCFD
        Select Case tipo
            Case "C"
                Return FormatoCFD.CFD
            Case "I"
                Return FormatoCFD.CFDI

            Case Else
                Return FormatoCFD.CFD
        End Select
    End Function

    Private Function GetTipoCFD(tipo As FormatoCFD) As String
        Select Case tipo
            Case FormatoCFD.CFD
                Return "C"
            Case FormatoCFD.CFDI
                Return "I"
            Case Else
                Return String.Empty
        End Select
    End Function

#End Region

End Class


''' <summary>
''' Business Facade con servicios para el manejo del catálogo de CFDCertificados
''' </summary>
''' <remarks></remarks>
Public Class CertificadoFacade
    Inherits CatalogFacade(Of CertificadoInfo)

#Region "Metodos de CatalogFacade"

    ''' <summary>
    ''' Crea una nueva instancia de un CertificadoInfo
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <remarks></remarks>
    Public Overrides Function Create(ByVal sessionID As GUID) As CertificadoInfo
        Dim CertificadoSvc As New CertificadoService(sessionID)
        Return CertificadoSvc.Create()
    End Function

    ''' <summary>
    ''' Elimina un elemento del catálogo de CFDCertificados
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCertificado">Identificador del Certificado que se eliminará</param>
    ''' <remarks></remarks>
    Public Overrides Sub Delete(ByVal sessionID As GUID, ByVal idCertificado As Integer)
        Dim CertificadoSvc As New CertificadoService(sessionID)
        Delete(CertificadoSvc, idCertificado)
    End Sub

    ''' <summary>
    ''' Verifica si existe un Certificado con el Identificador especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCertificado">ID de Certificado que será verificado</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Exists(ByVal sessionID As GUID, ByVal idCertificado As Integer) As Boolean
        Dim CertificadoSvc As New CertificadoService(sessionID)
        Return Exists(CertificadoSvc, idCertificado)
    End Function

    ''' <summary>
    ''' Verifica si existe un Certificado con el codigo de usuario especificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario búscado</param>
    ''' <returns>True si existe un usuario con ese código, false en caso contrario</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function Exists(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As Boolean
        Dim CertificadoSvc As New CertificadoService(sessionID)
        Return Exists(CertificadoSvc, userCode, idSucursal)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Certificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCertificado">Identificador de Certificado a consultar</param>
    ''' <returns>Paquete de información de tipo CertificadoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCertificado As Integer) As CertificadoInfo
        Return Me.GetDetail(sessionID, idCertificado, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Certificado.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión necesario para realizar la operación</param>
    ''' <param name="idCertificado">Identificador de Certificado</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Certificado.</param>
    ''' <returns>Paquete de información de tipo CertificadoInfo</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetDetail(ByVal sessionID As GUID, ByVal idCertificado As Integer, ByVal checkStatus As Boolean) As CertificadoInfo
        Dim CertificadoSvc As New CertificadoService(sessionID)
        Dim CertificadoInf As New CertificadoInfo(sessionID)
        GetDetail(CertificadoSvc, CertificadoInf, idCertificado, checkStatus)
        Return CertificadoInf
    End Function

    ''' <summary>
    ''' Obtiene la información de un Certificado en base a su codigo de usuario
    ''' y verifica que el Certificado esté activo.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Código de usuario a buscar</param>
    ''' <returns>Paquete de información CertificadoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer) As CertificadoInfo
        Return Me.GetDetail(sessionID, userCode, idSucursal, True)
    End Function

    ''' <summary>
    ''' Obtiene la información de un Certificado en base a su codigo de usuario
    ''' </summary>
    ''' <param name="sessionID">ID de sesión</param>
    ''' <param name="userCode">Codigo de usuario a buscar</param>
    ''' <param name="checkStatus">Indica si se debe checar el status del Certificado</param>
    ''' <returns>Paquete de información CertificadoInfo</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetDetail(ByVal sessionID As GUID, ByVal userCode As String, ByVal idSucursal As Integer, ByVal checkStatus As Boolean) As CertificadoInfo
        Dim CertificadoInf As New CertificadoInfo(sessionID)
        Dim CertificadoSvc As New CertificadoService(sessionID)
        GetDetail(CertificadoSvc, CertificadoInf, userCode, idSucursal, checkStatus)
        Return CertificadoInf
    End Function

    ''' <summary>
    ''' Actualiza la información de un Certificado.
    ''' </summary>
    ''' <param name="Certificado">Paquete de información del tipo CertificadoInfo con la información a actualizar</param>
    ''' <returns>Identificador de Certificado, si es nuevo, regresa el Id asignado.</returns>
    ''' <remarks></remarks>
    Public Overrides Function Update(ByVal Certificado As CertificadoInfo) As Integer
        Dim CertificadoSvc As New CertificadoService(Certificado.SessionID)
        Return Update(CertificadoSvc, Certificado)
    End Function

    ''' <summary>
    ''' Obtiene el número de páginas de la búsqueda solicitaa.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la operación</param>
    ''' <param name="conditions">Colección de condiciones de la búsqueda</param>
    ''' <returns>Número de páginas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetNumberOfPages(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection) As Integer
        Dim CertificadoSvc As New CertificadoService(sessionID)
        Return GetNumberOfPages(CertificadoSvc, idSite, conditions)
    End Function

    ''' <summary>
    ''' Busca CFDCertificados que coincidan con las condiciones especificadas.
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
    ''' Busca CFDCertificados que coincidan con las condiciones especificadas.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <param name="conditions">Colección de condiciones</param>
    ''' <param name="order">Orden en que se devolverá el conjunto resultante</param>
    ''' <param name="page">Número de página que se devolverá</param>
    ''' <returns>Dataset con las filas del resultado de la búsqueda.</returns>
    ''' <remarks></remarks>
    Public Overloads Overrides Function GetSearchResult(ByVal sessionID As GUID, ByVal idSite As Integer, ByVal conditions As SearchConditionCollection, ByVal order As SearchOrderCollection, ByVal page As Integer) As System.Data.DataSet
        Dim CertificadoSvc As New CertificadoService(sessionID)
        Return GetSearchResult(CertificadoSvc, idSite, conditions, order, page)
    End Function

    ''' <summary>
    ''' Obtiene la estructura de búsqueda del catálogo de CFDCertificados.
    ''' </summary>
    ''' <param name="sessionID">ID de sesión que autoriza la llamada</param>
    ''' <returns>Dataset con la estructra de columnas del conjunto de búsuqeda</returns>
    ''' <remarks></remarks>
    Public Overrides Function GetSearchStructure(ByVal sessionID As GUID) As System.Data.DataSet
        Dim CertificadoSvc As New CertificadoService(sessionID)
        Return GetSearchStructure(CertificadoSvc)
    End Function

#End Region

End Class

<Serializable()> _
Public Enum FormatoCFD
    CFD = 1
    CFDI = 2
End Enum
