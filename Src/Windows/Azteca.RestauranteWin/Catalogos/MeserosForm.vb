Public Class MeserosForm

    Private Sub MeserosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As MeseroInfo = CType(Me.PackageInfo, MeseroInfo)
        With info
            selUsuario.LoadInfo(.IdUsuario)
            selCuenta.LoadInfo(.IdCuenta)
            txtNombreCorto.Text = .NombreCorto
            picMngrImage.SetImageBytes(.Fotografia)
           
        End With
    End Sub

    Private Sub MeserosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As MeseroInfo = CType(Me.PackageInfo, MeseroInfo)
        With info
            .IdUsuario = selUsuario.Key
            .IdCuenta = selCuenta.Key
            .Fotografia = picMngrImage.GetImageBytes
            .NombreCorto = txtNombreCorto.Text
            
        End With

    End Sub

End Class