Public Class EditServicioZonaForm
    Private IdServicio, IdZona As Integer
    Private Servicio As ZonasVentaDS.ServiciosRow
    Private Zona As ZonasVentaDS.ZonasRow

    Private Function IsValid() As Boolean
        IsValid = False
        If cboZona.SelectedIndex = -1 AndAlso Servicio Is Nothing Then
            MessageBox.Show("Debe elegir una zona de ventas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboZona.Focus()
        ElseIf txtServicio.Key = 0 AndAlso Zona Is Nothing Then
            MessageBox.Show("Debe elegir un servicio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtServicio.Focus()
        ElseIf Val(txtPrecio.Text) <= 0 Then
            MessageBox.Show("El precio debe ser mayor a cero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPrecio.Focus()
        ElseIf cboDivisa.SelectedIndex = -1 Then
            MessageBox.Show("Debe elegir una divisa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboDivisa.Focus()
        Else
            Return True
        End If
    End Function

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idZona As Integer, ByVal drServicio As ZonasVentaDS.ServiciosRow) As DialogResult
        Me.IdZona = idZona
        Servicio = drServicio
        Return MyBase.ShowDialog(owner)
    End Function

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idServicio As Integer, ByVal drZona As ZonasVentaDS.ZonasRow) As DialogResult
        Me.IdServicio = idServicio
        Zona = drZona
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub EditServicioZonaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cboZona.Focus()
            cboZona.LoadList()
            cboDivisa.LoadList()
            cboImpuesto1.LoadList()
            cboImpuesto2.LoadList()
            cboImpuesto3.LoadList()
            If Zona IsNot Nothing Then
                If IdServicio > 0 Then txtServicio.LoadInfo(IdServicio)                
                txtServicio.Enabled = False
                If Zona.IdZonaVenta > 0 Then cboZona.Enabled = False
                With Zona
                    cboZona.SelectedValue = .IdZonaVenta
                    txtPrecio.Text = .Precio.ToString
                    cboDivisa.SelectedValue = .IdDivisa
                    nudDiasEntrega.Value = .DiasEntrega
                    cboImpuesto1.SelectedValue = .IdImpuesto1
                    cboImpuesto2.SelectedValue = .IdImpuesto2
                    cboImpuesto3.SelectedValue = .IdImpuesto3
                    nudPorcRetencion1.Value = .PorcRetencion1 * 100D
                    nudPorcRetencion2.Value = .PorcRetencion2 * 100D
                    nudPorcRetencion3.Value = .PorcRetencion3 * 100D
                End With
            ElseIf Servicio IsNot Nothing Then
                cboZona.SelectedValue = IdZona
                cboZona.Enabled = False
                If Servicio.IdServicio > 0 Then txtServicio.Enabled = False
                With Servicio
                    If .IdServicio > 0 Then txtServicio.LoadInfo(.IdServicio)
                    txtPrecio.Text = .Precio.ToString
                    cboDivisa.SelectedValue = .IdDivisa
                    nudDiasEntrega.Value = .DiasEntrega
                    cboImpuesto1.SelectedValue = .IdImpuesto1
                    cboImpuesto2.SelectedValue = .IdImpuesto2
                    cboImpuesto3.SelectedValue = .IdImpuesto3
                    nudPorcRetencion1.Value = .PorcRetencion1 * 100D
                    nudPorcRetencion2.Value = .PorcRetencion2 * 100D
                    nudPorcRetencion3.Value = .PorcRetencion3 * 100D
                End With
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If IsValid() Then
            Try
                If Servicio Is Nothing Then
                    With Zona
                        .IdZonaVenta = CInt(cboZona.SelectedValue)
                        .ZonaVenta = cboZona.Text
                        .Precio = CDec(Val(txtPrecio.Text))
                        .IdDivisa = CInt(cboDivisa.SelectedValue)
                        .Divisa = cboDivisa.Text
                        .DiasEntrega = CInt(nudDiasEntrega.Value)
                        .IdImpuesto1 = CInt(cboImpuesto1.SelectedValue)
                        .IdImpuesto2 = CInt(cboImpuesto2.SelectedValue)
                        .IdImpuesto3 = CInt(cboImpuesto3.SelectedValue)
                        .Impuesto1 = cboImpuesto1.Text
                        .Impuesto2 = cboImpuesto2.Text
                        .Impuesto3 = cboImpuesto3.Text
                        .PorcRetencion1 = nudPorcRetencion1.Value / 100D
                        .PorcRetencion2 = nudPorcRetencion2.Value / 100D
                        .PorcRetencion3 = nudPorcRetencion3.Value / 100D
                    End With
                ElseIf Zona Is Nothing Then
                    With Servicio
                        .IdServicio = txtServicio.Key
                        Dim Servicio As ServicioInfo = CType(txtServicio.PackageInfo, ServicioInfo)
                        .CodigoServicio = Servicio.UserCode
                        .NombreServicio = Servicio.Nombre
                        .Precio = CDec(Val(txtPrecio.Text))
                        .IdDivisa = CInt(cboDivisa.SelectedValue)
                        .Divisa = cboDivisa.Text
                        .DiasEntrega = CInt(nudDiasEntrega.Value)
                        .IdImpuesto1 = CInt(cboImpuesto1.SelectedValue)
                        .IdImpuesto2 = CInt(cboImpuesto2.SelectedValue)
                        .IdImpuesto3 = CInt(cboImpuesto3.SelectedValue)
                        .Impuesto1 = cboImpuesto1.Text
                        .Impuesto2 = cboImpuesto2.Text
                        .Impuesto3 = cboImpuesto3.Text
                        .PorcRetencion1 = nudPorcRetencion1.Value / 100D
                        .PorcRetencion2 = nudPorcRetencion2.Value / 100D
                        .PorcRetencion3 = nudPorcRetencion3.Value / 100D
                    End With
                End If
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub


End Class
