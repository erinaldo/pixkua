Public Class PolizaOrigenForm
    Private _IdPolizaOrigen As Integer
    Private _Descripcion As String
    Public ReadOnly Property IdPolizaOrigen As Integer
        Get
            Return _IdpolizaOrigen
        End Get
    End Property
    Public ReadOnly Property Descripcion As String
        Get
            Return _Descripcion
        End Get
    End Property

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim PolFac As New PolizaPerfilFacade
            _IdPolizaOrigen = PolFac.SaveOrigen(App.Session.SessionID, txtOrigen.Text)
            _Descripcion = txtOrigen.Text
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class