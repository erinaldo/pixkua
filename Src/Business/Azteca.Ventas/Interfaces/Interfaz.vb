Imports System.Data.SqlClient
Imports Azteca.Kernel.Security


Public Class InterfazService

    Private Connection As IDbConnection
    Private Transaction As IDbTransaction
    Private Session As Azteca.Kernel.Security.UsuarioInfo

#Region "Constructores"
    Public Sub New(ByVal sessionID As Guid)
        Me.New(sessionID, Nothing, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection)
        Me.New(sessionID, cnn, Nothing)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal cnn As IDbConnection, ByVal tran As IDbTransaction)
        Me.Session = Session
        Me.Connection = cnn
        Me.Transaction = tran
    End Sub
#End Region

    Public Function GetVentasByPeriodo(ByVal idSegmento As Integer) As DataTable

        Dim TiposPeriodos As New DataTable

        Try

            'Obtener cadena de conexión a base de datos de Nomipaq
            Dim CnnStr As String = GetSegConnectionString(idSegmento)
            'Abrir conexión a base de datos
            If (CnnStr IsNot String.Empty) Then
                Dim Cnn As New SqlConnection(CnnStr)

                Try

                    Cnn.Open()
                    Dim comm As New SqlClient.SqlCommand
                    comm.Connection = Cnn
                    comm.CommandType = CommandType.Text
                    comm.CommandText = "select * from MGW10026"

                    Dim sqlAdapter As New SqlDataAdapter(comm.CommandText, Cnn)
                    sqlAdapter.Fill(TiposPeriodos)

                Catch ex As Exception
                    Throw New BusinessException("Error al obtener informacion de ADMINPAQ: " & ex.Message.ToString() & vbCrLf & "Segmento: " & idSegmento.ToString(), ex)
                Finally
                    Cnn.Close()
                End Try

            End If
            Return TiposPeriodos
        Catch ex As Exception
            Throw New BusinessException("Error de conexion con NOMIPAQ: " & ex.Message.ToString(), ex)
        End Try

    End Function

    Private Function GetSegConnectionString(idSegmento As Integer) As String
        Try
            Dim sqlSegmento As New SentenceSQL("SELECT CnnStrInterfaz FROM dbo.Segmentos WHERE IdSegmento=@IdSegmento", Connection, Transaction)
            sqlSegmento.Parameters.Add("@IdSegmento", DbType.Int32).Value = idSegmento
            Dim CnnStr As String = sqlSegmento.GetScalar().ToString()
            Return CnnStr
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la cadena de conexión del segmento.", ex)
        End Try
    End Function

End Class

Public Class InterfazFacade

    Private Connection As IDbConnection
    Private Transaction As IDbTransaction
    Private Session As Azteca.Kernel.Security.UsuarioInfo

#Region "Metodos Privados"

    Public Function ValidateSession(ByVal sessionID As Guid) As Boolean
        If sessionID = Guid.Empty Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub HandleException(ByVal ex As Exception)
        Throw ex
    End Sub
#End Region

    Public Function GetVentasByPeriodo(sessionID As Guid, ByVal idSegmento As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtTiposPeriodos As New DataTable
        Try
            Me.Connection = DataServices.OpenConnection
            Dim InterfaseSvc As New InterfazService(sessionID, Me.Connection)
            dtTiposPeriodos = InterfaseSvc.GetVentasByPeriodo(idSegmento)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Me.Connection)
        End Try
        Return dtTiposPeriodos
    End Function

End Class


