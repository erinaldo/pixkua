Public Class IncidenciasForm

    Private Sub IncidenciasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboTipoIncidencia.LoadList()
    End Sub

    Private Sub IncidenciasForm_LoadingItem(ByVal sender As System.Object, ByVal e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles MyBase.LoadingItem
        Try
            Dim info As IncidenciaInfo = CType(Me.PackageInfo, IncidenciaInfo)

            With info
                txtNombre.Text = info.Nombre
                cboTipoIncidencia.SelectedValue = info.IdTipoIncidencia

            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub IncidenciasForm_SavingItem(ByVal sender As System.Object, ByVal e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles MyBase.SavingItem
        Try
            Dim info As IncidenciaInfo = CType(Me.PackageInfo, IncidenciaInfo)

            With info
                info.Nombre = txtNombre.Text
                info.IdTipoIncidencia = CInt(cboTipoIncidencia.SelectedValue)
                info.IdCuenta = 0
            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class