Public Class FlujoForm

    Private Sub FlujoForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FlujoForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As FlujoInfo = CType(PackageInfo, FlujoInfo)
        With info
            txtNombre.Text = .Nombre
            cboTipo.SelectedText = .Tipo
            If .IdPadre > 0 Then
                selPadre.LoadInfo(.IdPadre)
            Else
                selPadre.Text = String.Empty
            End If
            txtPath.Text = .NamedPath
            txtNivel.Text = .Nivel.ToString
            txtNombre.Focus()
        End With
        txtNombre.Focus()
    End Sub


    Private Sub FlujoForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As FlujoInfo = CType(PackageInfo, FlujoInfo)
        With info
            .Nombre = txtNombre.Text
            .IdPadre = selPadre.Key
            .Tipo = cboTipo.SelectedText
        End With
    End Sub
End Class