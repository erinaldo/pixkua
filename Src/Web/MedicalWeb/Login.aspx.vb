Imports Azteca.Kernel.Security

Public Class Login
    Inherits System.Web.UI.Page

    Private Sesion As SessionInfo

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Try
            Dim UsuarioFac As New UsuarioFacade
            Sesion = UsuarioFac.FindSession(Guid.Parse(hdnSessionID.Value))
            If Sesion IsNot Nothing Then
                Session.Add("Sesion", Sesion)
                ''Cargar información de la empresa y sucursal seleccionadas
                CargarEmpresa()
                CargarSucursal()
                FormsAuthentication.RedirectFromLoginPage(txtNombre.Text, False)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarEmpresa()
        Dim EmpresaFac As New EmpresaFacade()
        Dim Empresa As EmpresaInfo = EmpresaFac.GetDetail(Sesion.SessionID, Integer.Parse(hdnIdEmpresa.Value), False)
        Session.Add("DefaultCompany", Empresa)
    End Sub

    Private Sub CargarSucursal()
        Dim SucursalFac As New SucursalFacade()
        Dim Sucursal As SucursalInfo = SucursalFac.GetDetail(Sesion.SessionID, Integer.Parse(hdnIdSucursal.Value), False)
        Session.Add("DefaultBranch", Sucursal)
    End Sub

End Class