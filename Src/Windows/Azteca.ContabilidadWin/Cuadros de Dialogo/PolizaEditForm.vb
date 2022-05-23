Public Class PolizaEditForm
    Dim Info As PolizaInfo

    Public Overloads Function ShowDialog(ByVal IdPolizaTit As String) As DialogResult
        Dim PolizaFac As New PolizaFacade
        Info = PolizaFac.GetDetail(App.Session.SessionID, IdPolizaTit)
        grdPoliza.AutoGenerateColumns = False
        grdPoliza.DataSource = Info.Details
        Return MyBase.ShowDialog
    End Function

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            Dim PolizaFac As New PolizaFacade
            Info = PolizaFac.Update(Info)
            MessageBox.Show("Se ha actualizado la información", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub grdPoliza_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPoliza.CellClick
        Dim row As DataGridViewRow = grdPoliza.CurrentRow

        Dim dv As New DataView(Info.Details, "IdPolizaDet=" & row.Cells(colIdPolizaDet.Index).FormattedValue, "", DataViewRowState.CurrentRows)

        If e.ColumnIndex = colDiarioCuenta.Index Then
            Dim frm As New seleccionCuentaForm
            If frm.ShowDialog = DialogResult.OK Then
                dv(0)("IdCuenta") = frm.IdCuenta
                dv(0)("Cuenta") = frm.Cuenta
                If frm.Concepto.Length > 0 Then dv(0)("Observaciones") = frm.Concepto
            End If
        End If

    End Sub


End Class