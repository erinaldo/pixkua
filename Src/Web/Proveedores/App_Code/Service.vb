Imports Azteca.Business.Compras
Imports System.Web

Public Class Service
    Implements IService

    Dim PixcuaSession As Azteca.Kernel.Security.SessionInfo


    Public Sub EnviarCFD(ByVal codigoProveedor As String, ByVal password As String, ByVal cfd As String) Implements IService.EnviarCFD
        Try
            PixcuaSession = CType(HttpContext.Current.Application("Session"), Azteca.Kernel.Security.SessionInfo)
            Dim Factura As New ComprobanteFiscalFacade
            Factura.Save(PixcuaSession.SessionID, 1, cfd)

        Catch ex As System.Exception
            Throw ex
        End Try
    End Sub

End Class
