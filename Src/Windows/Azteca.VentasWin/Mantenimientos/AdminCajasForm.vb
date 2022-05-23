Public Class AdminCajasForm

    Private Sub AdminCajasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            showCortes()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnVerCortes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerCortes.Click
        Try
            showCortes()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrir.Click
        Dim row As DataRowView = CType(bsCajas.Current, DataRowView)
        If Not IsDBNull(row("IdCorte")) Then
            MessageBox.Show("La caja tiene ya esta actualmente abierta", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If Not IsNothing(row) Then

            Dim IdCaja As Integer = CInt(row("IdCaja"))
            Try
                Dim frm As New AbrirCajaForm
                frm.StartPosition = FormStartPosition.CenterParent
                If frm.ShowDialog(Me, IdCaja, CStr(row("Caja"))) = System.Windows.Forms.DialogResult.OK Then
                    showCortes()
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        Else
            MessageBox.Show("Debe seleccionar una caja ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Sub

    Private Sub ShowCortes()
        Try
            Dim CajaFac As New CajaFacade
            Dim dtCajas As DataTable = CajaFac.LoadCortes(App.Session.SessionID, App.DefaultSite.Identity)
            bsCajas.DataSource = dtCajas
            grdCajas.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Try
            Dim row As DataRowView = CType(bsCajas.Current, DataRowView)
            Dim CajaFac As New CajaFacade
            CajaFac.Cerrar(App.Session.SessionID, CType(row("IdCorte"), Guid))
            MessageBox.Show("Se ha realizado el cierre de la caja", "Corte", MessageBoxButtons.OK, MessageBoxIcon.Information)
            showCortes()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub btnImpresionCorte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpresionCorte.Click
        Try
            Dim row As DataRowView = CType(bsCajas.Current, DataRowView)
            Dim frm As New ImpresionCorteForm
            frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, CInt(row("IdCaja")), CStr(row("Caja"))) = System.Windows.Forms.DialogResult.OK Then
                showCortes()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

End Class