Public Class AdminCajaInventariosForm

    Private Sub btnVerCortes_Click(sender As System.Object, e As System.EventArgs) Handles btnVerCortes.Click
        Try
            Dim row As DataRowView = CType(bsCortes.Current, DataRowView)
            Dim CajaFac As New CajaFacade
            bsCortes.DataSource = CajaFac.LoadCortes(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value, App.DefaultSite.Identity)
            grdCortes.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class