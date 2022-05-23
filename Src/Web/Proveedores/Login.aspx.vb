Imports Azteca.Business.Compras

Partial Class Login
    Inherits System.Web.UI.Page

    Private PixcuaSession As Azteca.Kernel.Security.SessionInfo


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PixcuaSession = CType(Application("Session"), Azteca.Kernel.Security.SessionInfo)
        lblError.Text = String.Empty
    End Sub


    Protected Sub Login1_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles Login1.Authenticate
        Try
            Dim ProveedorFac As New ProveedorFacade
            If ProveedorFac.Login(1, Login1.UserName, Login1.Password) Then
                Session("CodigoProveedor") = Login1.UserName.Trim
                e.Authenticated = True
                'Cargar información del proveedor
                Dim ProveedorInf As ProveedorInfo = ProveedorFac.GetDetail(PixcuaSession.SessionID, Login1.UserName, 1)
                Session("Proveedor") = ProveedorInf
            End If
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

End Class
