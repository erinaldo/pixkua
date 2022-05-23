Public Class seleccionCuentaForm
    Public ReadOnly Property Cuenta As String
        Get
            Return selCuenta.Text
        End Get
    End Property

    Public ReadOnly Property Concepto As String
        Get
            If chkConservar.Checked Then
                Return ""
            Else
                Return selCuenta.TextInfo
            End If
        End Get
    End Property

    Public ReadOnly Property IdCuenta As Integer
        Get
            Return selCuenta.Key
        End Get
    End Property

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If selCuenta.Key = 0 Then
            MessageBox.Show("Debe seleccionar la cuenta", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

End Class