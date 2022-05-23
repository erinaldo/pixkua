Public Class CerrarInventarioForm
    Private AreaFac As AreaFacade
    Private Inventario As AreasDS.InventarioFisicoDataTable

    Private IdCorte As Guid
    Private Corte As CorteInfo

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idCorte As Guid) As DialogResult
        Me.IdCorte = idCorte
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub CerrarInventarioForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AreaFac = New AreaFacade
            Corte = AreaFac.LoadCorte(App.Session.SessionID, IdCorte)
            Inventario = AreaFac.CargarInventarioFisico(App.Session.SessionID, Corte.IdArea)
            bsDiferencias.DataSource = Inventario
            bsDiferencias.Filter = "Diferencia <> 0"
            grdDiferencias.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnCerrarCorte_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdCerrarCorte.Click
        Try
            If bsDiferencias.Count > 0 Then
                Dim Resp As DialogResult = MessageBox.Show("¿Desea ajustar las diferencias de forma automática?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                Dim Ajustar As Boolean = (Resp = System.Windows.Forms.DialogResult.Yes)
                AreaFac.CerrarTurno(App.Session.SessionID, IdCorte, Ajustar)
            Else
                AreaFac.CerrarTurno(App.Session.SessionID, IdCorte, False)
            End If
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdDiferencias_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdDiferencias.FetchCellStyle
        Try
            If e.Column.Name = "Diferencia" Or e.Column.Name = "Diferencia (Unidades)" Then
                Dim Cantidad As Decimal = CDec(grdDiferencias.Columns("Diferencia").CellValue(e.Row))
                Dim Unidades As Decimal = CDec(grdDiferencias.Columns("Diferencia (Unidades)").CellValue(e.Row))
                Dim Result As Integer = CInt(Cantidad + Unidades)
                If Result = 0 Then
                    e.CellStyle.BackColor = System.Drawing.SystemColors.Control
                ElseIf Result < 0 Then
                    e.CellStyle.BackColor = Drawing.Color.OrangeRed
                ElseIf Result > 0 Then
                    e.CellStyle.BackColor = Drawing.Color.GreenYellow
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class