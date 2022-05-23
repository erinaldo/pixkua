Imports Azteca.Kernel.General
Imports Azteca.Windows.Forms.General
Imports System.Windows.Forms

Public Class ProveedoresForm

#Region "Implementacion"

    Private Sub ProveedoresForm_LoadingLists(sender As Object, e As System.EventArgs) Handles Me.LoadingLists
        cboBanco.LoadList()
    End Sub

    Private Sub ProveedoresForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarZonas()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ProveedoresForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim Proveedor As ProveedorInfo = CType(PackageInfo, ProveedorInfo)
        bsContactos.DataSource = Proveedor.Contactos
        grdContactos.Rebind(True)
        grdZonas.Rebind(True)
    End Sub

    Private Sub ProveedoresForm_LoadingItem(ByVal sender As Object, ByVal e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Proveedor As ProveedorInfo = CType(PackageInfo, ProveedorInfo)
        With Proveedor
            'GENERAL
            txtNombre.Text = .Nombre
            txtRFC.Text = .RFC
            txtTelefono.Text = .Telefono
            txtFax.Text = .Fax
            txtCorreo.Text = .Correo
            txtURL.Text = .PaginaWeb
            txtCuenta.Text = String.Empty
            txtPassword.Text = .WebPassword
            nudDiasEntrega.Value = .DiasEntrega
            'DOMICILIO
            txtCalle.Text = .Calle
            txtNumInt.Text = .NumInt
            txtNumExt.Text = .NumExt
            txtColonia.Text = .Colonia
            txtPoblacion.LoadInfo(.IdPoblacion)
            txtCP.Text = .CP.Trim
            'FACTURACION
            txtRFC.Text = .RFC
            txtRazonSocial.Text = .RazonSocial
            txtCalleFIS.Text = .CalleFiscal
            txtNumExtFIS.Text = .NumExtFiscal
            txtNumIntFIS.Text = .NumIntFiscal
            txtColoniaFIS.Text = .ColoniaFiscal
            txtCPFis.Text = .CPFiscal.Trim
            txtPoblacionFIS.LoadInfo(.IdPoblacionFiscal)
            chkFactElectronica.Checked = .FacturaElectronica
            'PAGOS
            If .PagoAnticipado Then
                rdbAdelantado.Checked = True
            Else
                If .DiasCredito > 0 Then
                    rdbCredito.Checked = True
                Else
                    rdbContado.Checked = True
                End If
            End If
            txtLimiteCredito.Text = .LimiteCredito.ToString
            txtSaldo.Text = .Saldo.ToString("$#;##0.00")
            nudDiasCredito.Value = .DiasCredito
            cboBanco.SelectedValue = .IdBanco
            txtCLABE.Text = .CLABE
            chkLeyenda.Checked = .LeyendaCheque
            '
            bsContactos.DataSource = .Contactos
            grdContactos.Rebind(True)
            grdZonas.Rebind(True)
            If .IdCuentaContable > 0 Then txtCuenta.LoadInfo(.IdCuentaContable)
        End With
    End Sub

    Private Sub ProveedoresForm_SavingItem(ByVal sender As Object, ByVal e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Proveedor As ProveedorInfo = CType(PackageInfo, ProveedorInfo)
        With Proveedor
            'GENERAL
            .Nombre = txtNombre.Text
            .RFC = txtRFC.Text
            .Telefono = txtTelefono.Text
            .Fax = txtFax.Text
            .Correo = txtCorreo.Text
            .PaginaWeb = txtURL.Text
            .IdCuentaContable = txtCuenta.Key
            .WebPassword = txtPassword.Text
            .DiasEntrega = CInt(nudDiasEntrega.Value)
            'DOMICILIO
            .Calle = txtCalle.Text
            .NumInt = txtNumInt.Text
            .NumExt = txtNumExt.Text
            .Colonia = txtColonia.Text
            .IdPoblacion = txtPoblacion.Key
            .CP = txtCP.Text
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
            'PAGOS
            If rdbCredito.Checked Then
                .LimiteCredito = CDec(Val(txtLimiteCredito.Text))
                .DiasCredito = CInt(nudDiasCredito.Value)
                .PagoAnticipado = False
            Else
                .LimiteCredito = 0
                .DiasCredito = 0
                .PagoAnticipado = rdbAdelantado.Checked
            End If
            .PorcentajeAnticipo = 0
            .IdBanco = CInt(cboBanco.SelectedValue)
            .CLABE = txtCLABE.Text
            .LeyendaCheque = chkLeyenda.Checked
        End With
    End Sub

    Private Sub rdbContado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbContado.CheckedChanged
        pnlCredito.Enabled = False
        txtLimiteCredito.Text = "0"
        nudDiasCredito.Value = 0
    End Sub

    Private Sub rdbAdelantado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbAdelantado.CheckedChanged
        pnlCredito.Enabled = False
        txtLimiteCredito.Text = "0"
        nudDiasCredito.Value = 0
    End Sub

    Private Sub rdbCredito_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbCredito.CheckedChanged
        pnlCredito.Enabled = True
    End Sub

#End Region

#Region "Implementacion Contactos"

    Private Sub btnNuevoContacto_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdNuevoContacto.Click
        Dim ProveedorInf As ProveedorInfo = CType(PackageInfo, ProveedorInfo)
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim frmContacto As New CatalogoPersonas
            If frmContacto.ShowDialog(0, "Nuevo contacto") = System.Windows.Forms.DialogResult.OK Then
                Dim Contacto As PersonaInfo = CType(frmContacto.PackageInfo, PersonaInfo)
                With Contacto
                    Dim drContacto As ProveedoresDS.ContactosRow = ProveedorInf.Contactos.NewContactosRow
                    drContacto.IdPersona = .Identity
                    drContacto.Nombre = .Nombre
                    drContacto.Apellidos = .ApellidoP & " " & .ApellidoM
                    drContacto.Telefono = .TelOficina
                    drContacto.Celular = .Celular
                    drContacto.Correo = .Correo
                    ProveedorInf.Contactos.AddContactosRow(drContacto)
                    grdContactos.Rebind(True)
                End With
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub EditarContacto()
        Dim ProveedorInf As ProveedorInfo = CType(PackageInfo, ProveedorInfo)
        Dim frmContacto As New CatalogoPersonas
        Dim drContacto As ProveedoresDS.ContactosRow = CType(CType(bsContactos.Current, DataRowView).Row, ProveedoresDS.ContactosRow)
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
    End Sub

    Private Sub grdContactos_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdContactos.DeleteButtonClick
        If bsContactos.Current IsNot Nothing Then
            bsContactos.RemoveCurrent()
        End If
    End Sub

    Private Sub grdContactos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdContactos.DoubleClick
        If bsContactos.Current IsNot Nothing Then
            Try
                EditarContacto()
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdContactos_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdContactos.EditButtonClick
        If bsContactos.Current IsNot Nothing Then
            Try
                EditarContacto()
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub


#End Region

#Region "Zonas"

    Private Sub CargarZonas()
        Dim ZonaFac As New ZonaCompraFacade
        Dim Zonas As DataTable = ZonaFac.LoadList(App.Session.SessionID, App.DefaultCompany.Identity, App.Session.User.Identity)
        bsZonas.DataSource = Zonas
        grdZonas.Rebind(True)
    End Sub

    Private Sub cmdArticulos_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdArticulos.Click
        Dim Proveedor As ProveedorInfo = CType(PackageInfo, ProveedorInfo)
        If bsZonas.Current IsNot Nothing Then
            If Proveedor.Identity > 0 Then
                Try
                    Dim IdZona As Integer = CInt(grdZonas.Columns("IdZonaCompra").Value)
                    Dim frmArticulos As New ArticulosProveedorForm
                    If frmArticulos.ShowDialog(Me, IdZona, Proveedor.Identity, False) = System.Windows.Forms.DialogResult.OK Then

                    End If
                Catch ex As Exception
                    MsgInfo.Show(ex)
                End Try
            Else
                MessageBox.Show("Primero debe guardar los datos del nuevo proveedor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe seleccionar una zona de compras.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdServicios_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdServicios.Click
        Dim Proveedor As ProveedorInfo = CType(PackageInfo, ProveedorInfo)
        If bsZonas.Current IsNot Nothing Then
            If Proveedor.Identity > 0 Then
                Try
                    Dim IdZona As Integer = CInt(grdZonas.Columns("IdZonaCompra").Value)
                    Dim frmServicios As New ServiciosProveedorForm
                    If frmServicios.ShowDialog(Me, IdZona, Proveedor.Identity, False) = System.Windows.Forms.DialogResult.OK Then

                    End If
                Catch ex As Exception
                    MsgInfo.Show(ex)
                End Try
            Else
                MessageBox.Show("Primero debe guardar los datos del nuevo proveedor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe seleccionar una zona de compras.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

    
End Class