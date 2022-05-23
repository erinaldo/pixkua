Public Class EditCantidadForm

    Public ReadOnly Property Cantidad As Decimal
        Get
            Return updwnCantidad.Value
        End Get
    End Property


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Public Overloads Function showdialog(ByVal Cantidad As Decimal) As DialogResult
        updwnCantidad.Value = Cantidad
        updwnCantidad.Select(0, updwnCantidad.ToString().Length)
        Return MyBase.ShowDialog
    End Function

    Private Sub cmdBuscarArt_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdBuscarArt.ClickButtonArea
        Dim TecladoForm As New TecladoNumerosForm
        If TecladoForm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            updwnCantidad.Value = CDec(TecladoForm.txtTexto.Text)
        End If
    End Sub
End Class