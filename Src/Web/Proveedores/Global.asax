<%@ Application Language="VB" %>

<script runat="server">
    
    Private Function GetProvider(ByVal provider As String) As Azteca.Data.DataProvider
        Select Case provider.ToLower
            Case "sql"
                Return Azteca.Data.DataProvider.Sql
            Case "oledb"
                Return Azteca.Data.DataProvider.OleDb
            Case "oracle"
                Return Azteca.Data.DataProvider.Oracle
            Case "odbc"
                Return Azteca.Data.DataProvider.Odbc
            Case Else
                Return Azteca.Data.DataProvider.OleDb
        End Select
    End Function


    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Azteca.Kernel.Server.Initialize("Pixkua Server", True, "C:\Desarrollo\Pixkua\Src\Web\Proveedores", "C:\Desarrollo\Pixkua\Src\Web\Proveedores\App_Data", Azteca.Kernel.SessionRepository.Database)
            '
            Dim UsuarioFac As New Azteca.Kernel.Security.UsuarioFacade
            Dim Session As Azteca.Kernel.Security.SessionInfo = UsuarioFac.LogIn("admin", "", "Web Server")
            If session Is Nothing Then
                Throw New Azteca.Kernel.Security.SecurityAccessException("Error al iniciar sesión en pixkua con el usuario 'admin'")
            Else
                Application("Session") = session
            End If
        Catch ex As Exception
            System.Diagnostics.EventLog.WriteEntry("Pixkua", ex.ToString, Diagnostics.EventLogEntryType.Error)
        End Try
    End Sub
    
    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application shutdown
    End Sub
        
    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when an unhandled error occurs
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a new session is started
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a session ends. 
        ' Note: The Session_End event is raised only when the sessionstate mode
        ' is set to InProc in the Web.config file. If session mode is set to StateServer 
        ' or SQLServer, the event is not raised.
    End Sub
       
</script>