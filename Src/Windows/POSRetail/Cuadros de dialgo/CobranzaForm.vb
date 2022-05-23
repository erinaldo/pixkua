Public Class CobranzaForm
    Private _FormasPagoTable As Business.Ventas.DetalleVentaDS.FormasPagoDataTable

    Public Property FormasPagoTable As Business.Ventas.DetalleVentaDS.FormasPagoDataTable
        Get
            Return _FormasPagoTable
        End Get
        Set(ByVal value As Business.Ventas.DetalleVentaDS.FormasPagoDataTable)
            _FormasPagoTable = value
        End Set
    End Property

    Private Sub CobranzaForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 112 Then 'F1'
            addFormaPago(FormasPagoEnum.Efectivo, "Efectivo")
        ElseIf e.KeyCode = 113 Then 'F2'
            addFormaPago(FormasPagoEnum.Tarjeta, "Tarjeta de Credito")
        ElseIf e.KeyCode = 114 Then 'F3'
            addFormaPago(FormasPagoEnum.Cheque, "Cheque")
        ElseIf e.KeyCode = 115 Then 'F4'
            addFormaPago(FormasPagoEnum.ValesDespensa, "Vales de despensa")
        ElseIf e.KeyCode = 116 Then 'F5'
            lblFormasPago.Visible = True : cboFormasPago.Visible = True
        ElseIf e.KeyCode = 123 Then 'F12' Aceptar
            Aceptar()
        End If
    End Sub

    Private Sub CobranzaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboFormasPago.LoadList()
        txtCantidad.Focus()
        _FormasPagoTable = New Business.Ventas.DetalleVentaDS.FormasPagoDataTable
        grdFormaPago.AutoGenerateColumns = False
        grdFormaPago.DataSource = _FormasPagoTable
    End Sub

    Public Overloads Function showdialog(ByVal IdVentaTipo As Integer, ByVal Total As Decimal) As DialogResult
        lblTotalTXT.Text = "$" & Total.ToString("0.00")
        txtCantidad.Text = Total.ToString("0.00")
        Return MyBase.ShowDialog()
    End Function

    Private Sub addFormaPago(ByVal FormaPago As FormasPagoEnum, ByVal Descripcion As String)
        Dim IdFormaPago As Integer = 0
        Dim ConfFac As New Kernel.Configuration.ConfigurationFacade

        If CDec(Val(txtCantidad.Text)) <= 0 Then
            MessageBox.Show("Debe capturar un monto mayor a cero", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtCantidad.Focus()
            Exit Sub
        End If

        If FormaPago = FormasPagoEnum.Efectivo Then
            IdFormaPago = CInt(ConfFac.GetSystemParameter("Configuracion/Ventas/FormasPago", "Efectivo"))
        ElseIf FormaPago = FormasPagoEnum.Tarjeta Then
            IdFormaPago = CInt(ConfFac.GetSystemParameter("Configuracion/Ventas/FormasPago", "TarjetaCredito"))
        ElseIf FormaPago = FormasPagoEnum.Cheque Then
            IdFormaPago = CInt(ConfFac.GetSystemParameter("Configuracion/Ventas/FormasPago", "Cheque"))
        ElseIf FormaPago = FormasPagoEnum.ValesDespensa Then
            IdFormaPago = CInt(ConfFac.GetSystemParameter("Configuracion/Ventas/FormasPago", "ValesDespensa"))
        End If

        Dim Suma As Object = _FormasPagoTable.Compute("SUM(MONTO)", "")
        If IsDBNull(Suma) Then Suma = 0

        If FormaPago <> FormasPagoEnum.Efectivo Then ''And _FormasPagoTable.Rows.Count > 0 Then
            If CDec(Suma) + CDec(Val(txtCantidad.Text)) > CDec((lblTotalTXT.Text)) Then
                MessageBox.Show("Esta forma de pago no permite exceder el monto de la venta ya que no se permite devolucion de cambio", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        Else
            Dim Efectivo As Object = _FormasPagoTable.Compute("SUM(MONTO)", "IdFormaPago=" & IdFormaPago)
            If IsDBNull(Efectivo) Then Efectivo = 0
            If Suma + CDec(Val(txtCantidad.Text)) > CDec((lblTotalTXT.Text)) Then
                lblCambioTXT.Text = Format((Suma + CDec(Val(txtCantidad.Text))) - CDec((lblTotalTXT.Text)), "0.00")
                txtCantidad.Text = Format(CDec(txtCantidad.Text) - CDec(lblCambioTXT.Text), "0.00")
            End If
        End If

        Dim dv As New DataView(_FormasPagoTable, "IdFormaPago=" & IdFormaPago, "", DataViewRowState.CurrentRows)
        If dv.Count = 0 Then
            Dim drPago As Business.Ventas.DetalleVentaDS.FormasPagoRow = _FormasPagoTable.NewFormasPagoRow
            With drPago
                .IdFormaPago = IdFormaPago : .FormaPago = Descripcion : .Monto = CDec(Val(txtCantidad.Text))
                If FormaPago = FormasPagoEnum.Efectivo Then .Cambio = CDec(Val(lblCambioTXT.Text))
                .Referencia = CStr(txtReferencia.Text)
                _FormasPagoTable.AddFormasPagoRow(drPago)
            End With
        Else
            dv(0)("Monto") = dv(0)("Monto") + CDec(txtCantidad.Text)
        End If

        Suma = _FormasPagoTable.Compute("SUM(MONTO)", "")
        If IsDBNull(Suma) Then Suma = 0

        txtCantidad.Text = Format(CDec(lblTotalTXT.Text) - Suma, "0.00")

        ActualizaEncabezado()
    End Sub

    Private Sub grdFormaPago_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grdFormaPago.RowsRemoved
        ActualizaEncabezado()
    End Sub

    Private Sub ActualizaEncabezado()
        Dim Suma As Object = _FormasPagoTable.Compute("SUM(MONTO)", "")
        If IsDBNull(Suma) Then Suma = 0
        lblPagoTXT.Text = Format(CDec(Suma) + CDec(lblCambioTXT.Text), "0.00")
        ''If CDec(Suma) > CDec(lblTotalTXT.Text) Then lblCambioTXT.Text = Format(CDec(Suma) - CDec(lblTotalTXT.Text), "0.00")
    End Sub

    Private Sub Aceptar()
        If _FormasPagoTable.Rows.Count = 0 Then addFormaPago(FormasPagoEnum.Efectivo, "Efectivo")
        Dim Suma As Object = _FormasPagoTable.Compute("SUM(MONTO)", "")
        If IsDBNull(Suma) Then Suma = 0

        If CDec(lblTotalTXT.Text) > Suma Then
            MessageBox.Show("No ha completado el monto total de la venta.", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cmdEfectivo_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdEfectivo.ClickButtonArea
        addFormaPago(FormasPagoEnum.Efectivo, "Efectivo")
    End Sub

    Private Sub ButtonPlus1_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdTarjeta.ClickButtonArea
        addFormaPago(FormasPagoEnum.Tarjeta, "Tarjeta")
    End Sub

    Private Sub cmdCheque_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdCheque.ClickButtonArea
        addFormaPago(FormasPagoEnum.Cheque, "Cheque")
    End Sub

    Private Sub cmdValeDesp_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdValeDesp.ClickButtonArea
        addFormaPago(FormasPagoEnum.ValesDespensa, "Vales de Despensa")
    End Sub

    Private Sub cmdOtro_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdOtro.ClickButtonArea

    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Aceptar()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdBuscarArt_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdBuscarArt.ClickButtonArea
        Dim TecladoForm As New TecladoNumerosForm
        If TecladoForm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            txtCantidad.Text = CDec(TecladoForm.txtTexto.Text).ToString("#.##")
        End If
    End Sub
End Class

Public Enum FormasPagoEnum
    Efectivo
    Cheque
    Tarjeta
    ValesDespensa
End Enum