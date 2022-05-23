Imports Azteca.Kernel.Security

Public Class Login
    Inherits BasePage

    Private Sesion As SessionInfo

    Private Sub CargarEmpresa()
        Dim EmpresaFac As New EmpresaFacade
        Dim Empresa As EmpresaInfo = EmpresaFac.GetDetail(Sesion.SessionID, CInt(hdnIdEmpresa.Value))
        Session.Add("DefaultCompany", Empresa)
    End Sub

    Private Sub CargarSucursal()
        Dim SucursalFac As New SucursalFacade
        Dim Sucursal As SucursalInfo = SucursalFac.GetDetail(Sesion.SessionID, CInt(hdnIdSucursal.Value))
        Session.Add("DefaultBranch", Sucursal)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnIniciarSesion_Click(sender As Object, e As EventArgs)
        Try
            Dim UsuarioFac As New UsuarioFacade
            Sesion = UsuarioFac.FindSession(Guid.Parse(hdnSessionID.Value))
            If Sesion IsNot Nothing Then
                Session.Add("Sesion", Sesion)
                CargarEmpresa()
                CargarSucursal()
                FormsAuthentication.RedirectFromLoginPage(txtNombre.Text, False)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnSelectSucursal_Click(sender As Object, e As EventArgs)
        Try
            Dim UsuarioFac As New UsuarioFacade
            Sesion = UsuarioFac.FindSession(Guid.Parse(hdnSessionID.Value))
            If Sesion IsNot Nothing Then
                Session.Add("Sesion", Sesion)
                CargarEmpresa()
                CargarSucursal()
                FormsAuthentication.RedirectFromLoginPage(txtNombre.Text, False)
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class