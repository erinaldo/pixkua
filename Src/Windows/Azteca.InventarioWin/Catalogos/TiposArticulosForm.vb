Public Class TiposArticulosForm

    Private Sub TiposArticulosForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TiposArticulosForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As TipoInfo = CType(Me.PackageInfo, TipoInfo)
        With info
            txtNombre.Text = .Nombre
        End With
    End Sub

    Private Sub TiposArticulosForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As TipoInfo = CType(Me.PackageInfo, TipoInfo)
        With info
            .Nombre = txtNombre.Text
        End With
    End Sub
End Class