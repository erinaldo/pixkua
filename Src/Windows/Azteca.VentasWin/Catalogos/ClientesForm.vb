Imports Azteca.Windows.Forms.General
Imports Azteca.Kernel.General

Public Class ClientesForm
    Private Clasificaciones, GruposClasif As DataTable

#Region "Clasificaciones"
    Private Sub CargarClasificaciones()
        Dim GrupoFac As New GrupoClasificacionesFacade
        Clasificaciones = GrupoFac.CargarClasificaciones(App.Session.SessionID, 1)
        bsClasificaciones.DataSource = Clasificaciones
        cboClasificaciones.Rebind(True)
        bsClasificaciones.Sort = "Nombre"
    End Sub

    Private Sub CargarGruposClasificaciones(ByVal idCliente As Integer)
        Dim CteFac As New ClienteFacade
        GruposClasif = CteFac.CargarClasificaciones(App.Session.SessionID, idCliente)
        bsGruposClasif.DataSource = GruposClasif
        grdClasificaciones.Rebind(True)
        If bsGruposClasif.Count > 0 Then bsGruposClasif.Position = 0
    End Sub

    Private Function ValidarClasificaciones() As Boolean
        grdClasificaciones.UpdateData()
        For Each dr As DataRow In GruposClasif.Rows
            If CBool(dr("Requerido")) And CInt(dr("IdClasificacion")) = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

#End Region

    Private Sub grdClasificaciones_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdClasificaciones.BeforeColEdit
        If e.Column.Name = "Valor" And bsClasificaciones.Current IsNot Nothing Then
            Dim IdGrupo As Integer = CInt(grdClasificaciones.Columns("IdGrupo").Value)
            bsClasificaciones.Filter = "IdClasificacionGrupo=" & IdGrupo
        End If
    End Sub

    Private Sub grdClasificaciones_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdClasificaciones.ButtonClick
        Try
            If e.Column.Name = "Valor" And bsGruposClasif.Current IsNot Nothing Then
                Dim IdGrupo As Integer = CInt(grdClasificaciones.Columns("IdGrupo").Value)
                bsClasificaciones.Filter = "IdClasificacionGrupo=" & IdGrupo
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdClasificaciones_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles grdClasificaciones.FetchRowStyle
        Try
            If CBool(grdClasificaciones.Columns("Requerido").CellValue(e.Row)) AndAlso CInt(grdClasificaciones.Columns("Valor").CellValue(e.Row)) = 0 Then
                e.CellStyle.BackColor = Drawing.Color.Orange
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


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

    Private Function IsValidCondicionesPago() As Boolean
        IsValidCondicionesPago = False
        If Val(txtDiasCredito.Text) <= 0 Then
            MessageBox.Show("El valor de los dias de crédito debe ser mayor a cero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDiasCredito.Focus()
        ElseIf Val(txtLimiteCredito.Text) <= 0 Then
            MessageBox.Show("El campo de limite de crédito debe contener un valor mayor a cero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtLimiteCredito.Focus()
        Else
            Return True
        End If
    End Function

    Protected Overrides Function IsValid() As Boolean
        IsValid = False
        If chkFacturable.Checked AndAlso Not IsValidDatosFiscales() Then
            Return False
        ElseIf rdbCredito.Checked AndAlso Not IsValidCondicionesPago() Then
            Return False
        Else
            Return MyBase.IsValid()
        End If
    End Function

    Private Sub ClientesForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim Cliente As ClienteInfo = CType(PackageInfo, ClienteInfo)
        bsContactos.DataSource = Cliente.Contactos
        grdContactos.Rebind(True)
        CargarGruposClasificaciones(0)
    End Sub

    Private Sub ClientesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClientesForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Cliente As ClienteInfo = CType(PackageInfo, ClienteInfo)
        With Cliente
            'General
            txtNombre.Text = .Nombre
            txtTel.Text = .Telefonos
            txtFax.Text = .Fax
            txtCorreo.Text = .Correo
            txtPagWeb.Text = .PagWeb
            'Domicilio
            txtCalle.Text = .Calle
            txtNumExt.Text = .NumExt
            txtNumInt.Text = .NumInt
            txtColonia.Text = .Colonia
            txtCP.Text = .CP
            txtPoblacion.Text = CStr(.IdPoblacion)
            If .IdPoblacion > 0 Then txtPoblacion.LoadInfo()
            'Facturacion
            chkFacturable.Checked = .Facturable
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
            'Ventas
            If .IdListaPrecio > 0 Then selListaPrecios.LoadInfo(.IdListaPrecio)
            If .IdGrupoDescuentos > 0 Then selGrupoDescuentos.LoadInfo(.IdGrupoDescuentos)
            If .CondicionesPago = CondicionesPago.Contado Then
                rdbContado.Checked = True
            Else
                rdbCredito.Checked = True
            End If
            txtLimiteCredito.Text = .LimiteCredito.ToString
            txtDiasCredito.Text = .DiasCredito.ToString
            txtSaldoCredito.Text = .SaldoCredito.ToString
            cboMetodoPago.SelectedValue = .IdMetodoPago
            txtCuentaPago.Text = .CuentaPago
            'Contactos
            bsContactos.DataSource = .Contactos
            grdContactos.Rebind(True)
            'Contabilidad
            If .IdCuentaContable > 0 Then txtCuenta.LoadInfo(.IdCuentaContable)

            CargarGruposClasificaciones(.Identity)
        End With
    End Sub

    Private Sub ClientesForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        cboAddenda.LoadList()
        CargarClasificaciones()
        cboMetodoPago.LoadList()
    End Sub

    Protected Overrides Sub OnSaveItem(ByVal e As Forms.InfoEntryEventArgs)
        MyBase.OnSaveItem(e)
        Dim Cliente As ClienteInfo = CType(PackageInfo, ClienteInfo)
        Dim CteFac As New ClienteFacade
        CteFac.GuardarClasificaciones(App.Session.SessionID, Cliente.Identity, GruposClasif)
    End Sub


    Private Sub ClientesForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Cliente As ClienteInfo = CType(PackageInfo, ClienteInfo)
        With Cliente
            'General
            .Nombre = txtNombre.Text
            .Telefonos = txtTel.Text
            .Fax = txtFax.Text
            .Correo = txtCorreo.Text
            .PagWeb = txtPagWeb.Text
            'Domicilio
            .Calle = txtCalle.Text
            .Cruce1 = String.Empty
            .Cruce2 = String.Empty
            .NumExt = txtNumExt.Text
            .NumInt = txtNumInt.Text
            .Colonia = txtColonia.Text
            .CP = txtCP.Text
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
            .IdComprobanteAddenda = CInt(cboAddenda.SelectedValue)
            .GLN = txtGLN.Text
            .GLNTienda = txtGLNTienda.Text
            .NumProveedor = CInt(Val(txtNumProveedor.Text))
            'Ventas
            If rdbContado.Checked Then
                .CondicionesPago = CondicionesPago.Contado
            Else
                .CondicionesPago = CondicionesPago.Credito
            End If
            .IdListaPrecio = selListaPrecios.Key
            .IdGrupoDescuentos = selGrupoDescuentos.Key
            .IdGama = 0
            .LimiteCredito = CDec(Val(txtLimiteCredito.Text))
            .DiasCredito = CInt(Val(txtDiasCredito.Text))
            .IdMetodoPago = CInt(cboMetodoPago.SelectedValue)
            .CuentaPago = txtCuentaPago.Text
            'Contabilidad
            .IdCuentaContable = txtCuenta.Key
            .WebPassword = String.Empty
        End With
    End Sub

    Private Sub chkFacturable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFacturable.CheckedChanged
        grpDatosFiscales.Enabled = chkFacturable.Checked
        grpIntegracionFact.Enabled = chkFacturable.Checked
    End Sub

    Private Sub rdbContado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbContado.CheckedChanged
        txtLimiteCredito.ReadOnly = True
        txtDiasCredito.ReadOnly = True
        txtLimiteCredito.Text = "0"
        txtDiasCredito.Text = "0"
    End Sub

    Private Sub rdbCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCredito.CheckedChanged
        txtLimiteCredito.ReadOnly = False
        txtDiasCredito.ReadOnly = False
        txtLimiteCredito.Text = ""
        txtDiasCredito.Text = ""
    End Sub


    Private Sub btnNuevoContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoContacto.Click
        Try
            Dim Cliente As ClienteInfo = CType(PackageInfo, ClienteInfo)
            Dim frmContacto As New CatalogoPersonas
            If frmContacto.ShowDialog(0, "Nuevo contacto") = System.Windows.Forms.DialogResult.OK Then
                Dim Contacto As PersonaInfo = CType(frmContacto.PackageInfo, PersonaInfo)
                With Contacto
                    Dim drContacto As ClientesDS.ContactosRow = Cliente.Contactos.NewContactosRow
                    drContacto.IdPersona = .Identity
                    drContacto.Nombre = .Nombre
                    drContacto.Apellidos = .ApellidoP & " " & .ApellidoM
                    drContacto.Telefono = .TelOficina
                    drContacto.Celular = .Celular
                    drContacto.Correo = .Correo
                    Cliente.Contactos.AddContactosRow(drContacto)
                End With
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdContactos_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdContactos.DeleteButtonClick
        If bsContactos.Current IsNot Nothing Then
            Try
                bsContactos.RemoveCurrent()
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdContactos_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdContactos.EditButtonClick
        If bsContactos.Current IsNot Nothing Then
            Try
                Dim Cliente As ClienteInfo = CType(PackageInfo, ClienteInfo)
                Dim frmContacto As New CatalogoPersonas
                Dim drContacto As ClientesDS.ContactosRow = CType(CType(bsContactos.Current, DataRowView).Row, ClientesDS.ContactosRow)
                If frmContacto.ShowDialog(drContacto.IdPersona, "Editar contacto") = System.Windows.Forms.DialogResult.OK Then
                    Dim Contacto As PersonaInfo = CType(frmContacto.PackageInfo, PersonaInfo)
                    With Contacto
                        drContacto.Nombre = .Nombre
                        drContacto.Apellidos = .ApellidoP & " " & .ApellidoM
                        drContacto.Telefono = .TelOficina
                        drContacto.Celular = .Celular
                        drContacto.Correo = .Correo
                    End With
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub


End Class