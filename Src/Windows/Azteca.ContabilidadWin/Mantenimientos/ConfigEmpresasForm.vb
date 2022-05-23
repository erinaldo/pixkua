Public Class ConfigEmpresasForm
    Private Configuracion As SucursalesConfigDS.SucursalesDataTable

    Private Sub ConfigEmpresasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim SucursalConfig As New SucursalConfigFacade
            Configuracion = SucursalConfig.CargarConfiguraciones(App.Session.SessionID, App.DefaultCompany.Identity)
            bsEmpresas.DataSource = Configuracion
            grdEmpresas.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
            Close()
        End Try

    End Sub
End Class