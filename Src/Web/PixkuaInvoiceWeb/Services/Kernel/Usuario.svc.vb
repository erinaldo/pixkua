Imports Azteca.Kernel.Security

Namespace Services.Kernel


    Public Class Usuario
        Implements IUsuario

        Public Function Login(userName As String, password As String) As String Implements IUsuario.Login
            Try
                Dim UsuarioFac As New UsuarioFacade()
                Dim Sesssion As SessionInfo = UsuarioFac.LogIn(userName, password, String.Empty)
                If Sesssion Is Nothing Then
                    Throw New Exception("Nombre de usuario o password incorrectos")
                Else
                    Return JsonConvert.SerializeObject(Sesssion)
                End If
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function


    End Class

End Namespace