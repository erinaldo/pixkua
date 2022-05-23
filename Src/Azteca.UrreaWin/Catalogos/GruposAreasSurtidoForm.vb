Imports Azteca.Business.Urrea
Imports Azteca.Windows.Forms

Public Class GruposAreasSurtidoForm

    Private Sub GruposAreasSurtidoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GruposAreasSurtidoForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim grupoInfo As GrupoAreaSurtidoInfo = CType(PackageInfo, GrupoAreaSurtidoInfo)
            txtNombre.Text = grupoInfo.Nombre
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub GruposAreasSurtidoForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim grupoInfo As GrupoAreaSurtidoInfo = CType(PackageInfo, GrupoAreaSurtidoInfo)
            grupoInfo.Nombre = txtNombre.Text
            grupoInfo.IdSucursal = App.DefaultSite.Identity
            grupoInfo.IdEmpresa = App.DefaultCompany.Identity

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class