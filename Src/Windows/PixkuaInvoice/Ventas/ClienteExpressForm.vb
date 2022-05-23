Imports Azteca.Windows
Imports Azteca.Business.Ventas

Public Class ClienteExpressForm

    Private Function IsValidDatosFiscales() As Boolean
        IsValidDatosFiscales = False
        If txtRFC.Text = String.Empty Then
            MessageBox.Show("Debe introducir el RFC del cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRFC.Focus()
        ElseIf txtRazonSocial.Text = String.Empty Then
            MessageBox.Show("Debe introducir la Razón Social.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRazonSocial.Focus()
        ElseIf txtPoblacionFis.Key = 0 Then
            MessageBox.Show("Debe elegir la población fiscal", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPoblacionFis.Focus()
        Else
            Return True
        End If
    End Function

    Private Sub ClientesForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Cliente As ClienteInfo = CType(PackageInfo, ClienteInfo)
        With Cliente
            'General
            txtNombre.Text = .Nombre
            'txtTel.Text = .Telefonos
            'txtFax.Text = .Fax
            txtCorreo.Text = .Correo
            'txtPagWeb.Text = .PagWeb
            ''Domicilio
            'txtCalle.Text = .Calle
            'txtNumExt.Text = .NumExt
            'txtNumInt.Text = .NumInt
            'txtColonia.Text = .Colonia
            'txtCP.Text = .CP
            'txtPoblacion.Text = CStr(.IdPoblacion)
            'If .IdPoblacion > 0 Then txtPoblacion.LoadInfo()
            'Facturacion
            'chkFacturable.Checked = .Facturable
            txtRFC.Text = .RFC
            txtRazonSocial.Text = .RazonSocial
            txtCalleFis.Text = .CalleFiscal
            txtNumExtFis.Text = .NumExtFiscal
            txtNumIntFis.Text = .NumIntFiscal
            txtColoniaFis.Text = .ColoniaFiscal
            txtCPFis.Text = .CPFiscal
            txtPoblacionFis.Text = String.Empty
            If .IdPoblacionFiscal > 0 Then txtPoblacionFis.LoadInfo(.IdPoblacionFiscal)
            cboAddenda.SelectedValue = .IdComprobanteAddenda
            txtGLN.Text = .GLN
            txtGLNTienda.Text = .GLNTienda
            txtNumProveedor.Text = .NumProveedor.ToString
            ''Ventas
            If .IdListaPrecio > 0 Then selListaPrecios.LoadInfo(.IdListaPrecio)
            'If .IdGrupoDescuentos > 0 Then selGrupoDescuentos.LoadInfo(.IdGrupoDescuentos)
            'If .CondicionesPago = CondicionesPago.Contado Then
            '    rdbContado.Checked = True
            'Else
            '    rdbCredito.Checked = True
            'End If
            'txtLimiteCredito.Text = .LimiteCredito.ToString
            'txtDiasCredito.Text = .DiasCredito.ToString
            'txtSaldoCredito.Text = .SaldoCredito.ToString
            cboMetodoPago.SelectedValue = .IdMetodoPago
            txtCuentaPago.Text = .CuentaPago
            ''Contactos
            'bsContactos.DataSource = .Contactos
            'grdContactos.Rebind(True)
            ''Contabilidad
            'If .IdCuentaContable > 0 Then txtCuenta.LoadInfo(.IdCuentaContable)

            'CargarGruposClasificaciones(.Identity)
        End With
    End Sub

    Private Sub ClienteExpressForm_SavingItem(sender As Object, e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Cliente As ClienteInfo = CType(PackageInfo, ClienteInfo)
        With Cliente
            'General
            .Nombre = txtNombre.Text
            .Telefonos = "" '''' txtTel.Text
            .Fax = "" ''''txtFax.Text
            .Correo = txtCorreo.Text
            .PagWeb = "" ''''txtPagWeb.Text
            'Domicilio
            .Calle = txtCalleFis.Text ''''txtCalle.Text
            .Cruce1 = String.Empty
            .Cruce2 = String.Empty
            .NumExt = txtNumExtFis.Text ''''txtNumExt.Text
            .NumInt = txtNumIntFis.Text ''''txtNumInt.Text
            .Colonia = txtColoniaFis.Text ''''txtColonia.Text
            .CP = txtCPFis.Text ''''txtCP.Text
            .IdPoblacion = txtPoblacionFis.Key ''''txtPoblacion.Key
            .Latitud = 0
            .Longitud = 0
            'Facturacion
            .Facturable = True ''''chkFacturable.Checked
            .RFC = txtRFC.Text
            .RazonSocial = txtRazonSocial.Text
            .CalleFiscal = txtCalleFis.Text
            .NumExtFiscal = txtNumExtFis.Text
            .NumIntFiscal = txtNumIntFis.Text
            .ColoniaFiscal = txtColoniaFis.Text
            .CPFiscal = txtCPFis.Text
            .IdPoblacionFiscal = txtPoblacionFis.Key
            .IdComprobanteAddenda = CInt(cboAddenda.SelectedValue)
            .GLN = txtGLN.Text
            .GLNTienda = txtGLNTienda.Text
            .NumProveedor = CInt(Val(txtNumProveedor.Text))
            'Ventas
            ''''If rdbContado.Checked Then
            .CondicionesPago = CondicionesPago.Contado
            ''''Else
            ''''.CondicionesPago = CondicionesPago.Credito
            ''''End If
            .IdListaPrecio = selListaPrecios.Key
            .IdGrupoDescuentos = 0 ''''selGrupoDescuentos.Key
            .IdGama = 0
            .LimiteCredito = 0 ''''CDec(Val(txtLimiteCredito.Text))
            .DiasCredito = 0 ''''CInt(Val(txtDiasCredito.Text))
            .IdMetodoPago = CInt(cboMetodoPago.SelectedValue)
            .CuentaPago = txtCuentaPago.Text
            'Contabilidad
            .IdCuentaContable = 0 ''''txtCuenta.Key
            .WebPassword = String.Empty
        End With
    End Sub

    Private Sub ClienteExpressForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboMetodoPago.LoadList()
        cboAddenda.LoadList()
    End Sub

End Class