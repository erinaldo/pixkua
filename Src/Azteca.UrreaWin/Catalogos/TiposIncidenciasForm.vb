Public Class TiposIncidenciasForm

    Private Sub TiposIncidenciasForm_LoadingItem(ByVal sender As System.Object, ByVal e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles MyBase.LoadingItem
        Try
            Dim info As TipoIncidenciaInfo = CType(Me.PackageInfo, TipoIncidenciaInfo)

            With info
                txtNombre.Text = .Nombre


            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub TiposIncidenciasForm_SavingItem(ByVal sender As System.Object, ByVal e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles MyBase.SavingItem
        Try
            Dim info As TipoIncidenciaInfo = CType(Me.PackageInfo, TipoIncidenciaInfo)
            With info
                info.Nombre = txtNombre.Text


            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class