Public Class ImporteForm

    Private Sub ImporteForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try

            Dim info As ImporteInfo = CType(Me.PackageInfo, ImporteInfo)
            With info
                txtDescripcion.Text = .Descripcion
                txtImporte.Text = .Importe
            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub ImporteForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim info As ImporteInfo = CType(Me.PackageInfo, ImporteInfo)
            With info
                .Descripcion = txtDescripcion.Text
                .Importe = txtImporte.Text
            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub
End Class