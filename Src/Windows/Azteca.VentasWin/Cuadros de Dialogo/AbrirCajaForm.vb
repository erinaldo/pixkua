Public Class AbrirCajaForm
    Private _IdCaja As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idCaja As Integer, ByVal Caja As String) As DialogResult
        _IdCaja = idCaja
        lblCaja.Text = Caja
        Return MyBase.ShowDialog()
    End Function

Private Sub AbrirCajaForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Try
            cboCajeros.LoadList()
    Catch ex As Exception
        MsgInfo.Show(ex)
    End Try
End Sub

Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Try
        Dim CajaFac As New CajaFacade
            CajaFac.Abrir(App.Session.SessionID, _IdCaja, CInt(cboCajeros.SelectedValue), 0)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Catch ex As Exception
        MsgInfo.Show(ex)
    End Try
End Sub

Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
End Sub
End Class