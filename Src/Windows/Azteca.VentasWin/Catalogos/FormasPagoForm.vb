Public Class FormasPagoForm


    Private Sub FormasPagoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormasPagoForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim FormaPago As FormaPagoInfo = CType(PackageInfo, FormaPagoInfo)
        With FormaPago
            txtNombre.Text = .Nombre
        End With
    End Sub

    Private Sub FormasPagoForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim FormaPago As FormaPagoInfo = CType(PackageInfo, FormaPagoInfo)
        With FormaPago
            .Nombre = txtNombre.Text
        End With
    End Sub

End Class