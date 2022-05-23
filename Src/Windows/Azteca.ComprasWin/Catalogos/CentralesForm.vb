Public Class CentralesForm

    Private Sub CentralesForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem

    End Sub

    Private Sub CentralesForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As CentralInfo = CType(Me.PackageInfo, CentralInfo)
        With info
            txtNombre.Text = .Nombre
            cboZona.SelectedValue = .IdZonaCompra
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)
            cboRemitente.SelectedValue = .IdRemitente
            cboCaja.SelectedValue = .IdCaja
            cboOperador.SelectedValue = .IdOperador
            chkNotificarOC.Checked = .NotificarOC
            chkEnviarOC.Checked = .EnviarOC
        End With
    End Sub

    Private Sub CentralesForm_LoadingLists(sender As Object, e As System.EventArgs) Handles Me.LoadingLists
        cboOperador.LoadList()
        cboRemitente.LoadList()
        cboCaja.LoadList()
        cboZona.LoadList(App.DefaultCompany.Identity)
    End Sub

    Private Sub CentralesForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As CentralInfo = CType(Me.PackageInfo, CentralInfo)
        With info
            .Nombre = txtNombre.Text
            .IdZonaCompra = CInt(cboZona.SelectedValue)
            .IdCuenta = selCuenta.Key
            .IdCaja = CInt(cboCaja.SelectedValue)
            .IdRemitente = CInt(cboRemitente.SelectedValue)
            .IdOperador = CInt(cboOperador.SelectedValue)
            .NotificarOC = chkNotificarOC.Checked
            .EnviarOC = chkEnviarOC.Checked
        End With
    End Sub

    Private Sub CentralesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class