Public Class AgregarIncidenciaWOSel
    Dim _otInfo As OrdenTrabajoInfo
    Dim _IdEmpleado As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal OTInfo As OrdenTrabajoInfo, ByVal idEmpleado As Integer) As DialogResult

        _otInfo = OTInfo
        cboIncidencias.LoadList(App.DefaultCompany.Identity)
        cboEnsambles.LoadListByOT(_otInfo.Identity)
        lblOrdenTrabajo.Text = _otInfo.UserCode
        _IdEmpleado = idEmpleado

        cboEnsambles.SelectedValue = _otInfo.EnsambleActual.Identity


        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub AgregarIncidenciaWOSel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If (IsValid()) Then

            Me.Cursor = Cursors.WaitCursor

            Dim mov As New Movimiento
            mov.IdEnsamble = CInt(cboEnsambles.SelectedValue)
            mov.IdIncidencia = CInt(cboIncidencias.SelectedValue)
            mov.IdOrdenTrabajo = _otInfo.Identity
            mov.Fecha = Date.Today
            mov.Clase = TipoMovimientoOT.InicioIncidencia
            mov.Observaciones = txtObservaciones.Text
            mov.IdEmpleado = _IdEmpleado

            Dim otFac As New OrdenTrabajoFacade
            Dim msgError As String
            msgError = otFac.AddMovimiento(App.Session.SessionID, mov)

            If (msgError <> "") Then
                MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Incidencia aplicada correctamente a la OT: " & _otInfo.UserCode, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Function IsValid() As Boolean

        If (cboIncidencias.SelectedValue = 0) Then
            MessageBox.Show("Favor de seleccionar una incidencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If (cboEnsambles.SelectedValue = 0) Then
            MessageBox.Show("Favor de seleccionar un ensamble", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmsModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsModificar.Click

    End Sub
End Class