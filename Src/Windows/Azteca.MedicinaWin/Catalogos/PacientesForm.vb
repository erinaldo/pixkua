Public Class PacientesForm

    Protected Overrides Function IsValid() As Boolean
        If txtRFC.Text = String.Empty And chkFacturable.Checked Then
            MessageBox.Show("Debe introducir el RFC del cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRFC.Focus()
            Return False
        ElseIf txtRazonSocial.Text = String.Empty And chkFacturable.Checked Then
            MessageBox.Show("Debe introducir la Razón Social.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRazonSocial.Focus()
            Return False
        ElseIf txtCalleFis.Text = String.Empty And chkFacturable.Checked Then
            MessageBox.Show("Debe capturar la calle", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCalleFis.Focus()
            Return False
        ElseIf txtColoniaFis.Text = String.Empty And chkFacturable.Checked Then
            MessageBox.Show("Debe capturar la colonia", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtColoniaFis.Focus()
            Return False
        ElseIf txtNumExtFis.Text = String.Empty And chkFacturable.Checked Then
            MessageBox.Show("Debe capturar el numero exterior", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNumExtFis.Focus()
            Return False
        ElseIf txtCPFis.Text = String.Empty And chkFacturable.Checked Then
            MessageBox.Show("Debe capturar el codigo postal", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCPFis.Focus()
            Return False
        ElseIf txtPoblacionFis.Key = 0 And chkFacturable.Checked Then
            MessageBox.Show("Debe elegir la población fiscal", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPoblacionFis.Focus()
            Return False
        ElseIf txtCorreo.Text.Trim.Length = 0 And chkFacturable.Checked Then
            MessageBox.Show("Debe capturar el correo electronico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCorreo.Focus()
            Return False
        Else
            Return MyBase.IsValid()
        End If

    End Function

    Private Sub PacientesForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        selListaPrecios.LoadInfo(1)
    End Sub


    Private Sub ClientesForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Paciente As PacienteInfo = CType(PackageInfo, PacienteInfo)

        dtpFechaNac.Value = Paciente.FechaNacimiento
        chkAfiliado.Checked = Paciente.Afiliado
        rbFemenino.Checked = IIf(Paciente.Sexo = SexoEnum.Femenino, True, False)
        txtTel.Text = Paciente.Ocupacion

        With Paciente.Cliente
            'General
            txtNombre.Text = .Nombre
            txtTel.Text = .Telefonos
            'txtFax.Text = .Fax
            txtCorreo.Text = .Correo
            'txtPagWeb.Text = .PagWeb

            ''Domicilio
            txtCalle.Text = .Calle
            txtNumExt.Text = .NumExt
            txtNumInt.Text = .NumInt
            txtColonia.Text = .Colonia
            txtCodPos.Text = .CP
            txtPoblacion.Text = String.Empty
            If .IdPoblacion > 0 Then txtPoblacion.LoadInfo(.IdPoblacion)

            ''Datos Fiscales
            txtRFC.Text = .RFC
            txtRazonSocial.Text = .RazonSocial
            chkFacturable.Checked = .Facturable

            txtCalleFis.Text = .CalleFiscal
            txtNumExtFis.Text = .NumExtFiscal
            txtNumIntFis.Text = .NumIntFiscal
            txtColoniaFis.Text = .ColoniaFiscal
            txtCPFis.Text = .CPFiscal
            txtPoblacionFis.Text = String.Empty
            If .IdPoblacionFiscal > 0 Then txtPoblacionFis.LoadInfo(.IdPoblacionFiscal)
            ''cboAddenda.SelectedValue = .IdComprobanteAddenda
            ''txtGLN.Text = .GLN
            ''txtGLNTienda.Text = .GLNTienda
            ''txtNumProveedor.Text = .NumProveedor.ToString

            ''Ventas
            If .IdListaPrecio > 0 Then selListaPrecios.LoadInfo(.IdListaPrecio)
            ' ''If .IdGrupoDescuentos > 0 Then selGrupoDescuentos.LoadInfo(.IdGrupoDescuentos)
            'If .CondicionesPago = CondicionesPago.Contado Then
            '    rdbContado.Checked = True
            ''Else
            ' ''    rdbCredito.Checked = True
            'End If
            'txtLimiteCredito.Text = .LimiteCredito.ToString
            'txtDiasCredito.Text = .DiasCredito.ToString
            'txtSaldoCredito.Text = .SaldoCredito.ToString
            'cboMetodoPago.SelectedValue = .IdMetodoPago
            'txtCuentaPago.Text = .CuentaPago
            ''Contactos
            'bsContactos.DataSource = .Contactos
            'grdContactos.Rebind(True)
            ''Contabilidad
            'If .IdCuentaContable > 0 Then txtCuenta.LoadInfo(.IdCuentaContable)

            ' ''CargarGruposClasificaciones(.Identity)
        End With
    End Sub

    Private Sub ClienteExpressForm_SavingItem(sender As Object, e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Paciente As PacienteInfo = CType(PackageInfo, PacienteInfo)

        Paciente.FechaNacimiento = dtpFechaNac.Value
        Paciente.Afiliado = chkAfiliado.Checked
        If rbFemenino.Checked Then
            Paciente.Sexo = SexoEnum.Femenino
        Else
            Paciente.Sexo = SexoEnum.Masculino
        End If
        Paciente.Ocupacion = txtTel.Text

        With Paciente.Cliente
            'General
            .Nombre = txtNombre.Text
            .Telefonos = txtTel.Text
            .Fax = "" ''''txtFax.Text
            .Correo = txtCorreo.Text
            .PagWeb = "" ''''txtPagWeb.Text

            'Domicilio
            .Calle = txtCalle.Text
            .Cruce1 = String.Empty
            .Cruce2 = String.Empty
            .NumExt = txtNumExt.Text
            .NumInt = txtNumInt.Text
            .Colonia = txtColonia.Text
            .CP = txtCodPos.Text
            .IdPoblacion = txtPoblacion.Key
            .Latitud = 0
            .Longitud = 0
            'Facturacion
            .Facturable = chkFacturable.Checked
            .RFC = txtRFC.Text
            .RazonSocial = txtRazonSocial.Text
            .CalleFiscal = txtCalleFis.Text
            .NumExtFiscal = txtNumExtFis.Text
            .NumIntFiscal = txtNumIntFis.Text
            .ColoniaFiscal = txtColoniaFis.Text
            .CPFiscal = txtCPFis.Text
            .IdPoblacionFiscal = txtPoblacionFis.Key
            '.IdComprobanteAddenda = CInt(cboAddenda.SelectedValue)
            '.GLN = txtGLN.Text
            '.GLNTienda = txtGLNTienda.Text
            '.NumProveedor = CInt(Val(txtNumProveedor.Text))
            'Ventas
            ''''If rdbContado.Checked Then
            '.CondicionesPago = CondicionesPago.Contado
            ''''Else
            ''''.CondicionesPago = CondicionesPago.Credito
            ''''End If
            .IdListaPrecio = selListaPrecios.Key
            '.IdGrupoDescuentos = 0 ''''selGrupoDescuentos.Key
            '.IdGama = 0
            '.LimiteCredito = 0 ''''CDec(Val(txtLimiteCredito.Text))
            '.DiasCredito = 0 ''''CInt(Val(txtDiasCredito.Text))
            '.IdMetodoPago = CInt(cboMetodoPago.SelectedValue)
            '.CuentaPago = txtCuentaPago.Text
            'Contabilidad
            '.IdCuentaContable = 0 ''''txtCuenta.Key
            '.WebPassword = String.Empty
            .IdEmpresa = App.DefaultCompany.Identity
            .IdSucursal = App.DefaultSite.Identity
        End With
    End Sub

    Private Sub txtCopiar_Click(sender As System.Object, e As System.EventArgs) Handles txtCopiar.Click
        txtCalleFis.Text = txtCalle.Text
        txtNumExtFis.Text = txtNumExt.Text
        txtNumIntFis.Text = txtNumInt.Text
        txtColoniaFis.Text = txtColonia.Text
        txtPoblacionFis.LoadInfo(txtPoblacion.Key)
        txtCPFis.Text = txtCodPos.Text
    End Sub


    Private Sub CiButton1_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New PacienteSearch
        frm.ShowDialog()
    End Sub


End Class