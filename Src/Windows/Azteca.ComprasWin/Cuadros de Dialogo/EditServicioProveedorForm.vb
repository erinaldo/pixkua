Public Class EditServicioProveedorForm
    Private IdZona, IdProveedor, IdServicio As Integer
    Private Info As CompraServicioInfo
    Private ProveedorFac As ProveedorFacade

    Public Function IsValid() As Boolean
        IsValid = False
        If cboZona.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una zona de compra.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboZona.Focus()
        ElseIf txtProveedor.Key = 0 Then
            MessageBox.Show("Debe seleccionar un proveedor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtProveedor.Focus()
        ElseIf txtServicio.Key = 0 Then
            MessageBox.Show("Debe seleccionar un servicio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtServicio.Focus()
        ElseIf Val(txtPrecio.Text) <= 0 Then
            MessageBox.Show("Debe introducir un precio mayor a cero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPrecio.Focus()
        ElseIf cboDivisa.SelectedIndex = -1 Then
            MessageBox.Show("Debe elegir la divisa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboDivisa.Focus()
        Else
            Return True
        End If
    End Function

    Public Overloads Function ShowDialog(owner As Form, idZona As Integer, idProveedor As Integer, idServicio As Integer) As DialogResult
        Me.IdZona = idZona
        Me.IdProveedor = idProveedor
        Me.IdServicio = idServicio
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub EditArticuloProveedorForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ProveedorFac = New ProveedorFacade
            If IdZona > 0 And IdProveedor > 0 And IdServicio > 0 Then Info = ProveedorFac.CargarServicio(App.Session.SessionID, IdZona, IdProveedor, IdServicio)
            'Cargar listas
            cboZona.LoadList(App.DefaultCompany.Identity)
            cboDivisa.LoadList()
            cboImpuesto1.LoadList()
            cboImpuesto2.LoadList()
            cboImpuesto3.LoadList()
            cboRetencion1.LoadList()
            cboRetencion2.LoadList()
            cboRetencion2.LoadList()
            '
            If IdZona > 0 Then
                cboZona.SelectedValue = IdZona
                cboZona.Enabled = False
            End If
            '
            If IdProveedor > 0 Then
                txtProveedor.LoadInfo(IdProveedor)
                txtProveedor.Enabled = False
            End If
            '
            If IdServicio > 0 Then
                txtServicio.LoadInfo(IdServicio)
                txtServicio.Enabled = False
            End If
            'Verificar si existe información en la base de datos
            If Info Is Nothing Then
                Info = New CompraServicioInfo
                'Obtener la divisa base
                Dim ConfigMgr As New Azteca.Kernel.Configuration.ConfigurationFacade
                Dim IdDivisaBase As Integer = CInt(ConfigMgr.GetSystemParameter("Configuracion/Contabilidad/Divisas", "Base"))
                cboDivisa.SelectedValue = IdDivisaBase
            Else
                With Info
                    txtPrecio.Text = .Costo.ToString
                    cboDivisa.SelectedValue = .IdDivisa
                    nudDiasCredito.Value = .DiasCredito
                    nudDiasEntrega.Value = .DiasEntrega
                    cboImpuesto1.SelectedValue = .IdImpuesto1
                    cboImpuesto2.SelectedValue = .IdImpuesto2
                    cboImpuesto3.SelectedValue = .IdImpuesto3
                    cboRetencion1.SelectedValue = .IdRetencion1
                    cboRetencion2.SelectedValue = .IdRetencion2
                    cboRetencion3.SelectedValue = .IdRetencion3
                    nudDesc1.Value = .PorcentajeDescuento1 * 100D
                    nudDesc2.Value = .PorcentajeDescuento2 * 100D
                    nudDesc3.Value = .PorcentajeDescuento3 * 100D
                End With
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
            DialogResult = System.Windows.Forms.DialogResult.Cancel
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If IsValid() Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                btnAceptar.Enabled = False
                With Info
                    .IdZonaCompra = CInt(cboZona.SelectedValue)
                    .IdProveedor = txtProveedor.Key
                    .IdServicio = txtServicio.Key
                    .Costo = CDec(Val(txtPrecio.Text))
                    .IdDivisa = CInt(cboDivisa.SelectedValue)
                    .DiasCredito = CInt(nudDiasCredito.Value)
                    .DiasEntrega = CInt(nudDiasEntrega.Value)
                    .IdImpuesto1 = CInt(cboImpuesto1.SelectedValue)
                    .IdImpuesto2 = CInt(cboImpuesto2.SelectedValue)
                    .IdImpuesto3 = CInt(cboImpuesto3.SelectedValue)
                    .IdRetencion1 = CInt(cboRetencion1.SelectedValue)
                    .IdRetencion2 = CInt(cboRetencion2.SelectedValue)
                    .IdRetencion3 = CInt(cboRetencion3.SelectedValue)
                    .PorcentajeDescuento1 = (nudDesc1.Value / 100D)
                    .PorcentajeDescuento2 = (nudDesc2.Value / 100D)
                    .PorcentajeDescuento3 = (nudDesc3.Value / 100D)
                End With
                ProveedorFac.GuardarServicio(App.Session.SessionID, Info)
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
                btnAceptar.Enabled = True
            End Try
        End If
    End Sub

End Class