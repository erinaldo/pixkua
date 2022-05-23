Public Class ProveedoresExpressForm

    Private Sub ProveedoresExpressForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
    End Sub

    Private Sub ProveedoresExpressForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Proveedor As ProveedorInfo = CType(PackageInfo, ProveedorInfo)
        With Proveedor
            ''GENERAL
            'txtNombre.Text = .Nombre
            'txtRFC.Text = .RFC
            'txtTelefono.Text = .Telefono
            'txtFax.Text = .Fax
            'txtCorreo.Text = .Correo
            'txtURL.Text = .PaginaWeb
            'txtCuenta.Text = String.Empty
            'txtPassword.Text = .WebPassword
            'nudDiasEntrega.Value = .DiasEntrega
            'chkActivo.Checked = (.Status = Kernel.BusinessStructure.CatalogState.Active)
            ''DOMICILIO
            'txtCalle.Text = .Calle
            'txtNumInt.Text = .NumInt
            'txtNumExt.Text = .NumExt
            'txtColonia.Text = .Colonia
            'txtPoblacion.LoadInfo(.IdPoblacion)
            'txtCP.Text = .CP
            'FACTURACION
            txtRFC.Text = .RFC
            txtRazonSocial.Text = .RazonSocial
            txtCalleFIS.Text = .CalleFiscal
            txtNumExtFIS.Text = .NumExtFiscal
            txtNumIntFIS.Text = .NumIntFiscal
            txtColoniaFIS.Text = .ColoniaFiscal
            txtCPFis.Text = .CPFiscal
            txtPoblacionFIS.LoadInfo(.IdPoblacionFiscal)
            chkFactElectronica.Checked = .FacturaElectronica
            ''CREDITO
            'If .PagoAnticipado Then
            '    rdbAdelantado.Checked = True
            'Else
            '    If .DiasCredito > 0 Then
            '        rdbCredito.Checked = True
            '    Else
            '        rdbContado.Checked = True
            '    End If
            'End If
            'txtLimiteCredito.Text = .LimiteCredito.ToString
            'txtSaldo.Text = .Saldo.ToString("$#;##0.00")
            'nudDiasCredito.Value = .DiasCredito
            ''
            'bsContactos.DataSource = .Contactos
            'grdContactos.Rebind(True)
            'grdZonas.Rebind(True)
            'If .IdCuentaContable > 0 Then txtCuenta.LoadInfo(.IdCuentaContable)
        End With
    End Sub

    Private Sub ProveedoresExpressForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Proveedor As ProveedorInfo = CType(PackageInfo, ProveedorInfo)
        With Proveedor
            'GENERAL
            .Nombre = txtRazonSocial.Text 'txtNombre.Text
            .Telefono = "" ' txtTelefono.Text
            .Fax = "" ' txtFax.Text
            .Correo = "" 'txtCorreo.Text
            .PaginaWeb = "" 'txtURL.Text
            .IdCuentaContable = 0 ' txtCuenta.Key
            .WebPassword = "" 'txtPassword.Text
            .DiasEntrega = 0 'CInt(nudDiasEntrega.Value)
 
            'DOMICILIO
            .Calle = txtCalleFIS.Text
            .NumInt = txtNumIntFIS.Text
            .NumExt = txtNumExtFIS.Text
            .Colonia = txtColoniaFIS.Text
            .IdPoblacion = txtPoblacionFIS.Key
            .CP = txtCPFis.Text
            'FACTURACION
            .RFC = txtRFC.Text
            .RazonSocial = txtRazonSocial.Text
            .CalleFiscal = txtCalleFIS.Text
            .NumExtFiscal = txtNumExtFIS.Text
            .NumIntFiscal = txtNumIntFIS.Text
            .ColoniaFiscal = txtColoniaFIS.Text
            .CPFiscal = txtCPFis.Text
            .IdPoblacionFiscal = txtPoblacionFIS.Key
            .FacturaElectronica = chkFactElectronica.Checked
            'CREDITO
            'If rdbCredito.Checked Then
            '    .LimiteCredito = CDec(Val(txtLimiteCredito.Text))
            '    .DiasCredito = CInt(nudDiasCredito.Value)
            '    .PagoAnticipado = False
            'Else
            .LimiteCredito = 0
            .DiasCredito = 0
            .PagoAnticipado = False ' rdbAdelantado.Checked
            ' End If
            .PorcentajeAnticipo = 0
        End With

    End Sub


End Class