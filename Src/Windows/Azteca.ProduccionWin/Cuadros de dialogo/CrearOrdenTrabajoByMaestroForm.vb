Public Class CrearOrdenTrabajoByMaestroForm
    Public _OrdenTrabajoIdentity As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form) As DialogResult

        Return MyBase.ShowDialog(owner)
    End Function


    Private Sub CrearOrdenTrabajoByMaestroForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Try
            Dim OTSvc As New OrdenTrabajoFacade()
            Dim OTBase As New OrdenTrabajoInfo(App.Session.SessionID)
            OTBase = CType(selMaestroIng.PackageInfo, OrdenTrabajoInfo)
            _OrdenTrabajoIdentity = OTSvc.GenerarOrdenTrabajoByMaestro(App.Session.SessionID, OTBase, CDec(txtCantidad.Text), dtpFechaRecepcion.Value.Date, dtpFechaPromEntrega.Value.Date, dtpFechaRequerida.Value.Date)
            If (OTSvc.GenerarDetalleFromMaestro(App.Session.SessionID, OTBase, _OrdenTrabajoIdentity, CDec(txtCantidad.Text)) = True) Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
            Me.DialogResult = DialogResult.Cancel
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub selMaestroIng_InfoLoaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selMaestroIng.InfoLoaded
        Try
            Dim maestroInfo As New Azteca.Business.Produccion.OrdenTrabajoInfo(App.Session.SessionID)

            maestroInfo = CType(selMaestroIng.PackageInfo, OrdenTrabajoInfo)
            txtVersion.Text = maestroInfo.Version.ToString()
            txtCantidad.Text = maestroInfo.CantDeseada.ToString()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


End Class