Public Class addImportesForm
    Private _IdImporte As Integer
    Private _Importe As String
    Public ReadOnly Property IdImporte As Integer
        Get
            Return _IdImporte
        End Get
    End Property
    Public ReadOnly Property Importe As String
        Get
            Return _Importe
        End Get
    End Property

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim PolFac As New PolizaPerfilFacade
            _IdImporte = PolFac.SaveImporte(App.Session.SessionID, txtImporte.Text)
            _Importe = txtImporte.Text
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class