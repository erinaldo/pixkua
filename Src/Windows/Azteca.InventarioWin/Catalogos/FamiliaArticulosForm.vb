Public Class FamiliaArticulosForm

    Private Sub FamiliaArticulosForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FamiliaArticulosForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As FamiliaInfo = CType(Me.PackageInfo, FamiliaInfo)
        With info
            txtNombre.Text = .Nombre
        End With
    End Sub

    Private Sub FamiliaArticulosForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As FamiliaInfo = CType(Me.PackageInfo, FamiliaInfo)
        With info
            .Nombre = txtNombre.Text
        End With
    End Sub
End Class