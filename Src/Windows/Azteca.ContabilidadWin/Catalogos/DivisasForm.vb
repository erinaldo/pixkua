Public Class DivisasForm

    Private Sub DivisasForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
    End Sub

    Private Sub DivisasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DivisasForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Divisa As DivisaInfo = CType(PackageInfo, DivisaInfo)
        With Divisa
            txtNombre.Text = .Nombre
            txtAbreviatura.Text = .Abreviatura
            txtTipo.Text = .Tipo
            txtSerie.Text = .SerieBanxico
        End With
    End Sub

    Private Sub DivisasForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Divisa As DivisaInfo = CType(PackageInfo, DivisaInfo)
        With Divisa
            .Nombre = txtNombre.Text
            .Abreviatura = txtAbreviatura.Text
            .SerieBanxico = txtSerie.Text
            .Tipo = txtTipo.Text
        End With
    End Sub

End Class