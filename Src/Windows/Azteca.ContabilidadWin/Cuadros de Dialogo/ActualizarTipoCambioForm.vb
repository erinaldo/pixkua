
Public Class ActualizarTipoCambioForm
    Private DivisaFac As DivisaFacade
    Private IdDivisaBase As Integer
    Private IdDivisa As Integer
    Private Divisa As DivisaInfo

    Private Function IsValid() As Boolean
        IsValid = True
        If Val(txtVenta.Text) <= 0 Then
            MessageBox.Show("El tipo de cambio a la venta debe ser un valor mayor a cero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtVenta.Focus()
        Else
            Return True
        End If
    End Function

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idDivisa As Integer, ByVal idDivisaBase As Integer) As DialogResult
        Me.IdDivisa = idDivisa
        Me.IdDivisaBase = idDivisaBase
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub ActualizarTipoCambioForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DivisaFac = New DivisaFacade
        Try
            Divisa = DivisaFac.GetDetail(App.Session.SessionID, IdDivisa)
            lblDivisa.Text = Divisa.Nombre
        Catch ex As Exception
            MsgInfo.Show(ex)
            DialogResult = System.Windows.Forms.DialogResult.Cancel
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        If IsValid() Then
            Try
                DivisaFac.GuardarTipoCambio(App.Session.SessionID, IdDivisa, IdDivisaBase, CDec(Val(txtCompra.Text)), CDec(Val(txtVenta.Text)))
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub btnActulizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActulizar.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        btnActulizar.Enabled = False
        Try
            txtVenta.Text = DivisaFac.GetTipoCambioBanxico(App.Session.SessionID, Divisa.Identity)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
            btnActulizar.Enabled = True
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

End Class