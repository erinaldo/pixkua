Public Class MetodoPagoSELForm
    Private IdCliente As Integer
    Private Cliente As ClienteInfo

    Public Overloads Function ShowDialog(idCliente As Integer) As DialogResult
        Me.IdCliente = idCliente
        Return MyBase.ShowDialog()
    End Function

    Private Sub MetodoPagoSELForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            cboMetodoPago.LoadList()
            'Cargar la información del cliente
            Dim ClienteFac As New ClienteFacade
            Cliente = ClienteFac.GetDetail(App.Session.SessionID, IdCliente, False)
            cboMetodoPago.SelectedValue = Cliente.IdMetodoPago
            txtCuentaPago.Text = Cliente.CuentaPago
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click        
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Cliente.IdMetodoPago = CInt(cboMetodoPago.SelectedValue)
            Cliente.CuentaPago = txtCuentaPago.Text
            Dim ClienteFac As New ClienteFacade
            ClienteFac.Update(Cliente)
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub
End Class