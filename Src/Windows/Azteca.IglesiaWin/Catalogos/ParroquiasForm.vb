Public Class ParroquiasForm

    Private Sub ParroquiasForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        chkActivo.Checked = True
    End Sub

    Private Sub ParroquiasForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ParroquiasForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim ParroquiaInfo As ParroquiaInfo = CType(PackageInfo, ParroquiaInfo)
            With ParroquiaInfo
                'Datos Personales
                txtNombre.Text = .Nombre
                txtTelefono.Text = .Telefono
                txtCorreo.Text = .Correo
                txtCalle.Text = .Calle
                txtNumExt.Text = .NumExt
                txtNumInt.Text = .NumInt
                txtColonia.Text = .Colonia
                txtCP.Text = .CP
                chkActivo.Checked = CBool(IIf(.Status = CatalogState.Active, True, False))
                txtPoblacion.Text = CStr(.IdPoblacion)
                txtPoblacion.LoadInfo()

                'Adicionales
                txtRFC.Text = .RFC
                txtRazonSocial.Text = .RazonSocial
                txtFax.Text = .Fax
                txtPaginaWeb.Text = .PagWeb
                SacerdoteSel.Text = CStr(.IdSacerdote)
                SacerdoteSel.LoadInfo()
                txtNumero.Text = .Numero
            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ParroquiasForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim ParroquiaInfo As ParroquiaInfo = CType(PackageInfo, ParroquiaInfo)
            With ParroquiaInfo
                'Datos Personales
                .Nombre = txtNombre.Text
                .Telefono = txtTelefono.Text
                .Correo = txtCorreo.Text
                .Calle = txtCalle.Text
                .NumExt = txtNumExt.Text
                .NumInt = txtNumInt.Text
                .Colonia = txtColonia.Text
                .CP = txtCP.Text
                .Status = CType(IIf(chkActivo.Checked, CatalogState.Active, CatalogState.Inactive), CatalogState)
                .IdPoblacion = txtPoblacion.Key

                'Adicionales
                .RFC = txtRFC.Text
                .RazonSocial = txtRazonSocial.Text
                .Fax = txtFax.Text
                .PagWeb = txtPaginaWeb.Text
                .IdSacerdote = SacerdoteSel.Key
                .Arquidiocesis = txtArquidiocesis.Text
                .Numero = txtNumero.Text
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