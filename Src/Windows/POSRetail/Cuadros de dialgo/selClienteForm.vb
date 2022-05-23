Public Class selClienteForm

    Public ReadOnly Property Cliente As ClienteInfo
        Get
            Return CType(selCliente.PackageInfo, ClienteInfo)
        End Get
    End Property

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If selCliente.Key = 0 Then
            MessageBox.Show("Seleccione un Cliente o teclé ESC para continuar con el cliente Generico", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub


End Class