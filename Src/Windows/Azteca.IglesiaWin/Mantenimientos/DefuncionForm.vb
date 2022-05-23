Public Class DefuncionForm

    Private Sub DefuncionForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        txtPoblacion.LoadInfo()
    End Sub

    Private Sub DefuncionForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DefuncionForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim DefuncionInfo = CType(PackageInfo, DefuncionInfo)

            With DefuncionInfo
                txtLibro.Text = .Libro
                txtPagina.Text = .Pagina
                txtActa.Text = .Acta
                dtpFechaDefuncion.Value = .Fecha
                txtSolicitante.LoadInfo(.IdSolicitante)

                txtFamiliaresSobreviven.Text = .FamiliaresSobreviven
                txtCausaFallecimiento.Text = .Causa
                txtSepultadoEn.Text = .DomicilioSepultura
                txtSacerdote.Text = CStr(.IdSacerdote)
                txtSacerdote.LoadInfo()
                chkReconciliacion.Checked = .Reconcialiacion
                chkViatico.Checked = .Viatico
                chkUncionEnfermos.Checked = .UncionEnfermos
                txtActaCivilDefuncion.Text = .ActaCivilDefuncion
                txtPoblacion.Text = CStr(.IdPoblacionDefuncion)
                txtPoblacion.LoadInfo()
            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub DefuncionForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim DefuncionInfo = CType(PackageInfo, DefuncionInfo)

            With DefuncionInfo
                .Libro = txtLibro.Text
                .Pagina = txtPagina.Text
                .Acta = txtActa.Text
                .Fecha = dtpFechaDefuncion.Value

                .IdSolicitante = txtSolicitante.Key
                .FamiliaresSobreviven = txtFamiliaresSobreviven.Text
                .Causa = txtCausaFallecimiento.Text
                .DomicilioSepultura = txtSepultadoEn.Text
                .IdSacerdote = txtSacerdote.Key
                .Reconcialiacion = chkReconciliacion.Checked
                .Viatico = chkViatico.Checked
                .UncionEnfermos = chkUncionEnfermos.Checked
                If (Trim(txtActaCivilDefuncion.Text) <> "") Then
                    .ActaCivilDefuncion = CInt(txtActaCivilDefuncion.Text)
                Else
                    .ActaCivilDefuncion = 0
                End If

                .IdPoblacionDefuncion = txtPoblacion.Key
            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub txtPoblacion_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles txtPoblacion.InfoLoaded
        Dim poblacion As Azteca.Kernel.General.PoblacionInfo = CType(txtPoblacion.PackageInfo, Azteca.Kernel.General.PoblacionInfo)
        lblEstadoInf.Text = poblacion.Estado
    End Sub
End Class