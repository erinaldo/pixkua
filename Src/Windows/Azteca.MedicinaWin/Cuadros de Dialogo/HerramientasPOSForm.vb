Public Class HerramientasPOSForm

    Private Sub cmdHerramientas_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdHerramientas.ClickButtonArea
        Try
            Dim frm As New ResumenConsultasForm
            frm.ShowDialog()
        Catch ex As Exception
            Azteca.Windows.Forms.MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdVentas_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdVentas.ClickButtonArea
        Try
            Dim frm As New Azteca.Windows.Ventas.AdminVentasForm
            frm.ShowDialog()
        Catch ex As Exception
            Azteca.Windows.Forms.MsgInfo.Show(ex)
        End Try
    End Sub
End Class