Public Class ConceptosNotasForm

    Private Sub ConceptosNotasForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
    End Sub

    Private Sub ConceptosNotasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ConceptosNotasForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Concepto As ConceptoNotaInfo = CType(PackageInfo, ConceptoNotaInfo)
        With Concepto
            txtNombre.Text = .Nombre
            txtCuenta.Text = String.Empty
            chkLibre.Checked = .ConceptoLibre
            If .IdCuenta > 0 Then txtCuenta.LoadInfo(.IdCuenta)
        End With
    End Sub

    Private Sub ConceptosNotasForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Concepto As ConceptoNotaInfo = CType(PackageInfo, ConceptoNotaInfo)
        With Concepto
            .Nombre = txtNombre.Text
            .IdCuenta = txtCuenta.Key
            .ConceptoLibre = chkLibre.Checked
        End With
    End Sub

End Class