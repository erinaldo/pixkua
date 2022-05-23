Public Class SelectFormaPagoForm
    Private Venta As VentaInfo
    Private FormaPagoFac As FormaPagoFacade
    Private FormasPago As DetalleVentaDS.FormasPagoDataTable
    Private Total, Saldo As Decimal
    Private _ManejarCambio As Boolean

    Public ReadOnly Property FormasPagoSelected As DetalleVentaDS.FormasPagoDataTable
        Get
            Return FormasPago
        End Get
    End Property


    Private Sub CalcularSaldo()
        Dim Monto = Aggregate F In FormasPago Into Sum(F.Monto)
        '
        Saldo = Total - Monto
        txtSaldo.Text = Saldo.ToString
    End Sub

    Private Sub CargarFormasPago()
        FormaPagoFac = New FormaPagoFacade
        FormasPago = New DetalleVentaDS.FormasPagoDataTable
        Dim dtList As DataTable = FormaPagoFac.LoadList(App.Session.SessionID)
        For Each dr As DataRow In dtList.Rows
            Dim drFormaPago As DetalleVentaDS.FormasPagoRow = FormasPago.NewFormasPagoRow
            With drFormaPago
                .IdFormaPago = CInt(dr("IdFormaPago"))
                .FormaPago = dr("Nombre").ToString
                .Monto = 0
            End With
            FormasPago.AddFormasPagoRow(drFormaPago)
        Next
        FormasPago.AcceptChanges()
    End Sub

    Private Function IsValid() As Boolean
        grdFormasPago.UpdateData()
        CalcularSaldo()
        IsValid = False
        If rdbSingle.Checked AndAlso cboFormaPago.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar la forma de pago", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboFormaPago.Focus()
        ElseIf rdbMultiple.Checked AndAlso Saldo <> 0 Then
            MessageBox.Show("Debe liquidar el monto total de la venta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            grdFormasPago.Focus()
        Else
            Return True
        End If
    End Function

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal venta As VentaInfo, ManejarCambio As Boolean) As DialogResult
        Me.Venta = venta
        _ManejarCambio = ManejarCambio
        ControlesCambio()
        Return MyBase.ShowDialog(owner)
    End Function

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal venta As VentaInfo) As DialogResult
        Return ShowDialog(owner, venta, False)
    End Function

    Private Sub ControlesCambio()
        lblCambio.Visible = _ManejarCambio
        txtCambio.Visible = _ManejarCambio
        txtRecibo.Visible = _ManejarCambio
        lblRecibo.Visible = _ManejarCambio
    End Sub

    Private Sub SelectFormaPagoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarFormasPago()
            cboFormaPago.LoadList()
            cboFormaPago.SelectedValue = 1
            bsFormasPago.DataSource = FormasPago
            grdFormasPago.Rebind(True)
            txtTotal.Text = Venta.Total.ToString
            txtRecibo.Text = Venta.Total.ToString
            txtCambio.Text = "0"
            txtSaldo.Text = "0"
            Total = Venta.Total
            Saldo = 0
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub rdbSingle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSingle.CheckedChanged
        cboFormaPago.Enabled = True
        grdFormasPago.Enabled = False
        Saldo = 0
        txtSaldo.Text = Saldo.ToString
    End Sub

    Private Sub rdbMultiple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMultiple.CheckedChanged
        cboFormaPago.Enabled = False
        grdFormasPago.Enabled = True
        CalcularSaldo()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If IsValid() Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor                
                If rdbSingle.Checked Then
                    'Cuando es pago en una sola forma, lo agregamos en la tabla de formas de pago para cuando esta forma se herede y solo se requiera obtener el detalle de formas de pago sin aplicar el pedido
                    Dim dv As New DataView(FormasPago, "IdFormaPago=" & CInt(cboFormaPago.SelectedValue), "", DataViewRowState.CurrentRows)
                    dv(0)("Monto") = Venta.Total
                End If

                AceptarPago()
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Public Overridable Sub AceptarPago()
        Dim VentaFac As New VentaFacade
        If rdbSingle.Checked Then
            VentaFac.Aplicar(App.Session.SessionID, Venta.Identity, App.Session.BussinesDate, CInt(cboFormaPago.SelectedValue), Venta.Total)
        Else
            VentaFac.Aplicar(App.Session.SessionID, Venta.Identity, App.Session.BussinesDate, FormasPago)
        End If
    End Sub

    Private Sub grdFormasPago_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdFormasPago.AfterColUpdate
        CalcularSaldo()
    End Sub

    Private Sub txtRecibo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRecibo.TextChanged
        txtCambio.Text = CStr(CDec(txtRecibo.Text) - CDec(txtTotal.Text))
    End Sub

End Class