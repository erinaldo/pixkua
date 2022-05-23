Public Class NuevaOrdenOpcionesForm

    Private Sub NuevaOrdenOpcionesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAceptar.Click
        If rdbOrdenSimple.Checked Then
            Dim frmOrden As New OrdenesForm
            If frmOrden.ShowDialog(String.Empty, "Capturar nueva orden de compra") = System.Windows.Forms.DialogResult.OK Then
                DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        ElseIf rdbOrdenMult.Checked Then

        Else
            Dim frmGenerador As New GeneradorOrdenesForm
            If frmGenerador.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class